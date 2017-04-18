Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Public Class ClaimsTestResultsFrm
    Private Function GetCustomerName(ByVal cus_id As Object) As String
        Try
            cmd = New MySqlCommand("SELECT customer_name FROM customer WHERE customer_id='" & cus_id & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Return Dr.GetString("customer_name")
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function
    Friend Sub loadDataClaims()
        Me.dgCTR.Rows.Clear()
        strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,datetime_save FROM claims WHERE status='รอทดสอบ';"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim r As Integer
                With Me.dgCTR
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(6).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For a As Integer = 0 To Me.dgCTR.Rows.Count - 1
            Me.dgCTR.Rows(a).Cells(3).Value = GetCustomerName(Me.dgCTR.Rows(a).Cells(2).Value)
        Next
        Me.dgCTR.ClearSelection()
    End Sub

    Private Sub ClaimsTestResultsFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsTestResultsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call loadDataClaims()
    End Sub

    Private Sub TestToolStripMenu_Click(sender As Object, e As EventArgs) Handles TestToolStripMenu.Click
        Call ClaimsTestSaveFrm.getDataClaimsSNtoTextBox(Me.dgCTR.CurrentRow.Cells(4).Value)
        ClaimsTestSaveFrm.ShowDialog(Me)
    End Sub

    Private Sub dgCTR_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCTR.CellMouseClick
        If dgCTR.RowCount <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgCTR.Rows(e.RowIndex).Selected = True
                Me.dgCTR.CurrentCell = Me.dgCTR.Rows(e.RowIndex).Cells(0)
                Me.TestProClaimsContextMenu.Show(Me.dgCTR, e.Location)
                Me.TestProClaimsContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub GetClaimsTestForm()
        For r As Integer = 0 To Me.dgCTR.Rows.Count - 1
            If Me.txtCTRsearchSN.Text = Me.dgCTR.Rows(r).Cells(4).Value Then
                Call ClaimsTestSaveFrm.getDataClaimsSNtoTextBox(Me.dgCTR.Rows(r).Cells(4).Value)
                ClaimsTestSaveFrm.ShowDialog(Me)
                Exit For
                'Else
                '    MessageBox.Show(Me, "ไม่พบข้อมูล sn นี้", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Next
        Me.txtCTRsearchSN.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txtCTRsearchSN.Text <> Nothing Then
            Call GetClaimsTestForm()
        End If
    End Sub

    Private Sub txtCTRsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCTRsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCTRsearchSN.Text <> Nothing Then
                Call GetClaimsTestForm()
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/managerclaimssendout/claimstestresultsfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class