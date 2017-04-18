Imports MySql.Data.MySqlClient
Public Class TaxInvoiceFrm
    Friend DTPTI1 As String
    Private Sub thaitext()
        Dim mne As New MoneyExt()
        Try
            Me.txtTItahitext.Text = mne.NumberToThaiWord(CDbl(Me.txtTItotalAll.Text))
        Catch ex As Exception
            Me.txtTItahitext.Text = mne.NumberToThaiWord(0)
        End Try
    End Sub

    Private Sub AutoNumberNo()
        If Me.cbbTIselectbill.Text = "ใบส่งของ" Then
            Call ALLAutonumber("ver_invoice", Me.txtTIbillID.Text)
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน" Then
            Call ALLAutonumber("ver_cashinvoice", Me.txtTIbillID.Text)
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน/ใบกำกับภาษี" Then
            Call ALLAutonumber("ver_cashinvoice", Me.txtTIbillID.Text)
        ElseIf Me.cbbTIselectbill.Text = "ใบเสนอราคา" Then
            Call ALLAutonumber("ver_quotation", Me.txtTIbillID.Text)
        End If
    End Sub
    Private Sub cbTI_CheckedChanged(sender As Object, e As EventArgs) Handles cbTI.CheckedChanged
        If Me.cbTI.Checked = False Then
            DateTimePicker1.Enabled = False
            DTPTI1 = ".............../.............../..............."
        ElseIf Me.cbTI.Checked = True Then
            DateTimePicker1.Enabled = True
            DTPTI1 = DateTimePicker1.Value.ToString("dd MMMM yyyy")
        End If
    End Sub

    Public Sub restart()
        Me.txtTIcusid.Clear()
        Me.txtTIcusname.Clear()
        Me.txtTIcustel.Clear()
        Me.txtTIcusaddress.Clear()
        Me.dgTI.Rows.Clear()
        Me.txtTInote.Text = "-"
        Me.txtTItaxNumber.Text = "0"
        Me.txtTItaxSection.Text = "สำนักงานใหญ่"
        Me.txtTItotalPro.Text = "0"
        Me.txtTIdiscount1.Text = "0"
        Me.txtTItotalTax.Text = "0"
        Me.txtTItotalAll.Text = "0"
        Me.txtTItotal.Text = "0"
        Me.txtTItaxpercen.Text = "0"
        Call sumALL()
    End Sub
    ''' <summary>
    ''' ดังข้อมูลลูกค้า  รหัสลูกค้า As String
    ''' </summary>
    ''' <param name="cusid">รหัสลูกค้า As String</param>
    ''' <remarks></remarks>
    Friend Sub getCustomerData(ByVal cusid As String)
        Try
            strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name,customer_address," & _
                "customer_zipcode,customer_tel FROM customer WHERE customer_id='" & cusid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.txtTIcusid.Text = Dr.Item("customer_id")
                Me.txtTIcusname.Text = Dr.Item("customer_name")
                Me.txtTIcusaddress.Text = Dr.Item("customer_address") & " " & Dr.Item("customer_zipcode")
                Me.txtTIcustel.Text = Dr.Item("customer_tel")
                Me.txtTItaxNumber.Text = Dr.Item("customer_tax")
                Me.txtTItaxSection.Text = Dr.Item("customer_section")
                Me.txtTIsearchBillID.Focus()
            Else
                MsgBox("ไม่พบรหัสลูกค้า " & Me.txtTIcusid.Text)
                Me.txtTIcusid.Clear()
                Me.txtTIcusid.Focus()
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Dim selsctStrSQL As Integer
    Private Sub getDataBill()
        Try
            strSQL = "SELECT code_pro FROM cash_sale_barcode WHERE " _
                & "sale_id='" & Me.txtTIsearchBillID.Text & "' OR fix_id='" & Me.txtTIsearchBillID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                selsctStrSQL = 100
            ElseIf Not Dr.HasRows Then
                strSQL = "SELECT code_pro FROM sale_barcode WHERE " _
                    & "sale_id='" & Me.txtTIsearchBillID.Text & "' OR fix_id='" & Me.txtTIsearchBillID.Text & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    selsctStrSQL = 200
                ElseIf Not Dr.HasRows Then
                    MsgBox("ไม่พบข้อมูล " & Me.txtTIsearchBillID.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try


        Try
            If selsctStrSQL = 100 Then
                strSQL = "SELECT code_pro,name_pro,total_pro,unit,price_buy FROM cash_sale_barcode " _
                    & "WHERE sale_id='" & Me.txtTIsearchBillID.Text & "' or fix_id='" & Me.txtTIsearchBillID.Text & "';"
            ElseIf selsctStrSQL = 200 Then
                MsgBox("แจ้งเตือน หมายเลขบิลนี้ยังไม่ได้ชำระเงิน การออกใบเสร็จรับเงินสำหรับบิลนี้" & vbNewLine &
                       "อาจมีผลตามกฎหมายที่เป็นหลักฐานว่าลูกค้าได้ชำระเงินแล้ว" & vbNewLine & "โปรดออกใบเสร็จรับเงินแก่ลูกค้าที่ไว้ใจได้เท่านั้น", MsgBoxStyle.Information, "แจ้งเตือน")
                strSQL = "SELECT code_pro,name_pro,total_pro,unit,price_buy FROM sale_barcode WHERE " _
                    & "sale_id='" & Me.txtTIsearchBillID.Text & "' or fix_id='" & Me.txtTIsearchBillID.Text & "';"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgTI
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("unit")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call sumALL()
        selsctStrSQL = Nothing
    End Sub

    Friend Sub getDataProduct()
        Try
            strSQL = "SELECT code_pro,name_pro,unit,price_buy FROM product WHERE " _
                & "code_pro='" & Me.txtTIsearchBarcode.Text & "' OR bar_code='" & Me.txtTIsearchBarcode.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                If Dr.HasRows Then
                    For dup As Integer = 0 To Me.dgTI.Rows.Count - 1
                        If Dr.Item("code_pro") = Me.dgTI.Rows(dup).Cells(1).Value Then
                            Me.dgTI.Rows(dup).Cells(3).Value = CInt(Me.dgTI.Rows(dup).Cells(3).Value) + 1
                            Exit Sub
                        End If
                    Next
                    With Me.dgTI
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = "1"
                        .Rows(r).Cells(4).Value = Dr.Item("unit")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(6).Value = 0
                    End With
                Else
                    MsgBox("ไม่พบข้อมูล " & Me.txtTIsearchBarcode.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                End If
            End While
            Call sumALL()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub getDataProductByView(ByVal tiid As String)
        Try
            dt = New DataTable
            strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,customer_address,customer_tel,note,tax_num,tax_section,refer " _
                & "FROM taxinvoice WHERE taxinvoice_id='" & tiid & "';"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Me.txtTIcusid.Text = dt(0)("customer_id")
            Me.txtTIcusname.Text = dt(0)("customer_name")
            Me.txtTIcusaddress.Text = dt(0)("customer_address")
            Me.txtTIcustel.Text = dt(0)("customer_tel")
            Me.txtTIbillID.Text = dt(0)("taxinvoice_id")
            Me.cbbTIselectbill.Text = dt(0)("taxinvoice_type")
            Me.txtTInote.Text = dt(0)("note")
            Me.txtTItaxNumber.Text = dt(0)("tax_num")
            Me.txtTItaxSection.Text = dt(0)("tax_section")
            Me.txtRefer.Text = dt(0)("refer")
            Me.txtTInote.Text = SelectNote(Me.cbbTIselectbill.Text.ToString)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT code_pro,name_pro,total,unit,price_buy,discount FROM taxinvoice WHERE " _
                & "taxinvoice_id='" & tiid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                If Dr.HasRows Then
                    With Me.dgTI
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("total")
                        .Rows(r).Cells(4).Value = Dr.Item("unit")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(6).Value = Dr.GetDecimal("discount")
                    End With
                Else
                    MsgBox("ไม่พบข้อมูล " & Me.txtTIsearchBarcode.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                End If
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call sumALL()
    End Sub

    Friend Sub sumALL()
        Try
            If Me.dgTI.Rows.Count <> 0 Then
                Dim ptt As Decimal = 0
                Dim distt As Decimal = 0
                Dim ttNotDis As Decimal = 0
                For sum As Integer = 0 To Me.dgTI.Rows.Count - 1
                    Me.dgTI.Rows(sum).Cells(0).Value = sum + 1
                    Me.dgTI.Rows(sum).Cells(7).Value = (CDec(Me.dgTI.Rows(sum).Cells(5).Value) * CDec(Me.dgTI.Rows(sum).Cells(3).Value)) -
                        CDec(Me.dgTI.Rows(sum).Cells(6).Value)
                    Me.dgTI.Rows(sum).Cells(7).Tag = CDec(Me.dgTI.Rows(sum).Cells(5).Value) * CDec(Me.dgTI.Rows(sum).Cells(3).Value)
                    distt += CDec(Me.dgTI.Rows(sum).Cells(6).Value)
                    ptt += CDec(Me.dgTI.Rows(sum).Cells(7).Value)
                    ttNotDis += CDec(Me.dgTI.Rows(sum).Cells(7).Tag)

                    Me.txtTItotalPro.Text = ttNotDis.ToString("N2")
                    Me.txtTIdiscount1.Text = distt.ToString("N2")
                    Me.txtTItotal.Text = ptt.ToString("N2")
                    Dim txtTItotalTax As Decimal = 0
                    Dim txtTItotalAll As Decimal = 0
                    If Me.rbTItotaltax.Checked Then
                        If Me.btnTaxinEx.Text = "นอก" Then
                            txtTItotalTax = (CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text)
                            txtTItotalAll = CDec(Me.txtTItotal.Text) + txtTItotalTax
                        ElseIf Me.btnTaxinEx.Text = "ใน" Then
                            txtTItotalTax = (CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text)
                            Dim xx As Decimal = CDec(Me.txtTItotal.Text) - txtTItotalTax
                            Me.txtTItotal.Text = xx.ToString("N2")
                            txtTItotalAll = CDec(Me.txtTItotal.Text) + txtTItotalTax
                        End If
                        Me.txtTItotalTax.Text = txtTItotalTax.ToString("N2")
                        Me.txtTItotalAll.Text = txtTItotalAll.ToString("N2")
                    ElseIf Me.rbTIuntax.Checked Then
                        If Me.btnTaxinEx.Text = "นอก" Then
                            txtTItotalTax = (CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text)
                            txtTItotalAll = CDec(Me.txtTItotal.Text) + CDec(Me.txtTItotalTax.Text)
                        ElseIf Me.btnTaxinEx.Text = "ใน" Then
                            txtTItotalTax = (CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text)
                            Dim xx As Decimal = CDec(Me.txtTItotal.Text) - CDec(Me.txtTItotalTax.Text)
                            Me.txtTItotal.Text = xx.ToString("N2")
                            txtTItotalAll = CDec(Me.txtTItotal.Text) + CDec(Me.txtTItotalTax.Text)
                        End If
              
                        Me.txtTItotalTax.Text = txtTItotalTax.ToString("N2")
                        Me.txtTItotalAll.Text = txtTItotalAll.ToString("N2")
                    End If
                Next
            Else
                Me.txtTItotalPro.Text = 0
                Me.txtTIdiscount1.Text = 0
                Me.txtTItotal.Text = 0
                Me.txtTItotalTax.Text = 0
                Me.txtTItotalAll.Text = 0
            End If
            Call thaitext()
        Catch ex As Exception
            MessageBox.Show(Me, "ผิดพลาด คำนวนผลรวมไม่ได้กรุณาตรวจสอบ ตัวเลข จำนวน, จำนวน/หน่วย, ส่วนลด ให้ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub rbCheck()
        If Me.rbTItotaltax.Checked = True Then
            Me.txtTItaxpercen.Enabled = True
            Me.txtTItaxpercen.Text = "7"
        ElseIf Me.rbTIuntax.Checked = True Then
            Me.txtTItaxpercen.Enabled = False
            Me.txtTItaxpercen.Text = "0"
        End If
    End Sub

    Private Sub TaxInvoiceFrm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'TaxInvoiceSelectProFrm.Close()
    End Sub

    Private Sub TaxInvoiceFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub TaxInvoiceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.cbbTIselectbill.Items.Clear()
        Me.cbbTIselectbill.Items.Add("ใบเสนอราคา")
        Me.cbbTIselectbill.Items.Add("ใบส่งของ")
        Me.cbbTIselectbill.Items.Add("ใบเสร็จรับเงิน")
        Me.cbbTIselectbill.Items.Add("ใบเสร็จรับเงิน/ใบกำกับภาษี")
        Call thaitext()
        Me.DateTimePicker1.Value = DateTime.Now.AddDays(0)
        Me.DateTimePicker2.Value = DateTime.Now.AddDays(0)
        Me.cbbExDay.SelectedText = "7"
        Me.cbbDateCadit.SelectedText = "-"
        'Call AutoNumberNo()
        Call rbCheck()
    End Sub

    Private Sub txtTIcusid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIcusid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getCustomerData(Me.txtTIcusid.Text)
        End If
    End Sub

    Private Sub txtTIsearchBillID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIsearchBillID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataBill()
            Me.txtTIsearchBillID.Clear()
            Me.txtTIsearchBillID.Focus()
        End If
    End Sub

    Private Sub dgTI_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgTI.CellEndEdit
        Call sumALL()
    End Sub

    Private Sub dgTI_KeyDown(sender As Object, e As KeyEventArgs) Handles dgTI.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgTI.RowCount = 0 Then
            Else
                Dim r As Integer = Me.dgTI.SelectedRows.Count - 1
                Me.dgTI.Rows.Remove(Me.dgTI.SelectedRows(r))
                Call sumALL()
            End If
        End If
    End Sub

    Private Sub txtTIsearchBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIsearchBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataProduct()
            Me.txtTIsearchBarcode.Clear()
            Me.txtTIsearchBarcode.Focus()
        End If
    End Sub

    Private Sub txtTIdiscount1_LostFocus(sender As Object, e As EventArgs) Handles txtTIdiscount1.LostFocus
        If Me.txtTIdiscount1.Text = "" Then
            Me.txtTIdiscount1.Text = "0"
        Else

            Dim txtdis As Decimal = Me.txtTIdiscount1.Text
            Me.txtTIdiscount1.Text = txtdis.ToString("N2")
            Call sumALL()
        End If
    End Sub

    Private Sub txtTIdiscount1_MouseClick(sender As Object, e As MouseEventArgs) Handles txtTIdiscount1.MouseClick
        Me.txtTIdiscount1.SelectAll()
    End Sub



    Private Sub txtTItaxpercen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTItaxpercen.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtTItaxpercen_TextChanged(sender As Object, e As EventArgs) Handles txtTItaxpercen.TextChanged
        If Me.txtTItaxpercen.Text = "" Then
            Me.txtTItaxpercen.Text = "0"
        Else
            Call sumALL()
        End If
    End Sub

    Private Sub rbTItotaltax_CheckedChanged(sender As Object, e As EventArgs) Handles rbTItotaltax.CheckedChanged
        Call rbCheck()
        Call sumALL()
    End Sub

    Private Sub rbTIuntax_CheckedChanged(sender As Object, e As EventArgs) Handles rbTIuntax.CheckedChanged
        Call rbCheck()
        Call sumALL()
    End Sub
    Private Sub saveANDprint()
        Try
            strSQL = "DELETE FROM taxinvoice WHERE taxinvoice_id='" & Me.txtTIbillID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If Me.cbTaxUpdate.CheckState = CheckState.Checked Then
            Try
                strSQL = "UPDATE customer SET customer_tax='" & Me.txtTItaxNumber.Text & "'" _
                    & ",customer_section='" & Me.txtTItaxSection.Text & "' WHERE customer_id='" & Me.txtTIcusid.Text & "';"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If

        Try
            For SPP As Integer = 0 To Me.dgTI.Rows.Count - 1
                strSQL = "INSERT INTO taxinvoice(taxinvoice_id,taxinvoice_type,customer_id,customer_name," _
                    & "customer_address,customer_tel,code_pro,name_pro,total,unit,price_buy,discount,note,tax_num,tax_section,refer)" _
                            & "VALUES(@taxinvoice_id,@taxinvoice_type,@customer_id,@customer_name," _
                            & "@customer_address,@customer_tel,@code_pro,@name_pro,@total,@unit,@price_buy,@discount,@note,@tax_num,@tax_section,@refer);"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.AddWithValue("@taxinvoice_id", Me.txtTIbillID.Text)
                        .Parameters.AddWithValue("@taxinvoice_type", Me.cbbTIselectbill.Text)
                        .Parameters.AddWithValue("@customer_id", Me.txtTIcusid.Text)
                        .Parameters.AddWithValue("@customer_name", Me.txtTIcusname.Text)
                        .Parameters.AddWithValue("@customer_address", Me.txtTIcusaddress.Text)
                        .Parameters.AddWithValue("@customer_tel", Me.txtTIcustel.Text)
                        .Parameters.AddWithValue("@code_pro", Me.dgTI.Rows(SPP).Cells(1).Value)
                        .Parameters.AddWithValue("@name_pro", Me.dgTI.Rows(SPP).Cells(2).Value)
                        .Parameters.AddWithValue("@total", Me.dgTI.Rows(SPP).Cells(3).Value)
                        .Parameters.AddWithValue("@unit", Me.dgTI.Rows(SPP).Cells(4).Value)
                        .Parameters.AddWithValue("@price_buy", Me.dgTI.Rows(SPP).Cells(5).Value)
                        .Parameters.AddWithValue("@discount", Me.dgTI.Rows(SPP).Cells(6).Value)
                        .Parameters.AddWithValue("@note", Me.txtTInote.Text)
                        .Parameters.AddWithValue("@tax_num", Me.txtTItaxNumber.Text)
                        .Parameters.AddWithValue("@tax_section", Me.txtTItaxSection.Text)
                        .Parameters.AddWithValue("@refer", Me.txtRefer.Text)
                    End With
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

    End Sub

    Friend BillHeader As String

    Private Sub btnTIsavePrint_Click(sender As Object, e As EventArgs) Handles btnTIsavePrint.Click
        If Me.dgTI.Rows.Count = 0 Then
            Exit Sub
        Else
            If Me.txtTIcusid.Text = "" Then
                Me.txtTIcusid.Focus()
                Me.txtTIcusid.BackColor = Color.OrangeRed
                MsgBox("กรุณาใส่รหัสลูกค้าด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf Me.cbbTIselectbill.Text = "" Then
                Me.Label4.BackColor = Color.OrangeRed
                MsgBox("กรุณาเลือกชนิดใบเสร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                If MessageBox.Show("โปรดตรวจสอบข้อมูลว่าถูกต้องหรือไม่ก่อนพิมพ์", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If Me.txtRefer.Text = Nothing Then
                        Me.txtRefer.Text = "-"
                    End If

                    If Me.txtTIbillID.Text = Nothing Then
                        Call AutoNumberNo()
                    End If
                    Call saveANDprint()
                    If Me.cbbTIselectbill.Text = "ใบส่งของ" Then
                        BillHeader = "ใบส่งของ/Invoice"
                        BillingINV1A4CRPrintFrm.ShowDialog(Me)
                    ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน" Then
                        BillHeader = "ใบเสร็จรับเงิน/Receipt"
                        BillingINVnotVATA4CRPrintFrm.ShowDialog(Me)
                    ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน/ใบกำกับภาษี" Then
                        BillHeader = "ใบเสร็จรับเงิน/ใบกำกับภาษี/Receipt/Tax Invoice"
                        BillingINVSaleA4CRPrintFrm.ShowDialog(Me)
                    ElseIf Me.cbbTIselectbill.Text = "ใบเสนอราคา" Then
                        BillHeader = "ใบเสนอราคา/Quotation"
                        BillingINVA4CRPrintFrm.ShowDialog(Me)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnTIcancel_Click(sender As Object, e As EventArgs) Handles btnTIcancel.Click
        Call restart()
    End Sub

    Private Sub btnTIserachBill_Click(sender As Object, e As EventArgs) Handles btnTIserachBill.Click
        TaxInvoiceSearchIDFrm.ShowDialog(Me)
    End Sub

    Private Sub btnTIsearchBarcode_Click(sender As Object, e As EventArgs) Handles btnTIsearchBarcode.Click
        TaxInvoiceSelectProFrm.ShowDialog(Me)
    End Sub

    Private Sub btnTIsearchOldBill_Click(sender As Object, e As EventArgs) Handles btnTIsearchOldBill.Click
        ViewOldTaxInvoiceFrm.ShowDialog(Me)
    End Sub
    Friend dc As String
    Friend tp As String
    Friend Sub cbs()
        If cbTIdiscount.Checked Then
            dc = "ส่วนลด " & Me.txtTIdiscount1.Text & " บาท"
        Else
            dc = ""
        End If
        If cbTItexpro.Checked Then
            tp = "ภาษีมูลค่าเพิ่ม " & Me.txtTItotalTax.Text & " บาท"
        Else
            tp = ""
        End If
    End Sub
    Friend ssp As String
    Friend srp As String
    Friend Sub selbill()
        If Me.cbbTIselectbill.Text = "ใบส่งของ" Then
            ssp = "ผู้ส่งของ....................................................." & vbNewLine & "             (.....................................................)"
            srp = "ผู้รับของ....................................................." & vbNewLine & "             (.....................................................)"
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน" Then
            ssp = "พนักงาน......................................................" & vbNewLine & "             (.....................................................)"
            srp = "ผู้รับเงิน....................................................." & vbNewLine & "              (.....................................................)"
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน/ใบกำกับภาษี" Then
            ssp = "พนักงาน......................................................" & vbNewLine & "             (.....................................................)"
            srp = "ผู้รับเงิน...................................................." & vbNewLine & "               (.....................................................)"
        ElseIf Me.cbbTIselectbill.Text = "ใบเสนอราคา" Then
            ssp = "ผู้จัดทำ......................................................." & vbNewLine & "             (.....................................................)"
            srp = "ผู้เสนอราคา...................................................." & vbNewLine & "             (.....................................................)"
        End If
    End Sub

    Private Sub btnTIsearchCus_Click(sender As Object, e As EventArgs) Handles btnTIsearchCus.Click
        SearchCustomerByBillingFrm.ShowDialog(Me)
    End Sub

    Private Function SelectNote(cbbTIselectbill) As String

        If cbbTIselectbill = "ใบส่งของ" Then
            Try
                cmd = New MySqlCommand("SELECT com_Invoice FROM company;", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows = True Then
                    Dr.Read()
                    Return Dr.Item("com_Invoice")
                Else
                    Return "-"
                End If
            Catch ex As Exception
                Return "-"
            End Try
        ElseIf cbbTIselectbill = "ใบเสร็จรับเงิน" Then
            Try
                cmd = New MySqlCommand("SELECT com_recipt FROM company;", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows = True Then
                    Dr.Read()
                    Return Dr.Item("com_recipt")
                Else
                    Return "-"
                End If
            Catch ex As Exception
                Return "-"
            End Try
        ElseIf cbbTIselectbill = "ใบเสร็จรับเงิน/ใบกำกับภาษี" Then
            Try
                cmd = New MySqlCommand("SELECT com_recipt FROM company;", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows = True Then
                    Dr.Read()
                    Return Dr.Item("com_recipt")
                Else
                    Return "-"
                End If
            Catch ex As Exception
                Return "-"
            End Try
        ElseIf cbbTIselectbill = "ใบเสนอราคา" Then
            Try
                cmd = New MySqlCommand("SELECT com_quotation FROM company;", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows = True Then
                    Dr.Read()
                    Return Dr.Item("com_quotation")
                Else
                    Return "-"
                End If
            Catch ex As Exception
                Return "-"
            End Try
        Else
            Return "-"
        End If
    End Function

    Private Sub cbbSelectBill()
        If Me.cbbTIselectbill.Text = "ใบส่งของ" Then
            Me.lblExDay.Visible = False
            Me.cbbExDay.Visible = False
            Me.rbTIuntax.Visible = True
            Me.rbTItotaltax.Visible = True
            Me.txtTItaxpercen.Visible = True
            Me.lblTItaxpercen.Visible = True
            Me.btnTaxinEx.Visible = True
            Me.btnTaxinEx.Text = "นอก"
            Me.cbDateSend.Visible = True
            Me.DateTimePicker2.Visible = True
            Me.lblDateCadit.Visible = True
            Me.cbbDateCadit.Visible = True
            Me.lblRefer.Visible = True
            Me.txtRefer.Visible = True
            Me.DateTimePicker2.Value = DateTime.Now.AddDays(0)
            Me.cbbExDay.SelectedItem = "7"
            Me.cbbDateCadit.SelectedItem = "-"
            Me.txtTInote.Text = SelectNote(Me.cbbTIselectbill.Text.ToString)
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน" Then
            Me.lblExDay.Visible = False
            Me.cbbExDay.Visible = False
            Me.rbTIuntax.Visible = False
            Me.rbTItotaltax.Visible = False
            Me.txtTItaxpercen.Visible = False
            Me.lblTItaxpercen.Visible = False
            Me.btnTaxinEx.Visible = False
            Me.btnTaxinEx.Text = "นอก"
            Me.cbDateSend.Visible = True
            Me.DateTimePicker2.Visible = True
            Me.lblDateCadit.Visible = False
            Me.cbbDateCadit.Visible = False
            Me.lblRefer.Visible = True
            Me.txtRefer.Visible = True
            Me.txtTInote.Text = SelectNote(Me.cbbTIselectbill.Text.ToString)
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน/ใบกำกับภาษี" Then
            Me.lblExDay.Visible = False
            Me.cbbExDay.Visible = False
            Me.rbTIuntax.Visible = True
            Me.rbTItotaltax.Visible = True
            Me.txtTItaxpercen.Visible = True
            Me.lblTItaxpercen.Visible = True
            Me.btnTaxinEx.Visible = True
            Me.btnTaxinEx.Text = "นอก"
            Me.cbDateSend.Visible = False
            Me.DateTimePicker2.Visible = False
            Me.lblDateCadit.Visible = False
            Me.cbbDateCadit.Visible = False
            Me.lblRefer.Visible = True
            Me.txtRefer.Visible = True
            Me.txtTInote.Text = SelectNote(Me.cbbTIselectbill.Text.ToString)
        ElseIf Me.cbbTIselectbill.Text = "ใบเสนอราคา" Then
            Me.lblExDay.Visible = True
            Me.cbbExDay.Visible = True
            Me.rbTIuntax.Visible = True
            Me.rbTItotaltax.Visible = True
            Me.txtTItaxpercen.Visible = True
            Me.lblTItaxpercen.Visible = True
            Me.btnTaxinEx.Visible = True
            Me.btnTaxinEx.Text = "นอก"
            Me.cbDateSend.Visible = True
            Me.DateTimePicker2.Visible = True
            Me.lblDateCadit.Visible = True
            Me.cbbDateCadit.Visible = True
            Me.lblRefer.Visible = False
            Me.txtRefer.Visible = False
            Me.DateTimePicker2.Value = DateTime.Now.AddDays(0)
            Me.cbbExDay.SelectedItem = "7"
            Me.cbbDateCadit.SelectedItem = "-"
            Me.txtTInote.Text = SelectNote(Me.cbbTIselectbill.Text.ToString)
        End If
    End Sub

    Private Sub cbbTIselectbill_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbTIselectbill.SelectedValueChanged
        Call cbbSelectBill()
        'Me.txtTIbillID.Clear()
    End Sub

    Private Sub cbbDateCadit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbDateCadit.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbExDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbExDay.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbDateSend_CheckedChanged(sender As Object, e As EventArgs) Handles cbDateSend.CheckedChanged
        If Me.cbDateSend.Checked = True Then
            Me.DateTimePicker2.Enabled = True
        Else
            Me.DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub DUDTaxinEx_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub btnTaxinEx_Click(sender As Object, e As EventArgs) Handles btnTaxinEx.Click
        If Me.btnTaxinEx.Text = "นอก" Then
            Me.btnTaxinEx.Text = "ใน"
            Call sumALL()
        ElseIf Me.btnTaxinEx.Text = "ใน" Then
            Me.btnTaxinEx.Text = "นอก"
            Call sumALL()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/billing/taxinvoicefrm")
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub cbbTIselectbill_TextChanged(sender As Object, e As EventArgs) Handles cbbTIselectbill.TextChanged
        Call cbbSelectBill()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call AutoNumberNo()
    End Sub
End Class