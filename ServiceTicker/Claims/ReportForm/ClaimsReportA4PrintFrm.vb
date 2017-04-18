Imports Microsoft.Reporting.WinForms

Public Class ClaimsReportA4PrintFrm

    Private Sub ClaimsReportA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.claims_cache' table. You can move, or remove it, as needed.
        Me.claims_cacheTableAdapter.Fill(Me.STdata.claims_cache)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim customer_name As New ReportParameter("cus_name", ClaimsFrm.txtCFcustomer_name.Text)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {customer_name})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class