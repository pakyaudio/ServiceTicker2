Public Class ClaimsreceiveGroupAddSNFrm

    Private Sub CKC()
        If Me.rbOldSN.Checked = True Then
            Me.txtNewSN.Enabled = False
            Me.btnOK.Enabled = True
        ElseIf Me.rbNewSN.Checked = True Then
            Me.txtNewSN.Enabled = True
            Me.btnOK.Enabled = True
        End If
    End Sub

    Private Sub rbNewSN_CheckedChanged(sender As Object, e As EventArgs) Handles rbNewSN.CheckedChanged
        Call CKC()
    End Sub

    Private Sub rbOldSN_CheckedChanged(sender As Object, e As EventArgs) Handles rbOldSN.CheckedChanged
        Call CKC()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Me.rbNewSN.Checked = True Then
            If Me.txtNewSN.Text = Nothing Then
                swap = 0
                MessageBox.Show(Me, "กรุณาระบุรหัส SN ใหม่ด้วย", "ใส่ SN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Timer1.Start()
                Me.txtNewSN.Focus()
            Else
                ClaimsreceiveGroupFrm.Stringnewsn = Me.txtNewSN.Text
                Me.Close()
            End If
        ElseIf Me.rbOldSN.Checked = True Then
            ClaimsreceiveGroupFrm.Stringnewsn = Me.txtoldSN.Text
            Me.Close()
        End If
    End Sub
    Dim swap As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.txtNewSN.BackColor = SystemColors.Window Then
            Me.txtNewSN.BackColor = Color.Red
            swap = swap + 1
        Else
            Me.txtNewSN.BackColor = SystemColors.Window
        End If
        If swap = 5 Then
            Me.txtNewSN.BackColor = SystemColors.Window
            Me.Timer1.Stop()
        End If
    End Sub

    Private Sub ClaimsreceiveGroupAddSNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsreceiveGroupAddSNFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.rbNewSN.Checked = True Then
                If Me.txtNewSN.Text = Nothing Then
                    swap = 0
                    MessageBox.Show(Me, "กรุณาระบุรหัส SN ใหม่ด้วย", "ใส่ SN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Timer1.Start()
                    Me.txtNewSN.Focus()
                Else
                    ClaimsreceiveGroupFrm.Stringnewsn = Me.txtNewSN.Text
                    Me.Close()
                End If
            ElseIf Me.rbOldSN.Checked = True Then
                ClaimsreceiveGroupFrm.Stringnewsn = Me.txtoldSN.Text
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ClaimsreceiveGroupAddSNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
End Class