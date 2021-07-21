Imports ADODB
Module Fetcher_Function
    Public fetchID As String
    Public F_AccNo As String
    Public F_StudID As String

    Public Sub headerF(ByVal lst As ListView)
        lst.Columns.Add("Fetchar Name", 250, HorizontalAlignment.Left)
        lst.Columns.Add("Position", 215, HorizontalAlignment.Left)
        lst.Columns.Add("", 0, HorizontalAlignment.Left)
        lst.Columns.Add("", 0, HorizontalAlignment.Left)
        lst.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Public Sub fillfetcher(ByVal lst As ListView, ByVal IdNo As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblFetcher where IDnumber = '" & IdNo & "'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lst.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lst.Items.Add(rs("FetcherName").Value, lup)
                viewlst.SubItems.Add(rs("Position").Value)
                viewlst.SubItems.Add(rs("ID").Value)
                viewlst.SubItems.Add(rs("ACnumber").Value)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Public Function fetcherAcNo(ByVal IdNo As String) As String
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Return vbNullString
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblFetcher where IDnumber = '" & IdNo & "'")
        If rs.EOF = False Then
            Return rs("ACnumber").Value
        Else
            Return vbNullString
        End If
    End Function

    Public Function FetcherPic(ByRef Id As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select * from tblfetcher where ID = '" & Id & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Pic").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub cmdFetchDisable()
        With frmNewStud
            .cmdAdd.Enabled = False
            .cmdEdit.Enabled = False
            .cmdDel.Enabled = False
        End With
    End Sub

    Public Sub cmdFetchEnable()
        With frmNewStud
            .cmdAdd.Enabled = True
            .cmdEdit.Enabled = True
            .cmdDel.Enabled = True
        End With
    End Sub

End Module
