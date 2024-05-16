Public Class FrmReceived
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).Text <> "" Then
                    Dim ReceivedFrm As New FrmReceivedMessage
                    ReceivedFrm.TextBoxReceivedDate.Text = ListView1.SelectedItems(0).Text
                    ReceivedFrm.TextBoxSender.Text = ListView1.SelectedItems(0).SubItems(1).Text
                    ReceivedFrm.TextBoxReceivedMessage.Text = ListView1.SelectedItems(0).SubItems(2).Text
                    ReceivedFrm.WhatsAppID = ListView1.SelectedItems(0).Tag
                    ReceivedFrm.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, Application.ProductName)
        End Try
    End Sub

    Private Sub FrmReceived_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = 1
        Me.Hide()
    End Sub
End Class