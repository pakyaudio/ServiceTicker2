Imports MySql.Data.MySqlClient

Public Class accessoryClaimsFrm
    Private Sub getData()
        Try
            cmd = New MySqlCommand("SELECT accessory_name FROM accessory", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgAccessory
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("accessory_name")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub accessoryClaimsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub accessoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call getData()
    End Sub

    Private Sub btnAccessoryClose_Click(sender As Object, e As EventArgs) Handles btnAccessoryClose.Click
        Me.Close()
    End Sub

    Private Sub dgAccessory_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgAccessory.CellMouseDoubleClick
        Try
            If Not ClaimsFrm.txtCFaccessory.Text = Nothing Then
                ClaimsFrm.txtCFaccessory.Text = ClaimsFrm.txtCFaccessory.Text + "," & Me.dgAccessory.SelectedCells.Item(1).Value
                Me.Label1.Text = "เพิ่มข้อมูลแล้ว"
            Else
                ClaimsFrm.txtCFaccessory.Text = Me.dgAccessory.SelectedCells.Item(1).Value
                Me.Label1.Text = "เพิ่มข้อมูลแล้ว"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = "ดับเบิ๊ลคลิ๊กเพื่อเลือก"
        Me.Timer1.Stop()
    End Sub
End Class