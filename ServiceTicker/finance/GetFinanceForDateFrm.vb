Imports System.Globalization

Public Class GetFinanceForDateFrm

    Private Sub GetFinanceForDateFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub GetFinanceForDateFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.Location = New Point(System.Windows.Forms.Cursor.Position.X - 300, System.Windows.Forms.Cursor.Position.Y - 100)
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(0)
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Call DebtorFrm.startfrm()
        Call DebtorFrm.searchByDate(Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")),
        Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
        Me.Close()
    End Sub
End Class