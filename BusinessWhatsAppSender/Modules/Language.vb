Module Language
    Private i As Integer
    Dim _language As String
    Public CurrentLanguage As String
    Public Sub ApplyLanguage()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmAdd
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmAdd.BtnOK.Text = GetLangbyKey("FrmAdd.BtnOK")
        FrmAdd.BtnCancel.Text = GetLangbyKey("FrmAdd.BtnCancel")
        FrmAdd.Label1.Text = GetLangbyKey("FrmAdd.Label1")
        FrmAdd.Text = GetLangbyKey("FrmAdd")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmAddFamiliarAccount
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'FrmAddFamiliarAccount.BtnOk.Text = GetLangbyKey("FrmAddFamiliarAccount.BtnOk")
        'FrmAddFamiliarAccount.BtnCancel.Text = GetLangbyKey("FrmAddFamiliarAccount.BtnCancel")
        'FrmAddFamiliarAccount.Label1.Text = GetLangbyKey("FrmAddFamiliarAccount.Label1")
        'FrmAddFamiliarAccount.Label2.Text = GetLangbyKey("FrmAddFamiliarAccount.Label2")
        'FrmAddFamiliarAccount.Text = GetLangbyKey("FrmAddFamiliarAccount")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmAddMessage
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'FrmAddMessage.BtnOK.Text = GetLangbyKey("FrmAddMessage.BtnOK")
        'FrmAddMessage.BtnCancel.Text = GetLangbyKey("FrmAddMessage.BtnCancel")
        'FrmAddMessage.Label1.Text = GetLangbyKey("FrmAddMessage.Label1")
        'FrmAddMessage.Text = GetLangbyKey("FrmAddMessage")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmAdvanced
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmAdvanced.BtnAddFamiliarAccount.Text = GetLangbyKey("FrmAdvanced.BtnAddFamiliarAccount")
        FrmAdvanced.BtnDeleteFamiliarAccount.Text = GetLangbyKey("FrmAdvanced.BtnDeleteFamiliarAccount")
        FrmAdvanced.BtnAddMessages.Text = GetLangbyKey("FrmAdvanced.BtnAddMessages")
        FrmAdvanced.BtnDeleteMessages.Text = GetLangbyKey("FrmAdvanced.BtnDeleteMessages")
        FrmAdvanced.Label2.Text = GetLangbyKey("FrmAdvanced.Label2")
        FrmAdvanced.Label10.Text = GetLangbyKey("FrmAdvanced.Label10")
        FrmAdvanced.Label3.Text = GetLangbyKey("FrmAdvanced.Label3")
        FrmAdvanced.Label1.Text = GetLangbyKey("FrmAdvanced.Label1")
        FrmAdvanced.Label7.Text = GetLangbyKey("FrmAdvanced.Label7")
        FrmAdvanced.Label8.Text = GetLangbyKey("FrmAdvanced.Label8")
        FrmAdvanced.Button5.Text = GetLangbyKey("FrmAdvanced.Button5")
        FrmAdvanced.CheckBox2.Text = GetLangbyKey("FrmAdvanced.CheckBox2")
        FrmAdvanced.GroupBox4.Text = GetLangbyKey("FrmAdvanced.GroupBox4")
        FrmAdvanced.Label12.Text = GetLangbyKey("FrmAdvanced.Label12")
        FrmAdvanced.Label14.Text = GetLangbyKey("FrmAdvanced.Label14")
        FrmAdvanced.Label11.Text = GetLangbyKey("FrmAdvanced.Label11")
        FrmAdvanced.WaitFrom2.Text = GetLangbyKey("FrmAdvanced.WaitFrom2")
        FrmAdvanced.GroupBox5.Text = GetLangbyKey("FrmAdvanced.GroupBox5")
        FrmAdvanced.TabPage1.Text = GetLangbyKey("FrmAdvanced.TabPage1")
        FrmAdvanced.TabPage2.Text = GetLangbyKey("FrmAdvanced.TabPage2")
        FrmAdvanced.TabPage3.Text = GetLangbyKey("FrmAdvanced.TabPage3")
        FrmAdvanced.CheckBox1.Text = GetLangbyKey("FrmAdvanced.CheckBox1")
        FrmAdvanced.Label13.Text = GetLangbyKey("FrmAdvanced.Label13")
        FrmAdvanced.Label4.Text = GetLangbyKey("FrmAdvanced.Label4")
        FrmAdvanced.Label5.Text = GetLangbyKey("FrmAdvanced.Label5")
        FrmAdvanced.Label15.Text = GetLangbyKey("FrmAdvanced.Label15")
        FrmAdvanced.Text = GetLangbyKey("FrmAdvanced")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmAutoReply
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        FrmAutoReply.ButtonClear.Text = GetLangbyKey("FrmAutoReply.ButtonClear")
        FrmAutoReply.ButtonDelete.Text = GetLangbyKey("FrmAutoReply.ButtonDelete")
        FrmAutoReply.ButtonAdd.Text = GetLangbyKey("FrmAutoReply.ButtonAdd")
        FrmAutoReply.LabelAttachment.Text = GetLangbyKey("FrmAutoReply.LabelAttachment")
        FrmAutoReply.LabelMessage.Text = GetLangbyKey("FrmAutoReply.LabelMessage")
        FrmAutoReply.ButtonCancel.Text = GetLangbyKey("FrmAutoReply.ButtonCancel")
        FrmAutoReply.ButtonOK.Text = GetLangbyKey("FrmAutoReply.ButtonOK")
        FrmAutoReply.ColumnHeader1.Text = GetLangbyKey("FrmAutoReply.ColumnHeader1")
        FrmAutoReply.ColumnHeader2.Text = GetLangbyKey("FrmAutoReply.ColumnHeader2")
        FrmAutoReply.ColumnHeader3.Text = GetLangbyKey("FrmAutoReply.ColumnHeader3")
        FrmAutoReply.SetCaptionToolStripMenuItem.Text = GetLangbyKey("FrmAutoReply.SetCaptionToolStripMenuItem")
        FrmAutoReply.DeleteToolStripMenuItem1.Text = GetLangbyKey("FrmAutoReply.DeleteToolStripMenuItem1")
        FrmAutoReply.OpenFileToolStripMenuItem.Text = GetLangbyKey("FrmAutoReply.OpenFileToolStripMenuItem")
        FrmAutoReply.PhotosToolStripMenuItem.Text = GetLangbyKey("FrmAutoReply.PhotosToolStripMenuItem")
        FrmAutoReply.VideosToolStripMenuItem.Text = GetLangbyKey("FrmAutoReply.VideosToolStripMenuItem")
        FrmAutoReply.DocumentsToolStripMenuItem.Text = GetLangbyKey("FrmAutoReply.DocumentsToolStripMenuItem")
        FrmAutoReply.StickersToolStripMenuItem.Text = GetLangbyKey("FrmAutoReply.StickersToolStripMenuItem")
        FrmAutoReply.Text = GetLangbyKey("FrmAutoReply")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmBrowser
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmBrowser.Text = GetLangbyKey("FrmBrowser")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmFilter
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmFilter.ColumnHeader1.Text = GetLangbyKey("FrmFilter.ColumnHeader1")
        FrmFilter.ColumnHeader2.Text = GetLangbyKey("FrmFilter.ColumnHeader2")
        FrmFilter.ColumnHeader3.Text = GetLangbyKey("FrmFilter.ColumnHeader3")
        FrmFilter.ColumnHeader4.Text = GetLangbyKey("FrmFilter.ColumnHeader4")
        FrmFilter.ButtonImportFromFile.Text = GetLangbyKey("FrmFilter.ButtonImportFromFile")
        FrmFilter.ButtonManualImport.Text = GetLangbyKey("FrmFilter.ButtonManualImport")
        FrmFilter.ButtonNumberGenerator.Text = GetLangbyKey("FrmFilter.ButtonNumberGenerator")
        FrmFilter.ButtonExport.Text = GetLangbyKey("FrmFilter.ButtonExport")
        FrmFilter.Label4.Text = GetLangbyKey("FrmFilter.Label4")
        FrmFilter.ExportAllToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ExportAllToolStripMenuItem")
        FrmFilter.WhatsAppOnlyToolStripMenuItem.Text = GetLangbyKey("FrmFilter.WhatsAppOnlyToolStripMenuItem")
        FrmFilter.BusinessWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.BusinessWhatsAppToolStripMenuItem")
        FrmFilter.RegularWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.RegularWhatsAppToolStripMenuItem")
        FrmFilter.NonWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.NonWhatsAppToolStripMenuItem")
        FrmFilter.Button1.Text = GetLangbyKey("FrmFilter.Button1")
        FrmFilter.ButtonStop.Text = GetLangbyKey("FrmFilter.ButtonStop")
        FrmFilter.GroupBox1.Text = GetLangbyKey("FrmFilter.GroupBox1")
        FrmFilter.Label1.Text = GetLangbyKey("FrmFilter.Label1")
        FrmFilter.Label8.Text = GetLangbyKey("FrmFilter.Label8")
        FrmFilter.Label10.Text = GetLangbyKey("FrmFilter.Label10")
        FrmFilter.Label12.Text = GetLangbyKey("FrmFilter.Label12")
        FrmFilter.LabelRequestProgress.Text = GetLangbyKey("FrmFilter.LabelRequestProgress")
        FrmFilter.LabelVerificationProgress.Text = GetLangbyKey("FrmFilter.LabelVerificationProgress")
        FrmFilter.ButtonClear.Text = GetLangbyKey("FrmFilter.ButtonClear")
        FrmFilter.ButtonClose.Text = GetLangbyKey("FrmFilter.ButtonClose")
        FrmFilter.GroupBox2.Text = GetLangbyKey("FrmFilter.GroupBox2")
        FrmFilter.ButtonImporttosender.Text = GetLangbyKey("FrmFilter.ButtonImporttosender")
        FrmFilter.ImportAllWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ImportAllWhatsAppToolStripMenuItem")
        FrmFilter.ImportRegularWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ImportRegularWhatsAppToolStripMenuItem")
        FrmFilter.ImportBusinessWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ImportBusinessWhatsAppToolStripMenuItem")
        FrmFilter.Text = GetLangbyKey("FrmFilter")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmImportFromFiles
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmImportFromFiles.BtnOpenDialog.Text = GetLangbyKey("FrmImportFromFiles.BtnOpenDialog")
        FrmImportFromFiles.BtnImport.Text = GetLangbyKey("FrmImportFromFiles.BtnImport")
        FrmImportFromFiles.BtnCancel.Text = GetLangbyKey("FrmImportFromFiles.BtnCancel")
        FrmImportFromFiles.LinkLabel1.Text = GetLangbyKey("FrmImportFromFiles.LinkLabel1")
        FrmImportFromFiles.CheckBox1.Text = GetLangbyKey("FrmImportFromFiles.CheckBox1")
        FrmImportFromFiles.CheckBox2.Text = GetLangbyKey("FrmImportFromFiles.CheckBox2")
        FrmImportFromFiles.Label1.Text = GetLangbyKey("FrmImportFromFiles.Label1")
        FrmImportFromFiles.GroupBox2.Text = GetLangbyKey("FrmImportFromFiles.GroupBox2")
        FrmImportFromFiles.Label9.Text = GetLangbyKey("FrmImportFromFiles.Label9")
        FrmImportFromFiles.GroupBox3.Text = GetLangbyKey("FrmImportFromFiles.GroupBox3")
        FrmImportFromFiles.Label2.Text = GetLangbyKey("FrmImportFromFiles.Label2")
        FrmImportFromFiles.Label3.Text = GetLangbyKey("FrmImportFromFiles.Label3")
        FrmImportFromFiles.Label7.Text = GetLangbyKey("FrmImportFromFiles.Label7")
        FrmImportFromFiles.Label4.Text = GetLangbyKey("FrmImportFromFiles.Label4")
        FrmImportFromFiles.Label6.Text = GetLangbyKey("FrmImportFromFiles.Label6")
        FrmImportFromFiles.Label5.Text = GetLangbyKey("FrmImportFromFiles.Label5")
        FrmImportFromFiles.GroupBox1.Text = GetLangbyKey("FrmImportFromFiles.GroupBox1")
        FrmImportFromFiles.CheckBoxDelimeter.Text = GetLangbyKey("FrmImportFromFiles.CheckBoxDelimeter")
        FrmImportFromFiles.CheckBoxRemoveDuplication.Text = GetLangbyKey("FrmImportFromFiles.CheckBoxRemoveDuplication")
        FrmImportFromFiles.CheckBoxFirstRow.Text = GetLangbyKey("FrmImportFromFiles.CheckBoxFirstRow")
        FrmImportFromFiles.Label8.Text = GetLangbyKey("FrmImportFromFiles.Label8")
        FrmImportFromFiles.Text = GetLangbyKey("FrmImportFromFiles")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmLanguage
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmLanguage.LabelLanguage.Text = GetLangbyKey("FrmLanguage.LabelLanguage")
        FrmLanguage.BtnCancel.Text = GetLangbyKey("FrmLanguage.BtnCancel")
        FrmLanguage.BtnOK.Text = GetLangbyKey("FrmLanguage.BtnOK")
        FrmLanguage.Text = GetLangbyKey("FrmLanguage")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmLicense
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmLicense.Label1.Text = GetLangbyKey("FrmLicense.Label1")
        FrmLicense.Label3.Text = GetLangbyKey("FrmLicense.Label3")
        FrmLicense.Button1.Text = GetLangbyKey("FrmLicense.Button1")
        FrmLicense.Button2.Text = GetLangbyKey("FrmLicense.Button2")
        FrmLicense.Button3.Text = GetLangbyKey("FrmLicense.Button3")
        'FrmLicense.Text = GetLangbyKey("FrmLicense")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmLog
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmLog.MenuStrip1.Text = GetLangbyKey("FrmLog.MenuStrip1")
        FrmLog.FileToolStripMenuItem.Text = GetLangbyKey("FrmLog.FileToolStripMenuItem")
        FrmLog.SaveLogToolStripMenuItem.Text = GetLangbyKey("FrmLog.SaveLogToolStripMenuItem")
        FrmLog.ExitToolStripMenuItem.Text = GetLangbyKey("FrmLog.ExitToolStripMenuItem")
        FrmLog.Text = GetLangbyKey("FrmLog")



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmMain
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        FrmMain.FF3.Text = GetLangbyKey("FrmMain.FF3")
        FrmMain.MM3.Text = GetLangbyKey("FrmMain.MM3")
        FrmMain.DeleteToolStripMenuItem.Text = GetLangbyKey("FrmMain.DeleteToolStripMenuItem")
        FrmMain.ClearListToolStripMenuItem.Text = GetLangbyKey("FrmMain.ClearListToolStripMenuItem")
        FrmMain.MnStripMain.Text = GetLangbyKey("FrmMain.MnStripMain")
        FrmMain.FileToolStripMenuItem.Text = GetLangbyKey("FrmMain.FileToolStripMenuItem")
        FrmMain.NewBulkToolStripMenuItem.Text = GetLangbyKey("FrmMain.NewBulkToolStripMenuItem")
        FrmMain.NewAutoReplyRuleToolStripMenuItem.Text = GetLangbyKey("FrmMain.NewAutoReplyRuleToolStripMenuItem")
        FrmMain.ImportNumbersToolStripMenuItem.Text = GetLangbyKey("FrmMain.ImportNumbersToolStripMenuItem")
        FrmMain.FF2.Text = GetLangbyKey("FrmMain.FF2")
        FrmMain.MM2.Text = GetLangbyKey("FrmMain.MM2")
        FrmMain.WhatsAppContactsToolStripMenuItem.Text = GetLangbyKey("FrmMain.WhatsAppContactsToolStripMenuItem")
        FrmMain.WhatsAppGroupsToolStripMenuItem.Text = GetLangbyKey("FrmMain.WhatsAppGroupsToolStripMenuItem")
        FrmMain.ImportMessageToolStripMenuItem.Text = GetLangbyKey("FrmMain.ImportMessageToolStripMenuItem")
        FrmMain.ExportNumbersToolStripMenuItem.Text = GetLangbyKey("FrmMain.ExportNumbersToolStripMenuItem")
        FrmMain.SaveMessageToolStripMenuItem.Text = GetLangbyKey("FrmMain.SaveMessageToolStripMenuItem")
        FrmMain.ExitToolStripMenuItem.Text = GetLangbyKey("FrmMain.ExitToolStripMenuItem")
        FrmMain.EditToolStripMenuItem.Text = GetLangbyKey("FrmMain.EditToolStripMenuItem")
        FrmMain.ClearNumbersListToolStripMenuItem.Text = GetLangbyKey("FrmMain.ClearNumbersListToolStripMenuItem")
        FrmMain.ClearMessageToolStripMenuItem.Text = GetLangbyKey("FrmMain.ClearMessageToolStripMenuItem")
        FrmMain.ClearLogToolStripMenuItem.Text = GetLangbyKey("FrmMain.ClearLogToolStripMenuItem")
        FrmMain.ViewToolStripMenuItem.Text = GetLangbyKey("FrmMain.ViewToolStripMenuItem")
        FrmMain.SentCampaignsToolStripMenuItem.Text = GetLangbyKey("FrmMain.SentCampaignsToolStripMenuItem")
        FrmMain.ReceivedMessageToolStripMenuItem.Text = GetLangbyKey("FrmMain.ReceivedMessageToolStripMenuItem")
        FrmMain.LogsToolStripMenuItem.Text = GetLangbyKey("FrmMain.LogsToolStripMenuItem")
        FrmMain.SettingsToolStripMenuItem1.Text = GetLangbyKey("FrmMain.SettingsToolStripMenuItem1")
        FrmMain.SendingSettingsToolStripMenuItem.Text = GetLangbyKey("FrmMain.SendingSettingsToolStripMenuItem")
        FrmMain.SetAutoReplyToolStripMenuItem1.Text = GetLangbyKey("FrmMain.SetAutoReplyToolStripMenuItem1")
        FrmMain.LanguagesToolStripMenuItem.Text = GetLangbyKey("FrmMain.LanguagesToolStripMenuItem")
        FrmMain.ThemesToolStripMenuItem.Text = GetLangbyKey("FrmMain.ThemesToolStripMenuItem")
        FrmMain.ToolsToolStripMenuItem.Text = GetLangbyKey("FrmMain.ToolsToolStripMenuItem")
        FrmMain.NumberFilterToolStripMenuItem.Text = GetLangbyKey("FrmMain.NumberFilterToolStripMenuItem")
        FrmMain.VirtualNumbersToolStripMenuItem.Text = GetLangbyKey("FrmMain.VirtualNumbersToolStripMenuItem")
        FrmMain.HelpToolStripMenuItem.Text = GetLangbyKey("FrmMain.HelpToolStripMenuItem")
        FrmMain.ViewHelpToolStripMenuItem.Text = GetLangbyKey("FrmMain.ViewHelpToolStripMenuItem")
        FrmMain.CheckForUpdateToolStripMenuItem.Text = GetLangbyKey("FrmMain.CheckForUpdateToolStripMenuItem")

        FrmMain.AboutToolStripMenuItem.Text = GetLangbyKey("FrmMain.AboutToolStripMenuItem")
        FrmMain.ColumnHeader3.Text = GetLangbyKey("FrmMain.ColumnHeader3")
        FrmMain.ColumnHeader4.Text = GetLangbyKey("FrmMain.ColumnHeader4")
        FrmMain.ColumnHeader5.Text = GetLangbyKey("FrmMain.ColumnHeader5")
        FrmMain.SetCaptionToolStripMenuItem.Text = GetLangbyKey("FrmMain.SetCaptionToolStripMenuItem")
        FrmMain.DeleteToolStripMenuItem1.Text = GetLangbyKey("FrmMain.DeleteToolStripMenuItem1")
        FrmMain.OpenFileToolStripMenuItem.Text = GetLangbyKey("FrmMain.OpenFileToolStripMenuItem")

        FrmMain.Label17.Text = GetLangbyKey("FrmMain.Label17")

        FrmMain.BtnSending.Text = GetLangbyKey("FrmMain.BtnSending")
        FrmMain.HeadarPanel.Text = GetLangbyKey("FrmMain.HeadarPanel")
        FrmMain.Label10.Text = GetLangbyKey("FrmMain.Label10")
        FrmMain.ButtonOpenWhatsApp.Text = GetLangbyKey("FrmMain.ButtonOpenWhatsApp")
        FrmMain.FF1.Text = GetLangbyKey("FrmMain.FF1")
        FrmMain.MM1.Text = GetLangbyKey("FrmMain.MM1")
        FrmMain.ImportFromWhatsAppContactsToolStripMenuItem.Text = GetLangbyKey("FrmMain.ImportFromWhatsAppContactsToolStripMenuItem")
        FrmMain.ImportFromWhatsAppGroupsToolStripMenuItem.Text = GetLangbyKey("FrmMain.ImportFromWhatsAppGroupsToolStripMenuItem")
        FrmMain.LblNumbers.Text = GetLangbyKey("FrmMain.LblNumbers")
        FrmMain.ClnNumber.Text = GetLangbyKey("FrmMain.ClnNumber")
        FrmMain.ColumnHeader2.Text = GetLangbyKey("FrmMain.ColumnHeader2")
        FrmMain.ColumnHeader6.Text = GetLangbyKey("FrmMain.ColumnHeader6")
        FrmMain.ColumnHeader7.Text = GetLangbyKey("FrmMain.ColumnHeader7")
        FrmMain.ColumnHeader8.Text = GetLangbyKey("FrmMain.ColumnHeader8")
        FrmMain.ColumnHeader9.Text = GetLangbyKey("FrmMain.ColumnHeader9")
        FrmMain.ColumnHeader10.Text = GetLangbyKey("FrmMain.ColumnHeader10")
        FrmMain.LabelLoginStatus.Text = GetLangbyKey("FrmMain.LabelLoginStatus")
        FrmMain.Label4.Text = GetLangbyKey("FrmMain.Label4")
        FrmMain.Button19.Text = GetLangbyKey("FrmMain.Button19")
        FrmMain.InsertFullNameToolStripMenuItem.Text = GetLangbyKey("FrmMain.InsertFullNameToolStripMenuItem")
        FrmMain.InsertFirstNameToolStripMenuItem.Text = GetLangbyKey("FrmMain.InsertFirstNameToolStripMenuItem")
        FrmMain.InsertLastNameToolStripMenuItem.Text = GetLangbyKey("FrmMain.InsertLastNameToolStripMenuItem")
        FrmMain.InsertVarToolStripMenuItem.Text = GetLangbyKey("FrmMain.InsertVarToolStripMenuItem")
        FrmMain.Variable1ToolStripMenuItem.Text = GetLangbyKey("FrmMain.Variable1ToolStripMenuItem")
        FrmMain.Variable2ToolStripMenuItem1.Text = GetLangbyKey("FrmMain.Variable2ToolStripMenuItem1")
        FrmMain.Variable3ToolStripMenuItem1.Text = GetLangbyKey("FrmMain.Variable3ToolStripMenuItem1")
        FrmMain.Variable4ToolStripMenuItem1.Text = GetLangbyKey("FrmMain.Variable4ToolStripMenuItem1")
        FrmMain.Variable5ToolStripMenuItem1.Text = GetLangbyKey("FrmMain.Variable5ToolStripMenuItem1")
        FrmMain.InsertRandomTagToolStripMenuItem.Text = GetLangbyKey("FrmMain.InsertRandomTagToolStripMenuItem")
        FrmMain.InsertSpintaxToolStripMenuItem.Text = GetLangbyKey("FrmMain.InsertSpintaxToolStripMenuItem")
        FrmMain.Button4.Text = GetLangbyKey("FrmMain.Button4")
        FrmMain.Button5.Text = GetLangbyKey("FrmMain.Button5")
        FrmMain.ToolStripMenuItem16.Text = GetLangbyKey("FrmMain.ToolStripMenuItem16")
        FrmMain.Variable2ToolStripMenuItem.Text = GetLangbyKey("FrmMain.Variable2ToolStripMenuItem")
        FrmMain.Variable3ToolStripMenuItem.Text = GetLangbyKey("FrmMain.Variable3ToolStripMenuItem")
        FrmMain.Variable4ToolStripMenuItem.Text = GetLangbyKey("FrmMain.Variable4ToolStripMenuItem")
        FrmMain.Variable5ToolStripMenuItem.Text = GetLangbyKey("FrmMain.Variable5ToolStripMenuItem")
        FrmMain.Button20.Text = GetLangbyKey("FrmMain.Button20")
        FrmMain.Button9.Text = GetLangbyKey("FrmMain.Button9")
        FrmMain.Button7.Text = GetLangbyKey("FrmMain.Button7")
        FrmMain.Button14.Text = GetLangbyKey("FrmMain.Button14")
        FrmMain.Button15.Text = GetLangbyKey("FrmMain.Button15")
        FrmMain.Button16.Text = GetLangbyKey("FrmMain.Button16")
        FrmMain.ColumnHeader1.Text = GetLangbyKey("FrmMain.ColumnHeader1")
        FrmMain.ColumnHeader11.Text = GetLangbyKey("FrmMain.ColumnHeader11")
        FrmMain.ColumnHeader12.Text = GetLangbyKey("FrmMain.ColumnHeader12")
        FrmMain.Label2.Text = GetLangbyKey("FrmMain.Label2")
        FrmMain.ButtonSchedule.Text = GetLangbyKey("FrmMain.ButtonSchedule")
        FrmMain.LabelGroups.Text = GetLangbyKey("FrmMain.LabelGroups")
        FrmMain.LabelContacts.Text = GetLangbyKey("FrmMain.LabelContacts")
        FrmMain.ColumnHeader13.Text = GetLangbyKey("FrmMain.ColumnHeader13")
        FrmMain.ColumnHeader18.Text = GetLangbyKey("FrmMain.ColumnHeader18")
        FrmMain.ColumnHeader14.Text = GetLangbyKey("FrmMain.ColumnHeader14")
        FrmMain.ModifyRuleToolStripMenuItem.Text = GetLangbyKey("FrmMain.ModifyRuleToolStripMenuItem")
        FrmMain.DeleteRuleToolStripMenuItem.Text = GetLangbyKey("FrmMain.DeleteRuleToolStripMenuItem")
        FrmMain.Label1.Text = GetLangbyKey("FrmMain.Label1")

        FrmMain.PhotosToolStripMenuItem.Text = GetLangbyKey("FrmMain.PhotosToolStripMenuItem")
        FrmMain.VideosToolStripMenuItem.Text = GetLangbyKey("FrmMain.VideosToolStripMenuItem")
        FrmMain.DocumentsToolStripMenuItem.Text = GetLangbyKey("FrmMain.DocumentsToolStripMenuItem")
        FrmMain.SetAutoReplyToolStripMenuItem.Text = GetLangbyKey("FrmMain.SetAutoReplyToolStripMenuItem")
        FrmMain.AddAutoReplyRuleToolStripMenuItem.Text = GetLangbyKey("FrmMain.AddAutoReplyRuleToolStripMenuItem")
        FrmMain.ResetAutoReplyToolStripMenuItem.Text = GetLangbyKey("FrmMain.ResetAutoReplyToolStripMenuItem")
        FrmMain.ExportReceivedMessageToolStripMenuItem.Text = GetLangbyKey("FrmMain.ExportReceivedMessageToolStripMenuItem")
        FrmMain.ClearListToolStripMenuItem1.Text = GetLangbyKey("FrmMain.ClearListToolStripMenuItem1")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmManualImports
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmManualImports.BtnCancel.Text = GetLangbyKey("FrmManualImports.BtnCancel")
        FrmManualImports.BtnImport.Text = GetLangbyKey("FrmManualImports.BtnImport")
        FrmManualImports.Label2.Text = GetLangbyKey("FrmManualImports.Label2")
        FrmManualImports.ColumnHeader1.Text = GetLangbyKey("FrmManualImports.ColumnHeader1")
        FrmManualImports.ColumnHeader2.Text = GetLangbyKey("FrmManualImports.ColumnHeader2")
        FrmManualImports.LabelCount.Text = GetLangbyKey("FrmManualImports.LabelCount")
        FrmManualImports.CheckBoxRemoveDuplication.Text = GetLangbyKey("FrmManualImports.CheckBoxRemoveDuplication")
        FrmManualImports.Label1.Text = GetLangbyKey("FrmManualImports.Label1")
        FrmManualImports.Label3.Text = GetLangbyKey("FrmManualImports.Label3")
        FrmManualImports.LabelDuplication.Text = GetLangbyKey("FrmManualImports.LabelDuplication")
        FrmManualImports.Text = GetLangbyKey("FrmManualImports")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmMessages
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmNumberGenerator
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmNumberGenerator.Label1.Text = GetLangbyKey("FrmNumberGenerator.Label1")
        FrmNumberGenerator.Label2.Text = GetLangbyKey("FrmNumberGenerator.Label2")
        FrmNumberGenerator.BtnOK.Text = GetLangbyKey("FrmNumberGenerator.BtnOK")
        FrmNumberGenerator.BtnCancel.Text = GetLangbyKey("FrmNumberGenerator.BtnCancel")
        FrmNumberGenerator.Label3.Text = GetLangbyKey("FrmNumberGenerator.Label3")
        FrmNumberGenerator.Text = GetLangbyKey("FrmNumberGenerator")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmReceived
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmReceived.ColumnHeader1.Text = GetLangbyKey("FrmReceived.ColumnHeader1")
        FrmReceived.ColumnHeader2.Text = GetLangbyKey("FrmReceived.ColumnHeader2")
        FrmReceived.ColumnHeader3.Text = GetLangbyKey("FrmReceived.ColumnHeader3")
        FrmReceived.ColumnHeader4.Text = GetLangbyKey("FrmReceived.ColumnHeader4")
        FrmReceived.Text = GetLangbyKey("FrmReceived")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmReceivedMessage
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmReceivedMessage.LabelReceivedDate.Text = GetLangbyKey("FrmReceivedMessage.LabelReceivedDate")
        FrmReceivedMessage.LabelSender.Text = GetLangbyKey("FrmReceivedMessage.LabelSender")
        FrmReceivedMessage.LabelReceivedMessage.Text = GetLangbyKey("FrmReceivedMessage.LabelReceivedMessage")
        FrmReceivedMessage.LabelReplytoSender.Text = GetLangbyKey("FrmReceivedMessage.LabelReplytoSender")
        FrmReceivedMessage.ButtonSend.Text = GetLangbyKey("FrmReceivedMessage.ButtonSend")
        FrmReceivedMessage.ButtonClose.Text = GetLangbyKey("FrmReceivedMessage.ButtonClose")
        FrmReceivedMessage.Text = GetLangbyKey("FrmReceivedMessage")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmRules
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmRules.ColumnHeader1.Text = GetLangbyKey("FrmRules.ColumnHeader1")
        FrmRules.ColumnHeader2.Text = GetLangbyKey("FrmRules.ColumnHeader2")
        FrmRules.ColumnHeader3.Text = GetLangbyKey("FrmRules.ColumnHeader3")
        FrmRules.SetCaptionToolStripMenuItem.Text = GetLangbyKey("FrmRules.SetCaptionToolStripMenuItem")
        FrmRules.DeleteToolStripMenuItem1.Text = GetLangbyKey("FrmRules.DeleteToolStripMenuItem1")
        FrmRules.OpenFileToolStripMenuItem.Text = GetLangbyKey("FrmRules.OpenFileToolStripMenuItem")
        FrmRules.ButtonOK.Text = GetLangbyKey("FrmRules.ButtonOK")
        FrmRules.ButtonCancel.Text = GetLangbyKey("FrmRules.ButtonCancel")
        FrmRules.LabelRuleName.Text = GetLangbyKey("FrmRules.LabelRuleName")
        FrmRules.LabelKeyword.Text = GetLangbyKey("FrmRules.LabelKeyword")
        FrmRules.LabelMessage.Text = GetLangbyKey("FrmRules.LabelMessage")
        FrmRules.LabelAttachment.Text = GetLangbyKey("FrmRules.LabelAttachment")
        FrmRules.ButtonAdd.Text = GetLangbyKey("FrmRules.ButtonAdd")
        FrmRules.ButtonModify.Text = GetLangbyKey("FrmRules.ButtonModify")
        FrmRules.ButtonDelete.Text = GetLangbyKey("FrmRules.ButtonDelete")
        FrmRules.ButtonClear.Text = GetLangbyKey("FrmRules.ButtonClear")
        FrmRules.CheckBoxEnable.Text = GetLangbyKey("FrmRules.CheckBoxEnable")
        FrmRules.PhotosToolStripMenuItem.Text = GetLangbyKey("FrmRules.PhotosToolStripMenuItem")
        FrmRules.VideosToolStripMenuItem.Text = GetLangbyKey("FrmRules.VideosToolStripMenuItem")
        FrmRules.DocumentsToolStripMenuItem.Text = GetLangbyKey("FrmRules.DocumentsToolStripMenuItem")
        FrmRules.StickersToolStripMenuItem.Text = GetLangbyKey("FrmRules.StickersToolStripMenuItem")
        FrmRules.Text = GetLangbyKey("FrmRules")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmSending
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmSending.ColumnHeader1.Text = GetLangbyKey("FrmSending.ColumnHeader1")
        FrmSending.ColumnHeader3.Text = GetLangbyKey("FrmSending.ColumnHeader3")
        FrmSending.ColumnHeader2.Text = GetLangbyKey("FrmSending.ColumnHeader2")
        FrmSending.ColumnHeader5.Text = GetLangbyKey("FrmSending.ColumnHeader5")
        FrmSending.ColumnHeader4.Text = GetLangbyKey("FrmSending.ColumnHeader4")
        FrmSending.ColumnHeader6.Text = GetLangbyKey("FrmSending.ColumnHeader6")
        FrmSending.ButtonStop.Text = GetLangbyKey("FrmSending.ButtonStop")
        FrmSending.ButtonPause.Text = GetLangbyKey("FrmSending.ButtonPause")
        FrmSending.LabelProgress.Text = GetLangbyKey("FrmSending.LabelProgress")
        FrmSending.ButtonViewLog.Text = GetLangbyKey("FrmSending.ButtonViewLog")
        FrmSending.LabelCountDown.Text = GetLangbyKey("FrmSending.LabelCountDown")
        FrmSending.LabelCountDownHeader.Text = GetLangbyKey("FrmSending.LabelCountDownHeader")

        '  FrmSending.ExportSuccessfulToolStripMenuItem.Text = GetLangbyKey("FrmSending.ExportSuccessfulToolStripMenuItem")
        ' FrmSending.ExportAllToolStripMenuItem.Text = GetLangbyKey("FrmSending.ExportAllToolStripMenuItem")
        FrmSending.Text = GetLangbyKey("FrmSending")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmSendingMode
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmSendingMode.ButtonOK.Text = GetLangbyKey("FrmSendingMode.ButtonOK")
        FrmSendingMode.ButtonCancel.Text = GetLangbyKey("FrmSendingMode.ButtonCancel")
        FrmSendingMode.Label2.Text = GetLangbyKey("FrmSendingMode.Label2")
        FrmSendingMode.Label1.Text = GetLangbyKey("FrmSendingMode.Label1")
        FrmSendingMode.Text = GetLangbyKey("FrmSendingMode")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmSendingType
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmSendingType.RadioButtonSafeMode.Text = GetLangbyKey("FrmSendingType.RadioButtonSafeMode")
        FrmSendingType.RadioButtonBlindMode.Text = GetLangbyKey("FrmSendingType.RadioButtonBlindMode")
        FrmSendingType.Label1.Text = GetLangbyKey("FrmSendingType.Label1")
        FrmSendingType.Label2.Text = GetLangbyKey("FrmSendingType.Label2")
        FrmSendingType.ButtonOK.Text = GetLangbyKey("FrmSendingType.ButtonOK")
        FrmSendingType.ButtonCancel.Text = GetLangbyKey("FrmSendingType.ButtonCancel")
        FrmSendingType.Label3.Text = GetLangbyKey("FrmSendingType.Label3")
        FrmSendingType.Label4.Text = GetLangbyKey("FrmSendingType.Label4")
        FrmSendingType.Label6.Text = GetLangbyKey("FrmSendingType.Label6")
        FrmSendingType.Text = GetLangbyKey("FrmSendingType")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmSentCampain
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        FrmSentCampain.ColumnHeader1.Text = GetLangbyKey("FrmSentCampain.ColumnHeader1")
        FrmSentCampain.ColumnHeader2.Text = GetLangbyKey("FrmSentCampain.ColumnHeader2")
        FrmSentCampain.Text = GetLangbyKey("FrmSentCampain")


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmSetCaption
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        FrmSetCaption.BtnOK.Text = GetLangbyKey("FrmSetCaption.BtnOK")
        FrmSetCaption.BtnCancel.Text = GetLangbyKey("FrmSetCaption.BtnCancel")
        FrmSetCaption.LinkLastName.Text = GetLangbyKey("FrmSetCaption.LinkLastName")
        FrmSetCaption.LinkFirstName.Text = GetLangbyKey("FrmSetCaption.LinkFirstName")
        FrmSetCaption.Text = GetLangbyKey("FrmSetCaption")


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmSpintax
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'FrmSpintax.Label1.Text = GetLangbyKey("FrmSpintax.Label1")
        'FrmSpintax.Label2.Text = GetLangbyKey("FrmSpintax.Label2")
        'FrmSpintax.Label3.Text = GetLangbyKey("FrmSpintax.Label3")
        'FrmSpintax.Label4.Text = GetLangbyKey("FrmSpintax.Label4")
        'FrmSpintax.Label5.Text = GetLangbyKey("FrmSpintax.Label5")
        'FrmSpintax.Label6.Text = GetLangbyKey("FrmSpintax.Label6")
        'FrmSpintax.Label7.Text = GetLangbyKey("FrmSpintax.Label7")
        'FrmSpintax.Label8.Text = GetLangbyKey("FrmSpintax.Label8")
        'FrmSpintax.Label9.Text = GetLangbyKey("FrmSpintax.Label9")
        'FrmSpintax.Label10.Text = GetLangbyKey("FrmSpintax.Label10")
        'FrmSpintax.Label11.Text = GetLangbyKey("FrmSpintax.Label11")
        'FrmSpintax.Label12.Text = GetLangbyKey("FrmSpintax.Label12")
        'FrmSpintax.Label13.Text = GetLangbyKey("FrmSpintax.Label13")
        'FrmSpintax.Label14.Text = GetLangbyKey("FrmSpintax.Label14")
        'FrmSpintax.Label15.Text = GetLangbyKey("FrmSpintax.Label15")
        'FrmSpintax.Label16.Text = GetLangbyKey("FrmSpintax.Label16")
        'FrmSpintax.Label17.Text = GetLangbyKey("FrmSpintax.Label17")
        'FrmSpintax.Label18.Text = GetLangbyKey("FrmSpintax.Label18")
        'FrmSpintax.Button1.Text = GetLangbyKey("FrmSpintax.Button1")
        'FrmSpintax.Button2.Text = GetLangbyKey("FrmSpintax.Button2")
        'FrmSpintax.Button3.Text = GetLangbyKey("FrmSpintax.Button3")
        'FrmSpintax.Text = GetLangbyKey("FrmSpintax")







    End Sub
    Public Function GetLangbyKey(ByVal objectName As String) As String
        Try
            Dim lstlang As List(Of ClsLangModel) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ClsLangModel))(IO.File.ReadAllText(Application.StartupPath & "\languages\" & CurrentLanguage & ".json"))
            Dim _lang As ClsLangModel
            For Each _lang In lstlang
                If _lang.Key = objectName Then

                    Return _lang.Text
                    Exit Function
                End If
            Next
            Return objectName
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            End
        End Try

    End Function


End Module
