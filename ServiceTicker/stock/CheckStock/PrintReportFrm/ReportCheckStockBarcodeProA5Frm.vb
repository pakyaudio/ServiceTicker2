Imports Microsoft.Reporting.WinForms

Public Class ReportCheckStockBarcodeProA5Frm

    Private Sub ReportCheckStockBarcodeProA5Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.check_stock_barcode_save_pro' table. You can move, or remove it, as needed.
        Me.check_stock_barcode_save_proTableAdapter.Fill(Me.STdata.check_stock_barcode_save_pro)

        Dim ttext As New ReportParameter("protype", CheckStockBCReportFrm.DateTimePicker1.Text)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttext})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class