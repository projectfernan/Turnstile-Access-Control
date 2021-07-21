Public Class frmAddStud
    Public image_stud As String
    Public Idrec As Long

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

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs)
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_stud = vbNullString
            image_stud = OpenPath.FileName
        End If

        If image_stud = vbNullString Then Exit Sub
        '  EmpPic.Image = Image.FromFile(image_stud)
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
                Dim strBday As String = Format(CDate(dtBdate.Value), "yyyy-MM-dd")
                Dim strYE As String = Format(CDate(dtYearEnd.Value), "yyyy-MM-dd")

                Dim rs As New Recordset
                rs = New Recordset
                rs = conSql.Execute("insert into tblstudinfo(ACnumber,IDnumber,Name,Course,Gender,EduLevel,GradeYear,Section,BirthDate,Address,Guardian,ContactNo,YearEnd,CardStatus)VALUES('" & _
                                  txtAC.Text & "','" & _
                                  txtId.Text & "','" & _
                                  txtName.Text & "','" & _
                                  txtCourse.Text & "','" & _
                                  txtGender.Text & "','" & _
                                  cboEduLv.Text & "','" & _
                                  txtGy.Text & "','" & _
                                  txtSec.Text & "','" & _
                                  strBday & "','" & _
                                  txtAdd.Text & "','" & _
                                  txtGuardian.Text & "','" & _
                                  txtContact.Text & "','" & _
                                  strYE & "'," & 1 & ")")
                'rs.Open("select * from tblStudInfo where 1=0", conSql, 1, 2)
                'rs.AddNew()
                'rs("ACnumber").Value = txtAC.Text
                'rs("IDnumber").Value = txtId.Text
                'rs("Name").Value = txtName.Text
                'rs("Course").Value = txtCourse.Text
                'rs("Gender").Value = txtGender.Text
                'rs("EduLevel").Value = cboEduLv.Text
                'rs("GradeYear").Value = txtGy.Text
                'rs("Section").Value = txtSec.Text
                'rs("BirthDate").Value = dtBdate.Text
                'rs("Address").Value = txtAdd.Text
                'rs("Guardian").Value = txtGuardian.Text
                'rs("ContactNo").Value = txtContact.Text
                'rs("YearEnd").Value = dtYearEnd.Text
                'rs("CardStatus").Value = 1

                'If image_stud IsNot vbNullString Then
                '    Dim strem As New Stream
                '  strem.Type = StreamTypeEnum.adTypeBinary
                '    strem.Open()
                '    strem.LoadFromFile(image_stud)
                '   rs("Pic").Value = strem.Read
                'End If

                'rs.Update()

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

            'If image_stud = vbNullString Then
            If conServer() = True Then
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSql.Execute("update tblstudinfo set ACnumber='" & txtAC.Text & "'," & _
                                    "IDnumber='" & txtId.Text & "'," & _
                                    "Name='" & txtName.Text & "'," & _
                                    "Course='" & txtCourse.Text & "'," & _
                                    "Gender='" & txtGender.Text & "'," & _
                                    "EduLevel='" & cboEduLv.Text & "'," & _
                                    "GradeYear='" & txtGy.Text & "'," & _
                                    "Section='" & txtSec.Text & "'," & _
                                    "BirthDate='" & dtBdate.Text & "'," & _
                                    "Address='" & txtAdd.Text & "'," & _
                                    "Guardian='" & txtGuardian.Text & "'," & _
                                    "ContactNo='" & txtContact.Text & "'," & _
                                    "YearEnd='" & dtYearEnd.Text & "' where Id = " & Idrec)

                'rs.Open("select * from tblStudInfo where ACnumber = '" & txtAC.Text & "'", conSql, 1, 2)
                'rs("IDnumber").Value = txtId.Text
                'rs("Name").Value = txtName.Text
                'rs("Course").Value = txtCourse.Text
                'rs("Gender").Value = txtGender.Text
                'rs("EduLevel").Value = cboEduLv.Text
                'rs("GradeYear").Value = txtGy.Text
                'rs("Section").Value = txtSec.Text
                'rs("BirthDate").Value = dtBdate.Text
                'rs("Address").Value = txtAdd.Text
                'rs("Guardian").Value = txtGuardian.Text
                'rs("ContactNo").Value = txtContact.Text
                'rs("YearEnd").Value = dtYearEnd.Text
                'rs("CardStatus").Value = 1
                'rs.Update()
                MsgBox("Updated successfully!    ", vbInformation, "Update")
                txtAC.ReadOnly = False
                Me.Close()
            Else
                MsgBox("Database disconnected!    ", vbExclamation, "Update")
                frmConDB.ShowDialog()
                Exit Sub
            End If
            'If conServer() = True Then
            '    Dim rs As New Recordset
            '    rs = New Recordset
            '    rs.Open("select * from tblStudInfo where ACnumber = '" & txtAC.Text & "'", conSql, 1, 2)
            '    rs("IDnumber").Value = txtId.Text
            '    rs("Name").Value = txtName.Text
            '    rs("Gender").Value = txtGender.Text
            '    rs("GradeYear").Value = txtGy.Text
            '    rs("Section").Value = txtSec.Text
            '    rs("BirthDate").Value = dtBdate.Text
            '    rs("Address").Value = txtAdd.Text
            '    rs("Guardian").Value = txtGuardian.Text
            '    rs("ContactNo").Value = txtContact.Text
            '    Dim strem As New Stream
            '    strem.Type = StreamTypeEnum.adTypeBinary
            '    strem.Open()
            '    strem.LoadFromFile(image_stud)
            '    rs("Pic").Value = strem.Read
            '    rs.Update()
            '    MsgBox("Updated successfully!    ", vbInformation, "Update")
            '    txtAC.ReadOnly = False
            '    Me.Close()
            'Else
            '    MsgBox("Database disconnected!    ", vbExclamation, "Update")
            '    frmConDB.ShowDialog()
            '    Exit Sub
            'End If
            'If
        End If
    End Sub

    Private Sub frmAddStud_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If flag = "Save" Then
            cmdUpdateCard.Enabled = False
        Else
            cmdUpdateCard.Enabled = True
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

    Function chkCCode(Code As String) As Boolean
        If conServer() = False Then Return True

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select ACnumber from tblstudinfo where ACnumber = '" & Code & "';")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return True
        End Try

    End Function

    Private Sub tmeRead_Tick(sender As System.Object, e As System.EventArgs) Handles tmeRead.Tick
        If d8_conn() = True Then
            If d8_Card() = True Then
                If Len(d8CardCod) < 10 Then
                    Dim Crdcode As Integer = d8CardCod
                    Dim d8cardCod2 As String = Crdcode + 4294967296.0#
                    If chkCCode(d8cardCod2) = True Then
                        MsgBox("Card code is already exist! ", vbExclamation, "Card Read")
                        Exit Sub
                    End If
                    txtAC.Text = d8cardCod2
                    txtAC.ReadOnly = True
                    txtId.Focus()
                Else
                    If chkCCode(d8CardCod) = True Then
                        MsgBox("Card code is already exist! ", vbExclamation, "Card Read")
                        Exit Sub
                    End If
                    txtAC.Text = d8CardCod
                End If
                d8_Beep()
                tmeRead.Enabled = False
                txtAC.ReadOnly = True
                txtId.Focus()
            End If
        End If
    End Sub

    Private Sub cmdUpdateCard_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdateCard.Click
        MsgBox("Please place your card to reader! ", vbInformation, "Update Card")
        tmeRead.Enabled = True
        txtAC.ReadOnly = False
        txtAC.Text = vbNullString
    End Sub
End Class