Imports System.Runtime.InteropServices

Public Class UserAgentHelper
    <DllImport("urlmon.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True)>
    Private Shared Function UrlMkSetSessionOption(ByVal dwOption As Integer, ByVal pBuffer As String, ByVal dwBufferLength As Integer, ByVal dwReserved As Integer) As Integer

    End Function

    Private Const URLMON_OPTION_USERAGENT As Integer = &H10000001

    Public Shared Sub SetDefaultUserAgent(ByVal userAgent As String)
        UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, userAgent, userAgent.Length, 0)
    End Sub
End Class
