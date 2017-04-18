Imports MySql.Data.MySqlClient

Public Class SelectSectionFrm

    Private Sub SelectSectionFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SelectSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

#Region "code"
    Friend Sub getProSection()
        Me.TreeView1.Nodes.Clear()
        Dim RootNodes As TreeNode = New TreeNode
        RootNodes.Name = "RootNodes"
        RootNodes.Text = "ประเภทสินค้า"
        RootNodes.Tag = "RootNodes"
        TreeView1.Nodes.Add(RootNodes)
        Try
            strSQL = "SELECT prosection_id,prosection_name FROM product_section ORDER BY prosection_name ASC"
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
                    & "product_section_subs WHERE product_section_id='" & TView.Name.ToString & "'"
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
#End Region

#Region "TreeView RootChild"
    Private Sub AddRootToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddRootToolStripMenu.Click
        ''Edit
        SelectProductSectionFrm.ShowDialog(Me)
    End Sub
#End Region

#Region "TreeView Child"

    Private Sub AddChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddChildToolStripMenu.Click
        ''Edit
        SelectProductChildSectionFrm.ShowDialog(Me)
    End Sub

    Private Sub EditChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles EditChildToolStripMenu.Click
        ''Edit
        SelectProductChildSectionEditFrm.ShowDialog(Me)
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
                            ProductDetailFrm.getProSection()
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

#Region "TreeView ParentChild"
    Private Sub EditParentChildToolStripMenu_Click(sender As Object, e As EventArgs) Handles EditParentChildToolStripMenu.Click
        ''Edit
        SelectProductParentChildSectionEditFrm.ShowDialog(Me)
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
                            ProductDetailFrm.getProSection()
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
    End Sub
    Private m_OldSelectNode As TreeNode

    Private Sub TreeView1_MouseUp(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseUp
        ' Show menu only if Right Mouse button is clicked
        If e.Button = MouseButtons.Right Then
            ' Highlight the selected node
            TreeView1.SelectedNode = m_OldSelectNode
            ' Point where mouse is clicked
            Dim p As Point = New Point(e.X, e.Y)

            ' Go to the node that the user clicked
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

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Try
            If TreeView1.SelectedNode.Tag = "mainNodes" Then
                ProductDetailEditFrm.txtPDEsection.Text = TreeView1.SelectedNode.Text.ToString
                ProductDetailEditFrm.txtPDEsection.Tag = TreeView1.SelectedNode.Name.ToString
                ProductDetailEditFrm.txtPDEsubsection.Text = "-"
                ProductDetailEditFrm.txtPDEsubsection.Tag = "0"
            Else
                If (e.Node.Parent IsNot Nothing) Then
                    If (e.Node.Parent.GetType() Is GetType(TreeNode)) Then
                        If TreeView1.SelectedNode.Tag = "childNodes" Then
                            ProductDetailEditFrm.txtPDEsection.Text = e.Node.Parent.Text.ToString
                            ProductDetailEditFrm.txtPDEsection.Tag = e.Node.Parent.Name.ToString
                            ProductDetailEditFrm.txtPDEsubsection.Text = TextChild
                            ProductDetailEditFrm.txtPDEsubsection.Tag = nameChild
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub SelectSectionFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call getProSection()
    End Sub
End Class