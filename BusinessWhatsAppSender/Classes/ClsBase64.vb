Imports System.IO

Public Class ClsBase64
    Public Function ConvertFileToBase64(ByVal fileName As String) As String
        Dim Extension As String = Path.GetExtension(fileName)
        Dim MimeType As String = "data:image/png;base64,"
        Select Case Extension.ToLower
            Case ".jpg"
                MimeType = "data:image/jpeg;base64,"
            Case ".jpeg"
                MimeType = "data:image/jpeg;base64,"
            Case ".gif"
                MimeType = "data:image/gif;base64,"
            Case ".png"
                MimeType = "data:image/png;base64,"
            Case ".bmp"
                MimeType = "data:image/bmp;base64,"
            Case ".ico"
                MimeType = "data:image/x-icon;base64,"
            Case ".pdf"
                MimeType = "data:application/pdf;base64,"
            Case ".mp4"
                ' MimeType = "data:video/mp4;base64,"
                MimeType = "data:video/mp4;base64,"
            Case ".txt"
                MimeType = "data:text/plain;base64,"
        End Select
        Return MimeType & Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName))
    End Function
    Public Function ConvertFileToBase64NoMime(ByVal fileName As String) As String
        Return Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName))
    End Function
    Public Shared Function EncodeBase64(ByVal stringtoencode As String) As String
        Dim data() As Byte = Text.Encoding.ASCII.GetBytes(stringtoencode)
        Return Convert.ToBase64String(data)
    End Function
    Public Shared Function DecodeBase64(ByVal StringtoDecode As String) As String

        Dim data() As Byte = System.Convert.FromBase64String(StringtoDecode)
        Return System.Text.ASCIIEncoding.ASCII.GetString(data)

    End Function
End Class
