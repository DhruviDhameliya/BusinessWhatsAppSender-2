Public Class FrmInput
    Public CountryCode As String
    Private Sub FrmInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        Me.DialogResult = DialogResult.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Only number accepted.", vbCritical, Application.ProductName)
            TextBox1.Focus()
            Exit Sub
        End If
        CountryCode = TextBox1.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class