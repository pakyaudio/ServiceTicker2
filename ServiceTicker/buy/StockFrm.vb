Imports MySql.Data.MySqlClient

Public Class StockFrm
    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView

#Region "Code"
    Friend Sub getProSection()
        Me.TreeView1.Nodes.Clear()
        Dim RootNodes As TreeNode = New TreeNode
        RootNodes.Name = "RootNodes"
        RootNodes.Text = "ประเภทสินค้า"
        RootNodes.Tag = "RootNodes"
        TreeView1.Nodes.Add(RootNodes)
        Try
            strSQL = "SELECT prosection_id,prosection_name FROM product_section ORDER BY prosection_name;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim mainNodes As TreeNode = New TreeNode
                mainNodes.Name = Dr.Item("prosection_id")
                mainNodes.Text = Dr.Item("prosection_name")
                mainNodes.Tag = "mainNodes"
                Me.TreeView1.Nodes(0).Nodes.Add(mainNodes)
            End While
            Me.TreeView1.ExpandAll()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For Each TView As TreeNode In TreeView1.Nodes(0).Nodes
            Try
                strSQL = "SELECT product_section_id,product_section_subs_id,product_section_subs_name FROM " _
                    & "product_section_subs WHERE product_section_id='" & TView.Name.ToString & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    Dim childNodes As TreeNode = New TreeNode(TView.Text)
                    childNodes.Name = Dr.Item("product_section_subs_id")
                    childNodes.Text = Dr.Item("product_section_subs_name")
                    childNodes.Tag = "childNodes"
                    TView.Nodes.Add(childNodes)
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Friend Sub GetDataProduct()
        Try
            Me.dgStock.DataSource = Nothing
            Call addtodgS()
            If TreeView1.SelectedNode.Tag = "RootNodes" Then
                Try
                    Using dt = New DataTable
                        strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                              & "product WHERE sub_section='0' ORDER BY name_pro;"
                        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                        Call open_connection()
                        dtAdapter.Fill(dt)
                        Me.dgStock.DataSource = dt
                    End Using
                    Me.dgStock.ClearSelection()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            ElseIf TreeView1.SelectedNode.Tag = "mainNodes" Then
                Try
                    Using dt = New DataTable
                        strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                                   & "product WHERE `type`='" & TreeView1.SelectedNode.Name.ToString & "' AND sub_section='0';"
                        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                        Call open_connection()
                        dtAdapter.Fill(dt)
                        Me.dgStock.DataSource = dt
                    End Using
                    Me.dgStock.ClearSelection()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            ElseIf TreeView1.SelectedNode.Tag = "childNodes" Then
                Try
                    Using dt = New DataTable
                        strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                                   & "product WHERE sub_section='" & nameChild & "';"
                        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                        Call open_connection()
                        dtAdapter.Fill(dt)
                        Me.dgStock.DataSource = dt
                    End Using
                    Me.dgStock.ClearSelection()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend nameChild As String
    Friend TextChild As String
    Friend tagChild As String
    Friend CountNodes As Boolean


#End Region

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        CountNodes = Nothing
        If (e.Node.Parent IsNot Nothing) Then
            If (e.Node.Parent.GetType() Is GetType(TreeNode)) Then
                TextChild = e.Node.Text
                tagChild = e.Node.Tag
                nameChild = e.Node.Name
            End If
        End If

        If e.Node.Nodes.Count <> 0 Then
            CountNodes = True
        ElseIf e.Node.Nodes.Count = 0 Then
            CountNodes = False
        End If
        Call GetDataProduct()
        Call countProduct()
        Call count_num()
        Call profit()
        Call cost()
    End Sub


    Private Sub StockFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub addtodgS()
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "code_pro"
        ColumnTextBox.HeaderText = "รหัสสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 110
        Me.dgStock.Columns.Add(ColumnTextBox)
        '1
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "bar_code"
        ColumnTextBox.HeaderText = "บาร์โค๊ต"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 110
        Me.dgStock.Columns.Add(ColumnTextBox)
        '2
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "name_pro"
        ColumnTextBox.HeaderText = "ชื่อสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 227
        Me.dgStock.Columns.Add(ColumnTextBox)
        '3
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "price_cost"
        ColumnTextBox.HeaderText = "ราคาทุน"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 80
        Me.dgStock.Columns.Add(ColumnTextBox)
        '4
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "price_buy"
        ColumnTextBox.HeaderText = "ราคาขาย"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 90
        Me.dgStock.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "unit"
        ColumnTextBox.HeaderText = "หน่วย"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 73
        Me.dgStock.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "count_num"
        ColumnTextBox.HeaderText = "คงเหลือ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 73
        Me.dgStock.Columns.Add(ColumnTextBox)
    End Sub

    Private Sub StockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call addtodgS()
        'Call getDtatToCbbSproTypeSelect()
        Call getProSection()
    End Sub
    Private Sub countProduct()
        For i = 0 To dgStock.RowCount
            Me.txtScountProduct.Text = i & " รายการ"
        Next
    End Sub
    Private Sub count_num()
        Try
            Me.txtScount_num.Text = "0"
            Dim sum As Double = 0
            Dim count As Integer = 0
            For i = 0 To dgStock.RowCount - 1
                If dgStock.Rows(i).Cells(6).Value > count Then
                    sum += dgStock.Rows(i).Cells(4).Value * dgStock.Rows(i).Cells(6).Value
                    Me.txtScount_num.Text = sum.ToString("N2")
                End If
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub profit()
        Try
            Me.txtSprofit.Text = "0"
            Dim sum As Integer
            For i = 0 To dgStock.RowCount - 1
                If Me.dgStock.Rows(i).Cells(6).Value = "-" Then
                    Me.dgStock.Rows(i).Cells(6).Value = 0
                End If
                sum += (CInt(Me.dgStock.Rows(i).Cells(4).Value) * CInt(Me.dgStock.Rows(i).Cells(6).Value)) - (CInt(Me.dgStock.Rows(i).Cells(3).Value) * CInt(Me.dgStock.Rows(i).Cells(6).Value))
                Me.txtSprofit.Text = sum.ToString("N2")
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub cost()
        Try
            Me.txtScost.Text = "0"
            Dim sum As Integer
            For i = 0 To dgStock.RowCount - 1
                If Me.dgStock.Rows(i).Cells(6).Value = "-" Then
                    Me.dgStock.Rows(i).Cells(6).Value = 0
                End If
                sum += CInt(Me.dgStock.Rows(i).Cells(3).Value) * CInt(Me.dgStock.Rows(i).Cells(6).Value)
                Me.txtScost.Text = sum.ToString("N2")
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    'Private Sub getDtatToCbbSproTypeSelect()
    '    Try
    '        Me.cbbSproType.DataSource = Nothing
    '        dt = New DataTable
    '        cmd = New MySqlCommand("SELECT prosection_id,prosection_name FROM product_section ORDER BY prosection_name;", ConnectionDB)
    '        Call open_connection()
    '        Dr = cmd.ExecuteReader
    '        Me.cbbSproType.DisplayMember = "Name"
    '        Me.cbbSproType.ValueMember = "ID"

    '        dt.Columns.Add("Name", GetType(String))
    '        dt.Columns.Add("ID", GetType(String))
    '        While Dr.Read()
    '            dt.Rows.Add(Dr.Item("prosection_name"), Dr.Item("prosection_id"))
    '        End While
    '        Me.cbbSproType.DataSource = dt
    '        Me.cbbSproType.SelectedIndex = 0
    '    Catch ex As Exception
    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
    '    End Try
    'End Sub

    'Private Sub getDtatToCbbsubSproTypeSelect()
    '    Try
    '        Me.cbbSsubType.DataSource = Nothing
    '        dt = New DataTable
    '        cmd = New MySqlCommand("SELECT product_section_subs_id,product_section_subs_name FROM product_section_subs " & _
    '                               "WHERE product_section_id='" & Me.cbbSproType.SelectedValue.ToString & "' ORDER BY prosection_name;", ConnectionDB)
    '        Call open_connection()
    '        Dr = cmd.ExecuteReader
    '        Me.cbbSsubType.DisplayMember = "Name"
    '        Me.cbbSsubType.ValueMember = "ID"

    '        dt.Columns.Add("Name", GetType(String))
    '        dt.Columns.Add("ID", GetType(String))
    '        While Dr.Read()
    '            dt.Rows.Add(Dr.Item("product_section_subs_name"), Dr.Item("product_section_subs_id"))
    '        End While
    '        Me.cbbSsubType.DataSource = dt
    '    Catch ex As Exception
    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
    '    End Try
    'End Sub

    'Private Sub getDtatToCbbSproCompanySelect()
    '    Try
    '        Me.cbbSsaleCompany.Items.Clear()
    '        cmd = New MySqlCommand("SELECT sale_company_name FROM " _
    '                               & "sale_company ORDER BY sale_company_name;", ConnectionDB)
    '        Call open_connection()
    '        Dr = cmd.ExecuteReader
    '        While Dr.Read()
    '            Me.cbbSsaleCompany.Items.Add(Dr.Item("sale_company_name"))
    '        End While
    '    Catch ex As Exception
    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
    '    End Try
    'End Sub

    'Private Sub getDataTocbbSproType()
    '    Try
    '        Me.dgStock.Refresh()
    '        Using dt = New DataTable
    '            strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
    '                & "product WHERE `type`='" & Me.cbbSproType.SelectedValue.ToString & "';"
    '            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
    '            Call open_connection()
    '            dtAdapter.Fill(dt)
    '            Me.dgStock.DataSource = dt
    '        End Using
    '    Catch ex As Exception
    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
    '    End Try
    'End Sub
    'Private Sub getDataTocbbSproCompany()
    '    Try
    '        Me.dgStock.Refresh()
    '        Using dt = New DataTable
    '            strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
    '                & "product WHERE company_buy='" & Me.cbbSsaleCompany.Text & "';"
    '            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
    '            Call open_connection()
    '            dtAdapter.Fill(dt)
    '            Me.dgStock.DataSource = dt
    '        End Using
    '    Catch ex As Exception
    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
    '    End Try
    'End Sub
    Private Sub getDataBycbbSproStatus_all()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product;"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_uder_values()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                    & "product WHERE count_num < check_stock;"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_as_values()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                    & "product WHERE count_num <= check_stock;"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_upper_values()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                    & "product WHERE count_num > check_stock;"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub SearchData()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM " _
                    & "product WHERE name_pro LIKE '%" & Me.txtSsearchPro.Text & "%' OR bar_code LIKE '%" & Me.txtSsearchPro.Text & "%'" _
                    & " OR code_pro LIKE '%" & Me.txtSsearchPro.Text & "%';"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtSsearchPro.Clear()
    End Sub


    'Private Sub cbbSproType_SelectionChangeCommitted(sender As Object, e As EventArgs)
    '    Call getDtatToCbbsubSproTypeSelect()
    '    Call countProduct()
    '    Call count_num()
    '    Call profit()
    '    Call cost()
    '    Me.cbbSproStatus.Items.Clear()
    '    Me.cbbSsaleCompany.Items.Clear()
    'End Sub


    'Private Sub cbbSproStatus_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    e.Handled = True
    'End Sub

    'Private Sub cbbSproStatus_MouseClick(sender As Object, e As MouseEventArgs)
    '    Me.cbbSproStatus.Items.Clear()
    '    Me.cbbSproStatus.Items.Add("สินค้ารวม")
    '    Me.cbbSproStatus.Items.Add("สินค้าต่ำกว่าจุดเตือน")
    '    Me.cbbSproStatus.Items.Add("สินค้าหมด/ขาด")
    '    Me.cbbSproStatus.Items.Add("สินค้ายังไม่หมด/มี")
    'End Sub

    'Private Sub cbbSproStatus_SelectedValueChanged(sender As Object, e As EventArgs)
    '    Me.cbbSproType.DataSource = Nothing
    '    Me.cbbSsaleCompany.Items.Clear()
    '    If cbbSproStatus.SelectedItem = "สินค้ารวม" Then
    '        Call getDataBycbbSproStatus_all()
    '    ElseIf cbbSproStatus.SelectedItem = "สินค้าต่ำกว่าจุดเตือน" Then
    '        Call getDataBycbbSproStatus_uder_values()
    '    ElseIf cbbSproStatus.SelectedItem = "สินค้าหมด/ขาด" Then
    '        Call getDataBycbbSproStatus_as_values()
    '    ElseIf cbbSproStatus.SelectedItem = "สินค้ายังไม่หมด/มี" Then
    '        Call getDataBycbbSproStatus_upper_values()
    '    End If
    '    Call countProduct()
    '    Call count_num()
    '    Call profit()
    '    Call cost()
    'End Sub

    'Private Sub cbbSsaleCompany_DropDown(sender As Object, e As EventArgs)
    '    Call getDtatToCbbSproCompanySelect()
    'End Sub

    'Private Sub cbbSsaleCompany_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    e.Handled = True
    'End Sub

    'Private Sub cbbSsaleCompany_SelectedValueChanged(sender As Object, e As EventArgs)
    '    Call getDataTocbbSproCompany()
    '    'Me.cbbSproType.DataSource = Nothing
    '    Me.cbbSproStatus.Items.Clear()
    '    Call countProduct()
    '    Call count_num()
    '    Call profit()
    '    Call cost()
    'End Sub

    Private Sub txtSsearchPro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSsearchPro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSsearchPro.Text <> Nothing Then
                e.SuppressKeyPress = True
                Call SearchData()
            End If
        End If
    End Sub

    Private Sub btnSshowallpro_Click(sender As Object, e As EventArgs) Handles btnSshowallpro.Click
        If Me.txtSsearchPro.Text <> Nothing Then
            Call SearchData()
        End If
    End Sub

    Private Sub dgStock_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgStock.CellMouseDoubleClick
        For i As Integer = 0 To OrderFrm.dgOR.RowCount - 1
            If OrderFrm.dgOR.Rows(i).Cells(0).Value = dgStock.CurrentRow.Cells(1).Value Then
                MessageBox.Show(Me, "มีข้อมูลอยู่แล้ว กรุณาเลือกใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next
        StockSnumFrm.ShowDialog(Me)
    End Sub
    Friend Sub numOK()
        MessageBox.Show(Me, "เพิ่มข้อมูลแล้ว", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        TreeView1.SelectedNode = e.Node
        If (e.Node.Parent IsNot Nothing) Then
            If (e.Node.Parent.GetType() Is GetType(TreeNode)) Then
                TextChild = e.Node.Text
                tagChild = e.Node.Tag
                nameChild = e.Node.Name
            End If
        End If
        Call GetDataProduct()
        Call countProduct()
        Call count_num()
        Call profit()
        Call cost()
    End Sub
End Class