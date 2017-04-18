Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class SNFrm

    Private Sub SNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
    End Sub
    Dim snid As String
    Private Sub AutoNumberNo()
        'Try
        '    cmd = New MySqlCommand("SELECT Max(id) as ID FROM sn_id", ConnectionDB)
        '    Call open_connection()
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    If Not Dr.HasRows Then
        '        Me.txtSNNumber.Text = Now.ToString("yyMMdd", CultureInfo.CreateSpecificCulture("en-US")) & "0001"
        '    Else
        '        Dim newID As Integer = CInt(Dr.Item("ID"))
        '        newID += 1
        '        Me.txtSNNumber.Text = Now.ToString("yyMMdd", CultureInfo.CreateSpecificCulture("en-US")) & newID.ToString("0000")
        '    End If
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try

        Call ALLAutonumber("ver_sn", snid)
        Me.txtSNNumber.Text = snid
    End Sub

    Private Sub startfrm()
        Me.dgSN.ClearSelection()
        'Me.PictureBox1.Image = Nothing
        If Me.cbSNautoSN.CheckState = CheckState.Checked Then
            Me.cbSNautoSN.CheckState = CheckState.Unchecked
        End If
        'clear
        Me.txtSNNumber.Clear()
        Me.cbbP_Type.Items.Clear()
        Me.cbbP_Name.Items.Clear()
        Me.cbbP_model.Items.Clear()
        Me.cbbP_color.Items.Clear()
        Me.SearchToolStripTextBox.Clear()
        Me.dgSN.Enabled = True
        'btn
        Me.SearchToolStripButton.Enabled = True
        Me.ShowAllToolStripButton.Enabled = True
        Me.NewToolStripButton.Enabled = True
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = False
        Me.CancelToolStripButton.Enabled = False
        Me.DelToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        'txt
        Me.SearchToolStripTextBox.Enabled = True
        Me.txtSNNumber.Enabled = False
        Me.cbbP_Type.Enabled = False
        Me.cbbP_Name.Enabled = False
        Me.cbbP_model.Enabled = False
        Me.cbbP_color.Enabled = False
        Me.cbSNautoSN.Enabled = False
        'Me.captureImg.Enabled = False
    End Sub

    Private Sub GetAllData()
        Dim LM As String = Nothing
        If Me.ToolStripComboBox1.Text = Nothing Then
            LM = Nothing
        Else
            LM = "LIMIT " & Me.ToolStripComboBox1.Text
        End If
        Try
            Me.dgSN.Rows.Clear()
            cmd = New MySqlCommand("SELECT Snum,p_type,p_name,model,color,startdate FROM " _
                                   & "sn ORDER BY startdate DESC " & LM & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer = Nothing
            While (Dr.Read())
                With Me.dgSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("Snum")
                    .Rows(r).Cells(2).Value = Dr.Item("p_type")
                    .Rows(r).Cells(3).Value = Dr.Item("p_name")
                    .Rows(r).Cells(4).Value = Dr.Item("model")
                    .Rows(r).Cells(5).Value = Dr.Item("color")
                    .Rows(r).Cells(6).Value = Dr.Item("startdate")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SearchAllData()
        Try
            Me.dgSN.Rows.Clear()
            Dim strKeyWord As String = Me.SearchToolStripTextBox.Text
            strSQL = "SELECT Snum,p_type,p_name,model,color,startdate FROM sn WHERE "
            If strKeyWord <> Nothing Then
                strSQL = strSQL & "Snum LIKE '%" & strKeyWord & "%' or p_type like '%" & strKeyWord & "%' or p_name like '%" & strKeyWord & "%' or model like '%" & strKeyWord & "%' or color like '%" & strKeyWord & "%'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer = Nothing
            While (Dr.Read())
                With Me.dgSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("Snum")
                    .Rows(r).Cells(2).Value = Dr.Item("p_type")
                    .Rows(r).Cells(3).Value = Dr.Item("p_name")
                    .Rows(r).Cells(4).Value = Dr.Item("model")
                    .Rows(r).Cells(5).Value = Dr.Item("color")
                    .Rows(r).Cells(6).Value = Dr.Item("startdate")
                End With
            End While
            Me.SearchToolStripTextBox.Clear()
        Catch ex As Exception
            Me.SearchToolStripTextBox.Clear()
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_typeSN()
        Try
            Me.cbbP_Type.Items.Clear()
            cmd = New MySqlCommand("SELECT p_type FROM product_type ORDER BY p_type;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_Type.Items.Add(Dr.GetString("p_type"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getdatecombbox_nameSN()
        Try
            Me.cbbP_Name.Items.Clear()
            cmd = New MySqlCommand("SELECT p_name FROM product_name ORDER BY p_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_Name.Items.Add(Dr.GetString("p_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_modelSN()
        Try
            Me.cbbP_model.Items.Clear()
            cmd = New MySqlCommand("SELECT p_model FROM product_model WHERE p_name='" & Me.cbbP_Name.Text & "' ORDER BY p_model;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_model.Items.Add(Dr.GetString("p_model"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_colorSN()
        Try
            Me.cbbP_color.Items.Clear()
            cmd = New MySqlCommand("SELECT color FROM product_color ORDER BY color;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_color.Items.Add(Dr.GetString("color"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbP_Type_DropDown(sender As Object, e As EventArgs) Handles cbbP_Type.DropDown
        Call getdatecombbox_typeSN()
    End Sub

    Private Sub cbbP_Name_DropDown(sender As Object, e As EventArgs) Handles cbbP_Name.DropDown
        Call getdatecombbox_nameSN()
    End Sub

    Private Sub cbbP_model_DropDown(sender As Object, e As EventArgs) Handles cbbP_model.DropDown
        Call getdatecombbox_modelSN()
    End Sub

    Private Sub cbbP_color_DropDown(sender As Object, e As EventArgs) Handles cbbP_color.DropDown
        Call getdatecombbox_colorSN()
    End Sub

    Private Sub ShowAllToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripButton.Click
        Call GetAllData()
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        If Me.SearchToolStripTextBox.Text <> Nothing Then
            Call SearchAllData()
        End If
    End Sub

    Private Sub SearchToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchToolStripTextBox.KeyDown
        If Me.SearchToolStripTextBox.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Call SearchAllData()
            End If
        End If
    End Sub

    Private Sub cbSNautoSN_CheckStateChanged(sender As Object, e As EventArgs) Handles cbSNautoSN.CheckStateChanged
        If Me.cbSNautoSN.Checked Then
            Call AutoNumberNo()
            Me.txtSNNumber.Enabled = False
        Else
            Me.txtSNNumber.Clear()
            Me.txtSNNumber.Enabled = True
        End If
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgSN.CurrentCell = Me.dgSN.Rows(Me.dgSN.CurrentCell.RowIndex - 1).Cells(0)
            Call dgSNclick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgSN.CurrentCell = Me.dgSN.Rows(Me.dgSN.CurrentCell.RowIndex + 1).Cells(0)
            Call dgSNclick()
        Catch ex As Exception

        End Try
    End Sub
    Dim SelectSave As Integer = Nothing
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        SelectSave = 100
        If Me.cbSNautoSN.CheckState = CheckState.Checked Then
            Me.cbSNautoSN.CheckState = CheckState.Unchecked
        End If

        'clear
        Me.txtSNNumber.Clear()
        Me.cbbP_Type.Items.Clear()
        Me.cbbP_Name.Items.Clear()
        Me.cbbP_model.Items.Clear()
        Me.cbbP_color.Items.Clear()
        Me.cbbP_Type.Text = Nothing
        Me.cbbP_Name.Text = Nothing
        Me.cbbP_model.Text = Nothing
        Me.cbbP_color.Text = Nothing
        Me.SearchToolStripTextBox.Clear()
        Me.dgSN.Enabled = False
        'btn
        Me.SearchToolStripButton.Enabled = False
        Me.ShowAllToolStripButton.Enabled = False
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DelToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        'txt
        Me.SearchToolStripTextBox.Enabled = False
        Me.txtSNNumber.Enabled = True
        Me.cbbP_Type.Enabled = True
        Me.cbbP_Name.Enabled = True
        Me.cbbP_model.Enabled = True
        Me.cbbP_color.Enabled = True
        Me.cbSNautoSN.Enabled = True
        'Me.captureImg.Enabled = True
        'Me.PictureBox1.Image = Nothing
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrm()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If SelectSave = 100 Then
            Call AddNewSN()
        ElseIf SelectSave = 200 Then
            Call editdata()
        End If
    End Sub

    Private Function CHKsn(ByVal nSN As String) As Boolean
        Try
            cmd = New MySqlCommand("SELECT Snum FROM sn WHERE Snum='" & nSN & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
        Catch ex As Exception

        End Try
        If Dr.HasRows Then
            If nSN = "-" Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Sub AddNewSN()
        If Me.txtSNNumber.Text <> Nothing Then
            If CHKsn(Me.txtSNNumber.Text) = True Then
                MessageBox.Show(Me, "SN ห้ามซ้ำกัน กรุณาเปลี่ยนไปใช้ SN ตัวอื่นเพื่อบันทึกข้อมูลประวัติ", "SN ซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf CHKsn(Me.txtSNNumber.Text) = False Then
                If Me.cbbP_Type.Text = Nothing Then
                    MsgBox("กรุณาเลือกประเภทสินค้า", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                    Timer1.Start()
                    Me.cbbP_Type.Focus()
                    Me.cbbP_Type.BackColor = Drawing.Color.Salmon
                ElseIf Me.cbbP_Name.Text = Nothing Then
                    MsgBox("กรุณาเลือกยี่ห้อ", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                    Timer1.Start()
                    Me.cbbP_Name.Focus()
                    Me.cbbP_Name.BackColor = Drawing.Color.Salmon
                ElseIf Me.cbbP_model.Text = Nothing Then
                    MsgBox("กรุณาใส่รุ่น หรือ - หากไม่มีข้อมูล", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                    Timer1.Start()
                    Me.cbbP_model.Focus()
                    Me.cbbP_model.BackColor = Drawing.Color.Salmon
                ElseIf Me.cbbP_color.Text = Nothing Then
                    MsgBox("กรุณาใส่สี หรือ - หากไม่มีข้อมูล", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                    Timer1.Start()
                    Me.cbbP_color.Focus()
                    Me.cbbP_color.BackColor = Drawing.Color.Salmon
                Else
                    If MessageBox.Show(Me, "ต้องการเพิ่มข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Try
                            cmd = New MySqlCommand("INSERT INTO sn(Snum,p_type,p_name,model,color,startdate)" _
                                & "VALUES('" & Me.txtSNNumber.Text & "','" & Me.cbbP_Type.Text & "'," _
                                & "'" & Me.cbbP_Name.Text & "','" & Me.cbbP_model.Text & "','" & Me.cbbP_color.Text & "', Now());", ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try

                        'ไม่ใช้แล้ว เก็บรูปซ้ำซ้อนกับงานซ่อม ใช้เก็บตอนรับซ่อมก็น่าจะพอแล้ว
                        'If Not PictureBox1.Image Is Nothing Then
                        '    Try
                        '        Dim mStream As New MemoryStream()
                        '        PictureBox1.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        '        Dim PicByte As Byte() = mStream.ToArray
                        '        cmd = New MySqlCommand("UPDATE sn SET sn_img=@snimg WHERE Snum='" & Me.txtSNNumber.Text & "';", ConnectionDB)
                        '        cmd.Parameters.AddWithValue("@snimg", PicByte)
                        '        Call open_connection()
                        '        cmd.ExecuteNonQuery()
                        '    Catch ex As Exception
                        '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        '    End Try
                        'End If

                        'If Me.cbSNautoSN.Checked Then
                        '    Try
                        '        cmd = New MySqlCommand("INSERT INTO sn_id(sn_id)VALUES('" & Me.txtSNNumber.Text & "');", ConnectionDB)
                        '        Call open_connection()
                        '        cmd.ExecuteNonQuery()
                        '    Catch ex As Exception
                        '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        '    End Try
                        'End If


                        Try
                            cmd = New MySqlCommand("SELECT p_name,p_model FROM product_model WHERE " _
                                                   & "p_name='" & Me.cbbP_Name.Text & "' AND p_model='" & Me.cbbP_model.Text & "'", ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dr.Read()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try

                        If Not Dr.HasRows Then
                            Try
                                cmd = New MySqlCommand("INSERT INTO product_model(p_name,p_model)VALUES" _
                                    & "('" & Me.cbbP_Name.Text & "','" & Me.cbbP_model.Text & "')", ConnectionDB)
                                Call open_connection()
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                            End Try
                        End If
                        Call GetAllData()
                        Call startfrm()
                        SelectSave = Nothing
                        MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txtSNNumber.BackColor = SystemColors.Window
        Me.cbbP_Type.BackColor = SystemColors.Window
        Me.cbbP_Name.BackColor = SystemColors.Window
        Me.cbbP_model.BackColor = SystemColors.Window
        Me.cbbP_color.BackColor = SystemColors.Window
        Timer1.Stop()
    End Sub

    Private Sub editdata()
        If Me.txtSNNumber.Text <> Nothing Then

            If Me.cbbP_Type.Text = Nothing Then
                MsgBox("กรุณาเลือกประเภทสินค้า", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_Type.Focus()
                Me.cbbP_Type.BackColor = Drawing.Color.Salmon
            ElseIf Me.cbbP_Name.Text = Nothing Then
                MsgBox("กรุณาเลือกยี่ห้อ", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_Name.Focus()
                Me.cbbP_Name.BackColor = Drawing.Color.Salmon
            ElseIf Me.cbbP_model.Text = Nothing Then
                MsgBox("กรุณาใส่รุ่น หรือ - หากไม่มีข้อมูล", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_model.Focus()
                Me.cbbP_model.BackColor = Drawing.Color.Salmon
            ElseIf Me.cbbP_color.Text = Nothing Then
                MsgBox("กรุณาใส่สี หรือ - หากไม่มีข้อมูล", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_color.Focus()
                Me.cbbP_color.BackColor = Drawing.Color.Salmon
            Else
                If MessageBox.Show(Me, "ต้องการแก้ไข", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        cmd = New MySqlCommand("UPDATE sn SET Snum='" & Me.txtSNNumber.Text & "', p_type='" & Me.cbbP_Type.Text & "'," _
                            & "p_name='" & Me.cbbP_Name.Text & "', model='" & Me.cbbP_model.Text & "'," _
                            & "color='" & Me.cbbP_color.Text & "' WHERE Snum='" & Me.txtSNNumber.Text & "'" _
                            & "AND startdate='" & Me.dgSN.CurrentRow.Cells(6).Value & "'", ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    'ไม่ใช้แล้ว เก็บรูปซ้ำซ้อนกับงานซ่อม ใช้เก็บตอนรับซ่อมก็น่าจะพอแล้ว
                    'If Not PictureBox1.Image Is Nothing Then
                    '    Try
                    '        Dim mStream As New MemoryStream()
                    '        PictureBox1.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    '        Dim PicByte As Byte() = mStream.ToArray
                    '        cmd = New MySqlCommand("UPDATE sn SET sn_img=@snimg WHERE Snum='" & Me.txtSNNumber.Text & "'", ConnectionDB)
                    '        cmd.Parameters.AddWithValue("@snimg", PicByte)
                    '        Call open_connection()
                    '        cmd.ExecuteNonQuery()
                    '    Catch ex As Exception
                    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    '    End Try
                    'End If

                    Try
                        cmd = New MySqlCommand("SELECT p_name,p_model FROM " _
                            & "product_model WHERE p_name='" & Me.cbbP_Name.Text & "' " _
                            & "AND p_model='" & Me.cbbP_model.Text & "'", ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    If Not Dr.HasRows Then
                        Try
                            cmd = New MySqlCommand("INSERT INTO product_model (p_name,p_model)VALUES" _
                            & "(@p_name,@p_model)", ConnectionDB)
                            cmd.Parameters.AddWithValue("@p_name", Me.cbbP_Name.Text)
                            cmd.Parameters.AddWithValue("@p_model", Me.cbbP_model.Text)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try
                    End If
                    Call GetAllData()
                    Call startfrm()
                    SelectSave = Nothing
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        SelectSave = 200
        If Me.cbSNautoSN.CheckState = CheckState.Checked Then
            Me.cbSNautoSN.CheckState = CheckState.Unchecked
        End If

        'clear
        Me.SearchToolStripTextBox.Clear()
        Me.dgSN.Enabled = False
        'btn
        Me.SearchToolStripButton.Enabled = False
        Me.ShowAllToolStripButton.Enabled = False
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DelToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        'txt
        Me.SearchToolStripTextBox.Enabled = False
        Me.txtSNNumber.Enabled = False
        Me.cbbP_Type.Enabled = True
        Me.cbbP_Name.Enabled = True
        Me.cbbP_model.Enabled = True
        Me.cbbP_color.Enabled = True
        Me.cbSNautoSN.Enabled = False
        'Me.captureImg.Enabled = True
        'Me.PictureBox1.Image = Nothing
    End Sub


    Private Sub dgSNclick()
        Me.txtSNNumber.Text = Me.dgSN.SelectedCells(1).Value
        Me.cbbP_Type.Text = Me.dgSN.SelectedCells(2).Value
        Me.cbbP_Name.Text = Me.dgSN.SelectedCells(3).Value
        Me.cbbP_model.Text = Me.dgSN.SelectedCells(4).Value
        Me.cbbP_color.Text = Me.dgSN.SelectedCells(5).Value

        'ไม่ใช้แล้ว เก็บรูปซ้ำซ้อนกับงานซ่อม ใช้เก็บตอนรับซ่อมก็น่าจะพอแล้ว
        'Try
        '    cmd = New MySqlCommand("SELECT sn_img FROM sn WHERE Snum='" & Me.txtSNNumber.Text & "'", ConnectionDB)
        '    Call open_connection()
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    PictureBox1.Image = Byte2Image(Dr.Item("sn_img"))
        'Catch ex As Exception
        '    PictureBox1.Image = Nothing
        'End Try

        Me.EditToolStripButton.Enabled = True
        Me.DelToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = True
        Me.NextToolStripButton.Enabled = True
    End Sub

    Private Sub dgSN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSN.CellClick
        Call dgSNclick()
    End Sub

    Private Function CHKsnComfix(ByVal csn As String) As Boolean
        Try
            cmd = New MySqlCommand("SELECT sn FROM comfix WHERE sn='" & csn & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
        Catch ex As Exception
            Return False
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        If Dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub DelToolStripButton_Click(sender As Object, e As EventArgs) Handles DelToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CHKsnComfix(Me.txtSNNumber.Text) = True Then
                MessageBox.Show(Me, "ไม่สามารถลบได้ พบข้อมูล SN นี้ในระบบงานช่าง", "ไม่สามารถลบได้", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf CHKsnComfix(Me.txtSNNumber.Text) = False Then
                Try
                    cmd = New MySqlCommand("DELETE FROM sn WHERE Snum='" & Me.txtSNNumber.Text & "' AND " _
                                           & "startdate='" & Me.dgSN.CurrentRow.Cells(6).Value & "'", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Call GetAllData()
                    Call startfrm()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        End If
    End Sub

    Private Sub dgSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSN.CellMouseClick
        If Me.dgSN.Rows.Count <> 0 Then
            For Each form In My.Application.OpenForms
                If (form.name = SaveDataFixFrm.Name) Then
                    If form.Visible Then
                        If e.Button = MouseButtons.Right Then
                            Me.dgSN.Rows(e.RowIndex).Selected = True
                            Me.dgSN.CurrentCell = Me.dgSN.Rows(e.RowIndex).Cells(0)
                            Me.SendToMenu.Show(dgSN, e.Location)
                            Me.SendToMenu.Show(Cursor.Position)
                            Me.SendToMenu.Enabled = True
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub SendToComfixToolStripMenu_Click(sender As Object, e As EventArgs) Handles SendToComfixToolStripMenu.Click
        Call SaveDataFixFrm.getDataSNtoTextBox(Me.dgSN.CurrentRow.Cells(1).Value)
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixconfig/snfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class