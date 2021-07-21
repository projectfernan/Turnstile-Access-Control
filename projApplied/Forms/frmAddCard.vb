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

    Sub save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblemp", conSql, 1, 2)
        rs.AddNew()
        rs("ACno").Value = txtAccNo.Text
        rs("IDnumber").Value = txtIdnumber.Text
        rs("Name").Value = txtname.Text
        rs("Title").Value = txtTitle.Text
        rs("Gender").Value = txtGender.Text
        rs("ContactNo").Value = txtContact.Text
        rs("Address").Value = txtAddress.Text
        rs("BirthDate").Value = dtBdate.Value
        rs("HiredDay").Value = dtHiredDate.Value
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
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblemp where AcNo = '" & Acc & "'", conSql, 1, 2)
        rs("IDnumber").Value = txtIdnumber.Text
        rs("Name").Value = txtName.Text
        rs("Title").Value = txtTitle.Text
        rs("Gender").Value = txtGender.Text
        rs("ContactNo").Value = txtContact.Text
        rs("Address").Value = txtAddress.Text
        rs("BirthDate").Value = dtBdate.Value
        rs("HiredDay").Value = dtHiredDate.Value
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
    End Sub

    Function chkFilds() As Boolean
        If txtAccNo.Text = vbNullString Or txtIdnumber.Text = vbNullString Or txtName.Text = vbNullString Or txtTitle.Text = vbNullString Or txtGender.Text = vbNullString Or txtContact.Text = vbNullString Or txtAddress.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
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
                    updateRec(txtAccNo.Text)
                End If
        End Select
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
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
End Class