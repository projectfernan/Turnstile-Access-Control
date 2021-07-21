
Class LogTable

 

    Public logArea As New ArrayList
    'Protected elemInUse As Integer

    ' The AddRecord method throws a derived exception if  
    ' the array bounds exception is caught. 
    Public Sub AddRecord(newRecord As String)
        Try
            'Dim curElement As Integer = 'elemInUse
            logArea.Add(newRecord)
            ' elemInUse += 1
        Catch ex As Exception
            Throw New LogTableOverflowException( _
                String.Format("Record ""{0}"" was not logged.", _
                    newRecord), ex)
        End Try
    End Sub ' AddRecord
End Class ' LogTable

