Module Blocked_Expired
    Public Sub BlokedCards(ByVal Eid As Integer)
        With frmMain
            If .StatDev1.Text = "Connected" Then
                If .StatDev2.Text = "Conected" Then
                    'Dev1Control.Dev1.EnableUser(1, Eid, 1, 0, False)
                    '.Dev2.EnableUser(1, Eid, 1, 0, False)
                Else
                    ' MsgBox("Please connect to device 2!    ", vbExclamation, "Connect")
                End If
            Else
                'MsgBox("Please connect to device 1!    ", vbExclamation, "Connect")
            End If
        End With
    End Sub

    Public Sub UnblokedCards(ByVal Eid As Integer)
        With frmMain
            If .StatDev1.Text = "Connected" Then
                If .StatDev2.Text = "Conected" Then
                    ' .Dev1.EnableUser(1, Eid, 1, 0, True)
                    '.Dev2.EnableUser(1, Eid, 1, 0, True)
                Else
                    ' MsgBox("Please connect to device 2!    ", vbExclamation, "Connect")
                End If
            Else
                'MsgBox("Please connect to device 1!    ", vbExclamation, "Connect")
            End If
        End With
    End Sub

    Public Function chkExp() As Boolean

        If subSQl() = False Then Return False
        Try
            Dim dtNow As String = Format(Now, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs.Open("select * from tblemp where DateExpired <= '" & dtNow & "' and Type='Monthly' and Status = 'Access'", conSql, 1, 2)
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Public Sub DateExp()
        If subSQl() = False Then Exit Sub
        On Error Resume Next
        Dim dtNow As String = Format(Now, "yyyy-MM-dd")
        Dim rs As New Recordset
        Dim lup As Integer

        rs = New Recordset
        rs.Open("select * from tblemp where DateExpired <= '" & dtNow & "' and Type='Monthly' and Status = 'Access'", conSql, 1, 2)
        If rs.EOF = False Then
            With frmStatus
                .Progbar.Maximum = rs.RecordCount
                For lup = 1 To rs.RecordCount
                    Dim AC As Integer = rs("AcNo").Value
                    BlokedCards(AC)

                    Dim rs2 As New Recordset
                    rs2.Open("select * from tblemp where AcNo = '" & AC & "'", conSql, 1, 2)
                    rs2("Status").Value = "Blocked"
                    rs2.Update()

                    rs.MoveNext()
                    .Progbar.Value = lup
                Next

                frmStatus.Close()
            End With
        End If
    End Sub

    Public Sub BlockedCard(ByVal Acno As String)
        If subSQl() = False Then Exit Sub

        Dim rs As New Recordset
        rs.Open("select ACno,AccessStatus from tblemp where Acno = '" & Acno & "'", conSql, 1, 2)
        If rs.EOF = False Then
            ' Dim AC As Integer = rs("AcNo").Value
            ' BlokedCards(AC)
            rs("AccessStatus").Value = 0
            rs.Update()
            MsgBox("Card successfully blocked!", vbInformation, "Blocked")
        End If
    End Sub

    Public Sub UnblockedCard(ByVal Acno As String)
        If subSQl() = False Then Exit Sub

        Dim rs As New Recordset
        rs.Open("select ACno,AccessStatus from tblemp where Acno = '" & Acno & "'", conSql, 1, 2)
        If rs.EOF = False Then
            ' Dim AC As Integer = rs("AcNo").Value
            ' UnblokedCards(AC)
            rs("AccessStatus").Value = 1
            rs.Update()
            MsgBox("Card successfully unblocked!", vbInformation, "Unblocked")
        End If
    End Sub

    Public Function ChekBlocked(ByVal Acno As String) As Boolean
        If subSQl() = False Then Return False
        Try
            Dim rs As New Recordset
            rs.Open("select * from tblemp where Acno = '" & Acno & "'", conSql, 1, 2)
            If rs.EOF = False Then
                If rs("Status").Value = "Blocked" Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            frmMain.txtSystemErr.Text = ex.Message
            Return False
        End Try
    End Function

    Public Sub UpdateExp(ByVal Acno As String, ByVal dt As String)
        If subSQl() = False Then Exit Sub

        Dim rs As New Recordset
        rs.Open("select * from tblemp where Acno = '" & Acno & "'", conSql, 1, 2)
        If rs.EOF = False Then
            Dim AC As Integer = rs("AcNo").Value
            UnblokedCards(AC)
            rs("DateExpired").Value = dt
            rs("Status").Value = "Access"
            rs.Update()
            MsgBox("Expiration date updated successfully!", vbInformation, "Expiration Date")
        End If
    End Sub
End Module
