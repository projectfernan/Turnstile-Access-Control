Imports ADODB
Public Class frmDowloadLogs
    Dim strDevnum As String
    Dim strDevSetStat As String

    Sub header()
        lstList.Columns.Add("ID", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("IDnumber", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Name", 250, HorizontalAlignment.Left)
        lstList.Columns.Add("CheckTime", 180, HorizontalAlignment.Left)
    End Sub

    Public Sub vehicleCharging(ByVal cbo As ComboBox)
        If subSQl() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            cbo.Items.Clear()

            rs = New Recordset
            rs = conSql.Execute("SELECT DeviceName from tbldevices")

            While rs.EOF = False
                cbo.Items.Add(rs("DeviceName").Value)
                rs.MoveNext()
            End While

        Catch

        End Try
    End Sub

    Sub GetDevNo(ByVal Devname As String)
        If subSQl() = False Then
            Exit Sub
        End If

        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSql.Execute("SELECT DevNumber,Status from tbldevices where DeviceName = '" & Devname & "'")

            If rs.EOF = False Then
                strDevnum = rs("DevNumber").Value
                strDevSetStat = rs("Status").Value
            Else
                strDevnum = "0"
                strDevSetStat = "NA"
            End If
        Catch

        End Try
    End Sub

    Sub fill()
        If ConPath() = False Then
            MsgBox("Please connect to MS Access database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        '  txtLoading.Text = 0
        txtTotal.Text = 0
        Progbar.Maximum = 0
        txtMsg.Text = "Reading data..."

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm:ss")
        GetDevNo(cboDevice.Text)

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = PathConn.Execute("select USERID,CHECKTIME,SENSORID from CHECKINOUT where SENSORID = '" & strDevnum & "' and CHECKTIME between #" & TmeInFrm & "# and #" & TmeInTo & "#")
        If rs.EOF = False Then
            txtTotal.Text = rs.RecordCount
            Progbar.Maximum = rs.RecordCount

            For lup = 1 To rs.RecordCount
                Dim strUserID As Long = rs("USERID").Value
                Dim strChkTime As String = Format(rs("CHECKTIME").Value, "yyyy-MM-dd HH:mm:ss")


                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = PathConn.Execute("Select SSN,Name from USERINFO where USERID = " & strUserID & "")
                If rs2.EOF = False Then

                    'On Error Resume Next
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(strUserID.ToString, lup)
                    Try
                        viewlst.SubItems.Add(rs2("SSN").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs2("Name").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("na")
                    End Try

                    viewlst.SubItems.Add(strChkTime)

                End If
                '  txtLoading.Text = lup
                Progbar.Value = lup

                rs.MoveNext()
            Next

            txtMsg.Text = "Successfully generated"
            strDevnum = 0
            strDevSetStat = "In"
        Else
            MsgBox("No record found! ", vbExclamation, "Search")
        End If

    End Sub

    Sub DelLogs(ByVal stUserID As Long)
        If ConPath() = False Then
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = PathConn.Execute("Delete from CHECKINOUT where USERID = " & stUserID & "")
        Catch ex As Exception

        End Try

    End Sub

    Function GEt_Shift(ByVal Idno As String) As String


        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select Shift from tblemp where IDnumber = '" & Idno & "' limit 1;")
            If rs.EOF = False Then
                Return rs("Shift").Value
            Else
                Return "na"
            End If
        Catch ex As Exception
            Return "na"
        End Try
    End Function

    Public Function TotalTime_FUNCTION(ByVal tmeIN As Date, ByVal tmeOUT As Date) As String
        Try
            Dim MIN As Long = DateDiff("n", tmeIN, tmeOUT)
            Dim hh As Integer = DateDiff("h", tmeIN, tmeOUT)

            If MIN > 0 Then
                If MIN >= 60 Then
                    Dim tHH As Long = hh
                    Dim tExcessMin As Long = CLng(MIN Mod 60)

                    Return tHH & " Hr and " & tExcessMin & " Mins"
                Else
                    Return "0 Hr and " & MIN & " Mins"
                End If
            Else
                Return "0 Hr and 0 Mins"
                'Dim tHH As Long = hh
                'Dim tExcessMin As Long = CLng(MIN Mod -60)

                'If tHH < 0 Then
                'Return tHH & " Hr and " & tExcessMin & " Mins"
                'Else
                'Return tHH & " Hr and " & MIN & " Mins"
                'End If
            End If

        Catch ex As Exception
            Return "0 Hr and 0 Mins"
        End Try
    End Function

    Sub DownloadData()
        If ConPath() = False Then
            MsgBox("Please connect to MS Access database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        '  txtLoading.Text = 0
        txtTotal.Text = 0
        Progbar.Maximum = 0
        txtMsg.Text = "Reading data..."

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm:ss")
        GetDevNo(cboDevice.Text)

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = PathConn.Execute("select USERID,CHECKTIME,SENSORID from CHECKINOUT where SENSORID = '" & strDevnum & "' and CHECKTIME between #" & TmeInFrm & "# and #" & TmeInTo & "#")
        If rs.EOF = False Then
            txtTotal.Text = rs.RecordCount
            Progbar.Maximum = rs.RecordCount

            For lup = 1 To rs.RecordCount
                Dim strUserID As Long = rs("USERID").Value
                Dim strChkTime As String = Format(rs("CHECKTIME").Value, "yyyy-MM-dd HH:mm:ss")


                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = PathConn.Execute("Select SSN,Name from USERINFO where USERID = " & strUserID & "")
                If rs2.EOF = False Then
                    Dim rs3 As New Recordset
                    Select Case strDevSetStat
                        Case "In"
                            Dim startTME As Date
                            Dim EndTME As Date
                            Dim ShiftNem As String

                            If rs2("SSN").Value.ToString = vbNullString Then
                                ShiftNem = "na"
                            Else
                                ShiftNem = GEt_Shift(rs2("SSN").Value)
                            End If

                            Dim rs1 As New Recordset
                            rs1 = New Recordset
                            rs1 = conSql.Execute("select TimeStart,TimeEnd from tblshifts where ShiftName = '" & ShiftNem & "'")
                            If rs1.EOF = False Then
                                Dim dtNow1 As String = Format(CDate(strChkTime), "yyyy-MM-dd")
                                Dim dtNow2 As String = Format(CDate(strChkTime), "yyyy-MM-dd")

                                startTME = dtNow1 & " " & Format(CDate(rs1("TimeStart").Value), "HH:mm:ss")
                                EndTME = dtNow2 & " " & Format(CDate(rs1("TimeEnd").Value), "HH:mm:ss")
                            End If

                            rs3 = New Recordset
                            rs3.Open("select * from tbltimein where 1=0", conSql, 1, 2)
                            rs3.AddNew()
                            Try
                                If rs2("SSN").Value.ToString = vbNullString Then
                                    rs3("IDnumber").Value = "na"
                                Else
                                    rs3("IDnumber").Value = rs2("SSN").Value
                                End If

                            Catch ex As Exception
                                rs3("IDnumber").Value = "na"
                            End Try

                            Try
                                rs3("Name").Value = rs2("Name").Value
                            Catch ex As Exception
                                rs3("Name").Value = "na"
                            End Try

                            Try
                                rs3("ShiftName").Value = ShiftNem
                            Catch ex As Exception
                                rs3("ShiftName").Value = "na"
                            End Try

                            rs3("TimeIn").Value = strChkTime

                            If CDate(strChkTime) <= startTME Then
                                rs3("Status").Value = "OnTime"
                            ElseIf Now > startTME Then
                                rs3("Status").Value = "Late"
                            End If

                            rs3("StatusTime").Value = TotalTime_FUNCTION(startTME, CDate(strChkTime))

                            'rs3 = New Recordset
                            'rs3.Open("select * from tbltimein where 1=0", conSql, 1, 2)
                            'rs3.AddNew()
                            'Try
                            '    rs3("IDnumber").Value = rs2("SSN").Value
                            'Catch ex As Exception
                            '    rs3("IDnumber").Value = "na"
                            'End Try

                            'Try
                            '    rs3("Name").Value = rs2("Name").Value
                            'Catch ex As Exception
                            '    rs3("Name").Value = "na"
                            'End Try

                            'rs3("TimeIn").Value = strChkTime
                            rs3.Update()
                        Case "Out"
                            rs3 = New Recordset
                            rs3.Open("select * from tbltimeout where 1=0", conSql, 1, 2)
                            rs3.AddNew()
                            Try
                                If rs2("SSN").Value.ToString = vbNullString Then
                                    rs3("IDnumber").Value = "na"
                                Else
                                    rs3("IDnumber").Value = rs2("SSN").Value
                                End If
                            Catch ex As Exception
                                rs3("IDnumber").Value = "na"
                            End Try

                            Try
                                rs3("Name").Value = rs2("Name").Value
                            Catch ex As Exception
                                rs3("Name").Value = "na"
                            End Try

                            Try
                                rs3("ShiftName").Value = GEt_Shift(rs2("SSN").Value)
                            Catch ex As Exception
                                rs3("ShiftName").Value = "na"
                            End Try

                            rs3("TimeOut").Value = strChkTime
                            rs3.Update()
                    End Select
                End If
                DelLogs(strUserID)
                '  txtLoading.Text = lup
                Progbar.Value = lup

                rs.MoveNext()
            Next

            txtMsg.Text = "Successfully downloaded"
            strDevnum = 0
            strDevSetStat = "In"
        Else
            MsgBox("No record found! ", vbExclamation, "Search")
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If cboDevice.Text = vbNullString Then
            MsgBox("Please select device! ", vbExclamation, "Search")
            Exit Sub
        End If

        lstList.Clear()
        header()
        fill()
    End Sub

    Private Sub frmDowloadLogs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' txtLoading.Text = 0
        txtTotal.Text = 0
        Progbar.Maximum = 0
        txtMsg.Text = "---"

        vehicleCharging(cboDevice)

        lstList.Clear()
        header()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        If cboDevice.Text = vbNullString Then
            MsgBox("Please select device! ", vbExclamation, "Search")
            Exit Sub
        End If

        DownloadData()
    End Sub
End Class