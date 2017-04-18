Imports System.Globalization

Public Class ProductChildSectionFrm

    Private Sub ProductChildSectionFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductChildSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.txtChildParentName.Clear()
        Me.txtChildParentName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtChildParentName.Text <> Nothing Then
            Call Save()
        Else
            MessageBox.Show(Me, "กรุณาใส่ข้อมูลในช่อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Save()
        Dim ssid As Integer = Nothing

        Try
            strSQL = "SELECT Product_section_subs_name FROM product_section_subs " _
                & "WHERE product_section_id='" & ProductDetailFrm.nameChild & "' AND product_section_subs_name='" & Me.txtChildParentName.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MessageBox.Show(Me, "ชื่อหมวดหมู่ย่อยซ้ำกันกรุณาตรวจสอบ", "ชื่อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    strSQL = "INSERT INTO product_section_subs_id(datetime_save)VALUES(@datetime_save)"
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                'เลือกไอดีที่มากที่สุด
                Try
                    strSQL = "SELECT MAX(id) as id FROM product_section_subs_id"
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    ssid = Dr.Item("id")
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    strSQL = "INSERT INTO product_section_subs(product_section_id,product_section_subs_id,product_section_subs_name,datetime_edit)" _
                        & "VALUES(@product_section_id,@product_section_subs_id,@product_section_subs_name,@datetime_edit)"
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@product_section_id", ProductDetailFrm.nameChild)
                    cmd.Parameters.AddWithValue("@product_section_subs_id", ssid)
                    cmd.Parameters.AddWithValue("@product_section_subs_name", Me.txtChildParentName.Text)
                    cmd.Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    'Call ProductSectionANDsubsFrm.getProSection()
                    Dim childNodes As TreeNode = New TreeNode(Me.txtChildParentName.Text)
                    'ต้องเอาไอดีล่าสุดออกมา
                    childNodes.Name = ssid
                    childNodes.Text = Me.txtChildParentName.Text
                    childNodes.Tag = "childNodes"
                    ProductDetailFrm.TreeView1.SelectedNode.Nodes.Add(childNodes)
                    ProductDetailFrm.TreeView1.Refresh()
                    Me.Close()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtChildParentName_TextChanged(sender As Object, e As EventArgs) Handles txtChildParentName.TextChanged
        Me.txtChildParentName.Text = strReplacetext(Me.txtChildParentName.Text)
    End Sub
End Class