Imports ADODB
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core
Imports System.Collections
Public Class frmUpload
    Public UploadStat As Integer
    Public totalRec As Integer

    Public Sub UploadCard()
        Try
            Dim Upflag As Boolean
            Dim i As Short
            Dim j As Short
            Dim page As Short
            Dim bFlag As Byte
            Dim dwn_user_pack(1024) As Byte

            'Dim dte As Short

            i = -1
            page = 0
            bFlag = &H55

            If subSQl() = False Then Exit Sub

            Dim lup As Integer = 0
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select * from tblcards")
            If rs.EOF = False Then

                Dim recCount As Integer = rs.RecordCount
                Progbar.Maximum = rs.RecordCount

                For j = 0 To recCount '44 record

                    UploadStat = j
                    Progbar.Value = j
                    txtLoadStat.Text = totalRec & "  /  " & UploadStat

                    i = i + 1
                    If i = CInt(recCount) Then
                        Exit For
                    End If

                    Dim CardCode As Long = rs("CardCode").Value 'Replace(strLim0, "0", vbNullString)
                    Dim EnrolDate As Date = rs("DateEnrolled").Value
                    Dim ExpDate As Date = rs("DateExpired").Value

                    Dim s As String = CardCode
                    Dim cardid As UInt32
                    If Not UInt32.TryParse(s, System.Globalization.NumberStyles.[Integer], Nothing, cardid) Then
                        MessageBox.Show("Failed to upload! " & vbCr & vbLf)
                        Upflag = False
                        Return
                    End If

                    Dim mjrc As New MjRegisterCard()

                    '注册卡信息修改
                    mjrc.CardID = cardid
                    '卡号 
                    mjrc.Password = UInteger.Parse("345678")
                    '密码
                    mjrc.ymdStart = EnrolDate
                    '起始日期
                    mjrc.ymdEnd = ExpDate
                    '结束日期
                    mjrc.ControlSegIndexSet(1, Byte.Parse("1"))
                    '1号门时段
                    mjrc.ControlSegIndexSet(2, Byte.Parse("1"))
                    '2号门时段
                    mjrc.ControlSegIndexSet(3, Byte.Parse("1"))
                    '3号门时段
                    mjrc.ControlSegIndexSet(4, Byte.Parse("1"))
                    '4号门时段
                    Dim ret As Integer = -1
                    Using pri As New wgMjControllerPrivilege()
                        ret = pri.AddPrivilegeOfOneCardIP(controler.ControllerSN, controler.IP, controler.PORT, mjrc)
                    End Using
                    If ret >= 0 Then
                        'MessageBox.Show("Successfully uploaded! " & vbCr & vbLf)
                        Upflag = True
                    Else
                        MessageBox.Show("Failed to upload! " & vbCr & vbLf)
                        Upflag = False
                    End If

                    rs.MoveNext()
                Next

                If i = CInt(recCount) Then
                End If

            End If
            If Upflag = True Then
                MsgBox("Successfully uploaded! ", vbInformation, "Upload")
            End If
            cmdUpload.Visible = False
            cmdClose.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Upload")
        End Try
    End Sub

    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click
        UploadCard()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        controler.ControllerSN = CInt(uplod_SN)
        controler.IP = uplod_IP
        controler.PORT = uplod_Port
    End Sub

    Sub CardRec()
        If subSQl() = False Then Exit Sub

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlLoc.Execute("select * from tblcards")
        If rs.EOF = False Then
            totalRec = rs.RecordCount
            UploadStat = 0
            txtLoadStat.Text = totalRec & "  /  " & UploadStat
        End If
    End Sub

    Private Sub frmUpload_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmdUpload.Visible = True
        cmdClose.Visible = False
        Progbar.Value = 0
        totalRec = 0
        UploadStat = 0

        CardRec()
    End Sub
End Class