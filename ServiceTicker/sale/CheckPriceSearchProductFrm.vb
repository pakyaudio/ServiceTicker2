Imports MySql.Data.MySqlClient

Public Class CheckPriceSearchProductFrm

    Private Sub CheckPriceSearchProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckPriceSearchProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.cbbMeAndNO.Items.Clear()
        Me.cbbMeAndNO.Items.Add("ที่มีสินค้า")
        Me.cbbMeAndNO.Items.Add("ที่ไม่มีสินค้า")
        Me.cbbMeAndNO.Items.Add("ทั้งหมด")
        Me.cbbMeAndNO.SelectedIndex = 0
    End Sub

    Private Sub cbbMeAndNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbMeAndNO.KeyPress
        e.Handled = True
    End Sub
    Private Sub SearchPro(ByVal txtSearch As String, ByVal mme As Integer, ByVal all As Integer)
        Try
            Me.DataGridView1.Rows.Clear()
            If all = 5000 Then
                If mme = 100 Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,unit,count_num,type FROM " _
                            & "product WHERE name_pro LIKE '%" & txtSearch & "%' AND count_num > 0 ORDER BY type ASC"
                ElseIf mme = 200 Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,unit,count_num,type FROM " _
                            & "product WHERE name_pro LIKE '%" & txtSearch & "%' AND count_num <= 0 ORDER BY type ASC"
                ElseIf mme = 300 Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,unit,count_num,type FROM " _
                            & "product WHERE name_pro LIKE '%" & txtSearch & "%' ORDER BY type ASC"
                End If
            ElseIf all = 6000 Then
                If mme = 100 Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,unit,count_num,type FROM " _
                            & "product WHERE count_num > 0 ORDER BY type ASC"
                ElseIf mme = 200 Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,unit,count_num,type FROM " _
                            & "product WHERE count_num <= 0 ORDER BY type ASC"
                ElseIf mme = 300 Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,unit,count_num,type FROM " _
                            & "product ORDER BY type ASC"
                End If
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                With Me.DataGridView1
                    Dim r As Integer
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("type")
                    .Rows(r).Cells(4).Value = Dr.Item("count_num")
                    .Rows(r).Cells(5).Value = Dr.Item("unit")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtSearch.Clear()
    End Sub

    Private Function cbbcheck() As Integer
        If cbbMeAndNO.Text = "ที่มีสินค้า" Then
            Return 100
        ElseIf cbbMeAndNO.Text = "ที่ไม่มีสินค้า" Then
            Return 200
        ElseIf cbbMeAndNO.Text = "ทั้งหมด" Then
            Return 300
        Else
            Return 1
        End If
    End Function

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSearch.Text <> Nothing Then
                Call SearchPro(Me.txtSearch.Text, cbbcheck(), 5000)
            Else
                Call SearchPro(Nothing, cbbcheck(), 6000)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Me.txtSearch.Text <> Nothing Then
            Call SearchPro(Me.txtSearch.Text, cbbcheck(), 5000)
        Else
            Call SearchPro(Nothing, cbbcheck(), 6000)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call CheckPriceFrm.getDataProPrice(Me.DataGridView1.CurrentRow.Cells(1).Value)
        Me.Close()
    End Sub
End Class