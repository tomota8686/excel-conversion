Imports System.Runtime.InteropServices


Public Class RWini

    Dim lpFileName As String

    'コンストラクタ
    Public Sub New(ByVal lpFileName As String)
        Me.lpFileName = lpFileName
    End Sub

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileString(
    ByVal lpAppName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer,
    ByVal lpFileName As String) As Integer
    End Function

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function WritePrivateProfileString(
    ByVal lpApplicationName As String,
    ByVal lpKeyName As String,
    ByVal lpString As String,
    ByVal lpFileName As String) As Long
    End Function

    '----------------------------------------------------------------------------------
    'iniファイルから取得する
    Public Function GetIniString(ByVal lpSection As String, ByVal lpKeyName As String) As String
        Dim strValue As System.Text.StringBuilder = New System.Text.StringBuilder(1024)

        Dim sLen = GetPrivateProfileString(lpSection, lpKeyName, "", strValue, 1024, lpFileName)
        Dim str As String = strValue.ToString()

        Return str
    End Function

    '----------------------------------------------------------------------------------
    'iniファイルに書き込む
    Public Function PutIniString(ByVal lpSection As String, lpKeyName As String, ByVal lpValue As String) As Boolean
        Dim result As Long = WritePrivateProfileString(lpSection, lpKeyName, lpValue, lpFileName)
        Return result <> 0
    End Function

End Class