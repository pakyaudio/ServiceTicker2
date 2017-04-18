Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite

Public Class ClaimsReportFrm

    Private Sub ClaimsReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ClaimsStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
    Friend strsqlSelect As String
    Friend Sub getdataClaims(ByVal strsqlSelect As String, ByVal kywd As String)
        Try
            Me.dgCS.Rows.Clear()
            If strsqlSelect = 100 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM " _
                    & "claims_copy WHERE datetime_return between '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "' and '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "'"
            ElseIf strsqlSelect = 300 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims_copy WHERE "
                Dim strKeyWord As String = kywd
                If strKeyWord <> "" Then
                    strSQL = strSQL & "name_pro like '%" & strKeyWord & "%'  or serial_pro like '%" & strKeyWord & "%';"
                End If
            ElseIf strsqlSelect = 400 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims_copy"
            ElseIf strsqlSelect = 500 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims " _
                    & "WHERE `status`='" & kywd & "'"
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCS
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("symptom")
                        .Rows(r).Cells(7).Value = Dr.Item("status")
                        .Rows(r).Cells(8).Value = Dr.Item("tel_to_cus")
                        .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(10).Value = Dr.Item("note2")
                        .Rows(r).Cells(11).Value = Dr.Item("note")
                    End With
                End While
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ดึงชื่อลูกค้า
            For sum As Integer = 0 To Me.dgCS.Rows.Count - 1
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgCS.Rows(sum).Cells(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgCS
                    If Dr.HasRows Then
                        .Rows(sum).Cells(3).Value = Dr.Item("customer_name")
                    Else
                        .Rows(sum).Cells(3).Value = "-"
                    End If
                End With
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

    End Sub

    Private Sub btnCSshowAll_Click(sender As Object, e As EventArgs) Handles btnCSshowAll.Click
        Call getdataClaims(400, Nothing)
    End Sub

    Private Sub txtCSsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCSsearch.Text <> Nothing Then
                Call getdataClaims(300, Me.txtCSsearch.Text)
            End If
        End If
    End Sub

    Private Sub btnCSsearch_Click(sender As Object, e As EventArgs) Handles btnCSsearch.Click
        If Me.txtCSsearch.Text <> Nothing Then
            Call getdataClaims(300, Me.txtCSsearch.Text)
        End If
    End Sub

    Private Sub btnCRsearchbydate_Click(sender As Object, e As EventArgs) Handles btnCRsearchbydate.Click
        Call getdataClaims(100, Nothing)
    End Sub
    Private Sub reportPrint()
        If Me.dgCS.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Try
                strSQLite = "DELETE FROM claimsreport"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgCS.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO claimsreport(`no`,claims_id,cus_id,cus_name,`sn`,name_pro,syptom,`status`,t_to_cus,date_in,go_to,`note`)" _
                     & "VALUES(@no,@claims_id,@cus_id,@cus_name,@sn,@name_pro,@syptom,@status,@t_to_cus,@date_in,@go_to,@note)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgCS.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@claims_id", Me.dgCS.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_id", Me.dgCS.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_name", Me.dgCS.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@sn", Me.dgCS.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgCS.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@syptom", Me.dgCS.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", Me.dgCS.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@t_to_cus", Me.dgCS.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@date_in", Me.dgCS.Rows(r).Cells(9).Value)
                    cmdSQLite.Parameters.AddWithValue("@go_to", Me.dgCS.Rows(r).Cells(10).Value)
                    cmdSQLite.Parameters.AddWithValue("@note", Me.dgCS.Rows(r).Cells(11).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            If checkPrinter() = "A4" Then
                ClaimsReportWorksA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ClaimsReportWorksA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call reportPrint()
    End Sub

    Private Sub cbbCRstatus_DropDown(sender As Object, e As EventArgs) Handles cbbCRstatus.DropDown
        Try
            Me.cbbCRstatus.Items.Clear()
            strSQL = "SELECT DISTINCT `status` AS st FROM claims"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Me.cbbCRstatus.Items.Add(Dr.GetString("st"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbCRstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbCRstatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbCRstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCRstatus.SelectedIndexChanged
        Call getdataClaims(500, Me.cbbCRstatus.Text)
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/claimsreportfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class