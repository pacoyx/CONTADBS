Public Class CO_PR_Apertura_Tmp

    Private Sub CO_PR_Apertura_Tmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year
        ume_fecha.Value = "01/01/" & gDat_Fecha_Sis.Year.ToString

        Call Cargar_Asiento_temporal()
        Call Cargar_Subdiario_Apertura()
        Call Formatear_Grilla_Selector(ug_asiento_tmp)
    End Sub

    Private Sub Cargar_Asiento_temporal()
        Dim cierreBL As New BL.ContabilidadBL.SG_CO_TB_CTAS_CIERRE
        Dim cierreBE As New BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE
        Dim dt_tmp As DataTable = Nothing

        cierreBE.CC_IDEMPRESA = gInt_IdEmpresa
        cierreBE.CC_ANHO = (CInt(une_Ayo.Value) - 1)
        dt_tmp = cierreBL.Generar_Apertura_Temporal(cierreBE)
        ug_asiento_tmp.DataSource = dt_tmp

        ume_tot_d.Value = dt_tmp.Compute("sum(debe)", "")
        ume_tot_h.Value = dt_tmp.Compute("sum(haber)", "")

        cierreBE = Nothing
        cierreBL = Nothing
    End Sub

    Private Sub Cargar_Subdiario_Apertura()
        Dim subdiarioBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        txt_subdiario.Text = subdiarioBL.get_Subdiario_Apertura(gInt_IdEmpresa)
        subdiarioBL = Nothing
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Generar_Asiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Generar_Asiento.Click
        If ume_fecha.Value Is Nothing Then
            Avisar("Ingrese la fecha del Voucher")
            ume_fecha.Focus()
            Exit Sub
        End If

        If txt_subdiario.Text.Trim.Length = 0 Then
            Avisar("El subdiario de Apertura no esta establecido, Verifique!")
            txt_subdiario.Focus()
            Exit Sub
        End If


        '
        If Preguntar("Seguro de generar el Asiento de Apertura?") Then

            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim cabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim str_subdiario_Ape As String = txt_subdiario.Text.Substring(0, 2).Trim
            Dim dbl_tipoCambio_Cierre As Double = 0

            With cabeceraBE
                .AC_ID = 0
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = str_subdiario_Ape}
                .AC_NUM_VOUCHER = String.Empty
                .AC_ANHO = CDate(ume_fecha.Value).Year
                .AC_MES = CDate(ume_fecha.Value).Month
                .AC_FEC_VOUCHER = CDate(ume_fecha.Value).ToShortDateString
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                .AC_DEBE = ume_tot_d.Value
                .AC_HABER = ume_tot_h.Value
                .AC_TC_OPE = dbl_tipoCambio_Cierre
                .AC_TC_ESPECIAL = 0
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = "Apertura de Ejercicio " & une_Ayo.Value.ToString
                .AC_ES_INTERFACE = 0
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Date.Now
                .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With


            '_______________________________
            'Grabamos los detalles en la coleccion de detalles
            'Grabamos todos os datos:
            '
            '
            '

            Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            For i As Integer = 0 To ug_asiento_tmp.Rows.Count - 1
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = cabeceraBE
                    .AD_SECUENCIA = (i + 1).ToString.PadLeft(3, "0")
                    .AD_CUENTA = ug_asiento_tmp.Rows(i).Cells("AD_CUENTA").Value.ToString


                    Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                    Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                    PlanCtasBE.PC_PERIODO = CDate(ume_fecha.Value).Year
                    PlanCtasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    PlanCtasBE.PC_NUM_CUENTA = .AD_CUENTA
                    PlanCtasBL.getCuenta_X_NumeroCta(PlanCtasBE)

                    Dim Int_TipoAnexo_Local As Integer = 0
                    If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                        Int_TipoAnexo_Local = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO
                    End If

                    If Int_TipoAnexo_Local <> 0 Then
                        .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo_Local}
                    Else
                        .AD_TANEXO = Nothing
                    End If

                    PlanCtasBE = Nothing
                    PlanCtasBL = Nothing

                    If ug_asiento_tmp.Rows(i).Cells("AD_IDANEXO").Value.ToString <> "" Then
                        .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = ug_asiento_tmp.Rows(i).Cells("AD_IDANEXO").Value.ToString}
                    Else
                        .AD_IDANEXO = Nothing
                    End If

                    If ug_asiento_tmp.Rows(i).Cells("AD_TDOC").Value.ToString <> "" Then
                        .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_asiento_tmp.Rows(i).Cells("AD_TDOC").Value.ToString}
                    Else
                        .AD_TDOC = Nothing
                    End If

                    .AD_SDOC = ug_asiento_tmp.Rows(i).Cells("AD_SDOC").Value.ToString
                    .AD_NDOC = ug_asiento_tmp.Rows(i).Cells("AD_NDOC").Value.ToString
                    .AD_FDOC = ""
                    .AD_VDOC = ""

                    If Val(ug_asiento_tmp.Rows(i).Cells("DEBE").Value) > 0 Then
                        .AD_DEBE = ug_asiento_tmp.Rows(i).Cells("DEBE").Value
                    Else
                        .AD_DEBE = 0
                    End If

                    If Val(ug_asiento_tmp.Rows(i).Cells("HABER").Value) > 0 Then
                        .AD_HABER = ug_asiento_tmp.Rows(i).Cells("HABER").Value
                    Else
                        .AD_HABER = 0
                    End If


                    If Val(ug_asiento_tmp.Rows(i).Cells("DEBE").Value.ToString) > 0 Then
                        If ug_asiento_tmp.Rows(i).Cells("DEBE").Value.ToString = "" Then
                            .AD_MONTO_ORI = 0
                        Else
                            .AD_MONTO_ORI = ug_asiento_tmp.Rows(i).Cells("DEBE").Value
                        End If

                    Else
                        If ug_asiento_tmp.Rows(i).Cells("HABER").Value.ToString = "" Then
                            .AD_MONTO_ORI = 0
                        Else
                            .AD_MONTO_ORI = ug_asiento_tmp.Rows(i).Cells("HABER").Value
                        End If
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = 0

                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = "Apertura de Ejercicio " & une_Ayo.Value.ToString
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                End With
                Detalles.Add(E_Detalle)
            Next

            Dim Str_NumVoucher As String = String.Empty
            asientoBL.Insert_Generales(cabeceraBE, Detalles, Str_NumVoucher, False)

            Call Avisar("Listo!")

            asientoBL = Nothing
        End If
    End Sub
End Class