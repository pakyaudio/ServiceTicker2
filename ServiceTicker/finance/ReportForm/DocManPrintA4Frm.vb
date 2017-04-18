Public Class DocManPrintA4Frm

    Private Sub DocManPrintA4Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Friend paid As Integer
    Private Sub DocManPrintA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'Picture_allDataSet.picture_all' table. You can move, or remove it, as needed.
        Me.picture_allTableAdapter.FillBypa_id(Me.Picture_allDataSet.picture_all, paid)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    
End Class