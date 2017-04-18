Public Class PercenFrm

    Private Sub PercenFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtPCProfit.Text = ReportUserRepairFrm.txtRURtotalProfit.Text
        Me.txtRURperfit.Text = ReportUserRepairFrm.txtRURtotalProfit.Text
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Try
            Me.txtRURperfit.Text = Me.txtPCProfit.Text
            Me.txtPCtt.Text = (CInt(Me.txtPCProfit.Text) / 100) * CInt(Me.NumericUpDown1.Value)
            Me.txtRURtotal.Text = CInt(Me.txtPCProfit.Text) - CInt(Me.txtPCtt.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class