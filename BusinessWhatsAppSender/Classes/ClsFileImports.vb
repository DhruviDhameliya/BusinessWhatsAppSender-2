Public Class FileImports
    Public Contacts As List(Of WhatsAppContact)
    Public DialogResult As DialogResult
    Public Function Showdialog() As DialogResult
        FrmImportFromFiles.CurrentImportContext = Me
        FrmImportFromFiles.ShowDialog()
        Return DialogResult
    End Function
End Class
