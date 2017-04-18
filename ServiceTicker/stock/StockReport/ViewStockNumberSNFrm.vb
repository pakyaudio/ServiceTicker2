Imports MySql.Data.MySqlClient

Public Class ViewStockNumberSNFrm
    Friend l2 As Integer
    Friend r2 As Integer
    Friend Sub GetSNByCodepro(ByVal cp)
        Me.DataGridView1.Rows.Clear()
        Try
            If cp = "all" Then
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM product_serial LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Else
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM product_serial " _
                                      & "WHERE code_pro='" & cp & "' LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            End If
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    With Me.DataGridView1
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    End With
                End While
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            If cp = "all" Then
                cmd = New MySqlCommand("SELECT COUNT(code_pro) AS cid FROM product_serial;", ConnectionDB)
            Else
                cmd = New MySqlCommand("SELECT COUNT(code_pro) AS cid FROM product_serial WHERE code_pro='" & cp & "';", ConnectionDB)
            End If
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                l2 = Dr.Item("cid")
                r2 = Me.DataGridView1.Rows.Count
                Me.Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Else
                l2 = 0
            End If
        Catch ex As Exception
            l2 = 0
        End Try
    End Sub

    Private Sub codeproSelect2Next(ByVal cp)
        Try
            If cp = "all" Then
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM " _
                                    & "product_serial " _
                                    & "LIMIT " & Me.NumericUpDown1.Value & " OFFSET " & Me.DataGridView1.Rows.Count & ";", ConnectionDB)
            Else
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM " _
                                     & "product_serial WHERE code_pro='" & cp & "' " _
                                     & "LIMIT " & Me.NumericUpDown1.Value & " OFFSET " & Me.DataGridView1.Rows.Count & ";", ConnectionDB)
            End If

            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                ' Me.dgMSN.Rows.Clear()
                Dim r As Integer
                While Dr.Read()
                    With Me.DataGridView1
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    End With
                End While
            End If
            Label2.Text = Me.DataGridView1.Rows.Count.ToString("N0") & "/" & l2.ToString("N0")
            Me.DataGridView1.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ViewCheckStockSNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewCheckStockSNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If l2 > Me.NumericUpDown1.Value Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub
End Class