Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Public Class ReportBarcodeComfixFrm

    Private Sub ReportBarcodeComfixFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReportRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
    Dim selectfun As Integer
    Dim ss2, ss, ss1, sss1, astv As Decimal
    Private Sub searchDatadgReport()

        Try
            strSQL = "SELECT COALESCE(SUM(replace(discount, ',', '')),0) AS sbb FROM discount WHERE datetime_save between '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' and '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND NOT (fix_id='" & "ขายสินค้า" & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            astv = Dr.Item("sbb")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Me.dgReportRepair.Rows.Clear()
            If selectfun = 100 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save FROM cash_sale_barcode WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND NOT (fix_id='" & "ขายสินค้า" & "')"
            ElseIf selectfun = 200 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save FROM sale_barcode WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND NOT (fix_id='" & "ขายสินค้า" & "')"
            ElseIf selectfun = 300 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save FROM cash_sale_barcode WHERE datetime_save LIKE '%" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
            ElseIf selectfun = 400 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save FROM sale_barcode WHERE datetime_save LIKE '%" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgReportRepair
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("price_cost")
                    .Rows(r).Cells(6).Value = Dr.GetDecimal("price_buy")
                    .Rows(r).Cells(7).Value = CDec(Me.dgReportRepair.Rows(r).Cells(5).Value) * CDec(Me.dgReportRepair.Rows(r).Cells(4).Value)
                    .Rows(r).Cells(8).Value = CDec(Me.dgReportRepair.Rows(r).Cells(6).Value) * CDec(Me.dgReportRepair.Rows(r).Cells(4).Value)
                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                    ss2 += CDec(Me.dgReportRepair.Rows(r).Cells(4).Value)
                    ss += CDec(Me.dgReportRepair.Rows(r).Cells(7).Value)
                    ss1 += CDec(Me.dgReportRepair.Rows(r).Cells(8).Value)
                End With
            End While
            sss1 = ss1 - ss - astv
            Me.txtmoney.Text = "(รวมราคาขาย " & ss1.ToString("N2") & " บาท)" & " - " & "(รวมราคาทุน " & ss.ToString("N2") & " บาท)" & " - " & "(ส่วนลด " & astv.ToString("N2") & " บาท)" & " = " & "กำไร " & sss1.ToString("N2") & " บาท "
            Dim no As Integer = Me.dgReportRepair.RowCount
            Me.txtRRrows.Text = "จำนวน " & no & " รายการ" & ", " & ss2 & " ชิ้น"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        ss2 = Nothing
        ss = Nothing
        ss1 = Nothing
        sss1 = Nothing
        astv = Nothing
        selectfun = Nothing
    End Sub

    Private Sub btnRRdisplayData_Click(sender As Object, e As EventArgs) Handles btnRRdisplayData.Click
        If Me.cbbRRcashstatus.Text = "" Then
            MsgBox("เลือกสถานะ", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.lblRRcashStatus.BackColor = Color.Orange
        Else
            If Me.cbbRRcashstatus.Text = "ชำระเงิน(ตามวันที่)" Then
                selectfun = 100
                Call searchDatadgReport()
            ElseIf Me.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(ตามวันที่)" Then
                selectfun = 200
                Call searchDatadgReport()
            ElseIf Me.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
                selectfun = 300
                Call searchDatadgReport()
            ElseIf Me.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
                selectfun = 400
                Call searchDatadgReport()
            End If
        End If
    End Sub

    Private Sub cbbRRcashstatus_Click(sender As Object, e As EventArgs) Handles cbbRRcashstatus.Click
        Me.cbbRRcashstatus.Items.Clear()
        Me.cbbRRcashstatus.Items.Add("ชำระเงิน(ตามวันที่)")
        Me.cbbRRcashstatus.Items.Add("ยังไม่ได้ชำระเงิน(ตามวันที่)")
        Me.cbbRRcashstatus.Items.Add("ชำระเงิน(วันนี้)")
        Me.cbbRRcashstatus.Items.Add("ยังไม่ได้ชำระเงิน(วันนี้)")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.dgReportRepair.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Try
                strSQLite = "DELETE FROM ReportBarcodeComfix"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO ReportBarcodeComfix(`no`,code_pro,bar_code,name_pro,total,price_cost,price_buy,total_cost,total_buy,datetime_save)" _
                     & "VALUES(@no,@code_pro,@bar_code,@name_pro,@total,@price_cost,@price_buy,@total_cost,@total_buy,@datetime_save)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgReportRepair.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgReportRepair.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgReportRepair.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgReportRepair.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@total", Me.dgReportRepair.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_cost", Me.dgReportRepair.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgReportRepair.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_cost", Me.dgReportRepair.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_buy", Me.dgReportRepair.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime_save", Me.dgReportRepair.Rows(r).Cells(9).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            If checkPrinter() = "A4" Then
                ReportBarcodeComfixA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReportBarcodeComfixA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub cbbRRcashstatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbRRcashstatus.SelectedValueChanged
        Me.lblRRcashStatus.BackColor = SystemColors.Control
    End Sub

    Dim oldData As Object
    Private Sub dgReportRepair_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportRepair.CellDoubleClick
        oldData = Me.dgReportRepair.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgReportRepair_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgReportRepair.CellEndEdit
        Me.dgReportRepair.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixreportmenu/reportbarcodecomfixfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class