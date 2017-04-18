Public Class ClaimsCoverPrintA5Frm

    Private Sub ClaimsCoverPrintA5Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsCoverPrintA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClaimsCoverDataSet.customer' table. You can move, or remove it, as needed.
        Me.customerTableAdapter.Fill(Me.ClaimsCoverDataSet.customer, PrintingGetClaimsFrm.dgPGC.CurrentRow.Cells(2).Value)
        'TODO: This line of code loads data into the 'ClaimsCoverDataSet.claims' table. You can move, or remove it, as needed.
        Me.claimsTableAdapter.Fill(Me.ClaimsCoverDataSet.claims, PrintingGetClaimsFrm.dgPGC.CurrentRow.Cells(1).Value)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class