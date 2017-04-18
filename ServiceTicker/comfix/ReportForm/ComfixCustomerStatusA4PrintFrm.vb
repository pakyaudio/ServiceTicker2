Imports Microsoft.Reporting.WinForms

Public Class ComfixCustomerStatusA4PrintFrm
    Dim sed As String

    Private Sub ComfixCustomerStatusA4PrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ComfixCustomerStatusA4PrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'STdata.comfixcustomerstatus' table. You can move, or remove it, as needed.
        Me.comfixcustomerstatusTableAdapter.Fill(Me.STdata.comfixcustomerstatus)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        If ComfixCustomerStatusFrm.CheckBox1.CheckState = CheckState.Checked Then
            sed = "ระหว่างวันที่  " & ComfixCustomerStatusFrm.DateTimePicker1.Text & " ถึง " & ComfixCustomerStatusFrm.DateTimePicker2.Text
        ElseIf ComfixCustomerStatusFrm.CheckBox1.CheckState = CheckState.Unchecked Then
            sed = ""
        End If
        Dim s_e_date As New ReportParameter("start_end_date", sed)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {s_e_date})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class