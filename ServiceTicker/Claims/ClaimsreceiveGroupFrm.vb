Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ClaimsreceiveGroupFrm

    Private Sub ClaimsreceiveGroupFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsreceiveGroupFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Dim staX As String
    Friend Stringnewsn As String
    Friend Sub getDataClaim()
        Try
            strSQL = "SELECT `status` FROM claims WHERE serial_pro='" & Me.txtCRGsearchSN.Text & "' AND `status`='" & "ส่งเคลม" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                staX = Dr.GetString("status")
            Else
                MsgBox("ไม่พบข้อมูล " & Me.txtCRGsearchSN.Text, MsgBoxStyle.Information, "แจ้งเตือน")
                Me.txtCRGsearchSN.Clear()
                Me.txtCRGsearchSN.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If staX = "ส่งเคลม" Then

            If Me.txtCRGsearchSN.Text <> Nothing Then
                ClaimsreceiveGroupAddSNFrm.txtoldSN.Text = Me.txtCRGsearchSN.Text
                ClaimsreceiveGroupAddSNFrm.ShowDialog(Me)

                If Me.dgCRG.Rows.Count = 0 Then
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCRGsearchSN.Text & "' AND `status`='" & "ส่งเคลม" & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dim r As Integer
                        While (Dr.Read())
                            With Me.dgCRG
                                r = .RowCount
                                .Rows.Add()
                                .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                .Rows(r).Cells(6).Value = Stringnewsn
                                .Rows(r).Cells(7).Value = Dr.Item("name_pro")
                                .Rows(r).Cells(8).Value = Dr.Item("type")
                                .Rows(r).Cells(9).Value = Dr.Item("unit")
                                .Rows(r).Cells(10).Value = Dr.Item("datetime_save")
                                Me.txtCRGlastSN.Text = Me.txtCRGsearchSN.Text
                            End With
                        End While
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Me.txtCRGsearchSN.Clear()
                    Me.txtCRGsearchSN.Focus()
                Else
                    For g As Integer = 0 To dgCRG.Rows.Count - 1
                        If Me.dgCRG.Rows(g).Cells(5).Value = Me.txtCRGsearchSN.Text Then
                            MsgBox("มีข้อมูล " & Me.txtCRGsearchSN.Text & " อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Me.txtCRGsearchSN.Clear()
                            Me.txtCRGsearchSN.Focus()
                            Exit Sub
                        End If
                        If Me.dgCRG.Rows(g).Cells(6).Value = Stringnewsn Then
                            MsgBox("มีข้อมูล " & Stringnewsn & " อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Me.txtCRGsearchSN.Clear()
                            Me.txtCRGsearchSN.Focus()
                            Exit Sub
                        End If
                    Next
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit," _
                            & "datetime_save FROM claims WHERE serial_pro='" & Me.txtCRGsearchSN.Text & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCRG
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Stringnewsn
                                    .Rows(r).Cells(7).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(8).Value = Dr.Item("type")
                                    .Rows(r).Cells(9).Value = Dr.Item("unit")
                                    .Rows(r).Cells(10).Value = Dr.Item("datetime_save")
                                    Me.txtCRGlastSN.Text = Me.txtCRGsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Me.txtCRGsearchSN.Clear()
                    Me.txtCRGsearchSN.Focus()
                End If
            End If
        Else
            MsgBox("สินค้านี้มีสถานะ " & staX & " สินค้าต้องมีสถานะ ส่งเคลม เท่านั้น จึงจะสามารถรับสินค้าเคลมเข้าได้", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.txtCRGsearchSN.Clear()
            Me.txtCRGsearchSN.Focus()
        End If
        Call sumDG()
    End Sub

    Private Sub sumDG()
        For ggg As Integer = 0 To dgCRG.Rows.Count - 1
            Me.dgCRG.Rows(ggg).Cells(0).Value = ggg + 1
        Next
        Me.txtCRGtotal.Text = Me.dgCRG.Rows.Count
    End Sub

    Private Sub InsertData()
        For gg As Integer = 0 To dgCRG.Rows.Count - 1
            Dim n As String = Me.dgCRG.Rows(gg).Cells(1).Value
            Try
                'update claims status
                strSQL = "UPDATE claims SET serial_pro='" & Me.dgCRG.Rows(gg).Cells(6).Value & "',status='" & "รอทดสอบ" & "'," _
                    & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                        CultureInfo.CreateSpecificCulture("en-US")) & "',employee='" & Me.lblEmployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'update claims send status
                strSQL = "UPDATE claims_send SET claims_send_status='" & "รอทดสอบ" & "',datetime_edit='" & _
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) _
                    & "',employee='" & Me.lblEmployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'นำเข้าไปฐานข้อมูลทดสอบสินค้า
            Try
                strSQL = "INSERT INTO claims_test_results(claims_id,fix_by_company,old_sn,new_sn,test_results,test_note,datetime_save)" _
                    & "VALUES(@claims_id,@fix_by_company,@old_sn,@new_sn,@test_results,@test_note,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@claims_id", Me.dgCRG.Rows(gg).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@fix_by_company", "-"))
                    .Parameters.Add(New MySqlParameter("@old_sn", Me.dgCRG.Rows(gg).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@new_sn", Me.dgCRG.Rows(gg).Cells(6).Value))
                    .Parameters.Add(New MySqlParameter("@test_results", "-"))
                    .Parameters.Add(New MySqlParameter("@test_note", "-"))
                    .Parameters.Add(New MySqlParameter("@datetime_save", "-"))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
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
                strSQLite = "INSERT INTO claims_send_r_report(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy," _
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
                    .Parameters.Add(New SQLite.SQLiteParameter("@serial_pro", Me.dgCRG.Rows(gg).Cells(6).Value))
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

        If MessageBox.Show(Me, "ต้องการพิมพ์ใบรับเข้าของเคลมหรือไม่", "พิมพ์รับเข้าเคลม", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If checkPrinter() = "A4" Then
                ClaimsreceiveReportA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ClaimsreceiveReportA5PrintFrm.ShowDialog(Me)
            End If
        End If

        MsgBox("บันทึกข้อมูลแล้ว สินค้าจะอยู่ในสถานะรอทดสอบ", MsgBoxStyle.Information, "แจ้งเตือน")
        Try
            cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM claims_send_r_report", connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.dgCRG.Rows.Clear()
        Me.txtCRGtotal.Clear()
        Me.txtCRGlastSN.Clear()
        Call sumDG()
    End Sub

    Private Sub txtCPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCRGsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCRGsearchSN.Text = "" Then
            Else
                Call getDataClaim()
            End If
        End If
    End Sub

    Private Sub btnCPsave_Click(sender As Object, e As EventArgs) Handles btnCRGsave.Click
        If Me.dgCRG.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลเคลมในตาราง", MsgBoxStyle.Exclamation, "No Data")
        Else
            If MessageBox.Show("โปรดแน่ใจว่าข้อมูลถูกต้องก่อนการบันทึก คุณต้องการจะบันทึกข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call InsertData()
            Else
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClaimsTestResultsSelectSNFrm1.ShowDialog(Me)
    End Sub

    Private Sub DelToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelToolStripMenu.Click
        If MessageBox.Show(Me, "แน่ใจว่าจะลบข้อมูลนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim a As Integer = Me.dgCRG.SelectedRows.Count - 1
            Me.dgCRG.Rows.Remove(Me.dgCRG.SelectedRows(a))
            Me.dgCRG.Refresh()
            Call sumDG()
        End If
    End Sub

    Private Sub ClearToolStripMenu_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenu.Click
        If MessageBox.Show(Me, "แน่ใจว่าจะลบข้อมูลทั้งหมด", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.dgCRG.Rows.Clear()
            Call sumDG()
        End If
    End Sub

    Dim oldData As Object
    Private Sub dgCRG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCRG.CellDoubleClick
        Me.dgCRG.ReadOnly = False
        oldData = Me.dgCRG.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgCRG_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCRG.CellEndEdit
        Me.dgCRG.CurrentRow.Cells(e.ColumnIndex).Value = oldData
        Me.dgCRG.ReadOnly = True
    End Sub

    Private Sub dgCRG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCRG.CellMouseClick
        If dgCRG.RowCount <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgCRG.Rows(e.RowIndex).Selected = True
                Me.dgCRG.CurrentCell = Me.dgCRG.Rows(e.RowIndex).Cells(0)
                Me.DelContextMenu.Show(Me.dgCRG, e.Location)
                Me.DelContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/managerclaimssendout/claimsreceivegroupfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class