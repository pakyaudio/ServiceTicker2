Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CheckStockReportFrm

    Private Sub CheckStockReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckStockReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
    End Sub

    Private Sub searchCheckStock()
        Try
            Me.dgCSR.Rows.Clear()
            strSQL = "SELECT c_stock_id,datetime_save,t_stock,dontcheck,checked,datetime_last FROM check_stock_id WHERE datetime_save LIKE '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM", CultureInfo.CreateSpecificCulture("en-US")) & "%'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                With Me.dgCSR
                    Dim r As Integer
                    While Dr.Read
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Tag = Dr.Item("c_stock_id")
                        .Rows(r).Cells(1).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(2).Value = Dr.Item("t_stock")
                        .Rows(r).Cells(3).Value = Dr.Item("dontcheck")
                        .Rows(r).Cells(4).Value = Dr.Item("checked")
                        .Rows(r).Cells(5).Value = Dr.Item("datetime_last")
                    End While
                End With
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub DateTimePicker1_FormatChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.FormatChanged
        DateTimePicker1.CustomFormat = "MMMM yyyy"
    End Sub

    Private Sub btnCSRsearch_Click(sender As Object, e As EventArgs) Handles btnCSRsearch.Click
        Call searchCheckStock()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.dgCSR.SelectedRows.Count <> 0 Then
            Call ViewCheckStockSNFrm.LoadSNData(Me.dgCSR.CurrentRow.Cells(1).Tag, True)
            ViewCheckStockSNFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.dgCSR.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการพิมพ์รายการนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM check_stock_save;", connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For r As Integer = 0 To Me.dgCSR.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO check_stock_save(no,set_stock,totalsn,dont_check,checked,last_edit)VALUES" _
                            & "(@no,@set_stock,@totalsn,@dont_check,@checked,@last_edit)"
                        cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                        With cmdSQLite
                            .Parameters.AddWithValue("@no", Me.dgCSR.Rows(r).Cells(0).Value)
                            .Parameters.AddWithValue("@set_stock", Me.dgCSR.Rows(r).Cells(1).Value)
                            .Parameters.AddWithValue("@totalsn", Me.dgCSR.Rows(r).Cells(2).Value)
                            .Parameters.AddWithValue("@dont_check", Me.dgCSR.Rows(r).Cells(3).Value)
                            .Parameters.AddWithValue("@checked", Me.dgCSR.Rows(r).Cells(4).Value)
                            .Parameters.AddWithValue("@last_edit", Me.dgCSR.Rows(r).Cells(5).Value)
                            Call open_connectionSQLite()
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                If checkPrinter() = "A4" Then
                    ReportCheckStockAllA4Frm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    ReportCheckStockAllA5Frm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub dgCSR_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgCSR.RowStateChanged
        If Me.dgCSR.Rows.Count <> 0 Then
            Me.btnPrint.Enabled = True
        Else
            Me.btnPrint.Enabled = False
        End If
        If Me.dgCSR.SelectedRows.Count <> 0 Then
            Me.Button1.Enabled = True
        Else
            Me.Button1.Enabled = False
        End If

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/stock/stockreport/checkstockreportfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class