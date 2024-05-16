Public Class FrmReceivedMessage
    Public WhatsAppID As String
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        FrmBrowser.SendMessageWithoutDriver(WhatsAppID, TextBoxReplyToSender.Text)
        Me.Close()
    End Sub

    Private Sub FrmReceivedMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class