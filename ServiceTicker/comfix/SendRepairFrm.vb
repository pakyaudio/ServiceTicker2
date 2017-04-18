Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SendRepairFrm

    Private Sub SendRepairFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SendRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.DateTimePickerSRR.Value = DateTime.Now.AddDays(0)
    End Sub
    Dim frn As String
    Friend cusID As String
    Friend cusName As String
    Private Sub getDataFromFixid()
        strSQL = "SELECT fix_id,date_save,customer_id,customer_name,sn,symptom,managerdata," _
            & "fixaccessory,date_get,status,user_repair,note_repair,teltocus,fixrepairnote FROM comfix WHERE fix_id='" & Me.txtSRgetDataByFixID.Text & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.lblSRcustomerDetail.Text = Dr.GetString("customer_name") & " รหัสลูกค้า: " & Dr.GetString("customer_id") & _
                    vbNewLine & " อาการเสีย: " & Dr.GetString("symptom") & " ช่างซ่อม: " & Dr.GetString("user_repair") & _
                    vbNewLine & " วันที่ส่งซ่อม: " & Dr.GetString("date_save") & " วันที่นัดรับเครื่อง: " & Dr.GetString("date_get")
                Me.txtSRfixRepairNote.Text = Dr.GetString("note_repair")
                Me.txtSRfixAccessory.Text = Dr.GetString("fixaccessory")
                Me.txtSRstatus.Text = Dr.GetString("status")
                frn = Dr.GetString("fixrepairnote")
                cusID = Dr.GetString("customer_id")
                Me.txtHideform.Text = Dr.GetString("fix_id")
            Else
                MessageBox.Show(Me, "ไม่พบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.txtSRgetDataByFixID.Clear()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getDatasale()
        Try
            strSQL = "SELECT sale_id,total_all FROM sale WHERE fix_id='" & Me.txtSRgetDataByFixID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtSRfixPrice.Text = Dr.GetDecimal("total_all")
                Me.txtSRsale_id.Text = Dr.GetString("sale_id")
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getDatasale_Barcode()
        Me.dgSRsale_detail.Rows.Clear()
        strSQL = "SELECT code_pro,name_pro,total_pro,price_buy,unit from sale_barcode where fix_id='" & Me.txtHideform.Text & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read
                With Me.dgSRsale_detail
                    Dim r As Integer
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(5).Value = Dr.Item("unit")
                    .Rows(r).Cells(6).Value = CDec(.Rows(r).Cells(4).Value) * CDec(.Rows(r).Cells(3).Value)
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Dim sum1 As Decimal
        For x = 0 To Me.dgSRsale_detail.Rows.Count - 1
            sum1 += CDec(Me.dgSRsale_detail.Rows(x).Cells("total_all").Value)
        Next
        Me.txtSRfixPrice.Text = sum1
    End Sub

    Private Sub txtSRgetDataByFixID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSRgetDataByFixID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataFromFixid()
            If frn = "ส่งมาจากงานเคลม" Then
                MsgBox("สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้าสถานะงานซ่อม", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.Enabled = False
                Me.Close()
            Else
                Call getDatasale()
            End If
        End If
    End Sub

    Private Sub txtSRsale_id_TextChanged(sender As Object, e As EventArgs) Handles txtSRsale_id.TextChanged
        Call getDatasale_Barcode()
    End Sub

    Private Sub btnSRgetDataByFixID_Click(sender As Object, e As EventArgs) Handles btnSRgetDataByFixID.Click
        If Me.txtSRgetDataByFixID.Text <> Nothing Then
            Call getDataFromFixid()
            If frn = "ส่งมาจากงานเคลม" Then
                MsgBox("สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้าสถานะงานซ่อม", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.Enabled = False
                Me.Close()
            Else
                Call getDatasale()
             
            End If
        End If
    End Sub

    Private Sub txtHideform_TextChanged(sender As Object, e As EventArgs) Handles txtHideform.TextChanged
        If Me.txtHideform.Text <> Nothing Then
            Me.btnSRsaveAndSend.Enabled = True
            Call getDatasale_Barcode()
            Try
                Using dt = New DataTable
                    strSQL = "SELECT fix_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixaccessory,date_get,status,user_repair,note_repair,teltocus FROM " _
                        & "comfix WHERE fix_id='" & Me.txtHideform.Text & "'"
                    dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                    Call open_connection()
                    dtAdapter.Fill(dt)
                    Me.lblSRcustomerDetail.Text = dt.Rows(0).Item("customer_name") & " รหัสลูกค้า: " & dt.Rows(0).Item("customer_id") & vbNewLine & " อาการเสีย: " & dt.Rows(0).Item("symptom") & " ช่างซ่อม: " & dt.Rows(0).Item("user_repair") & vbNewLine & " วันที่ส่งซ่อม: " & dt.Rows(0).Item("date_save") & " วันที่นัดรับเครื่อง: " & dt.Rows(0).Item("date_get")
                    Me.txtSRfixRepairNote.Text = dt.Rows(0).Item("note_repair")
                    Me.txtSRfixAccessory.Text = dt.Rows(0).Item("fixaccessory")
                    Me.txtSRstatus.Text = dt.Rows(0).Item("status")
                    cusID = dt.Rows(0).Item("customer_id")
                    cusName = dt.Rows(0).Item("customer_name")
                End Using
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                Using dt = New DataTable
                    strSQL = "SELECT sale_id FROM sale WHERE fix_id='" & Me.txtHideform.Text & "'"
                    dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                    Call open_connection()
                    dtAdapter.Fill(dt)
                    Me.txtSRsale_id.Text = dt.Rows(0).Item("sale_id")
                End Using
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Else
            Me.btnSRsaveAndSend.Enabled = False
        End If
    End Sub

    Private Sub notPayment()
        Try
            strSQL = "Update comfix SET status='" & "7 คืนเครื่องแล้ว" & "'," _
                & "date_send='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'" _
                & "WHERE fix_id='" & Me.txtHideform.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            For Each form In My.Application.OpenForms
                If (form.name = SearchRepairFrm.Name) Then
                    If form.Visible Then
                        Call SearchRepairFrm.searchDatacomfixBystatus(SearchRepairFrm.cbbSRsearchAll.Text)
                    End If
                End If
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnSRsaveAndSend_Click(sender As Object, e As EventArgs) Handles btnSRsaveAndSend.Click
        If Me.txtSRstatus.Text = "4 ซ่อมไม่ได้" Or Me.txtSRstatus.Text = "5 ซ่อมเสร็จ" Or Me.txtSRstatus.Text = "6 ยกเลิกซ่อม" Then
            If MessageBox.Show(Me, "ต้องการทำรายการส่งคืนเครื่องนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Me.txtSRfixPrice.Text = Nothing Or Me.txtSRfixPrice.Text = "0" Or Me.txtSRfixPrice.Text = "-" Then
                    Call notPayment() 'บันทึกสถานะ
                    If MessageBox.Show("บันทึกคืนแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งคืนหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If checkPrinter() = "A5" Then
                            SendRepairPrintA5Frm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A4" Then
                            SendRepairPrintA4Frm.ShowDialog(Me)
                        End If
                    End If
                    'โหลดฟอร์มทั้งสองเมื่อคืนเครื่องเพื่อดึงข้อมูลปัจจุบันที่ถูกบันทึกแล้ว
                    'ตรวจสอบว่า RepairStatusFrm เปิดอยู่หรือไม่
                    For Each form In My.Application.OpenForms
                        If (form.name = RepairStatusFrm.Name) Then
                            If form.Visible Then
                                RepairStatusFrm.loadCurrentStatus()
                                Exit For
                            End If
                        End If
                    Next
                    'ตรวจสอบว่า SearchRepairFrm เปิดอยู่หรือไม่
                    For Each form In My.Application.OpenForms
                        If (form.name = SearchRepairFrm.Name) Then
                            If form.Visible Then
                                SearchRepairFrm.searchDatacomfixBystatus(SearchRepairFrm.cbbSRsearchAll.Text)
                                Exit For
                            End If
                        End If
                    Next
                    Me.Close()
                Else
                    If Me.cbbSRRcash_status.Text = Nothing Then
                        Me.lblSRpayment.BackColor = Color.Orange
                        MessageBox.Show(Me, "เลือกการชำระเงินก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf Me.cbbSRRcash_status.Text = "ชำระเงิน" Then
                        CashFrm.txtCashCusID.Text = cusID
                        CashFrm.txtCashFixID.Text = Me.txtHideform.Text
                        CashFrm.txtCashCash.Text = Me.txtSRfixPrice.Text
                        CashFrm.lblEmployee.Text = Me.lblEmployee.Text
                        CashFrm.ShowDialog(Me)
                    ElseIf Me.cbbSRRcash_status.Text = "ยังไม่ชำระเงิน" Then
                        Call notPayment() 'บันทึกสถานะ
                        If MessageBox.Show("บันทึกคืนแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งคืนหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If checkPrinter() = "A5" Then
                                SendRepairPrintA5Frm.ShowDialog(Me)
                            ElseIf checkPrinter() = "A4" Then
                                SendRepairPrintA4Frm.ShowDialog(Me)
                            End If
                        End If
                        If MessageBox.Show("ต้องการจะพิมพ์ใบส่งของหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If checkPrinter() = "A5" Then
                                InvoiceRepairReportA5Frm.ShowDialog(Me)
                            ElseIf checkPrinter() = "A4" Then
                                InvoiceRepairReportA4Frm.ShowDialog(Me)
                            End If
                        End If
                        'โหลดฟอร์มทั้งสองเมื่อคืนเครื่องเพื่อดึงข้อมูลปัจจุบันที่ถูกบันทึกแล้ว
                        'ตรวจสอบว่า RepairStatusFrm เปิดอยู่หรือไม่
                        For Each form In My.Application.OpenForms
                            If (form.name = RepairStatusFrm.Name) Then
                                If form.Visible Then
                                    RepairStatusFrm.loadCurrentStatus()
                                    Exit For
                                End If
                            End If
                        Next
                        'ตรวจสอบว่า SearchRepairFrm เปิดอยู่หรือไม่
                        For Each form In My.Application.OpenForms
                            If (form.name = SearchRepairFrm.Name) Then
                                If form.Visible Then
                                    SearchRepairFrm.searchDatacomfixBystatus(SearchRepairFrm.cbbSRsearchAll.Text)
                                    Exit For
                                End If
                            End If
                        Next
                        Me.Close()
                    End If
                End If
            End If
        Else
            MessageBox.Show(Me, "ต้องเป็นสถานะ ยกเลิกซ่อม, ซ่อมเสร็จ หรือ ซ่อมไม่ได้ ถึงจะทำคืนเครื่องได้ กรุณากลับไปกำหนดสถานะให้เรียบร้อยก่อน", "แจ้งเตือน",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cbbSRRcash_status_DropDown(sender As Object, e As EventArgs) Handles cbbSRRcash_status.DropDown
        Me.cbbSRRcash_status.Items.Clear()
        Me.cbbSRRcash_status.Items.Add("ชำระเงิน")
        Me.cbbSRRcash_status.Items.Add("ยังไม่ชำระเงิน")
    End Sub

    Private Sub cbbSRRcash_status_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSRRcash_status.SelectedValueChanged
        Me.lblSRpayment.BackColor = SystemColors.Control
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/sendrepairfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class