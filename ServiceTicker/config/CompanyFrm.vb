Imports MySql.Data.MySqlClient

Public Class CompanyFrm

    Private Sub CompanyFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CompanyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
    End Sub

    Private Sub startfrm()
        Me.btnSelectLogo.Enabled = False
        Me.btnCompanyEdit.Text = "แก้ไข"
        Me.btnCompanyCancel.Visible = False
        Call disableTextBoxes(Me)
        Try
            strSQL = "SELECT com_name,com_address,com_tel,com_fax,com_tax,com_line,com_facebook,com_email,com_website,tel_lable,fax_lable,images FROM company;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.txtCompanyName.Text = Dr.Item("com_name")
                Me.txtCompanyAddress.Text = Dr.Item("com_address")
                Me.txtCompanyTel.Text = Dr.Item("com_tel")
                Me.txtCompanyFax.Text = Dr.Item("com_fax")
                Me.txtCompanyTax.Text = Dr.Item("com_tax")
                Me.txtCompanyLine.Text = Dr.Item("com_line")
                Me.txtCompanyFacebook.Text = Dr.Item("com_facebook")
                Me.txtCompanyEmail.Text = Dr.Item("com_email")
                Me.txtCompanyWebsite.Text = Dr.Item("com_website")
                Me.txtTelLable.Text = Dr.Item("tel_lable")
                Me.txtFaxLabel.Text = Dr.Item("fax_lable")
                PictureBox1.Image = Byte2Image(Dr.Item("images"))
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub updateData()
        Try
            strSQL = "UPDATE company SET com_name='" & Me.txtCompanyName.Text & "'," _
                                      & "com_address='" & Me.txtCompanyAddress.Text & "'," _
                                      & "com_tel='" & Me.txtCompanyTel.Text & "'," _
                                      & "com_fax='" & Me.txtCompanyFax.Text & "'," _
                                      & "com_tax='" & Me.txtCompanyTax.Text & "'," _
                                      & "com_line='" & Me.txtCompanyLine.Text & "'," _
                                      & "com_facebook='" & Me.txtCompanyFacebook.Text & "'," _
                                      & "com_email='" & Me.txtCompanyEmail.Text & "'," _
                                      & "com_website='" & Me.txtCompanyWebsite.Text & "'," _
                                      & "tel_lable='" & Me.txtTelLable.Text & "'," _
                                      & "fax_lable='" & Me.txtFaxLabel.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnCompanyEdit_Click(sender As Object, e As EventArgs) Handles btnCompanyEdit.Click
        If Me.btnCompanyEdit.Text = "แก้ไข" Then
            Me.btnSelectLogo.Enabled = True
            Me.btnCompanyEdit.Text = "บันทึก"
            Me.btnCompanyCancel.Visible = True
            Call enableTextBoxes(Me)
        ElseIf Me.btnCompanyEdit.Text = "บันทึก" Then
            Call updateData()
            Call saveimg()
            Me.btnCompanyEdit.Text = "แก้ไข"
            Me.btnSelectLogo.Enabled = False
            Call startfrm()
        End If
    End Sub

    Private Sub btnCompanyCancel_Click(sender As Object, e As EventArgs) Handles btnCompanyCancel.Click
        Call startfrm()
    End Sub
    Private Sub saveimg()
        If imgpath <> Nothing Then
            Try
                strSQL = "UPDATE company SET images=@im"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@im", ConvertImageFiletoBytes(imgpath))
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            imgpath = Nothing
        End If
    End Sub
    Dim imgpath As String

    Private Sub btnSelectLogo_Click(sender As Object, e As EventArgs) Handles btnSelectLogo.Click
        If OpenLogo.ShowDialog = DialogResult.OK AndAlso OpenLogo.FileName <> "" Then
            imgpath = OpenLogo.FileName
            PictureBox1.Image = Image.FromFile(imgpath)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Dim webAddress As String = "https://sites.google.com/site/pakyaudio/home/serviceticker/config/companyfrm"
            Process.Start(webAddress)
        Catch ex As Exception

        End Try
    End Sub
End Class