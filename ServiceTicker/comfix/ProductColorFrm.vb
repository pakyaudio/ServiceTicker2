Imports MySql.Data.MySqlClient

Public Class ProductColorFrm
    Private Sub startfrm()

        Me.NewToolStripButton.Enabled = True
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = False
        Me.CancelToolStripButton.Enabled = False
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = False
        Me.dgProductType.Enabled = True
        Me.txtEdit.Clear()
        Call getData()

        Me.dgProductType.ClearSelection()

    End Sub

    Private Sub getData()
        Try
            Me.dgProductType.Rows.Clear()
            cmd = New MySqlCommand("SELECT ID,color FROM product_color ORDER BY color", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgProductType
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Tag = Dr.Item("ID")
                    .Rows(r).Cells(0).Value = Dr.Item("color")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ProductColorFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
    End Sub

    Private Sub dgProductType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProductType.CellClick
        If Me.dgProductType.Rows.Count <> 0 Then
            Me.NewToolStripButton.Enabled = True
            Me.EditToolStripButton.Enabled = True
            Me.SaveToolStripButton.Enabled = False
            Me.CancelToolStripButton.Enabled = False
            Me.DeleteToolStripButton.Enabled = True
            Me.BackToolStripButton.Enabled = True
            Me.NextToolStripButton.Enabled = True
            Me.txtEdit.Enabled = False
            Me.txtEdit.Text = Me.dgProductType.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        Try
            Me.dgProductType.CurrentCell = Me.dgProductType.Rows(Me.dgProductType.CurrentCell.RowIndex - 1).Cells(0)
            Me.txtEdit.Text = Me.dgProductType.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs) Handles NextToolStripButton.Click
        Try
            Me.dgProductType.CurrentCell = Me.dgProductType.Rows(Me.dgProductType.CurrentCell.RowIndex + 1).Cells(0)
            Me.txtEdit.Text = Me.dgProductType.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Dim selectSaveCadit As Integer
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        selectSaveCadit = 1000
        Me.NewToolStripButton.Enabled = False
        Me.EditToolStripButton.Enabled = False
        Me.SaveToolStripButton.Enabled = True
        Me.CancelToolStripButton.Enabled = True
        Me.DeleteToolStripButton.Enabled = False
        Me.BackToolStripButton.Enabled = False
        Me.NextToolStripButton.Enabled = False
        Me.txtEdit.Enabled = True
        Me.txtEdit.Clear()
        Me.dgProductType.ClearSelection()
        Me.dgProductType.Enabled = False
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
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

    Private Sub InsertData()
        If checkMySQLDruplicateDB("SELECT color FROM product_color WHERE color='" & Me.txtEdit.Text & "'") = True Then
            MessageBox.Show(Me, "มีรายการนี้อยู่แล้ว กรุณาเปลี่ยนเป็นอย่างอื่น", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                cmd = New MySqlCommand("INSERT INTO product_color(color)VALUES('" & Me.txtEdit.Text & "')", ConnectionDB)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call startfrm()
                    selectSaveCadit = Nothing
                ElseIf save = 0 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub UpdateData()
        If checkMySQLDruplicateDB("SELECT color FROM product_color WHERE " _
                                & "color='" & Me.txtEdit.Text & "' AND NOT color='" & Me.dgProductType.CurrentRow.Cells(0).Value & "'") = True Then
            MessageBox.Show(Me, "มีรายการนี้อยู่แล้ว กรุณาเปลี่ยนเป็นอย่างอื่น", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                cmd = New MySqlCommand("UPDATE product_color SET color='" & Me.txtEdit.Text & "' WHERE ID='" & Me.dgProductType.CurrentRow.Cells(0).Tag & "'", ConnectionDB)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call startfrm()
                    selectSaveCadit = Nothing
                ElseIf save = 0 Then
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
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

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DeleteData()
        End If
    End Sub

    Private Sub DeleteData()
        Try
            cmd = New MySqlCommand("DELETE FROM product_color WHERE color='" & Me.txtEdit.Text & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MessageBox.Show(Me, "ลบข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call startfrm()
                selectSaveCadit = Nothing
            ElseIf save = 0 Then
                MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrm()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixconfig/productcolorfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class