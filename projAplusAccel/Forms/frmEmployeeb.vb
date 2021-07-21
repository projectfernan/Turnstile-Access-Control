Imports ADODB
Public Class frmEmployeeb
    Public id As String
    Public delPic As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmEmployee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        EmpPic.Image = Nothing
        LstEmpRec.Clear()
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        header()
        fill()
    End Sub

    Sub header()
        LstEmpRec.Columns.Add("", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ACno", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IDNumber", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Title", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Gender", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ContactNo", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("BirthDate", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("HiredDay", 150, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        On Error Resume Next

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp order by Id")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("ACno").Value)
                viewlst.SubItems.Add(rs("IDnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Title").Value)
                viewlst.SubItems.Add(rs("Gender").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("BirthDate").Value)
                viewlst.SubItems.Add(rs("HiredDay").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Findfill()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        On Error Resume Next

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("ACno").Value)
                viewlst.SubItems.Add(rs("IDnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Title").Value)
                viewlst.SubItems.Add(rs("Gender").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("BirthDate").Value)
                viewlst.SubItems.Add(rs("HiredDay").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function picView() As Bitmap
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select PicPath from tblEmp where idNumber = '" & id & "'")
            If rs.EOF = False Then
                Try
                    Dim Img As New IO.MemoryStream(CType(rs("PicPath").Value, Byte()))
                    Return Image.FromStream(Img)
                Catch ex As Exception
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            Return Nothing
        End Try
    End Function

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(1).Text
            End If
        Next
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slct()
        EmpPic.Image = picView()
        'frmNewEmployee.EmpPic.Image = picView()
        enableCmd(Me)
    End Sub


    Private Sub txtInput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmdEdit.Enabled = False

        'EmpPic.Image = Nothing
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            LstEmpRec.Clear()
            header()
            Findfill()
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub edit(ByVal acc As String)
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp where AcNo = '" & acc & "'")
        If rs.EOF = False Then
            With frmAddCard
                On Error Resume Next
                .txtAccNo.Text = rs("AcNo").Value
                .txtIdnumber.Text = rs("IDnumber").Value
                .txtName.Text = rs("Name").Value
                .txtTitle.Text = rs("Title").Value
                .txtGender.Text = rs("Gender").Value
                .txtContact.Text = rs("ContactNo").Value
                .txtAddress.Text = rs("Address").Value
                .dtBdate.Value = rs("BirthDate").Value
                .dtHiredDate.Value = rs("HiredDate").Value
                .EmpPic.Image = Get_PicEmp(acc)
                .Text = " Update Employee"
                .ShowDialog()
            End With
        End If
    End Sub

    Sub del(ByVal AC As String)
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs2 As New Recordset
        rs2 = New Recordset
        rs2 = conSql.Execute("delete from tblEmp where Acno = '" & AC & "'")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmAddList.ShowDialog()
    End Sub

    Private Sub cboCateg_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
    End Sub

    Private Sub cmdEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                edit(viewlst.SubItems(1).Text)
            End If
        Next
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                EmpPic.Image = Get_PicEmp(viewlst.SubItems(2).Text)
            End If
        Next
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record?     ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In LstEmpRec.Items
                If viewlst.Selected = True Then
                    del(viewlst.SubItems(1).Text)
                    LstEmpRec.Clear()
                    header()
                    fill()
                End If
            Next
        End If
    End Sub

    Private Sub cmdBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBlock.Click
        If MsgBox("Are you sure do you want to block this card?     ", vbYesNo + vbQuestion + vbDefaultButton2, "Block") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In LstEmpRec.Items
                If viewlst.Selected = True Then
                    BlockedCard(viewlst.SubItems(1).Text)
                    LstEmpRec.Clear()
                    header()
                    fill()
                End If
            Next
        End If
    End Sub

    Private Sub cmdUnblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnblock.Click
        If MsgBox("Are you sure do you want to unblock this card?     ", vbYesNo + vbQuestion + vbDefaultButton2, "Unblock") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In LstEmpRec.Items
                If viewlst.Selected = True Then
                    UnblockedCard(viewlst.SubItems(1).Text)
                    LstEmpRec.Clear()
                    header()
                    fill()
                End If
            Next
        End If
    End Sub

    Private Sub cmdUpdExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdExp.Click

        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then

                With frmUpdateExp
                    .txtAcno.Text = viewlst.SubItems(1).Text
                    .txtDtExp.Text = viewlst.SubItems(8).Text
                    .ShowDialog()
                End With

            End If
        Next

    End Sub

    Private Sub cmdSearch_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub txtInput_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            LstEmpRec.Clear()
            header()
            Findfill()
        End If
    End Sub

End Class