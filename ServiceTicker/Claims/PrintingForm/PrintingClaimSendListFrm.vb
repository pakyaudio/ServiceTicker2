Public Class PrintingClaimSendListFrm

    Private Sub PrintingClaimSendListFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub PrintingClaimSendListFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetClaimsList()
    End Sub

#Region "CodePro"
    Private Sub GetClaimsList()
        Me.dgClaimsList.Rows.Clear()
        Try
            strSQL = "SELECT DISTINCT claims_lot AS CL FROM claims_send WHERE claims_send_status='ส่งเคลม'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgClaimsList
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = "ส่งเคลม"
                    .Rows(r).Cells(2).Value = Dr.Item("cl")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For row As Integer = 0 To Me.dgClaimsList.Rows.Count - 1
            Try
                strSQL = "SELECT claims_company FROM claims_send WHERE claims_lot='" & Me.dgClaimsList.Rows(row).Cells(2).Value & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    With Me.dgClaimsList
                        .Rows(row).Cells(0).Value = Dr.Item("claims_company")
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "SELECT COUNT(claims_lot) AS CCT FROM claims_send WHERE claims_lot='" & Me.dgClaimsList.Rows(row).Cells(2).Value & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    With Me.dgClaimsList
                        .Rows(row).Cells(3).Value = Dr.Item("CCT")
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub GetClaimsPro(ByVal claimslot As String)
        Me.dgClaimsProList.Rows.Clear()
        Me.txtClaims_company.Clear()
        Me.txtClaims_lot.Clear()
        Try
            strSQL = "SELECT claims_id FROM claims_send WHERE claims_lot='" & claimslot & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgClaimsProList
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("claims_id")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For row As Integer = 0 To Me.dgClaimsProList.Rows.Count - 1
            Try
                strSQL = "SELECT customer_id,serial_pro,code_pro,bar_code,name_pro,unit,symptom," _
                    & "accressory FROM claims WHERE claims_id='" & Me.dgClaimsProList.Rows(row).Cells(0).Value & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    With Me.dgClaimsProList
                        .Rows(row).Cells(1).Value = Dr.Item("customer_id")
                        .Rows(row).Cells(3).Value = Dr.Item("serial_pro")
                        .Rows(row).Cells(4).Value = Dr.Item("code_pro")
                        .Rows(row).Cells(5).Value = Dr.Item("bar_code")
                        .Rows(row).Cells(6).Value = Dr.Item("name_pro")
                        .Rows(row).Cells(7).Value = Dr.Item("unit")
                        .Rows(row).Cells(8).Value = Dr.Item("symptom")
                        .Rows(row).Cells(9).Value = Dr.Item("accressory")
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgClaimsProList.Rows(row).Cells(1).Value & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    While Dr.Read()
                        With Me.dgClaimsProList
                            .Rows(row).Cells(2).Value = Dr.Item("customer_name")
                        End With
                    End While
                Else
                    With Me.dgClaimsProList
                        .Rows(row).Cells(2).Value = "##ไม่พบข้อมูล##"
                    End With
                End If
                Me.txtClaims_company.Text = Me.dgClaimsList.CurrentRow.Cells(0).Value
                Me.txtClaims_lot.Text = Me.dgClaimsList.CurrentRow.Cells(2).Value
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub Enablebtu()
        If Me.dgClaimsProList.Rows.Count <> 0 Then
            Me.btnPrint.Enabled = True
        Else
            Me.btnPrint.Enabled = False
            Me.txtClaims_company.Clear()
            Me.txtClaims_lot.Clear()
        End If
    End Sub

    Private Sub Printing()
        'del
        Try
            cmdSQLite = New SQLite.SQLiteCommand("DELETE FROM claims_list", connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        For r As Integer = 0 To Me.dgClaimsProList.Rows.Count - 1
            Try
                strSQLite = "INSERT INTO claims_list(claims_id,customer_id,customer_name,serial_pro,code_pro,bar_code,name_pro,unit,symptom,accessory)" _
                    & "VALUES(@claims_id,@customer_id,@customer_name,@serial_pro,@code_pro,@bar_code,@name_pro,@unit,@symptom,@accessory)"
                cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                cmdSQLite.Parameters.AddWithValue("@claims_id", Me.dgClaimsProList.Rows(r).Cells(0).Value)
                cmdSQLite.Parameters.AddWithValue("@customer_id", Me.dgClaimsProList.Rows(r).Cells(1).Value)
                cmdSQLite.Parameters.AddWithValue("@customer_name", Me.dgClaimsProList.Rows(r).Cells(2).Value)
                cmdSQLite.Parameters.AddWithValue("@serial_pro", Me.dgClaimsProList.Rows(r).Cells(3).Value)
                cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgClaimsProList.Rows(r).Cells(4).Value)
                cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgClaimsProList.Rows(r).Cells(5).Value)
                cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgClaimsProList.Rows(r).Cells(6).Value)
                cmdSQLite.Parameters.AddWithValue("@unit", Me.dgClaimsProList.Rows(r).Cells(7).Value)
                cmdSQLite.Parameters.AddWithValue("@symptom", Me.dgClaimsProList.Rows(r).Cells(8).Value)
                cmdSQLite.Parameters.AddWithValue("@accessory", Me.dgClaimsProList.Rows(r).Cells(9).Value)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        If checkPrinter() = "A4" Then
            ReClaimsListA4PrintFrm.ShowDialog(Me)
        ElseIf checkPrinter() = "A5" Then
            ReClaimsListA5PrintFrm.ShowDialog(Me)
        End If
    End Sub
#End Region

    Private Sub dgClaimsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClaimsList.CellClick
        If Me.dgClaimsList.Rows.Count <> 0 Then
            Call GetClaimsPro(Me.dgClaimsList.CurrentRow.Cells(2).Value)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.dgClaimsProList.Rows.Clear()
        Call GetClaimsList()
    End Sub

    Private Sub dgClaimsProList_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgClaimsProList.RowStateChanged
        Call Enablebtu()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call Printing()
    End Sub

    Private Sub txtClaims_company_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClaims_company.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtClaims_lot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClaims_lot.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/claimsprint/printingclaimsendlistfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class