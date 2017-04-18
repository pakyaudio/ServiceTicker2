Imports MySql.Data.MySqlClient

Public Class VarunteeViewProductFrm

    Private Sub VarunteeViewProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReportRepairViewProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call getDataVaruntee(VarunteeCheckFrm.dgVC.CurrentRow.Cells(1).Value)
    End Sub
    Friend Sub getDataVaruntee(ByVal fid As String)
        Me.DataGridView1.Rows.Clear()
        strSQL = "SELECT sale_id,code_pro,name_pro,total_pro,price_buy,unit,datetime_save,employee FROM sale_barcode WHERE fix_id='" & fid & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader()
            'Dr.Read()
            If Dr.HasRows Then
                While Dr.Read()
                    Me.lblRRVPshow.Text = "เลขที่ใบเบิกสินค้า " & Dr.Item("sale_id") & " (ยังไม่ได้ชำระเงิน)"
                    Dim r As Integer
                    With Me.DataGridView1
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("total_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("unit")
                        .Rows(r).Cells(4).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(5).Value = Dr.GetString("datetime_save")
                        .Rows(r).Cells(6).Value = Dr.GetString("employee")
                    End With
                End While
            Else
                strSQL = "SELECT sale_id,code_pro,name_pro,total_pro,price_buy,unit,datetime_save,employee FROM cash_sale_barcode WHERE fix_id='" & fid & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                'Dr.Read()
                If Dr.HasRows Then
                    While Dr.Read()
                        Me.lblRRVPshow.Text = "เลขที่ใบเบิกสินค้า " & Dr.Item("sale_id") & " (ชำระเงินแล้ว)"
                        Dim r As Integer
                        With Me.DataGridView1
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                            .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                            .Rows(r).Cells(2).Value = Dr.Item("total_pro")
                            .Rows(r).Cells(3).Value = Dr.Item("unit")
                            .Rows(r).Cells(4).Value = Dr.GetDecimal("price_buy")
                            .Rows(r).Cells(5).Value = Dr.GetString("datetime_save")
                            .Rows(r).Cells(6).Value = Dr.GetString("employee")
                        End With
                    End While
                Else
                    MessageBox.Show(Me, "ไม่พบข้อมูล", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(Me, "ผิดพลาด " & ex.Message, "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            Me.Close()
        End Try
        'fid = String.Empty
    End Sub

    Dim oldData As Object
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.DataGridView1.ReadOnly = False
        oldData = Me.DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Me.DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value = oldData
        Me.DataGridView1.ReadOnly = True
    End Sub
End Class