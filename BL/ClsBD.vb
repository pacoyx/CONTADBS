Imports System.Data
Imports System.Data.SqlClient

Public Class ClsBD
    Protected Cn As SqlConnection

    Public Str_Servidor As String = "Servidor"
    Public Str_Base As String = "Servidor"
    Dim Str_Usuario As String = "Usuario"
    Dim Str_Clave As String = "Clave"
    Public Str_Reportes As String = "\\Reportes\"
    Const cnstKey As String = "TUPAPI"


    Public Sub New()
        Try
            'If Not ValidarRegEdit() Then
            'Throw New Exception("El RegEdit no a sido registrado correctamente.")
            'Exit Sub
            'End If

            Dim strPath As String = System.Environment.CurrentDirectory
            strPath = System.Reflection.Assembly.GetExecutingAssembly().Location
            strPath = strPath.Substring(0, strPath.Length - 7)

            Dim mINI As New cIniArray
            Dim sFicINI As String = strPath & "\conexion.ini"
            Dim sValor As String = ""

            'Str_Servidor = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Servidor", Nothing)
            'Str_Base = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Base", Nothing)
            'Str_Usuario = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Usuario", Nothing)
            'Str_Clave = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Clave", Nothing)
            'Str_Clave = DesEncryptString(Str_Clave)
            'Str_Reportes = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Reportes", Nothing)

            Str_Servidor = mINI.IniGet(sFicINI, "conectar", "servidor", sValor)
            Str_Base = mINI.IniGet(sFicINI, "conectar", "base", sValor)
            Str_Usuario = mINI.IniGet(sFicINI, "conectar", "usuario", sValor)
            Str_Clave = mINI.IniGet(sFicINI, "conectar", "pwd", sValor)
            Str_Clave = DesEncryptString(Str_Clave)
            Str_Reportes = mINI.IniGet(sFicINI, "conectar", "reportes", sValor)

            Dim Conexion As String = String.Format("Server={0}; User={1}; Pwd={2} ;Initial Catalog={3} ; Pooling=false; ", Str_Servidor, Str_Usuario, Str_Clave, Str_Base)

            Cn = New SqlConnection(Conexion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarRegEdit() As Boolean
        ValidarRegEdit = False
        Try

            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Helios", "Servidor", Nothing) Is Nothing Then
                Exit Function
            End If
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Helios", "Base", Nothing) Is Nothing Then
                Exit Function
            End If
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Helios", "Usuario", Nothing) Is Nothing Then
                Exit Function
            End If
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Helios", "Clave", Nothing) Is Nothing Then
                Exit Function
            End If
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Helios", "Reportes", Nothing) Is Nothing Then
                Exit Function
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Funciones para encriptar y/o desencriptar password de usuarios"
    Private Function EncryptString(ByRef Text As String) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        n = Len(cnstKey)
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid(cnstKey, i, 1))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To Len(Text)
            TextASCIIS(i) = Asc(Mid(Text, i, 1))
        Next

        For i = 1 To Len(Text)
            j = IIf(j + 1 >= n, 1, j + 1)
            Temp = TextASCIIS(i) + UserKeyASCIIS(j)
            If Temp > 255 Then
                Temp = Temp - 255
            End If
            rtn = rtn & Chr(Temp)
        Next
        EncryptString = rtn
    End Function

    Private Function DesEncryptString(ByRef Text As String) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        n = Len(cnstKey)
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid(cnstKey, i, 1))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To Len(Text)
            TextASCIIS(i) = Asc(Mid(Text, i, 1))
        Next

        For i = 1 To Len(Text)
            j = IIf(j + 1 >= n, 1, j + 1)
            Temp = TextASCIIS(i) - UserKeyASCIIS(j)
            If Temp < 0 Then
                Temp = Temp + 255
            End If
            rtn = rtn & Chr(Temp)
        Next
        DesEncryptString = rtn
    End Function
#End Region

End Class
