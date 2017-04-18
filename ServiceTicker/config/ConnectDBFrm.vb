Imports MySql.Data.MySqlClient

Public Class ConnectDBFrm
    Private Function StrToHex(ByRef Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & sVal
        End While
        Return sHex
    End Function

    Private Function HexToStr(ByVal Data As String) As String
        Dim com As String = String.Empty
        For x = 0 To Data.Length - 1 Step 2
            com &= ChrW(CInt("&H" & Data.Substring(x, 2)))
        Next
        Return com
    End Function

    Dim FileConfigINI = Application.StartupPath + "\CONFIG.ini"
    Private Sub btnDBCsave_Click(sender As Object, e As EventArgs) Handles btnDBCsave.Click
        Try
            writeIni(FileConfigINI, "database_config", "server", StrToHex(Me.txtDBCservername.Text))
            writeIni(FileConfigINI, "database_config", "data_base_name", StrToHex(Me.cbbDataBaseName.Text))
            writeIni(FileConfigINI, "database_config", "data_base_user", StrToHex(Me.txtDBCusername.Text))
            writeIni(FileConfigINI, "database_config", "data_base_password", StrToHex(Me.txtDBCpassword.Text))
            writeIni(FileConfigINI, "database_config", "data_base_port", StrToHex(Me.txtDBCport.Text))
            Call ReloadConfig()
            MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "การบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, "ไม่สามารถบันทึกข้อมูลได้ " & ex.Message, "การบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        MessageBox.Show(Me, "โปรแกรมจะปิดตัวเอง กรุณาเปิดโปรแกรมใหม่", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.ExitThread()
        Process.Start(Application.StartupPath & "\ServiceTicker.exe")
    End Sub

    Private Sub btnDBCtest_Click(sender As Object, e As EventArgs) Handles btnDBCtest.Click
        Try
            Dim server As String = Me.txtDBCservername.Text
            Dim database As String = Me.cbbDataBaseName.Text
            Dim user As String = Me.txtDBCusername.Text
            Dim password As String = Me.txtDBCpassword.Text
            Dim port As String = Me.txtDBCport.Text
            Dim testdata As String = "Server='" & server & "';Port='" & port & "';Database='" & database & "';Uid='" & user & "';Pwd='" & password & "';"
            Dim testConnectionDB As New MySqlConnection(testdata)

            cmd = New MySqlCommand("SELECT * FROM database_version;", testConnectionDB)
            If testConnectionDB.State = ConnectionState.Open Then testConnectionDB.Close()
            testConnectionDB.Open()
            Dr = cmd.ExecuteReader
            MessageBox.Show(Me, "สามารถเชื่อมต่อ Server ได้และใช้ฐานข้อมูลนี้ได้", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If testConnectionDB.State = ConnectionState.Open Then testConnectionDB.Close()
        Catch ex As MySqlException
            Select Case ex.Number
                Case 1042
                    MessageBox.Show(Me, "เชื่อมต่อ Server ไม่ได้ ตรวจสอบว่าข้อมูลการเชื่อมต่อถูกต้อง ฐานข้อมูลทำงานหรือไม่", "เชื่อมต่อ Server ไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 1146
                    MessageBox.Show(Me, "สามารถเชื่อมต่อ Server ได้ แต่ไม่สามารถใช้ฐานข้อมูลนี้ได้", "ฐานข้อมูลเข้ากันไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        End Try
    End Sub

    Private Sub ReloadConfig()
        Try
            Me.txtDBCservername.Text = HexToStr(ReadIni(FileConfigINI, "database_config", "server", ""))
            Me.cbbDataBaseName.Text = HexToStr(ReadIni(FileConfigINI, "database_config", "data_base_name", ""))
            Me.txtDBCusername.Text = HexToStr(ReadIni(FileConfigINI, "database_config", "data_base_user", ""))
            Me.txtDBCpassword.Text = HexToStr(ReadIni(FileConfigINI, "database_config", "data_base_password", ""))
            Me.txtDBCport.Text = HexToStr(ReadIni(FileConfigINI, "database_config", "data_base_port", ""))
        Catch ex As Exception
            MessageBox.Show(Me, "ไม่สามารถอ่านข้อมูลได้ เกิดข้อผิดพลาด", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConnectDBFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each form In My.Application.OpenForms
            If (form.name = MainFrm.Name) Then
                If form.Visible Then
                    Me.Dispose()
                    OnTopFrm()
                    Exit Sub
                End If
            End If
        Next
        Application.ExitThread()
    End Sub

    Private Sub ConnectDBFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.db_active
        Call ReloadConfig()
    End Sub

    Private Sub btnSearchComputer_Click(sender As Object, e As EventArgs) Handles btnSearchComputer.Click
        NetworksSearchFrm.ShowDialog(Me)
    End Sub

    Private Sub cbbDataBaseName_DropDown(sender As Object, e As EventArgs) Handles cbbDataBaseName.DropDown
        Try
            Dim server As String = Me.txtDBCservername.Text
            Dim user As String = Me.txtDBCusername.Text
            Dim password As String = Me.txtDBCpassword.Text
            Dim testdata As String = "Server='" & server & "';Uid='" & user & "';Pwd='" & password & "';"
            Dim testConnectionDB As New MySqlConnection(testdata)
            cmd = New MySqlCommand("SHOW DATABASES;", testConnectionDB)
            If testConnectionDB.State = ConnectionState.Open Then testConnectionDB.Close()
            testConnectionDB.Open()
            Dr = cmd.ExecuteReader
            Me.cbbDataBaseName.Items.Clear()
            While Dr.Read
                Me.cbbDataBaseName.Items.Add(Dr.Item(0))
            End While
            If testConnectionDB.State = ConnectionState.Open Then testConnectionDB.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInstallDB_Click(sender As Object, e As EventArgs) Handles btnInstallDB.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/databasemenu/connectdbfrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbbDataBaseName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbDataBaseName.KeyPress
        e.Handled = True
    End Sub
End Class