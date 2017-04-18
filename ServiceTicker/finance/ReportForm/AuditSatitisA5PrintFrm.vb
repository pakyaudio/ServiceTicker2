Imports Microsoft.Reporting.WinForms

Public Class AuditSatitisA5PrintFrm

    Private Sub AuditSatitisA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub AuditSatitisA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.satitis' table. You can move, or remove it, as needed.
        Me.satitisTableAdapter.Fill(Me.STdata.satitis)
        Dim htext As New ReportParameter("h_text", AuditChartFrm.hhtext)
        Dim year As New ReportParameter("year", AuditChartFrm.header)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {year, htext})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class