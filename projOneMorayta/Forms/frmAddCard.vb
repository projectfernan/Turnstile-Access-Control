Imports System.Threading
Public Class frmAddCard
    Private Delegate Sub DelDisableEid()

    Dim recon As Boolean
    Dim devTo As String
    Private Sub frmAddCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Vtype(cboVtype)
        LoadBar.Value = 0

        lstList.Clear()
        header()
        fill()
        UnselectAll()
        listStatus.Items.Clear()

        EmpPath = vbNullString

        RoomNameList(cboRoomName)
        BedNumberList(cboBedNo, cboRoomName.Text)
        AccessGroupList(cboAccessGroup)



    End Sub

    Private Sub cboType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub Shfttype(ByVal cbo As ComboBox)

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT ShiftName from tblshifts")
        While rs.EOF = False
            cbo.Items.Add(rs("ShiftName").Value)
            rs.MoveNext()
        End While
    End Sub


    Sub Vtype(ByVal cbo As ComboBox)

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblvehicletype")
        While rs.EOF = False
            cbo.Items.Add(rs("VehicleType").Value)
            rs.MoveNext()
        End While
    End Sub

    Function chkCardCode(ByVal cCode As String) As Boolean
        If subSQl() = False Then Return True

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select ACno from tblemp where ACno = '" & cCode & "';")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function

    Sub save()
        If chkCardCode(txtAccNo.Text) = True Then
            MsgBox("Card Code Already Exist!", vbExclamation, "Card Code")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblemp", conSql, 1, 2)
        rs.AddNew()
        rs("ACno").Value = txtAccNo.Text
        rs("IDnumber").Value = txtIdnumber.Text
        rs("Name").Value = txtName.Text
        rs("Title").Value = txtTitle.Text
        rs("Gender").Value = txtGender.Text
        rs("ContactNo").Value = txtContact.Text
        rs("Address").Value = txtAddress.Text
        rs("BirthDate").Value = dtBdate.Value
        rs("RoomName").Value = cboRoomName.Text
        rs("BedNumber").Value = cboBedNo.Text
        rs("AccessGroup").Value = cboAccessGroup.Text
        rs("ExpiredDate").Value = dtExpiredDate.Value
        rs("AccessStatus").Value = 1
        If EmpPath = vbNullString Then
        Else
            Dim strem As New Stream
            strem.Type = StreamTypeEnum.adTypeBinary
            strem.Open()
            strem.LoadFromFile(EmpPath)
            rs("PicPath").Value = strem.Read
        End If
        rs.Update()
        MsgBox("Saved successfully!    ", vbInformation, "Save")

    End Sub

    Sub updateRec(ByVal Acc As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblemp where AcNo = '" & Acc & "'", conSql, 1, 2)
        rs("IDnumber").Value = txtIdnumber.Text
        rs("Name").Value = txtName.Text
        rs("Title").Value = txtTitle.Text
        rs("Gender").Value = txtGender.Text
        rs("ContactNo").Value = txtContact.Text
        rs("Address").Value = txtAddress.Text
        rs("RoomName").Value = cboRoomName.Text
        rs("BedNumber").Value = cboBedNo.Text
        rs("AccessGroup").Value = cboAccessGroup.Text
        rs("BirthDate").Value = dtBdate.Value
        rs("ExpiredDate").Value = dtExpiredDate.Value
        If EmpPath = vbNullString Then
        Else
            Dim strem As New Stream
            strem.Type = StreamTypeEnum.adTypeBinary
            strem.Open()
            strem.LoadFromFile(EmpPath)
            rs("PicPath").Value = strem.Read
        End If
        rs.Update()
        MsgBox("Successfully updated!    ", vbInformation, "Update")

    End Sub

    Function chkFilds() As Boolean
        If txtAccNo.Text = vbNullString Or txtIdnumber.Text = vbNullString Or txtName.Text = vbNullString Or txtTitle.Text = vbNullString Or txtGender.Text = vbNullString Or txtContact.Text = vbNullString Or txtAddress.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Function BlokedCards(ByVal Eid As Integer, ByVal Ip As String, ByVal devName As String) As Boolean
        Try
            With Dev

                If devTo <> devName Then
                    Dev.Disconnect()
                    recon = True
                End If

                devTo = devName

                If PingMe(Ip) = False Then
                    listStatus.Items.Add("Failed to connect to " & devTo)
                    recon = True
                    Return False
                End If

                If recon = False Then
                    Dev.EnableUser(1, Eid, 1, 0, False)
                    'listStatus.Items.Add("AC number " & Eid.ToString & " is set to anti passback feature to reader " & devName)
                    Return True
                End If

                If Dev.Connect_Net(Ip, 4370) = False Then
                    listStatus.Items.Add("Failed to connect to " & devTo)
                    recon = True
                    Return False
                Else
                    recon = False
                End If

                Dev.EnableUser(1, Eid, 1, 0, False)
                'listStatus.Items.Add("AC number " & Eid.ToString & " is set to anti passback feature to reader " & devName)
                Return True

                Return True
            End With
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function UnblokedCards(ByVal Eid As Integer, ByVal Ip As String, ByVal devName As String) As Boolean
        Try
            With Dev
                If PingMe(Ip) = False Then
                    listStatus.Items.Add("Failed to connect to " & Ip)
                    Return False
                End If

                If Dev.Connect_Net(Ip, 4370) = False Then
                    Return False
                End If

                Dev.EnableUser(1, Eid, 1, 0, True)
                listStatus.Items.Add("ACnumber " & Eid.ToString & " Anti Passback successfully set to " & "Reader " & devName)
                Return True
            End With
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub disaledAcc()
        If (InvokeRequired) Then
            Invoke(New DelDisableEid(AddressOf disaledAcc))
        Else
            Try
                listStatus.Items.Clear()
                LoadBar.Maximum = lstList.Items.Count


                Dim lod As Integer = 1
                For Each ls In lstList.Items
                    If ls.Checked = True Then
                        If BlokedCards(txtAccNo.Text, ls.SubItems(1).Text(), ls.SubItems(0).Text()) = True Then
                            listStatus.Items.Add("AC number " & txtAccNo.Text & " is set to anti passback feature to reader " & ls.SubItems(0).Text())
                        End If
                    End If
                    LoadBar.Value = lod
                    lod = lod + 1

                Next
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
       

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If tmeRead.Enabled = True Then
            MsgBox("Please scan your card! ", vbExclamation, "Save")
            Exit Sub
        End If

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If chkFilds() = True Then
            MsgBox("Please fill up the blanks! ", vbExclamation, "Save")
            Exit Sub
        End If


        Select Case Me.Text
            Case " New Resident"
                If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
                    Dim th As New Thread(New ThreadStart(Sub() disaledAcc()))
                    th.Start()
                    save()
                End If
            Case " Update Resident"
                If MsgBox("Are you sure do you want save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
                    Dim th As New Thread(New ThreadStart(Sub() disaledAcc()))
                    th.Start()
                    updateRec(txtAccNo.Text)
                End If
        End Select
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtGender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGender.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            EmpPath = OpenPath.FileName
        End If

        If EmpPath = vbNullString Then
        Else
            EmpPic.Image = Image.FromFile(EmpPath)
        End If
    End Sub

    Private Sub frmAddCard_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        EmpPath = vbNullString
    End Sub

    Private Sub tmeRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeRead.Tick
        'If d8_conn() = True Then
        '    If d8_Card() = True Then
        '        If Len(CardCod) < 10 Then
        '            Dim Crdcode As Integer = CardCod
        '            txtAccNo.Text = Crdcode + 4294967296.0#
        '        Else
        '            txtAccNo.Text = CardCod
        '        End If
        '        d8_Beep()
        '        tmeRead.Enabled = False
        '    End If
        'End If

        txtCodeInput.Focus()

    End Sub

    Private Sub cboRoomName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRoomName.Click
        RoomNameList(cboRoomName)
    End Sub

    Private Sub cboCardType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRoomName.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtCodeInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim DecCode As Long = txtCodeInput.Text
            txtAccNo.Text = Hex(DecCode)
            txtCodeInput.Text = vbNullString
            tmeRead.Enabled = False
            txtIdnumber.Focus()
            txtCodeInput.Enabled = False
        End If
    End Sub

    Sub RoomNameList(ByVal cbo As ComboBox)

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblroomname")

        If rs.EOF = True Then
            MsgBox("Please set Room Number!    ", vbExclamation, Me.Text)
            frmRoomName.ShowDialog()
            Exit Sub
        End If

        While rs.EOF = False
            cbo.Items.Add(rs("RoomName").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub BedNumberList(ByVal cbo As ComboBox, ByVal RoomNem As String)

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblbed where RoomName = '" & RoomNem & "'")

        While rs.EOF = False
            cbo.Items.Add(rs("BedNumber").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub AccessGroupList(ByVal cbo As ComboBox)

        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT AccessGroup from tblaccessgroup")

        While rs.EOF = False
            cbo.Items.Add(rs("AccessGroup").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cboBedNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBedNo.Click
        BedNumberList(cboBedNo, cboRoomName.Text)
    End Sub

    Private Sub cboAccessGroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAccessGroup.Click
        AccessGroupList(cboAccessGroup)
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        lstList.Columns.Add("DeviceName", w, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If subSQlLoc() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select DeviceName,Ip from tblDevices order by ID")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                On Error Resume Next
                lstList.Refresh()

                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("DeviceName").Value, lup)
                viewlst.SubItems.Add(rs("Ip").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub ChekAll()
        Dim ls As ListViewItem
        For Each ls In lstList.Items
            ls.Checked = True
        Next
    End Sub

    Sub UnselectAll()
        Dim ls As ListViewItem
        For Each ls In lstList.Items
            ls.Checked = False
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UnselectAll()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ChekAll()
    End Sub

    Private Sub cboBedNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBedNo.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboAccessGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboAccessGroup.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class