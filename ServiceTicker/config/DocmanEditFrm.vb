Imports MySql.Data.MySqlClient

Public Class DocmanEditFrm
    Private Sub addcbbFormat()
        Me.cbbFormat.Items.Clear()
        Me.cbbFormat.Items.Add("yy")
        Me.cbbFormat.Items.Add("yyMM")
        Me.cbbFormat.Items.Add("yyMMdd")
        Me.cbbFormat.Items.Add("yyMMddHH")
        Me.cbbFormat.Items.Add("yyMMddHHmm")
        Me.cbbFormat.Items.Add("yyMMddHHmmss")
        Me.cbbFormat.Items.Add("yyyy")
        Me.cbbFormat.Items.Add("yyyyMM")
        Me.cbbFormat.Items.Add("yyyyMMdd")
        Me.cbbFormat.Items.Add("yyyyMMddHH")
        Me.cbbFormat.Items.Add("yyyyMMddHHmm")
        Me.cbbFormat.Items.Add("yyyyMMddHHmmss")
        Me.cbbNumTotal.Items.Clear()
        Me.cbbNumTotal.Items.Add("4")
        Me.cbbNumTotal.Items.Add("5")
        Me.cbbNumTotal.Items.Add("6")
        Me.cbbNumTotal.Items.Add("7")
        Me.cbbNumTotal.Items.Add("8")
        Me.cbbNumTotal.Items.Add("9")
        Me.cbbNumTotal.Items.Add("10")
        Me.cbbNumTotal.Items.Add("11")
        Me.cbbNumTotal.Items.Add("12")
        Me.cbbNumTotal.Items.Add("13")
        Me.cbbNumTotal.Items.Add("14")
        Me.cbbNumTotal.Items.Add("15")
        Me.cbbNumTotal.Items.Add("16")
        Me.cbbNumTotal.Items.Add("17")
        Me.cbbNumTotal.Items.Add("18")
        Me.cbbNumTotal.Items.Add("19")

    End Sub

    Private Sub DocmanEditFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub DocmanEditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call addcbbFormat()
        Call Numex()
    End Sub

    Private Sub txtEx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEx.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbFormat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbFormat.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbNumTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbNumTotal.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 127     'enter 8   del 127
                e.Handled = False
            Case 65 To 90   'A-Z
                e.Handled = False
            Case 97 To 122   'a-z
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Numex()
        Dim NewID As Integer = 1
        Dim numexp As String = Me.txtFname.Text & Now.ToString(Me.cbbFormat.Text) & Me.txtdat.Text & NewID.ToString(DocManNumTotal(CInt(Me.cbbNumTotal.Text)))
        Me.txtEx.Text = numexp
    End Sub

    Private Sub txtFname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFname.KeyUp
        Call Numex()
    End Sub

    Private Sub cbbFormat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbFormat.SelectedValueChanged
        Call Numex()
    End Sub

    Private Sub cbbNumTotal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbNumTotal.SelectedValueChanged
        Call Numex()
    End Sub

    Private Sub txtdat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdat.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 127, 45     'enter 8   del 127
                e.Handled = False
            Case 65 To 90   'A-Z
                e.Handled = False
            Case 97 To 122   'a-z
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtdat_KeyUp(sender As Object, e As KeyEventArgs) Handles txtdat.KeyUp
        Call Numex()
    End Sub

    Private Sub txtEx_TextChanged(sender As Object, e As EventArgs) Handles txtEx.TextChanged
        Dim countCharacter As Integer = Me.txtEx.TextLength
        Me.Label7.Text = "จำนวน " & countCharacter & " ตัวอักษร"
    End Sub

    Private Sub UpdateData()
        Try
            strSQL = "UPDATE ver_name SET ver_detail=@ver_detail,format=@format,num_total=@num_total," _
                & "dat=@dat,y_reset=@y_reset WHERE ver=@ver"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@ver_detail", Me.txtFname.Text)
            cmd.Parameters.AddWithValue("@format", Me.cbbFormat.Text)
            cmd.Parameters.AddWithValue("@num_total", Me.cbbNumTotal.Text)
            cmd.Parameters.AddWithValue("@dat", Me.txtdat.Text)
            If cbby_reset.Text = "ใช่" Then
                cmd.Parameters.AddWithValue("@y_reset", 1)
            Else
                cmd.Parameters.AddWithValue("@y_reset", 0)
            End If
            cmd.Parameters.AddWithValue("@ver", Me.txtNameDoc.Tag)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call AppConfigFrm.loadVerDetaildg()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call UpdateData()
    End Sub

    Private Sub txtdat_TextChanged(sender As Object, e As EventArgs) Handles txtdat.TextChanged
        Me.txtdat.Text = strReplacetext(Me.txtdat.Text)
    End Sub

    Private Sub cbby_reset_DropDown(sender As Object, e As EventArgs) Handles cbby_reset.DropDown
        Me.cbby_reset.Items.Clear()
        Me.cbby_reset.Items.Add("ไม่")
        Me.cbby_reset.Items.Add("ใช่")
    End Sub

    Private Sub cbby_reset_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbby_reset.KeyPress
        e.Handled = True
    End Sub
End Class