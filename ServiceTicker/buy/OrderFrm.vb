Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class OrderFrm
    Friend tbl, tbl1, tbl2 As New DataTable
    Friend r, r1 As DataRow
    Dim ORid As String
    Private Sub AutoNumberNo()
        'cmd = New MySqlCommand("SELECT ver_order FROM ver_detail", ConnectionDB)
        'Call open_connection()
        'Try
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    If Dr.HasRows Then
        '        ORid = Dr.Item("ver_order")
        '    End If
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try

        'cmd = New MySqlCommand("SELECT Max(id) as ID FROM buy_id", ConnectionDB)
        'Call open_connection()
        'Try
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    If Not Dr.HasRows Then
        '        Me.lblORid.Text = ORid & Now.ToString("yyMMddHHmm") & "00001"
        '    Else
        '        Dim newID As Integer = CInt(Dr.Item("id"))
        '        newID += 1
        '        Me.lblORid.Text = ORid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
        '    End If
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try


    End Sub
    Private Sub getDtatToCbbORcompanySelect()
        Me.cbbORcompanySelect.Items.Clear()
        cmd = New MySqlCommand("SELECT sale_company_name FROM sale_company ORDER BY sale_company_name ASC", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Me.cbbORcompanySelect.Items.Add(Dr.Item("sale_company_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDtatToCbbORcompany()
        cmd = New MySqlCommand("SELECT sale_company_id,sale_company_address,sale_company_tel FROM " _
            & "sale_company WHERE sale_company_name='" & Me.cbbORcompanySelect.Text & "'", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                Me.txtORcompanyID.Text = .Item("sale_company_id")
                Me.txtORcompanyAddress.Text = .Item("sale_company_address")
                Me.txtORcompanyTel.Text = .Item("sale_company_tel")
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub addtodgOR()
        tbl.NewRow()
        tbl.Columns.Add(New DataColumn("bar_code", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("name_pro", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("price_cost", GetType(System.Decimal)))
        tbl.Columns.Add(New DataColumn("price_buy", GetType(System.Decimal)))
        tbl.Columns.Add(New DataColumn("unit", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("count_num", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("total", GetType(System.Decimal)))
        dgOR.DataSource = tbl
        With dgOR
            .Columns(0).HeaderText = "บาร์โค๊ต"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "ราคาทุน"
            .Columns(3).HeaderText = "ราคาขาย"
            .Columns(4).HeaderText = "หน่วยนับ"
            .Columns(5).HeaderText = "จำนวน"
            .Columns(6).HeaderText = "รวมราคาทุน"

            .Columns(0).Width = 90
            .Columns(1).Width = 270
            .Columns(2).Width = 70
            .Columns(3).Width = 70
            .Columns(4).Width = 100
            .Columns(5).Width = 70
            .Columns(6).Width = 80

            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = False
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = False
            .Columns(6).ReadOnly = True
            r = tbl.NewRow
        End With
    End Sub

    'Private Sub startfrm()

    'End Sub
    Dim c As Integer
    Private Sub OrdreFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgOR.Rows.Count <> 0 Then
            Dim result = MessageBox.Show("มีข้อมูลยังไม่ถูกบันทึก ต้องการจะบันทึกข้อมูลหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then
                e.Cancel = False
                Me.Dispose()
                OnTopFrm()
            ElseIf result = DialogResult.Yes Then
                e.Cancel = True
                c = 1
                Call savedgORToDatabase()
            End If
        Else
            Me.Dispose()
            OnTopFrm()
        End If
    End Sub
    Private Sub OrdreFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call addtodgOR()
    End Sub

    Private Sub cbbORcompanySelect_DropDown(sender As Object, e As EventArgs) Handles cbbORcompanySelect.DropDown
        Call getDtatToCbbORcompanySelect()
    End Sub

    Private Sub cbbORcompanySelect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbORcompanySelect.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbORcompanySelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbORcompanySelect.SelectedIndexChanged
        Call getDtatToCbbORcompany()
    End Sub

    Private Sub txtORcompanyID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtORcompanyID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbbORcompanySelect.Items.Clear()
            cmd = New MySqlCommand("SELECT sale_company_name,sale_company_address,sale_company_tel FROM " _
                & "sale_company WHERE sale_company_id='" & Me.txtORcompanyID.Text & "'", ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    Me.cbbORcompanySelect.Text = .Item("sale_company_name")
                    Me.txtORcompanyAddress.Text = .Item("sale_company_address")
                    Me.txtORcompanyTel.Text = .Item("sale_company_tel")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                MessageBox.Show(Me, "ไม่พบข้อมูลรหัสบริษัท " & Me.txtORcompanyID.Text, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtORcompanyID.Clear()
                Me.txtORcompanyAddress.Clear()
                Me.txtORcompanyTel.Clear()
                Me.cbbORcompanySelect.Items.Clear()
            End Try
        End If
    End Sub

    Private Sub getProduct()
        'ตรวจบาร์โค๊ตซ้ำ
        For duplicate As Integer = 0 To dgOR.Rows.Count - 1
            If Strings.Trim(Me.txtORbarcodePro.Text) = Strings.Trim(Me.dgOR.Item(0, duplicate).Value) Then
                MessageBox.Show(Me, "บาร์โค๊ต " & Me.txtORbarcodePro.Text & " นี้มีอยู่แล้ว", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtORbarcodePro.Clear()
                Me.txtORbarcodePro.Focus()
                Exit Sub
            End If
        Next
        'ค้นหาข้อมูล อัดลง ดาต้ากริต
        Try
            cmd = New MySqlCommand("SELECT bar_code,name_pro,price_cost,price_buy,unit FROM product WHERE bar_code=@1", ConnectionDB)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@1", Me.txtORbarcodePro.Text)
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                r = tbl.NewRow
                r("bar_code") = .Item("bar_code")
                r("name_pro") = .Item("name_pro")
                r("price_cost") = .GetDecimal("price_cost")
                r("price_buy") = .GetDecimal("price_buy")
                r("unit") = .Item("unit")
                r("count_num") = "1"
                r("total") = .GetDecimal("price_cost")
                tbl.Rows.Add(r)
            End With
            Dr.Close()
            Call sumTdg()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            MessageBox.Show("ไม่พบข้อมูล " & Me.txtORbarcodePro.Text, "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.txtORbarcodePro.Clear()
        Me.txtORbarcodePro.Focus()
    End Sub

    Private Sub sumTdg()
        'หาผลรวมยอดสั่งซื้อทั้งหมดให้มาแสดงที่ Me.txtORsumMoney.Text
        Dim sum As Decimal = 0
        For i = 0 To dgOR.RowCount - 1
            sum += CDec(dgOR.Rows(i).Cells("total").Value)
            Me.txtORsumMoney.Text = sum.ToString("N2")
        Next
    End Sub
    Private Sub txtORbarcodePro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtORbarcodePro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getProduct()
        End If
    End Sub
    Friend Sub sum_dgOR()
        Try
            If Me.dgOR.RowCount = 0 Then
                Me.txtORsumMoney.Text = "0"
                Exit Try
            End If
            For su As Integer = 0 To Me.dgOR.Rows.Count - 1
                Dim iCell1 As Decimal
                Dim icell2 As Decimal
                Dim icellResult As Decimal
                iCell1 = Me.dgOR.Rows(su).Cells(2).Value
                icell2 = Me.dgOR.Rows(su).Cells(5).Value
                icellResult = iCell1 * icell2
                Me.dgOR.Rows(su).Cells(6).Value = icellResult
            Next
            Call sumTdg()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            MessageBox.Show("คำนวนยอดรวมไม่ได้ กรุณาตรวจสอบให้เป็นตัวเลขเท่านั้น", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Dim oldData As Object
    Private Sub dgOR_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOR.CellDoubleClick
        oldData = Me.dgOR.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub
    Private Sub dgOR_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgOR.CellEndEdit
        'รวม ราคาคูณจำนวน
            Try
                Dim iCell1 As Decimal
                Dim icell2 As Decimal
                Dim icellResult As Decimal
                iCell1 = dgOR.CurrentRow.Cells(2).Value
                icell2 = dgOR.CurrentRow.Cells(5).Value
                icellResult = iCell1 * icell2
                dgOR.CurrentRow.Cells(6).Value = icellResult
                Call sumTdg()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                MessageBox.Show("คำนวนยอดรวมไม่ได้ กรุณาใส่ตัวเลข", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.dgOR.CurrentRow.Cells(e.ColumnIndex).Value = oldData
            End Try
    End Sub

    Private Sub btnORdel_Click(sender As Object, e As EventArgs) Handles btnORdel.Click
        'ลบโรล
        If Me.dgOR.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            Me.dgOR.Rows.Remove(Me.dgOR.SelectedRows(0))
            Call sumTdg()
        Else
            MsgBox("กรุณาเลือก 1 รายการเพื่อทำการลบ", MsgBoxStyle.Information, "แจ้งเตือน")
        End If
    End Sub
    Private Sub savedgORToDatabase()
        If Me.txtORcompanyID.Text = Nothing Then
            Me.txtORcompanyID.BackColor = Color.Salmon
            Me.cbbORcompanySelect.BackColor = Color.Salmon
            MsgBox("กรุณาเลือกบริษัทที่จัดซื้อ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        ElseIf Me.dgOR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลกรุณาเลือกสินค้าก่อนทำการบันทึก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            'หลักการคือ อ่านค่าจากตางรางที่ 1 มาจาำนั้นนำ insert into ลงฐานข้อมูล จากนั้นมาตารางที่สอง วนลูปโดยใช้ for
            'Try
            '    'insert to buy_id
            '    strSQL = "INSERT INTO buy_id(buy_id,datetime_save) " _
            '     & "VALUES(@buy_id,@datetime_save)"
            '    cmd = New MySqlCommand(strSQL, ConnectionDB)
            '    With cmd
            '        .Parameters.Add(New MySqlParameter("@buy_id", Me.lblORid.Text))
            '        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
            '        Call open_connection()
            '        .ExecuteNonQuery()
            '    End With
            'Catch ex As Exception
            '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            'End Try

            Try
                'insert to buy
                strSQL = "INSERT INTO buy(buy_id,total,status,sale_company_id,sale_company_name,datetime_save,datetime_edit,employee) " _
                       & "VALUES(@buy_id,@total,@status,@sale_company_id,@sale_company_name,@datetime_save,@datetime_edit,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@buy_id", Me.lblORid.Text))
                    .Parameters.Add(New MySqlParameter("@total", Me.txtORsumMoney.Text))
                    .Parameters.Add(New MySqlParameter("@status", "ยังไม่ได้รับสินค้า"))
                    .Parameters.Add(New MySqlParameter("@sale_company_id", Me.txtORcompanyID.Text))
                    .Parameters.Add(New MySqlParameter("@sale_company_name", Me.cbbORcompanySelect.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@datetime_edit", "no_stockin"))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                For rALL As Integer = 0 To dgOR.RowCount - 1
                    Dim gbc As String = dgOR.Rows(rALL).Cells(0).Value
                    strSQL = "SELECT code_pro,unit FROM product WHERE bar_code='" & gbc & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dim code_pro, unit As String
                    With Dr
                        .Read()
                        code_pro = .Item("code_pro")
                        unit = .Item("unit")
                    End With


                    ''insert to buy_pro
                    strSQL = "INSERT INTO buy_pro(buy_id,sale_company_id,sale_company_name,code_pro,bar_code,name_pro,price_cost,price_buy,count_num,unit,total,datetime_save,employee) " _
                        & "VALUES(@buy_id,@sale_company_id,@sale_company_name,@code_pro,@bar_code,@name_pro,@price_cost,@price_buy,@count_num,@unit,@total,@datetime_save,@employee)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@buy_id", Me.lblORid.Text))
                        .Parameters.Add(New MySqlParameter("@sale_company_id", Me.txtORcompanyID.Text))
                        .Parameters.Add(New MySqlParameter("@sale_company_name", Me.cbbORcompanySelect.Text))
                        .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                        .Parameters.Add(New MySqlParameter("@bar_code", Me.dgOR.Rows(rALL).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgOR.Rows(rALL).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@price_cost", Me.dgOR.Rows(rALL).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@price_buy", Me.dgOR.Rows(rALL).Cells(3).Value))
                        .Parameters.Add(New MySqlParameter("@count_num", Me.dgOR.Rows(rALL).Cells(5).Value))
                        .Parameters.Add(New MySqlParameter("@unit", Me.dgOR.Rows(rALL).Cells(4).Value))
                        .Parameters.Add(New MySqlParameter("@total", Me.dgOR.Rows(rALL).Cells(6).Value))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                Next
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")

            If MessageBox.Show(Me, "ต้องการจะพิมพ์ใบสั่งซื้อหรือไม่", "พิมพ์หรือไม่", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If checkPrinter() = "A4" Then
                    Buy_ProReportA4PrintFrm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    Buy_ProReportA5PrintFrm.ShowDialog(Me)
                End If
            End If
            tbl.Clear()
            Me.txtORsumMoney.Text = "0"
            Me.txtORcompanyID.Clear()
            Me.txtORcompanyAddress.Clear()
            Me.txtORcompanyTel.Clear()
            Me.cbbORcompanySelect.Text = ""
            Me.lblORid.Text = Nothing
            Me.autonum = Nothing
            If c = 1 Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btnORsave_Click(sender As Object, e As EventArgs) Handles btnORsave.Click
        If MessageBox.Show(Me, "ต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call savedgORToDatabase()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaleCompanyFrm.lblEmployee.Text = Me.lblEmployee.Text
        SaleCompanyFrm.ShowDialog(Me)
    End Sub

    Private Sub btnORselectPro_Click(sender As Object, e As EventArgs) Handles btnORselectPro.Click
        StockFrm.ShowDialog(Me)
    End Sub

    Private Sub btnORokBarcode_Click(sender As Object, e As EventArgs) Handles btnORokBarcode.Click
        Call getProduct()
    End Sub

    Private Sub Number_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub dgOR_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgOR.EditingControlShowing
        If Me.dgOR.CurrentCell.ColumnIndex = 2 Or
            Me.dgOR.CurrentCell.ColumnIndex = 5 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Number_keyPress
        End If
    End Sub
    Dim autonum As String
    Private Sub dgOR_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgOR.RowStateChanged
        If Me.dgOR.RowCount = 0 Then
            Me.btnORdel.Enabled = False
            Me.btnORsave.Enabled = False
        Else
            Me.btnORdel.Enabled = True
            Me.btnORsave.Enabled = True
            If autonum = Nothing Then
                Call ALLAutonumber("ver_order", autonum)
                Me.lblORid.Text = autonum
            Else
                Me.lblORid.Text = autonum
            End If
        End If
        Call sum_dgOR()
    End Sub

    Private Sub cbbORcompanySelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbORcompanySelect.SelectedValueChanged
        Me.txtORcompanyID.BackColor = SystemColors.Window
        Me.cbbORcompanySelect.BackColor = SystemColors.Window
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/buymenu/orderfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class