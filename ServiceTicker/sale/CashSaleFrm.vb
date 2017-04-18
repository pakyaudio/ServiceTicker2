Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class CashSaleFrm
    Friend price As Decimal
    Friend Sub addCBBpay()
        Me.cbbCashSelectPayment.Items.Add("เงินสด")
        Me.cbbCashSelectPayment.Items.Add("เช็ค")
        Me.cbbCashSelectPayment.Items.Add("โอนเข้าบัญชีธนาคาร")
        Me.cbbCashSelectPayment.Items.Add("บัตรเครดิต")
        Me.cbbCashSelectPayment.Items.Add("อื่น ๆ")
    End Sub

    Private Sub CashSaleFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CashSaleFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            NumberPadFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub CashSaleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.lblEmployee.Text = SaleFrm.lblEmployee.Text
        Me.btnSelectDetail.Enabled = False
        Call addCBBpay()
        Me.txtCashCusPrice.Text = "0.00"
        Me.DateTimePicker1.Value = DateTime.Now.AddDays(0)
        Me.Timer1.Start()
    End Sub
    Friend cashID As String
    Dim nid As String
    Dim nids As String

    Private Sub AutoNumberNo()
        'Try
        '    cmd = New MySqlCommand("SELECT ver_cash FROM ver_detail", ConnectionDB)
        '    Call open_connection()
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    nids = Dr.Item("ver_cash")
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try

        'Try
        '    cmd = New MySqlCommand("SELECT Max(ID) as ID FROM cash_id", ConnectionDB)
        '    Call open_connection()
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    If Not Dr.HasRows Then
        '        Me.txtCScashID.Text = nids & Now.ToString("yyMMddHHmm") & "00001"
        '    Else
        '        Dim newID As Integer = CInt(Dr.Item("ID"))
        '        newID += 1
        '        Me.txtCScashID.Text = nids & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
        '    End If
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try
        Call ALLAutonumber("ver_cash", Me.txtCScashID.Text)
    End Sub

    Friend Sub getData(ByVal CCid As String)
        Try
            Me.dgCash.Rows.Clear()
            strSQL = "SELECT sale_id,datetime_save,total_all FROM sale WHERE customer_id='" & CCid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With dgCash
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells("sale_id").Value = Dr.Item("sale_id")
                    .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                    .Rows(r).Cells("total_all").Value = Dr.GetDecimal("total_all")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT p_id,datetime_save,total1 FROM pledge_sale WHERE customer_id='" & CCid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With dgCash
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("p_id")
                    .Rows(r).Cells(2).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(3).Value = -(Dr.GetDecimal("total1"))
                End With
            End While
            Dim suml As Decimal
            For sum As Integer = 0 To Me.dgCash.Rows.Count - 1
                Me.dgCash.Rows(sum).Cells(0).Value = sum + 1
                suml += CDec(Me.dgCash.Rows(sum).Cells(3).Value)
            Next
            Me.txtCStotal.Text = suml
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.txtCashCusPrice.ForeColor = SystemColors.WindowText Then
            Me.txtCashCusPrice.ForeColor = Color.Red
        Else
            Me.txtCashCusPrice.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txtCashCusPrice_Click(sender As Object, e As EventArgs) Handles txtCashCusPrice.Click
        NumberPadFrm.ShowDialog(Me)
    End Sub

    Private Sub txtCashCusPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashCusPrice.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCashCusPrice_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusPrice.TextChanged
        Try
            Me.txtCashBack.Text = CDec(Me.txtCashCusPrice.Text) - CDec(Me.txtCStotalmoney.Text)
        Catch ex As Exception

        End Try
        If CDec(Me.txtCashCusPrice.Text) >= SaleFrm.totalPAL Then
            Call AutoNumberNo()
           
            Me.btnCashSave.Enabled = True
            Me.btnCashSave.Text = "บันทึกจ่ายเงิน (F10)"
            Try
                Me.cbbCashSelectPayment.SelectedIndex = 0
            Catch ex As Exception

            End Try
        ElseIf CDec(Me.txtCashCusPrice.Text) <= 0 Then
            Me.btnCashSave.Enabled = True
            Me.btnCashSave.Text = "ใบส่งของ (F10)"
        Else
            Me.btnCashSave.Enabled = False
            Me.btnCashSave.Text = "ชำระเต็มยอดเท่านั้น"
        End If

        If Me.btnCashSave.Text = "บันทึกจ่ายเงิน (F10)" Then
            Me.cbbCashSelectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
        ElseIf Me.btnCashSave.Text = "ใบส่งของ (F10)" Then
            Me.cbbCashSelectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.txtCashByselectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
        Else
            Me.cbbCashSelectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.txtCashByselectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
        End If
    End Sub

    Private Sub btnCashSave_TextChanged(sender As Object, e As EventArgs) Handles btnCashSave.TextChanged
        If Me.btnCashSave.Text = "บันทึกจ่ายเงิน (F10)" Then
            Me.cbbCashSelectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
        ElseIf Me.btnCashSave.Text = "ใบส่งของ (F10)" Then
            Me.cbbCashSelectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.txtCashByselectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
        Else
            Me.cbbCashSelectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.txtCashByselectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
        End If
    End Sub

    Private Sub StaetPaymentDetail(ByVal sta As Boolean)
        If sta = False Then
            Me.cbbCashSelectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.txtCashByselectPayment.Enabled = False
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
            Me.lblCashSelectPayment.Text = "......"
            Me.lblCashDTP.Text = "......"
        ElseIf sta = True Then
            Me.cbbCashSelectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.txtCashByselectPayment.Enabled = True
            'Me.cbbCScreditCard.Enabled = True
            'Me.cbbCScreditCardBank.Enabled = True
        End If
    End Sub

    Private Sub cbbCashSelectPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbCashSelectPayment.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbCashSelectPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCashSelectPayment.SelectedIndexChanged
        Call StaetPaymentDetail(False)
        Me.cbbCashSelectPayment.Enabled = True
        If Me.cbbCashSelectPayment.Text = "เงินสด" Then
            Me.txtCashByselectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = True
            Me.lblCashSelectPayment.Text = "......"
            Me.lblCashDTP.Text = "วันที่ชำระเงิน(วันนี้)"
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
            Me.btnSelectDetail.Enabled = False
        ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.lblCashSelectPayment.Text = "หมายเลขเช็ค"
            Me.lblCashDTP.Text = "สั่งจ่ายวันที่"
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False     
            Me.btnSelectDetail.Enabled = True
        ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.lblCashSelectPayment.Text = "ชื่อธนาคาร"
            Me.lblCashDTP.Text = "วันที่โอน"
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
            Me.btnSelectDetail.Enabled = True
        ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            'Me.cbbCScreditCard.Enabled = True
            'Me.cbbCScreditCardBank.Enabled = True
            Me.btnSelectDetail.Enabled = True
            Me.lblCashSelectPayment.Text = "หมายเลขบัตร/ประเภท"
            Me.lblCashDTP.Text = "วันที่ชำระ/ธ.เจ้าของบัตร"
        ElseIf Me.cbbCashSelectPayment.Text = "อื่น ๆ" Then
            If Me.txtCashByselectPayment.Text <> Nothing Then
                Me.txtCashByselectPayment.Clear()
            End If
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
            Me.btnSelectDetail.Enabled = True
            Me.lblCashSelectPayment.Text = "ใส่รายละเอียดการชำระ"
            Me.lblCashDTP.Text = ""
        End If
    End Sub

    Private Sub cbbCScreditCard_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbbCScreditCardBank_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub discount()
        If CInt(Me.txtCSdiscount.Text) > 0 Then
            Try
                strSQL = "INSERT INTO discount(sale_id,fix_id,cash,cash_back,cash_detail,discount,discount_detail,datetime_save)VALUES" _
                    & "(@sale_id,@fix_id,@cash,@cash_back,@cash_detail,@discount,@discount_detail,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtCSsale_id.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                    .Parameters.Add(New MySqlParameter("@cash", Me.txtCashCusPrice.Text))
                    .Parameters.Add(New MySqlParameter("@cash_back", Me.txtCashBack.Text))
                    .Parameters.Add(New MySqlParameter("@cash_detail", cashDetail))
                    .Parameters.Add(New MySqlParameter("@discount", Me.txtCSdiscount.Text))
                    .Parameters.Add(New MySqlParameter("@discount_detail", "ลด " & Me.txtCSdiscount.Text & " บาท"))
                    .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime()))
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Friend cashDetail As String
    Private Sub btnCashSave_Click(sender As Object, e As EventArgs) Handles btnCashSave.Click
        If Me.btnCashSave.Text = "บันทึกจ่ายเงิน (F10)" Then
            If Me.cbbCashSelectPayment.Text = "" Then
                MessageBox.Show(Me, "กรูณาเลือกรูปแบบการชำระเงินก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.lblCashSelectPaymentlbl.BackColor = Color.Orange
            Else
                If MessageBox.Show(Me, "โปรดตรวจสอบความถูกต้องของสินค้า ราคาสินค้าให้เรียบร้อย จากนี้ไปจะไม่สามารถแก้ไขได้อีก", "ยืนยัน", MessageBoxButtons.OKCancel _
                          , MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If Me.cbbCashSelectPayment.Text = "เงินสด" Then
                        cashDetail = "เงินสด"
                    ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
                        cashDetail = Me.txtCashByselectPayment.Text & "\ลงวันที่ " & Convert.ToDateTime _
                            (Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))
                    ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
                        cashDetail = "โอนเข้าธนาคาร" & Me.txtCashByselectPayment.Text & "\โอนวันที่ " & Convert.ToDateTime _
                            (Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))
                        'add
                    ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
                        cashDetail = "บัตรเครดิต " & Me.txtCashByselectPayment.Text _
                            & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))
                    ElseIf Me.cbbCashSelectPayment.Text = "อื่น ๆ" Then
                        cashDetail = "อื่นๆ " & Me.txtCashByselectPayment.Text & " " _
                             & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))
                    End If
                    Call SaleFrm.saveSale_id()
                    Call SaleFrm.saveCash_id()
                    Call discount()
                    Call SaleFrm.saveCashDGwsnTodatabase()
                    Call SaleFrm.saveCashDGNosnTodatabase()
                    Call SaleFrm.saveCashSaleAll()
                    'พิมพ์ใบเสร็จรับเงิน
                    If MessageBox.Show(Me, "ต้องการจะพิมพ์ใบเสร็จรับเงินหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        If checkPrinter() = "A4" Then
                            ReceiptSalePrintA4ReportFrm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A5" Then
                            ReceiptSalePrintA5ReportFrm.ShowDialog(Me)
                        End If
                    End If
                    SaleFrm.autonum = Nothing
                    SaleFrm.clearform()
                    Me.Close()
                End If
            End If
        ElseIf Me.btnCashSave.Text = "ใบส่งของ (F10)" Then
            If SaleFrm.txtScusID.Text = "0" Then
                MessageBox.Show(Me, "การออกใบส่งของควรเป็นชื่อบุคคล ไม่ใช่ชื่อลูกค้าเงินสด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Call SaleFrm.saveSaleAll()
                Call SaleFrm.saveSale_id()
                Call discount()
                Call SaleFrm.saveDGwsnTodatabase()
                Call SaleFrm.saveDGNosnTodatabase()
                'พิมพ์ใบส่งของ
                If MessageBox.Show(Me, "ต้องการจะพิมพ์ใบส่งของหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If checkPrinter() = "A4" Then
                        InvoiceSaleA4ReportFrm.ShowDialog(Me)
                    ElseIf checkPrinter() = "A5" Then
                        InvoiceSaleA5ReportFrm.ShowDialog(Me)
                    End If
                End If
                SaleFrm.clearform()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnSelectDetail_Click(sender As Object, e As EventArgs) Handles btnSelectDetail.Click
        cashSelectDetail = "CashSaleFrm"
        If Me.cbbCashSelectPayment.Text = "เช็ค" Then
            DebtorCheckDetailFrm.ShowDialog(Me)
        ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
            DebtorBookbankDetailFrm.ShowDialog(Me)
        ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
            DebtorCraditCardDetailFrm.ShowDialog(Me)
        End If
        cashSelectDetail = Nothing
    End Sub
End Class