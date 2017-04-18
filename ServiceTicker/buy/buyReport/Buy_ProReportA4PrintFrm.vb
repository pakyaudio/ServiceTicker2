Imports Microsoft.Reporting.WinForms

Public Class Buy_ProReportA4PrintFrm

    Private Sub Buy_ProReportA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub Buy_ProReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'BuyDataSet.buy_pro' table. You can move, or remove it, as needed.
        Me.buy_proTableAdapter.BuyproFill(Me.BuyDataSet.buy_pro, OrderFrm.lblORid.Text)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(OrderFrm.txtORsumMoney.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Dim ttext As New ReportParameter("thaitext", thaitext)
        Dim toal As New ReportParameter("total_buy", OrderFrm.txtORsumMoney.Text)

        'Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        'Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        'Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttext, toal})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class