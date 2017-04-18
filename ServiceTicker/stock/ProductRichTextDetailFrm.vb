Public Class ProductRichTextDetailFrm

    Private Sub btnFontDialog_Click(sender As Object, e As EventArgs) Handles btnFontDialog.Click
        If FontDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub TrackBarZoom_Scroll(sender As Object, e As EventArgs) Handles TrackBarZoom.Scroll
        Call ZoomPercen()
    End Sub

    Private Sub ZoomPercen()
        If TrackBarZoom.Value = 0 Then
            RichTextBox1.ZoomFactor = 0.5
        ElseIf TrackBarZoom.Value = 1 Then
            RichTextBox1.ZoomFactor = 0.6
        ElseIf TrackBarZoom.Value = 2 Then
            RichTextBox1.ZoomFactor = 0.7
        ElseIf TrackBarZoom.Value = 3 Then
            RichTextBox1.ZoomFactor = 0.8
        ElseIf TrackBarZoom.Value = 4 Then
            RichTextBox1.ZoomFactor = 0.9
        ElseIf TrackBarZoom.Value = 5 Then
            RichTextBox1.ZoomFactor = 1
        ElseIf TrackBarZoom.Value = 6 Then
            RichTextBox1.ZoomFactor = 2
        ElseIf TrackBarZoom.Value = 7 Then
            RichTextBox1.ZoomFactor = 3
        ElseIf TrackBarZoom.Value = 8 Then
            RichTextBox1.ZoomFactor = 4
        ElseIf TrackBarZoom.Value = 9 Then
            RichTextBox1.ZoomFactor = 5
        ElseIf TrackBarZoom.Value = 10 Then
            RichTextBox1.ZoomFactor = 6
        End If

        If TrackBarZoom.Value = 0 Then
            Me.Label1.Text = "-50%"
        ElseIf TrackBarZoom.Value = 1 Then
            Me.Label1.Text = "-40%"
        ElseIf TrackBarZoom.Value = 2 Then
            Me.Label1.Text = "-30%"
        ElseIf TrackBarZoom.Value = 3 Then
            Me.Label1.Text = "-20%"
        ElseIf TrackBarZoom.Value = 4 Then
            Me.Label1.Text = "-10%"
        ElseIf TrackBarZoom.Value = 5 Then
            Me.Label1.Text = "100%"
        ElseIf TrackBarZoom.Value = 6 Then
            Me.Label1.Text = "120%"
        ElseIf TrackBarZoom.Value = 7 Then
            Me.Label1.Text = "140%"
        ElseIf TrackBarZoom.Value = 8 Then
            Me.Label1.Text = "160%"
        ElseIf TrackBarZoom.Value = 9 Then
            Me.Label1.Text = "180%"
        ElseIf TrackBarZoom.Value = 10 Then
            Me.Label1.Text = "200%"
        End If
    End Sub

    Private Sub ProductRichTextDetailFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductRichTextDetailFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        TrackBarZoom.Value = 5
        Call ZoomPercen()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ProductDetailEditFrm.RichTextProdetail.Rtf = Me.RichTextBox1.Rtf
        Me.Close()
    End Sub

    Private Sub btnColorRed_Click(sender As Object, e As EventArgs) Handles btnColorRed.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionColor = Color.Red
        End If
    End Sub

    Private Sub btnColorYallow_Click(sender As Object, e As EventArgs) Handles btnColorYallow.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionColor = Color.Yellow
        End If
    End Sub

    Private Sub btnColorGreen_Click(sender As Object, e As EventArgs) Handles btnColorGreen.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionColor = Color.Green
        End If
    End Sub

    Private Sub btnColorBlue_Click(sender As Object, e As EventArgs) Handles btnColorBlue.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionColor = Color.Blue
        End If
    End Sub

    Private Sub btnColorBlack_Click(sender As Object, e As EventArgs) Handles btnColorBlack.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionColor = Color.Black
        End If
    End Sub

    Private Sub btnFontB_Click(sender As Object, e As EventArgs) Handles btnFontB.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If RichTextBox1.SelectionFont.Bold = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Bold
            End If

            RichTextBox1.SelectionFont = New Font( _
               currentFont.FontFamily, _
               currentFont.Size, _
               newFontStyle _
            )
        End If
    End Sub

    Private Sub btnFontI_Click(sender As Object, e As EventArgs) Handles btnFontI.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If RichTextBox1.SelectionFont.Italic = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Italic
            End If

            RichTextBox1.SelectionFont = New Font( _
               currentFont.FontFamily, _
               currentFont.Size, _
               newFontStyle _
            )
        End If
    End Sub

    Private Sub btnFontU_Click(sender As Object, e As EventArgs) Handles btnFontU.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If RichTextBox1.SelectionFont.Underline = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Underline
            End If

            RichTextBox1.SelectionFont = New Font( _
               currentFont.FontFamily, _
               currentFont.Size, _
               newFontStyle _
            )
        End If
    End Sub

    Private Sub btnFontUline_Click(sender As Object, e As EventArgs) Handles btnFontUline.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle

            If RichTextBox1.SelectionFont.Strikeout = True Then
                newFontStyle = FontStyle.Regular
            Else
                newFontStyle = FontStyle.Strikeout
            End If

            RichTextBox1.SelectionFont = New Font( _
               currentFont.FontFamily, _
               currentFont.Size, _
               newFontStyle _
            )
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub btnRedu_Click(sender As Object, e As EventArgs) Handles btnRedu.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
       
    End Sub

    Private Sub ProductRichTextDetailFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Z AndAlso e.Modifiers = Keys.Control Then
            RichTextBox1.Undo()
        End If

        If e.KeyCode = Keys.Y AndAlso e.Modifiers = Keys.Control Then
            RichTextBox1.Redo()
        End If

        If e.KeyCode = Keys.A AndAlso e.Modifiers = Keys.Control Then
            RichTextBox1.SelectAll()
        End If

        If e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Control Then
            If RichTextBox1.SelectedText IsNot Nothing Then
                RichTextBox1.Copy()
            End If
        End If

        If e.KeyCode = Keys.P AndAlso e.Modifiers = Keys.Control Then
            RichTextBox1.Paste()
        End If

        If e.KeyCode = Keys.B AndAlso e.Modifiers = Keys.Control Then
            If RichTextBox1.SelectionFont IsNot Nothing Then
                Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
                Dim newFontStyle As System.Drawing.FontStyle

                If RichTextBox1.SelectionFont.Bold = True Then
                    newFontStyle = FontStyle.Regular
                Else
                    newFontStyle = FontStyle.Bold
                End If

                RichTextBox1.SelectionFont = New Font( _
                   currentFont.FontFamily, _
                   currentFont.Size, _
                   newFontStyle _
                )
            End If
        End If

        If e.KeyCode = Keys.I AndAlso e.Modifiers = Keys.Control Then
            If RichTextBox1.SelectionFont IsNot Nothing Then
                Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
                Dim newFontStyle As System.Drawing.FontStyle

                If RichTextBox1.SelectionFont.Italic = True Then
                    newFontStyle = FontStyle.Regular
                Else
                    newFontStyle = FontStyle.Italic
                End If

                RichTextBox1.SelectionFont = New Font( _
                   currentFont.FontFamily, _
                   currentFont.Size, _
                   newFontStyle _
                )
            End If
        End If

        If e.KeyCode = Keys.U AndAlso e.Modifiers = Keys.Control Then
            If RichTextBox1.SelectionFont IsNot Nothing Then
                Dim currentFont As System.Drawing.Font = RichTextBox1.SelectionFont
                Dim newFontStyle As System.Drawing.FontStyle

                If RichTextBox1.SelectionFont.Underline = True Then
                    newFontStyle = FontStyle.Regular
                Else
                    newFontStyle = FontStyle.Underline
                End If

                RichTextBox1.SelectionFont = New Font( _
                   currentFont.FontFamily, _
                   currentFont.Size, _
                   newFontStyle _
                )
            End If
        End If
    End Sub
End Class