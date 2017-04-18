Public Class CheckStoclBarcodeEnterFrm

    Private Sub CheckStoclBarcodeEnterFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckStoclBarcodeEnterFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub txtNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtNum.Text = Nothing Then
                MainFrm.lblMainStatus.Text = "กรุณาใส่ตัวเลขด้วย"
            Else
                Call fdg()
            End If
        End If
    End Sub
    Private Sub fdg()
        If CheckStoclBarcodeFrm.scc = 100 Then
            CheckStoclBarcodeFrm.dgCSBC.CurrentRow.Cells(6).Value = CheckStoclBarcodeFrm.dgCSBC.CurrentRow.Cells(6).Value + CDec(Me.txtNum.Text)
            Me.Close()
        ElseIf CheckStoclBarcodeFrm.scc = 200 Then
            CheckStoclBarcodeFrm.dgCSBC.CurrentRow.Cells(6).Value = CheckStoclBarcodeFrm.dgCSBC.CurrentRow.Cells(6).Value - CDec(Me.txtNum.Text)
            Me.Close()
        End If
    End Sub
    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Me.txtNum.SelectAll()
                Me.txtNum.Focus()
        End Select
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Me.txtNum.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ตัวเลขด้วย", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Call fdg()
        End If
    End Sub
End Class