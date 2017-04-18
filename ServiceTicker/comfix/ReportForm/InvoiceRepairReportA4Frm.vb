Imports Microsoft.Reporting.WinForms

Public Class InvoiceRepairReportA4Frm

    Private Sub InvoiceRepairReportA4Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub InvoiceRepairReportA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.salebcFill(Me.MySQLReport.sale_barcode, SendRepairFrm.txtHideform.Text)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'MySQLReport.comfix' table. You can move, or remove it, as needed.
        Me.comfixTableAdapter.ComfixFill(Me.MySQLReport.comfix, SendRepairFrm.txtHideform.Text)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(SendRepairFrm.txtSRfixPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim ttall As New ReportParameter("totalall", SendRepairFrm.txtSRfixPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttall, tx})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class