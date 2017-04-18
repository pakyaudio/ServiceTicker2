Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class ReceiptReportA4PrintFrm
    Dim tlall As Decimal

    Private Sub ReceiptReportA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReceiptReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MySQLReport.discount' table. You can move, or remove it, as needed.
        Me.discountTableAdapter.Fill(Me.MySQLReport.discount, CashFrm.txtCashFixID.Text)
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'MySQLReport.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.salebcFill(Me.MySQLReport.sale_barcode, CashFrm.txtCashFixID.Text)

        'รวมราคาใบขาย
        Try
            strSQL = "SELECT SUM(total_all) AS ttl FROM sale WHERE fix_id='" & CashFrm.txtCashFixID.Text & "'"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            tlall = Dr.Item("ttl")
        Catch ex As Exception

        End Try


        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(CashFrm.txtCashCash.Text))
        Catch ex As Exception
            thaitext = ""
        End Try


        Dim ttall As New ReportParameter("total_price", tlall)
        Dim ttext As New ReportParameter("thai_text", thaitext)
        Dim cashid As New ReportParameter("cash_id", CashFrm.cashID)

        Dim ttaa As New ReportParameter("ta", CashFrm.txtCashCash.Text)

        Dim cby As New ReportParameter("cash_by", CashFrm.cashDetail)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttall, ttext, _
                                                                          cashid, ttaa, cby})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class