Imports System.Globalization

Public Class ProductChildSectionEditFrm

    Private Sub ProductChildSectionEditFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductChildSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtChildParentName.Clear()
        Me.txtChildParentName.Text = ProductDetailFrm.TextChild
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtChildParentName.Text <> Nothing Then
            Call Save()
        Else
            MessageBox.Show(Me, "กรุณาใส่ข้อมูลในช่อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Save()
        Try
            If ProductDetailFrm.TextChild <> Me.txtChildParentName.Text Then
                strSQL = "SELECT prosection_name FROM product_section " _
                    & "WHERE prosection_name='" & Me.txtChildParentName.Text & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    MessageBox.Show(Me, "ชื่อประเภทสินค้าซ้ำกันกรุณาตรวจสอบ", "ชื่อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Try
                        strSQL = "UPDATE product_section SET prosection_name=@prosection_name WHERE prosection_id=@prosection_id"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@prosection_id", ProductDetailFrm.nameChild)
                        cmd.Parameters.AddWithValue("@prosection_name", Me.txtChildParentName.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        'Call ProductSectionANDsubsFrm.getProSection()
                        ProductDetailFrm.TreeView1.SelectedNode.Text = Me.txtChildParentName.Text
                        ProductDetailFrm.TreeView1.Refresh()
                        Me.Close()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ProductChildSectionEditFrm_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        Me.txtChildParentName.Text = strReplacetext(Me.txtChildParentName.Text)
    End Sub
End Class