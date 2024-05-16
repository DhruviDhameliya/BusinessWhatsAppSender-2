Public Class FrmAddMessage

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If TxtMessage.Text = "" Then
            Exit Sub
        End If
        FrmAdvanced.LstMessages.Items.Add(TxtMessage.Text)
        Me.Close()
    End Sub

    Private Sub FrmAddMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtMessage.Text = ""
    End Sub
End Class