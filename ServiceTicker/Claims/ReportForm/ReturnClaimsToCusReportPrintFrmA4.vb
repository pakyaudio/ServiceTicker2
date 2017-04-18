Imports Microsoft.Reporting.WinForms

Public Class ReturnClaimsToCusReportPrintFrmA4

    Private Sub ReturnClaimsToCusReportPrintFrmA4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReturnClaimsToCusReportPrintFrmA4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)


        Dim c_id As New ReportParameter("claims_id", ReturnClaimstoCus1Frm.txtRCTC1claims_id.Text)
        Dim customer_id As New ReportParameter("cus_id", ReturnClaimstoCus1Frm.txtRCTC1cus_id.Text)
        Dim customer_name As New ReportParameter("cus_name", ReturnClaimstoCus1Frm.txtRCTC1cus_name.Text)
        Dim customer_tel As New ReportParameter("cus_tel", ReturnClaimstoCus1Frm.txtRCTC1cus_tel.Text)
        Dim sn_pro As New ReportParameter("sn", ReturnClaimstoCus1Frm.txtRCTC1serial_pro.Text)
        Dim barcode_pro As New ReportParameter("barcode", ReturnClaimstoCus1Frm.txtRCTC1bar_code.Text)
        Dim name_pro_pro As New ReportParameter("name_pro", ReturnClaimstoCus1Frm.txtRCTC1name_pro.Text)
        Dim sytp As New ReportParameter("symptom", ReturnClaimstoCus1Frm.txtRCTC1symptom.Text)
        Dim acc As New ReportParameter("accressory", ReturnClaimstoCus1Frm.txtRCTCaccessory.Text)
        Dim ne As New ReportParameter("note", ReturnClaimstoCus1Frm.txtRCTC1fix.Text)
        Dim emp As New ReportParameter("employee", ReturnClaimstoCus1Frm.lblEmployee.Text)
        Dim dts As New ReportParameter("datetime_sale", ReturnClaimstoCus1Frm.txtRCTC1datetime_sale.Text)
        Dim dtss As New ReportParameter("datetime_save", ReturnClaimstoCus1Frm.txtRCTC1datetime_save.Text)
        Dim dtr As New ReportParameter("datetime_return", ReturnClaimstoCus1Frm.txtRCTC1datetime_edit.Text)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {c_id, customer_id, customer_name, _
                                                                          customer_tel, sn_pro, barcode_pro, name_pro_pro, sytp, acc, ne, emp, _
                                                                          dts, dtss, dtr})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class