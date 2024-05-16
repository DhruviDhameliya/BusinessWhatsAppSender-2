Imports System.ComponentModel
Imports CefSharp
Imports CefSharp.WinForms
Imports System.Threading
Imports OpenQA.Selenium.Chrome
Imports Microsoft.VisualStudio.OLE.Interop
Imports System.Security.Cryptography
Imports Newtonsoft.Json

Public Class FrmBrowser
    Public WithEvents CefBrowser As ChromiumWebBrowser
    Public CefBrowserSettings As New CefSettings
    Public loginResult As String
    Public IsWhatsAppLogginIn As Boolean
    Public IsWAPILoggedIn As Boolean
    Public Structure WAPI
        Public Shared IsWAPILoggedIn As Boolean
        Public Shared IsWAPIConnected As Boolean
    End Structure
    Private SendingThread As Thread
    Private _Destinations As List(Of DestinationModel)
    Private _Messages As List(Of String)
    Private _Attachments As List(Of AttachmentModel)
    Private _SafeMode As Boolean
    Public Sub StartBulk(ByVal Destinations As List(Of DestinationModel),
                         ByVal Messages As List(Of String),
                         ByVal Attachments As List(Of AttachmentModel),
                         ByVal SafeMode As Boolean)

        _Destinations = Destinations
        _Messages = Messages
        _Attachments = Attachments
        _SafeMode = SafeMode

        SendingThread = New Thread(AddressOf DoSendBulk)
        SendingThread.Start()
    End Sub
    Private Sub DoSendBulk()
        BulkIsStarted = True
        BulkIsSending = True
        BulkMAXProgress = _Destinations.Count

        Dim MessageToSend As String = ""
        Dim SendingCounter As Integer = 1
        BulkCurrentProgress = 0
        MessagesSentList.Clear()
        For Each Destination As DestinationModel In _Destinations
            BulkCurrentProgress = BulkCurrentProgress + 1
            '    If MsgBox("OOPS!!! something wrong , whatsapp logged out or blocked check what is the matter and press retry to continue your bulk," & vbNewLine & "Do you want open the browser to check what is going on ? ", vbCritical + vbYesNo, ApplicationTitle) = vbYes Then
            BulkIsLoggedIn = True
            While Not IsWAPILoggedIn
                BulkIsLoggedIn = False
                Thread.Sleep(10)
            End While
            '' Select Message to send 
            Randomize()
            If _Messages.Count > 0 Then
                MessageToSend = _Messages(Int(Rnd() * _Messages.Count))
            Else
                MessageToSend = ""
            End If
            Dim SendingResult As Boolean = False

            MessageToSend = ApplyVariables(MessageToSend, Destination.Fullname,
                                           Destination.FirstName, Destination.LastName,
                                           Destination.Var1, Destination.Var2, Destination.Var3,
                                           Destination.Var4, Destination.Var5)
            If MessageToSend IsNot "" Then
                SendingResult = SendMessage(CefBrowser, Destination.WhatsAppID, MessageToSend, _SafeMode)
            Else
                SendingResult = NumberExist(CefBrowser, Destination.WhatsAppID)
            End If
            Dim SentMessage As New MessageSentModel
            SentMessage.MessageID = SendingCounter
            SentMessage.BuLkMessageDestination = Destination.Number
            SentMessage.BulkMessageBody = MessageToSend
            SentMessage.BulkMessageName = Destination.Fullname
            SentMessage.BulkMessageType = If(Destination.WhatsAppID.Contains("@c.us"), "Contact", "Group")
            SentMessage.BulkMessageStatus = SendingResult
            SentMessage.BulkMessageDate = Now
            MessagesSentList.Add(SentMessage)
            BulkIsMessageSent = True
            If SendingResult Then
                If Not IsNothing(_Attachments) Then
                    For Each Attachment As AttachmentModel In _Attachments
                        Dim AttachmentCaption As String = Attachment.Caption
                        AttachmentCaption = ApplyVariables(AttachmentCaption, Destination.Fullname,
                                           Destination.FirstName, Destination.LastName,
                                           Destination.Var1, Destination.Var2, Destination.Var3,
                                           Destination.Var4, Destination.Var5)
                        SendFile(Attachment.FileName, Destination.WhatsAppID, AttachmentCaption)
                        Thread.Sleep(500) ' Delay between messages 
                    Next
                End If
            End If
            '' Pause Bulk 
            Do
                Thread.Sleep(10)
            Loop While BulkIsPaused

            Thread.Sleep(GetDelay)

            '' Resting 
            If CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false")) Then
                If SendingCounter Mod Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20)) = 0 Then
                    BulkIsResting = True
                    Thread.Sleep(Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5)) * 1000)
                    BulkIsResting = False
                End If
            End If


            '' Falimiar Sending 
            If CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateDialog", "false")) Then
                If SendingCounter Mod (Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogAfter", 5)) + 1) = 0 Then

                    Dim FamiliarLimits As Integer = 0
                    Dim FamiliarDestination As String() = IO.File.ReadAllLines(ClsSpecialDirectories.Getdata & "commonList.data")
                    If FamiliarDestination.Count > Val(GetSetting(ApplicationTitle, "SendingConfig", "DialoCount", 15)) Then
                        FamiliarLimits = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialoCount", 15))
                    Else
                        FamiliarLimits = FamiliarDestination.Count
                    End If

                    Dim FamiliarMessages() As String = IO.File.ReadAllLines(ClsSpecialDirectories.Getdata & "commonMessage.data")

                    For i = 0 To FamiliarLimits - 1
                        Randomize()
                        SendMessage(CefBrowser, FamiliarDestination(i) & "@c.us", FamiliarMessages(Int(Rnd() * FamiliarMessages.Count)), False)
                        Thread.Sleep(Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogWait", 1)) * 1000)
                    Next
                End If
            End If

            SendingCounter += 1
            '' Delay 
        Next
        SendingCounter = 0
        BulkIsDone = True
        BulkIsSending = False
        BulkIsStarted = False
        SendingThread.Abort()
    End Sub

    Public Function ApplyVariables(ByVal VariableText As String, Optional fullName As String = "", Optional FirstName As String = "",
            Optional LastName As String = "", Optional Var1 As String = "", Optional Var2 As String = "", Optional Var3 As String = "",
                                  Optional Var4 As String = "", Optional Var5 As String = "") As String

        VariableText = VariableText.Replace("[[fullname]]", fullName)
        VariableText = VariableText.Replace("[[firstname]]", FirstName)
        VariableText = VariableText.Replace("[[lastname]]", LastName)

        VariableText = VariableText.Replace("[[VAR1]]", Var1)
        VariableText = VariableText.Replace("[[VAR2]]", Var2)
        VariableText = VariableText.Replace("[[VAR3]]", Var3)
        VariableText = VariableText.Replace("[[VAR4]]", Var4)
        VariableText = VariableText.Replace("[[VAR5]]", Var5)
        VariableText = VariableText.Replace("[[randomtag]]", "#" & (Int(Rnd() * 1000000) + 1000000))

        VariableText = ApplySpinText(VariableText)

        Return VariableText
    End Function

    Private Function ApplySpinText(ByVal Text As String) As String
        Dim _text As String = Text
        Dim dicEntry As DictionaryEntry
        Dim SpinTextDictionary As New List(Of DictionaryEntry)
        _text = _text.Replace("{{", "||{{") : _text = _text.Replace("}}", "}}||")
        Dim SpintextArr() As String = Split(_text, "||")
        For Each Spintext As String In SpintextArr
            If Spintext.Trim.StartsWith("{{") And Spintext.Trim.EndsWith("}}") Then
                Dim cSpin As String = Spintext
                cSpin = cSpin.Replace("{{", "") : cSpin = cSpin.Replace("}}", "")
                Dim rWords() As String = cSpin.Split("|")
                If rWords.Count > 0 Then
                    Randomize()
                    Dim selector As Integer = 0
                    For i As Integer = 0 To 30 : selector = Int(Rnd() * rWords.Count)
                    Next
                    dicEntry = New DictionaryEntry(Spintext, rWords(selector)) : SpinTextDictionary.Add(dicEntry)
                End If
            End If
        Next
        Dim Result As String = Text
        For Each dicEntry In SpinTextDictionary
            Result = Result.Replace(dicEntry.Key, dicEntry.Value)
        Next
        Return Result
    End Function

    Private Function GetDelay() As Integer
        Dim Num1 As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayStart", "0"))
        Dim Num2 As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayEnd", "2"))

        Randomize()
        Dim a As Integer = 10
        If Num2 > 0 Then
            a = (Num1 + (Int(Rnd() * Num2))) * 1000
        Else
            a = 100
        End If
        If a = 0 Then
            a = 100
        End If
        Return a
    End Function
    Public Sub StopBulk()
        Try
            SendingThread.Abort()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If Profile <> "" Then
                InitializeCef(GetProfiles() & Profile)
            Else
                InitializeCef(GetProfiles() & Application.ProductName)
            End If
            CefBrowser = New ChromiumWebBrowser("")


            Me.Controls.Add(CefBrowser)
            CefBrowser.Dock = DockStyle.Fill

            CefBrowser.Load("https://web.whatsapp.com/")
            System.Threading.Thread.Sleep(1000)
            CefBrowser.Reload()
            CefBrowser.Load("https://web.whatsapp.com/")
        Catch ex As Exception
            If ex.Message.Contains("CefSharp") Then
                If MsgBox("Application need Visual C++ Redistributable for Visual Studio 2015 to work proprely, do you want download it?", vbCritical + vbYesNo, Application.ProductName) = vbYes Then
                    Process.Start("https://www.microsoft.com/en-in/download/details.aspx?id=48145")
                End If
            End If
        End Try

    End Sub
    Public Sub ClearCef()
        CefBrowser.EvaluateScriptAsync("clear()")
    End Sub
    Public Sub InitializeCef(Optional Profile As String = "")
        If Profile <> "" Then
            Try
                CefBrowserSettings = New CefSettings
                CefBrowserSettings.RemoteDebuggingPort = 8088
                CefBrowserSettings.UserDataPath = Profile
                CefBrowserSettings.CachePath = Profile


                'CefBrowserSettings.CefCommandLineArgs.Add("user-data-dir", Profile)
                CefSharp.Cef.Initialize(CefBrowserSettings)
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub FrmBrowser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        CefBrowser.Dispose()
        Me.Dispose()
    End Sub
    Private Sub FrmBrowser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub TimerEvent_TickAsync(sender As Object, e As EventArgs) Handles TimerEvent.Tick
        If IsWAPILoggedIn Then
            FrmMain.LabelLoginStatus.BackColor = Color.Green
            FrmMain.LabelLoginStatus.Text = "Ready"
        Else
            FrmMain.LabelLoginStatus.BackColor = Color.Red
            FrmMain.LabelLoginStatus.Text = "Not Ready"
        End If
    End Sub
    Private Sub TimerInitiateWAPI_Tick(sender As Object, e As EventArgs) Handles TimerInitiateWAPI.Tick
        If IsWhatsAppLogginIn Then
            TimerInitiateWAPI.Enabled = False
            For i = 1 To 300
                Application.DoEvents()
                System.Threading.Thread.Sleep(10)
            Next
            Try
                CefBrowser.ExecuteScriptAsync(WAPIScript)
                CefBrowser.JavascriptObjectRepository.Register("boundAsync", New CefSharpJavascriptObj(), True)
                TimerReceive.Enabled = True
            Catch ex As Exception
                MsgBox("Unable To Login...")
            End Try

        End If
    End Sub
    Private Async Sub Timer1_TickAsync(sender As Object, e As EventArgs) Handles TimerIsWhatsAppLoggedIn.Tick
        Try
            CefBrowser.ExecuteScriptAsync(API.IsLoggedInAll)
            Dim a = Await CefBrowser.EvaluateScriptAsync("window.IsLoggedInAll()")
            If CBool(a.Result) Then
                IsWhatsAppLogginIn = True
            Else
                IsWhatsAppLogginIn = False
            End If
        Catch ex As Exception
            IsWhatsAppLogginIn = False
        End Try
        If IsWhatsAppLogginIn Then
            If Not IsWAPILoggedIn Then
                Try
                    CefBrowser.ExecuteScriptAsync(WAPIScript)
                Catch ex As Exception
                    MsgBox("Unable To Execute API...")
                End Try
            End If
        End If

        Try
            Dim b = Await CefBrowser.EvaluateScriptAsync("tlsbot.isLogginDone();")
            IsWAPILoggedIn = CBool(b.Result)
        Catch ex As Exception
        End Try



    End Sub
    Public Function GetAllContact() As DataTable
        Try
            CefBrowser.ExecuteScriptAsync("tlsbot.contactList='null';tlsbot.getAllContacts().then(e=>tlsbot.contactList=e)")
            Dim GroupContactResult = CefBrowser.EvaluateScriptAsync("tlsbot.contactList")
            Do
                Thread.Sleep(200)
                GroupContactResult = CefBrowser.EvaluateScriptAsync("tlsbot.contactList")
            Loop While GroupContactResult.Result.Result.ToString() = "null"
            Dim Contact As Object
            Dim Resultdt As New DataTable
            Resultdt.TableName = "Contacts"
            Resultdt.Columns.Add("ID")
            Resultdt.Columns.Add("Name")
            Resultdt.Columns.Add("Number")
            Dim ContactDr As DataRow
            Dim groupdata = JsonConvert.SerializeObject(GroupContactResult.Result.Result)
            For Each Contact In JsonConvert.DeserializeObject(groupdata)
                Application.DoEvents()
                ContactDr = Resultdt.NewRow
                ContactDr("ID") = Contact("id")
                ContactDr("Name") = Contact("name")
                ContactDr("Number") = Contact("number")
                Resultdt.Rows.Add(ContactDr)
            Next
            Return Resultdt
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New DataTable
        End Try
    End Function
    Public Function GetAllGroups() As DataTable
        Try
            CefBrowser.ExecuteScriptAsync("tlsbot.groupList='null';tlsbot.getAllGroups().then(e=>tlsbot.groupList=e)")
            Dim GroupContactResult = CefBrowser.EvaluateScriptAsync("tlsbot.groupList")
            Do
                Thread.Sleep(200)
                GroupContactResult = CefBrowser.EvaluateScriptAsync("tlsbot.groupList")
            Loop While GroupContactResult.Result.Result.ToString() = "null"
            Dim Contact As Object
            Dim Resultdt As New DataTable
            Resultdt.TableName = "Contacts"
            Resultdt.Columns.Add("ID")
            Resultdt.Columns.Add("Name")
            Resultdt.Columns.Add("Number")
            Dim ContactDr As DataRow
            Dim groupdata = JsonConvert.SerializeObject(GroupContactResult.Result.Result)
            For Each Contact In JsonConvert.DeserializeObject(groupdata)
                Application.DoEvents()
                ContactDr = Resultdt.NewRow
                ContactDr("ID") = Contact("id")
                ContactDr("Name") = Contact("name")
                ContactDr("Number") = Contact("number")
                Resultdt.Rows.Add(ContactDr)
            Next
            Return Resultdt
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New DataTable
        End Try
    End Function

    Public Shared Function SendMessage(ByVal Driver As ChromiumWebBrowser, ByVal Destination As String, ByVal Message As String, IsSafe As Boolean) As Boolean
        Try
            Driver.ExecuteScriptAsync($"tlsbot.status='null';tlsbot.sendMessage('{Destination}', '{SafeJavaScript(Message)}' ,{IsSafe.ToString.ToLower}).then(e=>tlsbot.status=e.sentStatus)")
            System.Threading.Thread.Sleep(200)
            Dim result = Driver.EvaluateScriptAsync("tlsbot.status;")
            Do
                System.Threading.Thread.Sleep(200)
                result = Driver.EvaluateScriptAsync("tlsbot.status;")
                Console.WriteLine(result.Result.Result.ToString())
            Loop While (result.Result.Result.ToString() = "null")
            Return CBool(result.Result.Result.ToString())
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function NumberExist(ByVal Driver As ChromiumWebBrowser, num As String) As Boolean
        Try
            Driver.ExecuteScriptAsync("window.fnum='null';tlsbot.checkNumberStatus('" & num & "').then((e)=>{if(e.status==200){window.fnum=true;}else {window.fnum=false;}});")
            System.Threading.Thread.Sleep(100)
            Dim result = Driver.EvaluateScriptAsync("window.fnum;")
            Do
                System.Threading.Thread.Sleep(100)
                result = Driver.EvaluateScriptAsync("window.fnum;")
            Loop While (result.Result.Result.ToString() = "null")

            Return CBool(result.Result.Result.ToString())
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub CheckWhatsAppAccount(ByVal WhatsAppAccount As String)
        Try
            CefBrowser.ExecuteScriptAsync("window.find=0;WAPI.checkNumberStatus('" & WhatsAppAccount & "').then(async (result)=>{result.num='" & WhatsAppAccount & "'; window.find=result;await CefSharp.BindObjectAsync('boundAsync','bound');boundAsync.checkNumberStatus(result);});")
            System.Threading.Thread.Sleep(100)
        Catch ex As Exception

        End Try
    End Sub


    Public Async Function getGroupParticipantIDs(ByVal id As String) As Task(Of String)
        Try
            CefBrowser.ExecuteScriptAsync($"tlsbot.groupContactList='null';tlsbot.getGroupParticipantList('" & id & "').then(e=>tlsbot.groupContactList=e)")
            System.Threading.Thread.Sleep(200)
            Dim result = CefBrowser.EvaluateScriptAsync("tlsbot.groupContactList;")
            Do
                System.Threading.Thread.Sleep(200)
                result = CefBrowser.EvaluateScriptAsync("tlsbot.groupContactList;")
            Loop While (result.Result.Result.ToString() = "null")

            Return result.Result.Result.ToString()

        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Sub SendMessageWithoutDriver(ByVal WhatsAppAccount As String, ByVal Message As String)
        Try
            SendMessage(CefBrowser, WhatsAppAccount, Message, False)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SendFile(ByVal FileName As String, ByVal WhatsAppAccount As String, ByVal Caption As String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64(FileName)
            Dim a() As String = Split(FileName, "\")

            Caption = SafeJavaScript(Caption)

            Dim _filename As String = a(UBound(a))
            Try
                CefBrowser.ExecuteScriptAsync("tlsbot.sendFile('" & Base64File & "','" & WhatsAppAccount & "','" & _filename & "','" & Caption & "');")
            Catch ex As Exception
                Console.WriteLine("Catch SendFile")
            End Try
            Thread.Sleep(1000)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SendStickers(ByVal FileName As String, ByVal WhatsAppAccount As String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64NoMime(FileName)
            CefBrowser.ExecuteScriptAsync("WAPI.sendImageAsSticker('" & Base64File & "','" & WhatsAppAccount & "')")
        Catch ex As Exception

        End Try

    End Sub

    Public ReceivingCounter As Integer
    Private Async Sub Receiver(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        Console.WriteLine("Receiver")
        If LicenseMode Then
            If Not AllowAutoReply Then
                Exit Sub
            End If
        End If
        If MessageRetriveProgress Then
            Exit Sub
        End If
        MessageRetriveProgress = True
        If Not CBool(GetSetting(ApplicationTitle, "SendingConfig", "UnreadMessage", "false")) Then
            FrmMain.ButtonSwitch.Dock = DockStyle.Left
            Exit Sub
        Else
            FrmMain.ButtonSwitch.Dock = DockStyle.Right
        End If
        If FrmMain.ButtonSwitch.Dock = DockStyle.Left Then
            Exit Sub
        End If

        Dim WhatsAppAccount As String = ""
        Dim Body As String = ""

        Try
            Dim li As ListViewItem
            Dim li2 As ListViewItem
            Dim a = Await GetAllUnreadChats()
            Dim t As Object
            If a.Count > 0 Then
                For Each t In a
                    Application.DoEvents()
                    If Not IsReceivedKeyExsist(t("_serialized")) Then
                        Try
                            If FrmMain.ButtonSwitch.Dock = DockStyle.Right Then
                                AddMessageKey(t("_serialized"))
                                Dim b = Await GetUnreadChatById(t("_serialized"))
                                If b("server") = "c.us" Then
                                    If b("type") = "in" Then
                                        allReceivedMessage = allReceivedMessage & Newtonsoft.Json.JsonConvert.SerializeObject(b) & vbNewLine & vbNewLine
                                        li = New ListViewItem
                                        li2 = New ListViewItem

                                        li.Tag = b("_serialized").ToString
                                        li.Text = Now
                                        li.SubItems.Add(b("user").ToString)

                                        If Not IsNothing(b("body")) Then
                                            li.SubItems.Add(b("body").ToString)
                                            li2.SubItems.Add(b("body").ToString)
                                        End If
                                        li2.Tag = b("_serialized").ToString
                                        li2.Text = Now
                                        li2.SubItems.Add(b("user").ToString)

                                        li2.SubItems.Add("In")

                                        FrmMain.ListReceivedMessages.Items.Add(li)
                                        FrmReceived.ListView1.Items.Add(li2)
                                        If Not IsNothing(b("body")) Then
                                            Body = b("body").ToString
                                        End If
                                        WhatsAppAccount = b("_serialized").ToString
                                        ' Console.WriteLine(WhatsAppAccount)

                                        ''''''''''''''''''''''''''''''
                                        '''''Load AutoReply 
                                        ''''''''''''''''''''''''''''''

                                        Dim _autoReplyObject As ClsAutoReplyMessage
                                        If IO.File.Exists(ClsSpecialDirectories.Getdata & "autoreply.json") Then
                                            _autoReplyObject = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ClsAutoReplyMessage)(IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "autoreply.json"))
                                        Else
                                            _autoReplyObject = Nothing
                                        End If

                                        If Not IsNothing(_autoReplyObject) Then

                                            If Not IsAutoReplied(WhatsAppAccount) Then
                                                If WhatsAppAccount.ToLower.Contains("@c.us") Then
                                                    AddAutoReplyAccount(WhatsAppAccount)
                                                    SendMessage(CefBrowser, WhatsAppAccount, _autoReplyObject.Message, False)
                                                    If DemoMode Then
                                                        ReceivingCounter = ReceivingCounter + 1
                                                        If ReceivingCounter = 8 Then
                                                            ReceivingCounter = 0
                                                            ShowDemoMessage()
                                                        End If
                                                    End If
                                                    Application.DoEvents()

                                                    If Not IsNothing(_autoReplyObject.Attachment) Then
                                                        For Each attach As ClsAttachment In _autoReplyObject.Attachment
                                                            Application.DoEvents()
                                                            If attach.MediaType <> "Sticker" Then
                                                                SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                            Else
                                                                SendStickers(attach.File, WhatsAppAccount)
                                                            End If
                                                        Next
                                                    End If
                                                End If
                                            End If


                                        End If


                                        ''''''''''''''''''''''''''''''
                                        '''''Load Rules
                                        ''''''''''''''''''''''''''''''
                                        Dim lst As List(Of ClsRuleModel)
                                        lst = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ClsRuleModel))(IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "rules.json"))
                                        If Not IsNothing(lst) Then
                                            For Each rule As ClsRuleModel In lst
                                                If WhatsAppAccount.ToLower.Contains("@c.us") Then

                                                    If rule.RuleStatus Then

                                                        Select Case rule.Operand
                                                            Case "="

                                                                If rule.RuleKeyword = Body.Trim Then
                                                                    If DemoMode Then
                                                                        ReceivingCounter = ReceivingCounter + 1
                                                                        If ReceivingCounter = 8 Then
                                                                            ReceivingCounter = 0
                                                                            ShowDemoMessage()
                                                                        End If
                                                                    End If
                                                                    SendMessage(CefBrowser, WhatsAppAccount, rule.RuleMessage, False)
                                                                    Application.DoEvents()
                                                                    If Not IsNothing(rule.Attachment) Then
                                                                        For Each attach As ClsAttachment In rule.Attachment
                                                                            Application.DoEvents()
                                                                            If attach.MediaType <> "Sticker" Then
                                                                                SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                            Else
                                                                                SendStickers(attach.File, WhatsAppAccount)
                                                                            End If
                                                                        Next

                                                                    End If
                                                                End If


                                                            Case "Like"

                                                                If rule.RuleKeyword.ToLower = Body.Trim.ToLower Then
                                                                    If DemoMode Then
                                                                        ReceivingCounter = ReceivingCounter + 1
                                                                        If ReceivingCounter = 8 Then
                                                                            ReceivingCounter = 0
                                                                            ShowDemoMessage()
                                                                        End If
                                                                    End If
                                                                    SendMessage(CefBrowser, WhatsAppAccount, rule.RuleMessage, False)
                                                                    Application.DoEvents()
                                                                    If Not IsNothing(rule.Attachment) Then
                                                                        For Each attach As ClsAttachment In rule.Attachment
                                                                            Application.DoEvents()
                                                                            If attach.MediaType <> "Sticker" Then
                                                                                SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                            Else
                                                                                SendStickers(attach.File, WhatsAppAccount)
                                                                            End If
                                                                        Next

                                                                    End If
                                                                End If

                                                            Case "Start with"
                                                                If Body.ToLower.StartsWith(rule.RuleKeyword.ToLower.Trim) Then
                                                                    If DemoMode Then
                                                                        ReceivingCounter = ReceivingCounter + 1
                                                                        If ReceivingCounter = 8 Then
                                                                            ReceivingCounter = 0
                                                                            ShowDemoMessage()
                                                                        End If
                                                                    End If
                                                                    SendMessage(CefBrowser, WhatsAppAccount, rule.RuleMessage, False)
                                                                    Application.DoEvents()
                                                                    If Not IsNothing(rule.Attachment) Then
                                                                        For Each attach As ClsAttachment In rule.Attachment
                                                                            Application.DoEvents()
                                                                            If attach.MediaType <> "Sticker" Then
                                                                                SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                            Else
                                                                                SendStickers(attach.File, WhatsAppAccount)
                                                                            End If
                                                                        Next

                                                                    End If
                                                                End If


                                                            Case "End with"
                                                                If Body.ToLower.EndsWith(rule.RuleKeyword.ToLower.Trim) Then
                                                                    If DemoMode Then
                                                                        ReceivingCounter = ReceivingCounter + 1
                                                                        If ReceivingCounter = 8 Then
                                                                            ReceivingCounter = 0
                                                                            ShowDemoMessage()
                                                                        End If
                                                                    End If
                                                                    SendMessage(CefBrowser, WhatsAppAccount, rule.RuleMessage, False)
                                                                    Application.DoEvents()
                                                                    If Not IsNothing(rule.Attachment) Then
                                                                        For Each attach As ClsAttachment In rule.Attachment
                                                                            Application.DoEvents()
                                                                            If attach.MediaType <> "Sticker" Then
                                                                                SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                            Else
                                                                                SendStickers(attach.File, WhatsAppAccount)
                                                                            End If
                                                                        Next

                                                                    End If
                                                                End If
                                                            Case "Contains"

                                                                If Body.ToLower.Contains(rule.RuleKeyword.ToLower) Then
                                                                    If DemoMode Then
                                                                        ReceivingCounter = ReceivingCounter + 1
                                                                        If ReceivingCounter = 8 Then
                                                                            ReceivingCounter = 0
                                                                            ShowDemoMessage()
                                                                        End If
                                                                    End If
                                                                    SendMessage(CefBrowser, WhatsAppAccount, rule.RuleMessage, False)
                                                                    Application.DoEvents()
                                                                    If Not IsNothing(rule.Attachment) Then
                                                                        For Each attach As ClsAttachment In rule.Attachment
                                                                            Application.DoEvents()
                                                                            If attach.MediaType <> "Sticker" Then
                                                                                SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                            Else
                                                                                SendStickers(attach.File, WhatsAppAccount)
                                                                            End If
                                                                        Next

                                                                    End If
                                                                End If
                                                        End Select
                                                    End If
                                                End If
                                            Next
                                        End If
                                    End If
                                End If
                            End If
                        Catch ex As Exception
                            Console.WriteLine("Catch Called")
                            Console.WriteLine(ex)
                        End Try
                    End If
                Next

            End If

        Catch ex As Exception
            Console.WriteLine("Catch Called outer")
            Console.WriteLine(ex)
        End Try
        MessageRetriveProgress = False
    End Sub
    Public Async Function GetAllUnreadChats() As Task(Of Object)
        Try
            CefBrowser.ExecuteScriptAsync("tlsbot.UnreadChatList='null';tlsbot.getUnreadChat().then(e=>tlsbot.UnreadChatList=e)")
            Dim unreadChatResult = CefBrowser.EvaluateScriptAsync("tlsbot.UnreadChatList")
            Do
                Thread.Sleep(200)
                Application.DoEvents()
                unreadChatResult = CefBrowser.EvaluateScriptAsync("tlsbot.UnreadChatList")
            Loop While unreadChatResult.Result.Result.ToString() = "null"
            Dim unreadChatData = JsonConvert.SerializeObject(unreadChatResult.Result.Result)
            Return JsonConvert.DeserializeObject(unreadChatData)
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New List(Of String)
        End Try
    End Function
    Public Async Function GetUnreadChatById(id) As Task(Of Object)
        Try
            CefBrowser.ExecuteScriptAsync("tlsbot.UnreadChat='null';tlsbot.getUnreadChatbyId('" & id & "').then(e=>tlsbot.UnreadChat=e)")
            Dim unreadChatResult = CefBrowser.EvaluateScriptAsync("tlsbot.UnreadChat")
            Do
                Thread.Sleep(200)
                Application.DoEvents()
                unreadChatResult = CefBrowser.EvaluateScriptAsync("tlsbot.UnreadChat")
            Loop While unreadChatResult.Result.Result.ToString() = "null"
            Dim unreadChatData = JsonConvert.SerializeObject(unreadChatResult.Result.Result)
            Return JsonConvert.DeserializeObject(unreadChatData)
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New List(Of String)
        End Try
    End Function
    Public Sub AddAutoReplyAccount(ByVal Account As String)
        Dim Sw As New IO.StreamWriter(ClsSpecialDirectories.Getdata & "autoreplyusers.key", True)
        Sw.WriteLine(Account)
        Sw.Close()
        Sw.Dispose()
    End Sub
    Public Function IsAutoReplied(ByVal Account As String) As Boolean
        If IO.File.Exists(ClsSpecialDirectories.Getdata & "autoreplyusers.key") Then
            Return IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "autoreplyusers.key").Contains(Account)
        Else
            Return False
        End If
    End Function

    Public Function IsReceivedKeyExsist(ByVal key As String) As Boolean
        If IO.File.Exists(ClsSpecialDirectories.Getdata & "messageskeys.key") Then
            Dim a As String = IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "messageskeys.key")
            Return a.Contains(key)
        Else
            Return False
        End If

    End Function
    Public Sub AddMessageKey(ByVal key As String)
        Console.WriteLine("AddMessageKey")
        Dim sw As New IO.StreamWriter(ClsSpecialDirectories.Getdata & "messageskeys.key", True)
        sw.Write(key & vbNewLine)
        sw.Close()
        sw.Dispose()
    End Sub



End Class
Public Class CefSharpJavascriptObj
    Public Sub checkNumberStatus(ByVal e As Object)
        Console.WriteLine(e)
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(e))
        NumberCheckedList = Newtonsoft.Json.JsonConvert.SerializeObject(e) & "|" & NumberCheckedList
    End Sub
    Public Sub sendMessage(ByVal e As Object)

        SentMessageslist = SentMessageslist & "|" & Newtonsoft.Json.JsonConvert.SerializeObject(e)
    End Sub
    Public Sub getGroupParticipantIDs(ByVal e As Object)
        GroupsParticipant = e
    End Sub

End Class
