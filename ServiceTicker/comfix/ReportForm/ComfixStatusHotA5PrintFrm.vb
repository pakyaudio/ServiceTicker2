Imports Microsoft.Reporting.WinForms

Public Class ComfixStatusHotA5PrintFrm
    Dim sed As String

    Private Sub ComfixStatusHotA5PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ComfixStatusHotA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.comfixcustomerstatus_t2' table. You can move, or remove it, as needed.
        Me.comfixcustomerstatus_t2TableAdapter.Fill(Me.STdata.comfixcustomerstatus_t2)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        Me.Icon = MainFrm.Icon


        If ComfixCustomerStatusFrm.CheckBox1.CheckState = CheckState.Checked Then
            sed = "ระหว่างวันที่  " & ComfixCustomerStatusFrm.DateTimePicker1.Text & " ถึง " & ComfixCustomerStatusFrm.DateTimePicker2.Text
        ElseIf ComfixCustomerStatusFrm.CheckBox1.CheckState = CheckState.Unchecked Then
            sed = ""
        End If
        Dim s_e_date As New ReportParameter("start_end_date", sed)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {s_e_date})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class