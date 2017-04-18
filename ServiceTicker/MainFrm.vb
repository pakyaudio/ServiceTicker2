Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Xml

Public Class MainFrm
    Friend MenuLoigName As String
    Friend access, leval As Integer
    Friend Sub checkAccess(ByVal CeAc As String)
        Try
            access = Nothing
            leval = Nothing
            MenuLoigName = CeAc
            cmd = New MySqlCommand("SELECT access,leval FROM access_lavel WHERE zone='" & CeAc & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                access = Dr.Item("access")
                leval = Dr.Item("leval")
            End If
        Catch ex As Exception
            Me.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub loadIcon()
        Try
            cmd = New MySqlCommand("SELECT ver_icon FROM ver_detail", ConnectionDB)
            Call open_connection()
            Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            Dim stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.'
            stream.Write(pictureData, 0, pictureData.Length)
            Dim PICON As New Bitmap(stream)
            Dim HIcon As IntPtr = PICON.GetHicon()
            Dim newIcon As Icon = System.Drawing.Icon.FromHandle(HIcon)
            Me.Icon = newIcon
            stream.Close()
        Catch ex As Exception
            Me.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(Me, "คุณแน่ใจว่าจะออกจากโปรแกรม จงแน่ใจว่าบันทึกข้อมูลต่างๆเรียบร้อยแล้ว", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            e.Cancel = False
            ConnectionDB.Close()
            LoginFrm.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Friend msg As String
    Private Sub importune()
        'แสดงผลงานที่เร่งด่วน
        Try
            Dim ims As Integer = ReadIni(FileConfigINI_mcode, "importune", "status", "")
            If ims = 1 Then
                strSQL = "SELECT importune FROM comfix WHERE importune='" & "เร่งด่วน" & "' AND status='" & "1 รอซ่อม" & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    strSQL = "SELECT com_qjob FROM company"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    msg = Dr.GetString("com_qjob")
                    Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 10)
                    Dim slice As New POPupmsgFrm(5000, msg)
                    'slice.Height = Me.rng.Next(50, 200)
                    slice.Show()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Me.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub


    Private Sub lblMainStatus_Click(sender As Object, e As EventArgs) Handles lblMainStatus.Click
        For Each form In My.Application.OpenForms
            If (form.name = StatusFrm.Name) Then
                If form.Visible Then
                    StatusFrm.WindowState = FormWindowState.Normal
                    StatusFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        StatusFrm.Show(Me)
    End Sub
    Private Sub SaveErrorLog(ByVal logs As String)
        Try
            Dim strFile As String = Application.StartupPath & "\ERROR.log"
            logs = "[" & DateTime.Now & "]" & " -- " & logs
            Using sw As New StreamWriter(File.Open(strFile, FileMode.Append))
                sw.WriteLine(logs, Environment.NewLine)
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblMainStatus_TextChanged(sender As Object, e As EventArgs) Handles lblMainStatus.TextChanged
        Me.TimerStatus.Stop()
        StatusFrm.txtSatus.AppendText(Environment.NewLine)
        StatusFrm.txtSatus.AppendText(Me.lblMainStatus.Text)
        Call SaveErrorLog(Me.lblMainStatus.Text)
        Me.TimerStatus.Start()
    End Sub

    Private Sub TimerStatus_Tick(sender As Object, e As EventArgs) Handles TimerStatus.Tick
        Me.lblMainStatus.Text = "Ready"
        Me.TimerStatus.Stop()
    End Sub

    Private Sub CheckVersion()
        'Try
        '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://github.com/pakyaudio/ServiceTicker2/blob/master/version_update.txt")
        '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
        '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        '    Dim newestversion As String = sr.ReadToEnd()
        '    Dim currentversion As String = Application.ProductVersion
        '    If newestversion.Contains(currentversion) = True Then
        '        Me.updateStatus.Enabled = False
        '        Me.updateStatus.Visible = False
        '        Me.updateStatus.Image = Nothing
        '    Else
        '        If Me.updateStatus.Image Is Nothing Then
        '            Me.updateStatus.Enabled = True
        '            Me.updateStatus.Visible = True
        '            Me.updateStatus.Image = My.Resources._109_AllAnnotations_Complete_16x16_72
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub


    'Private Sub TimerCheckUpdate_Tick(sender As Object, e As EventArgs) Handles TimerCheckUpdate.Tick
    '    Dim thread As New Thread(AddressOf CheckVersion)
    '    thread.Start()
    'End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadIcon()
        'Application.CurrentCulture = New CultureInfo("th-TH")
        MainTsslUserLogin.Text = "ผู้เข้าระบบ : " & LoginFrm.txtLoginUsername.Text
        Me.Text = "เครื่องแม่ข่าย : " & server _
       & "   ฐานข้อมูล : " & database _
       & "   ชื่อคอมพิวเตอร์ : " & SystemInformation.ComputerName
        Me.lblPaper.Text = "การตั้งค่าขนาดกระดาษที่พิมพ์ " & ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", "")
        Me.TimerImportune.Interval = ReadIni(FileConfigINI_mcode, "importune", "time", "")
        Me.TimerImportune.Start()
        Me.TimerDBconnect.Start()
       
    End Sub

    Private Sub TimerImportune_Tick(sender As Object, e As EventArgs) Handles TimerImportune.Tick
        Call importune()
    End Sub

#Region "Show On ListViewDebtor"
    Friend Sub SearchSaleByCusID(ByVal cusid)
        Dim slice As New popupCeditFrm(5000, "")
        'slice.Height = Me.rng.Next(50, 200)

        With slice.ListView1
            .Clear()
            .Columns.Clear()
            Try
                cmd = New MySqlCommand("SELECT customer_id,customer_name,total_all," _
                                       & "datetime_save FROM sale WHERE customer_id='" & cusid & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    .Columns.Add("รหัสลูกค้า", 150)
                    .Columns.Add("ชื่อลูกค้า", 150)
                    .Columns.Add("ยอดค้างชำระ", 150)
                    .Columns.Add("วันที่", 140)
                    .Groups.Add("0", "ยอดค้างชำระ")
                    While Dr.Read
                        Dim nt As String = Dr.Item("customer_id")
                        Dim lsvparent As New ListViewItem(nt)
                        lsvparent.SubItems.Add(Dr.Item("customer_name"))
                        lsvparent.SubItems.Add(Dr.Item("total_all"))
                        lsvparent.SubItems.Add(CDate(Dr.Item("datetime_save")).ToString("dd MMMM yyyy HH:mm"))
                        .Items.Add(lsvparent).Group = .Groups(0)
                    End While
                    Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 10)
                    slice.Show()
                End If
            Catch ex As Exception
                Me.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End With
    End Sub
    Friend Sub SearchComfixBySN(ByVal snid)
        Dim slice As New popupCeditFrm(5000, "")
        'slice.Height = Me.rng.Next(50, 200)
        With slice.ListView1
            .Clear()
            .Columns.Clear()
            Try
                cmd = New MySqlCommand("SELECT fix_id,date_save,`sn`,symptom,user_repair,note_repair " _
                                       & "FROM comfix WHERE sn='" & snid & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    .Columns.Add("รหัสใบซ่อม", 150)
                    .Columns.Add("วันที่รับ", 150)
                    .Columns.Add("Serial Number", 150)
                    .Columns.Add("อาการเสีย", 140)
                    .Columns.Add("ผู้ซ่อม", 140)
                    .Columns.Add("การซ่อม", 140)
                    .Groups.Add("0", "บันทึกการซ่อม")
                    While Dr.Read
                        Dim nt As String = Dr.Item("fix_id")
                        Dim lsvparent As New ListViewItem(nt)
                        lsvparent.SubItems.Add(Dr.Item("date_save"))
                        lsvparent.SubItems.Add(Dr.Item("sn"))
                        lsvparent.SubItems.Add(Dr.Item("symptom"))
                        lsvparent.SubItems.Add(Dr.Item("user_repair"))
                        lsvparent.SubItems.Add(Dr.Item("note_repair"))
                        .Items.Add(lsvparent).Group = .Groups(0)
                    End While
                    Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 10)
                    slice.Show()
                End If
            Catch ex As Exception
                Me.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End With
    End Sub
#End Region

#Region "Config Menu"

    Private Sub CompanyMenu_Click(sender As Object, e As EventArgs) Handles CompanyMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CompanyFrm.Name) Then
                If form.Visible Then
                    CompanyFrm.WindowState = FormWindowState.Normal
                    CompanyFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลสถานประกอบการ")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CompanyFrm.Show(Me)
            CompanyFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UsersMenu_Click(sender As Object, e As EventArgs) Handles UsersMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = UsersFrm.Name) Then
                If form.Visible Then
                    UsersFrm.WindowState = FormWindowState.Normal
                    UsersFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ผู้ใช้งาน")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            UsersFrm.Show(Me)
            UsersFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CustomerMenu_Click(sender As Object, e As EventArgs) Handles CustomerMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CustomerFrm.Name) Then
                If form.Visible Then
                    CustomerFrm.WindowState = FormWindowState.Normal
                    CustomerFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลลูกค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CustomerFrm.Show(Me)
            CustomerFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AppConfigMenu_Click(sender As Object, e As EventArgs) Handles AppConfigMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = AppConfigFrm.Name) Then
                If form.Visible Then
                    AppConfigFrm.WindowState = FormWindowState.Normal
                    AppConfigFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ตั้งค่าโปรแกรม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            AppConfigFrm.Show(Me)
            AppConfigFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CreditCardConfigMenu_Click(sender As Object, e As EventArgs) Handles CreditCardConfigMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CreditCardManagFrm.Name) Then
                If form.Visible Then
                    CreditCardManagFrm.WindowState = FormWindowState.Normal
                    CreditCardManagFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ตั้งค่าข้อมูลบัตรเครดิต")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CreditCardManagFrm.Show(Me)
            CreditCardManagFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BookBankToolStripMenu_Click(sender As Object, e As EventArgs) Handles BookBankToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = BankBookFrm.Name) Then
                If form.Visible Then
                    BankBookFrm.WindowState = FormWindowState.Normal
                    BankBookFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ตั้งค่าบัญชีธนาคาร")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            BankBookFrm.Show(Me)
            BankBookFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PicDelToolStripMenu_Click(sender As Object, e As EventArgs) Handles PicDelToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = PictureDelFrm.Name) Then
                If form.Visible Then
                    PictureDelFrm.WindowState = FormWindowState.Normal
                    PictureDelFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("จัดการรูปภาพ")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            PictureDelFrm.Show(Me)
            PictureDelFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AccessLavelMenu_Click(sender As Object, e As EventArgs) Handles AccessLavelMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = AccessLavelFrm.Name) Then
                If form.Visible Then
                    AccessLavelFrm.WindowState = FormWindowState.Normal
                    AccessLavelFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ตั้งค่าสิทธิการใช้งานโปรแกรม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            AccessLavelFrm.Show(Me)
            AccessLavelFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrintSettingMenu_Click(sender As Object, e As EventArgs) Handles PrintSettingMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = PrinterSettingFrm.Name) Then
                If form.Visible Then
                    PrinterSettingFrm.WindowState = FormWindowState.Normal
                    PrinterSettingFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ตั้งค่าเครื่องพิมพ์")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            PrinterSettingFrm.Show(Me)
            PrinterSettingFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BackupDataBaseMenu_Click(sender As Object, e As EventArgs) Handles BackupDataBaseMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = BackupDatabaseFrm.Name) Then
                If form.Visible Then
                    BackupDatabaseFrm.WindowState = FormWindowState.Normal
                    BackupDatabaseFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("สำรองฐานข้อมูล")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            BackupDatabaseFrm.Show(Me)
            BackupDatabaseFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ImportDataBaseMenu_Click(sender As Object, e As EventArgs) Handles ImportDataBaseMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ImportRestoreDatabaseFrm.Name) Then
                If form.Visible Then
                    ImportRestoreDatabaseFrm.WindowState = FormWindowState.Normal
                    ImportRestoreDatabaseFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("นำเข้าฐานข้อมูล")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ImportRestoreDatabaseFrm.Show(Me)
            ImportRestoreDatabaseFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ConnectDBMenu_Click(sender As Object, e As EventArgs) Handles ConnectDBMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ConnectDBFrm.Name) Then
                If form.Visible Then
                    ConnectDBFrm.WindowState = FormWindowState.Normal
                    ConnectDBFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เปลี่ยนฐานข้อมูล")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ConnectDBFrm.Show(Me)
            'ConnectDBFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FixDBMenu_Click(sender As Object, e As EventArgs) Handles FixDBMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = OpimizeDBFrm.Name) Then
                If form.Visible Then
                    OpimizeDBFrm.WindowState = FormWindowState.Normal
                    OpimizeDBFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ปรับปรุงฐานข้อมูล")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            OpimizeDBFrm.Show(Me)
            OpimizeDBFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LogsMenu_Click(sender As Object, e As EventArgs) Handles LogsMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = logsFrm.Name) Then
                If form.Visible Then
                    logsFrm.WindowState = FormWindowState.Normal
                    logsFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("User Logs")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            logsFrm.Show(Me)
            logsFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LogoutToolStripMenu_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenu.Click
        Try
            Application.ExitThread()
            Process.Start(Application.StartupPath & "\ServiceTicker.exe")
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Comfix Menu"

    Private Sub ReceiveComfixMenu_Click(sender As Object, e As EventArgs) Handles ReceiveComfixMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = SaveDataFixFrm.Name) Then
                If form.Visible Then
                    SaveDataFixFrm.WindowState = FormWindowState.Normal
                    SaveDataFixFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รับงานซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SaveDataFixFrm.Show(Me)
            SaveDataFixFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub StatusComfixMenu_Click(sender As Object, e As EventArgs) Handles StatusComfixMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = RepairStatusFrm.Name) Then
                If form.Visible Then
                    RepairStatusFrm.WindowState = FormWindowState.Normal
                    RepairStatusFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("สถานะงานซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            RepairStatusFrm.Show(Me)
            RepairStatusFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigSN_Click(sender As Object, e As EventArgs) Handles ComfixConfigSN.Click
        For Each form In My.Application.OpenForms
            If (form.name = SNFrm.Name) Then
                If form.Visible Then
                    SNFrm.WindowState = FormWindowState.Normal
                    SNFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูล SN เครื่องซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SNFrm.Show(Me)
            SNFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigPtypeMenu_Click(sender As Object, e As EventArgs) Handles ComfixConfigPtypeMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ProductFrm.Name) Then
                If form.Visible Then
                    ProductFrm.WindowState = FormWindowState.Normal
                    ProductFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลประเภทสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ProductFrm.Show(Me)
            ProductFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComFixConfigPnameMenu_Click(sender As Object, e As EventArgs) Handles ComFixConfigPnameMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ProductNameFrm.Name) Then
                If form.Visible Then
                    ProductNameFrm.WindowState = FormWindowState.Normal
                    ProductNameFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลยี่ห้อสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ProductNameFrm.Show(Me)
            ProductNameFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigPmodelMenu_Click(sender As Object, e As EventArgs) Handles ComfixConfigPmodelMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ProductModelFrm.Name) Then
                If form.Visible Then
                    ProductModelFrm.WindowState = FormWindowState.Normal
                    ProductModelFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลรุ่นสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ProductModelFrm.Show(Me)
            ProductModelFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigPcolorMenu_Click(sender As Object, e As EventArgs) Handles ComfixConfigPcolorMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ProductColorFrm.Name) Then
                If form.Visible Then
                    ProductColorFrm.WindowState = FormWindowState.Normal
                    ProductColorFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลสีตัวสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ProductColorFrm.Show(Me)
            ProductColorFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigRepairTypeMenu_Click(sender As Object, e As EventArgs) Handles ComfixConfigRepairTypeMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = FixcomFrm.Name) Then
                If form.Visible Then
                    FixcomFrm.WindowState = FormWindowState.Normal
                    FixcomFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลอาการเสีย")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            FixcomFrm.Show(Me)
            FixcomFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigRepairDataMenu_Click(sender As Object, e As EventArgs) Handles ComfixConfigRepairDataMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ManagerdataFrm.Name) Then
                If form.Visible Then
                    ManagerdataFrm.WindowState = FormWindowState.Normal
                    ManagerdataFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลการจัดการข้อมูล")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ManagerdataFrm.Show(Me)
            ManagerdataFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixConfigAccessoryMenu_Click(sender As Object, e As EventArgs) Handles ComfixConfigAccessoryMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = AccessoryEditFrm.Name) Then
                If form.Visible Then
                    AccessoryEditFrm.WindowState = FormWindowState.Normal
                    AccessoryEditFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ข้อมูลอุปกรณ์ที่นำมาด้วย")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            AccessoryEditFrm.Show(Me)
            AccessoryEditFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SearchComfixMenu_Click(sender As Object, e As EventArgs) Handles SearchComfixMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = SearchRepairFrm.Name) Then
                If form.Visible Then
                    SearchRepairFrm.WindowState = FormWindowState.Normal
                    SearchRepairFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ค้นหางานซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SearchRepairFrm.Show(Me)
            SearchRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SendComfix_Click(sender As Object, e As EventArgs) Handles SendComfix.Click
        For Each form In My.Application.OpenForms
            If (form.name = SendRepairFrm.Name) Then
                If form.Visible Then
                    SendRepairFrm.WindowState = FormWindowState.Normal
                    SendRepairFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ส่งคืนงานซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SendRepairFrm.Show(Me)
            SendRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReportUserRepairToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReportUserRepairToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReportUserRepairFrm.Name) Then
                If form.Visible Then
                    ReportUserRepairFrm.WindowState = FormWindowState.Normal
                    ReportUserRepairFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานการซ่อมตามรายชื่อช่างซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReportUserRepairFrm.Show(Me)
            ReportUserRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RepairHistoryToolStripMenu_Click(sender As Object, e As EventArgs) Handles RepairHistoryToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = RepairHistoryFrm.Name) Then
                If form.Visible Then
                    RepairHistoryFrm.WindowState = FormWindowState.Normal
                    RepairHistoryFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานประวิติงานซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            RepairHistoryFrm.Show(Me)
            RepairHistoryFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComfixStatusToolStripMenu_Click(sender As Object, e As EventArgs) Handles ComfixStatusToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ComfixCustomerStatusFrm.Name) Then
                If form.Visible Then
                    ComfixCustomerStatusFrm.WindowState = FormWindowState.Normal
                    ComfixCustomerStatusFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("สถิติงานช่าง")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ComfixCustomerStatusFrm.Show(Me)
            ComfixCustomerStatusFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReportBarcodeComfixToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReportBarcodeComfixToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReportBarcodeComfixFrm.Name) Then
                If form.Visible Then
                    ReportBarcodeComfixFrm.WindowState = FormWindowState.Normal
                    ReportBarcodeComfixFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานการเบิกสินค้า แบบแสดงรายชื่อสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReportBarcodeComfixFrm.Show(Me)
            ReportBarcodeComfixFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReportRepairToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReportRepairToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReportRepairFrm.Name) Then
                If form.Visible Then
                    ReportRepairFrm.WindowState = FormWindowState.Normal
                    ReportRepairFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานรวมเบิกสินค้าตามวันที่")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReportRepairFrm.Show(Me)
            ReportRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub VarunteeCheckFrmToolStripMenu_Click(sender As Object, e As EventArgs) Handles VarunteeCheckFrmToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = VarunteeCheckFrm.Name) Then
                If form.Visible Then
                    VarunteeCheckFrm.WindowState = FormWindowState.Normal
                    VarunteeCheckFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เช็คประกันงานซ่อม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            VarunteeCheckFrm.Show(Me)
            VarunteeCheckFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrintGetSendToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintGetSendToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = PrintSaveDatafixSendRepairFrm.Name) Then
                If form.Visible Then
                    PrintSaveDatafixSendRepairFrm.WindowState = FormWindowState.Normal
                    PrintSaveDatafixSendRepairFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("พิมพ์ใบรับซ่อม/ส่งคืนย้อนหลัง")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            PrintSaveDatafixSendRepairFrm.Show(Me)
            PrintSaveDatafixSendRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SaveDataFixBankToolStripMenu_Click(sender As Object, e As EventArgs) Handles SaveDataFixBankToolStripMenu.Click
        SaveDataFixBankPrintFrm.Show(Me)
    End Sub

    Private Sub SNlabelToolStripMenu_Click(sender As Object, e As EventArgs) Handles SNlabelToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = SNLabelFrm.Name) Then
                If form.Visible Then
                    SNLabelFrm.WindowState = FormWindowState.Normal
                    SNLabelFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("พิมพ์ฉลาก SN")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SNLabelFrm.Show(Me)
            SNLabelFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "Buy Menu"

    Private Sub OrderToolStripMenu_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = OrderFrm.Name) Then
                If form.Visible Then
                    OrderFrm.WindowState = FormWindowState.Normal
                    OrderFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("สั่งซื้อสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            OrderFrm.Show(Me)
            OrderFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ViewReceiToolStripMenu_Click(sender As Object, e As EventArgs) Handles ViewReceiToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ViewReceiveFrm.Name) Then
                If form.Visible Then
                    ViewReceiveFrm.WindowState = FormWindowState.Normal
                    ViewReceiveFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายการสั่งซื้อสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ViewReceiveFrm.Show(Me)
            ViewReceiveFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReceiveProductToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReceiveProductToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReceiveProductFrm.Name) Then
                If form.Visible Then
                    ReceiveProductFrm.WindowState = FormWindowState.Normal
                    ReceiveProductFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รับสินค้าเข้าระบบ")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReceiveProductFrm.Show(Me)
            ReceiveProductFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SaleCompanyToolStripMenu_Click(sender As Object, e As EventArgs) Handles SaleCompanyToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = SaleCompanyFrm.Name) Then
                If form.Visible Then
                    SaleCompanyFrm.WindowState = FormWindowState.Normal
                    SaleCompanyFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายชื่อบริษัทที่สั่งซื้อ")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SaleCompanyFrm.Show(Me)
            SaleCompanyFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub buyReportToolStripMenu_Click(sender As Object, e As EventArgs) Handles buyReportToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReceiveReportFrm.Name) Then
                If form.Visible Then
                    ReceiveReportFrm.WindowState = FormWindowState.Normal
                    ReceiveReportFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานการรับสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReceiveReportFrm.Show(Me)
            ReceiveReportFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "Sale Menu"

    Private Sub SaleToolStripMenu_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = SaleFrm.Name) Then
                If form.Visible Then
                    SaleFrm.WindowState = FormWindowState.Normal
                    SaleFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ขายสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            SaleFrm.Show(Me)
            SaleFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReturnProductToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReturnProductToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReturnsProductFrm.Name) Then
                If form.Visible Then
                    ReturnsProductFrm.WindowState = FormWindowState.Normal
                    ReturnsProductFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("คืนสินค้า/ยกเลิกบิลขาย")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReturnsProductFrm.Show(Me)
            ReturnsProductFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReportSaleAllByDateToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReportSaleAllByDateToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReportSaleFrm.Name) Then
                If form.Visible Then
                    ReportSaleFrm.WindowState = FormWindowState.Normal
                    ReportSaleFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานรวมขายสินค้าตามวันที่")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReportSaleFrm.Show(Me)
            ReportSaleFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReportSaleByProductToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReportSaleByProductToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReportBarcodeFrm.Name) Then
                If form.Visible Then
                    ReportBarcodeFrm.WindowState = FormWindowState.Normal
                    ReportBarcodeFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานขาย แบบแสดงรายชื่อสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReportBarcodeFrm.Show(Me)
            ReportBarcodeFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReturnProToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReturnProToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReturnProdductReportFrm.Name) Then
                If form.Visible Then
                    ReturnProdductReportFrm.WindowState = FormWindowState.Normal
                    ReturnProdductReportFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานการคืนสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReturnProdductReportFrm.Show(Me)
            ReturnProdductReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckPriceToolStripMenu_Click(sender As Object, e As EventArgs) Handles CheckPriceToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CheckPriceFrm.Name) Then
                If form.Visible Then
                    CheckPriceFrm.WindowState = FormWindowState.Normal
                    CheckPriceFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ตรวจสอบราคาสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CheckPriceFrm.Show(Me)
            CheckPriceFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub VarunteeCheckProToolStripMenu_Click(sender As Object, e As EventArgs) Handles VarunteeCheckProToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = VarunteeCheckSNFrm.Name) Then
                If form.Visible Then
                    VarunteeCheckSNFrm.WindowState = FormWindowState.Normal
                    VarunteeCheckSNFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เช็คประกันตัวสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            VarunteeCheckSNFrm.Show(Me)
            VarunteeCheckSNFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Claims Menu"
    Private Sub ReceiveClaimsToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReceiveClaimsToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsFrm.Name) Then
                If form.Visible Then
                    ClaimsFrm.WindowState = FormWindowState.Normal
                    ClaimsFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รับเคลมสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsFrm.Show(Me)
            ClaimsFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrepareClaimsToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrepareClaimsToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsPrepareFrm.Name) Then
                If form.Visible Then
                    ClaimsPrepareFrm.WindowState = FormWindowState.Normal
                    ClaimsPrepareFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เตรียมสินค้าเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsPrepareFrm.Show(Me)
            ClaimsPrepareFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SendClaimsToolStripMenu_Click(sender As Object, e As EventArgs) Handles SendClaimsToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsSendGroupFrm.Name) Then
                If form.Visible Then
                    ClaimsSendGroupFrm.WindowState = FormWindowState.Normal
                    ClaimsSendGroupFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ส่งสินค้าเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsSendGroupFrm.Show(Me)
            ClaimsSendGroupFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AdmissionClaimToolStripMenu_Click(sender As Object, e As EventArgs) Handles AdmissionClaimToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsreceiveGroupFrm.Name) Then
                If form.Visible Then
                    ClaimsreceiveGroupFrm.WindowState = FormWindowState.Normal
                    ClaimsreceiveGroupFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รับเข้าสินค้าเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsreceiveGroupFrm.Show(Me)
            ClaimsreceiveGroupFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TestProClaimsToolStripMenu_Click(sender As Object, e As EventArgs) Handles TestProClaimsToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsTestResultsFrm.Name) Then
                If form.Visible Then
                    ClaimsTestResultsFrm.WindowState = FormWindowState.Normal
                    ClaimsTestResultsFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ทดสอบสินค้าเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsTestResultsFrm.Show(Me)
            ClaimsTestResultsFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ImportClaimsToolStripMenu_Click(sender As Object, e As EventArgs) Handles ImportClaimsToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsImportProFrm.Name) Then
                If form.Visible Then
                    ClaimsImportProFrm.WindowState = FormWindowState.Normal
                    ClaimsImportProFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("นำเข้าสินค้าเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsImportProFrm.Show(Me)
            ClaimsImportProFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClaimsStatusToolStripMenu_Click(sender As Object, e As EventArgs) Handles ClaimsStatusToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsStatusFrm.Name) Then
                If form.Visible Then
                    ClaimsStatusFrm.WindowState = FormWindowState.Normal
                    ClaimsStatusFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ติดตามสถานะเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsStatusFrm.Show(Me)
            ClaimsStatusFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub ClaimsReturnToolStripMenu_Click(sender As Object, e As EventArgs) Handles ClaimsReturnToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ReturnClaimsToCusFrm.Name) Then
                If form.Visible Then
                    ReturnClaimsToCusFrm.WindowState = FormWindowState.Normal
                    ReturnClaimsToCusFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("คืนสินค้าเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ReturnClaimsToCusFrm.Show(Me)
            ReturnClaimsToCusFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClaimsReportToolStripMenu_Click(sender As Object, e As EventArgs) Handles ClaimsReportToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ClaimsReportFrm.Name) Then
                If form.Visible Then
                    ClaimsReportFrm.WindowState = FormWindowState.Normal
                    ClaimsReportFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานการเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ClaimsReportFrm.Show(Me)
            ClaimsReportFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrintingBoxCoverToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintingBoxCoverToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = BoxCoverFrm.Name) Then
                If form.Visible Then
                    BoxCoverFrm.WindowState = FormWindowState.Normal
                    BoxCoverFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("พิมพ์ใบปะหน้ากล่อง")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            BoxCoverFrm.Show(Me)
            BoxCoverFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrintingGetClaimsToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintingGetClaimsToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = PrintingGetClaimsFrm.Name) Then
                If form.Visible Then
                    PrintingGetClaimsFrm.WindowState = FormWindowState.Normal
                    PrintingGetClaimsFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("พิมพ์ใบรับเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            PrintingGetClaimsFrm.Show(Me)
            PrintingGetClaimsFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PrintingClaimsSendToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintingClaimsSendToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = PrintingClaimSendListFrm.Name) Then
                If form.Visible Then
                    PrintingClaimSendListFrm.WindowState = FormWindowState.Normal
                    PrintingClaimSendListFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("พิมพ์รายการส่งเคลม")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            PrintingClaimSendListFrm.Show(Me)
            PrintingClaimSendListFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "finance"
    Private Sub DebtorToolStripMenu_Click(sender As Object, e As EventArgs) Handles DebtorToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = DebtorFrm.Name) Then
                If form.Visible Then
                    DebtorFrm.WindowState = FormWindowState.Normal
                    DebtorFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ลูกหนี้ค้างจ่าย")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            DebtorFrm.Show(Me)
            DebtorFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AuditToolStripMenu_Click(sender As Object, e As EventArgs) Handles AuditToolStripMenu.Click
        Try
            strSQL = "SELECT datetime FROM audit WHERE datetime='" & "start" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("คุณยังไม่ได้เริ่มระบบตรวจสอบบัญชี สิ่งที่ต้องทำคือ" & vbNewLine & _
                        "1.มีเงินทอนที่เพียงพอในการทอนและนับเงินทอนที่จะใช้ทอนในวันพรุ่งนี้" & vbNewLine & _
                        "2.บันทึกเงินทอนลงในโปรแกรม เพื่อเริ่มต้น การตรวจสอบบัญชี" & vbNewLine & _
                        "ต้องนับเงินทอนที่จะใช้ทอนในวันถัดไป เมื่อสิ้นสุดของวันนี้ก่อนเที่ยงคืน ", MsgBoxStyle.Information, "ข้อควรทราบ")
                StartAuditFrm.Show(Me)
                StartAuditFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            Else
                For Each form In My.Application.OpenForms
                    If (form.name = AuditFrm.Name) Then
                        If form.Visible Then
                            AuditFrm.WindowState = FormWindowState.Normal
                            AuditFrm.BringToFront()
                            Exit Sub
                        End If
                    End If
                Next
                Call checkAccess("ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย")
                If access = 1 Then
                    MiniAllLoginFrm.ShowDialog(Me)
                ElseIf access = 0 Then
                    AuditFrm.Show(Me)
                    AuditFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
                Else
                    MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            Me.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SatitisYearToolStripMenu_Click(sender As Object, e As EventArgs) Handles SatitisYearToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = AuditChartFrm.Name) Then
                If form.Visible Then
                    AuditChartFrm.WindowState = FormWindowState.Normal
                    AuditChartFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("สถิติรายปี")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            AuditChartFrm.Show(Me)
            AuditChartFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReportINOUTToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReportINOUTToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = AuditReportFrm.Name) Then
                If form.Visible Then
                    AuditReportFrm.WindowState = FormWindowState.Normal
                    AuditReportFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานรายรับ/รายจ่าย")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            AuditReportFrm.Show(Me)
            AuditReportFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DocCumentToolStripMenu_Click(sender As Object, e As EventArgs) Handles DocCumentToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = DocumentManagerFrm.Name) Then
                If form.Visible Then
                    DocumentManagerFrm.WindowState = FormWindowState.Normal
                    DocumentManagerFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ระบบเอกสาร")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            DocumentManagerFrm.Show(Me)
            DocumentManagerFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "Stock"
    Private Sub ProductListToolStripMenu_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = ProductDetailFrm.Name) Then
                If form.Visible Then
                    ProductDetailFrm.WindowState = FormWindowState.Normal
                    ProductDetailFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายการสินค้า")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            ProductDetailFrm.Show(Me)
            ProductDetailFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckStockSNToolStripMenu_Click(sender As Object, e As EventArgs) Handles CheckStockSNToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CheckStockFrm.Name) Then
                If form.Visible Then
                    CheckStockFrm.WindowState = FormWindowState.Normal
                    CheckStockFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เช็คสต็อก Serial Number")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CheckStockFrm.Show(Me)
            CheckStockFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckStockBCToolStripMenu_Click(sender As Object, e As EventArgs) Handles CheckStockBCToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CheckStoclBarcodeFrm.Name) Then
                If form.Visible Then
                    CheckStoclBarcodeFrm.WindowState = FormWindowState.Normal
                    CheckStoclBarcodeFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เช็คสต็อกบาร์โค๊ต")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CheckStoclBarcodeFrm.Show(Me)
            CheckStoclBarcodeFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckStockSNReportToolStripMenu_Click(sender As Object, e As EventArgs) Handles CheckStockSNReportToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CheckStockReportFrm.Name) Then
                If form.Visible Then
                    CheckStockReportFrm.WindowState = FormWindowState.Normal
                    CheckStockReportFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานตรวจสอบสต็อก SN")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CheckStockReportFrm.Show(Me)
            CheckStockReportFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckSStockBarcodeToolStripMenu_Click(sender As Object, e As EventArgs) Handles CheckSStockBarcodeToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = CheckStockBCReportFrm.Name) Then
                If form.Visible Then
                    CheckStockBCReportFrm.WindowState = FormWindowState.Normal
                    CheckStockBCReportFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานตรวจสอบสต็อกบาร์โค๊ต")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            CheckStockBCReportFrm.Show(Me)
            CheckStockBCReportFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub StockAllReportToolStripMenu_Click(sender As Object, e As EventArgs) Handles StockAllReportToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = StockNumberFrm.Name) Then
                If form.Visible Then
                    StockNumberFrm.WindowState = FormWindowState.Normal
                    StockNumberFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("รายงานยอดรวมสต็อก")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            StockNumberFrm.Show(Me)
            StockNumberFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "Billing"
    Private Sub InvoiceToolStripMenu_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = TaxInvoiceFrm.Name) Then
                If form.Visible Then
                    TaxInvoiceFrm.WindowState = FormWindowState.Normal
                    TaxInvoiceFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("ออกใบกำกับภาษี/ใบส่งของ")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            TaxInvoiceFrm.Show(Me)
            TaxInvoiceFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PosonalDocToolStripMenu_Click(sender As Object, e As EventArgs) Handles PosonalDocToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = PosonalDocFrm.Name) Then
                If form.Visible Then
                    PosonalDocFrm.WindowState = FormWindowState.Normal
                    PosonalDocFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call checkAccess("เอกสารประกอบ")
        If access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf access = 0 Then
            PosonalDocFrm.Show(Me)
            PosonalDocFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "Help"
    Private Sub AboutUSToolStripMenu_Click(sender As Object, e As EventArgs) Handles AboutUSToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = AboutUSFrm.Name) Then
                If form.Visible Then
                    AboutUSFrm.WindowState = FormWindowState.Normal
                    AboutUSFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        AboutUSFrm.Show(Me)
    End Sub

    Private Sub ManualToolStripMenu_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenu.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DonatToolStripMenu_Click(sender As Object, e As EventArgs) Handles DonatToolStripMenu.Click
        For Each form In My.Application.OpenForms
            If (form.name = DonatFrm.Name) Then
                If form.Visible Then
                    DonatFrm.WindowState = FormWindowState.Normal
                    DonatFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        DonatFrm.Show(Me)
    End Sub
#End Region

End Class
