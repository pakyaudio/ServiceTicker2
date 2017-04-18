Imports MySql.Data.MySqlClient

Public Class accessoryFrm

    Private Sub accessoryFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub accessoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call getData()
    End Sub

    Private Sub getData()
        Try
            cmd = New MySqlCommand("SELECT accessory_name FROM accessory ORDER BY accessory_name ASC", ConnectionDB)
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

    Private Sub btnAccessoryClose_Click(sender As Object, e As EventArgs) Handles btnAccessoryClose.Click
        Me.Close()
    End Sub

    Private Sub dgAccessory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAccessory.CellDoubleClick
        If Not SaveDataFixFrm.txtSDFfixaccessory.Text = Nothing Then
            SaveDataFixFrm.txtSDFfixaccessory.Text = SaveDataFixFrm.txtSDFfixaccessory.Text + "," & Me.dgAccessory.CurrentRow.Cells(1).Value
        Else
            SaveDataFixFrm.txtSDFfixaccessory.Text = Me.dgAccessory.CurrentRow.Cells(1).Value
        End If
    End Sub
End Class