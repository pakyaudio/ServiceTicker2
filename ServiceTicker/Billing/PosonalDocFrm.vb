Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Globalization

Public Class PosonalDocFrm

    Private Sub PosonalDocFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub PosonalDocFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call LoadPictureList()
        End If
    End Sub

    Private Sub PosonalDocFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Friend Sub LoadPictureList()
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(200, 200)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='posonal' AND del='no' ORDER BY datetime_save ASC LIMIT 100;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim img_buffer() As Byte
                img_buffer = CType(Dr.Item("byte_pic"), Byte())
                Dim img_stream As New MemoryStream(img_buffer, True)

                img_stream.Write(img_buffer, 0, img_buffer.Length)
                imglist.Images.Add(Dr.Item("pa_id").ToString(), New Bitmap(img_stream))
                img_stream.Close()

                Dim lsvparent As New ListViewItem
                lsvparent.Text = Dr.Item("datetime_save").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub


    Private Sub PosonalDocFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadPictureList()
    End Sub

#Region "COnTextMenu"
    Private Sub DelToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelToolStripMenu.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Try
                cmd = New MySqlCommand("UPDATE picture_all SET del='yes' WHERE pa_id='" & ListView1.FocusedItem.ImageKey.ToString & "';", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                While ListView1.SelectedItems.Count > 0
                    Dim lvi As ListViewItem = ListView1.SelectedItems(0)
                    ListView1.Items.Remove(lvi)
                End While
                ListView1.Refresh()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub AddToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddToolStripMenu.Click
        CameraCapturePosonalFrm.ShowDialog(Me)
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                MainViewPictureFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                Me.EditContextMenu.Show(ListView1, e.Location)
            Else
                Me.AddContextMenu.Show(ListView1, e.Location)
            End If
        End If
    End Sub

    Private Sub ZoomToolStripMenu_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenu.Click
        MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
        MainViewPictureFrm.ShowDialog(Me)
    End Sub

    Private Sub PrintToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenu.Click
        DocManPrintA4Frm.paid = Me.ListView1.FocusedItem.ImageKey.ToString
        DocManPrintA4Frm.ShowDialog(Me)
    End Sub

    Private Sub ExportToolStripMenu_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenu.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                cmd = New MySqlCommand("SELECT byte_pic FROM " _
                                & "picture_all WHERE pa_id='" & Me.ListView1.FocusedItem.ImageKey.ToString & "' AND del='no';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    Dim img_buffer() As Byte = Dr.Item("byte_pic")
                    System.IO.File.WriteAllBytes(FolderBrowserDialog1.SelectedPath & "\" & DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.CreateSpecificCulture("en-US")) & ".jpg", img_buffer)
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If

    End Sub

    Private Sub RefeshToolStripMenu_Click(sender As Object, e As EventArgs) Handles RefeshToolStripMenu.Click
        Call LoadPictureList()
    End Sub
#End Region

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/billing/posonaldocfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class