
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data


Public Class PlanillaBL


    Public Class SG_PL_Reportes
        Inherits ClsBD

        Public Function get_afp_tmp(ByVal empresa As Integer) As DataTable
            Dim str_database As String = "Planilla"

            Select Case empresa
                Case 1 'CLINICA MIRAFLORES S.A.C
                    str_database = "Planilla"
                Case 2 'FERTI FARM S.A.C.
                    str_database = "Planilla_Fertifarm"
                Case 3 'GESTAR S.A.C
                    str_database = "Planilla_Gestar"
                Case 4 'GINEFERT SA.C
                    str_database = "Planilla_Ginefert"
                Case 5 'GINECOLOGIA Y FERTILIDAD S.A.C
                    str_database = "Planilla_GyFSAC"
                Case 6 'ECOGEST S.A.C
                    str_database = "Planilla_Ecogest"
                Case 7 'BOTICA IGFARMA SAC
                    str_database = "Planilla_Igfarma"
            End Select


            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=" & str_database & ";Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnigf.Open()
            Return SqlHelper.ExecuteDataset(cnigf, CommandType.Text, "select * from afp order by 1").Tables(0)
        End Function

        Public Function get_Liq_Anual_Aportes_Retenciones(ByVal anho As Integer, ByVal afp As Integer, ByVal empresa As Integer) As DataTable
            Dim str_database As String = "Planilla"

            Select Case empresa
                Case 1 'CLINICA MIRAFLORES S.A.C
                    str_database = "Planilla"
                Case 2 'FERTI FARM S.A.C.
                    str_database = "Planilla_Fertifarm"
                Case 3 'GESTAR S.A.C
                    str_database = "Planilla_Gestar"
                Case 4 'GINEFERT SA.C
                    str_database = "Planilla_Ginefert"
                Case 5 'GINECOLOGIA Y FERTILIDAD S.A.C
                    str_database = "Planilla_GyFSAC"
                Case 6 'ECOGEST S.A.C
                    str_database = "Planilla_Ecogest"
                Case 7 'BOTICA IGFARMA SAC
                    str_database = "Planilla_Igfarma"
            End Select


            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=" & str_database & ";Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnigf.Open()
            Return SqlHelper.ExecuteDataset(cnigf, "PL_LIQ_ANUAL_APORTES_RETENC", anho, afp).Tables(0)

        End Function


    End Class

    Public Class SG_PL_TB_TOPE_MENSUAL
        Inherits ClsBD

        Public Function get_tope_mensual(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL) As Double
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TOPE_MEN_X_MES", Entidad.TM_PERIODO, Entidad.TM_MES, Entidad.TM_IDEMPRESA.EM_ID)
        End Function

    End Class

    Public Class SG_PL_TB_HISTORIAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_HISTORIAL)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_HISTORIAL", .HI_ID_PERSONAL.PE_ID, .HI_MES, .HI_FEC_OPE, .HI_COD_HD.CO_ID, .HI_MONTO, .HI_IDEN_HD, .HI_EST_ASI, .HI_COD_AFP, .HI_DES_HD, .HI_HORAS, .HI_ID_EMPRESA.EM_ID, .HI_USUARIO, .HI_TERMINAL, .HI_FECREG)
            End With
        End Sub

        Public Function get_Historial() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "").Tables(0)
        End Function

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_HISTORIAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_HISTORIAL_BY_IDPERSON", Entidad.HI_ID_PERSONAL.PE_ID, Entidad.HI_ID_EMPRESA.EM_ID)
        End Sub

    End Class

    Public Class SG_PL_TB_PERSONAL_CONCEPTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PERSONAL_CONCEPTO", .PC_ID_PERSONAL.PE_ID, .PC_ID_CONCEPTO.CO_ID, .PC_VALOR, .PC_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_CONCEPTO", .PC_ID_PERSONAL.PE_ID, .PC_ID_CONCEPTO.CO_ID, .PC_VALOR, .PC_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL_CONCEPTO", .PC_ID_PERSONAL.PE_ID, .PC_ID_CONCEPTO.CO_ID, .PC_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Conceptos(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_CONCEPTO", Entidad.PE_ID).Tables(0)
        End Function


    End Class

    Public Class SG_PL_TB_CTA_CTE_CRONOGRAMA
        Inherits ClsBD


        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE_CRONOGRAMA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CTA_CTE_CRONOGRAMA", .CR_ID_CTACTE.CC_ID, .CR_NUM_CUOTA, .CR_FECHA_PAGO, .CR_IMPORTE, .CR_ESTADO.EP_ID)
            End With

            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "UPDATE SG_PL_TB_CTA_CTE SET CC_NUM_CUOTAS = " & Entidad.CR_NUM_CUOTA & " WHERE CC_ID = " & Entidad.CR_ID_CTACTE.CC_ID)

        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE_CRONOGRAMA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CTA_CTE_CRONOGRAMA", Entidad.CR_ID_CTACTE.CC_ID,Entidad.CR_NUM_CUOTA)
        End Sub

        Public Function get_Cronograma(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CTA_CTE_CRONO", Entidad.CC_ID).Tables(0)
        End Function

    End Class
    Public Class SG_PL_TB_CTA_CTE
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            With Entidad
                Entidad.CC_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_CTA_CTE", .CC_NUMERO, .CC_FECHA_REGISTRO, _
                                          .CC_ID_PERSONAL.PE_ID, .CC_ID_MOTIVO.MP_ID, .CC_AFECTA_PLANILLA, _
                                          .CC_ID_MONEDA.MO_CODIGO, .CC_IMPORTE, .CC_TC, .CC_NUM_CUOTAS, _
                                          .CC_OBSERVACIONES, .CC_ESTADO.EP_ID, .CC_SALDO, .CC_USUARIO, _
                                          .CC_TERMINAL, .CC_FECREG)

                Dim dbl_Cuotas As Double = (Entidad.CC_IMPORTE / Entidad.CC_NUM_CUOTAS)
                Dim dat_fecha_pago As Date = CDate(Entidad.CC_FECHA_REGISTRO)

                For i As Integer = 1 To Entidad.CC_NUM_CUOTAS
                    dat_fecha_pago = dat_fecha_pago.AddMonths(1)
                    SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CTA_CTE_CRONO", Entidad.CC_ID, i, dat_fecha_pago, dbl_Cuotas, 1)
                Next

            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CTA_CTE", .CC_ID, .CC_NUMERO, .CC_FECHA_REGISTRO, _
                                          .CC_ID_PERSONAL.PE_ID, .CC_ID_MOTIVO.MP_ID, .CC_AFECTA_PLANILLA, _
                                          .CC_ID_MONEDA.MO_CODIGO, .CC_IMPORTE, .CC_TC, .CC_NUM_CUOTAS, _
                                          .CC_OBSERVACIONES, .CC_ESTADO.EP_ID, .CC_SALDO, .CC_USUARIO, _
                                          .CC_TERMINAL, .CC_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CTA_CTE", .CC_ID)
            End With
        End Sub

        Public Function get_ctacte(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CTA_CTE", empresa.EM_ID).Tables(0)
        End Function

        Public Sub get_ctacte_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CTA_CTE_BY_ID", Entidad.CC_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .CC_NUMERO = drr("CC_NUMERO")
                    .CC_FECHA_REGISTRO = drr("CC_FECHA_REGISTRO")
                    .CC_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = drr("CC_ID_PERSONAL"), .PE_APE_PAT = drr("PE_APE_PAT"), .PE_APE_MAT = drr("PE_APE_MAT"), .PE_NOM_PRI = drr("PE_NOM_PRI"), .PE_NOM_SEG = drr("PE_NOM_SEG"), .PE_CODIGO = drr("PE_CODIGO")}
                    .CC_ID_MOTIVO = New BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO With {.MP_ID = drr("CC_ID_MOTIVO")}
                    .CC_AFECTA_PLANILLA = drr("CC_AFECTA_PLANILLA")
                    .CC_ID_MONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = drr("CC_ID_MONEDA")}
                    .CC_IMPORTE = drr("CC_IMPORTE")
                    .CC_TC = drr("CC_TC")
                    .CC_NUM_CUOTAS = drr("CC_NUM_CUOTAS")
                    .CC_OBSERVACIONES = drr("CC_OBSERVACIONES")
                    .CC_ESTADO = New BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO With {.EP_ID = drr("CC_ESTADO")}
                    .CC_SALDO = drr("CC_SALDO")
                End With
            End If
            drr.Close()
        End Sub

        Public Function get_Ultimo_Num_Recibo(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As Integer
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULT_NUM_RECIBO", empresa.EM_ID)
        End Function

    End Class

    Public Class SG_PL_TB_ESTADO_PRESTAMO
        Inherits ClsBD

        Public Function get_Estados() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_PRESTAMO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_MOTIVO_PRESTAMO
        Inherits ClsBD

        Public Function get_Motivos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_MOTIVO_PRESTAMO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SUSPENSIONES
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_SUSPENSIONES", .SU_ID_TIPO_SUSPENSION.TS_ID, .SU_ID_PERSONAL.PE_ID, .SU_FECHA_INI, .SU_FECHA_FIN, .SU_DIAS_VACA, .SU_DIAS_TRABAJO, .SU_USUARIO, .SU_TERMINAL, .SU_FECREG, .SU_ID_TIPO_SUSPE_SUNAT.TS_CODIGO, .SU_PROCESAR)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_SUSPENSIONES", .SU_ID, .SU_ID_TIPO_SUSPENSION.TS_ID, .SU_ID_PERSONAL.PE_ID, .SU_FECHA_INI, .SU_FECHA_FIN, .SU_DIAS_VACA, .SU_DIAS_TRABAJO, .SU_USUARIO, .SU_TERMINAL, .SU_FECREG, .SU_ID_TIPO_SUSPE_SUNAT.TS_CODIGO, .SU_PROCESAR)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_SUSPENSIONES", .SU_ID)
            End With
        End Sub

        Public Function Procesado(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES) As Boolean
            Procesado = False
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPENSIONES_BY_ID", Entidad.SU_ID)
            If drr.HasRows Then
                drr.Read()
                If drr("SU_PROCESASADO") = 1 Then
                    Procesado = True
                End If
            End If
            drr.Close()
        End Function

        Public Function get_Suspensiones(ByVal tipo As Integer, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SUSPENSIONES", tipo, empresa).Tables(0)
        End Function

        Public Function get_Suspensiones_x_Tipo_x_Personal_x_Periodo(ByVal id_tipo As Integer, ByVal id_personal As Integer, ByVal periodo As Date) As Integer
            get_Suspensiones_x_Tipo_x_Personal_x_Periodo = 0
            Dim int_dias As Integer = 0
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPEN_BY_IDPER_IDTIPO", id_tipo, id_personal, periodo.Year, periodo.Month)

            If drr.HasRows Then
                drr.Read()
                If drr("SU_PROCESAR") = 1 Then
                    int_dias = drr("SU_DIAS_VACA")
                End If
            End If

            drr.Close()

            Return int_dias

        End Function

        Public Sub get_Suspensiones_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPENSIONES_BY_ID", Entidad.SU_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .SU_ID = drr("SU_ID")
                    .SU_ID_TIPO_SUSPENSION = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION With {.TS_ID = drr("SU_ID_TIPO_SUSPENSION")}
                    .SU_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = drr("SU_ID_PERSONAL")}
                    .SU_FECHA_INI = drr("SU_FECHA_INI")
                    .SU_FECHA_FIN = drr("SU_FECHA_FIN")
                    .SU_DIAS_VACA = drr("SU_DIAS_VACA")
                    .SU_DIAS_TRABAJO = drr("SU_DIAS_TRABAJO")
                    .SU_ID_TIPO_SUSPE_SUNAT = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT With {.TS_CODIGO = drr("SU_ID_TIPO_SUSPE_SUNAT")}
                    .SU_PROCESAR = drr("SU_PROCESAR")
                End With
            End If
            drr.Close()
        End Sub

    End Class

    Public Class SG_PL_TB_TIPO_SUSPENSION_SUNAT
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_SUSPENSION_SUNAT").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_SUSPENSION
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_SUSPENSION").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_FOLIO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_FOLIO", .FO_ANHO, .FO_MES, .FO_ID_PERSONA.PE_ID, .FO_ID_CONCEPTO.CO_ID, .FO_VALOR, .FO_ID_EMPRESA.EM_ID, .FO_USUARIO, .FO_TERMINAL, .FO_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_FOLIO", .FO_ANHO, .FO_MES, .FO_ID_PERSONA.PE_ID, .FO_ID_CONCEPTO.CO_ID, .FO_VALOR, .FO_ID_EMPRESA.EM_ID, .FO_USUARIO, .FO_TERMINAL, .FO_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_FOLIO", .FO_ANHO, .FO_MES, .FO_ID_CONCEPTO.CO_ID, .FO_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Folios(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_FOLIO", Entidad.FO_ANHO, Entidad.FO_MES, Entidad.FO_ID_CONCEPTO.CO_ID, Entidad.FO_ID_EMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub get_Folios_x_IdPersonal(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_FOLIO_BY_ID_PER", Entidad.FO_ANHO, Entidad.FO_MES, Entidad.FO_ID_CONCEPTO.CO_ID, Entidad.FO_ID_PERSONA.PE_ID, Entidad.FO_ID_EMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    '.FO_ANHO = drr("FO_ANHO")
                    '.FO_MES = drr("FO_MES")
                    '.FO_ID_PERSONA = drr("FO_ID_PERSONA")
                    '.FO_ID_CONCEPTO = drr("FO_ID_CONCEPTO")
                    .FO_VALOR = drr("FO_VALOR")
                    .HasRow = True
                End With
            End If
            drr.Close()
        End Sub

    End Class

    Public Class SG_PL_TB_IDENTIFICADOR
        Inherits ClsBD

        Public Function get_Identificadores() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_IDENTIFICADOR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_ALCANCE_CONCEPTO
        Inherits ClsBD

        Public Function get_Alcances() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ALCANCE_CONCEPTO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_CONCEPTO
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CONCEPTO").Tables(0)
        End Function

        Public Function get_Tipo_X_Concepto(ByVal concepto, ByVal empresa) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TIPO_X_IDCONCEPTO", concepto, empresa)
        End Function
    End Class

    Public Class SG_PL_TB_CONCEPTOS
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CONCEPTOS", .CO_ID, .CO_DESCRIPCION, .CO_ID_TIPO.TC_ID, _
                                          .CO_VALOR, .CO_ESTADO, .CO_ID_ALCANCE.AC_ID, .CO_ID_IDENTIFICADOR.ID_ID, _
                                          .CO_ID_CUENTA_D.PC_IDCUENTA, .CO_ID_CUENTA_H.PC_IDCUENTA, .CO_ID_SUNAT.CS_ID, _
                                          .CO_NO_AFECT_AFP, .CO_NO_AFECTA_QUINTA, .CO_NO_PROYECTA_QUINTA, .CO_AFECTA_GRATI, _
                                          .CO_ID_INTERNO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CONCEPTOS", .CO_ID, .CO_DESCRIPCION, .CO_ID_TIPO.TC_ID, _
                                          .CO_VALOR, .CO_ESTADO, .CO_ID_ALCANCE.AC_ID, .CO_ID_IDENTIFICADOR.ID_ID, _
                                          .CO_ID_CUENTA_D.PC_IDCUENTA, .CO_ID_CUENTA_H.PC_IDCUENTA, .CO_ID_SUNAT.CS_ID, _
                                          .CO_NO_AFECT_AFP, .CO_NO_AFECTA_QUINTA, .CO_NO_PROYECTA_QUINTA, .CO_AFECTA_GRATI, _
                                          .CO_ID_INTERNO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CONCEPTOS", .CO_ID, .CO_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Conceptos(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_Matriz(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As List(Of BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CONCEPTOS_ACTIVOS", Empresa.EM_ID)
            Dim lista_conceptos As New List(Of BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            Dim concepto As BE.PlanillaBE.SG_PL_TB_CONCEPTOS

            If drr.HasRows Then
                Do While drr.Read
                    concepto = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS()
                    With concepto
                        .CO_ID = drr("CO_ID")
                        .CO_DESCRIPCION = drr("CO_DESCRIPCION")
                        .CO_ID_TIPO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO With {.TC_ID = drr("CO_ID_TIPO")}
                        .CO_VALOR = drr("CO_VALOR")
                        .CO_ESTADO = drr("CO_ESTADO")
                        .CO_ID_ALCANCE = New BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO With {.AC_ID = drr("CO_ID_ALCANCE")}
                        .CO_ID_IDENTIFICADOR = New BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR With {.ID_ID = drr("CO_ID_IDENTIFICADOR")}
                        .CO_ID_CUENTA_D = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = drr("CO_ID_CUENTA_D")}
                        .CO_ID_CUENTA_H = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = drr("CO_ID_CUENTA_H")}

                        If drr("CO_ID_SUNAT").ToString.Equals(String.Empty) Then
                            .CO_ID_SUNAT = Nothing
                        Else
                            .CO_ID_SUNAT = New BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT With {.CS_ID = drr("CO_ID_SUNAT")}
                        End If


                        .CO_NO_AFECT_AFP = drr("CO_NO_AFECT_AFP")
                        .CO_NO_AFECTA_QUINTA = drr("CO_NO_AFECTA_QUINTA")
                        .CO_NO_PROYECTA_QUINTA = drr("CO_NO_PROYECTA_QUINTA")
                        .CO_AFECTA_GRATI = drr("CO_AFECTA_GRATI")
                        .CO_ID_INTERNO = drr("CO_ID_INTERNO")

                    End With
                    lista_conceptos.Add(concepto)
                Loop
            End If

            drr.Close()

            Return lista_conceptos

        End Function

        Public Function get_Conceptos_Lista_Chica(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_LISTA_CHICA", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_Lista_Calculo(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_LISTA_CALCULO", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_x_Id(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_BY_ID", Entidad.CO_ID, Entidad.CO_ID_EMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Ultimo_Num_Interno_concepto(ByVal int_empresa As Integer) As String
            Dim ultimo As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULT_NUM_CONCEP_INT", int_empresa)
            Return ultimo
        End Function

        Public Sub Copiar_de_otro_Folio(ByVal ayo As Integer, ByVal mes As Integer, ByVal ayo_a As Integer, ByVal mes_a As Integer, ByVal folio As String, ByVal porcentaje As Double, ByVal empresa As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_FOLIO_DESDE_OTRO", ayo, mes, ayo_a, mes_a, folio, porcentaje, empresa)
        End Sub
    End Class

    Public Class SG_PL_TB_CONCEPTO_SUNAT
        Inherits ClsBD

        Public Function get_Conceptos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTO_SUNAT").Tables(0)
        End Function

        Public Function get_Conceptos_x_Tipo(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTO_SUNAT_BY_TIPO", Entidad.CS_TIPO).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_TARIFA
        Inherits ClsBD


        Public Sub Insert()

        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_TIPO_TARIFA", .TI_ID, .TI_IDCONCEPTO.CO_ID, .TI_ID_EMPRESA.EM_ID)
            End With

        End Sub


        Public Function get_Tipos(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_TARIFA", empresa.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TARIFA
        Inherits ClsBD

        Public Function get_Tarifas(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TARIFA", Empresa.EM_ID).Tables(0)
        End Function

        Public Function Existe_Llave(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TARIFA) As Boolean
            Dim cantidad As Integer = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TARIFA_X_LLAVE", Entidad.TA_ID_TIPO_TARIFA.TI_ID, Entidad.TA_ID_TIPO_PER.TT_ID, Entidad.TA_ID_EMPRESA.EM_ID)
            If cantidad > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TARIFA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_TARIFA", Entidad.TA_ID_TIPO_PER.TT_ID, Entidad.TA_ID_TIPO_TARIFA.TI_ID, Entidad.TA_VALOR, Entidad.TA_ID_EMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TARIFA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_TARIFA", Entidad.TA_ID_TIPO_PER.TT_ID, Entidad.TA_ID_TIPO_TARIFA.TI_ID, Entidad.TA_VALOR, Entidad.TA_ID_EMPRESA.EM_ID)
        End Sub

    End Class

    Public Class SG_PL_TB_TIPO_PERSO_TARIFA
        Inherits ClsBD

        Public Function get_Tipos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PERSO_TARIFA", Entidad.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_CCOSTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PERSONAL_CCOSTO", .CC_CC.CC_CODIGO, .CC_ID_PERSONA.PE_ID, .CC_PORCENTAJE, .CC_USUARIO, .CC_TERMINAL, .CC_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_CCOSTO", .CC_CC.CC_CODIGO, .CC_ID_PERSONA.PE_ID, .CC_PORCENTAJE, .CC_USUARIO, .CC_TERMINAL, .CC_FECREG)
            End With
        End Sub

        Public Function get_CCostosPersonal_x_IdPersonal(ByVal personaBE As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_TB_S_PERSO_CCOSTO_BY_IDPER", personaBE.PE_ID, personaBE.PE_ID_EMPRESA).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_CONTRATOS
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
            With Entidad
                Entidad.CO_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONAL_CONTRATOS", .CO_ID_PERSONAL.PE_ID, .CO_ID_TIPO_CONTRATO.TC_ID, .CO_FECHA_INI, .CO_FECHA_FIN, .CO_COMENTARIO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_CONTRATOS", .CO_ID, .CO_ID_PERSONAL.PE_ID, .CO_ID_TIPO_CONTRATO.TC_ID, .CO_FECHA_INI, .CO_FECHA_FIN, .CO_COMENTARIO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL_CONTRATOS", Entidad.CO_ID)
        End Sub

        Public Function get_Data_Generar_Contrato(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DATOS_CONTRATO").Tables(0)
        End Function

        Public Function get_Contratos_x_IdPersonal(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_CONTRATOS", Entidad.PE_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_CONTRATO
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CONTRATO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_DOCUMENTOS
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            With Entidad
                Entidad.DO_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONAL_DOCUMENTOS", .DO_ID_PERSONAL.PE_ID, .DO_NOMBRE_ARCHIVO, .DO_DESCRIPCION, .DO_FILE, .DO_USUARIO, .DO_TERMINAL, .DO_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_DOCUMENTOS", .DO_ID, .DO_DESCRIPCION)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL_DOCUMENTOS", .DO_ID)
            End With
        End Sub

        Public Function get_Documentos_X_IdPersona(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSO_DOC_BY_IDPER", Entidad.PE_ID).Tables(0)
        End Function

        Public Sub Recuperar_Documento_Almacenado(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSO_DOC_BY_IDDOC", Entidad.DO_ID)
            If drr.HasRows Then
                drr.Read()
                Dim bufferSize As Int32 = Convert.ToInt32(drr.GetBytes(0, 0, Nothing, 0, 0))
                Dim aByte(bufferSize - 1) As Byte
                drr.GetBytes(0, 0, aByte, 0, bufferSize)

                Dim cls_funciones As New LR.ClsFunciones
                cls_funciones.WriteBinaryFile(aByte, "C:\" & Entidad.DO_NOMBRE_ARCHIVO)
                cls_funciones = Nothing
                Process.Start("C:\" & Entidad.DO_NOMBRE_ARCHIVO)
            End If
            drr.Close()
        End Sub

    End Class

    Public Class SG_PL_TB_PERSONA_COMUNICACION
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            With Entidad
                Entidad.PC_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONA_COMUNICACION", .PC_ID_PERSONA.PE_ID, .PC_ID_COMUNICACION.TC_ID, .PC_NUMERO, .PC_DESCRIPCION, .PC_ISTATUS, .PC_USUARIO, .PC_TERMINAL, .PC_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONA_COMUNICACION", .PC_ID, .PC_ID_PERSONA.PE_ID, .PC_ID_COMUNICACION.TC_ID, .PC_NUMERO, .PC_DESCRIPCION, .PC_ISTATUS, .PC_USUARIO, .PC_TERMINAL, .PC_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONA_COMUNICACION", .PC_ID)
            End With
        End Sub

        Public Function getComunicaciones_x_IdPersona(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERS_COMUN_BY_IDPER", Entidad.PE_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_UBI_UBIGEO
        Inherits ClsBD

        Public Function getUbigeo() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_UBIGEO").Tables(0)
        End Function

        Public Function getUbigeo_x_Provincia(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_UBI_PROVINCIA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_UBIGEO_BY_PROVI", Entidad.PR_CODIGO).Tables(0)
        End Function

        Public Sub getUbigeo_x_Id(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_UBI_UBIGEO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_UBI_UBIGEO_BY_ID")

            If drr.HasRows Then
                drr.Read()
                Entidad.UB_DESCRIPCION = drr("UB_DESCRIPCION")
            End If
            drr.Close()
        End Sub

    End Class

    Public Class SG_PL_TB_UBI_PROVINCIA
        Inherits ClsBD

        Public Function getProvincias() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_PROVINCIA").Tables(0)
        End Function

        Public Function getProvincias_x_Departamento(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_UBI_DEPARTAMENTO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_PROVINCIA_BY_DEPA", Entidad.DE_CODIGO).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_UBI_DEPARTAMENTO
        Inherits ClsBD

        Public Function getDepartamentos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_DEPARTAMENTO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_AFP
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_AFP", .AF_ID, .AF_NOMBRE, .AF_DIRECCION, .AF_TELEFONO, .AF_COMISION_FIJA, .AF_COMISION_VAR, .AF_SEGURO, .AF_TOPE_SEGURO, .AF_IDCUENTA_CONTA.PC_IDCUENTA, .AF_IDEMPRESA.EM_ID, .AF_COD_SUNAT.PE_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_AFP", .AF_ID, .AF_NOMBRE, .AF_DIRECCION, .AF_TELEFONO, .AF_COMISION_FIJA, .AF_COMISION_VAR, .AF_SEGURO, .AF_TOPE_SEGURO, .AF_IDCUENTA_CONTA.PC_IDCUENTA, .AF_IDEMPRESA.EM_ID, .AF_COD_SUNAT.PE_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_AFP", .AF_ID, .AF_IDEMPRESA)
            End With
        End Sub

        Public Function getAfp(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_AFP", Entidad.EM_ID).Tables(0)
        End Function

        Public Sub getAfp_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_AFP_BY_ID", Entidad.AF_ID, Entidad.AF_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .AF_ID = drr("AF_ID")
                    .AF_NOMBRE = drr("AF_NOMBRE").ToString
                    .AF_DIRECCION = drr("AF_DIRECCION").ToString
                    .AF_TELEFONO = Val(drr("AF_TELEFONO").ToString)
                    .AF_COMISION_FIJA = Val(drr("AF_COMISION_FIJA").ToString)
                    .AF_COMISION_VAR = Val(drr("AF_COMISION_VAR").ToString)
                    .AF_SEGURO = Val(drr("AF_SEGURO").ToString)
                    .AF_TOPE_SEGURO = Val(drr("AF_TOPE_SEGURO").ToString)
                    .AF_IDCUENTA_CONTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Val(drr("AF_IDCUENTA_CONTA").ToString)}
                    .AF_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = drr("AF_IDEMPRESA")}
                    .AF_COD_SUNAT = New BE.PlanillaBE.SG_PL_TB_PENSIONES With {.PE_ID = Val(drr("AF_COD_SUNAT").ToString)}
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub

    End Class

    Public Class SG_PL_TB_AREA
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            Entidad.AR_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_AREA", Entidad.AR_DESCRIPCION, Entidad.AR_ID_EMPRESA.EM_ID)
        End Sub
        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_AREA", Entidad.AR_ID, Entidad.AR_DESCRIPCION, Entidad.AR_ID_EMPRESA.EM_ID)
        End Sub
        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_AREA", Entidad.AR_ID, Entidad.AR_ID_EMPRESA.EM_ID)
        End Sub
        Public Sub getArea_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_AREA_BY_ID", Entidad.AR_ID, Entidad.AR_ID_EMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .AR_ID = drr("AR_ID")
                    .AR_DESCRIPCION = drr("AR_DESCRIPCION")
                    .AR_ID_EMPRESA = drr("AR_ID_EMPRESA")
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub
        Public Function getArea(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_AREA", Entidad.AR_ID_EMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_CARGO
        Inherits ClsBD


        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            Entidad.EC_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_CARGO", Entidad.EC_CARGO, Entidad.EC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CARGO", Entidad.EC_ID, Entidad.EC_CARGO, Entidad.EC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CARGO", Entidad.EC_ID)
        End Sub

        Public Sub getCargo_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CARGO_BY_ID", Entidad.EC_ID, Entidad.EC_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .EC_CARGO = drr("EC_CARGO")
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub

        Public Function getCargos(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CARGO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CARGO", Entidad.EC_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_CLASIFICACION_PERSONAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CLASIF_PERSONAL", Entidad.CP_ID, Entidad.CP_DESCRIPCION)
        End Sub
        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CLASIF_PERSONAL", Entidad.CP_ID, Entidad.CP_DESCRIPCION)
        End Sub
        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CLASIF_PERSONAL", Entidad.CP_ID)
        End Sub
        Public Sub getClasificacion_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CLASIF_PER_BY_ID", Entidad.CP_ID)
            If drr.HasRows Then
                drr.Read()
                Entidad.CP_DESCRIPCION = drr("CP_DESCRIPCION")
            End If
            drr.Close()
        End Sub
        Public Function getClasificacion() As DataTable
            getClasificacion = Nothing
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_PL_SP_S_CLASIF_PER").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_PENSIONES
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PENSIONES)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PENSIONES", Entidad.PE_ID, Entidad.PE_DESCRIPCION)
        End Sub
        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PENSIONES)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PENSIONES", Entidad.PE_ID, Entidad.PE_DESCRIPCION)
        End Sub
        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PENSIONES)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PENSIONES", Entidad.PE_ID)
        End Sub
        Public Function getPensiones() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_PL_SP_S_PENSIONES").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_DOCUMENTO_PERSONAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DOCUMENTO_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_DOCUMENTO_PERSONAL", Entidad.DP_ID, Entidad.DP_CODIGO, Entidad.DP_DESCRIPCION)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DOCUMENTO_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_DOCUMENTO_PERSONAL", Entidad.DP_ID, Entidad.DP_DESCRIPCION)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DOCUMENTO_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_DOCUMENTO_PERSONAL", Entidad.DP_ID)
        End Sub

        Public Function getDocumentos() As DataTable
            getDocumentos = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DOCUMENTO_PERSONAL").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_EPS_SERVICIO_PROPIO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_EPS_SERVICIO_PROPIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_EPS_SERVICIO_PROPIO", Entidad.EP_ID, Entidad.EP_RUC, Entidad.EP_DESCRIPCION)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_EPS_SERVICIO_PROPIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_EPS_SERVICIO_PROPIO", Entidad.EP_ID, Entidad.EP_RUC, Entidad.EP_DESCRIPCION)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_EPS_SERVICIO_PROPIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_EPS_SERVICIO_PROPIO", Entidad.EP_ID)
        End Sub

        Public Function getEPS() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_EPS_SERVICIO_PROPIO").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_ESTADO_TRABAJADOR
        Inherits ClsBD

        Public Function getEstados() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_TRABAJADOR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_ESTADO_VICIL
        Inherits ClsBD

        Public Function getEstados() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_VICIL").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_GRUPO_SANGUINEO
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO)
            Entidad.GS_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_GRUPO_SANGUINEO", Entidad.GS_TIPO, Entidad.GS_DESCRIPCION)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_GRUPO_SANGUINEO", Entidad.GS_ID, Entidad.GS_TIPO, Entidad.GS_DESCRIPCION)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_GRUPO_SANGUINEO", Entidad.GS_ID)
        End Sub

        Public Function getGrupoSanguineo() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_GRUPO_SANGUINEO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_NACIONALIDAD
        Inherits ClsBD

        Public Function getNacionalidades() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_NACIONALIDAD").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_NIVEL_EDUCATIVO
        Inherits ClsBD

        Public Function getNiveles() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_NIVEL_EDUCATIVO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_OCUPACION
        Inherits ClsBD
        Public Function getOcupaciones() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_OCUPACION").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERIODO_REMUNERATIVO
        Inherits ClsBD

        Public Function getPeriodos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERIODO_REMUNERATIVO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_REGIMEN_LABORAL
        Inherits ClsBD

        Public Function getRegimenes() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REGIMEN_LABORAL").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SCTR_PENSION
        Inherits ClsBD

        Public Function getSctr() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SCTR_PENSION").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SCTR_SALUD
        Inherits ClsBD

        Public Function getSctr() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SCTR_SALUD").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_SEXO
        Inherits ClsBD

        Public Function getSexos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SEXO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SITUACION_EPS
        Inherits ClsBD

        Public Function getSituaciones_x_Tipo(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SITUACION_EPS) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SIT_EPS_BY_TIPO", Entidad.SE_TIPO).Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_SITUACION_ESPECIAL
        Inherits ClsBD

        Public Function getSituaciones() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SITUACION_ESPECIAL").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_CESE
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CESE").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_CTA_BANCO
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CTA_BANCO").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_PAGO
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PAGO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_PERSONAL
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PERSONAL").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_PERSONAL_CLI
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PERSONAL_CLI").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_REMUNERACION
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_REMUNERACION").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_TRABAJADOR
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_TRABAJADOR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_VIA
        Inherits ClsBD

        Public Function getVias() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_VIA").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_ZONA
        Inherits ClsBD

        Public Function getZonas() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_ZONA").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_PERSONAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal Lis_Comunicacion As List(Of BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION), ByVal Lis_ccostos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO), ByVal Lis_documentos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS), ByVal Lis_contratos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS), ByVal Lis_conceptos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO))
            With Entidad
                Entidad.PE_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONAL", .PE_CODIGO, .PE_CODIGO_ALT, .PE_ID_TIPO_PER, _
                                          .PE_APE_PAT, .PE_APE_MAT, .PE_NOM_PRI, .PE_NOM_SEG, .PE_ID_TIPO_DOC_PER, _
                                          .PE_NUM_DOC_PER, .PE_FEC_NAC, .PE_ID_EST_CIVIL, _
                                          IIf(.PE_ID_CARGO = 0, DBNull.Value, .PE_ID_CARGO), .PE_NUM_IPSS, _
                                          IIf(.PE_ID_AFP = 0, DBNull.Value, .PE_ID_AFP), .PE_NUM_AFP, .PE_ID_EST_TRABAJADOR, .PE_IMPORTE_REMUNERACION, _
                                          .PE_ID_MONEDA_REMU, .PE_ID_TIPO_REMU, .PE_ID_TIPO_CUENTA_REMU, _
                                          .PE_ID_MONEDA_CUENTA, .PE_NUM_CUENTA, .PE_ID_SEXO, .PE_ID_NACIONALIDAD, _
                                          IIf(.PE_ID_ANEXO_CONTA = 0, DBNull.Value, .PE_ID_ANEXO_CONTA), _
                                          IIf(.PE_ID_GRUPO_SANGUINEO = 0, DBNull.Value, .PE_ID_GRUPO_SANGUINEO), .PE_HORAS_TRABAJO, .PE_DOMICILIADO, _
                                          .PE_ID_TIPO_VIA, .PE_NOMBRE_VIA, .PE_NUMERO_VIA, .PE_INTERIOR, .PE_ID_TIPO_ZONA, _
                                          .PE_NOMBRE_ZONA, .PE_REFERENCIA, LSet(.PE_UBIGEO, 6).Trim, .PE_ID_TIPO_TRABAJADOR, _
                                          IIf(.PE_ID_NIVEL_EDU Is Nothing, DBNull.Value, .PE_ID_NIVEL_EDU), _
                                          IIf(.PE_ID_OCUPACION Is Nothing, DBNull.Value, .PE_ID_OCUPACION), .PE_DISCAPACIDAD, _
                                          IIf(.PE_FEC_INSCRIP_REG_PEN = "", DBNull.Value, .PE_FEC_INSCRIP_REG_PEN), .PE_ID_REGIMEN_LABORAL, _
                                          .PE_SUJETO_JOR_MAX, .PE_SUJETO_REG_ALT, .PE_FEC_ING, _
                                          IIf(.PE_FEC_CESE = "", DBNull.Value, .PE_FEC_CESE), _
                                          IIf(.PE_ID_TIPO_CESE Is Nothing, DBNull.Value, .PE_ID_TIPO_CESE), _
                                          .PE_ID_SCTR_SALUD, .PE_ID_SCTR_PENSION, .PE_SUJETO_HORA_NOC, .PE_OTRO_ING_5TA, _
                                          .PE_ES_SINDICALIZADO, .PE_ID_PERIODO_REMUNERA, .PE_AFILIADO_EPS_SER_PRO, _
                                          IIf(.PE_ID_COD_EPS_SER_PRO = 0, DBNull.Value, .PE_ID_COD_EPS_SER_PRO), _
                                          IIf(.PE_ID_SITUACION_EPS Is Nothing, DBNull.Value, .PE_ID_SITUACION_EPS), .PE_ID_TIPO_PAGO, _
                                          .PE_ID_SITUACION_ESPECIAL, .PE_ID_CLASIFI_PER, .PE_ID_PERSONAL, _
                                          IIf(.PE_ID_AREA = 0, DBNull.Value, .PE_ID_AREA), _
                                          .PE_ASIGNACION_FAM, .PE_NUM_HIJOS, _
                                          IIf(.PE_ID_BANCO_CTS = 0, DBNull.Value, .PE_ID_BANCO_CTS), _
                                          IIf(.PE_ID_TIPO_CUENTA_CTS = 0, DBNull.Value, .PE_ID_TIPO_CUENTA_CTS), _
                                          .PE_NUM_CUENTA_CTS, .PE_ID_MONEDA_CTS, .PE_AFECTO_QUINTA, .PE_FOTO, .PE_ID_EMPRESA, _
                                          .PE_FICHA, .PE_USUARIO, .PE_TERMINAL, .PE_FECREG, _
                                          IIf(.PE_ID_TIPO_PERSO_TARIFA.TT_ID = 0, DBNull.Value, .PE_ID_TIPO_PERSO_TARIFA.TT_ID))
            End With

            If Not Lis_Comunicacion Is Nothing Then
                Dim comuniBL As New BL.PlanillaBL.SG_PL_TB_PERSONA_COMUNICACION
                For Each comunicaiconBE As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION In Lis_Comunicacion
                    comunicaiconBE.PC_ID_PERSONA = Entidad
                    comuniBL.Insert(comunicaiconBE)
                Next
            End If


            If Not Lis_ccostos Is Nothing Then
                Dim ccostoBL As New SG_PL_TB_PERSONAL_CCOSTO
                For Each ccosto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO In Lis_ccostos
                    ccosto.CC_ID_PERSONA = Entidad
                    ccostoBL.Insert(ccosto)
                Next
            End If

            If Not Lis_documentos Is Nothing Then
                Dim docBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
                For Each doc As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS In Lis_documentos
                    doc.DO_ID_PERSONAL = Entidad
                    docBL.Insert(doc)
                Next
            End If

            If Not Lis_contratos Is Nothing Then
                Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
                For Each contrato As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS In Lis_contratos
                    contrato.CO_ID_PERSONAL = Entidad
                    contratoBL.Insert(contrato)
                Next
            End If

            If Not Lis_conceptos Is Nothing Then
                Dim PerConceptoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONCEPTO
                For Each personaConcepto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO In Lis_conceptos
                    personaConcepto.PC_ID_PERSONAL = Entidad
                    PerConceptoBL.Insert(personaConcepto)
                Next
            End If


            Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            anexoBE.AN_IDANEXO = 0
            anexoBE.AN_DESCRIPCION = Entidad.PE_NOM_PRI + " " + Entidad.PE_NOM_SEG + " " + Entidad.PE_APE_PAT + " " + Entidad.PE_APE_MAT
            anexoBE.AN_ES_RELACIONADO = 0
            anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Entidad.PE_ID_EMPRESA}
            anexoBE.AN_NUM_DOC = Entidad.PE_NUM_DOC_PER
            anexoBE.AN_PC_FECREG = Entidad.PE_FECREG
            anexoBE.AN_PC_TERMINAL = Entidad.PE_TERMINAL
            anexoBE.AN_PC_USUARIO = Entidad.PE_USUARIO
            anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Personal}
            anexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = BE.ContabilidadBE.TipoDocPersonal.Dni}
            anexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = BE.ContabilidadBE.TipoEmpresa.Natural}

            Dim query_U_Personal As String = String.Empty
            Dim Id_Anexo_Nuevo As Integer = 0
            Try
                anexoBL.Insert_x_Planillas(anexoBE)
                Id_Anexo_Nuevo = anexoBE.AN_IDANEXO
            Catch ex As Exception
                If ex.Message.Equals("DUPLICADO") Then
                    Dim anexo_tmp As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                    anexo_tmp.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Entidad.PE_ID_EMPRESA}
                    anexo_tmp.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Personal}
                    anexo_tmp.AN_NUM_DOC = Entidad.PE_NUM_DOC_PER
                    anexoBL.getAnexo_x_Ruc(anexo_tmp)
                    Id_Anexo_Nuevo = anexo_tmp.AN_IDANEXO
                    anexo_tmp = Nothing
                End If

            End Try

            query_U_Personal = "UPDATE SG_PL_TB_PERSONAL SET PE_ID_ANEXO_CONTA = " & Id_Anexo_Nuevo & " WHERE PE_ID = " & Entidad.PE_ID.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query_U_Personal)


            anexoBE = Nothing
            anexoBL = Nothing
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal Lis_ccostos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO), ByVal Lis_conceptos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO))
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL", .PE_ID, .PE_CODIGO, .PE_CODIGO_ALT, .PE_ID_TIPO_PER, _
                                          .PE_APE_PAT, .PE_APE_MAT, .PE_NOM_PRI, .PE_NOM_SEG, .PE_ID_TIPO_DOC_PER, _
                                          .PE_NUM_DOC_PER, .PE_FEC_NAC, .PE_ID_EST_CIVIL, _
                                          IIf(.PE_ID_CARGO = 0, DBNull.Value, .PE_ID_CARGO), .PE_NUM_IPSS, _
                                          IIf(.PE_ID_AFP = 0, DBNull.Value, .PE_ID_AFP), .PE_NUM_AFP, .PE_ID_EST_TRABAJADOR, .PE_IMPORTE_REMUNERACION, _
                                          .PE_ID_MONEDA_REMU, .PE_ID_TIPO_REMU, .PE_ID_TIPO_CUENTA_REMU, _
                                          .PE_ID_MONEDA_CUENTA, .PE_NUM_CUENTA, .PE_ID_SEXO, .PE_ID_NACIONALIDAD, _
                                          IIf(.PE_ID_ANEXO_CONTA = 0, DBNull.Value, .PE_ID_ANEXO_CONTA), _
                                          IIf(.PE_ID_GRUPO_SANGUINEO = 0, DBNull.Value, .PE_ID_GRUPO_SANGUINEO), .PE_HORAS_TRABAJO, .PE_DOMICILIADO, _
                                          .PE_ID_TIPO_VIA, .PE_NOMBRE_VIA, .PE_NUMERO_VIA, .PE_INTERIOR, .PE_ID_TIPO_ZONA, _
                                          .PE_NOMBRE_ZONA, .PE_REFERENCIA, LSet(.PE_UBIGEO, 6).Trim, .PE_ID_TIPO_TRABAJADOR, _
                                          IIf(.PE_ID_NIVEL_EDU Is Nothing, DBNull.Value, .PE_ID_NIVEL_EDU), _
                                          IIf(.PE_ID_OCUPACION Is Nothing, DBNull.Value, .PE_ID_OCUPACION), .PE_DISCAPACIDAD, _
                                          IIf(.PE_FEC_INSCRIP_REG_PEN = "", DBNull.Value, .PE_FEC_INSCRIP_REG_PEN), .PE_ID_REGIMEN_LABORAL, _
                                          .PE_SUJETO_JOR_MAX, .PE_SUJETO_REG_ALT, .PE_FEC_ING, _
                                          IIf(.PE_FEC_CESE = "", DBNull.Value, .PE_FEC_CESE), _
                                          IIf(.PE_ID_TIPO_CESE Is Nothing, DBNull.Value, .PE_ID_TIPO_CESE), _
                                          .PE_ID_SCTR_SALUD, .PE_ID_SCTR_PENSION, .PE_SUJETO_HORA_NOC, .PE_OTRO_ING_5TA, _
                                          .PE_ES_SINDICALIZADO, .PE_ID_PERIODO_REMUNERA, .PE_AFILIADO_EPS_SER_PRO, _
                                          IIf(.PE_ID_COD_EPS_SER_PRO = 0, DBNull.Value, .PE_ID_COD_EPS_SER_PRO), _
                                          IIf(.PE_ID_SITUACION_EPS Is Nothing, DBNull.Value, .PE_ID_SITUACION_EPS), .PE_ID_TIPO_PAGO, _
                                          .PE_ID_SITUACION_ESPECIAL, .PE_ID_CLASIFI_PER, .PE_ID_PERSONAL, _
                                          IIf(.PE_ID_AREA = 0, DBNull.Value, .PE_ID_AREA), _
                                          .PE_ASIGNACION_FAM, .PE_NUM_HIJOS, _
                                          IIf(.PE_ID_BANCO_CTS = 0, DBNull.Value, .PE_ID_BANCO_CTS), _
                                          IIf(.PE_ID_TIPO_CUENTA_CTS = 0, DBNull.Value, .PE_ID_TIPO_CUENTA_CTS), _
                                          .PE_NUM_CUENTA_CTS, .PE_ID_MONEDA_CTS, .PE_AFECTO_QUINTA, .PE_FOTO, .PE_ID_EMPRESA, _
                                          .PE_FICHA, .PE_USUARIO, .PE_TERMINAL, .PE_FECREG, .PE_ID_TIPO_PERSO_TARIFA.TT_ID)
            End With

            If Not Lis_ccostos Is Nothing Then
                Dim ccostoBL As New SG_PL_TB_PERSONAL_CCOSTO
                For Each ccosto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO In Lis_ccostos
                    ccosto.CC_ID_PERSONA = Entidad
                    ccostoBL.Update(ccosto)
                Next
            End If


            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "DELETE FROM SG_PL_TB_PERSONAL_CONCEPTO WHERE PC_ID_PERSONAL = " & Entidad.PE_ID.ToString & " AND PC_ID_EMPRESA = " & Entidad.PE_ID_EMPRESA.ToString)

            If Not Lis_conceptos Is Nothing Then
                Dim PerConceptoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONCEPTO
                For Each personaConcepto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO In Lis_conceptos
                    personaConcepto.PC_ID_PERSONAL = Entidad
                    PerConceptoBL.Insert(personaConcepto)
                Next
            End If


        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL", .PE_ID)
            End With
        End Sub

        Public Function getPersonal(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL", Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_x_Tipo(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_X_TIPO", Entidad.PE_ID_TIPO_PER, Entidad.PE_AFECTO_QUINTA, Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Sub getPersonal_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSONAL_BY_ID", Entidad.PE_ID, Entidad.PE_ID_EMPRESA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .PE_ID = drr("PE_ID")
                    .PE_CODIGO = drr("PE_CODIGO")
                    .PE_CODIGO_ALT = drr("PE_CODIGO_ALT")
                    .PE_ID_TIPO_PER = drr("PE_ID_TIPO_PER")
                    .PE_APE_PAT = drr("PE_APE_PAT")
                    .PE_APE_MAT = drr("PE_APE_MAT")
                    .PE_NOM_PRI = drr("PE_NOM_PRI")
                    .PE_NOM_SEG = drr("PE_NOM_SEG")
                    .PE_ID_TIPO_DOC_PER = drr("PE_ID_TIPO_DOC_PER")
                    .PE_NUM_DOC_PER = drr("PE_NUM_DOC_PER")
                    .PE_FEC_NAC = drr("PE_FEC_NAC")
                    .PE_ID_EST_CIVIL = drr("PE_ID_EST_CIVIL")
                    .PE_ID_CARGO = Val(drr("PE_ID_CARGO").ToString)
                    .PE_NUM_IPSS = drr("PE_NUM_IPSS")
                    .PE_ID_AFP = Val(drr("PE_ID_AFP").ToString)
                    .PE_NUM_AFP = drr("PE_NUM_AFP")
                    .PE_ID_EST_TRABAJADOR = drr("PE_ID_EST_TRABAJADOR")
                    .PE_IMPORTE_REMUNERACION = drr("PE_IMPORTE_REMUNERACION")
                    .PE_ID_MONEDA_REMU = drr("PE_ID_MONEDA_REMU")
                    .PE_ID_TIPO_REMU = drr("PE_ID_TIPO_REMU")
                    .PE_ID_TIPO_CUENTA_REMU = drr("PE_ID_TIPO_CUENTA_REMU")
                    .PE_ID_MONEDA_CUENTA = drr("PE_ID_MONEDA_CUENTA")
                    .PE_NUM_CUENTA = drr("PE_NUM_CUENTA")
                    .PE_ID_SEXO = drr("PE_ID_SEXO")
                    .PE_ID_NACIONALIDAD = drr("PE_ID_NACIONALIDAD")
                    .PE_ID_ANEXO_CONTA = drr("PE_ID_ANEXO_CONTA")
                    .PE_ID_GRUPO_SANGUINEO = Val(drr("PE_ID_GRUPO_SANGUINEO").ToString)
                    .PE_HORAS_TRABAJO = drr("PE_HORAS_TRABAJO")
                    .PE_DOMICILIADO = drr("PE_DOMICILIADO")
                    .PE_ID_TIPO_VIA = drr("PE_ID_TIPO_VIA")
                    .PE_NOMBRE_VIA = drr("PE_NOMBRE_VIA")
                    .PE_NUMERO_VIA = drr("PE_NUMERO_VIA")
                    .PE_INTERIOR = drr("PE_INTERIOR")
                    .PE_ID_TIPO_ZONA = drr("PE_ID_TIPO_ZONA")
                    .PE_NOMBRE_ZONA = drr("PE_NOMBRE_ZONA")
                    .PE_REFERENCIA = drr("PE_REFERENCIA")
                    .PE_UBIGEO = drr("PE_UBIGEO")
                    .PE_ID_TIPO_TRABAJADOR = drr("PE_ID_TIPO_TRABAJADOR")
                    .PE_ID_NIVEL_EDU = Val(drr("PE_ID_NIVEL_EDU").ToString)
                    .PE_ID_OCUPACION = Val(drr("PE_ID_OCUPACION").ToString)
                    .PE_DISCAPACIDAD = drr("PE_DISCAPACIDAD")
                    .PE_FEC_INSCRIP_REG_PEN = drr("PE_FEC_INSCRIP_REG_PEN").ToString
                    .PE_ID_REGIMEN_LABORAL = drr("PE_ID_REGIMEN_LABORAL")
                    .PE_SUJETO_JOR_MAX = drr("PE_SUJETO_JOR_MAX")
                    .PE_SUJETO_REG_ALT = drr("PE_SUJETO_REG_ALT")
                    .PE_FEC_ING = drr("PE_FEC_ING")
                    .PE_FEC_CESE = drr("PE_FEC_CESE").ToString
                    .PE_ID_TIPO_CESE = drr("PE_ID_TIPO_CESE").ToString
                    .PE_ID_SCTR_SALUD = drr("PE_ID_SCTR_SALUD")
                    .PE_ID_SCTR_PENSION = drr("PE_ID_SCTR_PENSION")
                    .PE_SUJETO_HORA_NOC = drr("PE_SUJETO_HORA_NOC")
                    .PE_OTRO_ING_5TA = drr("PE_OTRO_ING_5TA")
                    .PE_ES_SINDICALIZADO = drr("PE_ES_SINDICALIZADO")
                    .PE_ID_PERIODO_REMUNERA = drr("PE_ID_PERIODO_REMUNERA")
                    .PE_AFILIADO_EPS_SER_PRO = drr("PE_AFILIADO_EPS_SER_PRO")
                    .PE_ID_COD_EPS_SER_PRO = Val(drr("PE_ID_COD_EPS_SER_PRO").ToString)
                    .PE_ID_SITUACION_EPS = Val(drr("PE_ID_SITUACION_EPS").ToString)
                    .PE_ID_TIPO_PAGO = drr("PE_ID_TIPO_PAGO")
                    .PE_ID_SITUACION_ESPECIAL = drr("PE_ID_SITUACION_ESPECIAL")
                    .PE_ID_CLASIFI_PER = drr("PE_ID_CLASIFI_PER")
                    .PE_ID_PERSONAL = drr("PE_ID_PERSONAL")
                    .PE_ID_AREA = Val(drr("PE_ID_AREA").ToString)
                    .PE_ASIGNACION_FAM = drr("PE_ASIGNACION_FAM")
                    .PE_NUM_HIJOS = drr("PE_NUM_HIJOS")
                    .PE_ID_BANCO_CTS = Val(drr("PE_ID_BANCO_CTS").ToString)
                    .PE_ID_TIPO_CUENTA_CTS = Val(drr("PE_ID_TIPO_CUENTA_CTS").ToString)
                    .PE_NUM_CUENTA_CTS = drr("PE_NUM_CUENTA_CTS")
                    .PE_ID_MONEDA_CTS = drr("PE_ID_MONEDA_CTS")
                    .PE_AFECTO_QUINTA = drr("PE_AFECTO_QUINTA")
                    .PE_FOTO = drr("PE_FOTO")
                    .PE_ID_EMPRESA = drr("PE_ID_EMPRESA")
                    .PE_FICHA = drr("PE_FICHA")
                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub

        Public Sub getPersonal_x_Codigo(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSONAL_BY_COD", Entidad.PE_CODIGO, Entidad.PE_ID_EMPRESA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .PE_ID = drr("PE_ID")
                    .PE_CODIGO = drr("PE_CODIGO")
                    .PE_CODIGO_ALT = drr("PE_CODIGO_ALT")
                    .PE_ID_TIPO_PER = drr("PE_ID_TIPO_PER")
                    .PE_APE_PAT = drr("PE_APE_PAT")
                    .PE_APE_MAT = drr("PE_APE_MAT")
                    .PE_NOM_PRI = drr("PE_NOM_PRI")
                    .PE_NOM_SEG = drr("PE_NOM_SEG")
                    .PE_ID_TIPO_DOC_PER = drr("PE_ID_TIPO_DOC_PER")
                    .PE_NUM_DOC_PER = drr("PE_NUM_DOC_PER")
                    .PE_FEC_NAC = drr("PE_FEC_NAC")
                    .PE_ID_EST_CIVIL = drr("PE_ID_EST_CIVIL")
                    .PE_ID_CARGO = Val(drr("PE_ID_CARGO").ToString)
                    .PE_NUM_IPSS = drr("PE_NUM_IPSS")
                    .PE_ID_AFP = Val(drr("PE_ID_AFP").ToString)
                    .PE_NUM_AFP = drr("PE_NUM_AFP")
                    .PE_ID_EST_TRABAJADOR = drr("PE_ID_EST_TRABAJADOR")
                    .PE_IMPORTE_REMUNERACION = drr("PE_IMPORTE_REMUNERACION")
                    .PE_ID_MONEDA_REMU = drr("PE_ID_MONEDA_REMU")
                    .PE_ID_TIPO_REMU = drr("PE_ID_TIPO_REMU")
                    .PE_ID_TIPO_CUENTA_REMU = drr("PE_ID_TIPO_CUENTA_REMU")
                    .PE_ID_MONEDA_CUENTA = drr("PE_ID_MONEDA_CUENTA")
                    .PE_NUM_CUENTA = drr("PE_NUM_CUENTA")
                    .PE_ID_SEXO = drr("PE_ID_SEXO")
                    .PE_ID_NACIONALIDAD = drr("PE_ID_NACIONALIDAD")
                    .PE_ID_ANEXO_CONTA = drr("PE_ID_ANEXO_CONTA")
                    .PE_ID_GRUPO_SANGUINEO = Val(drr("PE_ID_GRUPO_SANGUINEO").ToString)
                    .PE_HORAS_TRABAJO = drr("PE_HORAS_TRABAJO")
                    .PE_DOMICILIADO = drr("PE_DOMICILIADO")
                    .PE_ID_TIPO_VIA = drr("PE_ID_TIPO_VIA")
                    .PE_NOMBRE_VIA = drr("PE_NOMBRE_VIA")
                    .PE_NUMERO_VIA = drr("PE_NUMERO_VIA")
                    .PE_INTERIOR = drr("PE_INTERIOR")
                    .PE_ID_TIPO_ZONA = drr("PE_ID_TIPO_ZONA")
                    .PE_NOMBRE_ZONA = drr("PE_NOMBRE_ZONA")
                    .PE_REFERENCIA = drr("PE_REFERENCIA")
                    .PE_UBIGEO = drr("PE_UBIGEO")
                    .PE_ID_TIPO_TRABAJADOR = drr("PE_ID_TIPO_TRABAJADOR")
                    .PE_ID_NIVEL_EDU = Val(drr("PE_ID_NIVEL_EDU").ToString)
                    .PE_ID_OCUPACION = Val(drr("PE_ID_OCUPACION").ToString)
                    .PE_DISCAPACIDAD = drr("PE_DISCAPACIDAD")
                    .PE_FEC_INSCRIP_REG_PEN = drr("PE_FEC_INSCRIP_REG_PEN").ToString
                    .PE_ID_REGIMEN_LABORAL = drr("PE_ID_REGIMEN_LABORAL")
                    .PE_SUJETO_JOR_MAX = drr("PE_SUJETO_JOR_MAX")
                    .PE_SUJETO_REG_ALT = drr("PE_SUJETO_REG_ALT")
                    .PE_FEC_ING = drr("PE_FEC_ING")
                    .PE_FEC_CESE = drr("PE_FEC_CESE").ToString
                    .PE_ID_TIPO_CESE = drr("PE_ID_TIPO_CESE").ToString
                    .PE_ID_SCTR_SALUD = drr("PE_ID_SCTR_SALUD")
                    .PE_ID_SCTR_PENSION = drr("PE_ID_SCTR_PENSION")
                    .PE_SUJETO_HORA_NOC = drr("PE_SUJETO_HORA_NOC")
                    .PE_OTRO_ING_5TA = drr("PE_OTRO_ING_5TA")
                    .PE_ES_SINDICALIZADO = drr("PE_ES_SINDICALIZADO")
                    .PE_ID_PERIODO_REMUNERA = drr("PE_ID_PERIODO_REMUNERA")
                    .PE_AFILIADO_EPS_SER_PRO = drr("PE_AFILIADO_EPS_SER_PRO")
                    .PE_ID_COD_EPS_SER_PRO = Val(drr("PE_ID_COD_EPS_SER_PRO").ToString)
                    .PE_ID_SITUACION_EPS = Val(drr("PE_ID_SITUACION_EPS").ToString)
                    .PE_ID_TIPO_PAGO = drr("PE_ID_TIPO_PAGO")
                    .PE_ID_SITUACION_ESPECIAL = drr("PE_ID_SITUACION_ESPECIAL")
                    .PE_ID_CLASIFI_PER = drr("PE_ID_CLASIFI_PER")
                    .PE_ID_PERSONAL = drr("PE_ID_PERSONAL")
                    .PE_ID_AREA = Val(drr("PE_ID_AREA").ToString)
                    .PE_ASIGNACION_FAM = drr("PE_ASIGNACION_FAM")
                    .PE_NUM_HIJOS = drr("PE_NUM_HIJOS")
                    .PE_ID_BANCO_CTS = Val(drr("PE_ID_BANCO_CTS").ToString)
                    .PE_ID_TIPO_CUENTA_CTS = Val(drr("PE_ID_TIPO_CUENTA_CTS").ToString)
                    .PE_NUM_CUENTA_CTS = drr("PE_NUM_CUENTA_CTS")
                    .PE_ID_MONEDA_CTS = drr("PE_ID_MONEDA_CTS")
                    .PE_AFECTO_QUINTA = drr("PE_AFECTO_QUINTA")
                    .PE_FOTO = drr("PE_FOTO")
                    .PE_ID_EMPRESA = drr("PE_ID_EMPRESA")
                    .PE_FICHA = drr("PE_FICHA")
                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub

        Public Function get_Nuevo_Codigo_Personal(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As String
            Dim codigo_tmp As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULTIMO_COD_PER", Empresa.EM_ID)
            codigo_tmp = codigo_tmp.PadLeft(5, "0")
            Return codigo_tmp
        End Function


    End Class


End Class
