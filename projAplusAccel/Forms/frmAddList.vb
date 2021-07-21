Public Class frmAddList

    Private Sub frmAddList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Progbar.Value = 0
        LstEmpRec.Clear()
        header()
        fill()

    End Sub

    Sub header()
        LstEmpRec.Columns.Add("BadgeNumber", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("SSN", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Title", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Gender", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ContactNo", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("BirthDate", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("HiredDate", 180, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If ConPath() = False Then
            MsgBox("Please connect to MS access database!    ", vbExclamation, "Database")
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = PathConn.Execute("select BADGENUMBER,SSN,Name,Title,Gender,Pager,Street,Birthday,HiredDay from USERINFO order by USERID")
        If rs.EOF = False Then
            Progbar.Value = 0
            Progbar.Maximum = rs.RecordCount
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                If subSQl() = False Then
                    Exit Sub
                End If
                rs2 = New Recordset
                rs2 = conSql.Execute("select * from tblemp where Acno = '" & rs("BADGENUMBER").Value & "'")
                If rs2.EOF = True Then
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rs("BADGENUMBER").Value, lup)
                    Try
                        viewlst.SubItems.Add(rs("SSN").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("Name").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("Title").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("Gender").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("Pager").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("Street").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add("NA")
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("Birthday").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add(Now)
                    End Try
                    Try
                        viewlst.SubItems.Add(rs("HiredDay").Value)
                    Catch ex As Exception
                        viewlst.SubItems.Add(Now)
                    End Try
                End If
                Progbar.Value = lup
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub AddAllInfo()
        If ConPath() = False Then
            MsgBox("Please connect to MS access database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        If subSQl() = False Then
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
            Progbar.Value = 0
            Progbar.Maximum = rs.RecordCount
            lup = 0
            Do While rs.EOF = False
                rs2 = New Recordset
                rs2 = conSql.Execute("select * from tblemp where Acno = '" & rs("BADGENUMBER").Value & "'")
                If rs2.EOF = True Then
                    rs3 = New Recordset
                    rs3.Open("select * from tblemp where 1=0", conSql, 1, 2)
                    rs3.AddNew()
                    rs3("ACno").Value = rs("BADGENUMBER").Value
                    rs3("IDnumber").Value = rs("SSN").Value
                    rs3("Name").Value = rs("Name").Value
                    rs3("Title").Value = rs("Title").Value
                    rs3("Gender").Value = rs("Gender").Value
                    rs3("ContactNo").Value = rs("Pager").Value
                    rs3("Address").Value = rs("Street").Value
                    rs3("BirthDate").Value = rs("Birthday").Value
                    rs3("HiredDay").Value = rs("HiredDay").Value
                    rs3.Update()
                End If
                lup = lup + 1
                Progbar.Value = lup
                rs.MoveNext()
            Loop
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
            Progbar.Value = 0
            Progbar.Maximum = rs.RecordCount
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                rs2 = New Recordset
                rs2 = conSql.Execute("select * from tblemp where Acno = '" & rs("BADGENUMBER").Value & "'")
                If rs2.EOF = True Then
                    Dim viewlst As New ListViewItem
                    On Error Resume Next
                    viewlst = LstEmpRec.Items.Add(rs("BADGENUMBER").Value, lup)
                    viewlst.SubItems.Add(rs("SSN").Value)
                    viewlst.SubItems.Add(rs("Name").Value)
                    viewlst.SubItems.Add(rs("Title").Value)
                    viewlst.SubItems.Add(rs("Gender").Value)
                    viewlst.SubItems.Add(rs("Pager").Value)
                    viewlst.SubItems.Add(rs("Street").Value)
                    viewlst.SubItems.Add(rs("Birthday").Value)
                    viewlst.SubItems.Add(rs("HiredDay").Value)
                End If
                Progbar.Value = lup
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
    End Sub

    Private Sub txtInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            LstEmpRec.Clear()
            header()
            Findfill()
        End If
    End Sub

    Sub AddInfo()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                On Error Resume Next
                With frmAddCard
                    .txtAccNo.Text = viewlst.SubItems(0).Text
                    .txtIdnumber.Text = viewlst.SubItems(1).Text
                    .txtName.Text = viewlst.SubItems(2).Text
                    .txtTitle.Text = viewlst.SubItems(3).Text
                    .txtGender.Text = viewlst.SubItems(4).Text
                    .txtContact.Text = viewlst.SubItems(5).Text
                    .txtAddress.Text = viewlst.SubItems(6).Text
                    .dtBdate.Value = viewlst.SubItems(7).Text
                    .dtHiredDate.Value = viewlst.SubItems(8).Text
                    .Text = " New Employee"
                    .ShowDialog()
                    Me.Visible = False
                    Me.Close()
                End With
            End If
        Next
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddInfo()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If LstEmpRec.Items.Count = 0 Then
            MsgBox("There is no record to be loaded!", vbExclamation, "Add All")
            Progbar.Value = 0
            Exit Sub
        End If

        If MsgBox("Are you sure do you want to add all records? ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
            AddAllInfo()
            LstEmpRec.Clear()
            header()
            fill()
        End If

    End Sub
End Class