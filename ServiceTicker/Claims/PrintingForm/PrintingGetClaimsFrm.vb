Public Class PrintingGetClaimsFrm

    Private Sub PrintingGetClaimsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub PrintingGetClaimsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call lodadataClaims()
    End Sub

    Private Sub lodadataClaims()
        Try
            strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,unit,symptom,datetime_save FROM claims"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    With Me.dgPGC
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(7).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(8).Value = Dr.Item("unit")
                        .Rows(r).Cells(9).Value = Dr.Item("symptom")
                        .Rows(r).Cells(10).Value = Dr.Item("datetime_save")
                    End With
                End While
            Else
                MessageBox.Show(Me, "ไม่พบข้อมูลสินค้าเคลม", "ไม่มีข้อมูลการเคลม", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For s As Integer = 0 To Me.dgPGC.Rows.Count - 1
            Try
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgPGC.Rows(s).Cells(2).Value & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.dgPGC.Rows(s).Cells(3).Value = Dr.Item("customer_name")
                Else
                    Me.dgPGC.Rows(s).Cells(3).Value = "###ไม่พบข้อมูล###"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub btnPrinting_Click(sender As Object, e As EventArgs) Handles btnPrinting.Click
        If Me.dgPGC.Rows.Count <> 0 Then
            Try
                cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM reclaims", connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            For s = 0 To Me.dgPGC.Rows.Count - 1
                If Me.dgPGC.Rows(s).Cells(0).Value = True Then
                    Try
                        strSQLite = "INSERT INTO reclaims(claims_id,customer_id,customer_name,`sn`,code_pro,barcode,name_pro,unit,datetime_save,symptom)" _
                            & "VALUES(@claims_id,@customer_id,@customer_name,@sn,@code_pro,@barcode,@name_pro,@unit,@datetime_save,@symptom)"
                        cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                        cmdSQLite.Parameters.AddWithValue("@claims_id", Me.dgPGC.Rows(s).Cells(1).Value)
                        cmdSQLite.Parameters.AddWithValue("@customer_id", Me.dgPGC.Rows(s).Cells(2).Value)
                        cmdSQLite.Parameters.AddWithValue("@customer_name", Me.dgPGC.Rows(s).Cells(3).Value)
                        cmdSQLite.Parameters.AddWithValue("@sn", Me.dgPGC.Rows(s).Cells(4).Value)
                        cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgPGC.Rows(s).Cells(5).Value)
                        cmdSQLite.Parameters.AddWithValue("@barcode", Me.dgPGC.Rows(s).Cells(6).Value)
                        cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgPGC.Rows(s).Cells(7).Value)
                        cmdSQLite.Parameters.AddWithValue("@unit", Me.dgPGC.Rows(s).Cells(8).Value)
                        cmdSQLite.Parameters.AddWithValue("@symptom", Me.dgPGC.Rows(s).Cells(9).Value)
                        cmdSQLite.Parameters.AddWithValue("@datetime_save", Me.dgPGC.Rows(s).Cells(10).Value)
                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            Next

            If checkPrinter() = "A4" Then
                ReclaimssendPrintA4Frm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReclaimssendPrintA5Frm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub dgPGC_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPGC.CellMouseClick
        Try
            If Me.dgPGC.Rows.Count <> 0 Then
                If e.Button = MouseButtons.Right Then
                    Me.dgPGC.Rows(e.RowIndex).Selected = True
                    Me.dgPGC.CurrentCell = Me.dgPGC.Rows(e.RowIndex).Cells(1)
                    Me.PrintProCoverContextMenu.Show(dgPGC, e.Location)
                    Me.PrintProCoverContextMenu.Show(Cursor.Position)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintProCoverToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintProCoverToolStripMenu.Click
        If checkPrinter() = "A4" Then
            ClaimsCoverPrintA4Frm.ShowDialog(Me)
        ElseIf checkPrinter() = "A5" Then
            ClaimsCoverPrintA5Frm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/claimsprint/printinggetclaimsfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class