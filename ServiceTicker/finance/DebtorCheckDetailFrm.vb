Public Class DebtorCheckDetailFrm
    Private Sub GetBank()
        Try
            strSQL = "SELECT bank_name FROM credit_card_bank ORDER BY bank_name;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read
                    Me.ComboBox1.Items.Add(Dr.Item("bank_name"))
                End While
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DebtorCheckDetailFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub DebtorCheckDetailFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = MainFrm.Icon
        Me.Location = New Point(System.Windows.Forms.Cursor.Position.X - 300, System.Windows.Forms.Cursor.Position.Y - 100)
        Call GetBank()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ComboBox1.Text = Nothing Or Me.TextBox1.Text = Nothing Then
            MessageBox.Show(Me, "กรุณากรอข้อมูลให้ครบถ้วน", "ใส่ข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If cashSelectDetail = "CashSaleFrm" Then
                CashSaleFrm.txtCashByselectPayment.Text = "เช็คธนาคาร" & Me.ComboBox1.Text & "/เลขที่ " & Me.TextBox1.Text
            ElseIf cashSelectDetail = "CashFrm" Then
                CashFrm.txtCashByselectPayment.Text = "เช็คธนาคาร" & Me.ComboBox1.Text & "/เลขที่ " & Me.TextBox1.Text
            Else
                DebtorFrm.txtDTpayments.Text = "เช็คธนาคาร" & Me.ComboBox1.Text & "/เลขที่ " & Me.TextBox1.Text
            End If
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        For Each form In My.Application.OpenForms
            If (form.name = CreditCardManagFrm.Name) Then
                If form.Visible Then
                    CreditCardManagFrm.WindowState = FormWindowState.Normal
                    CreditCardManagFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ตั้งค่าข้อมูลบัตรเครดิต")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            CreditCardManagFrm.Show(Me)
            CreditCardManagFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class