Imports System.Data.SQLite
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ComfixCustomerStatusFrm

    Private Sub ComfixCustomerStatusFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ComfixCustomerStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.DateTimePicker1.Value = DateTime.Now.AddMonths(-1)
        Me.DateTimePicker2.Value = DateTime.Now.AddMonths(0)
        Call cb1c()
    End Sub

    Friend bsearch As Integer

    Friend Sub getCustomerStatus(cusID As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            If bsearch = 100 Then
                strSQL = "SELECT customer_id,customer_name FROM customer WHERE customer_id='" & cusID & "'"
            ElseIf bsearch = 200 Then
                Me.Cursor = Cursors.Default
                Exit Try
            ElseIf bsearch = 300 Then
                Me.dgCCcusStatus.Rows.Clear()
                strSQL = "SELECT DISTINCT customer_id,customer_name FROM comfix WHERE date_send BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                                      & "AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                                      & "AND NOT(fix_id='" & "ขายสินค้า" & "')"
            Else
                Me.dgCCcusStatus.Rows.Clear()
                strSQL = "SELECT DISTINCT customer_id,customer_name FROM comfix WHERE NOT fix_id='" & "ขายสินค้า" & "'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read
                    With Me.dgCCcusStatus
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_name")
                    End With
                End While
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Me.Cursor = Cursors.WaitCursor
            'หาจำนวนครั้งที่ใช้งาน
            For cp As Integer = 0 To Me.dgCCcusStatus.Rows.Count
                If CheckBox1.CheckState = CheckState.Unchecked Then
                    strSQL = "SELECT COUNT(customer_id) AS Coun FROM comfix " _
                        & "WHERE customer_id='" & Me.dgCCcusStatus.Rows(cp).Cells(1).Value & "'"
                ElseIf CheckBox1.CheckState = CheckState.Checked Then
                    strSQL = "SELECT COUNT(customer_id) AS Coun FROM comfix " _
                        & "WHERE customer_id='" & Me.dgCCcusStatus.Rows(cp).Cells(1).Value & "' " _
                        & "AND date_send BETWEEN'" & DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                                          & "AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "'"
                End If
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    With Me.dgCCcusStatus
                        .Rows(cp).Cells(3).Value = Dr.Item("Coun")
                    End With
                End While
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Me.Cursor = Cursors.WaitCursor
            'หาค่าใช่บริการ รวม
            For cp As Integer = 0 To Me.dgCCcusStatus.Rows.Count
                If CheckBox1.CheckState = CheckState.Checked Then
                    strSQL = "SELECT SUM(total_all) AS tl FROM cash_sale " _
                                      & "WHERE customer_id='" & Me.dgCCcusStatus.Rows(cp).Cells(1).Value & "' AND NOT(fix_id='" & "ขายสินค้า" & "') " _
                                      & "AND datetime_save BETWEEN'" & DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                                      & "AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "'"
                ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                    strSQL = "SELECT SUM(total_all) AS tl FROM cash_sale " _
                                    & "WHERE customer_id='" & Me.dgCCcusStatus.Rows(cp).Cells(1).Value & "' AND NOT(fix_id='" & "ขายสินค้า" & "')"
                End If

                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    With Me.dgCCcusStatus
                        .Rows(cp).Cells(4).Value = Dr.Item("tl")
                    End With
                End While
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        bsearch = Nothing
        cusID = Nothing
    End Sub

    Friend Sub getCustomerStatusProHot()
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.dgCCproHot.Rows.Clear()
            If CheckBox1.CheckState = CheckState.Checked Then
                strSQL = "SELECT COUNT(total_pro) AS CC,code_pro,name_pro FROM cash_sale_barcode " _
                    & "WHERE datetime_save BETWEEN'" & DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                    & "AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND NOT(fix_id='" & "ขายสินค้า" & "')" _
                    & "GROUP BY code_pro ORDER BY COUNT(total_pro) DESC"
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                strSQL = "SELECT COUNT(total_pro) AS CC,code_pro,name_pro FROM cash_sale_barcode WHERE fix_id NOT IN ('" & "ขายสินค้า" & "') GROUP BY code_pro ORDER BY COUNT(total_pro) DESC"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read
                    With Me.dgCCproHot
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("CC")
                    End With
                End While
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'Number
            For NumBer As Integer = 0 To Me.dgCCproHot.Rows.Count - 1
                Me.dgCCproHot.Rows(NumBer).Cells(0).Value = NumBer + 1
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCCgetdata_Click(sender As Object, e As EventArgs) Handles btnCCgetdata.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            If Me.CheckBox1.CheckState = CheckState.Unchecked Then
                If MessageBox.Show(Me, "อาจจะใช้เวลานาน หากข้อมูลมีปริมาณเยอะ ต้องการจะทำต่อหรือไม่", "ยืนยัน",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Call getCustomerStatus(Nothing)
                End If
            ElseIf Me.CheckBox1.CheckState = CheckState.Checked Then
                bsearch = 300
                Call getCustomerStatus(Nothing)
            End If
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            Call getCustomerStatusProHot()
        End If
    End Sub

    Private Sub btnCCsearch_Click(sender As Object, e As EventArgs) Handles btnCCsearch.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            SearchCustomerCCFrm.ShowDialog(Me)
        End If
    End Sub
    Private Sub cb1c()
        If CheckBox1.CheckState = CheckState.Checked Then
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        End If
    End Sub
    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        Call cb1c()
    End Sub
    Private Sub tabclick()
        If TabControl1.SelectedTab Is TabPage1 Then
            Me.btnCCsearch.Enabled = True
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            Me.btnCCsearch.Enabled = False
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Call tabclick()
    End Sub
    Private Sub tab1Print()
        If Me.dgCCcusStatus.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Try
                strSQLite = "DELETE FROM `comfixcustomerstatus`;"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            MainFrm.lblMainStatus.Text = "สร้างข้อมูลรายงาน"
            For r As Integer = 0 To Me.dgCCcusStatus.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO comfixcustomerstatus(`no`,cus_id,cus_name,num_service,total_service)" _
                     & "VALUES(@no,@cus_id,@cus_name,@num_service,@total_service)"

                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgCCcusStatus.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_id", Me.dgCCcusStatus.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_name", Me.dgCCcusStatus.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@num_service", Me.dgCCcusStatus.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_service", Me.dgCCcusStatus.Rows(r).Cells(4).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default

            If checkPrinter() = "A4" Then
                ComfixCustomerStatusA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ComfixCustomerStatusA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub
    Private Sub tab2Print()
        If Me.dgCCproHot.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor

            Try
                strSQLite = "DELETE FROM comfixcustomerstatus_t2"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            MainFrm.lblMainStatus.Text = "สร้างข้อมูลรายงาน"
            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgCCproHot.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO comfixcustomerstatus_t2(`no`,code_pro,name_pro,total_buy)" _
                     & "VALUES(@no,@code_pro,@name_pro,@total_buy)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgCCproHot.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgCCproHot.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgCCproHot.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_buy", Me.dgCCproHot.Rows(r).Cells(3).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            If checkPrinter() = "A4" Then
                ComfixStatusHotA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ComfixStatusHotA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            Call tab1Print()
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            Call tab2Print()
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        Me.btnCCsearch.Enabled = False
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Me.btnCCsearch.Enabled = True
    End Sub
    Dim OldData As Object
    Private Sub dgCCcusStatus_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCcusStatus.CellDoubleClick
        OldData = Me.dgCCcusStatus.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgCCcusStatus_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCcusStatus.CellEndEdit
        Me.dgCCcusStatus.CurrentRow.Cells(e.ColumnIndex).Value = OldData
    End Sub

    Private Sub dgCCproHot_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCproHot.CellDoubleClick
        OldData = Me.dgCCproHot.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgCCproHot_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCproHot.CellEndEdit
        Me.dgCCproHot.CurrentRow.Cells(e.ColumnIndex).Value = OldData
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixreportmenu/comfixcustomerstatusfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class