Imports MySql.Data.MySqlClient

Public Class SelectProductSectionFrm

    Private Sub txtPSName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPSName.KeyPress
        If Me.txtPSName.Text <> Nothing Then
            Me.btnPSadd.Enabled = True
        Else
            Me.btnPSadd.Enabled = False
        End If
    End Sub

    Private Sub SelectProductSectionFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProductSectionFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.txtPSName.Clear()
        Me.txtPSName.Focus()
    End Sub

    Private Sub txtPSid_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Dim autonumsec As String
    Private Sub btnPSadd_Click(sender As Object, e As EventArgs) Handles btnPSadd.Click
        Call ALLAutonumber("ver_productsectio", autonumsec)
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
                        cmd.Parameters.AddWithValue("@1", autonumsec)
                        cmd.Parameters.AddWithValue("@2", Me.txtPSName.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    'Call ProductSectionANDsubsFrm.getProSection()
                    Dim mainNodes As TreeNode = New TreeNode
                    mainNodes.Name = autonumsec
                    mainNodes.Text = Me.txtPSName.Text
                    mainNodes.Tag = "mainNodes"
                    SelectSectionFrm.TreeView1.SelectedNode.Nodes.Add(mainNodes)
                    ProductDetailFrm.getProSection()
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
End Class