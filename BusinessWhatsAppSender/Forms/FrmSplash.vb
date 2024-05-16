Imports System.Reflection
Public Class FrmSplash
    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelStatus.Text = "Loading API..."
        LabelVersion.Text = "v: " & Appv
        LabelBuildDate.Text = "Build:" & Builddate


    End Sub

    Private Sub FrmSplash_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DropShadow.ApplyShadows(Me)

        Dim fecha As Date = IO.File.GetCreationTime(Assembly.GetExecutingAssembly().Location)
        Application.DoEvents()
        Try
            InitAPI()
            Do
                System.Threading.Thread.Sleep(100)
            Loop Until allloaded()
        Catch ex As Exception
            MsgBox(ex.Message)
            StaticInitAPI()
        End Try
        System.Threading.Thread.Sleep(1000)
        LoginTag = GetLoginTag()

        WAPIScript = GetWapi()
        If WAPIScript = "" Then
            MsgBox("Unable to load latest API...", vbCritical, ApplicationTitle)
            End
        End If
        ClearMessageKey()
    End Sub
    Public Sub ClearMessageKey()
        Dim sw As New IO.StreamWriter(ClsSpecialDirectories.Getdata & "messageskeys.key", False)
        sw.Write("")
        sw.Close()
        sw.Dispose()
    End Sub
End Class