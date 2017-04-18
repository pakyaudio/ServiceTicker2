Imports MySql.Data.MySqlClient

Public Class FixHitoryBySNFrm
    Private Sub addRows()
        For rRow As Integer = 0 To 17
            Me.DataGridView2.Rows.Add()
        Next
        With Me.DataGridView2
            .Rows(0).Cells(0).Value = "#"
            .Rows(1).Cells(0).Value = "รหัสซ่อม"
            .Rows(2).Cells(0).Value = "วันที่รับ"
            .Rows(3).Cells(0).Value = "รหัสลูกค้า"
            .Rows(4).Cells(0).Value = "ชื่อลูกค้า"
            .Rows(5).Cells(0).Value = "SN"
            .Rows(6).Cells(0).Value = "ประเภท"
            .Rows(7).Cells(0).Value = "ยี่ห้อ"
            .Rows(8).Cells(0).Value = "รุ่น"
            .Rows(9).Cells(0).Value = "สี"
            .Rows(10).Cells(0).Value = "อาการเสีย"
            .Rows(11).Cells(0).Value = "การจัดการข้อมูล"
            .Rows(12).Cells(0).Value = "อุปกรณ์ที่นำมาด้วย"
            .Rows(13).Cells(0).Value = "ผู้ซ่อม"
            .Rows(14).Cells(0).Value = "บักทึกซ่อม"
            .Rows(15).Cells(0).Value = "แจ้งลูกค้า"
            .Rows(16).Cells(0).Value = "ซ่อมเสร็จ"
            .Rows(17).Cells(0).Value = "วันที่ส่งคืน"
        End With
    End Sub
    Protected Sub getdata()
        Try
            cmd = New MySqlCommand("SELECT fix_id,date_save,customer_id,customer_name,sn,symptom," _
                                   & "managerdata,fixaccessory,user_repair,note_repair,teltocus," _
                                   & "date_send,datecom_repair FROM comfix WHERE " _
                                   & "sn='" & SaveDataFixFrm.dgSDFlistComfix.CurrentRow.Cells(3).Value & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read()
                    Dim r As Integer
                    With Me.DataGridView1
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                        .Rows(r).Cells(2).Value = Dr.Item("date_save")
                        .Rows(r).Cells(3).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("customer_name")
                        .Rows(r).Cells(5).Value = Dr.Item("sn")

                        .Rows(r).Cells(10).Value = Dr.Item("symptom")
                        .Rows(r).Cells(11).Value = Dr.Item("managerdata")
                        .Rows(r).Cells(12).Value = Dr.Item("fixaccessory")
                        .Rows(r).Cells(13).Value = Dr.Item("user_repair")
                        .Rows(r).Cells(14).Value = Dr.Item("note_repair")
                        .Rows(r).Cells(15).Value = Dr.Item("teltocus")
                        .Rows(r).Cells(16).Value = Dr.Item("datecom_repair")
                        .Rows(r).Cells(17).Value = Dr.Item("date_send")
                    End With
                End While
            Else
                MessageBox.Show(Me, "ไม่พบข้อมูลประวัติงานซ่อม", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For snnum As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            cmd = New MySqlCommand("SELECT p_type,p_name,model,color FROM sn WHERE Snum='" & Me.DataGridView1.Rows(snnum).Cells(5).Value & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.DataGridView1.Rows(snnum).Cells(6).Value = Dr.Item("p_type")
            Me.DataGridView1.Rows(snnum).Cells(7).Value = Dr.Item("p_name")
            Me.DataGridView1.Rows(snnum).Cells(8).Value = Dr.Item("model")
            Me.DataGridView1.Rows(snnum).Cells(9).Value = Dr.Item("color")
        Next
    End Sub

    Private Sub FixHitoryBySNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub FixHitoryBySNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call addRows()
        Call getdata()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Me.DataGridView1.Rows.Count <> 0 Then
            Me.DataGridView2.Rows(0).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(0).Value
            Me.DataGridView2.Rows(1).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(1).Value
            Me.DataGridView2.Rows(2).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(2).Value
            Me.DataGridView2.Rows(3).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(3).Value
            Me.DataGridView2.Rows(4).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(4).Value
            Me.DataGridView2.Rows(5).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(5).Value
            Me.DataGridView2.Rows(6).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(6).Value
            Me.DataGridView2.Rows(7).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(7).Value
            Me.DataGridView2.Rows(8).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(8).Value
            Me.DataGridView2.Rows(9).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(9).Value
            Me.DataGridView2.Rows(10).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(10).Value
            Me.DataGridView2.Rows(11).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(11).Value
            Me.DataGridView2.Rows(12).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(12).Value
            Me.DataGridView2.Rows(13).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(13).Value
            Me.DataGridView2.Rows(14).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(14).Value
            Me.DataGridView2.Rows(15).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(15).Value
            Me.DataGridView2.Rows(16).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(16).Value
            Me.DataGridView2.Rows(17).Cells(1).Value = Me.DataGridView1.CurrentRow.Cells(17).Value
            Try
                cmd = New MySqlCommand("SELECT sn_img FROM sn WHERE Snum='" & Me.DataGridView1.CurrentRow.Cells(5).Value & "'", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                PictureBox1.Image = Byte2Image(Dr.Item("sn_img"))
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub
End Class