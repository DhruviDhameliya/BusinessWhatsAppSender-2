Public Class FrmLanguage
    Private Sub FrmLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        SaveSetting(Application.ProductName, "language", "languagename", ComboBoxLanguage.Text)
        CurrentLanguage = ComboBoxLanguage.Text
        ApplyLanguage()
        Close()
    End Sub

End Class