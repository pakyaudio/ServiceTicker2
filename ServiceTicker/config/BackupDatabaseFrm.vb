Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Threading
Imports System.ComponentModel


Public Class BackupDatabaseFrm
#Region "Code"
    ' Load Resource To Disk
    ' ( By Elektro )
    '
    ' Usage Examples:
    ' LoadResourceToDisk(My.Resources.Program, "C:\Program.exe")
    ' Process.Start("C:\Program.exe")
    '
    ''' <summary>
    ''' Loads a resource to disk.
    ''' </summary>
    ''' <param name="Resource">
    ''' Indicates the resource to load.
    ''' </param>
    ''' <param name="TargetFile">
    ''' Indicates the target file to save the resource.
    ''' The target file is overwritten.
    ''' </param>
    ''' <returns>
    ''' <c>true</c> if operation succeeds, <c>false</c> otherwise.
    ''' </returns>
    ''' <exception cref="Exception"></exception>
    Private Function LoadResourceToDisk(ByVal Resource As Byte(),
                                        ByVal TargetFile As String) As Boolean
        Try
            Dim BufferFileStream As New IO.FileStream(TargetFile, IO.FileMode.Create, IO.FileAccess.Write)
            BufferFileStream.Write(Resource, 0, Resource.Length)
            BufferFileStream.Close()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
            Return False
        End Try
    End Function
#End Region

    Private Sub BackupDatabaseFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub startf()
        Me.btnStop.Text = "หยุด"
        Me.btnBDsave.Enabled = False
        Me.btnBDselectFolder.Enabled = False
        Me.btnHelp.Enabled = False
        Me.btExport.Enabled = False
        ProgressBar1.Value = 0
        Me.Timer1.Start()
        MainFrm.Enabled = False
    End Sub

    Private Sub exSt()
        Me.btnStop.Text = "ปิด"
        Me.btnBDsave.Enabled = True
        Me.btnBDselectFolder.Enabled = True
        Me.btnHelp.Enabled = True
        Me.btExport.Enabled = True
        Me.Timer1.Stop()
        ProgressBar1.Value = 0
        Me.Label2.Text = ""
        MainFrm.Enabled = True
    End Sub

    Private Sub BackupDatabaseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtBDbackDIR.Text = ReadIni(FileConfigINI_mcode, "backup_path", "path", "")
        Call GetData()
        Me.btnStop.Text = "ปิด"
    End Sub

    Private Sub btnBDselectFolder_Click(sender As Object, e As EventArgs) Handles btnBDselectFolder.Click
        If BackupFolderBrowser.ShowDialog(Me) = DialogResult.OK Then
            Me.txtBDbackDIR.Text = BackupFolderBrowser.SelectedPath
        End If
    End Sub

    Private Sub btnBDsave_Click(sender As Object, e As EventArgs) Handles btnBDsave.Click
        If Me.txtBDbackDIR.Text <> Nothing Then
            writeIni(FileConfigINI_mcode, "backup_path", "path", Me.txtBDbackDIR.Text)
            MessageBox.Show(Me, "บันทึกแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(Me, "กรณุาระบุโฟล์เดอร์สำรองข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If BackupFolderBrowser.ShowDialog(Me) = DialogResult.OK Then
                Me.txtBDbackDIR.Text = BackupFolderBrowser.SelectedPath
                writeIni(FileConfigINI_mcode, "backup_path", "path", Me.txtBDbackDIR.Text)
            End If
        End If
    End Sub

    Private comp As Boolean
    Private fcheck As String
    Private Sub bak()
        If Not System.IO.File.Exists(Application.StartupPath & "\mysqldump.exe") Then
            Call LoadResourceToDisk(My.Resources.mysqldump, Application.StartupPath & "\mysqldump.exe")
        End If
        Dim filePath As String = Me.txtBDbackDIR.Text & "\ServiceTicker_Backup_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-ms") + ".sql"
        fcheck = filePath
        comp = False
        Dim osVer As Version = Environment.OSVersion.Version

        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("@echo off")

        sb.AppendLine("echo Backup MySQL...")
        sb.AppendLine("cd """ & Application.StartupPath & "\""")

        sb.AppendLine("mysqldump" & String.Format(" -h{0} -u{1} -p{2} --max_allowed_packet=1073741824 {3} > """ & filePath & """", server, user, password, database))
        'sb.AppendLine("pause")
        IO.File.WriteAllText(Application.StartupPath & "\Backup.bat", sb.ToString())
        System.IO.File.SetAttributes(Application.StartupPath & "\Backup.bat", IO.FileAttributes.Hidden)
        If osVer.Major < 6 Then
            Try
                Dim runbat As Process = Process.Start(Application.StartupPath & "\Backup.bat")
                runbat.WaitForExit()
                comp = True
            Catch ex As Exception

            End Try
        ElseIf osVer.Major >= 6 Then
            Try
                Dim procInfo As New ProcessStartInfo()
                procInfo.WindowStyle = ProcessWindowStyle.Hidden
                procInfo.UseShellExecute = True
                procInfo.FileName = (Application.StartupPath & "\Backup.bat")
                procInfo.WorkingDirectory = ""
                procInfo.Verb = "runas"
                Dim runbat As Process = Process.Start(procInfo)
                runbat.WaitForExit()
                comp = True
            Catch ex As Exception

            End Try
        End If

    End Sub

    Dim dll As Decimal
    Dim dllTT As Decimal = Nothing
    Dim dllo As String = String.Empty
    Private Sub GetData()
        Try
            cmd = New MySqlCommand("SELECT table_name, table_rows, data_length, index_length," & _
            "Sum(round(((data_length + index_length) / 1024 / 1024), 2)) AS A " & _
            "FROM information_schema.`TABLES` WHERE TABLE_SCHEMA='serviceticker';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            dll = Dr.Item("A")
            If dll > 1024 Then
                dllTT = dll / 1024
                dllo = dllTT.ToString("N2") & " GB"
            ElseIf dll > 10240 Then
                dllTT = dll / 1024 / 1024
                dllo = dllTT.ToString("N2") & " TB"
            ElseIf dll < 1024 Then
                dllTT = dll
                dllo = dllTT.ToString("N2") & " MB"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.Label1.Text = "ขนาดฐานข้อมูลทั้งหมดที่จะสำรอง " & dllo
    End Sub
    Private trd As Thread
    'Private CurrentBackUp As MySqlBackUp.BackUp '
    'Private CurrentRestore As MySqlBackUp.Restore
    'Private BackUpFileName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btExport.Click
        Dim di As DirectoryInfo = New DirectoryInfo(Me.txtBDbackDIR.Text)
        '*** Create Folder ***'
        If Not di.Exists Then
            If MessageBox.Show("ไม่พบโฟล์เดอร์ " & Me.txtBDbackDIR.Text & " ต้องการจะสร้างใหม่หรือไม่ ", "ไม่พบโฟล์เดอร์", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Try
                    di.Create()
                Catch ex As Exception
                    MsgBox("ไม่สามารถสร้างโฟล์เดอร์ " & Me.txtBDbackDIR.Text & " ได้" & vbNewLine & "กรุณาเลือกไดร์ที่ต้องการเก็บไฟล์สำรองข้อมูล", MsgBoxStyle.Critical, "สร้างโฟล์เดอร์ไม่ได้")
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
        If dll > 1024 Then
            If MessageBox.Show(Me, "คำเตือน ฐานข้อมูลมีขนาดใหญ่อาจจะใช้เวลานานในการสำรองข้อมูล ต้องการจะทำต่อหรือไม่", "ข้อมูลมีขนาดใหญ่",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                Call startf()
                trd = New Thread(AddressOf bak)
                trd.IsBackground = True
                trd.Start()
            End If
        Else
            Call startf()
            trd = New Thread(AddressOf bak)
            trd.IsBackground = True
            trd.Start()

        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/databasemenu/backupdatabasefrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If Me.btnStop.Text = "หยุด" Then
            comp = False
            Try
                Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("mysqldump")
                For Each p As Process In arrProcess
                    p.Kill()
                Next
                Dim ab() As Process = System.Diagnostics.Process.GetProcessesByName("runbat")
                For Each p As Process In ab
                    p.Kill()
                Next

                trd.Abort()
                Timer1.Stop()
                Call exSt()
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Backup.bat")
                MessageBox.Show(Me, "หยุดการสำรองข้อมูลแล้ว", "หยุด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception

            End Try
        ElseIf Me.btnStop.Text = "ปิด" Then
            Me.Close()
        End If
    End Sub

    Private Sub mess()
        MessageBox.Show(Me, "สำรองข้อมูลเสร็จแล้ว", "สำรองข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Backup.bat")
    End Sub

    Dim bbs As String
    Dim bbc As Decimal
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim infoReader As System.IO.FileInfo
            infoReader = My.Computer.FileSystem.GetFileInfo(fcheck)
            Dim bb As Decimal = infoReader.Length / 1024 / 1024
            ProgressBar1.Value = (bb * 100) / dll

            If bb > 1024 Then
                bbc = bb / 1024
                bbs = bbc.ToString("N2") & " GB"
            ElseIf bb > 10240 Then
                bbc = bb / 1024 / 1024
                bbs = bbc.ToString("N2") & " TB"
            ElseIf bb < 1024 Then
                bbc = bb
                bbs = bbc.ToString("N2") & " MB"
            End If
            Me.Label2.Text = bbs & " of " & dllo
        Catch ex As Exception

        End Try
        If comp = True Then
            Timer1.Stop()
            Call exSt()
            Call mess()
        End If
    End Sub
End Class