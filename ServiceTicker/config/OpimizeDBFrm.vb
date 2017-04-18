Imports MySql.Data.MySqlClient
Imports System.Text


Public Class OpimizeDBFrm
    Private Sub GetData()
        Try
            Me.dgData.Rows.Clear()
            cmd = New MySqlCommand("SELECT TABLE_NAME,TABLE_ROWS,DATA_LENGTH,MAX_DATA_LENGTH," _
                              & "INDEX_LENGTH,TABLE_COLLATION FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" & database & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgData
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("TABLE_NAME")
                    .Rows(r).Cells(1).Value = Dr.GetUInt64("TABLE_ROWS")
                    Dim DATA_LENGTH As Decimal = Dr.GetDecimal("DATA_LENGTH")
                    .Rows(r).Cells(2).Value = DATA_LENGTH / 1024 / 1024
                    Dim INDEX_LENGTH As Decimal = Dr.GetDecimal("INDEX_LENGTH")
                    .Rows(r).Cells(3).Value = INDEX_LENGTH / 1024 / 1024
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        For r As Integer = 0 To Me.dgData.Rows.Count - 1
            Try
                cmd = New MySqlCommand("ANALYZE TABLE " & database & "." & Me.dgData.Rows(r).Cells(0).Value, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Me.dgData.Rows(r).Cells(4).Value = Dr.Item("Msg_text")
            Catch ex As Exception
                Me.dgData.Rows(r).Cells(4).Value = "N/A"
            End Try
        Next
       

        Try
            Dim tr, dl As Decimal
            For row As Integer = 0 To Me.dgData.Rows.Count - 1
                tr += Me.dgData.Rows(row).Cells(1).Value
                dl += Me.dgData.Rows(row).Cells(2).Value + Me.dgData.Rows(row).Cells(3).Value
            Next
            Dim dll As String
            If dl > 1024 Then
                dl = dl / 1024
                dll = dl.ToString("N2") & " GB"
            Else
                dll = dl.ToString("N2") & " MB"
            End If
            lblDetail.Text = tr & " Record " & dll
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub OpimizeDBFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub OpimizeDBFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetData()
    End Sub

    Private Sub btnOpt_Click(sender As Object, e As EventArgs) Handles btnOpt.Click
        Try
            Dim result As Integer = MessageBox.Show(Me, "ต้องการจะสำรองข้อมูลหรือไม่", "สำรองข้อมูล", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then
                Exit Sub
            ElseIf result = DialogResult.No Then
                Me.Enabled = False
                MainFrm.lblMainStatus.Text = "ซ่อมแซมฐานข้อมูล"
                cmd = New MySqlCommand("OPTIMIZE TABLE serviceticker", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MessageBox.Show(Me, "ปรับปรุงฐานข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call GetData()
            ElseIf result = DialogResult.Yes Then
                Me.Enabled = False
                Call BackUpDatabase()
                MessageBox.Show(Me, "สำรองข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainFrm.lblMainStatus.Text = "ซ่อมแซมฐานข้อมูล"
                cmd = New MySqlCommand("OPTIMIZE TABLE serviceticker", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MessageBox.Show(Me, "ปรับปรุงฐานข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call GetData()
            End If
            Me.Enabled = True
        Catch ex As Exception
            Me.Enabled = True
            MessageBox.Show(Me, "ปรับปรุงฐานข้อมูลไม่สำเร็จ " & ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnRepair_Click(sender As Object, e As EventArgs) Handles btnRepair.Click
        Try
            Dim result As Integer = MessageBox.Show(Me, "ต้องการจะสำรองข้อมูลหรือไม่", "สำรองข้อมูล", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then
                Exit Sub
            ElseIf result = DialogResult.No Then
                Me.Enabled = False
                MainFrm.lblMainStatus.Text = "ซ่อมแซมฐานข้อมูล"
                cmd = New MySqlCommand("REPAIR TABLE serviceticker", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MessageBox.Show(Me, "ซ่อมแซมฐานข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call GetData()
            ElseIf result = DialogResult.Yes Then
                Me.Enabled = False
                Call BackUpDatabase()
                MessageBox.Show(Me, "สำรองข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainFrm.lblMainStatus.Text = "ซ่อมแซมฐานข้อมูล"
                cmd = New MySqlCommand("REPAIR TABLE serviceticker", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MessageBox.Show(Me, "ซ่อมแซมฐานข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call GetData()
            End If
            Me.Enabled = True
        Catch ex As Exception
            Me.Enabled = True
            MessageBox.Show(Me, "ซ่อมแซมฐานข้อมูลไม่สำเร็จ " & ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call GetData()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/databasemenu/opimizedbfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class