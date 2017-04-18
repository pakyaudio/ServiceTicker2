Imports Microsoft.Reporting.WinForms

Public Class ClaimsReportWorksA5PrintFrm
    Dim sed, cn As String

    Private Sub ClaimsReportWorksA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ClaimsReportWorksA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.claimsreport' table. You can move, or remove it, as needed.
        Me.claimsreportTableAdapter.Fill(Me.STdata.claimsreport)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)

        sed = "ระหว่างวันที่  " & ClaimsReportFrm.DateTimePicker1.Text & " ถึง " & ClaimsReportFrm.DateTimePicker2.Text



        Dim s_e_date As New ReportParameter("start_end_date", sed)
        Dim cnn As New ReportParameter("com_name", cn)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, s_e_date})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class