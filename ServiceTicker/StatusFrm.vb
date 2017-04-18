Imports System.IO

Public Class StatusFrm

    Private Sub StatusFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        OnTopFrm()
    End Sub

    Private Sub StatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
End Class