Imports ADODB
Module Conn
    Public PathConn As New ADODB.Connection
    Public conSql As New ADODB.Connection
    Public recset As New ADODB.Recordset
    Public DBpath As String

    Public Ip As String
    Public UID As String
    Public PWD As String
    Public DB As String
    Public admin As String

    Public Access As String
    Public Sub setcon()
        Try
            With My.Settings
                Ip = .DB_IpAdd
                UID = .DB_UID
                PWD = .DB_PWD
                DB = .DB_DB
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub subSQl()
        Try
            conSql = New ADODB.Connection
            conSql.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSql.Open("Driver={mySQL ODBC 5.1 Driver}; " _
                                  & "Server=" & Ip & ";" _
                                  & "Port=3306;" _
                                  & "Option=3;" _
                                  & "Database=" & DB & ";" _
                                  & "UID=" & UID & ";" _
                                  & "PWD=" & PWD & ";")
            frmMain.StatDB.Text = "Connected"
            frmMain.StatDB.ForeColor = Color.Blue
            Exit Sub
        Catch ex As Exception
            frmMain.StatDB.Text = "Disconnected"
            frmMain.StatDB.ForeColor = Color.Maroon
            Exit Sub
        End Try
    End Sub
    Public Sub ConPath()
        Try
            PathConn = New ADODB.Connection
            PathConn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            PathConn.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & My.Settings.DB_Path & "")
            'frmMain.StatDBpath.Text = "Connected"
            'frmMain.StatDBpath.ForeColor = Color.Blue
            Exit Sub
        Catch ex As Exception
            'frmMain.StatDBpath.Text = "Disconnected"
            'frmMain.StatDBpath.ForeColor = Color.Maroon
            'MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function VerPathCon() As Boolean
        Try
            PathConn = New ADODB.Connection
            PathConn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            PathConn.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & My.Settings.DB_Path & "")
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
