Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class UsersFrm

    Private Sub UsersFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub UsersFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetAllData()
        Call startfrm()
    End Sub
    Dim uid As String
    Private Sub AutoNumberNo()
        Call ALLAutonumber("ver_user", uid)
        Me.txtUserID.Text = uid
    End Sub
    Private Sub startfrm()
        PicUsers.Image = Nothing
        Call ClearTextBoxes(Me)
        Me.dgUser.ClearSelection()
        Me.dgUser.Enabled = True
        Me.NewToolStripButton.Enabled = True
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = False
        Me.CancelStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.btnselectImage.Enabled = False
        Me.ZoomStripButton.Enabled = False

        Me.txtUserID.Clear()
        Me.txtUsername.Clear()
        Me.txtUserAddress.Clear()
        Me.txtUserTel.Clear()
        Me.txtUserEmail.Clear()
        Me.txtUsernamelogin.Clear()
        Me.txtUserPassword.Clear()
        Me.txtUserPasswordC.Clear()

        Me.txtUsername.Enabled = False
        Me.txtUserAddress.Enabled = False
        Me.txtUserTel.Enabled = False
        Me.txtUserEmail.Enabled = False
        Me.txtUsernamelogin.Enabled = False
        Me.txtUserPassword.Enabled = False
        Me.txtUserPasswordC.Enabled = False

        Me.RB1.Enabled = False
        Me.RB2.Enabled = False
        Me.RB3.Enabled = False
        Me.RB1.Checked = True

    End Sub

    Private Sub GetAllData()
        Try
            Me.dgUser.Rows.Clear()
            cmd = New MySqlCommand("SELECT user_id,user_name,user_address,user_tel,user_email,user_usernamelogin,user_leval FROM users", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgUser
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.GetString("user_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("user_name")
                    .Rows(r).Cells(3).Value = Dr.GetString("user_address")
                    .Rows(r).Cells(4).Value = Dr.GetString("user_tel")
                    .Rows(r).Cells(5).Value = Dr.GetString("user_email")
                    .Rows(r).Cells(6).Value = Dr.GetString("user_usernamelogin")
                    If Dr.GetString("user_leval") = "1" Then
                        .Rows(r).Cells(7).Value = "ผู้ใช้งาน"
                    ElseIf Dr.GetString("user_leval") = "2" Then
                        .Rows(r).Cells(7).Value = "หัวหน้า"
                    ElseIf Dr.GetString("user_leval") = "3" Then
                        .Rows(r).Cells(7).Value = "ผู้ดูแลระบบ"
                    End If
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getDataByRow()
        Try
            If Me.dgUser.Rows.Count <> 0 Then
                Me.NewToolStripButton.Enabled = True
                Me.EditToolStripButton.Enabled = True
                Me.DeleteToolStripButton.Enabled = True
                Me.BackToolStripButton.Enabled = True
                Me.NextToolStripButton.Enabled = True
                Me.ZoomStripButton.Enabled = True


                PicUsers.Image = Nothing
                PicUsers.BackColor = Color.Empty
                PicUsers.Invalidate()
                With Me.dgUser
                    Me.txtUserID.Text = .CurrentRow.Cells(1).Value
                    Me.txtUsername.Text = .CurrentRow.Cells(2).Value
                    Me.txtUserAddress.Text = .CurrentRow.Cells(3).Value
                    Me.txtUserTel.Text = .CurrentRow.Cells(4).Value
                    Me.txtUserEmail.Text = .CurrentRow.Cells(5).Value
                    Me.txtUsernamelogin.Text = .CurrentRow.Cells(6).Value
                    If .CurrentRow.Cells(7).Value = "ผู้ใช้งาน" Then
                        Me.RB1.Checked = True
                    ElseIf .CurrentRow.Cells(7).Value = "หัวหน้า" Then
                        Me.RB2.Checked = True
                    ElseIf .CurrentRow.Cells(7).Value = "ผู้ดูแลระบบ" Then
                        Me.RB3.Checked = True
                    End If
                    Try
                        cmd = New MySqlCommand("SELECT images FROM users WHERE user_id='" & .CurrentRow.Cells(1).Value & "'", ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        If Dr.HasRows Then
                            PicUsers.Image = Byte2Image(Dr.Item("images"))
                        Else
                            PicUsers.Image = Nothing
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End With
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Dim leval As String
    Private Sub CheckNullPassword()
        If Me.txtUserPassword.Text <> Nothing Or Me.txtUserPasswordC.Text <> Nothing Then
            If Me.txtUserPassword.Text = Me.txtUserPasswordC.Text Then
                UsersOldPWFrm.ShowDialog(Me)
            Else
                MessageBox.Show(Me, "ยืนยันรหัสไม่ตรงกัน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Exit Sub
            End If
        Else
            Call EditDataOldPassword()
        End If
    End Sub
    Friend Sub EditDataNewPassword()
        If RB1.Checked = True Then
            leval = "1"
        ElseIf RB2.Checked = True Then
            leval = "2"
        ElseIf RB3.Checked = True Then
            leval = "3"
        End If
        Try

            cmd = New MySqlCommand("UPDATE users SET user_name='" & Me.txtUsername.Text & "'," _
               & "user_address='" & Me.txtUserAddress.Text & "', user_tel='" & Me.txtUserTel.Text & "'," _
               & "user_email='" & Me.txtUserEmail.Text & "', user_usernamelogin='" & Me.txtUsernamelogin.Text & "'," _
               & "user_password='" & Me.txtUserPassword.Text & "',user_leval='" & leval & "' WHERE user_id='" & Me.txtUserID.Text & "'", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            cmd = New MySqlCommand("UPDATE users SET images=@img WHERE user_id='" & Me.txtUserID.Text & "'", ConnectionDB)
            Using stream As New IO.MemoryStream
                Using ibmp As Bitmap = New Bitmap(PicUsers.Image)
                    ibmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp)
                    cmd.Parameters.AddWithValue("@img", stream.GetBuffer())
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    stream.Close()
                End Using
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call GetAllData()
        Call startfrm()
    End Sub

    Friend Sub EditDataOldPassword()
        If RB1.Checked = True Then
            leval = "1"
        ElseIf RB2.Checked = True Then
            leval = "2"
        ElseIf RB3.Checked = True Then
            leval = "3"
        End If
        Try
            cmd = New MySqlCommand("UPDATE users SET user_name='" & Me.txtUsername.Text & "'," _
                & "user_address='" & Me.txtUserAddress.Text & "', user_tel='" & Me.txtUserTel.Text & "'," _
                & "user_email='" & Me.txtUserEmail.Text & "', user_usernamelogin='" & Me.txtUsernamelogin.Text & "'," _
                & "user_leval='" & leval & "' WHERE user_id='" & Me.txtUserID.Text & "'", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            cmd = New MySqlCommand("UPDATE users SET images=@img WHERE user_id='" & Me.txtUserID.Text & "'", ConnectionDB)
            Using stream As New IO.MemoryStream
                Using ibmp As Bitmap = New Bitmap(PicUsers.Image)
                    ibmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp)
                    cmd.Parameters.AddWithValue("@img", stream.GetBuffer())
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    stream.Close()
                End Using
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call GetAllData()
        Call startfrm()
    End Sub

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
                strSQL = ("SELECT user_usernamelogin FROM users WHERE user_usernamelogin = '" & Me.txtUsernamelogin.Text & "'")
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.HasRows Then
                    MessageBox.Show(Me, "ชื่อผู้เข้าระบบซ้ำกัน กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtUsernamelogin.Focus()
                    Me.txtUsernamelogin.BackColor = Color.Salmon
                Else
                    'บันทึกข้อมูล
                    If RB1.Checked = True Then
                        leval = "1"
                    ElseIf RB2.Checked = True Then
                        leval = "2"
                    ElseIf RB3.Checked = True Then
                        leval = "3"
                    End If
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
                        & "'" & Me.txtUserEmail.Text & "','" & Me.txtUserPassword.Text & "','" & Me.txtUsernamelogin.Text & "','" & leval & "',@img )"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@img", arrImage)
                    Call open_connection()
                    saveMess = cmd.ExecuteNonQuery()

                    If saveMess = 1 Then
                        MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    arrImage = Nothing
                    Call startfrm()
                    Call GetAllData()
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

        End If
    End Sub

    Private Sub DeleteData()
        If MessageBox.Show(Me, "คุณต้องการจะลบข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MainFrm.lblMainStatus.Text = "ยกเลิกการลบข้อมูล"
        Else
            Try
                cmd = New MySqlCommand("DELETE FROM users WHERE user_id='" & Me.txtUserID.Text & "'", ConnectionDB)
                Call open_connection()
                Dim delAccess As Integer
                delAccess = cmd.ExecuteNonQuery()
                If delAccess = 1 Then
                    MainFrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
                    Call startfrm()
                    Call GetAllData()
                Else
                    MainFrm.lblMainStatus.Text = "ลบข้อมูลไม่สำเร็จ"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ZoomStripButton.Click
        If Not PicUsers.Image Is Nothing Then
            UsersImageZoomFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgUser.CurrentCell = Me.dgUser.Rows(Me.dgUser.CurrentCell.RowIndex + 1).Cells(0)
            Call getDataByRow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgUser.CurrentCell = Me.dgUser.Rows(Me.dgUser.CurrentCell.RowIndex - 1).Cells(0)
            Call getDataByRow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CancelStripButton_Click(sender As Object, e As EventArgs) Handles CancelStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrm()
        End If
    End Sub
    Dim btnset As String
    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        Me.dgUser.Enabled = False
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.btnselectImage.Enabled = True
        Me.ZoomStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelStripButton.Enabled = True

        Me.txtUsername.Enabled = True
        Me.txtUserAddress.Enabled = True
        Me.txtUserTel.Enabled = True
        Me.txtUserEmail.Enabled = True
        Me.txtUsernamelogin.Enabled = True
        Me.txtUserPassword.Enabled = True
        Me.txtUserPasswordC.Enabled = True

        Me.RB1.Enabled = True
        Me.RB2.Enabled = True
        Me.RB3.Enabled = True
        btnset = "edit"
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If MessageBox.Show(Me, "คุณต้องการบันทึก", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If btnset = "edit" Then
                Call CheckNullPassword()
            ElseIf btnset = "new" Then
                Call SaveUsersData()
            End If
        End If
    End Sub

    Private Sub dgUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUser.CellClick
        Call getDataByRow()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Me.dgUser.Enabled = False
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.btnselectImage.Enabled = True
        Me.ZoomStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelStripButton.Enabled = True

        Me.txtUsername.Clear()
        Me.txtUserAddress.Clear()
        Me.txtUserTel.Clear()
        Me.txtUserEmail.Clear()
        Me.txtUsernamelogin.Clear()
        Me.txtUserPassword.Clear()
        Me.txtUserPasswordC.Clear()

        Me.txtUsername.Enabled = True
        Me.txtUserAddress.Enabled = True
        Me.txtUserTel.Enabled = True
        Me.txtUserEmail.Enabled = True
        Me.txtUsernamelogin.Enabled = True
        Me.txtUserPassword.Enabled = True
        Me.txtUserPasswordC.Enabled = True

        Me.RB1.Enabled = True
        Me.RB2.Enabled = True
        Me.RB3.Enabled = True
        Me.RB1.Checked = True
        PicUsers.Image = Nothing
        PicUsers.BackColor = Color.Empty
        PicUsers.Invalidate()
        Call AutoNumberNo()
        btnset = "new"
    End Sub


    Private Sub txtUserName_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        Me.txtUsername.BackColor = SystemColors.Window
    End Sub

    Private Sub txtUserAddress_Click(sender As Object, e As EventArgs) Handles txtUserAddress.Click
        Me.txtUserAddress.BackColor = SystemColors.Window
    End Sub

    Private Sub txtUserTel_Click(sender As Object, e As EventArgs) Handles txtUserTel.Click
        Me.txtUserTel.BackColor = SystemColors.Window
    End Sub

    Private Sub txtUserEmail_Click(sender As Object, e As EventArgs) Handles txtUserEmail.Click
        Me.txtUserEmail.BackColor = SystemColors.Window
    End Sub

    Private Sub txtUsernamelogin_Click(sender As Object, e As EventArgs) Handles txtUsernamelogin.Click
        Me.txtUsernamelogin.BackColor = SystemColors.InactiveCaption
    End Sub

    Private Sub txtUserPassword_Click(sender As Object, e As EventArgs) Handles txtUserPassword.Click
        Me.txtUserPassword.BackColor = SystemColors.InactiveCaption
    End Sub

    Private Sub txtUserPasswordC_Click(sender As Object, e As EventArgs) Handles txtUserPasswordC.Click
        Me.txtUserPasswordC.BackColor = SystemColors.InactiveCaption
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Call DeleteData()
    End Sub

    Private Sub PicUsers_Click(sender As Object, e As EventArgs) Handles PicUsers.Click
        If Not PicUsers.Image Is Nothing Then
            UsersImageZoomFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnselectImage_Click(sender As Object, e As EventArgs) Handles btnselectImage.Click
        CameraCaptureuserFrm.ShowDialog(Me)
    End Sub

    Private Sub btnHelp_Click_1(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/employee")
        Catch ex As Exception

        End Try
    End Sub
End Class