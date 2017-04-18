Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class SaveDataFixPrintA5Frm

    Private Sub SaveDataFixPrintA5Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SaveDataFixPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.comfix_savedatafixreport' table. You can move, or remove it, as needed.
        Me.comfix_savedatafixreportTableAdapter.Fill(Me.STdata.comfix_savedatafixreport)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)

        Dim cusID As New ReportParameter("cus_id", SaveDataFixFrm.txtSDFCusID.Text)
        Dim cusname As New ReportParameter("cus_name", SaveDataFixFrm.txtSDFcusname.Text)
        Dim custel As New ReportParameter("cus_tel", SaveDataFixFrm.txtSDFcusTel.Text)
        Dim cusaddress As New ReportParameter("cus_address", SaveDataFixFrm.txtSDFcusaddress.Text)
        Dim DTsave As New ReportParameter("datetime", SaveDataFixFrm.DateTimePickerSDFadd.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cusID, cusname, cusaddress, custel, DTsave})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class