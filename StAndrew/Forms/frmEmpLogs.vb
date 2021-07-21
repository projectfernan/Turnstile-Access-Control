Public Class frmEmpLogs
    Public rsPRS As New ADODB.Recordset
    Public rsIO As New ADODB.Recordset
    Public categ As String
    Public id As String
    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged
        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                able()
                cmdDel.Enabled = False
                cmdPrint.Enabled = False
                EmpPic.Image = Nothing
                cboRem.Text = vbNullString
                cboCategory.Enabled = True
            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                able()
                cmdDel.Enabled = False
                cmdPrint.Enabled = False
                EmpPic.Image = Nothing
                cboRem.Text = vbNullString
                cboCategory.Enabled = True
        End Select
    End Sub

    Sub EntHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("IdLog", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IdNumber", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 350, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 170, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Status", 100, HorizontalAlignment.Left)
        'LstEmpRec.Columns.Add("Date", 100, HorizontalAlignment.Left)
        'LstEmpRec.Columns.Add("Remarks", 120, HorizontalAlignment.Left)
    End Sub
    Sub AttHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("IdLog", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IdNumber", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeOut", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Status", 100, HorizontalAlignment.Left)
        'LstEmpRec.Columns.Add("Remarks", 120, HorizontalAlignment.Left)
    End Sub
    Sub able()
        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        cmdPrint.Enabled = True
        'Button1.Enabled = True
    End Sub
    Sub unable()
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        cmdPrint.Enabled = False
        cmdFind.Enabled = False

        'dtDateFrm.Enabled = False
        'dtDateTo.Enabled = False
        'dtTmeFrm.Enabled = False
        'dtTmeTo.Enabled = False
        'txtInput.Enabled = False
        txtKeyword.Enabled = False

        cboCategory.Enabled = False
        cboRem.Enabled = False

    End Sub

    Private Sub frmEmpLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        EntHead()
        EmpPic.Image = Nothing
        'ExtPic.Image = Nothing
        unable()
        cboCateg.Text = vbNullString
        If PingMe(Ip) = True Then
            subSQl()
        End If
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.Text = "All" Then
            cboRem.Enabled = True
            cboRem.Text = vbNullString
            txtKeyword.Enabled = False
            cmdFind.Enabled = True
        ElseIf cboCategory.Text = "IDnumber" Then
            cboRem.Enabled = True
            cboRem.Text = vbNullString
            txtKeyword.Enabled = True
            txtKeyword.Focus()
            cmdFind.Enabled = True
        Else
            cboCategory.Text = "Name"
            cboRem.Enabled = True
            cboRem.Text = vbNullString
            txtKeyword.Enabled = True
            txtKeyword.Focus()
            cmdFind.Enabled = True
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                Entall()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True

            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                InOutAll()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True
        End Select
        categ = "All"
    End Sub
    Sub Entall()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        ' Dim rs As New Recordset
        Dim lup As Short
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from tblEmpTImein")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                viewlst.SubItems.Add(rsPRS("Name").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                'viewlst.SubItems.Add(rs("Date").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub
    Sub InOutAll()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        'Dim rs As New Recordset
        Dim lup As Short
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblEmpinOut")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("IdLog").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                If cboCategory.Text = "All" Then
                    EntSrch()
                    If desig = "User" Then
                        cmdDel.Enabled = False
                    Else
                        cmdDel.Enabled = True
                    End If
                    cmdPrint.Enabled = True
                    categ = "Search"
                    Exit Sub
                End If
                EntIndi()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True
            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                If cboCategory.Text = "All" Then
                    InOutSrch()
                    If desig = "User" Then
                        cmdDel.Enabled = False
                    Else
                        cmdDel.Enabled = True
                    End If
                    cmdPrint.Enabled = True
                    categ = "Search"
                    Exit Sub
                End If
                IndiInOut()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True
        End Select
        categ = "Search"
    End Sub
    Sub EntSrch()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String
        'Dim DateInFrm As String
        'Dim DateInTo As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
        'Dim rs As New Recordset
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from tblEmpTImein where Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                viewlst.SubItems.Add(rsPRS("Name").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                'viewlst.SubItems.Add(rs("Date").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub
    Sub EntIndi()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String
        'Dim DateInFrm As String
        'Dim DateInTo As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
        'Dim rs As New Recordset
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from tblEmpTImein where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                viewlst.SubItems.Add(rsPRS("Name").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                'viewlst.SubItems.Add(rs("Date").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub

    Sub InOutSrch()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        'Dim rs As New Recordset
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblEmpInOut where Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("IDLog").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Sub IndiInOut()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        'Dim rs As New Recordset
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblEmpInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("IDlog").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        frmMain.Timer1.Enabled = False
        Select Case cboCateg.Text
            Case "Time In"
                If PingMe(Ip) = True Then
                    subSQl()
                End If
                frmMain.Timer1.Enabled = False
                Prstprint()
            Case "Logs Report"
                If PingMe(Ip) = True Then
                    subSQl()
                End If
                frmMain.Timer1.Enabled = False
                AttRecPrint()
        End Select
    End Sub
    Sub Prstprint()
        Dim ReportPath As String = Application.StartupPath & "\Report\CrystalReport2.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsPRS)
        frmReportLogs.CRViewer.ReportSource = Report
        frmReportLogs.ShowDialog()
    End Sub

    Sub AttRecPrint()
        Dim ReportPath As String = Application.StartupPath & "\Report\CrystalReport1.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsIO)
        frmReportLogs.CRViewer.ReportSource = Report
        frmReportLogs.ShowDialog()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Select Case cboCateg.Text
            Case "Time In"
                If cboCategory.Text = "All" Then
                    PresDel()
                    LstEmpRec.Clear()
                    EntHead()
                    Entall()
                    ' frmMain.filllist()
                    Exit Sub
                End If
                IndiPresDel()
                LstEmpRec.Clear()
                EntHead()
                Entall()
                'frmMain.filllist()
            Case "Logs Report"
                If cboCategory.Text = "All" Then
                    AttDel()
                    LstEmpRec.Clear()
                    AttHead()
                    InOutAll()
                    Exit Sub
                End If
                IndiAttDel()
                LstEmpRec.Clear()
                AttHead()
                InOutAll()
        End Select
    End Sub

    Sub PresDel()
        If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            If categ = "All" Then
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSql.Execute("Delete from tblEmpTImein")
            ElseIf categ = "Search" Then
                Dim TmeInTo As String
                Dim TmeInFrm As String
                TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = conSql.Execute("delete from tblEmpTImein where Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            End If
        End If
    End Sub

    Sub IndiPresDel()
        If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            If categ = "All" Then
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSql.Execute("Delete from tblEmpTImein")
            ElseIf categ = "Search" Then
                Dim TmeInTo As String
                Dim TmeInFrm As String
                TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = conSql.Execute("delete from tblEmpTImein where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            End If
        End If
    End Sub

    Sub AttDel()
        If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            If categ = "All" Then
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSql.Execute("delete from tblEmpinOut")
            ElseIf categ = "Search" Then
                Dim TmeInTo As String
                Dim TmeInFrm As String

                TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = conSql.Execute("delete from tblEmpInOut where Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
            End If
        End If
    End Sub

    Sub IndiAttDel()
        If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            If categ = "All" Then
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSql.Execute("delete from tblEmpinOut")
            ElseIf categ = "Search" Then
                Dim TmeInTo As String
                Dim TmeInFrm As String

                TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = conSql.Execute("delete from tblEmpInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
            End If
        End If
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        slct()
        slctAc()
        If viewStud() = True Then
            Try
                EmpPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            Catch
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End Try
        Else
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End If
    End Sub
    Sub slct()
        Dim viewlst As New ListViewItem
        Idno = vbNullString
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                Idno = viewlst.SubItems(1).Text
            End If
        Next
    End Sub
    Sub slctAc()
        Dim rs As New Recordset
        id = vbNullString
        rs = conSql.Execute("select * from tblEmp where IDnumber = '" & Idno & "'")
        If rs.EOF = False Then
            id = rs("Acnumber").Value
        End If
    End Sub

    Function viewStud() As Boolean
        Dim rs As Recordset
        rs = conSql.Execute("select * from tblEmp where AcNumber = '" & id & "'")
        If rs.EOF = True Then
            Return False
        Else
            Return True
        End If
    End Function
End Class