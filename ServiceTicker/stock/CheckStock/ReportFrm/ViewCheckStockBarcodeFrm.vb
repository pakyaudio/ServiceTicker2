Public Class ViewCheckStockBarcodeFrm

    Private Sub ViewCheckStockBarcodeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Friend Sub GetDataCheckStockBarcode(ByVal csbcid As String)
        Try
            Me.DataGridView1.Rows.Clear()
            strSQL = "SELECT code_pro,bar_code,name_pro,count_num,count,datetime_save FROM check_stock_bc_save WHERE csbc_id='" & csbcid & "';"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                Dim r As Integer
                With Me.DataGridView1
                    While Dr.Read()
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("count_num")
                        .Rows(r).Cells(4).Value = Dr.Item("count")
                        .Rows(r).Cells(5).Value = Dr.Item("datetime_save")
                    End While
                End With
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If Me.DataGridView1.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการพิมพ์รายการนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM check_stock_barcode_save_pro;", connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For r As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO check_stock_barcode_save_pro(code_pro,bar_code,name_pro,count_num,count,datetime_save)VALUES" _
                            & "(@code_pro,@bar_code,@name_pro,@count_num,@count,@datetime_save)"
                        cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                        With cmdSQLite
                            .Parameters.AddWithValue("@code_pro", Me.DataGridView1.Rows(r).Cells(0).Value)
                            .Parameters.AddWithValue("@bar_code", Me.DataGridView1.Rows(r).Cells(1).Value)
                            .Parameters.AddWithValue("@name_pro", Me.DataGridView1.Rows(r).Cells(2).Value)
                            .Parameters.AddWithValue("@count_num", Me.DataGridView1.Rows(r).Cells(3).Value)
                            .Parameters.AddWithValue("@count", Me.DataGridView1.Rows(r).Cells(4).Value)
                            .Parameters.AddWithValue("@datetime_save", Me.DataGridView1.Rows(r).Cells(5).Value)
                            Call open_connectionSQLite()
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                If checkPrinter() = "A4" Then
                    ReportCheckStockBarcodeProA4Frm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    ReportCheckStockBarcodeProA5Frm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        If Me.DataGridView1.Rows.Count <> 0 Then
            Me.btnprint.Enabled = True
        Else
            Me.btnprint.Enabled = False
        End If
    End Sub
End Class