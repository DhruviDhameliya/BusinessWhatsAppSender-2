Public Class FrmSentCampain
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmSentCampain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReportShowToday()
    End Sub

    Public Sub LoadReportShowAll()
        Me.ColumnHeader1.Text = GetLangbyKey("FrmSentCampain.ColumnHeader1")
        Me.ColumnHeader2.Text = GetLangbyKey("FrmSentCampain.ColumnHeader2")
        Me.Text = GetLangbyKey("FrmSentCampain")
        ListView1.Items.Clear()

        If IO.Directory.Exists(ClsSpecialDirectories.GetReport) Then
            On Error Resume Next
            Dim _RepFile As String
            Dim li As ListViewItem
            Dim t As String = ""
            Dim fname() As String
            Dim _FName() As String
            Dim FileParts() As String
            Dim RepDate As String = ""
            For Each _RepFile In IO.Directory.GetFiles(ClsSpecialDirectories.GetReport, "*.html")
                If _RepFile.Contains("[") Then
                    li = New ListViewItem
                    li.Tag = _RepFile
                    fname = Split(_RepFile, "\")
                    _FName = Split(fname(UBound(fname)), ".")
                    FileParts = Split(_FName(0), "_")
                    RepDate = FileParts(0)

                    RepDate = RepDate.Replace("[", ":")
                    li.Text = RepDate
                    li.SubItems.Add(FileParts(1))
                    If li.Text <> "" Then
                        ListView1.Items.Add(li)
                    End If

                End If
            Next
        End If
        ListView1.Sort()
    End Sub


    Public Sub LoadReportShowTwoDates(ByVal Date1 As DateTime, ByVal Date2 As DateTime)
        Me.ColumnHeader1.Text = GetLangbyKey("FrmSentCampain.ColumnHeader1")
        Me.ColumnHeader2.Text = GetLangbyKey("FrmSentCampain.ColumnHeader2")
        Me.Text = GetLangbyKey("FrmSentCampain")
        ListView1.Items.Clear()

        If IO.Directory.Exists(ClsSpecialDirectories.GetReport) Then
            On Error Resume Next
            Dim _RepFile As String
            Dim li As ListViewItem
            Dim t As String = ""
            Dim fname() As String
            Dim _FName() As String
            Dim FileParts() As String
            Dim RepDate As String = ""
            For Each _RepFile In IO.Directory.GetFiles(ClsSpecialDirectories.GetReport, "*.html")
                If _RepFile.Contains("[") Then
                    li = New ListViewItem
                    li.Tag = _RepFile
                    fname = Split(_RepFile, "\")
                    _FName = Split(fname(UBound(fname)), ".")
                    FileParts = Split(_FName(0), "_")
                    RepDate = FileParts(0)

                    RepDate = RepDate.Replace("[", ":")
                    If CDate(RepDate) > CDate(Date1.ToString("yyyy-MM-dd 00:00:00")) And CDate(RepDate) < CDate(Date2.ToString("yyyy-MM-dd 23:59:59")) Then
                        li.Text = RepDate
                        li.SubItems.Add(FileParts(1))
                        If li.Text <> "" Then
                            ListView1.Items.Add(li)
                        End If
                    End If
                End If
            Next
        End If
        ListView1.Sort()
    End Sub

    Public Sub LoadReportShowYesterday()
        Me.ColumnHeader1.Text = GetLangbyKey("FrmSentCampain.ColumnHeader1")
        Me.ColumnHeader2.Text = GetLangbyKey("FrmSentCampain.ColumnHeader2")
        Me.Text = GetLangbyKey("FrmSentCampain")
        ListView1.Items.Clear()

        If IO.Directory.Exists(ClsSpecialDirectories.GetReport) Then
            On Error Resume Next
            Dim _RepFile As String
            Dim li As ListViewItem
            Dim t As String = ""
            Dim fname() As String
            Dim _FName() As String
            Dim FileParts() As String
            Dim RepDate As String = ""
            For Each _RepFile In IO.Directory.GetFiles(ClsSpecialDirectories.GetReport, "*.html")
                If _RepFile.Contains("[") Then
                    li = New ListViewItem
                    li.Tag = _RepFile
                    fname = Split(_RepFile, "\")
                    _FName = Split(fname(UBound(fname)), ".")
                    FileParts = Split(_FName(0), "_")
                    RepDate = FileParts(0)

                    RepDate = RepDate.Replace("[", ":")
                    If CDate(RepDate) > CDate(Now.AddDays(-1).ToString("yyyy-MM-dd 00:00:00")) And CDate(RepDate) < CDate(Now.AddDays(-1).ToString("yyyy-MM-dd 23:59:59")) Then
                        li.Text = RepDate
                        li.SubItems.Add(FileParts(1))
                        If li.Text <> "" Then
                            ListView1.Items.Add(li)
                        End If
                    End If
                End If
            Next
        End If
        ListView1.Sort()
    End Sub

    Public Sub LoadReportShowToday()
        ListView1.Items.Clear()
        Me.ColumnHeader1.Text = GetLangbyKey("FrmSentCampain.ColumnHeader1")
        Me.ColumnHeader2.Text = GetLangbyKey("FrmSentCampain.ColumnHeader2")
        Me.Text = GetLangbyKey("FrmSentCampain")
        If IO.Directory.Exists(ClsSpecialDirectories.GetReport) Then
            On Error Resume Next
            Dim _RepFile As String
            Dim li As ListViewItem
            Dim t As String = ""
            Dim fname() As String
            Dim _FName() As String
            Dim FileParts() As String
            Dim RepDate As String = ""
            For Each _RepFile In IO.Directory.GetFiles(ClsSpecialDirectories.GetReport, "*.html")
                If _RepFile.Contains("[") Then
                    li = New ListViewItem
                    li.Tag = _RepFile
                    fname = Split(_RepFile, "\")
                    _FName = Split(fname(UBound(fname)), ".")
                    FileParts = Split(_FName(0), "_")
                    RepDate = FileParts(0)

                    RepDate = RepDate.Replace("[", ":")
                    If CDate(RepDate) > CDate(Now.ToString("yyyy-MM-dd 00:00:00")) Then
                        li.Text = RepDate
                        li.SubItems.Add(FileParts(1))
                        If li.Text <> "" Then
                            ListView1.Items.Add(li)
                        End If
                    End If
                End If
            Next
        End If
        ListView1.Sort()
    End Sub
    Private Sub FrmSentCampain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try


            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).Tag <> "" Then
                    Process.Start(ListView1.SelectedItems(0).Tag)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, Application.ProductName)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).Tag <> "" Then
                    WebBrowser1.Navigate(ListView1.SelectedItems(0).Tag)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        LoadReportShowYesterday()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoadReportShowToday()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        LoadReportShowTwoDates(Now.AddDays(-7), Now)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        LoadReportShowTwoDates(Now.AddDays(-30), Now)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        LoadReportShowTwoDates(MonthCalendar1.SelectionStart, MonthCalendar1.SelectionEnd)


    End Sub
End Class