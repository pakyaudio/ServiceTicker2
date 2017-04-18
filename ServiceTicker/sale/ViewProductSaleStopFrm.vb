Public Class ViewProductSaleStopFrm

    Private Sub ViewProductSaleStopFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewProductSaleStopFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Friend Sub GetStopSale(ByVal sid As String)
        Try
            strSQL = "SELECT customer_id,customer_name,bar_code,name_pro,count_num,unit,datetime_save,employee " _
                & "FROM stop_sale_bc WHERE sale_id='" & sid & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.DataGridView1
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(1).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(2).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("count_num")
                    .Rows(r).Cells(5).Value = Dr.Item("unit")
                    .Rows(r).Cells(6).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(7).Value = Dr.Item("employee")
                End With
            End While
        Catch ex As Exception

        End Try
    End Sub
End Class