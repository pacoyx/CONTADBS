Imports System.Collections.Generic

Public Class ContabilidadDA
    Const cnstKey As String = "TUPAPI"
    Dim cnx As New SqlConnection

#Region "Abrir la conexion"
    Private Function GetConexion() As String

        Dim Str_Servidor As String = ""
        Dim Str_Base As String = ""
        Dim Str_Usuario As String = ""
        Dim Str_Clave As String = ""

        'Str_Servidor = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Servidor", Nothing).ToString
        'Str_Base = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Base", Nothing).ToString
        'Str_Usuario = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Usuario", Nothing).ToString
        'Str_Clave = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Clave", Nothing).ToString
        'Str_Clave = DesEncryptString(Str_Clave)


        Dim strPath As String = System.Environment.CurrentDirectory
        strPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        strPath = strPath.Substring(0, strPath.Length - 37)

        Dim mINI As New cIniArray
        Dim sFicINI As String = strPath & "\conexion.ini"
        Dim sValor As String = ""

        Str_Servidor = mINI.IniGet(sFicINI, "conectar", "servidor", sValor)
        Str_Base = mINI.IniGet(sFicINI, "conectar", "base", sValor)
        Str_Usuario = mINI.IniGet(sFicINI, "conectar", "usuario", sValor)
        Str_Clave = mINI.IniGet(sFicINI, "conectar", "pwd", sValor)
        Str_Clave = DesEncryptString(Str_Clave)


        Dim Conexion As String = String.Format("Server={0}; User={1}; Pwd={2} ;Initial Catalog={3} ; Pooling=false; ", Str_Servidor, Str_Usuario, Str_Clave, Str_Base)
        Return Conexion
    End Function

    Private Sub Abri_Conexion()
        Try
            Dim Conexion As String = GetConexion()
            cnx = New SqlConnection(Conexion)
            cnx.Open()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Cerrar_Conexion()
        Try
            'cerramos la conexion.
            cnx.Close()
            cnx.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Funciones para encriptar y/o desencriptar password de usuarios"
    Private Function EncryptString(ByRef Text As String) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        n = CShort(Len(cnstKey))
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = CShort(Asc(Mid(cnstKey, i, 1)))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To CShort(Len(Text))
            TextASCIIS(i) = CShort(Asc(Mid(Text, i, 1)))
        Next

        For i = 1 To CShort(Len(Text))
            j = CShort(IIf(j + 1 >= n, 1, j + 1))
            Temp = TextASCIIS(i) + UserKeyASCIIS(j)
            If Temp > 255 Then
                Temp = CShort(Temp - 255)
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

        n = CShort(Len(cnstKey))
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = CShort(Asc(Mid(cnstKey, i, 1)))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To CShort(Len(Text))
            TextASCIIS(i) = CShort(Asc(Mid(Text, i, 1)))
        Next

        For i = 1 To CShort(Len(Text))
            j = CShort(IIf(j + 1 >= n, 1, j + 1))
            Temp = TextASCIIS(i) - UserKeyASCIIS(j)
            If Temp < 0 Then
                Temp = CShort(Temp + 255)
            End If
            rtn = rtn & Chr(Temp)
        Next
        DesEncryptString = rtn
    End Function
#End Region

    Public Sub setCodigos(ByVal codigos As List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP))
        Try
            Call Abri_Conexion()

            If codigos.Count > 0 Then
                Dim cmd As New SqlCommand()
                cmd.Connection = cnx
                cmd.CommandType = CommandType.Text
                cmd.CommandText = String.Format("DELETE FROM SG_CO_TB_CODIGOS_TMP WHERE PC = '{0}' AND EMPRESA = {1}", codigos(0).PC, codigos(0).EMPRESA)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand()
                cmd.Connection = cnx
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SG_CO_SP_I_CODIGOS_TMP"

                For Each codigo As BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP In codigos
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add(New SqlParameter("@P_CODIGO", codigo.CODIGO))
                    cmd.Parameters.Add(New SqlParameter("@P_PC", codigo.PC))
                    cmd.Parameters.Add(New SqlParameter("@P_EMPRESA", codigo.EMPRESA))
                    cmd.ExecuteNonQuery()
                Next

                cmd.Dispose()
                Call Cerrar_Conexion()

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub setSaldos_Cuentas(ByVal cuentas As List(Of String), ByVal anho_ As Integer, ByVal mes_ As Integer, ByVal pc_ As String, ByVal empresa_ As Integer)
        Try
            Call Abri_Conexion()

            Dim cmd As New SqlCommand()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM SG_CO_TB_TMP_SALDO_CUENTA WHERE SC_EMPRESA = " & empresa_ & " AND SC_PC = '" & pc_ & "'"
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand
            cmd.Connection = cnx
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SG_CO_SP_I_SALDO_CUENTA1"

            For Each cuenta As String In cuentas
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@P_ANHO", anho_))
                cmd.Parameters.Add(New SqlParameter("@P_MES", mes_))
                cmd.Parameters.Add(New SqlParameter("@P_IDCUENTA", cuenta))
                cmd.Parameters.Add(New SqlParameter("@P_PC", pc_))
                cmd.Parameters.Add(New SqlParameter("@P_IDEMPRESA", empresa_))
                cmd.ExecuteNonQuery()
            Next

            cmd.Dispose()

            Call Cerrar_Conexion()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
