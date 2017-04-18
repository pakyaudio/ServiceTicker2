Imports System.Globalization

Public Class SelectCodeProFrm
#Region "code"
    Private Sub loadPro()
        Try
            strSQL = "SELECT `id`,code_pro,bar_code,name_pro FROM product ORDER BY name_pro ASC"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    With Me.DataGridView1
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Tag = Dr.Item("id")
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    End With
                End While
            End If
            Me.DataGridView1.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub SelectCodeProFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub SelectCodeProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub SelectCodeProFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call loadPro()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Me.DataGridView1.SelectedRows.Count <> 0 Then
            For i As Integer = ManagerSNFrm.dgMSN.Rows.Count() - 1 To 0 Step -1
                Dim delete As Boolean
                delete = ManagerSNFrm.dgMSN.Rows(i).Cells(0).Value

                ' if the checkbox cell is checked
                If delete = True Then
                    Dim row As DataGridViewRow
                    row = ManagerSNFrm.dgMSN.Rows(i)
                    Try
                        strSQL = "UPDATE product_serial SET code_pro='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'," _
                            & "date_in='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                            & "WHERE serial_pro='" & ManagerSNFrm.dgMSN.Rows(i).Cells(2).Value & "';"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    Dim cnum As Integer = Nothing
                    Try
                        strSQL = "UPDATE product SET count_num=CAST(count_num AS UNSIGNED) - 1 WHERE code_pro='" & ManagerSNFrm.dgMSN.Rows(i).Cells(1).Value & "';"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()

                        strSQL = "UPDATE product SET count_num=CAST(count_num AS UNSIGNED) + 1 WHERE code_pro='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "';"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    ManagerSNFrm.dgMSN.Rows.Remove(row)
                    ManagerSNFrm.l2 = ManagerSNFrm.l2 - 1
                    ManagerSNFrm.r2 = ManagerSNFrm.r2 - 1
                    ManagerSNFrm.Label2.Text = ManagerSNFrm.r2.ToString("N0") & "/" & ManagerSNFrm.l2.ToString("N0")
                End If
            Next
            ManagerSNFrm.btnMoveCodePro.Enabled = False
            ManagerSNFrm.btnRename_proSN.Enabled = False
            Me.Close()
        Else
            MessageBox.Show(Me, "กรุณาเลือกรายชื่อสินค้า", "เลือก", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class