Public Class FrmAdd
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub FrmAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FrmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class