Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.ServiceProcess
Imports System.Threading


Public NotInheritable Class SplashScreen1
    Private Sub SplashScreen1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

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

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = My.Application.Info.Version.Major & "." &
            My.Application.Info.Version.Minor & "." &
            My.Application.Info.Version.Build & "." &
            My.Application.Info.Version.Revision

        'Copyright info
        Copyright.Text = "Free Software By P A Tech Group"

    End Sub
    Private Sub coderun()
        Application.CurrentCulture = New CultureInfo("th-TH")
        Application.DoEvents()
        Try
            Dim FILEsqlite As String
            FILEsqlite = Application.StartupPath & "\IDAutomationHC39M.ttf"
            If File.Exists(FILEsqlite) = False Then
                Me.lblLoad.Text = "ไม่พบ Fonts"
                IO.File.WriteAllBytes(FILEsqlite, My.Resources.IDAutomationHC39M)
            End If
        Catch ex As Exception

        End Try

        Me.ProgressBar1.Value = 0
        Me.lblLoad.Text = "ตรวจสอบไฟล์ตั้งค่าโปรแกรม"
        Me.ProgressBar1.Value = 10
        'ตรวจสอบไฟล์ CONFIG.ini 
        Try
            Dim FILEINI As String
            FILEINI = Application.StartupPath & "\CONFIG.ini"
            If File.Exists(FILEINI) = False Then
                'Me.lblLoad.Text = "ไม่พบไฟล์สำหรับตั้งค่า"
                IO.File.WriteAllText(FILEINI, My.Resources.CONFIG)
                Application.ExitThread()
                Process.Start(Application.StartupPath & "\ServiceTicker.exe")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        Me.ProgressBar1.Value = 20
        Me.lblLoad.Text = "ตรวจสอบไฟล์ฐานข้อมูลชั่วคราว"
        Me.ProgressBar1.Value = 30
        'ตรวจสอบไฟล์ localdb.db 
        Try
            Dim FILEsqlite As String
            FILEsqlite = Application.StartupPath & "\localdb.db"
            If File.Exists(FILEsqlite) = False Then
                'Me.lblLoad.Text = "ไม่พบไฟล์สำหรับฐานข้อมูลชั่วคราว"
                IO.File.WriteAllBytes(FILEsqlite, My.Resources.localdb)
                Application.ExitThread()
                Process.Start(Application.StartupPath & "\ServiceTicker.exe")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        Me.ProgressBar1.Value = 40
        Me.lblLoad.Text = "ตรวจสอบการเชื่อมต่อฐานข้อมูล"
        Me.ProgressBar1.Value = 50
        'ตรวจการเชื่อมต่อ MySQL
        Try
            Dim testConnectionDB As New MySqlConnection(data)
            cmd = New MySqlCommand("SELECT * FROM database_version;", testConnectionDB)
            If testConnectionDB.State = ConnectionState.Open Then testConnectionDB.Close()
            testConnectionDB.Open()
            Dr = cmd.ExecuteReader
            If testConnectionDB.State = ConnectionState.Open Then testConnectionDB.Close()
        Catch ex As MySqlException
            Select Case ex.Number
                Case 1042
                    If MessageBox.Show(Me, "เชื่อมต่อ Server ไม่ได้ ตรวจสอบว่าข้อมูลการเชื่อมต่อถูกต้อง ฐานข้อมูลทำงานหรือไม่", "เชื่อมต่อ Server ไม่ได้",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                        ConnectDBFrm.Show()
                        Me.Close()
                        Exit Sub
                    End If
                Case 1146
                    If MessageBox.Show(Me, "สามารถเชื่อมต่อ Server ได้ แต่ไม่สามารถใช้ฐานข้อมูลนี้ได้ กรุณาเลือกฐานข้อมูลให้ถูกต้อง", "ฐานข้อมูลเข้ากันไม่ได้",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                        ConnectDBFrm.Show()
                        Me.Close()
                        Exit Sub
                    End If
                Case Else
                    If MessageBox.Show(Me, "เชื่อมต่อ Server ไม่ได้ ตรวจสอบว่าข้อมูลการเชื่อมต่อถูกต้อง ฐานข้อมูลทำงานหรือไม่", "เชื่อมต่อ Server ไม่ได้",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                        ConnectDBFrm.Show()
                        Me.Close()
                        Exit Sub
                    End If
            End Select
        End Try
        Me.ProgressBar1.Value = 50
        Me.lblLoad.Text = "ตรวจสอบตรวจสอบรุ่นฐานข้อมูล"
        Me.ProgressBar1.Value = 60
        Call checkDBVersion()
        Me.ProgressBar1.Value = 70
        Me.lblLoad.Text = "ตรวจสอบการตั้งค่าเวลาของเครื่อง"
        Me.ProgressBar1.Value = 80
        If CInt(Now.Year) < 2017 Then
            If MessageBox.Show(Me, "เวลาของระบบไม่เป็นปัจจุบัน กรุณาตั้งวันที่และเวลาให้เป็นปัจจุบัน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                End
            End If
        End If

        Me.ProgressBar1.Value = 90
        Try
            strSQL = "SELECT COUNT(user_id) AS UID FROM users;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim cr As Integer
            cr = cmd.ExecuteScalar()
            If cr = 0 Then
                StartAddNewUserFrm.ShowDialog(Me)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.ProgressBar1.Value = 100
        Me.lblLoad.Text = "เปิดหน้ายืนยันตัวตน"
        LoginFrm.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End
    End Sub

    Private Sub SplashScreen1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        coderun()
    End Sub



End Class
