Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class ReturnProdductReportFrm

    Private Sub ReturnProdductReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReturnProdductReportFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1All.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2All.Value = DateTime.Now.AddDays(1)
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub

    Dim oldData As Object
    Private Sub dgReportRepair_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportRepair.CellDoubleClick
        Me.dgReportRepair.ReadOnly = False
        oldData = Me.dgReportRepair.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgReportRepair_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportRepair.CellEndEdit
        Me.dgReportRepair.CurrentRow.Cells(e.ColumnIndex).Value = oldData
        Me.dgReportRepair.ReadOnly = True
    End Sub

    Dim oldData1 As Object
    Private Sub dgReportRepairAll_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportRepairAll.CellDoubleClick
        Me.dgReportRepairAll.ReadOnly = False
        oldData1 = Me.dgReportRepairAll.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgReportRepairAll_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportRepairAll.CellEndEdit
        Me.dgReportRepairAll.CurrentRow.Cells(e.ColumnIndex).Value = oldData1
        Me.dgReportRepairAll.ReadOnly = False
    End Sub

    'รายงานการคืนสินค้าแบบรวม****************************************************************

    Private Sub searchDatadgReportreturnproduct(ByVal selSTR As Integer)
        Try
            Me.dgReportRepairAll.Rows.Clear()
            If selSTR = 100 Then
                strSQL = "SELECT * FROM " _
                    & "returnproduct WHERE return_status='เครดิต' OR return_status='ยังไม่ชำระเงิน' AND datetime_save BETWEEN " _
                    & "'" & Convert.ToDateTime(DateTimePicker1All.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2All.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
            ElseIf selSTR = 200 Then
                strSQL = "SELECT * FROM " _
                    & "returnproduct WHERE return_status='เงินสด' OR return_status='ชำระเงิน' AND " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1All.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2All.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
            ElseIf selSTR = 300 Then
                strSQL = "SELECT * FROM " _
                    & "returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1All.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2All.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgReportRepairAll
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(4).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total_all")
                    .Rows(r).Cells(6).Value = Dr.Item("discount")
                    .Rows(r).Cells(7).Value = Dr.Item("decline")
                    .Rows(r).Cells(8).Value = Dr.Item("return_status")
                    .Rows(r).Cells(9).Value = Dr.Item("return_note")
                    .Rows(r).Cells(10).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(11).Value = Dr.Item("employee")
                End With
            End While
            'นับจำนวนแถว
            Me.txtmoneyALL.Text = ""
            Dim no As Integer = Me.dgReportRepairAll.RowCount
            Me.txtRRrowsALL.Text = "จำนวน " & no & " รายการ"
            'นับจำนวนเงิน
            If no = 0 Then
                Me.txtmoneyALL.Text = "รวมราคา 0 บาท "
            Else
                Dim ss As Decimal = 0
                Dim sdiscount As Decimal = 0
                Dim sdeline As Decimal = 0
                For sum As Integer = 0 To Me.dgReportRepairAll.Rows.Count - 1
                    ss += Me.dgReportRepairAll.Rows(sum).Cells(5).Value
                    sdiscount += Me.dgReportRepairAll.Rows(sum).Cells(6).Value
                    sdeline += Me.dgReportRepairAll.Rows(sum).Cells(7).Value
                    Me.txtmoneyALL.Text = "รวมราคา " & ss.ToString("N2") & " บาท " _
                        & ", รวมส่วนลด " & sdiscount.ToString("N2") & " บาท " & ", รวมค่าเสื่อมราคา " _
                        & sdeline.ToString("N2") & " บาท "
                Next
            End If
            Dr.Close()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnRRdisplayDataAll_Click(sender As Object, e As EventArgs) Handles btnRRdisplayDataAll.Click
        If Me.cbbRRcashstatusAll.Text = "" Then
            MsgBox("เลือกสถานะ", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.lblRRcashStatus.BackColor = Color.Orange
        Else
            If Me.cbbRRcashstatusAll.Text = "ยังไม่ชำระเงิน" Then
                Call searchDatadgReportreturnproduct(100)
            ElseIf Me.cbbRRcashstatusAll.Text = "ชำระเงิน" Then
                Call searchDatadgReportreturnproduct(200)
            ElseIf Me.cbbRRcashstatusAll.Text = "ทั้งหมด" Then
                Call searchDatadgReportreturnproduct(300)
            End If
        End If
    End Sub

    Private Sub cbbRRcashstatusAll_Click(sender As Object, e As EventArgs) Handles cbbRRcashstatusAll.Click
        Me.cbbRRcashstatusAll.Items.Clear()
        Me.cbbRRcashstatusAll.Items.Add("ยังไม่ชำระเงิน")
        Me.cbbRRcashstatusAll.Items.Add("ชำระเงิน")
        Me.cbbRRcashstatusAll.Items.Add("ทั้งหมด")
    End Sub

    Private Sub reportPrintALL()
        If Me.dgReportRepairAll.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Try
                strSQLite = "DELETE FROM returnproductall"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            For r As Integer = 0 To Me.dgReportRepairAll.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO returnproductall(`no`,sale_id,fix_id,cus_id,cus_name,price_buy,return_status,return_note,datetime,employee,discount,decline)" _
                     & "VALUES(@no,@sale_id,@fix_id,@cus_id,@cus_name,@price_buy,@return_status,@return_note,@datetime,@employee,@discount,@decline)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgReportRepairAll.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@sale_id", Me.dgReportRepairAll.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@fix_id", Me.dgReportRepairAll.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_id", Me.dgReportRepairAll.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_name", Me.dgReportRepairAll.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgReportRepairAll.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@discount", Me.dgReportRepairAll.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@decline", Me.dgReportRepairAll.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@return_status", Me.dgReportRepairAll.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@return_note", Me.dgReportRepairAll.Rows(r).Cells(9).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime", Me.dgReportRepairAll.Rows(r).Cells(10).Value)
                    cmdSQLite.Parameters.AddWithValue("@employee", Me.dgReportRepairAll.Rows(r).Cells(11).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            If checkPrinter() = "A4" Then
                RturnProductA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                RturnProductA5PrintFrm.ShowDialog(Me)
            End If

        End If
    End Sub

    Private Sub btnPrintALL_Click(sender As Object, e As EventArgs) Handles btnPrintALL.Click
        Call reportPrintALL()
    End Sub

    'รายงานการคืนสินค้าแบบแสดงรายชื่อสินค้า****************************************************************
    Private Sub searchDatadgReportReturnbarcode(ByVal strss As Integer)

        Me.dgReportRepair.Rows.Clear()
        Try
            If strss = 100 Then
                strSQL = "SELECT return_id,return_status FROM returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "return_status='เครดิต' OR return_status='ยังไม่ชำระเงิน'"
            ElseIf strss = 200 Then
                strSQL = "SELECT return_id,return_status FROM returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "return_status='เงินสด' OR return_status='ชำระเงิน'"
            ElseIf strss = 300 Then
                strSQL = "SELECT return_id,return_status FROM returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgReportRepair
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("return_id")
                    .Rows(r).Cells(13).Value = Dr.Item("return_status")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For cROWS As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                strSQL = "SELECT sale_id,fix_id,code_pro,name_pro,price_buy,total,employee,datetime_save,discount,decline FROM returnproduct_barcode WHERE " _
                    & "return_id='" & Me.dgReportRepair.Rows(cROWS).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgReportRepair
                    .Rows(cROWS).Cells(2).Value = Dr.Item("sale_id")
                    .Rows(cROWS).Cells(3).Value = Dr.Item("fix_id")
                    .Rows(cROWS).Cells(4).Value = Dr.Item("code_pro")
                    .Rows(cROWS).Cells(5).Value = Dr.Item("name_pro")
                    .Rows(cROWS).Cells(6).Value = Dr.Item("total")
                    .Rows(cROWS).Cells(7).Value = Dr.GetDecimal("price_buy")
                    .Rows(cROWS).Cells(8).Value = Dr.Item("discount")
                    .Rows(cROWS).Cells(9).Value = Dr.Item("decline")
                    .Rows(cROWS).Cells(11).Value = Dr.Item("datetime_save")
                    .Rows(cROWS).Cells(12).Value = Dr.Item("employee")
                End With
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'นับจำนวนชิ้น
            Dim ss2 As Integer
            For sumn As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                ss2 += Me.dgReportRepair.Rows(sumn).Cells(6).Value
            Next

            'นับจำนวนแถว
            Me.txtmoney.Text = ""
            Dim no As Integer = Me.dgReportRepair.RowCount
            Me.txtRRrows.Text = "จำนวน " & no & " รายการ" & ", " & ss2 & " ชิ้น"

            'นับจำนวนแถวใส่หมายเลขหน้าแถว
            For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Me.dgReportRepair.Rows(sum).Cells(0).Value = sum + 1
                Me.dgReportRepair.Rows(sum).Cells(10).Value = (CDec(Me.dgReportRepair.Rows(sum).Cells(7).Value) * CDec(Me.dgReportRepair.Rows(sum).Cells(6).Value)) _
                                                       - CDec(Me.dgReportRepair.Rows(sum).Cells(8).Value) - CDec(Me.dgReportRepair.Rows(sum).Cells(9).Value)
            Next

            'นับจำนวนเงิน
            If no = 0 Then
                Me.txtmoney.Text = "รวมราคา 0 บาท "
            Else
                    Dim ss As Decimal = 0
                    Dim sdiscount As Decimal = 0
                    Dim sdeline As Decimal = 0
                For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                    ss += Me.dgReportRepair.Rows(sum).Cells(10).Value
                    sdiscount += Me.dgReportRepair.Rows(sum).Cells(8).Value
                    sdeline += Me.dgReportRepair.Rows(sum).Cells(9).Value
                    Me.txtmoney.Text = "รวมราคา " & ss.ToString("N2") & " บาท " _
                        & ", รวมส่วนลด " & sdiscount.ToString("N2") & " บาท " & ", รวมค่าเสื่อมราคา " _
                        & sdeline.ToString("N2") & " บาท "
                Next
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        strss = Nothing
    End Sub

    Private Sub btnRRdisplayData_Click(sender As Object, e As EventArgs) Handles btnRRdisplayData.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox("เลือกสถานะ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        ElseIf Me.ComboBox1.Text = "ยังไม่ชำระเงิน" Then
            Call searchDatadgReportReturnbarcode(100)
        ElseIf Me.ComboBox1.Text = "ชำระเงิน" Then
            Call searchDatadgReportReturnbarcode(200)
        ElseIf Me.ComboBox1.Text = "ทั้งหมด" Then
            Call searchDatadgReportReturnbarcode(300)
        End If
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("ยังไม่ชำระเงิน")
        Me.ComboBox1.Items.Add("ชำระเงิน")
        Me.ComboBox1.Items.Add("ทั้งหมด")
    End Sub

    Private Sub reportPrint()
        If Me.dgReportRepair.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Try
                strSQLite = "DELETE FROM returnproductbarcode"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            For r As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO returnproductbarcode(`no`,return_id,sale_id,bar_code,name_pro,total_pro,price_buy,total_price_buy,datetime,employee,`status`,fix_id,discount,decline)" _
                     & "VALUES(@no,@return_id,@sale_id,@bar_code,@name_pro,@total_pro,@price_buy,@total_price_buy,@datetime,@employee,@status,@fix_id,@discount,@decline)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgReportRepair.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@return_id", Me.dgReportRepair.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@sale_id", Me.dgReportRepair.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgReportRepair.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgReportRepair.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_pro", Me.dgReportRepair.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgReportRepair.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_price_buy", Me.dgReportRepair.Rows(r).Cells(10).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime", Me.dgReportRepair.Rows(r).Cells(11).Value)
                    cmdSQLite.Parameters.AddWithValue("@employee", Me.dgReportRepair.Rows(r).Cells(12).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", Me.dgReportRepair.Rows(r).Cells(13).Value)
                    cmdSQLite.Parameters.AddWithValue("@fix_id", Me.dgReportRepair.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@discount", Me.dgReportRepair.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@decline", Me.dgReportRepair.Rows(r).Cells(9).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            If checkPrinter() = "A4" Then
                ReturnProductBarcodeA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReturnProductBarcodeA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call reportPrint()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/sales/salesreport/returnprodductreportfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class