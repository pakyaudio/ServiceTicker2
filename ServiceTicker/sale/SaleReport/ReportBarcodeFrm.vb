Imports System.Data.SQLite
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ReportBarcodeFrm

    Private Sub ReportBarcodeFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReportRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
    Dim selectfun As Integer
    Private Sub searchDatadgReport()
        Try
            Me.dgReportRepair.Rows.Clear()
            If selectfun = 100 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save,discount FROM " _
                    & "cash_sale_barcode WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", _
                                                                    CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & _
                                                                Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", _
                                                                CultureInfo.CreateSpecificCulture("en-US")) & "' AND fix_id='" & "ขายสินค้า" & "'"
            ElseIf selectfun = 200 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save,discount FROM " _
                    & "sale_barcode WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", _
                                                                CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & _
                                                            Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", _
                                                            CultureInfo.CreateSpecificCulture("en-US")) & "' AND fix_id='" & "ขายสินค้า" & "'"
            ElseIf selectfun = 300 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save,discount FROM " _
                    & "cash_sale_barcode WHERE datetime_save LIKE '%" & Now.ToString("yyyy-MM-dd", _
                                                CultureInfo.CreateSpecificCulture("en-EN")) & "%' AND fix_id='" & "ขายสินค้า" & "'"
            ElseIf selectfun = 400 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,datetime_save,discount FROM " _
                    & "sale_barcode WHERE datetime_save LIKE '%" & Now.ToString("yyyy-MM-dd", _
                                                CultureInfo.CreateSpecificCulture("en-EN")) & "%' AND fix_id='" & "ขายสินค้า" & "'"
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
                    .Rows(r).Cells(7).Value = Dr.GetDecimal("discount")
                    .Rows(r).Cells(10).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        
        'นับจำนวนชิ้น
        Try
            Dim ss2, astv As Decimal
            For sumn As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                ss2 += CDec(Me.dgReportRepair.Rows(sumn).Cells(4).Value)
                astv += CDec(Me.dgReportRepair.Rows(sumn).Cells(7).Value)
            Next
            'นับจำนวนแถว
            Me.txtmoney.Text = ""
            Dim no As Integer = Me.dgReportRepair.RowCount
            Me.txtRRrows.Text = "จำนวน " & no & " รายการ" & ", " & ss2 & " ชิ้น"
            'นับจำนวนแถวใส่หมายเลขหน้าแถว
            For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Me.dgReportRepair.Rows(sum).Cells(9).Value = CDec(Me.dgReportRepair.Rows(sum).Cells(6).Value) _
                    * CDec(Me.dgReportRepair.Rows(sum).Cells(4).Value)
                Me.dgReportRepair.Rows(sum).Cells(8).Value = CDec(Me.dgReportRepair.Rows(sum).Cells(5).Value) _
                    * CDec(Me.dgReportRepair.Rows(sum).Cells(4).Value)
            Next

            'นับจำนวนเงิน
            If no = 0 Then
                Me.txtmoney.Text = "รวมราคาทุน 0 บาท " & " รวมราคาขาย 0 บาท"
            Else
                For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                    Dim ss, ss1, sss1 As Decimal
                    ss += CDec(Me.dgReportRepair.Rows(sum).Cells(8).Value)
                    ss1 += CDec(Me.dgReportRepair.Rows(sum).Cells(9).Value)
                    sss1 = ss1 - ss - astv
                    Me.txtmoney.Text = "(รวมราคาขาย " & ss1.ToString("N2") & " บาท)" & " - " & _
                        "(รวมราคาทุน " & ss.ToString("N2") & " บาท)" & " - " & "(ส่วนลด " & astv.ToString("N2") & _
                        " บาท)" & " = " & "กำไร " & sss1.ToString("N2") & " บาท "
                Next
            End If
            Dr.Close()
            selectfun = Nothing
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
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

    Private Sub ReportPrint()
        If Me.dgReportRepair.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Try
                strSQLite = "DELETE FROM reportbarcodesale"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            For r As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO reportbarcodesale(`no`,code_pro,bar_code,name_pro,total,price_cost,price_buy,total_cost,total_buy,datetime_save,discount)" _
                     & "VALUES(@no,@code_pro,@bar_code,@name_pro,@total,@price_cost,@price_buy,@total_cost,@total_buy,@datetime_save,@discount)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgReportRepair.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgReportRepair.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgReportRepair.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgReportRepair.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@total", Me.dgReportRepair.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_cost", Me.dgReportRepair.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgReportRepair.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@discount", Me.dgReportRepair.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_cost", Me.dgReportRepair.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_buy", Me.dgReportRepair.Rows(r).Cells(9).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime_save", Me.dgReportRepair.Rows(r).Cells(10).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            If checkPrinter() = "A4" Then
                ReportBarcodeSaleA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReportBarcodeSaleA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call ReportPrint()
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

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/sales/salesreport/reportbarcodefrm")
        Catch ex As Exception

        End Try
    End Sub
End Class