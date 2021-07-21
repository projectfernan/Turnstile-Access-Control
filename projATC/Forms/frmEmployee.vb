Imports ADODB
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Threading
Public Class frmEmployee
    Public id As String
    Public delPic As String

    Private Delegate Sub FillDel()
    Private Delegate Sub FindDel()

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
        '  fill()
    End Sub

    Sub header()
        LstEmpRec.Columns.Add("Id", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("CardCode", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IDNumber", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Title", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Gender", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ContactNo", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("BirthDate", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("HiredDay", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("CardType", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("AccessStatus", 150, HorizontalAlignment.Left)
    End Sub

    Sub updateZero(ByVal cadCode As String)
        'If subSQl() = False Then
        '    MsgBox("Please connect to server!    ", vbExclamation, "Server")
        '    Exit Sub
        'End If

        Dim trimCode As String = cadCode

        Dim Zero1 As String = Mid(trimCode, 1, 1)
        Dim Zero2 As String = Mid(trimCode, 2, 1)
        Dim Zero3 As String = Mid(trimCode, 3, 1)

        Dim chkZero1 As String = Replace(Zero1, "0", vbNullString)
        Dim chkZero3 As String = Replace(Zero3, "0", vbNullString)

        Dim strLast As String = Mid(trimCode, 4)
        'Dim strRemoveZer0 As String = Replace(, "0", vbNullString)
        Dim NoZeroCode As String = chkZero1 & Zero2 & chkZero3 & strLast

        'Dim NoZeroCode As String = Replace(cadCode, "0", vbNullString)

        Dim rs As New Recordset

        rs = New Recordset
        rs = conSql.Execute("update tblemp set ACno = '" & NoZeroCode & "' where ACno = '" & cadCode & "'")

    End Sub

    Sub fill()
        If (InvokeRequired) Then
            Invoke(New FillDel(AddressOf fill))

        Else
            If subSQl() = False Then
                MsgBox("Please connect to server!    ", vbExclamation, "Server")
                Exit Sub
            End If
            On Error Resume Next

            txtRecordCount.Text = 0
            totalRecord.Text = 0
            Loadbar.Maximum = 0
            Loadbar.Value = 0

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSql.Execute("select * from vweempinfo order by Id")
            If rs.EOF = False Then
                Loadbar.Maximum = rs.RecordCount
                totalRecord.Text = rs.RecordCount
                For lup = 1 To rs.RecordCount
                    txtRecordCount.Text = lup
                    Loadbar.Value = lup

                    'updateZero(rs("CardCode").Value)
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rs("Id").Value, lup)
                    viewlst.SubItems.Add(rs("CardCode").Value)
                    viewlst.SubItems.Add(rs("IDnumber").Value)
                    viewlst.SubItems.Add(rs("Name").Value)
                    viewlst.SubItems.Add(rs("Title").Value)
                    viewlst.SubItems.Add(rs("Gender").Value)
                    viewlst.SubItems.Add(rs("ContactNo").Value)
                    viewlst.SubItems.Add(rs("Address").Value)
                    viewlst.SubItems.Add(rs("BirthDate").Value)
                    viewlst.SubItems.Add(rs("HiredDay").Value)
                    viewlst.SubItems.Add(rs("CardType").Value)
                    If rs("AccessStatus").Value = 1 Then
                        viewlst.SubItems.Add("Access")
                    Else
                        viewlst.SubItems.Add("Blocked")
                    End If
                    rs.MoveNext()
                Next
            End If
        End If
    End Sub

    Sub Findfill()

        If (InvokeRequired) Then
            Invoke(New FindDel(AddressOf Findfill))

        Else
            If subSQl() = False Then
                MsgBox("Please connect to server!    ", vbExclamation, "Server")
                Exit Sub
            End If
            On Error Resume Next

            txtRecordCount.Text = 0
            totalRecord.Text = 0
            Loadbar.Maximum = 0
            Loadbar.Value = 0

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSql.Execute("select * from vweempinfo where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
            If rs.EOF = False Then
                Loadbar.Maximum = rs.RecordCount
                totalRecord.Text = rs.RecordCount
                For lup = 1 To rs.RecordCount
                    txtRecordCount.Text = lup
                    Loadbar.Value = lup

                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rs("Id").Value, lup)
                    viewlst.SubItems.Add(rs("CardCode").Value)
                    viewlst.SubItems.Add(rs("IDnumber").Value)
                    viewlst.SubItems.Add(rs("Name").Value)
                    viewlst.SubItems.Add(rs("Title").Value)
                    viewlst.SubItems.Add(rs("Gender").Value)
                    viewlst.SubItems.Add(rs("ContactNo").Value)
                    viewlst.SubItems.Add(rs("Address").Value)
                    viewlst.SubItems.Add(rs("BirthDate").Value)
                    viewlst.SubItems.Add(rs("HiredDay").Value)
                    viewlst.SubItems.Add(rs("CardType").Value)
                    If rs("AccessStatus").Value = 1 Then
                        viewlst.SubItems.Add("Access")
                    Else
                        viewlst.SubItems.Add("Blocked")
                    End If
                    rs.MoveNext()
                Next
            End If
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
            strUpdateCode = rs("ACno").Value
            With frmAddCard
                On Error Resume Next

                .txtAccNo.Text = rs("AcNo").Value
                .txtIdnumber.Text = rs("IDnumber").Value
                .txtName.Text = rs("Name").Value
                .txtTitle.Text = rs("Title").Value
                .txtGender.Text = rs("Gender").Value
                .txtContact.Text = rs("ContactNo").Value
                .txtAddress.Text = rs("Address").Value
                .cboCardType.Text = rs("CardType").Value
                .dtBdate.Value = rs("BirthDate").Value
                .dtHiredDate.Value = rs("HiredDate").Value
                .EmpPic.Image = Get_PicEmp(acc)
                .Text = " Update Employee"
                .tmeRead.Enabled = True
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
        With frmAddCard
            .txtAccNo.Text = "00000000"
            .txtIdnumber.Text = vbNullString
            .txtName.Text = vbNullString
            .txtTitle.Text = vbNullString
            .txtGender.Text = vbNullString
            .txtContact.Text = vbNullString
            .txtAddress.Text = vbNullString
            .dtBdate.Value = Now
            .dtHiredDate.Value = Now
            .Text = " New Employee"
            .tmeRead.Enabled = True
            .ShowDialog()
          
        End With
    End Sub

    Private Sub cboCateg_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        ' fill()
        Dim th As New Thread(New ThreadStart(Sub() fill()))
        th.Start()

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
        'Findfill()
        Dim th As New Thread(New ThreadStart(Sub() Findfill()))
        th.Start()
    End Sub

    Private Sub txtInput_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            LstEmpRec.Clear()
            header()
            Dim th As New Thread(New ThreadStart(Sub() Findfill()))
            th.Start()
        End If
    End Sub

    Private Sub cmdExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportExcel.Click
        On Error Resume Next
        Savefile.Filter = "Excel File (*.slsx,*.slsx)|*.xlsx;*.xlsx"
        Savefile.InitialDirectory = "C:\"
        Savefile.FileName = vbNullString

        If Savefile.ShowDialog = Windows.Forms.DialogResult.OK Then

            pathFrm = vbNullString
            pathFrm = Savefile.FileName
        End If


        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range

        appXL = New Excel.ApplicationClass

        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet

        With shXL.Range("A1:XFD1")
            .Font.Bold = True
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        With shXL.Range("B1:B1048576")
            .NumberFormat = "@"
        End With


        shXL.Cells(1, 1).Value = "ID"
        shXL.Cells(1, 2).Value = "CardCode"
        shXL.Cells(1, 3).Value = "IDnumber"
        shXL.Cells(1, 4).Value = "Name"
        shXL.Cells(1, 5).Value = "Title"
        shXL.Cells(1, 6).Value = "Gender"
        shXL.Cells(1, 7).Value = "ContactNo"
        shXL.Cells(1, 8).Value = "Address"
        shXL.Cells(1, 9).Value = "BitrthDate"
        shXL.Cells(1, 10).Value = "HiredDay"
        shXL.Cells(1, 11).Value = "CardType"

        txtRecordCount.Text = 0
        totalRecord.Text = 0
        Loadbar.Maximum = 0
        Loadbar.Value = 0

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from vweempinfo where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            Me.Cursor = Cursors.WaitCursor
            Loadbar.Maximum = rs.RecordCount
            totalRecord.Text = rs.RecordCount

            Dim lupCount As Long = rs.RecordCount + 1
            For lup = 2 To lupCount

                txtRecordCount.Text = lup - 1
                Loadbar.Value = lup

                shXL.Cells(lup, 1).Value = rs("Id").Value
                shXL.Cells(lup, 2).Value = rs("CardCode").Value
                shXL.Cells(lup, 3).Value = rs("IDnumber").Value
                shXL.Cells(lup, 4).Value = rs("Name").Value
                shXL.Cells(lup, 5).Value = rs("Title").Value
                shXL.Cells(lup, 6).Value = rs("Gender").Value
                shXL.Cells(lup, 7).Value = rs("ContactNo").Value
                shXL.Cells(lup, 8).Value = rs("Address").Value
                shXL.Cells(lup, 9).Value = rs("BirthDate").Value
                shXL.Cells(lup, 10).Value = rs("HiredDay").Value
                shXL.Cells(lup, 11).Value = rs("CardType").Value
                rs.MoveNext()
            Next
        End If

        raXL = shXL.Range("A1", "XFD1")
        raXL.EntireColumn.AutoFit()

        shXL.SaveAs(pathFrm)

        appXL.Visible = True
        appXL.UserControl = True

        ' Release object references.
        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing

        CType(appXL, Excel._Application).Quit()

        ' appXL.Quit()
        appXL = Nothing

        Process.Start(pathFrm)

        Me.Cursor = Cursors.Default
    End Sub
End Class