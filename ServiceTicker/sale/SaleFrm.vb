Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class SaleFrm
    Private Sub SaleFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F9 Then
            Call keyf9()
        End If

        If e.KeyCode = Keys.F2 Then
            SelectCustomerFrm.ShowDialog(Me)
        End If

        If e.KeyCode = Keys.F10 Then
            Call ClickCash()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
            OnTopFrm()
        End If
    End Sub

    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView

    Private Sub search_record()
        dt = New DataTable
        Dim strKeyWord As String = Me.txtPWproSearch.Text
        strSQL = "SELECT bar_code,name_pro,price_buy,unit,count_num,update_date FROM product"
        If strKeyWord <> "" Then
            strSQL = strSQL & " WHERE bar_code LIKE '%" & strKeyWord & "%' OR name_pro LIKE '%" & strKeyWord & "%';"
        End If
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        Try
            dtAdapter.Fill(dt)
            Me.dgPWProsearch.DataSource = dt
            '******************************'
            Me.dgPWProsearch.Columns.Clear()
            With dgPWProsearch.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
            End With
            Dim ColumnTextBox As DataGridViewTextBoxColumn
            '0
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "update_date"
            ColumnTextBox.HeaderText = "update"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '1
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "bar_code"
            ColumnTextBox.HeaderText = "รหัสสินค้า"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '2
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "name_pro"
            ColumnTextBox.HeaderText = "ชื่อสินค้า"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 200
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '3
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "price_buy"
            ColumnTextBox.HeaderText = "ราคาปกติ"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 70
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '4
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "unit"
            ColumnTextBox.HeaderText = "หน่วย"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '5
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "count_num"
            ColumnTextBox.HeaderText = "คงเหลือ"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 50
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtPWproSearch.Clear()
    End Sub

    Private Sub search_recordfromcbbPWsection(ByVal psid)
        dt = New DataTable
        strSQL = "SELECT update_date,bar_code,name_pro,price_buy,unit,count_num FROM product " _
            & "WHERE type='" & psid & "';"
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        Try
            dtAdapter.Fill(dt)
            Me.dgPWProsearch.DataSource = dt
            '******************************'
            Me.dgPWProsearch.Columns.Clear()
            With dgPWProsearch.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
            End With
            Dim ColumnTextBox As DataGridViewTextBoxColumn
            '0
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "update_date"
            ColumnTextBox.HeaderText = "update"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '1
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "bar_code"
            ColumnTextBox.HeaderText = "รหัสสินค้า"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '2
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "name_pro"
            ColumnTextBox.HeaderText = "ชื่อสินค้า"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 200
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '3
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "price_buy"
            ColumnTextBox.HeaderText = "ราคา"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '4
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "unit"
            ColumnTextBox.HeaderText = "หน่วย"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 100
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
            '5
            ColumnTextBox = New DataGridViewTextBoxColumn()
            ColumnTextBox.DataPropertyName = "count_num"
            ColumnTextBox.HeaderText = "เหลือ"
            ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ColumnTextBox.Width = 50
            Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getdatacombobox_prosection()
            Me.cbbPWgetProSection.DataSource = Nothing
            Try
                cmd = New MySqlCommand("SELECT prosection_id,prosection_name FROM product_section ORDER BY prosection_name;", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    dt = New DataTable
                    Me.cbbPWgetProSection.DisplayMember = "Name"
                    Me.cbbPWgetProSection.ValueMember = "ID"

                    dt.Columns.Add("Name", GetType(String))
                    dt.Columns.Add("ID", GetType(String))
                    While Dr.Read
                        dt.Rows.Add(Dr.Item("prosection_name"), Dr.Item("prosection_id"))
                    End While
                    Me.cbbPWgetProSection.DataSource = dt
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
    End Sub

    Private Sub keyf9()
        Try
            dt = New DataTable
            dtAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT customer_id,customer_name,customer_address,customer_tel" _
                                                         & " FROM customer WHERE customer_id='0';", ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Me.txtScusID.Text = dt(0)("customer_id")
            Me.txtScusName.Text = dt(0)("customer_name")
            Me.txtSaddress.Text = dt(0)("customer_address")
            Me.txtScusTel.Text = dt(0)("customer_tel")
            Me.rbSbuy.Checked = True
            dt.Dispose()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub


    Private Sub SaleFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgPWproMeNoSN.Rows.Count <> 0 Or Me.dgPWproMEwSN.Rows.Count <> 0 Then
            If MessageBox.Show("มีข้อมูลอยู่ในตารางสินค้า" & vbNewLine & "ต้องการจะปิดหน้าต่างนี้ OK = ใช่ หรือ Cancel = ไม่", "ยืนยัน", _
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                'For r As Integer = 0 To Me.dgPWproMEwSN.Rows.Count - 1
                '    Try
                '        cmd = New MySqlCommand("UPDATE product_serial SET stop='0' WHERE serial_pro='" & _
                '                               Me.dgPWproMEwSN.Rows(r).Cells(0).Value & "'", ConnectionDB)
                '        Call open_connection()
                '        cmd.ExecuteNonQuery()
                '    Catch ex As Exception
                '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                '    End Try
                'Next
                e.Cancel = False
                Me.Dispose(True)
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = False
            Me.Dispose()
            OnTopFrm()
        End If
    End Sub

    Private Sub SaleFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SelectCustomerFrm.ShowDialog(Me)
    End Sub

    Private Sub SaleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.dgPWproMeNoSN.Columns(0).ReadOnly = True
        Me.dgPWproMeNoSN.Columns(1).ReadOnly = True
        Me.dgPWproMeNoSN.Columns(2).ReadOnly = True
        Me.dgPWproMeNoSN.Columns(3).ReadOnly = False
        Me.dgPWproMeNoSN.Columns(4).ReadOnly = False
        Me.dgPWproMeNoSN.Columns(5).ReadOnly = True
        Me.dgPWproMeNoSN.Columns(6).ReadOnly = True
        Call sumStopSale()
        Me.Timer1.Start()
    End Sub

    Private Sub txtPWprobarcodeANDsn_GotFocus(sender As Object, e As EventArgs) Handles txtPWprobarcodeANDsn.GotFocus
        If Me.txtPWprobarcodeANDsn.ForeColor = SystemColors.ScrollBar Then
            Me.txtPWprobarcodeANDsn.ForeColor = SystemColors.WindowText
            Me.txtPWprobarcodeANDsn.Clear()
        End If
    End Sub

    Private Sub txtPWprobarcodeANDsn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWprobarcodeANDsn.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtPWprobarcodeANDsn.Text <> Nothing Then
                Call AddsnBCTodg()
                Me.txtPWprobarcodeANDsn.Clear()
            End If
        End If
    End Sub

    Private Sub txtPWprobarcodeANDsn_LostFocus(sender As Object, e As EventArgs) Handles txtPWprobarcodeANDsn.LostFocus
        If Me.txtPWprobarcodeANDsn.Text = Nothing Then
            Me.txtPWprobarcodeANDsn.ForeColor = SystemColors.ScrollBar
            Me.txtPWprobarcodeANDsn.Text = "ป้อน SN/BarCode"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectCustomerFrm.ShowDialog(Me)
    End Sub

    Friend totalxS, totalyS, totalzS As Decimal


    Private Sub sumDatagridview()
        'บวก datagrid
        For x = 0 To dgPWproMeNoSN.RowCount - 1
            If IsDBNull(Me.dgPWproMeNoSN.CurrentRow.Cells(4).Value) _
                OrElse Me.dgPWproMeNoSN.CurrentRow.Cells(4).Value = Nothing _
                OrElse Me.dgPWproMeNoSN.CurrentRow.Cells(4).Value < 0 Then
                Me.dgPWproMeNoSN.CurrentRow.Cells(4).Value = 0.0
            End If
            Me.dgPWproMeNoSN.Rows(x).Cells(6).Value = CDec(Me.dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(Me.dgPWproMeNoSN.Rows(x).Cells(3).Value) _
                  - CDec(Me.dgPWproMeNoSN.Rows(x).Cells(4).Value)
            totalxS += CDec(dgPWproMeNoSN.Rows(x).Cells(6).Value)
            totalyS += CDec(dgPWproMeNoSN.Rows(x).Cells(3).Value)
            totalzS = Me.dgPWproMeNoSN.Rows.Count
        Next
        Me.lblPWgetTotalPrice.Text = totalxS.ToString("N2")
        Me.lblPWtotalXYZ.Text = "รายการ " & totalzS.ToString & " | ปริมาณ " & totalyS.ToString
        totalxS = Nothing
        totalyS = Nothing
        totalzS = Nothing
    End Sub

    Private Sub dgPWproMeNoSN_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPWproMeNoSN.CellEndEdit
        If Trim(Me.dgPWproMeNoSN.CurrentRow.Cells(4).Value) = Nothing Then
            Me.dgPWproMeNoSN.CurrentRow.Cells(4).Value = 0
        End If
        If Trim(Me.dgPWproMeNoSN.CurrentRow.Cells(3).Value) = Nothing Then
            Me.dgPWproMeNoSN.CurrentRow.Cells(3).Value = 1
        Else
            strSQL = "SELECT count_num FROM product WHERE bar_code='" & Me.dgPWproMeNoSN.CurrentRow.Cells(0).Value & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Dim cn As Integer = Dr.Item("count_num") - CInt(Me.dgPWproMeNoSN.CurrentRow.Cells(3).Value)
                If cn < 0 Then
                    MessageBox.Show(Me, "จำนวนสินค้าคงเหลือ ไม่พอกับจำนวนที่ขาย", "เบิกเกินจำนวน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.dgPWproMeNoSN.CurrentRow.Cells(3).Value = 1
                End If
            End If
        End If
        Call sumDatagridview()
    End Sub

    Private Sub dgPWproMeNoSN_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgPWproMeNoSN.EditingControlShowing
        If Me.dgPWproMeNoSN.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf KeyPress_decimal
        End If
        If Me.dgPWproMeNoSN.CurrentCell.ColumnIndex = 3 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf KeyPress_Integer
        End If
    End Sub

    Private Function checkBC(ByVal snbc As String) As Boolean
        Try
            cmd = New MySqlCommand("SELECT bar_code FROM product WHERE bar_code='" & snbc & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Function checkSN(ByVal snbc As String) As Boolean
        Try
            cmd = New MySqlCommand("SELECT serial_pro FROM product_serial WHERE serial_pro='" & snbc & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function checkSNstop(ByVal snbc As String) As Boolean
        Try
            cmd = New MySqlCommand("SELECT stop FROM product_serial WHERE serial_pro='" & snbc & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim sp As Integer
            sp = Dr.Item("stop")
            If sp = 0 Then
                Return True
            ElseIf sp = 1 Then
                Return False
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub updateStop(ByVal bc As String, ByVal count_num As String)
        'อัพเดท stop เพิ่อลดจำนวนสต็อก ป้องกันเครื่องอื่นตัดขายและใช้สำพักการขายด้วย
        Try
            cmd = New MySqlCommand("UPDATE product SET count_num=count_num - '" & count_num & "'," _
                                        & "stop=stop + '" & count_num & "' WHERE bar_code='" & bc & "'", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub AddsnBCTodg()
        If autonum = Nothing Then
            Call ALLAutonumber("ver_PartsWithdrawal", autonum)
            Me.txtPWsaleID.Text = autonum
        Else
            Me.txtPWsaleID.Text = autonum
        End If
        If checkBC(Me.txtPWprobarcodeANDsn.Text) = True Then
            Dim code_pro As String = String.Empty
            Dim bar_code As String = String.Empty
            Dim name_pro As String = String.Empty
            Dim typep As String = String.Empty
            Dim unit As String = String.Empty
            Dim varuntee As String = String.Empty
            Dim notepro As String = String.Empty
            Dim spec As String = String.Empty
            Dim price_buy As Decimal = 0
            Dim count_num As Integer = 0
            Dim check_stock As Integer = 0
            Try
                cmd = New MySqlCommand("SELECT * FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                code_pro = Dr.Item("code_pro")
                bar_code = Dr.Item("bar_code")
                name_pro = Dr.Item("name_pro")
                typep = Dr.Item("type")
                unit = Dr.Item("unit")
                varuntee = Dr.Item("varuntee")
                notepro = Dr.Item("notepro")
                'spec = Dr.Item("spec")
                count_num = Dr.Item("count_num")
                check_stock = Dr.Item("check_stock")
                'เช็คของหมด
                If count_num <= 0 Then
                    MessageBox.Show(Me, "สินค้าเหลือ " & count_num & " ชิ้น" & vbNewLine & "สินค้าในสต็อกหมด", "สินค้าหมด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                'หาจำนวนที่เหลือของสินค้า
                For NPro As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                    If Me.txtPWprobarcodeANDsn.Text = Me.dgPWproMeNoSN.Rows(NPro).Cells(0).Value Then
                        Dim ttAll As Integer = CInt(Me.dgPWproMeNoSN.Rows(NPro).Cells(3).Value) + 1
                        Dim CLA As Decimal = count_num - ttAll
                        If count_num < ttAll Then
                            MsgBox("สินค้าในสต็อกมี " & count_num & " ชิ้น" & vbNewLine & "เบิกไปแล้ว " & _
                                    Me.dgPWproMeNoSN.Rows(NPro).Cells(3).Value _
                                   & vbNewLine & "เบิกเกินจำนวนที่มีในสต็อก", MsgBoxStyle.Information, "เบิกเกินจำนวน")
                            Exit Sub
                        End If
                    End If
                Next

                If Me.rbSbuy.Checked = True Then
                    price_buy = Dr.Item("price_buy")
                ElseIf Me.rbSwholesale.Checked = True Then
                    price_buy = Dr.Item("price_wholesale")
                ElseIf Me.rbStechnician.Checked = True Then
                    price_buy = Dr.Item("price_technician")
                ElseIf Me.rbSloyal.Checked = True Then
                    price_buy = Dr.Item("price_loyal")
                ElseIf Me.rbSmembers.Checked = True Then
                    price_buy = Dr.Item("price_members")
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'add to dg
            Dim d As String = String.Empty
            Dim f As Integer = Nothing
            For f = 0 To dgPWproMeNoSN.RowCount - 1
                If Me.txtPWprobarcodeANDsn.Text = Me.dgPWproMeNoSN.Rows(f).Cells(0).Value Then
                    Me.dgPWproMeNoSN.Rows(f).Cells(3).Value = CInt(Me.dgPWproMeNoSN.Rows(f).Cells(3).Value) + 1
                    'อัพเดท stop เพิ่อลดจำนวนสต็อก ป้องกันเครื่องอื่นตัดขายและใช้สำพักการขายด้วย
                    'Call updateStop(bar_code)
                    d = "d"
                End If
            Next
            If d <> "d" Then
                Dim r As Integer = Me.dgPWproMeNoSN.Rows.Count
                Me.dgPWproMeNoSN.Rows.Add()
                Me.dgPWproMeNoSN.Rows(r).Cells(0).Value = bar_code
                Me.dgPWproMeNoSN.Rows(r).Cells(1).Value = name_pro
                Me.dgPWproMeNoSN.Rows(r).Cells(2).Value = price_buy
                Me.dgPWproMeNoSN.Rows(r).Cells(3).Value = 1
                Me.dgPWproMeNoSN.Rows(r).Cells(4).Value = 0
                Me.dgPWproMeNoSN.Rows(r).Cells(5).Value = unit
                'อัพเดท stop เพิ่อลดจำนวนสต็อก ป้องกันเครื่องอื่นตัดขายและใช้สำพักการขายด้วย
                'Call updateStop(bar_code)
            End If

            Call sumDatagridview()
            Me.dgPWproMeNoSN.ClearSelection()
        ElseIf checkSN(Me.txtPWprobarcodeANDsn.Text) = True Then
            If checkSNstop(Me.txtPWprobarcodeANDsn.Text) = True Then
                'ตรวจ sn ซ้ำ
                'ส่วน sn
                For i As Integer = 0 To dgPWproMEwSN.Rows.Count - 1
                    If Strings.Trim(Me.txtPWprobarcodeANDsn.Text) = Strings.Trim(Me.dgPWproMEwSN.Rows(i).Cells(0).Value) Then
                        MessageBox.Show("Serial Number นี้มีอยู่แล้ว", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.dgPWproMEwSN.Rows(i).Selected = True
                        Exit Sub
                    End If
                Next

                Dim code_pro As String = String.Empty
                Dim bar_code As String = String.Empty
                Dim name_pro As String = String.Empty
                Dim typep As String = String.Empty
                Dim unit As String = String.Empty
                Dim varuntee As String = String.Empty
                Dim notepro As String = String.Empty
                Dim spec As String = String.Empty
                Dim price_buy As Decimal = 0
                Dim count_num As Integer = 0
                Dim check_stock As Integer = 0
                Try
                    cmd = New MySqlCommand("SELECT * FROM " _
                                           & "product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE " _
                                           & "serial_pro='" & Me.txtPWprobarcodeANDsn.Text & "')", ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    code_pro = Dr.Item("code_pro")
                    bar_code = Dr.Item("bar_code")
                    name_pro = Dr.Item("name_pro")
                    typep = Dr.Item("type")
                    unit = Dr.Item("unit")
                    varuntee = Dr.Item("varuntee")
                    notepro = Dr.Item("notepro")
                    'spec = Dr.Item("spec")
                    count_num = Dr.Item("count_num")
                    check_stock = Dr.Item("check_stock")
                    'เช็คของหมด
                    If count_num <= 0 Then
                        MessageBox.Show(Me, "สินค้าเหลือ " & count_num & " ชิ้น" & vbNewLine & "สินค้าในสต็อกหมด", "สินค้าหมด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    'หาจำนวนที่เหลือของสินค้า
                    For NPro As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                        If Me.txtPWprobarcodeANDsn.Text = Me.dgPWproMeNoSN.Rows(NPro).Cells(0).Value Then
                            Dim ttAll As Integer = CInt(Me.dgPWproMeNoSN.Rows(NPro).Cells(3).Value) + 1
                            Dim CLA As Decimal = count_num - ttAll
                            If count_num < ttAll Then
                                MsgBox("สินค้าในสต็อกมี " & count_num & " ชิ้น" & vbNewLine & "เบิกไปแล้ว " & _
                                        Me.dgPWproMeNoSN.Rows(NPro).Cells(3).Value _
                                       & vbNewLine & "เบิกเกินจำนวนที่มีในสต็อก", MsgBoxStyle.Information, "เบิกเกินจำนวน")
                                Exit Sub
                            End If
                        End If
                    Next

                    If Me.rbSbuy.Checked = True Then
                        price_buy = Dr.Item("price_buy")
                    ElseIf Me.rbSwholesale.Checked = True Then
                        price_buy = Dr.Item("price_wholesale")
                    ElseIf Me.rbStechnician.Checked = True Then
                        price_buy = Dr.Item("price_technician")
                    ElseIf Me.rbSloyal.Checked = True Then
                        price_buy = Dr.Item("price_loyal")
                    ElseIf Me.rbSmembers.Checked = True Then
                        price_buy = Dr.Item("price_members")
                    End If
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                'add to dg SN
                Dim asn As Integer = Me.dgPWproMEwSN.Rows.Count
                Me.dgPWproMEwSN.Rows.Add()
                Me.dgPWproMEwSN.Rows(asn).Cells(0).Value = Strings.Trim(Me.txtPWprobarcodeANDsn.Text)
                Me.dgPWproMEwSN.Rows(asn).Cells(1).Value = name_pro

                'อัพเดท รายการ SN เป็น stop = 1 แปลว่า สินค้านี้จะถูกขายต่อไม่ได้จนกว่าจะถูกยกเลิกการขาย
                'Try
                '    cmd = New MySqlCommand("UPDATE product_serial SET stop='1' WHERE serial_pro='" & Me.txtPWprobarcodeANDsn.Text & "'", ConnectionDB)
                '    Call open_connection()
                '    cmd.ExecuteNonQuery()
                'Catch ex As Exception
                '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                'End Try
                'add to dg BC
                Dim d As String = String.Empty
                Dim f As Integer = Nothing
                For f = 0 To dgPWproMeNoSN.RowCount - 1
                    If bar_code = Me.dgPWproMeNoSN.Rows(f).Cells(0).Value Then
                        Me.dgPWproMeNoSN.Rows(f).Cells(3).Value = CInt(Me.dgPWproMeNoSN.Rows(f).Cells(3).Value) + 1
                        'Call updateStop(bar_code)
                        d = "d"
                    End If
                Next
                If d <> "d" Then
                    Dim r As Integer = Me.dgPWproMeNoSN.Rows.Count
                    Me.dgPWproMeNoSN.Rows.Add()
                    Me.dgPWproMeNoSN.Rows(r).Cells(0).Value = bar_code
                    Me.dgPWproMeNoSN.Rows(r).Cells(1).Value = name_pro
                    Me.dgPWproMeNoSN.Rows(r).Cells(2).Value = price_buy
                    Me.dgPWproMeNoSN.Rows(r).Cells(3).Value = 1
                    Me.dgPWproMeNoSN.Rows(r).Cells(4).Value = 0
                    Me.dgPWproMeNoSN.Rows(r).Cells(5).Value = unit
                    'Call updateStop(bar_code)
                End If
                Call sumDatagridview()
                Me.dgPWproMEwSN.ClearSelection()
                Me.dgPWproMeNoSN.ClearSelection()
            ElseIf checkSNstop(Me.txtPWprobarcodeANDsn.Text) = False Then
                MessageBox.Show(Me, "สินค้านี้อยู่ในระหว่างพักการขาย ไม่สามารถขายได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            MessageBox.Show(Me, "ไม่พบ SN หรือบาร์โค๊ต " & Me.txtPWprobarcodeANDsn.Text, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub btnPWokTodg_Click(sender As Object, e As EventArgs) Handles btnPWokTodg.Click
        If Me.txtPWprobarcodeANDsn.Text <> Nothing Or Me.txtPWprobarcodeANDsn.Text <> "ป้อน SN/BarCode" Then
            Call AddsnBCTodg()
            Me.txtPWprobarcodeANDsn.Clear()
        End If
    End Sub

    Private Sub dgPWproMeNoSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPWproMeNoSN.CellMouseClick
        Try
            If Me.dgPWproMeNoSN.Rows.Count <> 0 Then
                If e.Button = MouseButtons.Right Then
                    Me.dgPWproMeNoSN.Rows(e.RowIndex).Selected = True
                    Me.dgPWproMeNoSN.CurrentCell = Me.dgPWproMeNoSN.Rows(e.RowIndex).Cells(1)
                    Me.mnuDGnoSN.Show(dgPWproMeNoSN, e.Location)
                    Me.mnuDGnoSN.Show(Cursor.Position)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPWproMEwSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPWproMEwSN.CellMouseClick
        Try
            If Me.dgPWproMEwSN.Rows.Count <> 0 Then
                If e.Button = MouseButtons.Right Then
                    Me.dgPWproMEwSN.Rows(e.RowIndex).Selected = True
                    Me.dgPWproMEwSN.CurrentCell = Me.dgPWproMEwSN.Rows(e.RowIndex).Cells(0)
                    Me.mnuDGSN.Show(dgPWproMEwSN, e.Location)
                    Me.mnuDGSN.Show(Cursor.Position)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteSNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSNToolStripMenuItem.Click
        Try
            For o As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                If Me.dgPWproMEwSN.CurrentRow.Cells(1).Value = Me.dgPWproMeNoSN.Rows(o).Cells(1).Value Then
                    If Me.dgPWproMeNoSN.Rows(o).Cells(3).Value = 1 Then
                        Me.dgPWproMeNoSN.Rows.Remove(Me.dgPWproMeNoSN.Rows(o))
                    ElseIf Me.dgPWproMeNoSN.Rows(o).Cells(3).Value > 1 Then
                        Me.dgPWproMeNoSN.Rows(o).Cells(3).Value = CDec(Me.dgPWproMeNoSN.Rows(o).Cells(3).Value) - 1
                    End If
                    Dim a As Integer = Me.dgPWproMEwSN.SelectedRows.Count - 1
                    Me.dgPWproMEwSN.Rows.Remove(Me.dgPWproMEwSN.SelectedRows(a))
                End If
            Next


            Call sumDatagridview()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub DeleteDGnoSNToolStripMenu_Click(sender As Object, e As EventArgs) Handles DeleteDGnoSNToolStripMenu.Click
        For checkSN As Integer = 0 To Me.dgPWproMEwSN.Rows.Count - 1
            If Me.dgPWproMeNoSN.CurrentRow.Cells(1).Value = Me.dgPWproMEwSN.Rows(checkSN).Cells(1).Value Then
                MessageBox.Show(Me, "รายการสินค้านี้มีสินค้าแบบ SN กรุณาลบรายการสินค้าที่เป็น SN ออกก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        For tto As Integer = Me.dgPWproMeNoSN.SelectedRows.Count - 1 To 0 Step -1
            Me.dgPWproMeNoSN.Rows.Remove(Me.dgPWproMeNoSN.Rows(tto))
        Next
        Call sumDatagridview()
    End Sub

    'พักบิลขาย SN
    Dim p_buy As String
    Private Sub StopBillSN()
        If Me.rbSbuy.Checked = True Then
            p_buy = "1"
        ElseIf Me.rbSwholesale.Checked = True Then
            p_buy = "2"
        ElseIf Me.rbStechnician.Checked = True Then
            p_buy = "3"
        ElseIf Me.rbSloyal.Checked = True Then
            p_buy = "4"
        ElseIf Me.rbSmembers.Checked = True Then
            p_buy = "5"
        End If
        For rsn As Integer = 0 To Me.dgPWproMEwSN.Rows.Count - 1
            Try
                strSQL = "INSERT INTO stop_sale_sn(sale_id,customer_id,customer_name," _
                    & "customer_address,customer_tel,price_leval,serial_pro,name_pro,datetime_save,employee,active,datetime_edit)" _
                    & "VALUES(@sale_id,@customer_id,@customer_name," _
                    & "@customer_address,@customer_tel,@price_leval,@serial_pro,@name_pro,@datetime_save,@employee,@active,@datetime_edit)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@sale_id", Me.txtPWsaleID.Text)
                    .Parameters.AddWithValue("@customer_id", Me.txtScusID.Text)
                    .Parameters.AddWithValue("@customer_name", Me.txtScusName.Text)
                    .Parameters.AddWithValue("@customer_address", Me.txtSaddress.Text)
                    .Parameters.AddWithValue("@customer_tel", Me.txtScusTel.Text)
                    .Parameters.AddWithValue("@price_leval", p_buy)
                    .Parameters.AddWithValue("@serial_pro", Me.dgPWproMEwSN.Rows(rsn).Cells(0).Value)
                    .Parameters.AddWithValue("@name_pro", Me.dgPWproMEwSN.Rows(rsn).Cells(1).Value)
                    .Parameters.AddWithValue("@datetime_save", GetLocalServerDateTime)
                    .Parameters.AddWithValue("@employee", Me.lblEmployee.Text)
                    .Parameters.AddWithValue("@active", "1")
                    .Parameters.AddWithValue("@datetime_edit", "-")
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try


            'อัพเดท รายการ SN เป็น stop = 1 แปลว่า สินค้านี้จะถูกขายต่อไม่ได้จนกว่าจะถูกยกเลิกการขาย
            Try
                cmd = New MySqlCommand("UPDATE product_serial SET stop='1' WHERE serial_pro='" & Me.dgPWproMEwSN.Rows(rsn).Cells(0).Value & "'", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    'พักบิลขาย BC
    Private Sub StopBillBC()
        If Me.rbSbuy.Checked = True Then
            p_buy = "1"
        ElseIf Me.rbSwholesale.Checked = True Then
            p_buy = "2"
        ElseIf Me.rbStechnician.Checked = True Then
            p_buy = "3"
        ElseIf Me.rbSloyal.Checked = True Then
            p_buy = "4"
        ElseIf Me.rbSmembers.Checked = True Then
            p_buy = "5"
        End If
        For rbc As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
            Try
                strSQL = "INSERT INTO stop_sale_bc(sale_id,customer_id,customer_name,customer_address," _
                    & "customer_tel,price_leval,bar_code,name_pro,price_buy,count_num,discount,unit,datetime_save,employee,active,datetime_edit)" _
                    & "VALUES(@sale_id,@customer_id,@customer_name,@customer_address," _
                    & "@customer_tel,@price_leval,@bar_code,@name_pro,@price_buy,@count_num,@discount,@unit,@datetime_save,@employee,@active,@datetime_edit)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@sale_id", Me.txtPWsaleID.Text)
                    .Parameters.AddWithValue("@customer_id", Me.txtScusID.Text)
                    .Parameters.AddWithValue("@customer_name", Me.txtScusName.Text)
                    .Parameters.AddWithValue("@customer_address", Me.txtSaddress.Text)
                    .Parameters.AddWithValue("@customer_tel", Me.txtScusTel.Text)
                    .Parameters.AddWithValue("@price_leval", p_buy)
                    .Parameters.AddWithValue("@bar_code", Me.dgPWproMeNoSN.Rows(rbc).Cells(0).Value)
                    .Parameters.AddWithValue("@name_pro", Me.dgPWproMeNoSN.Rows(rbc).Cells(1).Value)
                    .Parameters.AddWithValue("@price_buy", Me.dgPWproMeNoSN.Rows(rbc).Cells(2).Value)
                    .Parameters.AddWithValue("@count_num", Me.dgPWproMeNoSN.Rows(rbc).Cells(3).Value)
                    .Parameters.AddWithValue("@discount", Me.dgPWproMeNoSN.Rows(rbc).Cells(4).Value)
                    .Parameters.AddWithValue("@unit", Me.dgPWproMeNoSN.Rows(rbc).Cells(5).Value)
                    .Parameters.AddWithValue("@datetime_save", GetLocalServerDateTime)
                    .Parameters.AddWithValue("@employee", Me.lblEmployee.Text)
                    .Parameters.AddWithValue("@active", "1")
                    .Parameters.AddWithValue("@datetime_edit", "-")
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
                Call updateStop(Me.dgPWproMeNoSN.Rows(rbc).Cells(0).Value, Me.dgPWproMeNoSN.Rows(rbc).Cells(3).Value)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

        Next
    End Sub

    Private Sub saveSale_id_stop()
        'Try
        '    'sale_id  ทุกกรณี
        '    strSQL = "INSERT INTO sale_id(sale_id,fix_id,customer_id,customer_name,date_in,datetime_save) " _
        '                   & " VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@date_in,@datetime_save)"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    With cmd
        '        .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
        '        .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
        '        .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
        '        .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
        '        .Parameters.Add(New MySqlParameter("@date_in", Me.txtPWdateNow.Text))
        '        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
        '        Call open_connection()
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try
    End Sub

    Private Sub sumStopSale()
        Me.dgSsaleStop.Rows.Clear()
        strSQL = "SELECT DISTINCT sale_id FROM stop_sale_bc WHERE active='1';"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgSsaleStop
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("sale_id")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        For rr As Integer = 0 To Me.dgSsaleStop.Rows.Count - 1
            strSQL = "SELECT SUM(count_num) AS cn FROM stop_sale_bc WHERE sale_id='" & Me.dgSsaleStop.Rows(rr).Cells(0).Value & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgSsaleStop
                    .Rows(rr).Cells(1).Value = Dr.Item("cn")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            strSQL = "SELECT datetime_save,employee FROM stop_sale_bc WHERE sale_id='" & Me.dgSsaleStop.Rows(rr).Cells(0).Value & "' LIMIT 1;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgSsaleStop
                    .Rows(rr).Cells(2).Value = Dr.Item("datetime_save")
                    .Rows(rr).Cells(3).Value = Dr.Item("employee")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

        Next
        Me.lblSStopNum.Text = Me.dgSsaleStop.Rows.Count

    End Sub

    Friend Sub clearform()
        Me.txtScusID.Clear()
        Me.txtSaddress.Clear()
        Me.txtScusName.Clear()
        Me.txtScusTel.Clear()
        Me.txtPWsaleID.Clear()
        Me.rbSbuy.Checked = True
        Me.dgPWproMeNoSN.Rows.Clear()
        Me.dgPWproMEwSN.Rows.Clear()
        Call sumStopSale()
        Call sumDatagridview()

    End Sub

    Private Sub btuSstopSale_Click(sender As Object, e As EventArgs) Handles btuSstopSale.Click
        If Me.dgPWproMeNoSN.Rows.Count <> 0 Or Me.dgPWproMEwSN.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการพักการขาย", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Call saveSale_id_stop()
                If Me.dgPWproMeNoSN.Rows.Count <> 0 Then
                    Call StopBillBC()
                End If
                If Me.dgPWproMEwSN.Rows.Count <> 0 Then
                    Call StopBillSN()
                End If
                Me.txtScusID.Clear()
                Me.txtSaddress.Clear()
                Me.txtScusName.Clear()
                Me.txtScusTel.Clear()
                Me.rbSbuy.Checked = True
                Me.dgPWproMeNoSN.Rows.Clear()
                Me.dgPWproMEwSN.Rows.Clear()
                Call sumStopSale()
                Call sumDatagridview()
                Me.txtPWsaleID.Clear()
                autonum = Nothing
                MessageBox.Show(Me, "พักการขายแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgSsaleStop_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSsaleStop.CellMouseClick
        Try
            If Me.dgSsaleStop.Rows.Count <> 0 Then
                If e.Button = MouseButtons.Right Then
                    Me.dgSsaleStop.Rows(e.RowIndex).Selected = True
                    Me.dgSsaleStop.CurrentCell = Me.dgSsaleStop.Rows(e.RowIndex).Cells(1)
                    Me.munStopSale.Show(dgSsaleStop, e.Location)
                    Me.munStopSale.Show(Cursor.Position)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim returnSale As Boolean = Nothing
    Private Sub ReturnSaleToolStripMenu_Click(sender As Object, e As EventArgs) Handles ReturnSaleToolStripMenu.Click
        If MessageBox.Show(Me, "ต้องการขายสินค้าต่อในรายการพักสินค้านี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            returnSale = True
            Me.txtPWsaleID.Clear()
            Try
                dt = New DataTable
                strSQL = "SELECT sale_id,customer_id,customer_name,customer_address,customer_tel," _
                  & "price_leval FROM " _
                  & "stop_sale_bc WHERE sale_id='" & Me.dgSsaleStop.CurrentRow.Cells(0).Value & "';"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtPWsaleID.Text = dt(0)("sale_id")
                Me.txtScusID.Text = dt(0)("customer_id")
                Me.txtScusName.Text = dt(0)("customer_name")
                Me.txtSaddress.Text = dt(0)("customer_address")
                Me.txtScusTel.Text = dt(0)("customer_tel")
                Dim rbc As String = dt(0)("price_leval")
                If rbc = "1" Then
                    Me.rbSbuy.Checked = True
                ElseIf rbc = "2" Then
                    Me.rbSwholesale.Checked = True
                ElseIf rbc = "3" Then
                    Me.rbStechnician.Checked = True
                ElseIf rbc = "4" Then
                    Me.rbSloyal.Checked = True
                ElseIf rbc = "5" Then
                    Me.rbSmembers.Checked = True
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'ดึงข้อมูลจาก stop_sale_bc
            Me.dgPWproMeNoSN.Rows.Clear()
            strSQL = "SELECT bar_code,name_pro,price_buy,count_num,discount,unit FROM " _
                & "stop_sale_bc WHERE sale_id='" & Me.dgSsaleStop.CurrentRow.Cells(0).Value & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    Dim r As Integer
                    With Me.dgPWproMeNoSN
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("price_buy")
                        .Rows(r).Cells(3).Value = Dr.Item("count_num")
                        .Rows(r).Cells(4).Value = Dr.Item("discount")
                        .Rows(r).Cells(5).Value = Dr.Item("unit")
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'ดึงข้อมูลจาก stop_sale_sn
            Me.dgPWproMEwSN.Rows.Clear()
            strSQL = "SELECT serial_pro,name_pro FROM " _
               & "stop_sale_sn WHERE sale_id='" & Me.dgSsaleStop.CurrentRow.Cells(0).Value & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    Dim r As Integer
                    With Me.dgPWproMEwSN
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            For ur As Integer = 0 To Me.dgPWproMEwSN.Rows.Count - 1
                Try
                    cmd = New MySqlCommand("UPDATE product_serial SET stop='0' WHERE serial_pro='" & _
                                                 Me.dgPWproMEwSN.Rows(ur).Cells(0).Value & "';", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            For urbc As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                Try
                    cmd = New MySqlCommand("UPDATE product SET count_num=count_num + '" & Me.dgPWproMeNoSN.Rows(urbc).Cells(3).Value & "'," _
                                                & "stop=stop - '" & Me.dgPWproMeNoSN.Rows(urbc).Cells(3).Value & "' " _
                                                & "WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(urbc).Cells(0).Value & "';", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next

            Try
                cmd = New MySqlCommand("DELETE FROM stop_sale_bc WHERE sale_id='" & Me.dgSsaleStop.CurrentRow.Cells(0).Value & "';", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try


            Try
                cmd = New MySqlCommand("DELETE FROM stop_sale_sn WHERE sale_id='" & Me.dgSsaleStop.CurrentRow.Cells(0).Value & "';", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Call sumDatagridview()
            Call sumStopSale()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call sumStopSale()
    End Sub
    Friend autonum As String
    Private Sub dgPWproMeNoSN_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgPWproMeNoSN.RowStateChanged
        If Me.dgPWproMeNoSN.Rows.Count <> 0 Then
           
            Me.btnPWsave.Enabled = True
            Me.btuSstopSale.Enabled = True
        Else
            Me.btnPWsave.Enabled = False
            Me.btuSstopSale.Enabled = False
        End If


    End Sub

    Private Sub ViewProDuctToolStripMenu_Click(sender As Object, e As EventArgs) Handles ViewProDuctToolStripMenu.Click
        Call ViewProductSaleStopFrm.GetStopSale(Me.dgSsaleStop.CurrentRow.Cells(0).Value)
        ViewProductSaleStopFrm.ShowDialog(Me)
    End Sub

    Private Sub btnPWdel_Click(sender As Object, e As EventArgs) Handles btnPWdel.Click
        If MessageBox.Show(Me, "ต้องการลบรายการทั้งหมด", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Call clearform()
        End If
    End Sub
    Friend totalPB, totalDC, totalPAL As Decimal
    Private Sub ClickCash()

        totalPB = 0
        totalDC = 0
        totalPAL = 0
        Call sumDatagridview()
        If Me.txtScusID.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ชื่อลูกค้าก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SelectCustomerFrm.ShowDialog(Me)
            Exit Sub
        End If
        For i As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
            totalPB += CDec(Me.dgPWproMeNoSN.Rows(i).Cells(2).Value) * CDec(Me.dgPWproMeNoSN.Rows(i).Cells(3).Value)
            totalDC += CDec(Me.dgPWproMeNoSN.Rows(i).Cells(4).Value)
            totalPAL += CDec(Me.dgPWproMeNoSN.Rows(i).Cells(6).Value)
        Next
        CashSaleFrm.txtCashCash.Text = totalPB.ToString("N2")
        CashSaleFrm.txtCSdiscount.Text = totalDC.ToString("N2")
        CashSaleFrm.txtCStotalmoney.Text = totalPAL.ToString("N2")
        Call CashSaleFrm.getData(Me.txtScusID.Text)
        CashSaleFrm.txtCSsale_id.Text = Me.txtPWsaleID.Text
        CashSaleFrm.ShowDialog(Me)
    End Sub
    Private Sub btnPWsave_Click(sender As Object, e As EventArgs) Handles btnPWsave.Click
        Call ClickCash()
    End Sub
    '------------------------------------------------------------------------------------
    Friend Sub saveSale_id()
        'Try
        '    'sale_id  ทุกกรณี
        'strSQL = "INSERT INTO sale_id(sale_id,fix_id,customer_id,customer_name,date_in,datetime_save) " _
        '               & " VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@date_in,@datetime_save)"
        'cmd = New MySqlCommand(strSQL, ConnectionDB)
        'With cmd
        '    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
        '    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
        '    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
        '    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
        '    .Parameters.Add(New MySqlParameter("@date_in", Me.txtPWdateNow.Text))
        '    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
        '    Call open_connection()
        '    .ExecuteNonQuery()
        'End With
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try
    End Sub

    Friend Sub saveCash_id()
        'Try
        '    'sale_id  ทุกกรณี
        '    strSQL = "INSERT INTO cash_id(cash_id,datetime_save) " _
        '                   & " VALUES(@cash_id,@datetime_save)"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    With cmd
        '        .Parameters.Add(New MySqlParameter("@cash_id", CashSaleFrm.txtCScashID.Text))
        '        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
        '        Call open_connection()
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try
    End Sub

    Friend Sub saveCashDGwsnTodatabase()
        'บันทึกไป cash_sale_serial จ่ายเงิน
        'SN
        For rALL As Integer = 0 To dgPWproMEwSN.RowCount - 1
            Dim name_pro As String = String.Empty
            Dim bar_code As String = String.Empty
            Dim code_pro As String = String.Empty
            Try
                strSQL = "SELECT name_pro,bar_code,code_pro FROM product " _
                    & "WHERE code_pro IN (SELECT code_pro FROM product_serial " _
                    & "WHERE serial_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value & "');"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    name_pro = .Item("name_pro")
                    bar_code = .Item("bar_code")
                    code_pro = .Item("code_pro")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO cash_sale_serial(sale_id,fix_id,cash_id,customer_id,customer_name," _
                    & "name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee)" _
                          & "VALUES(@sale_id,@fix_id,@cash_id,@customer_id,@customer_name,@name_pro," _
                          & "@code_pro,@bar_code,@serial_pro,@date_in,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                    .Parameters.Add(New MySqlParameter("@cash_id", CashSaleFrm.txtCScashID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
                    .Parameters.Add(New MySqlParameter("@name_pro", name_pro))
                    .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", bar_code))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblEmployee.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'ลบ sn 
                strSQL = "DELETE FROM product_serial WHERE serial_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value & "'" & _
                                                     " AND name_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(1).Value & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub
    Dim code_pro, Typet As String
    Dim price_cost, count_numS As Decimal
    Friend Sub saveCashDGNosnTodatabase()
        'บันทึกไป cash_sale_barcode กรณียังไม่จ่ายเงิน
        For rALL As Integer = 0 To dgPWproMeNoSN.RowCount - 1
            Try
                strSQL = "SELECT code_pro,price_cost,type,count_num FROM product WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    code_pro = .Item("code_pro")
                    price_cost = .Item("price_cost")
                    Typet = .Item("type")
                    count_numS = .GetDecimal("count_num")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO cash_sale_barcode(sale_id,cash_id,fix_id,customer_id,customer_name,customer_tel," _
                    & "code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,type,date_in,datetime_save,employee,discount) " _
                        & " VALUES(@sale_id,@cash_id,@fix_id,@customer_id,@customer_name,@customer_tel," _
                        & "@code_pro,@bar_code,@name_pro,@total_pro,@price_cost,@price_buy,@unit,@type,@date_in,@datetime_save,@employee,@discount)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                    .Parameters.Add(New MySqlParameter("@cash_id", CashSaleFrm.txtCScashID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
                    .Parameters.Add(New MySqlParameter("@customer_tel", Me.txtScusTel.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@total_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(3).Value))
                    .Parameters.Add(New MySqlParameter("@price_cost", price_cost))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgPWproMeNoSN.Rows(rALL).Cells(2).Value)) 'old = price_buy
                    .Parameters.Add(New MySqlParameter("@unit", Me.dgPWproMeNoSN.Rows(rALL).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@type", Typet))
                    .Parameters.Add(New MySqlParameter("@date_in", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblEmployee.Text))
                    .Parameters.Add(New MySqlParameter("@discount", Me.dgPWproMeNoSN.Rows(rALL).Cells(4).Value))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'อัพเดทจำนวน 
            Try
                Dim totalDel As Decimal
                totalDel = count_numS - CDec(Me.dgPWproMeNoSN.Rows(rALL).Cells(3).Value)
                strSQL = "UPDATE product SET count_num='" & totalDel & "' WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Friend Sub saveCashSaleAll()
        Try
            'บันทึกไป cash_sale กรณีจ่ายเงิน
            strSQL = "INSERT INTO cash_sale(sale_id,fix_id,cash_id,customer_id,customer_name,total_all,date_in,datetime_save,cash_status,date_edit,employee,cash_detail) " _
                       & " VALUES(@sale_id,@fix_id,@cash_id,@customer_id,@customer_name,@total_all,@date_in,@datetime_save,@cash_status,@date_edit,@employee,@cash_detail)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                .Parameters.Add(New MySqlParameter("@cash_id", CashSaleFrm.txtCScashID.Text))
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
                .Parameters.Add(New MySqlParameter("@total_all", Me.lblPWgetTotalPrice.Text))
                .Parameters.Add(New MySqlParameter("@date_in", GetLocalServerDateTime))
                .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime))
                .Parameters.Add(New MySqlParameter("@cash_status", "ชำระเงิน"))
                .Parameters.Add(New MySqlParameter("@date_edit", GetLocalServerDateTime))
                .Parameters.Add(New MySqlParameter("@employee", Me.lblEmployee.Text))
                .Parameters.Add(New MySqlParameter("@cash_detail", CashSaleFrm.cashDetail))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    '-----------------------------------------------------------------------------------

    Friend Sub saveSaleAll()
        Try
            'บันทึกไป sale กรณียังไม่จ่ายเงิน
            strSQL = "INSERT INTO sale(sale_id,fix_id,customer_id,customer_name,total_all,date_in,datetime_save,cash_status,date_edit,employee)" _
                       & " VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@total_all,@date_in,@datetime_save,@cash_status,@date_edit,@employee)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
                .Parameters.Add(New MySqlParameter("@total_all", Me.lblPWgetTotalPrice.Text))
                .Parameters.Add(New MySqlParameter("@date_in", GetLocalServerDateTime))
                .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime))
                .Parameters.Add(New MySqlParameter("@cash_status", "ยังไม่ชำระเงิน"))
                .Parameters.Add(New MySqlParameter("@date_edit", GetLocalServerDateTime))
                .Parameters.Add(New MySqlParameter("@employee", Me.lblEmployee.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub saveDGwsnTodatabase()
        'บันทึกไป sale_serial กรณียังไม่จ่ายเงิน
        'SN
        'บันทึกข้อมูลลงฐานข้อมูล หลักการโดยการนำข้อมูล sn จากตาราง 0 ของ ดาต้ากริต ไปเลือกข้อมูลในฐานข้อมูลเพื่อจะนำเอาชื่อและบาร์โค๊ต ฯลฯ ออกมาจากนั้น อ่านแล้วนำไปเก็บไว้ใน String 
        'จากนั้นอ่าน String แล้ว insert into อีกที จากนั้นก็ตามไปลบ serial_pro ทิ้ง จากนั้นก็ลูปจากต้นจนครบหมดทุกแถว


        For rALL As Integer = 0 To dgPWproMEwSN.RowCount - 1
            Dim name_pro As String = String.Empty
            Dim bar_code As String = String.Empty
            Dim code_pro As String = String.Empty
            Try
                strSQL = "SELECT name_pro,bar_code,code_pro FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    name_pro = .Item("name_pro").ToString
                    bar_code = .Item("bar_code").ToString
                    code_pro = .Item("code_pro").ToString
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO sale_serial(sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee)" _
                          & "VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@name_pro,@code_pro,@bar_code,@serial_pro,@date_in,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
                    .Parameters.Add(New MySqlParameter("@name_pro", name_pro))
                    .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", bar_code))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblEmployee.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                'ลบ sn 

                strSQL = "DELETE FROM product_serial WHERE serial_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value & "'" & _
                                                         " AND name_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Friend Sub saveDGNosnTodatabase()
        'บันทึกไป sale_barcode กรณียังไม่จ่ายเงิน
        For rALL As Integer = 0 To dgPWproMeNoSN.RowCount - 1
            Try
                strSQL = "SELECT code_pro,price_cost,type,count_num FROM product WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    code_pro = .Item("code_pro")
                    price_cost = .Item("price_cost")
                    Typet = .Item("type")
                    count_numS = .GetDecimal("count_num")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO sale_barcode(sale_id,fix_id,customer_id,customer_name,customer_tel," _
                    & "code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,type,date_in,datetime_save,employee,discount) " _
                        & " VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@customer_tel," _
                        & "@code_pro,@bar_code,@name_pro,@total_pro,@price_cost,@price_buy,@unit,@type,@date_in,@datetime_save,@employee,@discount)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtScusID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtScusName.Text))
                    .Parameters.Add(New MySqlParameter("@customer_tel", Me.txtScusTel.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@total_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(3).Value))
                    .Parameters.Add(New MySqlParameter("@price_cost", price_cost))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgPWproMeNoSN.Rows(rALL).Cells(2).Value)) 'old = price_buy
                    .Parameters.Add(New MySqlParameter("@unit", Me.dgPWproMeNoSN.Rows(rALL).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@type", Typet))
                    .Parameters.Add(New MySqlParameter("@date_in", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@datetime_save", GetLocalServerDateTime))
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblEmployee.Text))
                    .Parameters.Add(New MySqlParameter("@discount", Me.dgPWproMeNoSN.Rows(rALL).Cells(4).Value))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'อัพเดทจำนวน 
            Try
                Dim totalDel As Decimal
                totalDel = count_numS - CDec(Me.dgPWproMeNoSN.Rows(rALL).Cells(3).Value)
                strSQL = "UPDATE product SET count_num='" & totalDel & "' WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub txtScusID_TextChanged(sender As Object, e As EventArgs) Handles txtScusID.TextChanged
        If Me.txtScusID.Text <> Nothing Then
            Call MainFrm.SearchSaleByCusID(Me.txtScusID.Text)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/sales/salefrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbbPWgetProSection_DropDown(sender As Object, e As EventArgs) Handles cbbPWgetProSection.DropDown
        Call getdatacombobox_prosection()
    End Sub

    Private Sub cbbPWgetProSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbPWgetProSection.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbPWgetProSection_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbPWgetProSection.SelectionChangeCommitted
        Try
            Call search_recordfromcbbPWsection(Me.cbbPWgetProSection.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPWProsearch_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgPWProsearch.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.txtScusID.Text = "" Then
                MainFrm.lblMainStatus.Text = "กรุณาเลือกรายชื่อลูกค้า"
                Me.txtScusID.BackColor = Color.OrangeRed
                Me.txtScusName.BackColor = Color.OrangeRed
                Me.txtSaddress.BackColor = Color.OrangeRed
                Me.txtScusTel.BackColor = Color.OrangeRed
                Timer1.Start()
                Exit Sub
            End If
            If Me.dgPWProsearch.SelectedRows.Count <= 0 Then
            Else
                Me.txtPWprobarcodeANDsn.Text = Me.dgPWProsearch.SelectedCells(1).Value
                If Me.txtPWprobarcodeANDsn.Text <> Nothing Or Me.txtPWprobarcodeANDsn.Text <> "ป้อน SN/BarCode" Then
                    Call AddsnBCTodg()
                    Me.txtPWprobarcodeANDsn.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub txtPWproSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWproSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call search_record()
        End If
    End Sub
End Class