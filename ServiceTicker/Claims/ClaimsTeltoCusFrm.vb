Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsTeltoCusFrm

    Private Sub ClaimsTeltoCusFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ClaimsTeltoCusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.lblCTCteltocus.Text = ClaimsStatusFrm.teltocustel
        ClaimsStatusFrm.teltocustel = Nothing
    End Sub

    Private Sub btnCTCsave_Click(sender As Object, e As EventArgs) Handles btnCTCsave.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox("เลือกการโทรแจ้งก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If MessageBox.Show(Me, "คุณแน่ใจว่าจะเปลี่ยนแปลงข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                Try
                    strSQL = "UPDATE claims SET tel_to_cus='" & Me.ComboBox1.Text & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                                CultureInfo.CreateSpecificCulture("en-US")) & "'" _
                                & ",employee='" & ClaimsStatusFrm.lblEmployee.Text & "' WHERE claims_id='" & Me.lblCTCclaims_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    ClaimsStatusFrm.getdataClaims(200, Nothing)
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Me.Close()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
End Class