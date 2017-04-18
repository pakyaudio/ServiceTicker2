Public Class CheckStockBarcodeA5PrintFrm

    Private Sub CheckStockBarcodeA5PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.check_stock_bc' table. You can move, or remove it, as needed.
        Me.check_stock_bcTableAdapter.Fill(Me.STdata.check_stock_bc)
        Me.Icon = MainFrm.Icon
       
    End Sub

    Private Sub CheckStockBarcodeA5PrintFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.check_stock_bc' table. You can move, or remove it, as needed.
        Me.check_stock_bcTableAdapter.Fill(Me.STdata.check_stock_bc)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class