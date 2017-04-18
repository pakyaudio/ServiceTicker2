Imports Microsoft.Reporting.WinForms

Public Class ReportUserRepairA5PrintFrm

    Private Sub ReportUserRepairA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReportUserRepairA5PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.ReportUserRepair' table. You can move, or remove it, as needed.
        Me.ReportUserRepairTableAdapter.Fill(Me.STdata.ReportUserRepair)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)

        Dim u_repair As New ReportParameter("user_repair", ReportUserRepairFrm.cbbRURselectUser.Text)
        Dim s_date As New ReportParameter("start_date", ReportUserRepairFrm.DateTimePicker1.Text)
        Dim e_date As New ReportParameter("end_date", ReportUserRepairFrm.DateTimePicker2.Text)
        Dim ttnf As New ReportParameter("tital_num_fix", ReportUserRepairFrm.txtRURrows.Text)
        Dim b As New ReportParameter("buy", ReportUserRepairFrm.txtRURtotalBuy.Text)
        Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_repair, s_date, e_date, ttnf, b, c, d, p})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class