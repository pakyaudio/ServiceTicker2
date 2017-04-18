Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsStatusFrm

    Private Sub ClaimsStatusFrm_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ClaimsStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.cbbCSclaimsStatus.Items.Clear()
        Me.cbbCSclaimsStatus.Items.Add("รับเข้าระบบ")
        Me.cbbCSclaimsStatus.Items.Add("ส่งเคลม")
        Me.cbbCSclaimsStatus.Items.Add("ส่งไปงานช่าง")
        Me.cbbCSclaimsStatus.Items.Add("รอคืนเงิน")
        Me.cbbCSclaimsStatus.Items.Add("ซ่อมเสร็จ")
        Me.cbbCSclaimsStatus.Items.Add("รอส่งคืน")
        Call getdataClaims(400, Nothing)
    End Sub

    Friend Sub getdataClaims(ByVal strsqlSelect As Integer, ByVal where As String)
        Try
            Me.dgCS.Rows.Clear()
            If strsqlSelect = 100 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save " _
                  & "FROM claims WHERE status='" & where & "';"
            ElseIf strsqlSelect = 200 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save " _
                  & "FROM claims WHERE Not `status`='ส่งคืนแล้ว';"
            ElseIf strsqlSelect = 300 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims WHERE "
                Dim strKeyWord As String = where
                If strKeyWord <> "" Then
                    strSQL = strSQL & "serial_pro like '%" & strKeyWord & "%';"
                End If
            ElseIf strsqlSelect = 400 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,`status`,tel_to_cus,datetime_save FROM claims" _
                & " WHERE NOT `status`='รอส่งคืน';"
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCS
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("symptom")
                        .Rows(r).Cells(7).Value = Dr.Item("status")
                        .Rows(r).Cells(8).Value = Dr.Item("tel_to_cus")
                        .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(10).Value = Dr.Item("note2")
                        .Rows(r).Cells(11).Value = Dr.Item("note")
                    End With
                End While
            End Using
            For sum As Integer = 0 To Me.dgCS.Rows.Count - 1
                Me.dgCS.Rows(sum).Cells(0).Value = sum + 1
                If Me.dgCS.Rows(sum).Cells(2).Value = "สินค้าจากสต็อก" Then
                    With Me.dgCS
                        .Rows(sum).Cells(3).Value = "-"
                    End With
                Else
                    strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgCS.Rows(sum).Cells(2).Value & "'"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                        With Me.dgCS
                            .Rows(sum).Cells(3).Value = Dr.Item("customer_name")
                        End With
                    End Using
                End If
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbCSclaimsStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbCSclaimsStatus.SelectedValueChanged
        Call getdataClaims(100, Me.cbbCSclaimsStatus.Text)
    End Sub
    Friend Sub UpdateStatusClaims()
        Try
            'update claims send
            strSQL = "UPDATE claims_send SET claims_send_status='ส่งคืนแล้ว'," _
                & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                               CultureInfo.CreateSpecificCulture("en-US")) & "' WHERE claims_id='" & Me.dgCS.CurrentRow.Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ย้ายข้อมูลงานเคลมที่ส่งคืนแล้ว
            strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale," _
                & "price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money," _
                & "employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                & "SELECT * FROM claims WHERE claims_id='" & Me.dgCS.CurrentRow.Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "DELETE FROM claims WHERE claims_id='" & Me.dgCS.CurrentRow.Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call ClaimsImportProFrm.getDataClaims()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend SendMoneyClaims As Boolean
    Private Sub GetSatustClaims()
        Try
            If Me.dgCS.Rows.Count <> 0 Then
                If Me.dgCS.SelectedCells.Item(7).Value = "รับเข้าระบบ" Then
                    EditClaimsStatusFrm.txtECSclaimsID.Text = Me.dgCS.SelectedCells.Item(1).Value
                    EditClaimsStatusFrm.txtECScus_id.Text = Me.dgCS.SelectedCells.Item(2).Value
                    EditClaimsStatusFrm.txtECScus_name.Text = Me.dgCS.SelectedCells.Item(3).Value
                    EditClaimsStatusFrm.ShowDialog(Me)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ส่งเคลม" Then
                    MessageBox.Show(Me, "สถานะ ส่งเคลม จัดการข้อมูลส่งเคลมที่ งานเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> รับเข้าสินค้าเคลม (หากสินค้ามาแล้ว)", "จัดการสินค้าเคลม",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "รอทดสอบ" Then
                    MessageBox.Show(Me, "สถานะ รอทดสอบ จัดการข้อมูลส่งเคลมที่ งานเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> ทดสอบสินค้าเคลม", "จัดการสินค้าเคลม",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ทดสอบแล้ว" Then
                    MessageBox.Show(Me, "สถานะ ทดสอบแล้ว จัดการข้อมูลส่งเคลมที่ งานเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> นำเข้าสินค้าเคลม", "จัดการสินค้าเคลม",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ส่งไปงานช่าง" Then
                    MessageBox.Show(Me, "สถานะ ส่งไปงานช่าง ต้องรองานช่างส่งข้อมูลกลับมางานเคลมกลับมาที่ส่วนเคลม", "จัดการสินค้าเคลม",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ส่งซ่อม" Then
                    MessageBox.Show(Me, "สถานะ ส่งซ่อม ต้องรองานช่างส่งข้อมูลกลับมางานเคลมกลับมาที่ส่วนเคลม", "จัดการสินค้าเคลม",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "รอคืนเงิน" Then
                    SendMoneyClaims = True
                    Call ReturnsProductFrm.SearchSaleIDbySN(Me.dgCS.CurrentRow.Cells(4).Value)
                    ReturnsProductFrm.ShowDialog(Me)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ซ่อมเสร็จ" Then
                    ClaimsComfixBackFrm.lblEmployee.Text = Me.lblEmployee.Text
                    ClaimsComfixBackFrm.getdataClaims(Me.dgCS.CurrentRow.Cells(4).Value)
                    ClaimsComfixBackFrm.ShowDialog(Me)
                ElseIf Me.dgCS.SelectedCells.Item(7).Value = "รอส่งคืน" Then
                    ReturnClaimstoCus1Frm.lblEmployee.Text = Me.lblEmployee.Text
                    ReturnClaimstoCus1Frm.getdataClaims(Me.dgCS.CurrentRow.Cells(1).Value)
                    ReturnClaimstoCus1Frm.ShowDialog(Me)
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub dgCS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCS.CellDoubleClick
        Call GetSatustClaims()
    End Sub

    Private Sub btnCSshowAll_Click(sender As Object, e As EventArgs) Handles btnCSshowAll.Click
        Call getdataClaims(200, Nothing)
    End Sub

    Private Sub dgCS_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCS.CellMouseClick
        If Me.dgCS.Rows.Count <> 0 Then
            Me.btnCSeditteltocus.Enabled = True
        End If
    End Sub
    Friend teltocustel As String
    Private Sub btnCSeditteltocus_Click(sender As Object, e As EventArgs) Handles btnCSeditteltocus.Click
        If Me.dgCS.SelectedCells.Item(2).Value = "สินค้าจากสต็อก" Then
            MsgBox("สินค้าของร้าน ไม่ต้องโทรบอกใครหรอกครับ", MsgBoxStyle.Information, "NO Tel")
        Else
            Try
                strSQL = "SELECT customer_name,customer_tel FROM customer WHERE customer_id='" & Me.dgCS.SelectedCells.Item(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                teltocustel = Dr.GetString("customer_name") & " เบอร์โทร " & Dr.GetString("customer_tel")
                ClaimsTeltoCusFrm.lblCTCclaims_id.Text = Me.dgCS.SelectedCells.Item(1).Value
                ClaimsTeltoCusFrm.ShowDialog(Me)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub txtSearchStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSearchStatus.Text <> Nothing Then
                Call getdataClaims(300, Me.txtSearchStatus.Text)
                Call GetSatustClaims()
                Me.txtSearchStatus.Clear()
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/claimsstatusfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class