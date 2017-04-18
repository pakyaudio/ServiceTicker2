Imports System.Threading

Public Class SelectCustomerFrm

    Private Sub SelectCustomerFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SelectCustomerFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F9 Then
            Call keyf9()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SelectCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.TextBox1.Focus()

        'TODO: This line of code loads data into the 'CustomerSaleDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CustomerSaleDataSet.customer)

        'get my names from the dataset
        Dim myNames = From n In Me.CustomerSaleDataSet.customer Select n.customer_name
        Dim myTel = From n In Me.CustomerSaleDataSet.customer Select n.customer_tel

        Me.TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource

        'add names to custom list
        Me.TextBox1.AutoCompleteCustomSource.AddRange(myNames.ToArray())
        Me.TextBox1.AutoCompleteCustomSource.AddRange(myTel.ToArray())
    End Sub

    Private Sub GetDataCustomer(ByVal cus As String)
        Me.dgScus.Rows.Clear()
        strSQL = "SELECT customer_id,customer_tax,customer_name,customer_address,customer_tel" _
            & " FROM customer WHERE customer_tel LIKE '%" & cus & "%' OR customer_name LIKE '%" & cus & "%'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim r As Integer
                With Me.dgScus
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_tax")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_tel")
                End With
            End While
            Me.dgScus.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If Me.TextBox1.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Call GetDataCustomer(Me.TextBox1.Text)
                Me.TextBox1.Clear()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text <> Nothing Then
            Call GetDataCustomer(Me.TextBox1.Text)
            Me.TextBox1.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.dgScus.Rows.Count <> 0 Then
            SaleFrm.txtScusID.Text = Me.dgScus.CurrentRow.Cells(0).Value
            SaleFrm.txtScusName.Text = Me.dgScus.CurrentRow.Cells(2).Value
            SaleFrm.txtSaddress.Text = Me.dgScus.CurrentRow.Cells(3).Value
            SaleFrm.txtScusTel.Text = Me.dgScus.CurrentRow.Cells(4).Value
            Dim pleval As String = String.Empty
            Try
                cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT price_level FROM " _
                                                              & "customer WHERE customer_id='" & Me.dgScus.CurrentRow.Cells(0).Value & "'", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    pleval = Dr.Item("price_level")
                Else
                    pleval = "1"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            If pleval = "1" Then
                SaleFrm.rbSbuy.Checked = True
            ElseIf pleval = "2" Then
                SaleFrm.rbSwholesale.Checked = True
            ElseIf pleval = "3" Then
                SaleFrm.rbStechnician.Checked = True
            ElseIf pleval = "4" Then
                SaleFrm.rbSloyal.Checked = True
            ElseIf pleval = "5" Then
                SaleFrm.rbSmembers.Checked = True
            Else
                SaleFrm.rbSbuy.Checked = True
            End If
            Me.Close()
        End If
    End Sub
    Private Sub keyf9()
        Try
            dt = New DataTable
            dtAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT customer_id,customer_name,customer_address,customer_tel" _
                                                  & " FROM customer WHERE customer_id='0';", ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            SaleFrm.txtScusID.Text = dt(0)("customer_id")
            SaleFrm.txtScusName.Text = dt(0)("customer_name")
            SaleFrm.txtSaddress.Text = dt(0)("customer_address")
            SaleFrm.txtScusTel.Text = dt(0)("customer_tel")
            SaleFrm.rbSbuy.Checked = True
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call keyf9()
    End Sub
End Class