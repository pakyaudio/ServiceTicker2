Imports MySql.Data.MySqlClient
Imports WIA

Public Class shelfFrm
    Private Sub startfrm()

        Me.NewToolStripButton.Enabled = True
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = False
        Me.CancelToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = False
        Me.dgProductType.Enabled = True
        Me.txtEdit.Clear()
        Call getData()

        Me.dgProductType.ClearSelection()
        Call LoadPicture()
    End Sub

    Private Sub getData()
        Try
            Me.dgProductType.Rows.Clear()
            cmd = New MySqlCommand("SELECT `s` FROM shelf ORDER BY `s` ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgProductType
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("s")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub LoadPicture()
        Try
            strSQL = "SELECT byte_pic FROM picture_all WHERE key_pic='shelfFrm';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                PictureBox1.Image = Byte2Image(Dr.Item("byte_pic"))
            Else
                PictureBox1.Image = Nothing
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub shelfFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
    End Sub

    Private Sub dgProductType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProductType.CellClick
        If Me.dgProductType.Rows.Count <> 0 Then
            Me.NewToolStripButton.Enabled = True
            Me.EditToolStripButton.Enabled = True
            Me.SaveToolStripButton.Enabled = False
            Me.CancelToolStripButton.Enabled = False
            Me.DeleteToolStripButton.Enabled = True
            Me.BackToolStripButton.Enabled = True
            Me.NextToolStripButton.Enabled = True
            Me.txtEdit.Enabled = False
            Me.txtEdit.Text = Me.dgProductType.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgProductType.CurrentCell = Me.dgProductType.Rows(Me.dgProductType.CurrentCell.RowIndex - 1).Cells(0)
            Me.txtEdit.Text = Me.dgProductType.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgProductType.CurrentCell = Me.dgProductType.Rows(Me.dgProductType.CurrentCell.RowIndex + 1).Cells(0)
            Me.txtEdit.Text = Me.dgProductType.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Dim selectSaveCadit As Integer
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        selectSaveCadit = 1000
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = True
        Me.txtEdit.Clear()
        Me.dgProductType.ClearSelection()
        Me.dgProductType.Enabled = False
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If Me.txtEdit.Text <> Nothing Then
            If MessageBox.Show(Me, "ต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If selectSaveCadit = 1000 Then
                    Call InsertData()
                ElseIf selectSaveCadit = 2000 Then
                    Call UpdateData()
                End If
            End If
        End If
    End Sub

    Private Sub InsertData()
        If checkMySQLDruplicateDB("SELECT `s` FROM `shelf` WHERE s='" & Me.txtEdit.Text & "'") = True Then
            MessageBox.Show(Me, "มีรายการนี้อยู่แล้ว กรุณาเปลี่ยนเป็นอย่างอื่น", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                cmd = New MySqlCommand("INSERT INTO `shelf`(`s`)VALUES('" & Me.txtEdit.Text & "')", ConnectionDB)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call startfrm()
                    selectSaveCadit = Nothing
                ElseIf save = 0 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub UpdateData()
        If checkMySQLDruplicateDB("SELECT `s` FROM `shelf` WHERE " _
                                & "s='" & Me.txtEdit.Text & "' AND NOT s='" & Me.dgProductType.CurrentRow.Cells(0).Value & "'") = True Then
            MessageBox.Show(Me, "มีรายการนี้อยู่แล้ว กรุณาเปลี่ยนเป็นอย่างอื่น", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                cmd = New MySqlCommand("UPDATE `shelf` SET s='" & Me.txtEdit.Text & "' WHERE s='" & Me.dgProductType.CurrentRow.Cells(0).Value & "'", ConnectionDB)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call startfrm()
                    selectSaveCadit = Nothing
                ElseIf save = 0 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        selectSaveCadit = 2000
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = True
        Me.dgProductType.Enabled = False
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการลบหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DeleteData()
        End If
    End Sub

    Private Sub DeleteData()
        Try
            cmd = New MySqlCommand("DELETE FROM `shelf` WHERE s='" & Me.txtEdit.Text & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MessageBox.Show(Me, "ลบข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call startfrm()
                selectSaveCadit = Nothing
            ElseIf save = 0 Then
                MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrm()
        End If
    End Sub

    Private Sub btnOpenPicture_Click(sender As Object, e As EventArgs) Handles btnOpenPicture.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso OpenFileDialog1.FileName <> Nothing Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            If checkMySQLDruplicateDB("SELECT * FROM picture_all WHERE key_pic='shelfFrm';") = True Then
                Try
                    Using stream As New IO.MemoryStream
                        Using ibmp As Bitmap = New Bitmap(PictureBox1.Image)
                            ibmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp)
                            strSQL = "UPDATE picture_all SET byte_pic=@byte_pic WHERE key_pic='shelfFrm';"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@byte_pic", stream.GetBuffer())
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                            stream.Close()
                        End Using
                    End Using
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Else
                Call SavePictureToDB(PictureBox1, "shelfFrm", "รูปชั้นวางเครื่องซ่อม")
            End If
        End If
    End Sub

    Private Sub btnScaner_Click(sender As Object, e As EventArgs) Handles btnScaner.Click
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
                    'Assign the bitmap as the PictureBox Image
                    PictureBox1.Image = Bmp
                    'Do a victory dance. It worked!
                    If checkMySQLDruplicateDB("SELECT * FROM picture_all WHERE key_pic='shelfFrm';") = True Then
                        Try
                            Using stream As New IO.MemoryStream
                                Using ibmp As Bitmap = New Bitmap(PictureBox1.Image)
                                    ibmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp)
                                    strSQL = "UPDATE picture_all SET byte_pic=@byte_pic WHERE key_pic='shelfFrm';"
                                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                                    cmd.Parameters.AddWithValue("@byte_pic", stream.GetBuffer())
                                    Call open_connection()
                                    cmd.ExecuteNonQuery()
                                    stream.Close()
                                End Using
                            End Using
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try
                    Else
                        Call SavePictureToDB(PictureBox1, "shelfFrm", "รูปชั้นวางเครื่องซ่อม")
                    End If
                Catch ex As Exception
                    MsgBox("ผิดพลาด : " & ex.Message)
                End Try
                If MStream IsNot Nothing Then MStream.Dispose()
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

    Private Sub btnSavePicture_Click(sender As Object, e As EventArgs) Handles btnSavePicture.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK AndAlso SaveFileDialog1.FileName <> Nothing Then
            Dim FileToSaveAs As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, SaveFileDialog1.FileName)
            Dim ibmp As Bitmap = New Bitmap(PictureBox1.Image)
            ibmp.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Not PictureBox1.Image Is Nothing Then
            ShelfPrintFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่มีรูปแผนผังให้พิมพ์", "ไม่มีรูป", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class