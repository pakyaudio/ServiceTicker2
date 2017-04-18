Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ViewComFixNoteFrm
    ''' <summary>
    ''' โหลดข้อมูล comfix_note SELECT note,datetime_save FROM comfix_note 
    ''' </summary>
    ''' <param name="fixid">เลขใบรับซ่อม</param>
    ''' <remarks></remarks>
    Friend Sub GetComfix_note(ByVal fixid)
        Me.ListView1.Clear()
        Me.ListView1.Columns.Add("รายละเอียดการซ่อม", 230)
        Me.ListView1.Columns.Add("วันที่บันทึก", 140)
        Me.ListView1.Columns.Add("พนักงาน", 100)
        Try
            cmd = New MySqlCommand("SELECT note,etc,datetime_save FROM comfix_note WHERE key_note='" & fixid & "' ORDER BY datetime_save DESC;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim nt As String = Dr.Item("note")
                Dim lsvparent As New ListViewItem(nt)
                lsvparent.SubItems.Add(CDate(Dr.Item("datetime_save")).ToString("dd MMMM yyyy HH:mm"))
                lsvparent.SubItems.Add(Dr.Item("etc"))
                Me.ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ViewComFixNoteFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewComFixNoteFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
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
                Call GetComfix_note(RepairStatusFrm.txtRSfix_id.Text)
                Call RepairStatusFrm.GetComfix_note(RepairStatusFrm.txtRSfix_id.Text)
                Me.TextBox1.Clear()
            End If
        End If
    End Sub
End Class