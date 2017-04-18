Public Class RepairSendAddEditFrm
#Region "code"
    Private Sub AddData()
        If Me.txtSend_name.Text = String.Empty Then
            MessageBox.Show(Me, "กรุณาใส่ข้อมูล ชื่อร้าน/สถานที่", "ห้ามว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_name.Focus()
            Exit Sub
        End If

        If Me.txtSend_Address.Text = String.Empty Then
            MessageBox.Show(Me, "กรุณาใส่ข้อมูล ที่อยู่", "ห้ามว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_Address.Focus()
            Exit Sub
        End If

        If Me.txtSend_contact.Text = String.Empty Then
            MessageBox.Show(Me, "กรุณาใส่ข้อมูล ติดต่อ", "ห้ามว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_contact.Focus()
            Exit Sub
        End If

        If checkMySQLDruplicateDB("SELECT send_name FROM comfix_send_ex WHERE send_name='" & Me.txtSend_name.Text & "';") = True Then
            MessageBox.Show(Me, "มีชื่อนี้แล้วในฐานข้อมูล กรุณาเปลี่ยนชื่ออื่น", "ชื่อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_name.Focus()
            Exit Sub
        End If

        Try
            strSQL = "INSERT INTO comfix_send_ex(send_name,send_address,send_contact)VALUES(@send_name,@send_address,@send_contact);"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.Parameters.AddWithValue("@send_name", Me.txtSend_name.Text)
            cmd.Parameters.AddWithValue("@send_address", Me.txtSend_Address.Text)
            cmd.Parameters.AddWithValue("@send_contact", Me.txtSend_contact.Text)
            cmd.ExecuteNonQuery()
            Call RepairSendFrm.LoadData()
            Me.Close()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub EditData()
        If Me.txtSend_name.Text = String.Empty Then
            MessageBox.Show(Me, "กรุณาใส่ข้อมูล ชื่อร้าน/สถานที่", "ห้ามว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_name.Focus()
            Exit Sub
        End If

        If Me.txtSend_Address.Text = String.Empty Then
            MessageBox.Show(Me, "กรุณาใส่ข้อมูล ที่อยู่", "ห้ามว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_Address.Focus()
            Exit Sub
        End If

        If Me.txtSend_contact.Text = String.Empty Then
            MessageBox.Show(Me, "กรุณาใส่ข้อมูล ติดต่อ", "ห้ามว่าง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_contact.Focus()
            Exit Sub
        End If

        If checkMySQLDruplicateDB("SELECT send_name FROM comfix_send_ex WHERE send_name='" & Me.txtSend_name.Text & "' " _
                                  & "AND (id <> '" & Me.txtSend_name.Tag & "');") = True Then
            MessageBox.Show(Me, "มีชื่อนี้แล้วในฐานข้อมูล กรุณาเปลี่ยนชื่ออื่น", "ชื่อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSend_name.Focus()
            Exit Sub
        End If

        Try
            strSQL = "UPDATE comfix_send_ex SET send_name=@send_name,send_address=@send_address,send_contact=@send_contact WHERE id=@id;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.Parameters.AddWithValue("@id", Me.txtSend_name.Tag)
            cmd.Parameters.AddWithValue("@send_name", Me.txtSend_name.Text)
            cmd.Parameters.AddWithValue("@send_address", Me.txtSend_Address.Text)
            cmd.Parameters.AddWithValue("@send_contact", Me.txtSend_contact.Text)
            cmd.ExecuteNonQuery()
            Call RepairSendFrm.LoadData()
            Me.Close()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub RepairSendAddEditFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub RepairSendAddEditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "เพิ่ม" Then
            Call AddData()
        ElseIf Me.Text = "แก้ไข" Then
            Call EditData()
        End If
    End Sub
End Class