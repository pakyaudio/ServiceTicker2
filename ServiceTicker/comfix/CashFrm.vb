Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class CashFrm
    Friend price As Decimal
    Private Sub addCBBpay()
        Me.cbbCashSelectPayment.Items.Add("เงินสด")
        Me.cbbCashSelectPayment.Items.Add("เช็ค")
        Me.cbbCashSelectPayment.Items.Add("โอนเข้าบัญชีธนาคาร")
        Me.cbbCashSelectPayment.Items.Add("บัตรเครดิต")
        Me.cbbCashSelectPayment.Items.Add("อื่นๆ")
    End Sub

    Private Sub CashFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CashFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call addCBBpay()
        price = Me.txtCashCash.Text
        Me.btnCashSave.Enabled = False
        Me.DateTimePicker1.Value = DateTime.Now.AddDays(0)
    End Sub
    Friend cashID As String
 
    'Private Sub AutoNumberNo()
    '    Call ALLAutonumber("ver_debtor", Me.txtCashpledgeID.Text)
    '    Call ALLAutonumber("ver_cash", cashID)
    'End Sub

    Friend sid, cashDetail, discountDT As String
    Friend tta, dscl As Decimal

    Private Sub cdt()
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
    End Sub

    Private Sub discount()
        If Me.txtCashPercen.Text <> Nothing Or Me.txtCashLowerCash.Text <> Nothing Then
            Try
                If Me.txtCashPercen.Text <> Nothing Then
                    discountDT = "ลด " & Me.txtCashPercen.Text & " %"
                ElseIf Me.txtCashLowerCash.Text <> Nothing Then
                    discountDT = "ลด " & Me.txtCashLowerCash.Text & " บาท"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                cmd = New MySqlCommand("SELECT sale_id,total_all FROM sale WHERE fix_id='" & Me.txtCashFixID.Text & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                sid = Dr.Item("sale_id")
                tta = Dr.GetDecimal("total_all")
                dscl = tta - CDec(Me.txtCashCash.Text)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Call cdt()

            Try
                strSQL = "insert into discount(sale_id,fix_id,cash,cash_back,cash_detail,discount,discount_detail,datetime_save)values" _
                    & "(@sale_id,@fix_id,@cash,@cash_back,@cash_detail,@discount,@discount_detail,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", sid))
                    .Parameters.Add(New MySqlParameter("@fix_id", Me.txtCashFixID.Text))
                    .Parameters.Add(New MySqlParameter("@cash", Me.txtCashCusPrice.Text))
                    .Parameters.Add(New MySqlParameter("@cash_back", Me.txtCashBack.Text))
                    .Parameters.Add(New MySqlParameter("@cash_detail", cashDetail))
                    .Parameters.Add(New MySqlParameter("@discount", dscl))
                    .Parameters.Add(New MySqlParameter("@discount_detail", discountDT))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub saveDataPledge_sale()
        Try
            cmd = New MySqlCommand("SELECT customer_name from sale where fix_id='" & Me.txtCashFixID.Text & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim xx As String
            xx = Dr.Item("customer_name")
            Dr.Close()
            strSQL = "insert into pledge_sale(p_id,total1,cash1,transfer1,check1,detail1,customer_id,customer_name,employee,datetime_save)values" _
                & "(@p_id,@total1,@cash1,@transfer1,@check1,@detail1,@customer_id,@customer_name,@employee,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@p_id", Me.txtCashpledgeID.Text))
                .Parameters.Add(New MySqlParameter("@total1", Me.txtCashCusPrice.Text))
                If Me.cbbCashSelectPayment.Text = "เงินสด" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "เงินสด"))
                    .Parameters.Add(New MySqlParameter("@transfer1", "-"))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/เงินสด"))
                ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", "-"))
                    .Parameters.Add(New MySqlParameter("@check1", Me.txtCashByselectPayment.Text))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/เช็ค"))
                ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", Me.txtCashByselectPayment.Text))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/โอนเข้าบัญชีธนาคาร"))

                ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", Me.txtCashByselectPayment.Text))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/บัตรเครดิต"))

                ElseIf Me.cbbCashSelectPayment.Text = "อื่นๆ" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", Me.txtCashByselectPayment.Text))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/อื่นๆ"))
                End If
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtCashCusID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", xx))
                .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                Call open_connection()
                Dim savepay As Integer
                savepay = cmd.ExecuteNonQuery()
                If savepay = 1 Then
                    MessageBox.Show(Me, "บันทึกมัดจำ/ลดหนี้ แล้ว", "บันทึกแล้ว", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(Me, "บันทึกมัดไม่สำเร็จ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtCashPercen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashPercen.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = "." Then
            If txtCashPercen.Text = "" Then 'ตรวจสอบว่า มีค่าใน textbox หรือยัง
                If e.KeyChar = "." Then 'ตรวจสอบว่า ผู้ใช้ป้อน . หรือไม่ ถ้าใช้ให้
                    txtCashPercen.Text = "0." 'แทนค่าใน textbox เป็น 0.
                    txtCashPercen.SelectionStart() = 2 'สั่งให้ ตัว select อยู่ในตำแหน่งที่ 2 คือ ต่อจาก 0.
                End If
            End If
            If txtCashPercen.Text Like "[0]" Then 'ตรวจสอบว่า ใน textbox มีตัวเลข 0 อยู่ด้านหน้าสุดหรือไม่
                If e.KeyChar = "." Or e.KeyChar = vbBack Then 'ถ้ามีให้ รับได้เฉพาะ . กับ backspace
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                txtCashPercen.SelectionStart() = 1 'สั่งให้ selecttion เริ่มที่ 0 คือ ต่อจาก 1
                Exit Sub
            End If
            If Me.txtCashPercen.Text Like "*[.]*" Then
                If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                Exit Sub
            End If
            e.Handled = False
        Else
            e.Handled = True
            txtCashPercen.Focus()
            txtCashPercen.SelectAll()
        End If
    End Sub
    Private Sub txtCashPercen_TextChanged(sender As Object, e As EventArgs) Handles txtCashPercen.TextChanged
        Try
            Me.txtCashLowerCash.Text = Nothing
            Me.txtCashCusPrice.Text = "0"
            Me.txtCashCash.Text = price
            If Me.txtCashPercen.Text = Nothing Then
                Me.txtCashCash.Text = price
            Else
                Me.txtCashCash.Text = price - ((CDec(Me.txtCashPercen.Text) / 100) * CDec(Me.txtCashCash.Text))
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtCashLowerCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashLowerCash.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = "." Then
            If txtCashLowerCash.Text = "" Then 'ตรวจสอบว่า มีค่าใน textbox หรือยัง
                If e.KeyChar = "." Then 'ตรวจสอบว่า ผู้ใช้ป้อน . หรือไม่ ถ้าใช้ให้
                    txtCashLowerCash.Text = "0." 'แทนค่าใน textbox เป็น 0.
                    txtCashLowerCash.SelectionStart() = 2 'สั่งให้ ตัว select อยู่ในตำแหน่งที่ 2 คือ ต่อจาก 0.
                End If
            End If
            If txtCashLowerCash.Text Like "[0]" Then 'ตรวจสอบว่า ใน textbox มีตัวเลข 0 อยู่ด้านหน้าสุดหรือไม่
                If e.KeyChar = "." Or e.KeyChar = vbBack Then 'ถ้ามีให้ รับได้เฉพาะ . กับ backspace
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                txtCashLowerCash.SelectionStart() = 1 'สั่งให้ selecttion เริ่มที่ 0 คือ ต่อจาก 1
                Exit Sub
            End If
            If Me.txtCashLowerCash.Text Like "*[.]*" Then
                If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                Exit Sub
            End If
            e.Handled = False
        Else
            e.Handled = True
            txtCashLowerCash.Focus()
            txtCashLowerCash.SelectAll()
        End If
    End Sub

    Private Sub txtCashLowerCash_TextChanged(sender As Object, e As EventArgs) Handles txtCashLowerCash.TextChanged
        Try
            Me.txtCashPercen.Text = Nothing
            Me.txtCashCusPrice.Text = "0"
            Me.txtCashCash.Text = price
            If Me.txtCashLowerCash.Text = Nothing Then
            Else
                Me.txtCashCash.Text = CDec(Me.txtCashCash.Text) - CDec(Me.txtCashLowerCash.Text)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtCashCusPrice_GotFocus(sender As Object, e As EventArgs) Handles txtCashCusPrice.GotFocus
        If Me.txtCashCusPrice.Text = "0" Then
            Me.txtCashCusPrice.Clear()
        End If
    End Sub

    Private Sub txtCashCusPrice_LostFocus(sender As Object, e As EventArgs) Handles txtCashCusPrice.LostFocus
        If Me.txtCashCusPrice.Text = Nothing Then
            Me.txtCashCusPrice.Text = "0"
        End If
    End Sub

    Private Sub txtCashCusPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashCusPrice.KeyPress
        If Me.txtCashCusPrice.Text = "0" Then
            Me.txtCashCusPrice.Clear()
        End If
        AddHandler CType(txtCashCusPrice, TextBox).KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub txtCashCusPrice_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusPrice.TextChanged
        Try
            If CDec(Me.txtCashCusPrice.Text) = CDec(Me.txtCashCash.Text) Or CDec(Me.txtCashCusPrice.Text) > CDec(Me.txtCashCash.Text) Then
                Me.cbbCashSelectPayment.SelectedItem = "เงินสด"
            End If

            If Me.txtCashCusPrice.Text = Nothing Then
                Me.txtCashBack.Text = "0"
                Me.txtCashpledgeID.Text = Nothing
                Me.btnCashSave.Enabled = False
            Else
                Me.txtCashBack.Text = CDec(Me.txtCashCusPrice.Text) - CDec(Me.txtCashCash.Text)
            End If

            If CDec(Me.txtCashCusPrice.Text) >= CDec(Me.txtCashCash.Text) Then
                Me.btnCashSave.Text = "บันทึกจ่ายเงิน"
                Me.txtCashpledgeID.Text = Nothing
                Me.btnCashSave.Enabled = True
            ElseIf CDec(Me.txtCashCusPrice.Text) < CDec(Me.txtCashCash.Text) Then
                Me.btnCashSave.Text = "มัดจำ"
                Me.btnCashSave.Enabled = True
                'Call AutoNumberNo()
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getData()
        Try
            Me.dgCash.Rows.Clear()
            strSQL = "SELECT sale_id,datetime_save,total_all from sale where customer_id='" & Me.txtCashCusID.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
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
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT p_id,datetime_save,total1 FROM pledge_sale WHERE customer_id='" & Me.txtCashCusID.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgCash
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("p_id")
                        .Rows(r).Cells(2).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(3).Value = -(Dr.GetDecimal("total1"))
                    End With
                End While
            End Using
            Dim suml As Decimal
            For sum As Integer = 0 To Me.dgCash.Rows.Count - 1
                suml += Me.dgCash.Rows(sum).Cells(3).Value
            Next
            Me.txtCcreditTotal.Text = suml
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub PaymentAndsendRepair()
        Try
            strSQL = "Update comfix set status='" & "7 คืนเครื่องแล้ว" & "',date_send='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' where fix_id='" & Me.txtCashFixID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtCashCusID_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusID.TextChanged
        Call getData()
    End Sub

    Private Sub cbbCashSelectPayment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbCashSelectPayment.SelectedValueChanged
        Me.lblCashSelectPaymentlbl.BackColor = SystemColors.Control
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
        ElseIf Me.cbbCashSelectPayment.Text = "อื่นๆ" Then
            If Me.txtCashByselectPayment.Text <> Nothing Then
                Me.txtCashByselectPayment.Clear()
            End If
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            'Me.cbbCScreditCard.Enabled = False
            'Me.cbbCScreditCardBank.Enabled = False
            Me.btnSelectDetail.Enabled = True
            Me.lblCashSelectPayment.Text = "รายละเอียด"
            Me.lblCashDTP.Text = "วันที่ชำระ"
        End If
    End Sub

    Private Sub SavePaymentsPrice()
        Try
            'ก็อปปี้ sale ไป cash_sale
            strSQL = "INSERT INTO cash_sale(sale_id,fix_id,customer_id,customer_name,total_all,date_in,datetime_save,date_edit,cash,cash_status,employee,return_id)" _
                 & "SELECT sale_id,fix_id,customer_id,customer_name,total_all,date_in,datetime_save,date_edit,cash,cash_status,employee,return_id FROM sale WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ก็อปปี้ sale_barcode ไป cash_sale_barcode
            strSQL = "INSERT INTO cash_sale_barcode(sale_id,customer_id,fix_id,customer_name,customer_tel,code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,`type`,date_in,datetime_save,return_id,employee,discount)" _
                    & "SELECT sale_id,customer_id,fix_id,customer_name,customer_tel,code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,`type`,date_in,datetime_save,return_id,employee,discount FROM sale_barcode WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ก็อปปี้ sale_serial ไป cash_sale_serial
            strSQL = "INSERT INTO cash_sale_serial(sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee)" _
                   & "SELECT sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee FROM sale_serial WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'อัพเดทวันที่บันทึก
        Call cdt()

        'อัพเดทวันที่,หมายเลขจ่ายเงิน cash ID บันทึกข้อมูล      
        'Try
        '    cmd = New MySqlCommand("INSERT INTO cash_id(cash_id,datetime_save)VALUES(@ci,@dts)", ConnectionDB)
        '    With cmd
        '        .Parameters.Add(New MySqlParameter("@ci", cashID))
        '        .Parameters.Add(New MySqlParameter("@dts", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
        '        Call open_connection()
        '        cmd.ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try
 
        Try
            'อัพเดท cash_sale
            strSQL = "UPDATE cash_sale SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString _
                ("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "',cash_status='" & "ชำระเงิน" & "',employee='" & _
                Me.lblEmployee.Text & "',cash='" & Me.txtCashCusPrice.Text & "',cash_back='" & Me.txtCashBack.Text & _
                "',cash_detail='" & cashDetail & "' WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'อัพเดท cash_sale_barcode
            strSQL = "UPDATE cash_sale_barcode SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString _
                ("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "',employee='" & Me.lblEmployee.Text & _
                "' WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'อัพเดท cash_sale_serial
            strSQL = "UPDATE cash_sale_serial SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString _
                ("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "',employee='" & Me.lblEmployee.Text & _
                "' WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

       
        Try
            'ลบ sale
            strSQL = "DELETE FROM sale WHERE fix_id='" & Me.txtCashFixID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ลบ sale_barcode
            strSQL = "DELETE FROM sale_barcode WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ลบ sale_serial
            strSQL = "DELETE FROM sale_serial WHERE fix_id='" & Me.txtCashFixID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Friend SRP As Integer


    Private Sub btnCashSave_Click(sender As Object, e As EventArgs) Handles btnCashSave.Click
        If MessageBox.Show(Me, "กรุณาตรวจสอบให้แน่ใจว่าทุกอย่างถูกต้อง ก่อนการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call cdt()
            If Me.btnCashSave.Text = "มัดจำ" Then

                If Me.cbbCashSelectPayment.Text = Nothing Then
                    Me.lblCashSelectPaymentlbl.BackColor = Color.Orange
                    MessageBox.Show(Me, "กรุณาเลือกรูปแบบการชำระเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Call ALLAutonumber("ver_debtor", Me.txtCashpledgeID.Text)
                    'Call SaveID()
                    Call saveDataPledge_sale()
                    Call PaymentAndsendRepair()

                    If MessageBox.Show("บันทึกคืนแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งคืนหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If checkPrinter() = "A5" Then
                            SRP = 1235
                            SendRepairPrintA5Frm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A4" Then
                            SRP = 1234
                            SendRepairPrintA4Frm.ShowDialog(Me)
                        End If
                    End If
                    If MessageBox.Show("ต้องการจะพิมพ์ใบมัดจำ/ลดหนี้หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If checkPrinter() = "A5" Then
                            CreditReportPrintA5Frm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A4" Then
                            CreditReportPrintA4Frm.ShowDialog(Me)
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
                    SendRepairFrm.Close()
                    Me.Close()
                End If
            ElseIf Me.btnCashSave.Text = "บันทึกจ่ายเงิน" Then
                If Me.cbbCashSelectPayment.Text = "" Then
                    Me.lblCashSelectPaymentlbl.BackColor = Color.Orange
                    MessageBox.Show(Me, "กรุณาเลือกรูปแบบการชำระเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Call ALLAutonumber("ver_cash", cashID)
                    Call discount()  'บันทึกส่วนลด
                    Call PaymentAndsendRepair()   'บันทึกจ่ายเงินและคืนเครื่อง

                    If MessageBox.Show("บันทึกคืนแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งคืนหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If checkPrinter() = "A5" Then
                            SRP = 1235
                            SendRepairPrintA5Frm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A4" Then
                            SRP = 1234
                            SendRepairPrintA4Frm.ShowDialog(Me)
                        End If
                    End If

                    If MessageBox.Show("ต้องการจะพิมพ์ใบเสร็จรับเงินหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If checkPrinter() = "A5" Then
                            SRP = 1235
                            ReceiptReportA5PrintFrm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A4" Then
                            SRP = 1234
                            ReceiptReportA4PrintFrm.ShowDialog(Me)
                        End If
                    End If

                    Call SavePaymentsPrice()         'ย้ายข้อมูลจากยังไม่ชำระไปชำระแล้ว
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
                    SendRepairFrm.Close()
                    Me.Close()
                End If
            End If
            cashDetail = Nothing
        End If
    End Sub

    Private Sub btnSelectDetail_Click(sender As Object, e As EventArgs) Handles btnSelectDetail.Click
        cashSelectDetail = "CashFrm"
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