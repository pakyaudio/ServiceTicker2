Imports Microsoft.Reporting.WinForms

Public Class ReceviceReportA4PrintFrm
    Dim datetime As String

    Private Sub ReceviceReportA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReceviceReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.receivereport' table. You can move, or remove it, as needed.
        Me.receivereportTableAdapter.Fill(Me.STdata.receivereport)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        DateTime = "ระหว่างวันที่ " & ReceiveReportFrm.DateTimePicker1.Text & " ถึง " & ReceiveReportFrm.DateTimePicker2.Text
        If ReceiveReportFrm.cbbVRbuyCompany.Text <> "" Then
            DateTime = DateTime & "  " & ReceiveReportFrm.cbbVRbuyCompany.Text
        End If
        Dim u_datetime As New ReportParameter("start_end_date", DateTime)
        Dim u_totalpro As New ReportParameter("total_pro", ReceiveReportFrm.txtRRRrow.Text)
        Dim st_money As New ReportParameter("total_money", ReceiveReportFrm.txtRRRsum.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class