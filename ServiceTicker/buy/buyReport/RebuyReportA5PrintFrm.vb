Imports Microsoft.Reporting.WinForms

Public Class RebuyReportA5PrintFrm

    Private Sub RebuyReportA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub RebuyReportA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.buy_pro_reword' table. You can move, or remove it, as needed.
        Me.buy_pro_rewordTableAdapter.Fill(Me.STdata.buy_pro_reword)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(ViewSelectReceiveProductFrm.txtVSRtotalBuy.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Dim bstatus As String = ViewReceiveFrm.dgVR.CurrentRow.Cells(6).Value
        Dim buyid As New ReportParameter("buy_id", ViewSelectReceiveProductFrm.txtVSRPbuy_id.Text)
        Dim em As New ReportParameter("employee", ViewSelectReceiveProductFrm.txtVSRPemployee.Text)
        Dim ttext As New ReportParameter("thaitext", thaitext)
        Dim toal As New ReportParameter("total_buy", ViewSelectReceiveProductFrm.txtVSRtotalBuy.Text)
        Dim cbuy As New ReportParameter("company_buy", ViewSelectReceiveProductFrm.txtVSRPsale_company_name.Text)
        Dim bsta As New ReportParameter("buy_status", bstatus)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {buyid, ttext, toal, cbuy, em, bsta})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class