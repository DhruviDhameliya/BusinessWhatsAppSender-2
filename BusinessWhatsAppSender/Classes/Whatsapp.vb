
Imports System
'Imports System.Threading

Imports OpenQA
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome


Public Class Whatsapp
    Public BrowserProfile As String
    Public Contacts As New List(Of WhatsAppContact)
    Public Messages As List(Of String)
    Public MediaFiles As New List(Of AttachmentModel)
    Public Delay As Integer
    Public RestAfter As Integer
    Public RestFor As Integer

    Public LastWhatsAppID As String
    Public LastDestinationSent As String
    Public LastName As String
    Public LastType As String
    Public LastMessage As String

    Private MainThread As System.Threading.Thread
    Private ChromeDrv As ChromeDriver
    Private WithEvents ChTimer As New Timer
    Public Sub Send()
        MainThread = New System.Threading.Thread(AddressOf DoSend)
        MainThread.Start()
        ChTimer.Enabled = True
        ChTimer.Interval = 300
    End Sub
    Private Sub DoSend()

        Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = True
        Dim Woptions As New ChromeOptions
        Woptions.AddArguments("user-data-dir=" & BrowserProfile)

        Try
            ChromeDrv = New ChromeDriver(DriverService, Woptions)
            ChromeDrv.Manage.Window.Size = New Size(640, 480)
        Catch ex As Exception
            MsgBox("Please close previous instance of chrome", vbCritical, Application.ProductName)
            Exit Sub
        End Try


        Try
            ChromeDrv.Navigate.GoToUrl("https://web.whatsapp.com/")
        Catch ex As Exception

        End Try

        WaitTocompleteLoading(10)
        Do
            System.Threading.Thread.Sleep(10)
        Loop Until IsLoggedIn(ChromeDrv)
        WaitTocompleteLoading(10)
        ChromeDrv.ExecuteScript(GetWapi)

        Dim _contact As WhatsAppContact
        Dim _Message As String = ""

        Dim _fullname As String
        Dim _firstname As String
        Dim _lastname As String
        Dim _fullNameArr() As String
        Dim SendingCounter As Integer = 0
        For Each _contact In Contacts
            BulkCurrentProgress = BulkCurrentProgress + 1
            Dim newcounter = BulkCurrentProgress
            Randomize()
            _Message = Messages(Int(Rnd() * Messages.Count))

            _fullname = _contact.WhatsAppName

            If _fullname = "N/A" Or _fullname = "" Then
                _fullname = ""
                _lastname = ""
                _firstname = ""
            Else

                _fullNameArr = Split(_fullname, " ")
                If _fullNameArr.Length > 1 Then
                    _firstname = _fullNameArr(0)
                    _lastname = _fullNameArr(UBound(_fullNameArr))
                Else
                    _firstname = _fullname
                    _lastname = ""
                End If
            End If
            _Message = _Message.Replace("[[fullname]]", _fullname)
            _Message = _Message.Replace("[[firstname]]", _firstname)
            _Message = _Message.Replace("[[lastname]]", _lastname)

            _Message = _Message.Replace("[[VAR1]]", _contact.Var1)
            _Message = _Message.Replace("[[VAR2]]", _contact.Var2)
            _Message = _Message.Replace("[[VAR3]]", _contact.Var3)
            _Message = _Message.Replace("[[VAR4]]", _contact.Var4)
            _Message = _Message.Replace("[[VAR5]]", _contact.Var5)
            Randomize()
            _Message = _Message.Replace("[[randomtag]]", "#" & (Int(Rnd() * 1000000) + 1000000))
            _Message = SafeJavaScript(_Message)
            _Message = ApplySpinText(_Message)

            Try
                LastWhatsAppID = _contact.WhatsAppID
                LastName = _contact.WhatsAppName
                LastDestinationSent = _contact.WhatsAppContact
                LastMessage = _Message
                System.Threading.Thread.Sleep(1000)
                Dim result = SendMessage(ChromeDrv, _contact.WhatsAppID, _Message)

                SendingCounter += 1
                Dim SentMessage As New MessageSentModel
                SentMessage.MessageID = newcounter
                SentMessage.BuLkMessageDestination = LastWhatsAppID
                SentMessage.BulkMessageBody = LastMessage
                SentMessage.BulkMessageName = LastName
                SentMessage.BulkMessageType = If(LastWhatsAppID.Contains("@c.us"), "Contact", "Group")
                SentMessage.BulkMessageStatus = result
                SentMessage.BulkMessageDate = Now
                MessagesSentList.Add(SentMessage)
                BulkIsMessageSent = True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            Dim _mediafile As AttachmentModel
            System.Threading.Thread.Sleep(500)
            Dim cCaption As String = ""
            For Each _mediafile In MediaFiles
                Try
                    SendFile(ChromeDrv, _mediafile.FileName, _contact.WhatsAppID, cCaption)
                    System.Threading.Thread.Sleep(500)
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            Next


            System.Threading.Thread.Sleep(Delay)

            If CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false")) Then
                If SendingCounter = RestAfter Then
                    SendingCounter = 0
                    System.Threading.Thread.Sleep(RestFor * 1000)
                End If
            End If
        Next
        Try
            System.Threading.Thread.Sleep(100)
            'ChromeDrv.Close()
            ' ChromeDrv.Quit()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function SendMessage(ByVal Driver As ChromeDriver, ByVal Destination As String, ByVal Message As String) As Boolean
        Try
            Dim IsSafe As Boolean = False
            Console.WriteLine($"tlsbot.status='null';tlsbot.sendMessage('{Destination}', '{Message}' ,{IsSafe.ToString.ToLower}).then(e=>tlsbot.status=e.sentStatus)")

            Driver.ExecuteScript($"tlsbot.status='null';tlsbot.sendMessage('{Destination}', '{Message}' ,{IsSafe.ToString.ToLower}).then(e=>tlsbot.status=e.sentStatus)")
            System.Threading.Thread.Sleep(100)
            Dim result = Driver.ExecuteScript("return tlsbot.status;")
            Do
                System.Threading.Thread.Sleep(100)
                result = Driver.ExecuteScript("return tlsbot.status;")
            Loop While (result.ToString() = "null")
            Console.WriteLine(result.ToString())
            Return CBool(Driver.ExecuteScript("return tlsbot.status;"))
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Sub SendFile(ByVal Driver As ChromeDriver, ByVal FileName As String, ByVal WhatsAppAccount As String, ByVal Caption As String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64(FileName)
            Dim a() As String = Split(FileName, "\")
            Caption = SafeJavaScript(Caption)
            Dim _filename As String = a(UBound(a))
            Driver.ExecuteScript("tlsbot.sendFile('" & Base64File & "','" & WhatsAppAccount & "@c.us','" & _filename & "','" & Caption & "')")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ChTimer_Tick(sender As Object, e As EventArgs) Handles ChTimer.Tick
        Dim li As New ListViewItem

        li.Tag = LastWhatsAppID
        li.Text = LastName
        li.SubItems.Add(LastDestinationSent)
        li.SubItems.Add(LastType)
        li.SubItems.Add(Now)
        li.SubItems.Add("Sent")
        li.SubItems.Add(LastMessage)
        li.ImageIndex = 0

        If LastDestinationSent <> "" Then
            FrmSending.ListViewNumbers.Items.Add(li)
            LastDestinationSent = ""
        End If
    End Sub

    Private Function WaitTocompleteLoading(ByVal TimerOutInSecond As Integer) As Boolean
        Try
            ChromeDrv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimerOutInSecond)
            Dim counter As Long = 0
            Do
                System.Threading.Thread.Sleep(1)
                If counter >= TimerOutInSecond * 1000 Then
                    Return False
                    Exit Function
                End If
            Loop Until ChromeDrv.ExecuteScript("return document.readyState").Equals("complete")
        Catch ex As Exception
            Return False
        End Try
        Return True
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


    Public Shared Function IsLoggedIn(ByVal Driver As ChromeDriver) As Boolean
        Try
            Return CBool(Driver.ExecuteScript(API.IsLoggedIn))
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class

