Public Class MiniReturnProductFrm
    Private Sub btnMRPcancel_Click(sender As Object, e As EventArgs) Handles btnMRPcancel.Click
        Me.Close()
    End Sub

    Private Sub MiniReturnProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub MiniReturnProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtMRPnumpro1.Text = Me.txtMRPnumPro.Text
    End Sub

    Private Sub btnMRPok_Click(sender As Object, e As EventArgs) Handles btnMRPok.Click
        If Me.txtMRPnumpro1.Text = Nothing Then
            Me.txtMRPnumpro1.Text = Me.txtMRPnumPro.Text
        End If
        Call btnClickok()
    End Sub

    Private Sub btnClickok()
        Try
            For g As Integer = 0 To ReturnsProductFrm.dgRPsendProBarcode.Rows.Count - 1
                If ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(0).Value = ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(0).Value Then
                    Dim CN As Integer = CInt(ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value) + CInt(Me.txtMRPnumpro1.Text)
                    If CN > CInt(ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(3).Value) Then
                        MsgBox("จำนวนที่คืนมีมากกว่าจำนวนที่ขาย ไม่สามารถคืนมากกว่าจำนวนที่ขายได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Exit Sub
                    ElseIf CN <= CInt(ReturnsProductFrm.dgRPproBarcode.Rows(g).Cells(3).Value) Then
                        ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value = CInt(ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value) + CInt(Me.txtMRPnumpro1.Text)
                        ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(5).Value = (CDec(ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(5).Value) _
                                                                                / CDec(ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(3).Value)) _
                                                                                * CDec(ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value)

                        Me.Close()
                        Exit Sub
                    End If
                End If
            Next
            If CInt(Me.txtMRPnumpro1.Text) > CInt(Me.txtMRPnumPro.Text) Then
                MsgBox("ปริมาณคืน มีจำนวนมากกว่าปริมาณที่สามารถคืนได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf CInt(Me.txtMRPnumpro1.Text) <= 0 Then
                MsgBox("ปริมาณคืน มีค่าเป็น 0 หรือน้อยกว่า 0 ไม่ได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            Else
                Dim ff As Integer = ReturnsProductFrm.dgRPsendProBarcode.Rows.Count
                ReturnsProductFrm.dgRPsendProBarcode.Rows.Add()
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(0).Value = ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(0).Value
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(1).Value = ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(1).Value
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(2).Value = ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(2).Value
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(3).Value = CInt(Me.txtMRPnumpro1.Text)
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(4).Value = ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(4).Value
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(5).Value = (CDec(ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(5).Value) _
                                                                                / CDec(ReturnsProductFrm.dgRPproBarcode.CurrentRow.Cells(3).Value)) _
                                                                                * CDec(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(3).Value)
                ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(7).Value = ((CDec(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(2).Value) * CDec(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(3).Value)) _
                                                        - CDec(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(5).Value)) - CDec(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(6).Value)

                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMRPnumpro1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMRPnumpro1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtMRPnumpro1.Text = Nothing Then
                Me.txtMRPnumpro1.Text = Me.txtMRPnumPro.Text
            End If
            Call btnClickok()
        End If
    End Sub

    Private Sub txtMRPnumpro1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMRPnumpro1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtMRPnumPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMRPnumPro.KeyPress
        e.Handled = True
    End Sub
End Class