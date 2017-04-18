Imports Microsoft.Reporting.WinForms

Public Class ReturnProductBarcodeA4PrintFrm
    Dim DateTime As String

    Private Sub ReturnProductBarcodeA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReturnProductBarcodePrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.returnproductbarcode' table. You can move, or remove it, as needed.
        Me.returnproductbarcodeTableAdapter.Fill(Me.STdata.returnproductbarcode)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        If ReturnProdductReportFrm.ComboBox1.Text = "ยังไม่ชำระเงิน" Then
            DateTime = "สถานะสินค้ายังไม่ชำระเงิ ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2.Text
        ElseIf ReturnProdductReportFrm.ComboBox1.Text = "ชำระเงิน Then" Then
            DateTime = "สถานะสินค้าชำระเงิน ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2.Text
        ElseIf ReturnProdductReportFrm.ComboBox1.Text = "ทั้งหมด" Then
            DateTime = "สถานะสินค้าทั้งหมด ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2.Text
        End If

        Dim u_datetime As New ReportParameter("start_end_date", DateTime)
        Dim u_totalpro As New ReportParameter("total_pro", ReturnProdductReportFrm.txtRRrows.Text)
        Dim st_money As New ReportParameter("money", ReturnProdductReportFrm.txtmoney.Text)


        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class