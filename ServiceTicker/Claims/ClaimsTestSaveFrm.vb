Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsTestSaveFrm
    Friend Sub getDataClaimsSNtoTextBox(ByVal snp As String)
        Try
            strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,symptom,datetime_save,datetime_edit FROM " _
                & "claims WHERE serial_pro='" & snp & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                Me.txtCTRcus_id.Text = .Item("customer_id")
                Me.txtCTRclaims_id.Text = .Item("claims_id")
                Me.txtCTRclaims_sn.Text = .Item("serial_pro")
                Me.txtCTRclaims_code_pro.Text = .Item("code_pro")
                Me.txtCTR_claims_barcode.Text = .Item("bar_code")
                Me.txtCTRclaims_namepro.Text = .Item("name_pro")
                Me.txtCTRclaims_sytom.Text = .Item("symptom")
                Me.txtCTRclaims_datetime_save.Text = .Item("datetime_save")
                Me.txtCTRclaims_datetime_send.Text = .Item("datetime_edit")
            End With
            Me.txtCTRcus_id.Text = ClaimsTestResultsFrm.dgCTR.CurrentRow.Cells(2).Value
            Me.txtCTRcus_name.Text = ClaimsTestResultsFrm.dgCTR.CurrentRow.Cells(3).Value
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SaveTest(ByVal claims_id As String)
        Try
            strSQL = "UPDATE claims SET status='" & "ทดสอบแล้ว" & "',datetime_edit='" & _
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                & "employee='" & ClaimsTestResultsFrm.lblEmployee.Text & "' WHERE claims_id='" & claims_id & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'update claims send status
            strSQL = "UPDATE claims_send SET claims_send_status='" & "ทดสอบแล้ว" & "',datetime_edit='" & _
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                & "employee='" & ClaimsTestResultsFrm.lblEmployee.Text & "' WHERE claims_id='" & claims_id & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "UPDATE claims_test_results SET fix_by_company='" & Me.txtCTRclaims_correction.Text & "'," _
                & "test_results='" & IIf(Me.rbCTRtestPass.Checked = True, "past", "fail") & "'," _
                & "test_note='" & IIf(Me.rbCTRtestNoPass.Checked = True, Me.txtCTRtest_note.Text, "past") & "'," _
                & "datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                & "WHERE claims_id='" & claims_id & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call ClaimsTestResultsFrm.loadDataClaims()
        Me.Close()
    End Sub

    Private Sub ClaimsTestSaveFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call ClaimsTestResultsFrm.loadDataClaims()
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsTestSaveFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub btnCTRcancel_Click(sender As Object, e As EventArgs) Handles btnCTRcancel.Click
        Me.Close()
    End Sub

    Private Sub btnCTRsave_Click(sender As Object, e As EventArgs) Handles btnCTRsave.Click
        If Me.txtCTRclaims_correction.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาระบุผลการแก้ไขจากบริษัท", "ระบุผลการแก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Timer1.Start()
            numT = 0
            Me.txtCTRclaims_correction.BackColor = Color.Red
            Me.txtCTRclaims_correction.Focus()
            Exit Sub
        End If

        If Me.rbCTRtestPass.Checked = False And Me.rbCTRtestNoPass.Checked = False Then
            MessageBox.Show(Me, "กรุณาระบุว่าทดสอบผ่านหรือไม่ผ่าน", "ระบุผลการทดสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Timer3.Start()
            numT2 = 0
            Me.rbCTRtestPass.BackColor = Color.Red
            Me.rbCTRtestNoPass.BackColor = Color.Red
            Exit Sub
        End If

        If Me.rbCTRtestNoPass.Checked = True Then
            If Me.txtCTRtest_note.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาระบุผลการทดสอบว่าไม่ผ่านเพราะอะไร", "ระบุผลการทดสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Timer2.Start()
                numT1 = 0
                Me.txtCTRtest_note.BackColor = Color.Red
                Me.txtCTRtest_note.Focus()
                Exit Sub
            End If
        End If
        If MessageBox.Show(Me, "ต้องการบันทึกผลการทดสอบสินค้าเคลม", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Call SaveTest(Me.txtCTRclaims_id.Text)
        End If
    End Sub

    Dim numT As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If Me.txtCTRclaims_correction.BackColor = Color.Red Then
                Me.txtCTRclaims_correction.BackColor = SystemColors.Window
            Else
                Me.txtCTRclaims_correction.BackColor = Color.Red
                numT = numT + 1
            End If

            If numT = 5 Then
                Me.txtCTRclaims_correction.BackColor = SystemColors.Window
                Me.Timer1.Stop()
            End If
    End Sub

    Dim numT1 As Integer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.txtCTRtest_note.BackColor = Color.Red Then
            Me.txtCTRtest_note.BackColor = SystemColors.Window
        Else
            Me.txtCTRtest_note.BackColor = Color.Red
            numT1 = numT1 + 1
        End If

        If numT1 = 5 Then
            Me.txtCTRtest_note.BackColor = SystemColors.Window
            Me.Timer2.Stop()
        End If
    End Sub

    Dim numT2 As Integer
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.rbCTRtestPass.BackColor = Color.Red Then
            Me.rbCTRtestPass.BackColor = SystemColors.Control
        Else
            Me.rbCTRtestPass.BackColor = Color.Red
        End If

        If Me.rbCTRtestNoPass.BackColor = Color.Red Then
            Me.rbCTRtestNoPass.BackColor = SystemColors.Control
        Else
            Me.rbCTRtestNoPass.BackColor = Color.Red
            numT2 = numT2 + 1
        End If
        If numT2 = 5 Then
            Me.rbCTRtestPass.BackColor = SystemColors.Control
            Me.rbCTRtestNoPass.BackColor = SystemColors.Control
            Me.Timer3.Stop()
        End If
    End Sub

    Private Sub rbCheck()
        If Me.rbCTRtestPass.Checked = True Then
            Me.txtCTRtest_note.Enabled = False
        ElseIf Me.rbCTRtestNoPass.Checked = True Then
            Me.txtCTRtest_note.Enabled = True
        End If

    End Sub

    Private Sub rbCTRtestPass_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTRtestPass.CheckedChanged
        Call rbCheck()
    End Sub

    Private Sub rbCTRtestNoPass_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTRtestNoPass.CheckedChanged
        Call rbCheck()
    End Sub
End Class