Public Class NumberPadFrm

    Private Sub NumberPadFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub NumberPadFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = 8 Then
            If Me.txtNum.Text.Count > 0 Then
                Me.txtNum.Text = Me.txtNum.Text.Remove(Me.txtNum.Text.Count - 1)
            End If
        End If
        If e.KeyCode = Keys.Decimal Then
            Me.txtNum.Text = Me.txtNum.Text + "."
        End If
        If e.KeyCode = Keys.NumPad0 Then
            Me.txtNum.Text = Me.txtNum.Text + "0"
        End If
        If e.KeyCode = Keys.NumPad1 Then
            Me.txtNum.Text = Me.txtNum.Text + "1"
        End If
        If e.KeyCode = Keys.NumPad2 Then
            Me.txtNum.Text = Me.txtNum.Text + "2"
        End If
        If e.KeyCode = Keys.NumPad3 Then
            Me.txtNum.Text = Me.txtNum.Text + "3"
        End If
        If e.KeyCode = Keys.NumPad4 Then
            Me.txtNum.Text = Me.txtNum.Text + "4"
        End If
        If e.KeyCode = Keys.NumPad5 Then
            Me.txtNum.Text = Me.txtNum.Text + "5"
        End If
        If e.KeyCode = Keys.NumPad6 Then
            Me.txtNum.Text = Me.txtNum.Text + "6"
        End If
        If e.KeyCode = Keys.NumPad7 Then
            Me.txtNum.Text = Me.txtNum.Text + "7"
        End If
        If e.KeyCode = Keys.NumPad8 Then
            Me.txtNum.Text = Me.txtNum.Text + "8"
        End If
        If e.KeyCode = Keys.NumPad9 Then
            Me.txtNum.Text = Me.txtNum.Text + "9"
        End If
        If e.KeyCode = Keys.Enter Then
            Call keyEnter()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.txtNum.Clear()
        End If
    End Sub

    Private Sub NumberPadFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Me.txtNum.Text = Me.txtNum.Text + "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Me.txtNum.Text = Me.txtNum.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Me.txtNum.Text = Me.txtNum.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Me.txtNum.Text = Me.txtNum.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.txtNum.Text = Me.txtNum.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Me.txtNum.Text = Me.txtNum.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Me.txtNum.Text = Me.txtNum.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Me.txtNum.Text = Me.txtNum.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Me.txtNum.Text = Me.txtNum.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Me.txtNum.Text = Me.txtNum.Text + "9"
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        Me.txtNum.Text = Me.txtNum.Text + "."
    End Sub

    Private Sub keyEnter()
        Try
            If Me.txtNum.Text = Nothing Then
                CashSaleFrm.txtCashCusPrice.Text = 0.0
            Else
                Dim txt As Decimal = Trim(Me.txtNum.Text)
                CashSaleFrm.txtCashCusPrice.Text = txt.ToString("N2")
                Me.Close()
            End If
           
        Catch ex As Exception
            MessageBox.Show(Me, "ใส่ตัวเลขให้ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Call keyEnter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txtNum.Text.Count > 0 Then
            Me.txtNum.Text = Me.txtNum.Text.Remove(Me.txtNum.Text.Count - 1)
        End If
    End Sub

    Private Sub btnESC_Click(sender As Object, e As EventArgs) Handles btnESC.Click
        Me.txtNum.Clear()
    End Sub
End Class