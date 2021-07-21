Public Class frmAddStud
    Public image_stud As String

    Private Sub frmAddStud_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Sub EduLv(cbo As ComboBox)
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbledulevel")

            cbo.Items.Clear()
            cbo.Items.Add("Employee")
            Do While rs.EOF = False
                cbo.Items.Add(rs("EducationLevel").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub Gy(ByVal Edulv As String, cbo As ComboBox)
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New ADODB.Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblGradeYear where EducationLevel = '" & Edulv & "'")

            cbo.Items.Clear()
            cbo.Items.Add("Employee")
            Do While rs.EOF = False
                cbo.Items.Add(rs("GradeYear").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Sub sec(ByVal gy As String, cbo As ComboBox)
        Try
            Dim rs As New ADODB.Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblSection where GradeYear = '" & gy & "'")

            cbo.Items.Clear()
            cbo.Items.Add("Employee")
            Do While rs.EOF = False
                cbo.Items.Add(rs("Section").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
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

    Function FieldEmpty() As Boolean
        If txtAC.Text = vbNullString Or _
            txtId.Text = vbNullString Or _
            txtName.Text = vbNullString Or _
            txtGender.Text = vbNullString Or _
            txtGy.Text = vbNullString Or _
            txtSec.Text = vbNullString Or _
            dtBdate.Text = vbNullString Or _
            txtAdd.Text = vbNullString Or _
            txtGuardian.Text = vbNullString Or _
            txtContact.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdCon_Click(sender As System.Object, e As System.EventArgs) Handles cmdCon.Click
        If FieldEmpty() = True Then
            MsgBox("Please fill up the blanks! ", vbExclamation, "Save")
            Exit Sub
        End If

        IDNumber = txtAC.Text
        If flag = "Save" Then
            save()
        ElseIf flag = "Edit" Then
            edit()
        End If
    End Sub

    Sub save()
        If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then

            If conServer() = True Then
                Dim rs As New Recordset
                rs = New Recordset
                rs.Open("select * from tblStudInfo", conSql, 1, 2)
                rs.AddNew()
                rs("ACnumber").Value = txtAC.Text
                rs("IDnumber").Value = txtId.Text
                rs("Name").Value = txtName.Text
                rs("Course").Value = txtCourse.Text
                rs("Gender").Value = txtGender.Text
                rs("GradeYear").Value = txtGy.Text
                rs("Section").Value = txtSec.Text
                rs("BirthDate").Value = dtBdate.Text
                rs("Address").Value = txtAdd.Text
                rs("Guardian").Value = txtGuardian.Text
                rs("ContactNo").Value = txtContact.Text

                If image_stud IsNot vbNullString Then
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(image_stud)
                    rs("Pic").Value = strem.Read
                End If

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
                    rs("Course").Value = txtCourse.Text
                    rs("Gender").Value = txtGender.Text
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
                    rs("Gender").Value = txtGender.Text
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

    Private Sub frmAddStud_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If flag = "Save" Then
            txtGuardian.Focus()
        End If
    End Sub

    Private Sub cboEduLv_GotFocus(sender As Object, e As System.EventArgs) Handles cboEduLv.GotFocus
        EduLv(cboEduLv)
    End Sub

    Private Sub txtGy_GotFocus(sender As Object, e As System.EventArgs) Handles txtGy.GotFocus
        Gy(cboEduLv.Text, txtGy)
    End Sub

    Private Sub txtSec_GotFocus1(sender As Object, e As System.EventArgs) Handles txtSec.GotFocus
        sec(txtGy.Text, txtSec)
    End Sub

    Private Sub txtGy_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGy.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtSec_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSec.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboEduLv_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboEduLv.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class