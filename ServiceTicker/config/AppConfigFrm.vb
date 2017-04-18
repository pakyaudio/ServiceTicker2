Imports MySql.Data.MySqlClient

Public Class AppConfigFrm

    Private Sub AppConfigFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub AppConfigFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call loadVerDetail()
        Call loadDataBill()
        Call DisableTextBox_GroupBox2()
        Call loadVerDetaildg()
        Call rbStatus()
        Call CulTimer()

    End Sub

    Private Sub DisableTextBox_GroupBox2()
        Me.EditToolStripButton.Enabled = True
        Me.SaveToolStripButton.Enabled = False
        Me.UndoToolStripButton.Enabled = False
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            End If
        Next
    End Sub

    Private Sub EnableTextBox_GroupBox1()
        For Each c As Control In GroupBox1.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    Private Sub EnableTextBox_GroupBox2()
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    Private Sub loadVerDetail()
        Try
            dt = New DataTable
            dtAdapter = New MySqlDataAdapter("SELECT ver_imglogin,ver_company,ver_version FROM ver_detail", ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            PictureBoxLoginOld.Image = Byte2Image(dt(0)("ver_imglogin"))
            Me.txtACappnameSave.Text = dt(0)("ver_company")
            Me.txtACtextlogin.Text = dt(0)("ver_version")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT ver_icon FROM ver_detail"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            Dim stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.'
            stream.Write(pictureData, 0, pictureData.Length)
            Dim bitmap As New Bitmap(stream)
            PictureIconOld.Image = bitmap
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub loadDataBill()
        Try
            strSQL = "SELECT footer1,footer2,footer3,com_sendrepairrow1,com_sendrepairrow2,com_sendrepairrow3," _
                 & "com_Invoice,com_quotation,com_billing,com_claims,com_qjob,com_pledge,com_recipt FROM company"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Me.txtACTextFooter1.Text = Dr.GetString("footer1")
            Me.txtACTextFooter2.Text = Dr.GetString("footer2")
            Me.txtACTextFooter3.Text = Dr.GetString("footer3")
            Me.txtACSendRepairRow1.Text = Dr.GetString("com_sendrepairrow1")
            Me.txtACSendRepairRow2.Text = Dr.GetString("com_sendrepairrow2")
            Me.txtACSendRepairRow3.Text = Dr.GetString("com_sendrepairrow3")
            Me.txtACInvoice.Text = Dr.GetString("com_Invoice")
            Me.txtACtxtQuotation.Text = Dr.GetString("com_quotation")
            Me.txtACBilling.Text = Dr.GetString("com_billing")
            Me.txtACclaimsbill.Text = Dr.GetString("com_claims")
            Me.txtACqJob.Text = Dr.GetString("com_qjob")
            Me.txtACpladge.Text = Dr.GetString("com_pledge")
            Me.txtACrecipt.Text = Dr.GetString("com_recipt")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Dim imgpath As String
    Private Sub btnOpenIcon_Click(sender As Object, e As EventArgs) Handles btnOpenIcon.Click
        If OpenFile.ShowDialog = DialogResult.OK AndAlso OpenFile.FileName <> "" Then
            imgpath = OpenFile.FileName
            PictureIconNew.Image = Drawing.Image.FromFile(imgpath)
        End If
    End Sub

    Private Sub btnIconSave_Click(sender As Object, e As EventArgs) Handles btnIconSave.Click
            If MessageBox.Show("ต้องการบันทึกข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If imgpath <> Nothing Then
                    Try
                        cmd = New MySqlCommand("UPDATE ver_detail SET ver_icon=@vi", ConnectionDB)
                        cmd.Parameters.AddWithValue("@vi", ConvertImageFiletoBytes(imgpath))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        PictureIconOld.Image = PictureIconNew.Image
                        Call MainFrm.loadIcon()
                        Me.Icon = MainFrm.Icon
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    imgpath = Nothing
                    PictureIconNew.Image = Nothing
                    PictureIconNew.BackColor = Color.Empty
                    PictureIconNew.Invalidate()
                End If
            End If
    End Sub

    Dim imglogin As String

    Private Sub btnOpenliginImage_Click(sender As Object, e As EventArgs) Handles btnOpenliginImage.Click
        If OpenFileImgLogo.ShowDialog = DialogResult.OK AndAlso OpenFileImgLogo.FileName <> "" Then
            imglogin = OpenFileImgLogo.FileName
            PictureBoxLoginNew.Image = Drawing.Image.FromFile(imglogin)
        End If
    End Sub

    Private Sub btnACloginImageSave_Click(sender As Object, e As EventArgs) Handles btnACloginImageSave.Click
            If MessageBox.Show("ต้องการบันทึกข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If imglogin <> Nothing Then
                    Try
                        cmd = New MySqlCommand("UPDATE ver_detail SET ver_imglogin=@vi", ConnectionDB)
                        cmd.Parameters.AddWithValue("@vi", ConvertImageFiletoBytes(imglogin))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        PictureBoxLoginOld.Image = PictureBoxLoginNew.Image
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    imglogin = Nothing
                    PictureBoxLoginNew.Image = Nothing
                    PictureBoxLoginNew.BackColor = Color.Empty
                    PictureBoxLoginNew.Invalidate()
                End If
            End If
    End Sub

    Private Sub btnACappnameSave_Click(sender As Object, e As EventArgs) Handles btnACappnameSave.Click
        If MessageBox.Show("ต้องการบันทึกข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                cmd = New MySqlCommand("update ver_detail set ver_company=@vc", ConnectionDB)
                cmd.Parameters.AddWithValue("@vc", Me.txtACappnameSave.Text)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub btnACtextlogin_Click(sender As Object, e As EventArgs) Handles btnACtextlogin.Click

        If MessageBox.Show("ต้องการบันทึกข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                cmd = New MySqlCommand("update ver_detail set ver_version=@vv", ConnectionDB)
                cmd.Parameters.AddWithValue("@vv", Me.txtACtextlogin.Text)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
       
    End Sub

    Private Sub UndoToolStripButtonFF_Click(sender As Object, e As EventArgs)
        Call loadVerDetail()
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.UndoToolStripButton.Enabled = True
        Call EnableTextBox_GroupBox2()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If MessageBox.Show("ต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                cmd = New MySqlCommand("UPDATE company SET footer1=@f1,footer2=@f2,footer3=@f3,com_sendrepairrow1=@cs1," _
                    & "com_sendrepairrow2=@cs2,com_sendrepairrow3=@cs3,com_Invoice=@ci,com_quotation=@cq," _
                    & "com_billing=@cb,com_claims=@cm,com_qjob=@qj,com_pledge=@cpl,com_recipt=@crc", ConnectionDB)
                cmd.Parameters.AddWithValue("@f1", Me.txtACTextFooter1.Text)
                cmd.Parameters.AddWithValue("@f2", Me.txtACTextFooter2.Text)
                cmd.Parameters.AddWithValue("@f3", Me.txtACTextFooter3.Text)
                cmd.Parameters.AddWithValue("@cs1", Me.txtACSendRepairRow1.Text)
                cmd.Parameters.AddWithValue("@cs2", Me.txtACSendRepairRow2.Text)
                cmd.Parameters.AddWithValue("@cs3", Me.txtACSendRepairRow3.Text)
                cmd.Parameters.AddWithValue("@ci", Me.txtACInvoice.Text)
                cmd.Parameters.AddWithValue("@cq", Me.txtACtxtQuotation.Text)
                cmd.Parameters.AddWithValue("@cb", Me.txtACBilling.Text)
                cmd.Parameters.AddWithValue("@cm", Me.txtACclaimsbill.Text)
                cmd.Parameters.AddWithValue("@qj", Me.txtACqJob.Text)
                cmd.Parameters.AddWithValue("@cpl", Me.txtACpladge.Text)
                cmd.Parameters.AddWithValue("@crc", Me.txtACrecipt.Text)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Call loadDataBill()
                Call DisableTextBox_GroupBox2()
                MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งให้ทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        Call loadDataBill()
        Call DisableTextBox_GroupBox2()
    End Sub

    '-------------------------------------------------เลขบิล----------------------------------------------------
    Friend Sub loadVerDetaildg()
        Try
            Me.dgDocMan.Rows.Clear()
            cmd = New MySqlCommand("SELECT `ver`,`ver_detail`,`format`,`num_total`,`ver_name`,`dat`,`id`,`y_reset` FROM ver_name GROUP BY `ver`;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgDocMan
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Tag = Dr.Item("ver")
                    .Rows(r).Cells(0).Value = Dr.Item("ver_name")
                    .Rows(r).Cells(1).Value = Dr.Item("ver_detail")
                    .Rows(r).Cells(2).Value = Dr.Item("format")
                    .Rows(r).Cells(3).Value = Dr.Item("dat")
                    .Rows(r).Cells(4).Value = Dr.Item("num_total")
                    Dim yreset As Integer = Dr.Item("y_reset")
                    If yreset = 0 Then
                        .Rows(r).Cells(5).Value = "ไม่"
                    Else
                        .Rows(r).Cells(5).Value = "ใช่"
                    End If

                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Event dgALButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)

    Private Sub dgDocMan_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgDocMan.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            RaiseEvent dgALButtonClick(senderGrid, e)
        End If
    End Sub

    Private Sub dgDocMan_ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles Me.dgALButtonClick
        Try
            DocmanEditFrm.txtNameDoc.Tag = Me.dgDocMan.CurrentRow.Cells(0).Tag
        Catch ex As Exception
            DocmanEditFrm.txtNameDoc.Tag = Nothing
        End Try
        Try
            DocmanEditFrm.txtNameDoc.Text = Me.dgDocMan.CurrentRow.Cells(0).Value
        Catch ex As Exception
            DocmanEditFrm.txtNameDoc.Text = Nothing
        End Try
        Try
            DocmanEditFrm.txtFname.Text = Me.dgDocMan.CurrentRow.Cells(1).Value
        Catch ex As Exception
            DocmanEditFrm.txtFname.Text = Nothing
        End Try
        Try
            DocmanEditFrm.cbbFormat.Text = Me.dgDocMan.CurrentRow.Cells(2).Value
        Catch ex As Exception
            DocmanEditFrm.cbbFormat.Text = Nothing
        End Try
        Try
            DocmanEditFrm.txtdat.Text = Me.dgDocMan.CurrentRow.Cells(3).Value
        Catch ex As Exception
            DocmanEditFrm.txtdat.Text = Nothing
        End Try
        Try
            DocmanEditFrm.cbbNumTotal.Text = Me.dgDocMan.CurrentRow.Cells(4).Value
        Catch ex As Exception
            DocmanEditFrm.cbbNumTotal.Text = Nothing
        End Try

        Try
            DocmanEditFrm.cbby_reset.Text = Me.dgDocMan.CurrentRow.Cells(5).Value
        Catch ex As Exception
            DocmanEditFrm.cbby_reset.Text = "ใช่"
        End Try

        DocmanEditFrm.ShowDialog(Me)
    End Sub

    Private Sub rbStatus()
        If ReadIni(FileConfigINI_mcode, "importune", "status", "") = "1" Then
            rbimportuneOpen.Checked = True
        ElseIf ReadIni(FileConfigINI_mcode, "importune", "status", "") = "0" Then
            rbimportuneClose.Checked = True
        End If
    End Sub

    Private Sub rbCheckedChanged()
        If rbimportuneOpen.Checked = True Then
            writeIni(FileConfigINI_mcode, "importune", "status", "1")
        ElseIf rbimportuneClose.Checked = True Then
            writeIni(FileConfigINI_mcode, "importune", "status", "0")
        End If
    End Sub

    Private Sub rbimportuneClose_CheckedChanged(sender As Object, e As EventArgs) Handles rbimportuneClose.CheckedChanged
        Call rbCheckedChanged()
    End Sub

    Private Sub rbimportuneOpen_CheckedChanged(sender As Object, e As EventArgs) Handles rbimportuneOpen.CheckedChanged
        Call rbCheckedChanged()
    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CulTimer()
        Dim ttimer As Integer = ReadIni(FileConfigINI_mcode, "importune", "time", "")
        Dim setnumber As Integer = ttimer / 1000
        Me.cbbTime.Text = setnumber
    End Sub

    Private Sub cbbTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbTime.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbTime_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbTime.SelectedValueChanged
        Dim timer_time As Integer = Nothing
        timer_time = CInt(Me.cbbTime.Text) * 1000
        writeIni(FileConfigINI_mcode, "importune", "time", timer_time.ToString)
        MainFrm.TimerImportune.Stop()
        MainFrm.TimerImportune.Interval = ReadIni(FileConfigINI_mcode, "importune", "time", "")
        MainFrm.TimerImportune.Start()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/appconfig/configapp")
        Catch ex As Exception

        End Try
    End Sub
End Class