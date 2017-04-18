Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class AccessLavelFrm
#Region "code"
    Friend Sub getProSection()
        For Each TView As TreeNode In TreeView1.Nodes
            Try
                strSQL = "SELECT id,zone FROM access_lavel WHERE menu='" & TView.Tag & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    Dim mainNodes As TreeNode = New TreeNode
                    mainNodes.Name = Dr.Item("id")
                    mainNodes.Text = Dr.Item("zone")
                    mainNodes.Tag = "mainNodes"
                    Me.TreeView1.Nodes(TView.Index).Nodes.Add(mainNodes)
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

    End Sub
#End Region

    Private Sub AccessLavelFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub AccessLavelFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call getProSection()
    End Sub

    Friend nameChild As String
    Friend TextChild As String
    Friend tagChild As String

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If (e.Node IsNot Nothing) Then
            If (e.Node.GetType() Is GetType(TreeNode)) Then
                TextChild = e.Node.Text
                tagChild = e.Node.Tag
                nameChild = e.Node.Name
            End If
        End If
        If tagChild = "mainNodes" Then
            Try
                strSQL = "SELECT access,leval FROM access_lavel WHERE id='" & nameChild & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows = True Then
                    Dr.Read()
                    Dim lavel As Integer = Dr.Item("leval")
                    Dim laveltxt As String = String.Empty
                    If lavel = 1 Then
                        laveltxt = "ผู้ใช้งานทั่วไป"
                    ElseIf lavel = 2 Then
                        laveltxt = "หัวหน้า"
                    ElseIf lavel = 3 Then
                        laveltxt = "ผู้ดูแลระบบ"
                    End If
                    Dim lg As Integer = Dr.Item("access")
                    Dim lgtxt As String = String.Empty
                    If lg = 0 Then
                        lgtxt = "ไม่ต้องยืนยันตัวตนก่อนเข้าใช้งาน"
                    ElseIf lg = 1 Then
                        lgtxt = "ยืนยันตัวตนก่อนเข้าใช้งาน"
                    End If
                    Me.lblShowAccess.ForeColor = Color.Red
                    Me.lblShowAccess.Text = "การเข้าใช้งาน : " & lgtxt & " , ระดับสิทธิ์ : " & laveltxt
                Else
                    Me.lblShowAccess.Text = ""
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Else
            Me.lblShowAccess.Text = ""
        End If
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If tagChild = "mainNodes" Then
                AccessLavelEditFrm.GetAccess(nameChild)
                AccessLavelEditFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub lblShowAccess_ForeColorChanged(sender As Object, e As EventArgs) Handles lblShowAccess.ForeColorChanged
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.lblShowAccess.ForeColor = Color.Red Then
            Me.lblShowAccess.ForeColor = Color.Black
            Me.Timer1.Stop()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/appconfig/accesslavel")
        Catch ex As Exception

        End Try
    End Sub
End Class