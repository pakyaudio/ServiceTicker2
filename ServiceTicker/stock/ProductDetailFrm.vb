Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class ProductDetailFrm
#Region "code"
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

    ''' <summary>
    ''' ดึงข้อมูลจากฐานข้อมูล MySQL ในตาราง product มาแสดงในดาต้ากริดวิว
    ''' </summary>
    ''' <param name="keyword">คำค้นหา เป็น สตริง, หากแสดงทั้งหมดให้กำหนดเป็น Notting, หากเป็น where ตัวอย่าง WHERE `type`='PS0001'</param>
    ''' <param name="selectSQL">เงื่อนไข SQL Commend ตาราง product search=ค้นหา, all=แสดงทั้งหมด, me=แสดงที่มีสินค้า, date=แสดงที่ปรับปรุงวันนี้ , where=where ของ mysql เช่น "search", "all"</param>
    ''' <code>Call SearchProduct(Me.TextBoxText, "search")</code >
    Friend Sub SearchProduct(ByVal keyword, ByVal selectSQL)
        Try
            Me.dgPDprolist.Rows.Clear()
            Me.dgPDserial.Rows.Clear()
            Me.txtPDprodetail.Clear()
            Me.ListView1.Clear()
            If selectSQL = "search" Then
                strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                           & "product WHERE name_pro LIKE '%" & keyword & "%';"
            ElseIf selectSQL = "all" Then
                strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                      & "product ORDER BY name_pro ASC;"
            ElseIf selectSQL = "me" Then
                strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                      & "product WHERE count_num <> 0;"
            ElseIf selectSQL = "date" Then
                strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                      & "product WHERE update_date LIKE '%" & DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "%';"
            ElseIf selectSQL = "where" Then
                strSQL = keyword
            End If

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgPDprolist
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Tag = Dr.Item("id")
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("count_num")
                    .Rows(r).Cells(4).Value = Dr.Item("update_date")
                End With
            End While
            Me.dgPDprolist.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub GetDataProduct()
        Try
            Me.dgPDprolist.Rows.Clear()
            Me.dgPDserial.Rows.Clear()
            Me.txtPDprodetail.Clear()
            Me.ListView1.Clear()
            If TreeView1.SelectedNode.Tag = "RootNodes" Then
                Try
                    Me.dgPDprolist.Rows.Clear()
                    strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                               & "product WHERE sub_section='0' ORDER BY name_pro;"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    While Dr.Read()
                        Dim r As Integer
                        With Me.dgPDprolist
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = r + 1
                            .Rows(r).Cells(1).Tag = Dr.Item("id")
                            .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                            .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                            .Rows(r).Cells(3).Value = Dr.Item("count_num")
                            .Rows(r).Cells(4).Value = Dr.Item("update_date")
                        End With
                    End While
                    Me.dgPDprolist.ClearSelection()
                    l2 = 0
                    r2 = Me.dgPDserial.RowCount
                    Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            ElseIf TreeView1.SelectedNode.Tag = "mainNodes" Then
                Try
                    Me.dgPDprolist.Rows.Clear()
                    strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                               & "product WHERE `type`='" & TreeView1.SelectedNode.Name.ToString & "' AND sub_section='0';"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    While Dr.Read()
                        Dim r As Integer
                        With Me.dgPDprolist
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = r + 1
                            .Rows(r).Cells(1).Tag = Dr.Item("id")
                            .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                            .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                            .Rows(r).Cells(3).Value = Dr.Item("count_num")
                            .Rows(r).Cells(4).Value = Dr.Item("update_date")
                        End With
                    End While
                    Me.dgPDprolist.ClearSelection()
                    l2 = 0
                    r2 = Me.dgPDserial.RowCount
                    Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            ElseIf TreeView1.SelectedNode.Tag = "childNodes" Then
                Try
                    Me.dgPDprolist.Rows.Clear()

                    'Dim childNodes As TreeNode = New TreeNode(TreeView1.Nodes)
                    strSQL = "SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                               & "product WHERE sub_section='" & nameChild & "';"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    While Dr.Read()
                        Dim r As Integer
                        With Me.dgPDprolist
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = r + 1
                            .Rows(r).Cells(1).Tag = Dr.Item("id")
                            .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                            .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                            .Rows(r).Cells(3).Value = Dr.Item("count_num")
                            .Rows(r).Cells(4).Value = Dr.Item("update_date")
                        End With
                    End While
                    Me.dgPDprolist.ClearSelection()
                    l2 = 0
                    r2 = Me.dgPDserial.RowCount
                    Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
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

    Private Sub GetProDetail(ByVal code_pro As String)
        Me.dgPDserial.Rows.Clear()
        Me.dgPDserial.Rows.Clear()
        Me.txtPDprodetail.Clear()
        Try
            strSQL = "SELECT price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,unit,varuntee,check_stock,company_buy " _
                & "FROM product WHERE code_pro='" & code_pro & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Me.txtPDprodetail.Text = "ราคาทุน=" & Dr.Item("price_cost") & ", " & _
                "ราคาขาย=" & Dr.Item("price_buy") & ", " & _
                "ราคาขายส่ง=" & Dr.Item("price_wholesale") & ", " & _
                "ราคาช่าง=" & Dr.Item("price_technician") & ", " & _
                "ราคาลูกค้าประจำ=" & Dr.Item("price_loyal") & ", " & _
                "ราคาสมาชิก=" & Dr.Item("price_members") & ", " & _
                "หน่วย=" & Dr.Item("unit") & ", " & _
                "ประกัน=" & Dr.Item("varuntee") & ", " & _
                "เตือนเมื่อหมด=" & Dr.Item("check_stock") & ", " & _
                "ซื้อมาจาก=" & Dr.Item("company_buy") & ""
            Else
                Me.txtPDprodetail.Text = "ไม่พบข้อมูลสินค้า"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'load sn
        Try
            strSQL = "SELECT `id`,code_pro,serial_pro,date_in " _
                & "FROM product_serial WHERE code_pro='" & code_pro & "' LIMIT " & Me.NumericUpDown1.Value & ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read
                    Dim r As Integer
                    With Me.dgPDserial
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Tag = Dr.Item("id")
                        .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(1).Tag = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("date_in")
                    End With
                End While
            End If
            Me.dgPDserial.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Call LoadPictureList(code_pro)
        Try
            Call CountSN(Me.dgPDserial.Rows(0).Cells(1).Tag)
            r2 = Me.dgPDserial.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
        Catch ex As Exception
            l2 = 0
            r2 = Me.dgPDserial.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
        End Try
    End Sub

    Private Sub codeproSelect2Next()
        Try
            cmd = New MySqlCommand("SELECT id,code_pro,serial_pro,date_in FROM " _
                                   & "product_serial WHERE code_pro='" & Me.dgPDprolist.CurrentRow.Cells(1).Value & "' " _
                                   & "AND `id` > '" & Me.dgPDserial.Rows(Me.dgPDserial.RowCount - 1).Cells(0).Tag & "' " _
                                   & "LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                ' Me.dgMSN.Rows.Clear()
                Dim r As Integer
                While Dr.Read()
                    With Me.dgPDserial
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Tag = Dr.Item("id")
                        .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(1).Tag = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("date_in")
                    End With
                End While
            End If
            r2 = Me.dgPDserial.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Me.dgPDserial.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Dim codepro As Integer
    Friend Sub DelSNrows(ByVal cellsn As Object)
        Try
            For rr As Integer = 0 To Me.dgPDprolist.Rows.Count - 1
                cmd = New MySqlCommand("SELECT count_num FROM product WHERE code_pro='" & Me.dgPDprolist.Rows(rr).Cells(1).Value & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Me.dgPDprolist.Rows(rr).Cells(3).Value = Dr.Item("count_num")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            For rr As Integer = 0 To Me.dgPDserial.Rows.Count - 1
                If Me.dgPDserial.Rows(rr).Cells(0).Value = cellsn Then
                    Me.dgPDserial.Rows.RemoveAt(Me.dgPDserial.Rows(rr).Index)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub addSNrows(ByVal cellsn As Object)
        Try
            For rr As Integer = 0 To Me.dgPDprolist.Rows.Count - 1
                cmd = New MySqlCommand("SELECT count_num FROM product WHERE code_pro='" & Me.dgPDprolist.Rows(rr).Cells(1).Value & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Me.dgPDprolist.Rows(rr).Cells(3).Value = Dr.Item("count_num")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim rs As Integer
            With Me.dgPDserial
                rs = .Rows.Count
                .Rows.Add()
                .Rows(rs).Cells(0).Value = rs + 1
                .Rows(rs).Cells(1).Value = cellsn
                .Rows(rs).Cells(2).Value = Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
            End With

        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'Try
        '    For r As Integer = 0 To Me.dgPDserial.Rows.Count - 1
        '        Me.dgPDserial.Rows(r).Cells(0).Value = r + 1
        '    Next
        'Catch ex As Exception

        'End Try
    End Sub

    Friend l2 As Integer
    Friend r2 As Integer
    Friend Sub CountSN(ByVal keyword As Object)
        Try
            cmd = New MySqlCommand("SELECT COUNT(code_pro) AS cid FROM product_serial WHERE code_pro='" & keyword & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                l2 = Dr.Item("cid")
                r2 = Me.dgPDserial.Rows.Count
                Me.Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Else
                l2 = 0
            End If
        Catch ex As Exception
            l2 = 0
        End Try
    End Sub

    ''' <summary>
    ''' โหลดรูปลง listview  call LoadPictureList(code_pro)
    ''' </summary>
    ''' <param name="key_pic"></param>
    ''' <remarks></remarks>
    Private Sub LoadPictureList(ByVal key_pic As String)
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(100, 100)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim img_buffer() As Byte
                img_buffer = CType(Dr.Item("byte_pic"), Byte())
                Dim img_stream As New MemoryStream(img_buffer, True)

                img_stream.Write(img_buffer, 0, img_buffer.Length)
                imglist.Images.Add(Dr.Item("pa_id").ToString(), New Bitmap(img_stream))
                img_stream.Close()

                Dim lsvparent As New ListViewItem
                lsvparent.Text = Dr.Item("datetime_save").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

#Region "TreeView RootChild"
    Private Sub AddRootToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddRootToolStripMenu.Click
        ProductSectionFrm.ShowDialog(Me)
    End Sub
#End Region

#Region "TreeView Child"

    Private Sub AddChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddChildToolStripMenu.Click
        ProductChildSectionFrm.ShowDialog(Me)
    End Sub

    Private Sub EditChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles EditChildToolStripMenu.Click
        ProductChildSectionEditFrm.ShowDialog(Me)
    End Sub

    Private Sub DelChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelChildToolStripMenu.Click
        If CountNodes = True Then
            MessageBox.Show(Me, "ไม่สามารถลบได้ เนื่องจากยังมีหมวดหมู่สินค้าย่อยอยู่", "ไม่สามารถลบได้", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CountNodes = False Then
            If MessageBox.Show(Me, "ต้องการลบหมวดหมู่สินค้าหลัก " & TextChild, "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If TreeView1.SelectedNode.Tag = "mainNodes" Then
                    Try
                        cmd = New MySqlCommand("DELETE FROM product_section WHERE prosection_id='" & nameChild & "';", ConnectionDB)
                        Call open_connection()
                        Dim DC As Integer
                        DC = cmd.ExecuteNonQuery()
                        If DC = 1 Then
                            TreeView1.SelectedNode.Remove()
                            TreeView1.Refresh()
                            MessageBox.Show(Me, "ลบข้อมูลแล้ว", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub MoveToolStripMenu_Click(sender As Object, e As EventArgs) Handles MoveToolStripMenu.Click
        If CountNodes = True Then
            MessageBox.Show(Me, "ไม่สามารถย้ายได้ เนื่องจากยังมีหมวดหมู่สินค้าย่อยอยู่", "ไม่สามารถลบได้", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CountNodes = False Then
            'MsgBox("TextChild=" & TextChild & " " & "tagChild=" & tagChild & " " & "nameChild=" & nameChild)
            Call ProductMoveChildSectionFrm.GetProductType(nameChild, TextChild)
            ProductMoveChildSectionFrm.ShowDialog(Me)
        End If
    End Sub
#End Region

#Region "TreeView ParentChild"
    Private Sub MoveParentChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles MoveParentChildToolStripMenu.Click
        Call ProductMoveParentChildSectionFrm.GetProductType(nameChild, TextChild)
        ProductMoveParentChildSectionFrm.ShowDialog(Me)
    End Sub

    Private Sub EditParentChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles EditParentChildToolStripMenu.Click
        ProductParentChildSectionEditFrm.ShowDialog(Me)
    End Sub

    Private Sub DelParentChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelParentChildToolStripMenu.Click
        If CountNodes = True Then
            MessageBox.Show(Me, "ไม่สามารถลบได้ เนื่องจากยังมีหมวดหมู่สินค้าย่อยอยู่", "ไม่สามารถลบได้", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CountNodes = False Then
            If MessageBox.Show(Me, "ต้องการลบหมวดหมู่ย่อยสินค้า " & TextChild, "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If TreeView1.SelectedNode.Tag = "childNodes" Then
                    Try
                        cmd = New MySqlCommand("DELETE FROM product_section_subs WHERE product_section_subs_id='" & nameChild & "'", ConnectionDB)
                        Call open_connection()
                        Dim DC As Integer
                        DC = cmd.ExecuteNonQuery()
                        If DC = 1 Then
                            TreeView1.SelectedNode.Remove()
                            TreeView1.Refresh()
                            MessageBox.Show(Me, "ลบข้อมูลแล้ว", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            End If
        End If
    End Sub
#End Region

#Region "ConTextDG"
    Private Sub MoveSectionDGToolStripMenu_Click(sender As Object, e As EventArgs) Handles MoveSectionDGToolStripMenu.Click
        ProductMoveProSectionFrm.ShowDialog(Me)
    End Sub
#End Region
    Friend nameChild As String
    Friend TextChild As String
    Friend tagChild As String
    Friend CountNodes As Boolean


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
    End Sub
    Private m_OldSelectNode As TreeNode

    Private Sub TreeView1_MouseUp(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Highlight the selected node
            TreeView1.SelectedNode = m_OldSelectNode
            ' Point where mouse is clicked
            Dim p As Point = New Point(e.X, e.Y)

            ' Go to the node that the us           
            Dim node As TreeNode = TreeView1.GetNodeAt(p)
            If Not node Is Nothing Then

                ' Highlight the node that the user clicked. 
                ' The node is highlighted until the Menu is displayed on the screen
                m_OldSelectNode = TreeView1.SelectedNode
                TreeView1.SelectedNode = node

                ' Find the appropriate ContextMenu based on the highlighted node
                Select Case node.Tag
                    Case "mainNodes"
                        Me.ChildContextMenu.Show(TreeView1, p)
                    Case "RootNodes"
                        Me.AddChildRootNodesContextMenu.Show(TreeView1, p)
                    Case "childNodes"
                        Me.ParentChildContextMenu.Show(TreeView1, p)
                End Select
                m_OldSelectNode = Nothing
            End If
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
        'MsgBox("TextChild=" & TextChild & " " & "tagChild=" & tagChild & " " & "nameChild=" & nameChild)
    End Sub

    Private Sub ProductDetailFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub


    Private Sub ProductDetailFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call getProSection()
    End Sub

    Private Sub ProductDetailFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub dgPDprolist_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPDprolist.CellMouseClick
        If dgPDprolist.SelectedRows.Count <> 0 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Me.btnPDedit.Enabled = True
                Call GetProDetail(Me.dgPDprolist.CurrentRow.Cells(1).Value)
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                Me.btnPDedit.Enabled = True
                Me.dgPDprolist.Rows(e.RowIndex).Selected = True
                Me.dgPDprolist.CurrentCell = Me.dgPDprolist.Rows(e.RowIndex).Cells(1)
                Me.DataGridContextMenu.Show(dgPDprolist, e.Location)
                Me.DataGridContextMenu.Show(Cursor.Position)
            End If
        Else
            Me.btnPDedit.Enabled = False
        End If
    End Sub

    Private Sub btnPDsearch_Click(sender As Object, e As EventArgs) Handles btnPDsearch.Click
        productDetailSearchFrm.ShowDialog(Me)
    End Sub

    Private Sub txtPDprodetail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPDprodetail.KeyPress
        e.Handled = True
    End Sub

    Friend NewPro As Boolean
    Private Sub btnPDadd_Click(sender As Object, e As EventArgs) Handles btnPDadd.Click
        Try
            With ProductDetailEditFrm
                .saveCheck = True
                .txtPDAddSn.Enabled = False
                .btnPDSerialSave.Enabled = False
                .dgPDserial.Enabled = False
                'txt clear
                .txtPDproID.Clear()
                .txtPDbarcode.Clear()
                .txtPDproName.Clear()
                .txtPDEsection.Clear()
                .txtPDEsubsection.Clear()
                .cbbPDproUnit.DataSource = Nothing
                .cbbPDproUnit.Text = Nothing
                .cbPDvaruntee.DataSource = Nothing
                .cbPDvaruntee.Text = Nothing
                '=0
                .txtPDstockbalance.Text = "0"
                .txtPDprodepleted.Text = "0"
                .txtPDproPiceCost.Text = "0"
                .txtDprobuy.Text = "0"
                .txtPDp_wholsale.Text = "0"
                .txtPDp_technician.Text = "0"
                .txtPDp_loyel.Text = "0"
                .txtPDp_member.Text = "0"

                .RichTextProdetail.Text = "-"
                .cbbPDsalefor.DataSource = Nothing
                .cbbPDsalefor.Text = Nothing
                .txtPDnote.Text = "-"
                .txtPDAddSn.Clear()
                .ListView1.Clear()
                .dgPDserial.Rows.Clear()
                .lblSNcount.Text = "0" & "/" & "0"
            End With

            If TreeView1.SelectedNode.Tag = "mainNodes" Then
                ProductDetailEditFrm.txtPDEsection.Text = TreeView1.SelectedNode.Text.ToString
                ProductDetailEditFrm.txtPDEsection.Tag = TreeView1.SelectedNode.Name.ToString
                ProductDetailEditFrm.txtPDEsubsection.Text = "-"
                ProductDetailEditFrm.txtPDEsubsection.Tag = "0"
            Else
                If (TreeView1.SelectedNode.Parent IsNot Nothing) Then
                    If (TreeView1.SelectedNode.Parent.GetType() Is GetType(TreeNode)) Then
                        If TreeView1.SelectedNode.Tag = "childNodes" Then
                            ProductDetailEditFrm.txtPDEsection.Text = TreeView1.SelectedNode.Parent.Text.ToString
                            ProductDetailEditFrm.txtPDEsection.Tag = TreeView1.SelectedNode.Parent.Name.ToString
                            ProductDetailEditFrm.txtPDEsubsection.Text = TextChild
                            ProductDetailEditFrm.txtPDEsubsection.Tag = nameChild
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        ProductDetailEditFrm.ShowDialog(Me)
        Call GetDataProduct()
    End Sub

    Private Sub btnPDedit_Click(sender As Object, e As EventArgs) Handles btnPDedit.Click
        If Me.dgPDprolist.SelectedRows.Count <> 0 Then
            ProductDetailEditFrm.saveCheck = False
            ProductDetailEditFrm.txtPDAddSn.Enabled = True
            ProductDetailEditFrm.btnPDSerialSave.Enabled = True
            ProductDetailEditFrm.dgPDserial.Enabled = True
            ProductDetailEditFrm.txtPDproID.Enabled = False
            ProductDetailEditFrm.btnPDgetCodepro.Enabled = False
            Call ProductDetailEditFrm.LoadEditProduct(Me.dgPDprolist.CurrentRow.Cells(1).Tag)
            Call ProductDetailEditFrm.LoadPictureList(Me.dgPDprolist.CurrentRow.Cells(1).Value)
            ProductDetailEditFrm.ShowDialog(Me)
            'Call GetDataProduct()
        End If

    End Sub

    Private Sub btnManagerSN_Click(sender As Object, e As EventArgs) Handles btnManagerSN.Click
        ManagerSNFrm.ShowDialog(Me)
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If l2 > Me.NumericUpDown1.Value Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Me.btnForward.Enabled = False
        Call codeproSelect2Next()
        Me.btnForward.Enabled = True
    End Sub

    Private Sub btnPDdel_Click(sender As Object, e As EventArgs) Handles btnPDdel.Click
        If Me.dgPDprolist.SelectedRows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการลบสินค้านี้ ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    cmd = New MySqlCommand("DELETE FROM product WHERE `id`='" & Me.dgPDprolist.CurrentRow.Cells(1).Tag & "';", ConnectionDB)
                    Call open_connection()
                    Dim de As Integer
                    de = cmd.ExecuteNonQuery
                    If de = 1 Then
                        MessageBox.Show(Me, "ลบสินค้าแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call GetDataProduct()
                    Else
                        MessageBox.Show(Me, "ลบสินค้าไม่สำเร็จ", "ไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        Else
            MessageBox.Show(Me, "กรุณาเลือกสินค้าที่ต้องการลบ", "เลือกสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgPDprolist_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPDprolist.CellMouseDoubleClick
        If Me.dgPDprolist.SelectedRows.Count <> 0 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                ProductDetailEditFrm.saveCheck = False
                ProductDetailEditFrm.txtPDAddSn.Enabled = True
                ProductDetailEditFrm.btnPDSerialSave.Enabled = True
                ProductDetailEditFrm.dgPDserial.Enabled = True
                ProductDetailEditFrm.txtPDproID.Enabled = False
                ProductDetailEditFrm.btnPDgetCodepro.Enabled = False
                Call ProductDetailEditFrm.LoadEditProduct(Me.dgPDprolist.CurrentRow.Cells(1).Tag)
                Call ProductDetailEditFrm.LoadPictureList(Me.dgPDprolist.CurrentRow.Cells(1).Value)
                ProductDetailEditFrm.ShowDialog(Me)
                'Call GetDataProduct()
            End If
        End If
    End Sub

    Private Sub dgPDprolist_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgPDprolist.RowStateChanged
        If Me.dgPDprolist.SelectedRows.Count <> 0 Then
            Me.btnPDedit.Enabled = True
        Else
            Me.btnPDedit.Enabled = False
        End If
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                    MainViewPictureFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                    MainViewPictureFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/stock/productdetailfrm")
        Catch ex As Exception

        End Try
    End Sub

   
  
End Class