Public Class ManualImport
    Public Contacts As List(Of WhatsAppContact)
    Public DialogResult As DialogResult
    Public Function Showdialog() As DialogResult
        FrmManualImports.CurrentImportContext = Me
        FrmManualImports.ShowDialog()
        Return DialogResult
    End Function
End Class
