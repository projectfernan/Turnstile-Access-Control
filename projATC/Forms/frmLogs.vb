Imports ADODB
Public Class frmLogs
    Public id As String
    Public categ As String
    Public rsPRS As New Recordset
    Public rsIO As Recordset
    Public rsOut As Recordset

    Private Sub cboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub EntHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("ID", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IDnumber", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 350, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 170, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Lane", 170, HorizontalAlignment.Left)
    End Sub

    Sub ExtHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("ID", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IDnumber", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 350, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeOut", 170, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Lane", 170, HorizontalAlignment.Left)
    End Sub

    Sub AttHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("ID Log", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IDNumber", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeOut", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Lane", 170, HorizontalAlignment.Left)
    End Sub

    Private Sub frmLogs_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
   
    End Sub

    Private Sub frmLogs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'frmMain.tmrPingDev1.Enabled = True
        'frmMain.tmrPingDev2.Enabled = True
        'frmMain.tmrPingServer.Enabled = True
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        EntHead()
        unable()
        cboCateg.Text = vbNullString
        ProgBar.Value = 0

        EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        ' ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")

        If subSQl() = True Then

        End If
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged
        Select Case cboCateg.Text
            Case "Time In Logs"
                LstEmpRec.Clear()
                EntHead()
                able()
                cmdDel.Enabled = False
                ' cmdPrint.Enabled = False
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                ' ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            Case "Time Out Logs"
                LstEmpRec.Clear()
                ExtHead()
                able()
                cmdDel.Enabled = False
                ' cmdPrint.Enabled = False
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                '  ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            Case "Time In and Out Logs"
                LstEmpRec.Clear()
                AttHead()
                able()
                cmdDel.Enabled = False
                'cmdPrint.Enabled = False
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                ' ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Select
    End Sub
    Sub able()
        cmdDel.Enabled = True
        ' cmdPrint.Enabled = True
        Button1.Enabled = True
    End Sub
    Sub unable()
        cmdDel.Enabled = False
        ' cmdPrint.Enabled = False
        Button1.Enabled = False
    End Sub

    Sub Entall()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        ' Dim rs As New Recordset
        Dim lup As Short
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from tblTImein")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                viewlst.SubItems.Add(rsPRS("Name").Value)
                viewlst.SubItems.Add(rsPRS("ShiftName").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                viewlst.SubItems.Add(rsPRS("StatusTime").Value)
                Try
                    viewlst.SubItems.Add(rsPRS("FolderName").Value)
                Catch ex As Exception
                    viewlst.SubItems.Add("")
                End Try
                rsPRS.MoveNext()
            Next
        End If
    End Sub

    Sub Extall()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        ' Dim rs As New Recordset
        Dim lup As Short
        rsOut = New Recordset
        rsOut = conSql.Execute("select * from tblTImeOut")
        If rsOut.EOF = False Then
            For lup = 1 To rsOut.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsOut("IDLog").Value, lup)
                viewlst.SubItems.Add(rsOut("IDnumber").Value)
                viewlst.SubItems.Add(rsOut("Name").Value)
                viewlst.SubItems.Add(rsOut("ShiftName").Value)
                viewlst.SubItems.Add(rsOut("TimeOut").Value)
                Try
                    viewlst.SubItems.Add((rsOut("FolderName").Value))
                Catch ex As Exception
                    viewlst.SubItems.Add("")
                End Try
                rsOut.MoveNext()
            Next
        End If
    End Sub

    Sub EntSrch()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
        'Dim rs As New Recordset
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from vwetimein where Name like '" & txtInput.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsPRS.EOF = False Then
            ProgBar.Value = 0
            ProgBar.Maximum = rsPRS.RecordCount
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                viewlst.SubItems.Add(rsPRS("Name").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Lane").Value)
                rsPRS.MoveNext()
                ProgBar.Value = lup
            Next
        End If
    End Sub

    Sub ExtSrch()
        If subSQl() = False Then
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
        rsOut = New Recordset
        rsOut = conSql.Execute("select * from vwetimeout where Name like '" & txtInput.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsOut.EOF = False Then
            ProgBar.Value = 0
            ProgBar.Maximum = rsOut.RecordCount
            For lup = 1 To rsOut.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsOut("IDLog").Value, lup)
                viewlst.SubItems.Add(rsOut("IDnumber").Value)
                viewlst.SubItems.Add(rsOut("Name").Value)
                viewlst.SubItems.Add(rsOut("TimeOut").Value)
                viewlst.SubItems.Add(rsOut("Lane").Value)
                rsOut.MoveNext()
                ProgBar.Value = lup
            Next
        End If
    End Sub

    Sub InOutSrch()
        If subSQl() = False Then
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
        rsIO = conSql.Execute("select * from vweinout where Name like '" & txtInput.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsIO.EOF = False Then
            ProgBar.Value = 0
            ProgBar.Maximum = rsIO.RecordCount
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("IdLog").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Lane").Value)
                rsIO.MoveNext()
                ProgBar.Value = lup
            Next
        End If
    End Sub

    Sub InOutAll()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        'LstEmpRec.Clear()
        'Dim rs As New Recordset
        Dim lup As Short
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblinOut")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("InOutID").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("ShiftName").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                viewlst.SubItems.Add(rsIO("StatusTime").Value)
                viewlst.SubItems.Add(rsIO("TotalTime").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                Try
                    viewlst.SubItems.Add(rsIO("FolderName").Value)
                Catch ex As Exception
                    viewlst.SubItems.Add("")
                End Try
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Public Function Get_ImageName(ByVal IdLog As String) As String
        Dim Name As String = Dir$(My.Settings.CapImgPath & "\EntCapture" & IdLog & "\JPEGCapture\*.jpeg")
        If Name = "" Then
            Return Nothing
        Else
            Return My.Settings.CapImgPath & "\EntCapture" & IdLog & "\JPEGCapture\" & Name
        End If
    End Function

    Public Function Get_ImageNameExt(ByVal IdLog As String) As String
        Dim Name As String = Dir$(My.Settings.CapImgPath & "\ExtCapture" & IdLog & "\JPEGCapture\*.jpeg")
        If Name = "" Then
            Return Nothing
        Else
            Return My.Settings.CapImgPath & "\ExtCapture" & IdLog & "\JPEGCapture\" & Name
        End If
    End Function

    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                EmpPic.Image = Get_PicEmp(viewlst.SubItems(1).Text)
            End If
        Next
    End Sub

    Sub picEntView()
        EmpPic.Image = Get_ImageIn(id)
    End Sub

    Sub picInOutView()
        EmpPic.Image = Get_PicEnt(id)
        ' ExtPic.Image = Get_PicExt(id)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case cboCateg.Text
            Case "Time In Logs"
                LstEmpRec.Clear()
                EntHead()
                EntSrch()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                'cmdPrint.Enabled = True
                Button2.Enabled = True
            Case "Time Out Logs"
                LstEmpRec.Clear()
                EntHead()
                ExtSrch()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                ' cmdPrint.Enabled = True
                Button2.Enabled = True
            Case "Time In and Out Logs"
                LstEmpRec.Clear()
                AttHead()
                InOutSrch()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                'cmdPrint.Enabled = True
                Button2.Enabled = True
        End Select
        categ = "Search"
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case cboCateg.Text
            Case "Time In Logs"
                Prstprint()
            Case "Time Out Logs"
                Outprint()
            Case "Time In and Out Logs"
                AttRecPrint()
        End Select
    End Sub

    Sub PresDel()
        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String
            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("delete from tblTImein where Name like '" & txtInput.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        Catch ex As Exception

        End Try
    End Sub

    Sub PresDelImg()
        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String
            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            Dim lup As Long
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblTImein where Name like '" & txtInput.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            If rs2.EOF = False Then
                For lup = 1 To rs2.RecordCount
                    If rs2("FolderName").Value <> Nothing Then
                        Delete_ImageInLogs(rs2("IDnumber").Value, rs2("FolderName").Value)
                    End If
                    rs2.MoveNext()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub OutDel()

        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String
            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("delete from tblTImeOut where Name like '" & txtInput.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")

        Catch ex As Exception

        End Try
      
    End Sub

    Sub OutDelImg()

        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String
            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            Dim lup As Long
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblTImeout where Name like '" & txtInput.Text & "%' and Timeout >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
            If rs2.EOF = False Then
                For lup = 1 To rs2.RecordCount
                    If rs2("FolderName").Value <> Nothing Then
                        Delete_ImageIn(rs2("FolderName").Value)
                    End If
                    rs2.MoveNext()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub AttDel()

        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("delete from tblInOut where Name like '" & txtInput.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")

        Catch ex As Exception

        End Try
     
    End Sub

    Sub AttDelImg()

        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            Dim lup As Long
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblinout where Name like '" & txtInput.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
            If rs2.EOF = False Then
                For lup = 1 To rs2.RecordCount
                    If rs2("FolderName").Value <> Nothing Then
                        Delete_ImageIn(rs2("FolderName").Value)
                    End If
                    rs2.MoveNext()
                Next
            End If
        Catch ex As Exception

        End Try
   
    End Sub

    Sub Prstprint()
        Dim ReportPath As String = Application.StartupPath & "\Report\Crtreport.rpt"
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

    Sub PrstprintL()
        Dim ReportPath As String = Application.StartupPath & "\Report\Cr_timeIn.rpt"
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

    Sub Outprint()
        Dim ReportPath As String = Application.StartupPath & "\Report\CrTimeOut.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsOut)
        frmReportLogs.CRViewer.ReportSource = Report
        frmReportLogs.ShowDialog()
    End Sub


    Sub OutprintL()
        Dim ReportPath As String = Application.StartupPath & "\Report\CR_TimeOut.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsOut)
        frmReportLogs.CRViewer.ReportSource = Report
        frmReportLogs.ShowDialog()
    End Sub

    Sub AttRecPrint()
        Dim ReportPath As String = Application.StartupPath & "\Report\CrtAttreport.rpt"
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

    Sub AttRecPrintL()
        Dim ReportPath As String = Application.StartupPath & "\Report\CR_ListLogs.rpt"
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
            Case "Time In Logs"
                If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                    PresDelImg()
                    PresDel()
                    LstEmpRec.Clear()
                    EntHead()
                    Entall()
                End If
            Case "Time Out Logs"
                If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                    OutDelImg()
                    OutDel()
                    LstEmpRec.Clear()
                    ExtHead()
                    Extall()
                End If
            Case "Time In and Out Logs"
                If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                    AttDelImg()
                    AttDel()
                    LstEmpRec.Clear()
                    AttHead()
                    InOutAll()
                End If
        End Select
    End Sub

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged
        'Select Case cboCateg.Text
        '    Case "Time In Logs"
        '        LstEmpRec.Clear()
        '        EntHead()
        '        nemPrs()
        '        If desig = "User" Then
        '            cmdDel.Enabled = False
        '        Else
        '            cmdDel.Enabled = True
        '        End If
        '        cmdPrint.Enabled = True
        '        categ = "nemSirch"
        '        EntPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        '        ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        '    Case "Time Out Logs"
        '        LstEmpRec.Clear()
        '        ExtHead()
        '        nemOut()
        '        If desig = "User" Then
        '            cmdDel.Enabled = False
        '        Else
        '            cmdDel.Enabled = True
        '        End If
        '        cmdPrint.Enabled = True
        '        categ = "nemSirch"
        '        EntPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        '        ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        '    Case "Time In and Out Logs"
        '        LstEmpRec.Clear()
        '        AttHead()
        '        nematt()
        '        If desig = "User" Then
        '            cmdDel.Enabled = False
        '        Else
        '            cmdDel.Enabled = True
        '        End If
        '        cmdPrint.Enabled = True
        '        categ = "nemSirch"
        '        EntPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        '        ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        'End Select
    End Sub

    Sub nemPrs()
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from tbltimein where Name like '" & txtInput.Text & "%'")
        ProgBar.Value = 0
        ProgBar.Maximum = rsPRS.RecordCount
        For lup = 1 To rsPRS.RecordCount
            LstEmpRec.Refresh()
            Dim viewlst As New ListViewItem
            viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
            viewlst.SubItems.Add(rsPRS("IDnumber").Value)
            viewlst.SubItems.Add(rsPRS("Name").Value)
            viewlst.SubItems.Add(rsPRS("TimeIn").Value)
            rsPRS.MoveNext()
            ProgBar.Value = lup
        Next
    End Sub

    Sub nemOut()
        rsOut = New Recordset
        rsOut = conSql.Execute("select * from tbltimeOut where Name like '" & txtInput.Text & "%'")
        ProgBar.Value = 0
        ProgBar.Maximum = rsOut.RecordCount
        For lup = 1 To rsOut.RecordCount
            LstEmpRec.Refresh()
            Dim viewlst As New ListViewItem
            viewlst = LstEmpRec.Items.Add(rsOut("IDLog").Value, lup)
            viewlst.SubItems.Add(rsOut("IDnumber").Value)
            viewlst.SubItems.Add(rsOut("Name").Value)
            viewlst.SubItems.Add(rsOut("TimeOut").Value)
            rsOut.MoveNext()
            ProgBar.Value = lup
        Next
    End Sub

    Sub nematt()
        'Dim rs As New Recordset
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblinout where Name like '" & txtInput.Text & "%'")
        If rsIO.EOF = False Then
            ProgBar.Value = 0
            ProgBar.Maximum = rsIO.RecordCount
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("InOutID").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsIO.MoveNext()
                ProgBar.Value = lup
            Next
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Select Case cboCateg.Text
            Case "Time In Logs"
                PrstprintL()
            Case "Time Out Logs"
                OutprintL()
            Case "Time In and Out Logs"
                AttRecPrintL()
        End Select
    End Sub

    Sub Shfttype(ByVal cbo As ComboBox)

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT ShiftName from tblshifts")
        cbo.Items.Add("All")
        While rs.EOF = False
            cbo.Items.Add(rs("ShiftName").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub frmLogs_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub cboShift_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class