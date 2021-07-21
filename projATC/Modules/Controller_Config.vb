
Module Controller_Config
    Declare Sub Sleep Lib "kernel32" (ByVal MSmiliSeconds As Long)

    Public ctrl_Node As String
    Public ctrl_SN As String
    Public ctrl_Port As String
    Public ctrl_IP As String
    Public ctrl_MAC As String
    Public ctrl_Mask As String
    Public ctrl_SubNet As String
    Public ctrl_Gateway As String
    Public ctrl_PCip As String

    Public ctrl_CamIP As String
    Public ctrl_CamUID As String
    Public ctrl_CamPWD As String
    Public ctrl_CamPort As Integer

    Public ctrl_Cam1 As Integer
    Public ctrl_Cap1 As Integer

    Public ctrl_Cam2 As Integer
    Public ctrl_Cap2 As Integer

    Public uplod_SN As String
    Public uplod_IP As String
    Public uplod_Port As String
End Module
