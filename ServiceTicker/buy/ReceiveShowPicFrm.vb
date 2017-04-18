Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ReceiveShowPicFrm
    ''' <summary>
    ''' โหลดรูปลง listview  call LoadPictureList(code_pro)
    ''' </summary>
    ''' <param name="key_pic"></param>
    ''' <remarks></remarks>
    Friend Sub LoadPictureList(ByVal key_pic As String)
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(200, 200)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save;", ConnectionDB)
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
                lsvparent.Text = Dr.Item("note_pic").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub DelPic(ByVal pa_id)
        Try
            cmd = New MySqlCommand("DELETE FROM picture_all WHERE pa_id='" & pa_id & "';", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call LoadPictureList(ReceiveProductFrm.txtRPbuy_id.Text)
            Call ReceiveProductFrm.CountPicture()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ReceiveShowPicFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReceiveShowPicFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                Call ReceiveViewPicFrm.LoadPic(Me.ListView1.FocusedItem.ImageKey.ToString)
                ReceiveViewPicFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub DelToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelToolStripMenu.Click
        If MessageBox.Show(Me, "ต้องการจะลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DelPic(Me.ListView1.FocusedItem.ImageKey.ToString)
        End If
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                Me.EditPictureContextMenu.Show(Me.ListView1, e.Location)
                Me.EditPictureContextMenu.Show(Cursor.Position)
            Else
                Me.AddContextMenu.Show(Me.ListView1, e.Location)
                Me.AddContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub AddToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddToolStripMenu.Click
        CameraCaptureAttactBillFrm.ShowDialog(Me)
        Call LoadPictureList(ReceiveProductFrm.txtRPbuy_id.Text)
        Call ReceiveProductFrm.CountPicture()
    End Sub
End Class