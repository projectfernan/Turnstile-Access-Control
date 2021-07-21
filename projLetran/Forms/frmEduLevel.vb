Imports ADODB
Public Class frmEduLevel

    Private Sub frmEduLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        lstList.Clear()
        header()
        fill()
    End Sub

    Sub header()
        lstList.Columns.Add("Education Level", 275, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tbledulevel")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("EducationLevel").Value, lup)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function chkRS(ByVal id As String) As Boolean
        Dim rs As New Recordset
        rs = conSql.Execute("select * from tbledulevel where EducationLevel = '" & id & "'")
        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub save()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        If chkRS(txtEduLv.Text) = False Then
            MsgBox("Education level already exist!    ", vbExclamation, "Add")
            txtEduLv.Text = vbNullString
            txtEduLv.Focus()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tbledulevel", conSql, 1, 2)
        rs.AddNew()
        rs("EducationLevel").Value = txtEduLv.Text
        rs.Update()
    End Sub

    Sub del(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = conSql.Execute("delete from tbledulevel where EducationLevel = '" & id & "'")
        MsgBox("Record successfully deleted!", vbInformation, "Delete")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtEduLv.Text = vbNullString Then
            MsgBox("Please fill the blank!    ", vbExclamation, "Add")
            txtEduLv.Focus()
            Exit Sub
        End If

        If chkRS(txtEduLv.Text) = False Then
            MsgBox("Education level already exist!    ", vbExclamation, "Add")
            txtEduLv.Text = vbNullString
            txtEduLv.Focus()
            Exit Sub
        End If

        save()
        lstList.Clear()
        header()
        fill()
        txtEduLv.Text = vbNullString
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click

        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                    del(viewlst.SubItems(0).Text)
                    lstList.Clear()
                    header()
                    fill()
                End If
            End If
        Next

    End Sub

    Private Sub txtEduLv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEduLv.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEduLv.Text = vbNullString Then
                MsgBox("Please fill the blank!    ", vbExclamation, "Add")
                txtEduLv.Focus()
                Exit Sub
            End If
            save()
            lstList.Clear()
            header()
            fill()
            txtEduLv.Text = vbNullString
        End If
    End Sub

End Class