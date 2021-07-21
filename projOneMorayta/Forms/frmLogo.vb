Public Class frmLogo

    Private Sub frmLogo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmdBrowse.Visible = True
        cmdUpdate.Visible = False
        If subSQl() = False Then
            MsgBox("Please connect to local database! ", vbExclamation, "Logo")
            frmConDB.ShowDialog()
        End If
        If chk() = False Then
            PicLogo.Image = Logo_Image()
        End If
    End Sub

    Sub BrowsePath()
        On Error Resume Next
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathFrm = vbNullString
            pathFrm = OpenPath.FileName
        End If

        PicLogo.Image = Image.FromFile(pathFrm)

        cmdBrowse.Visible = False
        cmdUpdate.Visible = True
    End Sub

    Function chk() As Boolean
        If subSQl() = False Then
            Return False
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSql.Execute("select * from tblLogo")
        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub SaveLogo()
        Dim rs As New Recordset
        Dim pathsave As String = getpicLogo(pathFrm)
        rs = New Recordset

        rs.Open("select * from tblLogo", conSql, 1, 2)
        rs.AddNew()
        Dim strem As New Stream
        strem.Type = StreamTypeEnum.adTypeBinary
        strem.Open()
        strem.LoadFromFile(pathsave)
        rs("Logo").Value = strem.Read
        rs.Update()

    End Sub

    Public Sub deleteLogo()
        Dim rs As New Recordset
        Dim pathsave As String = getpicLogo(pathFrm)
        rs = New Recordset

        rs = conSql.Execute("delete from tblLogo")
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        BrowsePath()
        cmdUpdate.Visible = True
        cmdBrowse.Visible = False
    End Sub

    Private Sub cmdUpdate_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdate.Click
        deleteLogo()
        SaveLogo()
        Delete_Logo()
        If chk() = False Then
            moraytaMain.Pic2Sa.Image = Logo_Image()
        End If
        MsgBox("System logo successfully saved!    ", vbInformation, "System Logo")
        cmdBrowse.Visible = True
        cmdUpdate.Visible = False
    End Sub
End Class