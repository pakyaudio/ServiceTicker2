Public Class productDetailSearchFrm

    Private Sub productDetailSearchFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub productDetailSearchFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtsearch.Clear()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtsearch.Text <> Nothing Then
                Call ProductDetailFrm.SearchProduct(Me.txtsearch.Text, "search")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnPDSsearchByProNoME_Click(sender As Object, e As EventArgs) Handles btnPDSsearchByProNoME.Click
        Call ProductDetailFrm.SearchProduct(Nothing, "all")
        Me.Close()
    End Sub

    Private Sub btnPDSsearchByProME_Click(sender As Object, e As EventArgs) Handles btnPDSsearchByProME.Click
        Call ProductDetailFrm.SearchProduct(Nothing, "me")
        Me.Close()
    End Sub

    Private Sub btnPDSsearchByUpdate_Click(sender As Object, e As EventArgs) Handles btnPDSsearchByUpdate.Click
        Call ProductDetailFrm.SearchProduct(Nothing, "date")
        Me.Close()
    End Sub

    Private Sub btnPDSsearch_Click(sender As Object, e As EventArgs) Handles btnPDSsearch.Click
        If Me.txtsearch.Text <> Nothing Then
            Call ProductDetailFrm.SearchProduct(Me.txtsearch.Text, "search")
            Me.Close()
        End If
    End Sub
End Class