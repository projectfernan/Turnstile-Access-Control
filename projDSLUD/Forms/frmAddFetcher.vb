Imports ADODB
Public Class frmAddFetcher
    Public image_path As String = vbNullString

    Sub BrowsePath()
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_path = vbNullString
            image_path = Openpath.FileName
        End If

        If image_path = vbNullString Then Exit Sub

        imgFetch.Image = Image.FromFile(image_path)

    End Sub

    Sub saveFetch()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Save")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If image_path = vbNullString Then
            image_path = Application.StartupPath & "\noimage.jpeg"
        End If

        Try
            Dim rs As New Recordset
            With frmNewStud
                rs = New Recordset
                rs.Open("select * from tblfetcher", conSql, 1, 2)
                rs.AddNew()
                rs("ACnumber").Value = .txtFetchAC.Text
                rs("IDnumber").Value = .txtId.Text
                rs("FetcherName").Value = txtName.Text
                rs("Position").Value = txtPosition.Text
                Dim strem As New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(image_path)
                rs("Pic").Value = strem.Read
                rs.Update()
                MsgBox("New Fetcher added!    ", vbInformation, "Update fetcher")
                Me.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save Fetcher")
        End Try

    End Sub

    Sub updateFetch(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Update")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If image_path = vbNullString Then
            Try

                With frmNewStud
                    Dim rs1 As New Recordset
                    rs1 = New Recordset
                    rs1.Open("select * from tblfetcher where Id = '" & id & "'", conSql, 1, 2)
                    rs1("ACnumber").Value = .txtFetchAC.Text
                    rs1("IDnumber").Value = .txtId.Text
                    rs1("FetcherName").Value = txtName.Text
                    rs1("Position").Value = txtPosition.Text
                    rs1.Update()
                    MsgBox("Fetcher updated!    ", vbInformation, "Update fetcher")
                    Me.Close()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Update Fetcher")
            End Try
        Else

            Try
                Dim rs As New Recordset
                With frmNewStud
                    rs = New Recordset
                    rs.Open("select * from tblfetcher where Id = '" & id & "'", conSql, 1, 2)
                    rs("ACnumber").Value = .txtFetchAC.Text
                    rs("IDnumber").Value = .txtId.Text
                    rs("FetcherName").Value = txtName.Text
                    rs("Position").Value = txtPosition.Text
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(image_path)
                    rs("Pic").Value = strem.Read
                    rs.Update()

                    MsgBox("Fetcher updated!    ", vbInformation, "Update fetcher")
                    Me.Close()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Update Fetcher")
            End Try
        End If
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click

        With frmNewStud
            Select Case Me.Text
                Case "Add Fetcher"
                    saveFetch()
                    .LstFetcher.Clear()
                    headerF(.LstFetcher)
                    fillfetcher(.LstFetcher, .txtId.Text)

                    If .LstFetcher.Items.Count = 6 Then
                        cmdFetchEnable()
                    Else
                        cmdFetchEnable()
                    End If
                Case "Update Fetcher"
                    updateFetch(fetchID)
                    .LstFetcher.Clear()
                    headerF(.LstFetcher)
                    fillfetcher(.LstFetcher, .txtId.Text)

                    If .LstFetcher.Items.Count = 6 Then
                        cmdFetchEnable()
                    Else
                        cmdFetchEnable()
                    End If
            End Select
        End With
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        BrowsePath()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class