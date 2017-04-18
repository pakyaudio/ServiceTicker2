Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class MiniAllLoginFrm
#Region "Code"
    Dim Lev As Integer
    Dim uid, uname, ifc As String
    Private Sub saveLogs()
        Try
            strSQL = "INSERT INTO applogs(user_id,user_name,user_usernamelogin,note,date_in)" _
                & "VALUES('" & uid & "','" & uname & "','" & Me.txtMLUusername.Text & "','" & "เข้า" & MainFrm.MenuLoigName & "-จากเครื่อง " & SystemInformation.ComputerName & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            uid = Nothing
            uname = Nothing
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ok()
        Try
            strSQL = "SELECT user_id,user_name,user_leval FROM users WHERE user_usernamelogin='" & Me.txtMLUusername.Text & "' AND user_password = '" & Me.txtMLUpassword.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Dr = cmd.ExecuteReader()
            If Dr.Read Then
                With Dr
                    .Read()
                    uid = .GetString("user_id")
                    uname = .GetString("user_name")
                    Lev = .Item("user_leval")
                End With
                If MainFrm.leval <= Lev Then
                    Call saveLogs()
                    Call SelectFrom()
                    Me.Close()
                Else
                    ifc = "400"
                    Timer1.Start()
                    Timer2.Start()
                    Me.txtMLUusername.Clear()
                    Me.txtMLUpassword.Clear()
                    Me.txtMLUusername.Focus()
                End If
            Else
                ifc = "100"
                Timer1.Start()
                Timer2.Start()
                Me.txtMLUpassword.Clear()
                Me.txtMLUpassword.Focus()
            End If
            Dr.Close()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

#Region "SelectFrom"
    Private Sub SelectFrom()
        If MainFrm.MenuLoigName = "ข้อมูลสถานประกอบการ" Then
            CompanyFrm.lblEmployee.Text = Me.txtMLUusername.Text
            CompanyFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ผู้ใช้งาน" Then
            UsersFrm.lblEmployee.Text = Me.txtMLUusername.Text
            UsersFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ข้อมูลลูกค้า" Then
            If SaveDataFixFrm.sCustomerSDFF = 100 Then
                CustomerFrm.lblEmployee.Text = Me.txtMLUusername.Text
                CustomerFrm.ShowDialog(SearchCustomerFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.sCustomerSDFF = Nothing
            ElseIf SaveDataFixFrm.sCustomerSDFF = 200 Then
                CustomerFrm.lblEmployee.Text = Me.txtMLUusername.Text
                CustomerFrm.ShowDialog(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.sCustomerSDFF = Nothing
            Else
                CustomerFrm.lblEmployee.Text = Me.txtMLUusername.Text
                CustomerFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ตั้งค่าโปรแกรม" Then
            AppConfigFrm.lblEmployee.Text = Me.txtMLUusername.Text
            AppConfigFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ตั้งค่าข้อมูลบัตรเครดิต" Then
            CreditCardManagFrm.lblEmployee.Text = Me.txtMLUusername.Text
            CreditCardManagFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ตั้งค่าสิทธิการใช้งานโปรแกรม" Then
            AccessLavelFrm.lblEmployee.Text = Me.txtMLUusername.Text
            AccessLavelFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ตั้งค่าเครื่องพิมพ์" Then
            PrinterSettingFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PrinterSettingFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "สำรองฐานข้อมูล" Then
            BackupDatabaseFrm.lblEmployee.Text = Me.txtMLUusername.Text
            BackupDatabaseFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "นำเข้าฐานข้อมูล" Then
            ImportRestoreDatabaseFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ImportRestoreDatabaseFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เปลี่ยนฐานข้อมูล" Then
            ConnectDBFrm.Show(MainFrm)
            'ConnectDBFrm.lblEmployee.Text = Me.txtMLUusername.Text
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ปรับปรุงฐานข้อมูล" Then
            OpimizeDBFrm.lblEmployee.Text = Me.txtMLUusername.Text
            OpimizeDBFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "User Logs" Then
            logsFrm.lblEmployee.Text = Me.txtMLUusername.Text
            logsFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รับงานซ่อม" Then
            SaveDataFixFrm.lblEmployee.Text = Me.txtMLUusername.Text
            SaveDataFixFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ข้อมูล SN เครื่องซ่อม" Then
                SNFrm.lblEmployee.Text = Me.txtMLUusername.Text
                SNFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            'ตั้งค่างานซ่อม
        ElseIf MainFrm.MenuLoigName = "ข้อมูลประเภทสินค้า" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                ProductFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                ProductFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ข้อมูลยี่ห้อสินค้า" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                ProductNameFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductNameFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                ProductNameFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductNameFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ข้อมูลรุ่นสินค้า" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                ProductModelFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductModelFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                ProductModelFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductModelFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ข้อมูลสีตัวสินค้า" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                ProductColorFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductColorFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                ProductColorFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ProductColorFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ข้อมูลอาการเสีย" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                FixcomFrm.lblEmployee.Text = Me.txtMLUusername.Text
                FixcomFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                FixcomFrm.lblEmployee.Text = Me.txtMLUusername.Text
                FixcomFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ข้อมูลการจัดการข้อมูล" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                ManagerdataFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ManagerdataFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                ManagerdataFrm.lblEmployee.Text = Me.txtMLUusername.Text
                ManagerdataFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "ข้อมูลอุปกรณ์ที่นำมาด้วย" Then
            If SaveDataFixFrm.comfixConfigMenu = 50000 Then
                AccessoryEditFrm.lblEmployee.Text = Me.txtMLUusername.Text
                AccessoryEditFrm.Show(SaveDataFixFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
                SaveDataFixFrm.comfixConfigMenu = Nothing
            Else
                AccessoryEditFrm.lblEmployee.Text = Me.txtMLUusername.Text
                AccessoryEditFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "เบิกอะไหล่/ค่าซ่อม" Then
            PartsWithdrawalFrm.txtPWrepairID.Text = RepairStatusFrm.txtRSfix_id.Text
            PartsWithdrawalFrm.txtPWcusID.Text = RepairStatusFrm.txtRScus_id.Text
            PartsWithdrawalFrm.txtPWcusName.Text = RepairStatusFrm.txtRScus_name.Text
            PartsWithdrawalFrm.txtPWcusTel.Text = RepairStatusFrm.txtRScus_tel.Text
            PartsWithdrawalFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PartsWithdrawalFrm.Show(RepairStatusFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "สถานะงานซ่อม" Then
            RepairStatusFrm.lblEmployee.Text = Me.txtMLUusername.Text
            RepairStatusFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ค้นหางานซ่อม" Then
            SearchRepairFrm.lblEmployee.Text = Me.txtMLUusername.Text
            SearchRepairFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing

        ElseIf MainFrm.MenuLoigName = "ส่งคืนงานซ่อม" Then
            If RepairStatusFrm.selectOpen = 123456789 Then
                SendRepairFrm.txtHideform.Text = RepairStatusFrm.txtRSfix_id.Text
                SendRepairFrm.cbbSRRcash_status.Enabled = True
                SendRepairFrm.DateTimePickerSRR.Enabled = True
                SendRepairFrm.lblEmployee.Text = Me.txtMLUusername.Text
                SendRepairFrm.Show(RepairStatusFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            Else
                SendRepairFrm.lblEmployee.Text = Me.txtMLUusername.Text
                SendRepairFrm.Show(MainFrm)
                MainFrm.MenuLoigName = Nothing
                MainFrm.access = Nothing
                MainFrm.leval = Nothing
            End If
        ElseIf MainFrm.MenuLoigName = "รายงานการซ่อมตามรายชื่อช่างซ่อม" Then
            ReportUserRepairFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReportUserRepairFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานประวิติงานซ่อม" Then
            RepairHistoryFrm.lblEmployee.Text = Me.txtMLUusername.Text
            RepairHistoryFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "สถิติงานช่าง" Then
            ComfixCustomerStatusFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ComfixCustomerStatusFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานการเบิกสินค้า แบบแสดงรายชื่อสินค้า" Then
            ReportBarcodeComfixFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReportBarcodeComfixFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานรวมเบิกสินค้าตามวันที่" Then
            ReportRepairFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReportRepairFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เช็คประกันงานซ่อม" Then
            VarunteeCheckFrm.lblEmployee.Text = Me.txtMLUusername.Text
            VarunteeCheckFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "พิมพ์ใบรับซ่อม/ส่งคืนย้อนหลัง" Then
            PrintSaveDatafixSendRepairFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PrintSaveDatafixSendRepairFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "สั่งซื้อสินค้า" Then
            OrderFrm.lblEmployee.Text = Me.txtMLUusername.Text
            OrderFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายการสั่งซื้อสินค้า" Then
            ViewReceiveFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ViewReceiveFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รับสินค้าเข้าระบบ" Then
            ReceiveProductFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReceiveProductFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายชื่อบริษัทที่สั่งซื้อ" Then
            SaleCompanyFrm.lblEmployee.Text = Me.txtMLUusername.Text
            SaleCompanyFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานการรับสินค้า" Then
            ReceiveReportFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReceiveReportFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ขายสินค้า" Then
            SaleFrm.lblEmployee.Text = Me.txtMLUusername.Text
            SaleFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "คืนสินค้า/ยกเลิกบิลขาย" Then
            ReturnsProductFrm.lblemployee.Text = Me.txtMLUusername.Text
            ReturnsProductFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานรวมขายสินค้าตามวันที่" Then
            ReportSaleFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReportSaleFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานขาย แบบแสดงรายชื่อสินค้า" Then
            ReportBarcodeFrm.lblemployee.Text = Me.txtMLUusername.Text
            ReportBarcodeFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานการคืนสินค้า" Then
            ReturnProdductReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            ReturnProdductReportFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ตรวจสอบราคาสินค้า" Then
            CheckPriceFrm.lblemployee.Text = Me.txtMLUusername.Text
            CheckPriceFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เช็คประกันตัวสินค้า" Then
            VarunteeCheckSNFrm.lblEmployee.Text = Me.txtMLUusername.Text
            VarunteeCheckSNFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รับเคลมสินค้า" Then
            ClaimsFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เตรียมสินค้าเคลม" Then
            ClaimsPrepareFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsPrepareFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ส่งสินค้าเคลม" Then
            ClaimsSendGroupFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsSendGroupFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "พิมพ์ใบปะหน้ากล่อง" Then
            BoxCoverFrm.lblEmployee.Text = Me.txtMLUusername.Text
            BoxCoverFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รับเข้าสินค้าเคลม" Then
            ClaimsreceiveGroupFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsreceiveGroupFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ทดสอบสินค้าเคลม" Then
            ClaimsTestResultsFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsTestResultsFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "นำเข้าสินค้าเคลม" Then
            ClaimsImportProFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsImportProFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ติดตามสถานะเคลม" Then
            ClaimsStatusFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsStatusFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "คืนสินค้าเคลม" Then
            ReturnClaimsToCusFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ReturnClaimsToCusFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานการเคลม" Then
            ClaimsReportFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ClaimsReportFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "พิมพ์ใบรับเคลม" Then
            PrintingGetClaimsFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PrintingGetClaimsFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "พิมพ์รายการส่งเคลม" Then
            PrintingClaimSendListFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PrintingClaimSendListFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ลูกหนี้ค้างจ่าย" Then
            DebtorFrm.lblEmployee.Text = Me.txtMLUusername.Text
            DebtorFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "สถิติรายปี" Then
            AuditChartFrm.lblEmployee.Text = Me.txtMLUusername.Text
            AuditChartFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายการสินค้า" Then
            ProductDetailFrm.lblEmployee.Text = Me.txtMLUusername.Text
            ProductDetailFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เคลียร์ข้อมูลการตรวจสอบสต็อก" Then
            Call CheckStockFrm.ClearStock()
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เช็คสต็อก Serial Number" Then
            CheckStockFrm.lblEmployee.Text = Me.txtMLUusername.Text
            CheckStockFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เคลียร์ข้อมูลตรวจสอบสต็อกบาร์โค๊ต" Then
            Call CheckStoclBarcodeFrm.clearStock(Me.txtMLUusername.Text)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เช็คสต็อกบาร์โค๊ต" Then
            CheckStoclBarcodeFrm.lblEmployee.Text = Me.txtMLUusername.Text
            CheckStoclBarcodeFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานตรวจสอบสต็อก SN" Then
            CheckStockReportFrm.lblEmployee.Text = Me.txtMLUusername.Text
            CheckStockReportFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานตรวจสอบสต็อกบาร์โค๊ต" Then
            CheckStockBCReportFrm.lblEmployee.Text = Me.txtMLUusername.Text
            CheckStockBCReportFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานยอดรวมสต็อก" Then
            StockNumberFrm.lblEmployee.Text = Me.txtMLUusername.Text
            StockNumberFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ออกใบกำกับภาษี/ใบส่งของ" Then
            TaxInvoiceFrm.lblEmployee.Text = Me.txtMLUusername.Text
            TaxInvoiceFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย" Then
            AuditFrm.lblEmployee.Text = Me.txtMLUusername.Text
            AuditFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ตั้งค่าบัญชีธนาคาร" Then
            BankBookFrm.lblEmployee.Text = Me.txtMLUusername.Text
            BankBookFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "จัดการรูปภาพ" Then
            PictureDelFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PictureDelFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "พิมพ์ฉลาก SN" Then
            SNLabelFrm.lblEmployee.Text = Me.txtMLUusername.Text
            SNLabelFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "รายงานรายรับ/รายจ่าย" Then
            AuditReportFrm.lblEmployee.Text = Me.txtMLUusername.Text
            AuditReportFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "ระบบเอกสาร" Then
            DocumentManagerFrm.lblEmployee.Text = Me.txtMLUusername.Text
            DocumentManagerFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        ElseIf MainFrm.MenuLoigName = "เอกสารประกอบ" Then
            PosonalDocFrm.lblEmployee.Text = Me.txtMLUusername.Text
            PosonalDocFrm.Show(MainFrm)
            MainFrm.MenuLoigName = Nothing
            MainFrm.access = Nothing
            MainFrm.leval = Nothing
        End If
    End Sub

#End Region

    Private Sub MiniAllLoginFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub MiniAllLoginFrm_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Try
            Dim webaddress As String = "https://sites.google.com/site/pakyaudio/home/serviceticker/minilogin"
            Process.Start(webaddress)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MiniAllLoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Timer1.Enabled = False
        Me.txtMLUusername.Clear()
        Me.txtMLUpassword.Clear()
        Me.Label1.Text = "ยืนยันตัวตนเพื่อเข้าใช้งาน " & MainFrm.MenuLoigName
        Me.txtMLUusername.Focus()
    End Sub

    Private Sub txtMLUusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLUusername.KeyDown
        If Me.txtMLUusername.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Me.txtMLUpassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtMLUpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLUpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtMLUusername.Text = "" Then
                ifc = "200"
                Me.Timer1.Start()
                Me.Timer2.Start()
            ElseIf Me.txtMLUpassword.Text = "" Then
                ifc = "300"
                Me.Timer1.Start()
                Me.Timer2.Start()
            Else
                Call ok()
            End If
        End If
    End Sub

    Private Sub btnMLUok_Click(sender As Object, e As EventArgs) Handles btnMLUok.Click
        If Me.txtMLUusername.Text = "" Then
            ifc = "200"
            Me.Timer1.Start()
            Me.Timer2.Start()
        ElseIf Me.txtMLUpassword.Text = "" Then
            ifc = "300"
            Me.Timer1.Start()
            Me.Timer2.Start()
        Else
            Call ok()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.ForeColor = Color.Red
        If ifc = "100" Then
            Me.Label1.Text = "ชื่อหรือรหัสผ่านไม่ถูกต้อง"
        ElseIf ifc = "200" Then
            Me.Label1.Text = "กรุณาใส่ชื่อผู้ใช้งาน"
        ElseIf ifc = "300" Then
            Me.Label1.Text = "กรุณาใส่รหัสผ่าน"
        ElseIf ifc = "400" Then
            Me.Label1.Text = "คุณไม่มีสิทธิใช้งานในส่วนนี้ ติดต่อผู้ดูแลระบบเพื่อขอเข้าใช้งาน"
        End If
        If Me.Label1.Visible = True Then
            Me.Label1.Visible = False
        Else
            Me.Label1.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Label1.ForeColor = Color.Black
        Me.Label1.Text = "ยืนยันตัวตนเพื่อเข้าใช้งานเมนู" & MainFrm.MenuLoigName
        ifc = Nothing
        Me.Timer1.Stop()
        Me.Timer2.Stop()
    End Sub
End Class