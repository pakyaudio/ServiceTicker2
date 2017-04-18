Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CustomerFrm
    Dim aucusid As String
    Private Sub AutoNumberNo()
        If aucusid = Nothing Then
            Call ALLAutonumber("ver_cusid", aucusid)
            Me.txtCustomerID.Text = aucusid
        Else
            Me.txtCustomerID.Text = aucusid
        End If
    End Sub

    Private Sub startfrm()
        Me.NewToolStripButton.Enabled = True
        Me.EditToolStripButton.Enabled = False

        Me.SaveToolStripButton.Enabled = False
        Me.CancelToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        Me.cbAutoCusID.CheckState = CheckState.Checked
        Me.cbAutoCusID.Enabled = False
        Me.txtCustomerID.Clear()
        Me.txtCustomerTAX.Clear()
        Me.txtCustomerSection.Clear()
        Me.txtCustomerName.Clear()
        Me.txtCustomerAddress.Clear()
        Me.txtCustomerZipcode.Clear()
        Me.txtCustomerTel.Clear()
        Me.txtCustomerNote.Clear()

        Me.cbbCustomerPrice_leval.Items.Clear()
        Me.cbbCustomerCadit.Items.Clear()

        Me.txtCustomerTAX.Text = "000000000000"
        Me.txtCustomerSection.Text = "-"
        Me.txtCustomerZipcode.Text = ""
        Me.txtCustomerNote.Text = "-"

        Me.dgCustomerSearch.Enabled = True
        Me.SearchToolStripTextBox.Enabled = True
        Me.SearchToolStripButton.Enabled = True
        Me.ShowAllStripButton.Enabled = True

        Me.txtCustomerID.Clear()

        Me.txtCustomerTAX.BackColor = SystemColors.Window
        Me.txtCustomerSection.BackColor = SystemColors.Window
        Me.txtCustomerName.BackColor = SystemColors.Window
        Me.txtCustomerAddress.BackColor = SystemColors.Window
        Me.txtCustomerZipcode.BackColor = SystemColors.Window
        Me.txtCustomerTel.BackColor = SystemColors.Window
        Me.txtCustomerNote.BackColor = SystemColors.Window
        Me.cbbCustomerPrice_leval.BackColor = SystemColors.Window
        Me.cbbCustomerCadit.BackColor = SystemColors.Window

        Me.txtCustomerTAX.Enabled = False
        Me.txtCustomerSection.Enabled = False
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerAddress.Enabled = False
        Me.txtCustomerZipcode.Enabled = False
        Me.txtCustomerTel.Enabled = False
        Me.txtCustomerNote.Enabled = False
        Me.cbbCustomerPrice_leval.Enabled = False
        Me.cbbCustomerCadit.Enabled = False
        Me.btnPicture.Enabled = False
        Me.PictureBox1.Image = Nothing
        SelectSave = Nothing

        Me.dgCustomerSearch.ClearSelection()
    End Sub

    Private Sub CustomerFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
        Try
            Dim cmd As New MySqlCommand("SELECT DISTINCT customer_address,customer_zipcode FROM customer ORDER BY customer_id DESC LIMIT 1000", ConnectionDB)
            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "customer_address")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("customer_address").ToString())
                Next
                Me.txtCustomerAddress.AutoCompleteCustomSource = col
                Me.txtCustomerAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCustomerAddress.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using


            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "customer_zipcode")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("customer_zipcode").ToString())
                Next
                Me.txtCustomerZipcode.AutoCompleteCustomSource = col
                Me.txtCustomerZipcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCustomerZipcode.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub CountNumber()
        Dim countCharacter As Integer = Me.txtCustomerTel.TextLength
        Me.lblCusCountNum.Text = "มี " & countCharacter & " ตัว"
    End Sub

    Private Sub txtCustomerTel_KeyPress(sender As Object, e As EventArgs) Handles txtCustomerTel.KeyPress
        Call CountNumber()
    End Sub

    'Item is filled either manually or from database 
    Dim lst As New List(Of String)

    'AutoComplete collection that will help to filter keep the records.
    Dim MySource As New AutoCompleteStringCollection()

    Private Sub txtCustomerAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerAddress.KeyDown
        If e.KeyCode = Keys.Enter Then   ' On enter I planned to add it the list
            If Not Me.txtCustomerAddress.AutoCompleteCustomSource.Contains(Me.txtCustomerAddress.Text) Then  ' If item not present already
                ' Add to the source directly
                Me.txtCustomerAddress.AutoCompleteCustomSource.Add(Me.txtCustomerAddress.Text)
            End If
        ElseIf e.KeyCode = Keys.Delete Then  ' On delete key i have planned to remove the entry
            ' remove item from source
            CType(Me.txtCustomerAddress.AutoCompleteCustomSource, AutoCompleteStringCollection).Remove(Me.txtCustomerAddress.Text)
            ' Clear textbox
            Me.txtCustomerAddress.Clear()
        End If
    End Sub

    Private Sub txtCustomerZipcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerZipcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not Me.txtCustomerZipcode.AutoCompleteCustomSource.Contains(Me.txtCustomerZipcode.Text) Then

                Me.txtCustomerZipcode.AutoCompleteCustomSource.Add(Me.txtCustomerZipcode.Text)
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            CType(txtCustomerZipcode.AutoCompleteCustomSource, AutoCompleteStringCollection).Remove(Me.txtCustomerZipcode.Text)
            Me.txtCustomerZipcode.Clear()
        End If
    End Sub

    Private Sub cbbCustomerPrice_level_Click(sender As Object, e As EventArgs) Handles cbbCustomerPrice_leval.Click
        Me.cbbCustomerPrice_leval.Items.Clear()
        Me.cbbCustomerPrice_leval.Items.Add("ราคาปกติ")
        Me.cbbCustomerPrice_leval.Items.Add("ราคาขายส่ง")
        Me.cbbCustomerPrice_leval.Items.Add("ราคาช่าง")
        Me.cbbCustomerPrice_leval.Items.Add("ราคาลูกค้าประจำ")
        Me.cbbCustomerPrice_leval.Items.Add("ราคาสมาชิก")
    End Sub

    Private Sub cbbCustomerCadit_Click(sender As Object, e As EventArgs) Handles cbbCustomerCadit.Click
        Me.cbbCustomerCadit.Items.Clear()
        Me.cbbCustomerCadit.Items.Add("5 วัน")
        Me.cbbCustomerCadit.Items.Add("15 วัน")
        Me.cbbCustomerCadit.Items.Add("1 เดือน")
        Me.cbbCustomerCadit.Items.Add("2 เดือน")
        Me.cbbCustomerCadit.Items.Add("3 เดือน")
        Me.cbbCustomerCadit.Items.Add("4 เดือน")
        Me.cbbCustomerCadit.Items.Add("5 เดือน")
        Me.cbbCustomerCadit.Items.Add("6 เดือน")
        Me.cbbCustomerCadit.Items.Add("7 เดือน")
        Me.cbbCustomerCadit.Items.Add("8 เดือน")
        Me.cbbCustomerCadit.Items.Add("9 เดือน")
        Me.cbbCustomerCadit.Items.Add("10 เดือน")
        Me.cbbCustomerCadit.Items.Add("11 เดือน")
        Me.cbbCustomerCadit.Items.Add("1 ปี")
        Me.cbbCustomerCadit.Items.Add("2 ปี")
        Me.cbbCustomerCadit.Items.Add("3 ปี")
    End Sub


    Private Sub GetAllData(Optional ByVal cSelect As Integer = Nothing)
        Try
            Me.dgCustomerSearch.Rows.Clear()
            If cSelect = 2 Then
                strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name," _
                               & "customer_address,customer_zipcode,customer_tel,customer_note,price_level,maturity,date_edit FROM customer" _
                               & " WHERE customer_tax LIKE'%" & Me.SearchToolStripTextBox.Text & "%'" _
                               & " OR customer_section LIKE'%" & Me.SearchToolStripTextBox.Text & "%'" _
                               & " OR customer_name LIKE'%" & Me.SearchToolStripTextBox.Text & "%'" _
                               & " OR customer_address LIKE'%" & Me.SearchToolStripTextBox.Text & "%'" _
                               & " OR customer_tel LIKE'%" & Me.SearchToolStripTextBox.Text & "%'"
                Me.SearchToolStripTextBox.Clear()
            ElseIf cSelect = 3 Then
                strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name," _
                                & "customer_address,customer_zipcode,customer_tel,customer_note," _
                                & "price_level,maturity,date_edit FROM customer ORDER BY date_edit DESC LIMIT " & NumericUpDown1.Value & ""
            Else
                strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name," _
                                & "customer_address,customer_zipcode,customer_tel,customer_note," _
                                & "price_level,maturity,date_edit FROM customer ORDER BY date_edit DESC LIMIT " & NumericUpDown1.Value & ""
            End If

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                With Me.dgCustomerSearch
                    Dim r As Integer = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_tax")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_section")
                    .Rows(r).Cells(5).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(6).Value = Dr.GetString("customer_zipcode")
                    .Rows(r).Cells(7).Value = Dr.GetString("customer_tel")
                    Dim num As String = Dr.GetString("price_level")
                    If num = "1" Then
                        .Rows(r).Cells(8).Value = "ราคาปกติ"
                    ElseIf num = "2" Then
                        .Rows(r).Cells(8).Value = "ราคาขายส่ง"
                    ElseIf num = "3" Then
                        .Rows(r).Cells(8).Value = "ราคาช่าง"
                    ElseIf num = "4" Then
                        .Rows(r).Cells(8).Value = "ราคาลูกค้าประจำ"
                    ElseIf num = "5" Then
                        .Rows(r).Cells(8).Value = "ราคาสมาชิก"
                    ElseIf num = "-" Then
                        .Rows(r).Cells(8).Value = "ราคาปกติ"
                    End If
                    Dim MT As String = Dr.GetString("maturity")
                    If MT = "5" Then
                        .Rows(r).Cells(9).Value = "5 วัน"
                    ElseIf MT = "15" Then
                        .Rows(r).Cells(9).Value = "15 วัน"
                    ElseIf MT = "30" Then
                        .Rows(r).Cells(9).Value = "1 เดือน"
                    ElseIf MT = "60" Then
                        .Rows(r).Cells(9).Value = "2 เดือน"
                    ElseIf MT = "90" Then
                        .Rows(r).Cells(9).Value = "3 เดือน"
                    ElseIf MT = "120" Then
                        .Rows(r).Cells(9).Value = "4 เดือน"
                    ElseIf MT = "150" Then
                        .Rows(r).Cells(9).Value = "5 เดือน"
                    ElseIf MT = "180" Then
                        .Rows(r).Cells(9).Value = "6 เดือน"
                    ElseIf MT = "210" Then
                        .Rows(r).Cells(9).Value = "7 เดือน"
                    ElseIf MT = "240" Then
                        .Rows(r).Cells(9).Value = "8 เดือน"
                    ElseIf MT = "270" Then
                        .Rows(r).Cells(9).Value = "9 เดือน"
                    ElseIf MT = "300" Then
                        .Rows(r).Cells(9).Value = "10 เดือน"
                    ElseIf MT = "330" Then
                        .Rows(r).Cells(9).Value = "11 เดือน"
                    ElseIf MT = "360" Then
                        .Rows(r).Cells(9).Value = "1 ปี"
                    ElseIf MT = "720" Then
                        .Rows(r).Cells(9).Value = "2 ปี"
                    ElseIf MT = "1080" Then
                        .Rows(r).Cells(9).Value = "3 ปี"
                    ElseIf MT = "-" Or MT = "" Then
                        .Rows(r).Cells(9).Value = "15 วัน"
                    End If
                    .Rows(r).Cells(10).Value = Dr.GetString("customer_note")
                    .Rows(r).Cells(11).Value = Dr.GetString("date_edit")
                End With
            End While
        Catch ex As Exception
            Me.SearchToolStripTextBox.Text = Nothing
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        For x As Integer = 0 To Me.dgCustomerSearch.Rows.Count - 1
            Try
                strSQL = "SELECT datetime_save FROM customer_id WHERE customer_id='" & Me.dgCustomerSearch.Rows(x).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.HasRows Then
                    Dr.Read()
                    Me.dgCustomerSearch.Rows(x).Cells(12).Value = Dr.GetString("datetime_save")
                Else
                    Me.dgCustomerSearch.Rows(x).Cells(12).Value = "###ไม่พบข้อมูล###"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
        cSelect = Nothing
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgCustomerSearch.CurrentCell = Me.dgCustomerSearch.Rows(Me.dgCustomerSearch.CurrentCell.RowIndex + 1).Cells(0)
            Call getDataByRow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgCustomerSearch.CurrentCell = Me.dgCustomerSearch.Rows(Me.dgCustomerSearch.CurrentCell.RowIndex - 1).Cells(0)
            Call getDataByRow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchToolStripTextBox.KeyDown
        If Me.SearchToolStripTextBox.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Call GetAllData(2)
            End If
        End If
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrm()
        End If
    End Sub

    Private Sub ShowAllStripButton_Click(sender As Object, e As EventArgs) Handles ShowAllStripButton.Click
        If Me.NumericUpDown1.Value > "10000" Then
            If MessageBox.Show(Me, "การแสดงผลทั้งหมดอาจจะใช้เวลานาน หากรายชื่อมีจำนวนมาก ต้องการทำต่อหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call GetAllData()
            End If
        Else
            Call GetAllData()
        End If
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        If Me.SearchToolStripTextBox.Text <> Nothing Then
            Call GetAllData(2)
        End If
    End Sub
    Private Sub NewDataSave()
        If Me.txtCustomerID.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ ID ลูกค้า", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerID.Focus()
            Me.txtCustomerID.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtCustomerTAX.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่หมายเลขผู้เสียภาษี ถ้าไม่มีให้ -", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerTAX.Focus()
            Me.txtCustomerTAX.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtCustomerSection.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่สาขาถ้าไม่มีให้ -", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerSection.Focus()
            Me.txtCustomerSection.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtCustomerName.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ชื่อลูกค้า", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerName.Focus()
            Me.txtCustomerName.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtCustomerAddress.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ที่อยู่ ถ้าไม่มีให้ -", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerAddress.Focus()
            Me.txtCustomerAddress.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtCustomerZipcode.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่รหัสไปรษณีย์ ถ้าไม่มีให้ -", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerZipcode.Focus()
            Me.txtCustomerZipcode.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtCustomerTel.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่เบอร์โทร ถ้าไม่มีให้ -", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerTel.Focus()
            Me.txtCustomerTel.BackColor = Color.Salmon
            Exit Sub
        End If

        If Me.txtCustomerNote.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาหมายเหตุ ถ้าไม่มีให้ -", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            Me.txtCustomerNote.Focus()
            Me.txtCustomerNote.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbCustomerPrice_leval.Text = Nothing Then
            Me.cbbCustomerPrice_leval.Text = "ราคาปกติ"
        End If
        If Me.cbbCustomerCadit.Text = Nothing Then
            Me.cbbCustomerCadit.Text = "1 เดือน"
        End If

        Try
            'ตรวจชื่อซ้ำ
            strSQL = "SELECT customer_id FROM customer WHERE customer_id='" & Me.txtCustomerID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                MessageBox.Show(Me, "รหัสสมาชิกซ้ำ กรุณาตรวจสอบ", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerID.Focus()
                Me.txtCustomerID.BackColor = Color.Salmon
                Exit Sub
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Dim iddu As String
            strSQL = "SELECT customer_name,customer_id FROM customer WHERE customer_tel='" & Me.txtCustomerTel.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            iddu = Dr.Item("customer_id")
            If Dr.HasRows Then
                If iddu = Me.txtCustomerID.Text Or Me.txtCustomerTel.Text = "-" Then
                    Exit Try
                Else
                    MessageBox.Show(Me, "พบเบอร์โทรศัพท์นี้ตรงกับรหัสลูกค้า " & iddu & " เบอร์โทรศัพท์ซ้ำ กรุณาตรวจสอบ", "ข้อมูลลูกค้า", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                    Me.txtCustomerTel.Focus()
                    Me.txtCustomerTel.BackColor = Color.Salmon
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If MessageBox.Show(Me, "ต้องการเพิ่มข้อมูลลูกค้า", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "INSERT INTO customer(customer_id, customer_name, customer_address, customer_zipcode, " & _
                    "customer_tel, customer_note, customer_tax, customer_section, price_level, maturity, date_edit,img)" _
                    & "VALUES(@i, @n, @a, @z, @t, @note, @tax, @sec, @pl, @mat, @ds,@img)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@i", Me.txtCustomerID.Text)
                cmd.Parameters.AddWithValue("@n", Me.txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@a", Me.txtCustomerAddress.Text)
                cmd.Parameters.AddWithValue("@z", Me.txtCustomerZipcode.Text)
                cmd.Parameters.AddWithValue("@t", Me.txtCustomerTel.Text)
                cmd.Parameters.AddWithValue("@note", Me.txtCustomerNote.Text)
                cmd.Parameters.AddWithValue("@tax", Me.txtCustomerTAX.Text)
                cmd.Parameters.AddWithValue("@sec", Me.txtCustomerSection.Text)
                Call selectPrice_level()
                cmd.Parameters.AddWithValue("@pl", num_level)
                Call Todate()
                cmd.Parameters.AddWithValue("@mat", Maturity)
                cmd.Parameters.AddWithValue("@ds", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                If Not PictureBox1.Image Is Nothing Then
                    Using newIMG = New Bitmap(PictureBox1.Image)
                        Using stream As New IO.MemoryStream
                            newIMG.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            cmd.Parameters.AddWithValue("@img", stream.GetBuffer())
                        End Using
                    End Using
                Else
                    cmd.Parameters.AddWithValue("@img", Nothing)
                End If
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            aucusid = Nothing
            Call startfrm()
            SelectSave = Nothing

            Call GetAllData(3)
        End If
        For Each form In My.Application.OpenForms
            If (form.name = SearchCustomerFrm.Name) Then
                If form.Visible Then
                    Call SearchCustomerFrm.GetDataByID()
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub EditCustomer()
            If Me.txtCustomerID.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาใส่ ID ลูกค้า", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerID.Focus()
                Me.txtCustomerID.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.txtCustomerName.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาใส่ชื่อลูกค้า", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerName.Focus()
                Me.txtCustomerName.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.txtCustomerAddress.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาใส่ที่อยู่ ถ้าไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerAddress.Focus()
                Me.txtCustomerAddress.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.txtCustomerZipcode.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาใส่รหัสไปรษณีย์ ถ้าไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerZipcode.Focus()
                Me.txtCustomerZipcode.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.txtCustomerTel.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาใส่เบอร์โทร ถ้าไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerTel.Focus()
                Me.txtCustomerTel.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.txtCustomerNote.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาหมายเหตุ ถ้าไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                Me.txtCustomerNote.Focus()
                Me.txtCustomerNote.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.cbbCustomerPrice_leval.Text = Nothing Then
                Me.cbbCustomerPrice_leval.Text = "ราคาปกติ"
            End If

            If Me.cbbCustomerCadit.Text = Nothing Then
                Me.cbbCustomerCadit.Text = "1 เดือน"
            End If

            Try
                Dim iddu As String
                strSQL = "SELECT customer_name,customer_id FROM customer WHERE customer_tel='" & Me.txtCustomerTel.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                iddu = Dr.Item("customer_id")

                If Dr.HasRows Then
                    If iddu = Me.txtCustomerID.Text Or Me.txtCustomerTel.Text = "-" Then
                        Exit Try
                    Else
                        MessageBox.Show(Me, "พบเบอร์โทรศัพท์นี้ตรงกับรหัสลูกค้า " & iddu & " เบอร์โทรศัพท์ซ้ำ กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
                        Me.txtCustomerTel.Focus()
                        Me.txtCustomerTel.BackColor = Color.Salmon
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try



        If MessageBox.Show(Me, "ต้องการแก้ไขข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                ' update customer
                Call selectPrice_level()
                Call Todate()
                strSQL = "UPDATE customer SET customer_id='" & Me.txtCustomerID.Text & "'," _
                    & "customer_tax='" & Me.txtCustomerTAX.Text & "'," _
                    & "customer_section='" & Me.txtCustomerSection.Text & "'," _
                    & "customer_name='" & Me.txtCustomerName.Text & "'," _
                    & "customer_address='" & Me.txtCustomerAddress.Text & "'," _
                    & "customer_zipcode='" & Me.txtCustomerZipcode.Text & "'," _
                    & "customer_tel='" & Me.txtCustomerTel.Text & "'," _
                    & "customer_note='" & Me.txtCustomerNote.Text & "'," _
                    & "price_level='" & num_level.ToString & "'," _
                    & "maturity='" & Maturity.ToString & "'," _
                    & "date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                    & "img=@img" _
                    & " WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                If Not PictureBox1.Image Is Nothing Then
                    Using newIMG = New Bitmap(PictureBox1.Image)
                        Using stream As New IO.MemoryStream
                            newIMG.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            cmd.Parameters.AddWithValue("@img", stream.GetBuffer())
                        End Using
                    End Using
                Else
                    cmd.Parameters.AddWithValue("@img", Nothing)
                End If
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update cash_pledge_sale
                strSQL = "UPDATE cash_pledge_sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update cash_sale
                strSQL = "UPDATE cash_sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update cash_sale_barcode
                strSQL = "UPDATE cash_sale_barcode SET customer_name='" & Me.txtCustomerName.Text & "',customer_tel='" & Me.txtCustomerTel.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update cash_sale_serial
                strSQL = "UPDATE cash_sale_serial SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update comfix
                strSQL = "UPDATE comfix SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update pledge_sale
                strSQL = "UPDATE pledge_sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update returnproduct
                strSQL = "UPDATE returnproduct SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update returnproduct_serial
                strSQL = "UPDATE returnproduct_serial SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update sale
                strSQL = "UPDATE sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update sale_barcode
                strSQL = "UPDATE sale_barcode SET customer_name='" & Me.txtCustomerName.Text & "',customer_tel='" & Me.txtCustomerTel.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update sale_id
                strSQL = "UPDATE sale_id SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update sale_serial
                strSQL = "UPDATE sale_serial SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                ' update taxinvoice
                strSQL = "UPDATE taxinvoice SET customer_name='" & Me.txtCustomerName.Text & "',customer_address='" & Me.txtCustomerAddress.Text & "',customer_tel='" & Me.txtCustomerTel.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            MessageBox.Show(Me, "แก้ไขข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgCustomerSearch.ClearSelection()
        End If
        Call GetAllData(3)
            Call startfrm()
    End Sub

    Private Sub DeleteData()
        If Me.txtCustomerID.Text = "0" Then
            Mainfrm.lblMainStatus.Text = "ไม่สามารถลบได้"
            MessageBox.Show(Me, "ค่าปริยาย ไม่สามารถลบได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show(Me, "ต้องการลบข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then

            Else
                Try
                    strSQL = "DELETE FROM customer WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dim delCom As Integer
                    delCom = cmd.ExecuteNonQuery()
                    If delCom = 1 Then
                        MainFrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
                    Else
                        MainFrm.lblMainStatus.Text = "ลบข้อมูลไม่ได้"
                    End If

                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Call GetAllData()
                Call startfrm()
            End If
        End If
    End Sub

    Private Sub getDataByRow()
        Try
            If Me.dgCustomerSearch.Rows.Count <> 0 Then
                Me.NewToolStripButton.Enabled = True
                Me.EditToolStripButton.Enabled = True
                Me.DeleteToolStripButton.Enabled = True
                Me.BackToolStripButton.Enabled = True
                Me.NextToolStripButton.Enabled = True

                Try
                    strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name," _
                        & "customer_address,customer_zipcode,customer_tel,customer_note,price_level,maturity,img " _
                        & "FROM customer WHERE customer_id='" & Me.dgCustomerSearch.CurrentRow.Cells(1).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtCustomerID.Text = Dr.GetString("customer_id")
                        Me.txtCustomerTAX.Text = Dr.GetString("customer_tax")
                        Me.txtCustomerSection.Text = Dr.GetString("customer_section")
                        Me.txtCustomerName.Text = Dr.GetString("customer_name")
                        Me.txtCustomerAddress.Text = Dr.GetString("customer_address")
                        Me.txtCustomerZipcode.Text = Dr.GetString("customer_zipcode")
                        Me.txtCustomerTel.Text = Dr.GetString("customer_tel")
                        Me.txtCustomerNote.Text = Dr.GetString("customer_note")
                        Dim num As String = Dr.GetString("price_level")
                        If num = "1" Then
                            Me.cbbCustomerPrice_leval.Text = "ราคาปกติ"
                        ElseIf num = "2" Then
                            Me.cbbCustomerPrice_leval.Text = "ราคาขายส่ง"
                        ElseIf num = "3" Then
                            Me.cbbCustomerPrice_leval.Text = "ราคาช่าง"
                        ElseIf num = "4" Then
                            Me.cbbCustomerPrice_leval.Text = "ราคาลูกค้าประจำ"
                        ElseIf num = "5" Then
                            Me.cbbCustomerPrice_leval.Text = "ราคาสมาชิก"
                        ElseIf num = "-" Then
                            Me.cbbCustomerPrice_leval.Text = "ราคาปกติ"
                        End If
                        Dim MT As String = Dr.GetString("maturity")
                        If MT = "5" Then
                            Me.cbbCustomerCadit.Text = "5 วัน"
                        ElseIf MT = "15" Then
                            Me.cbbCustomerCadit.Text = "15 วัน"
                        ElseIf MT = "30" Then
                            Me.cbbCustomerCadit.Text = "1 เดือน"
                        ElseIf MT = "60" Then
                            Me.cbbCustomerCadit.Text = "2 เดือน"
                        ElseIf MT = "90" Then
                            Me.cbbCustomerCadit.Text = "3 เดือน"
                        ElseIf MT = "120" Then
                            Me.cbbCustomerCadit.Text = "4 เดือน"
                        ElseIf MT = "150" Then
                            Me.cbbCustomerCadit.Text = "5 เดือน"
                        ElseIf MT = "180" Then
                            Me.cbbCustomerCadit.Text = "6 เดือน"
                        ElseIf MT = "210" Then
                            Me.cbbCustomerCadit.Text = "7 เดือน"
                        ElseIf MT = "240" Then
                            Me.cbbCustomerCadit.Text = "8 เดือน"
                        ElseIf MT = "270" Then
                            Me.cbbCustomerCadit.Text = "9 เดือน"
                        ElseIf MT = "300" Then
                            Me.cbbCustomerCadit.Text = "10 เดือน"
                        ElseIf MT = "330" Then
                            Me.cbbCustomerCadit.Text = "11 เดือน"
                        ElseIf MT = "360" Then
                            Me.cbbCustomerCadit.Text = "1 ปี"
                        ElseIf MT = "720" Then
                            Me.cbbCustomerCadit.Text = "2 ปี"
                        ElseIf MT = "1080" Then
                            Me.cbbCustomerCadit.Text = "3 ปี"
                        ElseIf MT = "-" Or MT = "" Then
                            Me.cbbCustomerCadit.Text = "15 วัน"
                        End If
                        Try
                            Me.PictureBox1.Image = Byte2Image(Dr.Item("img"))
                        Catch ex As Exception
                            Me.PictureBox1.Image = Nothing
                        End Try
                    Else
                        MessageBox.Show(Me, "ไม่พบข้อมูลนี้ในฐานข้อมูล", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Dim num_level As String
    Private Sub selectPrice_level()
        If Me.cbbCustomerPrice_leval.Text = "ราคาปกติ" Then
            num_level = "1"
        ElseIf Me.cbbCustomerPrice_leval.Text = "ราคาขายส่ง" Then
            num_level = "2"
        ElseIf Me.cbbCustomerPrice_leval.Text = "ราคาช่าง" Then
            num_level = "3"
        ElseIf Me.cbbCustomerPrice_leval.Text = "ราคาลูกค้าประจำ" Then
            num_level = "4"
        ElseIf Me.cbbCustomerPrice_leval.Text = "ราคาสมาชิก" Then
            num_level = "5"
        ElseIf Me.cbbCustomerPrice_leval.Text = "" Then
            num_level = "1"
        End If
    End Sub

    Dim Maturity As Integer

    Private Sub Todate()
        If Me.cbbCustomerCadit.Text = "5 วัน" Then
            Maturity = 5
        ElseIf Me.cbbCustomerCadit.Text = "15 วัน" Then
            Maturity = 15
        ElseIf Me.cbbCustomerCadit.Text = "1 เดือน" Then
            Maturity = 30
        ElseIf Me.cbbCustomerCadit.Text = "2 เดือน" Then
            Maturity = 60
        ElseIf Me.cbbCustomerCadit.Text = "3 เดือน" Then
            Maturity = 90
        ElseIf Me.cbbCustomerCadit.Text = "4 เดือน" Then
            Maturity = 120
        ElseIf Me.cbbCustomerCadit.Text = "5 เดือน" Then
            Maturity = 150
        ElseIf Me.cbbCustomerCadit.Text = "6 เดือน" Then
            Maturity = 180
        ElseIf Me.cbbCustomerCadit.Text = "7 เดือน" Then
            Maturity = 210
        ElseIf Me.cbbCustomerCadit.Text = "8 เดือน" Then
            Maturity = 240
        ElseIf Me.cbbCustomerCadit.Text = "9 เดือน" Then
            Maturity = 270
        ElseIf Me.cbbCustomerCadit.Text = "10 เดือน" Then
            Maturity = 300
        ElseIf Me.cbbCustomerCadit.Text = "11 เดือน" Then
            Maturity = 330
        ElseIf Me.cbbCustomerCadit.Text = "1 ปี" Then
            Maturity = 360
        ElseIf Me.cbbCustomerCadit.Text = "2 ปี" Then
            Maturity = 720
        ElseIf Me.cbbCustomerCadit.Text = "3 ปี" Then
            Maturity = 1080
        ElseIf Me.cbbCustomerCadit.Text = "" Then
            Maturity = 15
        End If
    End Sub

    Dim SelectSave As Integer = Nothing

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        SelectSave = 1000
        Call ClearTextBoxes(Me)
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False

        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        Me.txtCustomerTAX.Text = "000000000000"
        Me.txtCustomerSection.Text = "-"
        Me.txtCustomerZipcode.Text = ""
        Me.txtCustomerNote.Text = "-"
        Me.txtCustomerName.Clear()
        Me.txtCustomerAddress.Clear()
        Me.txtCustomerZipcode.Clear()
        Me.txtCustomerTel.Clear()

        Me.dgCustomerSearch.Enabled = False
        Me.SearchToolStripTextBox.Enabled = False
        Me.SearchToolStripButton.Enabled = False
        Me.ShowAllStripButton.Enabled = False

        Me.cbAutoCusID.Enabled = True
        Me.txtCustomerTAX.Enabled = True
        Me.txtCustomerSection.Enabled = True
        Me.txtCustomerName.Enabled = True
        Me.txtCustomerAddress.Enabled = True
        Me.txtCustomerZipcode.Enabled = True
        Me.txtCustomerTel.Enabled = True
        Me.txtCustomerNote.Enabled = True
        Me.cbbCustomerPrice_leval.Enabled = True
        Me.cbbCustomerCadit.Enabled = True
        Me.btnPicture.Enabled = True
        Me.PictureBox1.Image = Nothing

        Call AutoNumberNo()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If SelectSave = 1000 Then
            Call NewDataSave()
        ElseIf SelectSave = 2000 Then
            Call EditCustomer()
        End If
    End Sub

    Private Sub dgCustomerSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomerSearch.CellClick
        Call getDataByRow()
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        If Me.txtCustomerID.Text = "0" Then
            MessageBox.Show(Me, "ลูกค้าเงินสดไม่สามารถแก้ไขได้", "แจ้งเตือน", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
        Else
            SelectSave = 2000
            Me.dgCustomerSearch.Enabled = False
            Me.NewToolStripButton.Enabled = False
            Me.EditToolStripButton.Enabled = False
            Me.DeleteToolStripButton.Enabled = False
            Me.BackToolStripButton.Enabled = False
            Me.NextToolStripButton.Enabled = False
            Me.SaveToolStripButton.Enabled = True
            Me.CancelToolStripButton.Enabled = True

            Me.cbAutoCusID.Enabled = True
            Me.txtCustomerTAX.Enabled = True
            Me.txtCustomerSection.Enabled = True
            Me.txtCustomerName.Enabled = True
            Me.txtCustomerAddress.Enabled = True
            Me.txtCustomerZipcode.Enabled = True
            Me.txtCustomerTel.Enabled = True
            Me.txtCustomerNote.Enabled = True
            Me.cbbCustomerPrice_leval.Enabled = True
            Me.cbbCustomerCadit.Enabled = True
            Me.btnPicture.Enabled = True
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Call DeleteData()
    End Sub

    Private Sub cbbCustomerCadit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbCustomerCadit.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbCustomerPrice_leval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbCustomerPrice_leval.KeyPress
        e.Handled = True
    End Sub

    Dim oldData As Object
    Private Sub dgCustomerSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomerSearch.CellDoubleClick
        Me.dgCustomerSearch.ReadOnly = False
        oldData = Me.dgCustomerSearch.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgCustomerSearch_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomerSearch.CellEndEdit
        Me.dgCustomerSearch.CurrentRow.Cells(e.ColumnIndex).Value = oldData
        Me.dgCustomerSearch.ReadOnly = True
    End Sub

    Private Sub txtCustomerAddress_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerAddress.Enabled = True Then
            If Me.txtCustomerAddress.BackColor = Color.Salmon Then
                Me.txtCustomerAddress.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerID_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerID.Enabled = True Then
            If Me.txtCustomerID.BackColor = Color.Salmon Then
                Me.txtCustomerID.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerName_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerName.Enabled = True Then
            If Me.txtCustomerName.BackColor = Color.Salmon Then
                Me.txtCustomerName.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerNote_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerNote.Enabled = True Then
            If Me.txtCustomerNote.BackColor = Color.Salmon Then
                Me.txtCustomerNote.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerSection_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerSection.Enabled = True Then
            If Me.txtCustomerSection.BackColor = Color.Salmon Then
                Me.txtCustomerSection.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerTAX_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerTAX.Enabled = True Then
            If Me.txtCustomerTAX.BackColor = Color.Salmon Then
                Me.txtCustomerTAX.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerTel_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerTel.Enabled = True Then
            If Me.txtCustomerTel.BackColor = Color.Salmon Then
                Me.txtCustomerTel.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtCustomerZipcode_Click(sender As Object, e As EventArgs)
        If Me.txtCustomerZipcode.Enabled = True Then
            If Me.txtCustomerZipcode.BackColor = Color.Salmon Then
                Me.txtCustomerZipcode.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub btnPicture_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
        CameraCaptureCustomerFrm.ShowDialog(Me)
    End Sub

    Private Sub cbAutoCusID_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoCusID.CheckedChanged
        If Me.cbAutoCusID.Checked = True Then
            Me.txtCustomerID.Enabled = False
            If aucusid = Nothing Then
                Call ALLAutonumber("ver_cusid", aucusid)
                Me.txtCustomerID.Text = aucusid
            Else
                Me.txtCustomerID.Text = aucusid
            End If
        ElseIf Me.cbAutoCusID.Checked = False Then
            Me.txtCustomerID.Enabled = True
            Me.txtCustomerID.Clear()
        End If
    End Sub

    Private Sub txtCustomerTel_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerTel.TextChanged
        Call CountNumber()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/customer")
        Catch ex As Exception

        End Try
    End Sub
End Class