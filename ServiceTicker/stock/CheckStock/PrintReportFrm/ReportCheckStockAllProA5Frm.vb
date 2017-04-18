Imports Microsoft.Reporting.WinForms

Public Class ReportCheckStockAllProA5Frm

    Private Sub ReportCheckStockAllProA5Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'STdata.check_stock_save_pro' table. You can move, or remove it, as needed.
        Me.check_stock_save_proTableAdapter.csspFill(Me.STdata.check_stock_save_pro)




        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class