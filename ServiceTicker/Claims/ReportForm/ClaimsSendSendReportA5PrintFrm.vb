Imports Microsoft.Reporting.WinForms

Public Class ClaimsSendSendReportA5PrintFrm

    Private Sub ClaimsSendSendReportA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsSendReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.claims_send_s_report' table. You can move, or remove it, as needed.
        Me.claims_send_s_reportTableAdapter.Fill(Me.STdata.claims_send_s_report)



        Dim clot As New ReportParameter("claims_lot", ClaimsSendGroupFrm.txtCSGlotNum.Text)
        Dim lname As New ReportParameter("login_name", ClaimsSendGroupFrm.lblEmployee.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {clot, lname})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class