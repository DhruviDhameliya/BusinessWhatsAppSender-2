Public Class ClsSpecialDirectories
    Public Shared Function GetProfiles()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Profiles\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Profiles\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Profiles\"
    End Function
    Public Shared Function GetReport()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Reports\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Reports\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Reports\"
    End Function

    Public Shared Function Getdata()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Data\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Data\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Data\"
    End Function
End Class
