Public Class DebtorBookbankDetailFrm
    Private Sub GetBank()
        Try
            Me.ListView1.Items.Clear()
            Me.ListView1.Columns.Add("ธนาคาร", 100)
            Me.ListView1.Columns.Add("สาขา", 100)
            Me.ListView1.Columns.Add("ชื่อบัญชี", 150)
            Me.ListView1.Columns.Add("หมายเลขบัญชี", 150)
            strSQL = "SELECT bank_name,acc_name,acc_num,bank_section FROM book_bank ORDER BY bank_name"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read
                    Dim bk As String = Dr.Item("bank_name")
                    Dim lv As New ListViewItem(bk)
                    lv.SubItems.Add(Dr.Item("bank_section"))
                    lv.SubItems.Add(Dr.Item("acc_name"))
                    lv.SubItems.Add(Dr.Item("acc_num"))
                    ListView1.Items.Add(lv)
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

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                If cashSelectDetail = "CashSaleFrm" Then
                    CashSaleFrm.txtCashByselectPayment.Text = Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text _
                        & ", สาขา" & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text _
                        & ", ชื่อบัญชี " & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text _
                        & ", หมายเลขบัญชี " & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text
                    Me.Close()
                ElseIf cashSelectDetail = "CashFrm" Then
                    CashFrm.txtCashByselectPayment.Text = Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text _
                        & ", สาขา" & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text _
                        & ", ชื่อบัญชี " & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text _
                        & ", หมายเลขบัญชี " & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text
                    Me.Close()
                Else
                    DebtorFrm.txtDTpayments.Text = Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text _
                        & ", สาขา" & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text _
                        & ", ชื่อบัญชี " & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text _
                        & ", หมายเลขบัญชี " & Me.ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        For Each form In My.Application.OpenForms
            If (form.name = BankBookFrm.Name) Then
                If form.Visible Then
                    BankBookFrm.WindowState = FormWindowState.Normal
                    BankBookFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ตั้งค่าบัญชีธนาคาร")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            BankBookFrm.Show(Me)
            BankBookFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class