
Public Class frmImport
    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        browse()
        If txtpath.Text = vbNullString Then
            Exit Sub
        End If
        cmdSubmit.Visible = True
        cmdBrowse.Visible = False
    End Sub
    Sub browse()
        OpenPath.Filter = "Excel File (*.xls)|*.xls"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString
        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtpath.Text = OpenPath.FileName
        End If
    End Sub
    Sub import()
        On Error Resume Next
        'Try
        Dim xl As New ADODB.Connection
        Dim rs2 As Recordset
        Dim lup As Long
        Dim str As String
        lup = 0
        str = vbNullString
        xl = New ADODB.Connection
        xl.Open("provider=Microsoft.Jet.OLEDB.4.0; Data Source='" & txtpath.Text & "';Extended Properties=Excel 8.0;")

        rs2 = New Recordset
        rs2.Open("select * from [Sheet1$]", xl, 1, 2)
        ProgBar.Maximum = rs2.RecordCount

        Do While rs2.EOF = False

            Dim rs As New Recordset
            Dim rs3 As New Recordset

            rs = New Recordset
            rs.Open("select * from tblStudInfo", conSql, 1, 2)
            rs.AddNew()
            rs("ACnumber").Value = rs2.Fields(0).Value
            rs("IDnumber").Value = rs2.Fields(1).Value
            rs("Name").Value = rs2.Fields(2).Value
            rs("GradeYear").Value = rs2.Fields(3).Value
            rs("Section").Value = rs2.Fields(4).Value
            rs("Address").Value = rs2.Fields(5).Value
            rs("Guardian").Value = rs2.Fields(6).Value
            rs("ContactNo").Value = rs2.Fields(7).Value
            rs.Update()
           

            rs3 = New Recordset
            rs3.Open("select * from tblcbosec", conSql, 1, 2)
            rs3.AddNew()
            rs3("Sec").Value = rs2.Fields(4).Value
            rs3("Gy").Value = rs2.Fields(3).Value
            rs3.Update()

            lup = lup + 1
            ProgBar.Value = lup
            rs2.MoveNext()
        Loop

        MsgBox("Import successfully!    ", vbInformation, "Import")
        ProgBar.Value = 0
        txtpath.Text = vbNullString
        cmdSubmit.Visible = False
        cmdBrowse.Visible = True
        Me.Close()
        'Catch ex As Exception
        'MsgBox(ex.Message, vbCritical, "Import")
        'End Try
    End Sub
    Function config(ByVal id As String) As Boolean
        Dim rs As New Recordset
        rs = conSql.Execute("select * from tblStudInfo where IdNumber = '" & id & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frmImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        import()
    End Sub
End Class