Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ClaimsImportProFrm
    Friend Sub getDataClaims()
        Me.dgCIP.Rows.Clear()
        Try
            strSQL = "SELECT claims_id,customer_id,code_pro,bar_code,name_pro,symptom,accressory FROM claims WHERE `status`='" & "ทดสอบแล้ว" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgCIP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(6).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(7).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(8).Value = Dr.Item("symptom")
                    .Rows(r).Cells(9).Value = Dr.Item("accressory")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For i As Integer = 0 To Me.dgCIP.Rows.Count - 1
            Try
                Me.dgCIP.Rows(i).Cells.Item(0).Value = i + 1
                strSQL = "SELECT old_sn,new_sn,test_results FROM claims_test_results WHERE claims_id='" & Me.dgCIP.Rows(i).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgCIP
                    If Dr.HasRows Then
                        .Rows(i).Cells(3).Value = Dr.GetString("old_sn")
                        .Rows(i).Cells(4).Value = Dr.GetString("new_sn")
                        If Dr.GetString("test_results") = "past" Then
                            .Rows(i).Cells(5).Value = "ผ่าน"
                        ElseIf Dr.GetString("test_results") = "fail" Then
                            .Rows(i).Cells(5).Value = "ไม่ผ่าน"
                        End If
                    Else
                        .Rows(i).Cells(5).Value = "##ไม่พบข้อมูล##"
                    End If
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub ClaimsImportProFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsImportProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub ClaimsImportProFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call getDataClaims()
    End Sub

    Private Function GetcustomerName(cusid) As String
        Try
            cmd = New MySqlCommand("SELECT customer_name FROM customer WHERE customer_id='" & cusid & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Return Dr.Item("customer_name")
        Catch ex As Exception
            Return "## ไม่พบข้อมู ล##"
        End Try
    End Function

    Private Sub txtCIPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCIPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                For i As Integer = 0 To dgCIP.RowCount - 1
                    If Me.dgCIP.Rows(i).Cells(4).Value = Me.txtCIPsearchSN.Text Then
                        Me.dgCIP.Rows(i).Selected = True
                        If Me.dgCIP.Rows(i).Cells(2).Value = "สินค้าจากสต็อก" Then
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows.Clear()
                            Dim r As Integer
                            r = ClaimsImportProMiniMEFrm.dgCIPme.RowCount
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows.Add()
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(0).Value = r + 1
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(1).Value = Me.dgCIP.Rows(i).Cells(1).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(2).Value = Me.dgCIP.Rows(i).Cells(2).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(3).Value = "-"
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(4).Value = Me.dgCIP.Rows(i).Cells(3).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(5).Value = Me.dgCIP.Rows(i).Cells(4).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(6).Value = Me.dgCIP.Rows(i).Cells(5).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(7).Value = Me.dgCIP.Rows(i).Cells(6).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(8).Value = Me.dgCIP.Rows(i).Cells(7).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(9).Value = Me.dgCIP.Rows(i).Cells(8).Value
                            ClaimsImportProMiniMEFrm.dgCIPme.Rows(r).Cells(10).Value = Me.dgCIP.Rows(i).Cells(9).Value
                            If Me.dgCIP.Rows(i).Cells(5).Value = "ผ่าน" Then
                                ClaimsImportProMiniMEFrm.rbCIPreturnStockMe.Checked = True
                            ElseIf Me.dgCIP.Rows(i).Cells(5).Value = "ไม่ผ่าน" Then
                                ClaimsImportProMiniMEFrm.rbCIPreturnClaimsMe.Checked = True
                            End If
                            ClaimsImportProMiniMEFrm.ShowDialog(Me)
                            Exit For
                        Else
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows.Clear()
                            Dim r As Integer
                            r = ClaimsImportProMiniMEFrm.dgCIPme.RowCount
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows.Add()
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(0).Value = r + 1
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(1).Value = Me.dgCIP.Rows(i).Cells(1).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(2).Value = Me.dgCIP.Rows(i).Cells(2).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(3).Value = GetcustomerName(Me.dgCIP.Rows(i).Cells(2).Value)
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(4).Value = Me.dgCIP.Rows(i).Cells(3).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(5).Value = Me.dgCIP.Rows(i).Cells(4).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(6).Value = Me.dgCIP.Rows(i).Cells(5).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(7).Value = Me.dgCIP.Rows(i).Cells(6).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(8).Value = Me.dgCIP.Rows(i).Cells(7).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(9).Value = Me.dgCIP.Rows(i).Cells(8).Value
                            ClaimsImportProMiniCUSFrm.dgCIPcus.Rows(r).Cells(10).Value = Me.dgCIP.Rows(i).Cells(9).Value
                            If Me.dgCIP.Rows(i).Cells(5).Value = "ผ่าน" Then
                                ClaimsImportProMiniCUSFrm.rbCIPreturnCus.Checked = True
                            ElseIf Me.dgCIP.Rows(i).Cells(5).Value = "ไม่ผ่าน" Then
                                ClaimsImportProMiniCUSFrm.rbCIPreturnClaimsCus.Checked = True
                            End If
                            ClaimsImportProMiniCUSFrm.ShowDialog(Me)
                            Exit For
                        End If
                    End If
                Next
            Catch ex As Exception
                Exit Sub
            End Try
            Me.txtCIPsearchSN.Clear()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/managerclaimssendout/claimsimportprofrm")
        Catch ex As Exception

        End Try
    End Sub
End Class