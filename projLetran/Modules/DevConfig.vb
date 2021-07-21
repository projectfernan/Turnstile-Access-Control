Module DevConfig
    Public Dev_Name As String
    Public Dev_Ip As String
    Public Dev_Frame As String
    Public Dev_Stat As String
    Public Dev_Delay As Long

    Public Dvr_IP As String
    Public Dvr_UID As String
    Public Dvr_PWD As String
    Public Dvr_Port As String
    Public Dvr_Cam_Chan As Integer
    Public Dvr_Cam_Capture As Integer

    Public ConnDevCnt As Long

    Public Structure Dev_Config
        Public Dev_Name As String
        Public Dev_Ip As String
        Public Dev_Frame As String
        Public Dev_Lane As String
        Public Dev_Stat As String
        Public Dev_Delay As Long
    End Structure

    Public DevStructure As New Dev_Config

    Public idPicno As String

    Public Erollin1 As String
    Public Erollout1 As String
    Public Erollin2 As String
    Public Erollout2 As String


End Module
