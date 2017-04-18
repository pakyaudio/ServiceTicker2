Imports MySql.Data.MySqlClient

Public Class ViewCheckStockSNCheckedFrm

    Private Sub GetProduct()
        Me.cbbProduct.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT code_pro,name_pro FROM product " _
                                   & "ORDER BY name_pro ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.cbbProduct.DisplayMember = "Name"
                Me.cbbProduct.ValueMember = "ID"

                dt.Columns.Add("Name", GetType(String))
                dt.Columns.Add("ID", GetType(String))
                dt.Rows.Add("แสดงทั้งหมด", "all")
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("name_pro"), Dr.Item("code_pro"))
                End While
                Me.cbbProduct.DataSource = dt
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend l2 As Integer
    Friend r2 As Integer
    Private Sub GetSNByCodepro(ByVal cp)
        Me.DataGridView1.Rows.Clear()
        Try
            If cp = "all" Then
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM check_stock_cache LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Else
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM check_stock_cache " _
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
                cmd = New MySqlCommand("SELECT COUNT(code_pro) AS cid FROM check_stock_cache;", ConnectionDB)
            Else
                cmd = New MySqlCommand("SELECT COUNT(code_pro) AS cid FROM check_stock_cache WHERE code_pro='" & cp & "';", ConnectionDB)
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
                                    & "check_stock_cache " _
                                    & "LIMIT " & Me.NumericUpDown1.Value & " OFFSET " & Me.DataGridView1.Rows.Count & ";", ConnectionDB)
            Else
                cmd = New MySqlCommand("SELECT serial_pro,name_pro FROM " _
                                     & "check_stock_cache WHERE code_pro='" & cp & "' " _
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
        Call GetProduct()
    End Sub

    Private Sub cbbProduct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbProduct.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbProduct.SelectedIndexChanged
        Call GetSNByCodepro(Me.cbbProduct.SelectedValue.ToString)
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If l2 > Me.NumericUpDown1.Value Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Call codeproSelect2Next(Me.cbbProduct.SelectedValue.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.DataGridView1.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการพิมพ์รายการนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    strSQLite = "DELETE FROM check_stock_cache;"
                    cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For r As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO check_stock_cache(no,serial_pro,name_pro)VALUES(@no,@serial_pro,@name_pro)"
                        cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                        cmdSQLite.Parameters.AddWithValue("@no", Me.DataGridView1.Rows(r).Cells(0).Value)
                        cmdSQLite.Parameters.AddWithValue("@serial_pro", Me.DataGridView1.Rows(r).Cells(1).Value)
                        cmdSQLite.Parameters.AddWithValue("@name_pro", Me.DataGridView1.Rows(r).Cells(2).Value)
                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                If checkPrinter() = "A4" Then
                    CheckStockCheckedA4ReportPrintFrm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    CheckStockCheckedA5ReportPrintFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub
End Class