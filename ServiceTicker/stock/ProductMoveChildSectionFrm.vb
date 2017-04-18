Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProductMoveChildSectionFrm

    Private Sub ProductMoveChildSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
    Dim nc As String
    Dim tc As String
    ''' <summary>
    ''' โหลด product_section ลง ComboBox1
    ''' </summary>
    ''' <param name="NameChild">prosection_id</param>
    ''' <param name="TextChild">prosection_name</param>
    ''' <remarks></remarks>
    Friend Sub GetProductType(ByVal NameChild As String, ByVal TextChild As String)
        Me.ComboBox1.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT prosection_id,prosection_name FROM product_section WHERE NOT prosection_id='" & NameChild & "' " _
                                   & "ORDER BY prosection_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.ComboBox1.DisplayMember = "Name"
                Me.ComboBox1.ValueMember = "ID"

                dt.Columns.Add("Name", GetType(String))
                dt.Columns.Add("ID", GetType(String))
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("prosection_name"), Dr.Item("prosection_id"))
                End While
                Me.ComboBox1.DataSource = dt
                nc = NameChild
                tc = TextChild
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim ssid As Integer = Nothing
        Try
            strSQL = "SELECT Product_section_subs_name FROM product_section_subs " _
                & "WHERE product_section_subs_name='" & tc & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MessageBox.Show(Me, "ชื่อหมวดหมู่ย่อยซ้ำกันกรุณาตรวจสอบ", "ชื่อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    strSQL = "INSERT INTO product_section_subs_id(datetime_save)VALUES(@datetime_save)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                'เลือกไอดีที่มากที่สุด
                Try
                    strSQL = "SELECT MAX(id) as id FROM product_section_subs_id"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
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
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@product_section_id", Me.ComboBox1.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@product_section_subs_id", ssid)
                    cmd.Parameters.AddWithValue("@product_section_subs_name", tc)
                    cmd.Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    cmd = New MySqlCommand("DELETE FROM product_section WHERE prosection_id='" & nc & "';", ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    strSQL = "UPDATE product SET `type`=@type,sub_section=@sub_section WHERE `type`='" & nc & "';"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@type", Me.ComboBox1.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@sub_section", ssid)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Call ProductDetailFrm.getProSection()
                Me.Close()
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
End Class