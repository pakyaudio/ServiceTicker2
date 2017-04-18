Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class StartAuditFrm
    Private Sub SUMmoney()
        Dim t1, t2, t5, t10, t20, t50, t100, t500, t1000 As Integer
        Try
            t1 = CInt(Me.nudAD1.Text) * CInt(1)
            t2 = CInt(Me.nudAD2.Text) * CInt(2)
            t5 = CInt(Me.nudAD5.Text) * CInt(5)
            t10 = CInt(Me.nudAD10.Text) * CInt(10)
            t20 = CInt(Me.nudAD20.Text) * CInt(20)
            t50 = CInt(Me.nudAD50.Text) * CInt(50)
            t100 = CInt(Me.nudAD100.Text) * CInt(100)
            t500 = CInt(Me.nudAD500.Text) * CInt(500)
            t1000 = CInt(Me.nudAD1000.Text) * CInt(1000)
            Me.txtADtotalAll.Text = t1 + t2 + t5 + t10 + t20 + t50 + t100 + t500 + t1000
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Save()

        If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "INSERT INTO audit(datetime,money1,money2,money5,money10,money20,money50,money100," _
                    & "money500,money1000,totalAll,`check`,transfer,cash,charges,deliverMorning,deliverNoon,deliverEvening,totalDeliver,difference)" _
                            & "VALUES(@datetime,@money1,@money2,@money5,@money10,@money20,@money50,@money100," _
                            & "@money500,@money1000,@totalAll,@check,@transfer,@cash,@charges,@deliverMorning," _
                            & "@deliverNoon,@deliverEvening,@totalDeliver,@difference)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@datetime", "start")
                cmd.Parameters.AddWithValue("@money1", Me.nudAD1.Text)
                cmd.Parameters.AddWithValue("@money2", Me.nudAD2.Text)
                cmd.Parameters.AddWithValue("@money5", Me.nudAD5.Text)
                cmd.Parameters.AddWithValue("@money10", Me.nudAD10.Text)
                cmd.Parameters.AddWithValue("@money20", Me.nudAD20.Text)
                cmd.Parameters.AddWithValue("@money50", Me.nudAD50.Text)
                cmd.Parameters.AddWithValue("@money100", Me.nudAD100.Text)
                cmd.Parameters.AddWithValue("@money500", Me.nudAD500.Text)
                cmd.Parameters.AddWithValue("@money1000", Me.nudAD1000.Text)
                cmd.Parameters.AddWithValue("@totalAll", Me.txtADtotalAll.Text)
                cmd.Parameters.AddWithValue("@check", "0")
                cmd.Parameters.AddWithValue("@transfer", "0")
                cmd.Parameters.AddWithValue("@cash", "0")
                cmd.Parameters.AddWithValue("@charges", "0")
                cmd.Parameters.AddWithValue("@deliverMorning", "0")
                cmd.Parameters.AddWithValue("@deliverNoon", "0")
                cmd.Parameters.AddWithValue("@deliverEvening", "0")
                cmd.Parameters.AddWithValue("@totalDeliver", "0")
                cmd.Parameters.AddWithValue("@difference", "0")
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO audit(datetime,money1,money2,money5,money10,money20,money50,money100,money500," _
                    & "money1000,totalAll,`check`,transfer,cash,charges,deliverMorning,deliverNoon,deliverEvening,totalDeliver,difference)" _
                           & "VALUES(@datetime,@money1,@money2,@money5,@money10,@money20,@money50,@money100,@money500," _
                           & "@money1000,@totalAll,@check,@transfer,@cash,@charges,@deliverMorning,@deliverNoon,@deliverEvening,@totalDeliver,@difference)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@datetime", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
                cmd.Parameters.AddWithValue("@money1", Me.nudAD1.Text)
                cmd.Parameters.AddWithValue("@money2", Me.nudAD2.Text)
                cmd.Parameters.AddWithValue("@money5", Me.nudAD5.Text)
                cmd.Parameters.AddWithValue("@money10", Me.nudAD10.Text)
                cmd.Parameters.AddWithValue("@money20", Me.nudAD20.Text)
                cmd.Parameters.AddWithValue("@money50", Me.nudAD50.Text)
                cmd.Parameters.AddWithValue("@money100", Me.nudAD100.Text)
                cmd.Parameters.AddWithValue("@money500", Me.nudAD500.Text)
                cmd.Parameters.AddWithValue("@money1000", Me.nudAD1000.Text)
                cmd.Parameters.AddWithValue("@totalAll", Me.txtADtotalAll.Text)
                cmd.Parameters.AddWithValue("@check", "0")
                cmd.Parameters.AddWithValue("@transfer", "0")
                cmd.Parameters.AddWithValue("@cash", "0")
                cmd.Parameters.AddWithValue("@charges", "0")
                cmd.Parameters.AddWithValue("@deliverMorning", "0")
                cmd.Parameters.AddWithValue("@deliverNoon", "0")
                cmd.Parameters.AddWithValue("@deliverEvening", "0")
                cmd.Parameters.AddWithValue("@totalDeliver", "0")
                cmd.Parameters.AddWithValue("@difference", "0")
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "สำเร็จ")
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Call MainFrm.checkAccess("ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย")
            If MainFrm.access = 1 Then
                MiniAllLoginFrm.ShowDialog(Me)
            ElseIf MainFrm.access = 0 Then
                AuditFrm.Show(Me)
                AuditFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            Else
                MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Close()
        End If

    End Sub
    Private Sub StartAuditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call SUMmoney()
        Call Save()
    End Sub

    Private Sub nudAD1_Click(sender As Object, e As EventArgs) Handles nudAD1.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD2_Click(sender As Object, e As EventArgs) Handles nudAD2.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD5_Click(sender As Object, e As EventArgs) Handles nudAD5.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD50_Click(sender As Object, e As EventArgs) Handles nudAD50.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD20_Click(sender As Object, e As EventArgs) Handles nudAD20.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD100_Click(sender As Object, e As EventArgs) Handles nudAD100.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD500_Click(sender As Object, e As EventArgs) Handles nudAD500.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD1000_Click(sender As Object, e As EventArgs) Handles nudAD1000.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD10_Click(sender As Object, e As EventArgs) Handles nudAD10.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD1_ValueChanged(sender As Object, e As EventArgs) Handles nudAD1.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD2_ValueChanged(sender As Object, e As EventArgs) Handles nudAD2.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD5_ValueChanged(sender As Object, e As EventArgs) Handles nudAD5.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD10_ValueChanged(sender As Object, e As EventArgs) Handles nudAD10.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD20_ValueChanged(sender As Object, e As EventArgs) Handles nudAD20.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD50_ValueChanged(sender As Object, e As EventArgs) Handles nudAD50.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD100_ValueChanged(sender As Object, e As EventArgs) Handles nudAD100.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD500_ValueChanged(sender As Object, e As EventArgs) Handles nudAD500.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD1000_ValueChanged(sender As Object, e As EventArgs) Handles nudAD1000.ValueChanged
        Call SUMmoney()
    End Sub
End Class