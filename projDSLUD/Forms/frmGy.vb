Public Class frmGy

    Private Sub frmGy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EduLv(cboEduLv)
        lstList.Clear()
        header()
        fill()
    End Sub

    Sub EduLv(ByVal cbo As ComboBox)

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tbledulevel")

        If rs.EOF = True Then
            MsgBox("Please set education level!    ", vbExclamation, Me.Text)
            frmEduLevel.ShowDialog()
            Exit Sub
        End If

        While rs.EOF = False
            cbo.Items.Add(rs("EducationLevel").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub header()
        lstList.Columns.Add("Grade/Year", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Education Level", 190, HorizontalAlignment.Left)
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
        rs = conSql.Execute("select * from tblgradeyear")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("GradeYear").Value, lup)
                viewlst.SubItems.Add(rs("EducationLevel").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function chkRS(ByVal id As String) As Boolean
        Dim rs As New Recordset
        rs = conSql.Execute("select * from tblgradeyear where GradeYear = '" & id & "'")
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

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblgradeyear", conSql, 1, 2)
        rs.AddNew()
        rs("EducationLevel").Value = cboEduLv.Text
        rs("GradeYear").Value = txtGy.Text
        rs.Update()
    End Sub

    Sub del(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = conSql.Execute("delete from tblgradeyear where GradeYear = '" & id & "'")
        MsgBox("Record successfully deleted!", vbInformation, "Delete")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cboEduLv.Text = vbNullString Or txtGy.Text = vbNullString Then
            MsgBox("Please fill up the blanks!    ", vbExclamation)
            Exit Sub
        End If

        If chkRS(txtGy.Text) = False Then
            MsgBox("Grade/Year level already exist!    ", vbExclamation, "Add")
            txtGy.Text = vbNullString
            txtGy.Focus()
            Exit Sub
        End If

        save()
        lstList.Clear()
        header()
        fill()
        cboEduLv.Text = vbNullString
        txtGy.Text = vbNullString
    End Sub

    Private Sub txtGy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGy.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboEduLv.Text = vbNullString Or txtGy.Text = vbNullString Then
                MsgBox("Please fill up the blanks!    ", vbExclamation)
                Exit Sub
            End If

            If chkRS(txtGy.Text) = False Then
                MsgBox("Grade/Year level already exist!    ", vbExclamation, "Add")
                txtGy.Text = vbNullString
                txtGy.Focus()
                Exit Sub
            End If

            save()
            lstList.Clear()
            header()
            fill()
            cboEduLv.Text = vbNullString
            txtGy.Text = vbNullString
        End If
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
End Class