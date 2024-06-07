Imports System.Net
Imports System.Web

Public Class ClsLicence

    Private Shared Function GetServerDate() As Long
        Try
            Dim wc As New WebClient
            Return Val(ServerDecrypt(wc.DownloadString(ServerURL)))
        Catch ex As Exception
            Return Val(Now.ToString("yyyyMMdd"))
        End Try
    End Function
    Public Shared Function ResolveDate(ByVal sDate1 As Long) As String
        Dim Date1 As New Date(Mid(sDate1, 1, 4), Mid(sDate1, 5, 2), Mid(sDate1, 7, 2))
        Return Date1.ToString("dd MMMM yyyy")
    End Function
    Public Shared Function GetRemianingDays(ByVal sDate1 As Long, ByVal sDate2 As Long) As Integer
        Dim Date1 As New Date(Mid(sDate1, 1, 4), Mid(sDate1, 5, 2), Mid(sDate1, 7, 2))
        Dim Date2 As New Date(Mid(sDate2, 1, 4), Mid(sDate2, 5, 2), Mid(sDate2, 7, 2))
        Return DateDiff(DateInterval.Day, Date2, Date1)
    End Function
End Class
Public Class LicenseVerificationResult
    Public IsValid As Boolean
    Public ExpiryDate As String
    Public RemaningDays As Integer
    Public ErrorDescription As String
    Public IsFilter As Boolean
    Public IsSending As Boolean
    Public iSbOT As Boolean
End Class
Public Class ActivationCodeResponse
    Public IsExsist As Boolean
    Public ErrorDescription As String
    Public Response As ActivationCodeModel
End Class
Public Class ActivationCodeModel
    Public ExpiryDate As String
    Public Name As String
    Public Email As String
    Public Mobile As String
    Public Status As Integer
    Public AllowSending As Boolean
    Public AllowBot As Boolean
    Public AllowFilter As Boolean
    Public RequestKey As String
End Class
