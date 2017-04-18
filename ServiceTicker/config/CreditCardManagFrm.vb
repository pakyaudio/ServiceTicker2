Imports MySql.Data.MySqlClient

Public Class CreditCardManagFrm
    'ดึงข้อมูลบัตรเครดิต
    Private Sub getCreditCard()
        Try
            Me.dgCCMcredit.Rows.Clear()
            cmd = New MySqlCommand("SELECT card_type FROM credit_card", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgCCMcredit
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("card_type")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    'ดึงข้อมูลแบ้งก์
    Private Sub getCreditCardBank()
        Try
            Me.dgCCMbank.Rows.Clear()
            cmd = New MySqlCommand("SELECT bank_name FROM credit_card_bank", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgCCMbank
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("bank_name")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub CreditCardManagFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CreditCardManagFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrmCadit()
        Call startfrmBank()
    End Sub

    Private Sub startfrmCadit()

        Me.NewCaditToolStripButton.Enabled = True
        Me.EditCaditToolStripButton.Enabled = False
        Me.SaveCaditToolStripButton.Enabled = False
        Me.CancelCaditToolStripButton.Enabled = False
        Me.DeleteCaditToolStripButton.Enabled = False
        Me.BackCaditToolStripButton.Enabled = False
        Me.NextCaditToolStripButton.Enabled = False
        Me.txtCCMcredit.Enabled = False
        Me.dgCCMcredit.Enabled = True
        Me.txtCCMcredit.Clear()
        Call getCreditCard()

        Me.dgCCMcredit.ClearSelection()

    End Sub

    Private Sub startfrmBank()
        Me.NewBankToolStripButton.Enabled = True
        Me.EditBankToolStripButton.Enabled = False
        Me.SaveBankToolStripButton.Enabled = False
        Me.CancelBankToolStripButton.Enabled = False
        Me.DeleteBankToolStripButton.Enabled = False
        Me.BackBankToolStripButton.Enabled = False
        Me.NextBankToolStripButton.Enabled = False
        Me.txtCCMBbank.Enabled = False
        Me.dgCCMbank.Enabled = True
        Me.txtCCMBbank.Clear()
        Call getCreditCardBank()

        Me.dgCCMbank.ClearSelection()

    End Sub

    Private Sub dgCCMcredit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCMcredit.CellClick
        Me.NewCaditToolStripButton.Enabled = True
        Me.EditCaditToolStripButton.Enabled = True
        Me.SaveCaditToolStripButton.Enabled = False
        Me.CancelCaditToolStripButton.Enabled = False
        Me.DeleteCaditToolStripButton.Enabled = True
        Me.BackCaditToolStripButton.Enabled = True
        Me.NextCaditToolStripButton.Enabled = True
        Me.txtCCMcredit.Enabled = False
        Me.txtCCMcredit.Text = Me.dgCCMcredit.CurrentRow.Cells(0).Value
    End Sub

    Private Sub BackCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles BackCaditToolStripButton.Click
        Try
            Me.dgCCMcredit.CurrentCell = Me.dgCCMcredit.Rows(Me.dgCCMcredit.CurrentCell.RowIndex - 1).Cells(0)
            Me.txtCCMcredit.Text = Me.dgCCMcredit.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles NextCaditToolStripButton.Click
        Try
            Me.dgCCMcredit.CurrentCell = Me.dgCCMcredit.Rows(Me.dgCCMcredit.CurrentCell.RowIndex + 1).Cells(0)
            Me.txtCCMcredit.Text = Me.dgCCMcredit.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Dim selectSaveCadit As Integer
    Private Sub NewCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles NewCaditToolStripButton.Click
        selectSaveCadit = 1000
        Me.NewCaditToolStripButton.Enabled = False
        Me.EditCaditToolStripButton.Enabled = False
        Me.SaveCaditToolStripButton.Enabled = True
        Me.CancelCaditToolStripButton.Enabled = True
        Me.DeleteCaditToolStripButton.Enabled = False
        Me.BackCaditToolStripButton.Enabled = False
        Me.NextCaditToolStripButton.Enabled = False
        Me.txtCCMcredit.Enabled = True
        Me.txtCCMcredit.Clear()
        Me.dgCCMcredit.ClearSelection()
        Me.dgCCMcredit.Enabled = False
    End Sub

    Private Sub SaveCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveCaditToolStripButton.Click
        If Me.txtCCMcredit.Text <> Nothing Then
            If MessageBox.Show(Me, "ต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If selectSaveCadit = 1000 Then
                    Call InsertCreditCard()
                ElseIf selectSaveCadit = 2000 Then
                    Call UpdateCreditCard()
                End If
            End If
        End If
    End Sub

    Private Sub EditCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditCaditToolStripButton.Click
        selectSaveCadit = 2000
        Me.NewCaditToolStripButton.Enabled = False
        Me.EditCaditToolStripButton.Enabled = False
        Me.SaveCaditToolStripButton.Enabled = True
        Me.CancelCaditToolStripButton.Enabled = True
        Me.DeleteCaditToolStripButton.Enabled = False
        Me.BackCaditToolStripButton.Enabled = False
        Me.NextCaditToolStripButton.Enabled = False
        Me.txtCCMcredit.Enabled = True
        Me.dgCCMcredit.Enabled = False
    End Sub

    Private Sub DeleteCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteCaditToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DeleteCreditCard()
        End If
    End Sub

    Private Sub CancelCaditToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelCaditToolStripButton.Click
        Call startfrmCadit()
    End Sub

    Private Sub InsertCreditCard()
        Try
            cmd = New MySqlCommand("INSERT INTO credit_card(card_type)VALUES('" & Me.txtCCMcredit.Text & "')", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call startfrmCadit()
                selectSaveCadit = Nothing
            ElseIf save = 0 Then
                MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub UpdateCreditCard()
        Try
            cmd = New MySqlCommand("UPDATE credit_card SET card_type='" & Me.txtCCMcredit.Text & "' WHERE card_type='" & Me.dgCCMcredit.CurrentRow.Cells(0).Value & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call startfrmCadit()
                selectSaveCadit = Nothing
            ElseIf save = 0 Then
                MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub DeleteCreditCard()
        Try
            cmd = New MySqlCommand("DELETE FROM credit_card WHERE card_type='" & Me.txtCCMcredit.Text & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MainFrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
                Call startfrmCadit()
                selectSaveCadit = Nothing
            ElseIf save = 0 Then
                MainFrm.lblMainStatus.Text = "ลบข้อมูลไม่สำเร็จ"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Dim selectSaveBank As Integer
    Private Sub dgCCMbank_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCMbank.CellClick
        Me.NewBankToolStripButton.Enabled = True
        Me.EditBankToolStripButton.Enabled = True
        Me.SaveBankToolStripButton.Enabled = False
        Me.CancelBankToolStripButton.Enabled = False
        Me.DeleteBankToolStripButton.Enabled = True
        Me.BackBankToolStripButton.Enabled = True
        Me.NextBankToolStripButton.Enabled = True
        Me.txtCCMBbank.Enabled = False
        Me.txtCCMBbank.Text = Me.dgCCMbank.CurrentRow.Cells(0).Value
    End Sub

    Private Sub BackBankToolStripButton_Click(sender As Object, e As EventArgs) Handles BackBankToolStripButton.Click
        Try
            Me.dgCCMbank.CurrentCell = Me.dgCCMbank.Rows(Me.dgCCMbank.CurrentCell.RowIndex - 1).Cells(0)
            Me.txtCCMBbank.Text = Me.dgCCMbank.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextBankToolStripButton_Click(sender As Object, e As EventArgs) Handles NextBankToolStripButton.Click
        Try
            Me.dgCCMbank.CurrentCell = Me.dgCCMbank.Rows(Me.dgCCMbank.CurrentCell.RowIndex + 1).Cells(0)
            Me.txtCCMBbank.Text = Me.dgCCMbank.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewBankToolStripButton_Click(sender As Object, e As EventArgs) Handles NewBankToolStripButton.Click
        selectSaveBank = 1000
        Me.NewBankToolStripButton.Enabled = False
        Me.EditBankToolStripButton.Enabled = False
        Me.SaveBankToolStripButton.Enabled = True
        Me.CancelBankToolStripButton.Enabled = True
        Me.DeleteBankToolStripButton.Enabled = False
        Me.BackBankToolStripButton.Enabled = False
        Me.NextBankToolStripButton.Enabled = False
        Me.txtCCMBbank.Enabled = True
        Me.txtCCMBbank.Clear()
        Me.dgCCMbank.ClearSelection()
        Me.dgCCMbank.Enabled = False
    End Sub

    Private Sub EditBankToolStripButton_Click(sender As Object, e As EventArgs) Handles EditBankToolStripButton.Click
        selectSaveBank = 2000
        Me.NewBankToolStripButton.Enabled = False
        Me.EditBankToolStripButton.Enabled = False
        Me.SaveBankToolStripButton.Enabled = True
        Me.CancelBankToolStripButton.Enabled = True
        Me.DeleteBankToolStripButton.Enabled = False
        Me.BackBankToolStripButton.Enabled = False
        Me.NextBankToolStripButton.Enabled = False
        Me.txtCCMBbank.Enabled = True
        Me.dgCCMbank.Enabled = False
    End Sub

    Private Sub SaveBankToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveBankToolStripButton.Click
        If Me.txtCCMBbank.Text <> Nothing Then
            If MessageBox.Show(Me, "ต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If selectSaveBank = 1000 Then
                    Call InsertBank()
                ElseIf selectSaveBank = 2000 Then
                    Call UpdateBank()
                End If
            End If
        End If
    End Sub
  
    Private Sub CancelBankToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelBankToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการยกเลิก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call startfrmBank()
        End If
    End Sub

    Private Sub DeleteBankToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteBankToolStripButton.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DeleteBank()
        End If
    End Sub

    'add edit del bank
    Private Sub InsertBank()
        Try
            cmd = New MySqlCommand("INSERT INTO credit_card_bank(bank_name)VALUES('" & Me.txtCCMBbank.Text & "')", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MainFrm.lblMainStatus.Text = "บันทึกข้อมูลแล้ว"
                Call startfrmBank()
                selectSaveBank = Nothing
            ElseIf save = 0 Then
                MainFrm.lblMainStatus.Text = "บันทึกข้อมูลไม่สำเร็จ"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub UpdateBank()
        Try
            cmd = New MySqlCommand("UPDATE credit_card_bank SET bank_name='" & Me.txtCCMBbank.Text & "' WHERE bank_name='" & Me.dgCCMbank.CurrentRow.Cells(0).Value & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MainFrm.lblMainStatus.Text = "บันทึกข้อมูลแล้ว"
                Call startfrmBank()
                selectSaveBank = Nothing
            ElseIf save = 0 Then
                MainFrm.lblMainStatus.Text = "บันทึกข้อมูลไม่สำเร็จ"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub DeleteBank()
        Try
            cmd = New MySqlCommand("DELETE FROM credit_card_bank WHERE bank_name='" & Me.txtCCMBbank.Text & "'", ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MainFrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
                Call startfrmBank()
                selectSaveBank = Nothing
            ElseIf save = 0 Then
                MainFrm.lblMainStatus.Text = "ลบข้อมูลไม่สำเร็จ"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnHelp_Click_1(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/appconfig/bankconfig")
        Catch ex As Exception

        End Try
    End Sub
End Class