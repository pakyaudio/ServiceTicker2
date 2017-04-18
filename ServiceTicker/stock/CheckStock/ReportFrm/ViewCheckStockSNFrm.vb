Imports MySql.Data.MySqlClient

Public Class ViewCheckStockSNFrm

    Private Sub ViewCheckStockSNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewCheckStockSNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
    ''' <summary>
    ''' โหลด SN ที่เช็คสต็อกไม่หมด  Call LoadSNData(หมายเลขเช็คสต็อก, True) True=Clear Rows Form DataGridView
    ''' </summary>
    ''' <param name="csid"></param>
    ''' <param name="clearRow"></param>
    ''' <remarks></remarks>
    Friend Sub LoadSNData(ByVal csid As String, ByVal clearRow As Boolean)
        If clearRow = True Then
            Me.DataGridView1.Rows.Clear()
            strSQL = "SELECT c_stock_id,serial_pro,name_pro FROM check_stock_save WHERE c_stock_id='" & csid & "' LIMIT " & Me.NumericUpDown1.Value & ";"
        ElseIf clearRow = False Then
            strSQL = "SELECT c_stock_id,serial_pro,name_pro FROM check_stock_save WHERE c_stock_id='" & csid & "'" _
                & "LIMIT " & r2 & ", " & Me.NumericUpDown1.Value & ";"
        End If
        Try

            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                Dim r As Integer
                With Me.DataGridView1
                    While Dr.Read()
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Tag = Dr.Item("c_stock_id")
                        .Rows(r).Cells(1).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    End While
                End With
            End If
        Catch ex As Exception

        End Try
        If clearRow = True Then
            CountSN(csid)
        End If

    End Sub

    Friend Sub CountSN(ByVal csid As Object)
        Try
            cmd = New MySqlCommand("SELECT COUNT(c_stock_id) AS cid FROM check_stock_save WHERE c_stock_id='" & csid & "';", ConnectionDB)
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

    Friend l2 As Integer
    Friend r2 As Integer

    Private Sub codeproSelect2Next()
        Try
            Call LoadSNData(Me.DataGridView1.Rows(0).Cells(1).Tag, False)
            r2 = Me.DataGridView1.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Me.btnForward.Enabled = False
        Call codeproSelect2Next()
        Me.btnForward.Enabled = True
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If l2 > Me.NumericUpDown1.Value Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If Me.DataGridView1.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ต้องการพิมพ์รายการนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM check_stock_save_pro;", connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For r As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO check_stock_save_pro(no,serial_pro,name_pro)VALUES" _
                            & "(@no,@serial_pro,@name_pro)"
                        cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                        With cmdSQLite
                            .Parameters.AddWithValue("@no", Me.DataGridView1.Rows(r).Cells(0).Value)
                            .Parameters.AddWithValue("@serial_pro", Me.DataGridView1.Rows(r).Cells(1).Value)
                            .Parameters.AddWithValue("@name_pro", Me.DataGridView1.Rows(r).Cells(2).Value)
                            Call open_connectionSQLite()
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                If checkPrinter() = "A4" Then
                    ReportCheckStockAllProA4Frm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    ReportCheckStockAllProA5Frm.ShowDialog(Me)
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