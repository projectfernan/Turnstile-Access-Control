Public Class frmAddList

    Private Sub frmAddList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        header()
        fill()
        Progbar.Value = 0
    End Sub

    Sub header()
        LstEmpRec.Columns.Add("BadgeNumber", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("SSN", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Title", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Gender", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ContactNo", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("BirthDate", 180, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If ConPath() = False Then
            MsgBox("Please connect to MS access database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = PathConn.Execute("select * from USERINFO order by USERID")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                On Error Resume Next
                LstEmpRec.Refresh()
                rs2 = New Recordset
                rs2 = conSql.Execute("select * from tblstudinfo where Acnumber = '" & rs("BADGENUMBER").Value & "'")
                If rs2.EOF = True Then
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rs("BADGENUMBER").Value, lup)
                    viewlst.SubItems.Add(rs("SSN").Value)
                    viewlst.SubItems.Add(rs("Name").Value)
                    viewlst.SubItems.Add(rs("Title").Value)
                    viewlst.SubItems.Add(rs("Gender").Value)
                    viewlst.SubItems.Add(rs("Pager").Value)
                    viewlst.SubItems.Add(rs("Street").Value)
                    viewlst.SubItems.Add(rs("Birthday").Value)
                End If
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Findfill()

        If ConPath() = False Then
            MsgBox("Please connect to MS access database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = PathConn.Execute("select * from USERINFO where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                rs2 = New Recordset
                rs2 = conSql.Execute("select * from tblstudinfo where Acnumber = '" & rs("BADGENUMBER").Value & "'")
                If rs2.EOF = True Then
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rs("BADGENUMBER").Value, lup)
                    viewlst.SubItems.Add(rs("SSN").Value)
                    viewlst.SubItems.Add(rs("Name").Value)
                    viewlst.SubItems.Add(rs("Title").Value)
                    viewlst.SubItems.Add(rs("Gender").Value)
                    viewlst.SubItems.Add(rs("Pager").Value)
                    viewlst.SubItems.Add(rs("Street").Value)
                    viewlst.SubItems.Add(rs("Birthday").Value)
                End If
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub AddInfo()

        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                flag = "Save"
                On Error Resume Next
                With frmAddStud
                    .txtAC.ReadOnly = False
                    .txtId.ReadOnly = False
                    .txtAC.Text = viewlst.SubItems(0).Text
                    .txtId.Text = viewlst.SubItems(1).Text
                    .txtName.Text = viewlst.SubItems(2).Text
                    .txtCourse.Text = viewlst.SubItems(3).Text
                    .txtGender.Text = viewlst.SubItems(4).Text
                    .txtContact.Text = viewlst.SubItems(5).Text
                    .txtAdd.Text = viewlst.SubItems(6).Text
                    .dtBdate.Value = viewlst.SubItems(7).Text
                    .Text = " New Student"
                    '   .EmpPic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                    .txtGuardian.Focus()
                    .ShowDialog()
                    Me.Visible = False
                    Me.Close()
                End With
            End If
        Next
    End Sub

    Sub AddAllInfo()
        If ConPath() = False Then
            MsgBox("Please connect to MS access database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        If conServer() = False Then
            MsgBox("Please connect to MySQL server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim rs3 As New Recordset
        Dim lup As Integer

        rs = New Recordset
        rs = PathConn.Execute("select * from USERINFO order by USERID")
        If rs.EOF = False Then
            Progbar.Maximum = rs.RecordCount
            lup = 0
            Do While rs.EOF = False
                rs2 = New Recordset
                rs2 = conSql.Execute("select * from tblstudinfo where Acnumber = '" & rs("BADGENUMBER").Value & "'")
                If rs2.EOF = True Then
                    rs3 = New Recordset
                    rs3.Open("select * from tblstudinfo where 1=0", conSql, 1, 2)
                    rs3.AddNew()
                    rs3("ACnumber").Value = rs("BADGENUMBER").Value
                    rs3("IDnumber").Value = rs("SSN").Value
                    rs3("Name").Value = rs("Name").Value
                    rs3("Course").Value = rs("Title").Value
                    rs3("Gender").Value = rs("Gender").Value
                    rs3("ContactNo").Value = rs("Pager").Value
                    rs3("Address").Value = rs("Street").Value
                    rs3("BirthDate").Value = rs("Birthday").Value
                    rs3("Guardian").Value = "Not encoded"
                    rs3("GradeYear").Value = "Not encoded"
                    rs3("Section").Value = "Not encoded"
                    rs3.Update()
                End If
                lup = lup + 1
                Progbar.Value = lup
                rs.MoveNext()
            Loop
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        AddInfo()
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure do you want to add all records? ", vbQuestion + vbYesNo + vbDefaultButton2, "Add All") = vbYes Then
            If LstEmpRec.Items.Count = 0 Then
                MsgBox("There is no record to be loaded!", vbExclamation, "Add All")
                Progbar.Value = 0
                Exit Sub
            End If

            AddAllInfo()
            LstEmpRec.Clear()
            header()
            fill()
        End If
       
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
    End Sub
End Class