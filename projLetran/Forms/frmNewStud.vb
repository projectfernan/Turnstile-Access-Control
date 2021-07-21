Imports ADODB
Public Class frmNewStud
    Public image_stud As String
    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        IDNumber = txtAC.Text
        If flag = "Save" Then
            save()
        ElseIf flag = "Edit" Then
            edit()
        End If
    End Sub
    Sub save()
        If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then

            If image_stud = vbNullString Then
                image_stud = Application.StartupPath & "\Nopic.jpg"
            End If

            If conServer() = True Then
                Dim rs As New Recordset
                rs = New Recordset
                rs.Open("select * from tblStudInfo", conSql, 1, 2)
                rs.AddNew()
                rs("ACnumber").Value = txtAC.Text
                rs("IDnumber").Value = txtId.Text
                rs("Name").Value = txtName.Text
                rs("GradeYear").Value = txtGy.Text
                rs("Section").Value = txtSec.Text
                rs("BirthDate").Value = dtBdate.Text
                rs("Address").Value = txtAdd.Text
                rs("Guardian").Value = txtGuardian.Text
                rs("ContactNo").Value = txtContact.Text
                Dim strem As New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(image_stud)
                rs("Pic").Value = strem.Read
                rs.Update()

                MsgBox("New record save!    ", vbInformation, "Save")
                Me.Close()
            Else
                MsgBox("Database disconnected!    ", vbExclamation, "Save")
                frmConDB.ShowDialog()
                Exit Sub
            End If
        End If
    End Sub
    Sub edit()
        If MsgBox("Are you sure do you want to save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
           
            If image_stud = vbNullString Then
                If conServer() = True Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs.Open("select * from tblStudInfo where ACnumber = '" & txtAC.Text & "'", conSql, 1, 2)
                    rs("IDnumber").Value = txtId.Text
                    rs("Name").Value = txtName.Text
                    rs("GradeYear").Value = txtGy.Text
                    rs("Section").Value = txtSec.Text
                    rs("BirthDate").Value = dtBdate.Text
                    rs("Address").Value = txtAdd.Text
                    rs("Guardian").Value = txtGuardian.Text
                    rs("ContactNo").Value = txtContact.Text
                    rs.Update()
                    MsgBox("Updated successfully!    ", vbInformation, "Update")
                    txtAC.ReadOnly = False
                    Me.Close()
                Else
                    MsgBox("Database disconnected!    ", vbExclamation, "Update")
                    frmConDB.ShowDialog()
                    Exit Sub
                End If
            Else
                If conServer() = True Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs.Open("select * from tblStudInfo where ACnumber = '" & txtAC.Text & "'", conSql, 1, 2)
                    rs("IDnumber").Value = txtId.Text
                    rs("Name").Value = txtName.Text
                    rs("GradeYear").Value = txtGy.Text
                    rs("Section").Value = txtSec.Text
                    rs("BirthDate").Value = dtBdate.Text
                    rs("Address").Value = txtAdd.Text
                    rs("Guardian").Value = txtGuardian.Text
                    rs("ContactNo").Value = txtContact.Text
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(image_stud)
                    rs("Pic").Value = strem.Read
                    rs.Update()
                    MsgBox("Updated successfully!    ", vbInformation, "Update")
                    txtAC.ReadOnly = False
                    Me.Close()
                Else
                    MsgBox("Database disconnected!    ", vbExclamation, "Update")
                    frmConDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_stud = vbNullString
            image_stud = OpenPath.FileName
        End If

        If image_stud = vbNullString Then Exit Sub
        EmpPic.Image = Image.FromFile(image_stud)
    End Sub
    Private Sub DevEnroller_OnAttTransaction(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles DevEnroller.OnAttTransaction
        If scan(e.enrollNumber) = True Then
            Exit Sub
        End If

        With frmCardNo
            .lblAcc.Text = e.enrollNumber
            .ShowDialog()
        End With

    End Sub

    Private Sub tmrRegEvent_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRegEvent.Tick
        DevEnroller.RegEvent(1, 32767)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        devconn()
    End Sub
    Sub devconn()
        If txtip.Text = vbNullString Then
            MsgBox("Please enter device IP address!    ", vbExclamation, "Connection")
            Exit Sub
        End If
        If Button1.Text = "&Connect" Then
            DevEnroller.Disconnect()
            DevEnroller.BeginInit()
            If PingMe(txtip.Text) = True Then
                If DevEnroller.Connect_Net(txtip.Text, 4370) Then
                    MsgBox("Device connected!    ", vbInformation, "Connection")
                    txtip.ReadOnly = True
                    My.Settings.DEV_Enroller = txtip.Text
                    My.Settings.Save()
                    'tmrRegEvent.Enabled = True
                    DevEnroller.RegEvent(1, 32767)
                    Button1.Text = "&Disconnect"
                    'lblFlag.ForeColor = Color.Green
                    'lblFlag.Visible = True
                Else
                    MsgBox("Failed to connect!    ", vbExclamation, "Connection")
                End If
            Else
                MsgBox("Failed to connect!    ", vbExclamation, "Connection")
            End If
        ElseIf Button1.Text = "&Disconnect" Then
            DevEnroller.EndInit()
            DevEnroller.Disconnect()
            tmrRegEvent.Enabled = False
            Button1.Text = "&Connect"
            txtip.ReadOnly = False
            'lblFlag.Visible = False
        End If
    End Sub

    Private Sub frmNewEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmStudent.cmdEdit.Enabled = False
        frmStudent.cmdDel.Enabled = False
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtip.Text = My.Settings.DEV_Enroller

        lstItem.Clear()
        headerItm(lstItem)
        fillItems(lstItem, txtId.Text)

        LstFetcher.Clear()
        headerF(LstFetcher)
        fillfetcher(LstFetcher, txtId.Text)

        If txtFetchAC.Text = vbNullString Then
            cmdFetchDisable()
        Else
            cmdFetchEnable()
        End If
    End Sub

    Sub Gy(ByVal cbo As ComboBox)

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblgradeyear")

        If rs.EOF = True Then
            MsgBox("Please set grade/year level!    ", vbExclamation, Me.Text)
            frmEduLevel.ShowDialog()
            Exit Sub
        End If

        While rs.EOF = False
            cbo.Items.Add(rs("GradeYear").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub Sec(ByVal cbo As ComboBox)

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblsection")

        If rs.EOF = True Then
            MsgBox("Please set section!    ", vbExclamation, Me.Text)
            frmEduLevel.ShowDialog()
            Exit Sub
        End If

        While rs.EOF = False
            cbo.Items.Add(rs("Section").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Function scan(ByVal idNO As String) As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblStudInfo where idnumber = '" & idNO & "'")
        If rs.EOF = False Then
            MsgBox("ID number already exist!    ", vbCritical, "ID Number")
            Return True
        Else
            Return False
        End If
        Exit Function
    End Function

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGy.Focus()
        End If
    End Sub

    Private Sub txtPosition_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtSec.Focus()
        End If
    End Sub

    Private Sub txtSec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtAdd.Focus()
        End If
    End Sub

    Private Sub txtSSS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuardian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtContact.Focus()
        End If
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Len(txtContact.Text) = 0 And Asc(e.KeyChar) = 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            IDNumber = txtId.Text
            If flag = "Save" Then
                save()
            ElseIf flag = "Edit" Then
                edit()
            End If
        End If

    End Sub

    Private Sub txtTin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'cboDept.Focus()
        End If
    End Sub

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If Len(txtContact.Text) = 0 And Asc(e.KeyChar) = 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            txtName.Focus()
        End If
    End Sub

    Private Sub txtAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGuardian.Focus()
        End If
    End Sub

    Private Sub txtAC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAC.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            txtId.Focus()
        End If
    End Sub

    Sub addFetcher()
        With frmAddFetcher
            .Text = "Add Fetcher"
            .imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            .txtName.Text = vbNullString
            .txtPosition.Text = vbNullString
            .txtName.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtId.Text = vbNullString Then
            MsgBox("Please enter id number!    ", vbExclamation, "Add Fetcher")
            Exit Sub
        End If

        If LstFetcher.Items.Count = 6 Then
            MsgBox("You reach maximum fetchers to be add!    ", vbExclamation, "Add Fetcher")
            Exit Sub
        End If

        addFetcher()
    End Sub

    Sub EditFetch()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstFetcher.Items
            If viewlst.Selected = True Then
                With frmAddFetcher
                    .Text = "Update Fetcher"
                    fetchID = vbNullString
                    fetchID = viewlst.SubItems(2).Text
                    .txtName.Text = viewlst.SubItems(0).Text
                    .txtPosition.Text = viewlst.SubItems(1).Text
                    .txtName.Focus()
                    .ShowDialog()
                End With
            End If
        Next
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        EditFetch()
    End Sub

    Private Sub LstFetcher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFetcher.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstFetcher.Items
            If viewlst.Selected = True Then
                imgFetch.Image = FetcherPic(viewlst.SubItems(2).Text)
                frmAddFetcher.imgFetch.Image = FetcherPic(viewlst.SubItems(2).Text)
            End If
        Next
    End Sub

    Sub delFetch(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Delete")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("delete from tblfetcher where Id = '" & id & "'")
            MsgBox("Fetcher successfully deleted!    ", vbInformation, "Delete")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try

    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click

        Dim viewlst As New ListViewItem
        For Each viewlst In LstFetcher.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this fetcher?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    delFetch(viewlst.SubItems(2).Text)
                    LstFetcher.Clear()
                    headerF(LstFetcher)
                    fillfetcher(LstFetcher, txtId.Text)
                    imgFetch.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End If
            End If
        Next

    End Sub

    Private Sub txtGy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGy.Click
        Gy(txtGy)
    End Sub

    Private Sub txtSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSec.Click
        Sec(txtSec)
    End Sub

    Private Sub txtGy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGy.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtSec_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSec.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub addItem()
        With frmAddItem
            .Text = "Add Item"
            .txtCardCode.Text = vbNullString
            .txtItemName.Text = vbNullString
            .txtModel.Text = vbNullString
            .txtSerial.Text = vbNullString
            .cboCateg.Text = vbNullString
            .txtCardCode.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdAddItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddItm.Click
        If txtId.Text = vbNullString Then
            MsgBox("Please enter id number!    ", vbExclamation, "Add Fetcher")
            Exit Sub
        End If

        addItem()
    End Sub

    Sub EditItem()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstItem.Items
            If viewlst.Selected = True Then
                With frmAddItem
                    .Text = "Update Item"
                    .txtCardCode.Text = viewlst.SubItems(1).Text
                    .txtItemName.Text = viewlst.SubItems(2).Text
                    .txtSerial.Text = viewlst.SubItems(3).Text
                    .txtModel.Text = viewlst.SubItems(4).Text
                    .cboCateg.Text = viewlst.SubItems(5).Text
                    .ShowDialog()
                End With
            End If
        Next
    End Sub

    Private Sub cmdEditItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditItm.Click
        EditItem()
    End Sub

    Sub delitem(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Delete")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("delete from tblitems where CardCode = '" & id & "'")
            MsgBox("Item successfully deleted!    ", vbInformation, "Delete")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try

    End Sub

    Private Sub cmdDelItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelItm.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstItem.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this fetcher?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    delitem(viewlst.SubItems(1).Text)
                    lstItem.Clear()
                    headerItm(lstItem)
                    fillItems(lstItem, txtId.Text)
                End If
            End If
        Next
    End Sub

    Private Sub txtGy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtGy.SelectedIndexChanged

    End Sub
End Class