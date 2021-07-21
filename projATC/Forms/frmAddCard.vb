Public Class frmAddCard

    Private Sub frmAddCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Vtype(cboVtype)

        EmpPath = vbNullString
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

    Function getIDno() As Long
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select max(Id) as recCount from tblemp;")
        If rs.EOF = False Then
            Return rs("recCount").Value + 1
        Else
            Return 1
        End If
    End Function

    Sub save()
        If chkCardCode(txtAccNo.Text) = True Then
            MsgBox("Card Code Already Exist!", vbExclamation, "Card Code")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblemp where 1=0", conSql, 1, 2)
        If rs.EOF = False Then
        End If
        rs.AddNew()
        rs("ID").Value = getIDno()
        rs("ACno").Value = txtAccNo.Text
        rs("IDnumber").Value = txtIdnumber.Text
        rs("Name").Value = txtName.Text
        rs("Title").Value = txtTitle.Text
        rs("Gender").Value = txtGender.Text
        rs("ContactNo").Value = txtContact.Text
        rs("Address").Value = txtAddress.Text
        rs("CardType").Value = cboCardType.Text
        rs("BirthDate").Value = dtBdate.Value
        rs("HiredDay").Value = dtHiredDate.Value
        If cboCardType.Text = "Employee" Then
            rs("AccessStatus").Value = 1
        Else
            rs("AccessStatus").Value = 0
        End If
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
        Me.Close()
    End Sub

    Sub updateRec(ByVal Acc As String)

        tmeRead.Enabled = False
        If chkCardCode(txtAccNo.Text) = True Then
            If Acc = txtAccNo.Text Then
            Else
                MsgBox("Card Code Already Exist!", vbExclamation, "Card Code")
                Exit Sub
            End If
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblemp where AcNo = '" & Acc & "'", conSql, , 2)
            If rs.EOF = False Then

                rs("ACno").Value = txtAccNo.Text
                rs("IDnumber").Value = txtIdnumber.Text
                rs("Name").Value = txtName.Text
                rs("Title").Value = txtTitle.Text
                rs("Gender").Value = txtGender.Text
                rs("ContactNo").Value = txtContact.Text
                rs("Address").Value = txtAddress.Text
                rs("CardType").Value = cboCardType.Text
                rs("BirthDate").Value = dtBdate.Value
                rs("HiredDay").Value = dtHiredDate.Value

                If cboCardType.Text = "Employee" Then
                    rs("AccessStatus").Value = 1
                Else
                    rs("AccessStatus").Value = 0
                End If

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
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try

    End Sub

    Function chkFilds() As Boolean
        If txtAccNo.Text = vbNullString Or txtIdnumber.Text = vbNullString Or txtName.Text = vbNullString Or txtTitle.Text = vbNullString Or txtGender.Text = vbNullString Or txtContact.Text = vbNullString Or txtAddress.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If tmeRead.Enabled = True Then
            If Me.Text = " New Employee" Then
                MsgBox("Please scan your card! ", vbExclamation, "Save")
                Exit Sub
            End If
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
            Case " New Employee"
                If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
                    save()
                End If
            Case " Update Employee"
                If MsgBox("Are you sure do you want save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
                    updateRec(strUpdateCode)
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

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
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

    Private Sub frmAddCard_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        EmpPath = vbNullString
    End Sub

    Private Sub tmeRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeRead.Tick
        If d8_conn() = True Then
            Select Case My.Settings.HexRead
                Case False
                    If d8_Card() = True Then
                        If Len(CardCod) < 10 Then
                            Dim Crdcode As Integer = CardCod
                            txtAccNo.Text = Crdcode + 4294967296.0#
                        Else
                            txtAccNo.Text = CardCod
                        End If
                        d8_Beep()
                        tmeRead.Enabled = False
                    End If
                Case True

                    If d8_Card() = False Then Exit Sub

                    Dim strCodeHex As String
                    strCodeHex = Hex(CardCod)
                    Dim trimCode As String

                    trimCode = Mid(strCodeHex, 3)

                    If Len(trimCode) < 6 Then
                        trimCode = Mid(strCodeHex, 2)
                    End If

                    txtAccNo.Text = trimCode

                    d8_Beep()
                    tmeRead.Enabled = False
            End Select

        End If
    End Sub

    Private Sub cboCardType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCardType.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class