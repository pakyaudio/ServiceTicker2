Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProductMoveProSectionFrm

    Private Sub ProductMoveProSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetMainProductType()
    End Sub

    ''' <summary>
    ''' โหลด product_section ลง ComboBox1
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub GetMainProductType()
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
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' โหลด product_sub_section ลง ComboBox1
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub GetSubProductType()
        Me.ComboBox2.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT product_section_subs_id,product_section_subs_name FROM product_section_subs " _
                                   & " WHERE product_section_id='" & Me.ComboBox1.SelectedValue.ToString & "' ORDER BY product_section_subs_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            dt = New DataTable
            Me.ComboBox2.DisplayMember = "Name"
            Me.ComboBox2.ValueMember = "ID"

            dt.Columns.Add("Name", GetType(String))
            dt.Columns.Add("ID", GetType(String))
            dt.Rows.Add("ไม่มีหมวดหมู่ย่อย", "0")
            If Dr.HasRows Then
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("product_section_subs_name"), Dr.Item("product_section_subs_id"))
                End While
            End If
            Me.ComboBox2.DataSource = dt
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        If Me.ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาเลือกหมวดหมู่หลักและหมวดหมู่ย่อย", "เลือก", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                strSQL = "UPDATE product SET `type`=@type,sub_section=@sub_section, update_date=@update_date WHERE `id`=@id;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@type", Me.ComboBox1.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@sub_section", Me.ComboBox2.SelectedValue.ToString)
                cmd.Parameters.AddWithValue("@update_date", DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
                cmd.Parameters.AddWithValue("@id", ProductDetailFrm.dgPDprolist.CurrentRow.Cells(1).Tag)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call ProductDetailFrm.GetDataProduct()
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Call GetSubProductType()
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.ComboBox2.DataSource = Nothing
        Catch ex As Exception

        End Try
    End Sub
End Class