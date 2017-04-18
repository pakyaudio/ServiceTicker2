Imports System.Globalization

Public Class AccessLavelEditFrm

    Private Sub AccessLavelEditFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub AccessLavelEditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Friend Sub GetAccess(ByVal aid As Integer)
        Try
            Me.cbbLavel.DataSource = Nothing
            dt = New DataTable
            Me.cbbLavel.DisplayMember = "Name"
            Me.cbbLavel.ValueMember = "ID"
            dt.Columns.Add("Name", GetType(String))
            dt.Columns.Add("ID", GetType(String))
            dt.Rows.Add("ผู้ใช้งาน", 1)
            dt.Rows.Add("หัวหน้า", 2)
            dt.Rows.Add("ผู้ดูแลระบบ", 3)
            Me.cbbLavel.DataSource = dt

        Catch ex As Exception

        End Try

        Try
            Me.cbbLogin.DataSource = Nothing
            dt = New DataTable
            Me.cbbLogin.DisplayMember = "Name"
            Me.cbbLogin.ValueMember = "ID"
            dt.Columns.Add("Name", GetType(String))
            dt.Columns.Add("ID", GetType(String))
            dt.Rows.Add("ไม่ต้องยืนยันตัวตนก่อนเข้าใช้งาน", 0)
            dt.Rows.Add("ยืนยันตัวตนก่อนเข้าใช้งาน", 1)
            Me.cbbLogin.DataSource = dt
        Catch ex As Exception

        End Try
        Try
            strSQL = "SELECT id,access,zone,link,leval,datetime_edit,menu FROM access_lavel WHERE id='" & aid & "';"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                Dr.Read()
                Me.txtALmenu.Tag = Dr.Item("id")
                Me.txtALmenu.Text = Dr.Item("link")
                Me.lblDateEdit.Text = "แก้ไขล่าสุด " & Dr.Item("datetime_edit")
                Dim lavel As Integer = Dr.Item("leval")
                If lavel = 1 Then
                    Me.cbbLavel.SelectedValue = 1
                ElseIf lavel = 2 Then
                    Me.cbbLavel.SelectedValue = 2
                ElseIf lavel = 3 Then
                    Me.cbbLavel.SelectedValue = 3
                End If
                Dim lg As Integer = Dr.Item("access")
                If lg = 0 Then
                    Me.cbbLogin.SelectedValue = 0
                ElseIf lg = 1 Then
                    Me.cbbLogin.SelectedValue = 1
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            strSQL = "UPDATE access_lavel SET access=@access,leval=@leval,datetime_edit=@datetime_edit WHERE id=@id;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@access", Me.cbbLogin.SelectedValue)
            cmd.Parameters.AddWithValue("@leval", Me.cbbLavel.SelectedValue)
            cmd.Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
            cmd.Parameters.AddWithValue("@id", Me.txtALmenu.Tag)
            Call open_connection()
            Dim s As Integer
            s = cmd.ExecuteNonQuery()
            If s = 1 Then
                MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbLavel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbLavel.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbLogin.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtALmenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtALmenu.KeyPress
        e.Handled = True
    End Sub
End Class