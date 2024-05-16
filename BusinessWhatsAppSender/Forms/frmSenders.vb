Imports System.ComponentModel
Imports CefSharp
Imports CefSharp.WinForms
Public Class frmSenders
    Public WithEvents CefBrowser As ChromiumWebBrowser
    Public CefBrowserSettings As New CefSettings
    Public loginResult As String
    Public IsWhatsAppLogginIn As Boolean
    Public IsWAPILoggedIn As Boolean
    Public Profile As String
    Public Structure WAPI
        Public Shared IsWAPILoggedIn As Boolean
        Public Shared IsWAPIConnected As Boolean
    End Structure
    Private Sub FrmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            InitializeCef(Profile)

            CefBrowser = New ChromiumWebBrowser("")

            Me.Controls.Add(CefBrowser)
            CefBrowser.Dock = DockStyle.Fill
            CefBrowser.Load("http://web.whatsapp.com")
        Catch ex As Exception
            If ex.Message.Contains("CefSharp") Then
                If MsgBox("Application need Visual C++ Redistributable for Visual Studio 2015 to work proprely, do you want download it?") = vbYes Then
                    Process.Start("https://www.microsoft.com/en-in/download/details.aspx?id=48145")
                End If
            End If
        End Try

    End Sub
    Public Sub InitializeCef(ByVal Profile As String)
        MsgBox(Profile)

        Try
            CefBrowserSettings = New CefSettings
            CefBrowserSettings.RemoteDebuggingPort = 8080
            CefBrowserSettings.UserDataPath = Profile
            CefBrowserSettings.CachePath = Profile
            CefBrowserSettings.CefCommandLineArgs.Add("user-data-dir", Profile)
            CefSharp.Cef.Initialize(CefBrowserSettings)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FrmBrowser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        CefBrowser.Dispose()
        Me.Dispose()
    End Sub

    Private Sub FrmBrowser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Public Sub SendMessageToID(ByVal WhatsAppAccount As String, ByVal Message As String)
        Try
            Message = SafeJavaScript(Message)

            CefBrowser.ExecuteScriptAsync("WAPI.sendMessageToID('" & WhatsAppAccount & "','" & Message & "')")

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
            CefBrowser.ExecuteScriptAsync("WAPI.sendImage('" & Base64File & "','" & WhatsAppAccount & "','" & _filename & "','" & Caption & "')")

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
End Class
