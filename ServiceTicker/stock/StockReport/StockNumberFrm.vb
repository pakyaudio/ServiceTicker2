Imports MySql.Data.MySqlClient

Public Class StockNumberFrm
#Region "Code"
    Private Sub GetProductType()
        Me.cbbSale_company.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT sale_company_id,sale_company_name FROM sale_company ORDER BY sale_company_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.cbbSale_company.DisplayMember = "sale_comname"
                Me.cbbSale_company.ValueMember = "sale_comid"

                dt.Columns.Add("sale_comname", GetType(String))
                dt.Columns.Add("sale_comid", GetType(String))
                dt.Rows.Add("แสดงทั้งหมด", "FORALL")
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("sale_company_name"), Dr.Item("sale_company_id"))
                End While

                Me.cbbSale_company.DataSource = dt
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

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
            Me.dgSN.Rows.Clear()
            If Me.TreeView1.SelectedNode.Tag = "RootNodes" Then
                If Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                     Me.rbLowPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                        & "WHERE count_num <= check_stock AND service_chart='0' AND sub_section='0';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                   Me.rbMePro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                           & "WHERE count_num > 0 AND service_chart='0' AND sub_section='0';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                  Me.rbNoPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                           & "WHERE count_num <= 0 AND service_chart='0' AND sub_section='0';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                   Me.rbAllpro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                        & "WHERE service_chart='0' AND sub_section='0';"


                ElseIf Me.rbLowPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                         & "WHERE company_buy='" & Me.cbbSale_company.Text & "' " _
                         & "AND count_num <= check_stock AND service_chart='0' AND sub_section='0';"
                ElseIf Me.rbMePro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                       & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                       & "count_num > 0 AND service_chart='0' AND sub_section='0';"
                ElseIf Me.rbNoPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                            & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                            & "count_num <= 0 AND service_chart='0' AND sub_section='0';"
                ElseIf Me.rbAllpro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                & "service_chart='0' AND sub_section='0';"
                End If
            ElseIf Me.TreeView1.SelectedNode.Tag = "mainNodes" Then
                If Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                    Me.rbLowPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                        & "WHERE count_num <= check_stock AND service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                  Me.rbMePro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                           & "WHERE count_num > 0 AND service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                 Me.rbNoPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                           & "WHERE count_num <= 0 AND service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                 Me.rbAllpro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product WHERE " _
                        & "service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"


                ElseIf Me.rbLowPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                         & "WHERE company_buy='" & Me.cbbSale_company.Text & "' " _
                         & "AND count_num <= check_stock AND service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                ElseIf Me.rbMePro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                       & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                       & "count_num > 0 AND service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                ElseIf Me.rbNoPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                            & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                            & "count_num <= 0 AND service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                ElseIf Me.rbAllpro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                & "service_chart='0' AND `type`='" & Me.nameChild & "' AND sub_section='0';"
                End If

            ElseIf Me.TreeView1.SelectedNode.Tag = "childNodes" Then
                If Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
              Me.rbLowPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                        & "WHERE count_num <= check_stock AND service_chart='0' AND sub_section='" & Me.nameChild & "';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                  Me.rbMePro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                           & "WHERE count_num > 0 AND service_chart='0' AND sub_section='" & Me.nameChild & "';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                 Me.rbNoPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                           & "WHERE count_num <= 0 AND service_chart='0' AND sub_section='" & Me.nameChild & "';"
                ElseIf Me.cbbSale_company.SelectedValue.ToString = "FORALL" And
                 Me.rbAllpro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product WHERE " _
                       & "service_chart='0' AND sub_section='" & Me.nameChild & "';"


                ElseIf Me.rbLowPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                         & "WHERE company_buy='" & Me.cbbSale_company.Text & "' " _
                         & "AND count_num <= check_stock AND service_chart='0' AND sub_section='" & Me.nameChild & "';"
                ElseIf Me.rbMePro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                       & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                       & "count_num > 0 AND service_chart='0' AND sub_section='" & Me.nameChild & "';"
                ElseIf Me.rbNoPro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                            & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                            & "count_num <= 0 AND service_chart='0' AND sub_section='" & Me.nameChild & "';"
                ElseIf Me.rbAllpro.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,count_num FROM product " _
                & "WHERE company_buy='" & Me.cbbSale_company.Text & "' AND " _
                & "service_chart='0' AND sub_section='" & Me.nameChild & "';"
                End If
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("count_num")
                    .Rows(r).Cells(6).Value = Dr.Item("price_cost")
                    .Rows(r).Cells(7).Value = Dr.Item("price_buy")
                End With
            End While

        Catch ex As Exception
            'GETwhere = Nothing

        End Try

        For d As Integer = 0 To Me.dgSN.Rows.Count - 1
            Try
                strSQL = "SELECT COUNT(code_pro) AS code FROM product_serial WHERE code_pro='" & Me.dgSN.Rows(d).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgSN
                    .Rows(d).Cells(5).Value = Dr.Item("code")
                End With
                'StockNumberFrm.dgSN.Rows(d).Cells(6).Value =
                '    CDec(StockNumberFrm.dgSN.Rows(d).Cells(4).Value) - CDec(StockNumberFrm.dgSN.Rows(d).Cells(5).Value)
                Me.dgSN.Rows(d).Cells(8).Value =
                    CDec(Me.dgSN.Rows(d).Cells(6).Value) * CDec(Me.dgSN.Rows(d).Cells(4).Value)
                Me.dgSN.Rows(d).Cells(9).Value =
                    CDec(Me.dgSN.Rows(d).Cells(7).Value) * CDec(Me.dgSN.Rows(d).Cells(4).Value)
            Catch ex As Exception

            End Try
        Next

        Try

            Dim tot, tot1, tot2 As Decimal
            For s1 As Integer = 0 To Me.dgSN.Rows.Count - 1
                tot += CDec(Me.dgSN.Rows(s1).Cells(4).Value)
                tot1 += CDec(Me.dgSN.Rows(s1).Cells(8).Value)
                tot2 += CDec(Me.dgSN.Rows(s1).Cells(9).Value)
            Next
            Me.txtSNtotal_p.Text = tot.ToString("N0")
            Me.txtSNtotal_costA.Text = tot1.ToString("N2")
            Me.txtSNtotal_buy.Text = tot2.ToString("N2")
        Catch ex As Exception

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
    End Sub

    Private Sub StockNumberFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub StockNumberFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call GetProductType()
    End Sub

    Private Sub cbbSale_company_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbSale_company.KeyPress
        e.Handled = True
    End Sub

 
    Private Sub txtSNtotal_buy_MouseHover(sender As Object, e As EventArgs) Handles txtSNtotal_buy.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtSNtotal_buy.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtSNtotal_buy, thaitext)
    End Sub

    Private Sub txtSNtotal_costA_MouseHover(sender As Object, e As EventArgs) Handles txtSNtotal_costA.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtSNtotal_costA.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtSNtotal_costA, thaitext)
    End Sub

    Private Sub txtSNtotal_p_MouseHover(sender As Object, e As EventArgs) Handles txtSNtotal_p.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtSNtotal_p.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtSNtotal_p, thaitext)
    End Sub

    Private Sub btnSNgetsn_Click(sender As Object, e As EventArgs) Handles btnSNgetsn.Click
        If Me.dgSN.Rows.Count <> 0 Then
            If Me.dgSN.CurrentRow.Cells(5).Value <= 0 Then
                MessageBox.Show(Me, "ไม่มีสินค้าในระบบ SN", "ไม่มี SN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Call ViewStockNumberSNFrm.GetSNByCodepro(Me.dgSN.CurrentRow.Cells(1).Value)
                ViewStockNumberSNFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub dgSN_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgSN.RowStateChanged
        If Me.dgSN.Rows.Count <> 0 Then
            Me.btnSNgetsn.Enabled = True
            Me.btnSNprint.Enabled = True
        Else
            Me.btnSNgetsn.Enabled = False
            Me.btnSNprint.Enabled = False
        End If
    End Sub

    Private Sub btnSNprint_Click(sender As Object, e As EventArgs) Handles btnSNprint.Click
        If Me.dgSN.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการพิมพ์รายการนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    strSQLite = "DELETE FROM StockAllReport;"
                    cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For r As Integer = 0 To Me.dgSN.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO StockAllReport(no,code_pro,bar_code,name_pro,count_num,sn,cost,buy,totalcost,totalbuy)VALUES" _
                            & "(@no,@code_pro,@bar_code,@name_pro,@count_num,@sn,@cost,@buy,@totalcost,@totalbuy)"
                        cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                        cmdSQLite.Parameters.AddWithValue("@no", Me.dgSN.Rows(r).Cells(0).Value)
                        cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgSN.Rows(r).Cells(1).Value)
                        cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgSN.Rows(r).Cells(2).Value)
                        cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgSN.Rows(r).Cells(3).Value)
                        cmdSQLite.Parameters.AddWithValue("@count_num", Me.dgSN.Rows(r).Cells(4).Value)
                        cmdSQLite.Parameters.AddWithValue("@sn", Me.dgSN.Rows(r).Cells(5).Value)
                        cmdSQLite.Parameters.AddWithValue("@cost", Me.dgSN.Rows(r).Cells(6).Value)
                        cmdSQLite.Parameters.AddWithValue("@buy", Me.dgSN.Rows(r).Cells(7).Value)
                        cmdSQLite.Parameters.AddWithValue("@totalcost", Me.dgSN.Rows(r).Cells(8).Value)
                        cmdSQLite.Parameters.AddWithValue("@totalbuy", Me.dgSN.Rows(r).Cells(9).Value)
                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                If checkPrinter() = "A4" Then
                    StockNumberPrintA4Frm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    StockNumberPrintA5Frm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/stock/stockreport/stocknumberfrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StockNumberFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call getProSection()
    End Sub
End Class