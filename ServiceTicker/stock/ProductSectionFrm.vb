Imports MySql.Data.MySqlClient

Public Class ProductSectionFrm

    Private Sub ProductSectionFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductSectionFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.txtPSid.Clear()
        Me.txtPSName.Clear()
        Call ALLAutonumber("ver_productsectio", Me.txtPSid.Text)
        Me.txtPSName.Focus()
    End Sub

    Private Sub txtPSid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPSid.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnPSadd_Click(sender As Object, e As EventArgs) Handles btnPSadd.Click
        Try
            strSQL = "SELECT prosection_id,prosection_name FROM product_section WHERE prosection_name='" & Me.txtPSName.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MsgBox("พบชื่อประเภทสินค้าซ้ำกรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Else
                Try
                    strSQL = "INSERT INTO product_section(prosection_id,prosection_name)VALUES(@1,@2)"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@1", Me.txtPSid.Text)
                        cmd.Parameters.AddWithValue("@2", Me.txtPSName.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    'Call ProductSectionANDsubsFrm.getProSection()
                    Dim mainNodes As TreeNode = New TreeNode
                    mainNodes.Name = Me.txtPSid.Text
                    mainNodes.Text = Me.txtPSName.Text
                    mainNodes.Tag = "mainNodes"
                    ProductDetailFrm.TreeView1.SelectedNode.Nodes.Add(mainNodes)
                    Me.Close()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ProductSectionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub txtPSName_TextChanged(sender As Object, e As EventArgs) Handles txtPSName.TextChanged
        Me.txtPSName.Text = strReplacetext(Me.txtPSName.Text)
        If Me.txtPSName.Text <> Nothing Then
            Me.btnPSadd.Enabled = True
        Else
            Me.btnPSadd.Enabled = False
        End If
    End Sub
End Class