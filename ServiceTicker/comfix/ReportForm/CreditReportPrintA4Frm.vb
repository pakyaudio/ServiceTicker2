Imports Microsoft.Reporting.WinForms

Public Class CreditReportPrintA4Frm

    Private Sub CreditReportPrintA4Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CreditReportPrintA4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'MySQLReport.pledge_sale' table. You can move, or remove it, as needed.
        Me.pledge_saleTableAdapter.pledgeSaleFill(Me.MySQLReport.pledge_sale, CashFrm.txtCashpledgeID.Text)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(CashFrm.txtCashCusPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim pdt As New ReportParameter("pledge_detail", CashFrm.cbbCashSelectPayment.Text & " " & CashFrm.txtCashByselectPayment.Text)

        Dim ttall As New ReportParameter("pledge_total", CashFrm.txtCashCusPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttall, tx, pdt})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class