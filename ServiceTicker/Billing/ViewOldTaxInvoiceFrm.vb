Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ViewOldTaxInvoiceFrm

#Region "Code"
    Dim cf As Integer
    Function countData() As Boolean
        Try
            strSQL = "SELECT COUNT(taxinvoice_id) AS CT FROM taxinvoice"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                Dr.Read()
                Dim r As Integer = Dr.Item("CT")
                cf = r
                If r > 10 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    ''' <summary>
    ''' ดึงข้อมูล taxinvoice Call getData(ByVal ddc As Integer, ByVal where As String) 
    ''' </summary>
    ''' <param name="ddc">100, 200</param>
    ''' <param name="where">where</param>
    ''' <remarks></remarks>
    Private Sub getData(ByVal ddc As Integer, Optional ByVal where As String = Nothing)
        Dim stringSearch As String = String.Empty
        Try
            If ddc = 100 Then
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                    "taxinvoice WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND " & _
                    "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' ORDER BY taxinvoice_id DESC"
                Me.dgVOTI.Rows.Clear()
            ElseIf ddc = 200 Then
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                    "taxinvoice WHERE taxinvoice_id='" & where & "';"
                Me.dgVOTI.Rows.Clear()
            ElseIf ddc = 300 Then
                stringSearch = where
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                   "taxinvoice WHERE taxinvoice_type LIKE '%" & where & "%' OR customer_name LIKE '%" & where & "%' OR name_pro LIKE '%" & where & "%'" _
                   & "ORDER BY taxinvoice_id DESC LIMIT 10;"
                Me.dgVOTI.Rows.Clear()
            ElseIf ddc = 400 Then
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                    "taxinvoice WHERE taxinvoice_type LIKE '%" & stringSearch & "%' OR customer_name LIKE '%" & stringSearch & "%' OR name_pro LIKE '%" & stringSearch & "%'" _
                    & "ORDER BY taxinvoice_id DESC LIMIT 10 OFFSET " & Me.dgVOTI.Rows.Count & ";"
            ElseIf ddc = 500 Then
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                    "taxinvoice ORDER BY datetime_save DESC LIMIT 30;"
                Me.dgVOTI.Rows.Clear()
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            If Dr.HasRows Then
                If ddc = 300 Then
                    Timer1.Start()
                End If
                Dim r As Integer
                While Dr.Read()
                    With Me.dgVOTI
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("taxinvoice_id")
                        .Rows(r).Cells(1).Value = Dr.Item("taxinvoice_type")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                        .Rows(r).Cells(4).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("total")
                        .Rows(r).Cells(7).Value = Dr.Item("unit")
                        .Rows(r).Cells(8).Value = Dr.Item("price_buy")
                        .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                    End With
                End While
            End If
            ddc = Nothing
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub btnVOTIsearch_Click(sender As Object, e As EventArgs) Handles btnVOTIsearch.Click
        Me.btnForward.Visible = False
        Call getData(100)
    End Sub

    Private Sub dgVOTI_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVOTI.CellDoubleClick
        If Me.dgVOTI.Rows.Count <> 0 Then
            If MouseButtons.Left Then
                Call getData(200, Me.dgVOTI.CurrentRow.Cells(0).Value)
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        Me.btnForward.Visible = False
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.txtSearch.Text <> String.Empty Then
                Call getData(300, Me.txtSearch.Text)
                If Me.dgVOTI.Rows.Count < cf Then
                    Me.btnForward.Visible = True
                End If
            End If
            Me.txtSearch.Clear()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.btnForward.Visible = False
        If Me.txtSearch.Text <> String.Empty Then
            Call getData(300, Me.txtSearch.Text)
            If Me.dgVOTI.Rows.Count < cf Then
                Me.btnForward.Visible = True
            End If
        End If
        Me.txtSearch.Clear()
    End Sub

    Private Sub btnVOTIdel_Click(sender As Object, e As EventArgs) Handles btnVOTIdel.Click
        Me.btnForward.Visible = False
        If MessageBox.Show(Me, "ต้องการจะลบข้อมูล" & Me.dgVOTI.CurrentRow.Cells(1).Value & "นี้", "ยืนยัน", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "DELETE FROM taxinvoice WHERE taxinvoice_id='" & Me.dgVOTI.CurrentRow.Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dim del As Integer = Nothing
                del = cmd.ExecuteNonQuery()
                MessageBox.Show(Me, "ลบข้อมูลนี้แล้ว " & Me.dgVOTI.CurrentRow.Cells(0).Value & " จำนวน " & del & " รายการ", "ลบ", MessageBoxButtons.OK,
                              MessageBoxIcon.Information)

                Call getData(500)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.btnForward.Visible = False
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.btnForward.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.btnForward.Visible = False
        If Me.dgVOTI.Rows.Count <> 0 Then
            Call TaxInvoiceFrm.getDataProductByView(Me.dgVOTI.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If Me.dgVOTI.Rows.Count < cf Then
            Call getData(400)
        Else
            Me.btnForward.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call countData()
        Timer1.Stop()
    End Sub

    Private Sub dgVOTI_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgVOTI.RowStateChanged
        If Me.dgVOTI.Rows.Count = 0 Then
            Me.btnForward.Visible = False
        End If
    End Sub

    Private Sub ViewOldTaxInvoiceFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewOldTaxInvoiceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub ViewOldTaxInvoiceFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call getData(500)
    End Sub
End Class