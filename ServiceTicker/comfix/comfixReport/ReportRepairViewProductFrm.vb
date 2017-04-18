Imports MySql.Data.MySqlClient

Public Class ReportRepairViewProductFrm

    Private Sub ReportRepairViewProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReportRepairViewProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
    Friend Sub getData(ByVal sid As String, ByVal fid As Integer)
        Me.DataGridView1.Rows.Clear()
        If fid = 300 Then
            strSQL = "SELECT sale_id,fix_id,code_pro,name_pro,total_pro,price_buy,unit FROM cash_sale_barcode WHERE sale_id='" & sid & "'"
        ElseIf fid = 400 Then
            strSQL = "SELECT sale_id,fix_id,code_pro,name_pro,total_pro,price_buy,unit FROM sale_barcode WHERE sale_id='" & sid & "'"
        End If
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                Dim a As String = Dr.Item("fix_id")
                If fid = 300 Then
                    If a = "ขายสินค้า" Then
                        lblRRVPshow.Text = "เลขที่ขาย " & Dr.Item("sale_id")
                    Else
                        lblRRVPshow.Text = "ใบรับซ่อมเลขที่ " & Dr.Item("fix_id")
                    End If
                ElseIf fid = 400 Then
                    If a = "ขายสินค้า" Then
                        lblRRVPshow.Text = "เลขที่ขาย " & Dr.Item("sale_id")
                    Else
                        lblRRVPshow.Text = "ใบรับซ่อมเลขที่ " & Dr.Item("fix_id")
                    End If
                End If
                With Me.DataGridView1
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("unit")
                    .Rows(r).Cells(4).Value = Dr.GetDecimal("price_buy")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        fid = Nothing
        sid = String.Empty
    End Sub
End Class