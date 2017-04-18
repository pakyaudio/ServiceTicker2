Imports System.Data.SQLite

Public Class BillingSelectPrintFrm

    Private Sub BillingSelectPrintFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub BillingSelectPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Try
            Me.dgDTshowAll.Rows.Clear()
            Dim asrow As Integer
            For r As Integer = 0 To DebtorFrm.dgDTshowAll.Rows.Count - 1
                asrow = Me.dgDTshowAll.Rows.Count
                Me.dgDTshowAll.Rows.Add()
                Me.dgDTshowAll.Rows(asrow).Cells(0).Value = True
                Me.dgDTshowAll.Rows(asrow).Cells(1).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(1).Value
                Me.dgDTshowAll.Rows(asrow).Cells(2).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(2).Value
                Me.dgDTshowAll.Rows(asrow).Cells(3).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(3).Value
                Me.dgDTshowAll.Rows(asrow).Cells(4).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(4).Value
                Me.dgDTshowAll.Rows(asrow).Cells(5).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(5).Value
                Me.dgDTshowAll.Rows(asrow).Cells(6).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(6).Value
                Me.dgDTshowAll.Rows(asrow).Cells(7).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(7).Value
                Me.dgDTshowAll.Rows(asrow).Cells(8).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(8).Value
                Me.dgDTshowAll.Rows(asrow).Cells(9).Value = DebtorFrm.dgDTshowAll.Rows(r).Cells(9).Value
            Next
            Call sumDG()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub sumDG()
        Dim sdg As Decimal = Nothing
        For ff As Integer = 0 To Me.dgDTshowAll.Rows.Count - 1
            If Me.dgDTshowAll.Rows(ff).Cells(0).Value = True Then
                sdg += Me.dgDTshowAll.Rows(ff).Cells(9).Value
            End If
        Next
        Me.txtSdg.Text = sdg.ToString("N2")
    End Sub


    Private Sub btnPrintBilling_Click(sender As Object, e As EventArgs) Handles btnPrintBilling.Click
        Try
            strSQLite = "DELETE FROM billing_print"
            cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For rf As Integer = 0 To Me.dgDTshowAll.Rows.Count - 1
            If Me.dgDTshowAll.Rows(rf).Cells(0).Value = True Then
                Try
                    strSQLite = "INSERT INTO billing_print(`sale_id`,`detail`,`customer_id`,`customer_name`,`datetime_save`,`total_all`,`cash`,`pledge`,`balance`)" _
                        & "VALUES(@sale_id,@detail,@customer_id,@customer_name,@datetime_save,@total_all,@cash,@pledge,@balance)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    With cmdSQLite
                        .Parameters.AddWithValue("@sale_id", Me.dgDTshowAll.Rows(rf).Cells(1).Value)
                        .Parameters.AddWithValue("@detail", Me.dgDTshowAll.Rows(rf).Cells(2).Value)
                        .Parameters.AddWithValue("@customer_id", Me.dgDTshowAll.Rows(rf).Cells(3).Value)
                        .Parameters.AddWithValue("@customer_name", Me.dgDTshowAll.Rows(rf).Cells(4).Value)
                        .Parameters.AddWithValue("@datetime_save", Me.dgDTshowAll.Rows(rf).Cells(5).Value)
                        .Parameters.AddWithValue("@total_all", Me.dgDTshowAll.Rows(rf).Cells(6).Value)
                        .Parameters.AddWithValue("@cash", Me.dgDTshowAll.Rows(rf).Cells(7).Value)
                        .Parameters.AddWithValue("@pledge", Me.dgDTshowAll.Rows(rf).Cells(8).Value)
                        .Parameters.AddWithValue("@balance", Me.dgDTshowAll.Rows(rf).Cells(9).Value)
                    End With
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        Next
        If checkPrinter() = "A4" Then
            BillingA4ReportFrm.ShowDialog(Me)
        ElseIf checkPrinter() = "A5" Then
            BillingA5ReportFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub dgDTshowAll_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgDTshowAll.CurrentCellDirtyStateChanged
        RemoveHandler dgDTshowAll.CurrentCellDirtyStateChanged,
           AddressOf dgDTshowAll_CurrentCellDirtyStateChanged

        If TypeOf dgDTshowAll.CurrentCell Is DataGridViewCheckBoxCell Then
            dgDTshowAll.EndEdit()
            Dim Checked As Boolean = CType(dgDTshowAll.CurrentCell.Value, Boolean)
            If Checked Then
                Call sumDG()
            Else
                Call sumDG()
            End If
        End If

        AddHandler dgDTshowAll.CurrentCellDirtyStateChanged,
            AddressOf dgDTshowAll_CurrentCellDirtyStateChanged
    End Sub

    Private Sub txtSdg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSdg.KeyPress
        e.Handled = True
    End Sub
End Class