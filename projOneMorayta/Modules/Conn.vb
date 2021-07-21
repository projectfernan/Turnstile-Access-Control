Imports ADODB
Imports System.Data.OleDb
Imports System.IO
Module Conn
    Public PathConn As New ADODB.Connection
    Public conSql As New ADODB.Connection
    Public conSqlLoc As New ADODB.Connection
    Public recset As New ADODB.Recordset

    Public Conn As New OleDbConnection
    Public Cmd As OleDbCommand

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

    Public Function subSQl()
        With moraytaMain
            Try
                If DB = vbNullString Then Return False

                If conSql.State = 1 Then conSql.Close()
                conSql = New ADODB.Connection
                conSql.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                conSql.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
                                      & "Server=" & Ip & ";" _
                                      & "Port=3306;" _
                                      & "Option=3;" _
                                      & "Database=" & DB & ";" _
                                      & "UID=" & UID & ";" _
                                      & "PWD=" & PWD & ";")
                .StatDB.Text = "Connected"
                .StatDB.ForeColor = Color.Aqua
                .txtSystemErr.Text = "---"
                Return True
            Catch ex As Exception
                .txtSystemErr.Text = ex.Message
                .StatDB.Text = "Disconnected"
                .StatDB.ForeColor = Color.Pink
                Return False
            End Try
        End With
        
    End Function

    Public Function subSQlLoc()
        With moraytaMain
            Try
                With My.Settings
                    If DB = vbNullString Then Return False

                    If conSqlLoc.State = 1 Then conSqlLoc.Close()
                    conSqlLoc = New ADODB.Connection
                    conSqlLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                    conSqlLoc.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
                                          & "Server=" & .DBloc_Ip & ";" _
                                          & "Port=3306;" _
                                          & "Option=3;" _
                                          & "Database=" & .DBloc_DB & ";" _
                                          & "UID=" & .DBloc_UID & ";" _
                                          & "PWD=" & .DBloc_PWD & ";")
                End With
                .txtLocalStat.Text = "Connected"
                .txtLocalStat.ForeColor = Color.Aqua
                '.txtSystemErr.Text = "---"
                Return True
            Catch ex As Exception
                '.txtSystemErr.Text = ex.Message
                .txtLocalStat.Text = "Disconnected"
                .txtLocalStat.ForeColor = Color.Pink
                Return False
            End Try
        End With

    End Function

    Public Function Connect_Local() As Boolean
        Conn = New OleDbConnection
        Try
            With Conn
                .ConnectionString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & My.Settings.DB_Path & ""
                .Open()
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ConPath()
        Try
            PathConn = New ADODB.Connection
            PathConn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ' PathConn.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & My.Settings.DB_Path & "")
            PathConn.Open("Driver={Microsoft Access Driver (*.mdb)};DBQ=" & My.Settings.DB_Path & "")
            frmMain.StatDBpath.Text = "Connected"
            frmMain.StatDBpath.ForeColor = Color.Blue
            frmMain.txtSystemErr.Text = "---"
            Return True
        Catch ex As Exception
            frmMain.txtSystemErr.Text = ex.Message
            frmMain.StatDBpath.Text = "Disconnected"
            frmMain.StatDBpath.ForeColor = Color.Maroon
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function VerPathCon() As Boolean
        Try
            PathConn = New ADODB.Connection
            PathConn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ' PathConn.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & My.Settings.DB_Path & "")
            PathConn.Open("Driver={Microsoft Access Driver (*.mdb)};DBQ=" & My.Settings.DB_Path & "")
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
