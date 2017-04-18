Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Threading
Imports System.ComponentModel


Public Class BackupDatabaseUpdateFrm
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
    End Sub
  

    Private Sub BackupDatabaseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetData()
        If MessageBox.Show(Me, "เนื่องจากต้องมีการปรับปรุงฐานข้อมูล คุณต้องการจะสำรองฐานข้อมูลก่อนการปรับปรุงหรือไม่", "สำรองข้อมูล",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Timer1.Start()
            trd = New Thread(AddressOf bak)
            trd.IsBackground = True
            trd.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private comp As Boolean
    Private fcheck As String
    Private Sub bak()
        Dim di As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\BackupDB")
        '*** Create Folder ***'
        If Not di.Exists Then
            di.Create()
        End If
        If Not System.IO.File.Exists(Application.StartupPath & "\mysqldump.exe") Then
            Call LoadResourceToDisk(My.Resources.mysqldump, Application.StartupPath & "\mysqldump.exe")
        End If
        Dim filePath As String = Application.StartupPath & "\BackupDB" & "\DatabaseBackup" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".sql"
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

    Private Sub mess()
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Backup.bat")
        Me.Close()
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
            Call mess()
        End If
    End Sub
End Class