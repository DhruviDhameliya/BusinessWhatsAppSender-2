Public Class FrmSpintax
    Public spintax As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        spintax = TxtResult.Text
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged, TextBox13.TextChanged, TextBox14.TextChanged, TextBox15.TextChanged, TextBox16.TextChanged
        Dim t As Object
        Dim Res As String = ""
        For Each t In Me.Controls
            If t.name.ToString.StartsWith("TextBox") Then
                If t.text <> "" Then
                    Res = Res & t.text & "|"
                End If
            End If
        Next
        If Res.Length > 0 Then
            Res = Mid(Res, 1, Res.Length - 1)
        End If
        TxtResult.Text = "{{" & Res & "}}"
    End Sub

    Private Sub FrmSpintax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As Object
        For Each t In Me.Controls
            If t.name.ToString.StartsWith("TextBox") Then
                t.text = ""
            End If
        Next
        TxtResult.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(TxtResult.Text)
    End Sub
End Class