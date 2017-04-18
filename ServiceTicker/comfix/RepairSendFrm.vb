Imports System.Globalization

Public Class RepairSendFrm
#Region "Code"
    Friend Sub LoadData()
        Try
            Me.dgRSF.Rows.Clear()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT id,send_name,send_address,send_contact FROM comfix_send_ex ORDER BY send_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    With Me.dgRSF
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Tag = Dr.Item("id")
                        .Rows(r).Cells(1).Value = Dr.Item("send_name")
                        .Rows(r).Cells(2).Value = Dr.Item("send_address")
                        .Rows(r).Cells(3).Value = Dr.Item("send_contact")
                    End With
                End While
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub RepairSendFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub RepairSendFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub RepairSendFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadData()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.dgRSF.SelectedRows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM comfix_send_ex WHERE id='" & Me.dgRSF.CurrentRow.Cells(1).Tag & "';", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Call LoadData()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Me.dgRSF.SelectedRows.Count <> 0 Then
            RepairSendAddEditFrm.Text = "แก้ไข"
            RepairSendAddEditFrm.txtSend_name.Tag = Me.dgRSF.CurrentRow.Cells(1).Tag
            RepairSendAddEditFrm.txtSend_name.Text = Me.dgRSF.CurrentRow.Cells(1).Value
            RepairSendAddEditFrm.txtSend_Address.Text = Me.dgRSF.CurrentRow.Cells(2).Value
            RepairSendAddEditFrm.txtSend_contact.Text = Me.dgRSF.CurrentRow.Cells(3).Value
            RepairSendAddEditFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub dgRSF_SelectionChanged(sender As Object, e As EventArgs) Handles dgRSF.SelectionChanged
        If Me.dgRSF.SelectedRows.Count <> 0 Then
            Me.btnEdit.Visible = True
            Me.btnDel.Visible = True
            Me.btnSelect.Visible = True
        Else
            Me.btnEdit.Visible = False
            Me.btnDel.Visible = False
            Me.btnSelect.Visible = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        RepairSendAddEditFrm.Text = "เพิ่ม"
        RepairSendAddEditFrm.ShowDialog(Me)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If MessageBox.Show(Me, "เมื่อบันทึกจะไม่สามารถลบหรือแก้ไขได้อีก โปรดแน่ใจว่าข้อมูลถูกต้อง", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "INSERT INTO comfix_note(note,key_note,etc,datetime_save)VALUES(@note,@key_note,@etc,@datetime_save)"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.Parameters.AddWithValue("@note", "ส่งซ่อม" & Me.dgRSF.CurrentRow.Cells(1).Value & " " & Me.dgRSF.CurrentRow.Cells(2).Value & " " & Me.dgRSF.CurrentRow.Cells(3).Value)
                cmd.Parameters.AddWithValue("@key_note", RepairStatusFrm.txtRSfix_id.Text)
                cmd.Parameters.AddWithValue("@etc", RepairStatusFrm.lblEmployee.Text)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call RepairStatusFrm.GetComfix_note(RepairStatusFrm.txtRSfix_id.Text)
            Me.Close()
        End If
    End Sub
End Class