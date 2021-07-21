Public Class frmAccessGroup
    Sub disableFields()
        txtShiftName.Enabled = False
        dtTmeFrm.Enabled = False
        dtTmeTo.Enabled = False

        txtShiftName.Text = vbNullString
    End Sub

    Sub enableFields()
        txtShiftName.Enabled = True
        dtTmeFrm.Enabled = True
        dtTmeTo.Enabled = True
    End Sub

    Sub header()
        LstDept.Columns.Add("Access Group", 250, HorizontalAlignment.Left)
        LstDept.Columns.Add("StartTime", 150, HorizontalAlignment.Left)
        LstDept.Columns.Add("EndTime", 150, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        LstDept.Columns.Add("", 0, HorizontalAlignment.Left)
        'LstDept.Columns.Add("Designation", 150, HorizontalAlignment.Left)
    End Sub

    Function chkDay(ByVal val As Integer) As String
        Dim strVal As Boolean = CBool(val)
        Select Case strVal
            Case False
                Return "False"
            Case True
                Return "True"
        End Select
    End Function

    Sub fill()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        On Error Resume Next

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblaccessgroup")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("AccessGroup").Value, lup)
                viewlst.SubItems.Add(Format(CDate(rs("TimeStart").Value), "HH:mm:ss"))
                viewlst.SubItems.Add(Format(CDate(rs("TimeEnd").Value), "HH:mm:ss"))
                viewlst.SubItems.Add(Format(rs("Sunday").Value))
                viewlst.SubItems.Add(Format(rs("Monday").Value))
                viewlst.SubItems.Add(Format(rs("Tuesday").Value))
                viewlst.SubItems.Add(Format(rs("Wednesday").Value))
                viewlst.SubItems.Add(Format(rs("Thursday").Value))
                viewlst.SubItems.Add(Format(rs("Friday").Value))
                viewlst.SubItems.Add(Format(rs("Saturday").Value))
                'viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub resetChk()
        chkSunday.Checked = False
        chkMonday.Checked = False
        chkTuesday.Checked = False
        chkWednesday.Checked = False
        chkThursday.Checked = False
        chkFriday.Checked = False
        chkSaturday.Checked = False
    End Sub

    Private Sub frmShift_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LstDept.Clear()
        header()
        fill()
        ' disableFields()

        cmdAdd.Text = "&Add"
        cmdUpdate.Text = "&Edit"
        txtShiftName.Text = vbNullString
        disableFields()

        resetChk()
    End Sub

    Function chkShift(ByVal shiftNem As String) As Boolean
        If subSQl() = False Then
            ' MsgBox("Failed to connect in database! ", vbExclamation, "Save")
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select ShiftName from tblaccessgroup where AccessGroup = '" & shiftNem & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function saveShift() As Boolean
        If subSQl() = False Then
            MsgBox("Failed to connect in database! ", vbExclamation, "Save")
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblaccessgroup where 1=0", conSql, 1, 2)
            rs.AddNew()
            rs("AccessGroup").Value = txtShiftName.Text
            rs("TimeStart").Value = dtTmeFrm.Value
            rs("TimeEnd").Value = dtTmeTo.Value
            rs("Sunday").Value = CInt(chkSunday.Checked)
            rs("Monday").Value = CInt(chkMonday.Checked)
            rs("Tuesday").Value = CInt(chkTuesday.Checked)
            rs("Wednesday").Value = CInt(chkWednesday.Checked)
            rs("Thursday").Value = CInt(chkThursday.Checked)
            rs("Friday").Value = CInt(chkFriday.Checked)
            rs("Saturday").Value = CInt(chkSaturday.Checked)
            rs.Update()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
            Return False
        End Try
    End Function

    Function UpdateShift(ByVal Sname As String) As Boolean
        If subSQl() = False Then
            MsgBox("Failed to connect in database! ", vbExclamation, "Save")
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblaccessgroup where AccessGroup = '" & Sname & "'", conSql, 1, 2)
            rs("TimeStart").Value = dtTmeFrm.Value
            rs("TimeEnd").Value = dtTmeTo.Value
            rs("Sunday").Value = CInt(chkSunday.Checked)
            rs("Monday").Value = CInt(chkMonday.Checked)
            rs("Tuesday").Value = CInt(chkTuesday.Checked)
            rs("Wednesday").Value = CInt(chkWednesday.Checked)
            rs("Thursday").Value = CInt(chkThursday.Checked)
            rs("Friday").Value = CInt(chkFriday.Checked)
            rs("Saturday").Value = CInt(chkSaturday.Checked)
            rs.Update()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
            Return False
        End Try
    End Function

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        resetChk()
        If cmdAdd.Text = "&Add" Then
            cmdAdd.Text = "&Save"
            enableFields()
            txtShiftName.Text = vbNullString
            txtShiftName.Focus()
        ElseIf cmdAdd.Text = "&Save" Then
            If chkShift(txtShiftName.Text) = True Then
                MsgBox("Access Group already exist! ", vbExclamation, "Save")
                Exit Sub
            End If

            If saveShift() = True Then
                LstDept.Clear()
                header()
                fill()
                MsgBox("New Access Group successfully saved!", vbInformation, "Save")
                cmdAdd.Text = "&Add"
                disableFields()
            End If
        End If
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If cmdUpdate.Text = "&Edit" Then
            cmdUpdate.Text = "&Update"
            enableFields()
            txtShiftName.Enabled = False
        ElseIf cmdUpdate.Text = "&Update" Then
            If UpdateShift(txtShiftName.Text) = True Then
                LstDept.Clear()
                header()
                fill()
                MsgBox("Access Group updated! ", vbInformation)
                cmdUpdate.Text = "&Edit"
            End If
        End If
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstDept.Items
            If viewlst.Selected = True Then
                txtShiftName.Text = viewlst.SubItems(0).Text
                dtTmeFrm.Value = CDate("2015-12-28 " & viewlst.SubItems(1).Text)
                dtTmeTo.Value = CDate("2015-12-28 " & viewlst.SubItems(2).Text)
                chkSunday.Checked = CBool(viewlst.SubItems(3).Text)
                chkMonday.Checked = CBool(viewlst.SubItems(4).Text)
                chkTuesday.Checked = CBool(viewlst.SubItems(5).Text)
                chkWednesday.Checked = CBool(viewlst.SubItems(6).Text)
                chkThursday.Checked = CBool(viewlst.SubItems(7).Text)
                chkFriday.Checked = CBool(viewlst.SubItems(8).Text)
                chkSaturday.Checked = CBool(viewlst.SubItems(9).Text)
            End If
        Next
    End Sub

    Function delRec(ByVal ShftNem As String) As Boolean
        If subSQl() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("delete from tblaccessgroup where AccessGroup = '" & ShftNem & "'")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
            Return False
        End Try

    End Function

    Private Sub LstDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDept.SelectedIndexChanged
        slct()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmdAdd.Text = "&Add"
        cmdUpdate.Text = "&Edit"
        txtShiftName.Text = vbNullString
        disableFields()
        resetChk()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In LstDept.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbNo Then
                    Exit Sub
                End If
                If delRec(viewlst.SubItems(0).Text) = True Then
                    LstDept.Clear()
                    header()
                    fill()
                    MsgBox("Record successfully deleted! ", vbInformation, "Delete")
                End If
            End If
        Next
    End Sub
End Class