Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ClaimsPrepareFrm

    Private Sub ClaimsPrepareFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsPrepareFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
    Friend selectCompanyClaims As Integer
    Private Sub ClaimsPrepareFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        selectCompanyClaims = 100
        ClaimsCompanyFrm.Timer1.Start()
        ClaimsCompanyFrm.lblEmployee.Text = Me.lblEmployee.Text
        ClaimsCompanyFrm.ShowDialog(Me)
    End Sub

    Dim staX As String
    Private Sub getDataClaim()
        Try
            strSQL = "SELECT `status` FROM claims WHERE serial_pro='" & Me.txtCPsearchSN.Text & "' AND status='รับเข้าระบบ';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                staX = Dr.GetString("status")
            Else
                MsgBox("ไม่พบข้อมูล " & Me.txtCPsearchSN.Text, MsgBoxStyle.Information, "แจ้งเตือน")
                Me.txtCPsearchSN.Clear()
                Me.txtCPsearchSN.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If staX = "รับเข้าระบบ" Then
            If Me.txtCPsearchSN.Text = "" Then
            Else
                If Me.dgCP.Rows.Count = 0 Then
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM " _
                            & "claims WHERE serial_pro='" & Me.txtCPsearchSN.Text & "' AND status='รับเข้าระบบ';"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCP
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(7).Value = Dr.Item("type")
                                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                                    Me.txtCPlastSN.Text = Me.txtCPsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Me.txtCPsearchSN.Clear()
                    Me.txtCPsearchSN.Focus()
                Else
                    For g As Integer = 0 To dgCP.Rows.Count - 1
                        If Me.dgCP.Rows(g).Cells(5).Value = Me.txtCPsearchSN.Text Then
                            MsgBox("มีข้อมูล " & Me.txtCPsearchSN.Text & " อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Me.txtCPsearchSN.Clear()
                            Me.txtCPsearchSN.Focus()
                            Exit Sub
                        End If
                    Next
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM " _
                            & "claims WHERE serial_pro='" & Me.txtCPsearchSN.Text & "' AND status='รับเข้าระบบ';"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCP
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(7).Value = Dr.Item("type")
                                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                                    Me.txtCPlastSN.Text = Me.txtCPsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Me.txtCPsearchSN.Clear()
                    Me.txtCPsearchSN.Focus()
                End If
            End If
        Else
            MsgBox("สินค้านี้มีสถานะ " & staX & " สินค้าต้องมีสถานะ รับเข้าระบบ เท่านั้น จึงจะสามารถทำเตรียมส่งเคลมได้", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.txtCPsearchSN.Clear()
            Me.txtCPsearchSN.Focus()
        End If
        Call sumRow()
        Me.dgCP.ClearSelection()
    End Sub
    Private Sub InsertData()

        For gg As Integer = 0 To dgCP.Rows.Count - 1
            Dim n As String = Me.dgCP.Rows(gg).Cells(1).Value
            'ส่งไป claims_send
            Try
                strSQL = "INSERT INTO claims_send(claims_id,claims_company,claims_company_id,claims_note,claims_send_status,datetime_edit,datetime_save,employee)" _
                    & "VALUES(@claims_id,@claims_company,@claims_company_id,@claims_note,@claims_send_status,@datetime_edit,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@claims_id", Me.dgCP.Rows(gg).Cells(1).Value)
                    .Parameters.AddWithValue("@claims_company", Me.txtCPclaimCompanyName.Text)
                    .Parameters.AddWithValue("@claims_company_id", Me.txtCPclamCompanyID.Text)
                    .Parameters.AddWithValue("@claims_note", "-")
                    .Parameters.AddWithValue("@claims_send_status", "เตรียมส่งเคลม")
                    .Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    .Parameters.AddWithValue("@datetime_save", Me.dgCP.Rows(gg).Cells(9).Value)
                    .Parameters.AddWithValue("@employee", Me.lblEmployee.Text)
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'update claims status
                strSQL = "UPDATE claims SET status='" & "เตรียมส่งเคลม" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                    CultureInfo.CreateSpecificCulture("en-US")) & "',employee='" & Me.lblEmployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "SELECT * FROM claims WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQLite = "INSERT INTO claims_send_report(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy," _
                    & "price_wholesale,price_technician,price_loyal,price_members,`type`,unit,datetime_sale,datetime_return," _
                    & "datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note," _
                    & "note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "VALUES(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro,@price_buy," _
                    & "@price_wholesale,@price_technician,@price_loyal,@price_members,@type,@unit,@datetime_sale,@datetime_return," _
                    & "@datetime_edit,@claims_money,@employee_claims_return,@tel_to_cus,@employee_sale,@symptom,@accressory,@note," _
                    & "@note2,@status,@employee,@datetime_save,@claims_id_pic)"
                cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                With cmdSQLite
                    .Parameters.Add(New SQLite.SQLiteParameter("@claims_id", Dr.Item("claims_id")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@customer_id", Dr.Item("customer_id")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@serial_pro", Dr.Item("serial_pro")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@code_pro", Dr.Item("code_pro")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@bar_code", Dr.Item("bar_code")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@name_pro", Dr.Item("name_pro")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@price_buy", Dr.Item("price_buy")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@price_wholesale", Dr.Item("price_wholesale")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@price_technician", Dr.Item("price_technician")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@price_loyal", Dr.Item("price_loyal")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@price_members", Dr.Item("price_members")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@type", Dr.Item("type")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@unit", Dr.Item("unit")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@datetime_sale", Dr.Item("datetime_sale")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@datetime_return", Dr.Item("datetime_return")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@datetime_edit", Dr.Item("datetime_edit")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@claims_money", Dr.Item("claims_money")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@employee_claims_return", Dr.Item("employee_claims_return")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@tel_to_cus", Dr.Item("tel_to_cus")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@employee_sale", Dr.Item("employee_sale")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@symptom", Dr.Item("symptom")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@accressory", Dr.Item("accressory")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@note", Dr.Item("note")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@note2", Dr.Item("note2")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@status", Dr.Item("status")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@employee", Dr.Item("employee")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@datetime_save", Dr.Item("datetime_save")))
                    .Parameters.Add(New SQLite.SQLiteParameter("@claims_id_pic", Dr.Item("claims_id_pic")))
                End With
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            n = Nothing
        Next
        If MessageBox.Show(Me, "ต้องการจะพิมพ์ใบเตรียมส่งเคลมหรือไม่", "พิมพ์รายงาน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If checkPrinter() = "A4" Then
                ClaimsSendReportA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ClaimsSendReportA5PrintFrm.ShowDialog(Me)
            End If
        End If

        Try
            cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM claims_send_report", connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        MsgBox("บันทึกเตรียมส่งเคลมแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Me.Close()
    End Sub

    Private Sub txtCPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataClaim()
        End If
    End Sub

    Private Sub btnCPsave_Click(sender As Object, e As EventArgs) Handles btnCPsave.Click
        If Me.dgCP.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลเคลมในตาราง", MsgBoxStyle.Exclamation, "No Data")
        Else
            If MessageBox.Show("โปรดแน่ใจว่าข้อมูลถูกต้องก่อนการบันทึก คุณต้องการจะบันทึกข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call InsertData()
            End If
        End If
    End Sub
    Dim oldData As Object
    Private Sub dgCP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCP.CellDoubleClick
        Me.dgCP.ReadOnly = False
        oldData = Me.dgCP.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgCP_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCP.CellEndEdit
        Me.dgCP.CurrentRow.Cells(e.ColumnIndex).Value = oldData
        Me.dgCP.ReadOnly = True
    End Sub

    Private Sub dgCP_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCP.CellMouseClick
        If dgCP.RowCount <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgCP.Rows(e.RowIndex).Selected = True
                Me.dgCP.CurrentCell = Me.dgCP.Rows(e.RowIndex).Cells(0)
                Me.DelContextMenu.Show(Me.dgCP, e.Location)
                Me.DelContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dgCP_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgCP.RowStateChanged
        If Me.dgCP.Rows.Count = 0 Then
            Me.btnCPsave.Enabled = False
        Else
            Me.btnCPsave.Enabled = True
        End If
    End Sub

    Private Sub DelToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelToolStripMenu.Click
        If MessageBox.Show(Me, "แน่ใจว่าจะลบข้อมูลเตรียมงานเคลมนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim a As Integer = Me.dgCP.SelectedRows.Count - 1
            Me.dgCP.Rows.Remove(Me.dgCP.SelectedRows(a))
            Me.dgCP.Refresh()
            Call sumRow()
        End If
    End Sub

    Private Sub sumRow()
        For ggg As Integer = 0 To Me.dgCP.Rows.Count - 1
            Me.dgCP.Rows(ggg).Cells(0).Value = ggg + 1
        Next
        Me.txtCPtotal.Text = Me.dgCP.Rows.Count
    End Sub

    Private Sub ClearToolStripMenu_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenu.Click
        If MessageBox.Show(Me, "แน่ใจว่าจะลบข้อมูลเตรียมงานเคลมนี้ทั้งหมด", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.dgCP.Rows.Clear()
            Call sumRow()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/managerclaimssendout/claimspreparefrm")
        Catch ex As Exception

        End Try
    End Sub
End Class
