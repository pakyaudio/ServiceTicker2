Public Class UsersImageZoomFrm

    Private Sub UsersImageZoomFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub UsersImageZoomFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        PictureBox1.Image = UsersFrm.PicUsers.Image
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class