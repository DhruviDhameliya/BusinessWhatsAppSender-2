Public Class ClsNumberGenerator
    Public Contacts As List(Of WhatsAppContact)
    Public DialogResult As DialogResult
    Public Function Showdialog() As DialogResult
        FrmNumberGenerator.CurrentImportContext = Me
        FrmNumberGenerator.ShowDialog()
        Return DialogResult
    End Function

End Class
