Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class AddRepairNoteFrm
    Private Sub AddRepairNoteFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub GetData()
        Me.ListView1.Clear()
        Me.ListView1.Columns.Add("รายละเอียดการซ่อม", 250)
        cmd = New MySqlCommand("SELECT DISTINCT note FROM comfix_note ORDER BY note LIMIT 1000;", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Me.ListView1.Items.Add(Dr.Item("note"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub AddRepairNoteFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetData()
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    If Me.TextBox1.Text <> Nothing Then
                        Me.TextBox1.Text = Me.TextBox1.Text & ", " & Me.ListView1.FocusedItem.Text.ToString
                    Else
                        Me.TextBox1.Text = Me.ListView1.FocusedItem.Text.ToString
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text <> Nothing Then
            If MessageBox.Show(Me, "เมื่อบันทึกจะไม่สามารถลบหรือแก้ไขได้อีก โปรดแน่ใจว่าข้อมูลถูกต้อง", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    strSQL = "INSERT INTO comfix_note(note,key_note,etc,datetime_save)VALUES(@note,@key_note,@etc,@datetime_save)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.Parameters.AddWithValue("@note", Me.TextBox1.Text)
                    cmd.Parameters.AddWithValue("@key_note", RepairStatusFrm.txtRSfix_id.Text)
                    cmd.Parameters.AddWithValue("@etc", RepairStatusFrm.lblEmployee.Text)
                    cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Call RepairStatusFrm.GetComfix_note(RepairStatusFrm.txtRSfix_id.Text)
                Me.Close()
            End If
        End If
    End Sub
End Class