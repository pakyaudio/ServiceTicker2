Imports Microsoft.Reporting.WinForms

Public Class ReportRepairA5PrintFrm
    Dim sed As String

    Private Sub ReportRepairA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReportRepairA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.reportrepair' table. You can move, or remove it, as needed.
        Me.reportrepairTableAdapter.Fill(Me.STdata.reportrepair)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        If ReportRepairFrm.cbbRRcashstatus.Text = "ชำระเงิน(เลือกตามวันที่)" Then
            sed = "ระหว่างวันที่  " & ReportRepairFrm.DateTimePicker1.Text & " ถึง " & ReportRepairFrm.DateTimePicker2.Text
        ElseIf ReportRepairFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(เลือกตามวันที่)" Then
            sed = "ระหว่างวันที่  " & ReportRepairFrm.DateTimePicker1.Text & " ถึง " & ReportRepairFrm.DateTimePicker2.Text
        ElseIf ReportRepairFrm.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
            sed = "วันที่ " & Now.ToString("dd MMMM yyyy")
        ElseIf ReportRepairFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
            sed = "วันที่ " & Now.ToString("dd MMMM yyyy")
        End If



        Dim s_e_date As New ReportParameter("start_end_date", sed)
        Dim ttp As New ReportParameter("total_pro", ReportRepairFrm.txtRRrows.Text)
        Dim buy_p As New ReportParameter("buy", ReportRepairFrm.txtRRttp.Text)
        Dim d_count As New ReportParameter("discount", ReportRepairFrm.txtRRttd.Text)
        Dim pt As New ReportParameter("profit", ReportRepairFrm.txtmoney.Text)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {s_e_date, ttp, buy_p, d_count, pt})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class