Imports ADODB
Module Student_Pic
    Public Function StudentPic(ByRef Id As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select IDnumber,Pic from tblStudinfo where IDnumber = '" & Id & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Pic").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    Try
                        Return Image.FromFile(My.Settings.PicPath & "\" & (Id) & ".Jpeg")
                    Catch ex2 As Exception
                        Try
                            Return Image.FromFile(My.Settings.PicPath & "\" & (Id) & ".Jpg")
                        Catch ex3 As Exception
                            Return Image.FromFile(Application.StartupPath & "\LetranIcod.jpg")
                        End Try
                    End Try
                End Try
            Else
                Try
                    Return Image.FromFile(My.Settings.PicPath & "\" & (Id) & ".Jpeg")
                Catch ex2 As Exception
                    Try
                        Return Image.FromFile(My.Settings.PicPath & "\" & (Id) & ".Jpg")
                    Catch ex3 As Exception
                        Return Image.FromFile(Application.StartupPath & "\LetranIcod.jpg")
                    End Try
                End Try
            End If
        Catch ex As Exception
            Try
                Return Image.FromFile(My.Settings.PicPath & "\" & (Id) & ".Jpeg")
            Catch ex2 As Exception
                Try
                    Return Image.FromFile(My.Settings.PicPath & "\" & (Id) & ".Jpg")
                Catch ex3 As Exception
                    Return Image.FromFile(Application.StartupPath & "\LetranIcod.jpg")
                End Try
            End Try
        End Try
    End Function

    Public Function StudentPicStr(ByRef Id As String) As String
        Try
            Dim Name1 As String = Dir$(My.Settings.PicPath & "\" & (Id) & ".jpeg")
            If Name1 = "" Then
                Dim Name2 As String = Dir$(My.Settings.PicPath & "\" & (Id) & ".jpg")
                If Name2 = "" Then
                    Return Application.StartupPath & "\LetranIcod.jpg"
                Else
                    Return My.Settings.PicPath & "\" & Name2
                End If
            Else
                Return My.Settings.PicPath & "\" & Name1
            End If
        Catch ex2 As Exception
            Return Application.StartupPath & "\LetranIcod.jpg"
        End Try
    End Function

End Module
