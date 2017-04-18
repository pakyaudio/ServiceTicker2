Imports MySql.Data.MySqlClient

Public Class SearchCustomerRHFrm

    Private Sub GetAllData()
        strSQL = "select customer_id as รหัสลูกค้า, customer_name as ชื่อ, customer_address as ที่อยู่, customer_zipcode as รหัสไปรษณีย์, customer_tel as เบอร์โทร from customer order by customer_id"
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        ds = New DataSet
        Call open_connection()
        dtAdapter.Fill(ds, "customer")
        Me.dgSearchCustoSaveFix.DataSource = ds
        Me.dgSearchCustoSaveFix.DataMember = "customer"
    End Sub
    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView
    Private Sub search_record()
        dt = New DataTable
        Dim strKeyWord As String = Me.txtSearchCus.Text
        strSQL = "select * from customer where 1=1"
        If strKeyWord <> "" Then
            strSQL = strSQL & " and customer_id like '%" & strKeyWord & "%' or customer_name like '%" & strKeyWord & "%' or customer_address like '%" & strKeyWord & "%' or customer_tel like '%" & strKeyWord & "%' "
        End If
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgSearchCustoSaveFix.DataSource = dt
        '******************************'
        Me.dgSearchCustoSaveFix.Columns.Clear()
        With dgSearchCustoSaveFix.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '1
        '*** Column (CustomerID) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_id"
        ColumnTextBox.HeaderText = "รหัสลูกค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '2
        '*** Column (Name) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_name"
        ColumnTextBox.HeaderText = "ชื่อ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '3
        '*** Column (Email) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_address"
        ColumnTextBox.HeaderText = "ที่อยู่"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '4
        '*** Column (CountryCode) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_zipcode"
        ColumnTextBox.HeaderText = "รหัสไปรษณีย์"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '5
        '*** Column (Budget) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_tel"
        ColumnTextBox.HeaderText = "เบอร์โทร"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
    End Sub
    Private Sub btnsearchShowAll_Click(sender As Object, e As EventArgs) Handles btnsearchShowAll.Click
        Call GetAllData()
    End Sub

    Private Sub dgSearchCustoSaveFix_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearchCustoSaveFix.CellDoubleClick
        If Me.dgSearchCustoSaveFix.Rows.Count <> 0 Then
            If Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าค้นหาประวัติงานซ่อม" Then
                RepairHistoryFrm.txtRHsearchCusID.Text = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
                RepairHistoryFrm.getDataComfix()
                RepairHistoryFrm.sumDetail()
                RepairHistoryFrm.txtRHsearchCusID.Clear()
            End If
            Me.Close()
        End If
    End Sub
    Private Sub dgSearchCustoSaveFix_MouseClick(sender As Object, e As MouseEventArgs) Handles dgSearchCustoSaveFix.MouseClick
        If Me.dgSearchCustoSaveFix.Rows.Count = 0 Then
            Exit Sub
        End If
        Me.txtSearchCusShowTel.Text = Me.dgSearchCustoSaveFix.SelectedCells(1).Value
    End Sub
    Private Sub btnSendtoSavedatafix_Click(sender As Object, e As EventArgs) Handles btnSendtoSavedatafix.Click
        If Me.dgSearchCustoSaveFix.Rows.Count <> 0 Then
            If Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าค้นหาประวัติงานซ่อม" Then
                RepairHistoryFrm.txtRHsearchCusID.Text = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
                RepairHistoryFrm.getDataComfix()
                RepairHistoryFrm.sumDetail()
                Call RepairHistoryFrm.TabCount()
                RepairHistoryFrm.txtRHsearchCusID.Clear()
            End If
            Me.Close()
        End If
    End Sub
    Private Sub txtSearchCus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchCus.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSearchCus.Text <> Nothing Then
                Call search_record()
            End If
        End If
    End Sub
    Private Sub btnsearchCusSearch_Click(sender As Object, e As EventArgs) Handles btnsearchCusSearch.Click
        If Me.txtSearchCus.Text <> Nothing Then
            Call search_record()
        End If
    End Sub

    Private Sub SearchCustomerRHFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SearchCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
End Class