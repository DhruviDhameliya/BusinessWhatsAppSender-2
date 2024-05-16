Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Public Class DropShadow
    Private _isAeroEnabled As Boolean = False
    Private _isDraggingEnabled As Boolean = False
    Private Const WM_NCHITTEST As Integer = &H84
    Private Const WS_MINIMIZEBOX As Integer = &H20000
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const CS_DBLCLKS As Integer = &H8
    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const WM_NCPAINT As Integer = &H85
    Private Const WM_ACTIVATEAPP As Integer = &H1C

    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure

    <DllImport("dwmapi.dll")>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer

    End Function
    <DllImport("dwmapi.dll")>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer

    End Function
    <DllImport("dwmapi.dll")>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer

    End Function

    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Shared Function IsCompositionEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then Return False
        Dim enabled As Boolean
        DwmIsCompositionEnabled(enabled)
        Return enabled
    End Function

    <DllImport("dwmapi.dll")>
    Private Shared Function DwmIsCompositionEnabled(<Out> ByRef enabled As Boolean) As Integer

    End Function
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function

    Private Function CheckIfAeroIsEnabled() As Boolean
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            DwmIsCompositionEnabled(enabled)
            Return If((enabled = 1), True, False)
        End If

        Return False
    End Function

    Public Shared Sub ApplyShadows(ByVal form As Form)
        Dim v = 2
        DwmSetWindowAttribute(form.Handle, 2, v, 4)
        Dim margins As MARGINS = New MARGINS() With {
                .bottomHeight = 1,
                .leftWidth = 0,
                .rightWidth = 0,
                .topHeight = 0
            }
        DwmExtendFrameIntoClientArea(form.Handle, margins)
    End Sub
End Class