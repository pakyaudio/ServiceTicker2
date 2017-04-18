Imports MySql.Data.MySqlClient

Public Class StartAddNewUserFrm
#Region "Code"
    Private Sub SaveUsersData()
        If txtUsername.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ชื่อจริง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUsername.Focus()
            Me.txtUsername.BackColor = Color.Salmon

        ElseIf txtUserAddress.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ที่อยู่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUserAddress.Focus()
            Me.txtUserAddress.BackColor = Color.Salmon

        ElseIf txtUserTel.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่เบอร์โทรศัพท์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUserTel.Focus()
            Me.txtUserTel.BackColor = Color.Salmon

        ElseIf txtUserEmail.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่อีเมล์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUserEmail.Focus()
            Me.txtUserEmail.BackColor = Color.Salmon

        ElseIf txtUsernamelogin.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ชื่อเข้าระบบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUsernamelogin.Focus()
            Me.txtUsernamelogin.BackColor = Color.Salmon
            Exit Sub

        ElseIf txtUserPassword.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่รหัสผ่าน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUserPassword.Focus()
            Me.txtUserPassword.BackColor = Color.Salmon

        ElseIf Me.txtUserPassword.Text <> Me.txtUserPasswordC.Text Then
            MessageBox.Show(Me, "ยืนยันรหัสผ่านไม่ตรงกัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtUserPasswordC.Focus()
            Me.txtUserPasswordC.BackColor = Color.Salmon
        Else
            'ตรวจชื่อซ้ำ
            Try
                Dim arrImage() As Byte
                If PicUsers.Image Is Nothing Then
                    arrImage = Nothing
                Else
                    Using stream As New IO.MemoryStream
                        Using ibmp As Bitmap = New Bitmap(PicUsers.Image)
                            ibmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp)
                            arrImage = stream.GetBuffer()
                            stream.Close()
                        End Using
                    End Using
                End If
                strSQL = "INSERT INTO users(user_id, user_name, user_address, user_tel, user_email, user_password, user_usernamelogin, user_leval,images)" _
                    & "VALUES('" & Me.txtUserID.Text & "','" & Me.txtUsername.Text & "','" & Me.txtUserAddress.Text & "','" & Me.txtUserTel.Text & "'," _
                    & "'" & Me.txtUserEmail.Text & "','" & Me.txtUserPassword.Text & "','" & Me.txtUsernamelogin.Text & "','3',@img )"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@img", arrImage)
                Call open_connection()
                saveMess = cmd.ExecuteNonQuery()

                If saveMess = 1 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    arrImage = Nothing
                    Me.Close()
                Else
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub startfrm()
        PicUsers.Image = Nothing
        Me.txtUserID.Clear()
        Me.txtUsername.Clear()
        Me.txtUserAddress.Clear()
        Me.txtUserTel.Clear()
        Me.txtUserEmail.Clear()
        Me.txtUsernamelogin.Clear()
        Me.txtUserPassword.Clear()
        Me.txtUserPasswordC.Clear()
        Call ALLAutonumber("ver_user", Me.txtUserID.Text)
    End Sub
#End Region

    Private Sub btnselectImage_Click(sender As Object, e As EventArgs) Handles btnselectImage.Click
        CameraCaptureAddNewuserFrm.ShowDialog(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveUsersData()
    End Sub

    Private Sub StartAddNewUserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
    End Sub
End Class