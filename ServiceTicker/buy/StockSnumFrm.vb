Public Class StockSnumFrm

    Private Sub StockSnumFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub StockSnumFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SelectOK()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSSok_Click(sender As Object, e As EventArgs) Handles btnSSok.Click
        Call SelectOK()
    End Sub
    Private Sub SelectOK()
        OrderFrm.r = OrderFrm.tbl.NewRow
        OrderFrm.r.Item(0) = StockFrm.dgStock.CurrentRow.Cells(1).Value
        OrderFrm.r.Item(1) = StockFrm.dgStock.CurrentRow.Cells(2).Value
        OrderFrm.r.Item(2) = StockFrm.dgStock.CurrentRow.Cells(3).Value
        OrderFrm.r.Item(3) = StockFrm.dgStock.CurrentRow.Cells(4).Value
        OrderFrm.r.Item(4) = StockFrm.dgStock.CurrentRow.Cells(5).Value
        OrderFrm.r.Item(5) = NumericUpDown1.Value
        OrderFrm.r.Item(6) = StockFrm.dgStock.CurrentRow.Cells(3).Value
        OrderFrm.tbl.Rows.Add(OrderFrm.r)
        Call OrderFrm.sum_dgOR()
        Call StockFrm.numOK()
        Me.Close()
    End Sub
End Class