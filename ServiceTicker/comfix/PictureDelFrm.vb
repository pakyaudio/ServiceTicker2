Imports MySql.Data.MySqlClient
Imports System.IO

Public Class PictureDelFrm
#Region "Code"
    ''' <summary>
    ''' โหลดข้อมูลรูปจากฐานข้อมูล SELECT pa_id,byte_pic,note_pic,datetime_save FROM picture_all WHERE key_pic=@key_pic"
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub LoadPictureList()
        Me.ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(200, 200)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,key_pic,note_pic,datetime_save FROM picture_all " _
                                   & "WHERE del='yes' ORDER BY datetime_save;", ConnectionDB)
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
                lsvparent.Text = Dr.Item("key_pic").ToString() & ", " & Dr.Item("note_pic").ToString() & ", " & Dr.Item("datetime_save").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub PictureDelFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub PictureDelFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call LoadPictureList()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If MessageBox.Show(Me, "ต้องการนำกลับคืนรูปภาพ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each item As ListViewItem In Me.ListView1.SelectedItems
                Try
                    cmd = New MySqlCommand("UPDATE picture_all SET del='no' WHERE pa_id='" & item.ImageKey & "';", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Call LoadPictureList()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(Me, "เมื่อลบแล้วจะไม่สามารถ นำกลับคืนมาได้อีกต่อไป", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each item As ListViewItem In Me.ListView1.SelectedItems
                Try
                    cmd = New MySqlCommand("DELETE FROM picture_all WHERE pa_id='" & item.ImageKey & "';", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Call LoadPictureList()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count <> 0 Then
            Me.btnRestore.Enabled = True
            Me.btnDelete.Enabled = True
        Else
            Me.btnRestore.Enabled = False
            Me.btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/appconfig/managerpicture")
        Catch ex As Exception

        End Try
    End Sub
End Class