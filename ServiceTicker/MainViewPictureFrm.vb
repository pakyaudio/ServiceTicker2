Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Globalization

Public Class MainViewPictureFrm
    Private imgOriginal As Image

    Private Sub MainViewPictureFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set image location

        PictureBox1.Image = imgOriginal

        ' set Picture Box Attributes
        'PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

        '' set Slider Attributes
        'zoomSlider.Minimum = 1
        'zoomSlider.Maximum = 5
        'zoomSlider.SmallChange = 1
        'zoomSlider.LargeChange = 1
        'zoomSlider.UseWaitCursor = False

        ' reduce flickering
        Me.DoubleBuffered = True
        Resize_pic()
    End Sub

    Private Sub Resize_pic()
        Dim scale As Double = zoomSlider.Value
        Label1.Text = scale
        Dim height As Integer = Convert.ToInt32((scale / 8) * PictureBox1.Image.Height)
        Dim width As Integer = Convert.ToInt32((scale / 8) * PictureBox1.Image.Width)
        'Apply new size according to TrackBar Value to PictureBox
        PictureBox1.Size = New Size(width, height)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Top = 0
        PictureBox1.Left = 0
    End Sub


    Private Sub zoomSlider_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles zoomSlider.Scroll
        Resize_pic()
    End Sub


    Dim paid As String
    Dim notepic As String
    Friend Sub GetPicture(ByVal id)
        paid = Nothing
        Try
            cmd = New MySqlCommand("SELECT byte_pic,key_pic,note_pic,datetime_save FROM picture_all WHERE pa_id='" & id & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            imgOriginal = Byte2Image(Dr.Item("byte_pic"))
            Me.Text = Dr.Item("key_pic") & " , " & Dr.Item("note_pic") & " , " & Dr.Item("datetime_save")
            paid = id
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Dim OldX As Integer = 0
    Dim OldY As Integer = 0
    Dim IsDragging As Boolean = False

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        PictureBox1.Height = PictureBox1.Image.Height
        PictureBox1.Width = PictureBox1.Image.Width
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        OldX = e.X
        OldY = e.Y
        IsDragging = True
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Cursor = Cursors.SizeAll
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If IsDragging = True Then
            PictureBox1.Location = New Point(e.X - (OldX - PictureBox1.Left), e.Y - (OldY - PictureBox1.Top))
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        IsDragging = False
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SaveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmssms", CultureInfo.CreateSpecificCulture("en-US"))
        Dim result As DialogResult = SaveFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FileName <> "" Then
                Try
                    cmd = New MySqlCommand("SELECT byte_pic FROM " _
                                    & "picture_all WHERE pa_id='" & paid & "' AND del='no';", ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    While Dr.Read
                        Dim img_buffer() As Byte = Dr.Item("byte_pic")
                        System.IO.File.WriteAllBytes(Me.SaveFileDialog1.FileName, img_buffer)
                    End While
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        End If
    End Sub
End Class