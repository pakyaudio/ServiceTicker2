Imports MySql.Data.MySqlClient
Public Class DebtorSelectCustomerFrm
    Dim s As Integer
    Private Sub getDataCustomer()
        Me.dgDSC.Rows.Clear()
        Try
            If s = 100 Then
                strSQL = "SELECT customer_id,customer_name,customer_address,customer_tel,date_edit FROM customer ORDER BY customer_id DESC"
            ElseIf s = 200 Then
                strSQL = "SELECT * FROM customer " _
                    & "WHERE customer_name LIKE '%" & Me.txtDSCsearch.Text & "%' " _
                    & "OR customer_address LIKE '%" & Me.txtDSCsearch.Text & "%' " _
                    & "OR customer_tel  LIKE '%" & Me.txtDSCsearch.Text & "%' "
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgDSC
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_tel")
                    .Rows(r).Cells(4).Value = Dr.GetString("date_edit")
                End With
            End While
            s = Nothing
        Catch ex As Exception

        End Try
        Me.txtDSCsearch.Clear()
    End Sub

    Private Sub txtDSCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDSCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtDSCsearch.Text = "" Then
            Else
                s = 200
                Call getDataCustomer()
            End If
        End If
    End Sub

    Private Sub btnDSCsearchCus_Click(sender As Object, e As EventArgs) Handles btnDSCsearchCus.Click
        If Me.txtDSCsearch.Text = "" Then
        Else
            s = 200
            Call getDataCustomer()
        End If
    End Sub

    Private Sub btnDSCshowall_Click(sender As Object, e As EventArgs) Handles btnDSCshowall.Click
        s = 100
        Call getDataCustomer()
    End Sub

    Private Sub dgDSC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDSC.CellDoubleClick
        If Me.dgDSC.Rows.Count = 0 Then

        ElseIf Me.dgDSC.SelectedCells.Item(0).Value = "0" Then
            MsgBox("มัดจำในชื่อลูกค้าเงินสดไม่ได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            DebtorFrm.txtDTcustomer_id.Text = Me.dgDSC.SelectedCells.Item(0).Value
            DebtorFrm.txtDTcustomer_name.Text = Me.dgDSC.SelectedCells.Item(1).Value
            DebtorFrm.txtDTcustomer_address.Text = Me.dgDSC.SelectedCells.Item(2).Value
            DebtorFrm.txtDTcustomer_tel.Text = Me.dgDSC.SelectedCells.Item(3).Value
            Me.Close()
        End If
    End Sub

    Private Sub DebtorSelectCustomerFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub DebtorSelectCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
End Class