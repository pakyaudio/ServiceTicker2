Imports MySql.Data.MySqlClient


Public Class ManagerSNFrm
    Friend l2 As Integer
    Friend r2 As Integer
#Region "Code"
    Friend Sub getProSection()

        Me.TreeView1.Nodes.Clear()
        Dim RootNodes As TreeNode = New TreeNode
        RootNodes.Name = "RootNodes"
        RootNodes.Text = "รายการสินค้า"
        RootNodes.Tag = "RootNodes"
        TreeView1.Nodes.Add(RootNodes)
        Try
            strSQL = "SELECT code_pro,name_pro FROM product ORDER BY name_pro ASC"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim mainNodes As TreeNode = New TreeNode
                mainNodes.Name = Dr.Item("code_pro")
                mainNodes.Text = Dr.Item("name_pro")
                mainNodes.Tag = "mainNodes"
                Me.TreeView1.Nodes(0).Nodes.Add(mainNodes)
            End While
            Me.TreeView1.ExpandAll()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Function GetNamPro(ByVal cpro) As String
        Try
            cmd = New MySqlCommand("SELECT name_pro FROM product WHERE code_pro='" & cpro & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Return Dr.Item("name_pro")
            Else
                Return "##ไม่พบข้อมูล##"
            End If
        Catch ex As Exception
            Return "##ไม่พบข้อมูล##"
        End Try
    End Function

    Private Sub GetSN()
        Me.dgMSN.Rows.Clear()
        Try
            cmd = New MySqlCommand("SELECT `id`,code_pro,serial_pro,name_pro,date_in FROM product_serial " _
                                   & "WHERE code_pro IN (SELECT code_pro FROM product) LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    r = Me.dgMSN.Rows.Count
                    Me.dgMSN.Rows.Add()
                    Me.dgMSN.Rows(r).Cells(0).ReadOnly = False
                    Me.dgMSN.Rows(r).Cells(0).Tag = Dr.Item("id")
                    Me.dgMSN.Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    Me.dgMSN.Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                    Me.dgMSN.Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    Me.dgMSN.Rows(r).Cells(4).Value = Dr.Item("date_in")
                End While
            End If

            Me.dgMSN.Refresh()
            l2 = CountSN(3, Nothing)
            r2 = Me.dgMSN.RowCount
            Label2.Text = r2.ToString("N") & "/" & l2.ToString("N")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

    End Sub

    Private Sub GetSNbyCodepro()
        Me.dgMSN.Rows.Clear()
        Try
            cmd = New MySqlCommand("SELECT id,code_pro,serial_pro,name_pro,date_in FROM " _
                                   & "product_serial WHERE code_pro='" & nameChild & "' LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    r = Me.dgMSN.Rows.Count
                    Me.dgMSN.Rows.Add()
                    Me.dgMSN.Rows(r).Cells(0).ReadOnly = False
                    Me.dgMSN.Rows(r).Cells(0).Tag = Dr.Item("id")
                    Me.dgMSN.Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    Me.dgMSN.Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                    Me.dgMSN.Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    Me.dgMSN.Rows(r).Cells(4).Value = Dr.Item("date_in")
                End While
            End If
        
            Me.dgMSN.Refresh()
            l2 = CountSN(2, nameChild)
            r2 = Me.dgMSN.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub


    ''' <summary>
    '''  นับจำนวน SN ที่มีอยู่ในฐานข้อมูล
    ''' </summary>
    ''' <param name="selectCode">1 = นับที่ไม่มีหมวดหมู่, 2 = นับที่มีหมวดหมู่</param>
    ''' <param name="keyword">code_pro ที่จะนับจำนวน</param>
    ''' <returns>As Integer</returns>
    ''' <remarks></remarks>
    Function CountSN(ByVal selectCode As Object, ByVal keyword As Object) As Object
        If selectCode = 1 Then
            codepro = selectCode
            Try
                cmd = New MySqlCommand("SELECT COUNT(id) AS cid FROM product_serial WHERE code_pro NOT IN (SELECT code_pro FROM product)", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Return Dr.Item("cid")
                Else
                    Return 0
                End If
                Exit Function
            Catch ex As Exception
                Return 0
            End Try
        ElseIf selectCode = 2 Then
            codepro = selectCode
            Try
                cmd = New MySqlCommand("SELECT COUNT(id) AS cid FROM product_serial WHERE code_pro='" & keyword & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Return Dr.Item("cid")
                Else
                    Return 0
                End If
                Exit Function
            Catch ex As Exception
                Return 0
            End Try
        ElseIf selectCode = 3 Then
            codepro = selectCode
            Try
                cmd = New MySqlCommand("SELECT COUNT(id) AS cid FROM product_serial WHERE code_pro IN (SELECT code_pro FROM product);", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Return Dr.Item("cid")
                Else
                    Return 0
                End If
                Exit Function
            Catch ex As Exception
                Return 0
            End Try
        End If
        Return 0
    End Function

    Dim codepro As Integer
    Private Sub LoadDataNoCode_pro()
        Me.dgMSN.Rows.Clear()
        Try
            cmd = New MySqlCommand("SELECT `id`,code_pro,serial_pro,name_pro,date_in " _
                                   & "FROM product_serial " _
                                  & "WHERE code_pro NOT IN (SELECT code_pro FROM product) LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    r = Me.dgMSN.Rows.Count
                    Me.dgMSN.Rows.Add()
                    Me.dgMSN.Rows(r).Cells(0).Tag = Dr.Item("id")
                    Me.dgMSN.Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    Me.dgMSN.Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                    Me.dgMSN.Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    Me.dgMSN.Rows(r).Cells(4).Value = Dr.Item("date_in")
                End While
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        l2 = CountSN(1, Nothing)
        r2 = Me.dgMSN.RowCount
        Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
        MessageBox.Show(Me, "ตรวจสอบ SN ที่ไม่มีหมวดหมู่แล้ว", "เสร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub codeproSelect1Next()
        Try
            cmd = New MySqlCommand("SELECT `id`,code_pro,serial_pro,name_pro,date_in " _
                                   & "FROM product_serial " _
                                  & "WHERE code_pro NOT IN (SELECT code_pro FROM product) " _
                                  & "AND ID > '" & Me.dgMSN.Rows(Me.dgMSN.RowCount - 1).Cells(0).Tag & "' " _
                                  & "LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                '    Me.dgMSN.Rows.Clear()
                Dim r As Integer
                While Dr.Read()
                    r = Me.dgMSN.Rows.Count
                    Me.dgMSN.Rows.Add()
                    Me.dgMSN.Rows(r).Cells(0).Tag = Dr.Item("id")
                    Me.dgMSN.Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    Me.dgMSN.Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                    Me.dgMSN.Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    Me.dgMSN.Rows(r).Cells(4).Value = Dr.Item("date_in")
                End While
            End If
            r2 = Me.dgMSN.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub codeproSelect2Next()
        Try
            cmd = New MySqlCommand("SELECT id,code_pro,serial_pro,name_pro,date_in FROM " _
                                   & "product_serial WHERE code_pro='" & nameChild & "' " _
                                   & "AND `id` > '" & Me.dgMSN.Rows(Me.dgMSN.RowCount - 1).Cells(0).Tag & "' " _
                                   & "LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                ' Me.dgMSN.Rows.Clear()
                Dim r As Integer
                While Dr.Read()
                    r = Me.dgMSN.Rows.Count
                    Me.dgMSN.Rows.Add()
                    Me.dgMSN.Rows(r).Cells(0).ReadOnly = False
                    Me.dgMSN.Rows(r).Cells(0).Tag = Dr.Item("id")
                    Me.dgMSN.Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    Me.dgMSN.Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                    Me.dgMSN.Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    Me.dgMSN.Rows(r).Cells(4).Value = Dr.Item("date_in")
                End While
            End If
            r2 = Me.dgMSN.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Me.dgMSN.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub codeproSelect3Next()
        Try
            cmd = New MySqlCommand("SELECT `id`,code_pro,serial_pro,name_pro,date_in FROM product_serial " _
                                   & "WHERE code_pro IN (SELECT code_pro FROM product) " _
                                   & "AND `id` > '" & Me.dgMSN.Rows(Me.dgMSN.RowCount - 1).Cells(0).Tag & "' " _
                                   & "LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                'Me.dgMSN.Rows.Clear()
                Dim r As Integer
                While Dr.Read()
                    r = Me.dgMSN.Rows.Count
                    Me.dgMSN.Rows.Add()
                    Me.dgMSN.Rows(r).Cells(0).ReadOnly = False
                    Me.dgMSN.Rows(r).Cells(0).Tag = Dr.Item("id")
                    Me.dgMSN.Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    Me.dgMSN.Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                    Me.dgMSN.Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    Me.dgMSN.Rows(r).Cells(4).Value = Dr.Item("date_in")
                End While
            End If
            r2 = Me.dgMSN.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Me.dgMSN.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region
 
    Private m_OldSelectNode As TreeNode

    Private Sub TreeView1_MouseUp(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseUp
        ' Show menu only if Right Mouse button is clicked
        If e.Button = MouseButtons.Left Then
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
                        Call GetSNbyCodepro()
                    Case "RootNodes"
                        Call GetSN()
                    Case "childNodes"

                End Select
                m_OldSelectNode = Nothing
            End If
        End If
    End Sub

    Private Sub btndontBysn_Click(sender As Object, e As EventArgs) Handles btndontBysn.Click
        Call LoadDataNoCode_pro()
    End Sub

    Friend nameChild As String
    Friend TextChild As String
    Friend tagChild As String
    Friend CountNodes As Boolean

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

    Private Sub cbox()
        With dgMSN.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            '.Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        'col = New DataGridViewCheckBoxColumn()

        'col.Name = "Checkbox"
        ''col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.dgMSN.Columns.Add(col)
        chkbox = New CheckBox()
        Dim rect As Rectangle = Me.dgMSN.GetCellDisplayRectangle(0, -1, True)
        chkbox.BackColor = Color.White
        chkbox.Size = New Size(18, 18)
        rect.X = rect.Location.X + (rect.Width / 4)

        chkbox.Location = rect.Location
        AddHandler chkbox.CheckedChanged, AddressOf chkBox_CheckedChanged
        Me.dgMSN.Controls.Add(chkbox)
    End Sub

    Private Sub ManagerSNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ManagerSNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call cbox()
    End Sub

    Private Sub ManagerSNFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call getProSection()
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If l2 > Me.NumericUpDown1.Value Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If codepro = 1 Then
            Me.btnForward.Enabled = False
            Call codeproSelect1Next()
            Me.btnForward.Enabled = True
        ElseIf codepro = 2 Then
            Me.btnForward.Enabled = False
            Call codeproSelect2Next()
            Me.btnForward.Enabled = True
        ElseIf codepro = 3 Then
            Me.btnForward.Enabled = False
            Call codeproSelect3Next()
            Me.btnForward.Enabled = True
        End If
    End Sub

    Private Sub btnMoveCodePro_Click(sender As Object, e As EventArgs) Handles btnMoveCodePro.Click
        SelectCodeProFrm.ShowDialog(Me)
    End Sub

    Private Sub btnRename_proSN_Click(sender As Object, e As EventArgs) Handles btnRename_proSN.Click
        SelectNameProFrm.ShowDialog(Me)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private chkBox As CheckBox
 
    Private Sub chkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        For i As Integer = 0 To Me.dgMSN.RowCount - 1
            Me.dgMSN(0, i).Value = Me.chkBox.Checked
        Next
        Me.dgMSN.EndEdit()
    End Sub



    Private Sub dgMSN_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgMSN.CellValueChanged
        Dim ck As Integer
        For i As Integer = 0 To Me.dgMSN.RowCount - 1
            If Me.dgMSN(0, i).Value = True Then
                ck = ck + 1
            End If
        Next
        Enabletbn(ck)
    End Sub

    Private Sub Enabletbn(ck)
        If ck = 0 Then
            Me.btnMoveCodePro.Enabled = False
            Me.btnRename_proSN.Enabled = False
        Else
            Me.btnMoveCodePro.Enabled = True
            Me.btnRename_proSN.Enabled = True
        End If
    End Sub

    Private Sub dgMSN_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgMSN.CurrentCellDirtyStateChanged
        If dgMSN.IsCurrentCellDirty Then
            dgMSN.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class