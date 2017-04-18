Imports Microsoft.Reporting.WinForms

Public Class ClaimsreceiveReportA5PrintFrm

    Private Sub ClaimsreceiveReportA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsSendReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.claims_send_r_report' table. You can move, or remove it, as needed.
        Me.claims_send_r_reportTableAdapter.Fill(Me.STdata.claims_send_r_report)


        Dim lname As New ReportParameter("login_name", ClaimsreceiveGroupFrm.lblEmployee.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {lname})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class