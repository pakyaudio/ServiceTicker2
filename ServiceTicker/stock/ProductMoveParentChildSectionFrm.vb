Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProductMoveParentChildSectionFrm

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
            cmd = New MySqlCommand("SELECT prosection_id,prosection_name FROM product_section " _
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
        Try
            strSQL = "UPDATE product_section_subs SET product_section_id=@product_section_id, datetime_edit=@datetime_edit " & _
                "WHERE product_section_subs_id=@product_section_subs_id"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@product_section_id", Me.ComboBox1.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@product_section_subs_id", nc)
            cmd.Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "UPDATE product SET `type`=@type,sub_section=@sub_section WHERE `type`='" & nc & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@type", Me.ComboBox1.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@sub_section", "")
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call ProductDetailFrm.getProSection()
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
End Class