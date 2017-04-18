Imports MySql.Data.MySqlClient

Public Class SelectReceiveProductFrm

    Private Sub SelectReceiveProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SelectReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.btnSRPselect.Enabled = False
        Me.btnSRPviewPro.Enabled = False
        Call getDataTocbbSRPbuyCompany(0)
    End Sub

    Private Sub getCompanyBuy()
        Try
            Me.cbbSRPbuyCompany.Items.Clear()
            cmd = New MySqlCommand("SELECT sale_company_name FROM sale_company ORDER BY sale_company_name ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSRPbuyCompany.Items.Add(Dr("sale_company_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getDataTocbbSRPbuyCompany(ByVal stSQL As Integer)
        Try
            Me.dgSRP.Rows.Clear()
            If stSQL = 100 Then
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee FROM " _
                    & "buy WHERE sale_company_name='" & Me.cbbSRPbuyCompany.Text & "' AND (status='ยังไม่ได้รับสินค้า' OR status='สินค้ายังไม่ครบ')"
            ElseIf stSQL = 0 Then
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee FROM " _
                 & "buy WHERE status='ยังไม่ได้รับสินค้า' OR status='สินค้ายังไม่ครบ'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgSRP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("buy_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("sale_company_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("sale_company_name")
                    .Rows(r).Cells(3).Value = Dr.GetString("datetime_save")
                    .Rows(r).Cells(4).Value = Dr.GetString("employee")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(6).Value = Dr.GetString("status")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSRPbuyCompany_DropDown(sender As Object, e As EventArgs) Handles cbbSRPbuyCompany.DropDown
        Call getCompanyBuy()
    End Sub

    Private Sub cbbSRPbuyCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbSRPbuyCompany.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbSRPbuyCompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSRPbuyCompany.SelectedValueChanged
        Call getDataTocbbSRPbuyCompany(100)
    End Sub

    Private Sub btnSRPviewPro_Click(sender As Object, e As EventArgs) Handles btnSRPviewPro.Click
        ViewSelectReceiveProductFrm.btnPrint.Visible = False
        Call ViewSelectReceiveProductFrm.getDataViewReceiveFrm(Me.dgSRP.CurrentRow.Cells(0).Value)
        ViewSelectReceiveProductFrm.ShowDialog(Me)
    End Sub
    Dim oldData As Object
    Private Sub dgSRP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRP.CellDoubleClick
        Me.dgSRP.ReadOnly = False
        oldData = Me.dgSRP.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgSRP_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRP.CellEndEdit
        Me.dgSRP.ReadOnly = True
        Me.dgSRP.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub dgSRP_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgSRP.RowStateChanged
        If Me.dgSRP.Rows.Count <> 0 Then
            Me.btnSRPselect.Enabled = True
            Me.btnSRPviewPro.Enabled = True
        ElseIf Me.dgSRP.Rows.Count = 0 Then
            Me.btnSRPselect.Enabled = False
            Me.btnSRPviewPro.Enabled = False
        End If
    End Sub

    Private Sub btnSRPselect_Click(sender As Object, e As EventArgs) Handles btnSRPselect.Click
        If Me.dgSRP.Rows.Count <> 0 Then
            If Me.dgSRP.SelectedCells.Item(6).Value = "ได้รับสินค้าแล้ว" Then
                MsgBox("ใบสั่งซื้อนี้ได้รับสินค้าแล้ว ไม่สามารถนำเข้าสินค้าได้อีก", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf Me.dgSRP.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                MsgBox("ใบสั่งซื้อนี้ได้รับการยกเลิก ไม่สามารถนำเข้าสินค้าได้อีก", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf Me.dgSRP.SelectedCells.Item(6).Value = "ยังไม่ได้รับสินค้า" Or Me.dgSRP.SelectedCells.Item(6).Value = "สินค้ายังไม่ครบ" Then
                Call ReceiveProductFrm.getDatatodgRPorderpro(Me.dgSRP.CurrentRow.Cells(0).Value)
                Call ReceiveProductFrm.totalSumCost()
                Me.Close()
            End If
        End If
    End Sub
End Class