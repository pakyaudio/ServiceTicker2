Imports Microsoft.Reporting.WinForms

Public Class ReSavedatafixPrintA4Frm

    Private Sub ReSavedatafixPrintA4Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReSavedatafixPrintA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'MySQLReport.customer' table. You can move, or remove it, as needed.
        Me.customerTableAdapter.CustomerFill(Me.MySQLReport.customer, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(4).Value)
        'TODO: This line of code loads data into the 'MySQLReport.comfix' table. You can move, or remove it, as needed.
        Me.comfixTableAdapter.ComfixFill(Me.MySQLReport.comfix, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value)
        'TODO: This line of code loads data into the 'MySQLReport.sn' table. You can move, or remove it, as needed.
        Me.snTableAdapter.SNFill(Me.MySQLReport.sn, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(7).Value)
        Dim fixd As New ReportParameter("fixid", PrintSaveDatafixSendRepairFrm.fixid)
        Dim fspt As New ReportParameter("spt", PrintSaveDatafixSendRepairFrm.spt)
        Dim facc As New ReportParameter("fixacc", PrintSaveDatafixSendRepairFrm.fixacc)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {fixd, fspt, facc})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class