Public Class FrmAddFamiliarAccount
    Public AccountNumber As String
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtAccount.Text = "" Then
            MsgBox("You have to add accounts", vbCritical, ApplicationTitle)
            Exit Sub
        End If
        If Not IsNumeric(TxtAccount.Text) Then
            MsgBox("Account must be numeric", vbCritical, ApplicationTitle)
            TxtAccount.SelectAll()
            TxtAccount.Focus()
            Exit Sub
        End If
        AccountNumber = TxtAccount.Text
            Me.Close()
    End Sub

    Private Sub FrmAddFamiliarAccount_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub FrmAddFamiliarAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountNumber = ""
        TxtAccount.Text = ""
    End Sub
End Class