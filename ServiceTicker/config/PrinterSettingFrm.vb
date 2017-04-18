Public Class PrinterSettingFrm

    Private Sub PrinterSettingFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub PrinterSettingFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        If ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", "") = "A4" Then
            Me.cbbSelectPaper.SelectedItem = "A4"
        ElseIf ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", "") = "A5" Then
            Me.cbbSelectPaper.SelectedItem = "A5"
        End If
    End Sub

    Private Sub cbbSelectPaper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSelectPaper.SelectedIndexChanged
        If Me.cbbSelectPaper.Text = "A4" Then
            Me.PictureBox1.Image = My.Resources.A4
        ElseIf Me.cbbSelectPaper.Text = "A5" Then
            Me.PictureBox1.Image = My.Resources.A5
        End If
    End Sub

    Private Sub btnSavePaper_Click(sender As Object, e As EventArgs) Handles btnSavePaper.Click
        Try
            writeIni(FileConfigINI_mcode, "checkPrinter", "paper", Me.cbbSelectPaper.Text)
            MessageBox.Show(Me, "ตั้งค่าหน้ากระดาษเป็น " & ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", "") _
                            , "บันทึกข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainFrm.lblPaper.Text = "การตั้งค่าขนาดกระดาษที่พิมพ์ " & ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", "")
        Catch ex As Exception
            MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ " & ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", ""), "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bntHelp_Click(sender As Object, e As EventArgs) Handles bntHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/appconfig/printersetting")
        Catch ex As Exception

        End Try
    End Sub
End Class