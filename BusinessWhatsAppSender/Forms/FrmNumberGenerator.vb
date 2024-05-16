Public Class FrmNumberGenerator
    Public ImportResults As New List(Of WhatsAppContact)
    Public SourceForm As Integer

    Public CurrentImportContext As ClsNumberGenerator
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If TxtNumberStart.Text = "" Then
            Exit Sub
        End If

        CurrentImportContext.DialogResult = DialogResult.OK
        Dim i As Integer
        Dim wacontact As WhatsAppContact
        Dim number As Long = Val(TxtNumberStart.Text)
        For i = 0 To Val(TxtCount.Text)
            wacontact = New WhatsAppContact
            wacontact.WhatsAppID = number & "@c.us"
            wacontact.WhatsAppContact = number
            wacontact.WhatsAppName = "N/A"
            ImportResults.Add(wacontact)
            number = number + Val(TxtIncrement.Text)
        Next
        CurrentImportContext.Contacts = ImportResults
        Me.Close()

    End Sub

    Private Sub FrmNumberGenerator_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub



    Private Sub TxtNumberStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumberStart.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class