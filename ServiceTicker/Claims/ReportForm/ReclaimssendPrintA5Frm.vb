Public Class ReclaimssendPrintA5Frm

    Private Sub ReclaimssendPrintA5Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReclaimssendPrintA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.reclaims' table. You can move, or remove it, as needed.
        Me.reclaimsTableAdapter.Fill(Me.STdata.reclaims)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class