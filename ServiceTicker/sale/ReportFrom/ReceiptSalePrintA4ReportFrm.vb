Imports Microsoft.Reporting.WinForms

Public Class ReceiptSalePrintA4ReportFrm

    Private Sub ReceiptSalePrintA4ReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReceiptSalePrintA4ReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'SaleDataSet.cash_sale_barcode' table. You can move, or remove it, as needed.
        Me.cash_sale_barcodeTableAdapter.Fill(Me.SaleDataSet.cash_sale_barcode, CashSaleFrm.txtCSsale_id.Text)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'SaleDataSet.cash_sale' table. You can move, or remove it, as needed.
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(CashSaleFrm.txtCStotalmoney.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Me.cash_saleTableAdapter.CashSaleFill(Me.SaleDataSet.cash_sale, CashSaleFrm.txtCSsale_id.Text)
        Dim Dcount As New ReportParameter("total_tdt", CashSaleFrm.txtCSdiscount.Text)
        Dim ttl As New ReportParameter("total_all", CashSaleFrm.txtCashCash.Text)
        Dim ttext As New ReportParameter("thai_text", thaitext)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Dcount, ttl, ttext})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class