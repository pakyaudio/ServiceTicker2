Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ReceiveProductFrm

    Dim autonum As String

    Private Sub ReceiveProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Friend Sub CountPicture()
        Me.lblAttactBill.Text = "มีเอกสารแนบจำนวน " & Me.Picture_allTableAdapter1.ScalarQuery_key_pic(Me.txtRPbuy_id.Text)
    End Sub

    Private Sub ReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
    End Sub
    Private Sub startfrm()
        Me.txtRPid.Clear()
        Me.txtRPsale_company_name.Clear()
        Me.txtRPbuy_id.Clear()
        Me.txtRPbillID.Clear()
        Me.txtRSorderID.Clear()
        Me.txtRPnamePro.Clear()
        Me.txtRPbarcode.Clear()
        Me.txtRPserialPro.Clear()
        Me.txtRPsumMoney.Clear()
        Me.txtsumBuy.Clear()
        Me.txtsumBC.Clear()
        Me.txtsumSN.Clear()
        Me.ProgressBar1.Value = 0
        Me.lblPercen.Text = Nothing
        Me.dgRPorderPro.Rows.Clear()
        Me.dgRPsn.Rows.Clear()
        Me.cbRPstatus.Items.Clear()
        Call disbleTXTinsert()
    End Sub

    Friend Sub getDatatodgRPorderpro(ByVal buy_id As String)
        Dim sta As String = String.Empty
        Try

            strSQL = "SELECT status FROM buy WHERE buy_id='" & buy_id & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            sta = Dr.Item("status")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If sta = "ยังไม่ได้รับสินค้า" Or sta = "สินค้ายังไม่ครบ" Then
            Try
                Me.dgRPorderPro.Rows.Clear()
                strSQL = "SELECT buy_id,sale_company_id,sale_company_name,code_pro,name_pro,price_cost,price_buy,count_num,get_bc,get_sn,unit FROM buy_pro WHERE buy_id='" & buy_id & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While Dr.Read()
                    With Me.dgRPorderPro
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("price_cost")
                        .Rows(r).Cells(3).Value = Dr.Item("price_buy")
                        .Rows(r).Cells(4).Value = Dr.Item("count_num")
                        .Rows(r).Cells(5).Value = Dr.Item("get_bc")
                        .Rows(r).Cells(6).Value = Dr.Item("get_sn")
                        .Rows(r).Cells(7).Value = Dr.Item("unit")
                        .Rows(r).Cells(8).Value = CDec(.Rows(r).Cells(2).Value) * CDec(.Rows(r).Cells(4).Value)
                    End With
                    Me.txtRPbuy_id.Text = Dr.Item("buy_id")
                    Me.txtRPsale_company_id.Text = Dr.Item("sale_company_id")
                    Me.txtRPsale_company_name.Text = Dr.Item("sale_company_name")
                End While
                Me.dgRPorderPro.ClearSelection()
                Call PbaCheng()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sta = "ได้รับสินค้าแล้ว" Or sta = "ยกเลิกรายการ" Then
            MessageBox.Show(Me, "สถานะ '" & sta & "' ไม่สามารถเลือกรับเข้าสินค้าได้", "ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not Dr.HasRows Then
            MessageBox.Show(Me, "ไม่พบข้อมูล", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRPselectOrder_Click(sender As Object, e As EventArgs) Handles btnRPselectOrder.Click
        Call PbaCheng()
        SelectReceiveProductFrm.ShowDialog(Me)
        If Me.dgRPorderPro.Rows.Count <> 0 Then
            If autonum = Nothing Then
                Call ALLAutonumber("ver_receive", autonum)
                Me.txtRPid.Text = autonum
            Else
                Me.txtRPid.Text = autonum
            End If
        End If
    End Sub

    Private Sub cbRPstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRPstatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbRPstatus_DropDown(sender As Object, e As EventArgs) Handles cbRPstatus.DropDown
        Me.cbRPstatus.Items.Clear()
        Me.cbRPstatus.Items.Add("ชำระเงินแล้ว")
        Me.cbRPstatus.Items.Add("ยังไม่ได้ชำระเงิน")
    End Sub

    Private Sub txtRSorderID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRSorderID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDatatodgRPorderpro(Me.txtRSorderID.Text)
            Me.txtRSorderID.Clear()
            If Me.dgRPorderPro.Rows.Count <> 0 Then
                If autonum = Nothing Then
                    Call ALLAutonumber("ver_receive", autonum)
                    Me.txtRPid.Text = autonum
                Else
                    Me.txtRPid.Text = autonum
                End If
            End If
        End If
    End Sub

    Private Sub dgRPorderPro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRPorderPro.CellClick
        If Me.dgRPorderPro.Rows.Count <> 0 Then
            Me.txtRPnamePro.Text = Me.dgRPorderPro.CurrentRow.Cells(1).Value
            Call PbaCheng()
        End If
    End Sub

    Private Sub addTodgRPsn()
        Try
            If Me.txtRPserialPro.Text <> Nothing Then
                If CInt(Me.dgRPorderPro.CurrentRow.Cells(4).Value) =
                    CInt(Me.dgRPorderPro.CurrentRow.Cells(5).Value) + CInt(Me.dgRPorderPro.CurrentRow.Cells(6).Value) Then
                    MessageBox.Show(Me, "สินค้าเกินจำนวนที่สั่งซื้อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Try
                Else
                    For checkSN As Integer = 0 To Me.dgRPsn.Rows.Count - 1
                        If Me.dgRPsn.Rows(checkSN).Cells(0).Value = Me.txtRPserialPro.Text Then
                            MessageBox.Show(Me, "SN ซ้ำ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Try
                        End If
                    Next
                    Dim sd As Integer = Me.dgRPsn.Rows.Add()
                    Me.dgRPsn.Rows(sd).Cells(0).Value = Me.txtRPserialPro.Text
                    Me.dgRPsn.Rows(sd).Cells(1).Value = Me.dgRPorderPro.CurrentRow.Cells(1).Value
                    Me.dgRPsn.Rows(sd).Cells(2).Value = Me.dgRPorderPro.CurrentRow.Cells(0).Value
                    Me.dgRPorderPro.CurrentRow.Cells(6).Value = CInt(Me.dgRPorderPro.CurrentRow.Cells(6).Value) + 1
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.dgRPsn.ClearSelection()
        Me.txtRPserialPro.Clear()
    End Sub
    Private Sub addBarcodeItem()
        Try
            If Me.txtRPbarcode.Text = "" Then
                MessageBox.Show(Me, "กรุณาใส่บาร์โค๊ต", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Me.txtRPnamePro.Text = "" Then
                    MessageBox.Show(Me, "กรุณาเลือกสินค้าก่อนที่จะป้อนบาร์โค๊ต", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtRPbarcode.Clear()
                    Exit Sub
                Else
                    Try
                        If Me.dgRPorderPro.CurrentRow.Cells(0).Value <> Me.txtRPbarcode.Text Then
                            MessageBox.Show(Me, "บาร์โค๊ตไม่ตรงกับในระบบที่บันทึกไว้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.txtRPbarcode.Clear()
                            Exit Sub
                        ElseIf Me.dgRPorderPro.CurrentRow.Cells(0).Value = Me.txtRPbarcode.Text Then
                            If Me.dgRPorderPro.SelectedCells.Item(4).Value =
                                (CInt(Me.dgRPorderPro.CurrentRow.Cells(5).Value) + CInt(Me.dgRPorderPro.CurrentRow.Cells(6).Value)) Then
                                MessageBox.Show(Me, "สินค้าเกินจำนวนที่สั่งซื้อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.txtRPbarcode.Clear()
                                Exit Sub
                            Else
                                Me.dgRPorderPro.CurrentRow.Cells(5).Value = CDbl(Me.dgRPorderPro.CurrentRow.Cells(5).Value) + 1
                                Me.txtRPbarcode.Clear()
                            End If
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub totalSumCost()
        Try
            Dim oop As Integer = 0
            Dim sumBC As Integer = 0
            Dim sumSN As Integer = 0
            Dim sumBuy As Integer = 0
            For i As Integer = 0 To dgRPorderPro.RowCount - 1
                sumBuy += CDec(Me.dgRPorderPro.Rows(i).Cells(4).Value)
                sumBC += CDec(Me.dgRPorderPro.Rows(i).Cells(5).Value)
                sumSN += CDec(Me.dgRPorderPro.Rows(i).Cells(6).Value)
                oop += CDec(Me.dgRPorderPro.Rows(i).Cells(8).Value)
            Next
            Me.txtsumBuy.Text = sumBuy.ToString
            Me.txtsumBC.Text = sumBC.ToString
            Me.txtsumSN.Text = sumSN.ToString
            Me.txtRPsumMoney.Text = oop.ToString("0,0") & " บาท"
            Dim percen As Integer = ProgressBar1.Value
            Me.ProgressBar1.Maximum = CInt(Me.txtsumBuy.Text)
            Me.ProgressBar1.Value = CInt(Me.txtsumBC.Text) + CInt(Me.txtsumSN.Text)
            Me.lblPercen.Text = "นำเข้าสินค้าไปแล้ว " & String.Format("{0}%", ((ProgressBar1.Value / ProgressBar1.Maximum) * 100).ToString("N2"))
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtRPserialPro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPserialPro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call addTodgRPsn()
        End If
    End Sub

    Private Sub btnRPaddSN_Click(sender As Object, e As EventArgs) Handles btnRPaddSN.Click
        Call addTodgRPsn()
        Call PbaCheng()
    End Sub

    Private Sub btnRPdelSN_Click(sender As Object, e As EventArgs) Handles btnRPdelSN.Click
        If dgRPsn.SelectedRows.Count <> 0 Then
            For h As Integer = 0 To dgRPorderPro.Rows.Count - 1
                If dgRPsn.CurrentRow.Cells(2).Value = dgRPorderPro.Rows(h).Cells(0).Value Then

                    Me.dgRPorderPro.Rows(h).Cells(6).Value = CDbl(Me.dgRPorderPro.Rows(h).Cells(6).Value) - 1
                End If
            Next
            Me.dgRPsn.Rows.Remove(dgRPsn.SelectedRows(0))
        End If
        Call PbaCheng()
    End Sub

    Private Sub btnRPsave_Click(sender As Object, e As EventArgs) Handles btnRPsave.Click
        If Me.dgRPorderPro.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลใบสั่งซื้อ", MsgBoxStyle.Critical, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.txtRPbillID.Text = "" Then
            MsgBox("กรูณาใส่หมายเลขบิลสินค้า หากไม่มีให้ - ไว้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Me.txtRPbillID.Focus()
            Me.txtRPbillID.BackColor = Color.OrangeRed
            Me.lblRPbillID.BackColor = Color.OrangeRed
            Exit Sub
        End If
        If Me.cbRPstatus.Text = "" Then
            MsgBox("กรูณาเลือกสถานะ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Me.cbRPstatus.BackColor = Color.OrangeRed
            Me.lblRPStatus.BackColor = Color.OrangeRed
            Exit Sub
        End If
        For checkProReceive As Integer = 0 To dgRPorderPro.Rows.Count - 1
            If Me.dgRPorderPro.Rows(checkProReceive).Cells(4).Value <> (CInt(Me.dgRPorderPro.Rows(checkProReceive).Cells(5).Value) + CInt(Me.dgRPorderPro.Rows(checkProReceive).Cells(6).Value)) Then
                If MessageBox.Show(Me, "สินค้ายังนำเข้าไม่ครบ สามารถบันทึกได้ โปรแกรมจะทำการบันทึกในสถานะ 'สินค้ายังไม่ครบ' ต้องการบันทึกหรือไม่", "ยืนยัน",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call saveDatatoDatabaseInComplese()
                    Exit Sub
                Else
                    Exit Sub
                End If
                Exit Sub
            End If
        Next
        If MessageBox.Show(Me, "ต้องการบันทึก", "ยืนยัน",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call saveDatatoDatabase()
            autonum = Nothing
            Me.txtRPid.Clear()
        End If
    End Sub

    Private Sub txtRPbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call addBarcodeItem()
        End If
    End Sub

    Private Sub btnRPdelBarcode_Click(sender As Object, e As EventArgs) Handles btnRPdelBarcode.Click
        If Me.dgRPorderPro.Rows.Count <> 0 Then
            If Me.dgRPorderPro.CurrentRow.Cells(5).Value <> 0 Then
                Me.dgRPorderPro.CurrentRow.Cells(5).Value = CDbl(Me.dgRPorderPro.CurrentRow.Cells(5).Value) - 1
            End If
        End If
        Call PbaCheng()
    End Sub

    Private Sub btnRPaddBarcode_Click(sender As Object, e As EventArgs) Handles btnRPaddBarcode.Click
        Call addBarcodeItem()
        Call PbaCheng()
    End Sub
    Private Sub btnRPclear_Click(sender As Object, e As EventArgs) Handles btnRPclear.Click
        Call startfrm()
        Call PbaCheng()
    End Sub
    Private Sub saveDatatoDatabaseInComplese()
        For SDD As Integer = 0 To dgRPorderPro.Rows.Count - 1
            Try
                strSQL = "SELECT count_num,bar_code FROM product WHERE code_pro='" & Me.dgRPorderPro.Rows(SDD).Cells(0).Value & "' "
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Dim count_num As Integer
                Dim cn As Integer = Dr.Item("count_num")
                Dim cn1 As Integer = CInt(Me.dgRPorderPro.Rows(SDD).Cells(5).Value) + CInt(Me.dgRPorderPro.Rows(SDD).Cells(6).Value)
                Dim cn2 As String = Dr.Item("bar_code")
                count_num = cn + cn1

                strSQL = "UPDATE product SET count_num='" & count_num & "' WHERE bar_code='" & cn2 & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        For SND As Integer = 0 To dgRPsn.Rows.Count - 1
            Try
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                        & " VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsn.Rows(SND).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsn.Rows(SND).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsn.Rows(SND).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        Try
            'อัพเดท status เป็น ได้รับสินค้าแล้ว
            strSQL = "UPDATE buy SET status='" & "สินค้ายังไม่ครบ" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "', employee='" & LoginFrm.txtLoginUsername.Text & "' WHERE buy_id='" & Me.txtRPbuy_id.Text & "' "
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'insert to receive //get data000000000000000000000000000000000
        Try
            strSQL = "SELECT * FROM buy WHERE buy_id='" & Me.txtRPbuy_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim buy_id, total, status, sale_company_id, sale_company_name, datetime_save, datetime_edit, employee As String
            With Dr
                .Read()
                buy_id = .Item("buy_id")
                total = .Item("total")
                status = .Item("status")
                sale_company_id = .Item("sale_company_id")
                sale_company_name = .Item("sale_company_name")
                datetime_save = .Item("datetime_save")
                datetime_edit = .Item("datetime_edit")
                employee = .Item("employee")
            End With

            'insert to receive //insert

            strSQL = "INSERT INTO receive(receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,datetime_edit,employee)" _
                     & "VALUES(@receive_id,@buy_id,@bill_buy_id,@receive_status,@total,@status,@sale_company_id,@sale_company_name,@datetime_save,@datetime_edit,@employee)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                .Parameters.Add(New MySqlParameter("@buy_id", buy_id))
                .Parameters.Add(New MySqlParameter("@bill_buy_id", Me.txtRPbillID.Text))
                .Parameters.Add(New MySqlParameter("@receive_status", Me.cbRPstatus.Text))
                .Parameters.Add(New MySqlParameter("@total", total))
                .Parameters.Add(New MySqlParameter("@status", status))
                .Parameters.Add(New MySqlParameter("@sale_company_id", sale_company_id))
                .Parameters.Add(New MySqlParameter("@sale_company_name", sale_company_name))
                .Parameters.Add(New MySqlParameter("@datetime_save", datetime_save))
                .Parameters.Add(New MySqlParameter("@datetime_edit", datetime_edit))
                .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'Try
        '    strSQL = "INSERT INTO receive_id(receive_id,datetime_save)" _
        '               & "VALUES(@receive_id,@datetime_save)"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    With cmd
        '        .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
        '        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
        '        Call open_connection()
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try


        For receiveLoop As Integer = 0 To Me.dgRPorderPro.Rows.Count - 1
            Try
                strSQL = "INSERT INTO receive_pro(receive_id,buy_id,sale_company_name,code_pro,name_pro,price_cost,price_buy,count_num,count_num_barcode,count_num_sn,unit,total_all,datetime_save,employee)" _
                            & "VALUES(@receive_id,@buy_id,@sale_company_name,@code_pro,@name_pro,@price_cost,@price_buy,@count_num,@count_num_barcode,@count_num_sn,@unit,@total_all,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                    .Parameters.Add(New MySqlParameter("@buy_id", Me.txtRPbuy_id.Text))
                    .Parameters.Add(New MySqlParameter("@sale_company_name", Me.txtRPsale_company_name.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPorderPro.Rows(receiveLoop).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPorderPro.Rows(receiveLoop).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@price_cost", Me.dgRPorderPro.Rows(receiveLoop).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPorderPro.Rows(receiveLoop).Cells(3).Value))
                    .Parameters.Add(New MySqlParameter("@count_num", Me.dgRPorderPro.Rows(receiveLoop).Cells(4).Value))
                    .Parameters.Add(New MySqlParameter("@count_num_barcode", Me.dgRPorderPro.Rows(receiveLoop).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@count_num_sn", Me.dgRPorderPro.Rows(receiveLoop).Cells(6).Value))
                    .Parameters.Add(New MySqlParameter("@unit", Me.dgRPorderPro.Rows(receiveLoop).Cells(7).Value))
                    .Parameters.Add(New MySqlParameter("@total_all", Me.dgRPorderPro.Rows(receiveLoop).Cells(8).Value))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With

                Try
                    strSQL = "UPDATE buy_pro SET count_num='" & Me.dgRPorderPro.Rows(receiveLoop).Cells(4).Value - (Me.dgRPorderPro.Rows(receiveLoop).Cells(5).Value + Me.dgRPorderPro.Rows(receiveLoop).Cells(6).Value) & "'," _
                        & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                        & "WHERE buy_id='" & Me.txtRPbuy_id.Text & "' AND code_pro='" & Me.dgRPorderPro.Rows(receiveLoop).Cells(0).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
        Me.dgRPsn.Rows.Clear()
        Me.dgRPorderPro.Rows.Clear()

        Call getDatatodgRPorderpro(Me.txtRPbuy_id.Text)
        MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub saveDatatoDatabase()

        'update number of product from product
        For SDD As Integer = 0 To dgRPorderPro.Rows.Count - 1
            Try
                strSQL = "SELECT count_num,bar_code FROM product WHERE code_pro='" & Me.dgRPorderPro.Rows(SDD).Cells(0).Value & "' "
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Dim count_num As Integer
                Dim cn As Integer = Dr.Item("count_num")
                Dim cn1 As Integer = CInt(Me.dgRPorderPro.Rows(SDD).Cells(5).Value) + CInt(Me.dgRPorderPro.Rows(SDD).Cells(6).Value)
                Dim cn2 As String = Dr.Item("bar_code")
                count_num = cn + cn1

                strSQL = "UPDATE product SET count_num='" & count_num & "' WHERE bar_code='" & cn2 & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
        'insert to product_serial
        For SND As Integer = 0 To dgRPsn.Rows.Count - 1
            Try
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                        & " VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsn.Rows(SND).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsn.Rows(SND).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsn.Rows(SND).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        Try
            'อัพเดท status เป็น ได้รับสินค้าแล้ว
            strSQL = "UPDATE buy SET status='" & "ได้รับสินค้าแล้ว" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "', employee='" & LoginFrm.txtLoginUsername.Text & "' WHERE buy_id='" & Me.txtRPbuy_id.Text & "' "
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'insert to receive //get data000000000000000000000000000000000
        Try
            strSQL = "SELECT * FROM buy WHERE buy_id='" & Me.txtRPbuy_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim buy_id, total, status, sale_company_id, sale_company_name, datetime_save, datetime_edit, employee As String
            With Dr
                .Read()
                buy_id = .Item("buy_id")
                total = .Item("total")
                status = .Item("status")
                sale_company_id = .Item("sale_company_id")
                sale_company_name = .Item("sale_company_name")
                datetime_save = .Item("datetime_save")
                datetime_edit = .Item("datetime_edit")
                employee = .Item("employee")
            End With
  
            'insert to receive //insert

            strSQL = "INSERT INTO receive(receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,datetime_edit,employee)" _
                     & "VALUES(@receive_id,@buy_id,@bill_buy_id,@receive_status,@total,@status,@sale_company_id,@sale_company_name,@datetime_save,@datetime_edit,@employee)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                .Parameters.Add(New MySqlParameter("@buy_id", buy_id))
                .Parameters.Add(New MySqlParameter("@bill_buy_id", Me.txtRPbillID.Text))
                .Parameters.Add(New MySqlParameter("@receive_status", Me.cbRPstatus.Text))
                .Parameters.Add(New MySqlParameter("@total", total))
                .Parameters.Add(New MySqlParameter("@status", status))
                .Parameters.Add(New MySqlParameter("@sale_company_id", sale_company_id))
                .Parameters.Add(New MySqlParameter("@sale_company_name", sale_company_name))
                .Parameters.Add(New MySqlParameter("@datetime_save", datetime_save))
                .Parameters.Add(New MySqlParameter("@datetime_edit", datetime_edit))
                .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "INSERT INTO receive_id(receive_id,datetime_save)" _
                       & "VALUES(@receive_id,@datetime_save)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try


        For receiveLoop As Integer = 0 To Me.dgRPorderPro.Rows.Count - 1
            Try
                strSQL = "INSERT INTO receive_pro(receive_id,buy_id,sale_company_name,code_pro,name_pro,price_cost,price_buy,count_num,count_num_barcode,count_num_sn,unit,total_all,datetime_save,employee)" _
                            & "VALUES(@receive_id,@buy_id,@sale_company_name,@code_pro,@name_pro,@price_cost,@price_buy,@count_num,@count_num_barcode,@count_num_sn,@unit,@total_all,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                    .Parameters.Add(New MySqlParameter("@buy_id", Me.txtRPbuy_id.Text))
                    .Parameters.Add(New MySqlParameter("@sale_company_name", Me.txtRPsale_company_name.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPorderPro.Rows(receiveLoop).Cells(3).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPorderPro.Rows(receiveLoop).Cells(4).Value))
                    .Parameters.Add(New MySqlParameter("@price_cost", Me.dgRPorderPro.Rows(receiveLoop).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPorderPro.Rows(receiveLoop).Cells(6).Value))
                    .Parameters.Add(New MySqlParameter("@count_num", Me.dgRPorderPro.Rows(receiveLoop).Cells(7).Value))
                    .Parameters.Add(New MySqlParameter("@count_num_barcode", Me.dgRPorderPro.Rows(receiveLoop).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@count_num_sn", Me.dgRPorderPro.Rows(receiveLoop).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@unit", Me.dgRPorderPro.Rows(receiveLoop).Cells(8).Value))
                    .Parameters.Add(New MySqlParameter("@total_all", Me.dgRPorderPro.Rows(receiveLoop).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
        MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call startfrm()
    End Sub

    Private Sub btnRPaddBCnum_Click(sender As Object, e As EventArgs) Handles btnRPaddBCnum.Click
        If Me.txtRPnamePro.Text <> Nothing Then
            Dim NumPro As Integer
            NumPro = CInt(Me.dgRPorderPro.CurrentRow.Cells(5).Value) + CInt(Me.dgRPorderPro.CurrentRow.Cells(6).Value) + CInt(Me.NumericUpDown1.Value)
            If NumPro > CInt(Me.dgRPorderPro.SelectedCells.Item(4).Value) Then
                MsgBox("จำนวนสินค้าเกินกว่าจำนวนที่สั่งซื้อ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Else
                Me.dgRPorderPro.CurrentRow.Cells(5).Value = CInt(Me.dgRPorderPro.CurrentRow.Cells(5).Value) + CInt(Me.NumericUpDown1.Value)
            End If
            Me.NumericUpDown1.Value = 1
        End If
        Call PbaCheng()
    End Sub

    Private Sub enableTXTinsert()
        Me.NumericUpDown1.Enabled = True
        Me.btnRPaddBCnum.Enabled = True
        Me.txtRPbarcode.Enabled = True
        Me.btnRPaddBarcode.Enabled = False
        Me.btnRPdelBarcode.Enabled = False
        Me.txtRPserialPro.Enabled = True
        Me.btnRPaddSN.Enabled = False
        Me.btnRPdelSN.Enabled = False
    End Sub
    Private Sub disbleTXTinsert()
        Me.NumericUpDown1.Enabled = False
        Me.btnRPaddBCnum.Enabled = False
        Me.txtRPbarcode.Enabled = False
        Me.btnRPaddBarcode.Enabled = False
        Me.btnRPdelBarcode.Enabled = False
        Me.txtRPserialPro.Enabled = False
        Me.btnRPaddSN.Enabled = False
        Me.btnRPdelSN.Enabled = False
    End Sub

    Private Sub txtRPnamePro_TextChanged(sender As Object, e As EventArgs) Handles txtRPnamePro.TextChanged
        If Me.txtRPnamePro.Text <> Nothing Then
            Me.Timer1.Start()
            Call enableTXTinsert()
        Else
            Me.Timer1.Stop()
            Call disbleTXTinsert()
        End If
        Call PbaCheng()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.txtRPnamePro.ForeColor = Color.White Then
            Me.txtRPnamePro.ForeColor = Color.Black
        ElseIf Me.txtRPnamePro.ForeColor = Color.Black Then
            Me.txtRPnamePro.ForeColor = Color.White
        End If
    End Sub

    Private Sub dgRPorderPro_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgRPorderPro.CellValueChanged
        Call PbaCheng()
    End Sub

    Private Sub dgRPorderPro_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgRPorderPro.CurrentCellDirtyStateChanged
        If Me.dgRPorderPro.IsCurrentCellDirty Then
            Me.dgRPorderPro.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub PbaCheng()
        If Me.dgRPorderPro.Rows.Count <> 0 Then
            If Me.dgRPorderPro.CurrentRow.Cells(5).Value <> 0 Then
                Me.btnRPdelBarcode.Enabled = True
            ElseIf Me.dgRPorderPro.CurrentRow.Cells(5).Value = 0 Then
                Me.btnRPdelBarcode.Enabled = False
            End If
        ElseIf Me.dgRPorderPro.Rows.Count = 0 Then
            Me.btnRPdelBarcode.Enabled = False
        End If
        Call totalSumCost()
    End Sub



    Private Sub dgRPorderPro_SelectionChanged(sender As Object, e As EventArgs) Handles dgRPorderPro.SelectionChanged
        If Me.dgRPorderPro.SelectedRows.Count = 0 Then
            Call disbleTXTinsert()
            Me.txtRPnamePro.Clear()
        Else
            Call enableTXTinsert()
        End If
        Call PbaCheng()
    End Sub

    Private Sub dgRPsn_SelectionChanged(sender As Object, e As EventArgs) Handles dgRPsn.SelectionChanged
        If Me.dgRPsn.Rows.Count <> 0 Then
            If Me.dgRPsn.CurrentRow.Selected = True Then
                Me.btnRPdelSN.Enabled = True
            ElseIf Me.dgRPsn.CurrentRow.Selected = False Then
                Me.btnRPdelSN.Enabled = False
            End If
        ElseIf Me.dgRPsn.Rows.Count = 0 Then
            Me.btnRPdelSN.Enabled = False
        End If
    End Sub

    Private Sub txtRPbarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRPbarcode.KeyPress
        If txtRPbarcode.Text <> Nothing Then
            Me.btnRPaddBarcode.Enabled = True
        Else
            Me.btnRPaddBarcode.Enabled = False
        End If
        Call PbaCheng()
    End Sub

    Private Sub txtRPbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtRPbarcode.TextChanged
        If txtRPbarcode.Text <> Nothing Then
            Me.btnRPaddBarcode.Enabled = True
        Else
            Me.btnRPaddBarcode.Enabled = False
        End If
        Call PbaCheng()
    End Sub

    Private Sub txtRPserialPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRPserialPro.KeyPress
        If Me.txtRPserialPro.Enabled <> Nothing Then
            Me.btnRPaddSN.Enabled = True
        Else
            Me.btnRPaddSN.Enabled = False
        End If
    End Sub

    Private Sub txtRPserialPro_TextChanged(sender As Object, e As EventArgs) Handles txtRPserialPro.TextChanged
        If Me.txtRPserialPro.Enabled <> Nothing Then
            Me.btnRPaddSN.Enabled = True
        Else
            Me.btnRPaddSN.Enabled = False
        End If
    End Sub

    Private Sub txtRPbillID_BackColorChanged(sender As Object, e As EventArgs) Handles txtRPbillID.BackColorChanged
        Me.Timer2.Start()
    End Sub

    Private Sub lblRPStatus_BackColorChanged(sender As Object, e As EventArgs) Handles lblRPStatus.BackColorChanged
        Me.Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.txtRPbillID.BackColor = Color.OrangeRed Then
            Me.txtRPbillID.BackColor = SystemColors.Window
            Me.lblRPbillID.BackColor = SystemColors.Control
            Me.Timer2.Stop()
        End If

        If Me.cbRPstatus.BackColor = Color.OrangeRed Then
            Me.cbRPstatus.BackColor = SystemColors.Window
            Me.lblRPStatus.BackColor = SystemColors.Control
            Me.Timer2.Stop()
        End If
    End Sub

    Private Sub btnAttactBill_Click(sender As Object, e As EventArgs) Handles btnAttactBill.Click
        CameraCaptureAttactBillFrm.ShowDialog(Me)
        Call CountPicture()
    End Sub

    Private Sub txtRPbuy_id_TextChanged(sender As Object, e As EventArgs) Handles txtRPbuy_id.TextChanged
        If Me.txtRPbuy_id.Text = Nothing Then
            Me.btnAttactBill.Enabled = False
        Else
            Me.btnAttactBill.Enabled = True
        End If
        Call CountPicture()
    End Sub

    Private Sub lblAttactBill_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAttactBill.LinkClicked
        If Me.txtRPbuy_id.Text <> Nothing Then
            Call ReceiveShowPicFrm.LoadPictureList(Me.txtRPbuy_id.Text)
            ReceiveShowPicFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/buymenu/receiveproductfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class