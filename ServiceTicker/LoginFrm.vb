Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class LoginFrm
    Private Sub ok()
        If txtLoginUsername.Text = Nothing Or txtLoginPassword.Text = Nothing Then
            MessageBox.Show(Me, "ใส่ชื่อหรือรหัสผ่านด้วย", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                strSQL = "SELECT * FROM users WHERE user_usernamelogin='" & Me.txtLoginUsername.Text & "' AND user_password = '" & Me.txtLoginPassword.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.Read() Then
                    Dim user_id As String = Dr.Item("user_id")
                    Dim user_name As String = Dr.Item("user_name")
                    Dim user_usernamelogin As String = Dr.Item("user_usernamelogin")
                    Dim date_in As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
                    strSQL = "INSERT INTO applogs(user_id,user_name,user_usernamelogin,note,date_in)VALUES " _
                        & "('" & user_id & "','" & user_name & "','" & user_usernamelogin & "','" & "เข้าโปรแกรม จากเครื่อง " & _
                        SystemInformation.ComputerName & "','" & date_in & "') "
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Me.Hide()
                    MainFrm.Show()
                Else
                    MessageBox.Show(Me, "ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง", "การยืนยันตัวตนผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtLoginUsername.Text = ""
                    Me.txtLoginPassword.Text = ""
                    Me.txtLoginUsername.Focus()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub loadLOGO()
        Try
            strSQL = "SELECT ver_company,ver_version,ver_imglogin FROM ver_detail"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.lblLoginCompanyname.Text = Dr.GetString("ver_company")
            Me.lblLoginVersion.Text = Dr.GetString("ver_version")
            PictureBox1.Image = Byte2Image(Dr.Item("ver_imglogin"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtLoginUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLoginUsername.KeyDown
        If Me.txtLoginUsername.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Me.txtLoginPassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtLoginPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLoginPassword.KeyDown
        If Me.txtLoginPassword.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Call ok()
            End If
        End If
    End Sub

    Private Sub LoginFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub LoginFrm_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/login")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.serviceicon
        Call loadLOGO()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call ok()
    End Sub
End Class