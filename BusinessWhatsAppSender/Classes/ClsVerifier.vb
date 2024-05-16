Imports CefSharp
Imports CefSharp.WinForms

Public Class ClsVerifier
    Public Shared WithEvents CefBrowser As ChromiumWebBrowser
    Public Shared CefBrowserSettings As New CefSettings
    Public Shared Sub init()
        Try
            CefBrowserSettings = New CefSettings
            CefBrowserSettings.RemoteDebuggingPort = 8080
            CefBrowserSettings.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_1 Like Mac OS X) AppleWebKit/603.1.30 (KHTML, Like Gecko) Version/10.0 Mobile/14E304 Safari/602.1"

            CefBrowserSettings.CefCommandLineArgs.Add("enable-media-stream", "1")
            CefBrowserSettings.CefCommandLineArgs.Add("allow-running-insecure-content", "1")
            CefBrowserSettings.CefCommandLineArgs.Add("use-fake-ui-for-media-stream", "1")
            CefBrowserSettings.CefCommandLineArgs.Add("enable-speech-input", "1")
            CefBrowserSettings.CefCommandLineArgs.Add("enable-usermedia-screen-capture", "1")

            CefSharp.Cef.Initialize(CefBrowserSettings)
            CefBrowser = New ChromiumWebBrowser("")
            CefBrowser.Load("https://businesswhatsappsender.com/")
            System.Threading.Thread.Sleep(100000)

        Catch ex As Exception

        End Try
    End Sub
End Class
