Public Class frmStudRec

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        frmAddList.ShowDialog()
    End Sub

    Private Sub frmStudRec_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        LstEmpRec.Clear()
        header()
        'fill()
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Sub header()
        LstEmpRec.Columns.Add("AC Number", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ID Number", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Course", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Gender", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Grade/Year", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Section", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Birth Date", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Guardian", 140, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ContactNo", 145, HorizontalAlignment.Left)
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
        rs = conSql.Execute("select * from tblStudInfo")
        If rs.EOF = False Then
            txtCount.Text = rs.RecordCount
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                viewlst.SubItems.Add(rs("Course").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Gender").Value)
                viewlst.SubItems.Add(rs("GradeYear").Value)
                viewlst.SubItems.Add(rs("Section").Value)
                viewlst.SubItems.Add(rs("BirthDate").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("Guardian").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        Else
            txtCount.Text = 0
        End If
    End Sub

    Sub Findfill()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        On Error Resume Next

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblStudInfo where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            txtCount.Text = rs.RecordCount
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                viewlst.SubItems.Add(rs("Course").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Gender").Value)
                viewlst.SubItems.Add(rs("GradeYear").Value)
                viewlst.SubItems.Add(rs("Section").Value)
                viewlst.SubItems.Add(rs("BirthDate").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("Guardian").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        Else
            txtCount.Text = 0
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                imgStud.Image = StudentPic(viewlst.SubItems(1).Text)
                frmAddStud.EmpPic.Image = StudentPic(viewlst.SubItems(1).Text)

                If desig = "User" Then
                    cmdDel.Enabled = False
                    cmdEdit.Enabled = False
                Else
                    cmdDel.Enabled = True
                    cmdEdit.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                edit(viewlst.SubItems(0).Text)

                flag = "Edit"
                With frmAddStud
                    .Text = "Update Student Information"
                    enableTxt(frmAddStud)
                    .cmdBrowse.Enabled = True
                    .txtAC.ReadOnly = True
                    .txtId.ReadOnly = True
                    .ShowDialog()
                End With
            End If
        Next
    End Sub

    Sub edit(ByVal acNo As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        On Error Resume Next
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblstudInfo where ACNumber = '" & acNo & "'")
        If rs.EOF = False Then
            frmAddStud.txtAC.Text = rs("ACnumber").Value
            frmAddStud.txtId.Text = rs("IDnumber").Value
            frmAddStud.txtName.Text = rs("Name").Value
            frmAddStud.txtGender.Text = rs("Gender").Value
            frmAddStud.txtGy.Text = rs("GradeYear").Value
            frmAddStud.txtSec.Text = rs("Section").Value
            frmAddStud.dtBdate.Text = rs("BirthDate").Value
            frmAddStud.txtAdd.Text = rs("Address").Value
            frmAddStud.txtGuardian.Text = rs("Guardian").Value
            frmAddStud.txtContact.Text = rs("ContactNo").Value
        End If
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                    del(viewlst.SubItems(0).Text)
                    LstEmpRec.Clear()
                    header()
                    fill()
                    cmdEdit.Enabled = False
                    cmdDel.Enabled = False
                    imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                    frmNewStud.EmpPic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End If
            End If
        Next
    End Sub

    Sub del(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        Try
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("delete from tblStudInfo where AcNumber = '" & id & "'")
            MsgBox("Record successfully deleted!    ", vbInformation, "Delete")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try

    End Sub

    Private Sub cboCateg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class