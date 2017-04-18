Imports System.Globalization

Public Class SelectNameProFrm
#Region "code"
    Private Sub loadPro()
        Try
            strSQL = "SELECT code_pro,bar_code,name_pro FROM product ORDER BY name_pro ASC"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read()
                    With Me.DataGridView1
                        r = .RowCount
                        .Rows.Add()
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

    Private Sub SelectNameProFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
                        strSQL = "UPDATE product_serial SET name_pro='" & Me.DataGridView1.CurrentRow.Cells(2).Value & "'," _
                            & "date_in='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                            & "WHERE serial_pro='" & ManagerSNFrm.dgMSN.Rows(i).Cells(2).Value & "';"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    Try
                        strSQL = "SELECT name_pro FROM product_serial WHERE serial_pro='" & ManagerSNFrm.dgMSN.Rows(i).Cells(2).Value & "';"
                        cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        If Dr.HasRows Then
                            Dr.Read()
                            ManagerSNFrm.dgMSN.Rows(i).Cells(3).Value = Dr.Item("name_pro")
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            Next
            Me.Close()
        Else
            MessageBox.Show(Me, "กรุณาเลือกรายชื่อสินค้า", "เลือก", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class