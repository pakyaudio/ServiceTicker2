Imports Microsoft.Reporting.WinForms

Public Class BillingA5ReportFrm

    Private Sub BillingA5ReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub BillingA4ReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.billing_print' table. You can move, or remove it, as needed.
        Me.billing_printTableAdapter.Fill(Me.STdata.billing_print)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(BillingSelectPrintFrm.txtSdg.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        ' ''Me.ReportViewer1.RefreshReport()
        ' ''Dim datasource As ReportDataSource = New ReportDataSource("Snum", dt)


        Dim cusid As New ReportParameter("cus_id", DebtorFrm.txtDTcustomer_id.Text)
        Dim cusname As New ReportParameter("cus_name", DebtorFrm.txtDTcustomer_name.Text)
        Dim ttall As New ReportParameter("totalall", BillingSelectPrintFrm.txtSdg.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cusid, cusname, ttall, tx})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class