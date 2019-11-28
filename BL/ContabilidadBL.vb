Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms



Public Class ContabilidadBL

#Region "Script para los Test"
    Public Class AyudaTest
        Inherits ClsBD
        Implements IDisposable


        Public Sub RunSQL(ByVal cadena As String)
            Try
                SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, cadena)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function RunSQL_getTable(ByVal cadena As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, cadena).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Liberar otro estado (objetos administrados).
                End If

                ' TODO: Liberar su propio estado (objetos no administrados).
                ' TODO: Establecer campos grandes como Null.
            End If
            Me.disposedValue = True
        End Sub

#Region " IDisposable Support "
        ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
#End Region

    Public Class SG_CO_TB_HONORARIO_PROFE
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.ContabilidadBE.SG_CO_TB_HONORARIO_PROFE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_HONO_PROFE", .HP_IDHONORARIO.AN_IDANEXO, _
                                          .HP_PRI_NOM, .HP_SEC_NOM, .HP_NOMBRE, .HP_DIR, .HP_IDPAIS.PA_CODIGO, _
                                          .HP_CIUDAD, .HP_TELF_FIJO, .HP_TELF_MOVIL, .HP_EMAIL, .HP_PROFESION, _
                                          DBNull.Value, .HP_ES_AFECTO_RENTA, .HP_USUARIO, .HP_TERMINAL, .HP_FECREG)
            End With
        End Sub

        Public Function getHonorarios(ByVal idHonorario_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_HONO_PROFE", idHonorario_).Tables(0)
        End Function

    End Class


#Region "Reportes  Contables"
    Public Class SG_CO_Reportes_Registros
        Inherits ClsBD

        Public Function get_Consolidado_Cta(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal pc_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CONSOL_X_CTA", ayo_, mes_, pc_, empresa_).Tables(0)
        End Function

        Public Sub get_PLE_Mayor(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_MAYOR_V2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00060100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_NUM_VOUCHER") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("COD_PLAN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_CUENTA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_FEC_VOUCHER") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_GLOSA_VOU").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", "") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_DEBE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_HABER") & "||||1|"
                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_Mayor_V3(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_MAYOR_V3", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00060100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)


            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|" '1
                Strdatos = Strdatos & dt_data.Rows(i)("AC_NUM_VOUCHER") & "|" '2
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|" '3
                Strdatos = Strdatos & dt_data.Rows(i)("AD_CUENTA") & "|" '4
                Strdatos = Strdatos & "|" '5
                Strdatos = Strdatos & "|" '6
                Strdatos = Strdatos & "PEN|" '7
                Strdatos = Strdatos & "|" '8
                Strdatos = Strdatos & "|" '9
                Strdatos = Strdatos & dt_data.Rows(i)("TD").ToString.PadLeft(2, "0") & "|" '10 OBLIGATORIO Tipo de Comprobante de Pago o Documento asociada a la operación, de corresponder

                Select Case dt_data.Rows(i)("TD").ToString.PadLeft(2, "0")
                    Case "01", "02", "03", "07"
                        Strdatos = Strdatos & dt_data.Rows(i)("SD").ToString.PadLeft(4, "0") & "|" '11 SERIE
                    Case Else
                        Strdatos = Strdatos & dt_data.Rows(i)("SD") & "|" '11 SERIE
                End Select

                Select Case dt_data.Rows(i)("TD").ToString.PadLeft(2, "0")
                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("ND"), 6) & "|" '12 OBLIGATORIO Número del comprobante de pago o documento asociada a la operación
                    Case Else
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("ND"), 8) & "|" '12 OBLIGATORIO Número del comprobante de pago o documento asociada a la operación
                End Select

                Strdatos = Strdatos & dt_data.Rows(i)("AC_FEC_VOUCHER") & "|" '13 FECHA CONTABLE
                Strdatos = Strdatos & dt_data.Rows(i)("AD_VDOC") & "|" '14 FECHA VENCIMIENTO
                Strdatos = Strdatos & dt_data.Rows(i)("FD") & "|" '15 OBLIGATORIO FECHA OPERACION Ò EMISION
                Strdatos = Strdatos & dt_data.Rows(i)("AC_GLOSA_VOU").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", "") & "|" '16 OBLIGATORIO GLOSA
                Strdatos = Strdatos & "|" '17 GLOSA
                Strdatos = Strdatos & dt_data.Rows(i)("AD_DEBE") & "|" '18 OBLIGATORIO DEBE
                Strdatos = Strdatos & dt_data.Rows(i)("AD_HABER") & "|" '19 OBLIGATORIO HABER
                Strdatos = Strdatos & "|1|" '20 GLOSA

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_PlanCuentas(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_PLE", ayo_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00050300001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                'Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "01" & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CUENTA") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DES_CUENTA").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", ""), 60) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPOPLAN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("DESPLAN") & "|" '5
                Strdatos = Strdatos & "|" '6
                Strdatos = Strdatos & "|" '7
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO") & "|" '8
                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_Diario(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_DIARIO_V2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00050100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_NUM_VOUCHER") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("COD_PLAN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_CUENTA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_FEC_VOUCHER") & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("AC_GLOSA_VOU").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", "") & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("AD_DEBE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_HABER") & "||||1|"

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_Diario_V3(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_DIARIO_V3", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00050100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|" '1
                Strdatos = Strdatos & dt_data.Rows(i)("AC_NUM_VOUCHER") & "|" '2
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|" '3
                Strdatos = Strdatos & dt_data.Rows(i)("AD_CUENTA") & "|" '4
                Strdatos = Strdatos & "|" '5
                Strdatos = Strdatos & "|" '6
                Strdatos = Strdatos & "PEN|" '7
                Strdatos = Strdatos & "|" '8
                Strdatos = Strdatos & "|" '9
                Strdatos = Strdatos & dt_data.Rows(i)("TD").ToString.PadLeft(2, "0") & "|" '10 OBLIGATORIO Tipo de Comprobante de Pago o Documento asociada a la operación, de corresponder

                Select Case dt_data.Rows(i)("TD").ToString.PadLeft(2, "0")
                    Case "01", "02", "03", "07"
                        Strdatos = Strdatos & dt_data.Rows(i)("SD").ToString.PadLeft(4, "0") & "|" '11 SERIE
                    Case Else
                        Strdatos = Strdatos & dt_data.Rows(i)("SD") & "|" '11 SERIE
                End Select

                Select Case dt_data.Rows(i)("TD").ToString.PadLeft(2, "0")
                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("ND"), 6) & "|" '12 OBLIGATORIO Número del comprobante de pago o documento asociada a la operación
                    Case Else
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("ND"), 8) & "|" '12 OBLIGATORIO Número del comprobante de pago o documento asociada a la operación
                End Select




                Strdatos = Strdatos & dt_data.Rows(i)("AC_FEC_VOUCHER") & "|" '13 FECHA CONTABLE
                Strdatos = Strdatos & dt_data.Rows(i)("AD_VDOC") & "|" '14 FECHA VENCIMIENTO
                Strdatos = Strdatos & dt_data.Rows(i)("FD") & "|" '15 OBLIGATORIO FECHA OPERACION Ò EMISION
                Strdatos = Strdatos & dt_data.Rows(i)("AC_GLOSA_VOU").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", "") & "|" '16 OBLIGATORIO GLOSA
                Strdatos = Strdatos & "|" '17 GLOSA
                Strdatos = Strdatos & dt_data.Rows(i)("AD_DEBE") & "|" '18 OBLIGATORIO DEBE
                Strdatos = Strdatos & dt_data.Rows(i)("AD_HABER") & "|" '19 OBLIGATORIO HABER
                Strdatos = Strdatos & "|1|" '20 GLOSA

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_RegVentas(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_REGVEN_V2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00140100001111.txt"
            'StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("COU") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_EMI") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_VEN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SER_DOC") & "|"
                Select Case dt_data.Rows(i)("TIP_DOC")
                    Case "05" 'boleto de avion
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"

                    Case "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 7) & "|"

                    Case "00", "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                    Case "11"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 15) & "|"

                    Case "36"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 8) & "|"

                    Case "56"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 4) & "|"

                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 6) & "|"

                End Select

                Strdatos = Strdatos & dt_data.Rows(i)("OPT1").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TDI_CLIENTE").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NDI_CLIENTE").ToString & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE").ToString, 60) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("VALOR_EXPOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("OPE_EXONERADA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("OPE_INAFECTA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IGV") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_IVAP") & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("IVAP") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SER_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUM_DOC_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FOB") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO") & "|"

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_RegVentas_V3(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_REGVEN_V2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            If dt_data.Rows.Count = 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00140100001011.txt"
            Else
                StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00140100001111.txt"
            End If

            'StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|" '1
                Strdatos = Strdatos & dt_data.Rows(i)("COU") & "|" '2
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|" '3
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_EMI") & "|" '4
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_VEN") & "|" '5
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC") & "|" '6
                Strdatos = Strdatos & dt_data.Rows(i)("SER_DOC") & "|" '7

                Select Case dt_data.Rows(i)("TIP_DOC") '8
                    Case "05" 'boleto de avion
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"

                    Case "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 7) & "|"

                    Case "00", "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                    Case "11"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 15) & "|"

                    Case "36"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 8) & "|"

                    Case "56"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 4) & "|"

                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 6) & "|"

                End Select


                'Strdatos = Strdatos & dt_data.Rows(i)("OPT1").ToString & "|" '9
                Strdatos = Strdatos & "|" '9
                Strdatos = Strdatos & dt_data.Rows(i)("TDI_CLIENTE").ToString & "|" '10
                Strdatos = Strdatos & dt_data.Rows(i)("NDI_CLIENTE").ToString & "|" '11
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE").ToString, 60) & "|" '12
                Strdatos = Strdatos & dt_data.Rows(i)("VALOR_EXPOR") & "|" '13
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|" '14
                Strdatos = Strdatos & "0.00|" '15
                Strdatos = Strdatos & dt_data.Rows(i)("IGV") & "|" '16
                Strdatos = Strdatos & "0.00|" '17
                Strdatos = Strdatos & dt_data.Rows(i)("OPE_EXONERADA") & "|" '18
                Strdatos = Strdatos & dt_data.Rows(i)("OPE_INAFECTA") & "|" '19
                Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|" '20
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_IVAP") & "|" '21
                Strdatos = Strdatos & dt_data.Rows(i)("IVAP") & "|" '22
                Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|" '23
                Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|" '24
                Strdatos = Strdatos & "PEN|" '25
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|" '26

                Strdatos = Strdatos & dt_data.Rows(i)("FEC_REF").ToString & "|" '27
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC_REF").ToString & "|" '28
                Strdatos = Strdatos & dt_data.Rows(i)("SER_REF").ToString & "|" '29
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC_REF").ToString, 7) & "|" '30
                Strdatos = Strdatos & "|" '31
                Strdatos = Strdatos & "|" '32
                Strdatos = Strdatos & "|" '33
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO") & "|"

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_RegCompras(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_REGCOM_v2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = Left(dt_data.Rows(i)("PERIODO"), 8) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("COU"), 40) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("CORRELATIVO"), 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|"

                If dt_data.Rows(i)("TIP_DOC").ToString = "14" Then
                    Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_VEN"), 10) & "|"
                Else
                    Strdatos = Strdatos & "|"
                End If

                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|"

                If dt_data.Rows(i)("TIP_DOC") = "05" Then
                    Strdatos = Strdatos & "1|"
                Else
                    Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_DOC"), 20) & "|"
                End If


                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA"), 4) & "|"

                Select Case dt_data.Rows(i)("TIP_DOC")
                    Case "05" 'boleto de avion
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"

                    Case "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 7) & "|"

                    Case "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                    Case "11"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 15) & "|"

                    Case "36"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 8) & "|"

                    Case "56"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 4) & "|"

                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 6) & "|"

                End Select

                Strdatos = Strdatos & Left(dt_data.Rows(i)("OPT1"), 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TDI_PROVEEDOR"), 1) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NDI_CLIENTE"), 15) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE"), 60) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IGV_G") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_MIXTA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IGV_MIXTA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_NOG") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IGV_NOG") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("VALOR_NOGRABADAS") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_REF").ToString, 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC_REF").ToString, 2) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_REF").ToString, 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA2"), 4) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_DOC_REF").ToString, 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_COM_NODOMI").ToString, 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_DETRA").ToString, 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_DETRA").ToString, 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("ESTADO"), 1) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("ESTADO2"), 1) & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            empresaBL = Nothing
            empresaBE = Nothing
        End Sub

        Public Sub get_PLE_RegCompras_V3(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_REGCOM_V2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            If dt_data.Rows.Count = 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080100001011.txt"
            Else
                StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080100001111.txt"
            End If


            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = Left(dt_data.Rows(i)("PERIODO"), 8) & "|" '1
                Strdatos = Strdatos & Left(dt_data.Rows(i)("COU"), 40) & "|" '2
                Strdatos = Strdatos & Left(dt_data.Rows(i)("CORRELATIVO"), 10) & "|" '3
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|" '4

                If dt_data.Rows(i)("TIP_DOC").ToString = "14" Then '5
                    Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_VEN"), 10) & "|"
                Else
                    Strdatos = Strdatos & "|"
                End If

                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|" '6

                If dt_data.Rows(i)("TIP_DOC") = "05" Then '7
                    Strdatos = Strdatos & "1|"
                Else
                    Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_DOC"), 20) & "|"
                End If


                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA"), 4) & "|" '8

                Select Case dt_data.Rows(i)("TIP_DOC") '9
                    Case "05" 'boleto de avion
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"

                    Case "00", "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 7) & "|"

                    Case "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                    Case "11"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 15) & "|"

                    Case "36"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 8) & "|"

                    Case "56"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 4) & "|"

                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 6) & "|"

                End Select

                'Strdatos = Strdatos & Left(dt_data.Rows(i)("OPT1"), 20) & "|" '10
                Strdatos = Strdatos & "|" '10
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TDI_PROVEEDOR"), 1) & "|" '11
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NDI_CLIENTE"), 15) & "|" '12
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE"), 60) & "|" '13
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|" '14
                Strdatos = Strdatos & dt_data.Rows(i)("IGV_G") & "|" '15
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_MIXTA") & "|" '16
                Strdatos = Strdatos & dt_data.Rows(i)("IGV_MIXTA") & "|" '17
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_NOG") & "|" '18
                Strdatos = Strdatos & dt_data.Rows(i)("IGV_NOG") & "|" '19
                Strdatos = Strdatos & dt_data.Rows(i)("VALOR_NOGRABADAS") & "|" '20
                Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|" '21
                Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|" '22
                Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|" '23
                Strdatos = Strdatos & "PEN|" '24
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|" '25
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_REF").ToString, 10) & "|" '26
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC_REF").ToString, 2) & "|" '27
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_REF").ToString, 20) & "|" '28
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA2"), 4) & "|" '29
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC_REF").ToString, 7) & "|" '30

                'Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_COM_NODOMI").ToString, 20) & "|"

                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_DETRA").ToString, 10) & "|" '31
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_DETRA").ToString, 20) & "|" '32
                Strdatos = Strdatos & "|" '33
                Strdatos = Strdatos & "|" '34
                Strdatos = Strdatos & "|" '35
                Strdatos = Strdatos & "|" '36
                Strdatos = Strdatos & "|" '37
                Strdatos = Strdatos & "|" '38
                Strdatos = Strdatos & "|" '39
                Strdatos = Strdatos & "|" '40
                Strdatos = Strdatos & Left(dt_data.Rows(i)("ESTADO2"), 1) & "|" '41

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_PLE_RegCompras_V3_NoDomiciliado(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, Str_vRutaPdt_ As String)

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLE_REGCOM_V3_8_2", ayo_, mes_, empresa_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String = ""

            If dt_data.Rows.Count > 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080200001111.txt"
            Else
                StrNomArchivo = Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\LE" & empresaBE.EM_RUC & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080200001011.txt"
            End If


            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt_ & "\" & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = Left(dt_data.Rows(i)("PERIODO"), 8) & "|" '1
                Strdatos = Strdatos & Left(dt_data.Rows(i)("COU"), 40) & "|" '2
                Strdatos = Strdatos & Left(dt_data.Rows(i)("CORRELATIVO"), 10) & "|" '3
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|" '4
                'Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|" '5
                Strdatos = Strdatos & "91|" '5
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_DOC"), 20) & "|" '6
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|" '7
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|" '8 Valor de las adquisiciones BASE
                Strdatos = Strdatos & "|" '9 Otros conceptos adicionales
                Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|" '10 Importe total  adquisiciones registradas según comprobante de pago o documento
                Strdatos = Strdatos & "00|" '11
                Strdatos = Strdatos & "|" '12
                Strdatos = Strdatos & "|" '13
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA"), 4) & "|" '14
                Strdatos = Strdatos & "|" '15                   Monto de retención del IGV  
                Strdatos = Strdatos & "PEN|" '16                Código de la Moneda (Tabla 4)
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|" '17
                Strdatos = Strdatos & "9249|" '18  Pais de la residencia del sujeto no domiciliado
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE"), 60) & "|" '19
                Strdatos = Strdatos & "|" '20 Domicilio en el extranjero del sujeto no domiciliado
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NDI_CLIENTE"), 15) & "|" '21
                Strdatos = Strdatos & "|" '22 'Número de identificación fiscal del beneficiario efectivo de los pagos
                Strdatos = Strdatos & "|" '23
                Strdatos = Strdatos & "|" '24
                Strdatos = Strdatos & "|" '25 vinculo entre el contribuyente y el residente en el extranjero
                Strdatos = Strdatos & Math.Round((dt_data.Rows(i)("BASE_G") * 0.07) * 0.3, 2) & "|" '26 Renta Bruta 7*30
                Strdatos = Strdatos & "|" '27 Deducción / Costo de Enajenación de bienes de capital
                Strdatos = Strdatos & "|" '28 Renta Neta
                Strdatos = Strdatos & "|" '29 Tasa de retención
                Strdatos = Strdatos & "|" '30 Impuesto retenido 
                Strdatos = Strdatos & "00|" '31 Convenios para evitar la doble imposición
                Strdatos = Strdatos & "|" '32 
                Strdatos = Strdatos & "30|" '33 Tipo de Renta
                Strdatos = Strdatos & "|" '34 Modalidad de servicio prestado por el no domiciliado
                Strdatos = Strdatos & "|" '35
                Strdatos = Strdatos & "0|" '36 Estado


                'Strdatos = Strdatos & "|" '10
                'Strdatos = Strdatos & Left(dt_data.Rows(i)("TDI_PROVEEDOR"), 1) & "|" '11
                'Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|" '14
                'Strdatos = Strdatos & dt_data.Rows(i)("IGV_G") & "|" '15
                'Strdatos = Strdatos & dt_data.Rows(i)("BASE_MIXTA") & "|" '16
                'Strdatos = Strdatos & dt_data.Rows(i)("IGV_MIXTA") & "|" '17
                'Strdatos = Strdatos & dt_data.Rows(i)("BASE_NOG") & "|" '18
                'Strdatos = Strdatos & dt_data.Rows(i)("IGV_NOG") & "|" '19
                'Strdatos = Strdatos & dt_data.Rows(i)("VALOR_NOGRABADAS") & "|" '20
                'Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|" '21
                'Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|" '22
                'Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|" '23
                'Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_COM_NODOMI").ToString, 20) & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing
            empresaBL = Nothing
            empresaBE = Nothing

        End Sub


        Public Function get_PlanCtas_1(ByVal cuentaIni As String, ByVal cuentaFin As String, ByVal periodo As Integer, ByVal empresa As Integer) As DataTable
            get_PlanCtas_1 = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_REP_PLANCTAS", cuentaIni, cuentaFin, periodo, empresa).Tables(0)
        End Function

        Public Function getEstadistico_Mov_Anual_de_centroCostos_3D(ByVal ayo As Integer, ByVal emp As Integer) As DataTable
            getEstadistico_Mov_Anual_de_centroCostos_3D = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ACUMU_ANUAL_CC_3D", ayo, emp).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function get_Estadistico_Mov_Anual_de_CentroCostos_3d_DataReader(ByVal ayo As Integer, ByVal emp As Integer) As SqlDataReader
            Dim dataR As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ACUMU_ANUAL_CC_3D", ayo, emp)
            Return dataR
        End Function

        Public Function getEstadistico_Mov_Anual_de_centroCostos(ByVal ayo As Integer, ByVal emp As Integer) As DataTable
            getEstadistico_Mov_Anual_de_centroCostos = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ACUMU_ANUAL_CC", ayo, emp).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getEstadistico_Mov_Anual_x_CentroCosto(ByVal ayo As Integer, ByVal cc As String, ByVal emp As Integer) As DataTable
            getEstadistico_Mov_Anual_x_CentroCosto = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ACUMU_X_CC", ayo, cc, emp).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getEstadistico_Mov_Anual_x_CentroCosto_DataReader(ByVal ayo As Integer, ByVal cc As String, ByVal emp As Integer) As SqlDataReader
            getEstadistico_Mov_Anual_x_CentroCosto_DataReader = Nothing
            Try
                Dim dReader As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ACUMU_X_CC_WEB", ayo, cc, emp)
                Return dReader
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getEstadistico_mov_mensual_x_anexo(ByVal anexo As Integer, ByVal empresa As Integer, ByVal ayo As Integer) As DataTable
            getEstadistico_mov_mensual_x_anexo = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DH_MENSUAL_XANEXO", anexo, empresa, ayo).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getEstadistico_mov_mensual_x_anexo_DReader(ByVal anexo As Integer, ByVal empresa As Integer, ByVal ayo As Integer) As SqlDataReader
            getEstadistico_mov_mensual_x_anexo_DReader = Nothing
            Try
                Return SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_DH_MENSUAL_XANEXO", anexo, empresa, ayo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getEstadistico_cta_x_mes(ByVal cuenta As Integer, ByVal empresa As Integer, ByVal ayo As Integer) As DataTable
            getEstadistico_cta_x_mes = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DH_MENSUAL", cuenta, empresa, ayo).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getEstadistico_mov_mensual_x_Cuenta_DReader(ByVal cuenta As Integer, ByVal empresa As Integer, ByVal ayo As Integer) As SqlDataReader
            Try
                Return SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_DH_MENSUAL_WEB", cuenta, empresa, ayo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function get_Cuentas_por_Titulos(ByVal titulos As String, ByVal empresa As Integer, ByVal periodo As Integer, ByVal digitos As Integer) As DataTable
            Dim query As New System.Text.StringBuilder
            query.Append("SELECT   PC_NUM_CUENTA as Cuenta, PC_DESCRIPCION  as Descripcion ,PC_IDCUENTA as IdCuenta        ")
            query.Append("FROM SG_CO_TB_PLANCTAS WHERE PC_PERIODO = " & periodo.ToString & " AND PC_IDEMPRESA = " & empresa.ToString & " AND PC_IDTIPO_MOV = 2    ")
            query.Append("and left(PC_NUM_CUENTA," & digitos.ToString & ") in (" & titulos & ")")
            query.Append("ORDER BY PC_NUM_CUENTA     ")
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query.ToString).Tables(0)

        End Function


        Public Sub setCodigos(ByVal codigos As List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP))
            Try
                Dim Obj_ContabilidadDA As New ContabilidadDA
                Obj_ContabilidadDA.setCodigos(codigos)
                Obj_ContabilidadDA = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub setSaldos_Cuentas(ByVal cuentas As List(Of String), ByVal anho_ As Integer, ByVal mes_ As Integer, ByVal pc_ As String, ByVal empresa_ As Integer)
            Try
                Dim Obj_ContabilidadDA As New ContabilidadDA
                Obj_ContabilidadDA.setSaldos_Cuentas(cuentas, anho_, mes_, pc_, empresa_)
                Obj_ContabilidadDA = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Grabar_Ctas_Ant_Mes(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal pc_ As String, ByVal empresa_ As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_CTA_ANT_MES", ayo_, mes_, pc_, empresa_)
        End Sub

        Public Function getLibro_Mayor(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_MAYOR", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_TERMINAL, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLibro_Bancos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BANCOS", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_TERMINAL, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLibro_Caja(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CAJA", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_TERMINAL, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function getLibro_Diario(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getLibro_Diario = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DIARIO", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_TERMINAL, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getLibro_Diario_Asientos_Descuadrados(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getLibro_Diario_Asientos_Descuadrados = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DIARIO_2", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_TERMINAL, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getRegistro_Compras(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getRegistro_Compras = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_REG_COMPRAS", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID, Entidad.AC_ESTADO).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getw_Registro_Compras1(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getw_Registro_Compras1 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_REG_COMPRAS_1", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getConciliacionBanco1(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO) As DataTable
            getConciliacionBanco1 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_MOV_SIN_CONCI", Entidad.SMB_ANHO, Entidad.SMB_CUENTA, Entidad.SMB_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getConciliacionBanco2(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO) As DataTable
            getConciliacionBanco2 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_EXTRACTO_BANCARIO", Entidad.SMB_ANHO, Entidad.SMB_MES, Entidad.SMB_CUENTA, Environment.MachineName, Entidad.SMB_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getRegistro_Ventas(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getRegistro_Ventas = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VENTAS", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getW_Registro_Ventas1(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getW_Registro_Ventas1 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_VENTAS1", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getRegistro_Honorarios(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getRegistro_Honorarios = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_REG_HONO", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getw_Registro_Honorarios1(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getw_Registro_Honorarios1 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_REG_HONO1", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getHistorial_Docs(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal empresa As Integer) As DataTable
            getHistorial_Docs = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_HISTO_DOC", tipo, serie, numero, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getW_Busca_Docs(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal empresa As Integer) As DataTable
            getW_Busca_Docs = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_BUSCA_DOC", tipo, serie, numero, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getHistorial_Docs_x_Anexo(ByVal IdAnexo As Integer, ByVal empresa As Integer) As DataTable
            getHistorial_Docs_x_Anexo = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_HISTO_DOC_X_ANEXO", IdAnexo, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getW_Busca_Docs_x_Anexo(ByVal IdAnexo As Integer, ByVal empresa As Integer) As DataTable
            getW_Busca_Docs_x_Anexo = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_BUSCA_DOC_X_ANEXO", IdAnexo, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getAnalisis_por_cuenta(ByVal fec1 As String, ByVal fec2 As String, ByVal cta1 As String, ByVal cta2 As String, ByVal ane1 As Integer, ByVal ane2 As Integer, ByVal pendiente As Integer, ByVal anho As Integer, ByVal empresa As Integer) As DataTable
            getAnalisis_por_cuenta = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ANALISIS3", fec1, fec2, cta1, cta2, ane1, ane2, pendiente, anho, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function get_Analisis_por_Cuenta_sinAnexo(ByVal cta_ini As String, ByVal cta_fin As String, ByVal fec_ini As String, ByVal fec_fin As String, ByVal ayo As Integer, ByVal idEmpresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ANALISIS3_A", fec_ini, fec_fin, cta_ini, cta_fin, ayo, idEmpresa).Tables(0)
        End Function

        Public Function getBalance_Comprobacion_1(ByVal Int_Ayo As Int16, ByVal Int_Mes As Integer, ByVal Int_Empresa As Integer, ByVal Str_Cuenta1 As String, ByVal Str_Cuenta2 As String, ByVal bol_con_cta_tit As Boolean, ByVal tipo As Integer, ByVal dig_cta_tit_ As Integer, ByVal ant_cierre_ As Integer) As DataTable
            getBalance_Comprobacion_1 = Nothing
            If Str_Cuenta1 = String.Empty And Str_Cuenta2 = String.Empty Then
                Str_Cuenta1 = "000000"
                Str_Cuenta2 = "999999"
            End If

            If ant_cierre_ = 1 Then
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BAL_COMPRO_1B", Int_Ayo, Int_Mes, Int_Empresa, Str_Cuenta1, Str_Cuenta2, dig_cta_tit_, tipo, IIf(bol_con_cta_tit, 1, 0)).Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BAL_COMPRO_1", Int_Ayo, Int_Mes, Int_Empresa, Str_Cuenta1, Str_Cuenta2, dig_cta_tit_, tipo, IIf(bol_con_cta_tit, 1, 0)).Tables(0)
            End If



        End Function

        Public Sub setCuentas_Balance_Comprobacion(ByVal Int_Ayo As Int16, ByVal Int_Mes As Integer, ByVal Int_Empresa As Integer, ByVal Str_Cuenta As String)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_S_BAL_COMPRO_2", Int_Ayo, Int_Mes, Int_Empresa, Str_Cuenta)
        End Sub

        Public Sub Limpiar_Tabla_Balance_Compro()
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "delete from SG_CO_TB_REP_BAL_COMPRO")
        End Sub

        Public Function getBalance_Comprobacion_2(ByVal Str_Cuenta_Ini As String, ByVal Str_Cuenta_Fin As String) As DataTable
            getBalance_Comprobacion_2 = Nothing
            Dim StrQuqry As String = "SELECT BC_CUENTA AS CUENTA,BC_DESCRIPCION AS DESCRIPCION,BC_MOV_DEBE AS DEBE,BC_MOV_HABER AS HABER,BC_SAL_DEBE AS SALDO_DEUDOR,BC_SAL_HABER AS SALDO_ACREEDOR FROM SG_CO_TB_REP_BAL_COMPRO ORDER BY  BC_CUENTA "
            If Str_Cuenta_Ini <> String.Empty And Str_Cuenta_Fin <> String.Empty Then
                StrQuqry = "SELECT BC_CUENTA AS CUENTA,BC_DESCRIPCION AS DESCRIPCION,BC_MOV_DEBE AS DEBE,BC_MOV_HABER AS HABER,BC_SAL_DEBE AS SALDO_DEUDOR,BC_SAL_HABER AS SALDO_ACREEDOR FROM SG_CO_TB_REP_BAL_COMPRO WHERE BC_CUENTA between '" & Str_Cuenta_Ini & "' and '" & Str_Cuenta_Fin & "' ORDER BY  BC_CUENTA "
            End If
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuqry).Tables(0)
        End Function

        Public Sub setImportes_Balance_Gral(ByVal clase As Integer, ByVal grupo As Integer, ByVal cuenta As String, ByVal ayo As Integer, ByVal mes As Integer, ByVal empresa As Integer, ByVal es_mensual As Boolean)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_S_BG_1", clase, grupo, cuenta, ayo, mes, empresa, IIf(es_mensual, 1, 0))
        End Sub

        Public Sub Limpiar_Tabla_Balance_Gral()
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "delete from SG_CO_TB_REP_BG10")
        End Sub

        Public Sub setActualizar_Importe_PasivoPatrimonio()
            Dim query As String = "update SG_CO_TB_REP_BG10 set rb_importe2 = (select sum(rb_importe) from SG_CO_TB_REP_BG10 where rb_idmod in (3,4,5))"
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)

            
        End Sub

        Public Sub set_Actualiza_Importe_CajaBancos_Cero()
            'aqui de paso actualizamos a cero el importe de la cuenta 10 del balance
            Dim query As String = "update  SG_CO_TB_REP_BG10 set rb_importe = 0 where rb_nucuenta = 10 "
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Function getBalance_Gral_1() As DataTable
            getBalance_Gral_1 = Nothing
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, "select * from SG_CO_TB_REP_BG10").Tables(0)
        End Function

        Public Function getCuentas10s_sobreGiro(ByVal periodo As Integer, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CTAS_10_SOBREGIRO", periodo, empresa).Tables(0)
        End Function

        Public Sub setActualizar_Cta10_SobreGiro(ByVal cuenta As String, ByVal periodo As Integer, ByVal mes As Integer, ByVal empresa As Integer, ByVal acumulado As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_BAL_GRAL_1", cuenta, periodo, mes, empresa, acumulado)
        End Sub
        Public Sub set_Actualizar_Resultado_Ejercicio(ByVal ayo As Integer, ByVal mes As Integer, ByVal empresa As Integer, ByVal cuenta_resultado As String)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_S_RESUL_BAL_COMPRO_CTA89", ayo, mes, empresa, "000000", "9999999", cuenta_resultado)
        End Sub

        Public Sub Set_Cuentas_Rango_a_Tmp(ByVal desde As String, ByVal hasta As String, ByVal periodo As Integer, ByVal pc As String, ByVal empresa As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_CTAS_RANGO_A_TMP", desde, hasta, periodo, pc, empresa)
        End Sub

        Public Function get_Reporte_Mov_Anual_x_Cuenta_V2(ByVal nivel As Integer, ByVal periodo As Integer, ByVal pc As String, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_REP_MOV_ANUAL_X_CTA_V2", nivel, periodo, pc, empresa).Tables(0)
        End Function

        Public Function get_Cuentas_x_Rango(ByVal desde As String, ByVal hasta As String, ByVal periodo As Integer, ByVal empresa As Integer) As List(Of String)
            Dim listado As New List(Of String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_CTAS_X_RANGO", desde, hasta, periodo, empresa)

            If drr.HasRows Then
                Do While drr.Read
                    listado.Add(drr("PC_NUM_CUENTA"))
                Loop
            End If

            drr.Close()
            drr = Nothing

            Return listado
        End Function

        Public Sub Limpiar_Tabla_Reporte(ByVal Tabla As String, Optional ByVal where As String = "")
            Dim query As String = "Delete from " & Tabla
            If where.Length > 0 Then
                query = query & where
            End If

            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Sub Insert_Mov_Anual_x_Cuenta(ByVal cuenta As String, ByVal lista_meses As List(Of Double), ByVal pc As String)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_MOV_ANUAL_X_CTA", cuenta, "", _
                                      lista_meses(0), lista_meses(1), lista_meses(2), lista_meses(3), lista_meses(4), lista_meses(5), _
                                      lista_meses(6), lista_meses(7), lista_meses(8), lista_meses(9), lista_meses(10), lista_meses(11), _
                                      pc)
        End Sub

        Public Function get_Mov_Anual_x_Cuenta(ByVal ayo As Integer, ByVal mes As Integer, ByVal cuenta As String, ByVal empresa As Integer) As Double
            Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_MOV_ANUAL_X_CTA", ayo, mes, cuenta, empresa)
        End Function

        Public Function get_Reporte_Mov_Anual_x_Cuenta(ByVal periodo As Integer, ByVal empresa As Integer) As DataTable
            get_Reporte_Mov_Anual_x_Cuenta = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_REP_MOV_ANUAL_X_CTA", periodo, empresa).Tables(0)
        End Function

        Public Function get_Reporte_Mov_X_Cc(ByVal periodo As Integer, ByVal mes1 As Integer, ByVal mes2 As Integer, ByVal empresa As Integer, ByVal pc1 As String, ByVal pc2 As String) As DataTable
            get_Reporte_Mov_X_Cc = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_R_CC_X_CTA", periodo, mes1, mes2, empresa, pc1, pc2).Tables(0)
        End Function

        Public Function get_Movimiento_por_Cuentas(ByVal cuenta As String, ByVal empresa As Integer, ByVal ayo As Integer, ByVal mes As Integer, ByVal anexo As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ANALISIS4", cuenta, empresa, ayo, mes, anexo).Tables(0)
        End Function

        Public Function get_Kardex_por_Anexo(ByVal empresa As Integer, ByVal anexo As Integer, ByVal td As String, ByVal ta As Integer, ByVal ayo As Integer, ByVal mes As Integer, ByVal conSaldo As Boolean) As DataTable
            Dim myQuery As New System.Text.StringBuilder

            myQuery.Append("SELECT  AN_NUM_DOC as RUC,AN_DESCRIPCION as RAZON,")
            myQuery.Append("MIN(AD_FDOC) AS FEC_EMISION,C.DO_ABREVIATURA as TD,AD_SDOC as SD,AD_NDOC as ND,")
            myQuery.Append("SUM((CASE WHEN AD_TANEXO IN (1) THEN AD_DEBE ELSE AD_HABER END)) AS PROVISION,")
            myQuery.Append("SUM((CASE WHEN AD_TANEXO IN (1) THEN AD_HABER ELSE AD_DEBE END)) AS PAGO,")
            myQuery.Append("ABS(SUM(AD_DEBE)-SUM(AD_HABER)) AS SALDO ")
            myQuery.Append("FROM SG_CO_TB_ASIENTO_DET A ")
            myQuery.Append("INNER JOIN SG_CO_TB_ASIENTO_CAB B ON A.AD_IDCAB = B.AC_ID ")
            myQuery.Append("INNER JOIN SG_CO_TB_DOCUMENTO C ON A.AD_TDOC = C.DO_CODIGO ")
            myQuery.Append("INNER JOIN SG_CO_TB_ANEXO D ON A.AD_IDANEXO = D.AN_IDANEXO ")
            myQuery.Append(String.Format("WHERE B.AC_IDEMPRESA = {0} ", empresa))
            myQuery.Append("AND C.DO_IDEMPRESA  =  " & empresa & " ")
            myQuery.Append("AND AC_ANHO = " & ayo & " ")
            If anexo > 0 Then myQuery.Append("AND AD_IDANEXO =  " & anexo & " ")
            If td.Length > 0 Then myQuery.Append("AND AD_TDOC = " & td & " ")
            If mes > 0 Then myQuery.Append("AND AC_MES = " & mes & " ")
            myQuery.Append("AND AD_TANEXO = " & ta & " ")
            myQuery.Append("GROUP BY AD_IDANEXO,AN_NUM_DOC,AN_DESCRIPCION,C.DO_ABREVIATURA,AD_SDOC,AD_NDOC ")
            If conSaldo Then myQuery.Append("HAVING SUM(AD_DEBE)-SUM(AD_HABER)<>0 ")
            myQuery.Append("ORDER BY FEC_EMISION ")

            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, myQuery.ToString).Tables(0)

        End Function


        Public Sub Limpiar_Tabla_Saldos_Mayor()
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "DELETE FROM SG_CO_TB_SALDOMAYOR")
        End Sub

        Public Sub set_Saldos_Mayor(ByVal Int_Ayo As Int16, ByVal Int_Mes As Integer, ByVal Int_Empresa As Integer, ByVal Str_Cuenta As String)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_S_SALDOMAYOR_1", Int_Ayo, Int_Mes, Int_Empresa, Str_Cuenta)
        End Sub

        Public Function get_Saldo_Mayor_ConCtasTitulo()
            Dim query As String = "SELECT SM_CUENTA AS CUENTA,SM_DESCRIPCION AS DESCRIPCION,(SM_INICIAL_DEBE-SM_INICIAL_HABER) AS INICIAL,SM_MOV_DEBE AS DEBE,SM_MOV_HABER AS HABER,(SM_SAL_DEBE - SM_SAL_HABER ) AS SALDO FROM SG_CO_TB_SALDOMAYOR "
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Saldo_Mayor_SinCtasTitulo(ByVal ayo As Integer, ByVal mes As Integer, ByVal empresa As Integer, ByVal cuentaIni As String, ByVal cuentaFin As String)
            If cuentaIni = String.Empty And cuentaFin = String.Empty Then
                cuentaIni = "0000000"
                cuentaFin = "9999999"
            End If
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_SALDOMAYOR_2", ayo, mes, empresa, cuentaIni, cuentaFin).Tables(0)
        End Function


        Public Function get_DAOT(ByVal anho As Integer, ByVal tipo As Integer, ByVal tope As Double, ByVal empresa As Int16) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DAOT", anho, tipo, tope, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_2_cta10(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_2_CTA10", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_3_cta12(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_3_CTA12", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_4_cta14(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_4_CTA14", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_5_cta16(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_5_CTA16", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_11_cta41(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_11_CTA41", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_12_cta42(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_12_CTA42", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_13_cta46(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_13_CTA46", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_5_cta19(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_5_CTA19", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_5_cta34(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_5_CTA34", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_10_cta40(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_10_CTA40", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_12_cta42_det(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_12_CTA42_DET", periodo, empresa).Tables(0)
        End Function

        Public Function get_BI_formato_3_12_cta43(ByVal periodo As Integer, ByVal empresa As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BI_F3_12_CTA43", periodo, empresa).Tables(0)
        End Function


        Public Sub set_Grabar_Cabecera_DetCta50(ByVal RC_AYO As Int16, ByVal RC_CS As Double, ByVal RC_VN As Double, ByVal RC_NA1 As Double, ByVal RC_NA2 As Double, ByVal RC_NA3 As Double, ByVal RC_IDEMPRESA As Int16)
            Dim query As String = "DELETE FROM SG_CO_TB_REP50C WHERE RC_AYO = " & RC_AYO.ToString & " AND RC_IDEMPRESA = " & RC_IDEMPRESA.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)

            query = "insert into SG_CO_TB_REP50C(RC_AYO,RC_CS,RC_VN,RC_NA1,RC_NA2,RC_NA3,RC_IDEMPRESA)values(" & RC_AYO & "," & RC_CS & "," & RC_VN & "," & RC_NA1 & "," & RC_NA2 & "," & RC_NA3 & "," & RC_IDEMPRESA & ")"
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)

            query = "DELETE FROM SG_CO_TB_REP50D WHERE RD_AYO = " & RC_AYO.ToString & " AND RD_IDEMPRESA  = " & RC_IDEMPRESA.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)

        End Sub

        Public Sub set_Grabat_Detalle_DetCta50(ByVal RC_AYO As Integer, ByVal RC_IDEMPRESA As Int16, ByVal TIPO_DOC As String, ByVal NUM_DOC As String, ByVal RAZON As String, ByVal TIPO_ACCION As String, ByVal NUM_ACCIONES As Integer, ByVal POR_ACCIONES As Double)
            Dim query As String = "insert into SG_CO_TB_REP50D(RD_AYO,RD_IDEMPRESA,RD_TIPO_DOC,RD_NUM_DOC,RD_RAZON,RD_TIPO_ACCION,RD_NUM_ACCIONES,RD_POR_ACCIONES)values(" & RC_AYO & "," & RC_IDEMPRESA & ",'" & TIPO_DOC & "','" & NUM_DOC & "','" & RAZON & "','" & TIPO_ACCION & "'," & NUM_ACCIONES & "," & POR_ACCIONES & ")"
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Function get_Grabar_Cabecera_DetCta50(ByVal ayo As Integer, ByVal empresa As Integer) As DataTable
            Dim query As String = "SELECT RC_CS,RC_VN,RC_NA1,RC_NA2,RC_NA3 FROM SG_CO_TB_REP50C WHERE RC_AYO = " & ayo.ToString & " AND RC_IDEMPRESA = " & empresa.ToString
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Grabat_Detalle_DetCta50(ByVal ayo As Integer, ByVal empresa As Integer) As DataTable
            Dim query As String = "SELECT RD_TIPO_DOC,RD_NUM_DOC,RD_RAZON,RD_TIPO_ACCION,RD_NUM_ACCIONES,RD_POR_ACCIONES FROM SG_CO_TB_REP50D WHERE RD_AYO = " & ayo.ToString & " AND RD_IDEMPRESA  = " & empresa.ToString
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Reporte_EGP(ByVal ayo As Integer, ByVal mes As Integer, ByVal empresa As Integer, ByVal formato As Integer) As DataTable
            get_Reporte_EGP = Nothing

            Select Case formato
                Case 1 'acumulado
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_REP_EGP", empresa, ayo, mes, 0).Tables(0)
                Case 2 'acumulado comparativo
                    Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_REP_EGP", empresa, ayo, mes, 0).Tables(0)
                    dt_tmp = Nothing
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_REP_EGP_COMPA", empresa, ayo - 1, mes, 0).Tables(0)
                Case 3 'mensual
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_REP_EGP", empresa, ayo, mes, 1).Tables(0)
                Case 4 'mensual comparativo
                    Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_REP_EGP", empresa, ayo, mes, 1).Tables(0)
                    dt_tmp = Nothing
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_REP_EGP_COMPA", empresa, ayo - 1, mes, 1).Tables(0)
            End Select
        End Function

    End Class
#End Region

#Region "Script para migrar asientos del sistema actual contable al nuevo"
    Public Class Migrador
        Inherits ClsBD

        Public Sub Migrar_Asiento_Compras(ByVal mes As String)
            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim ComprasBE As New BE.ContabilidadBE.SG_CO_TB_COMPRAS
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            Dim Str_serieDoc As String = String.Empty
            Dim Str_numDoc As String = String.Empty
            Dim Str_fechaDoc As String = String.Empty
            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0
            Dim Bol_Es_Mixta As Boolean = False
            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 30 order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1
                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "01"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi=3 AND m.Tip_Com = 30 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()
                Bol_Es_Mixta = False

                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Proveedor}
                                AnexoBE.AN_IDEMPRESA = EmpresaBE
                                AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Proveedor}
                                .AD_IDANEXO = AnexoBE

                                AnexoBL = Nothing
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                                .AD_SDOC = drr("Ser_Doc")
                                Str_serieDoc = drr("Ser_Doc")
                                .AD_NDOC = drr("Num_Doc")
                                Str_numDoc = drr("Num_Doc")
                                .AD_FDOC = drr("Fec_Asi")
                                Str_fechaDoc = drr("Fec_Asi")
                                .AD_VDOC = drr("Fec_Asi")

                            End If

                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")
                            If drr("inafecto").ToString = "1" Then Bol_Es_Mixta = True

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                Dim Dbl_Igv As Double = 0
                Dim Dbl_Base_Imp As Double = 0
                Dim Dbl_Total_cta42 As Double = 0

                For Each DetalleBE In ls_detalles
                    If DetalleBE.AD_CUENTA = "401112" Then Dbl_Igv += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)

                    Dim dr_Cta_Registros As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 1 AND RE_ID_TIPOCUENTA = 3")
                    If dr_Cta_Registros.HasRows Then
                        Do While dr_Cta_Registros.Read
                            If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                Dbl_Base_Imp += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                dr_Cta_Registros.Close()
                                GoTo Siguiente
                            End If
                        Loop
                    End If
                    dr_Cta_Registros.Close()


                    dr_Cta_Registros = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 1 AND RE_ID_TIPOCUENTA = 1")
                    If dr_Cta_Registros.HasRows Then
                        Do While dr_Cta_Registros.Read
                            If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                Dbl_Total_cta42 += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                dr_Cta_Registros.Close()
                                GoTo Siguiente
                            End If
                        Loop
                    End If
                    dr_Cta_Registros.Close()
Siguiente:
                Next




                With ComprasBE
                    .CO_IDCAB = CabeceraBE
                    .CO_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Proveedor}
                    .CO_ANEXO_ID = AnexoBE
                    .CO_TIP_DOC = DocumentoBE
                    .CO_SER_DOC = Str_serieDoc
                    .CO_NUM_DOC = Str_numDoc

                    If Bol_Es_Mixta Then
                        .CO_INDICADOR_DESTINO = "03"
                    Else
                        .CO_INDICADOR_DESTINO = IIf(Dbl_Igv > 0, "01", "02")
                    End If


                    .CO_FEC_EMI = Str_fechaDoc
                    .CO_FEC_VEN = Str_fechaDoc
                    .CO_FEC_VOU = CabeceraBE.AC_FEC_VOUCHER
                    .CO_TIP_DOC_REF = Nothing
                    .CO_SER_DOC_REF = String.Empty
                    .CO_NUM_DOC_REF = String.Empty
                    .CO_FEC_EMI_REF = String.Empty
                    .CO_TASA_IGV = 18
                    .CO_MONTO_IGV = Dbl_Igv
                    .CO_TASA_ISC = 10
                    .CO_MONTO_ISC = 0
                    .CO_OTROS_TRIBUTOS = 0

                    .CO_IMPORTE_COMPRA = Dbl_Base_Imp
                    .CO_IMPORTE_PAGAR = Dbl_Total_cta42

                    .CO_MONTO_EXONERADO = IIf(Dbl_Igv = 0, .CO_IMPORTE_COMPRA, 0)

                    .CO_IMPORTE_VENTA = Dbl_Total_cta42
                    .CO_ES_AFECTO_DETRA = 0
                    .CO_TASA_DETRA = 0
                    .CO_IMPORTE_DETRA = 0
                    .CO_VALOR_RAZ_DETRA = 0
                    .CO_NUMERO_DETRA = 0
                    .CO_FEC_EMI_DETRA = String.Empty
                    .CO_TIPO_SERV_DETRA = String.Empty
                    .CO_SERV_DETRA = String.Empty
                    .CO_ES_AFECTO_PERCEP = 0
                    .CO_TASA_PERCEP = 0
                    .CO_ISTATUS = 1
                    .CO_TASA_4TA = 0
                    .CO_TOTAL_HONO = 0
                    .CO_MONTO_RET = 0
                    .CO_MONTO_PERCI = 0

                End With



                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab
                Try
                    AsientoBL.Insert_Compras(CabeceraBE, ComprasBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next




        End Sub

        Public Sub Migrar_Asiento_Ventas(ByVal Mes As String)
            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim VentasBE As New BE.ContabilidadBE.SG_CO_TB_VENTAS
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            Dim Str_serieDoc As String = String.Empty
            Dim Str_numDoc As String = String.Empty
            Dim Str_fechaDoc As String = String.Empty
            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0
            Dim Bol_Es_Mixta As Boolean = False
            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 20  order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1
                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "02"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi=3 AND m.Tip_Com = 20 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()
                Bol_Es_Mixta = False

                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                                AnexoBE.AN_IDEMPRESA = EmpresaBE
                                AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                                .AD_IDANEXO = AnexoBE

                                AnexoBL = Nothing
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                                .AD_SDOC = drr("Ser_Doc")
                                Str_serieDoc = drr("Ser_Doc")
                                .AD_NDOC = drr("Num_Doc")
                                Str_numDoc = drr("Num_Doc")
                                .AD_FDOC = drr("Fec_Asi")
                                Str_fechaDoc = drr("Fec_Asi")
                                .AD_VDOC = drr("Fec_Asi")

                            End If

                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")
                            'If drr("inafecto").ToString = "1" Then Bol_Es_Mixta = True

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                Dim Dbl_Igv As Double = 0
                Dim Dbl_Base_Imp As Double = 0
                Dim Dbl_Total_cta42 As Double = 0

                For Each DetalleBE In ls_detalles
                    If DetalleBE.AD_CUENTA = "401111" Then Dbl_Igv += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)

                    Dim dr_Cta_Registros As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 2 AND RE_ID_TIPOCUENTA = 4")
                    If dr_Cta_Registros.HasRows Then
                        Do While dr_Cta_Registros.Read
                            If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                Dbl_Base_Imp += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                dr_Cta_Registros.Close()
                                GoTo Siguiente
                            End If
                        Loop
                    End If
                    dr_Cta_Registros.Close()


                    dr_Cta_Registros = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 2 AND RE_ID_TIPOCUENTA = 2")
                    If dr_Cta_Registros.HasRows Then
                        Do While dr_Cta_Registros.Read
                            If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                Dbl_Total_cta42 += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                dr_Cta_Registros.Close()
                                GoTo Siguiente
                            End If
                        Loop
                    End If
                    dr_Cta_Registros.Close()
Siguiente:
                Next




                With VentasBE
                    .VE_IDCAB = CabeceraBE
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = AnexoBE
                    .VE_TIP_DOC = DocumentoBE
                    .VE_SER_DOC = Str_serieDoc
                    .VE_NUM_DOC = Str_numDoc

                    If Bol_Es_Mixta Then
                        .VE_INDICADOR_DESTINO = "03"
                    Else
                        .VE_INDICADOR_DESTINO = IIf(Dbl_Igv > 0, "01", "02")
                    End If


                    .VE_FEC_EMI = Str_fechaDoc
                    .VE_FEC_VEN = Str_fechaDoc
                    .VE_FEC_VOU = CabeceraBE.AC_FEC_VOUCHER
                    .VE_TIP_DOC_REF = Nothing
                    .VE_SER_DOC_REF = String.Empty
                    .VE_NUM_DOC_REF = String.Empty
                    .VE_FEC_EMI_REF = String.Empty
                    .VE_TASA_IGV = 18
                    .VE_MONTO_IGV = Dbl_Igv
                    .VE_TASA_ISC = 10
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_MONTO_EXONERADO = 0

                    .VE_VALOR_VENTA = Dbl_Base_Imp
                    .VE_PRECIO_VENTA = Dbl_Total_cta42

                    .VE_VALOR_INAFECTO = IIf(Dbl_Igv = 0, Dbl_Base_Imp, 0)
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Ventas(CabeceraBE, VentasBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next

        End Sub

        Public Sub Migrar_Asiento_Honorarios(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim ComprasBE As New BE.ContabilidadBE.SG_CO_TB_COMPRAS
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            Dim Str_serieDoc As String = String.Empty
            Dim Str_numDoc As String = String.Empty
            Dim Str_fechaDoc As String = String.Empty
            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 35 order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1
                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "03"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi=3 AND m.Tip_Com = 35 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Honorarios}
                                AnexoBE.AN_IDEMPRESA = EmpresaBE
                                AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Honorarios}
                                .AD_IDANEXO = AnexoBE

                                AnexoBL = Nothing
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                                .AD_SDOC = drr("Ser_Doc")
                                Str_serieDoc = drr("Ser_Doc")
                                .AD_NDOC = drr("Num_Doc")
                                Str_numDoc = drr("Num_Doc")
                                .AD_FDOC = drr("Fec_Asi")
                                Str_fechaDoc = drr("Fec_Asi")
                                .AD_VDOC = drr("Fec_Asi")

                            End If

                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")


                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                Dim Dbl_Retencion As Double = 0
                Dim Dbl_Total_Hono As Double = 0
                Dim Dbl_Recibido As Double = 0

                For Each DetalleBE In ls_detalles
                    If DetalleBE.AD_CUENTA = "401721" Then Dbl_Retencion += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)

                    Dim dr_Cta_Registros As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 4 AND RE_ID_TIPOCUENTA = 3")
                    If dr_Cta_Registros.HasRows Then
                        Do While dr_Cta_Registros.Read
                            If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                Dbl_Total_Hono += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                dr_Cta_Registros.Close()
                                GoTo Siguiente
                            End If
                        Loop
                    End If
                    dr_Cta_Registros.Close()


                    dr_Cta_Registros = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 4 AND RE_ID_TIPOCUENTA = 8")
                    If dr_Cta_Registros.HasRows Then
                        Do While dr_Cta_Registros.Read
                            If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                Dbl_Recibido += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                dr_Cta_Registros.Close()
                                GoTo Siguiente
                            End If
                        Loop
                    End If
                    dr_Cta_Registros.Close()
Siguiente:
                Next




                With ComprasBE
                    .CO_IDCAB = CabeceraBE
                    .CO_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Honorarios}
                    .CO_ANEXO_ID = AnexoBE
                    .CO_TIP_DOC = DocumentoBE
                    .CO_SER_DOC = Str_serieDoc
                    .CO_NUM_DOC = Str_numDoc
                    .CO_INDICADOR_DESTINO = "00"
                    .CO_FEC_EMI = Str_fechaDoc
                    .CO_FEC_VEN = Str_fechaDoc
                    .CO_FEC_VOU = CabeceraBE.AC_FEC_VOUCHER
                    .CO_TIP_DOC_REF = Nothing
                    .CO_SER_DOC_REF = String.Empty
                    .CO_NUM_DOC_REF = String.Empty
                    .CO_FEC_EMI_REF = String.Empty
                    .CO_TASA_IGV = 0
                    .CO_MONTO_IGV = 0
                    .CO_TASA_ISC = 10
                    .CO_MONTO_ISC = 0
                    .CO_OTROS_TRIBUTOS = 0

                    .CO_IMPORTE_COMPRA = 0
                    .CO_IMPORTE_PAGAR = 0

                    .CO_MONTO_EXONERADO = 0

                    .CO_IMPORTE_VENTA = 0
                    .CO_ES_AFECTO_DETRA = 0
                    .CO_TASA_DETRA = 0
                    .CO_IMPORTE_DETRA = 0
                    .CO_VALOR_RAZ_DETRA = 0
                    .CO_NUMERO_DETRA = 0
                    .CO_FEC_EMI_DETRA = String.Empty
                    .CO_TIPO_SERV_DETRA = String.Empty
                    .CO_SERV_DETRA = String.Empty
                    .CO_ES_AFECTO_PERCEP = 0
                    .CO_TASA_PERCEP = 0
                    .CO_ISTATUS = 1

                    .CO_TASA_4TA = 10
                    .CO_TOTAL_HONO = Dbl_Total_Hono
                    .CO_MONTO_RET = Dbl_Retencion
                    .CO_MONTO_PERCI = Dbl_Recibido

                End With



                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab
                Try
                    AsientoBL.Insert_Compras(CabeceraBE, ComprasBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next




        End Sub

        Public Sub Migrar_Asiento_CajaBancos_Egresos(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 2 AND m.Tip_Com = 10   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "05"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 2 AND m.Tip_Com = 10 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If



                                AnexoBL = Nothing


                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_CajaBancos_Ingresos(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 1 AND m.Tip_Com = 10   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "04"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 1 AND m.Tip_Com = 10 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_Diario_Varios(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 10   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "14"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 3 AND m.Tip_Com = 10 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_Diario_Ajustes(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 45   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "09"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 3 AND m.Tip_Com = 45 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_Diario_Apertura()

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2012"
            Dim Str_Mes As String = "01"
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = 1 AND m.Lib_Asi = 3 AND m.Tip_Com = 98   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "12"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 3 AND m.Tip_Com = 98 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = 1 AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" And drr("Tip_Doc").ToString <> "0" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_Diario_Planilla(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 40   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "10"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 3 AND m.Tip_Com = 40 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET

                        If drr("Num_Reg").ToString = "320" Then
                            Dim paco As Boolean = False
                            paco = Not paco
                        End If

                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Generales(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_Diario_Planilla_Horas(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 41   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "15"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 3 AND m.Tip_Com = 41 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub

        Public Sub Migrar_Asiento_Diario_Provisiones(ByVal Mes As String)

            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim Query As String = ""
            Dim Str_Ayo As String = "2011"
            Dim Str_Mes As String = Mes
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = Nothing
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0

            '_____________________________________________________________

            cnigf.Open()

            Query = "select * FROM Mov1 m WHERE m.Anho=" & Str_Ayo & " AND m.Per_asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa.ToString & " AND m.Lib_Asi = 3 AND m.Tip_Com = 55   order by num_com " ' AND m.Num_Com = 3"
            Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1

                With CabeceraBE
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "13"}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = Dt_cabeceras.Rows(i)("Anho")
                    .AC_MES = Dt_cabeceras.Rows(i)("Per_asi")
                    .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("Fec_Asi")
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                    .AC_DEBE = 0
                    .AC_HABER = 0
                    .AC_TC_OPE = 0
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("Des_Asi")
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = EmpresaBE
                End With

                Query = "SELECT * FROM Mov2 m WHERE m.Lib_Asi = 3 AND m.Tip_Com = 55 AND m.Anho = " & Str_Ayo & " AND m.Per_Asi = '" & Str_Mes & "' AND m.Codigo_Empresa = " & Int_Empresa & " AND m.Num_Com = " & Dt_cabeceras.Rows(i)("Num_Com") & " order by num_reg"

                Dbl_Debe_Cab = 0
                Dbl_Haber_Cab = 0
                ls_detalles.Clear()


                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                If drr.HasRows Then
                    Do While drr.Read
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = drr("Num_Reg")
                            .AD_CUENTA = drr("Num_Cta")
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If Not drr("Cod_Ane").Equals(String.Empty) And Not drr("Doc_Ane").ToString.Trim.Equals(String.Empty) Then
                                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                                AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                                'buscamos el tipo por la cuenta en el "plan de cuentas"
                                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                                PlanCtasBE.PC_NUM_CUENTA = drr("Num_Cta")
                                PlanCtasBE.PC_PERIODO = CInt(Str_Ayo)
                                PlanCtasBE.PC_IDEMPRESA = EmpresaBE

                                PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                                    AnexoBE.AN_NUM_DOC = drr("Doc_Ane")
                                    AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    AnexoBE.AN_IDEMPRESA = EmpresaBE
                                    AnexoBL.getAnexo_x_Ruc(AnexoBE)

                                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO}
                                    .AD_IDANEXO = AnexoBE
                                End If
                                AnexoBL = Nothing
                            End If

                            If drr("Tip_Doc").ToString.Trim <> "" Then
                                DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = drr("Tip_Doc")}
                                .AD_TDOC = DocumentoBE
                            End If

                            If drr("Ser_Doc").ToString.Trim <> "" Then .AD_SDOC = drr("Ser_Doc")
                            If drr("Num_Doc").ToString.Trim <> "" Then .AD_NDOC = drr("Num_Doc")
                            If drr("Fec_Asi").ToString.Trim <> "" Then .AD_FDOC = drr("Fec_Asi")

                            '.AD_VDOC = drr("Fec_Asi")


                            If drr("Deb_Hab") = "D" Then .AD_DEBE = drr("Mon_Mov") Else .AD_HABER = drr("Mon_Mov")
                            .AD_TCAM = drr("Tip_cam")
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = drr("Des_Mov")
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0
                            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("select COUNT(*) from SG_CO_TB_CTA_DESTINO WHERE CD_CTA_DESTINO = '{0}'", drr("Num_Cta"))) > 0 Then
                                .AD_ES_DESTINO = 1
                            End If

                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = drr("Mon_Reg")
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = drr("inafecto")

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)
                    Loop
                End If

                drr.Close()
                drr = Nothing

                CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                CabeceraBE.AC_HABER = Dbl_Haber_Cab

                Try
                    AsientoBL.Insert_Bancos(CabeceraBE, ls_detalles, Str_NumVoucher, False)
                Catch ex As Exception
                    Throw ex
                End Try

            Next
        End Sub


        Public Function get_Cabecera_Ventas_Novaq(ByVal ayo_ As Integer, ByVal Mes_ As String) As DataTable
            get_Cabecera_Ventas_Novaq = Nothing
            Dim Query As String = ""
            Dim cnigf As New SqlConnection(get_Cadena_Conexion_Comercial)

            Query = "SELECT DOCUMENT_ID,NUMBER_SERIE,RIGHT('0000000000'+NUMBER_DOCUMENT,10) AS 'NUMBER_DOCUMENT',DOCUMENT_DATE,CADUCATE_DATE,CUSTOMER_ID,abs(AMOUNT) as 'AMOUNT',SELL_RATE,CURRENCY_ID,COMMENT,abs(AMOUNT_TAX) as 'AMOUNT_TAX',STATUS,CUSTOMER_NAME ,CAST(0 AS BIT ) AS 'CONTA' FROM RECEIVABLE WHERE YEAR(DOCUMENT_DATE)=" & ayo_ & " AND MONTH(DOCUMENT_DATE)=" & Mes_ & " ORDER BY DOCUMENT_DATE,NUMBER_DOCUMENT"

            Return SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

        End Function

        Public Function Existe_Doc_de_Venta(ByVal td_ As String, ByVal sd_ As String, ByVal nd_ As String) As Boolean
            Dim rpta As Boolean = False
            Dim c As Integer = 0
            Dim tipdoc As String
            Dim query As String = String.Empty

            Select Case td_
                Case "FT"
                    tipdoc = "01"
                Case "BV"
                    tipdoc = "03"
                Case "NC"
                    tipdoc = "07"
                Case Else
                    tipdoc = "01"
            End Select

            query = "select count(*) from sg_Co_tb_ventas where ve_tip_doc = '" & tipdoc & "'  and ve_ser_doc = '" & sd_ & "' and ve_num_doc = '" & nd_ & "' "
            c = SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)

            If c > 0 Then rpta = Not rpta

            Return rpta

        End Function

        Public Sub Actualizar_Datos_Cliente_Novaq()

            Dim cnNq As New SqlConnection(get_Cadena_Conexion_Comercial)
            Dim Int_Empresa As Integer = 1
            Dim Query As String = ""
            Dim str_ruc As String = ""
            Dim idcliente As Integer = 0
            Dim dt_clientes As DataTable = SqlHelper.ExecuteDataset(cnNq, CommandType.Text, "select * from CUSTOMER").Tables(0)
            Dim clienteBL As New SG_CO_TB_ANEXO
            Dim clienteBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

            Dim razon_soci As String = ""
            Dim dir_fis As String = ""
            Dim telf1 As String = ""
            Dim mail As String = ""
            Dim fax1 As String = ""
            Dim web As String = ""
            Dim repre As String = ""


            For i As Integer = 0 To dt_clientes.Rows.Count - 1

                clienteBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                clienteBE.AN_NUM_DOC = dt_clientes.Rows(i)("VAT_REGISTRATION").ToString
                clienteBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}
                clienteBL.getAnexo_x_Ruc(clienteBE)
                idcliente = clienteBE.AN_IDANEXO

                razon_soci = dt_clientes.Rows(i)("VAT_REGISTRATION").ToString.Trim()
                dir_fis = dt_clientes.Rows(i)("ADDR").ToString.Trim()
                telf1 = dt_clientes.Rows(i)("PHONE").ToString.Trim()
                mail = dt_clientes.Rows(i)("EMAIL").ToString.Trim()
                fax1 = dt_clientes.Rows(i)("FAX_NUMBER").ToString.Trim()
                web = dt_clientes.Rows(i)("WEBSITE").ToString.Trim()
                repre = dt_clientes.Rows(i)("CONTACT").ToString.Trim()

                If SqlHelper.ExecuteScalar(Cn, CommandType.Text, "SELECT COUNT(*) FROM DBO.SG_CO_TB_CLIENTES WHERE CL_IDCLIENTE = " & idcliente.ToString) = 0 Then
                    Query = "insert into SG_CO_TB_CLIENTES(cl_idcliente,cl_razon_social,cl_dir_fiscal,cl_dir_legal,cl_telef1,cl_telef2,cl_email,cl_fax1,cl_fax2,cl_website,cl_representante_legal)"
                    Query = Query & " values(" & idcliente & ",'" & razon_soci & "','" & dir_fis & "','" & dir_fis & "','" & telf1 & "','" & telf1 & "','" & mail & "','" & fax1 & "','" & fax1 & "','" & web & "','" & repre & "')"
                Else
                    Query = "update SG_CO_TB_CLIENTES set cl_razon_social = '" & razon_soci & "', cl_dir_fiscal = '" & dir_fis & "', cl_dir_legal = '" & dir_fis & "',cl_telef1 = '" & telf1 & "',cl_telef2 = '" & telf1 & "',cl_email = '" & mail & "',cl_fax1 = '" & fax1 & "',cl_fax2 = '" & fax1 & "',cl_website = '" & web & "', cl_representante_legal = '" & repre & "' "
                    Query = Query & " where cl_idcliente = " & idcliente.ToString
                End If

                SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, Query)

            Next





        End Sub

        Public Sub Migrar_Asiento_Ventas_Comercial(ByVal ayo_ As Integer, ByVal Mes_ As String, ByVal cta12 As String, ByVal cta12Rel As String, ByVal cta40 As String, ByVal bol_conCaja_ As Boolean, ByVal subdia_caja_ As String, ByVal cta_caja_ As String, ByVal dt_Comprobantes_ As DataTable)


            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim DetalleBE As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim VentasBE As New BE.ContabilidadBE.SG_CO_TB_VENTAS
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim ls_detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim Str_NumVoucher As String = String.Empty

            Dim cnigf As New SqlConnection(get_Cadena_Conexion_Comercial)

            Dim Query As String = ""
            Dim Str_Ayo As String = ayo_
            Dim Str_Mes As String = Mes_
            Dim Int_Empresa As Integer = 1
            Dim Dt_cabeceras As DataTable = dt_Comprobantes_
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Int_Empresa}

            Dim AnexoBE As BE.ContabilidadBE.SG_CO_TB_ANEXO
            Dim DocumentoBE As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            Dim Str_serieDoc As String = String.Empty
            Dim Str_numDoc As String = String.Empty
            Dim Str_fechaDoc As String = String.Empty
            Dim Dbl_Debe_Cab As Double = 0
            Dim Dbl_Haber_Cab As Double = 0
            Dim Bol_Es_Mixta As Boolean = False

            Dim td_nq As String = ""
            Dim sd_nq As String = ""
            Dim nd_nq As String = ""
            Dim fd_nq As String = ""
            Dim vd_nq As String = ""
            Dim mo_nq As String = ""
            Dim anexo_nq As String = ""
            Dim tc_nq As Double = 0
            Dim igv_nq As Double = 0
            Dim tot_nq As Double = 0
            Dim glosa_doc As String = ""
            Dim glosa_det As String = ""
            '_____________________________________________________________

            cnigf.Open()

            'Query = "SELECT DOCUMENT_ID,NUMBER_SERIE,NUMBER_DOCUMENT,DOCUMENT_DATE,CADUCATE_DATE,CUSTOMER_ID,abs(AMOUNT) as 'AMOUNT',SELL_RATE,CURRENCY_ID,COMMENT,abs(AMOUNT_TAX) as 'AMOUNT_TAX',STATUS,CUSTOMER_NAME FROM RECEIVABLE WHERE YEAR(DOCUMENT_DATE)=" & Str_Ayo & " AND MONTH(DOCUMENT_DATE)=" & Str_Mes & " ORDER BY DOCUMENT_DATE,NUMBER_DOCUMENT"
            'Dt_cabeceras = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)

            For i As Integer = 0 To Dt_cabeceras.Rows.Count - 1
                If Dt_cabeceras.Rows(i)("CONTA") = False Or Dt_cabeceras.Rows(i)("CONTA") = 0 Then


                    With CabeceraBE
                        .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = "02"}
                        .AC_NUM_VOUCHER = ""
                        .AC_ANHO = CInt(Str_Ayo)
                        .AC_MES = CInt(Str_Mes)
                        .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("DOCUMENT_DATE")
                        .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                        .AC_DEBE = 0
                        .AC_HABER = 0
                        .AC_TC_OPE = Dt_cabeceras.Rows(i)("SELL_RATE")
                        .AC_TC_ESPECIAL = 0
                        .AC_ESTADO = 1

                        If Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                            .AC_ESTADO = 0
                            .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("COMMENT") & "  (ANULADO)"
                        Else
                            .AC_GLOSA_VOU = Dt_cabeceras.Rows(i)("COMMENT")
                        End If


                        '0=conta
                        '1=interface
                        '2=carga
                        '3=migrador
                        .AC_ES_INTERFACE = 3


                        .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                        .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                        .AC_TERMINAL = Environment.MachineName
                        .AC_FECREG = Date.Now
                        .AC_IDEMPRESA = EmpresaBE
                    End With

                    td_nq = Dt_cabeceras.Rows(i)("DOCUMENT_ID")
                    sd_nq = Dt_cabeceras.Rows(i)("NUMBER_SERIE")
                    nd_nq = Dt_cabeceras.Rows(i)("NUMBER_DOCUMENT")
                    fd_nq = Dt_cabeceras.Rows(i)("DOCUMENT_DATE")
                    vd_nq = Dt_cabeceras.Rows(i)("CADUCATE_DATE")
                    mo_nq = Dt_cabeceras.Rows(i)("CURRENCY_ID")
                    tc_nq = Dt_cabeceras.Rows(i)("SELL_RATE")
                    igv_nq = Dt_cabeceras.Rows(i)("AMOUNT_TAX")
                    tot_nq = Dt_cabeceras.Rows(i)("AMOUNT")
                    anexo_nq = Dt_cabeceras.Rows(i)("CUSTOMER_ID")
                    glosa_det = Dt_cabeceras.Rows(i)("CUSTOMER_NAME")

                    Query = "SELECT * FROM RECEIVABLE_LINE WHERE DOCUMENT_ID = '" & td_nq & "' AND NUMBER_SERIE = '" & sd_nq & "' AND NUMBER_DOCUMENT = '" & nd_nq.Substring(3, 7) & "'"

                    Dbl_Debe_Cab = 0
                    Dbl_Haber_Cab = 0
                    glosa_doc = String.Empty
                    ls_detalles.Clear()
                    Bol_Es_Mixta = False
                    Dim contador As Integer = 0
                    Dim Tasa_igv As Double = 0

                    Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                    If drr.HasRows Then
                        Do While drr.Read

                            If drr("PART_ID") <> "TEXTO" And drr("PART_ID") <> "SNIGV" Then
                                contador = contador + 1
                                Tasa_igv = drr("TAX_PERCENT")

                                DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                                With DetalleBE
                                    .AD_IDCAB = CabeceraBE
                                    .AD_SECUENCIA = contador.ToString.PadLeft(3, "0")
                                    .AD_CUENTA = get_Cuenta70_deArticulo(Int_Empresa, drr("PART_ID").ToString)
                                    .AD_TANEXO = Nothing
                                    .AD_IDANEXO = Nothing

                                    If drr("DOCUMENT_ID") = "FT" Then
                                        If mo_nq = "MN" Then
                                            .AD_DEBE = 0
                                            .AD_HABER = Math.Abs(drr("PRICE_ORI")) * Math.Abs(drr("QTY"))
                                        Else
                                            .AD_DEBE = 0.0R
                                            .AD_HABER = (Math.Abs(drr("PRICE_ORI")) * Math.Abs(drr("QTY"))) * tc_nq
                                        End If
                                    Else
                                        If mo_nq = "MN" Then
                                            .AD_DEBE = Math.Abs(drr("PRICE_ORI")) * Math.Abs(drr("QTY"))
                                            .AD_HABER = 0
                                        Else
                                            .AD_DEBE = (Math.Abs(drr("PRICE_ORI")) * Math.Abs(drr("QTY"))) * tc_nq
                                            .AD_HABER = 0
                                        End If
                                    End If


                                    If mo_nq = "MN" Then .AD_TCAM = 0 Else .AD_TCAM = tc_nq


                                    .AD_SEC_ORI_DESTINO = 0
                                    .AD_GLOSA = drr("TEXT_DESCRIPTION").ToString

                                    If glosa_doc = String.Empty Then
                                        glosa_doc = drr("PART_DESCRIPTION").ToString
                                    End If

                                    .AD_IDCC = Nothing

                                    .AD_ES_DESTINO = 0


                                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                                    .AD_TERMINAL = Environment.MachineName
                                    .AD_FECREG = Date.Now


                                    '.AD_MONTO_ORI = IIf(mo_nq = "MN", drr("PRICE_ORI") * drr("QTY"), (drr("PRICE_ORI") * drr("QTY")) * tc_nq)
                                    .AD_MONTO_ORI = drr("PRICE_ORI") * drr("QTY")


                                    .AD_PORCE_DESTINO = 0
                                    .AD_ES_INAFECTO = 0


                                    'si esta anulado en el comercial todo a cero(0)
                                    If Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                                        .AD_DEBE = 0
                                        .AD_HABER = 0
                                        .AD_MONTO_ORI = 0
                                    End If

                                End With

                                Dbl_Debe_Cab += DetalleBE.AD_DEBE
                                Dbl_Haber_Cab += DetalleBE.AD_HABER

                                ls_detalles.Add(DetalleBE)


                            End If 'de TEXTO



                        Loop
                    End If

                    drr.Close()
                    drr = Nothing




                    'una linea por la 40 de IGV ______________________________________________________________

                    If igv_nq > 0 Then

                        contador = contador + 1
                        DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        With DetalleBE

                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = contador.ToString.PadLeft(3, "0")
                            .AD_CUENTA = cta40
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing

                            If td_nq = "FT" Then
                                If mo_nq = "MN" Then
                                    .AD_DEBE = 0
                                    .AD_HABER = igv_nq
                                Else
                                    .AD_DEBE = 0.0R
                                    .AD_HABER = (igv_nq) * tc_nq
                                End If
                            Else
                                If mo_nq = "MN" Then
                                    .AD_DEBE = igv_nq
                                    .AD_HABER = 0
                                Else
                                    .AD_DEBE = (igv_nq) * tc_nq
                                    .AD_HABER = 0
                                End If
                            End If


                            If mo_nq = "MN" Then
                                .AD_TCAM = 0
                            Else
                                .AD_TCAM = tc_nq
                            End If

                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = glosa_det
                            .AD_IDCC = Nothing

                            .AD_ES_DESTINO = 0


                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_MONTO_ORI = IIf(mo_nq = "MN", igv_nq, (igv_nq) * tc_nq)
                            .AD_PORCE_DESTINO = 0
                            .AD_ES_INAFECTO = 0


                            'si esta anulado en el comercial todo a cero(0)
                            If Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                                .AD_DEBE = 0
                                .AD_HABER = 0
                                .AD_MONTO_ORI = 0
                            End If

                        End With

                        Dbl_Debe_Cab += DetalleBE.AD_DEBE
                        Dbl_Haber_Cab += DetalleBE.AD_HABER

                        ls_detalles.Add(DetalleBE)

                    End If

                    'Una linea por la 12 de clientes   ______________________________________________________

                    contador = contador + 1
                    DetalleBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                    With DetalleBE
                        .AD_IDCAB = CabeceraBE
                        .AD_SECUENCIA = contador.ToString.PadLeft(3, "0")
                        .AD_TANEXO = Nothing
                        .AD_IDANEXO = Nothing

                        If True Then
                            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                            AnexoBE = New BE.ContabilidadBE.SG_CO_TB_ANEXO

                            If Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                                Dim lista As List(Of String) = AnexoBL.get_Anexo_Anulado(Int_Empresa)
                                AnexoBE.AN_IDANEXO = lista(0)
                                AnexoBL.getAnexo(AnexoBE)
                            Else
                                AnexoBE.AN_NUM_DOC = anexo_nq
                                AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                                AnexoBE.AN_IDEMPRESA = EmpresaBE
                                AnexoBL.getAnexo_x_Ruc(AnexoBE)
                            End If

                            .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}


                            If AnexoBE.AN_IDANEXO = 0 Then
                                'registramos el anexo nuevo
                                AnexoBE.AN_DESCRIPCION = Dt_cabeceras.Rows(i)("CUSTOMER_NAME")
                                AnexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = 6}
                                AnexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = 2}
                                AnexoBE.AN_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Nuevo_Libreria")
                                AnexoBE.AN_PC_TERMINAL = Environment.MachineName
                                AnexoBE.AN_PC_FECREG = Date.Now
                                AnexoBE.AN_ES_RELACIONADO = 0
                                AnexoBL.Insert(AnexoBE)

                                AnexoBL.getAnexo_x_Ruc(AnexoBE)

                            End If

                            .AD_IDANEXO = AnexoBE


                            If AnexoBE.AN_ES_RELACIONADO Then
                                .AD_CUENTA = cta12Rel
                            Else
                                .AD_CUENTA = cta12
                            End If

                            AnexoBL = Nothing

                            Select Case td_nq
                                Case "FT"
                                    DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = "01"}
                                Case "BV"
                                    DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = "03"}
                                Case "NC"
                                    DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = "07"}
                                Case Else
                                    DocumentoBE = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = "01"}
                            End Select


                            .AD_TDOC = DocumentoBE
                            .AD_SDOC = sd_nq
                            Str_serieDoc = sd_nq
                            .AD_NDOC = nd_nq
                            Str_numDoc = nd_nq
                            .AD_FDOC = fd_nq
                            Str_fechaDoc = fd_nq
                            .AD_VDOC = vd_nq

                        End If

                        If td_nq = "FT" Then
                            If mo_nq = "MN" Then
                                .AD_DEBE = tot_nq
                                .AD_HABER = 0
                            Else
                                .AD_DEBE = (tot_nq) * tc_nq
                                .AD_HABER = 0
                            End If
                        Else
                            If mo_nq = "MN" Then
                                .AD_DEBE = 0
                                .AD_HABER = tot_nq
                            Else
                                .AD_DEBE = 0
                                .AD_HABER = (tot_nq) * tc_nq
                            End If
                        End If

                        If mo_nq = "MN" Then
                            .AD_TCAM = 0
                        Else
                            .AD_TCAM = tc_nq
                        End If

                        .AD_SEC_ORI_DESTINO = 0
                        .AD_GLOSA = glosa_det
                        .AD_IDCC = Nothing

                        .AD_ES_DESTINO = 0

                        .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                        .AD_TERMINAL = Environment.MachineName
                        .AD_FECREG = Date.Now
                        .AD_MONTO_ORI = IIf(mo_nq = "MN", tot_nq, (tot_nq) * tc_nq)
                        .AD_PORCE_DESTINO = 0
                        .AD_ES_INAFECTO = 0


                        'si esta anulado en el comercial todo a cero(0)
                        If Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                            .AD_DEBE = 0
                            .AD_HABER = 0
                            .AD_MONTO_ORI = 0
                        End If

                    End With

                    Dbl_Debe_Cab += DetalleBE.AD_DEBE
                    Dbl_Haber_Cab += DetalleBE.AD_HABER

                    ls_detalles.Add(DetalleBE)








                    'Calculos para la tabla de ventas(reporte) _______________________________________________


                    Dim Dbl_Igv As Double = 0
                    Dim Dbl_Base_Imp As Double = 0
                    Dim Dbl_Total_cta42 As Double = 0

                    For Each DetalleBE In ls_detalles
                        If DetalleBE.AD_CUENTA = cta40 Then Dbl_Igv += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)

                        Dim dr_Cta_Registros As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 2 AND RE_ID_TIPOCUENTA = 4")
                        If dr_Cta_Registros.HasRows Then
                            Do While dr_Cta_Registros.Read
                                If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                    Dbl_Base_Imp += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                    dr_Cta_Registros.Close()
                                    GoTo Siguiente
                                End If
                            Loop
                        End If
                        dr_Cta_Registros.Close()


                        dr_Cta_Registros = SqlHelper.ExecuteReader(Cn, CommandType.Text, "select RE_NUM_CTA from SG_CO_TB_REG_COM_VTA_HON WHERE RE_ID_EMPRESA = " & Int_Empresa.ToString & " AND RE_ID_OPERACION = 2 AND RE_ID_TIPOCUENTA = 2")
                        If dr_Cta_Registros.HasRows Then
                            Do While dr_Cta_Registros.Read
                                If Left(DetalleBE.AD_CUENTA, dr_Cta_Registros("RE_NUM_CTA").ToString.Length) = dr_Cta_Registros("RE_NUM_CTA") Then
                                    Dbl_Total_cta42 += IIf(DetalleBE.AD_DEBE > 0, DetalleBE.AD_DEBE, DetalleBE.AD_HABER)
                                    dr_Cta_Registros.Close()
                                    GoTo Siguiente
                                End If
                            Loop
                        End If
                        dr_Cta_Registros.Close()
Siguiente:
                    Next




                    With VentasBE
                        .VE_IDCAB = CabeceraBE
                        .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                        .VE_ANEXO_ID = AnexoBE
                        .VE_TIP_DOC = DocumentoBE
                        .VE_SER_DOC = Str_serieDoc
                        .VE_NUM_DOC = Str_numDoc

                        If Bol_Es_Mixta Then
                            .VE_INDICADOR_DESTINO = "03"
                        Else
                            .VE_INDICADOR_DESTINO = IIf(Dbl_Igv > 0, "01", "02")
                        End If


                        .VE_FEC_EMI = Str_fechaDoc
                        .VE_FEC_VEN = vd_nq
                        .VE_FEC_VOU = CabeceraBE.AC_FEC_VOUCHER
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                        .VE_TASA_IGV = Tasa_igv
                        .VE_MONTO_IGV = Dbl_Igv
                        .VE_TASA_ISC = 10
                        .VE_MONTO_ISC = 0
                        .VE_OTROS_TRIBUTOS = 0
                        .VE_MONTO_EXONERADO = IIf(Dbl_Igv = 0, Dbl_Base_Imp, 0)

                        .VE_VALOR_VENTA = Dbl_Base_Imp
                        .VE_PRECIO_VENTA = Dbl_Total_cta42

                        .VE_VALOR_INAFECTO = 0
                        .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}

                        'si esta anula en el comercial todo a cero(0)
                        If Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                            .VE_TASA_IGV = 0
                            .VE_MONTO_IGV = 0
                            .VE_TASA_ISC = 0
                            .VE_MONTO_ISC = 0
                            .VE_OTROS_TRIBUTOS = 0
                            .VE_MONTO_EXONERADO = 0
                            .VE_VALOR_VENTA = 0
                            .VE_PRECIO_VENTA = 0
                            .VE_VALOR_INAFECTO = 0
                        End If

                    End With

                    If Not Dt_cabeceras.Rows(i)("STATUS") = "A" Then
                        CabeceraBE.AC_DEBE = Dbl_Debe_Cab
                        CabeceraBE.AC_HABER = Dbl_Haber_Cab
                        CabeceraBE.AC_GLOSA_VOU = CabeceraBE.AC_GLOSA_VOU & " - " & glosa_doc
                    End If


                    Try
                        AsientoBL.Insert_Ventas(CabeceraBE, VentasBE, ls_detalles, Str_NumVoucher, False)
                    Catch ex As Exception
                        Throw ex
                    End Try



                    '___________CAJA __________________________________
                    'grabamos el asiento de caja si es relacionado
                    If AnexoBE.AN_ES_RELACIONADO = 1 And bol_conCaja_ Then


                        CabeceraBE = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB

                        With CabeceraBE
                            .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = subdia_caja_}
                            .AC_NUM_VOUCHER = ""
                            .AC_ANHO = CInt(Str_Ayo)
                            .AC_MES = CInt(Str_Mes)
                            .AC_FEC_VOUCHER = Dt_cabeceras.Rows(i)("DOCUMENT_DATE")
                            .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                            .AC_DEBE = Dbl_Total_cta42
                            .AC_HABER = Dbl_Total_cta42
                            .AC_TC_OPE = Dt_cabeceras.Rows(i)("SELL_RATE")
                            .AC_TC_ESPECIAL = 0
                            .AC_ESTADO = 1
                            .AC_GLOSA_VOU = "Cancelacion del Documento - " & td_nq & "-" & sd_nq & "-" & nd_nq
                            .AC_ES_INTERFACE = 3 '0=conta '1=interface '2=carga '3=migrador
                            .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                            .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AC_TERMINAL = Environment.MachineName
                            .AC_FECREG = Date.Now
                            .AC_IDEMPRESA = EmpresaBE
                        End With

                        Dim ls_DetallesCaja As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
                        Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()

                        'Cuenta 10 de Caja
                        With E_Detalle
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = 1
                            .AD_CUENTA = cta_caja_
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing
                            .AD_TDOC = Nothing
                            .AD_SDOC = String.Empty
                            .AD_NDOC = String.Empty
                            .AD_FDOC = String.Empty
                            .AD_VDOC = String.Empty
                            .AD_HABER = 0

                            If mo_nq = "MN" Then
                                .AD_DEBE = tot_nq
                            Else
                                .AD_DEBE = (tot_nq) * tc_nq
                            End If

                            .AD_MONTO_ORI = .AD_DEBE

                            .AD_PORCE_DESTINO = 0
                            .AD_TCAM = 0
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = CabeceraBE.AC_GLOSA_VOU
                            .AD_IDCC = Nothing
                            .AD_ES_DESTINO = 0
                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_IDMEDIOPAGO = Nothing

                        End With
                        ls_DetallesCaja.Add(E_Detalle)


                        'la cuenta clientes 13 de relacionado
                        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()

                        With E_Detalle
                            .AD_IDCAB = CabeceraBE
                            .AD_SECUENCIA = 2
                            .AD_CUENTA = cta12Rel
                            .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                            .AD_IDANEXO = AnexoBE
                            .AD_TDOC = DocumentoBE
                            .AD_SDOC = Str_serieDoc
                            .AD_NDOC = Str_numDoc
                            .AD_FDOC = Str_fechaDoc
                            .AD_VDOC = vd_nq
                            .AD_DEBE = 0

                            If mo_nq = "MN" Then
                                .AD_HABER = tot_nq
                            Else
                                .AD_HABER = (tot_nq) * tc_nq
                            End If

                            .AD_MONTO_ORI = .AD_HABER

                            .AD_PORCE_DESTINO = 0
                            .AD_TCAM = 0
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = CabeceraBE.AC_GLOSA_VOU
                            .AD_IDCC = Nothing
                            .AD_ES_DESTINO = 0
                            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Migracion")
                            .AD_TERMINAL = Environment.MachineName
                            .AD_FECREG = Date.Now
                            .AD_IDMEDIOPAGO = Nothing
                        End With
                        ls_DetallesCaja.Add(E_Detalle)


                        'grabamos el asiento de caja en el SUBDIARIO DE GENERALES
                        Try
                            AsientoBL.Insert_Generales(CabeceraBE, ls_DetallesCaja, Str_NumVoucher, False)
                        Catch ex As Exception
                            Throw New Exception("Error en el asiento de Caja - " & ex.Message)
                        End Try


                        ls_DetallesCaja.Clear()
                    End If


                End If

            Next

        End Sub

        Private Function get_Cadena_Conexion_Comercial() As String
            Dim str_cadena As String = ""

            Dim strPath As String = System.Environment.CurrentDirectory
            strPath = System.Reflection.Assembly.GetExecutingAssembly().Location
            strPath = strPath.Substring(0, strPath.Length - 7)

            Dim mINI As New cIniArray
            Dim sFicINI As String = strPath & "\conexion.ini"
            Dim sValor As String = ""

            Dim se As String = mINI.IniGet(sFicINI, "conectar2", "servidor", sValor)
            Dim ba As String = mINI.IniGet(sFicINI, "conectar2", "base", sValor)
            Dim us As String = mINI.IniGet(sFicINI, "conectar2", "usuario", sValor)
            Dim pw As String = mINI.IniGet(sFicINI, "conectar2", "pwd", sValor)

            str_cadena = String.Format("server={0};user={1};pwd={2};Initial catalog={3};Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True", se, us, pw, ba)

            Return str_cadena

        End Function

        Private Function get_Cuenta70_deArticulo(ByVal empresa As Integer, ByVal cod_art As String) As String
            Dim str_cuenta70 As String = String.Empty
            Dim query As String = "SELECT ISNULL(AC_CUENTA,'') FROM SG_CO_TB_ARTICULO_CUENTA WHERE AC_IDEMPRESA = " & empresa.ToString & " AND AC_IDARTICULO = '" & cod_art & "'"
            str_cuenta70 = SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)

            Return str_cuenta70

        End Function

    End Class
#End Region


    Public Class SG_CO_TB_CTAS_CIERRE
        Inherits ClsBD

        Public Function get_CuentasCierre(ByVal ayo As Integer, ByVal empresa As Integer) As DataTable
            Dim query As String = "SELECT CC_CUENTA_MARGEN_COMER,CC_CUENTA_VALOR_AGREGADO,CC_CUENTA_VALOR_EXCEDENTE,CC_CUENTA_RESUL_EXPLOTACION,CC_CUENTA_RESUL_ANTES_PARTI,CC_CUENTA_RESULTADO_EJER FROM SG_CO_TB_CTAS_CIERRE WHERE CC_ANHO = " & ayo.ToString & " AND CC_IDEMPRESA = " & empresa.ToString
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE)
            Dim query As String = String.Empty
            With Entidad
                query = String.Format("insert into SG_CO_TB_CTAS_CIERRE(CC_CUENTA_MARGEN_COMER,CC_CUENTA_VALOR_AGREGADO,CC_CUENTA_VALOR_EXCEDENTE,CC_CUENTA_RESUL_EXPLOTACION,CC_CUENTA_RESUL_ANTES_PARTI,CC_CUENTA_RESULTADO_EJER,CC_ANHO,CC_IDEMPRESA)values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})", .CC_CUENTA_MARGEN_COMER, .CC_CUENTA_VALOR_AGREGADO, .CC_CUENTA_VALOR_EXCEDENTE, .CC_CUENTA_RESUL_EXPLOTACION, .CC_CUENTA_RESUL_ANTES_PARTI, .CC_CUENTA_RESULTADO_EJER, .CC_ANHO, .CC_IDEMPRESA)
            End With
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE)
            Dim query As String = "delete from SG_CO_TB_CTAS_CIERRE WHERE CC_ANHO = " & Entidad.CC_ANHO.ToString & " AND CC_IDEMPRESA = " & Entidad.CC_IDEMPRESA.ToString

            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Function Generar_Cierre_Temporal_1(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CIERRE_CONTA_1", Entidad.CC_ANHO, Entidad.CC_IDEMPRESA).Tables(0)
        End Function

        Public Function Generar_Cierre_Temporal_2(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CIERRE_CONTA", Entidad.CC_ANHO, Entidad.CC_IDEMPRESA).Tables(0)
        End Function

        Public Function Generar_Apertura_Temporal(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_APERTURA_CONTA", Entidad.CC_ANHO, Entidad.CC_IDEMPRESA).Tables(0)
        End Function

    End Class


    Public Class SG_CO_TB_CTA_CONCEPTO_EGP
        Inherits ClsBD

        Public Function get_Ctas_X_Concepto(ByVal concepto As Int16, ByVal empresa As Int16) As DataTable
            Dim query As String = "SELECT * FROM SG_CO_TB_CTA_CONCEPTO_EGP WHERE CC_CONCEPTO = " & concepto.ToString & " AND CC_IDEMPRESA = " & empresa.ToString
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTA_CONCEPTO_EGP)
            Dim query As String = "INSERT INTO SG_CO_TB_CTA_CONCEPTO_EGP(CC_CUENTA,CC_CONCEPTO,CC_IDEMPRESA)VALUES('" & Entidad.CC_CUENTA & "'," & Entidad.CC_CONCEPTO & "," & Entidad.CC_IDEMPRESA & ")"
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Sub Limpiar_Tabla_Amarre(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTA_CONCEPTO_EGP)
            Dim query As String = "DELETE FROM SG_CO_TB_CTA_CONCEPTO_EGP WHERE  CC_IDEMPRESA = " & Entidad.CC_IDEMPRESA.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub


    End Class

    Public Class SG_CO_TB_CONCEPTO_EGP
        Inherits ClsBD

        Public Function get_Ctas_Titulo() As DataTable
            Dim query As String = "SELECT * FROM SG_CO_TB_CONCEPTO_EGP WHERE  CO_CTAS = 1"
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

    End Class

    Public Class MyCorreo
        Inherits ClsBD

        Public Sub Enviar_Correo_CuentaOlvidada(ByVal Str_Nombre_cuenta As String)

            Dim Dt_Data As DataTable
            Dim CorreoBL As New BL.ContabilidadBL.SG_CO_TB_CONF_CORREO_MENSAJE

            Dim para As String
            Dim De As String
            Dim De_nombre As String
            Dim asunto As String
            Dim mensaje As String

            Dt_Data = CorreoBL.getCorreos

            With Dt_Data.Rows(0)
                para = .Item("CCM_CORREO_PARA")
                De = .Item("CCM_CORREO_DE")
                De_nombre = .Item("CCM_CORREO_DE_NOMBRE")
                asunto = .Item("CCM_ASUNTO")
                mensaje = .Item("CCM_MENSAJE")
            End With


            mensaje = mensaje & " - " & Str_Nombre_cuenta
            Dt_Data.Dispose()

            Try
                Call Enviar_Correo(De, De_nombre, para, asunto, mensaje)
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Sub Enviar_Correo(ByVal De As String, ByVal De_nombre As String, ByVal para As String, ByVal asunto As String, ByVal mensaje As String)
            Dim correo As New System.Net.Mail.MailMessage
            Dim smtp As New System.Net.Mail.SmtpClient
            Dim host As String
            Dim usuarioHost As String
            Dim claveHost As String
            Dim Dt_Data As DataTable
            Dim HostBL As New BL.ContabilidadBL.SG_CO_TB_CONF_CORREO_HOST
            Dt_Data = HostBL.getHost()

            With Dt_Data.Rows(0)
                host = .Item("CC_HOST")
                usuarioHost = .Item("CC_USUARIO")
                claveHost = .Item("CC_CLAVE")
            End With

            Dt_Data.Dispose()


            correo.From = New System.Net.Mail.MailAddress(De, De_nombre)
            correo.To.Add(para)
            correo.Subject = asunto
            correo.Body = mensaje
            correo.IsBodyHtml = False
            correo.Priority = System.Net.Mail.MailPriority.Normal

            smtp.Host = host
            smtp.Credentials = New System.Net.NetworkCredential(usuarioHost, claveHost)

            Try
                smtp.Send(correo)
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

    End Class

    Public Class SG_CO_TB_CENTROCOSTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_CC", .CC_CODIGO, .CC_DESCRIPCION, .CC_USUARIO, .CC_TERMINAL, .CC_FECREG, .CC_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CC", .CC_CODIGO, .CC_DESCRIPCION, .CC_USUARIO, .CC_TERMINAL, .CC_FECREG, .CC_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_CC", .CC_CODIGO, .CC_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Generar_Codigo_CC(ByVal empresa As Integer) As Integer
            get_Generar_Codigo_CC = 0
            Dim query As String = "SELECT isnull(max(CC_CODIGO),0) FROM SG_CO_TB_CENTROCOSTO WHERE CC_IDEMPRESA = " & empresa.ToString
            Dim resultado As Integer = 0
            resultado = SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)
            resultado = resultado + 1
            Return resultado
        End Function

        Public Function getCentroCostos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CENTROCOSTO", Entidad.CC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function getCentroCostos_cmb(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CENTROCOSTO_2", Entidad.CC_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_CO_TB_CONF_CORREO_MENSAJE
        Inherits ClsBD

        Public Function getCorreos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_CO_SP_S_CONF_CORREO").Tables(0)
        End Function

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CONF_CORREO_MENSAJE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CONF_CORREO", .CCM_CORREO_PARA, .CCM_CORREO_DE, .CCM_CORREO_DE_NOMBRE, .CCM_ASUNTO, .CCM_MENSAJE)
            End With
        End Sub

    End Class

    Public Class SG_CO_TB_CONF_CORREO_HOST
        Inherits ClsBD

        Public Function getHost() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_CO_SP_S_CONF_CORREO_HOST").Tables(0)
        End Function

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CONF_CORREO_HOST)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CONF_CORREO_HOST", Entidad.CC_HOST, Entidad.CC_USUARIO, Entidad.CC_CLAVE)
        End Sub

    End Class

    Public Class SG_CO_TB_GRUPOBG_CUENTAS
        Inherits ClsBD

        Public Sub Delete(ByVal empresa As Integer)
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "DELETE FROM SG_CO_TB_GRUPOBG_CUENTAS WHERE GC_IDEMPRESA = " & empresa.ToString)
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPOBG_CUENTAS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_GRUPOBG_CUENTAS", .GC_IDGRUPO.GBG_ID, .GC_IDCUENTA.PC_NUM_CUENTA, .GC_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function getCuentas_x_Grupo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG, ByVal Int_IdEmpresa As Integer, ByVal ayo As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            getCuentas_x_Grupo = Nothing
            Dim myLista As New List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)

            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPOBG_CUENTAS", Entidad.GBG_ID, Int_IdEmpresa, ayo)

            If dr.HasRows Then
                Do While dr.Read
                    myLista.Add(New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("GC_IDCUENTA"), .PC_NUM_CUENTA = dr("PC_NUM_CUENTA"), .PC_DESCRIPCION = dr("PC_DESCRIPCION")})
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return myLista

        End Function
    End Class

    Public Class SG_CO_TB_GRUPOBG_RUBRO
        Inherits ClsBD

        Public Sub Limpiar_Tablas_Amarres_BG()

            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "DELETE FROM SG_CO_TB_GRUPOBG_RUBRO")
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "DELETE FROM SG_CO_TB_RUBRO_CUENTA")

        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPOBG_RUBRO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_GRUPOBG_RUBRO", Entidad.GR_IDGRUPO.GBG_ID, Entidad.GR_IDRUBRO.RU_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub



    End Class

    Public Class SG_CO_TB_RUBRO_CUENTA
        Inherits ClsBD

        Public Function getCuentas_x_Rubro(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_RUBRO) As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            getCuentas_x_Rubro = Nothing
            Dim myLista As New List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)

            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_RUBRO_X_CUENTA", Entidad.RU_ID)

            If dr.HasRows Then
                Do While dr.Read
                    myLista.Add(New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("PC_IDCUENTA"), .PC_NUM_CUENTA = dr("PC_NUM_CUENTA"), .PC_DESCRIPCION = dr("PC_DESCRIPCION")})
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return myLista
        End Function

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_RUBRO_CUENTA)
            Try

                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_RUBRO_CUENTA", Entidad.RC_IDRUBRO.RU_ID, Entidad.RC_IDCUENTA.PC_IDCUENTA)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

    Public Class SG_CO_TB_RUBRO
        Inherits ClsBD

        Public Function getRubros_x_Grupos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG) As List(Of BE.ContabilidadBE.SG_CO_TB_RUBRO)
            getRubros_x_Grupos = Nothing
            Dim mylista As New List(Of BE.ContabilidadBE.SG_CO_TB_RUBRO)
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPO_RUBRO", Entidad.GBG_ID)
            If dr.HasRows Then
                Do While dr.Read
                    mylista.Add(New BE.ContabilidadBE.SG_CO_TB_RUBRO(dr("GR_IDRUBRO"), dr("RU_CODIGO"), dr("RU_DESCRIPCION")))
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return mylista

        End Function

        Public Function getRubros() As List(Of BE.ContabilidadBE.SG_CO_TB_RUBRO)
            getRubros = Nothing
            Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_RUBRO)
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.StoredProcedure, "SG_CO_SP_S_RUBRO")

            If dr.HasRows Then
                Do While dr.Read
                    lista.Add(New BE.ContabilidadBE.SG_CO_TB_RUBRO(dr("RU_ID"), dr("RU_CODIGO"), dr("RU_DESCRIPCION")))
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return lista
        End Function

    End Class

    Public Class SG_CO_TB_GRUPOS_BG
        Inherits ClsBD

        Public Function getGrupos_x_Clase(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CLASES_BG) As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
            getGrupos_x_Clase = Nothing
            Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)

            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPOS_BG", Entidad.CBG_ID)

            If dr.HasRows Then
                Do While dr.Read
                    Lista.Add(New BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG(Entidad, dr("GBG_ID"), dr("GBG_DESCRIPCION")))
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return Lista

        End Function

    End Class

    Public Class SG_CO_TB_CLASES_BG
        Inherits ClsBD
        Public Function getClases() As List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
            getClases = Nothing
            Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.StoredProcedure, "SG_CO_SP_S_CLASES_BG")
            If dr.HasRows Then
                Do While dr.Read
                    lista.Add(New BE.ContabilidadBE.SG_CO_TB_CLASES_BG(dr("CBG_ID"), dr("CBG_DESCRIPCION")))
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return lista

        End Function

    End Class

    Public Class SG_CO_TB_TIPO_ASIENTO_ITF
        Inherits ClsBD

        Public Function getTipos() As DataTable
            getTipos = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_TIPO_ASIENTO_ITF").Tables(0)
        End Function

    End Class

    Public Class SG_CO_TB_PARAMETROSGENERALES
        Inherits ClsBD

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_PARAMETROSGENERALES", Entidad.PG_CLAVE_CONTROL_MES)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update_Correo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_PARA_GENE_1", Entidad.PG_CORREO_CTA_WEB)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update_Inicializadores(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_PARA_GENE_2", Entidad.PG_MARCADOR_PRORATEO)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getParametros() As DataTable
            getParametros = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PARAMETROSGENERALES").Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

       


    End Class

    Public Class SG_CO_TB_EMP_ITF
        Inherits ClsBD

        Public Sub Insert(ByVal parametros As List(Of BE.ContabilidadBE.SG_CO_TB_EMP_ITF))
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_EMP_ITF")

                For Each Entidad As BE.ContabilidadBE.SG_CO_TB_EMP_ITF In parametros
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_EMP_ITF", Entidad.EI_IDEMP.EM_ID, Entidad.EI_ES_ITF, Entidad.EI_IDSUBDIARIO.SD_ID, Entidad.EI_IDTIPO_ITF.TI_ID, Entidad.EI_CTA6, Entidad.EI_CTA9, Entidad.EI_CTA7)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete()
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_EMP_ITF")
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getControl_ITF() As DataTable
            getControl_ITF = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_EMP_ITF").Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getControl_ITF_x_Empresa(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_EMP_ITF)
            Try
                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_EMP_ITF_BY_EMP")
                If drr.HasRows Then
                    drr.Read()
                    Entidad.EI_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = drr("IDSUBDIARIO")}
                    Entidad.EI_IDTIPO_ITF = New BE.ContabilidadBE.SG_CO_TB_TIPO_ASIENTO_ITF With {.TI_ID = drr("IDTIPO_ITF")}
                    Entidad.EI_CTA6 = drr("EI_CTA6")
                    Entidad.EI_CTA7 = drr("EI_CTA7")
                    Entidad.EI_CTA9 = drr("EI_CTA9")
                    Entidad.EI_ES_ITF = drr("ES_ITF")
                End If

                drr.Close()
                drr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

    Public Class SG_CO_TB_PROVINCIA
        Inherits ClsBD

        Public Function getProvincia(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PROVINCIA) As DataTable
            getProvincia = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PROVINCIA", Entidad.DE_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_DEPARTAMENTO
        Inherits ClsBD

        Public Function getDepartamentos() As DataTable
            getDepartamentos = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DEPARTAMENTO").Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_PERFIL_OPCION
        Inherits ClsBD

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_PERFIL_OPCION", Entidad.PG_IDPERFIL)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_PERFIL_OPCION", .PG_IDPERFIL, .PG_IDEMPRESA, .PG_IDMODULO, .PG_IDGRUPO, .PG_IDOPCION)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getOpcionesHijos_x_padre(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION) As DataTable
            getOpcionesHijos_x_padre = Nothing
            Try
                With Entidad
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PERFIL_OPCION_HIJOS", .PG_IDPERFIL, .PG_IDEMPRESA, .PG_IDMODULO, .PG_IDGRUPO, .PG_IDOPCION).Tables(0)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOpciones_x_perfil(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION) As DataTable
            getOpciones_x_perfil = Nothing
            Try
                With Entidad
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PERFIL_OPCION", .PG_IDPERFIL, .PG_IDEMPRESA, .PG_IDMODULO, .PG_IDGRUPO).Tables(0)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_PERFIL_GRUPO
        Inherits ClsBD

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_PERFIL_GRUPO", Entidad.PG_IDPERFIL)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_PERFIL_GRUPO", Entidad.PG_IDPERFIL, Entidad.PG_IDEMPRESA, Entidad.PG_IDMODULO, Entidad.PG_IDGRUPO)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getGrupos_x_Perfil(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO) As DataTable
            getGrupos_x_Perfil = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PERFIL_GRUPO", Entidad.PG_IDPERFIL, Entidad.PG_IDEMPRESA, Entidad.PG_IDMODULO).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_PERFIL_MODULO
        Inherits ClsBD

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_PERFIL_MODULO", Entidad.PM_IDPERFIL)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_PERFIL_MODULO", .PM_IDPERFIL, .PM_IDMODULO, .PM_IDEMPRESA)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getModulos_x_Perfil(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO) As DataTable
            getModulos_x_Perfil = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PERFIL_MODULO", Entidad.PM_IDPERFIL, Entidad.PM_IDEMPRESA).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_PERFIL_EMPRESA
        Inherits ClsBD

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_EMPRESA)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_PERFIL_EMPRESA", Entidad.PU_IDPERFIL)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_EMPRESA)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_PERFIL_EMPRESA", Entidad.PU_IDPERFIL, Entidad.PU_IDEMPRESA)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getEmpresas_x_Perfil(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PERFIL_EMPRESA) As DataTable
            getEmpresas_x_Perfil = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PERFIL_EMPRESA", Entidad.PU_IDPERFIL).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_COBRADOR
        Inherits ClsBD

        Public Function getCobrador(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_COBRADOR) As DataTable
            getCobrador = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_COBRADOR", Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_VENDEDOR
        Inherits ClsBD

        Public Function getVendedor(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_VENDEDOR) As DataTable
            getVendedor = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VENDEDOR", Entidad.VE_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_FORMADESPACHO
        Inherits ClsBD

        Public Function getFormaDespacho(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_FORMADESPACHO) As DataTable
            getFormaDespacho = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_FORMADESPACHO", Entidad.FD_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_FORMAENVIO
        Inherits ClsBD

        Public Function getFormaEnvio(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_FORMAENVIO) As DataTable
            getFormaEnvio = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_FORMAENVIO", Entidad.FE_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_FORMACOBRANZA
        Inherits ClsBD
        Public Function getFormasCobro(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_FORMACOBRANZA) As DataTable
            getFormasCobro = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_FORMACOBRANZA", Entidad.FC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_PAIS
        Inherits ClsBD

        Public Function getPais(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PAIS) As DataTable
            getPais = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PAIS", Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_GIRONEGOCIO
        Inherits ClsBD
        Public Function getGiros(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GIRONEGOCIO) As DataTable
            getGiros = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_GIRONEGOCIO", Entidad.GN_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_CLIENTES
        Inherits ClsBD



        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CLIENTES)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_CLIENTES", .CL_IDCLIENTE.AN_IDANEXO, .CL_APE_PAT, .CL_APE_MAT, .CL_NOMBRES, .CL_RAZON_SOCIAL, .CL_GIRO_NEGOCIO.GN_ID, .CL_DIR_FISCAL, .CL_DIR_LEGAL, .CL_IDPAIS.PA_CODIGO, .CL_CODIGO_POSTAL, .CL_CIUDAD, .CL_REFERENCIA, .CL_TELEF1, .CL_TELEF2, .CL_MOVIL1, .CL_MOVIL2, .CL_FAX1, .CL_FAX2, .CL_EMAIL, .CL_WEBSITE, .CL_CODIGO_INDUSTRIAL, .CL_FORMA_COBRO.FC_ID, .CL_IDMONEDA.MO_CODIGO, .CL_FORMA_ENVIO.FE_ID, .CL_FORMA_DESPACHO.FD_ID, .CL_REPRESENTANTE_LEGAL, .CL_REPRESENTANTE_LEGAL_DOC, .CL_AGENTE_PERCEPCION, .CL_AGENTE_RETENCION, .CL_BUENOS_CONTRIBUYENTES, .CL_IDVENDEDOR.VE_ID, .CL_IDCOBRADOR.CO_ID, .CL_ES_PRINCIPAL, .CL_DESCUENTO, .CL_USUARIO, .CL_TERMINAL, .CL_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CLIENTES)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CLIENTES", .CL_IDCLIENTE.AN_IDANEXO, .CL_APE_PAT, .CL_APE_MAT, .CL_NOMBRES, .CL_RAZON_SOCIAL, .CL_GIRO_NEGOCIO.GN_ID, .CL_DIR_FISCAL, .CL_DIR_LEGAL, .CL_IDPAIS.PA_CODIGO, .CL_CODIGO_POSTAL, .CL_CIUDAD, .CL_REFERENCIA, .CL_TELEF1, .CL_TELEF2, .CL_MOVIL1, .CL_MOVIL2, .CL_FAX1, .CL_FAX2, .CL_EMAIL, .CL_WEBSITE, .CL_CODIGO_INDUSTRIAL, .CL_FORMA_COBRO.FC_ID, .CL_IDMONEDA.MO_CODIGO, .CL_FORMA_ENVIO.FE_ID, .CL_FORMA_DESPACHO.FD_ID, .CL_REPRESENTANTE_LEGAL, .CL_REPRESENTANTE_LEGAL_DOC, .CL_AGENTE_PERCEPCION, .CL_AGENTE_RETENCION, .CL_BUENOS_CONTRIBUYENTES, .CL_IDVENDEDOR.VE_ID, .CL_IDCOBRADOR.CO_ID, .CL_ES_PRINCIPAL, .CL_DESCUENTO, .CL_USUARIO, .CL_TERMINAL, .CL_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CLIENTES)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_CLIENTES", .CL_IDCLIENTE.AN_IDANEXO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getClientes(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As DataTable
            getClientes = Nothing
            Try
                With Entidad
                    Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CLIENTES", .AN_IDANEXO, .AN_IDEMPRESA.EM_ID).Tables(0)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_REG_COM_VTA_HON
        Inherits ClsBD
        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_REG_COM_VTA_HON", .RE_ID_OPERACION.OP_CODIGO, .RE_ID_TIPOCUENTA.TC_ID, .RE_NUM_CTA.PC_NUM_CUENTA, .RE_ANHO, .RE_ID_EMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_REG_COM_VTA_HON", .RE_ID_OPERACION.OP_CODIGO, .RE_ID_TIPOCUENTA.TC_ID, .RE_NUM_CTA.PC_NUM_CUENTA, .RE_ANHO, .RE_ID_EMPRESA.EM_ID)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getRegistros(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON) As List(Of BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON)
            getRegistros = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON)
                Dim registro As BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON
                With Entidad
                    Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_REG_COM_VTA_HON", .RE_ID_OPERACION.OP_CODIGO, .RE_ID_TIPOCUENTA.TC_ID, .RE_ANHO, .RE_ID_EMPRESA.EM_ID)
                    If drr.HasRows Then
                        Do While drr.Read
                            registro = New BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON()
                            registro.RE_NUM_CTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = drr("RE_NUM_CTA")}
                            lista.Add(registro)
                        Loop
                    End If
                    drr.Close() : drr = Nothing
                End With

                Return lista
            Catch ex As Exception
                Throw ex
            End Try

        End Function

    End Class

    Public Class SG_CO_TB_TIPO_CUENTA
        Inherits ClsBD

        Public Function getTipos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA)
            getTipos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA)
                Dim tipo As BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_CUENTA")

                If dr.HasRows Then
                    Do While dr.Read
                        tipo = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA()
                        tipo.TC_ID = dr("TC_ID")
                        tipo.TC_DESCRIPCION = dr("TC_DESCRIPCION")
                        lista.Add(tipo)
                    Loop
                End If

                dr.Close() : dr = Nothing
                tipo = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getTipos_x_Operacion(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_OPERACION) As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA)
            getTipos_x_Operacion = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA)
                Dim tipo As BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_CTA_X_OPE", Entidad.OP_CODIGO)

                If dr.HasRows Then
                    Do While dr.Read
                        tipo = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA()
                        tipo.TC_ID = dr("TC_ID")
                        tipo.TC_DESCRIPCION = dr("TC_DESCRIPCION")
                        lista.Add(tipo)
                    Loop
                End If

                dr.Close() : dr = Nothing
                tipo = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_ADMMES
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ADMMES)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_ADMMES", .AM_ANHO, .AM_MES, .AM_ESTADO, .AM_IDEMPRESA.EM_ID, .AM_USUARIO, .AM_TERMINAL, .AM_FECREG)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ADMMES)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_ADMMES", .AM_ANHO, .AM_MES, .AM_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function Esta_Cerrado_Mes(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ADMMES) As Boolean
            Esta_Cerrado_Mes = False
            Try
                With Entidad
                    Dim dato As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_ADMMES2", .AM_ANHO, .AM_MES, .AM_IDEMPRESA.EM_ID)
                    If dato > 0 Then
                        Dim dato2 As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_ADMMES", .AM_ANHO, .AM_MES, .AM_IDEMPRESA.EM_ID)
                        If dato2 = 1 Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function get_Periodos(ByVal empresa As Integer) As DataTable
            Dim query As String = "SELECT AP_ANHO,AP_ESTADO FROM SG_CO_TB_ADM_PERIODO WHERE AP_IDEMPRESA = " & empresa.ToString
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Sub set_Periodos(ByVal p As Integer, ByVal e As Integer, ByVal u As String, ByVal t As String, ByVal f As String)
            Dim query As String = "INSERT INTO SG_CO_TB_ADM_PERIODO(AP_ANHO,AP_ESTADO,AP_IDEMPRESA,AP_USUARIO,AP_TERMINAL,AP_FECREG) values(" & p & ",0," & e & ",'" & u & "','" & t & "','" & f & "')"
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Sub Actualizar_Periodo(ByVal p As Integer, ByVal estado As Integer, ByVal e As Integer)
            Dim query As String = "UPDATE SG_CO_TB_ADM_PERIODO SET AP_ESTADO = " & estado.ToString & " WHERE AP_ANHO = " & p.ToString & " AND AP_IDEMPRESA = " & e.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Sub Eliminar_Periodo(ByVal p As Integer, ByVal estado As Integer, ByVal e As Integer)
            Dim query As String = "DELETE FROM SG_CO_TB_ADM_PERIODO WHERE AP_ANHO = " & p.ToString & " AND AP_IDEMPRESA = " & e.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub

        Public Function Es_Periodo_Cerrado(ByVal p As Integer, ByVal e As Integer) As Boolean
            Dim query As String = "SELECT count(*) FROM SG_CO_TB_ADM_PERIODO WHERE AP_ANHO = " & p.ToString & " and AP_IDEMPRESA = " & e.ToString

            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, query) = 0 Then
                Return True
                Exit Function
            End If

            query = "SELECT isnull(AP_ESTADO,1) FROM SG_CO_TB_ADM_PERIODO WHERE AP_ANHO = " & p.ToString & " and AP_IDEMPRESA = " & e.ToString

            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, query) = 0 Then
                Return False
            Else
                Return True
            End If
        End Function


    End Class

    Public Class SG_CO_TB_TIPO_SERVI_DETRA
        Inherits ClsBD

        Public Function getTipos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_SERVI_DETRA)
            getTipos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_SERVI_DETRA)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_SERVI_DETRA")

                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPO_SERVI_DETRA(dr("TS_CODIGO"), dr("TS_DESCRIPCION")))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_SERVI_DETRA
        Inherits ClsBD

        Public Function getServicios_x_Tipo(ByVal tipo As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_SERVI_DETRA)
            getServicios_x_Tipo = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_SERVI_DETRA)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_SERVI_DETRA", tipo)
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_SERVI_DETRA(dr("SD_CODIGO"), dr("SD_DESCRICPION"), New BE.ContabilidadBE.SG_CO_TB_TIPO_SERVI_DETRA With {.TS_CODIGO = dr("SD_IDTIPOSERVIDETRA")}))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception

            End Try
        End Function
    End Class

    Public Class SG_CO_TB_OPERACION
        Inherits ClsBD

        Public Sub getOperaciones(ByRef entidades As List(Of BE.ContabilidadBE.SG_CO_TB_OPERACION))
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_OPERACION")
                If dr.HasRows Then

                    While dr.Read
                        entidades.Add(New BE.ContabilidadBE.SG_CO_TB_OPERACION(dr("OP_CODIGO"), dr("OP_DESCRIPCION"), dr("OP_ES_CAJABANCO")))
                    End While
                    dr.Close()
                    Exit Sub
                End If

                dr.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Function EsCajaBancos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_OPERACION) As Boolean
            EsCajaBancos = False
            Try
                If SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_GET_CAJA_OPE", Entidad.OP_CODIGO) = 1 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try

        End Function

    End Class

    Public Class SG_CO_TB_SUBOPERACION
        Inherits ClsBD

        Public Sub getSubOperaciones(ByRef entidades As List(Of BE.ContabilidadBE.SG_CO_TB_SUBOPERACION))
            Try
                Dim Int_Ope As Integer = entidades(0).SO_IDOPERACION.OP_CODIGO
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_SUBOPERACIONES", Int_Ope)

                entidades.Clear()

                If dr.HasRows Then

                    While dr.Read
                        entidades.Add(New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION(dr("SO_CODIGO"), dr("SO_DESCRIPCION"), New BE.ContabilidadBE.SG_CO_TB_OPERACION() With {.OP_CODIGO = Int_Ope}))
                    End While
                    dr.Close()
                    Exit Sub
                End If

                dr.Close()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
    End Class

    Public Class SG_CO_TB_SUBDIARIO
        Inherits ClsBD

        Public Sub Insert(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO)
            Try
                With Ent_Subdiario
                    Dim Int_SubOpe As Integer = 0
                    Dim dt As DataTable = getSubdiario(Ent_Subdiario)

                    If dt.Rows.Count > 0 Then
                        dt = Nothing
                        Throw New Exception("Ya existe el codigo de Subdiario")
                        Exit Sub
                    End If

                    If Not .SD_IDSUBOPE Is Nothing Then Int_SubOpe = .SD_IDSUBOPE.SO_CODIGO

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_SUBDIARIO", .SD_ID, .SD_DESCRIPCION, .SD_ABREVIATURA, _
                                                                                .SD_ES_APER, .SD_ES_CIER, .SD_ISTATUS, _
                                                                                .SD_IDOPERACION.OP_CODIGO, .SD_USUARIO, _
                                                                                .SD_TERMINAL, .SD_FECREG, .SD_IDEMPRESA.EM_ID, _
                                                                                IIf(Int_SubOpe = 0, DBNull.Value, Int_SubOpe))
                End With
            Catch ex As Exception
                Throw ex
                'Throw New Exception("Ya existe el codigo de Subdiario")
            End Try
        End Sub

        Public Sub Update(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO)
            Try
                With Ent_Subdiario
                    Dim Int_SubOpe As Integer = 0


                    Dim dt As DataTable = getSubdiario(Ent_Subdiario)

                    If dt.Rows.Count = 0 Then
                        dt = Nothing
                        Throw New Exception("El codigo de Subdiario no existe!")
                        Exit Sub
                    End If

                    If Not .SD_IDSUBOPE Is Nothing Then Int_SubOpe = .SD_IDSUBOPE.SO_CODIGO

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_SUBDIARIO", .SD_ID, .SD_DESCRIPCION, .SD_ABREVIATURA, _
                                                                                .SD_ES_APER, .SD_ES_CIER, .SD_ISTATUS, _
                                                                                .SD_IDOPERACION.OP_CODIGO, .SD_USUARIO, _
                                                                                .SD_TERMINAL, .SD_FECREG, .SD_IDEMPRESA.EM_ID, _
                                                                                IIf(Int_SubOpe = 0, DBNull.Value, Int_SubOpe))
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO)
            Try
                With Ent_Subdiario
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_SUBDIARIO", .SD_ID, .SD_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getSubdiarios(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO) As DataTable
            getSubdiarios = Nothing

            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_SUBDIARIO", Ent_Subdiario.SD_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getW_Subdiarios(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO) As DataTable
            getW_Subdiarios = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_SUBDIARIO", Ent_Subdiario.SD_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSubdiarios_x_Modulo(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO) As DataTable
            getSubdiarios_x_Modulo = Nothing

            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_SUBDIARIO_BYMOD", Ent_Subdiario.SD_IDOPERACION.OP_CODIGO, Ent_Subdiario.SD_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSubdiario(ByVal Ent_Subdiario As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO) As DataTable
            getSubdiario = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_SUBDIARIO_BYID", Ent_Subdiario.SD_ID, Ent_Subdiario.SD_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function get_Subdiario_Cierre(ByVal empresa As Integer) As String
            Dim query As String = "SELECT SD_ID +' - '+SD_DESCRIPCION FROM SG_CO_TB_SUBDIARIO WHERE SD_IDEMPRESA = " & empresa.ToString & " AND SD_ISTATUS = 1 AND SD_ES_CIER = 1 "
            Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)
        End Function

        Public Function get_Subdiario_Apertura(ByVal empresa As Integer) As String
            Dim query As String = "SELECT SD_ID +' - '+SD_DESCRIPCION FROM SG_CO_TB_SUBDIARIO WHERE SD_IDEMPRESA = " & empresa.ToString & " AND SD_ISTATUS = 1 AND SD_ES_APER = 1 "
            Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)
        End Function

    End Class

    Public Class SG_CO_TB_PROVEEDOR
        Inherits ClsBD
        Public Sub New()

        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PROVEEDOR)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_PROVEEDOR", .PR_IDPROVEEDOR.AN_IDANEXO, .PR_RAZON_SOCIAL, .PR_APE_PAT, .PR_APE_MAT, .PR_NOMBRES, .PR_GIRO_NEGOCIO, .PR_DIR_FISCAL, .PR_DIR_LEGAL, .PR_IDPAIS.PA_CODIGO, .PR_CITY, .PR_CODIGO_POSTAL, .PR_REFERENCIA, .PR_TELEF, .PR_TELEF2, .PR_MOVIL1, .PR_FAX1, .PR_FAX2, .PR_EMAIL, .PR_WEBSITE, .PR_CODIGO_INDUSTRIAL, _
                                          IIf(.PR_IDFORMA_PAGO.ID = 0, DBNull.Value, .PR_IDFORMA_PAGO.ID), _
                                          .PR_REPRESENTANTE_LEGAL, .PR_REPRESENTANTE_DNI, .PR_DESCUENTO, .PR_ES_AGENTE_PERCEPCION, .PR_ES_AGENTE_RETENCION, .PR_ES_BUEN_CONTRIBUYENTE, .PR_DIAS_CREDITO, .PR_PC_USUARIO, .PR_PC_TERMINAL, .PR_PC_FECREG)
            End With
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PROVEEDOR)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_PROVEEDOR", .PR_IDPROVEEDOR, .PR_RAZON_SOCIAL, .PR_APE_PAT, .PR_APE_MAT, .PR_NOMBRES, .PR_GIRO_NEGOCIO, .PR_DIR_FISCAL, .PR_DIR_LEGAL, .PR_IDPAIS, .PR_CITY, .PR_CODIGO_POSTAL, .PR_REFERENCIA, .PR_TELEF, .PR_TELEF2, .PR_MOVIL1, .PR_FAX1, .PR_FAX2, .PR_EMAIL, .PR_WEBSITE, .PR_CODIGO_INDUSTRIAL, .PR_IDFORMA_PAGO, .PR_REPRESENTANTE_LEGAL, .PR_REPRESENTANTE_DNI, .PR_DESCUENTO, .PR_ES_AGENTE_PERCEPCION, .PR_ES_AGENTE_RETENCION, .PR_ES_BUEN_CONTRIBUYENTE, .PR_DIAS_CREDITO, .PR_PC_USUARIO, .PR_PC_TERMINAL, .PR_PC_FECREG)
            End With
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PROVEEDOR)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_PROVEEDOR", .PR_IDPROVEEDOR)
            End With
        End Sub
        Public Function getProveedor(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_PROVEEDOR) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PROVEEDOR_BYID", Entidad.PR_IDPROVEEDOR.AN_IDANEXO).Tables(0)
        End Function
        Public Function getProveedores(ByVal Int_CodigoProve As String) As List(Of BE.ContabilidadBE.SG_CO_TB_PROVEEDOR)
            getProveedores = Nothing
            Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_PROVEEDOR)
            Dim Entidad As BE.ContabilidadBE.SG_CO_TB_PROVEEDOR
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_PROVEEDOR", Int_CodigoProve)

            Try
                If dr.HasRows Then
                    Do While dr.Read
                        Entidad = New BE.ContabilidadBE.SG_CO_TB_PROVEEDOR()
                        With Entidad
                            .PR_IDPROVEEDOR = New BE.ContabilidadBE.SG_CO_TB_ANEXO() With {.AN_IDANEXO = Int_CodigoProve}
                            .PR_APE_MAT = String.Empty
                            .PR_APE_PAT = String.Empty


                            lista.Add(Entidad)
                        End With
                    Loop
                    dr.Close()
                Else
                    dr.Close()
                End If

            Catch ex As Exception
                Throw ex
            End Try


            Return lista
        End Function

    End Class

    Public Class SG_CO_TB_USUARIO
        Inherits ClsBD

        Public Function es_super_ft(ByVal login_ As String) As Boolean
            Dim bol_rpta As Boolean = False
            If SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_ES_SUPER_FT", login_) = 1 Then
                bol_rpta = True
            End If
            Return bol_rpta
        End Function

        Public Function get_Empresas_x_usuario(ByVal nombre_usuario_ As String) As DataTable
            Dim idusuario_ As Integer = getIdUsu_x_NomUsu(nombre_usuario_)
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_EMP_X_USU", idusuario_).Tables(0)
        End Function


        Public Sub cambiar_clave_usuario(ByVal usuario As String, ByVal claveNueva As String)
            Dim query As String = "UPDATE SG_CO_TB_USUARIO SET US_CLAVE ='" & claveNueva & "' WHERE US_NOMBRE = '" & usuario & "' "
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)

        End Sub

        Public Sub Insert(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO)
            Try
                With Entidad
                    Dim usuarios As List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO) = getUsuarios()
                    For Each usuario As BE.ContabilidadBE.SG_CO_TB_USUARIO In usuarios
                        If usuario.US_NOMBRE.Equals(Entidad.US_NOMBRE) Then
                            Throw New Exception("Nombre de usuario ya esta registrado")
                            Exit Sub
                        End If
                    Next

                    Dim Int_IdTipoUsuario As Integer = 0 ' perfil
                    If Not .US_IDTIPO_USU Is Nothing Then
                        Int_IdTipoUsuario = .US_IDTIPO_USU.TU_CODIGO
                    End If

                    .US_ID = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_USUARIO", .US_NOMBRE, .US_CLAVE, .US_DESCRIPCION, .US_ISTATUS, .US_USUARIO, .US_TERMINAL, .US_FECREG, Int_IdTipoUsuario, .US_FOTO, .US_TIPO_ACCESO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_USUARIO", .US_ID, .US_NOMBRE, .US_CLAVE, .US_DESCRIPCION, .US_ISTATUS, .US_USUARIO, .US_TERMINAL, .US_FECREG, .US_IDTIPO_USU.TU_CODIGO, .US_FOTO, .US_TIPO_ACCESO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO)
            With Entidad
                Try

                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_USUARIO_BYID", Entidad.US_ID)
                    If Not dr.HasRows Then
                        dr.Close()
                        dr = Nothing
                        Throw New Exception("El codigo de usuario no existe")
                        Exit Sub
                    End If
                    dr.Close()
                    dr = Nothing
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_USUARIO", .US_ID)

                Catch ex As Exception
                    Throw ex
                End Try
            End With
        End Sub
        Public Function Es_Administrador(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO) As Boolean
            Es_Administrador = False
            Try
                Dim tipo As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_TIPO_USU_BYNAME", Entidad.US_NOMBRE)
                If tipo = 1 Then Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub getUsuario(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO)
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_USUARIO_BYID", Entidad.US_ID)
            Try
                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .US_NOMBRE = IIf(dr("US_NOMBRE") Is DBNull.Value, "", dr("US_NOMBRE"))
                            .US_CLAVE = IIf(dr("US_CLAVE") Is DBNull.Value, "", dr("US_CLAVE"))
                            .US_DESCRIPCION = IIf(dr("US_DESCRIPCION") Is DBNull.Value, "", dr("US_DESCRIPCION"))
                            .US_ISTATUS = IIf(dr("US_ISTATUS") Is DBNull.Value, 0, dr("US_ISTATUS"))
                            .US_IDTIPO_USU = IIf(dr("US_IDTIPO_USU") Is DBNull.Value, Nothing, _
                                                 New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO With {.TU_CODIGO = dr("US_IDTIPO_USU")})
                            .US_FOTO = IIf(dr("US_FOTO") Is DBNull.Value, Nothing, dr("US_FOTO"))
                            .US_TIPO_ACCESO = IIf(dr("US_TIPO_ACCESO") Is DBNull.Value, 0, dr("US_TIPO_ACCESO"))
                        End With
                    Loop
                Else
                    dr.Close()
                    Throw New Exception("Usuario no existe")
                End If
                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Validar_Usuario_Sistema(ByRef E_Usuario As BE.ContabilidadBE.SG_CO_TB_USUARIO, ByVal E_Empresa As BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA) As Boolean
            Validar_Usuario_Sistema = False
            Try
                Dim Bol_Entro As Boolean = False
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_USUARIO_LOGIN")
                If dr.HasRows Then
                    Do While dr.Read
                        If dr("US_NOMBRE").Equals(E_Usuario.US_NOMBRE) And dr("US_CLAVE").Equals(E_Usuario.US_CLAVE) Then
                            If dr("US_ISTATUS") = 1 Then
                                Bol_Entro = True
                            Else
                                Bol_Entro = False
                                Throw New Exception("El usuario esta Inhabilitado")
                            End If

                        End If
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Dim dato As Integer = 0 'SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_USUARIO_BYName", E_Usuario.US_NOMBRE, E_Usuario.US_CLAVE)
                If Bol_Entro Then

                    dato = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_C_VALIDAR_USU_X_EMP", E_Usuario.US_NOMBRE, E_Empresa.UE_IDEMPRESA.EM_ID)

                    If dato > 0 Then
                        Return True
                    Else
                        Throw New Exception("El usuario no tiene permiso para esta empresa")
                    End If
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Validar_Usuario_Sistema_Web(ByRef E_Usuario As BE.ContabilidadBE.SG_CO_TB_USUARIO, ByVal E_Empresa As BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA) As Boolean
            Validar_Usuario_Sistema_Web = False
            Try
                Dim Bol_Entro As Boolean = False
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_USUARIO_LOGIN")
                If dr.HasRows Then
                    Do While dr.Read
                        If dr("US_NOMBRE").Equals(E_Usuario.US_NOMBRE) And dr("US_CLAVE").Equals(E_Usuario.US_CLAVE) Then
                            If dr("US_ES_WEB") = 1 Then
                                Bol_Entro = True
                            Else
                                Bol_Entro = False
                                Throw New Exception("La cuenta de usuario no esta activada para ingresar por Internet.")
                            End If
                        End If
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Dim dato As Integer = 0 'SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_USUARIO_BYName", E_Usuario.US_NOMBRE, E_Usuario.US_CLAVE)  
                If Bol_Entro Then

                    dato = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_C_VALIDAR_USU_X_EMP", E_Usuario.US_NOMBRE, E_Empresa.UE_IDEMPRESA.EM_ID)

                    If dato > 0 Then
                        Return True
                    Else
                        Throw New Exception("El usuario no tiene permiso para esta empresa")
                    End If
                Else
                    Return False
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Validar_Usuario_x_Empresa(ByVal login As String, ByVal empresa As Integer) As Boolean
            Validar_Usuario_x_Empresa = False
            Try
                Dim dato As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_C_VALIDAR_USU_X_EMP", login, empresa)
                If dato > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getUsuariosWeb() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_CO_SP_S_USUARIOS_WEB").Tables(0)
        End Function

        Public Sub Update_Permiso_Web(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_USU_WEB", Entidad.US_ID, Entidad.US_ES_WEB)
        End Sub


        Public Function getUsuarios() As List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO)
            Dim myLista As New List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO)
            Dim Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_USUARIO")
                If dr.HasRows Then
                    Do While dr.Read
                        Entidad = New BE.ContabilidadBE.SG_CO_TB_USUARIO()
                        With Entidad
                            .US_ID = IIf(dr("US_ID") Is DBNull.Value, "", dr("US_ID"))
                            .US_NOMBRE = IIf(dr("US_NOMBRE") Is DBNull.Value, "", dr("US_NOMBRE"))
                            .US_DESCRIPCION = IIf(dr("US_DESCRIPCION") Is DBNull.Value, "", dr("US_DESCRIPCION"))
                            .US_ISTATUS = IIf(dr("US_ISTATUS") Is DBNull.Value, 0, dr("US_ISTATUS"))
                            .US_FOTO = IIf(dr("US_FOTO") Is DBNull.Value, Nothing, dr("US_FOTO"))
                            .US_USUARIO = IIf(dr("TU_DESCRIPCION") Is DBNull.Value, String.Empty, dr("TU_DESCRIPCION"))
                        End With
                        myLista.Add(Entidad)
                    Loop
                End If
                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try

            Return myLista
        End Function

        Public Function getIdUsu_x_NomUsu(ByVal Str_Nombre_Usuario As String) As Integer
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_IDUSU_BYNOMUSU", Str_Nombre_Usuario)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getPerfil_x_NomUsu(ByVal Str_Nombre_Usuario As String) As Integer
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_GETPERFIL_BYNOMUSU", Str_Nombre_Usuario)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getTipo_Acceso_x_NomUsu(ByVal Str_Nombre_Usuario As String) As Integer
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_GETTIPO_ACCESO_BYNOMUSU", Str_Nombre_Usuario)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_TIPO_USUARIO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TIPO_USUARIO", Entidad.TU_CODIGO, Entidad.TU_DESCRIPCION)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_TIPO_USUARIO", Entidad.TU_CODIGO, Entidad.TU_DESCRIPCION)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_TIPO_USUARIO", Entidad.TU_CODIGO)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getTipos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_USUARIO")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO(dr("TU_CODIGO"), dr("TU_DESCRIPCION")))
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_USUARIO_EMPRESA
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_USUARIO_EMPRESA", Entidad.UE_IDUSUARIO.US_ID, Entidad.UE_IDEMPRESA.EM_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getPermisosEmpresa(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO) As DataTable
            getPermisosEmpresa = Nothing
            Try
                Dim dt_Permisos As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_USUARIO_EMPRESA", Entidad.US_ID).Tables(0)
                Return dt_Permisos

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_USUARIO_EMPRESA", Entidad.UE_IDUSUARIO.US_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

    Public Class SG_CO_TB_MODULO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MODULO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_MODULOS", .MO_ID, .MO_DESCRIPCION)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MODULO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_MODULOS", .MO_ID, .MO_DESCRIPCION)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MODULO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_MODULOS", .MO_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getModulos() As List(Of BE.ContabilidadBE.SG_CO_TB_MODULO)
            getModulos = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO)

                Dim Dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_MODULOS")

                If Dr.HasRows Then
                    Do While Dr.Read
                        Lista.Add(New BE.ContabilidadBE.SG_CO_TB_MODULO(Dr("MO_ID"), Dr("MO_DESCRIPCION")))
                    Loop
                End If
                Dr.Close() : Dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getModulo(ByVal Int_Cod_Modulo As Integer) As BE.ContabilidadBE.SG_CO_TB_MODULO
            getModulo = Nothing
            Try
                Dim Lista As BE.ContabilidadBE.SG_CO_TB_MODULO = Nothing
                Dim Dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_MODULOS_BYID", Int_Cod_Modulo)

                If Dr.HasRows Then
                    Do While Dr.Read
                        Lista = New BE.ContabilidadBE.SG_CO_TB_MODULO(Dr("MO_ID"), Dr("MO_DESCRIPCION"))
                    Loop
                End If
                Dr.Close() : Dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function


    End Class

    Public Class SG_CO_TB_GRUPO_MENU
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_GRUPOS_MDO", .GM_ID, .GM_NOMBRE, .GM_IDMODULO.MO_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_GRUPOS_MDO", .GM_ID, .GM_NOMBRE, .GM_IDMODULO.MO_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_GRUPOS_MDO", .GM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getGrupos() As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            getGrupos = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPOS_MDO")

                If dr.HasRows Then
                    Do While dr.Read
                        Lista.Add(New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU(dr("GM_ID"), dr("GM_NOMBRE"), New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = dr("GM_IDMODULO")}))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getGrupo(ByVal Int_CodGrupo As Integer) As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU
            getGrupo = Nothing
            Try
                Dim Lista As New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPOS_MNU_BYID", Int_CodGrupo)

                If dr.HasRows Then
                    dr.Read()
                    Lista = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU(dr("GM_ID"), dr("GM_NOMBRE"), New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = dr("GM_IDMODULO"), .MO_DESCRIPCION = dr("MO_DESCRIPCION")})
                End If

                dr.Close() : dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getGrupos_x_Modulo(ByVal Int_Cod_Mod As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            getGrupos_x_Modulo = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPOS_BYMOD", Int_Cod_Mod)

                If dr.HasRows Then
                    Do While dr.Read
                        Lista.Add(New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU(dr("GM_ID"), dr("GM_NOMBRE"), New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = dr("GM_IDMODULO")}))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_OPCIONES_MNU
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            Try
                With Entidad
                    Dim Int_IdMenuPadre As Integer = 0
                    If Not .OM_IDPADRE Is Nothing Then Int_IdMenuPadre = .OM_IDPADRE.OM_ID
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_OPCIONES_MNU", .OM_DESCRIPCION, .OM_TIPO.TB_ID, .OM_IMG, .OM_TAMANO_IMG.TI_ID, .OM_IDGRUPO.GM_ID, IIf(Int_IdMenuPadre = 0, DBNull.Value, Int_IdMenuPadre), .OM_NOM_FORM)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            Try
                With Entidad
                    Dim Int_IdMenuPadre As Integer = 0
                    If Not .OM_IDPADRE Is Nothing Then Int_IdMenuPadre = .OM_IDPADRE.OM_ID
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_OPCIONES_MNU", .OM_ID, .OM_DESCRIPCION, .OM_TIPO.TB_ID, .OM_IMG, .OM_TAMANO_IMG.TI_ID, .OM_IDGRUPO.GM_ID, IIf(Int_IdMenuPadre = 0, DBNull.Value, Int_IdMenuPadre), .OM_NOM_FORM)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_OPCIONES_MNU", .OM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getOpcionesMenu() As List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            getOpcionesMenu = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
                Dim opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_OPCIONES_MNU")
                If dr.HasRows Then
                    Do While dr.Read
                        opcion = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU
                        With opcion
                            .OM_ID = dr("OM_ID")
                            .OM_DESCRIPCION = dr("OM_DESCRIPCION")
                            .OM_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = dr("OM_IDGRUPO")}
                            .OM_IMG = dr("OM_IMG")
                            .OM_TAMANO_IMG = New BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON With {.TI_ID = dr("OM_TAMANO_IMG")}
                            .OM_TIPO = New BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU With {.TB_ID = dr("OM_TIPO")}
                            .OM_NOM_FORM = dr("OM_NOM_FORM").ToString
                        End With
                        Lista.Add(opcion)
                    Loop
                End If
                dr.Close() : dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOpcionesMenu_x_Grupo(ByVal Int_Cod_Grupo As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            getOpcionesMenu_x_Grupo = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
                Dim opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_OPCIONES_MNU_XGR", Int_Cod_Grupo)
                If dr.HasRows Then
                    Do While dr.Read
                        opcion = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU
                        With opcion
                            .OM_ID = dr("OM_ID")
                            .OM_DESCRIPCION = dr("OM_DESCRIPCION")
                            .OM_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = dr("OM_IDGRUPO")}
                            .OM_IMG = dr("OM_IMG")
                            .OM_TAMANO_IMG = New BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON With {.TI_ID = dr("OM_TAMANO_IMG")}
                            .OM_TIPO = New BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU With {.TB_ID = dr("OM_TIPO")}
                            If dr("OM_IDPADRE") Is DBNull.Value Then
                                .OM_IDPADRE = Nothing
                            Else
                                .OM_IDPADRE = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = dr("OM_IDPADRE")}
                            End If
                            .OM_NOM_FORM = dr("OM_NOM_FORM").ToString
                        End With
                        Lista.Add(opcion)
                    Loop
                End If
                dr.Close() : dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getOpcionesMenu_x_ItemPadre(ByVal Int_Cod_Padre As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            getOpcionesMenu_x_ItemPadre = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
                Dim opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_OPC_X_PADRE", Int_Cod_Padre)
                If dr.HasRows Then
                    Do While dr.Read
                        opcion = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU
                        With opcion
                            .OM_ID = dr("OM_ID")
                            .OM_DESCRIPCION = dr("OM_DESCRIPCION")
                            .OM_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = dr("OM_IDGRUPO")}
                            .OM_IMG = dr("OM_IMG")
                            .OM_TAMANO_IMG = New BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON With {.TI_ID = dr("OM_TAMANO_IMG")}
                            .OM_TIPO = New BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU With {.TB_ID = dr("OM_TIPO")}
                            If dr("OM_IDPADRE") Is DBNull.Value Then
                                .OM_IDPADRE = Nothing
                            Else
                                .OM_IDPADRE = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = dr("OM_IDPADRE")}
                            End If
                            .OM_NOM_FORM = dr("OM_NOM_FORM").ToString
                        End With
                        Lista.Add(opcion)
                    Loop
                End If
                dr.Close() : dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOpcionesMenu_x_Id(ByVal Int_Cod_Item As Integer) As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU
            getOpcionesMenu_x_Id = Nothing
            Try
                Dim opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU = Nothing

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_OPCIONES_MNU_BYID", Int_Cod_Item)
                If dr.HasRows Then
                    Do While dr.Read
                        opcion = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU
                        With opcion
                            .OM_ID = dr("OM_ID")
                            .OM_DESCRIPCION = dr("OM_DESCRIPCION")


                            Dim E_modulo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU
                            Dim Obj_Grupo As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU

                            E_modulo = Obj_Grupo.getGrupo(dr("OM_IDGRUPO"))

                            .OM_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = E_modulo.GM_ID, .GM_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = E_modulo.GM_IDMODULO.MO_ID}}
                            .OM_IMG = dr("OM_IMG")
                            .OM_TAMANO_IMG = New BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON With {.TI_ID = dr("OM_TAMANO_IMG")}
                            .OM_TIPO = New BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU With {.TB_ID = dr("OM_TIPO")}
                            If dr("OM_IDPADRE") Is DBNull.Value Then
                                .OM_IDPADRE = Nothing
                            Else
                                .OM_IDPADRE = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = dr("OM_IDPADRE")}
                            End If
                            .OM_NOM_FORM = dr("OM_NOM_FORM").ToString
                        End With
                    Loop
                End If
                dr.Close() : dr = Nothing

                Return opcion
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function getNombre_formulario_x_Id(ByVal Int_IdMenu As Integer) As String
            getNombre_formulario_x_Id = String.Empty
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CP_SP_S_NOMFORM_BYID", Int_IdMenu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getOpciones_x_Usuario_y_Grupo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC) As List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            getOpciones_x_Usuario_y_Grupo = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
                Dim item As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_OPC_X_USU_Y_GRU", Entidad.UGO_IDUSUARIO.US_ID, Entidad.UGO_IDGRUPO.GM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        item = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU()
                        item.OM_ID = dr("UGO_IDOPCION")
                        item.OM_DESCRIPCION = dr("OM_DESCRIPCION")
                        lista.Add(item)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_TAMANO_ICON
        Inherits ClsBD

        Public Function getTamanos() As List(Of BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON)
            getTamanos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TAMANO_ICON")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON With {.TI_ID = dr("TI_ID"), .TI_DESCRIPCION = dr("TI_DESCRIPCION")})
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_TIPO_BOTON_MENU
        Inherits ClsBD

        Public Function getTiposBotonIcon() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_BOTON_MENU")

                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU With {.TB_ID = dr("TB_ID"), .TB_DESCRIPCION = dr("TB_DESCRIPCION")})
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_MODULO_USUARIO
        Inherits ClsBD

        Public Sub Delete()
            Try

            Catch ex As Exception

            End Try
        End Sub

        Public Sub DeleteAll(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SP_CO_SP_D_MOD_X_USU_ALL", Entidad.US_ID)
            Catch ex As Exception

            End Try
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SP_CO_SP_I_MOD_X_USU", .MU_IDMODULO.MO_ID, .MU_IDUSUARIO.US_ID, .MU_ISTATUS, .MU_IDEMPRESA.EM_ID, .MU_USUARIO, .MU_TERMINAL, .MU_FECREG)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getMod_x_Usuario(ByVal Int_CodUsu As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            getMod_x_Usuario = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SP_CO_SP_S_MOD_X_USU", Int_CodUsu)
                If dr.HasRows Then
                    Do While dr.Read
                        Dim permiso As New BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO
                        permiso.MU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO(dr("MU_IDMODULO"), dr("MO_DESCRIPCION"))
                        lista.Add(permiso)
                    Loop

                End If

                dr.Close() : dr = Nothing

                Return lista

            Catch ex As Exception

            End Try
        End Function

    End Class

    Public Class SG_CO_TB_USUARIO_GRUPO_MNU
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_USUARIO_GRUPO_MNU", .GU_IDUSUARIO.US_ID, .GU_IDGRUPO.GM_ID, .GU_IDMODULO.MO_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub DeleteAll(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_USU_GRUPOMNU_XIDUSU", Entidad.GU_IDUSUARIO.US_ID, Entidad.GU_IDMODULO.MO_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getGrupos_Usu(ByVal Int_Cod_Usu As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU)
            getGrupos_Usu = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUPOS_X_USU", Int_Cod_Usu)
                Dim item As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU

                If dr.HasRows Then
                    Do While dr.Read
                        item = New BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU
                        item.GU_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU(dr("GU_IDGRUPO"), dr("GM_NOMBRE"), Nothing)
                        item.GU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = Int_Cod_Usu}
                        lista.Add(item)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getGrupos_x_Usu_Modulo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU) As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            getGrupos_x_Usu_Modulo = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GRUP_X_MOD_USU", Entidad.GU_IDUSUARIO.US_ID, Entidad.GU_IDMODULO.MO_ID)
                Dim item As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU

                If dr.HasRows Then
                    Do While dr.Read
                        item = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU
                        item.GM_ID = dr("GU_IDGRUPO")
                        item.GM_NOMBRE = dr("GM_NOMBRE")
                        lista.Add(item)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try

        End Function

    End Class

    Public Class SG_CO_TB_USU_GRU_OPC
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_USU_GRU_OPC", .UGO_IDUSUARIO.US_ID, .UGO_IDGRUPO.GM_ID, .UGO_IDOPCION.OM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_USU_GRU_OPC", Entidad.UGO_IDUSUARIO.US_ID, Entidad.UGO_IDGRUPO.GM_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

    Public Class SG_CO_TB_BTN_CMD
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_BTN_CMD", .BC_ID, .BC_DESCRIPCION, .BC_NOMBRE_BTN_SIS)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_BTN_CMD", .BC_ID, .BC_DESCRIPCION, .BC_NOMBRE_BTN_SIS)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_BTN_CMD", .BC_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function getCmds() As List(Of BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
            getCmds = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
                Dim cmd As BE.ContabilidadBE.SG_CO_TB_BTN_CMD
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BTN_CMD")

                If dr.HasRows Then
                    Do While dr.Read
                        cmd = New BE.ContabilidadBE.SG_CO_TB_BTN_CMD()
                        cmd.BC_ID = dr("BC_ID")
                        cmd.BC_DESCRIPCION = dr("BC_DESCRIPCION")
                        cmd.BC_NOMBRE_BTN_SIS = dr("BC_NOMBRE_BTN_SIS")
                        lista.Add(cmd)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getCmd_x_Id() As BE.ContabilidadBE.SG_CO_TB_BTN_CMD
            getCmd_x_Id = Nothing
            Try
                Dim cmd As New BE.ContabilidadBE.SG_CO_TB_BTN_CMD
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BTN_CMD_BYID")

                If dr.HasRows Then
                    dr.Read()
                    cmd.BC_ID = dr("BC_ID")
                    cmd.BC_DESCRIPCION = dr("BC_DESCRIPCION")
                    cmd.BC_NOMBRE_BTN_SIS = dr("BC_NOMBRE_BTN_SIS")
                End If

                dr.Close() : dr = Nothing

                Return cmd
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_USU_OPC_CMD
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_USU_OPC_CMD", .UOC_IDUSU.US_ID, .UOC_IDOPC.OM_ID, .UOC_IDCMD.BC_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_USU_OPC_CMD", Entidad.UOC_IDUSU.US_ID, Entidad.UOC_IDOPC.OM_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getCmds_x_usu_y_opcion(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD) As List(Of BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
                Dim cmd As BE.ContabilidadBE.SG_CO_TB_BTN_CMD
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_CMDS_BY_USUOPC", Entidad.UOC_IDUSU.US_ID, Entidad.UOC_IDOPC.OM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        cmd = New BE.ContabilidadBE.SG_CO_TB_BTN_CMD()
                        cmd.BC_ID = dr("UOC_IDCMD")
                        cmd.BC_DESCRIPCION = dr("BC_DESCRIPCION")
                        cmd.BC_NOMBRE_BTN_SIS = ""
                        lista.Add(cmd)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_MONEDA
        Inherits ClsBD
        Public Sub New()
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MONEDA)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_MONEDA", .MO_CODIGO, .MO_DESCRIPCION, _
                                              .MO_SIMBOLO, .MO_ES_PRINCIPAL, .MO_IDPAIS.PA_CODIGO, _
                                              .MO_CUENTA_GANANCIA, .MO_CUENTA_PERDIDA, .MO_CODIGO_SUNAT, _
                                              .MO_USUARIO, .MO_TERMINAL, .MO_FECREG, .MO_IDEMPRESA.EM_ID)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MONEDA)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_MONEDA", .MO_CODIGO, .MO_DESCRIPCION, _
                                              .MO_SIMBOLO, .MO_ES_PRINCIPAL, .MO_IDPAIS.PA_CODIGO, _
                                              .MO_CUENTA_GANANCIA, .MO_CUENTA_PERDIDA, .MO_CODIGO_SUNAT, _
                                              .MO_USUARIO, .MO_TERMINAL, .MO_FECREG, .MO_IDEMPRESA.EM_ID)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_MONEDA)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_MONEDA", .MO_CODIGO, .MO_IDEMPRESA.EM_ID)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub getMoneda(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_MONEDA)
            Try
                With Entidad
                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_MONEDA_BYID", .MO_CODIGO, .MO_IDEMPRESA.EM_ID)
                    If dr.HasRows Then
                        While dr.Read
                            .MO_CODIGO = IIf(dr("MO_CODIGO") Is DBNull.Value, 0, dr("MO_CODIGO"))
                            .MO_DESCRIPCION = IIf(dr("MO_DESCRIPCION") Is DBNull.Value, String.Empty, dr("MO_DESCRIPCION"))
                            .MO_SIMBOLO = IIf(dr("MO_SIMBOLO") Is DBNull.Value, String.Empty, dr("MO_SIMBOLO"))
                            .MO_ES_PRINCIPAL = IIf(dr("MO_ES_PRINCIPAL") Is DBNull.Value, 0, dr("MO_ES_PRINCIPAL"))
                            .MO_IDPAIS = IIf(dr("MO_IDPAIS") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = dr("MO_IDPAIS")})
                            .MO_CUENTA_GANANCIA = IIf(dr("MO_CUENTA_GANANCIA") Is DBNull.Value, String.Empty, dr("MO_CUENTA_GANANCIA"))
                            .MO_CUENTA_PERDIDA = IIf(dr("MO_CUENTA_PERDIDA") Is DBNull.Value, String.Empty, dr("MO_CUENTA_PERDIDA"))
                            .MO_CODIGO_SUNAT = IIf(dr("MO_CODIGO_SUNAT") Is DBNull.Value, String.Empty, dr("MO_CODIGO_SUNAT"))
                            .MO_USUARIO = IIf(dr("MO_USUARIO") Is DBNull.Value, String.Empty, dr("MO_USUARIO"))
                            .MO_TERMINAL = IIf(dr("MO_TERMINAL") Is DBNull.Value, String.Empty, dr("MO_TERMINAL"))
                            .MO_FECREG = IIf(dr("MO_FECREG") Is DBNull.Value, String.Empty, dr("MO_FECREG"))
                            '.MO_IDEMPRESA = IIf(dr("MO_IDEMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Entidad.MO_IDEMPRESA.EM_ID})
                        End While
                    End If

                    dr.Close()
                    dr = Nothing
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function getMonedas_dt() As DataTable
            getMonedas_dt = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_MONEDA").Tables(0)
        End Function
        Public Function getMonedas() As List(Of BE.ContabilidadBE.SG_CO_TB_MONEDA)
            getMonedas = Nothing
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_MONEDA")
                Dim moneda As BE.ContabilidadBE.SG_CO_TB_MONEDA
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_MONEDA)
                If dr.HasRows Then
                    While dr.Read
                        moneda = New BE.ContabilidadBE.SG_CO_TB_MONEDA()
                        With moneda
                            .MO_CODIGO = IIf(dr("MO_CODIGO") Is DBNull.Value, 0, dr("MO_CODIGO"))
                            .MO_DESCRIPCION = IIf(dr("MO_DESCRIPCION") Is DBNull.Value, String.Empty, dr("MO_DESCRIPCION"))
                            .MO_SIMBOLO = IIf(dr("MO_SIMBOLO") Is DBNull.Value, String.Empty, dr("MO_SIMBOLO"))
                            .MO_ES_PRINCIPAL = IIf(dr("MO_ES_PRINCIPAL") Is DBNull.Value, 0, dr("MO_ES_PRINCIPAL"))
                            .MO_IDPAIS = IIf(dr("MO_IDPAIS") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = dr("MO_IDPAIS")})
                            .MO_CUENTA_GANANCIA = IIf(dr("MO_CUENTA_GANANCIA") Is DBNull.Value, String.Empty, dr("MO_CUENTA_GANANCIA"))
                            .MO_CUENTA_PERDIDA = IIf(dr("MO_CUENTA_PERDIDA") Is DBNull.Value, String.Empty, dr("MO_CUENTA_PERDIDA"))
                            .MO_CODIGO_SUNAT = IIf(dr("MO_CODIGO_SUNAT") Is DBNull.Value, String.Empty, dr("MO_CODIGO_SUNAT"))
                            .MO_USUARIO = IIf(dr("MO_USUARIO") Is DBNull.Value, String.Empty, dr("MO_USUARIO"))
                            .MO_TERMINAL = IIf(dr("MO_TERMINAL") Is DBNull.Value, String.Empty, dr("MO_TERMINAL"))
                            .MO_FECREG = IIf(dr("MO_FECREG") Is DBNull.Value, String.Empty, dr("MO_FECREG"))
                        End With
                        lista.Add(moneda)
                    End While
                End If

                dr.Close()
                dr = Nothing
                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_TIPOCAMBIO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            Try
                With Entidad
                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOCAMBIO_BYID", _
                                                                 .TC_FECHA, .TC_IDMONEDA.MO_CODIGO, _
                                                                 .TC_IDEMPRESA.EM_ID)


                    If dr.HasRows Then
                        dr.Close()
                        dr = Nothing
                        Throw New Exception("Esta fecha ya tiene tipo de cambio")
                        Exit Sub
                    End If

                    dr.Close()
                    dr = Nothing

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TIPOCAMBIO", .TC_FECHA, _
                                              .TC_IDMONEDA.MO_CODIGO, .TC_COMPRA, .TC_VENTA, _
                                              .TC_USUARIO, .TC_TERMINAL, .TC_FECREG, .TC_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Insert(ByVal Entidades As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO))
            Try

                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_TIPOCAMBIO_XMES", Entidades(0).TC_FECHA, _
                                                       Entidades(0).TC_IDMONEDA.MO_CODIGO, Entidades(0).TC_IDEMPRESA.EM_ID)

                For Each Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO In Entidades

                    With Entidad

                        'Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOCAMBIO_BYID", _
                        '                                             .TC_FECHA, .TC_IDMONEDA.MO_CODIGO, _
                        '                                             .TC_IDEMPRESA.EM_ID)

                        'If dr.HasRows Then
                        '    dr.Close()
                        '    dr = Nothing
                        '    Throw New Exception("La fecha " & .TC_FECHA.ToString & "ya tiene tipo de cambio")
                        '    Exit Sub
                        'End If

                        'dr.Close()
                        'dr = Nothing

                        SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TIPOCAMBIO", .TC_FECHA, _
                                                  .TC_IDMONEDA.MO_CODIGO, .TC_COMPRA, .TC_VENTA, _
                                                  .TC_USUARIO, .TC_TERMINAL, .TC_FECREG, .TC_IDEMPRESA.EM_ID)
                    End With

                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Insert(ByVal Entidades As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO), ByVal Bol_Reemplazar As Boolean)
            Try
                If Bol_Reemplazar Then SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_TIPOCAMBIO_XMES", Entidades(0).TC_FECHA, Entidades(0).TC_IDMONEDA.MO_CODIGO, Entidades(0).TC_IDEMPRESA.EM_ID)

                For Each Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO In Entidades
                    With Entidad

                        If Bol_Reemplazar Then
                            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TIPOCAMBIO", .TC_FECHA, .TC_IDMONEDA.MO_CODIGO, .TC_COMPRA, .TC_VENTA, .TC_USUARIO, .TC_TERMINAL, .TC_FECREG, .TC_IDEMPRESA.EM_ID)
                        Else
                            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOCAMBIO_BYID", .TC_FECHA, .TC_IDMONEDA.MO_CODIGO, .TC_IDEMPRESA.EM_ID)

                            If dr.HasRows Then
                                dr.Read()
                                If dr("TC_COMPRA") = 0 Or dr("TC_VENTA") = 0 Then

                                    dr.Close() : dr = Nothing

                                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_TIPOCAMBIO", .TC_FECHA, _
                                              .TC_IDMONEDA.MO_CODIGO, .TC_COMPRA, .TC_VENTA, _
                                              .TC_USUARIO, .TC_TERMINAL, .TC_FECREG, .TC_IDEMPRESA.EM_ID)
                                Else
                                    dr.Close() : dr = Nothing
                                End If

                            Else
                                dr.Close() : dr = Nothing
                                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TIPOCAMBIO", .TC_FECHA, .TC_IDMONEDA.MO_CODIGO, .TC_COMPRA, .TC_VENTA, .TC_USUARIO, .TC_TERMINAL, .TC_FECREG, .TC_IDEMPRESA.EM_ID)
                            End If

                        End If

                    End With
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_TIPOCAMBIO", CDate(.TC_FECHA), _
                                              .TC_IDMONEDA.MO_CODIGO, .TC_COMPRA, .TC_VENTA, _
                                              .TC_USUARIO, .TC_TERMINAL, .TC_FECREG, .TC_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_TIPOCAMBIO", .TC_FECHA, _
                                              .TC_IDMONEDA.MO_CODIGO, .TC_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub getTipoCambio(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOCAMBIO_BYID", _
                                                                  CDate(Entidad.TC_FECHA), Entidad.TC_IDMONEDA.MO_CODIGO, _
                                                                  Entidad.TC_IDEMPRESA.EM_ID)
                If dr.HasRows Then
                    Do While dr.Read
                        Entidad.TC_COMPRA = IIf(dr("TC_COMPRA") Is DBNull.Value, 0, dr("TC_COMPRA"))
                        Entidad.TC_VENTA = IIf(dr("TC_VENTA") Is DBNull.Value, 0, dr("TC_VENTA"))
                    Loop
                End If

                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function getTipoCambios(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO) As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            getTipoCambios = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
                Dim cambio As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOCAMBIO", _
                                                                  Entidad.TC_FECHA, Entidad.TC_IDMONEDA.MO_CODIGO, _
                                                                  Entidad.TC_IDEMPRESA.EM_ID)
                If dr.HasRows Then
                    Do While dr.Read
                        cambio = New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO()
                        cambio.TC_FECHA = dr("FECHA")
                        cambio.TC_COMPRA = IIf(dr("COMPRA") Is DBNull.Value, 0, dr("COMPRA"))
                        cambio.TC_VENTA = IIf(dr("VENTA") Is DBNull.Value, 0, dr("VENTA"))
                        cambio.TC_IDMONEDA = Entidad.TC_IDMONEDA
                        cambio.TC_IDEMPRESA = Entidad.TC_IDEMPRESA
                        cambio.TC_USUARIO = Entidad.TC_USUARIO
                        cambio.TC_TERMINAL = Entidad.TC_TERMINAL
                        cambio.TC_FECREG = Entidad.TC_FECREG

                        Lista.Add(cambio)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getTipoCambios(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO, ByVal Int_Empresa_Destino As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            'Devuelve un array de la entidad tipo de cambio con el codigo de empresa igual a la variable que se tiene 
            'como parametro

            getTipoCambios = Nothing
            Try
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
                Dim cambio As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOCAMBIO", _
                                                                  Entidad.TC_FECHA, Entidad.TC_IDMONEDA.MO_CODIGO, _
                                                                  Entidad.TC_IDEMPRESA.EM_ID)

                Entidad.TC_IDEMPRESA.EM_ID = Int_Empresa_Destino

                If dr.HasRows Then
                    Do While dr.Read
                        cambio = New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO()
                        cambio.TC_FECHA = dr("FECHA")
                        cambio.TC_COMPRA = IIf(dr("COMPRA") Is DBNull.Value, 0, dr("COMPRA"))
                        cambio.TC_VENTA = IIf(dr("VENTA") Is DBNull.Value, 0, dr("VENTA"))
                        cambio.TC_IDMONEDA = Entidad.TC_IDMONEDA
                        cambio.TC_IDEMPRESA = Entidad.TC_IDEMPRESA
                        cambio.TC_USUARIO = Entidad.TC_USUARIO
                        cambio.TC_TERMINAL = Entidad.TC_TERMINAL
                        cambio.TC_FECREG = Entidad.TC_FECREG

                        Lista.Add(cambio)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return Lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getTipoCambios_Dt(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO) As DataTable
            getTipoCambios_Dt = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_TIPOCAMBIO", Entidad.TC_FECHA, Entidad.TC_IDMONEDA.MO_CODIGO, Entidad.TC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_USUARIO_PAGWEB
        Inherits ClsBD

        Public Sub Insert(ByVal Paginas As List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO_PAGWEB))
            Try
                For Each pagina As BE.ContabilidadBE.SG_CO_TB_USUARIO_PAGWEB In Paginas
                    With pagina
                        SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_USUARIO_PAGWEB", .UP_IDUSUARIO, .UP_DIR_WEB, .UP_IDEMPRESA, .UP_USUARIO, .UP_TERMINAL, .UP_FECREG)
                    End With
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


    End Class

    Public Class SG_CO_TB_ANEXO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                With Entidad

                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BY_DOC", _
                                                                      Entidad.AN_TIPO_DOC.DI_CODIGO, _
                                                                      Entidad.AN_NUM_DOC, _
                                                                      Entidad.AN_TIPO_ANEXO.TA_CODIGO, _
                                                                      Entidad.AN_IDEMPRESA.EM_ID)
                    If dr.HasRows Then
                        dr.Close()
                        dr = Nothing
                        Throw New Exception("El documento " & Entidad.AN_NUM_DOC & " ya esta registrado ")
                        Exit Sub
                    Else
                        dr.Close()
                        dr = Nothing
                    End If



                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_ANEXO", .AN_TIPO_ANEXO.TA_CODIGO, _
                                              .AN_TIPO_EMPRESA.TE_CODIGO, .AN_TIPO_DOC.DI_CODIGO, _
                                              .AN_NUM_DOC, .AN_DESCRIPCION, .AN_PC_USUARIO, _
                                              .AN_PC_TERMINAL, .AN_PC_FECREG, .AN_IDEMPRESA.EM_ID, .AN_ES_RELACIONADO, .AN_ES_NO_DOMI)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert_x_Planillas(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                With Entidad

                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BY_DOC", _
                                                                      Entidad.AN_TIPO_DOC.DI_CODIGO, _
                                                                      Entidad.AN_NUM_DOC, _
                                                                      Entidad.AN_TIPO_ANEXO.TA_CODIGO, _
                                                                      Entidad.AN_IDEMPRESA.EM_ID)
                    If dr.HasRows Then
                        dr.Close()
                        dr = Nothing
                        Throw New Exception("DUPLICADO")
                        Exit Sub
                    Else
                        dr.Close()
                        dr = Nothing
                    End If



                    Entidad.AN_IDANEXO = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_ANEXO_X_PLANILLAS", .AN_TIPO_ANEXO.TA_CODIGO, _
                                              .AN_TIPO_EMPRESA.TE_CODIGO, .AN_TIPO_DOC.DI_CODIGO, _
                                              .AN_NUM_DOC, .AN_DESCRIPCION, .AN_PC_USUARIO, _
                                              .AN_PC_TERMINAL, .AN_PC_FECREG, .AN_IDEMPRESA.EM_ID, .AN_ES_RELACIONADO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert_x_Facturacion(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO, ByVal idclienteFactu_ As Integer)
            Try
                With Entidad

                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BY_DOC", _
                                                                      Entidad.AN_TIPO_DOC.DI_CODIGO, _
                                                                      Entidad.AN_NUM_DOC, _
                                                                      Entidad.AN_TIPO_ANEXO.TA_CODIGO, _
                                                                      Entidad.AN_IDEMPRESA.EM_ID)
                    If dr.HasRows Then
                        dr.Close()
                        dr = Nothing
                        Throw New Exception("Ya existe en Contabilidad")
                        Exit Sub
                    Else
                        dr.Close()
                        dr = Nothing
                    End If

                    Entidad.AN_IDANEXO = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_ANEXO_X_PLANILLAS", .AN_TIPO_ANEXO.TA_CODIGO, _
                                              .AN_TIPO_EMPRESA.TE_CODIGO, .AN_TIPO_DOC.DI_CODIGO, _
                                              .AN_NUM_DOC, .AN_DESCRIPCION, .AN_PC_USUARIO, _
                                              .AN_PC_TERMINAL, .AN_PC_FECREG, .AN_IDEMPRESA.EM_ID, .AN_ES_RELACIONADO, .AN_ES_NO_DOMI)

                    SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "UPDATE SG_FA_TB_CLIENTE SET CL_IDANEX_CONTA = " & Entidad.AN_IDANEXO.ToString & " WHERE CL_ID = " & idclienteFactu_.ToString)

                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BYID", Entidad.AN_IDANEXO)
                If Not dr.HasRows Then
                    dr.Close()
                    dr = Nothing
                    Throw New Exception("El codigo de anexo no existe")
                    Exit Sub
                End If

                dr.Close()
                dr = Nothing

                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_ANEXO", .AN_IDANEXO, .AN_TIPO_ANEXO.TA_CODIGO, _
                                              .AN_TIPO_EMPRESA.TE_CODIGO, .AN_TIPO_DOC.DI_CODIGO, _
                                              .AN_NUM_DOC, .AN_DESCRIPCION, .AN_PC_USUARIO, _
                                              .AN_PC_TERMINAL, .AN_PC_FECREG, .AN_IDEMPRESA.EM_ID, .AN_ES_RELACIONADO, .AN_ES_NO_DOMI)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                With Entidad

                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BYID", Entidad.AN_IDANEXO)
                    If Not dr.HasRows Then
                        dr.Close()
                        dr = Nothing
                        Throw New Exception("El anexo no esta registrado")
                        Exit Sub
                    Else
                        dr.Close()
                        dr = Nothing
                    End If


                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_ANEXO", .AN_IDANEXO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub getAnexo_id_idemp(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BYID_Y_EMP", Entidad.AN_IDANEXO, Entidad.AN_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .AN_TIPO_ANEXO = IIf(dr("AN_TIPO_ANEXO") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("AN_TIPO_ANEXO")})
                            .AN_TIPO_EMPRESA = IIf(dr("AN_TIPO_EMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = dr("AN_TIPO_EMPRESA")})
                            .AN_TIPO_DOC = IIf(dr("AN_TIPO_DOC") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = dr("AN_TIPO_DOC")})
                            .AN_NUM_DOC = IIf(dr("AN_NUM_DOC") Is DBNull.Value, String.Empty, dr("AN_NUM_DOC"))
                            .AN_DESCRIPCION = IIf(dr("AN_DESCRIPCION") Is DBNull.Value, String.Empty, dr("AN_DESCRIPCION"))
                            .AN_PC_USUARIO = IIf(dr("AN_PC_USUARIO") Is DBNull.Value, String.Empty, dr("AN_PC_USUARIO"))
                            .AN_PC_TERMINAL = IIf(dr("AN_PC_TERMINAL") Is DBNull.Value, String.Empty, dr("AN_PC_TERMINAL"))
                            .AN_PC_FECREG = IIf(dr("AN_PC_FECREG") Is DBNull.Value, String.Empty, dr("AN_PC_FECREG"))
                            .AN_IDEMPRESA = IIf(dr("AN_IDEMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = dr("AN_IDEMPRESA")})
                            .AN_ES_RELACIONADO = IIf(dr("AN_ES_RELACIONADO") Is DBNull.Value, 0, dr("AN_ES_RELACIONADO"))
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub getAnexo(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BYID", Entidad.AN_IDANEXO)

                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .AN_TIPO_ANEXO = IIf(dr("AN_TIPO_ANEXO") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("AN_TIPO_ANEXO")})
                            .AN_TIPO_EMPRESA = IIf(dr("AN_TIPO_EMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = dr("AN_TIPO_EMPRESA")})
                            .AN_TIPO_DOC = IIf(dr("AN_TIPO_DOC") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = dr("AN_TIPO_DOC")})
                            .AN_NUM_DOC = IIf(dr("AN_NUM_DOC") Is DBNull.Value, String.Empty, dr("AN_NUM_DOC"))
                            .AN_DESCRIPCION = IIf(dr("AN_DESCRIPCION") Is DBNull.Value, String.Empty, dr("AN_DESCRIPCION"))
                            .AN_PC_USUARIO = IIf(dr("AN_PC_USUARIO") Is DBNull.Value, String.Empty, dr("AN_PC_USUARIO"))
                            .AN_PC_TERMINAL = IIf(dr("AN_PC_TERMINAL") Is DBNull.Value, String.Empty, dr("AN_PC_TERMINAL"))
                            .AN_PC_FECREG = IIf(dr("AN_PC_FECREG") Is DBNull.Value, String.Empty, dr("AN_PC_FECREG"))
                            .AN_IDEMPRESA = IIf(dr("AN_IDEMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = dr("AN_IDEMPRESA")})
                            .AN_ES_RELACIONADO = IIf(dr("AN_ES_RELACIONADO") Is DBNull.Value, 0, dr("AN_ES_RELACIONADO"))
                            .AN_ES_NO_DOMI = IIf(dr("AN_ES_NO_DOMI") Is DBNull.Value, 0, dr("AN_ES_NO_DOMI"))
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub getAnexo_x_Ruc(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BYRUC", Entidad.AN_NUM_DOC, Entidad.AN_TIPO_ANEXO.TA_CODIGO, Entidad.AN_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .AN_IDANEXO = dr("AN_IDANEXO")
                            .AN_TIPO_ANEXO = IIf(dr("AN_TIPO_ANEXO") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("AN_TIPO_ANEXO")})
                            .AN_TIPO_EMPRESA = IIf(dr("AN_TIPO_EMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = dr("AN_TIPO_EMPRESA")})
                            .AN_TIPO_DOC = IIf(dr("AN_TIPO_DOC") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = dr("AN_TIPO_DOC")})
                            .AN_NUM_DOC = IIf(dr("AN_NUM_DOC") Is DBNull.Value, String.Empty, dr("AN_NUM_DOC"))
                            .AN_DESCRIPCION = IIf(dr("AN_DESCRIPCION") Is DBNull.Value, String.Empty, dr("AN_DESCRIPCION"))
                            .AN_ES_RELACIONADO = IIf(dr("AN_ES_RELACIONADO") Is DBNull.Value, 0, dr("AN_ES_RELACIONADO"))
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getAnexo_x_Solo_por_Ruc(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As List(Of BE.ContabilidadBE.SG_CO_TB_ANEXO)
            getAnexo_x_Solo_por_Ruc = Nothing
            Try
                Dim Anexo As BE.ContabilidadBE.SG_CO_TB_ANEXO
                Dim Lista_Anexo As New List(Of BE.ContabilidadBE.SG_CO_TB_ANEXO)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BY_ONLY_RUC", Entidad.AN_NUM_DOC, Entidad.AN_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        Anexo = New BE.ContabilidadBE.SG_CO_TB_ANEXO()
                        With Anexo
                            .AN_IDANEXO = dr("AN_IDANEXO")
                            .AN_TIPO_ANEXO = IIf(dr("AN_TIPO_ANEXO") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("AN_TIPO_ANEXO"), .TA_DESCRIPCION = dr("TA_DESCRIPCION")})
                            .AN_TIPO_EMPRESA = IIf(dr("AN_TIPO_EMPRESA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = dr("AN_TIPO_EMPRESA")})
                            .AN_TIPO_DOC = IIf(dr("AN_TIPO_DOC") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = dr("AN_TIPO_DOC")})
                            .AN_NUM_DOC = IIf(dr("AN_NUM_DOC") Is DBNull.Value, String.Empty, dr("AN_NUM_DOC"))
                            .AN_DESCRIPCION = IIf(dr("AN_DESCRIPCION") Is DBNull.Value, String.Empty, dr("AN_DESCRIPCION"))
                            .AN_ES_RELACIONADO = IIf(dr("AN_ES_RELACIONADO") Is DBNull.Value, 0, dr("AN_ES_RELACIONADO"))
                        End With
                        Lista_Anexo.Add(Anexo)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return Lista_Anexo
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getAnexos(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As List(Of BE.ContabilidadBE.SG_CO_TB_ANEXO)
            Try
                Dim anexo As BE.ContabilidadBE.SG_CO_TB_ANEXO
                Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_ANEXO)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO", Entidad.AN_TIPO_ANEXO.TA_CODIGO, Entidad.AN_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        anexo = New BE.ContabilidadBE.SG_CO_TB_ANEXO()
                        With anexo
                            .AN_IDANEXO = IIf(dr("AN_IDANEXO") Is DBNull.Value, Nothing, dr("AN_IDANEXO"))
                            .AN_PC_USUARIO = IIf(dr("DI_ABREVIATURA") Is DBNull.Value, Nothing, dr("DI_ABREVIATURA"))
                            .AN_NUM_DOC = IIf(dr("AN_NUM_DOC") Is DBNull.Value, String.Empty, dr("AN_NUM_DOC"))
                            .AN_DESCRIPCION = IIf(dr("AN_DESCRIPCION") Is DBNull.Value, String.Empty, dr("AN_DESCRIPCION"))
                        End With
                        Lista.Add(anexo)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return Lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getAnexos_DT(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ANEXO", Entidad.AN_TIPO_ANEXO.TA_CODIGO, Entidad.AN_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getAnexos_DT_Ordenado_Razon(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ANEXO_ord_razon", Entidad.AN_TIPO_ANEXO.TA_CODIGO, Entidad.AN_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function w_getAnexo_x_ruc_dt(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_ANEXO_BY_ONLY_RUC", Entidad.AN_NUM_DOC, Entidad.AN_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function w_getAnexo_x_Razon(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ANEXO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_ANEXO_BY_RAZON", Entidad.AN_DESCRIPCION, Entidad.AN_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Anexo_Anulado(ByVal empresa As Integer) As List(Of String)
            Dim query As String = "SELECT AN_IDANEXO,AN_NUM_DOC,AN_DESCRIPCION FROM SG_CO_TB_ANEXO WHERE AN_DESCRIPCION = 'ANULADO' and an_idempresa = " & empresa.ToString
            Dim lista As New List(Of String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, query)

            If drr.HasRows Then
                drr.Read()
                lista.Add(drr("AN_IDANEXO"))
                lista.Add(drr("AN_NUM_DOC"))
                lista.Add(drr("AN_DESCRIPCION"))
            End If

            drr.Close()

            Return lista

        End Function

        Public Function getTipoAnexos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOANEXO")

                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("TA_CODIGO"), .TA_DESCRIPCION = dr("TA_DESCRIPCION"), .TA_IMG = dr("TA_IMG")})
                    Loop
                    dr.Close()
                Else
                    dr.Close()
                End If

                dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub CopiarAnexos_ExistentesIGF(ByVal cuenta As String, ByVal tipo As Integer, ByVal empresa As Integer)
            Try
                Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, "select * from master where  cod_red_cta = '" & cuenta & "' and codigo_empresa = " & empresa.ToString)


                If dr.HasRows Then
                    Do While dr.Read
                        Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                        Entidad.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO(tipo, "", Nothing)
                        Entidad.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD(dr("mas_tip_doc"), "", "")
                        Entidad.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA(BE.ContabilidadBE.TipoEmpresa.Juridica, "")
                        Entidad.AN_NUM_DOC = dr("ruc_ane")
                        Entidad.AN_DESCRIPCION = dr("Des_Ane")
                        Entidad.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa}
                        Entidad.AN_PC_USUARIO = String.Format("{0}-cbazan", Environment.UserName)
                        Entidad.AN_PC_TERMINAL = Environment.MachineName
                        Entidad.AN_PC_FECREG = Date.Now
                        Try
                            Insert(Entidad)
                        Catch ex As Exception

                        End Try

                    Loop
                End If

                dr.Close()

            Catch ex As Exception

            End Try
        End Sub


    End Class

    Public Class SG_CO_TB_TIPOANEXO
        Inherits ClsBD
        Implements IDisposable

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TIPOANEXO", .TA_CODIGO, .TA_DESCRIPCION, .TA_IMG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_TIPOANEXO", .TA_CODIGO, .TA_DESCRIPCION, .TA_IMG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_TIPOANEXO", .TA_CODIGO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function getTipoAnexos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOANEXO")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("TA_CODIGO"), _
                                                                                 .TA_DESCRIPCION = dr("TA_DESCRIPCION"), _
                                                                                 .TA_IMG = dr("TA_IMG")})
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getTipoAnexos_Dt() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_TIPOANEXO").Tables(0)
        End Function

        Public Sub getTipoAnexo(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOANEXO_BYID", Entidad.TA_CODIGO)
                If dr.HasRows Then
                    Do While dr.Read
                        Entidad.TA_CODIGO = dr("TA_CODIGO")
                        Entidad.TA_DESCRIPCION = dr("TA_DESCRIPCION")
                        Entidad.TA_IMG = dr("TA_IMG")
                    Loop
                End If

                dr.Close()
                dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getTipoAnexo_x_SubDiario(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO) As Integer
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_TIPOANE_BY_SUBDIA", Entidad.SD_ID, Entidad.SD_IDEMPRESA.EM_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getTipoAnexo_x_SubDiario_Hono(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SUBDIARIO) As Integer
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_TIPOANE_BY_SUBDIA_HONO", Entidad.SD_ID, Entidad.SD_IDEMPRESA.EM_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Liberar otro estado (objetos administrados).
                End If

                ' TODO: Liberar su propio estado (objetos no administrados).
                ' TODO: Establecer campos grandes como Null.
            End If
            Me.disposedValue = True
        End Sub

#Region " IDisposable Support "
        ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

    Public Class SG_CO_TB_TIPO_DOC_IDENTIDAD
        Inherits ClsBD

        Public Function getTipoDos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_DOC_IDENTIDAD")
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD)

                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = dr("DI_CODIGO"), .DI_DESCRIPCION = dr("DI_DESCRIPCION"), .DI_ABREVIATURA = dr("DI_ABREVIATURA")})
                    Loop
                End If

                dr.Close()

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

    Public Class SG_CO_TB_TIPOEMPRESA
        Inherits ClsBD

        Public Function getTipoEmpresas() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOEMPRESA")

                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA)

                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = dr("TE_CODIGO"), .TE_DESCRIPCION = dr("TE_DESCRIPCION")})
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_PLANCTAS
        Inherits ClsBD


        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal lista As List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO))
            Try
                With Entidad
                    Dim Int_TipoAnexo As Integer

                    'Validamos que no se repita la cuenta por periodo y empresa________________________________________________

                    Dim cantidad As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_CTAS_NUM_REG", Entidad.PC_NUM_CUENTA, Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID)

                    If cantidad > 0 Then
                        Throw New Exception("La cuenta ya esta registrada para este periodo.")
                        Exit Sub
                    End If

                    'Grabamos__________________________________________________________________________________________________
                    If Entidad.PC_IDTIPO_ANEXO Is Nothing Then
                        Int_TipoAnexo = 0
                    Else
                        Int_TipoAnexo = Entidad.PC_IDTIPO_ANEXO.TA_CODIGO
                    End If

                    Dim Int_IdCuentas As Integer = 0
                    Int_IdCuentas = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_PLANCTAS", _
                                              .PC_NUM_CUENTA, .PC_IDMONEDA.MO_CODIGO, _
                                              .PC_IDCLASE.CC_CODIGO, .PC_IDTIPO_MOV.TM_CODIGO, _
                                              .PC_IDTIPO_MOV_DET.TM_CODIGO, _
                                              IIf(Entidad.PC_IDTIPO_ANEXO Is Nothing, DBNull.Value, Int_TipoAnexo), _
                                              .PC_DESCRIPCION, .PC_PERIODO, .PC_ES_CC, .PC_ES_AUTO, _
                                              .PC_ISTATUS, .PC_USUARIO, .PC_TERMINAL, .PC_FECREG, _
                                              .PC_IDEMPRESA.EM_ID)

                    If Not lista Is Nothing Then
                        If Int_IdCuentas <> 0 Then
                            For Each destino As BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO In lista
                                With destino
                                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_I_CTA_DESTINO", Int_IdCuentas, .CD_CTA_DESTINO, .CD_DH, .CD_PORCE, .CD_PC_USUARIO, .CD_PC_TERMINAL, .CD_PC_FECREG, .CD_SECUENCIA)
                                End With
                            Next
                        End If
                    End If



                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            Try
                Dim Int_TipoAnexo As Integer
                If Entidad.PC_IDTIPO_ANEXO Is Nothing Then
                    Int_TipoAnexo = 0
                Else
                    Int_TipoAnexo = Entidad.PC_IDTIPO_ANEXO.TA_CODIGO
                End If

                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_PLANCTAS", .PC_IDCUENTA, _
                                              .PC_NUM_CUENTA, .PC_IDMONEDA.MO_CODIGO, _
                                              .PC_IDCLASE.CC_CODIGO, .PC_IDTIPO_MOV.TM_CODIGO, _
                                              .PC_IDTIPO_MOV_DET.TM_CODIGO, _
                                              IIf(Entidad.PC_IDTIPO_ANEXO Is Nothing, DBNull.Value, Int_TipoAnexo), _
                                              .PC_DESCRIPCION, .PC_PERIODO, .PC_ES_CC, .PC_ES_AUTO, _
                                              .PC_ISTATUS, .PC_USUARIO, .PC_TERMINAL, .PC_FECREG, _
                                              .PC_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            Try
                With Entidad

                    Dim num_reg As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_C_TIENE_MOVS", _
                                                                     .PC_IDCUENTA, _
                                                                     .PC_PERIODO, _
                                                                     .PC_IDEMPRESA.EM_ID)

                    If num_reg > 0 Then
                        Throw New Exception(String.Format("La cuenta tiene movimientos registrados.{0}No se puede eliminar.{0}Elimine o anule los movimientos de con esta cuenta.", Chr(13)))
                        Exit Sub
                    End If

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_PLANCTAS", .PC_IDCUENTA)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub getCuenta(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_PLANCTAS_BYID", Entidad.PC_IDCUENTA)

                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .PC_NUM_CUENTA = IIf(dr("PC_NUM_CUENTA") Is DBNull.Value, 0, dr("PC_NUM_CUENTA"))
                            .PC_IDMONEDA = IIf(dr("PC_IDMONEDA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = dr("PC_IDMONEDA")})
                            .PC_IDCLASE = IIf(dr("PC_IDCLASE") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_CLASE_CTA With {.CC_CODIGO = dr("PC_IDCLASE")})
                            .PC_IDTIPO_MOV = IIf(dr("PC_IDTIPO_MOV") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOMOV With {.TM_CODIGO = dr("PC_IDTIPO_MOV")})
                            .PC_IDTIPO_MOV_DET = IIf(dr("PC_IDTIPO_MOV_DET") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = dr("PC_IDTIPO_MOV_DET")})

                            If dr("PC_IDTIPO_ANEXO") Is DBNull.Value Then
                                .PC_IDTIPO_ANEXO = Nothing
                            Else
                                .PC_IDTIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("PC_IDTIPO_ANEXO")}
                            End If

                            .PC_DESCRIPCION = IIf(dr("PC_DESCRIPCION") Is DBNull.Value, String.Empty, dr("PC_DESCRIPCION"))
                            .PC_PERIODO = IIf(dr("PC_PERIODO") Is DBNull.Value, 0, dr("PC_PERIODO"))
                            .PC_ES_CC = IIf(dr("PC_ES_CC") Is DBNull.Value, 0, dr("PC_ES_CC"))
                            .PC_ES_AUTO = IIf(dr("PC_ES_AUTO") Is DBNull.Value, 0, dr("PC_ES_AUTO"))
                            .PC_ISTATUS = IIf(dr("PC_ISTATUS") Is DBNull.Value, 0, dr("PC_ISTATUS"))
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub getCuenta_X_NumeroCta(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_PLANCTAS_BYCTA", Entidad.PC_NUM_CUENTA, Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .PC_NUM_CUENTA = IIf(dr("PC_NUM_CUENTA") Is DBNull.Value, 0, dr("PC_NUM_CUENTA"))
                            .PC_IDMONEDA = IIf(dr("PC_IDMONEDA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = dr("PC_IDMONEDA")})
                            .PC_IDCLASE = IIf(dr("PC_IDCLASE") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_CLASE_CTA With {.CC_CODIGO = dr("PC_IDCLASE")})
                            .PC_IDTIPO_MOV = IIf(dr("PC_IDTIPO_MOV") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOMOV With {.TM_CODIGO = dr("PC_IDTIPO_MOV")})
                            .PC_IDTIPO_MOV_DET = IIf(dr("PC_IDTIPO_MOV_DET") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = dr("PC_IDTIPO_MOV_DET")})

                            If dr("PC_IDTIPO_ANEXO") Is DBNull.Value Then
                                .PC_IDTIPO_ANEXO = Nothing
                            Else
                                .PC_IDTIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("PC_IDTIPO_ANEXO")}
                            End If

                            .PC_DESCRIPCION = IIf(dr("PC_DESCRIPCION") Is DBNull.Value, String.Empty, dr("PC_DESCRIPCION"))
                            .PC_PERIODO = IIf(dr("PC_PERIODO") Is DBNull.Value, 0, dr("PC_PERIODO"))
                            .PC_ES_CC = IIf(dr("PC_ES_CC") Is DBNull.Value, 0, dr("PC_ES_CC"))
                            .PC_ES_AUTO = IIf(dr("PC_ES_AUTO") Is DBNull.Value, 0, dr("PC_ES_AUTO"))
                            .PC_ISTATUS = IIf(dr("PC_ISTATUS") Is DBNull.Value, 0, dr("PC_ISTATUS"))
                            .PC_IDCUENTA = IIf(dr("PC_IDCUENTA") Is DBNull.Value, 0, dr("PC_IDCUENTA"))
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getCuentas_DT(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataTable

            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_DT", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getCuentas_DT_X_cuentas(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal Str_Cuenta_Ini As String, ByVal Str_Cuenta_Fin As String) As DataTable
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_DT_F", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID, Str_Cuenta_Ini, Str_Cuenta_Fin).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getCuentas_Movimiento(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataTable
            getCuentas_Movimiento = Nothing
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_DT_MOV", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getCuentas_NDig(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal Int_Num_Digitos As Integer) As DataTable
            getCuentas_NDig = Nothing
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_DT_2DIG", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID, Int_Num_Digitos).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getCuentas_Movimiento_Con_Check(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataTable
            getCuentas_Movimiento_Con_Check = Nothing
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_DT_MOV2", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getCuentas_Movimiento_Tipo_Caja_Bancos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataTable
            getCuentas_Movimiento_Tipo_Caja_Bancos = Nothing
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CTAS_TIPO_CAJABANCO", Entidad.PC_PERIODO, Entidad.PC_IDTIPO_MOV_DET.TM_CODIGO, Entidad.PC_IDEMPRESA.EM_ID).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getCuentas_Manejan_Anexo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataTable
            getCuentas_Manejan_Anexo = Nothing
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_DT_CTAANE", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getCuentas_Ds(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataSet
            Try
                Dim ds_cuentas As DataSet
                ds_cuentas = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_12", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID)
                ds_cuentas.Tables(0).TableName = "Digitos2"
                ds_cuentas.Tables(1).TableName = "Digitos4"
                ds_cuentas.Tables(2).TableName = "Digitos6"

                ds_cuentas.Relations.Add("Nivel1", ds_cuentas.Tables("Digitos2").Columns("CUENTA"), ds_cuentas.Tables("Digitos4").Columns("Padre"), False)
                ds_cuentas.Relations.Add("Nivel2", ds_cuentas.Tables("Digitos4").Columns("CUENTA"), ds_cuentas.Tables("Digitos6").Columns("Padre"), False)



                Return ds_cuentas
            Catch ex As Exception
                Throw ex
            End Try


        End Function


        Public Function getCuentas_Ds_2(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataSet

            Dim ds_cuentas As DataSet
            ds_cuentas = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_12_2", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID)
            ds_cuentas.Tables(0).TableName = "Digitos2"
            ds_cuentas.Tables(1).TableName = "Digitos3"
            ds_cuentas.Tables(2).TableName = "Digitos4"
            ds_cuentas.Tables(3).TableName = "Digitos6"

            ds_cuentas.Relations.Add("Nivel1", ds_cuentas.Tables("Digitos2").Columns("CUENTA"), ds_cuentas.Tables("Digitos3").Columns("Padre"), False)
            ds_cuentas.Relations.Add("Nivel2", ds_cuentas.Tables("Digitos3").Columns("CUENTA"), ds_cuentas.Tables("Digitos4").Columns("Padre"), False)
            ds_cuentas.Relations.Add("Nivel3", ds_cuentas.Tables("Digitos4").Columns("CUENTA"), ds_cuentas.Tables("Digitos6").Columns("Padre"), False)

            Return ds_cuentas
            
        End Function

        Public Function getCuentas_Ds_3(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataSet

            Dim ds_cuentas As DataSet
            ds_cuentas = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_12_3", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID)
            ds_cuentas.Tables(0).TableName = "Digitos2"
            ds_cuentas.Tables(1).TableName = "Digitos3"
            ds_cuentas.Tables(2).TableName = "Digitos4"
            ds_cuentas.Tables(3).TableName = "Digitos5"
            ds_cuentas.Tables(4).TableName = "Digitos6"

            ds_cuentas.Relations.Add("Nivel1", ds_cuentas.Tables("Digitos2").Columns("CUENTA"), ds_cuentas.Tables("Digitos3").Columns("Padre"), False)
            ds_cuentas.Relations.Add("Nivel2", ds_cuentas.Tables("Digitos3").Columns("CUENTA"), ds_cuentas.Tables("Digitos4").Columns("Padre"), False)
            ds_cuentas.Relations.Add("Nivel3", ds_cuentas.Tables("Digitos4").Columns("CUENTA"), ds_cuentas.Tables("Digitos5").Columns("Padre"), False)
            ds_cuentas.Relations.Add("Nivel4", ds_cuentas.Tables("Digitos5").Columns("CUENTA"), ds_cuentas.Tables("Digitos6").Columns("Padre"), False)

            Return ds_cuentas

        End Function


        Public Function getCuentas_Ayuda(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As DataTable
            Try
                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_PLANCTAS_AYU", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID).Tables(0)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getCuentas(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_PLANCTAS) As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
            Try

                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
                Dim cuenta As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_PLANCTAS", Entidad.PC_PERIODO, Entidad.PC_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        cuenta = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS()
                        With cuenta
                            .PC_IDCUENTA = IIf(dr("PC_IDCUENTA") Is DBNull.Value, 0, dr("PC_IDCUENTA"))
                            .PC_NUM_CUENTA = IIf(dr("PC_NUM_CUENTA") Is DBNull.Value, 0, dr("PC_NUM_CUENTA"))
                            .PC_IDMONEDA = IIf(dr("PC_IDMONEDA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = dr("PC_IDMONEDA")})
                            .PC_IDCLASE = IIf(dr("PC_IDCLASE") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_CLASE_CTA With {.CC_CODIGO = dr("PC_IDCLASE")})
                            .PC_IDTIPO_MOV = IIf(dr("PC_IDTIPO_MOV") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOMOV With {.TM_CODIGO = dr("PC_IDTIPO_MOV")})
                            .PC_IDTIPO_MOV_DET = IIf(dr("PC_IDTIPO_MOV_DET") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = dr("PC_IDTIPO_MOV_DET")})

                            If dr("PC_IDTIPO_ANEXO") Is DBNull.Value Then
                                .PC_IDTIPO_ANEXO = Nothing
                            Else
                                .PC_IDTIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = dr("PC_IDTIPO_ANEXO")}
                            End If

                            .PC_DESCRIPCION = IIf(dr("PC_DESCRIPCION") Is DBNull.Value, String.Empty, dr("PC_DESCRIPCION"))
                            .PC_PERIODO = IIf(dr("PC_PERIODO") Is DBNull.Value, 0, dr("PC_PERIODO"))
                            .PC_ES_CC = IIf(dr("PC_ES_CC") Is DBNull.Value, 0, dr("PC_ES_CC"))
                            .PC_ES_AUTO = IIf(dr("PC_ES_AUTO") Is DBNull.Value, 0, dr("PC_ES_AUTO"))
                            .PC_ISTATUS = IIf(dr("PC_ISTATUS") Is DBNull.Value, 0, dr("PC_ISTATUS"))
                        End With
                        lista.Add(cuenta)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getTipoMovis() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOMOV)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOMOV)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOMOV")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPOMOV With {.TM_CODIGO = dr("TM_CODIGO"), .TM_DESCRIPCION = dr("TM_DESCRIPCION")})
                    Loop
                    dr.Close()
                Else
                    dr.Close()
                End If

                dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getTipoMovisDet() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPOMOV_DET")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = dr("TM_CODIGO"), .TM_DESCRIPCION = dr("TM_DESCRIPCION")})
                    Loop
                    dr.Close()
                Else
                    dr.Close()
                End If

                dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getClase_de_Cuenta(ByVal Clase As BE.ContabilidadBE.SG_CO_TB_CLASE_CTA) As String
            Try
                Dim resultado As String
                resultado = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_CLASE_CTA_BYID", Clase.CC_CODIGO)
                Return resultado
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function get_Cuentas_por_CentroCosto(ByVal periodo As Integer, ByVal empresa As Integer, ByVal pc As String) As DataTable
            get_Cuentas_por_CentroCosto = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CTAS_X_CC", periodo, empresa, pc).Tables(0)
        End Function


    End Class

    Public Class SG_CO_TB_CTA_DESTINO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_I_CTA_DESTINO", .CD_IDCUENTA.PC_IDCUENTA, .CD_CTA_DESTINO, .CD_DH, .CD_PORCE, .CD_PC_USUARIO, .CD_PC_TERMINAL, .CD_PC_FECREG, .CD_SECUENCIA)
            End With
        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_U_CTA_DESTINO", .CD_IDCUENTA, .CD_CTA_DESTINO, .CD_DH, .CD_PORCE, .CD_PC_USUARIO, .CD_PC_TERMINAL, .CD_PC_FECREG, .CD_SECUENCIA)
            End With
        End Sub
        Public Sub Delete(ByVal Int_IdCuenta As Integer, ByVal Int_Secuencia As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_D_CTA_DESTINO", Int_Secuencia, Int_IdCuenta)
        End Sub
        Public Sub Delete(ByVal Int_IdCuenta As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_D_CTA_DESTINO_BY_CUENTA", Int_IdCuenta)
        End Sub
        Public Function Tiene_Destinos(ByVal Int_IdCuenta As Integer) As Boolean
            Tiene_Destinos = False
            Try
                Dim Int_Resultado As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_TB_S_NUM_DESTINOS", Int_IdCuenta)

                If Int_Resultado = 0 Then
                    Return False
                Else
                    Return True
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getCuentasDestinos(ByVal Int_IdCuenta As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)
            getCuentasDestinos = Nothing
            Try
                Dim cuenta As BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_TB_S_CTA_DESTINO", Int_IdCuenta)

                If dr.HasRows Then
                    Do While dr.Read
                        cuenta = New BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO()
                        With cuenta
                            .CD_IDCUENTA = IIf(dr("CD_IDCUENTA") Is DBNull.Value, Nothing, New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("CD_IDCUENTA")})
                            .CD_CTA_DESTINO = IIf(dr("CD_CTA_DESTINO") Is DBNull.Value, String.Empty, dr("CD_CTA_DESTINO"))
                            .CD_DH = IIf(dr("CD_DH") Is DBNull.Value, String.Empty, dr("CD_DH"))
                            .CD_PORCE = IIf(dr("CD_PORCE") Is DBNull.Value, 0, dr("CD_PORCE"))
                            .CD_SECUENCIA = IIf(dr("CD_SECUENCIA") Is DBNull.Value, 0, dr("CD_SECUENCIA"))
                        End With
                        lista.Add(cuenta)
                    Loop
                End If
                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub Crear_Destino_Faltantes()
            Try
                Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contafarma;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
                Dim Query As String = String.Empty
                For j As Integer = 0 To 800
                    Query = "SELECT * FROM MOV2 WHERE LIB_ASI = 3 AND TIP_COM = 20 AND ANHO = 2011 AND PER_ASI = '05' AND CODIGO_EMPRESA = 1 AND NUM_COM = '" & j & "'"
                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(cnigf, CommandType.Text, Query)
                    Dim Bol_Tiene_cta_69 As Boolean = False
                    Dim filas As Integer = 0
                    If dr.HasRows Then
                        Do While dr.Read
                            filas += 1
                            If dr("num_cta") = "659909" Then
                                If CDbl(dr("Mon_Mov")) > 0 Then
                                    Bol_Tiene_cta_69 = Not Bol_Tiene_cta_69
                                End If
                            End If
                            If dr("num_cta") = "915020" Or dr("num_cta") = "791101" Then
                                Bol_Tiene_cta_69 = False
                            End If

                        Loop
                    End If

                    dr.Close()

                    If Bol_Tiene_cta_69 Then
                        Query = "SELECT * FROM MOV2 WHERE LIB_ASI = 3 AND TIP_COM = 20 AND ANHO = 2011 AND PER_ASI = '05' AND CODIGO_EMPRESA = 1 AND NUM_COM = '" & j & "' AND NUM_CTA = '659909'"
                        Dim dt As DataTable = SqlHelper.ExecuteDataset(cnigf, CommandType.Text, Query).Tables(0)
                        For i As Integer = 0 To dt.Rows.Count - 1
                            SqlHelper.ExecuteNonQuery(cnigf, "ac_InsertDetails", "1", dt(i)("codigo_empresa"), dt(i)("int_otr_car"), dt(i)("intcasflo"), _
                                                      dt(i)("par_pre"), dt(i)("tip_com_ref"), dt(i)("num_ser_ref"), dt(i)("num_doc_ref"), _
                                                      dt(i)("fec_emi_com_ref"), dt(i)("num_con_det"), dt(i)("fec_emi_det"), dt(i)("tip_cam_det"), _
                                                      dt(i)("anho"), dt(i)("lib_asi"), dt(i)("fec_asi"), dt(i)("per_asi"), dt(i)("tip_com"), _
                                                      dt(i)("num_com"), (filas + 1).ToString, "915020", "915020", dt(i)("cen_cos"), _
                                                      dt(i)("tip_mon"), "D", dt(i)("tip_doc"), dt(i)("ser_doc"), dt(i)("num_doc"), _
                                                      dt(i)("doc_ane"), dt(i)("mon_mov"), dt(i)("des_mov"), dt(i)("tip_cam"), dt(i)("mon_reg"), _
                                                      dt(i)("cod_ane"), dt(i)("id"), dt(i)("inafecto"), dt(i)("des_asi"), dt(i)("fec_emision"), _
                                                      dt(i)("porc_detraccion"))

                            SqlHelper.ExecuteNonQuery(cnigf, "ac_InsertDetails", "1", dt(i)("codigo_empresa"), dt(i)("int_otr_car"), dt(i)("intcasflo"), _
                                                      dt(i)("par_pre"), dt(i)("tip_com_ref"), dt(i)("num_ser_ref"), dt(i)("num_doc_ref"), _
                                                      dt(i)("fec_emi_com_ref"), dt(i)("num_con_det"), dt(i)("fec_emi_det"), dt(i)("tip_cam_det"), _
                                                      dt(i)("anho"), dt(i)("lib_asi"), dt(i)("fec_asi"), dt(i)("per_asi"), dt(i)("tip_com"), _
                                                      dt(i)("num_com"), (filas + 2).ToString, "791101", "791101", dt(i)("cen_cos"), _
                                                      dt(i)("tip_mon"), "H", dt(i)("tip_doc"), dt(i)("ser_doc"), dt(i)("num_doc"), _
                                                      dt(i)("doc_ane"), dt(i)("mon_mov"), dt(i)("des_mov"), dt(i)("tip_cam"), dt(i)("mon_reg"), _
                                                      dt(i)("cod_ane"), dt(i)("id"), dt(i)("inafecto"), dt(i)("des_asi"), dt(i)("fec_emision"), _
                                                      dt(i)("porc_detraccion"))
                        Next
                    End If

                Next







            Catch ex As Exception

            End Try
        End Sub


        Public Sub Copiar_DestinosIGF_a_PlanCtasNuevo()
            Try
                Dim empresa As String = "6"
                Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Contable;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
                Dim Query As String = "SELECT ps.num_cta,Nom_Cta FROM PlanSUNAT ps WHERE ps.Codigo_Empresa = 1 AND ps.anho = 2011 AND ps.Movimie = 2 AND ps.Num_Cta >= '621101'"
                Query = "SELECT PC_NUM_CUENTA,PC_DESCRIPCION FROM SG_CO_TB_PLANCTAS WHERE PC_IDEMPRESA = " & empresa & " AND PC_PERIODO = 2012 AND PC_IDTIPO_MOV = 2 AND PC_NUM_CUENTA > '621101'"

                Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, Query).Tables(0)

                For i As Integer = 0 To dt.Rows.Count - 1

                    If dt(i)(0).ToString = "656119" Then
                        Dim tyt As Integer = 0
                    End If

                    Dim Query2 As String = String.Format("SELECT ps.num_cta,ps.cta6,ps.cta6_h  FROM PlanSUNAT ps WHERE ps.Codigo_Empresa = " & empresa & " AND ps.anho = 2011 AND ps.Movimie = 2 AND cta6 = '{0}'", dt(i)(0).ToString.Trim)
                    Query2 = "SELECT PC_NUM_CUENTA,PC_DESCRIPCION FROM SG_CO_TB_PLANCTAS WHERE PC_IDEMPRESA = " & empresa & " AND PC_PERIODO = 2012 AND PC_IDTIPO_MOV = 2 AND PC_DESCRIPCION = '" & dt(i)(1).ToString.Trim & "' AND PC_NUM_CUENTA LIKE '9%' "

                    Dim IdCuenta As Integer = SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("SELECT PC_IDCUENTA FROM SG_CO_TB_PLANCTAS WHERE PC_IDEMPRESA  = " & empresa & " and pc_periodo = 2012 and PC_NUM_CUENTA = '{0}'", dt(i)(0).ToString.Trim))
                    Dim Dr As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, Query2).Tables(0)
                    Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO
                    Dim cuenta79 As String = "791101"


                    If IdCuenta = 0 Then
                        Dim planbe As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                        Dim planbl As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

                        With planbe
                            .PC_DESCRIPCION = dt(i)(1).ToString.Trim
                            .PC_ES_AUTO = 0
                            .PC_ES_CC = 0
                            .PC_FECREG = Now.Date
                            .PC_IDCLASE = New BE.ContabilidadBE.SG_CO_TB_CLASE_CTA With {.CC_CODIGO = dt(i)(0).ToString.Trim.Substring(0, 1)}
                            .PC_IDCUENTA = 0
                            .PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
                            .PC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                            .PC_IDTIPO_ANEXO = Nothing
                            .PC_IDTIPO_MOV = New BE.ContabilidadBE.SG_CO_TB_TIPOMOV With {.TM_CODIGO = 2}
                            .PC_IDTIPO_MOV_DET = New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = 1}
                            .PC_ISTATUS = 1
                            .PC_NUM_CUENTA = dt(i)(0).ToString.Trim
                            .PC_PERIODO = 2012
                            .PC_TERMINAL = "sistemas"
                            .PC_USUARIO = "Carlos"

                        End With
                        planbl.Insert(planbe, Nothing)
                        IdCuenta = SqlHelper.ExecuteScalar(Cn, CommandType.Text, String.Format("SELECT PC_IDCUENTA FROM SG_CO_TB_PLANCTAS WHERE PC_IDEMPRESA  = " & empresa & "  and pc_periodo = 2012 and PC_NUM_CUENTA = '{0}'", dt(i)(0).ToString.Trim))
                    End If

                    If Dr.Rows.Count > 0 Then
                        Dim j As Integer = 1
                        For Each fila As DataRow In Dr.Rows

                            Entidad = New BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO
                            Entidad.CD_CTA_DESTINO = fila("PC_NUM_CUENTA")
                            Entidad.CD_DH = "D"
                            Entidad.CD_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = IdCuenta}
                            Entidad.CD_PC_FECREG = Now.Date.ToShortDateString
                            Entidad.CD_PC_TERMINAL = Environment.MachineName
                            Entidad.CD_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Karlos")
                            Entidad.CD_PORCE = 0
                            Entidad.CD_SECUENCIA = j
                            Insert(Entidad)
                            j += 1
                        Next

                        'la 79
                        Entidad = New BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO
                        Entidad.CD_CTA_DESTINO = cuenta79
                        Entidad.CD_DH = "H"
                        Entidad.CD_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = IdCuenta}
                        Entidad.CD_PC_FECREG = Now.Date.ToShortDateString
                        Entidad.CD_PC_TERMINAL = Environment.MachineName
                        Entidad.CD_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, "Karlos")
                        Entidad.CD_PORCE = 100
                        Entidad.CD_SECUENCIA = j
                        Insert(Entidad)

                    End If

                Next

            Catch ex As Exception
                Throw ex
            End Try
        End Sub


    End Class

    Public Class SG_CO_TB_CONCEPTO_REGISTRO
        Inherits ClsBD


        Public Function getConceptos() As DataTable
            getConceptos = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CONCEPTOREG").Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_ASIENTO_CONTABLE
        Inherits ClsBD


        Public Function get_Ctas_Diferencia(ByVal anho As Integer, ByVal empresa As Integer) As List(Of String)
            Dim lista_ctas As New List(Of String)

            Dim query As String = "select CDC_CTA_GANANCIA from SG_CO_TB_CTA_DIF_CAM where cdc_idempresa = " & empresa.ToString & " and CDC_ANHO = " & anho.ToString
            lista_ctas.Add(SqlHelper.ExecuteScalar(Cn, CommandType.Text, query))

            query = "select CDC_CTA_PERDIDA from SG_CO_TB_CTA_DIF_CAM where cdc_idempresa = " & empresa.ToString & " and CDC_ANHO = " & anho.ToString
            lista_ctas.Add(SqlHelper.ExecuteScalar(Cn, CommandType.Text, query))

            Return lista_ctas

        End Function

        Public Sub Delete(ByVal Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_ASIENTO_CAB", Ent_Cab.AC_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Anular_Ventas(ByVal IdVoucher As Integer)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_ANULA_VOUCHER_VENTAS", IdVoucher)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Anular_CajaBancos(ByVal IdVoucher As Integer)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_ANULA_VOUCHER_CAJA", IdVoucher)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Insert_Caja_Facturacion(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, _
                                    ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), _
                                    ByRef Str_NumVoucher As String, ByVal ls_ids_comprobs As List(Of Integer), ByVal cajaBE As BE.FacturacionBE.SG_FA_TB_CAJA_CAB, ByVal ls_caja_det As List(Of BE.FacturacionBE.SG_FA_TB_CAJA_DET))


            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", _
                                                         Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                         Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                         Ent_Cab.AC_IDEMPRESA.EM_ID)


                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                'Grabamos la Cabecera
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB", .AC_IDSUBDIARIO.SD_ID, _
                                                                  .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                                                  .AC_IDMONEDA.MO_CODIGO, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                                                  .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                                                  .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                                                  .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID)
                End With

                'este procedimiento debe grabar em detalle
                For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In Ent_Detalles
                    With detalle

                        Dim Int_TipAnexo As Integer = 0
                        Dim Int_CodAnexo As Integer = 0
                        Dim Str_TipDoc As String = String.Empty
                        Dim Int_CodCC As Integer = 0
                        Dim Str_CodMP As String = String.Empty

                        If Not .AD_TANEXO Is Nothing Then Int_TipAnexo = .AD_TANEXO.TA_CODIGO
                        If Not .AD_IDANEXO Is Nothing Then Int_CodAnexo = .AD_IDANEXO.AN_IDANEXO
                        If Not .AD_TDOC Is Nothing Then Str_TipDoc = .AD_TDOC.DO_CODIGO
                        If Not .AD_IDCC Is Nothing Then Int_CodCC = .AD_IDCC.CC_CODIGO
                        If Not .AD_IDMEDIOPAGO Is Nothing Then Str_CodMP = .AD_IDMEDIOPAGO.MP_CODIGO


                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_CAJABANCOS", Ent_Cab.AC_ID, _
                                                    .AD_SECUENCIA, .AD_CUENTA, _
                                                    IIf(Int_TipAnexo = 0, DBNull.Value, Int_TipAnexo), _
                                                    IIf(Int_CodAnexo = 0, DBNull.Value, Int_CodAnexo), _
                                                    IIf(Str_TipDoc.Equals(String.Empty), DBNull.Value, Str_TipDoc), _
                                                    .AD_SDOC, _
                                                    .AD_NDOC, _
                                                    IIf(.AD_FDOC.Equals(String.Empty), DBNull.Value, .AD_FDOC), _
                                                    IIf(.AD_VDOC.Equals(String.Empty), DBNull.Value, .AD_VDOC), _
                                                    .AD_DEBE, _
                                                    .AD_HABER, .AD_TCAM, .AD_SEC_ORI_DESTINO, _
                                                    .AD_GLOSA, _
                                                    IIf(Int_CodCC = 0, DBNull.Value, Int_CodCC), _
                                                    .AD_ES_DESTINO, .AD_USUARIO, _
                                                    .AD_TERMINAL, .AD_FECREG, _
                                                    IIf(Str_CodMP.Equals(String.Empty), DBNull.Value, Str_CodMP), _
                                                    .AD_MONTO_ORI, .AD_PORCE_DESTINO)


                    End With
                Next


                For Each id_compro As Integer In ls_ids_comprobs

                    Dim queryy As String = "UPDATE SG_FA_TB_COMPROBANTE_C SET CO_ES_CONTA_CANCE = 1 WHERE CO_ID = " & id_compro.ToString & " AND CO_IDEMPRESA = " & Ent_Cab.AC_IDEMPRESA.EM_ID.ToString
                    SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, queryy)

                Next


                SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_U_ACT_NUMVOUCHER", _
                                                Ent_Cab.AC_ANHO, _
                                                Ent_Cab.AC_MES, _
                                                Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                Ent_Cab.AC_NUM_VOUCHER, _
                                                Ent_Cab.AC_IDEMPRESA.EM_ID)


                'cajaBE.CA_IDVOUCHER = Ent_Cab.AC_ID
                'cajaBE.CA_NUM_VOU_CONTA = Str_NumVoucher

                'With cajaBE
                '    SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_U_CAJA_CAB", .CA_ID, _
                '                                           .CA_CIE_SOL, .CA_CIE_DOL, .CA_USUARIO_CIE, _
                '                                           .CA_TERMINAL_CIE, .CA_FECREG_CIE, _
                '                                           .CA_NUM_VOU_CONTA, .CA_IDVOUCHER, .CA_IDEMPRESA)
                'End With

                'For Each det As BE.FacturacionBE.SG_FA_TB_CAJA_DET In ls_caja_det
                '    SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_CAJA_DET", cajaBE.CA_ID, det.CD_IDCOMPRO)
                'Next


                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Insert_Generales(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, _
                                    ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), _
                                    ByRef Str_NumVoucher As String, _
                                    ByVal Bol_Edit As Boolean)


            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                If Bol_Edit Then
                    'como esta en cascada la relacion al eliminar la cabecera eliminara tambien en :
                    'Detalle,Reg. de Compras, reg. de Ventas y saldo por anexo
                    Ent_Cab.AC_ES_INTERFACE = SqlHelper.ExecuteScalar(TRvar, CommandType.Text, "SELECT isnull(AC_ES_INTERFACE,0) FROM SG_CO_TB_ASIENTO_CAB WHERE AC_ID = " & Ent_Cab.AC_ID)
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_D_ASIENTO_CAB", Ent_Cab.AC_ID)
                Else
                    Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", _
                                                             Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                End If

                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                'Grabamos la Cabecera
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB", .AC_IDSUBDIARIO.SD_ID, _
                                                                  .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                                                  .AC_IDMONEDA.MO_CODIGO, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                                                  .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                                                  .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                                                  .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID)
                End With

                'este procedimiento debe grabar em detalle
                For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In Ent_Detalles
                    With detalle

                        Dim Int_TipAnexo As Integer = 0
                        Dim Int_CodAnexo As Integer = 0
                        Dim Str_TipDoc As String = String.Empty
                        Dim Int_CodCC As Integer = 0
                        Dim Str_CodMP As String = String.Empty

                        If Not .AD_TANEXO Is Nothing Then Int_TipAnexo = .AD_TANEXO.TA_CODIGO
                        If Not .AD_IDANEXO Is Nothing Then Int_CodAnexo = .AD_IDANEXO.AN_IDANEXO
                        If Not .AD_TDOC Is Nothing Then Str_TipDoc = .AD_TDOC.DO_CODIGO
                        If Not .AD_IDCC Is Nothing Then Int_CodCC = .AD_IDCC.CC_CODIGO
                        If Not .AD_IDMEDIOPAGO Is Nothing Then Str_CodMP = .AD_IDMEDIOPAGO.MP_CODIGO

                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_GENERALES", Ent_Cab.AC_ID, _
                                                  .AD_SECUENCIA, .AD_CUENTA, _
                                                    IIf(Int_TipAnexo = 0, DBNull.Value, Int_TipAnexo), _
                                                    IIf(Int_CodAnexo = 0, DBNull.Value, Int_CodAnexo), _
                                                    IIf(Str_TipDoc = "", DBNull.Value, Str_TipDoc), _
                                                    .AD_SDOC, _
                                                    .AD_NDOC, _
                                                    IIf(.AD_FDOC.Equals(String.Empty), DBNull.Value, .AD_FDOC), _
                                                    IIf(.AD_VDOC.Equals(String.Empty), DBNull.Value, .AD_VDOC), _
                                                    .AD_DEBE, _
                                                    .AD_HABER, .AD_TCAM, .AD_SEC_ORI_DESTINO, _
                                                    .AD_GLOSA, _
                                                    IIf(Int_CodCC = 0, DBNull.Value, Int_CodCC), _
                                                    .AD_ES_DESTINO, .AD_USUARIO, _
                                                    .AD_TERMINAL, .AD_FECREG, _
                                                    IIf(Str_CodMP.Equals(String.Empty), DBNull.Value, Str_CodMP), _
                                                    .AD_MONTO_ORI, .AD_PORCE_DESTINO)
                    End With
                Next


                If Not Bol_Edit Then
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_U_ACT_NUMVOUCHER", _
                                                    Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_NUM_VOUCHER, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Insert_Compras(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, _
                                  ByVal Ent_Compras As BE.ContabilidadBE.SG_CO_TB_COMPRAS, _
                                ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), _
                                ByRef Str_NumVoucher As String, _
                                ByVal Bol_Edit As Boolean)

            Dim Bol_Actualizar_Numero As Boolean = True
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                If Bol_Edit Then
                    'como esta en cascada la relacion al eliminar la cabecera eliminara tambien en :
                    'Detalle,Reg. de Compras, reg. de Ventas y saldo por anexo    
                    Ent_Cab.AC_ES_INTERFACE = SqlHelper.ExecuteScalar(TRvar, CommandType.Text, "SELECT isnull(AC_ES_INTERFACE,0) FROM SG_CO_TB_ASIENTO_CAB WHERE AC_ID = " & Ent_Cab.AC_ID)
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_D_ASIENTO_CAB", Ent_Cab.AC_ID)
                Else
                    If Ent_Cab.AC_NUM_VOUCHER.Trim.Length = 0 Then
                        Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", _
                                                             Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                    Else
                        Str_NumVoucher = Ent_Cab.AC_NUM_VOUCHER
                        Bol_Actualizar_Numero = False
                    End If
                End If

                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                'Grabamos la Cabecera
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB", .AC_IDSUBDIARIO.SD_ID, _
                                              .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                              .AC_IDMONEDA.MO_CODIGO, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                              .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                              .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                              .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID)
                End With

                'Grabamos las Compras 
                With Ent_Compras

                    Dim Int_TAnex As Integer = 0
                    Dim Int_CAnex As Integer = 0
                    Dim Str_TDoc As String = String.Empty
                    Dim Str_TDocRef As String = String.Empty

                    If Not .CO_TIPO_ANEXO Is Nothing Then Int_TAnex = .CO_TIPO_ANEXO.TA_CODIGO
                    If Not .CO_ANEXO_ID Is Nothing Then Int_CAnex = .CO_ANEXO_ID.AN_IDANEXO
                    If Not .CO_TIP_DOC Is Nothing Then Str_TDoc = .CO_TIP_DOC.DO_CODIGO
                    If Not .CO_TIP_DOC_REF Is Nothing Then Str_TDocRef = .CO_TIP_DOC_REF.DO_CODIGO

                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_COMPRAS", Ent_Cab.AC_ID, _
                                              IIf(Int_TAnex = 0, DBNull.Value, Int_TAnex), _
                                              IIf(Int_CAnex = 0, DBNull.Value, Int_CAnex), _
                                              IIf(Str_TDoc.Equals(String.Empty), DBNull.Value, Str_TDoc), _
                                              .CO_SER_DOC, _
                                              .CO_NUM_DOC, .CO_INDICADOR_DESTINO, _
                                              IIf(.CO_FEC_EMI.Equals(String.Empty), DBNull.Value, .CO_FEC_EMI), _
                                              IIf(.CO_FEC_VEN.Equals(String.Empty), DBNull.Value, .CO_FEC_VEN), _
                                              IIf(.CO_FEC_VOU.Equals(String.Empty), DBNull.Value, .CO_FEC_VOU), _
                                              IIf(Str_TDocRef.Equals(String.Empty), DBNull.Value, Str_TDocRef), _
                                              .CO_SER_DOC_REF, .CO_NUM_DOC_REF, _
                                              IIf(.CO_FEC_EMI_REF.Equals(String.Empty), DBNull.Value, .CO_FEC_EMI_REF), _
                                              .CO_TASA_IGV, _
                                              .CO_MONTO_IGV, .CO_MONTO_EXONERADO, _
                                              .CO_TASA_ISC, .CO_MONTO_ISC, _
                                              .CO_OTROS_TRIBUTOS, .CO_IMPORTE_COMPRA, _
                                              .CO_IMPORTE_VENTA, .CO_ES_AFECTO_DETRA, _
                                              .CO_TASA_DETRA, .CO_IMPORTE_DETRA, _
                                              .CO_VALOR_RAZ_DETRA, .CO_NUMERO_DETRA, _
                                              IIf(.CO_FEC_EMI_DETRA.Equals(String.Empty), DBNull.Value, .CO_FEC_EMI_DETRA), _
                                              .CO_TIPO_SERV_DETRA, _
                                              .CO_SERV_DETRA, .CO_ES_AFECTO_PERCEP, _
                                              .CO_TASA_PERCEP, .CO_ISTATUS, _
                                              .CO_IMPORTE_PAGAR, .CO_TASA_4TA, _
                                              .CO_TOTAL_HONO, .CO_MONTO_RET, _
                                              .CO_MONTO_PERCI)
                End With

                For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In Ent_Detalles
                    With detalle
                        Dim Int_TipAnexo As Integer = 0
                        Dim Int_CodAnexo As Integer = 0
                        Dim Str_TipDoc As String = String.Empty
                        Dim Int_CodCC As Integer = 0

                        If Not .AD_TANEXO Is Nothing Then Int_TipAnexo = .AD_TANEXO.TA_CODIGO
                        If Not .AD_IDANEXO Is Nothing Then Int_CodAnexo = .AD_IDANEXO.AN_IDANEXO
                        If Not .AD_TDOC Is Nothing Then Str_TipDoc = .AD_TDOC.DO_CODIGO
                        If Not .AD_IDCC Is Nothing Then Int_CodCC = .AD_IDCC.CC_CODIGO

                        'Este debe guardar por cada vuelta
                        'hasta que se acabe la coleccion
                        'revisar el Nothing de cada campo que es tipo Clase.

                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET", Ent_Cab.AC_ID, _
                                                  .AD_SECUENCIA, .AD_CUENTA, _
                                                    IIf(Int_TipAnexo = 0, DBNull.Value, Int_TipAnexo), _
                                                    IIf(Int_CodAnexo = 0, DBNull.Value, Int_CodAnexo), _
                                                    IIf(Str_TipDoc.Equals(String.Empty), DBNull.Value, Str_TipDoc), _
                                                    .AD_SDOC, _
                                                    .AD_NDOC, _
                                                    IIf(.AD_FDOC.Equals(String.Empty), DBNull.Value, .AD_FDOC), _
                                                    IIf(.AD_VDOC.Equals(String.Empty), DBNull.Value, .AD_VDOC), _
                                                    .AD_DEBE, .AD_HABER, .AD_TCAM, .AD_SEC_ORI_DESTINO, _
                                                    .AD_GLOSA, _
                                                    IIf(Int_CodCC = 0, DBNull.Value, Int_CodCC), _
                                                    .AD_ES_DESTINO, .AD_USUARIO, _
                                                    .AD_TERMINAL, .AD_FECREG, .AD_MONTO_ORI, .AD_PORCE_DESTINO, .AD_ES_INAFECTO)
                    End With
                Next

                If Not Bol_Edit Then

                    If Bol_Actualizar_Numero Then
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_U_ACT_NUMVOUCHER", _
                                                        Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                                 Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                                  Ent_Cab.AC_NUM_VOUCHER, _
                                                                 Ent_Cab.AC_IDEMPRESA.EM_ID)
                    End If
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Insert_Ventas(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, _
                          ByVal Ent_Ventas As BE.ContabilidadBE.SG_CO_TB_VENTAS, _
                        ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), _
                        ByRef Str_NumVoucher As String, _
                        ByVal Bol_Edit As Boolean)


            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                If Bol_Edit Then
                    'como esta en cascada la relacion al eliminar la cabecera eliminara tambien en :
                    'Detalle,Reg. de Compras, reg. de Ventas y saldo por anexo
                    Ent_Cab.AC_ES_INTERFACE = SqlHelper.ExecuteScalar(TRvar, CommandType.Text, "SELECT isnull(AC_ES_INTERFACE,0) FROM SG_CO_TB_ASIENTO_CAB WHERE AC_ID = " & Ent_Cab.AC_ID)
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_D_ASIENTO_CAB", Ent_Cab.AC_ID)
                Else
                    Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", _
                                                             Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                End If

                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                'Grabamos la Cabecera
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB", .AC_IDSUBDIARIO.SD_ID, _
                                              .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                              .AC_IDMONEDA.MO_CODIGO, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                              .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                              .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                              .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID)
                End With

                'Grabamos la Venta para el Reg. de Ventas
                With Ent_Ventas

                    Dim Int_tip_Anex As Integer = 0
                    Dim Int_cod_Anex As Integer = 0
                    Dim Str_cod_Doc As String = String.Empty
                    Dim Str_cod_Doc_Ref As String = String.Empty

                    If Not .VE_TIPO_ANEXO Is Nothing Then Int_tip_Anex = .VE_TIPO_ANEXO.TA_CODIGO
                    If Not .VE_ANEXO_ID Is Nothing Then Int_cod_Anex = .VE_ANEXO_ID.AN_IDANEXO
                    If Not .VE_TIP_DOC Is Nothing Then Str_cod_Doc = .VE_TIP_DOC.DO_CODIGO
                    If Not .VE_TIP_DOC_REF Is Nothing Then Str_cod_Doc_Ref = .VE_TIP_DOC_REF.DO_CODIGO


                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_VENTAS", Ent_Cab.AC_ID, _
                                              IIf(Int_tip_Anex = 0, DBNull.Value, Int_tip_Anex), _
                                              IIf(Int_cod_Anex = 0, DBNull.Value, Int_cod_Anex), _
                                              IIf(Str_cod_Doc.Equals(String.Empty), DBNull.Value, Str_cod_Doc), _
                                              .VE_SER_DOC, .VE_NUM_DOC, .VE_INDICADOR_DESTINO, _
                                              IIf(.VE_FEC_EMI.Equals(String.Empty), DBNull.Value, .VE_FEC_EMI), _
                                              IIf(.VE_FEC_VEN.Equals(String.Empty), DBNull.Value, .VE_FEC_VEN), _
                                              IIf(.VE_FEC_VOU.Equals(String.Empty), DBNull.Value, .VE_FEC_VOU), _
                                              IIf(Str_cod_Doc_Ref.Equals(String.Empty), DBNull.Value, Str_cod_Doc_Ref), _
                                              .VE_SER_DOC_REF, _
                                              .VE_NUM_DOC_REF, _
                                             IIf(.VE_FEC_EMI_REF.Equals(String.Empty), DBNull.Value, .VE_FEC_EMI_REF), _
                                              .VE_TASA_IGV, .VE_MONTO_IGV, .VE_MONTO_EXONERADO, _
                                              .VE_TASA_ISC, .VE_MONTO_ISC, .VE_OTROS_TRIBUTOS, .VE_VALOR_INAFECTO, .VE_DESCUENTO, _
                                              .VE_VALOR_VENTA, .VE_VALOR_BRUTO, .VE_PRECIO_VENTA, .VE_ISTATUS, .VE_IDSUBOPE.SO_CODIGO)
                End With

                For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In Ent_Detalles
                    With detalle

                        Dim Int_tip_Anex2 As Integer = 0
                        Dim Int_cod_Anex2 As Integer = 0
                        Dim Int_cod_cc As Integer = 0
                        Dim Str_cod_Doc2 As String = String.Empty


                        If Not .AD_TANEXO Is Nothing Then Int_tip_Anex2 = .AD_TANEXO.TA_CODIGO
                        If Not .AD_IDANEXO Is Nothing Then Int_cod_Anex2 = .AD_IDANEXO.AN_IDANEXO
                        If Not .AD_TDOC Is Nothing Then Str_cod_Doc2 = .AD_TDOC.DO_CODIGO
                        If Not .AD_IDCC Is Nothing Then Int_cod_cc = .AD_IDCC.CC_CODIGO


                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET", Ent_Cab.AC_ID, _
                                                  .AD_SECUENCIA, .AD_CUENTA, _
                                                    IIf(Int_tip_Anex2 = 0, DBNull.Value, Int_tip_Anex2), _
                                                    IIf(Int_cod_Anex2 = 0, DBNull.Value, Int_cod_Anex2), _
                                                    IIf(Str_cod_Doc2.Equals(String.Empty), DBNull.Value, Str_cod_Doc2), _
                                                    .AD_SDOC, .AD_NDOC, _
                                                    IIf(.AD_FDOC.Equals(String.Empty), DBNull.Value, .AD_FDOC), _
                                                    IIf(.AD_VDOC.Equals(String.Empty), DBNull.Value, .AD_VDOC), _
                                                    .AD_DEBE, .AD_HABER, .AD_TCAM, .AD_SEC_ORI_DESTINO, _
                                                    .AD_GLOSA, _
                                                    IIf(Int_cod_cc = 0, DBNull.Value, Int_cod_cc), _
                                                    .AD_ES_DESTINO, .AD_USUARIO, _
                                                    .AD_TERMINAL, .AD_FECREG, .AD_MONTO_ORI, .AD_PORCE_DESTINO, .AD_ES_INAFECTO)
                    End With
                Next

                If Not Bol_Edit Then
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_U_ACT_NUMVOUCHER", _
                                                    Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_NUM_VOUCHER, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Insert_Honorarios(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, _
                                     ByVal Ent_Compras As BE.ContabilidadBE.SG_CO_TB_COMPRAS, _
                            ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), _
                            ByRef Str_NumVoucher As String, _
                            ByVal Bol_Edit As Boolean)

            Dim Bol_Actualizar_Numero As Boolean = True
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                If Bol_Edit Then
                    'como esta en cascada la relacion al eliminar la cabecera eliminara tambien en :
                    Ent_Cab.AC_ES_INTERFACE = SqlHelper.ExecuteScalar(TRvar, CommandType.Text, "SELECT isnull(AC_ES_INTERFACE,0) FROM SG_CO_TB_ASIENTO_CAB WHERE AC_ID = " & Ent_Cab.AC_ID)
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_D_ASIENTO_CAB", Ent_Cab.AC_ID)
                Else
                    If Ent_Cab.AC_NUM_VOUCHER.Trim.Length = 0 Then
                        Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", _
                                                             Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                    Else
                        Bol_Actualizar_Numero = False
                        Str_NumVoucher = Ent_Cab.AC_NUM_VOUCHER
                    End If
                End If

                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                'Grabamos la Cabecera
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB", .AC_IDSUBDIARIO.SD_ID, _
                                                                  .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                                                  .AC_IDMONEDA.MO_CODIGO, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                                                  .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                                                  .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                                                  .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID)
                End With



                'Grabamos las Compras 
                With Ent_Compras

                    Dim Int_TAnex As Integer = 0
                    Dim Int_CAnex As Integer = 0
                    Dim Str_TDoc As String = String.Empty
                    Dim Str_TDocRef As String = String.Empty

                    If Not .CO_TIPO_ANEXO Is Nothing Then Int_TAnex = .CO_TIPO_ANEXO.TA_CODIGO
                    If Not .CO_ANEXO_ID Is Nothing Then Int_CAnex = .CO_ANEXO_ID.AN_IDANEXO
                    If Not .CO_TIP_DOC Is Nothing Then Str_TDoc = .CO_TIP_DOC.DO_CODIGO
                    If Not .CO_TIP_DOC_REF Is Nothing Then Str_TDocRef = .CO_TIP_DOC_REF.DO_CODIGO

                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_COMPRAS", Ent_Cab.AC_ID, _
                                              IIf(Int_TAnex = 0, DBNull.Value, Int_TAnex), _
                                              IIf(Int_CAnex = 0, DBNull.Value, Int_CAnex), _
                                              IIf(Str_TDoc.Equals(String.Empty), DBNull.Value, Str_TDoc), _
                                              .CO_SER_DOC, _
                                              .CO_NUM_DOC, .CO_INDICADOR_DESTINO, _
                                              IIf(.CO_FEC_EMI.Equals(String.Empty), DBNull.Value, .CO_FEC_EMI), _
                                              IIf(.CO_FEC_VEN.Equals(String.Empty), DBNull.Value, .CO_FEC_VEN), _
                                              IIf(.CO_FEC_VOU.Equals(String.Empty), DBNull.Value, .CO_FEC_VOU), _
                                              IIf(Str_TDocRef.Equals(String.Empty), DBNull.Value, Str_TDocRef), _
                                              .CO_SER_DOC_REF, .CO_NUM_DOC_REF, _
                                              IIf(.CO_FEC_EMI_REF.Equals(String.Empty), DBNull.Value, .CO_FEC_EMI_REF), _
                                              .CO_TASA_IGV, _
                                              .CO_MONTO_IGV, .CO_MONTO_EXONERADO, _
                                              .CO_TASA_ISC, .CO_MONTO_ISC, _
                                              .CO_OTROS_TRIBUTOS, .CO_IMPORTE_COMPRA, _
                                              .CO_IMPORTE_VENTA, .CO_ES_AFECTO_DETRA, _
                                              .CO_TASA_DETRA, .CO_IMPORTE_DETRA, _
                                              .CO_VALOR_RAZ_DETRA, .CO_NUMERO_DETRA, _
                                              IIf(.CO_FEC_EMI_DETRA.Equals(String.Empty), DBNull.Value, .CO_FEC_EMI_DETRA), _
                                              .CO_TIPO_SERV_DETRA, _
                                              .CO_SERV_DETRA, .CO_ES_AFECTO_PERCEP, _
                                              .CO_TASA_PERCEP, .CO_ISTATUS, _
                                              .CO_IMPORTE_PAGAR, .CO_TASA_4TA, _
                                              .CO_TOTAL_HONO, .CO_MONTO_RET, _
                                              .CO_MONTO_PERCI)
                End With



                'este procedimiento debe grabar em detalle
                For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In Ent_Detalles
                    With detalle

                        Dim Int_TipAnexo As Integer = 0
                        Dim Int_CodAnexo As Integer = 0
                        Dim Str_TipDoc As String = String.Empty
                        Dim Int_CodCC As Integer = 0

                        If .AD_TANEXO Is Nothing Then
                            Int_TipAnexo = 0
                        Else
                            Int_TipAnexo = .AD_TANEXO.TA_CODIGO
                        End If

                        If .AD_TDOC Is Nothing Then
                            Int_CodAnexo = 0
                        Else
                            Int_CodAnexo = .AD_IDANEXO.AN_IDANEXO
                        End If

                        If .AD_TDOC Is Nothing Then
                            Str_TipDoc = 0
                        Else
                            Str_TipDoc = .AD_TDOC.DO_CODIGO
                        End If

                        If .AD_IDCC Is Nothing Then
                            Int_CodCC = 0
                        Else
                            Int_CodCC = .AD_IDCC.CC_CODIGO
                        End If

                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET", Ent_Cab.AC_ID, _
                                                  .AD_SECUENCIA, .AD_CUENTA, _
                                                    IIf(Int_TipAnexo = 0, DBNull.Value, Int_TipAnexo), _
                                                    IIf(Int_CodAnexo = 0, DBNull.Value, Int_CodAnexo), _
                                                    IIf(Str_TipDoc = 0, DBNull.Value, Str_TipDoc), _
                                                    .AD_SDOC, _
                                                    .AD_NDOC, _
                                                    IIf(.AD_FDOC.Equals(String.Empty), DBNull.Value, .AD_FDOC), _
                                                    IIf(.AD_VDOC.Equals(String.Empty), DBNull.Value, .AD_VDOC), _
                                                    .AD_DEBE, _
                                                    .AD_HABER, .AD_TCAM, .AD_SEC_ORI_DESTINO, _
                                                    .AD_GLOSA, _
                                                    IIf(Int_CodCC = 0, DBNull.Value, Int_CodCC), _
                                                    .AD_ES_DESTINO, .AD_USUARIO, _
                                                    .AD_TERMINAL, .AD_FECREG, .AD_MONTO_ORI, .AD_PORCE_DESTINO, .AD_ES_INAFECTO)
                    End With
                Next
                ' 
                '
                If Not Bol_Edit Then
                    If Bol_Actualizar_Numero Then
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_U_ACT_NUMVOUCHER", _
                                                        Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                                 Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                                 Ent_Cab.AC_NUM_VOUCHER, _
                                                                 Ent_Cab.AC_IDEMPRESA.EM_ID)
                    End If
                End If

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Insert_Bancos(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, _
                                    ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), _
                                    ByRef Str_NumVoucher As String, _
                                    ByVal Bol_Edit As Boolean)


            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                If Bol_Edit Then
                    'como esta en cascada la relacion al eliminar la cabecera eliminara tambien en :
                    'Detalle,Reg. de Compras, reg. de Ventas y saldo por anexo
                    Ent_Cab.AC_ES_INTERFACE = SqlHelper.ExecuteScalar(TRvar, CommandType.Text, "SELECT isnull(AC_ES_INTERFACE,0) FROM SG_CO_TB_ASIENTO_CAB WHERE AC_ID = " & Ent_Cab.AC_ID)
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_D_ASIENTO_CAB", Ent_Cab.AC_ID)
                Else
                    Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", _
                                                             Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                End If

                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                'Grabamos la Cabecera
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB", .AC_IDSUBDIARIO.SD_ID, _
                                                                  .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                                                  .AC_IDMONEDA.MO_CODIGO, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                                                  .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                                                  .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                                                  .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID)
                End With

                'este procedimiento debe grabar em detalle
                For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In Ent_Detalles
                    With detalle

                        Dim Int_TipAnexo As Integer = 0
                        Dim Int_CodAnexo As Integer = 0
                        Dim Str_TipDoc As String = String.Empty
                        Dim Int_CodCC As Integer = 0
                        Dim Str_CodMP As String = String.Empty

                        If Not .AD_TANEXO Is Nothing Then Int_TipAnexo = .AD_TANEXO.TA_CODIGO
                        If Not .AD_IDANEXO Is Nothing Then Int_CodAnexo = .AD_IDANEXO.AN_IDANEXO
                        If Not .AD_TDOC Is Nothing Then Str_TipDoc = .AD_TDOC.DO_CODIGO
                        If Not .AD_IDCC Is Nothing Then Int_CodCC = .AD_IDCC.CC_CODIGO
                        If Not .AD_IDMEDIOPAGO Is Nothing Then Str_CodMP = .AD_IDMEDIOPAGO.MP_CODIGO


                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_CAJABANCOS", Ent_Cab.AC_ID, _
                                                    .AD_SECUENCIA, .AD_CUENTA, _
                                                    IIf(Int_TipAnexo = 0, DBNull.Value, Int_TipAnexo), _
                                                    IIf(Int_CodAnexo = 0, DBNull.Value, Int_CodAnexo), _
                                                    IIf(Str_TipDoc.Equals(String.Empty), DBNull.Value, Str_TipDoc), _
                                                    .AD_SDOC, _
                                                    .AD_NDOC, _
                                                    IIf(.AD_FDOC.Equals(String.Empty), DBNull.Value, .AD_FDOC), _
                                                    IIf(.AD_VDOC.Equals(String.Empty), DBNull.Value, .AD_VDOC), _
                                                    .AD_DEBE, _
                                                    .AD_HABER, .AD_TCAM, .AD_SEC_ORI_DESTINO, _
                                                    .AD_GLOSA, _
                                                    IIf(Int_CodCC = 0, DBNull.Value, Int_CodCC), _
                                                    .AD_ES_DESTINO, .AD_USUARIO, _
                                                    .AD_TERMINAL, .AD_FECREG, _
                                                    IIf(Str_CodMP.Equals(String.Empty), DBNull.Value, Str_CodMP), _
                                                    .AD_MONTO_ORI, .AD_PORCE_DESTINO)


                    End With
                Next


                If Not Bol_Edit Then
                    SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_U_ACT_NUMVOUCHER", _
                                                    Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                             Ent_Cab.AC_IDSUBDIARIO.SD_ID, _
                                                             Ent_Cab.AC_NUM_VOUCHER, _
                                                             Ent_Cab.AC_IDEMPRESA.EM_ID)
                End If

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Generar_Asiento_ITF_Mensual(ByVal empresa As Integer, ByVal ayo As Integer, ByVal mes As Integer, ByVal importe_itf As Double, ByVal fechaVou As Date, ByVal Str_Usuario_Sis As String, ByVal Int_cuentaContable As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                Dim Str_Codigo_Impuesto_ITF As String = "08" '_______________________________________________codigo en duro del ITF
                Dim Ent_Cab As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB


                '____________________________________________________________________________________________Traemos la cuenta por su id
                Dim CuentaBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                Dim CuentaBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                CuentaBE.PC_IDCUENTA = Int_cuentaContable
                CuentaBL.getCuenta(CuentaBE)

                '_____________________________________________________________________________________________Traemos el tipo de cambio
                Dim TCambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
                Dim TCambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
                TCambioBE.TC_FECHA = fechaVou
                TCambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
                TCambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa}
                TCambioBL.getTipoCambio(TCambioBE)


                '_____________________________________________________traemos la tasa del ITF para este mes
                Dim Str_NumVoucher As String
                Dim Str_Glosa_Referencia As String = "Asiento por ITF - Mensual del periodo : " & String.Format("{0}/{1}", ayo, mes) & " Fecha:" & fechaVou.ToShortDateString
                'Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENO_DET
                Dim Dbl_Tasa_ITF As Double = 0
                Dim ImpuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
                Dim ImpuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

                ImpuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa}
                ImpuestoBE.IM_CODIGO = Str_Codigo_Impuesto_ITF
                ImpuestoBE.IM_PERIODO = ayo
                ImpuestoBE.IM_MES = mes
                ImpuestoBL.getImpuestos_x_Codigo_interno(ImpuestoBE)
                Dbl_Tasa_ITF = ImpuestoBE.IM_TASA
                ImpuestoBL = Nothing
                ImpuestoBE = Nothing

                If Val(Dbl_Tasa_ITF) = 0 Then Exit Sub

                '_________________________________________________________________trameos los paramtros del ITF(subdiario)
                Dim Emp_Itf_BL As New BL.ContabilidadBL.SG_CO_TB_EMP_ITF
                Dim Emp_Itf_BE As New BE.ContabilidadBE.SG_CO_TB_EMP_ITF With {.EI_IDEMP = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa}}
                Emp_Itf_BL.getControl_ITF_x_Empresa(Emp_Itf_BE)

                With Ent_Cab
                    .AC_ID = 0
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = Emp_Itf_BE.EI_IDSUBDIARIO.SD_ID}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = ayo
                    .AC_MES = mes
                    .AC_FEC_VOUCHER = fechaVou.ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = IIf(CuentaBE.PC_IDMONEDA.MO_CODIGO = 1, importe_itf, importe_itf * TCambioBE.TC_VENTA)
                    .AC_HABER = IIf(CuentaBE.PC_IDMONEDA.MO_CODIGO = 1, importe_itf, importe_itf * TCambioBE.TC_VENTA)
                    .AC_TC_OPE = TCambioBE.TC_VENTA
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Str_Glosa_Referencia
                    .AC_ES_INTERFACE = 0
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, Str_Usuario_Sis)
                    .AC_TERMINAL = Environment.MachineName
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa}
                End With


                '_____________________________________________________________________________________________________________obtenemos el numero de voucher correlativo
                Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                           Emp_Itf_BE.EI_IDSUBDIARIO.SD_ID, Ent_Cab.AC_IDEMPRESA.EM_ID)

                Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher



                '_____________________________________________________________________________________________________________Grabamos la Cabecera 
                With Ent_Cab
                    Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB_ITF", Emp_Itf_BE.EI_IDSUBDIARIO.SD_ID, _
                                                                  .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                                                  1, .AC_DEBE, .AC_HABER, .AC_TC_OPE, _
                                                                  .AC_TC_ESPECIAL, .AC_ESTADO, .AC_GLOSA_VOU, _
                                                                  .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                                                  .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID, 1)
                End With


                '_______________________________________________________________________________________________________________Grabamos el detalle
                Dim Dbl_Imp_Itf_soles As Double = IIf(CuentaBE.PC_IDMONEDA.MO_CODIGO = 1, importe_itf, importe_itf * TCambioBE.TC_VENTA)
                Dim Dbl_TCambio_det As Double = IIf(CuentaBE.PC_IDMONEDA.MO_CODIGO = 1, 0, TCambioBE.TC_VENTA)

                'la cta 64
                SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 1, Emp_Itf_BE.EI_CTA6, _
                                             DBNull.Value, DBNull.Value, DBNull.Value, _
                                            "", "", DBNull.Value, DBNull.Value, _
                                            Dbl_Imp_Itf_soles, 0, Dbl_TCambio_det, 0, Str_Glosa_Referencia, _
                                             DBNull.Value, 0, Ent_Cab.AC_USUARIO, _
                                            Ent_Cab.AC_TERMINAL, Ent_Cab.AC_FECREG, _
                                             DBNull.Value, importe_itf, 0)


                'la cuenta gasto 98
                SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 2, Emp_Itf_BE.EI_CTA9, _
                                             DBNull.Value, DBNull.Value, DBNull.Value, _
                                            "", "", DBNull.Value, DBNull.Value, _
                                            Dbl_Imp_Itf_soles, 0, Dbl_TCambio_det, 1, Str_Glosa_Referencia, _
                                             DBNull.Value, 1, Ent_Cab.AC_USUARIO, _
                                            Ent_Cab.AC_TERMINAL, Ent_Cab.AC_FECREG, _
                                             DBNull.Value, importe_itf, 100)

                'la cta 79
                SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 3, Emp_Itf_BE.EI_CTA7, _
                                             DBNull.Value, DBNull.Value, DBNull.Value, _
                                            "", "", DBNull.Value, DBNull.Value, _
                                            0, Dbl_Imp_Itf_soles, Dbl_TCambio_det, 1, Str_Glosa_Referencia, _
                                             DBNull.Value, 1, Ent_Cab.AC_USUARIO, _
                                            Ent_Cab.AC_TERMINAL, Ent_Cab.AC_FECREG, _
                                             DBNull.Value, importe_itf, 100)

                'la cuenta 104 
                SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 4, CuentaBE.PC_NUM_CUENTA, _
                                             DBNull.Value, DBNull.Value, DBNull.Value, _
                                            "", "", DBNull.Value, DBNull.Value, _
                                            0, Dbl_Imp_Itf_soles, Dbl_TCambio_det, 0, Str_Glosa_Referencia, _
                                             DBNull.Value, 0, Ent_Cab.AC_USUARIO, _
                                            Ent_Cab.AC_TERMINAL, Ent_Cab.AC_FECREG, _
                                             DBNull.Value, importe_itf, 0)


                CuentaBL = Nothing
                CuentaBE = Nothing

                TCambioBL = Nothing
                TCambioBE = Nothing

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Sub Generar_Asiento_ITF_x_Movimiento(ByRef Ent_Cab As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB, ByVal Ent_Detalles As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET), ByVal Emp_Itf_BE As BE.ContabilidadBE.SG_CO_TB_EMP_ITF)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                Dim Str_Codigo_Impuesto_ITF As String = "08" '_______________________________________________codigo en duro del ITF


                '_____________Procedemos a  crear el asiento

                Dim Str_NumVoucher As String
                Dim Str_Glosa_Referencia As String = "Asiento por ITF - Voucher :" & Ent_Cab.AC_NUM_VOUCHER & " Fecha:" & Ent_Cab.AC_FEC_VOUCHER
                Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                Dim Dbl_Tasa_ITF As Double = 0
                Dim ImpuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
                Dim ImpuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

                ImpuestoBE.IM_IDEMPRESA = Ent_Cab.AC_IDEMPRESA
                ImpuestoBE.IM_CODIGO = Str_Codigo_Impuesto_ITF
                ImpuestoBE.IM_PERIODO = Ent_Cab.AC_ANHO
                ImpuestoBE.IM_MES = Ent_Cab.AC_MES
                ImpuestoBL.getImpuestos_x_Codigo_interno(ImpuestoBE)
                Dbl_Tasa_ITF = ImpuestoBE.IM_TASA
                ImpuestoBL = Nothing
                ImpuestoBE = Nothing

                If Val(Dbl_Tasa_ITF) = 0 Then Exit Sub


                For Each detalle In Ent_Detalles

                    '____________________________________ Verificamossi es cuenta de bancos, entonces genera ITF

                    Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                    Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                    planctasBE.PC_IDEMPRESA = Ent_Cab.AC_IDEMPRESA
                    planctasBE.PC_PERIODO = CDate(Ent_Cab.AC_FEC_VOUCHER).Year
                    planctasBE.PC_NUM_CUENTA = detalle.AD_CUENTA.ToString
                    planctasBL.getCuenta_X_NumeroCta(planctasBE)

                    If planctasBE.PC_IDTIPO_MOV.TM_CODIGO = 2 And planctasBE.PC_IDTIPO_MOV_DET.TM_CODIGO = 3 Then




                        '___________________________________________________________________calculamos el ITF => Dbl_Tasa_ITF(0.005%)
                        Dim Dbl_Imp_ITF_Ori As Double = 0
                        Dim Dbl_Imp_ITF_Sol As Double = 0
                        Dim Dbl_Imp_Movimiento As Double = detalle.AD_MONTO_ORI

                        Dbl_Imp_ITF_Ori = ((Dbl_Tasa_ITF / 100) * Dbl_Imp_Movimiento)
                        Dbl_Imp_ITF_Sol = Dbl_Imp_ITF_Ori

                        If detalle.AD_TCAM > 0 Then Dbl_Imp_ITF_Sol = Dbl_Imp_ITF_Ori * detalle.AD_TCAM


                        Dbl_Imp_ITF_Ori = Math.Round(Dbl_Imp_ITF_Ori, 2)
                        Dbl_Imp_ITF_Sol = Math.Round(Dbl_Imp_ITF_Sol, 2)




                        '____________________________________________________________________ Comenzamos a grabar los datos

                        Str_NumVoucher = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_C_ULT_NUM_VOU", Ent_Cab.AC_ANHO, Ent_Cab.AC_MES, _
                                                            Emp_Itf_BE.EI_IDSUBDIARIO.SD_ID, Ent_Cab.AC_IDEMPRESA.EM_ID)

                        Ent_Cab.AC_NUM_VOUCHER = Str_NumVoucher

                        'Grabamos la Cabecera 
                        With Ent_Cab
                            Ent_Cab.AC_ID = SqlHelper.ExecuteScalar(TRvar, "SG_CO_SP_I_ASIENTO_CAB_ITF", Emp_Itf_BE.EI_IDSUBDIARIO.SD_ID, _
                                                                          .AC_NUM_VOUCHER, .AC_ANHO, .AC_MES, .AC_FEC_VOUCHER, _
                                                                          1, Dbl_Imp_ITF_Sol, Dbl_Imp_ITF_Sol, .AC_TC_OPE, _
                                                                          .AC_TC_ESPECIAL, .AC_ESTADO, Str_Glosa_Referencia, _
                                                                          .AC_ES_INTERFACE, .AC_TC_FORMATO.FT_CODIGO, .AC_USUARIO, _
                                                                          .AC_TERMINAL, .AC_FECREG, .AC_IDEMPRESA.EM_ID, 1)
                        End With


                        'la cta 64
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 1, Emp_Itf_BE.EI_CTA6, _
                                                     DBNull.Value, DBNull.Value, DBNull.Value, _
                                                    "", "", DBNull.Value, DBNull.Value, _
                                                    Dbl_Imp_ITF_Sol, 0, detalle.AD_TCAM, 0, Str_Glosa_Referencia, _
                                                     DBNull.Value, 0, detalle.AD_USUARIO, _
                                                    detalle.AD_TERMINAL, detalle.AD_FECREG, _
                                                     DBNull.Value, Dbl_Imp_ITF_Ori, 0)

                        'la cuenta gasto 98
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 2, Emp_Itf_BE.EI_CTA9, _
                                                     DBNull.Value, DBNull.Value, DBNull.Value, _
                                                    "", "", DBNull.Value, DBNull.Value, _
                                                    Dbl_Imp_ITF_Sol, 0, detalle.AD_TCAM, 1, Str_Glosa_Referencia, _
                                                     DBNull.Value, 1, detalle.AD_USUARIO, _
                                                    detalle.AD_TERMINAL, detalle.AD_FECREG, _
                                                     DBNull.Value, Dbl_Imp_ITF_Ori, 100)

                        'la cta 79
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 3, String.Format("{0}", Emp_Itf_BE.EI_CTA7), _
                                                     DBNull.Value, DBNull.Value, DBNull.Value, _
                                                    "", "", DBNull.Value, DBNull.Value, _
                                                    0, Dbl_Imp_ITF_Sol, detalle.AD_TCAM, 1, Str_Glosa_Referencia, _
                                                     DBNull.Value, 1, detalle.AD_USUARIO, _
                                                    detalle.AD_TERMINAL, detalle.AD_FECREG, _
                                                     DBNull.Value, Dbl_Imp_ITF_Ori, 100)

                        'la cuenta 104
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_CO_SP_I_ASIENTO_DET_ITF", Ent_Cab.AC_ID, 4, detalle.AD_CUENTA, _
                                                     DBNull.Value, DBNull.Value, DBNull.Value, _
                                                    "", "", DBNull.Value, DBNull.Value, _
                                                    0, Dbl_Imp_ITF_Sol, detalle.AD_TCAM, 0, Str_Glosa_Referencia, _
                                                     DBNull.Value, 0, detalle.AD_USUARIO, _
                                                    detalle.AD_TERMINAL, detalle.AD_FECREG, _
                                                     DBNull.Value, Dbl_Imp_ITF_Ori, 0)

                    End If

                    planctasBE = Nothing
                    planctasBL = Nothing

                Next


                TRvar.Commit()
                TRvar.Dispose()
            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try
        End Sub
        Public Function getMov_Bancos_Calcular_ITF(ByVal emp As Integer, ByVal anho As Integer, ByVal mes As Integer, ByVal cuenta As Integer) As DataTable
            getMov_Bancos_Calcular_ITF = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_TB_ITF_MENSUAL", emp, anho, mes, cuenta).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getVouchers(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getVouchers = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VOUCHER_EDIT", Entidad.AC_IDSUBDIARIO.SD_ID, Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getVouchers_Web(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getVouchers_Web = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_VOUCHER_EDIT", Entidad.AC_IDSUBDIARIO.SD_ID, Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getVouchers_Impresion_cheques(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getVouchers_Impresion_cheques = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VOUCHER_IMPRE_CHEQ", Entidad.AC_ANHO, Entidad.AC_MES, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getVouchers_x_Id(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataSet
            getVouchers_x_Id = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VOUCHER_BYID", Entidad.AC_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getW_Voucher_x_Id(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataSet
            getW_Voucher_x_Id = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_VOUCHER_BYID", Entidad.AC_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getVouchers_Ventas_x_Id(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataSet
            getVouchers_Ventas_x_Id = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VOUCHER_2_BYID", Entidad.AC_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getW_Vouchers_Ventas_x_Id(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataSet
            getW_Vouchers_Ventas_x_Id = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_W_VOUCHER2_BYID", Entidad.AC_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getVoucher_Impresion1(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB) As DataTable
            getVoucher_Impresion1 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_VOUCHER1", Entidad.AC_ID, CDate(Entidad.AC_FEC_VOUCHER).Year, Entidad.AC_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDoc_Pendientes(ByVal Str_Cuenta As String, ByVal Int_Anexo As Integer, ByVal Int_Empresa As Integer, ByVal ayo_ As Integer) As DataTable
            getDoc_Pendientes = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DOC_PENDIENTE", Str_Cuenta, Int_Anexo, Int_Empresa, ayo_).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDoc_Pendientes_x_Anexo(ByVal Int_Anexo As Integer, ByVal Int_Empresa As Integer) As DataTable
            getDoc_Pendientes_x_Anexo = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DOC_PENDIENTE_3", Int_Anexo, Int_Empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDoc_Pendientes2(ByVal Str_Cuenta As String, ByVal Int_Anexo As Integer, ByVal Int_Empresa As Integer, ByVal Dat_fecha_corte As Date) As DataTable
            getDoc_Pendientes2 = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DOC_PENDIENTE_2", Str_Cuenta, Int_Anexo, Dat_fecha_corte.ToShortDateString, Int_Empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDoc_Pendientes2_Relacionado(ByVal Str_Cuenta As String, ByVal Int_Anexo As Integer, ByVal Int_Empresa As Integer, ByVal Dat_fecha_corte As Date) As DataSet
            getDoc_Pendientes2_Relacionado = Nothing
            Try
                Dim Ds As DataSet = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DOC_PENDIENTE_2", Str_Cuenta, Int_Anexo, Dat_fecha_corte.ToShortDateString, Int_Empresa)

                Ds.Tables(0).TableName = "Cab"
                Ds.Tables(1).TableName = "Det"

                With Ds

                    Dim COL_a() As DataColumn
                    Dim COL_B() As DataColumn

                    COL_a = New DataColumn() {.Tables(0).Columns("DO_DESCRIPCION"), .Tables(0).Columns("AD_SDOC"), .Tables(0).Columns("AD_NDOC")}
                    COL_B = New DataColumn() {.Tables(1).Columns("DO_DESCRIPCION"), .Tables(1).Columns("AD_SDOC"), .Tables(1).Columns("AD_NDOC")}

                    .Relations.Add("Rel_Cab_Det", COL_a, COL_B, True)

                End With

                Return Ds

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDetalle_x_Id(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET) As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            getDetalle_x_Id = Nothing
            Try
                Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With Entidad
                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_TB_S_DET_ASIENTO_BYID", .AD_IDCAB.AC_ID, .AD_TDOC.DO_CODIGO, .AD_SDOC, .AD_NDOC, .AD_CUENTA, .AD_IDANEXO.AN_IDANEXO)

                    If dr.HasRows Then
                        dr.Read()
                        detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        detalle.AD_TCAM = dr("AD_TCAM")
                        detalle.AD_MONTO_ORI = dr("AD_MONTO_ORI")
                    End If

                    dr.Close() : dr = Nothing
                    Return detalle
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function get_Detalle_Compras_x_Id(ByVal ID_Cabecera As Integer) As BE.ContabilidadBE.SG_CO_TB_COMPRAS
            get_Detalle_Compras_x_Id = Nothing

            Dim comprasBE As BE.ContabilidadBE.SG_CO_TB_COMPRAS
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_TB_S_DET_COMPRAS_BYID", ID_Cabecera)
            If dr.HasRows Then
                dr.Read()
                comprasBE = New BE.ContabilidadBE.SG_CO_TB_COMPRAS
                With comprasBE
                    .CO_ES_AFECTO_DETRA = dr("CO_ES_AFECTO_DETRA")
                    .CO_TASA_DETRA = dr("CO_TASA_DETRA")
                    .CO_IMPORTE_DETRA = dr("CO_IMPORTE_DETRA")
                    .CO_VALOR_RAZ_DETRA = dr("CO_VALOR_RAZ_DETRA")
                    .CO_NUMERO_DETRA = dr("CO_NUMERO_DETRA").ToString
                    .CO_FEC_EMI_DETRA = dr("CO_FEC_EMI_DETRA").ToString
                    .CO_TIPO_SERV_DETRA = dr("CO_TIPO_SERV_DETRA").ToString
                    .CO_SERV_DETRA = dr("CO_SERV_DETRA").ToString
                End With

            End If

            dr.Close() : dr = Nothing

            Return comprasBE

        End Function
        Public Function getDetalle_x_Id_2(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET) As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            getDetalle_x_Id_2 = Nothing
            Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Try

                With Entidad
                    Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_TB_S_DET_ASIENTO_BYID_2", .AD_IDCAB.AC_ID, .AD_TDOC.DO_CODIGO, .AD_SDOC, .AD_NDOC, .AD_IDANEXO.AN_IDANEXO)

                    If dr.HasRows Then
                        dr.Read()
                        detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                        detalle.AD_TCAM = dr("AD_TCAM")
                        detalle.AD_MONTO_ORI = dr("AD_MONTO_ORI")
                        detalle.AD_CUENTA = dr("AD_CUENTA")
                    End If

                    dr.Close() : dr = Nothing

                End With
                Return detalle

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDatos_Cheque(ByVal Int_IdCab As Integer, ByVal Int_IdEmpresa As Integer) As Dictionary(Of String, Object)
            getDatos_Cheque = Nothing
            Dim lista As New Dictionary(Of String, Object)
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_DATOS_CHEQUE", Int_IdCab, Int_IdEmpresa)

            If dr.HasRows Then
                Do While dr.Read
                    lista.Add("fecha", dr("FECHA"))
                    lista.Add("importe", dr("IMPORTE"))
                    lista.Add("formato", dr("FORMATO"))
                    lista.Add("razon", dr("RAZON"))
                    lista.Add("num_cheque", dr("NUM_CHEQUE"))
                Loop
            End If

            dr.Close()
            dr = Nothing

            Return lista

        End Function
        Public Function getDatos_Cheque_Dt(ByVal Int_IdCab As Integer, ByVal Int_IdEmpresa As Integer) As DataTable
            getDatos_Cheque_Dt = Nothing

            Dim dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_DATOS_CHEQUE", Int_IdCab, Int_IdEmpresa).Tables(0)

            Return dt

        End Function
        Public Sub Actualizar_Estado_Impresion_Cheque(ByVal Int_Id_Asiento As Integer)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_ESTADO_CHEQUE", Int_Id_Asiento)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Existe_Num_Voucher(ByVal n As String, ByVal a As Integer, ByVal e As Integer) As Boolean
            Existe_Num_Voucher = False
            Dim query As String = "SELECT count(*) FROM SG_CO_TB_ASIENTO_CAB WHERE AC_IDEMPRESA = " & e.ToString & " AND AC_NUM_VOUCHER = '" & n & "' AND AC_ANHO = " & a.ToString
            If SqlHelper.ExecuteScalar(Cn, CommandType.Text, query) > 0 Then
                Existe_Num_Voucher = True
            End If
        End Function
        Public Function getBuscar_Doc(ByVal tipo As String, ByVal serie As String, ByVal numero As String, ByVal empresa As Integer, ByVal anexo As Integer, ByVal cuenta As String, ByVal ayo As Integer) As DataTable
            getBuscar_Doc = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BUSCA_DOC", tipo, serie, numero, empresa, anexo, cuenta, ayo).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function get_Documentos_con_Detraccion(ByVal Ayo As Integer, ByVal mes As Integer, ByVal empres As Integer) As DataTable
            get_Documentos_con_Detraccion = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ACT_DETRA", Ayo, mes, empres).Tables(0)
        End Function
        Public Sub Actualizar_Datos_Detraccion(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_COMPRAS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_DETRACCION", Entidad.CO_IDCAB.AC_ID, Entidad.CO_TASA_DETRA, _
                                      Entidad.CO_NUMERO_DETRA, _
                                      IIf(Entidad.CO_FEC_EMI_DETRA.ToString = "", DBNull.Value, Entidad.CO_FEC_EMI_DETRA))
        End Sub
        Public Function get_Base_igv_x_Docu(ByVal td As String, ByVal sd As String, ByVal nd As String, ByVal ayo As Integer, ByVal emp As Integer, ByVal compras As Boolean) As List(Of String)
            get_Base_igv_x_Docu = Nothing
            Dim milista As New List(Of String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_GET_BI_TOT", td, sd, nd, ayo, emp, IIf(compras, 1, 2))
            If drr.HasRows Then
                drr.Read()
                milista.Add(drr("FECHA"))
                milista.Add(drr("IGV"))
                milista.Add(drr("BASE"))
            End If

            drr.Close()
            drr = Nothing

            Return milista

        End Function
        Public Function get_Id_asiento(ByVal num_vou As String, ByVal empresa As Integer, ByVal fecha As String) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_ID_ASIENTO", num_vou, fecha, empresa)
        End Function

    End Class

    Public Class SG_CO_TB_EMPRESA
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            Try

                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_EMPRESAS", .EM_ID, .EM_NOMBRE, .EM_RUC, _
                                              .EM_DIR1, .EM_NUMTELF1, .EM_REPRESENTANTE, .EM_IMAGEN, _
                                              IIf(.EM_FEC_INS = String.Empty, DBNull.Value, .EM_FEC_INS), _
                                              IIf(.EM_IDPAIS = 0, DBNull.Value, .EM_IDPAIS), _
                                              IIf(.EM_IDDEPARTAMENTO = 0, DBNull.Value, .EM_IDDEPARTAMENTO), _
                                              .EM_DOCREPRE, IIf(.EM_IDCIUDAD = 0, DBNull.Value, .EM_IDCIUDAD), _
                                              .EM_DIR2, .EM_POST1, .EM_POST2, .EM_NUMTELF2, .EM_FAX1, .EM_FAX2, _
                                              .EM_MOVIL1, .EM_MOVIL2, .EM_EMAIL1, .EM_EMAIL2, .EM_WEB_SITE, _
                                              .EM_ES_AGENTE_RETENCION, .EM_ES_AGENTE_PER_VTA_INT, _
                                              .EM_ES_AGENTE_PER_COMBUS, .EM_USUARIO, .EM_TERMINAL, _
                                              .EM_FECREG, .EM_LOGO, .EM_CARGO_REPRE)
                End With


            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_EMPRESAS", .EM_ID, .EM_NOMBRE, .EM_RUC, _
                                              .EM_DIR1, .EM_NUMTELF1, .EM_REPRESENTANTE, .EM_IMAGEN, _
                                              IIf(.EM_FEC_INS = String.Empty, DBNull.Value, .EM_FEC_INS), _
                                              IIf(.EM_IDPAIS = 0, DBNull.Value, .EM_IDPAIS), _
                                              IIf(.EM_IDDEPARTAMENTO = 0, DBNull.Value, .EM_IDDEPARTAMENTO), _
                                              .EM_DOCREPRE, IIf(.EM_IDCIUDAD = 0, DBNull.Value, .EM_IDCIUDAD), _
                                              .EM_DIR2, .EM_POST1, .EM_POST2, .EM_NUMTELF2, .EM_FAX1, .EM_FAX2, _
                                              .EM_MOVIL1, .EM_MOVIL2, .EM_EMAIL1, .EM_EMAIL2, .EM_WEB_SITE, _
                                              .EM_ES_AGENTE_RETENCION, .EM_ES_AGENTE_PER_VTA_INT, _
                                              .EM_ES_AGENTE_PER_COMBUS, .EM_USUARIO, .EM_TERMINAL, _
                                              .EM_FECREG, .EM_LOGO, .EM_CARGO_REPRE)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getEmpresas_1() As List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            Try
                Dim empresas As New List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_EMPRESAS1")

                If dr.HasRows Then
                    Do While dr.Read
                        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA

                        empresaBE.EM_ID = dr("EM_ID")
                        empresaBE.EM_NOMBRE = dr("EM_NOMBRE")
                        empresaBE.EM_IMAGEN = dr("EM_IMAGEN")
                        empresaBE.EM_LOGO = IIf(dr("EM_LOGO") Is DBNull.Value, Nothing, dr("EM_LOGO"))


                        empresas.Add(empresaBE)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return empresas

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Sub getEmpresas_2(ByRef empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            Try

                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_EMPRESAS2", empresa.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        With empresa
                            .EM_NOMBRE = dr("EM_NOMBRE").ToString
                            .EM_IMAGEN = dr("EM_IMAGEN")
                            .EM_RUC = dr("EM_RUC").ToString
                            .EM_DIR1 = dr("EM_DIR1").ToString
                            .EM_NUMTELF1 = dr("EM_NUMTELF1").ToString
                            .EM_REPRESENTANTE = dr("EM_REPRESENTANTE").ToString
                            .EM_FEC_INS = dr("EM_FEC_INS").ToString
                            .EM_IDPAIS = dr("EM_IDPAIS").ToString
                            .EM_IDDEPARTAMENTO = dr("EM_IDDEPARTAMENTO").ToString
                            .EM_DOCREPRE = dr("EM_DOCREPRE").ToString
                            .EM_IDCIUDAD = dr("EM_IDCIUDAD").ToString
                            .EM_DIR2 = dr("EM_DIR2").ToString
                            .EM_POST1 = dr("EM_POST1").ToString
                            .EM_POST2 = dr("EM_POST2").ToString
                            .EM_NUMTELF2 = dr("EM_NUMTELF2").ToString
                            .EM_FAX1 = dr("EM_FAX1").ToString
                            .EM_FAX2 = dr("EM_FAX2").ToString
                            .EM_MOVIL1 = dr("EM_MOVIL1").ToString
                            .EM_MOVIL2 = dr("EM_MOVIL2").ToString
                            .EM_EMAIL1 = dr("EM_EMAIL1").ToString
                            .EM_EMAIL2 = dr("EM_EMAIL2").ToString
                            .EM_WEB_SITE = dr("EM_WEB_SITE").ToString
                            .EM_ES_AGENTE_RETENCION = dr("EM_ES_AGENTE_RETENCION")
                            .EM_ES_AGENTE_PER_VTA_INT = dr("EM_ES_AGENTE_PER_VTA_INT")
                            .EM_ES_AGENTE_PER_COMBUS = dr("EM_ES_AGENTE_PER_COMBUS")
                            .EM_LOGO = IIf(dr("EM_LOGO").ToString = String.Empty, Nothing, dr("EM_LOGO"))
                            .EM_CARGO_REPRE = dr("EM_CARGO_REPRE").ToString
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try

        End Sub


    End Class

    Public Class SG_CO_TB_LOG_SIS
        Inherits ClsBD

        Public Function Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_LOG_SIS) As Integer
            Try
                Dim id As Integer = 0
                With Entidad
                    id = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_LOG", .LS_USU_DOM, _
                                                                .LS_USU_SIS, .LS_TERMINAL, _
                                                                .LS_MODULO, .LS_FEC_ING)
                End With

                Return id
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_LOG_SIS)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_LOG", .LS_ID, .LS_FEC_SAL)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function getLogs() As DataTable
            getLogs = Nothing
            Try
                Dim Dt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_LOG").Tables(0)

                Return Dt

            Catch ex As Exception
                Throw ex
            End Try
        End Function


    End Class

    Public Class SG_CO_TB_ASIENTO_AUTO_CAB
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB)
            Try
                With Entidad
                    .AA_ID = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_ASIENTO_AUTO_C", .AA_IDSUBDIARIO.SD_ID, .AA_ANHO, .AA_IDEMPRESA.EM_ID, .AA_ISTATUS, .AA_USUARIO, .AA_TERMINAL, .AA_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_ASIENTO_AUTO_C", .AA_ID, .AA_IDSUBDIARIO, .AA_ANHO, .AA_IDEMPRESA, .AA_ISTATUS, .AA_USUARIO, .AA_TERMINAL, .AA_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_ASIENTO_AUTO_C", Entidad.AA_ID)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getAutoCab(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB) As DataTable
            getAutoCab = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_ASIENTO_AUTO_C", Entidad.AA_ANHO, Entidad.AA_IDEMPRESA.EM_ID).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_ASIENTO_AUTO_DET
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
            Try
                With Entidad
                    Dim valor As Integer = 0
                    If Not .AA_IDCUENTA_R Is Nothing Then valor = .AA_IDCUENTA_R.PC_IDCUENTA

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_ASIENTO_AUTO_D", .AA_IDCAB.AA_ID, _
                                              .AA_IDCUENTA.PC_IDCUENTA, .AA_IDCONPCETO.CR_ID, _
                                              .AA_DH, .AA_ISTATUS, .AA_USUARIO, .AA_TERMINAL, _
                                              .AA_FECREG, _
                                             IIf(valor = 0, DBNull.Value, valor), _
                                             .AA_IDMONEDA.MO_CODIGO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getDetalles(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB) As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
            getDetalles = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
                Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ASIENTO_AUTO_D", Entidad.AA_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET()
                        detalle.AA_IDCONPCETO = New BE.ContabilidadBE.SG_CO_TB_CONCEPTO_REGISTRO With {.CR_ID = dr("AA_IDCONPCETO")}
                        detalle.AA_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("AA_IDCUENTA")}

                        If Not dr("AA_IDCUENTA_R").ToString.Equals(String.Empty) Then
                            detalle.AA_IDCUENTA_R = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("AA_IDCUENTA_R")}
                        End If

                        detalle.AA_DH = dr("AA_DH")

                        detalle.AA_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = dr("AA_IDMONEDA")}
                        lista.Add(detalle)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getDetalles_x_Sudiario(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB, ByVal moneda As Integer) As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
            getDetalles_x_Sudiario = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
                Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ASIENTO_PLANTILLA", Entidad.AA_IDSUBDIARIO.SD_ID, Entidad.AA_IDEMPRESA.EM_ID, Entidad.AA_ANHO, moneda)

                If dr.HasRows Then
                    Do While dr.Read
                        detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET()
                        detalle.AA_IDCONPCETO = New BE.ContabilidadBE.SG_CO_TB_CONCEPTO_REGISTRO With {.CR_ID = dr("AA_IDCONPCETO")}
                        detalle.AA_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("AA_IDCUENTA"), .PC_NUM_CUENTA = dr("PC_NUM_CUENTA")}
                        detalle.AA_IDCUENTA_R = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = dr("AA_IDCUENTA_R"), .PC_NUM_CUENTA = dr("PC_NUM_CUENTA_R")}
                        detalle.AA_DH = dr("AA_DH")
                        lista.Add(detalle)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_DOCUMENTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_DOCUMENTOS", .DO_CODIGO, .DO_DESCRIPCION, .DO_ABREVIATURA, .DO_ES_RESTA, .DO_ISTATUS, .DO_CODIGO_SUNAT, .DO_PC_USUARIO, .DO_PC_TERMINAL, .DO_PC_FECREG, .DO_IDEMPRESA.EM_ID, .DO_COLOR_DOC)
                End With

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_DOCUMENTOS", .DO_CODIGO, .DO_DESCRIPCION, .DO_ABREVIATURA, .DO_ES_RESTA, .DO_ISTATUS, .DO_CODIGO_SUNAT, .DO_PC_USUARIO, .DO_PC_TERMINAL, .DO_PC_FECREG, .DO_IDEMPRESA.EM_ID, .DO_COLOR_DOC)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_DOCUMENTOS", .DO_CODIGO, .DO_IDEMPRESA)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getDocumentos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO) As List(Of BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            getDocumentos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
                Dim doc As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_DOCUMENTOS", Entidad.DO_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        doc = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO()
                        doc.DO_CODIGO = dr("DO_CODIGO")
                        doc.DO_DESCRIPCION = dr("DO_DESCRIPCION")
                        doc.DO_ABREVIATURA = dr("DO_ABREVIATURA")
                        doc.DO_ISTATUS = dr("DO_ISTATUS")
                        doc.DO_COLOR_DOC = dr("DO_COLOR_DOC").ToString
                        lista.Add(doc)
                    Loop
                End If

                dr.Close() : dr = Nothing
                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getDocumentos_x_Codigo(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_DOCUMENTOS_BYID", Entidad.DO_CODIGO, Entidad.DO_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        Entidad.DO_CODIGO = dr("DO_CODIGO")
                        Entidad.DO_DESCRIPCION = dr("DO_DESCRIPCION")
                        Entidad.DO_ABREVIATURA = dr("DO_ABREVIATURA")
                        Entidad.DO_ISTATUS = dr("DO_ISTATUS")
                        Entidad.DO_CODIGO_SUNAT = dr("DO_CODIGO_SUNAT")
                        Entidad.DO_ES_RESTA = dr("DO_ES_RESTA")
                        Entidad.DO_COLOR_DOC = dr("DO_COLOR_DOC").ToString
                    Loop
                End If

                dr.Close() : dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub getDocumentos_x_Descripcion(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_DOCUMENTOS_BY_DES", Entidad.DO_DESCRIPCION, Entidad.DO_IDEMPRESA.EM_ID)

                If dr.HasRows Then
                    Do While dr.Read
                        Entidad.DO_CODIGO = dr("DO_CODIGO")
                        Entidad.DO_DESCRIPCION = dr("DO_DESCRIPCION")
                        Entidad.DO_ABREVIATURA = dr("DO_ABREVIATURA")
                        Entidad.DO_ISTATUS = dr("DO_ISTATUS")
                        Entidad.DO_CODIGO_SUNAT = dr("DO_CODIGO_SUNAT")
                        Entidad.DO_ES_RESTA = dr("DO_ES_RESTA")
                        Entidad.DO_COLOR_DOC = dr("DO_COLOR_DOC").ToString
                    Loop
                End If

                dr.Close() : dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function Es_Nota_De_Credito(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO) As Boolean
            Es_Nota_De_Credito = False
            Try
                Dim resultado As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_DOC_X_NC", Entidad.DO_CODIGO, Entidad.DO_IDEMPRESA.EM_ID)
                If resultado = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function get_Docs_Facturacion(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCUMENTOS_01", empresa_).tables(0)
        End Function


    End Class

    Public Class SG_CO_TB_FORM_TIPCAMB
        Inherits ClsBD

        Public Function getFormatos() As List(Of BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB)
            getFormatos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_FORM_TIPCAMB")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB(dr("FT_CODIGO"), dr("FT_DESCRIPCION")))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception

            End Try
        End Function

    End Class

    Public Class SG_CO_TB_INDICADOR_DESTINO
        Inherits ClsBD

        Public Function getIndicadores() As List(Of BE.ContabilidadBE.SG_CO_TB_INDICADOR_DESTINO)
            getIndicadores = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_INDICADOR_DESTINO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_INDICADOR_DESTINO")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_INDICADOR_DESTINO(dr("ID_CODIGO"), dr("ID_DESCRIPCION")))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_IMPUESTO
        Inherits ClsBD

        Public Function getImpuestos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO) As List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            getImpuestos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
                Dim impuesto As BE.ContabilidadBE.SG_CO_TB_IMPUESTO = Nothing
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_IMPUESTO", Entidad.IM_IDEMPRESA.EM_ID)
                If dr.HasRows Then
                    Do While dr.Read
                        impuesto = New BE.ContabilidadBE.SG_CO_TB_IMPUESTO()
                        With impuesto
                            .IM_CODIGO = dr("IM_CODIGO")
                            .IM_DESCRIPCION = dr("IM_DESCRIPCION")
                            .IM_TASA = dr("IM_TASA")
                        End With
                        lista.Add(impuesto)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getImpuestos_x_Periodo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO) As List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            getImpuestos_x_Periodo = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
                Dim impuesto As BE.ContabilidadBE.SG_CO_TB_IMPUESTO = Nothing
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_IMPUESTO_PERIODO", Entidad.IM_PERIODO, Entidad.IM_MES, Entidad.IM_IDEMPRESA.EM_ID)
                If dr.HasRows Then
                    Do While dr.Read
                        impuesto = New BE.ContabilidadBE.SG_CO_TB_IMPUESTO()
                        With impuesto
                            .IM_CODIGO = dr("IM_CODIGO")
                            .IM_DESCRIPCION = dr("IM_DESCRIPCION")
                            .IM_TASA = dr("IM_TASA")
                        End With
                        lista.Add(impuesto)
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub getImpuestos_x_Codigo_interno(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                Dim impuesto As BE.ContabilidadBE.SG_CO_TB_IMPUESTO = Nothing
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_IMPUESTO_BYID", Entidad.IM_CODIGO, Entidad.IM_IDEMPRESA.EM_ID, Entidad.IM_PERIODO, Entidad.IM_MES)
                If dr.HasRows Then
                    dr.Read()
                    With Entidad
                        .IM_CODIGO = dr("IM_CODIGO")
                        .IM_CODIGO_SUNAT = New BE.ContabilidadBE.SG_CO_TB_IMPUESTO_SUNAT With {.IS_CODIGO = dr("IM_CODIGO_SUNAT")}
                        .IM_DESCRIPCION = dr("IM_DESCRIPCION")
                        .IM_ABREVIATURA = dr("IM_ABREVIATURA")
                        .IM_TASA = dr("IM_TASA")
                        .IM_CUENTA = dr("IM_CUENTA")
                        .IM_ISTATUS = dr("IM_ISTATUS")
                        .IM_PERIODO = dr("IM_PERIODO")
                        .IM_MES = dr("IM_MES")
                        .IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = dr("IM_IDTIPOIMPUESTO")}
                    End With
                End If

                dr.Close() : dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub getImpuestos_x_Codigo_1(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                Dim impuesto As BE.ContabilidadBE.SG_CO_TB_IMPUESTO = Nothing
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_IMPUESTO_BYID_1", Entidad.IM_CODIGO, Entidad.IM_IDEMPRESA.EM_ID, Entidad.IM_PERIODO, Entidad.IM_MES)
                If dr.HasRows Then
                    dr.Read()
                    With Entidad
                        .IM_CODIGO = dr("IM_CODIGO")
                        .IM_CODIGO_SUNAT = New BE.ContabilidadBE.SG_CO_TB_IMPUESTO_SUNAT With {.IS_CODIGO = dr("IM_CODIGO_SUNAT")}
                        .IM_DESCRIPCION = dr("IM_DESCRIPCION")
                        .IM_ABREVIATURA = dr("IM_ABREVIATURA")
                        .IM_TASA = dr("IM_TASA")
                        .IM_CUENTA = dr("IM_CUENTA")
                        .IM_ISTATUS = dr("IM_ISTATUS")
                        .IM_PERIODO = dr("IM_PERIODO")
                        .IM_MES = dr("IM_MES")
                        .IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = dr("IM_IDTIPOIMPUESTO")}
                    End With
                End If

                dr.Close() : dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub getImpuestos_x_Tipo(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                Dim impuesto As BE.ContabilidadBE.SG_CO_TB_IMPUESTO = Nothing
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_IMPUESTO_BY_TIPO", Entidad.IM_IDTIPOIMPUESTO.TI_CODIGO, Entidad.IM_IDEMPRESA.EM_ID, Entidad.IM_PERIODO, Entidad.IM_MES)
                If dr.HasRows Then
                    dr.Read()
                    With Entidad
                        .IM_CODIGO = dr("IM_CODIGO")
                        .IM_CODIGO_SUNAT = New BE.ContabilidadBE.SG_CO_TB_IMPUESTO_SUNAT With {.IS_CODIGO = dr("IM_CODIGO_SUNAT")}
                        .IM_DESCRIPCION = dr("IM_DESCRIPCION")
                        .IM_ABREVIATURA = dr("IM_ABREVIATURA")
                        .IM_TASA = dr("IM_TASA")
                        .IM_CUENTA = dr("IM_CUENTA")
                        .IM_ISTATUS = dr("IM_ISTATUS")
                        .IM_PERIODO = dr("IM_PERIODO")
                        .IM_MES = dr("IM_MES")
                        '.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = dr("IM_IDTIPOIMPUESTO")}
                    End With
                End If

                dr.Close() : dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_IMPUESTO", .IM_CODIGO, .IM_CODIGO_SUNAT.IS_CODIGO, .IM_DESCRIPCION, .IM_ABREVIATURA, _
                                              .IM_TASA, .IM_CUENTA, .IM_ISTATUS, .IM_PERIODO, .IM_MES, .IM_USUARIO, .IM_TERMINAL, .IM_FECREG, .IM_IDEMPRESA.EM_ID, .IM_IDTIPOIMPUESTO.TI_CODIGO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_IMPUESTO", .IM_CODIGO, .IM_CODIGO_SUNAT.IS_CODIGO, .IM_DESCRIPCION, .IM_ABREVIATURA, _
                                              .IM_TASA, .IM_CUENTA, .IM_ISTATUS, .IM_PERIODO, .IM_MES, .IM_USUARIO, .IM_TERMINAL, .IM_FECREG, .IM_IDEMPRESA.EM_ID, .IM_IDTIPOIMPUESTO.TI_CODIGO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_IMPUESTO", .IM_CODIGO, .IM_PERIODO, .IM_MES, .IM_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Copiar_Impuestos_x_Periodo(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_COPY_IMP_X_PERI", .IM_PERIODO, .IM_MES, .IM_IDEMPRESA.EM_ID, .IM_USUARIO, .IM_TERMINAL)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


    End Class

    Public Class SG_CO_TB_IMPUESTO_SUNAT
        Inherits ClsBD

        Public Function getImpuestos() As List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO_SUNAT)
            getImpuestos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO_SUNAT)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_IMPUESTO_SUNAT")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_IMPUESTO_SUNAT(dr("IS_CODIGO"), dr("IS_DESCRIPCION")))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_TIPO_IMPUESTO
        Inherits ClsBD

        Public Function getTipos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO)
            getTipos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_IMPUESTO")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO(dr("TI_CODIGO"), dr("TI_DESCRIPCION")))
                    Loop
                End If

                dr.Close() : dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class


#Region "Imagen de Fondo de Sistema"

    Public Class SG_CO_TB_IMG_SIS
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMG_SIS)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_IMG_SIS", Entidad.IS_USUARIO)
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_IMG_SIS", Entidad.IS_PC, Entidad.IS_IMG, Entidad.IS_USUARIO)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_IMG_SIS)
            Try
                SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_IMG_SIS", Entidad.IS_USUARIO, Entidad.IS_ESTILO_SKIN)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function Existe_usuario(ByVal IdUsuario As Integer) As Boolean
            Existe_usuario = False
            Try
                Dim i As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_EXIS_USU", IdUsuario)
                If i = 0 Then
                    Return False
                Else
                    Return True
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getImg_x_IdUsu(ByVal IdUsuario As Integer) As DataTable
            getImg_x_IdUsu = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_IMG_SIS_X_USU", IdUsuario).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getImg_x_Pc(ByVal Pc As String) As DataTable
            getImg_x_Pc = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_IMG_SIS_X_PC", Pc).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

#End Region

#Region "Mantenimiento de Bancos"

    Public Class SG_CO_TB_BANCO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_TB_BANCO", .BA_CODIGO, .BA_NOMBRE, .BA_RUC, .BA_DIRECCION, .BA_CODIGO_ZIP, .BA_WEBSITE, .BA_LIMITE_CREDITO, .BA_ES_PRINCIPAL, .BA_IDBANCO_PRIN, .BA_IDPAIS.PA_CODIGO, .BA_IDEMPRESA.EM_ID, .BA_ISTATUS, .BA_USUARIO, .BA_TERMINAL, .BA_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_TB_BANCO", .BA_ID, .BA_CODIGO, .BA_NOMBRE, .BA_RUC, .BA_DIRECCION, .BA_CODIGO_ZIP, .BA_WEBSITE, .BA_LIMITE_CREDITO, .BA_ES_PRINCIPAL, .BA_IDBANCO_PRIN, .BA_IDPAIS.PA_CODIGO, .BA_IDEMPRESA.EM_ID, .BA_ISTATUS, .BA_USUARIO, .BA_TERMINAL, .BA_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_TB_BANCO", .BA_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getBancos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO) As List(Of BE.ContabilidadBE.SG_CO_TB_BANCO)
            getBancos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO)
                Dim banco As BE.ContabilidadBE.SG_CO_TB_BANCO
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TB_BANCOS", Entidad.BA_IDEMPRESA.EM_ID)
                If dr.HasRows Then
                    Do While dr.Read
                        banco = New BE.ContabilidadBE.SG_CO_TB_BANCO()
                        With banco
                            .BA_ID = dr("BA_ID")
                            .BA_CODIGO = dr("BA_CODIGO")
                            .BA_NOMBRE = dr("BA_NOMBRE")
                            .BA_RUC = dr("BA_RUC")
                        End With
                        lista.Add(banco)
                    Loop
                End If

                dr.Close() : dr = Nothing
                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getBanco(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TB_BANCO_BYID", Entidad.BA_ID)
                If dr.HasRows Then
                    dr.Read()
                    With Entidad
                        .BA_ID = dr("BA_ID")
                        .BA_CODIGO = dr("BA_CODIGO")
                        .BA_NOMBRE = dr("BA_NOMBRE")
                        .BA_RUC = dr("BA_RUC")
                        .BA_DIRECCION = dr("BA_DIRECCION")
                        .BA_CODIGO_ZIP = dr("BA_CODIGO_ZIP")
                        .BA_WEBSITE = dr("BA_WEBSITE")
                        .BA_LIMITE_CREDITO = dr("BA_LIMITE_CREDITO")
                        .BA_ES_PRINCIPAL = dr("BA_ES_PRINCIPAL")
                        .BA_IDBANCO_PRIN = dr("BA_IDBANCO_PRIN")
                        .BA_IDPAIS = New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = dr("BA_IDPAIS")}
                        .BA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = dr("BA_IDEMPRESA")}
                        .BA_ISTATUS = dr("BA_ISTATUS")
                    End With
                End If

                dr.Close() : dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getMovimientos_de_Banco(ByVal ayo As Integer, ByVal mes As Integer, ByVal es_conci As Integer, ByVal cuenta As Integer, ByVal empresa As Integer) As DataTable
            getMovimientos_de_Banco = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_MOV_BANCOS", ayo, mes, es_conci, cuenta, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getMovimientos_de_Banco_ITF(ByVal ayo As Integer, ByVal mes As Integer, ByVal es_conci As Integer, ByVal cuenta As Integer, ByVal empresa As Integer) As DataTable
            getMovimientos_de_Banco_ITF = Nothing
            Try
                Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_MOV_BANCOS_ITF", ayo, mes, es_conci, cuenta, empresa).Tables(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub Update_Conciliacion(ByVal lista As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET))
            Try
                For Each movi As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In lista
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CONCILIACION", movi.AD_ES_CONCI, movi.AD_ANHO_CONI, movi.AD_MES_CONCI, movi.AD_IDDET)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update_Conciliacion_ITF(ByVal lista As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET))
            Try
                For Each movi As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET In lista
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CONCILIACION_ITF", movi.AD_ES_CONCI, movi.AD_ANHO_CONI, movi.AD_MES_CONCI, movi.AD_IDDET)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getSuma_Mov_Conciliados_x_Mes(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO)
            getSuma_Mov_Conciliados_x_Mes = Nothing
            Try
                Dim lista As New List(Of Double)
                Dim Dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_SUM_MES_CONCI", Entidad.SMB_ANHO, Entidad.SMB_MES, Entidad.SMB_CUENTA, Entidad.SMB_IDEMPRESA.EM_ID)

                If Dr.HasRows Then
                    Dr.Read()
                    lista.Add(Dr("SUM_D"))
                    lista.Add(Dr("SUM_H"))
                End If

                Dr.Close()
                Dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

    Public Class SG_CO_TB_MEDIOPAGO
        Inherits ClsBD

        Public Function getMedios() As List(Of BE.ContabilidadBE.SG_CO_TB_MEDIOPAGO)
            getMedios = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_MEDIOPAGO)
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_MEDIOPAGO")
                If dr.HasRows Then
                    Do While dr.Read
                        lista.Add(New BE.ContabilidadBE.SG_CO_TB_MEDIOPAGO(dr("MP_CODIGO"), dr("MP_DESCRIPCION")))
                    Loop
                End If
                dr.Close() : dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function




    End Class

    Public Class SG_CO_TB_BANCO_CTACTE
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
            Try
                'validar k no exista el mismo numero de cuenta
                Dim resultado As Integer = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_CANT_CTACTE", Entidad.BC_NUMERO_CTA.Trim)

                If resultado > 0 Then
                    Throw New Exception("El numero de la cuenta corriente ya existe.")
                End If

                Dim fApertura As String = String.Empty
                Dim fCierre As String = String.Empty

                With Entidad
                    If Not .BC_FECHA_APERTURA.Equals(String.Empty) Then fApertura = .BC_FECHA_APERTURA
                    If Not .BC_FECHA_CIERRE.Equals(String.Empty) Then fCierre = .BC_FECHA_CIERRE

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_BANCO_CTACTE", .BC_IDBANCO.BA_ID, .BC_NUMERO_CTA, .BC_DESCRIPCION, _
                                              .BC_IDCUENTA.PC_IDCUENTA, .BC_ULTIMO_CHEQUE, _
                                              IIf(fApertura.Equals(String.Empty), DBNull.Value, fApertura), _
                                              IIf(fCierre.Equals(String.Empty), DBNull.Value, fCierre), _
                                              .BC_ISTATUS, .BC_USUARIO, .BC_TERMINAL, .BC_FECREG, .BC_FORMATO_CHEQUE, .BC_PERIODO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
            Try
                Dim fApertura As String = String.Empty
                Dim fCierre As String = String.Empty

                With Entidad
                    If Not .BC_FECHA_APERTURA.Equals(String.Empty) Then fApertura = .BC_FECHA_APERTURA
                    If Not .BC_FECHA_CIERRE.Equals(String.Empty) Then fCierre = .BC_FECHA_CIERRE

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_BANCO_CTACTE", .BC_ID_CTA, .BC_NUMERO_CTA, .BC_DESCRIPCION, .BC_IDCUENTA.PC_IDCUENTA, _
                                              .BC_ULTIMO_CHEQUE, _
                                              IIf(fApertura.Equals(String.Empty), DBNull.Value, fApertura), _
                                              IIf(fCierre.Equals(String.Empty), DBNull.Value, fCierre), _
                                              .BC_ISTATUS, .BC_USUARIO, .BC_TERMINAL, .BC_FECREG, .BC_FORMATO_CHEQUE, .BC_PERIODO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_BANCO_CTACTE", .BC_ID_CTA)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getCtasCorrientes_dt(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_BANCO_CTACTES_2", Entidad.BC_IDBANCO.BA_ID).Tables(0)
        End Function

        Public Function getCtasCorrientes(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE) As List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
            getCtasCorrientes = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
                Dim cuenta As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE
                Dim Dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BANCO_CTACTES", Entidad.BC_IDBANCO.BA_ID)

                If Dr.HasRows Then
                    Do While Dr.Read
                        cuenta = New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE()
                        With cuenta
                            .BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Dr("BC_IDBANCO")}
                            .BC_ID_CTA = Dr("BC_ID_CTA")
                            .BC_NUMERO_CTA = Dr("BC_NUMERO_CTA").ToString
                            .BC_DESCRIPCION = Dr("BC_DESCRIPCION").ToString
                            .BC_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Dr("BC_IDCUENTA")}
                            .BC_ULTIMO_CHEQUE = Dr("BC_ULTIMO_CHEQUE").ToString
                            .BC_FECHA_APERTURA = Dr("BC_FECHA_APERTURA").ToString
                            .BC_FECHA_CIERRE = Dr("BC_FECHA_CIERRE").ToString
                            .BC_FORMATO_CHEQUE = Dr("BC_FORMATO_CHEQUE").ToString
                        End With
                        lista.Add(cuenta)
                    Loop
                End If

                Dr.Close() : Dr = Nothing

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getCtasCorriente(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
            Try
                With Entidad
                    Dim Dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BANCO_CTACTE_BYID", Entidad.BC_ID_CTA)
                    If Dr.HasRows Then
                        Dr.Read()
                        .BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Dr("BC_IDBANCO")}
                        .BC_ID_CTA = Dr("BC_ID_CTA")
                        .BC_NUMERO_CTA = Dr("BC_NUMERO_CTA")
                        .BC_DESCRIPCION = Dr("BC_DESCRIPCION")
                        .BC_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Dr("BC_IDCUENTA")}
                        .BC_ULTIMO_CHEQUE = Dr("BC_ULTIMO_CHEQUE").ToString
                        .BC_FECHA_APERTURA = Dr("BC_FECHA_APERTURA").ToString
                        .BC_FECHA_CIERRE = Dr("BC_FECHA_CIERRE").ToString
                        .BC_FORMATO_CHEQUE = Dr("BC_FORMATO_CHEQUE").ToString
                    End If
                    Dr.Close() : Dr = Nothing
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


    End Class

    Public Class SG_CO_TB_BANCO_TELEF
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_BANCO_TELEF", .BT_IDBANCO.BA_ID, .BT_IDCOMUNICACION.TC_ID, .BT_NUMERO, .BT_DESCRIPCION, .BT_ISTATUS, .BT_USUARIO, .BT_TERMINAL, .BT_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_BANCO_TELEF", .BT_IDBANCO.BA_ID, .BT_IDTEL, .BT_IDCOMUNICACION.TC_ID, .BT_NUMERO, .BT_DESCRIPCION, .BT_ISTATUS, .BT_USUARIO, .BT_TERMINAL, .BT_FECREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_BANCO_TELEF", .BT_IDTEL)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getTelefonos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF) As List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)
            getTelefonos = Nothing
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BANCO_TELEF", Entidad.BT_IDBANCO.BA_ID)
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)
                Dim telefono As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF

                If dr.HasRows Then
                    Do While dr.Read
                        telefono = New BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF()
                        With telefono
                            .BT_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = dr("BT_IDBANCO")}
                            .BT_IDTEL = dr("BT_IDTEL")
                            .BT_IDCOMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION With {.TC_ID = dr("BT_IDCOMUNICACION"), .TC_DESCRIPCION = dr("TC_DESCRIPCION")}
                            .BT_NUMERO = dr("BT_NUMERO")
                            .BT_DESCRIPCION = dr("BT_DESCRIPCION")
                            .BT_ISTATUS = dr("BT_ISTATUS")
                        End With
                        lista.Add(telefono)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getTelefonos_x_Id(ByRef Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BANCO_TELEF_BYID", Entidad.BT_IDTEL)

                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .BT_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO() With {.BA_ID = dr("BT_IDBANCO")}
                            .BT_IDTEL = dr("BT_IDTEL")
                            .BT_IDCOMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION() With {.TC_ID = dr("BT_IDCOMUNICACION")}
                            .BT_NUMERO = dr("BT_NUMERO")
                            .BT_DESCRIPCION = dr("BT_DESCRIPCION")
                            .BT_ISTATUS = dr("BT_ISTATUS")
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub




    End Class

    Public Class SG_CO_TB_TIPO_COMUNICACION
        Inherits ClsBD

        Public Function getTipos_DT() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_TIPO_COMUNICACION").Tables(0)
        End Function

        Public Function getTipos() As List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION)
            getTipos = Nothing
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_TIPO_COMUNICACION")
                Dim tipo As BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION)

                If dr.HasRows Then
                    Do While dr.Read
                        tipo = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION()
                        tipo.TC_ID = dr("TC_ID")
                        tipo.TC_DESCRIPCION = dr("TC_DESCRIPCION")
                        lista.Add(tipo)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function






    End Class

    Public Class SG_CO_TB_BANCO_CONTACTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_BANCO_CONTACTO", .BC_IDBANCO.BA_ID, .BC_NOMBRES, .BC_APELLIDOS, .BC_CARGO, .BC_USUARIO, .BC_TERMINAL, .BC_FECREG, .BC_EMAIL)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_BANCO_CONTACTO", .BC_IDCONTACTO, .BC_NOMBRES, .BC_APELLIDOS, .BC_CARGO, .BC_USUARIO, .BC_TERMINAL, .BC_FECREG, .BC_EMAIL)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_BANCO_CONTACTO", .BC_IDCONTACTO)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getContactos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO) As List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)
            getContactos = Nothing
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BANCO_CONTACTO", Entidad.BC_IDBANCO.BA_ID)
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)
                Dim contacto As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO

                If dr.HasRows Then
                    Do While dr.Read
                        contacto = New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO()
                        With contacto
                            .BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = dr("BC_IDBANCO")}
                            .BC_IDCONTACTO = dr("BC_IDCONTACTO")
                            .BC_NOMBRES = dr("BC_NOMBRES").ToString
                            .BC_APELLIDOS = dr("BC_APELLIDOS").ToString
                            .BC_CARGO = dr("BC_CARGO").ToString
                            .BC_EMAIL = dr("BC_EMAIL").ToString
                        End With
                        lista.Add(contacto)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getContactos_x_Id(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)
            Try
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_BAN_CONTAC_BYID", Entidad.BC_IDCONTACTO)
                If dr.HasRows Then
                    Do While dr.Read
                        With Entidad
                            .BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = dr("BC_IDBANCO")}
                            .BC_IDCONTACTO = dr("BC_IDCONTACTO")
                            .BC_NOMBRES = dr("BC_NOMBRES").ToString
                            .BC_APELLIDOS = dr("BC_APELLIDOS").ToString
                            .BC_CARGO = dr("BC_CARGO").ToString
                            .BC_EMAIL = dr("BC_EMAIL").ToString
                        End With
                    Loop
                End If

                dr.Close()
                dr = Nothing

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

    Public Class SG_CO_TB_CONTACTO_TELEF
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_I_CONTACTO_TELEF", .CT_IDCONTACTO.BC_IDCONTACTO, .CT_IDCOMUNICACION.TC_ID, .CT_NUMERO, .CT_ISTATUS, .CT_USUARIO, .CT_TERMINAL, .CT_FECREG, .CT_DESCRIPCION)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_U_CONTACTO_TELEF", .CT_IDREG, .CT_IDCONTACTO.BC_IDCONTACTO, .CT_IDCOMUNICACION.TC_ID, .CT_NUMERO, .CT_ISTATUS, .CT_USUARIO, .CT_TERMINAL, .CT_FECREG, .CT_DESCRIPCION)
                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_D_CONTACTO_TELEF", .CT_IDREG)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getTelefonos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF) As List(Of BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF)
            getTelefonos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF)
                Dim telefono As BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF
                Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_CONTACTO_TELEF", Entidad.CT_IDCONTACTO.BC_IDCONTACTO)

                If dr.HasRows Then
                    Do While dr.Read
                        telefono = New BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF()
                        telefono.CT_IDREG = dr("CT_IDREG")
                        telefono.CT_IDCONTACTO = New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO With {.BC_IDCONTACTO = dr("CT_IDREG")}
                        telefono.CT_IDCOMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION With {.TC_ID = dr("CT_IDREG"), .TC_DESCRIPCION = dr("TC_DESCRIPCION")}
                        telefono.CT_NUMERO = dr("CT_NUMERO")
                        telefono.CT_DESCRIPCION = dr("CT_DESCRIPCION")
                        telefono.CT_ISTATUS = dr("CT_ISTATUS")
                        lista.Add(telefono)
                    Loop
                End If

                dr.Close()
                dr = Nothing

                Return lista

            Catch ex As Exception
                Throw ex
            End Try
        End Function


    End Class

    Public Class SG_CO_TB_SALDO_MOV_BANCO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO)
            Try
                With Entidad

                    Dim dato As Integer = SqlHelper.ExecuteScalar(Cn, CommandType.Text, "SELECT COUNT(*) FROM SG_CO_TB_SALDO_MOV_BANCO WHERE SMB_ANHO = " & Entidad.SMB_ANHO & " AND SMB_MES = " & Entidad.SMB_MES & " AND SMB_CUENTA = " & Entidad.SMB_CUENTA & " AND SMB_IDEMPRESA = " & Entidad.SMB_IDEMPRESA.EM_ID)

                    If dato > 0 Then
                        Throw New Exception("El mes ya tiene saldo registrado.")
                    End If

                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_SP_I_SALDO_MOV_BANCO", .SMB_ANHO, .SMB_MES, .SMB_CUENTA, .SMB_SALDO, .SMB_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_SP_U_SALDO_MOV_BANCO", .SMB_ANHO, .SMB_MES, .SMB_CUENTA, .SMB_SALDO, .SMB_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO)
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(Cn, "SG_CO_TB_SP_D_SALDO_MOV_BANCO", .SMB_ANHO, .SMB_MES, .SMB_CUENTA, .SMB_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function getSaldos_dt(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO) As DataTable
            getSaldos_dt = Nothing
            Try
                Dim dt As DataTable
                With Entidad
                    dt = SqlHelper.ExecuteDataset(Cn, "SG_CO_TB_SP_S_SALDO_MOV_BANCO", .SMB_ANHO, .SMB_CUENTA, .SMB_IDEMPRESA.EM_ID).Tables(0)
                End With

                Return dt

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSaldos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO) As List(Of BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO)
            getSaldos = Nothing
            Try
                Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO)
                Dim saldo As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO

                With Entidad
                    Dim Dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_TB_SP_S_SALDO_MOV_BANCO", .SMB_ANHO, .SMB_CUENTA, .SMB_IDEMPRESA.EM_ID)
                    If Dr.HasRows Then
                        Do While Dr.Read
                            saldo = New BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO()
                            saldo.SMB_ANHO = Dr("SMB_ANHO")
                            saldo.SMB_MES = Dr("SMB_MES")
                            saldo.SMB_CUENTA = Dr("SMB_CUENTA")
                            saldo.SMB_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Dr("SMB_IDEMPRESA")}
                            lista.Add(saldo)
                        Loop
                    End If

                    Dr.Close()
                    Dr = Nothing

                End With

                Return lista
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getBancoId_x_CtaCteId(ByVal Id_CtaConta As Integer) As Integer
            getBancoId_x_CtaCteId = 0
            Try
                Return SqlHelper.ExecuteScalar(Cn, "SG_CO_TB_SP_S_IDBANCO_X_IDCTACTE", Id_CtaConta)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSaldo_Anterior(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO) As Double
            getSaldo_Anterior = 0
            Try
                With Entidad
                    Return SqlHelper.ExecuteScalar(Cn, "SG_CO_TB_SP_S_SAL_ANT_MOVBANCO", .SMB_ANHO, .SMB_MES, .SMB_CUENTA, .SMB_IDEMPRESA.EM_ID)
                End With
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
#End Region

End Class




