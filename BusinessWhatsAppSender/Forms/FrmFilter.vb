
Public Class FrmFilter
    Private ForceStop As Boolean
    Private Sub FrmFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Form:FrmFilter
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ColumnHeader1.Text = GetLangbyKey("FrmFilter.ColumnHeader1")
        ColumnHeader2.Text = GetLangbyKey("FrmFilter.ColumnHeader2")
        ColumnHeader3.Text = GetLangbyKey("FrmFilter.ColumnHeader3")
        ColumnHeader4.Text = GetLangbyKey("FrmFilter.ColumnHeader4")
        ButtonImportFromFile.Text = GetLangbyKey("FrmFilter.ButtonImportFromFile")
        ButtonManualImport.Text = GetLangbyKey("FrmFilter.ButtonManualImport")
        ButtonNumberGenerator.Text = GetLangbyKey("FrmFilter.ButtonNumberGenerator")
        ButtonExport.Text = GetLangbyKey("FrmFilter.ButtonExport")
        Label4.Text = GetLangbyKey("FrmFilter.Label4")
        ExportAllToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ExportAllToolStripMenuItem")
        WhatsAppOnlyToolStripMenuItem.Text = GetLangbyKey("FrmFilter.WhatsAppOnlyToolStripMenuItem")
        BusinessWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.BusinessWhatsAppToolStripMenuItem")
        RegularWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.RegularWhatsAppToolStripMenuItem")
        NonWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.NonWhatsAppToolStripMenuItem")
        Button1.Text = GetLangbyKey("FrmFilter.Button1")
        ButtonStop.Text = GetLangbyKey("FrmFilter.ButtonStop")
        GroupBox1.Text = GetLangbyKey("FrmFilter.GroupBox1")
        Label1.Text = GetLangbyKey("FrmFilter.Label1")
        Label8.Text = GetLangbyKey("FrmFilter.Label8")
        Label10.Text = GetLangbyKey("FrmFilter.Label10")
        Label12.Text = GetLangbyKey("FrmFilter.Label12")
        LabelRequestProgress.Text = GetLangbyKey("FrmFilter.LabelRequestProgress")
        LabelVerificationProgress.Text = GetLangbyKey("FrmFilter.LabelVerificationProgress")
        ButtonClear.Text = GetLangbyKey("FrmFilter.ButtonClear")
        ButtonClose.Text = GetLangbyKey("FrmFilter.ButtonClose")
        GroupBox2.Text = GetLangbyKey("FrmFilter.GroupBox2")
        ButtonImporttosender.Text = GetLangbyKey("FrmFilter.ButtonImporttosender")
        ImportAllWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ImportAllWhatsAppToolStripMenuItem")
        ImportRegularWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ImportRegularWhatsAppToolStripMenuItem")
        ImportBusinessWhatsAppToolStripMenuItem.Text = GetLangbyKey("FrmFilter.ImportBusinessWhatsAppToolStripMenuItem")
        Me.Text = GetLangbyKey("FrmFilter")


        NumericUpDownDelay.Value = GetSetting(Application.ProductName, "Filter", "delay", "0")
        If LicenseMode Then
            CheckLicense()

            If Not allowFilter Then
                MsgBox("Not allowed to use this option , please check your vendor", vbInformation, ApplicationTitle)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonManualImport.Click
        Dim Importer As New ManualImport
        Dim _contact As WhatsAppContact
        If Importer.Showdialog = DialogResult.OK Then
            ListViewNumbers.Visible = False
            Dim ContactItem As ListViewItem
            For Each _contact In Importer.Contacts
                ContactItem = New ListViewItem
                ContactItem.Tag = _contact.WhatsAppID
                ContactItem.Text = _contact.WhatsAppName
                ContactItem.SubItems.Add(_contact.WhatsAppContact)
                ContactItem.SubItems.Add("")
                ContactItem.SubItems.Add("")
                ListViewNumbers.Items.Add(ContactItem)
            Next
            ListViewNumbers.Visible = True
            getListCount()
        End If
    End Sub
    Private Sub ValidateItem(ByRef item As ListViewItem)
        Dim _jsonItems() As String = Split(NumberCheckedList, "|")
        Dim _jsonItem As String
        Dim tempVal As String = ""
        For Each _jsonItem In _jsonItems
            If _jsonItem.Contains(item.Tag) Then
                NumberCheckedList = NumberCheckedList.Replace(_jsonItem & "|", "")
                tempVal = _jsonItem.Replace("""", "'")

                If tempVal.Contains("'numberExists':false") Then
                    item.SubItems(3).Text = "NO"
                    item.BackColor = Color.LightCoral
                End If
                If tempVal.Contains("'numberExists':true") Then
                    item.SubItems(3).Text = "YES"

                    If tempVal.Contains("'isBusiness':true") Then
                        item.SubItems(2).Text = "BIZ"
                        item.BackColor = Color.LightBlue
                    Else
                        item.SubItems(2).Text = "REG"
                        item.BackColor = Color.LightGreen
                    End If
                End If
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerVerification.Tick
        Dim li As ListViewItem
        For Each li In ListViewNumbers.Items
            If li.SubItems(3).Text = "Requested" Then
                ValidateItem(li)
            End If
        Next
        GetWhatsAppStatistics()
    End Sub
    Sub GetWhatsAppStatistics()
        Dim li As ListViewItem
        Dim WhatsAppCount As Integer = 0
        Dim BizCount As Integer = 0
        Dim RegCount As Integer = 0
        Dim Total As Integer = 1
        For Each li In ListViewNumbers.Items
            If Total < ListViewNumbers.Items.Count Then
                If li.SubItems(3).Text = "YES" Then
                    WhatsAppCount = WhatsAppCount + 1
                    If li.SubItems(2).Text = "BIZ" Then
                        BizCount = BizCount + 1
                    Else
                        RegCount = RegCount + 1
                    End If
                End If
                If li.SubItems(3).Text = "YES" Or li.SubItems(3).Text = "NO" Then
                    Total = Total + 1
                End If
            End If
        Next
        ProgressBar2.Value = Total
        LabelVerificationProgress.Text = "Verification Progress(" & Total & "/" & ListViewNumbers.Items.Count & ")"
        LabelWhatsApp.Text = WhatsAppCount
        LabelRegular.Text = RegCount
        LabelBusiness.Text = BizCount
        Application.DoEvents()
    End Sub
    Private Sub ButtonImportFromFile_Click(sender As Object, e As EventArgs) Handles ButtonImportFromFile.Click
        Dim Importer As New FileImports
        Dim _contact As WhatsAppContact
        If Importer.Showdialog = DialogResult.OK Then
            ListViewNumbers.Visible = False
            Dim ContactItem As ListViewItem
            For Each _contact In Importer.Contacts
                ContactItem = New ListViewItem
                ContactItem.Tag = _contact.WhatsAppID
                ContactItem.Text = _contact.WhatsAppName
                ContactItem.SubItems.Add(_contact.WhatsAppContact)
                ContactItem.SubItems.Add("")
                ContactItem.SubItems.Add("")
                ListViewNumbers.Items.Add(ContactItem)
            Next
            ListViewNumbers.Visible = True
            getListCount()
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to clear the list ?", vbYesNo + MsgBoxStyle.Question, Application.ProductName) = MsgBoxResult.Yes Then
            ListViewNumbers.Items.Clear()
            getListCount()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click

    End Sub

    Private Sub Button7_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonExport.MouseUp
        ContextMenuStripExport.Show(ButtonExport, e.Location)
    End Sub

    Public Sub Export(ByVal ExportType As Integer)
        If ListViewNumbers.Items.Count = 0 Then
            MsgBox("No records to exports", vbInformation, Application.ProductName)
            Exit Sub
        End If

        Dim li As ListViewItem
        Dim Result As String = ""

        For Each li In ListViewNumbers.Items
            Select Case ExportType
                Case 0
                    Result = Result & li.Text & vbTab & li.SubItems(1).Text & vbNewLine
                Case 1
                    If li.SubItems(3).Text = "YES" Then
                        Result = Result & li.Text & vbTab & li.SubItems(1).Text & vbNewLine
                    End If

                Case 2
                    If li.SubItems(2).Text = "REG" Then
                        Result = Result & li.Text & vbTab & li.SubItems(1).Text & vbNewLine
                    End If
                Case 3
                    If li.SubItems(2).Text = "BIZ" Then
                        Result = Result & li.Text & vbTab & li.SubItems(1).Text & vbNewLine
                    End If
                Case 4
                    If li.SubItems(3).Text = "NO" Then
                        Result = Result & li.Text & vbTab & li.SubItems(1).Text & vbNewLine
                    End If
            End Select
        Next

        Dim SaveDlg As New SaveFileDialog
        Select Case ExportType
            Case 0
                SaveDlg.FileName = "All_Numbers.txt"

            Case 1
                SaveDlg.FileName = "WhatsApp_Numbers.txt"

            Case 2
                SaveDlg.FileName = "Normal_WhatsApp_Numbers.txt"
            Case 3
                SaveDlg.FileName = "BizWhatsApp_Numbers.txt"
            Case 4
                SaveDlg.FileName = "Non_WhatsApp_Numbers.txt"
        End Select

        SaveDlg.Filter = "*.txt|*.txt"
        If SaveDlg.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(SaveDlg.FileName, Result)
        End If

    End Sub

    Private Sub ExportAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAllToolStripMenuItem.Click
        Export(0)
    End Sub

    Private Sub WhatsAppOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsAppOnlyToolStripMenuItem.Click
        Export(1)
    End Sub

    Private Sub BusinessWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusinessWhatsAppToolStripMenuItem.Click
        Export(3)
    End Sub

    Private Sub RegularWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularWhatsAppToolStripMenuItem.Click
        Export(2)
    End Sub

    Private Sub NonWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonWhatsAppToolStripMenuItem.Click
        Export(4)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Not FrmBrowser.IsWAPILoggedIn Then
            If MsgBox("WhatsApp not Loggged , do you want login ?", vbYesNo + vbQuestion, Application.ProductVersion) = vbYes Then
                FrmBrowser.Show()
            End If
            Exit Sub
        End If
        Try
            Dim li As ListViewItem
            Dim i As Integer = 1
            ForceStop = False
            ProgressBar2.Maximum = ListViewNumbers.Items.Count
            ProgressBar2.Value = 0
            DisableButtons()
            ProgressBarRequest.Maximum = ListViewNumbers.Items.Count
            Dim Progress As Integer = 1

            For Each li In ListViewNumbers.Items
                li.SubItems(3).Text = "Requested"
                FrmBrowser.CheckWhatsAppAccount(li.Tag)
                If ForceStop Then
                    Exit Sub
                End If
                For j = 0 To (NumericUpDownDelay.Value) * 100
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(10)
                Next
                LabelRequestProgress.Text = "Request Progress (" & i & "/" & ListViewNumbers.Items.Count & ")"
                ProgressBarRequest.Value = Progress
                Progress = Progress + 1
                ValidateItem(li)

                i = i + 1
            Next
        Catch ex As Exception

        End Try
        'MsgBox("Filtering done.", vbInformation, Application.ProductName)
        EnableButtons()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub
    Sub getListCount()
        LabelTotal.Text = ListViewNumbers.Items.Count
    End Sub

    Private Sub NumericUpDownDelay_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownDelay.ValueChanged
        SaveSetting(Application.ProductName, "Filter", "delay", NumericUpDownDelay.Value)
    End Sub
    Sub DisableButtons()
        Button1.Enabled = False
        ButtonImportFromFile.Enabled = False
        ButtonManualImport.Enabled = False
        ButtonNumberGenerator.Enabled = False
        ButtonClear.Enabled = False
        ButtonExport.Enabled = False
        ButtonImporttosender.Enabled = False
        ButtonStop.Enabled = True
    End Sub
    Sub EnableButtons()
        Button1.Enabled = True
        ButtonImportFromFile.Enabled = True
        ButtonManualImport.Enabled = True
        ButtonNumberGenerator.Enabled = True
        ButtonClear.Enabled = True
        ButtonExport.Enabled = True
        ButtonImporttosender.Enabled = True
        ButtonStop.Enabled = False
    End Sub

    Private Sub ButtonNumberGenerator_Click(sender As Object, e As EventArgs) Handles ButtonNumberGenerator.Click
        Dim Importer As New ClsNumberGenerator
        Dim _contact As WhatsAppContact
        If Importer.Showdialog = DialogResult.OK Then
            ListViewNumbers.Visible = False
            Dim ContactItem As ListViewItem
            For Each _contact In Importer.Contacts
                ContactItem = New ListViewItem
                ContactItem.Tag = _contact.WhatsAppID
                ContactItem.Text = _contact.WhatsAppName
                ContactItem.SubItems.Add(_contact.WhatsAppContact)
                ContactItem.SubItems.Add("")
                ContactItem.SubItems.Add("")
                ListViewNumbers.Items.Add(ContactItem)
            Next
            ListViewNumbers.Visible = True
            getListCount()
        End If
    End Sub

    Private Sub ButtonClear_Click_1(sender As Object, e As EventArgs) Handles ButtonClear.Click
        If MsgBox("Are you sure you want clear this list?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then
            ListViewNumbers.Items.Clear()
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FrmFilter_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        If MsgBox("Are you sure you want to stop?", vbYesNo + vbQuestion, Application.ProductName) = vbYes Then
            ForceStop = True
            EnableButtons()
        End If
    End Sub

    'Private Sub Button2_Click(sender As Object, e As MouseEventArgs) Handles ButtonImporttosender.MouseUp, Button2.Click
    '    '   ContextMenuStripImport.Show(ButtonImporttosender, e.Location)
    'End Sub

    Sub ImporttoSender(ByVal iType As Integer)
        Dim li As ListViewItem
        Dim li2 As ListViewItem
        Dim WaID As String
        Dim WaName As String
        Dim WaNumber As String
        For Each li In ListViewNumbers.Items
            If li.SubItems(3).Text = "YES" Then
                WaID = li.Tag
                WaName = li.Text
                WaNumber = li.SubItems(1).Text
                li2 = New ListViewItem
                li2.Tag = WaID
                li2.Text = WaName
                li2.SubItems.Add(WaNumber)
                li2.SubItems.Add("")
                li2.SubItems.Add("")
                li2.SubItems.Add("")
                li2.SubItems.Add("")
                li2.SubItems.Add("")
                Select Case iType
                    Case 0
                        FrmMain.LstNumbers.Items.Add(li2)
                    Case 1
                        If li.SubItems(2).Text <> "BIZ" Then
                            FrmMain.LstNumbers.Items.Add(li2)
                        End If

                    Case 2
                        If li.SubItems(2).Text = "BIZ" Then
                            FrmMain.LstNumbers.Items.Add(li2)
                        End If
                End Select

            End If
        Next
        FrmMain.Statistics()
        '   Me.Close()
    End Sub

    Private Sub ImportAllWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportAllWhatsAppToolStripMenuItem.Click
        ImporttoSender(0)
    End Sub

    Private Sub ImportRegularWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportRegularWhatsAppToolStripMenuItem.Click
        ImporttoSender(1)
    End Sub

    Private Sub ImportBusinessWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportBusinessWhatsAppToolStripMenuItem.Click
        ImporttoSender(2)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If FrmInput.ShowDialog = DialogResult.OK Then
            Dim li As ListViewItem
            For Each li In ListViewNumbers.Items
                li.SubItems(1).Text = FrmInput.CountryCode & li.SubItems(1).Text
                li.Tag = FrmInput.CountryCode & li.Tag
            Next
        End If
    End Sub
    Private Sub ButtonImporttosender_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonImporttosender.MouseDown
        ContextMenuStripImport.Show(sender, e.Location)
    End Sub
End Class