Public Class ReceiveViewPicFrm
    Friend Sub LoadPic(ByVal pa_id)
        Try
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT byte_pic FROM picture_all WHERE pa_id='" & pa_id & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Me.PictureBox1.Image = Byte2Image(Dr.Item("byte_pic"))
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ReceiveViewPicFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReceiveViewPicFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
End Class