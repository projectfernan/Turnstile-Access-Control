Public Class frmPicPath

    Private Sub frmPicPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewPath()
    End Sub
    Sub browse2()
        SavePath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        SavePath.InitialDirectory = "C:\"
        SavePath.FileName = vbNullString
        If SavePath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtpath.Text = SavePath.FileName
        End If
    End Sub
    Sub browse()
        Dim FBD As New FolderBrowserDialog
        FBD.Description = "Picture Path Designation"
        FBD.ShowNewFolderButton = True      'OR FALSE
        FBD.SelectedPath = "C:\"
        FBD.ShowDialog()
        txtpath.Text = FBD.SelectedPath      'Use this path to Process the folder...or files
        FBD = Nothing
    End Sub
    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        browse()
        If txtpath.Text = vbNullString Then
            Exit Sub
        End If
        cmdSubmit.Visible = True
        cmdBrowse.Visible = False
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        With My.Settings
            .PicPath = txtpath.Text
            .Save()
        End With
        MsgBox("Picture designate path successfully saved!    ", vbInformation, "Picture Settings")
        cmdSubmit.Visible = False
        cmdBrowse.Visible = True
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class