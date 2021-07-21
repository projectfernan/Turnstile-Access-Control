Imports ADODB
Module Items_Function
    Public itmFlag As String

    Public Sub headerItm(ByVal lst As ListView)
        lst.Columns.Add("ID", 90, HorizontalAlignment.Left)
        lst.Columns.Add("CardCode", 150, HorizontalAlignment.Left)
        lst.Columns.Add("ItemName", 200, HorizontalAlignment.Left)
        lst.Columns.Add("SerialNo", 150, HorizontalAlignment.Left)
        lst.Columns.Add("Model", 150, HorizontalAlignment.Left)
        lst.Columns.Add("Category", 150, HorizontalAlignment.Left)
        lst.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Public Sub fillItems(ByVal lst As ListView, ByVal IdNo As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblitems where IDnumber = '" & IdNo & "'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lst.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lst.Items.Add(rs("ID").Value, lup)
                viewlst.SubItems.Add(rs("CardCode").Value)
                viewlst.SubItems.Add(rs("ItemName").Value)
                viewlst.SubItems.Add(rs("SerialNo").Value)
                viewlst.SubItems.Add(rs("Model").Value)
                viewlst.SubItems.Add(rs("Category").Value)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Public Function cardCod(ByVal cardNo As String) As String
        If Len(cardNo) = 1 Then
            Return "0000000" + cardNo
        ElseIf Len(cardNo) = 2 Then
            Return "000000" + cardNo
        ElseIf Len(cardNo) = 3 Then
            Return "00000" + cardNo
        ElseIf Len(cardNo) = 4 Then
            Return "0000" + cardNo
        ElseIf Len(cardNo) = 5 Then
            Return "000" + cardNo
        ElseIf Len(cardNo) = 6 Then
            Return "00" + cardNo
        ElseIf Len(cardNo) = 7 Then
            Return "0" + cardNo
        Else
            Return cardNo
        End If
    End Function

End Module
