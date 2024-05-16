Public Class FrmSetCaption
    Private Sub BtnEmoji_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Public Caption As String
    Public dlgResult As DialogResult
    Private Sub BtnBold_Click(sender As Object, e As EventArgs) Handles BtnBold.Click
        Dim CurrentIndex As Integer = TxtCaption.SelectionStart
        Dim CurrentLenght As Integer = TxtCaption.SelectionLength
        TxtCaption.Text = TxtCaption.Text.Insert(CurrentIndex, "*")
        TxtCaption.Text = TxtCaption.Text.Insert(CurrentIndex + CurrentLenght + 1, "*")
    End Sub
    Private Sub BtnItalic_Click(sender As Object, e As EventArgs) Handles BtnItalic.Click
        Dim CurrentIndex As Integer = TxtCaption.SelectionStart
        Dim CurrentLenght As Integer = TxtCaption.SelectionLength
        TxtCaption.Text = TxtCaption.Text.Insert(CurrentIndex, "_")
        TxtCaption.Text = TxtCaption.Text.Insert(CurrentIndex + CurrentLenght + 1, "_")
    End Sub
    Private Sub BtnStrike_Click(sender As Object, e As EventArgs) Handles BtnStrike.Click
        Dim CurrentIndex As Integer = TxtCaption.SelectionStart
        Dim CurrentLenght As Integer = TxtCaption.SelectionLength
        TxtCaption.Text = TxtCaption.Text.Insert(CurrentIndex, "~")
        TxtCaption.Text = TxtCaption.Text.Insert(CurrentIndex + CurrentLenght + 1, "~")
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Caption = TxtCaption.Text
        dlgResult = DialogResult.OK
        Me.Close()

    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        dlgResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FrmSetCaption_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub LinkName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkName.LinkClicked
        TxtCaption.Text = TxtCaption.Text.Insert(TxtCaption.SelectionStart, "[[fullname]]")

    End Sub

    Private Sub LinkFirstName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkFirstName.LinkClicked
        TxtCaption.Text = TxtCaption.Text.Insert(TxtCaption.SelectionStart, "[[firstname]]")

    End Sub

    Private Sub LinkLastName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLastName.LinkClicked
        TxtCaption.Text = TxtCaption.Text.Insert(TxtCaption.SelectionStart, "[[lastname]]")
    End Sub

    Private Sub FrmSetCaption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://www.emojicopy.com/")
    End Sub
End Class