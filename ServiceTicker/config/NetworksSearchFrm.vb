Imports System.DirectoryServices
Imports System.Collections.Specialized

Public Class NetworksSearchFrm

    Private Sub NetworksSearchFrm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim t As New Threading.Thread(AddressOf GetNetworkComputers)
        t.IsBackground = True
        t.Start()
    End Sub

    Private Sub NetworksSearchFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each form In My.Application.OpenForms
            If (form.name = MainFrm.Name) Then
                If form.Visible Then
                    Me.Dispose()
                    OnTopFrm()
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub NetworksSearchFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.ListView1.Items.Clear()
    End Sub

    Private Delegate Sub UpdateDelegate(ByVal s As String)
    Private Sub AddListBoxItem(ByVal s As String)
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(64, 64)
        imglist.Images.Add("computer", My.Resources.echipamente)
        Dim lsvparent As New ListViewItem
        lsvparent.Text = s
        lsvparent.ImageKey = "computer"
        ListView1.Items.Add(lsvparent)
    End Sub

    Private Sub GetNetworkComputers()
        Try
            Dim alWorkGroups As New ArrayList
            Dim de As New DirectoryEntry

            de.Path = "WinNT:"
            For Each d As DirectoryEntry In de.Children
                If d.SchemaClassName = "Domain" Then alWorkGroups.Add(d.Name)
                d.Dispose()
            Next

            For Each workgroup As String In alWorkGroups

                de.Path = "WinNT://" & workgroup
                For Each d As DirectoryEntry In de.Children

                    If d.SchemaClassName = "Computer" Then

                        Dim del As UpdateDelegate = AddressOf AddListBoxItem
                        Me.Invoke(del, d.Name)

                    End If
                    d.Dispose()
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                If Me.ListView1.FocusedItem.Text = SystemInformation.ComputerName Then
                    ConnectDBFrm.txtDBCservername.Text = "localhost"
                Else
                    ConnectDBFrm.txtDBCservername.Text = Me.ListView1.FocusedItem.Text
                End If
                Me.Close()
            End If
        End If
    End Sub
End Class