Imports Microsoft.Reporting.WinForms

Public Class DebtorBillingA5PrintFrm

    Private Sub DebtorBillingA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub DebtorBillingA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(DebtorFrm.txtDTpaymentsPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Dim bname As New ReportParameter("header", DebtorFrm.cANDp.ToString)
        Dim namebb As New ReportParameter("nameb", DebtorFrm.cANDp1.ToString)
        Dim pid As New ReportParameter("pledge_id", DebtorFrm.txtDTautonumDT.Text)
        Dim cid As New ReportParameter("cus_id", DebtorFrm.txtDTcustomer_id.Text)
        Dim cname As New ReportParameter("cus_name", DebtorFrm.txtDTcustomer_name.Text)
        Dim pdt As New ReportParameter("pledge_detail", DebtorFrm.cbbDTpayments.Text & "/" & DebtorFrm.txtDTpayments.Text & "/" & DebtorFrm.DateTimePicker3.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Dim ttall As New ReportParameter("pledge_total", DebtorFrm.txtDTpaymentsPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {pid, cid, cname, pdt, _
                                                                          ttall, tx, bname, namebb})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class