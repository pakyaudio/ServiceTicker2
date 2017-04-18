Public Class ReturnProductA4ReportPrintFrm

    Private Sub ReturnProductA4ReportPrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReturnProductA4ReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'ReturnProductDataSet.returnproduct_barcode' table. You can move, or remove it, as needed.
        Me.returnproduct_barcodeTableAdapter.Fill(Me.ReturnProductDataSet.returnproduct_barcode, ReturnsProductFrm.txtRP_ID.Text)
        'TODO: This line of code loads data into the 'ReturnProductDataSet.returnproduct' table. You can move, or remove it, as needed.
        Me.returnproductTableAdapter.Fill(Me.ReturnProductDataSet.returnproduct, ReturnsProductFrm.txtRP_ID.Text)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class