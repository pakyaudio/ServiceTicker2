Imports Microsoft.Reporting.WinForms

Public Class ReportSaleA4PrintFrm

    Private Sub ReportSaleA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub


    Private Sub ReportSaleA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.reportsale' table. You can move, or remove it, as needed.
        Me.reportsaleTableAdapter.Fill(Me.STdata.reportsale)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Dim s_e_date As New ReportParameter("start_end_date", "ระหว่างวันที่  " & ReportSaleFrm.DateTimePicker1.Text & " ถึง " & ReportSaleFrm.DateTimePicker2.Text)
        Dim ttp As New ReportParameter("total", ReportSaleFrm.txtRRrows.Text)
        Dim buy_p As New ReportParameter("buy", ReportSaleFrm.txtRRttp.Text)
        Dim d_count As New ReportParameter("discount", ReportSaleFrm.txtRRttd.Text)
        Dim pt As New ReportParameter("profit", ReportSaleFrm.txtmoney.Text)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {s_e_date, ttp, buy_p, d_count, pt})
    End Sub
End Class