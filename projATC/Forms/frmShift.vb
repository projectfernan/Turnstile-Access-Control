Public Class frmShift
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
        LstDept.Columns.Add("Shift Name", 250, HorizontalAlignment.Left)
        LstDept.Columns.Add("StartTime", 150, HorizontalAlignment.Left)
        LstDept.Columns.Add("EndTime", 150, HorizontalAlignment.Left)
        'LstDept.Columns.Add("Designation", 150, HorizontalAlignment.Left)
    End Sub

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
        rs = conSql.Execute("select * from tblshifts")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("ShiftName").Value, lup)
                viewlst.SubItems.Add(Format(CDate(rs("TimeStart").Value), "HH:mm:ss"))
                viewlst.SubItems.Add(Format(CDate(rs("TimeEnd").Value), "HH:mm:ss"))
                'viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub frmShift_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        LstDept.Clear()
        header()
        fill()
        ' disableFields()

        cmdAdd.Text = "&Add"
        cmdUpdate.Text = "&Edit"
        txtShiftName.Text = vbNullString
        disableFields()
    End Sub

    Function chkShift(shiftNem As String) As Boolean
        If subSQl() = False Then
            ' MsgBox("Failed to connect in database! ", vbExclamation, "Save")
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select ShiftName from tblshifts where ShiftName = '" & shiftNem & "'")
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

            rs.Open("select * from tblshifts where 1=0", conSql, 1, 2)
            rs.AddNew()
            rs("ShiftName").Value = txtShiftName.Text
            rs("TimeStart").Value = dtTmeFrm.Value
            rs("TimeEnd").Value = dtTmeTo.Value
            rs.Update()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
            Return False
        End Try
    End Function

    Function UpdateShift(Sname As String) As Boolean
        If subSQl() = False Then
            MsgBox("Failed to connect in database! ", vbExclamation, "Save")
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblshifts where ShiftName = '" & Sname & "'", conSql, 1, 2)
            rs("TimeStart").Value = dtTmeFrm.Value
            rs("TimeEnd").Value = dtTmeTo.Value
            rs.Update()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
            Return False
        End Try
    End Function

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        If cmdAdd.Text = "&Add" Then
            cmdAdd.Text = "&Save"
            enableFields()
            txtShiftName.Text = vbNullString
            txtShiftName.Focus()
        ElseIf cmdAdd.Text = "&Save" Then
            If chkShift(txtShiftName.Text) = True Then
                MsgBox("Shift Name already exist! ", vbExclamation, "Save")
                Exit Sub
            End If

            If saveShift() = True Then
                LstDept.Clear()
                header()
                fill()
                MsgBox("New Shift successfully saved!", vbInformation, "Save")
                cmdAdd.Text = "&Add"
                disableFields()
            End If
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdate.Click
        If cmdUpdate.Text = "&Edit" Then
            cmdUpdate.Text = "&Update"
            enableFields()
            txtShiftName.Enabled = False
        ElseIf cmdUpdate.Text = "&Update" Then
            If UpdateShift(txtShiftName.Text) = True Then
                LstDept.Clear()
                header()
                fill()
                MsgBox("Shift schedule updated! ", vbInformation)
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
            End If
        Next
    End Sub

    Function delRec(ShftNem As String) As Boolean
        If subSQl() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("delete from tblshifts where ShiftName = '" & ShftNem & "'")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
            Return False
        End Try

    End Function

    Private Sub LstDept_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstDept.SelectedIndexChanged
        slct()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cmdAdd.Text = "&Add"
        cmdUpdate.Text = "&Edit"
        txtShiftName.Text = vbNullString
        disableFields()
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
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