Imports Microsoft.Reporting.WinForms

Public Class ReportBarcodeSaleA5PrintFrm
    Dim datetime As String

    Private Sub ReportBarcodeSaleA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReportBarcodeSaleA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.reportbarcodesale' table. You can move, or remove it, as needed.
        Me.reportbarcodesaleTableAdapter.Fill(Me.STdata.reportbarcodesale)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        If ReportBarcodeFrm.cbbRRcashstatus.Text = "ชำระเงิน(ตามวันที่)" Then
            DateTime = "ยอดชำระเงินระหว่างวันที่ " & ReportBarcodeFrm.DateTimePicker1.Text & " ถึง " & ReportBarcodeFrm.DateTimePicker2.Text
        ElseIf ReportBarcodeFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(ตามวันที่)" Then
            DateTime = "ยอดยังไม่ได้ชำระเงินระหว่างวันที่ " & ReportBarcodeFrm.DateTimePicker1.Text & " ถึง " & ReportBarcodeFrm.DateTimePicker2.Text
        ElseIf ReportBarcodeFrm.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
            DateTime = "ยอดชำระเงินวันที่ " & Now.ToString("dd MMMM yyyy")
        ElseIf ReportBarcodeFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
            DateTime = "ยอดยังไม่ได้ชำระเงินระหว่างวันที่ " & Now.ToString("dd MMMM yyyy")
        End If


        Dim u_datetime As New ReportParameter("start_end_date", DateTime)
        Dim u_totalpro As New ReportParameter("total_pro", ReportBarcodeFrm.txtRRrows.Text)
        Dim st_money As New ReportParameter("total_money", ReportBarcodeFrm.txtmoney.Text)


        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class