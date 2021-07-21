Imports ADODB
Public Class frmStudent
    Public id As String
    Public delPic As String
    Public delpath As String

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        flag = "Save"
        With frmNewStud
            .Text = "New Student"
            ClearTextBox(frmNewStud)
            .txtGy.Text = vbNullString
            .txtSec.Text = vbNullString
            .txtAC.ReadOnly = False
            .txtId.ReadOnly = False
            .GroupBox1.Enabled = True
            .cmdSubmit.Text = "&Save    "

            .txtip.Enabled = True
            .EmpPic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            .imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            .txtip.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        LstEmpRec.Clear()
        header()
        fill()

        lstFetcher.Clear()
        headerF(lstFetcher)

        lstItem.Clear()
        headerItm(lstItem)

        imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")

        disableCmd(Me)
        cmdSearch.Enabled = True
        cmdAdd.Enabled = True
        cmdRefresh.Enabled = True
    End Sub

    Sub header()
        LstEmpRec.Columns.Add("AC Number", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ID Number", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
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
                viewlst.SubItems.Add(rs("Name").Value)
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
                viewlst.SubItems.Add(rs("Name").Value)
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
  
    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                imgStud.Image = StudentPic(viewlst.SubItems(1).Text)
                frmNewStud.EmpPic.Image = StudentPic(viewlst.SubItems(1).Text)

                lstItem.Clear()
                headerItm(lstItem)
                fillItems(lstItem, viewlst.SubItems(1).Text)

                lstFetcher.Clear()
                headerF(lstFetcher)
                fillfetcher(lstFetcher, viewlst.SubItems(1).Text)
                enableCmd(Me)

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

    Private Sub txtInput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        imgStud.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
    End Sub

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            LstEmpRec.Clear()
            header()
            Findfill()
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                edit(viewlst.SubItems(0).Text)

                flag = "Edit"
                With frmNewStud
                    .Text = "Update Student Information"
                    'fillfetcher(.LstFetcher, viewlst.SubItems(1).Text)
                    enableTxt(frmNewStud)
                    .txtFetchAC.Text = fetcherAcNo(viewlst.SubItems(1).Text)
                    .imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    .cmdBrowse.Enabled = True
                    .cmdSubmit.Enabled = True
                    .cmdSubmit.Text = "&Update  "
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
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblstudInfo where ACNumber = '" & acNo & "'")
        If rs.EOF = False Then
            frmNewStud.txtAC.Text = rs("ACnumber").Value
            frmNewStud.txtId.Text = rs("IDnumber").Value
            frmNewStud.txtName.Text = rs("Name").Value
            frmNewStud.txtGy.Text = rs("GradeYear").Value
            frmNewStud.txtSec.Text = rs("Section").Value
            frmNewStud.dtBdate.Text = rs("BirthDate").Value
            frmNewStud.txtAdd.Text = rs("Address").Value
            frmNewStud.txtGuardian.Text = rs("Guardian").Value
            frmNewStud.txtContact.Text = rs("ContactNo").Value
        End If
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

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
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

    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        frmImport.ShowDialog()
    End Sub
    
    Private Sub lstFetcher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFetcher.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstFetcher.Items
            If viewlst.Selected = True Then
                imgFetch.Image = FetcherPic(viewlst.SubItems(2).Text)
            End If
        Next
    End Sub

    Private Sub cmdSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub txtInput_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInput.GotFocus
        imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        lstFetcher.Clear()
        headerF(lstFetcher)
        lstItem.Clear()
        headerItm(lstItem)
    End Sub

    Private Sub txtInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click_1(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub cboCateg_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
        imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        lstFetcher.Clear()
        headerF(lstFetcher)
        lstItem.Clear()
        headerItm(lstItem)
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Private Sub cboCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.Click

    End Sub

    Private Sub txtInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.Click

    End Sub
End Class
