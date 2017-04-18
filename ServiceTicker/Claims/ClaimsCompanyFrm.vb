Imports MySql.Data.MySqlClient
Public Class ClaimsCompanyFrm
    Private Sub startFrm()
        Me.txtCCcom_name.Enabled = False
        Me.txtCCcom_address.Enabled = False
        Me.txtCCcom_contect.Enabled = False
        Me.txtCCcom_id.Clear()
        Me.txtCCcom_name.Clear()
        Me.txtCCcom_address.Clear()
        Me.txtCCcom_contect.Clear()
        Me.btnCCadd.Enabled = True
        Me.btnCCedit.Enabled = False
        Me.btnCCdel.Enabled = False
        Me.btnCCcancel.Enabled = False
        Me.btnCCadd.Text = "เพิ่ม"
        Me.btnCCedit.Text = "แก้ไข"
        Me.dgCC.Enabled = True
        strsqlsel = 100
        Call getdata()
    End Sub

    Private Sub ClaimsCompanyFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ClaimsCompanyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startFrm()
    End Sub
    Dim strsqlsel As String
    Private Sub getdata()
        Try
            Me.dgCC.Rows.Clear()
            If strsqlsel = 100 Then
                strSQL = "SELECT company_id,company_name,company_address,company_contect FROM claims_company ORDER BY company_name ASC"
            ElseIf strsqlsel = 200 Then
                strSQL = "SELECT company_id,company_name,company_address,company_contect FROM claims_company WHERE 1=1"
                Dim strKeyWord As String = Me.txtCCsearch.Text
                If strKeyWord <> "" Then
                    strSQL = strSQL & " AND company_name like '%" & strKeyWord & "%'  OR company_address like '%" & strKeyWord & "%';"
                End If
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCC
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("company_id")
                        .Rows(r).Cells(1).Value = Dr.Item("company_name")
                        .Rows(r).Cells(2).Value = Dr.Item("company_address")
                        .Rows(r).Cells(3).Value = Dr.Item("company_contect")
                    End With
                End While
            End Using
            Me.dgCC.ClearSelection()
            strsqlsel = Nothing
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub AutoNumberNo()
        Try
            cmd = New MySqlCommand("SELECT Max(ID) as ID FROM claims_company_id", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim newID As Integer = CInt(Dr.Item("ID"))
            newID += 1
            Me.txtCCcom_id.Text = newID.ToString("000")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtCCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strsqlsel = 200
            Call getdata()
            Me.txtCCsearch.Clear()
        End If
    End Sub

    Private Sub btnCCsearch_Click(sender As Object, e As EventArgs) Handles btnCCsearch.Click
        strsqlsel = 200
        Call getdata()
        Me.txtCCsearch.Clear()
    End Sub

    Private Sub btnCCadd_Click(sender As Object, e As EventArgs) Handles btnCCadd.Click
        If Me.btnCCadd.Text = "เพิ่ม" Then
            Me.btnCCadd.Text = "บันทึก"
            Call AutoNumberNo()
            Me.btnCCcancel.Enabled = True
            Me.txtCCcom_name.Enabled = True
            Me.txtCCcom_address.Enabled = True
            Me.txtCCcom_contect.Enabled = True
            Me.dgCC.Enabled = False
        ElseIf Me.btnCCadd.Text = "บันทึก" Then
            Try
                strSQL = "SELECT company_name FROM claims_company WHERE company_name='" & Me.txtCCcom_name.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            If Dr.HasRows Then
                MsgBox("ชื่อนี้ " & Me.txtCCcom_name.Text & " มีในระบบเแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtCCcom_name.BackColor = Color.OrangeRed
                Me.txtCCcom_name.Focus()
                Exit Sub
            End If
            If Me.txtCCcom_name.Text = "" Then
                Me.txtCCcom_name.BackColor = Color.OrangeRed
                Me.txtCCcom_name.Focus()
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address.Text = "" Then
                Me.txtCCcom_address.BackColor = Color.OrangeRed
                Me.txtCCcom_address.Focus()
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_contect.Text = "" Then
                Me.txtCCcom_contect.BackColor = Color.OrangeRed
                Me.txtCCcom_contect.Focus()
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If

            If MessageBox.Show(Me, "แน่ใจว่าจะบันทึก", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    strSQL = "INSERT INTO claims_company_id(claims_company_id)" _
                           & "VALUES(@claims_company_id)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@claims_company_id", Me.txtCCcom_id.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    strSQL = "INSERT INTO claims_company(company_id,company_name,company_address,company_contect)" _
                               & "VALUES(@company_id,@company_name,@company_address,@company_contect)"

                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@company_id", Me.txtCCcom_id.Text))
                        .Parameters.Add(New MySqlParameter("@company_name", Me.txtCCcom_name.Text))
                        .Parameters.Add(New MySqlParameter("@company_address", Me.txtCCcom_address.Text))
                        .Parameters.Add(New MySqlParameter("@company_contect", Me.txtCCcom_contect.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Me.btnCCadd.Text = "เพิ่ม"
                Me.dgCC.Enabled = True
                Call startFrm()
            End If
        End If
    End Sub

    Private Sub btnCCcancel_Click(sender As Object, e As EventArgs) Handles btnCCcancel.Click
        Call startFrm()
    End Sub

    Private Sub txtCCcom_name_Click(sender As Object, e As EventArgs) Handles txtCCcom_name.Click
        Me.txtCCcom_name.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCCcom_address_Click(sender As Object, e As EventArgs) Handles txtCCcom_address.Click
        Me.txtCCcom_address.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCCcom_contect_Click(sender As Object, e As EventArgs) Handles txtCCcom_contect.Click
        Me.txtCCcom_contect.BackColor = SystemColors.Window
    End Sub

    Private Sub dgCC_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCC.CellMouseDoubleClick
        Try
            Me.txtCCcom_id.Text = Me.dgCC.SelectedCells.Item(0).Value
            Me.txtCCcom_name.Text = Me.dgCC.SelectedCells.Item(1).Value
            Me.txtCCcom_address.Text = Me.dgCC.SelectedCells.Item(2).Value
            Me.txtCCcom_contect.Text = Me.dgCC.SelectedCells.Item(3).Value
            Me.btnCCadd.Enabled = False
            Me.btnCCedit.Enabled = True
            Me.btnCCdel.Enabled = True
            Me.btnCCcancel.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCCedit_Click(sender As Object, e As EventArgs) Handles btnCCedit.Click
        If Me.btnCCedit.Text = "แก้ไข" Then
            Me.btnCCedit.Text = "บันทึก"
            Me.btnCCcancel.Enabled = True
            Me.txtCCcom_name.Enabled = True
            Me.txtCCcom_address.Enabled = True
            Me.txtCCcom_contect.Enabled = True
            Me.dgCC.Enabled = False

        ElseIf Me.btnCCedit.Text = "บันทึก" Then
            Try
                strSQL = "SELECT company_id FROM claims_company WHERE company_name='" & Me.txtCCcom_name.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim cn As String
                cn = Dr.Item("company_id")
                If Dr.HasRows Then
                    If cn = Me.txtCCcom_id.Text Then
                        Exit Try
                    Else
                        MsgBox("ชื่อนี้ " & Me.txtCCcom_name.Text & " มีในระบบเแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtCCcom_name.BackColor = Color.OrangeRed
                        Me.txtCCcom_name.Focus()
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try


            If Me.txtCCcom_name.Text = "" Then
                Me.txtCCcom_name.BackColor = Color.OrangeRed
                Me.txtCCcom_name.Focus()
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address.Text = "" Then
                Me.txtCCcom_address.BackColor = Color.OrangeRed
                Me.txtCCcom_address.Focus()
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_contect.Text = "" Then
                Me.txtCCcom_contect.BackColor = Color.OrangeRed
                Me.txtCCcom_contect.Focus()
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
            If MessageBox.Show(Me, "ต้องการแก้ไข", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    strSQL = "UPDATE claims_company set company_name=@company_name,company_address=@company_address,company_contect=@company_contect " _
                        & "WHERE company_id='" & Me.txtCCcom_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@company_name", Me.txtCCcom_name.Text))
                        .Parameters.Add(New MySqlParameter("@company_address", Me.txtCCcom_address.Text))
                        .Parameters.Add(New MySqlParameter("@company_contect", Me.txtCCcom_contect.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Me.btnCCedit.Text = "แก้ไข"
                Me.dgCC.Enabled = True
                Call startFrm()
            End If
            End If
    End Sub

    Private Sub btnCCdel_Click(sender As Object, e As EventArgs) Handles btnCCdel.Click
        If MessageBox.Show(Me, "ต้องการลบข้อมูลนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Try
                strSQL = "DELETE FROM claims_company WHERE company_id='" & Me.txtCCcom_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call startFrm()
        End If
    End Sub

    Private Sub btnCCtoclaimsSend_Click(sender As Object, e As EventArgs) Handles btnCCtoclaimsSend.Click
        If Me.dgCC.RowCount <> 0 Then
            If ClaimsPrepareFrm.selectCompanyClaims = 100 Then
                ClaimsPrepareFrm.txtCPclamCompanyID.Text = Me.dgCC.SelectedCells.Item(0).Value
                ClaimsPrepareFrm.txtCPclaimCompanyName.Text = Me.dgCC.SelectedCells.Item(1).Value
                Me.Close()
            Else
                'ClaimsSendFrm.txtCScom_id.Text = Me.dgCC.SelectedCells.Item(0).Value
                'ClaimsSendFrm.txtCScom_name.Text = Me.dgCC.SelectedCells.Item(1).Value
                'ClaimsSendFrm.txtCScom_address.Text = Me.dgCC.SelectedCells.Item(2).Value
                'ClaimsSendFrm.txtCScom_contect.Text = Me.dgCC.SelectedCells.Item(3).Value
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblCCwarninig.ForeColor = Color.DarkRed
        If lblCCwarninig.Visible = True Then
            lblCCwarninig.Visible = False
        Else
            lblCCwarninig.Visible = True
        End If

    End Sub
End Class