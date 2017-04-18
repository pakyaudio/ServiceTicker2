Imports MySql.Data.MySqlClient
Imports System.IO

Module UpdateModule
#Region "BackupDataBase"
    Friend Sub BackUpDatabase()
        BackupDatabaseUpdateFrm.ShowDialog()
    End Sub
#End Region

#Region "checkDBVersion"
    Friend Sub checkDBVersion()
        Try
            strSQL = "SELECT version FROM database_version;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Dim vers As String
                vers = Dr.GetString("version")
                If vers = "2" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1200()
                ElseIf vers = "2.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1210()
                ElseIf vers = "2.2" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1220()
                ElseIf vers = "2.3" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1300()
                ElseIf vers = "2.4" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1310()
                ElseIf vers = "2.5" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1350()
                ElseIf vers = "2.6" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1400()
                ElseIf vers = "2.7" Or vers = "2.7.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1440()
                ElseIf vers = "2.8" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1450()
                ElseIf vers = "2.9" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1500()
                ElseIf vers = "3.0" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1511()
                ElseIf vers = "3.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1522()
                ElseIf vers = "3.2" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1540()
                ElseIf vers = "4.0" Then
                    Call BackUpDatabase()
                    Call updateDatabase_2001()
                ElseIf vers = "4.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_20025()
                ElseIf vers = "4.2" Then
                    Call BackUpDatabase()
                    Call updateDatabase_20030()
                ElseIf vers = "4.3" Then
                    Exit Sub
                End If
            ElseIf Not Dr.HasRows Then
                Call updateDatabase_1102()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Start_V2"
    Friend Sub updateDatabase_1102_1()
        Try
            strSQL = "CREATE TABLE `claims` (`claims_id` VARCHAR(100) NULL DEFAULT '-',`customer_id` VARCHAR(100) NULL DEFAULT '-',`serial_pro` VARCHAR(100) NULL DEFAULT '-',`code_pro` VARCHAR(100) NULL DEFAULT '-',`bar_code` VARCHAR(100) NULL DEFAULT '-',`name_pro` VARCHAR(500) NULL DEFAULT '-',`price_buy` VARCHAR(100) NULL DEFAULT '-',`type` VARCHAR(100) NULL DEFAULT '-',`unit` VARCHAR(100) NULL DEFAULT '-',`datetime_sale` VARCHAR(100) NULL DEFAULT '-',`employee_sale` VARCHAR(200) NULL DEFAULT '-',`symptom` VARCHAR(100) NULL DEFAULT '-',`accressory` VARCHAR(500) NULL DEFAULT '-',`note` VARCHAR(1000) NULL DEFAULT '-',`employee` VARCHAR(200) NULL DEFAULT '-',`datetime_save` VARCHAR(100) NULL DEFAULT '-',claims_id_pic LONGBLOB) COLLATE='utf8_general_ci' ;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_id` (`id` INT UNSIGNED NOT NULL AUTO_INCREMENT,`claims_id` VARCHAR(50) NULL DEFAULT '0',`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY (`id`))COLLATE='utf8_general_ci';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "INSERT INTO `claims_id` (`claims_id`) VALUES ('01');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail` ADD COLUMN `ver_claims` VARCHAR(50) NULL DEFAULT '-' AFTER `ver_cashinvoice`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()

            strSQL = "UPDATE `ver_detail` SET `ver_claims`='CL';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `status` VARCHAR(50) NULL DEFAULT '-' AFTER `note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_send` (`claims_id` VARCHAR(50) NULL,`claims_company` VARCHAR(500) NULL,`claims_company_id` VARCHAR(50) NULL,`claims_send_status` VARCHAR(50) NULL,`datetime_edit` VARCHAR(100) NULL,`datetime_save` VARCHAR(100) NULL,`employee` VARCHAR(200) NULL)COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_company` (`id` INT UNSIGNED NOT NULL AUTO_INCREMENT,`company_id` VARCHAR(50) NULL DEFAULT '-',`company_name` VARCHAR(500) NULL DEFAULT '-',`company_address` VARCHAR(500) NULL DEFAULT '-',`company_contect` VARCHAR(500) NULL DEFAULT '-',PRIMARY KEY (`id`))COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_send`CHANGE COLUMN `claims_id` `claims_id` VARCHAR(50) NULL DEFAULT '-' FIRST,CHANGE COLUMN `claims_company` `claims_company` VARCHAR(500) NULL DEFAULT '-' AFTER `claims_id`,CHANGE COLUMN `claims_company_id` `claims_company_id` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_company`,CHANGE COLUMN `claims_send_status` `claims_send_status` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_company_id`,CHANGE COLUMN `datetime_edit` `datetime_edit` VARCHAR(100) NULL DEFAULT '-' AFTER `claims_send_status`,CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_edit`,CHANGE COLUMN `employee` `employee` VARCHAR(200) NULL DEFAULT '-' AFTER `datetime_save`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_send`ADD COLUMN `claims_note` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_company_id`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `claims_company_id` (`claims_company_id`) VALUES ('start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `datetime_return` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_sale`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `claims_money` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_return`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `employee_claims_return` VARCHAR(100) NULL DEFAULT '-' AFTER `claims_money`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `tel_to_cus` VARCHAR(100) NULL DEFAULT '-' AFTER `employee_claims_return`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `datetime_edit` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_return`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix`ADD COLUMN `claims_id` VARCHAR(45) NOT NULL AFTER `fix_id`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `applogs`CHANGE COLUMN `user_id` `user_id` VARCHAR(255) NULL DEFAULT '-' FIRST,CHANGE COLUMN `user_name` `user_name` VARCHAR(255) NULL DEFAULT '-' AFTER `user_id`,CHANGE COLUMN `user_usernamelogin` `user_usernamelogin` VARCHAR(255) NULL DEFAULT '-' AFTER `user_name`,ADD COLUMN `note` VARCHAR(255) NULL DEFAULT '-' AFTER `user_usernamelogin`,CHANGE COLUMN `date_in` `date_in` DATETIME NULL DEFAULT NULL AFTER `note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims` ADD COLUMN `note2` VARCHAR(1000) NULL DEFAULT '-' AFTER `note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_copy` (`claims_id` VARCHAR(100) NULL DEFAULT '-',`customer_id` VARCHAR(100) NULL DEFAULT '-',`serial_pro` VARCHAR(100) NULL DEFAULT '-',`code_pro` VARCHAR(100) NULL DEFAULT '-',`bar_code` VARCHAR(100) NULL DEFAULT '-',`name_pro` VARCHAR(500) NULL DEFAULT '-',`price_buy` VARCHAR(100) NULL DEFAULT '-',`type` VARCHAR(100) NULL DEFAULT '-',`unit` VARCHAR(100) NULL DEFAULT '-',`datetime_sale` VARCHAR(100) NULL DEFAULT '-',`datetime_return` VARCHAR(100) NULL DEFAULT '-',`datetime_edit` VARCHAR(100) NULL DEFAULT '-',`claims_money` VARCHAR(100) NULL DEFAULT '-',`employee_claims_return` VARCHAR(100) NULL DEFAULT '-',`tel_to_cus` VARCHAR(100) NULL DEFAULT '-',`employee_sale` VARCHAR(200) NULL DEFAULT '-',`symptom` VARCHAR(100) NULL DEFAULT '-',`accressory` VARCHAR(500) NULL DEFAULT '-',`note` VARCHAR(1000) NULL DEFAULT '-',`note2` VARCHAR(1000) NULL DEFAULT '-',`status` VARCHAR(50) NULL DEFAULT '-',`employee` VARCHAR(200) NULL DEFAULT '-',`datetime_save` VARCHAR(100) NULL DEFAULT '-',claims_id_pic LONGBLOB NULL)COLLATE='utf8_general_ci' ;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `database_version` (`version` VARCHAR(50) NULL DEFAULT '0')COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()

            strSQL = "INSERT INTO `database_version` (`version`) VALUES ('2');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1200()
        Call updateDatabase_1210()
        Call updateDatabase_1220()
        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub

    Friend Sub updateDatabase_1200()
        Try
            strSQL = "CREATE TABLE `claims_company_id` (`id` INT NOT NULL AUTO_INCREMENT,`claims_company_id` VARCHAR(50) NULL DEFAULT '0',`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY (`id`))COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "INSERT INTO `claims_company_id` (`claims_company_id`) VALUES ('start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "UPDATE `database_version` SET `version`='2.1';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1210()
        Call updateDatabase_1220()
        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2"
    Friend Sub updateDatabase_1102()
        Try
            strSQL = "CREATE TABLE `claims_company_id` (`id` INT NOT NULL AUTO_INCREMENT,`claims_company_id` VARCHAR(50) NULL DEFAULT '0',`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY (`id`))COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "INSERT INTO `claims_company_id` (`claims_company_id`) VALUES ('start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "UPDATE `database_version` SET `version`='2.1';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1210()
        Call updateDatabase_1220()
        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.1"
    Friend Sub updateDatabase_1210()
        Try
            strSQL = "ALTER TABLE `sn` DROP PRIMARY KEY;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product` ADD COLUMN `varuntee` VARCHAR(45) NULL DEFAULT '-' AFTER `unit`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_company` ADD COLUMN `company_address1` VARCHAR(500) NULL DEFAULT '-' AFTER `company_address`, ADD COLUMN `company_address2` VARCHAR(500) NULL DEFAULT '-' AFTER `company_address1`,ADD COLUMN `company_zipcode` VARCHAR(500) NULL DEFAULT '-' AFTER `company_address2`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.2';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1220()
        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.2"
    Friend Sub updateDatabase_1220()
        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `footer3` VARCHAR(500) NULL DEFAULT '-' AFTER `footer2`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `com_sendrepairrow3` VARCHAR(500) NULL DEFAULT '-' AFTER `com_sendrepairrow2`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `com_claims` VARCHAR(500) NULL DEFAULT '-' AFTER `com_billing`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `comfix_cache` (`fix_id` VARCHAR(45) NOT NULL, `claims_id` VARCHAR(45) NOT NULL, `date_save` VARCHAR(20) NULL DEFAULT '-', `customer_id` VARCHAR(100) NULL DEFAULT '-', `customer_name` VARCHAR(100) NULL DEFAULT '-', `sn` VARCHAR(50) NULL DEFAULT '-', `symptom` VARCHAR(100) NULL DEFAULT '-', `managerdata` VARCHAR(100) NULL DEFAULT '-', `fixrepairnote` VARCHAR(500) NULL DEFAULT '-', `fixaccessory` VARCHAR(500) NULL DEFAULT '-', `fixnote` VARCHAR(500) NULL DEFAULT '-', `fixtprice` VARCHAR(45) NULL DEFAULT '-', `varuntee` VARCHAR(45) NULL DEFAULT '-', `date_get` VARCHAR(20) NULL DEFAULT '-', `fixuser` VARCHAR(45) NULL DEFAULT '-', `status` VARCHAR(45) NULL DEFAULT '-', `user_repair` VARCHAR(100) NULL DEFAULT '-', `note_repair` VARCHAR(500) NULL DEFAULT '-', `teltocus` VARCHAR(45) NULL DEFAULT '-', `date_send` VARCHAR(45) NULL DEFAULT '-', `datecom_repair` VARCHAR(45) NULL DEFAULT '-', `comfix_barcode` LONGBLOB NULL, PRIMARY KEY (`fix_id`), UNIQUE INDEX `fix_id_UNIQUE` (`fix_id`)) COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_cache` (`claims_id` VARCHAR(100) NULL DEFAULT '-', `customer_id` VARCHAR(100) NULL DEFAULT '-', `serial_pro` VARCHAR(100) NULL DEFAULT '-', `code_pro` VARCHAR(100) NULL DEFAULT '-', `bar_code` VARCHAR(100) NULL DEFAULT '-', `name_pro` VARCHAR(500) NULL DEFAULT '-', `price_buy` VARCHAR(100) NULL DEFAULT '-', `type` VARCHAR(100) NULL DEFAULT '-', `unit` VARCHAR(100) NULL DEFAULT '-', `datetime_sale` VARCHAR(100) NULL DEFAULT '-', `datetime_return` VARCHAR(100) NULL DEFAULT '-', `datetime_edit` VARCHAR(100) NULL DEFAULT '-', `claims_money` VARCHAR(100) NULL DEFAULT '-', `employee_claims_return` VARCHAR(100) NULL DEFAULT '-', `tel_to_cus` VARCHAR(100) NULL DEFAULT '-', `employee_sale` VARCHAR(200) NULL DEFAULT '-', `symptom` VARCHAR(100) NULL DEFAULT '-', `accressory` VARCHAR(500) NULL DEFAULT '-', `note` VARCHAR(1000) NULL DEFAULT '-', `note2` VARCHAR(1000) NULL DEFAULT '-', `status` VARCHAR(50) NULL DEFAULT '-', `employee` VARCHAR(200) NULL DEFAULT '-', `datetime_save` VARCHAR(100) NULL DEFAULT '-', `claims_id_pic` LONGBLOB NULL ) COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.3';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.3"
    Friend Sub updateDatabase_1300()
        Try
            strSQL = "CREATE TABLE `audit_outgoings` (" _
                & "`datetime` VARCHAR(100) NULL DEFAULT '-'," _
                & "`namewiden` VARCHAR(200) NULL DEFAULT '-'," _
                & "`list` VARCHAR(200) NULL DEFAULT '-'," _
                & "`money` VARCHAR(200) NULL DEFAULT '0'," _
                & "`note` VARCHAR(200) NULL DEFAULT '-')COLLATE='utf8_general_ci';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `audit` (" _
                 & "`datetime` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money1` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money2` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money5` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money10` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money20` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money50` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money100` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money500` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money1000` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`totalAll` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`check` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`transfer` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`cash` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`charges` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`deliverMorning` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`deliverNoon` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`deliverEvening` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`totalDeliver` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`difference` VARCHAR(100) NULL DEFAULT '0'" _
                 & ")" _
                 & "COLLATE='utf8_general_ci'" _
                 & ";"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.4';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.4"
    Friend Sub updateDatabase_1310()
        Try
            strSQL = "CREATE TABLE `stock_number_cache` (" _
                    & "`number` VARCHAR(50) NULL," _
                    & "`code_pro` VARCHAR(200) NULL," _
                    & "`bar_code` VARCHAR(200) NULL," _
                    & "`name_pro` VARCHAR(500) NULL," _
                    & "`type` VARCHAR(100) NULL," _
                    & "`price_cost` VARCHAR(100) NULL," _
                    & "`total_all` VARCHAR(100) NULL," _
                    & "`total_cost` VARCHAR(100) NULL" _
                    & ")" _
                    & "COLLATE='utf8_general_ci'" _
                    & ";"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `stock_number_sn_cache` (" _
                    & "`no` VARCHAR(50) NULL," _
                    & "`code_pro` VARCHAR(100) NULL," _
                    & "`sn` VARCHAR(100) NULL," _
                    & "`name_pro` VARCHAR(500) NULL," _
                    & "`datetime` VARCHAR(100) NULL" _
                    & ")" _
                    & "COLLATE='utf8_general_ci'" _
                    & ";"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.5';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.5"
    Friend Sub updateDatabase_1350()
        Try
            strSQL = "ALTER TABLE `comfix` ADD COLUMN `importune` VARCHAR(45) NULL DEFAULT '-' AFTER `datecom_repair`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix_cache` ADD COLUMN `importune` VARCHAR(45) NULL DEFAULT '-' AFTER `datecom_repair`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix` ADD COLUMN `storage` VARCHAR(100) NULL DEFAULT '-' AFTER `importune`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `sn_id` (`id` INT(100) UNSIGNED NOT NULL AUTO_INCREMENT, `id` VARCHAR(50) NULL DEFAULT '0', `datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, PRIMARY KEY (`id`)) COLLATE() 'utf8_general_ci'  ROW_FORMAT=DEFAULT; AUTO_INCREMENT=3;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `sn_id` (`sn_id`) VALUES ('01');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.6';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.6"
    Friend Sub updateDatabase_1400()
        Try
            strSQL = "ALTER TABLE `product`" _
                    & " ADD COLUMN `price_wholesale` VARCHAR(45) NULL DEFAULT '-' AFTER `price_buy`," _
                    & " ADD COLUMN `price_technician` VARCHAR(45) NULL DEFAULT '-' AFTER `price_wholesale`," _
                    & " ADD COLUMN `price_loyal` VARCHAR(45) NULL DEFAULT '-' AFTER `price_technician`," _
                    & " ADD COLUMN `price_members` VARCHAR(45) NULL DEFAULT '-' AFTER `price_loyal`," _
                    & " ADD COLUMN `spec` VARCHAR(1000) NULL DEFAULT '-' AFTER `notepro`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `customer` ADD COLUMN `price_level` VARCHAR(10) NOT NULL AFTER `customer_note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `customer` (`customer_id`, `customer_tax`, `customer_section`, `customer_name`, `customer_address`, `customer_zipcode`, `customer_tel`, `customer_note`, `price_level`) VALUES ('0', '000000000000', '-', 'ลูกค้าเงินสด', 'รับสินค้าเอง', '-', '-', '-', '1');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "ALTER TABLE `product`" _
                & " CHANGE COLUMN `price_buy` `price_buy` VARCHAR(45) NULL DEFAULT '0' AFTER `price_cost`," _
                & " CHANGE COLUMN `price_wholesale` `price_wholesale` VARCHAR(45) NULL DEFAULT '0' AFTER `price_buy`," _
                & " CHANGE COLUMN `price_technician` `price_technician` VARCHAR(45) NULL DEFAULT '0' AFTER `price_wholesale`," _
                & " CHANGE COLUMN `price_loyal` `price_loyal` VARCHAR(45) NULL DEFAULT '0' AFTER `price_technician`," _
                & " CHANGE COLUMN `price_members` `price_members` VARCHAR(45) NULL DEFAULT '0' AFTER `price_loyal`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product` CHANGE COLUMN `price_cost` `price_cost` VARCHAR(45) NULL DEFAULT '0' AFTER `name_pro`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `product_model` ( `p_name` VARCHAR(200) NULL DEFAULT '-',`p_model` VARCHAR(200) NULL DEFAULT '-')COLLATE='utf8_general_ci' ;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `product_color` (`id` INT NOT NULL AUTO_INCREMENT, `color` VARCHAR(100) NULL DEFAULT '0', PRIMARY KEY (`id`)) COLLATE='utf8_general_ci' ;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('ดำ');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('แดง');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('เทา');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('ฟ้า');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE IF NOT EXISTS `sn_id` (" _
                        & "`id` int(100) unsigned NOT NULL AUTO_INCREMENT," _
                        & "`sn_id` varchar(50) DEFAULT '0'," _
                        & "`datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," _
                        & " PRIMARY KEY (`id`))  DEFAULT CHARSET=utf8;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `sn_id` (`sn_id`) VALUES ('start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`" _
                    & " ADD COLUMN `price_wholesale` VARCHAR(100) NULL DEFAULT '-' AFTER `price_buy`," _
                    & " ADD COLUMN `price_technician` VARCHAR(100) NULL DEFAULT '-' AFTER `price_wholesale`," _
                    & " ADD COLUMN `price_loyal` VARCHAR(100) NULL DEFAULT '-' AFTER `price_technician`," _
                    & " ADD COLUMN `price_members` VARCHAR(100) NULL DEFAULT '-' AFTER `price_loyal`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_cache`" _
                    & " ADD COLUMN `price_wholesale` VARCHAR(100) NULL DEFAULT '-' AFTER `price_buy`," _
                    & " ADD COLUMN `price_technician` VARCHAR(100) NULL DEFAULT '-' AFTER `price_wholesale`," _
                    & " ADD COLUMN `price_loyal` VARCHAR(100) NULL DEFAULT '-' AFTER `price_technician`," _
                    & " ADD COLUMN `price_members` VARCHAR(100) NULL DEFAULT '-' AFTER `price_loyal`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_send_report` (" _
                & "`claims_id` VARCHAR(100) NULL DEFAULT '-'," _
                & "`customer_id` VARCHAR(100) NULL DEFAULT '-'," _
                & "`serial_pro` VARCHAR(100) NULL DEFAULT '-'," _
                & "`code_pro` VARCHAR(100) NULL DEFAULT '-'," _
                & "`bar_code` VARCHAR(100) NULL DEFAULT '-'," _
                & "`name_pro` VARCHAR(500) NULL DEFAULT '-'," _
                & "`price_buy` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_wholesale` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_technician` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_loyal` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_members` VARCHAR(100) NULL DEFAULT '-'," _
                & "`type` VARCHAR(100) NULL DEFAULT '-'," _
                & "`unit` VARCHAR(100) NULL DEFAULT '-'," _
                & "`datetime_sale` VARCHAR(100) NULL DEFAULT '-'," _
                & "`datetime_return` VARCHAR(100) NULL DEFAULT '-'," _
                & "`datetime_edit` VARCHAR(100) NULL DEFAULT '-'," _
                & "`claims_money` VARCHAR(100) NULL DEFAULT '-'," _
                & "`employee_claims_return` VARCHAR(100) NULL DEFAULT '-'," _
                & "`tel_to_cus` VARCHAR(100) NULL DEFAULT '-'," _
                & "`employee_sale` VARCHAR(200) NULL DEFAULT '-'," _
                & "`symptom` VARCHAR(100) NULL DEFAULT '-'," _
                & "`accressory` VARCHAR(500) NULL DEFAULT '-'," _
                & "`note` VARCHAR(1000) NULL DEFAULT '-'," _
                & "`note2` VARCHAR(1000) NULL DEFAULT '-'," _
                & "`status` VARCHAR(50) NULL DEFAULT '-'," _
                & "`employee` VARCHAR(200) NULL DEFAULT '-'," _
                & "`datetime_save` VARCHAR(100) NULL DEFAULT '-'," _
                & "`claims_id_pic` LONGBLOB NULL" _
                & ")" _
                & "COLLATE() 'utf8_general_ci' ;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_send` ADD COLUMN `claims_lot` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_send_status`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_lot_id` (`id` INT UNSIGNED NOT NULL AUTO_INCREMENT, `claims_lot` VARCHAR(100) NULL DEFAULT '0', `datetime_save` VARCHAR(100) NULL DEFAULT '0', PRIMARY KEY (`id`)) COLLATE='utf8_general_ci' ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `claims_lot_id` (`id`, `claims_lot`) VALUES (0, 'start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_test_results` (`claims_id` VARCHAR(50) NULL DEFAULT '-', `fix_by_company` VARCHAR(50) NULL DEFAULT '-'," _
                & " `old_sn` VARCHAR(50) NULL DEFAULT '-', `new_sn` VARCHAR(50) NULL DEFAULT '-', `test_results` VARCHAR(50) NULL DEFAULT '-'," _
                & " `test_note` VARCHAR(500) NULL DEFAULT '-', `datetime_save` VARCHAR(50) NULL DEFAULT '-') COLLATE='utf8_general_ci' ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `customer`" _
                & " CHANGE COLUMN `customer_id` `customer_id` VARCHAR(45) NOT NULL DEFAULT '-' FIRST," _
                & " CHANGE COLUMN `customer_tax` `customer_tax` VARCHAR(45) NOT NULL DEFAULT '0000000000000' AFTER `customer_id`," _
                & " CHANGE COLUMN `customer_section` `customer_section` VARCHAR(100) NOT NULL DEFAULT '-' AFTER `customer_tax`," _
                & " CHANGE COLUMN `customer_name` `customer_name` VARCHAR(100) NOT NULL DEFAULT '-' AFTER `customer_section`," _
                & " CHANGE COLUMN `customer_address` `customer_address` VARCHAR(200) NOT NULL DEFAULT '-' AFTER `customer_name`," _
                & " CHANGE COLUMN `customer_zipcode` `customer_zipcode` VARCHAR(45) NOT NULL DEFAULT '-' AFTER `customer_address`," _
                & " CHANGE COLUMN `customer_tel` `customer_tel` VARCHAR(45) NOT NULL DEFAULT '-' AFTER `customer_zipcode`," _
                & " CHANGE COLUMN `customer_note` `customer_note` VARCHAR(255) NOT NULL DEFAULT '-' AFTER `customer_tel`," _
                & " CHANGE COLUMN `price_level` `price_level` VARCHAR(10) NOT NULL DEFAULT '-' AFTER `customer_note`," _
                & " ADD COLUMN `maturity` VARCHAR(50) NOT NULL DEFAULT '-' AFTER `price_level`," _
                & " ADD COLUMN `date_edit` VARCHAR(50) NOT NULL DEFAULT '-' AFTER `maturity`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `com_qjob` VARCHAR(500) NULL DEFAULT '-' AFTER `com_claims`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `company` SET `com_qjob`='แจ้งเตือนมีงานซ่อมด่วนเข้า' WHERE  `ID`=1;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.7';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.7"
    Friend Sub updateDatabase_1440()

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.8';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1450()
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.8"
    Friend Sub updateDatabase_1450()
        Try
            strSQL = "CREATE TABLE `reportuserrepair` (" _
                    & "`no` VARCHAR(50) NULL," _
                    & "`fix_id` VARCHAR(50) NULL," _
                    & "`cus_name` VARCHAR(200) NULL," _
                    & "`code_pro` VARCHAR(50) NULL," _
                    & "`name_pro` VARCHAR(50) NULL," _
                    & "`total` VARCHAR(50) NULL," _
                    & "`price_cost` VARCHAR(50) NULL," _
                    & "`price_buy` VARCHAR(50) NULL," _
                    & "`discount` VARCHAR(50) NULL," _
                    & "`total_cost` VARCHAR(50) NULL," _
                    & "`total_buy` VARCHAR(50) NULL," _
                    & "`datetime_save` VARCHAR(50) NULL" _
                    & ")" _
                    & "COLLATE='utf8_general_ci'" _
                    & "ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_copy`" _
                & "ADD COLUMN `price_wholesale` VARCHAR(100) NULL DEFAULT '-' AFTER `price_buy`," _
                & "ADD COLUMN `price_technician` VARCHAR(100) NULL DEFAULT '-' AFTER `price_wholesale`," _
                & "ADD COLUMN `price_loyel` VARCHAR(100) NULL DEFAULT '-' AFTER `price_technician`," _
                & "ADD COLUMN `price_members` VARCHAR(100) NULL DEFAULT '-' AFTER `price_loyel`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        'ย้ายงานเคลม ที่เคลมเสร็จส่งคืนแล้ว ไปไว้ที่ claims_copy
        Try
            Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลม"
            strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                & "SELECT * FROM claims WHERE `status`='" & "ส่งคืนแล้ว" & "'"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()


            strSQL = "DELETE FROM claims WHERE `status`='" & "ส่งคืนแล้ว" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.9';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1500()
        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V2.9"
    Friend Sub updateDatabase_1500()
        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
                            " ALTER `ver_icon` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
                        " CHANGE COLUMN `ver_icon` `ver_icon` LONGBLOB NULL AFTER `ver_version`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `check_stock_bc` (" & _
                        "`csbc_id` VARCHAR(50) NULL DEFAULT '-'," & _
                        "`code_pro` VARCHAR(200) NULL DEFAULT '-'," & _
                        "`bar_code` VARCHAR(200) NULL DEFAULT '-'," & _
                        "`name_pro` VARCHAR(500) NULL DEFAULT '-'," & _
                        "`price_buy` VARCHAR(100) NULL DEFAULT '-'," & _
                        "`count_num` VARCHAR(100) NULL DEFAULT '-'," & _
                        "`count` VARCHAR(100) NULL DEFAULT '-'," & _
                        "`datetime_save` VARCHAR(50) NULL DEFAULT '-'" & _
                        ")" & _
                        "COLLATE='utf8_general_ci'" & _
                        "ENGINE = MyISAM" & _
                        ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `check_stock_bc_id` (" & _
                        "`id` INT UNSIGNED NOT NULL AUTO_INCREMENT," & _
                        "`csbc_id` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`total_pro_bc` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`count_num` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`disappear` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`over` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`csbc_status` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`datetime_save` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`datetime_last` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`employee` VARCHAR(200) NULL DEFAULT '0'," & _
                        "PRIMARY KEY (`id`)" & _
                        ")" & _
                        "COLLATE='utf8_general_ci'" & _
                        "ENGINE = MyISAM" & _
                        ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `check_stock_bc_id` (`csbc_id`) VALUES ('start');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='3.0';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1511()
        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V3.0"
    Friend Sub updateDatabase_1511()
        Try
            strSQL = "CREATE TABLE `shelf` (`s` VARCHAR(255) NULL)COLLATE='utf8_general_ci'ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "CREATE TABLE `credit_card` (`card_type` VARCHAR(50) NULL DEFAULT 'none')COLLATE='utf8_general_ci'ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('MasterCard');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('Visa');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('American Express');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('Discover');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `credit_card_bank` (`bank_name` VARCHAR(200) NULL DEFAULT 'none')COLLATE='utf8_general_ci'ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กรุงไทย');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กรุงเทพ');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กสิกรไทย');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ไทยพานิชย์');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ซิตี้แบงก์');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กรุงศรีอยุธยา');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('อิออน');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ธนชาติ');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ทหารไทย');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ยูโอบี');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ซีไอเอ็มบี');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ธนาคารแห่งประเทศจีน');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('สแตนดาร์ดชาร์เตอร์');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ไอซีบีซี');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='3.1';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1522()
        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V3.1"
    Friend Sub updateDatabase_1522()
        Try
            strSQL = "DROP TABLE IF EXISTS `access_lavel`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "CREATE TABLE IF NOT EXISTS `access_lavel` (" & _
                        "`id` int(10) unsigned NOT NULL AUTO_INCREMENT," & _
                        "`access` int(10) DEFAULT '0'," & _
                        "`zone` varchar(100) DEFAULT '-'," & _
                        "`link` varchar(100) DEFAULT '-'," & _
                        "`leval` int(5) DEFAULT '1' COMMENT '1 ผู้ใช้งาน 2 หัวหน้า 3 ผู้ดูแล'," & _
                        "`datetime_edit` varchar(50) DEFAULT '-'," & _
                        "PRIMARY KEY (`id`)" & _
                        ")  AUTO_INCREMENT=71 DEFAULT CHARSET=utf8;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`id`, `access`, `zone`, `link`, `leval`, `datetime_edit`) VALUES" & _
    "(1, 1, 'ผู้ใช้งาน', 'ตั้งค่า >> ผู้ใช้งาน', 3, '-')," & _
    "(2, 0, 'ข้อมูลลูกค้า', 'ตั้งค่า >> ข้อมูลลูกค้า', 1, '-')," & _
    "(3, 1, 'ตั้งค่าโปรแกรม', 'ตั้งค่า >> ตั้งค่าโปรแกรม >> ตั้งค่าโปรแกรม', 3, '-')," & _
    "(4, 1, 'ตั้งค่าข้อมูลบัตรเครดิต', 'ตั้งค่า >> ตั้งค่าโปรแกรม >> ตั้งค่าข้อมูลบัตรเครดิต', 3, '-')," & _
    "(5, 1, 'ตั้งค่าสิทธิการใช้งานโปรแกรม', 'ตั้งค่า >> ตั้งค่าโปรแกรม >> ตั้งค่าสิทธิการใช้งานโปรแกรม', 3, '-')," & _
    "(6, 0, 'สำรองฐานข้อมูล', 'ตั้งค่า >> จัดการฐานข้อมูล >> สำรองฐานข้อมูล', 1, '-')," & _
    "(7, 1, 'นำเข้าฐานข้อมูล', 'ตั้งค่า >> จัดการฐานข้อมูล >> นำเข้าฐานข้อมูล', 3, '-')," & _
    "(8, 1, 'เปลี่ยนฐานข้อมูล', 'ตั้งค่า >> จัดการฐานข้อมูล >> เปลี่ยนฐานข้อมูล', 3, '-')," & _
    "(9, 0, 'ปรับปรุงฐานข้อมูล', 'ตั้งค่า >> จัดการฐานข้อมูล >> ปรับปรุงฐานข้อมูล', 3, '-')," & _
    "(10, 1, 'User Logs', 'ตั้งค่า >> Logs >> User Logs', 1, '-')," & _
    "(11, 1, 'ข้อมูลสถานประกอบการ', 'ตั้งค่า >> ข้อมูลสถานประกอบการ', 3, '-')," & _
    "(12, 1, 'รับงานซ่อม', 'งานช่าง >> รับงานซ่อม', 1, '-')," & _
    "(13, 1, 'สถานะงานซ่อม', 'งานช่าง >> สถานะงานซ่อม', 1, '-')," & _
    "(14, 0, 'ค้นหางานซ่อม', 'งานช่าง >> ค้นหางานซ่อม', 1, '-')," & _
    "(15, 1, 'ส่งคืนงานซ่อม', 'งานช่าง >> ส่งคืนงานซ่อม', 1, '-')," & _
    "(16, 0, 'รายงานการซ่อมตามรายชื่อช่างซ่อม', 'งานช่าง >> รายงาน >> รายงานการซ่อมตามรายชื่อช่างซ่อม', 1, '-')," & _
    "(17, 0, 'รายงานประวิติงานซ่อม', 'งานช่าง >> รายงาน >> รายงานประวัติงานซ่อม', 1, '-')," & _
    "(18, 0, 'สถิติงานช่าง', 'งานช่าง >> รายงาน >> สถิติงานช่าง', 1, '-')," & _
    "(19, 0, 'รายงานการเบิกสินค้า แบบแสดงรายชื่อสินค้า', 'งานช่าง >> รายงาน >> รายงานการเบิกสินค้า แบบแสดงรายชื่อสินค้า', 1, '-')," & _
    "(20, 0, 'รายงานรวมเบิกสินค้าตามวันที่', 'งานช่าง >> รายงาน >> รายงานเบิกสินค้าตามวันที่', 1, '-')," & _
    "(21, 0, 'เช็คประกันงานซ่อม', 'งานช่าง >> เช็คประกัน/ประวัติ >> เช็คประกันงานซ่อม', 1, '-')," & _
    "(22, 0, 'เช็คประวิติซ่อมเปลี่ยนอะไหล่', 'งานช่าง >> เช็คประกัน/ประวิติ >> เช็คประวิติซ่อมเปลี่ยนอะไหล่', 1, '-')," & _
    "(23, 0, 'เช็คประกันกับบริษัทผู้จำหน่าย', 'งานช่าง >> เช็คประกัน/ประวัติ >> เช็คประกันกับบริษัทผู้จำหน่าย', 1, '-')," & _
    "(24, 1, 'ข้อมูลประเภทสินค้า', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลประเภทสินค้า', 1, '-')," & _
    "(25, 0, 'ข้อมูลยี่ห้อสินค้า', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลยี่ห้อสินค้า', 1, '-')," & _
    "(26, 1, 'ข้อมูลอาการเสีย', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลอาการเสีย', 1, '-')," & _
    "(27, 1, 'ข้อมูลการจัดการข้อมูล', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลการจัดการข้อมูล', 1, '-')," & _
    "(28, 1, 'ข้อมูลอุปกรณ์ที่นำมาด้วย', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลอุปกรณ์ที่นำมาด้วย', 1, '-')," & _
    "(29, 1, 'ข้อมูลสีตัวสินค้า', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลสีตัวสินค้า', 1, '-')," & _
    "(30, 1, 'ข้อมูล SN เครื่องซ่อม', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูล SN เครื่องซ่อม', 1, '-')," & _
    "(31, 0, 'พิมพ์ใบรับซ่อม/ส่งคืนย้อนหลัง', 'งานช่าง >> พิมพ์ >> พิมพ์ใบรับซ่อม/ส่งคืนย้อนหลัง', 1, '-')," & _
    "(33, 0, 'รายการสั่งซื้อสินค้า', 'งานจัดซื้อ >> รายการสั่งซื้อสินค้า', 1, '-')," & _
    "(32, 0, 'สั่งซื้อสินค้า', 'งานจัดซื้อ >> สั่งซื้อสินค้า', 1, '-')," & _
    "(34, 0, 'รับสินค้าเข้าระบบ', 'งานจัดซื้อ >> รับสินค้าเข้าระบบ', 1, '-')," & _
    "(35, 0, 'รายชื่อบริษัทที่สั่งซื้อ', 'งานจัดซื้อ >> รายชื่อบริษัทที่จัดซื้อ', 1, '-')," & _
    "(36, 0, 'รายงานการรับสินค้า', 'งานจัดซื้อ >> รายงานการรับสินค้า', 1, '-')," & _
    "(37, 0, 'ขายสินค้า', 'งานขาย >> ขายสินค้า', 1, '-')," & _
    "(38, 0, 'คืนสินค้า/ยกเลิกบิลขาย', 'งานขาย >> ขายสินค้า/ยกเลิกบิลขาย', 1, '-')," & _
    "(39, 0, 'รายงานรวมขายสินค้าตามวันที่', 'งานขาย >> รายงานรวมขายสินค้าตามวันที่', 1, '-')," & _
    "(40, 0, 'รายงานขาย แบบแสดงรายชื่อสินค้า', 'งานขาย >> รายงานขาย แบบแสดงรายชื่อสินค้า', 1, '-')," & _
    "(41, 0, 'รายงานการคืน รวม', 'งานขาย >> รายงานการคืน รวม', 1, '-')," & _
    "(42, 0, 'รายงานคืนสินค้าแบบแสดงชื่อสินค้า', 'งานขาย >> รายงานคืนสินค้าแบบแสดงชื่อสินค้า', 1, '-')," & _
    "(43, 0, 'สถิติงานขาย', 'งานขาย >> สถิติงานขาย', 1, '-')," & _
    "(44, 0, 'ตรวจสอบราคาสินค้า', 'งานขาย >> ตรวจสอบราคาสินค้า', 1, '-')," & _
    "(45, 0, 'เช็คประกันตัวสินค้า', 'งานขาย >> เช็คประกันตัวสินค้า', 1, '-')," & _
    "(46, 1, 'รับเคลมสินค้า', 'งานเคลม >> รับเคลมสินค้า', 1, '-')," & _
    "(47, 1, 'เตรียมสินค้าเคลม', 'งามเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> เตรียมสินค้าเคลม ', 1, '-')," & _
    "(48, 1, 'ส่งสินค้าเคลม', 'งามเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> ส่งสินค้าเคลม', 1, '-')," & _
    "(49, 1, 'รับเข้าสินค้าเคลม', 'งามเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> รับเข้าสินค้าเคลม', 1, '-')," & _
    "(50, 1, 'ทดสอบสินค้าเคลม', 'งามเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> ทดสอบสินค้าเคลม', 1, '-')," & _
    "(51, 1, 'นำเข้าสินค้าเคลม', 'งามเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก) >> นำเข้าสินค้าเคลม', 1, '-')," & _
    "(52, 1, 'ติดตามสถานะเคลม', 'งานเคลม >> ติดตามสถานะเคลม', 1, '-')," & _
    "(53, 1, 'คืนสินค้าเคลม', 'งานเคลม >> คืนสินค้าเคลม', 1, '-')," & _
    "(54, 0, 'พิมพ์ใบปะหน้ากล่อง', 'งานเคลม >> พิมพ์ใบปะหน้ากล่อง', 1, '-')," & _
    "(55, 0, 'รายงานการเคลม', 'งานเคลม >> รายงานการเคลม', 1, '-')," & _
    "(56, 1, 'ลูกหนี้ค้างจ่าย', 'งานบัญชี/การเงิน >> ลูกหนี้ค้างจ่าย', 1, '-')," & _
    "(57, 1, 'ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย', 'งานบัญชี/การเงิน >> ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย', 1, '-')," & _
    "(58, 0, 'รายงานรายรับ/รายจ่าย', 'งานบัญชี/การเงิน >> รายงาน >> รายงานรายรับ/รายจ่าย', 1, '-')," & _
    "(59, 0, 'สถิติรายปี', 'งานบัญชี/การเงิน >> รายงาน >> สถิติรายปี', 1, '-')," & _
    "(60, 0, 'รายการสินค้า', 'สต็อกสินค้า >> รายการสินค้า', 1, '-')," & _
    "(61, 0, 'เช็คสต็อก Serial Number', 'สต็อกสินค้า >> เช็คสต็อก >> เช็คสต็อก Serial Number', 1, '-')," & _
    "(62, 0, 'เช็คสต็อกบาร์โค๊ต', 'สต็อกสินค้า >> เช็คสต็อก >> เช็คสต็อกบาร์โค๊ต', 1, '-')," & _
    "(63, 0, 'รายงานตรวจสอบสต็อก SN', 'สต็อกสินค้า >> รายงาน >> รายงานตรวจสอบสต็อก SN', 1, '-')," & _
    "(64, 0, 'รายงานตรวจสอบสต็อกบาร์โค๊ต', 'สต็อกสินค้า >> รายงาน >> รายงานตรวจสอบสต็อกบาร์โค๊ต', 1, '-')," & _
    "(65, 0, 'รายงานยอดรวมสต็อก', 'สต็อกสินค้า >> รายงาน >> รายงานยอดรวมสต็อก', 1, '-')," & _
    "(66, 0, 'รายงานจำนวนสต็อก', 'สต็อกสินค้า >> รายงาน >> รายงานจำนวนสต็อก', 1, '-')," & _
    "(67, 0, 'ออกใบเสนอราคา', 'ออกใบต่าง ๆ >> ใบเสนอราคา >> ออกใบเสนิราคา', 1, '-')," & _
    "(68, 0, 'ค้นหาใบเสนอราคา', 'ออกใบต่าง ๆ >> ใบเสนอราคา >> ค้นหาใบเสนอราคา', 1, '-')," & _
    "(69, 0, 'ออกใบกำกับภาษี/ใบส่งของ', 'ออกใบต่าง ๆ >> ออกใบกำกับภาษี/ใบส่งของ', 1, '-')," & _
    "(70, 1, 'เบิกอะไหล่/ค่าซ่อม', 'งานช่าง >> สถานะงานซ่อม >> เบิกอะไหล์/ค่าซ่อม(ปุ่ม)', 1, '-');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='3.2';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1540()
        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V4.0"
    Friend Sub updateDatabase_1540()
        Try
            strSQL = "ALTER TABLE `company`" & _
            "CHANGE COLUMN `images` `images` LONGBLOB NULL AFTER `footer3`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `users`" & _
            "ALTER `user_id` DROP DEFAULT," & _
            "ALTER `user_name` DROP DEFAULT," & _
            "ALTER `user_address` DROP DEFAULT," & _
            "ALTER `user_tel` DROP DEFAULT," & _
            "ALTER `user_email` DROP DEFAULT," & _
            "ALTER `user_password` DROP DEFAULT," & _
            "ALTER `user_usernamelogin` DROP DEFAULT," & _
            "ALTER `user_leval` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `users`" & _
            "CHANGE COLUMN `user_id` `user_id` VARCHAR(45) NULL FIRST," & _
            "CHANGE COLUMN `user_name` `user_name` VARCHAR(45) NULL AFTER `user_id`," & _
            "CHANGE COLUMN `user_address` `user_address` VARCHAR(500) NULL AFTER `user_name`," & _
            "CHANGE COLUMN `user_tel` `user_tel` VARCHAR(50) NULL AFTER `user_address`," & _
            "CHANGE COLUMN `user_email` `user_email` VARCHAR(100) NULL AFTER `user_tel`," & _
            "CHANGE COLUMN `user_password` `user_password` VARCHAR(50) NULL AFTER `user_email`," & _
            "CHANGE COLUMN `user_usernamelogin` `user_usernamelogin` VARCHAR(45) NULL AFTER `user_password`," & _
            "CHANGE COLUMN `user_leval` `user_leval` VARCHAR(10) NULL AFTER `user_usernamelogin`," & _
            "ADD COLUMN `images` LONGBLOB NULL AFTER `user_leval`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
            "ALTER `ver_imglogin` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
            "CHANGE COLUMN `ver_imglogin` `ver_imglogin` LONGBLOB NOT NULL AFTER `ver_icon`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix`" & _
            "CHANGE COLUMN `claims_id` `claims_id` VARCHAR(45) NULL DEFAULT '-' AFTER `fix_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix_cache`" & _
            "ADD COLUMN `com_name` VARCHAR(100) NULL DEFAULT '-' AFTER `comfix_barcode`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `access_lavel`" & _
            "ADD COLUMN `menu` INT(5) NULL DEFAULT '0' AFTER `datetime_edit`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=1;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=2;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=3;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=4;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=5;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=6;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=7;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=8;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=9;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=10;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=1 WHERE `id`=11;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=12;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=13;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=14;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=15;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=16;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=17;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=18;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=19;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=20;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=21;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE  `id`=22;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=23;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=24;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=25;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=26;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=27;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=28;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=29;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=30;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=31;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=3 WHERE `id`=33;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=3 WHERE `id`=32;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=3 WHERE `id`=34;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=3 WHERE `id`=35;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=3 WHERE `id`=36;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=37;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=38;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=39;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=40;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=41;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=42;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=43;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=44;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=4 WHERE `id`=45;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=46;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=47;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=48;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=49;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=50;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=51;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=52;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=53;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=54;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=5 WHERE `id`=55;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=6 WHERE `id`=56;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=6 WHERE `id`=57;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=6 WHERE `id`=58;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=6 WHERE `id`=59;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=60;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=61;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=62;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=63;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=64;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=65;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=7 WHERE `id`=66;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=8 WHERE `id`=67;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=8 WHERE `id`=68;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=8 WHERE `id`=69;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `menu`=2 WHERE `id`=70;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `menu`) VALUES (1, 'ตั้งค่าเครื่องพิมพ์', 'ตั้งค่า >> ตั้งค่าโปรแกรม >> ตั้งค่าเครื่องพิมพ์', 1);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`zone`, `link`, `menu`) VALUES ('ข้อมูลรุ่นสินค้า', 'งานช่าง >> ตั้งค่าข้อมูลงานช่าง >> ข้อมูลรุ่นสินค้า', 2);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`zone`, `link`, `menu`) VALUES ('พิมพ์ใบรับเคลม', 'งานเคลม >> พิมพ์ใบต่าง ๆ >> พิมพ์ใบรับเคลม', 5);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`zone`, `link`, `menu`) VALUES ('พิมพ์รายการส่งเคลม', 'งานเคลม >> พิมพ์ใบต่าง ๆ >> พิมพ์รายการส่งเคลม', 5);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `leval`, `menu`) VALUES (1, 'ตั้งค่าบัญชีธนาคาร', 'ตั้งค่า >> ตั้งค่าโปรแกรม >> ตั้งค่าบัญชีธนาคาร', 3, 1);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `leval`, `menu`) VALUES (1, 'จัดการรูปภาพ', 'ตั้งค่า >> ตั้งค่าโปรแกรม >> จัดการรูปภาพ', 3, 1);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `leval`, `menu`) VALUES (1, 'พิมพ์ฉลาก SN', 'งานช่าง >> พิมพ์ >> พิมพ์ฉลาก SN สำหรับติดเครื่องซ่อม', 1, 2);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel` WHERE `id`=42;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `zone`='รายงานการคืนสินค้า', `link`='งานขาย >> รายงานการคืนสินค้า' WHERE `id`=41;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `access_lavel` SET `link`='งานเคลม >> พิมพ์รายการต่าง ๆ >> พิมพ์ใบปะหน้ากล่อง' WHERE `id`=54;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company`" & _
            "ADD COLUMN `com_pledge` VARCHAR(500) NULL DEFAULT '-' AFTER `com_qjob`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = ""
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `company` SET `com_pledge`='ใช้เป็นหลักฐานการมัดจำลดหนี้ สินค้าและบริการ' WHERE `ID`=1;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company`" & _
            "ADD COLUMN `com_recipt` VARCHAR(500) NULL DEFAULT '-' AFTER `com_pledge`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `company` SET `com_recipt`='ใบเสร็จจะสมบูรณ์ต่อเมื่อมีลายมือชื่อผู้รับเงิน และได้รับเงินเรียบร้อยแล้ว' WHERE `ID`=1;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel` WHERE `id`=22;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel` WHERE `id`=23;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `buy_pro`" & _
            "ADD COLUMN `get_bc` VARCHAR(50) NULL DEFAULT '0' AFTER `count_num`," & _
            "ADD COLUMN `get_sn` VARCHAR(50) NULL DEFAULT '0' AFTER `get_bc`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `buy_pro`" & _
            "ADD COLUMN `datetime_edit` VARCHAR(50) NULL DEFAULT '0' AFTER `datetime_save`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product_serial`" & _
            "ADD COLUMN `stop` VARCHAR(10) NULL DEFAULT '0' AFTER `date_in`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product`" & _
            "ADD COLUMN `stop` VARCHAR(10) NULL DEFAULT '0' AFTER `picture`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `stop_sale_sn` (" & _
            "`sale_id` VARCHAR(50) NULL DEFAULT '-'," & _
            "`customer_id` VARCHAR(100) NULL DEFAULT '-'," & _
            "`customer_name` VARCHAR(255) NULL DEFAULT '-'," & _
            "`customer_address` VARCHAR(255) NULL DEFAULT '-'," & _
            "`customer_tel` VARCHAR(20) NULL DEFAULT '-'," & _
            "`price_leval` VARCHAR(10) NULL DEFAULT '-'," & _
            "`serial_pro` VARCHAR(255) NULL DEFAULT '-'," & _
            "`name_pro` VARCHAR(255) NULL DEFAULT '-'," & _
            "`datetime_save` VARCHAR(50) NULL DEFAULT '-'," & _
            "`employee` VARCHAR(100) NULL DEFAULT '-'," & _
            "`active` VARCHAR(50) NULL DEFAULT '-'," & _
            "`datetime_edit` VARCHAR(50) NULL DEFAULT '-'" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `stop_sale_bc` (" & _
            "`sale_id` VARCHAR(50) NULL DEFAULT '-'," & _
            "`customer_id` VARCHAR(50) NULL DEFAULT '-'," & _
            "`customer_name` VARCHAR(200) NULL DEFAULT '-'," & _
            "`customer_address` VARCHAR(200) NULL DEFAULT '-'," & _
            "`customer_tel` VARCHAR(50) NULL DEFAULT '-'," & _
            "`price_leval` VARCHAR(50) NULL DEFAULT '-'," & _
            "`bar_code` VARCHAR(50) NULL DEFAULT '-'," & _
            "`name_pro` VARCHAR(200) NULL DEFAULT '-'," & _
            "`price_buy` VARCHAR(50) NULL DEFAULT '-'," & _
            "`count_num` VARCHAR(50) NULL DEFAULT '-'," & _
            "`discount` VARCHAR(50) NULL DEFAULT '-'," & _
            "`unit` VARCHAR(50) NULL DEFAULT '-'," & _
            "`datetime_save` VARCHAR(50) NULL DEFAULT '-'," & _
            "`employee` VARCHAR(100) NULL DEFAULT '-'," & _
            "`active` VARCHAR(50) NULL DEFAULT '-'," & _
            "`datetime_edit` VARCHAR(50) NULL DEFAULT '-'" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `stop_sale_sn`" & _
            "CHANGE COLUMN `active` `active` VARCHAR(50) NULL DEFAULT '-' COMMENT '1=active, 0=no active' AFTER `employee`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `sale_barcode`" & _
            "ADD COLUMN `discount` VARCHAR(50) NULL DEFAULT '0' AFTER `employee`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `cash_sale_barcode`" & _
            "ADD COLUMN `discount` VARCHAR(255) NULL DEFAULT '0' AFTER `employee`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `returnproduct`" & _
            "ADD COLUMN `discount` VARCHAR(50) NULL DEFAULT '0' AFTER `employee`," & _
            "ADD COLUMN `decline` VARCHAR(50) NULL DEFAULT '0' AFTER `discount`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `returnproduct_barcode`" & _
            "ADD COLUMN `discount` VARCHAR(50) NULL DEFAULT '0' AFTER `datetime_save`," & _
            "ADD COLUMN `decline` VARCHAR(50) NULL DEFAULT '0' AFTER `discount`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_cache`" & _
            "CHANGE COLUMN `price_buy` `price_buy` VARCHAR(100) NULL DEFAULT '0' AFTER `name_pro`," & _
            "CHANGE COLUMN `price_wholesale` `price_wholesale` VARCHAR(100) NULL DEFAULT '0' AFTER `price_buy`," & _
            "CHANGE COLUMN `price_technician` `price_technician` VARCHAR(100) NULL DEFAULT '0' AFTER `price_wholesale`," & _
            "CHANGE COLUMN `price_loyal` `price_loyal` VARCHAR(100) NULL DEFAULT '0' AFTER `price_technician`," & _
            "CHANGE COLUMN `price_members` `price_members` VARCHAR(100) NULL DEFAULT '0' AFTER `price_loyal`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`" & _
            "CHANGE COLUMN `price_buy` `price_buy` VARCHAR(100) NULL DEFAULT '0' AFTER `name_pro`," & _
            "CHANGE COLUMN `price_wholesale` `price_wholesale` VARCHAR(100) NULL DEFAULT '0' AFTER `price_buy`," & _
            "CHANGE COLUMN `price_technician` `price_technician` VARCHAR(100) NULL DEFAULT '0' AFTER `price_wholesale`," & _
            "CHANGE COLUMN `price_loyal` `price_loyal` VARCHAR(100) NULL DEFAULT '0' AFTER `price_technician`," & _
            "CHANGE COLUMN `price_members` `price_members` VARCHAR(100) NULL DEFAULT '0' AFTER `price_loyal`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `boxcover` (" & _
            "`id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT," & _
            "`company_id` VARCHAR(50) NULL DEFAULT '-'," & _
            "`company_name` VARCHAR(500) NULL DEFAULT '-'," & _
            "`company_address` VARCHAR(500) NULL DEFAULT '-'," & _
            "`company_address1` VARCHAR(500) NULL DEFAULT '-'," & _
            "`company_address2` VARCHAR(500) NULL DEFAULT '-'," & _
            "`company_zipcode` VARCHAR(500) NULL DEFAULT '-'," & _
            "`company_contect` VARCHAR(500) NULL DEFAULT '-', " & _
            "PRIMARY KEY (`id`)" & _
            ")" & _
            "COLLATE() 'utf8_general_ci'  AUTO_INCREMENT=9;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `boxcover` (`id`, `company_id`, `company_name`, `company_address`, `company_address1`, `company_address2`, `company_zipcode`, `company_contect`) SELECT `id`, `company_id`, `company_name`, `company_address`, `company_address1`, `company_address2`, `company_zipcode`, `company_contect` FROM `claims_company`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `boxcover_id` (" & _
            "`id` INT(11) NOT NULL AUTO_INCREMENT," & _
            "`claims_company_id` VARCHAR(50) NULL DEFAULT '0'," & _
            "`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," & _
            "PRIMARY KEY (`id`)" & _
            ")" & _
            "COLLATE() 'utf8_general_ci'   AUTO_INCREMENT=8;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `boxcover_id` (`id`, `claims_company_id`, `datetime_save`) SELECT `id`, `claims_company_id`, `datetime_save` FROM `claims_company_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `ver_name` (" & _
            "`ver_detail` VARCHAR(50) NULL DEFAULT NULL," & _
            "`format` VARCHAR(50) NULL DEFAULT NULL," & _
            "`num_total` VARCHAR(50) NULL DEFAULT NULL," & _
            "`ver_name` VARCHAR(50) NULL DEFAULT NULL," & _
            "`dat` VARCHAR(50) NULL DEFAULT NULL ," & _
            "`ver` VARCHAR(50) NULL DEFAULT NULL ," & _
            "`id` INT UNSIGNED NOT NULL AUTO_INCREMENT," & _
            " PRIMARY KEY (`id`)" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_fixid` FROM `ver_detail`), 'yyyyMMdd', '4', 'รหัสใบรับซ่อม','-', 'ver_fixid');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_cusid` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสลูกค้า','-','ver_cusid');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_order` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสใบสั่งซื้อ','-','ver_order');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_returns` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสใบคืนสินค้า','-','ver_returns');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_cash` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสชำระเงิน','-','ver_cash');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_quotation` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสใบเสนอราคา','-','ver_quotation');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_claims` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสใบเคลมสินค้า','-','ver_claims');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_PartsWithdrawal` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสใบเบิกอะไหล่','-','ver_PartsWithdrawal');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_productsectio` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสประเภทสินค้า','-','ver_productsectio');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_barcode` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสบาร์โค๊ตสินค้า','-','ver_barcode');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_receive` FROM `ver_detail`), 'yyyyMMdd', '4','รหัสใบรับเข้าสินค้า','-','ver_receive');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_debtor` FROM `ver_detail`), 'yyyyMMdd', '4','เลขที่ใบชำระหนี้ค้างจ่าย/มัดจำ','-','ver_debtor');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`,`dat`,`ver`) VALUES ((SELECT `ver_cashinvoice` FROM `ver_detail`), 'yyyyMMdd', '4','เลขที่ใบเสร็จรับเงิน/ใบกำกับภาษี','-','ver_cashinvoice');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`, `ver`) VALUES ('US', 'yyMM', '2', 'รหัสผู้ใช้งาน', 'ver_user');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`, `ver`) VALUES ('SN', 'yyMMdd', '4', 'รหัสประจำเครื่องรับซ่อม (SN)', 'ver_sn');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`, `ver`) VALUES ('CLI', 'yyyyMMdd', '4', 'รหัสล็อตส่งเคลม', 'ver_claimsid');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `product_section_subs` (" & _
            "`product_section_id` VARCHAR(50) NULL DEFAULT '0'," & _
            "`product_section_subs_id` VARCHAR(200) NULL DEFAULT '0'," & _
            "`product_section_subs_name` VARCHAR(50) NULL DEFAULT '0'," & _
            "`datetime_edit` VARCHAR(50) NULL DEFAULT '0'" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            "ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product_section_subs`" & _
            "ALTER `product_section_subs_id` DROP DEFAULT;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product_section_subs`" & _
            "CHANGE COLUMN `product_section_subs_id` `product_section_subs_id` INT(200) UNSIGNED NOT NULL AFTER `product_section_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `product_section_subs_id` (" & _
            "`id` INT(200) UNSIGNED NOT NULL AUTO_INCREMENT," & _
            "`datetime_save` VARCHAR(50) NOT NULL DEFAULT '0'," & _
            "PRIMARY KEY (`id`)" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product`" & _
            "ADD COLUMN `sub_section` VARCHAR(10) NULL DEFAULT '0' AFTER `stop`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `product`" & _
            "SET `type` = (SELECT `prosection_id` FROM `product_section` WHERE `type` =  `prosection_name`)" & _
            "WHERE `type` = (SELECT `prosection_name` FROM `product_section` WHERE `type` =  `prosection_name`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`, `ver`) VALUES ('PD', 'yyMM', '4', 'รหัสสินค้า', 'ver_productid');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product`" & _
            "ADD COLUMN `id` BIGINT NOT NULL AUTO_INCREMENT FIRST," & _
            "ADD PRIMARY KEY (`id`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product`" & _
            "ADD INDEX `code_pro` (`code_pro`)," & _
            "ADD INDEX `bar_code` (`bar_code`)," & _
            "ADD INDEX `name_pro` (`name_pro`)," & _
            "ADD INDEX `id` (`id`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product_serial`" & _
            "ADD INDEX `code_pro` (`code_pro`)," & _
            "ADD INDEX `serial_pro` (`serial_pro`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product_serial`" & _
            "ADD COLUMN `id` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT AFTER `stop`," & _
            "ADD PRIMARY KEY (`id`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `check_stock`" & _
            "CHANGE COLUMN `serial_pro` `serial_pro` VARCHAR(1000) NULL DEFAULT '-' AFTER `code_pro`," & _
            "CHANGE COLUMN `name_pro` `name_pro` VARCHAR(1000) NULL DEFAULT '-' AFTER `serial_pro`," & _
            "ADD INDEX `serial_pro` (`serial_pro`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `check_stock_cache`" & _
            "CHANGE COLUMN `serial_pro` `serial_pro` VARCHAR(1000) NULL DEFAULT '-' FIRST," & _
            "CHANGE COLUMN `name_pro` `name_pro` VARCHAR(1000) NULL DEFAULT '-' AFTER `serial_pro`," & _
            "ADD INDEX `serial_pro` (`serial_pro`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `check_stock_bc`" & _
            "CHANGE COLUMN `csbc_id` `csbc_id` VARCHAR(100) NULL DEFAULT '-' FIRST," & _
            "CHANGE COLUMN `name_pro` `name_pro` VARCHAR(1000) NULL DEFAULT '-' AFTER `bar_code`," & _
            "CHANGE COLUMN `price_buy` `price_buy` VARCHAR(200) NULL DEFAULT '-' AFTER `name_pro`," & _
            "CHANGE COLUMN `count_num` `count_num` VARCHAR(1000) NULL DEFAULT '-' AFTER `price_buy`," & _
            "CHANGE COLUMN `count` `count` VARCHAR(1000) NULL DEFAULT '-' AFTER `count_num`," & _
            "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(200) NULL DEFAULT '-' AFTER `count`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `leval`, `menu`) VALUES (1, 'เคลียร์ข้อมูลการตรวจสอบสต็อก', 'สต็อกสินค้า >> เช็คสต็อก >> เช็คสต็อก Serial Number >> เคลียร์ข้อมูลการตรวจสอบสต็อก', 2, 7);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `leval`, `menu`) VALUES (1, 'เคลียร์ข้อมูลตรวจสอบสต็อกบาร์โค๊ต', 'สต็อกสินค้า >> เช็คสต็อก >> เช็คสต็อก Serial Number >> เคลียร์ข้อมูลการตรวจสอบสต็อกบาร์โค๊ต', 2, 7);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `leval`, `menu`) VALUES (1, 'ระบบเอกสาร', 'งานบัญชีการเงิน >> ระบบเอกสาร', 1,  6);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `check_stock_cache`" & _
            "ADD COLUMN `c_stock_id` VARCHAR(1000) NULL DEFAULT '-' FIRST," & _
            "ADD COLUMN `code_pro` VARCHAR(1000) NULL DEFAULT '-' AFTER `c_stock_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `check_stock_bc`" & _
            "CHANGE COLUMN `count_num` `count_num` VARCHAR(1000) NULL DEFAULT '0' AFTER `price_buy`," & _
            "CHANGE COLUMN `count` `count` VARCHAR(1000) NULL DEFAULT '0' AFTER `count_num`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `serviceticker`.`check_stock_bc_save` (" & _
            "`csbc_id` VARCHAR(100) NULL DEFAULT '-'," & _
            "`code_pro` VARCHAR(200) NULL DEFAULT '-'," & _
            "`bar_code` VARCHAR(200) NULL DEFAULT '-'," & _
            "`name_pro` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`price_buy` VARCHAR(200) NULL DEFAULT '-'," & _
            "`count_num` VARCHAR(1000) NULL DEFAULT '0'," & _
            "`count` VARCHAR(1000) NULL DEFAULT '0'," & _
            "`datetime_save` VARCHAR(200) NULL DEFAULT '-'" & _
            ")" & _
            "COLLATE() 'utf8_general_ci'  ;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `check_stock_save` (" & _
            "`c_stock_id` VARCHAR(100) NULL DEFAULT '-'," & _
            "`code_pro` VARCHAR(100) NULL DEFAULT '-'," & _
            "`serial_pro` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`name_pro` VARCHAR(1000) NULL DEFAULT '-'," & _
            "INDEX `c_stock_id` (`c_stock_id`)" & _
            ")" & _
            "COLLATE() 'utf8_general_ci'  ;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product`" & _
            "ADD COLUMN `service_chart` INT NULL DEFAULT '0' AFTER `sub_section`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel` WHERE  `id`=66;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `taxinvoice`" & _
            "ADD INDEX `taxinvoice_id` (`taxinvoice_id`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `taxinvoice`" & _
            "CHANGE COLUMN `total` `total` VARCHAR(100) NULL DEFAULT '0' AFTER `name_pro`," & _
            "CHANGE COLUMN `price_buy` `price_buy` VARCHAR(100) NULL DEFAULT '0' AFTER `unit`," & _
            "ADD COLUMN `discount` VARCHAR(100) NULL DEFAULT '0' AFTER `price_buy`," & _
            "ADD COLUMN `refer` VARCHAR(1000) NULL DEFAULT '-' AFTER `datetime_save`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `ver_name` (`ver_detail`, `format`, `num_total`, `ver_name`, `dat`, `ver`) VALUES ('INV', 'yyMMdd', '4', 'รหัสใบส่งของ', '-', 'ver_invoice');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel` WHERE  `id`=67;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "DELETE FROM `access_lavel` WHERE  `id`=68;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `customer`" & _
            "CHANGE COLUMN `customer_name` `customer_name` VARCHAR(1000) NOT NULL DEFAULT '-' AFTER `customer_section`," & _
            "CHANGE COLUMN `customer_address` `customer_address` VARCHAR(1000) NOT NULL DEFAULT '-' AFTER `customer_name`," & _
            "CHANGE COLUMN `customer_tel` `customer_tel` VARCHAR(1000) NOT NULL DEFAULT '-' AFTER `customer_zipcode`," & _
            "ADD COLUMN `img` LONGBLOB NULL DEFAULT NULL AFTER `date_edit`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
            "CHANGE COLUMN `ver_imglogin` `ver_imglogin` LONGBLOB NULL AFTER `ver_icon`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `picture_all` (" & _
            "`pa_id` INT UNSIGNED NOT NULL AUTO_INCREMENT," & _
            "`byte_pic` LONGBLOB NULL DEFAULT NULL," & _
            "`key_pic` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`note_pic` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," & _
            "`del` VARCHAR(50) NULL DEFAULT 'no'," & _
            "PRIMARY KEY (`pa_id`)," & _
            "INDEX `key_pic` (`key_pic`)" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix`" & _
            "ADD COLUMN `id` INT(200) UNSIGNED NOT NULL AUTO_INCREMENT AFTER `comfix_barcode`," & _
            "DROP INDEX `fix_id_UNIQUE`," & _
            "DROP PRIMARY KEY," & _
            "ADD INDEX `id` (`id`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO picture_all (byte_pic,key_pic,note_pic)(SELECT picture,code_pro,bar_code FROM product);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product`" & _
            "DROP COLUMN `picture`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `comfix_note` (`id` INT(200) NOT NULL AUTO_INCREMENT," & _
            "`note` VARCHAR(10000) NULL DEFAULT '-'," & _
            "`key_note` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`etc` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`datetime_save` DATETIME NULL DEFAULT '0000-00-00 00:00:00'," & _
            "INDEX `key_note` (`key_note`)," & _
            "PRIMARY KEY (`id`))" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `comfix_send_ex` (" & _
            "`id` INT  NOT NULL AUTO_INCREMENT," & _
            "`send_name` VARCHAR(500) NULL DEFAULT '-'," & _
            "`send_address` VARCHAR(1000) NULL DEFAULT '-'," & _
            "`send_contact` VARCHAR(500) NULL DEFAULT '-'," & _
            "`tetime` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," & _
            "PRIMARY KEY (`id`)" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix`" & _
            "ADD INDEX `status` (`status`);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `book_bank` (" & _
            "`id` INT UNSIGNED NOT NULL AUTO_INCREMENT," & _
            "`bank_name` VARCHAR(500) NULL DEFAULT '-'," & _
            "`acc_name` VARCHAR(500) NULL DEFAULT '-'," & _
            "`acc_num` VARCHAR(500) NULL DEFAULT '-'," & _
            "`bank_section` VARCHAR(500) NULL DEFAULT '-'," & _
            "`employee` VARCHAR(500) NULL DEFAULT '-'," & _
            "`datetime_edit` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," & _
            "PRIMARY KEY (`id`)" & _
            ")" & _
            "COLLATE='utf8_general_ci'" & _
            ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO comfix_note (note,key_note,datetime_save)(SELECT note_repair,fix_id,datecom_repair FROM comfix);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        'ส่วนนี้ใช้อัพเดทฐานข้อมูลจากเดิมเป็นสตริง เปลี่ยนเป็นไบต์
        Try
            cmd = New MySqlCommand("SELECT code_pro,spec FROM product", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                dt.Columns.Add("code_pro", GetType(String))
                dt.Columns.Add("spec", GetType(String))
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("code_pro"), Dr.Item("spec"))
                End While
            End If
            Try
                cmd = New MySqlCommand("UPDATE product SET spec='';", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Try
                cmd = New MySqlCommand("ALTER TABLE `product` ALTER `spec` DROP DEFAULT;", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Try
                cmd = New MySqlCommand("ALTER TABLE `product` CHANGE COLUMN `spec` `spec` LONGBLOB NULL AFTER `notepro`;", ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Dim rows() As DataRow = dt.Select()
            For i As Integer = 0 To rows.Count - 1
                Dim cp As String = rows(i)(0)
                Dim text As String = rows(i)(1)
                Dim rtfText As String = String.Empty
                Dim rtf As New RichTextBox
                rtf.Text = text
                rtfText = rtf.Rtf
                Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(rtfText)
                cmd = New MySqlCommand("UPDATE product SET spec=@spec WHERE code_pro=@cp;", ConnectionDB)
                cmd.Parameters.AddWithValue("@cp", cp)
                cmd.Parameters.AddWithValue("@spec", array)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='4.0';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_2001()
        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V4.1"
    Friend Sub updateDatabase_2001()

        Try
            Using dt = New DataTable
                strSQL = "SELECT  CONCAT('ALTER TABLE `', table_name, '` ENGINE=InnoDB;') AS sql_statements" & _
                        " FROM information_schema.tables AS tb" & _
                        " WHERE table_schema = 'serviceticker'" & _
                        " AND `ENGINE`='MyISAM'" & _
                        " AND `TABLE_TYPE`='BASE TABLE'" & _
                        " ORDER BY table_name DESC;"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Try
                    For Each row As DataRow In dt.Rows
                        strSQL = row(0)
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Next row
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            Using dt = New DataTable
                strSQL = "SELECT  CONCAT('ALTER TABLE `', table_name, '` ;') AS sql_statements FROM information_schema.tables AS tb WHERE table_schema = 'serviceticker' AND `ROW_FORMAT`<>'Dynamic' AND `TABLE_TYPE`='BASE TABLE' ORDER BY table_name DESC;"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Try
                    For Each row As DataRow In dt.Rows
                        strSQL = row(0)
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Next row
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `picture_all` ROW_FORMAT=COMPRESSED;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `access_lavel` (`access`, `zone`, `link`, `menu`) VALUES (1, 'เอกสารประกอบ', 'ออกใบต่าง ๆ >> เอกสารประกอบ', 8);"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='4.1';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_20025()
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V4.2"
    Friend Sub updateDatabase_20025()
        Try
            strSQL = "ALTER TABLE `company`" & _
                        "ADD COLUMN `tel_lable` VARCHAR(500) NULL DEFAULT '-' AFTER `com_recipt`," & _
                        "ADD COLUMN `fax_lable` VARCHAR(500) NULL DEFAULT '-' AFTER `tel_lable`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `company` SET `tel_lable`='โทรศัพท์', `fax_lable`='แฟกซ์' WHERE  `ID`=1;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='4.2';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_20030()
    End Sub
#End Region

#Region "V4.3"
    Friend Sub updateDatabase_20030()
        Try
            strSQL = "ALTER TABLE `pledge_sale` " & _
                "CHANGE COLUMN `p_id` `p_id` VARCHAR(1000) NULL DEFAULT '-' FIRST," & _
                "CHANGE COLUMN `total1` `total1` VARCHAR(1000) NULL DEFAULT '0' AFTER `p_id`," & _
                "CHANGE COLUMN `cash1` `cash1` VARCHAR(1000) NULL DEFAULT '-' AFTER `total1`," & _
                "CHANGE COLUMN `transfer1` `transfer1` VARCHAR(1000) NULL DEFAULT '-' AFTER `cash1`," & _
                "CHANGE COLUMN `check1` `check1` VARCHAR(1000) NULL DEFAULT '-' AFTER `transfer1`," & _
                "CHANGE COLUMN `detail1` `detail1` VARCHAR(1000) NULL DEFAULT '-' AFTER `check1`," & _
                "CHANGE COLUMN `customer_id` `customer_id` VARCHAR(1000) NULL DEFAULT '-' AFTER `detail1`," & _
                "CHANGE COLUMN `customer_name` `customer_name` VARCHAR(1000) NULL DEFAULT '-' AFTER `customer_id`," & _
                "CHANGE COLUMN `employee` `employee` VARCHAR(1000) NULL DEFAULT '-' AFTER `customer_name`," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(1000) NULL DEFAULT '-' AFTER `employee`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `comfix_id` ALTER `ID` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `comfix_id` CHANGE COLUMN `ID` `ID` INT(11) NOT NULL FIRST;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `comfix_id` DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        'Try
        '    strSQL = "CREATE TABLE `ver_name_copy` (" & _
        '        "`ver_detail` VARCHAR(50) NULL DEFAULT NULL," & _
        '        "`format` VARCHAR(50) NULL DEFAULT NULL," & _
        '        "`num_total` VARCHAR(50) NULL DEFAULT NULL," & _
        '        "`ver_name` VARCHAR(50) NULL DEFAULT NULL," & _
        '        "`dat` VARCHAR(50) NULL DEFAULT NULL," & _
        '        "`ver` VARCHAR(50) NULL DEFAULT NULL," & _
        '        "`id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT," & _
        '        "PRIMARY KEY (`id`)" & _
        '        ")" & _
        '        "COLLATE() 'utf8_general_ci' ENGINE=InnoDB ROW_FORMAT=Compact AUTO_INCREMENT=37;"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try

        'Try
        '    strSQL = "INSERT INTO `ver_name_copy`(`ver_detail`, `format`, `num_total`, `ver_name`, `dat`, `ver`, `id`) SELECT `ver_detail`, `format`, `num_total`, `ver_name`, `dat`, `ver`, `id` FROM `ver_name`;"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try

        'Try
        '    strSQL = "TRUNCATE `ver_name`;"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try

        'Try
        '    strSQL = "INSERT INTO `ver_name`(`ver_detail`, `format`, `num_total`, `ver_name`, `dat`, `ver`)" & _
        '        " SELECT DISTINCT `ver_detail`, `format`, `num_total`, `ver_name`, `dat`, `ver`" & _
        '        " FROM `ver_name_copy`;"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try

        'Try
        '    strSQL = "DROP TABLE `ver_name_copy`;"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try

        Try
            strSQL = "ALTER TABLE `ver_name` ADD COLUMN `y_reset` INT(10) NULL DEFAULT '0' AFTER `id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `users_id` ALTER `ID` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `users_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(11) NOT NULL FIRST," & _
                "CHANGE COLUMN `user_id` `user_id` VARCHAR(50) NULL DEFAULT '0' AFTER `ID`," & _
                "CHANGE COLUMN `user_namelogin` `user_namelogin` VARCHAR(100) NULL DEFAULT '0' AFTER `user_id`," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL DEFAULT '0' AFTER `user_namelogin`," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `customer_id` ALTER `ID` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `customer_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(11) NOT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `sn_id` ALTER `id` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `sn_id` " & _
                "CHANGE COLUMN `id` `id` INT(100) NOT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `sn_id` ALTER `datetime_save` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `sn_id` " & _
                "CHANGE COLUMN `datetime_save` `datetime_save` TIMESTAMP NULL AFTER `sn_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `sn_id` " & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL DEFAULT NULL AFTER `sn_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `pledge_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(11) NULL DEFAULT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `buy_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(10) NULL DEFAULT NULL FIRST," & _
                "CHANGE COLUMN `buy_id` `buy_id` VARCHAR(50) NULL DEFAULT '0' AFTER `ID`," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL DEFAULT '0' AFTER `buy_id`," & _
                "DROP PRIMARY KEY," & _
                "DROP INDEX `buy_id`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `returnproduct_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(11) NULL DEFAULT NULL FIRST," & _
                "CHANGE COLUMN `return_id` `return_id` VARCHAR(50) NULL DEFAULT '0' AFTER `ID`," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL DEFAULT '0' AFTER `return_id`," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `receive_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(10) NULL DEFAULT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `sale_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(11) NULL DEFAULT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `cash_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(10) NULL DEFAULT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `claims_id` " & _
                "ALTER `datetime_save` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `claims_id` " & _
                "CHANGE COLUMN `id` `id` INT(10) NULL DEFAULT NULL FIRST," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL AFTER `claims_id`," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `claims_lot_id` " & _
                "CHANGE COLUMN `id` `id` INT(10) NULL DEFAULT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `product_section_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(11) NULL DEFAULT NULL FIRST," & _
                "CHANGE COLUMN `prosection_id` `prosection_id` VARCHAR(45) NULL DEFAULT '0' AFTER `ID`," & _
                "CHANGE COLUMN `prosection_name` `prosection_name` VARCHAR(255) NULL DEFAULT '0' AFTER `prosection_id`," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL DEFAULT '0' AFTER `prosection_name`," & _
                "DROP PRIMARY KEY," & _
                "DROP INDEX `ID_UNIQUE`," & _
                "DROP INDEX `prosection_id_UNIQUE`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `product_id` " & _
                "CHANGE COLUMN `ID` `ID` INT(10) NULL DEFAULT NULL FIRST," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "CREATE TABLE `barcode_id` (" & _
                "`id` INT NULL," & _
                "`barcode_id` VARCHAR(500) NULL," & _
                "`datetime_save` VARCHAR(500) NULL" & _
                ")" & _
                "COLLATE='utf8_general_ci' " & _
                "ENGINE=InnoDB;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `taxinvoice_id` " & _
                "ALTER `id` DROP DEFAULT," & _
                "ALTER `datetime_save` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `taxinvoice_id` " & _
                "CHANGE COLUMN `id` `id` INT(11) NULL FIRST," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL AFTER `ti_id`," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `quotation_id` " & _
                "ALTER `id` DROP DEFAULT," & _
                "ALTER `datetime_save` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `quotation_id` " & _
                "CHANGE COLUMN `id` `id` INT(11) NULL FIRST," & _
                "CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(50) NULL AFTER `q_id`," & _
                "DROP PRIMARY KEY;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "CREATE TABLE `invoice_id` (" & _
                "`id` INT(11) NULL DEFAULT NULL," & _
                "`ti_id` VARCHAR(100) NULL DEFAULT NULL," & _
                "`datetime_save` VARCHAR(50) NULL DEFAULT NULL" & _
                ")" & _
                "COLLATE='utf8_general_ci' " & _
                "ENGINE = InnoDB;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `product_serial` " & _
                "CHANGE COLUMN `id` `id` BIGINT(200) UNSIGNED NOT NULL AUTO_INCREMENT AFTER `stop`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "ALTER TABLE `picture_all` " & _
                "CHANGE COLUMN `pa_id` `pa_id` INT(200) UNSIGNED NOT NULL AUTO_INCREMENT FIRST;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='4.3';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Module