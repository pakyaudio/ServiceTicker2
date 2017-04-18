Public Class BankBookFrm
#Region "code"
    Private Sub LoaddataBank()
        Try
            Me.dgBankAcc.Rows.Clear()
            strSQL = "SELECT id,bank_name,acc_name,acc_num,bank_section,employee,datetime_edit FROM book_bank ORDER BY bank_name;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read
                    With Me.dgBankAcc
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Tag = Dr.Item("id")
                        .Rows(r).Cells(0).Value = Dr.Item("bank_name")
                        .Rows(r).Cells(1).Value = Dr.Item("acc_name")
                        .Rows(r).Cells(2).Value = Dr.Item("acc_num")
                        .Rows(r).Cells(3).Value = Dr.Item("bank_section")
                        .Rows(r).Cells(4).Value = Dr.Item("datetime_edit")
                        .Rows(r).Cells(5).Value = Dr.Item("employee")
                    End With
                End While
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub UpdateData()
        If Me.txtBankName.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง ชื่อธนาคาร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtBankName.Focus()
            Exit Sub
        End If

        If Me.txtAccName.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง ชื่อบัญชี", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtAccName.Focus()
            Exit Sub
        End If

        If Me.txtAccNumber.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง เลขบัญชี", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtAccNumber.Focus()
            Exit Sub
        End If

        If Me.txtBankSection.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง สาขา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtBankSection.Focus()
            Exit Sub
        End If

        Try
            strSQL = "UPDATE book_bank SET bank_name=@bank_name,acc_name=@acc_name," _
                & "acc_num=@acc_num,bank_section=@bank_section,employee=@employee WHERE id=@id"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.Parameters.AddWithValue("@id", Me.txtBankName.Tag)
            cmd.Parameters.AddWithValue("@bank_name", Me.txtBankName.Text)
            cmd.Parameters.AddWithValue("@acc_name", Me.txtAccName.Text)
            cmd.Parameters.AddWithValue("@acc_num", Me.txtAccNumber.Text)
            cmd.Parameters.AddWithValue("@bank_section", Me.txtBankSection.Text)
            cmd.Parameters.AddWithValue("@employee", Me.lblEmployee.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call startFrm()
    End Sub

    Private Sub AddData()
        If Me.txtBankName.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง ชื่อธนาคาร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtBankName.Focus()
            Exit Sub
        End If

        If Me.txtAccName.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง ชื่อบัญชี", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtAccName.Focus()
            Exit Sub
        End If

        If Me.txtAccNumber.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง เลขบัญชี", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtAccNumber.Focus()
            Exit Sub
        End If

        If Me.txtBankSection.Text = Nothing Then
            MessageBox.Show(Me, "ไม่ควรว่าง สาขา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtBankSection.Focus()
            Exit Sub
        End If

        Try
            strSQL = "INSERT INTO book_bank(bank_name,acc_name,acc_num,bank_section,employee)" _
                & "VALUES(@bank_name,@acc_name,@acc_num,@bank_section,@employee)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.Parameters.AddWithValue("@bank_name", Me.txtBankName.Text)
            cmd.Parameters.AddWithValue("@acc_name", Me.txtAccName.Text)
            cmd.Parameters.AddWithValue("@acc_num", Me.txtAccNumber.Text)
            cmd.Parameters.AddWithValue("@bank_section", Me.txtBankSection.Text)
            cmd.Parameters.AddWithValue("@employee", Me.lblEmployee.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call startFrm()
    End Sub

    Private Sub DelData()
        Try
            strSQL = "DELETE FROM book_bank WHERE id='" & Me.txtBankName.Tag & "';"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MessageBox.Show(Me, "ลบข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call startFrm()
    End Sub


    Private Sub startFrm()

        Me.txtAccName.Clear()
        Me.txtAccNumber.Clear()
        Me.txtBankSection.Clear()

        Me.btnAdd.Enabled = True
        'Me.btnSearchBank.Enabled = False
        Me.btnSave.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDel.Enabled = False
        Me.btnCancel.Enabled = False

        Me.txtAccName.Enabled = False
        Me.txtAccNumber.Enabled = True
        Me.txtBankName.Items.Clear()
        Me.txtAccNumber.Enabled = False
        Me.txtBankName.Enabled = False
        Me.txtBankSection.Enabled = False

        Me.dgBankAcc.Enabled = True
        Call LoaddataBank()
    End Sub
#End Region
    Private Sub BankBookFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub BankBookFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startFrm()
    End Sub

    Private Sub dgBankAcc_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBankAcc.CellDoubleClick
        If Me.dgBankAcc.Rows.Count <> 0 Then
            With Me.dgBankAcc.CurrentRow
                Me.txtBankName.Tag = .Cells(0).Tag
                Me.txtBankName.Text = .Cells(0).Value
                Me.txtAccName.Text = .Cells(1).Value
                Me.txtAccNumber.Text = .Cells(2).Value
                Me.txtBankSection.Text = .Cells(3).Value
            End With
            'Me.btnSearchBank.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnAdd.Enabled = False
            Me.btnEdit.Enabled = True
            Me.btnDel.Enabled = True
            Me.btnCancel.Enabled = True
        End If
    End Sub

    Dim newdata As Boolean
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.txtBankName.Enabled = True
        Me.txtAccName.Enabled = True
        Me.txtAccNumber.Enabled = True
        Me.txtBankSection.Enabled = True

        'Me.btnSearchBank.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDel.Enabled = False
        Me.btnCancel.Enabled = True

        Me.dgBankAcc.Enabled = False
        newdata = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If newdata = False Then
            Call UpdateData()
        ElseIf newdata = True Then
            Call AddData()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call startFrm()
        Me.txtBankName.Enabled = True
        Me.txtAccName.Enabled = True
        Me.txtAccNumber.Enabled = True
        Me.txtBankSection.Enabled = True

        'Me.btnSearchBank.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDel.Enabled = False
        Me.btnCancel.Enabled = True

        Me.dgBankAcc.Enabled = False
        newdata = True
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DelData()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call startFrm()
    End Sub

    Private Sub btnSearchBank_Click(sender As Object, e As EventArgs)
        MsgBox(Me.txtBankName.Tag)
    End Sub

    Private Sub txtBankName_DropDown(sender As Object, e As EventArgs) Handles txtBankName.DropDown
        Try
            Me.txtBankName.Items.Clear()
            strSQL = "SELECT * FROM credit_card_bank ORDER BY bank_name;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read
                    Me.txtBankName.Items.Add(Dr.Item("bank_name"))
                End While
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtBankName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBankName.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/bookbankfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class