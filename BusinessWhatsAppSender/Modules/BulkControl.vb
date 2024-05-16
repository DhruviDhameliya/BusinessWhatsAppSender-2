Module BulkControl

    Public BulkIsStarted As Boolean
    Public BulkIsPaused As Boolean
    Public BulkIsUnPaused As Boolean


    Public BulkIsResting As Boolean
    Public BulkIsUnResting As Boolean

    Public BulkRestingTime As Integer

    Public BulkIsLoggedIn As Boolean

    Public BulkIsDone As Boolean
    Public BulkIsSending As Boolean

    Public BulkIsFamiliarSending


    Public BulkIsMessageSent As Boolean = False

    Public BuLkMessageDestination As String = ""
    Public BulkMessageBody As String = ""
    Public BulkMessageType As String = ""
    Public BulkMessageName As String = ""
    Public BulkMessageDate As String = ""
    Public BulkMessageStatus As Boolean

    Public BulkCurrentProgress As Integer = 0
    Public BulkMAXProgress As Integer = 0

    Public MessagesSentList As New List(Of MessageSentModel)


End Module
