Public Class ClsLanguage
    Public Structure Language
        Public LanguageName As String
        Public LanguageFile As String
    End Structure
    Public Shared Function GetLanguages() As List(Of Language)
        Dim LangPath As String = Application.StartupPath & "\language\"
        Dim ResultLangList As New List(Of Language)
        Dim LangItem As Language
        If IO.Directory.Exists(LangPath) Then
            ResultLangList.Clear()
            For Each LangFile As String In IO.Directory.GetFiles(LangPath, "*.lng")
                LangItem = New Language
                LangItem.LanguageFile = LangFile
                Dim langSpliter() As String = Split(LangFile, "\")
                Dim ExtenSplitter() As String = Split(langSpliter(UBound(langSpliter)), ".")
                LangItem.LanguageName = ExtenSplitter(0)
                ResultLangList.Add(LangItem)
            Next
            Return ResultLangList
        Else
            Return New List(Of Language)
        End If

    End Function

End Class
