Imports Microsoft.Reporting.WinForms

Public Class ReportBarcodeComfixA5PrintFrm
    Dim datetime As String

    Private Sub ReportBarcodeComfixA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReportBarcodeComfixA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.ReportBarcodeComfix' table. You can move, or remove it, as needed.
        Me.ReportBarcodeComfixTableAdapter.Fill(Me.STdata.ReportBarcodeComfix)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        If ReportBarcodeComfixFrm.cbbRRcashstatus.Text = "ชำระเงิน(ตามวันที่)" Then
            datetime = "ยอดชำระเงินระหว่างวันที่ " & ReportBarcodeComfixFrm.DateTimePicker1.Text & " ถึง " & ReportBarcodeComfixFrm.DateTimePicker2.Text
        ElseIf ReportBarcodeComfixFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(ตามวันที่)" Then
            datetime = "ยอดยังไม่ได้ชำระเงินระหว่างวันที่ " & ReportBarcodeComfixFrm.DateTimePicker1.Text & " ถึง " & ReportBarcodeComfixFrm.DateTimePicker2.Text
        ElseIf ReportBarcodeComfixFrm.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
            datetime = "ยอดชำระเงินวันที่ " & Now.ToString("dd MMMM yyyy")
        ElseIf ReportBarcodeComfixFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
            datetime = "ยอดยังไม่ได้ชำระเงินระหว่างวันที่ " & Now.ToString("dd MMMM yyyy")
        End If

        Dim u_datetime As New ReportParameter("start_end_date", datetime)
        Dim u_totalpro As New ReportParameter("total_pro", ReportBarcodeComfixFrm.txtRRrows.Text)
        Dim st_money As New ReportParameter("total_money", ReportBarcodeComfixFrm.txtmoney.Text)


        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class