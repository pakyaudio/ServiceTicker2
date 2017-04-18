Imports Microsoft.Reporting.WinForms

Public Class ReClaimsListA5PrintFrm

    Private Sub ReClaimsListA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReClaimsListA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.claims_list' table. You can move, or remove it, as needed.
        Me.claims_listTableAdapter.Fill(Me.STdata.claims_list)
        Dim lname As New ReportParameter("claims_lot", PrintingClaimSendListFrm.txtClaims_lot.Text)
        Dim claimscom As New ReportParameter("claims_company", PrintingClaimSendListFrm.txtClaims_company.Text)
        Dim lgn As New ReportParameter("login_name", PrintingClaimSendListFrm.lblEmployee.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {lname, claimscom, lgn})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class