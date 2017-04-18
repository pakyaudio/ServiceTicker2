Imports MySql.Data.MySqlClient

Public Class SearchCustomerByBillingFrm

    Private Sub AddCusToolStripButton_Click(sender As Object, e As EventArgs) Handles AddCusToolStripButton.Click
        For Each form In My.Application.OpenForms
            If (form.name = CustomerFrm.Name) Then
                If form.Visible Then
                    CustomerFrm.WindowState = FormWindowState.Normal
                    CustomerFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลลูกค้า")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            CustomerFrm.lblEmployee.Text = SaveDataFixFrm.lblEmployee.Text
            CustomerFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SearchCustomerFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SearchCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.SearchToolStripTextBox.Focus()
    End Sub

    Private Sub GetAllData()
        Try
            Me.dgSearchCustoSaveFix.Rows.Clear()
            cmd = New MySqlCommand("SELECT customer_id,customer_name,customer_address,customer_zipcode,customer_tel " _
                                   & "FROM customer ORDER BY date_edit DESC LIMIT " & LimitToolStripTextBox.Text & "", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim r As Integer
                With Me.dgSearchCustoSaveFix
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_zipcode")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_tel")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub GetDataByID()
        Try
            Me.dgSearchCustoSaveFix.Rows.Clear()
            cmd = New MySqlCommand("SELECT customer_id,customer_name,customer_address,customer_zipcode,customer_tel " _
                                   & "FROM customer ORDER BY date_edit DESC LIMIT 1", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim r As Integer
                With Me.dgSearchCustoSaveFix
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_zipcode")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_tel")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SearchCustomer()
        Try
            Me.dgSearchCustoSaveFix.Rows.Clear()
            Dim strKeyWord As String = Me.SearchToolStripTextBox.Text
            cmd = New MySqlCommand("SELECT customer_id,customer_name,customer_address,customer_zipcode,customer_tel " _
                 & "FROM customer WHERE customer_id LIKE '%" & strKeyWord & "%' OR customer_name LIKE " _
                 & "'%" & strKeyWord & "%' OR customer_address LIKE '%" & strKeyWord & "%' OR customer_tel LIKE '%" & strKeyWord & "%' ", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim r As Integer
                With Me.dgSearchCustoSaveFix
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_zipcode")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_tel")
                End With
            End While
            Me.SearchToolStripTextBox.Clear()
        Catch ex As Exception
            Me.SearchToolStripTextBox.Clear()
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ShowCusAllToolStripButton_Click(sender As Object, e As EventArgs) Handles ShowCusAllToolStripButton.Click
        Call GetAllData()
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        If Me.SearchToolStripTextBox.Text <> Nothing Then
            Call SearchCustomer()
        End If
    End Sub

    Private Sub SearchToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchToolStripTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.SearchToolStripTextBox.Text <> Nothing Then
                Call SearchCustomer()
            End If
        End If
    End Sub

    Private Sub btnSendtoSavedatafix_Click(sender As Object, e As EventArgs) Handles btnSendtoSavedatafix.Click
        If Me.dgSearchCustoSaveFix.Rows.Count <> 0 Then
            Call TaxInvoiceFrm.getCustomerData(Me.dgSearchCustoSaveFix.SelectedCells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub dgSearchCustoSaveFix_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSearchCustoSaveFix.CellMouseClick
        Me.txtSearchCusShowTel.Text = Me.dgSearchCustoSaveFix.CurrentRow.Cells(1).Value
    End Sub

    Private Sub dgSearchCustoSaveFix_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSearchCustoSaveFix.CellMouseDoubleClick
        If Me.dgSearchCustoSaveFix.Rows.Count <> 0 Then
            Call TaxInvoiceFrm.getCustomerData(Me.dgSearchCustoSaveFix.SelectedCells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub dgSearchCustoSaveFix_SelectionChanged(sender As Object, e As EventArgs) Handles dgSearchCustoSaveFix.SelectionChanged
        Me.txtSearchCusShowTel.Text = Me.dgSearchCustoSaveFix.CurrentRow.Cells(1).Value
    End Sub

    Private Sub LimitToolStripTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LimitToolStripTextBox.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class