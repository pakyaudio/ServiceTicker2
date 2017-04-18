Public Class UsersOldPWFrm

    Private Sub UsersOldPWFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub UsersOldPWFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub txtOldPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOldPassword.KeyDown
        If Me.txtOldPassword.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Call checkPW()
            End If
        End If
    End Sub

    Protected Sub checkPW()
        Try
            strSQL = "SELECT user_name FROM users WHERE user_id='" & UsersFrm.txtUserID.Text & "' AND user_password='" & Me.txtOldPassword.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Call UsersFrm.EditDataNewPassword()
                Me.Close()
            Else
                MessageBox.Show(Me, "รหัสผ่านไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtOldPassword.Text = Nothing
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Me.txtOldPassword.Text <> Nothing Then
                Call checkPW()
        End If
    End Sub
End Class