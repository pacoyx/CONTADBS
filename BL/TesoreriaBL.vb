Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class TesoreriaBL

    Public Class SG_TE_TB_CONCEPTOS_MOV_LISTAS
        Inherits ClsBD

        Public Function getListas(ByVal Entidad As BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV_LISTAS) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_TE_SP_S_CONCEP_LISTAS_BYID", Entidad.CL_IDCONCEPTO).Tables(0)
        End Function
    End Class

    Public Class SG_TE_TB_MOVIMIENTOS
        Inherits ClsBD

        Public Sub Insert_Egreso(ByVal Ent_Cabecera As BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_C, ByVal Ent_Detalles As List(Of BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_D))

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                Dim Int_IdCabecera As Integer = 0
                With Ent_Cabecera
                    Int_IdCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_TE_SP_I_MOVIMIENTO_C", .MC_ANEXO.AN_IDANEXO, _
                                      .MC_IDCONCEPTO.CM_ID, .MC_ID_COMPRO.DO_CODIGO, .MC_SER_COMPRO, _
                                      .MC_NUM_COMPRO, .MC_FECHA, .MC_TIPCAMBIO, .MC_COMENTARIO, _
                                      .MC_IDCENCOS, .MC_IDMONEDA.MO_CODIGO, .MC_MEDIOPAGO.MP_CODIGO, _
                                      .MC_PC_USUARIO, .MC_PC_TERMINAL, .MC_PC_FECREG, .MC_IDEMPRESA.EM_ID, _
                                      .MC_CUENTA_CORRI.BC_ID_CTA, .MC_IMPORTE)
                End With


                For Each item As BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_D In Ent_Detalles
                    With item

                        SqlHelper.ExecuteNonQuery(TRvar, "SG_TE_SP_I_MOVIMIENTO_D", Int_IdCabecera, .MD_SECUENCIA, _
                                                  .MD_TIP_DOC.DO_CODIGO, .MD_SER_DOC, .MD_NUM_DOC, .MD_FEC_DOC, _
                                                  .MD_IMPORTE, .MD_COMENTARIO, .MD_ES_CONCI, .MD_ANHO_CONI, _
                                                  .MD_MES_CONCI)

                    End With
                Next



                Dim MiContaBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim Asiento_Cab As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Asiento_Det As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                Dim Lista_Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de subdiario por el concepto
                Dim Subdiario As String = "05"
                Dim ConceptoBL As New BL.TesoreriaBL.SG_TE_TB_CONCEPTOS_MOV
                Dim ConceptoBE As New BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV
                Dim Dt_conceptos As DataTable = Nothing
                ConceptoBE.CM_IDTIPO_MOV = New BE.TesoreriaBE.SG_TE_TB_TIPO_MOVIMIENTO With {.TM_ID = 2}
                ConceptoBE.CM_IDEMPRESA = Ent_Cabecera.MC_IDEMPRESA
                Dt_conceptos = ConceptoBL.getConceptos(ConceptoBE)

                For j As Integer = 0 To Dt_conceptos.Rows.Count - 1
                    If Dt_conceptos.Rows(j)("CM_ID") = Ent_Cabecera.MC_IDCONCEPTO.CM_ID Then
                        Subdiario = Dt_conceptos.Rows(j)("CM_IDSUBDIARIO")
                        Exit For
                    End If
                Next

                Dt_conceptos.Dispose()
                ConceptoBE = Nothing
                ConceptoBL = Nothing

                'buscamos la cuenta por el codigo ID de la cuenta corriente, luego buscamos la cuenta contable por el ID de la Cuenta
                Dim Str_CuentaContableCaja As String = String.Empty
                Dim CtaCteBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CTACTE
                Dim CtaCteBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE
                CtaCteBE.BC_ID_CTA = Ent_Cabecera.MC_CUENTA_CORRI.BC_ID_CTA
                CtaCteBL.getCtasCorriente(CtaCteBE)

                'buscamos la cuenta por el ID cuenta amarrada a la cuenta corriente
                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                PlanCtasBE.PC_IDCUENTA = CtaCteBE.BC_IDCUENTA.PC_IDCUENTA
                PlanCtasBL.getCuenta(PlanCtasBE)
                Str_CuentaContableCaja = PlanCtasBE.PC_NUM_CUENTA

                PlanCtasBL = Nothing
                PlanCtasBE = Nothing
                CtaCteBL = Nothing
                CtaCteBE = Nothing


                'cargamos la entidad de cabecera de asiento
                With Asiento_Cab
                    .AC_ID = 0
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = Subdiario}
                    .AC_NUM_VOUCHER = Str_CuentaContableCaja
                    .AC_ANHO = CDate(Ent_Cabecera.MC_FECHA).Year
                    .AC_MES = CDate(Ent_Cabecera.MC_FECHA).Month
                    .AC_FEC_VOUCHER = CDate(Ent_Cabecera.MC_FECHA).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Ent_Cabecera.MC_IMPORTE
                    .AC_HABER = Ent_Cabecera.MC_IMPORTE
                    .AC_TC_OPE = Ent_Cabecera.MC_TIPCAMBIO
                    .AC_TC_ESPECIAL = 0

                    .AC_ESTADO = 1
                    .AC_GLOSA_VOU = Ent_Cabecera.MC_COMENTARIO
                    .AC_ES_INTERFACE = 3
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Ent_Cabecera.MC_PC_USUARIO
                    .AC_TERMINAL = Ent_Cabecera.MC_PC_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Ent_Cabecera.MC_IDEMPRESA
                End With


                'cargamos la entidad de detalles en una lista
                'Agregamos la primera fila al asiento
                'cuenta 104
                Asiento_Det = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With Asiento_Det
                    .AD_IDCAB = Asiento_Cab
                    .AD_SECUENCIA = 1
                    .AD_CUENTA = Str_CuentaContableCaja
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Ent_Cabecera.MC_ID_COMPRO
                    .AD_SDOC = Ent_Cabecera.MC_SER_COMPRO
                    .AD_NDOC = Ent_Cabecera.MC_NUM_COMPRO
                    .AD_FDOC = Ent_Cabecera.MC_FECHA
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = Ent_Cabecera.MC_IMPORTE
                    .AD_MONTO_ORI = Ent_Cabecera.MC_IMPORTE_ORI
                    .AD_PORCE_DESTINO = 0

                    If Ent_Cabecera.MC_IDMONEDA.MO_CODIGO = 1 Then
                        .AD_TCAM = 0
                    Else
                        .AD_TCAM = Ent_Cabecera.MC_TIPCAMBIO
                    End If

                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Ent_Cabecera.MC_COMENTARIO
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Ent_Cabecera.MC_PC_USUARIO
                    .AD_TERMINAL = Ent_Cabecera.MC_PC_TERMINAL
                    .AD_FECREG = Ent_Cabecera.MC_PC_FECREG
                    .AD_IDMEDIOPAGO = Ent_Cabecera.MC_MEDIOPAGO
                End With
                Lista_Detalles.Add(Asiento_Det)

                'luego agregamos las demas cuentas, una cuenta por cada factura
                Dim i As Integer = 2
                For Each item As BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_D In Ent_Detalles
                    Asiento_Det = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                    With Asiento_Det

                        .AD_IDCAB = Asiento_Cab
                        .AD_SECUENCIA = i.ToString
                        .AD_CUENTA = item.MD_CUENTA
                        .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Ent_Cabecera.MC_ID_TIPOANEXO}
                        .AD_IDANEXO = Ent_Cabecera.MC_ANEXO
                        .AD_TDOC = item.MD_TIP_DOC
                        .AD_SDOC = item.MD_SER_DOC
                        .AD_NDOC = item.MD_NUM_DOC
                        .AD_FDOC = item.MD_FEC_DOC
                        .AD_VDOC = String.Empty
                        .AD_DEBE = item.MD_IMPORTE
                        .AD_HABER = 0
                        .AD_MONTO_ORI = IIf(item.MD_TC = 0, item.MD_IMPORTE, item.MD_IMPORTE_ORI)
                        .AD_PORCE_DESTINO = 0
                        .AD_TCAM = item.MD_TC
                        .AD_SEC_ORI_DESTINO = 0
                        .AD_GLOSA = item.MD_COMENTARIO
                        .AD_IDCC = Nothing
                        .AD_ES_DESTINO = 0
                        .AD_USUARIO = Ent_Cabecera.MC_PC_USUARIO
                        .AD_TERMINAL = Ent_Cabecera.MC_PC_TERMINAL
                        .AD_FECREG = Ent_Cabecera.MC_PC_FECREG
                        .AD_IDMEDIOPAGO = Nothing
                    End With
                    Lista_Detalles.Add(Asiento_Det)
                    i += 1
                Next
                Dim Str_Num_Voucher As String = String.Empty
                MiContaBL.Insert_Bancos(Asiento_Cab, Lista_Detalles, Str_Num_Voucher, False)

                'actualizamos el campo de cabecera de movimiento(egresos)
                Dim Query As String = String.Format("UPDATE SG_TE_TB_MOVIMIENTO_C SET MC_IDCAB_CONTA = {0}, MC_NUM_VOU_CONTA = {1} WHERE MC_ID = {2}", Asiento_Cab.AC_ID, Str_Num_Voucher, Int_IdCabecera)
                SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, Query)



                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

        End Sub

    End Class

    Public Class SG_TE_TB_MOVIMIENTO_C
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_C)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_TE_SP_I_MOVIMIENTO_C", .MC_ANEXO.AN_IDANEXO, _
                                          .MC_IDCONCEPTO.CM_ID, .MC_ID_COMPRO.DO_CODIGO, .MC_SER_COMPRO, _
                                          .MC_NUM_COMPRO, .MC_FECHA, .MC_TIPCAMBIO, .MC_COMENTARIO, _
                                          .MC_IDCENCOS, .MC_IDMONEDA.MO_CODIGO, .MC_MEDIOPAGO.MP_CODIGO, _
                                          .MC_PC_USUARIO, .MC_PC_TERMINAL, .MC_PC_FECREG, .MC_IDEMPRESA.EM_ID, _
                                           .MC_CUENTA_CORRI.BC_ID_CTA)
            End With
        End Sub

    End Class

    Public Class SG_TE_TB_MOVIMIENTO_D



    End Class

    Public Class SG_TE_TB_CONCEPTOS_MOV
        Inherits ClsBD

        Public Function getConceptos(ByVal Entidad As BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_TE_SP_S_CONCEPTOS_MOV_X_TIPO", Entidad.CM_IDTIPO_MOV.TM_ID, Entidad.CM_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub getConceptos_x_Id(ByRef Entidad As BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV)

            With Entidad
                Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_TE_SP_S_CONCEPTOS_BYID", Entidad.CM_ID)
                If drr.HasRows Then
                    drr.Read()
                    .CM_DESCRIPCION = drr("CM_DESCRIPCION")
                    .CM_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = drr("CM_IDSUBDIARIO")}
                    .CM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = drr("CM_IDEMPRESA")}
                    .CM_IDTIPO_MOV = New BE.TesoreriaBE.SG_TE_TB_TIPO_MOVIMIENTO With {.TM_ID = drr("CM_IDTIPO_MOV")}
                    .CM_ES_DETALLE = drr("CM_ES_DETALLE")
                    .CM_ES_DOCUMENTO = drr("CM_ES_DOCUMENTO")
                    .CM_CUENTA_CONTA = drr("CM_CUENTA_CONTA").ToString
                End If
                drr.Close()
            End With

        End Sub

        Public Sub Insert()

        End Sub

        Public Sub Update()

        End Sub

        Public Sub Delete()

        End Sub


    End Class

End Class
