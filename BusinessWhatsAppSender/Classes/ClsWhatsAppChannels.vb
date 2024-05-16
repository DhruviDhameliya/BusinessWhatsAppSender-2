
Imports System
Imports System.Threading
Imports OpenQA
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class ClsWhatsappChannel
    Public BrowserProfile As String
    Public Contacts As List(Of WhatsAppContact)
    Public Messages As List(Of String)
    Public MediaFiles As List(Of ClsAttachment)
    Public Delay As Integer
    Public RestAfter As Integer
    Public RestFor As Integer


    Private MainThread As System.Threading.Thread
    Private ChromeDrv As ChromeDriver
    Public Sub Login()
        MainThread = New System.Threading.Thread(AddressOf DoLogin)
        MainThread.Start()
    End Sub
    Private Sub DoLogin()

        Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = False
        Dim Woptions As New ChromeOptions
        '     Woptions.BinaryLocation = "C:\Users\khillo\Desktop\ungoogled-chromium-85.0.4183.83-2_Win64\chrome.exe"
        Woptions.AddArguments("user-data-dir=" & BrowserProfile)

        Try
            ChromeDrv = New ChromeDriver(DriverService, Woptions)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Please close previous instance of chrome", vbCritical, Application.ProductName)
            Exit Sub
        End Try


        Try
            ChromeDrv.Navigate.GoToUrl("https://web.whatsapp.com/")
        Catch ex As Exception

        End Try

        WaitTocompleteLoading(10)

        Dim _loginTag As String = GetLoginTag()


        Dim _isLoggedIn As Integer = 0

        Do
            Try

                _isLoggedIn = ChromeDrv.FindElements(By.ClassName(_loginTag)).Count

            Catch ex As Exception
                _isLoggedIn = 0
            End Try
            Thread.Sleep(300)
            Application.DoEvents()

        Loop Until _isLoggedIn > 0

        MsgBox("WhatsApp Login and ready to be used , please close your browser now...", vbInformation, Application.ProductName)

    End Sub

    Private Function WaitTocompleteLoading(ByVal TimerOutInSecond As Integer) As Boolean
        Try
            ChromeDrv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimerOutInSecond)
            Dim counter As Long = 0
            Do
                Thread.Sleep(1)
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
End Class
