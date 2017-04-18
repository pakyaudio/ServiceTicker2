Imports Microsoft.Reporting.WinForms

Public Class InvoiceSaleA4ReportFrm

    Private Sub InvoiceSaleA4ReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub InvoiceSaleA4ReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'SaleDataSet.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.Fill(Me.SaleDataSet.sale_barcode, CashSaleFrm.txtCSsale_id.Text)
        'TODO: This line of code loads data into the 'SaleDataSet.sale' table. You can move, or remove it, as needed.
        Me.saleTableAdapter.Fill(Me.SaleDataSet.sale, CashSaleFrm.txtCSsale_id.Text)

        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(CashSaleFrm.txtCStotalmoney.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Dim tota As New ReportParameter("total", CashSaleFrm.txtCashCash.Text)
        Dim Dcount As New ReportParameter("discount", CashSaleFrm.txtCSdiscount.Text)
        Dim ttl As New ReportParameter("totalall", CashSaleFrm.txtCashCash.Text)
        Dim ttext As New ReportParameter("thaitext", thaitext)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {tota, Dcount, ttl, ttext})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class