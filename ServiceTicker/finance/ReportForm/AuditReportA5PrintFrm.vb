Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Reporting.WinForms

Public Class AuditReportA5PrintFrm
    Dim sed As String

    Private Sub AuditReportA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub AuditReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'AuditReportDataSet.dataGridview' table. You can move, or remove it, as needed.
        Me.dataGridviewTableAdapter.Fill(Me.AuditReportDataSet.dataGridview)
        sed = "ระหว่างวันที่  " & AuditReportFrm.DateTimePicker1.Text & " ถึง " & AuditReportFrm.DateTimePicker2.Text
        Dim s_e_date As New ReportParameter("datetodate", sed)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {s_e_date})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class