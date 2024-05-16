Imports System.ComponentModel

Public Class FrmLog

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text.Length > 99990000 Then
            TextBox1.Text = ""
        End If
        If allReceivedMessage <> "" Then
            TextBox1.Text = TextBox1.Text & allReceivedMessage & vbNewLine
            allReceivedMessage = ""
            TextBox1.SelectionStart = TextBox1.Text.Length
            TextBox1.Focus()
            TextBox1.ScrollToCaret()
        End If
    End Sub

    Private Sub SaveLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLogToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Filter = "*.log|*.log"
        If dlg.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(dlg.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub FrmLog_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = 1
        Me.Hide()
    End Sub

    Private Sub FrmLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MenuStrip1.Text = GetLangbyKey("FrmLog.MenuStrip1")
        Me.FileToolStripMenuItem.Text = GetLangbyKey("FrmLog.FileToolStripMenuItem")
        Me.SaveLogToolStripMenuItem.Text = GetLangbyKey("FrmLog.SaveLogToolStripMenuItem")
        Me.ExitToolStripMenuItem.Text = GetLangbyKey("FrmLog.ExitToolStripMenuItem")
        Me.Text = GetLangbyKey("FrmLog")

    End Sub
End Class