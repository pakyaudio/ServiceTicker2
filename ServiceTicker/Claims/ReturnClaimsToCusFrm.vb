Imports MySql.Data.MySqlClient

Public Class ReturnClaimsToCusFrm

    Friend Sub getdataClaims(ByVal strsqlSelect As Integer, ByVal Searchtxt As String)
        Try
            Me.dgRCTC.Rows.Clear()
            If strsqlSelect = 100 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,datetime_save FROM claims WHERE status='รอส่งคืน'"
            ElseIf strsqlSelect = 200 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,datetime_save FROM claims WHERE "
                Dim strKeyWord As String = Searchtxt
                If strKeyWord <> "" Then
                    strSQL = strSQL & "serial_pro like '%" & strKeyWord & "%';"
                End If
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgRCTC
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("datetime_save")
                    End With
                End While
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For sum As Integer = 0 To Me.dgRCTC.Rows.Count - 1
                Me.dgRCTC.Rows(sum).Cells(0).Value = sum + 1
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgRCTC.Rows(sum).Cells(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgRCTC
                    If Dr.HasRows Then
                        .Rows(sum).Cells(3).Value = Dr.Item("customer_name")
                    Else
                        .Rows(sum).Cells(3).Value = "###ไม่พบข้อมูล###"
                    End If
                End With
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDataSN(ByVal snid As String)
        Try
            strSQL = "SELECT claims_id FROM claims WHERE serial_pro='" & snid & "' AND `status`='รอส่งคืน'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                ReturnClaimstoCus1Frm.lblEmployee.Text = Me.lblEmployee.Text
                Call ReturnClaimstoCus1Frm.getdataClaims(Dr.GetString("claims_id"))
                ReturnClaimstoCus1Frm.ShowDialog(Me)
            Else
                MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            End If
            Me.txtRTCTsearchSN.Clear()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call getdataClaims(100, Nothing)
    End Sub

    Private Sub ReturnClaimsToCusFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReturnClaimsToCusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getdataClaims(100, Nothing)
    End Sub

    Private Sub btnRTCTrefresh_Click(sender As Object, e As EventArgs) Handles btnRTCTrefresh.Click
       Call getdataClaims(100, Nothing)
    End Sub

    Private Sub txtRTCTsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRTCTsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtRTCTsearchSN.Text <> Nothing Then
                Call getDataSN(Me.txtRTCTsearchSN.Text)
            End If
        End If
    End Sub

    Private Sub dgRCTC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRCTC.CellDoubleClick
        If Me.dgRCTC.Rows.Count <> 0 Then
            Call getDataSN(Me.dgRCTC.CurrentRow.Cells(4).Value)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/returnclaimstocusfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class