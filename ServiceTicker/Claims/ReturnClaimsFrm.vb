Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel

Public Class ReturnClaimsFrm

    Private Sub ReturnClaimsFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReturnClaimsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
        Me.lblEmployee.Text = EditClaimsStatusFrm.lblEmployee.Text
    End Sub

    Private Sub cbbRCtel_to_cus_Click(sender As Object, e As EventArgs) Handles cbbRCtel_to_cus.Click
        Me.cbbRCtel_to_cus.Items.Clear()
        Me.cbbRCtel_to_cus.Items.Add("ยังไม่ได้แจ้ง")
        Me.cbbRCtel_to_cus.Items.Add("แจ้งแล้ว")
        Me.lblRCtel_to_cus.BackColor = SystemColors.Control
    End Sub

    Private Sub btnRCcencel_Click(sender As Object, e As EventArgs) Handles btnRCcencel.Click
        Me.Close()
    End Sub
    Private Sub saveDataClaims()
        Try
            strSQL = "UPDATE claims SET claims_money='" & Me.txtRCclaims_money.Text & "'," _
                 & "employee_claims_return='" & Me.lblEmployee.Text & "'," _
                 & "tel_to_cus='" & Me.cbbRCtel_to_cus.Text & "'," _
                 & "status='รอส่งคืน'," _
                 & "datetime_return='" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss",
                                                                                            CultureInfo.CreateSpecificCulture("en-US")) & "'" _
                 & "WHERE claims_id='" & Me.txtRCclaimsID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnRCsave_Click(sender As Object, e As EventArgs) Handles btnRCsave.Click

        If Me.cbbRCtel_to_cus.Text = String.Empty Then
            Me.lblRCtel_to_cus.BackColor = Color.OrangeRed
            MsgBox("เลือกการแจ้งลูกค้าด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        ElseIf Me.txtRCnote.Text = String.Empty Then
            Me.txtRCnote.BackColor = Color.OrangeRed
            MsgBox("ระบุการซ่อมแซมแก้ไขจากทางบริษัท(ถ้ามี หากไม่มีให้ - ไว้)", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        Else
            If MessageBox.Show(Me, "โปรดตรวจสอบข้อมูลให้เรียบร้อยถูกต้องก่อนบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MsgBox("การส่งข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Exit Sub
            Else
                Call saveDataClaims()
            End If
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            ClaimsStatusFrm.getdataClaims(100, "รอส่งคืน")
            EditClaimsStatusFrm.Close()
            Me.Close()
        End If
    End Sub

    Private Sub txtRCclaims_money_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRCclaims_money.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtRCnote_Click(sender As Object, e As EventArgs) Handles txtRCnote.Click
        Me.txtRCnote.BackColor = SystemColors.Window
    End Sub

    Private Sub btnRCtelCUS_Click(sender As Object, e As EventArgs) Handles btnRCtelCUS.Click
        Try
            strSQL = "SELECT customer_tel FROM customer WHERE customer_id='" & EditClaimsStatusFrm.txtECScus_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Me.lblRCtel.Text = "TEL : " & Dr.Item("customer_tel")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
End Class