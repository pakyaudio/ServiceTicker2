Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class ImportRestoreDatabaseFrm
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

    Dim dll As Decimal
    Dim dllTT As Decimal = Nothing
    Dim dllo As String = String.Empty
    Dim bbs As String
    Dim bbc As Decimal
    Private Sub GetData()
        Try
            cmd = New MySqlCommand("SELECT DATA_LENGTH, INDEX_LENGTH," & _
            "Sum(round(((DATA_LENGTH + INDEX_LENGTH) / 1024 / 1024), 2)) AS A " & _
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
            Try
                Dim infoReader As System.IO.FileInfo
                infoReader = My.Computer.FileSystem.GetFileInfo(fcheck)
                Dim bb As Decimal = infoReader.Length / 1024 / 1024
                ProgressBar1.Value = (dll * 100) / bb

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

            Catch ex As Exception

            End Try
            Me.Label2.Text = "Imports " & dllo & " of " & bbs
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub Pstart()
        Me.btnIRDBimport.Enabled = False
        Me.btnIRDBstop.Text = "หยุด"
        Me.searchSQLfile.Enabled = False
        MainFrm.Enabled = False
    End Sub

    Private Sub Pstop()
        Me.btnIRDBimport.Enabled = True
        Me.btnIRDBstop.Text = "ปิด"
        Me.searchSQLfile.Enabled = True
        MainFrm.Enabled = True
        Me.Label2.Text = ""
        Me.ProgressBar1.Value = 0
    End Sub

#End Region

    Private Sub ImportRestoreDatabaseFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ImportRestoreDatabaseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.btnIRDBstop.Text = "ปิด"
    End Sub

    Private Sub searchSQLfile_Click(sender As Object, e As EventArgs) Handles searchSQLfile.Click
        If OpenFileDB.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDB.FileName <> "" Then
            Me.txtIRDBpath.Text = OpenFileDB.FileName
        End If
    End Sub
    Private trd As Thread
    Private Sub btnIRDBimport_Click(sender As Object, e As EventArgs) Handles btnIRDBimport.Click
        If Not System.IO.File.Exists(Application.StartupPath & "\mysql.exe") Then
            Call LoadResourceToDisk(My.Resources.mysql, Application.StartupPath & "\mysql.exe")
        End If
        If Me.txtIRDBpath.Text <> Nothing Then
            Dim bb0 As Decimal
            Try
                Dim infoReader As System.IO.FileInfo
                infoReader = My.Computer.FileSystem.GetFileInfo(Me.txtIRDBpath.Text)
                bb0 = infoReader.Length / 1024 / 1024 / 1024
            Catch ex As Exception

            End Try
            If bb0 > 2 Then
                If MessageBox.Show(Me, "คำเตือน การนำเข้าข้อมูลขนาดใหญ่อาจจะใช้เวลานาน ต้องการจะทำต่อหรือไม่", "ข้อมูลมีขนาดใหญ่",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Me.Timer1.Start()
                    Call Pstart()
                    trd = New Thread(AddressOf import)
                    trd.IsBackground = True
                    trd.Start()
                End If
            Else
                Me.Timer1.Start()
                Call Pstart()
                trd = New Thread(AddressOf import)
                trd.IsBackground = True
                trd.Start()
            End If
        Else
            If OpenFileDB.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDB.FileName <> "" Then
                Me.txtIRDBpath.Text = OpenFileDB.FileName
                Dim bb1 As Decimal
                Try
                    Dim infoReader As System.IO.FileInfo
                    infoReader = My.Computer.FileSystem.GetFileInfo(Me.txtIRDBpath.Text)
                    bb1 = infoReader.Length / 1024 / 1024 / 1024
                Catch ex As Exception

                End Try
                If bb1 > 2 Then
                    If MessageBox.Show(Me, "คำเตือน การนำเข้าข้อมูลขนาดใหญ่อาจจะใช้เวลานาน ต้องการจะทำต่อหรือไม่", "ข้อมูลมีขนาดใหญ่",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Me.Timer1.Start()
                        Call Pstart()
                        trd = New Thread(AddressOf import)
                        trd.IsBackground = True
                        trd.Start()
                    End If
                Else
                    Me.Timer1.Start()
                    Call Pstart()
                    trd = New Thread(AddressOf import)
                    trd.IsBackground = True
                    trd.Start()
                End If
            End If
        End If
    End Sub



    Private comp As Boolean
    Private fcheck As String
    Private osVer As Version = Environment.OSVersion.Version
    Private Sub import()
        Dim filePath As String = Me.txtIRDBpath.Text
        fcheck = filePath
        comp = False


        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("@echo off")

        sb.AppendLine("echo Import MySQL...")
        sb.AppendLine("cd """ & Application.StartupPath & "\""")

        sb.AppendLine("mysql" & String.Format(" -h{0} -u{1} -p{2} --port={3} --default-character-set=utf8 {4} < """ & filePath & """", server, user, password, port, database))

        IO.File.WriteAllText(Application.StartupPath & "\Import.bat", sb.ToString())
        System.IO.File.SetAttributes(Application.StartupPath & "\Import.bat", IO.FileAttributes.Hidden)
        If osVer.Major < 6 Then
            Try
                Dim runbat As Process = Process.Start(Application.StartupPath & "\Import.bat")
                runbat.WaitForExit()
                comp = True
            Catch ex As Exception

            End Try
        ElseIf osVer.Major >= 6 Then
            Try
                Dim procInfo As New ProcessStartInfo()
                procInfo.WindowStyle = ProcessWindowStyle.Hidden
                procInfo.UseShellExecute = True
                procInfo.FileName = (Application.StartupPath & "\Import.bat")
                procInfo.WorkingDirectory = ""
                procInfo.Verb = "runas"
                Dim runbat As Process = Process.Start(procInfo)
                runbat.WaitForExit()
                comp = True
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/databasemenu/importrestoredatabasefrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub msgStatus()
        MessageBox.Show(Me, "นำเข้าข้อมูลเสร็จแล้ว", "สำรองข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Import.bat")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call GetData()
        If comp = True Then
            Timer1.Stop()
            Call Pstop()
            Call msgStatus()
            Me.ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub btnIRDBstop_Click(sender As Object, e As EventArgs) Handles btnIRDBstop.Click
        If Me.btnIRDBstop.Text = "ปิด" Then
            Me.Close()
        ElseIf Me.btnIRDBstop.Text = "หยุด" Then
            comp = False
            Try
                Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("mysql")
                For Each p As Process In arrProcess
                    p.Kill()
                Next
                Dim ab() As Process = System.Diagnostics.Process.GetProcessesByName("runbat")
                For Each p As Process In ab
                    p.Kill()
                Next

                trd.Abort()
                Timer1.Stop()
                Call Pstop()
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Import.bat")
                MessageBox.Show(Me, "หยุดการสำรองข้อมูลแล้ว", "หยุด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class