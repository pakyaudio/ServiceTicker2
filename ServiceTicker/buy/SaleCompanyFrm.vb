Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SaleCompanyFrm
    Private Sub AutoNumberNo()
        Dim newID As Integer = Nothing
        Try
            cmd = New MySqlCommand("SELECT Max(ID) as ID FROM sale_company_id;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                newID = CInt(Dr.Item("id"))
                newID += 1
            Else
                newID = 1
            End If
            Me.txtSCid.Text = newID.ToString("00000")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "INSERT INTO sale_company_id(sale_company_name,sale_company_id,datetime_save)" _
                    & "VALUES(@sale_company_name,@sale_company_id,@datetime_save)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@sale_company_name", "-")
            cmd.Parameters.AddWithValue("@sale_company_id", Me.txtSCid.Text)
            cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Dim strSQLget As Integer
    Private Sub getDataSale_Company()
        Me.dgSC.Rows.Clear()
        If strSQLget = 100 Then
            strSQL = "SELECT sale_company_id,sale_company_name,sale_company_address," & _
                "sale_company_tel,sale_company_fax,sale_company_contact,sale_company_line," & _
                "sale_company_email,sale_company_facebook,sale_company_website,sale_company_tax FROM sale_company WHERE sale_company_id"
        ElseIf strSQLget = 200 Then
            strSQL = "SELECT sale_company_id,sale_company_name,sale_company_address," & _
                "sale_company_tel,sale_company_fax,sale_company_contact,sale_company_line," & _
                "sale_company_email,sale_company_facebook,sale_company_website,sale_company_tax " & _
                "FROM sale_company WHERE sale_company_name LIKE '%" & Me.txtSCsearch.Text & "%'"
        End If
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim tt As Integer
                With Me.dgSC
                    tt = .Rows.Count
                    .Rows.Add()
                    .Rows(tt).Cells(0).Value = Dr.GetString("sale_company_id")
                    .Rows(tt).Cells(1).Value = Dr.GetString("sale_company_name")
                    .Rows(tt).Cells(2).Value = Dr.GetString("sale_company_address")
                    .Rows(tt).Cells(3).Value = Dr.GetString("sale_company_tel")
                    .Rows(tt).Cells(4).Value = Dr.GetString("sale_company_contact")
                    .Rows(tt).Cells(5).Value = Dr.GetString("sale_company_fax")
                    .Rows(tt).Cells(6).Value = Dr.GetString("sale_company_line")
                    .Rows(tt).Cells(7).Value = Dr.GetString("sale_company_email")
                    .Rows(tt).Cells(8).Value = Dr.GetString("sale_company_facebook")
                    .Rows(tt).Cells(9).Value = Dr.GetString("sale_company_website")
                    .Rows(tt).Cells(10).Value = Dr.GetString("sale_company_tax")
                End With
            End While
            strSQLget = Nothing
            Me.dgSC.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub DeleteData()
        If MessageBox.Show(Me, "คุณแน่ใจว่าต้องการลบข้อมูลนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            cmd = New MySqlCommand("DELETE FROM sale_company WHERE sale_company_id='" & Me.txtSCid.Text & "'", ConnectionDB)
            Call open_connection()
            Try
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    MessageBox.Show(Me, "ลบข้อมูลแล้ว", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
        Me.dgSC.ClearSelection()
        Call getDataSale_Company()
        Call startfrm()
    End Sub
    Private Sub startfrm()
        strSQLget = 100
        Call ClearTextBoxes(Me)
        Me.dgSC.Enabled = True
        Me.txtSCid.Clear()
        Me.txtSCname.Clear()
        Me.txtSCaddress.Clear()
        Me.txtSCtel.Clear()
        Me.txtSCcontact.Clear()
        Me.txtSCfax.Clear()
        Me.txtSCline.Clear()
        Me.txtSCemail.Clear()
        Me.txtSCfacebook.Clear()
        Me.txtSCwebsite.Clear()
        Me.txtSCtax.Clear()
        Me.txtSCtax.Text = "00000000000000"
        '---------------------------
        Me.txtSCid.Enabled = False
        Me.txtSCname.Enabled = False
        Me.txtSCaddress.Enabled = False
        Me.txtSCtel.Enabled = False
        Me.txtSCcontact.Enabled = False
        Me.txtSCfax.Enabled = False
        Me.txtSCline.Enabled = False
        Me.txtSCemail.Enabled = False
        Me.txtSCfacebook.Enabled = False
        Me.txtSCwebsite.Enabled = False
        Me.txtSCtax.Enabled = False
        '----------------------------
        Me.NewToolStripButton.Enabled = True
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = False
        Me.UndoToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

    End Sub

    Private Sub dgSC_MouseClick(sender As Object, e As MouseEventArgs) Handles dgSC.MouseClick
        Try
            Me.txtSCid.Text = Me.dgSC.CurrentRow.Cells(0).Value
            Me.txtSCname.Text = Me.dgSC.CurrentRow.Cells(1).Value
            Me.txtSCaddress.Text = Me.dgSC.CurrentRow.Cells(2).Value
            Me.txtSCtel.Text = Me.dgSC.CurrentRow.Cells(3).Value
            Me.txtSCcontact.Text = Me.dgSC.CurrentRow.Cells(4).Value
            Me.txtSCfax.Text = Me.dgSC.CurrentRow.Cells(5).Value
            Me.txtSCline.Text = Me.dgSC.CurrentRow.Cells(6).Value
            Me.txtSCemail.Text = Me.dgSC.CurrentRow.Cells(7).Value
            Me.txtSCfacebook.Text = Me.dgSC.CurrentRow.Cells(8).Value
            Me.txtSCwebsite.Text = Me.dgSC.CurrentRow.Cells(9).Value
            Me.txtSCtax.Text = Me.dgSC.CurrentRow.Cells(10).Value
            Me.NewToolStripButton.Enabled = False
            Me.EditToolStripButton.Enabled = True
            Me.SaveToolStripButton.Enabled = False
            Me.UndoToolStripButton.Enabled = True
            Me.DeleteToolStripButton.Enabled = True
            Me.BackToolStripButton.Enabled = True
            Me.NextToolStripButton.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaleCompanyFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub SaleCompanyfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
        strSQLget = 100
        Call getDataSale_Company()
    End Sub
    Private Sub btnSCdel_Click(sender As Object, e As EventArgs)
        Call DeleteData()
    End Sub
   
    Private Sub btnSCsearch_Click(sender As Object, e As EventArgs) Handles btnSCsearch.Click
        strSQLget = 200
        Call getDataSale_Company()
        Call startfrm()
        Me.txtSCsearch.Clear()
    End Sub
    Private Sub btnSCgetallData_Click(sender As Object, e As EventArgs) Handles btnSCgetallData.Click
        strSQLget = 100
        Call getDataSale_Company()
        Call startfrm()
    End Sub

    Private Sub txtSCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strSQLget = 200
            Call getDataSale_Company()
            Call startfrm()
            Me.txtSCsearch.Clear()
        End If
    End Sub

    Private Function CheckNoting() As Boolean
        If Me.txtSCname.Text = "" Then
            MsgBox("กรุณาใส่ชื่อ", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCname.Focus()
            Me.txtSCname.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCaddress.Text = "" Then
            MsgBox("กรุณาใส่ที่อยู่ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCaddress.Focus()
            Me.txtSCaddress.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCcontact.Text = "" Then
            MsgBox("กรุณาใส่ผู้ติดต่อ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCcontact.Focus()
            Me.txtSCcontact.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCtel.Text = "" Then
            MsgBox("กรุณาใส่เบอร์โทร หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCtel.Focus()
            Me.txtSCtel.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCfax.Text = "" Then
            MsgBox("กรุณาใส่เบอร์แฟกซ์ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCfax.Focus()
            Me.txtSCfax.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCline.Text = "" Then
            MsgBox("กรุณาใส่ Line หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCline.Focus()
            Me.txtSCline.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCfacebook.Text = "" Then
            MsgBox("กรุณาใส่ FaceBook หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCfacebook.Focus()
            Me.txtSCfacebook.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCemail.Text = "" Then
            MsgBox("กรุณาใส่ Email หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCemail.Focus()
            Me.txtSCemail.BackColor = Color.Salmon
            Return False
        ElseIf Me.txtSCwebsite.Text = "" Then
            MsgBox("กรุณาใส่ WebSite หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCwebsite.Focus()
            Me.txtSCwebsite.BackColor = Color.Salmon
            Return False

        ElseIf Me.txtSCtax.Text = "" Then
            MsgBox("กรุณาใส่หมายเลขผู้เสียภาษี หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
            Me.txtSCtax.Focus()
            Me.txtSCtax.BackColor = Color.Salmon
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub EnableTextBox()
        Me.txtSCname.Enabled = True
        Me.txtSCaddress.Enabled = True
        Me.txtSCtel.Enabled = True
        Me.txtSCcontact.Enabled = True
        Me.txtSCfax.Enabled = True
        Me.txtSCline.Enabled = True
        Me.txtSCemail.Enabled = True
        Me.txtSCfacebook.Enabled = True
        Me.txtSCwebsite.Enabled = True
        Me.txtSCtax.Enabled = True
    End Sub

    Private Sub DisableTextBox()
        Me.txtSCname.Enabled = False
        Me.txtSCaddress.Enabled = False
        Me.txtSCtel.Enabled = False
        Me.txtSCcontact.Enabled = False
        Me.txtSCfax.Enabled = False
        Me.txtSCline.Enabled = False
        Me.txtSCemail.Enabled = False
        Me.txtSCfacebook.Enabled = False
        Me.txtSCwebsite.Enabled = False
        Me.txtSCtax.Enabled = False
    End Sub
    Private Sub SaveDataAndUpdate()
        If SelectSave = 100 Then
            If CheckNoting() = True Then
                If MessageBox.Show(Me, "ต้องการเพิ่มข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        strSQL = "INSERT INTO sale_company(sale_company_id,sale_company_name,sale_company_address," _
                            & "sale_company_tel,sale_company_fax,sale_company_contact,sale_company_line,sale_company_email," _
                            & "sale_company_facebook,sale_company_website,sale_company_tax)VALUES" _
                            & "(@sale_company_id,@sale_company_name,@sale_company_address," _
                            & "@sale_company_tel,@sale_company_fax,@sale_company_contact,@sale_company_line,@sale_company_email," _
                            & "@sale_company_facebook,@sale_company_website,@sale_company_tax)"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@sale_company_id", Me.txtSCid.Text)
                        cmd.Parameters.AddWithValue("@sale_company_name", Me.txtSCname.Text)
                        cmd.Parameters.AddWithValue("@sale_company_address", Me.txtSCaddress.Text)
                        cmd.Parameters.AddWithValue("@sale_company_tel", Me.txtSCtel.Text)
                        cmd.Parameters.AddWithValue("@sale_company_fax", Me.txtSCfax.Text)
                        cmd.Parameters.AddWithValue("@sale_company_contact", Me.txtSCcontact.Text)
                        cmd.Parameters.AddWithValue("@sale_company_line", Me.txtSCline.Text)
                        cmd.Parameters.AddWithValue("@sale_company_email", Me.txtSCemail.Text)
                        cmd.Parameters.AddWithValue("@sale_company_facebook", Me.txtSCfacebook.Text)
                        cmd.Parameters.AddWithValue("@sale_company_website", Me.txtSCwebsite.Text)
                        cmd.Parameters.AddWithValue("@sale_company_tax", Me.txtSCtax.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "บันทึกข้อมูล")
                    Call ClearTextBoxes(Me)
                    Me.dgSC.ClearSelection()
                    SelectSave = Nothing
                    strSQLget = 100
                    Call getDataSale_Company()
                    Call startfrm()
                End If
            End If
        ElseIf SelectSave = 200 Then
            If CheckNoting() = True Then
                If MessageBox.Show(Me, "ต้องการแก้ไข", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        strSQL = "UPDATE sale_company SET sale_company_id='" & Me.txtSCid.Text & "'," _
                             & "sale_company_name='" & Me.txtSCname.Text & "'," _
                             & "sale_company_address='" & Me.txtSCaddress.Text & "'," _
                             & "sale_company_tel='" & Me.txtSCtel.Text & "'," _
                             & "sale_company_contact='" & Me.txtSCcontact.Text & "'," _
                             & "sale_company_fax='" & Me.txtSCfax.Text & "'," _
                             & "sale_company_line='" & Me.txtSCline.Text & "'," _
                             & "sale_company_email='" & Me.txtSCemail.Text & "'," _
                             & "sale_company_facebook='" & Me.txtSCfacebook.Text & "'," _
                             & "sale_company_website='" & Me.txtSCwebsite.Text & "'," _
                             & "sale_company_tax='" & Me.txtSCtax.Text & "'" _
                             & " WHERE sale_company_id='" & Me.txtSCid.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Me.dgSC.ClearSelection()
                    SelectSave = Nothing
                    strSQLget = 100
                    Call getDataSale_Company()
                    Call startfrm()
                End If
            End If
        End If
    End Sub
    Dim SelectSave As Integer
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Call EnableTextBox()
        Call AutoNumberNo()
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.UndoToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.dgSC.Enabled = False
        SelectSave = 100
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        Call EnableTextBox()
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.UndoToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.dgSC.Enabled = False
        SelectSave = 200
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        Call startfrm()
        Me.dgSC.ClearSelection()
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Call DeleteData()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Call SaveDataAndUpdate()
    End Sub

    Private Sub txtSCaddress_Click(sender As Object, e As EventArgs) Handles txtSCaddress.Click
        If Me.txtSCaddress.Enabled = True And Me.txtSCaddress.BackColor = Color.Salmon Then
            Me.txtSCaddress.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCcontact_Click(sender As Object, e As EventArgs) Handles txtSCcontact.Click
        If Me.txtSCcontact.Enabled = True And Me.txtSCcontact.BackColor = Color.Salmon Then
            Me.txtSCcontact.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCemail_Click(sender As Object, e As EventArgs) Handles txtSCemail.Click
        If Me.txtSCemail.Enabled = True And Me.txtSCemail.BackColor = Color.Salmon Then
            Me.txtSCemail.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCfacebook_Click(sender As Object, e As EventArgs) Handles txtSCfacebook.Click
        If Me.txtSCfacebook.Enabled = True And Me.txtSCfacebook.BackColor = Color.Salmon Then
            Me.txtSCfacebook.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCfax_Click(sender As Object, e As EventArgs) Handles txtSCfax.Click
        If Me.txtSCfax.Enabled = True And Me.txtSCfax.BackColor = Color.Salmon Then
            Me.txtSCfax.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCid_Click(sender As Object, e As EventArgs) Handles txtSCid.Click
        If Me.txtSCid.Enabled = True And Me.txtSCid.BackColor = Color.Salmon Then
            Me.txtSCid.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCline_Click(sender As Object, e As EventArgs) Handles txtSCline.Click
        If Me.txtSCline.Enabled = True And Me.txtSCline.BackColor = Color.Salmon Then
            Me.txtSCline.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCname_Click(sender As Object, e As EventArgs) Handles txtSCname.Click
        If Me.txtSCname.Enabled = True And Me.txtSCname.BackColor = Color.Salmon Then
            Me.txtSCname.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCtax_Click(sender As Object, e As EventArgs) Handles txtSCtax.Click
        If Me.txtSCtax.Enabled = True And Me.txtSCtax.BackColor = Color.Salmon Then
            Me.txtSCtax.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCtel_Click(sender As Object, e As EventArgs) Handles txtSCtel.Click
        If Me.txtSCtel.Enabled = True And Me.txtSCtel.BackColor = Color.Salmon Then
            Me.txtSCtel.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtSCwebsite_Click(sender As Object, e As EventArgs) Handles txtSCwebsite.Click
        If Me.txtSCwebsite.Enabled = True And Me.txtSCwebsite.BackColor = Color.Salmon Then
            Me.txtSCwebsite.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub getDataByRow()
        Try
            Me.txtSCid.Text = Me.dgSC.CurrentRow.Cells(0).Value
            Me.txtSCname.Text = Me.dgSC.CurrentRow.Cells(1).Value
            Me.txtSCaddress.Text = Me.dgSC.CurrentRow.Cells(2).Value
            Me.txtSCtel.Text = Me.dgSC.CurrentRow.Cells(3).Value
            Me.txtSCcontact.Text = Me.dgSC.CurrentRow.Cells(4).Value
            Me.txtSCfax.Text = Me.dgSC.CurrentRow.Cells(5).Value
            Me.txtSCline.Text = Me.dgSC.CurrentRow.Cells(6).Value
            Me.txtSCemail.Text = Me.dgSC.CurrentRow.Cells(7).Value
            Me.txtSCfacebook.Text = Me.dgSC.CurrentRow.Cells(8).Value
            Me.txtSCwebsite.Text = Me.dgSC.CurrentRow.Cells(9).Value
            Me.txtSCtax.Text = Me.dgSC.CurrentRow.Cells(10).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgSC.CurrentCell = Me.dgSC.Rows(Me.dgSC.CurrentCell.RowIndex - 1).Cells(0)
            Call getDataByRow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgSC.CurrentCell = Me.dgSC.Rows(Me.dgSC.CurrentCell.RowIndex + 1).Cells(0)
            Call getDataByRow()
        Catch ex As Exception

        End Try
    End Sub
    Dim oldData As Object
    Private Sub dgSC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSC.CellDoubleClick
        Me.dgSC.ReadOnly = False
        oldData = Me.dgSC.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgSC_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgSC.CellEndEdit
        Me.dgSC.ReadOnly = True
        Me.dgSC.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/buymenu/salecompanyfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class