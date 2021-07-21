
Class LogTableOverflowException
    Inherits Exception

    Private Const overflowMessage As String = _
        "The log table has overflowed."

    Public Sub New(auxMessage As String, inner As Exception)
        MyBase.New(String.Format("{0} - {1}", _
            overflowMessage, auxMessage), inner)

        Me.HelpLink = "http://msdn.microsoft.com"
        Me.Source = "Exception_Class_Samples"

    End Sub ' New 
End Class ' LogTableOverflowException

