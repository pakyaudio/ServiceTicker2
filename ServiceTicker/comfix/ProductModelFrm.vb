Imports MySql.Data.MySqlClient

Public Class ProductModelFrm
    Private Sub startfrm()

        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = False
        Me.CancelToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = False
        Me.dgProductType.Enabled = True
        Me.dgModel.Enabled = True
        Me.txtEdit.Clear()

    End Sub

    Private Sub getData()
        Try
            Me.dgProductType.Rows.Clear()
            cmd = New MySqlCommand("SELECT ID,p_name FROM product_name ORDER BY p_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgProductType
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Tag = Dr.Item("ID")
                    .Rows(r).Cells(0).Value = Dr.Item("p_name")
                End With
            End While
            Me.dgProductType.ClearSelection()
            Me.dgModel.Rows.Clear()
            Me.NewToolStripButton.Enabled = False
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getProductModel()
        Try
            Me.dgModel.Rows.Clear()
            cmd = New MySqlCommand("SELECT p_model FROM product_model WHERE " _
                                   & "p_name='" & Me.dgProductType.CurrentRow.Cells(0).Value & "' ORDER BY p_model;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgModel
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.GetString("p_model")
                End With
            End While
            Me.dgModel.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ProductModelFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
        Call getData()
    End Sub
  
    Dim selectSaveCadit As Integer

    Private Sub InsertData()
        If checkMySQLDruplicateDB("SELECT * FROM product_model " _
                                  & "WHERE p_name='" & Me.dgProductType.CurrentRow.Cells(0).Value & "' " _
                                  & "AND p_model='" & Me.txtEdit.Text & "'") = True Then
            MessageBox.Show(Me, "มีรายการนี้อยู่แล้ว กรุณาเปลี่ยนเป็นอย่างอื่น", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                cmd = New MySqlCommand("INSERT INTO product_model(p_name,p_model)" _
                                       & "VALUES('" & Me.dgProductType.CurrentRow.Cells(0).Value & "'," _
                                       & "'" & Me.txtEdit.Text & "')", ConnectionDB)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call startfrm()
                    selectSaveCadit = Nothing
                    Call getProductModel()
                ElseIf save = 0 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub UpdateData()
        For r As Integer = 0 To Me.dgModel.Rows.Count - 1
            If Me.txtEdit.Text = Me.dgModel.Rows(r).Cells(1).Value Then
                If Me.txtEdit.Text = Me.dgModel.CurrentRow.Cells(1).Value Then
                Else
                    MessageBox.Show(Me, "มีรายการนี้อยู่แล้ว กรุณาเปลี่ยนเป็นอย่างอื่น", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            End If
        Next
        Try
            cmd = New MySqlCommand("UPDATE product_model SET p_model='" & Me.txtEdit.Text & "' WHERE " _
                                   & "p_name='" & Me.dgProductType.CurrentRow.Cells(0).Value & "' AND p_model='" & Me.dgModel.CurrentRow.Cells(1).Value & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call startfrm()
                selectSaveCadit = Nothing
                Call getProductModel()
            ElseIf save = 0 Then
                MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs)
        selectSaveCadit = 2000
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = True
        Me.dgProductType.Enabled = False
    End Sub

    Private Sub DeleteData()
        Try
            cmd = New MySqlCommand("DELETE FROM product_model WHERE p_name='" & Me.dgProductType.CurrentRow.Cells(0).Value & "' " _
                                   & "AND p_model='" & Me.txtEdit.Text & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MessageBox.Show(Me, "ลบข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call startfrm()
                selectSaveCadit = Nothing
                Call getProductModel()
            ElseIf save = 0 Then
                MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

  
    Private Sub RefeshTool_Click(sender As Object, e As EventArgs) Handles RefeshModelTool.Click
        Call getProductModel()
    End Sub

    Private Sub EditProductStripButton_Click(sender As Object, e As EventArgs) Handles EditProductStripButton.Click
        ProductNameFrm.ShowDialog(Me)
    End Sub

    Private Sub BackPStripButton_Click(sender As Object, e As EventArgs) Handles BackPStripButton.Click
        Try
            Me.dgProductType.CurrentCell = Me.dgProductType.Rows(Me.dgProductType.CurrentCell.RowIndex - 1).Cells(0)
            Call getProductModel()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub nextPStripButton_Click(sender As Object, e As EventArgs) Handles nextPStripButton.Click
        Try
            Me.dgProductType.CurrentCell = Me.dgProductType.Rows(Me.dgProductType.CurrentCell.RowIndex + 1).Cells(0)
            Call getProductModel()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefeshPStripButton_Click(sender As Object, e As EventArgs) Handles RefeshPStripButton.Click
        Call getData()
    End Sub

    Private Sub dgProductType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProductType.CellClick
        If Me.dgProductType.Rows.Count <> 0 Then
            Me.EditProductStripButton.Enabled = True

            Me.EditToolStripButton.Enabled = False
            Me.DeleteToolStripButton.Enabled = False
            Me.BackPStripButton.Enabled = True
            Me.nextPStripButton.Enabled = True
            Me.RefeshPStripButton.Enabled = True
            Me.RefeshModelTool.Enabled = True

            Me.NewToolStripButton.Enabled = True
            Me.txtEdit.Clear()

            Call getProductModel()
            Me.dgModel.ClearSelection()
        End If
    End Sub

    Private Sub NewToolStripButton_Click_1(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        selectSaveCadit = 1000
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        Me.EditProductStripButton.Enabled = False
        Me.BackPStripButton.Enabled = False
        Me.nextPStripButton.Enabled = False
        Me.RefeshPStripButton.Enabled = False
        Me.RefeshModelTool.Enabled = False

        Me.txtEdit.Enabled = True
        Me.txtEdit.Clear()
        Me.txtEdit.Focus()
        Me.dgProductType.Enabled = False
        Me.dgModel.Enabled = False
    End Sub

    Private Sub dgModel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgModel.CellClick
        If Me.dgModel.Rows.Count <> 0 Then
            Me.NewToolStripButton.Enabled = True
            Me.EditToolStripButton.Enabled = True
            Me.SaveToolStripButton.Enabled = False
            Me.CancelToolStripButton.Enabled = False
            Me.DeleteToolStripButton.Enabled = True
            Me.BackToolStripButton.Enabled = True
            Me.NextToolStripButton.Enabled = True
            Me.txtEdit.Enabled = False
            Me.txtEdit.Text = Me.dgModel.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub SaveToolStripButton_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If Me.txtEdit.Text <> Nothing Then
            If MessageBox.Show(Me, "ต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If selectSaveCadit = 1000 Then
                    Call InsertData()
                ElseIf selectSaveCadit = 2000 Then
                    Call UpdateData()
                End If
            End If
        End If
    End Sub

    Private Sub EditToolStripButton_Click_1(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        selectSaveCadit = 2000
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False

        Me.EditProductStripButton.Enabled = False
        Me.BackPStripButton.Enabled = False
        Me.nextPStripButton.Enabled = False
        Me.RefeshPStripButton.Enabled = False
        Me.RefeshModelTool.Enabled = False

        Me.txtEdit.Enabled = True
        Me.txtEdit.Focus()
        Me.dgProductType.Enabled = False
        Me.dgModel.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click_1(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrm()
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click_1(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DeleteData()
        End If
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgModel.CurrentCell = Me.dgModel.Rows(Me.dgModel.CurrentCell.RowIndex - 1).Cells(0)
            Me.txtEdit.Text = Me.dgModel.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgModel.CurrentCell = Me.dgModel.Rows(Me.dgModel.CurrentCell.RowIndex + 1).Cells(0)
            Me.txtEdit.Text = Me.dgModel.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixconfig/productmodelfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class