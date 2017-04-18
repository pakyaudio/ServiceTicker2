Public Class ShelfPrintFrm

    Private Sub ShelfPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'Picture_allDataSet.picture_all' table. You can move, or remove it, as needed.
        Me.picture_allTableAdapter.FillBykey_pic(Me.Picture_allDataSet.picture_all, "shelfFrm")
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class