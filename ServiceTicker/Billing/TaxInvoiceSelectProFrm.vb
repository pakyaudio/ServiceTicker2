Imports MySql.Data.MySqlClient

Public Class TaxInvoiceSelectProFrm

    Private Sub TaxInvoiceSelectProFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub TaxInvoiceSelectProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub GetProType()
        Me.cbbTISPpro.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT prosection_id,prosection_name FROM product_section ORDER BY prosection_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.cbbTISPpro.DisplayMember = "prosection_name"
                Me.cbbTISPpro.ValueMember = "prosection_id"

                dt.Columns.Add("prosection_name", GetType(String))
                dt.Columns.Add("prosection_id", GetType(String))
                dt.Rows.Add("แสดงทั้งหมด", "FORALL")
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("prosection_name"), Dr.Item("prosection_id"))
                End While

                Me.cbbTISPpro.DataSource = dt
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Function GetTapyName(ByVal pid As String) As String
        Try
            strSQL = "SELECT prosection_name FROM product_section WHERE prosection_id='" & pid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Return Dr.Item("prosection_name")
        Catch ex As Exception
            Return "##ไม่พบข้อมูล##"
        End Try
    End Function

    Private Function GetSubSectionName(ByVal subid As String) As String
        Try
            strSQL = "SELECT product_section_subs_name FROM product_section_subs WHERE product_section_subs_id='" & subid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Return Dr.Item("product_section_subs_name")
        Catch ex As Exception
            Return "##ไม่พบข้อมูล##"
        End Try
    End Function

    Private Sub LoadType()
        Try
            Me.dgTISP.Rows.Clear()
            If cbbTISPpro.SelectedValue = "FORALL" Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,unit,`type`,sub_section FROM product " _
                 & "ORDER BY name_pro;"
            Else
                strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,unit,`type`,sub_section FROM product " _
                 & "WHERE `type`='" & Me.cbbTISPpro.SelectedValue.ToString & "' ORDER BY name_pro;"
            End If

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgTISP
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Tag = Dr.Item("type")
                    .Rows(r).Cells(4).Tag = Dr.Item("sub_section")
                    .Rows(r).Cells(5).Value = Dr.Item("unit")
                    .Rows(r).Cells(6).Value = Dr.Item("price_buy")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For r As Integer = 0 To Me.dgTISP.Rows.Count - 1
                Me.dgTISP.Rows(r).Cells(3).Value = GetTapyName(Me.dgTISP.Rows(r).Cells(3).Tag)
                Me.dgTISP.Rows(r).Cells(4).Value = GetSubSectionName(Me.dgTISP.Rows(r).Cells(4).Tag)
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SearchPro(ByVal keyword)
        Try
            Me.dgTISP.Rows.Clear()

            strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,unit,`type`,sub_section FROM product " _
             & "WHERE name_pro LIKE '%" & keyword & "%';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgTISP
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Tag = Dr.Item("type")
                    .Rows(r).Cells(4).Tag = Dr.Item("sub_section")
                    .Rows(r).Cells(5).Value = Dr.Item("unit")
                    .Rows(r).Cells(6).Value = Dr.Item("price_buy")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For r As Integer = 0 To Me.dgTISP.Rows.Count - 1
                Me.dgTISP.Rows(r).Cells(3).Value = GetTapyName(Me.dgTISP.Rows(r).Cells(3).Tag)
                Me.dgTISP.Rows(r).Cells(4).Value = GetSubSectionName(Me.dgTISP.Rows(r).Cells(4).Tag)
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnTISPselect_Click(sender As Object, e As EventArgs) Handles btnTISPselect.Click
        Try
            If Me.dgTISP.Rows.Count <> 0 Then
                TaxInvoiceFrm.txtTIsearchBarcode.Text = Me.dgTISP.CurrentRow.Cells(1).Value
                Call TaxInvoiceFrm.getDataProduct()
                TaxInvoiceFrm.txtTIsearchBarcode.Clear()
                TaxInvoiceFrm.txtTIsearchBarcode.Focus()
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub TaxInvoiceSelectProFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call GetProType()
    End Sub

    Private Sub cbbTISPpro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbTISPpro.SelectionChangeCommitted
        Call LoadType()
    End Sub

    Private Sub dgTISP_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgTISP.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                If Me.dgTISP.Rows.Count <> 0 Then
                    TaxInvoiceFrm.txtTIsearchBarcode.Text = Me.dgTISP.CurrentRow.Cells(1).Value
                    Call TaxInvoiceFrm.getDataProduct()
                    TaxInvoiceFrm.txtTIsearchBarcode.Clear()
                    TaxInvoiceFrm.txtTIsearchBarcode.Focus()
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TextBox1.Text <> Nothing Then
                e.SuppressKeyPress = True
                Call SearchPro(Me.TextBox1.Text)
                Me.TextBox1.Clear()
            End If
        End If
    End Sub
End Class