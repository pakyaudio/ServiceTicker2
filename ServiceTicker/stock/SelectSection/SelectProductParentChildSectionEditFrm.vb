Imports System.Globalization

Public Class SelectProductParentChildSectionEditFrm

    Private Sub SelectProductParentChildSectionEditFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductChildSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtChildParentName.Clear()
        Me.txtChildParentName.Text = SelectSectionFrm.TextChild
        Me.txtChildParentName.Tag = SelectSectionFrm.nameChild
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call Save()
    End Sub

    Private Sub Save()
        Try
            If SelectSectionFrm.TextChild <> Me.txtChildParentName.Text Then
                strSQL = "SELECT product_section_subs_name FROM product_section_subs " _
                    & "WHERE product_section_subs_name='" & Me.txtChildParentName.Text & "' AND " _
                    & "product_section_subs_id <> '" & Me.txtChildParentName.Tag & "';"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    MessageBox.Show(Me, "ชื่อหมวดหมู่สินค้าย่อยซ้ำกันกรุณาตรวจสอบ", "ชื่อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Try
                        strSQL = "UPDATE product_section_subs SET product_section_subs_name=@product_section_subs_name,datetime_edit=@datetime_edit " _
                            & "WHERE product_section_subs_id=@product_section_subs_id"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@product_section_subs_name", Me.txtChildParentName.Text)
                        cmd.Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                        cmd.Parameters.AddWithValue("@product_section_subs_id", Me.txtChildParentName.Tag)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        'Call ProductSectionANDsubsFrm.getProSection()
                        SelectSectionFrm.TreeView1.SelectedNode.Text = Me.txtChildParentName.Text
                        SelectSectionFrm.TreeView1.Refresh()
                        ProductDetailFrm.getProSection()
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
End Class