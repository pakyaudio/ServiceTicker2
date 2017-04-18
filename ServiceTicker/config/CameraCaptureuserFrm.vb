Imports WIA


Public Class CameraCaptureuserFrm

    Private WithEvents cam As New DSCamCapture
    Dim MyPicturesFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

    Private Sub CameraCaptureFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cam.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        ComboBox_Devices.Items.AddRange(cam.GetCaptureDevices)
        If ComboBox_Devices.Items.Count > 0 Then ComboBox_Devices.SelectedIndex = 0

        For Each sz As String In [Enum].GetNames(GetType(DSCamCapture.FrameSizes))
            ComboBox_FrameSize.Items.Add(sz.Replace("s", ""))
        Next
        If ComboBox_FrameSize.Items.Count > 2 Then ComboBox_FrameSize.SelectedIndex = ComboBox_FrameSize.Items.Count - 1

        Button_Connect.Enabled = (ComboBox_Devices.Items.Count > 0)
        Button_Save.Enabled = False
        If GetOSXP() = True Then
            Me.btnScanner.Visible = False
        End If
    End Sub

    Private Sub ComboBox_Devices_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_Devices.DropDown
        ComboBox_Devices.Items.Clear()
        ComboBox_Devices.Items.AddRange(cam.GetCaptureDevices)
        Button_Connect.Enabled = (ComboBox_Devices.Items.Count > 0)
        If ComboBox_Devices.SelectedIndex = -1 And ComboBox_Devices.Items.Count > 0 Then ComboBox_Devices.SelectedIndex = 0
    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        If Not cam.IsConnected Then
            Dim si As Integer = ComboBox_FrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(ComboBox_Devices.SelectedIndex, 15, PictureBox1.ClientSize, SelectedSize, PictureBox1.Handle) Then
                cam.Start()
                Button_Connect.Text = "ยกเลิกการเชื่อมต่อ"
            End If
        Else
            cam.Dispose()
            Button_Connect.Text = "เชื่อมต่อกล้อง"
        End If
        Button_Save.Enabled = cam.IsConnected
        ComboBox_Devices.Enabled = Not cam.IsConnected
        ComboBox_FrameSize.Enabled = Not cam.IsConnected
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        'If Not IO.Directory.Exists(MyPicturesFolder) Then IO.Directory.CreateDirectory(MyPicturesFolder)
        Dim fName As String = "servicetickerPic.jpg"
        Dim SaveAs As String = IO.Path.Combine(Application.StartupPath, fName)
        cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)


    End Sub

    Private Sub PictureBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        cam.ResizeWindow(0, 0, PictureBox1.ClientSize.Width, PictureBox1.ClientSize.Height)
    End Sub

    Private Sub cam_FrameSaved(ByVal capImage As System.Drawing.Bitmap, ByVal imgPath As String) Handles cam.FrameSaved
        UsersFrm.PicUsers.Image = New Bitmap(capImage)
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If OpenImageFile.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenImageFile.FileName <> Nothing Then
            PictureBox1.Image = Image.FromFile(OpenImageFile.FileName)
            UsersFrm.PicUsers.Image = PictureBox1.Image
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox_Devices_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_Devices.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox_FrameSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_FrameSize.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnScanner_Click(sender As Object, e As EventArgs) Handles btnScanner.Click
        Try
            Dim CD As New WIA.CommonDialog
            Dim F As WIA.ImageFile = CD.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType, WiaImageIntent.ColorIntent, WiaImageBias.MinimizeSize, , True, True)
            If F IsNot Nothing Then
                Dim MStream As IO.MemoryStream = Nothing
                Try
                    'Convert the raw scanner output into a byte array
                    Dim ImgBytes() As Byte = DirectCast(F.FileData.BinaryData, Byte())
                    'Read the image data bytes into a MemoryStream
                    MStream = New IO.MemoryStream(ImgBytes)
                    'Create a Bitmap from the memory stream data
                    Dim Bmp As New Drawing.Bitmap(MStream)
                    'Do a victory dance. It worked!
                    UsersFrm.PicUsers.Image = Nothing
                    UsersFrm.PicUsers.Image = Bmp
                Catch ex As Exception
                    MsgBox("ผิดพลาด : " & ex.Message)
                End Try
                MStream.Close()
                Me.Close()
            End If
        Catch ex As Exception
            Select Case _WiaErrCode(ex.Message)
                Case "0x80210015"               '// No device detected.
                    msgStr = "ไม่พบอุปกรณ์สำหรับสแกนรูปภาพ "
                    msgStr &= "ตรวจสอบให้แน่ใจว่าอุปกรณ์สแกน ได้ติดตั้งแล้ว เสียบสายต่อเข้าคอมพิวเตอร์และเปิดอุปกรณ์สแกนแล้ว"
                    MessageBox.Show(Me, msgStr, "ไม่พบอุปกรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case "0x80210064"               '// Cancel was pressed

                Case Else
                    MessageBox.Show(Me, "Error: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Select
        End Try
    End Sub
End Class