Imports Microsoft.Reporting.WinForms

Public Class CheckStockDontCheckA4ReportPrintFrm

    Private Sub CheckStockDontCheckA4ReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.check_stock_dont' table. You can move, or remove it, as needed.
        Me.check_stock_dontTableAdapter.Fill(Me.STdata.check_stock_dont)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim ttext As New ReportParameter("protype", ViewCheckStockSNDontFrm.cbbProduct.Text)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttext})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class