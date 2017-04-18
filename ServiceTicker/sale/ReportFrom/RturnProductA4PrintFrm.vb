Imports Microsoft.Reporting.WinForms

Public Class RturnProductA4PrintFrm
    Dim DateTime As String

    Private Sub RturnProductA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub RturnProductA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.returnproductall' table. You can move, or remove it, as needed.
        Me.returnproductallTableAdapter.Fill(Me.STdata.returnproductall)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        If ReturnProdductReportFrm.cbbRRcashstatusAll.Text = "ยังไม่ชำระเงิน" Then
            DateTime = "สถานะสินค้ายังไม่ชำระเงิน ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1All.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2All.Text
        ElseIf ReturnProdductReportFrm.cbbRRcashstatusAll.Text = "ชำระเงิน" Then
            DateTime = "สถานะสินค้าชำระเงิน ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1All.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2All.Text
        ElseIf ReturnProdductReportFrm.cbbRRcashstatusAll.Text = "ทั้งหมด" Then
            DateTime = "สถานะสินค้าทั้งหมด ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1All.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2All.Text
        End If

        Dim u_datetime As New ReportParameter("start_end_date", DateTime)
        Dim u_totalpro As New ReportParameter("row", ReturnProdductReportFrm.txtRRrowsALL.Text)
        Dim st_money As New ReportParameter("money", ReturnProdductReportFrm.txtmoneyALL.Text)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class