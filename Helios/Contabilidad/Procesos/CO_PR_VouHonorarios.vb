Imports BE.ContabilidadBE

Public Class CO_PR_VouHonorarios

    Dim Obj_Voucher As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE

    Dim Str_Mon_Nac As Integer = 1
    Dim Bol_NuevoDet As Boolean
    Dim Bol_Edicion As Boolean = False
    Dim Bol_Copy As Boolean = False
    Dim Int_IdCab_Edit As Integer = 0
    Dim BYTFormatContable As Integer = 2
    Dim Int_TipoAnexo As Integer = 0
    Dim cuenta42 As String
    Dim cuenta42_relacionada As String


    Private Sub CO_PR_VouHonorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Bol_EstaCerrado As Boolean = False
        Call Verificar_Mes_Cerrado(Me, gDat_Fecha_Sis.Year, gDat_Fecha_Sis.Month, Bol_EstaCerrado)

        If Not Bol_EstaCerrado Then
            Call Cargar_Cmb_SubDiario()
            Call Cargar_Cmb_Monedas()
            Call Cargar_Documentos()
            Call Cargar_Combo_CC()
            Call Cargar_TipoCambioFormato()
            Call Limpiar_Controls_InGroupox(ugb_Cabecera)
            Call Cargar_Cuentas_Combo()

            Call Iniciar_Formulario()

            Call Cargar_Tasas_Impuestos()
            Call Formatear_Grilla_Selector(ug_asiento)
            Call Ocultar_Columnas(True)

            Call Cargar_Marcadores()

            txt_Num_Voucher.ReadOnly = False

            Try
                udte_fec_Vou.Value = ""
            Catch ex As Exception

            End Try

            uce_Subdiario.SelectedIndex = 0

        End If
        ubtn_Salir.Enabled = True
    End Sub

    Private Sub Cargar_Cuentas_Anexo()

        Dim plantillaBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_DET
        Dim autoCabBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB
        Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
        autoCabBE.AA_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = uce_Subdiario.Value}
        autoCabBE.AA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        autoCabBE.AA_ANHO = gDat_Fecha_Sis.Year
        lista = plantillaBL.getDetalles_x_Sudiario(autoCabBE, 1)

        For Each detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET In lista
            If detalle.AA_IDCONPCETO.CR_ID = 5 Then
                cuenta42 = detalle.AA_IDCUENTA.PC_NUM_CUENTA
                cuenta42_relacionada = detalle.AA_IDCUENTA_R.PC_NUM_CUENTA
            End If
        Next

        autoCabBE = Nothing
        plantillaBL = Nothing
        lista = Nothing

    End Sub

    Private Sub Cargar_Marcadores()

        'Inicializa algunos controles de acuerdo a la configuracion del sistema.

        Dim ParametrosBL As New BL.ContabilidadBL.SG_CO_TB_PARAMETROSGENERALES
        Dim ParametrosBE As New BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES
        Dim dt_para As DataTable = ParametrosBL.getParametros

        If dt_para.Rows(0)("PG_MARCADOR_PRORATEO") = 1 Then
            uchk_dividir9.Checked = True
        Else
            uchk_dividir9.Checked = False
        End If

        dt_para.Dispose()
        ParametrosBE = Nothing
        ParametrosBL = Nothing

    End Sub



    Private Sub Cargar_Combo_CC()
        Dim ccostoBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccostoBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
        ccostoBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_cc.DataSource = ccostoBL.getCentroCostos_cmb(ccostoBE)
        uce_cc.DisplayMember = "CC_DESCRIPCION"
        uce_cc.ValueMember = "CC_CODIGO"

        ccostoBE = Nothing
        ccostoBL = Nothing

    End Sub

    Private Sub Cargar_Cmb_SubDiario()
        Try
            Dim Obj_SubDBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
            Dim E_SD As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            E_SD.SD_IDOPERACION = New SG_CO_TB_OPERACION With {.OP_CODIGO = gCInt_Ope_Honorarios}
            E_SD.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            uce_Subdiario.DataSource = Obj_SubDBL.getSubdiarios_x_Modulo(E_SD)
            uce_Subdiario.DisplayMember = "SD_DESCRIPCION"
            uce_Subdiario.ValueMember = "SD_ID"

            E_SD = Nothing
            Obj_SubDBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cmb_Monedas()
        Try
            Dim Obj_MonedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
            uce_Moneda.DataSource = Obj_MonedaBL.getMonedas()
            uce_Moneda.DisplayMember = "MO_DESCRIPCION"
            uce_Moneda.ValueMember = "MO_CODIGO"

            uce_Moneda_Det.DataSource = Obj_MonedaBL.getMonedas()
            uce_Moneda_Det.DisplayMember = "MO_DESCRIPCION"
            uce_Moneda_Det.ValueMember = "MO_CODIGO"

            Obj_MonedaBL = Nothing
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Documentos()
        Try
            Dim Obj_DocBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
            Dim E_Doc As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            E_Doc.DO_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            uce_TipoDoc.DataSource = Obj_DocBL.getDocumentos(E_Doc)
            uce_TipoDoc.DisplayMember = "DO_DESCRIPCION"
            uce_TipoDoc.ValueMember = "DO_CODIGO"


            uce_TipoDoc_Det.DataSource = Obj_DocBL.getDocumentos(E_Doc)
            uce_TipoDoc_Det.DisplayMember = "DO_DESCRIPCION"
            uce_TipoDoc_Det.ValueMember = "DO_CODIGO"

            E_Doc = Nothing
            Obj_DocBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_TipoCambioFormato()
        Try
            Dim Obj_ForTC As New BL.ContabilidadBL.SG_CO_TB_FORM_TIPCAMB

            uce_TipoCambio.DataSource = Obj_ForTC.getFormatos
            uce_TipoCambio.DisplayMember = "FT_DESCRIPCION"
            uce_TipoCambio.ValueMember = "FT_CODIGO"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
 
    Private Sub Cargar_Tasas_Impuestos()
        Try
            Dim Obj_ImpuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
            Dim E_impuesto As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

            E_impuesto.IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_impuesto.IM_IDTIPOIMPUESTO = New SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "03"}
            E_impuesto.IM_PERIODO = CDate(udte_fec_Vou.Value).Year
            E_impuesto.IM_MES = CDate(udte_fec_Vou.Value).Month
            Obj_ImpuestosBL.getImpuestos_x_Tipo(E_impuesto)
            ume_Tasa_4ta.Value = E_impuesto.IM_TASA

            Obj_ImpuestosBL = Nothing
            E_impuesto = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)

        E_PlanCtas = Nothing
        Obj_PlanCtasBL = Nothing


    End Sub

    Private Sub Iniciar_Formulario()
        Try
            Me.Text = "Voucher de Honorarios"
            ugb_Cabecera.Enabled = True

            Call LimpiaGrid(ug_asiento, uds_Asiento)



            uce_Moneda.Value = 1
            txt_Cod_Mon_Cab.Text = 1

            txt_cod_Doc_Cab.Text = "02"
            uce_TipoDoc.Value = "02"

            uce_Subdiario.SelectedIndex = -1

            udte_fec_Vou.Value = gDat_Fecha_Sis
            udte_Fec_Emi.Value = gDat_Fecha_Sis
            udte_Fec_Ven.Value = gDat_Fecha_Sis

            uce_TipoCambio.SelectedIndex = -1
            uce_TipoCambio.SelectedIndex = 1

            txt_Glosa.Text = String.Empty
            txt_Num_Voucher.Text = String.Empty
            ugb_Cabecera.Enabled = True
            ubtn_Impresion.Visible = False
            btn_Nuevo.Enabled = False
            ume_Monto_Rete.Enabled = True

            Call MostrarTabs(0, utc_Asiento, 0)

            ume_tot_d.Value = 0
            ume_tot_h.Value = 0
            ume_dif.Value = 0

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Ocultar_Columnas(ByVal Ocultar As Boolean)

        ug_asiento.DisplayLayout.Bands(0).Columns("Fecha Emi").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Fecha ven").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Tip_Doc").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Serie").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Numero").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("TipoCam").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Soles").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("CenCosto").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("MedioPago").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Banco").Hidden = Ocultar
        'ug_asiento.DisplayLayout.Bands(0).Columns("Glosa").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("TipoAnexo").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Es_Destino").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("cc_id").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Sec_Ori_Destino").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Descripcion").Width = 350


    End Sub

    Private Sub ubtn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        If Bol_Edicion Then
            If Preguntar("Esta seguro de Salir?") Then
                Me.Close()
            End If
            Exit Sub
        End If

        If ubtn_Cancelar.Text.Equals("&Cancelar") Then
            If Preguntar("Esta seguro de cancelar?") Then
                Call Limpiar_Controls_InGroupox(ugb_Cabecera)
                Call Iniciar_Formulario()
                Call Cargar_Tasas_Impuestos()
                Try
                    udte_fec_Vou.Value = ""
                Catch ex As Exception

                End Try
                uce_Subdiario.SelectedIndex = 0

                txt_ruc_anexo.Focus()
            End If
        Else

            ugb_Cabecera.Enabled = True
            ubtn_GrabarVoucher.Enabled = True
            ubtn_Cancelar.Text = "&Cancelar"
            ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
            uce_Subdiario.Focus()
            Call Limpiar_Controls_InGroupox(ugb_Cabecera)
            Call Iniciar_Formulario()
            Call Cargar_Tasas_Impuestos()
            Try
                udte_fec_Vou.Value = ""
            Catch ex As Exception

            End Try

            uce_Subdiario.SelectedIndex = 0
            txt_ruc_anexo.Focus()
        End If
    End Sub

    Private Sub ubtn_GrabarVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_GrabarVoucher.Click
        Try

            If Math.Round(CDbl(ume_tot_d.Value), BYTFormatContable) <> Math.Round(CDbl(ume_tot_h.Value), BYTFormatContable) Then
                Avisar(String.Format("El asiento no esta cuadrando por {0}", CDbl(ume_dif.Value)))
                Exit Sub
            End If

            If Not Validar_Cabecera() Then Exit Sub


            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Compras As New BE.ContabilidadBE.SG_CO_TB_COMPRAS
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


            With E_Compras
                .CO_IDCAB = Nothing
                .CO_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo}
                .CO_ANEXO_ID = New SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_IdAnexo.Text.Trim}
                .CO_TIP_DOC = New SG_CO_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
                .CO_SER_DOC = txt_SerieDoc.Text.Trim
                .CO_NUM_DOC = txt_NumDoc.Text.Trim
                .CO_INDICADOR_DESTINO = "00"
                .CO_FEC_EMI = CDate(udte_Fec_Emi.Value).ToShortDateString
                .CO_FEC_VEN = CDate(udte_Fec_Ven.Value).ToShortDateString
                .CO_FEC_VOU = CDate(udte_fec_Vou.Value).ToShortDateString


                .CO_TIP_DOC_REF = Nothing
                .CO_SER_DOC_REF = String.Empty
                .CO_NUM_DOC_REF = String.Empty
                .CO_FEC_EMI_REF = String.Empty


                .CO_TASA_IGV = 0
                .CO_MONTO_IGV = 0
                .CO_MONTO_EXONERADO = 0
                .CO_TASA_ISC = 0
                .CO_MONTO_ISC = 0
                .CO_OTROS_TRIBUTOS = 0
                .CO_IMPORTE_COMPRA = 0
                .CO_IMPORTE_VENTA = 0

                .CO_ES_AFECTO_DETRA = 0
                .CO_TASA_DETRA = 0
                .CO_IMPORTE_DETRA = 0
                .CO_VALOR_RAZ_DETRA = 0
                .CO_NUMERO_DETRA = String.Empty
                .CO_FEC_EMI_DETRA = String.Empty
                .CO_TIPO_SERV_DETRA = String.Empty
                .CO_SERV_DETRA = String.Empty

                .CO_ES_AFECTO_PERCEP = 0
                .CO_TASA_PERCEP = 0

                .CO_ISTATUS = 1
                .CO_IMPORTE_PAGAR = 0
                .CO_TASA_4TA = CDbl(ume_Tasa_4ta.Value)
                .CO_TOTAL_HONO = CDbl(ume_Total_Hono.Value)
                .CO_MONTO_RET = CDbl(ume_Monto_Rete.Value)
                .CO_MONTO_PERCI = CDbl(ume_Monto_Perci.Value)
            End With

            With E_Cabecera
                .AC_ID = Int_IdCab_Edit
                .AC_IDSUBDIARIO = New SG_CO_TB_SUBDIARIO With {.SD_ID = uce_Subdiario.Value}
                .AC_NUM_VOUCHER = txt_Num_Voucher.Text.Trim
                .AC_ANHO = CDate(udte_fec_Vou.Value).Year
                .AC_MES = CDate(udte_fec_Vou.Value).Month
                .AC_FEC_VOUCHER = CDate(udte_fec_Vou.Value).ToShortDateString
                .AC_IDMONEDA = New SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                .AC_DEBE = ume_tot_d.Value
                .AC_HABER = ume_tot_h.Value
                .AC_TC_OPE = ume_ValorTipoCambio.Value
                .AC_TC_ESPECIAL = 0
                If uce_TipoCambio.Value = 3 Then
                    .AC_TC_ESPECIAL = ume_ValorTipoCambio.Value
                End If
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = txt_Glosa.Text.Trim
                .AC_ES_INTERFACE = 0
                .AC_TC_FORMATO = New SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = uce_TipoCambio.Value}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Date.Now
                .AC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            Dim E_Detalle As SG_CO_TB_ASIENTO_DET
            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                E_Detalle = New SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = ug_asiento.Rows(i).Cells("Item").Value.ToString
                    .AD_CUENTA = ug_asiento.Rows(i).Cells("Cuenta").Value.ToString


                    If ug_asiento.Rows(i).Cells("TipoAnexo").Value.ToString.Equals(String.Empty) Then
                        .AD_TANEXO = Nothing
                    Else
                        .AD_TANEXO = E_Compras.CO_TIPO_ANEXO
                    End If

                    If ug_asiento.Rows(i).Cells("Anexo").Value.ToString.Equals(String.Empty) Then
                        .AD_IDANEXO = Nothing
                    Else
                        .AD_IDANEXO = New SG_CO_TB_ANEXO With {.AN_IDANEXO = ug_asiento.Rows(i).Cells("Anexo").Value.ToString}
                    End If

                    If ug_asiento.Rows(i).Cells("Tip_Doc").Value.ToString.Equals(String.Empty) Then
                        .AD_TDOC = Nothing
                    Else
                        .AD_TDOC = New SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_asiento.Rows(i).Cells("Tip_Doc").Value.ToString}
                    End If

                    .AD_SDOC = ug_asiento.Rows(i).Cells("Serie").Value.ToString
                    .AD_NDOC = ug_asiento.Rows(i).Cells("Numero").Value.ToString
                    .AD_FDOC = ug_asiento.Rows(i).Cells("Fecha Emi").Value.ToString
                    .AD_VDOC = ug_asiento.Rows(i).Cells("Fecha ven").Value.ToString


                    .AD_DEBE = IIf(ug_asiento.Rows(i).Cells("Debe").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("Debe").Value)
                    .AD_HABER = IIf(ug_asiento.Rows(i).Cells("Haber").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("Haber").Value)
                    .AD_MONTO_ORI = ug_asiento.Rows(i).Cells("Soles").Value
                    .AD_PORCE_DESTINO = IIf(ug_asiento.Rows(i).Cells("porce_destino").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("porce_destino").Value)

                    If ug_asiento.Rows(i).Cells("TipoCam").Value.ToString.Equals(String.Empty) Then
                        .AD_TCAM = 0
                    Else
                        .AD_TCAM = ug_asiento.Rows(i).Cells("TipoCam").Value
                    End If

                    .AD_SEC_ORI_DESTINO = IIf(ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value.ToString.Equals(String.Empty), 0, ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value)
                    .AD_GLOSA = ug_asiento.Rows(i).Cells("Glosa").Value.ToString
                    .AD_IDCC = New SG_CO_TB_CENTROCOSTO With {.CC_CODIGO = ug_asiento.Rows(i).Cells("cc_id").Value}
                    .AD_ES_DESTINO = ug_asiento.Rows(i).Cells("Es_Destino").Value
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)
            Next

            Dim StrVoucher As String = String.Empty
            If Bol_Edicion Then StrVoucher = txt_Num_Voucher.Text

            AsientoBL.Insert_Honorarios(E_Cabecera, E_Compras, Detalles, StrVoucher, Bol_Edicion)
            txt_Num_Voucher.Text = StrVoucher
            txt_IdCabecera.Text = E_Cabecera.AC_ID

            Call Avisar("Listo!")

            If Bol_Edicion Or Bol_Copy Then
                CO_PR_EdicionVoucher.Cargar_Voucher_II(uce_Subdiario.Value, CDate(udte_fec_Vou.Value).Month)
                Me.Close()
            End If

            ubtn_Impresion.Visible = True
            ugb_Cabecera.Enabled = False
            ubtn_GrabarVoucher.Enabled = False
            ubtn_Cancelar.Text = "&Nuevo"
            ubtn_Cancelar.Appearance.Image = My.Resources._16__File_new_2_
            ubtn_Cancelar.Focus()

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_ruc_anexo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc_anexo.Leave
        Try

            If uce_Subdiario.SelectedIndex = -1 Then
                Avisar("Seleccione un subdiario.")
                uce_Subdiario.Focus()
                Exit Sub
            End If

            Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO

            Dim E_Anexo As New SG_CO_TB_ANEXO
            Dim E_SubDiario As New SG_CO_TB_SUBDIARIO
            E_SubDiario.SD_ID = uce_Subdiario.Value
            E_SubDiario.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Anexo.AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Anexo.AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Obj_TipoAnexoBL.getTipoAnexo_x_SubDiario_Hono(E_SubDiario)}
            E_Anexo.AN_NUM_DOC = txt_ruc_anexo.Text.Trim
            Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

            If E_Anexo.AN_DESCRIPCION.Length = 0 Then
                txt_Des_Prove.Text = "El anexo no existe."
            Else
                txt_Des_Prove.Text = E_Anexo.AN_DESCRIPCION
                txt_IdAnexo.Text = E_Anexo.AN_IDANEXO
                uchkRelacionado.Checked = E_Anexo.AN_ES_RELACIONADO
            End If

            E_Anexo = Nothing
            Obj_AnexoBL = Nothing
            Obj_TipoAnexoBL.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_ruc_anexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_anexo.KeyDown
        If e.KeyCode = Keys.Enter Then txt_IdAnexo.Focus()

        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Anexo_Cab()
        End If
    End Sub

    Private Sub Ayuda_Anexo_Cab()
        CO_MT_Buscar.Int_Opcion = 3
        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_ruc_anexo.Text = matriz(2)
            txt_IdAnexo.Text = matriz(0)
            txt_Des_Prove.Text = matriz(3)
        End If
    End Sub

    Private Sub Ayuda_Anexo_Det()
        CO_MT_Buscar.Int_Opcion = 3
        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_Anexo_Ruc_Det.Text = matriz(2)
            txt_idAnexoDet.Text = matriz(0)
            lbl_Des_Anexo.Text = matriz(3)
        End If
    End Sub


    Private Sub txt_ruc_anexo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_anexo.EditorButtonClick
        Select Case e.Button.Key
            Case "Ayuda"
                Call Ayuda_Anexo_Cab()
            Case ""

        End Select
    End Sub

    Private Sub udte_fec_Vou_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_Vou.KeyDown
        If e.KeyCode = Keys.Enter Then
            If udte_fec_Vou.Value = Nothing Then
                Avisar("Ingrese la fecha de voucher")
                udte_fec_Vou.Focus()
            Else
                SendKeys.Send(vbTab)
            End If

        End If
    End Sub

    Private Sub udte_Fec_Emi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_Fec_Emi.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_Fec_Ven_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_Fec_Ven.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Cod_Mon_Cab_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Cod_Mon_Cab.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Moneda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_TipoCambio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_ValorTipoCambio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_ValorTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_cod_Doc_Cab_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_Doc_Cab.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_TipoDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_SerieDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_NumDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Total_Hono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Total_Hono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ume_Total_Hono.Value > 0 Then
                Call Calcular_Valor_Retencion()
            End If
        End If
    End Sub

    Private Sub ume_Monto_Rete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Monto_Rete.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Monto_Perci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Monto_Perci.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Glosa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Glosa.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.Down Then txt_Glosa.Text = txt_Des_Prove.Text.Trim
    End Sub

    Private Sub uce_Moneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Moneda.ValueChanged
        txt_Cod_Mon_Cab.Text = uce_Moneda.Value
    End Sub

    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged
        txt_cod_Doc_Cab.Text = uce_TipoDoc.Value
    End Sub

    Private Sub ume_Total_Hono_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_Total_Hono.Leave
        If IsDBNull(ume_Total_Hono.Value) Then
            ume_Total_Hono.Value = 0
        End If

       
    End Sub

    Private Sub Calcular_Valor_Retencion()
        Try
            'Calculamos la Renta 4TA Categoria 

            If Preguntar("Desea Calcular el Monto Retenido a Cuarta Categoria?") Then
                ume_Monto_Perci.Value = Math.Round(CDbl(ume_Total_Hono.Value) - (CDbl(ume_Total_Hono.Value) * (CDbl(ume_Tasa_4ta.Value) / 100)), 3)
                ume_Monto_Rete.Value = Math.Round(CDbl(ume_Total_Hono.Value) * (CDbl(ume_Tasa_4ta.Value) / 100), 3)
                ume_Monto_Rete.Enabled = True
                ume_Monto_Perci.Focus()
            Else
                ume_Monto_Perci.Value = Math.Round(CDbl(ume_Total_Hono.Value), 3)
                ume_Monto_Rete.Value = Math.Round(0, 3)
                ume_Monto_Rete.Enabled = False
                ume_Monto_Perci.Focus()
            End If

        Catch ex As Exception
            ShowError("ocurrio un error: (Calcular_Valor_Compra)" & ex.Message)
        End Try

    End Sub

    Private Sub btn_ListoCab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ListoCab.Click
        Try
            'Validamos
            If Not Validar_Cabecera() Then Exit Sub

            'Mostramos la Ventana de Destino
            CO_PR_VouCompras_Destinos.bol_Dividir_9s = uchk_dividir9.Checked
            CO_PR_VouCompras_Destinos.Inicializar_Form()
            CO_PR_VouCompras_Destinos.ShowDialog()

            'Calculamos y Generamos el asiento
            If CO_PR_VouCompras_Destinos.Bol_Aceptar Then
                Call GenerarAsiento()
            End If


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Function Validar_Cabecera() As Boolean
        Validar_Cabecera = False
        Try

            If uce_SubDiario.SelectedIndex = -1 Then
                Avisar("Debe seleccionar un subdiario.")
                uce_SubDiario.Focus()
                Exit Function
            End If

            If txt_ruc_anexo.Text.Trim.Length = 0 Then
                Avisar("Debe seleccionar un anexo.")
                txt_ruc_anexo.Focus()
                Exit Function
            End If

            If uce_Moneda.SelectedIndex = -1 Then
                Avisar("Debe seleccionar una moneda.")
                uce_Moneda.Focus()
                Exit Function
            End If

            If uce_TipoCambio.SelectedIndex = -1 Then
                Avisar("Debe seleccionar un tipo de cambio.")
                uce_TipoCambio.Focus()
                Exit Function
            End If

            If ume_ValorTipoCambio.Value <= 0 Then
                Avisar("El tipo de cambio no puede ser menor o igual a cero.")
                ume_ValorTipoCambio.Focus()
                Exit Function
            End If

            If uce_TipoDoc.SelectedIndex = -1 Then
                Avisar("Debe seleccionar un tipo de documento.")
                uce_TipoDoc.Focus()
                Exit Function
            End If

            If txt_NumDoc.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar un numero de documento.")
                txt_NumDoc.Focus()
                Exit Function
            End If

            Return True
        Catch ex As Exception
            Avisar("Ocurrio un error: " & ex.Message)
        End Try
    End Function

    Private Sub GenerarAsiento()
        Try
            '_______________________________________________________________________Validamos
            If Not Validar_Cabecera() Then Exit Sub
            '_______________________________________________________________________Obtenemos el tipo de anexo
            Int_TipoAnexo = Obtener_Tipo_de_Anexo_Hono(uce_Subdiario.Value)

            '_______________________________________________Limpiamos la Grilla
            Call LimpiaGrid(ug_asiento, uds_Asiento)

            '_______________________________________________________________________Creamos el asiento destino
            Call Creamos_Asiento_Destino(CDbl(ume_Total_Hono.Value), True)

            '_______________________________________________________________________Creamos el Asiento
            Call CreaAsiento()

            '_______________________________________________________________________Sumamos debe haber
            Call Sum_Tot()

            '_______________________________________________________________________Todo Cabecera a Soles
            If uce_Moneda.Value = 2 Then
                ume_Total_Hono.Value = Math.Round(ume_Total_Hono.Value * ume_ValorTipoCambio.Value, BYTFormatContable)
                ume_Monto_Rete.Value = Math.Round(ume_Monto_Rete.Value * ume_ValorTipoCambio.Value, BYTFormatContable)
                ume_Monto_Perci.Value = Math.Round(ume_Monto_Perci.Value * ume_ValorTipoCambio.Value, BYTFormatContable)
            End If

            '_______________________________________________________________________Habilito Controles
            utc_Asiento.Enabled = True

            btn_Nuevo.Enabled = True
            ubtn_GrabarVoucher.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Sum_Tot()

        Dim Dbl_Debe As Double = 0
        Dim Dbl_Haber As Double = 0
        Dim Dbl_Dif As Double = 0

        For i As Integer = 0 To ug_asiento.Rows.Count - 1
            Dbl_Debe = Dbl_Debe + IIf(ug_asiento.Rows(i).Cells("Debe").Value.ToString = "", 0, ug_asiento.Rows(i).Cells("Debe").Value)
            Dbl_Haber = Dbl_Haber + IIf(ug_asiento.Rows(i).Cells("Haber").Value.ToString = "", 0, ug_asiento.Rows(i).Cells("Haber").Value)
        Next

        Dbl_Dif = Dbl_Debe - Dbl_Haber

        ume_tot_d.Value = Dbl_Debe
        ume_tot_h.Value = Dbl_Haber
        ume_dif.Value = Dbl_Dif

        
    End Sub

    Private Sub CreaAsiento()
        Try
            Dim Dt_plantilla As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
            Dim Ent_SD As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB
            Dim Obj_AutoDetBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_DET

            '_______________________________________________Traemos la plantilla con las cuentas
            Ent_SD.AA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Ent_SD.AA_IDSUBDIARIO = New SG_CO_TB_SUBDIARIO With {.SD_ID = uce_Subdiario.Value}
            Ent_SD.AA_ANHO = gDat_Fecha_Sis.Year

            Dt_plantilla = Obj_AutoDetBL.getDetalles_x_Sudiario(Ent_SD, uce_Moneda.Value)

            For Each DR As SG_CO_TB_ASIENTO_AUTO_DET In Dt_plantilla
                Select Case DR.AA_IDCONPCETO.CR_ID
                    Case 1 'Monto ISC
                    Case 6 'Monto Retencion 4ta
                        If CDbl(ume_Monto_Rete.Value) > 0 Then
                            Call Add_Row(DR.AA_IDCUENTA.PC_NUM_CUENTA, Nothing, Nothing, "", "", "", "", DR.AA_DH, CDbl(ume_Monto_Rete.Value), False)
                        End If
                    Case 3 'Otros tributos y Cargos
                    Case 7 'Valor Total
                        If CDbl(ume_Monto_Perci.Value) > 0 Then '_____________________________K sea mayor a cero pues!!
                            Call Add_Row(IIf(uchkRelacionado.Checked, DR.AA_IDCUENTA_R.PC_NUM_CUENTA, DR.AA_IDCUENTA.PC_NUM_CUENTA), udte_Fec_Emi.Value, udte_Fec_Ven.Value, uce_TipoDoc.Value, txt_SerieDoc.Text, txt_NumDoc.Text, txt_IdAnexo.Text, DR.AA_DH, ume_Monto_Perci.Value, True)
                        End If
                    Case 12 'Valor Compra
                    Case 16 'Monto Detracción

                    Case Else
                End Select
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Add_Row(ByVal cuenta_ As String, ByVal fec_Ini_ As String, ByVal fec_ven_ As String, ByVal td_ As String, ByVal sd_ As String, ByVal nd_ As String, ByVal anexo_ As String, ByVal dh As Integer, ByVal importe_ As Double, ByVal Con_Anexo As Boolean)
        Try
            Dim valor As Double = importe_
            ug_asiento.DisplayLayout.Bands(0).AddNew()
            Dim Int_NumFilas As Integer = ug_asiento.Rows.Count
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS

            With ug_asiento.Rows(Int_NumFilas - 1)
                .Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
                .Cells("Cuenta").Value = cuenta_

                Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

                E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
                E_PlanCtas.PC_NUM_CUENTA = cuenta_
                Obj_PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)

                If Con_Anexo Then
                    .Cells("Descripcion").Value = txt_Des_Prove.Text
                    .Cells("TipoAnexo").Value = Int_TipoAnexo
                Else
                    .Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION
                End If

                If Not fec_Ini_ Is Nothing Then
                    .Cells("Fecha Emi").Value = fec_Ini_
                End If

                If Not fec_ven_ Is Nothing Then
                    .Cells("Fecha ven").Value = fec_ven_
                End If

                .Cells("Tip_Doc").Value = td_
                .Cells("Serie").Value = sd_
                .Cells("Numero").Value = nd_
                .Cells("Anexo").Value = anexo_

                .Cells("Es_Destino").Value = "0"

                If dh = 2 Then 'haber

                    .Cells("Debe").Value = Nothing
                    .Cells("Haber").Value = Convert.ToDouble(IIf(uce_Moneda.Value = 1, importe_, importe_ * ume_ValorTipoCambio.Value)).ToString("##,##0.00")

                Else

                    .Cells("Debe").Value = Convert.ToDouble(IIf(uce_Moneda.Value = 1, importe_, importe_ * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                    .Cells("Haber").Value = Nothing

                End If

                .Cells("TipoCam").Value = IIf(uce_Moneda.Value = 1, Nothing, ume_ValorTipoCambio.Value)
                .Cells("CenCosto").Value = ""
                .Cells("Glosa").Value = txt_Glosa.Text.Trim
                .Cells("cc_id").Value = Val(0)
                .Cells("Soles").Value = Convert.ToDouble(valor).ToString("##,##0.000")

                ug_asiento.UpdateData()

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Creamos_Asiento_Destino(ByVal Dbl_importe As Double, ByVal Bol_EsCab As Boolean)
        Try
            Dim Dt_destinos As DataTable

            Dim Str_Cta_Origen As String = CO_PR_VouCompras_Destinos.uc_Cuentas.ActiveRow.Cells("PC_NUM_CUENTA").Text.Trim
            Dim Str_Des_Cta_Origen = CO_PR_VouCompras_Destinos.txt_Des_Cta.Text.Trim
            Dim Int_NumFilas As Integer = 0

            Dt_destinos = CO_PR_VouCompras_Destinos.getDestinos

            If Bol_EsCab Then

                Dim planCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                Dim planCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

                planCtasBE.PC_NUM_CUENTA = Str_Cta_Origen
                planCtasBE.PC_PERIODO = gDat_Fecha_Sis.Year
                planCtasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                planCtasBL.getCuenta_X_NumeroCta(planCtasBE)


                ug_asiento.DisplayLayout.Bands(0).AddNew()
                Int_NumFilas = ug_asiento.Rows.Count
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Cuenta").Value = Str_Cta_Origen
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = Str_Des_Cta_Origen

                ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = Convert.ToDouble(IIf(uce_Moneda.Value = 1, Dbl_importe, Dbl_importe * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = Nothing


                ug_asiento.Rows(Int_NumFilas - 1).Cells("Es_Destino").Value = "0"
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Soles").Value = Dbl_importe.ToString("##,##0.000")
                ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoCam").Value = IIf(uce_Moneda.Value = 1, Nothing, ume_ValorTipoCambio.Value)
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Glosa").Value = txt_Glosa.Text.Trim
                ug_asiento.Rows(Int_NumFilas - 1).Cells("cc_id").Value = 0



                If Not planCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Tip_Doc").Value = txt_cod_Doc_Cab.Text.Trim
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Serie").Value = txt_SerieDoc.Text.Trim
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Numero").Value = txt_NumDoc.Text.Trim
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Anexo").Value = txt_IdAnexo.Text.Trim
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Fecha Emi").Value = udte_Fec_Emi.Value
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Fecha ven").Value = udte_Fec_Ven.Value
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoAnexo").Value = Int_TipoAnexo
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = txt_Des_Prove.Text
                End If


                ug_asiento.UpdateData()

                planCtasBE = Nothing
                planCtasBL = Nothing
            End If



            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            Dim Int_Secuencia_Origen As Integer = ug_asiento.Rows.Count
            Dim Dbl_Importe_Prora As Double = 0
            Dim Dbl_porcentaje_destino As Double = 0

            For i As Integer = 0 To Dt_destinos.Rows.Count - 1
                If Dt_destinos.Rows(i)("Porcentaje") > 0 Then

                    E_PlanCtas.PC_NUM_CUENTA = Dt_destinos.Rows(i)("Cuenta")
                    Obj_PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)
                    Dbl_porcentaje_destino = Dt_destinos.Rows(i)("Porcentaje")
                    Dbl_Importe_Prora = Dbl_importe * (Dt_destinos.Rows(i)("Porcentaje") / 100)

                    ug_asiento.DisplayLayout.Bands(0).AddNew()
                    Int_NumFilas = ug_asiento.Rows.Count
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Cuenta").Value = E_PlanCtas.PC_NUM_CUENTA
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION


                    If Dt_destinos.Rows(i)("DH") = "D" Then 'sonia.jsr@gmail.com
                        ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = Convert.ToDouble(IIf(uce_Moneda.Value = 1, Dbl_Importe_Prora, Dbl_Importe_Prora * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                    Else
                        ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = Convert.ToDouble(IIf(uce_Moneda.Value = 1, Dbl_Importe_Prora, Dbl_Importe_Prora * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                    End If

                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Es_Destino").Value = "1"
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Soles").Value = Convert.ToDouble(Dbl_Importe_Prora).ToString("##,##0.000")
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoCam").Value = IIf(uce_Moneda.Value = 1, Nothing, ume_ValorTipoCambio.Value)
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Glosa").Value = txt_Glosa.Text.Trim
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("cc_id").Value = 0
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("sec_Ori_Destino").Value = Int_Secuencia_Origen.ToString.PadLeft("3", "0")
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("porce_destino").Value = Dbl_porcentaje_destino
                    ug_asiento.UpdateData()

                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub uce_TipoCambio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoCambio.ValueChanged
        Call Obtener_TipoCambio_dia()
    End Sub

    Public Sub CargarVoucher_toEdit(ByVal Ent_cabecera As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB)
        Try
            Bol_Edicion = True
            Int_IdCab_Edit = Ent_cabecera.AC_ID
            Dim Ds_Voucher As DataSet = Obj_Voucher.getVouchers_x_Id(Ent_cabecera)
            '____________________________________________________________________________Llenamos la cabecera

            If Ds_Voucher.Tables(0).Rows.Count > 0 Then '__________________________Tabla Cabecera
                With Ds_Voucher.Tables(0).Rows(0)
                    uce_Subdiario.Value = .Item("AC_IDSUBDIARIO")
                    txt_Num_Voucher.Text = .Item("AC_NUM_VOUCHER")
                    uce_TipoCambio.Value = .Item("AC_TC_FORMATO")
                    ume_ValorTipoCambio.Value = .Item("AC_TC_OPE")
                    txt_Glosa.Text = .Item("AC_GLOSA_VOU")
                    uce_Moneda.Value = .Item("AC_IDMONEDA")
                    txt_Cod_Mon_Cab.Text = .Item("AC_IDMONEDA")
                End With
            End If

            If Ds_Voucher.Tables(2).Rows.Count > 0 Then '__________________________Tabla Compras
                With Ds_Voucher.Tables(2).Rows(0)

                    Int_TipoAnexo = .Item("CO_TIPO_ANEXO")

                    txt_IdAnexo.Text = .Item("CO_ANEXO_ID")
                    Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_IdAnexo.Text}
                    Obj_AnexoBL.getAnexo(E_Anexo)

                    txt_ruc_anexo.Text = E_Anexo.AN_NUM_DOC
                    txt_Des_Prove.Text = E_Anexo.AN_DESCRIPCION
                    uchkRelacionado.Checked = IIf(E_Anexo.AN_ES_RELACIONADO = 1, True, False)

                    uce_TipoDoc.Value = .Item("CO_TIP_DOC")
                    txt_cod_Doc_Cab.Text = .Item("CO_TIP_DOC")
                    txt_SerieDoc.Text = .Item("CO_SER_DOC")
                    txt_NumDoc.Text = .Item("CO_NUM_DOC")

                    udte_Fec_Emi.Value = .Item("co_FEC_EMI")
                    udte_Fec_Ven.Value = .Item("co_FEC_VEN")
                    udte_fec_Vou.Value = .Item("co_FEC_VOU")

                    ume_Total_Hono.Value = .Item("CO_TOTAL_HONO")
                    ume_Monto_Rete.Value = .Item("CO_MONTO_RET")
                    ume_Monto_Perci.Value = .Item("CO_MONTO_PERCI")

                End With
            End If
            '____________________________________________________________________________Llenamos el detalle

            Call LimpiaGrid(ug_asiento, uds_Asiento)


            If Ds_Voucher.Tables(1).Rows.Count > 0 Then
                With Ds_Voucher.Tables(1)
                    For i As Integer = 0 To .Rows.Count - 1
                        ug_asiento.DisplayLayout.Bands(0).AddNew()
                        Dim Int_NumFilas As Integer = ug_asiento.Rows.Count
                        '
                        ug_asiento.Rows(i).Cells("Item").Value = .Rows(i)("AD_SECUENCIA").ToString.PadLeft("3", "0")
                        ug_asiento.Rows(i).Cells("Cuenta").Value = .Rows(i)("ad_cuenta").ToString

                        Dim Obj_PlanCtas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                        E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
                        E_PlanCtas.PC_NUM_CUENTA = .Rows(i)("ad_cuenta").ToString

                        Obj_PlanCtas.getCuenta_X_NumeroCta(E_PlanCtas)

                        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                            ug_asiento.Rows(i).Cells("Descripcion").Value = txt_Des_Prove.Text
                        Else
                            ug_asiento.Rows(i).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION
                        End If

                        ug_asiento.Rows(i).Cells("TipoAnexo").Value = .Rows(i)("AD_TANEXO").ToString

                        If Ds_Voucher.Tables(1).Rows(i)("AD_FDOC").ToString.Trim.Length = 0 Then
                            'ug_asiento.Rows(i).Cells("Fecha Emi").Value = ""
                        Else
                            ug_asiento.Rows(i).Cells("Fecha Emi").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_FDOC")).ToShortDateString
                        End If

                        If Ds_Voucher.Tables(1).Rows(i)("AD_VDOC").ToString.Trim.Length = 0 Then
                            'ug_asiento.Rows(i).Cells("Fecha ven").Value = ""
                        Else
                            ug_asiento.Rows(i).Cells("Fecha ven").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_VDOC")).ToShortDateString
                        End If

                        ug_asiento.Rows(i).Cells("Tip_Doc").Value = .Rows(i)("AD_TDOC").ToString
                        ug_asiento.Rows(i).Cells("Serie").Value = .Rows(i)("AD_SDOC").ToString
                        ug_asiento.Rows(i).Cells("Numero").Value = .Rows(i)("AD_NDOC").ToString
                        ug_asiento.Rows(i).Cells("Anexo").Value = .Rows(i)("AD_IDANEXO").ToString
                        If .Rows(i)("AD_DEBE") > 0 Then
                            ug_asiento.Rows(i).Cells("Debe").Value = Convert.ToDouble(.Rows(i)("AD_DEBE")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_HABER") > 0 Then
                            ug_asiento.Rows(i).Cells("Haber").Value = Convert.ToDouble(.Rows(i)("AD_HABER")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_TCAM") > 0 Then
                            ug_asiento.Rows(i).Cells("TipoCam").Value = .Rows(i)("AD_TCAM")
                        Else
                            ug_asiento.Rows(i).Cells("TipoCam").Value = Nothing
                        End If

                        ug_asiento.Rows(i).Cells("Glosa").Value = .Rows(i)("AD_GLOSA").ToString
                        ug_asiento.Rows(i).Cells("Es_Destino").Value = .Rows(i)("AD_ES_DESTINO").ToString
                        ug_asiento.Rows(i).Cells("cc_id").Value = IIf(.Rows(i)("AD_IDCC").ToString.Equals(String.Empty), 0, .Rows(i)("AD_IDCC"))
                        ug_asiento.Rows(i).Cells("Soles").Value = .Rows(i)("AD_MONTO_ORI")
                        ug_asiento.Rows(i).Cells("porce_destino").Value = .Rows(i)("AD_PORCE_DESTINO")

                        If .Rows(i)("AD_SEC_ORI_DESTINO") <> 0 Then
                            ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value = .Rows(i)("AD_SEC_ORI_DESTINO").ToString.PadLeft("3", "0")
                        Else
                            ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value = .Rows(i)("AD_SEC_ORI_DESTINO")
                        End If

                        ' si todo esta ok actualizamos la data confirmandola!
                        ug_asiento.UpdateData()
                    Next
                End With
            End If

            Call Sum_Tot()

            btn_Nuevo.Enabled = True
            txt_Num_Voucher.ReadOnly = True

            'ugb_Cabecera.Enabled = False

            Call MostrarTabs(0, utc_Asiento, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_GrabarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabarDet.Click

        If lbl_des_cta.Text.Length > 0 Then
            If lbl_des_cta.Text.Chars(0) = "*" Then
                Avisar("Debe ingresar una cuenta valida")
                If uc_Cuentas.Enabled Then uc_Cuentas.Focus()
                Exit Sub
            End If
        End If

        If lbl_Des_Anexo.Text.Length > 0 Then
            If lbl_Des_Anexo.Text.Chars(0) = "*" Then
                Avisar("Debe ingresar un anexo valido")
                If txt_Anexo_Ruc_Det.Enabled Then txt_Anexo_Ruc_Det.Focus()
                Exit Sub
            End If
        End If

        If ume_Debe_Det.Value = 0 And ume_Haber_Det.Value = 0 Then
            Avisar("Debe ingresar el importe mayor a cero")
            ume_Debe_Det.Focus()
            Exit Sub
        End If


        If Bol_NuevoDet Then Call SaveFilaDet() Else Call SaveRowDet_edit()
        Call Sum_Tot()
        Call Actualizar_Importe_Cabecera()


    End Sub

    Private Sub btn_CancelarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarDet.Click
        Call CancelSaveDet()
    End Sub

    Private Sub CancelSaveDet()
        Try
            Call LimpiarDetalle()
            Call MostrarTabs(0, utc_Asiento, 0)

            ug_asiento.UpdateData()
            ug_asiento.Focus()
            'ug_asiento.DisplayLayout.Bands(0).AddNew()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IngresarFilas()
        Call LimpiarDetalle()
        Call MostrarTabs(1, utc_Asiento, 1)
        Bol_NuevoDet = True
        uce_Moneda_Det.Value = 1
        txt_Glosa_Det.Text = txt_Glosa.Text
        txt_Anexo_Ruc_Det.Enabled = False
        uc_Cuentas.Focus()
    End Sub

    Private Sub SaveFilaDet()
        Try
            'validamos los datos
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
            E_PlanCtas.PC_NUM_CUENTA = uc_Cuentas.Text.Trim
            PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)

            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                If txt_Anexo_Ruc_Det.Text = "" Then
                    Avisar("La cuenta requiere un anexo.")
                    txt_Anexo_Ruc_Det.Focus()
                    Exit Sub
                End If
            End If


            If E_PlanCtas.PC_ES_CC = 1 Then
                If uce_cc.SelectedIndex = -1 Then
                    Call Avisar("La cuenta requiere centro de costo")
                    uce_cc.Focus()
                    Exit Sub
                End If
            End If


           

            ug_asiento.DisplayLayout.Bands(0).AddNew()
            Dim Int_NumFilas As Integer = ug_asiento.Rows.Count
            Dim valor As Double = 0
            Dim tcambio As Double = ume_ValorTipoCambio.Value

            If ume_Debe_Det.Value > 0 Then
                valor = ume_Debe_Det.Value
            Else
                valor = ume_Haber_Det.Value
            End If

            ug_asiento.Rows(Int_NumFilas - 1).Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Cuenta").Value = uc_Cuentas.Text.Trim
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = lbl_des_cta.Text

            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoAnexo").Value = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
            Else
                ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoAnexo").Value = Nothing
            End If


            If Not IsDBNull(ume_FecEmi_Det.Value) Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Fecha Emi").Value = CDate(ume_FecEmi_Det.Value).ToShortDateString
            End If

            If Not IsDBNull(ume_FecVen_Det.Value) Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Fecha ven").Value = CDate(ume_FecVen_Det.Value).ToShortDateString
            End If

            ug_asiento.Rows(Int_NumFilas - 1).Cells("Tip_Doc").Value = uce_TipoDoc_Det.Value
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Serie").Value = txt_SerieDoc_Det.Text
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Numero").Value = txt_NumDoc_Det.Text
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Anexo").Value = txt_idAnexoDet.Text


            If ume_Debe_Det.Value > 0 Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = Nothing
            Else
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = Nothing
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
            End If

            ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoCam").Value = IIf(uce_Moneda_Det.Value = 1, Nothing, ume_ValorTipoCambio.Value)
            ug_asiento.Rows(Int_NumFilas - 1).Cells("CenCosto").Value = IIf(uce_cc.SelectedIndex = -1, "", uce_cc.Value)
            ug_asiento.Rows(Int_NumFilas - 1).Cells("cc_id").Value = IIf(uce_cc.SelectedIndex = -1, 0, uce_cc.Value)
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Glosa").Value = txt_Glosa_Det.Text.Trim
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Es_Destino").Value = "0"


            ug_asiento.Rows(Int_NumFilas - 1).Cells("Soles").Value = valor.ToString("##,##0.000")
            ug_asiento.UpdateData()

            Dim Obj_DestinoBL As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO

            If Obj_DestinoBL.Tiene_Destinos(uc_Cuentas.Value) Then '______________________ Consultamos si la cuenta tiene destinos
                CO_PR_VouCompras_Destinos.Inicializar_Form()
                CO_PR_VouCompras_Destinos.uc_Cuentas.Value = uc_Cuentas.Value
                CO_PR_VouCompras_Destinos.txt_Des_Cta.Text = lbl_des_cta.Text
                CO_PR_VouCompras_Destinos.ShowDialog()

                Call Creamos_Asiento_Destino(valor, False)

            End If

            If uchk_Inafecto.Checked Then
                Call Sumar_impInafecto_a_cta42(valor)
            End If

            Call LimpiarDetalle()
            txt_Glosa_Det.Text = txt_Glosa.Text
            uc_Cuentas.Focus()
        Catch ex As Exception
            ShowError("Ocurrio un error: (SaveFilaDet) " & ex.Message)
        End Try
    End Sub

    Private Sub SaveRowDet_edit()
        Try
            Dim valor As Double = 0
            Dim tcambio As Double = ume_ValorTipoCambio.Value
            If ume_Debe_Det.Value > 0 Then
                valor = ume_Debe_Det.Value
            Else
                valor = ume_Haber_Det.Value
            End If


            If uce_cc.Enabled Then
                If uce_cc.SelectedIndex = -1 Then
                    Avisar("la cuenta requiere centro de costo, seleccione uno")
                    uce_cc.Focus()
                    Exit Sub
                End If
            End If



            With ug_asiento.ActiveRow
                .Cells("Cuenta").Value = uc_Cuentas.Text.Trim
                If lbl_Des_Anexo.Text.Trim.Length > 0 Then
                    .Cells("Descripcion").Value = lbl_Des_Anexo.Text.Trim
                Else
                    .Cells("Descripcion").Value = lbl_des_cta.Text.Trim
                End If

                If Not IsDBNull(ume_FecEmi_Det.Value) Then
                    .Cells("Fecha Emi").Value = CDate(ume_FecEmi_Det.Value).ToShortDateString
                End If

                If Not IsDBNull(ume_FecVen_Det.Value) Then
                    .Cells("Fecha ven").Value = CDate(ume_FecVen_Det.Value).ToShortDateString
                End If

                .Cells("Tip_Doc").Value = uce_TipoDoc_Det.Value
                .Cells("Serie").Value = txt_SerieDoc_Det.Text
                .Cells("Numero").Value = txt_NumDoc_Det.Text
                .Cells("Anexo").Value = txt_idAnexoDet.Text

                If ume_Debe_Det.Value > 0 Then
                    Dim calculo1 As Double = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
                    .Cells("Debe").Value = calculo1.ToString("##,##0.00")
                    .Cells("Haber").Value = Nothing
                Else
                    .Cells("Debe").Value = Nothing
                    .Cells("Haber").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
                End If

                .Cells("TipoCam").Value = IIf(uce_Moneda_Det.Value = 1, Nothing, ume_ValorTipoCambio.Value)
                .Cells("CenCosto").Value = IIf(uce_cc.SelectedIndex <> -1, uce_cc.Text.Trim, "")
                .Cells("cc_id").Value = IIf(uce_cc.SelectedIndex <> -1, uce_cc.Value, 0)
                .Cells("Glosa").Value = txt_Glosa_Det.Text.Trim

                .Cells("Soles").Value = valor.ToString("##,##0.000")

                ug_asiento.UpdateData()
                Call Actualizar_Importe_CtaDestino(.Cells("Item").Value, valor)
                Call Actualizar_Cuenta_en_Cabecera(uc_Cuentas.Text.Trim, IIf(uce_Moneda_Det.Value = 1, valor, CDbl(valor * ume_ValorTipoCambio.Value)))
                Call LimpiarDetalle()
                Call MostrarTabs(0, utc_Asiento, 0)


            End With

        Catch ex As Exception
            ShowError("Ocurrio un error : " & ex.Message)
        End Try
    End Sub

    Private Sub Actualizar_Importe_CtaDestino(ByVal Secuencia As String, ByVal importe As Double)
        Try
            Dim contador As Integer = 0
            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                If ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value.ToString.Equals(Secuencia) Then
                    contador += 1
                End If
            Next

            If contador = 2 Then
                For i As Integer = 0 To ug_asiento.Rows.Count - 1
                    If ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value.ToString.Equals(Secuencia) Then
                        If CDbl(IIf(IsDBNull(ug_asiento.Rows(i).Cells("Debe").Value), 0, ug_asiento.Rows(i).Cells("Debe").Value)) > 0 Then
                            ug_asiento.Rows(i).Cells("Debe").Value = IIf(uce_Moneda_Det.Value = 1, importe.ToString("##,##0.00"), CDbl(importe * ume_ValorTipoCambio.Value).ToString("##,##0.00"))
                        Else
                            ug_asiento.Rows(i).Cells("Haber").Value = IIf(uce_Moneda_Det.Value = 1, importe.ToString("##,##0.00"), CDbl(importe * ume_ValorTipoCambio.Value).ToString("##,##0.00"))
                        End If
                        ug_asiento.Rows(i).Cells("Soles").Value = importe.ToString("##,##0.00")
                    End If
                Next
            End If

            ug_asiento.UpdateData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReHacerSecuencia()
        Try
            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                ug_asiento.Rows(i).Cells("Item").Value = (i + 1).ToString.PadLeft("3", "0")
            Next
            ug_asiento.UpdateData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarDetalle()
        Try
            uc_Cuentas.Value = Nothing
            lbl_des_cta.Text = String.Empty
            txt_Anexo_Ruc_Det.Text = String.Empty
            lbl_Des_Anexo.Text = String.Empty
            uce_TipoDoc_Det.SelectedIndex = -1
            txt_SerieDoc_Det.Text = String.Empty
            txt_NumDoc_Det.Text = String.Empty
            ume_FecEmi_Det.Value = Nothing
            ume_FecVen_Det.Value = Nothing
            ume_Debe_Det.Value = 0
            ume_Haber_Det.Value = 0
            uce_cc.SelectedIndex = -1
            txt_Glosa_Det.Text = String.Empty

            txt_idAnexoDet.Text = String.Empty
            uchk_Inafecto.Checked = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Boxes_to_Enable(ByVal Str_MyCuenta As String)
        Try
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
            E_PlanCtas.PC_NUM_CUENTA = Str_MyCuenta.Trim
            PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)

            lbl_des_cta.Text = E_PlanCtas.PC_DESCRIPCION

            If E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                txt_Anexo_Ruc_Det.Enabled = False
            Else
                txt_Anexo_Ruc_Det.Enabled = True
            End If

            If E_PlanCtas.PC_ES_CC = 1 Then
                uce_cc.Enabled = True
            Else
                uce_cc.SelectedIndex = -1
                uce_cc.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Sumar_impInafecto_a_cta42(ByVal Dbl_Importe As Double)
        Try
            'ume_ValorNoGrabado.Value += IIf(uce_Moneda_Det.Value = 1, Dbl_Importe, Dbl_Importe * CDbl(ume_ValorTipoCambio.Value))

            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                If ug_asiento.Rows(i).Cells("Anexo").Value.ToString.Length > 0 Then

                    If Val(ug_asiento.Rows(i).Cells("Debe").Value) > 0 Then
                        ug_asiento.Rows(i).Cells("Debe").Value += Dbl_Importe
                    Else
                        ug_asiento.Rows(i).Cells("Haber").Value += Dbl_Importe
                    End If

                    Exit Sub
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Actualizar_Cuenta_en_Cabecera(ByVal Str_Cuenta_editada As String, ByVal Dbl_Importe_Editado As Double)
        Try
            Dim Dt_plantilla As List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_DET)
            Dim Ent_SD As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB
            Dim Obj_AutoDetBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_DET

            '_______________________________________________Traemos la plantilla con las cuentas
            Ent_SD.AA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Ent_SD.AA_IDSUBDIARIO = New SG_CO_TB_SUBDIARIO With {.SD_ID = uce_Subdiario.Value}
            Ent_SD.AA_ANHO = gDat_Fecha_Sis.Year

            Dt_plantilla = Obj_AutoDetBL.getDetalles_x_Sudiario(Ent_SD, uce_Moneda.Value)

            For Each DR As SG_CO_TB_ASIENTO_AUTO_DET In Dt_plantilla
                Select Case DR.AA_IDCONPCETO.CR_ID
                    Case 1 'Monto ISC
                    Case 6 'Monto Retencion 4ta
                        If DR.AA_IDCUENTA.PC_NUM_CUENTA.Equals(Str_Cuenta_editada) Then
                            ume_Monto_Rete.Value = Dbl_Importe_Editado
                            If Val(ume_Monto_Rete.Value) > 0 Then
                                ume_Monto_Perci.Value = Val(ume_Total_Hono.Value) - Val(ume_Monto_Rete.Value)
                            End If
                        End If

                    Case 3 'Otros tributos y Cargos
                    Case 7 'Valor Total
                        If CDbl(ume_Monto_Perci.Value) > 0 Then '_____________________________K sea mayor a cero pues!!

                            If DR.AA_IDCUENTA.PC_NUM_CUENTA.Equals(Str_Cuenta_editada) Then


                                If Val(ume_Monto_Rete.Value) = 0 Then
                                    ume_Monto_Perci.Value = Dbl_Importe_Editado
                                    ume_Total_Hono.Value = Dbl_Importe_Editado

                                End If

                                txt_ruc_anexo.Text = txt_Anexo_Ruc_Det.Text
                                txt_IdAnexo.Text = txt_idAnexoDet.Text
                                txt_Des_Prove.Text = lbl_Des_Anexo.Text
                                txt_cod_Doc_Cab.Text = txt_cod_Doc_Det.Text
                                uce_TipoDoc.Value = uce_TipoDoc_Det.Value
                                txt_SerieDoc.Text = txt_SerieDoc_Det.Text
                                txt_NumDoc.Text = txt_NumDoc_Det.Text
                                udte_Fec_Emi.Value = ume_FecEmi_Det.Value
                                udte_Fec_Ven.Value = ume_FecVen_Det.Value
                                txt_Glosa.Text = txt_Glosa_Det.Text


                            End If
                            'Call Add_Row(DR.AA_IDCUENTA.PC_NUM_CUENTA, udte_Fec_Emi.Value, udte_Fec_Ven.Value, uce_TipoDoc.Value, txt_SerieDoc.Text, txt_NumDoc.Text, txt_IdAnexo.Text, DR.AA_DH, ume_Precioventa.Value, True)
                        End If
                    Case 12 'Valor Compra
                    Case 16 'Monto Detracción

                    Case Else
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ug_asiento_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_asiento.DoubleClickRow
        Try
            Call EditarDetalle()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EditarDetalle()
        Try
            If ug_asiento.ActiveRow Is Nothing Then Exit Sub

            Call LimpiarDetalle()
            With ug_asiento.ActiveRow
                uc_Cuentas.Text = .Cells("Cuenta").Value.ToString
                Call Boxes_to_Enable(uc_Cuentas.Text)

                txt_Anexo_Ruc_Det.Text = String.Empty
                lbl_Des_Anexo.Text = String.Empty
                If Not .Cells("Anexo").Value.ToString = String.Empty Then
                    Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                    E_Anexo.AN_IDANEXO = ug_asiento.ActiveRow.Cells("Anexo").Value
                    AnexoBL.getAnexo(E_Anexo)

                    txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO
                    txt_Anexo_Ruc_Det.Text = E_Anexo.AN_NUM_DOC
                    lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION

                    E_Anexo = Nothing
                    AnexoBL = Nothing
                End If

                txt_cod_Doc_Det.Text = .Cells("Tip_Doc").Value.ToString
                uce_TipoDoc_Det.Value = .Cells("Tip_Doc").Value.ToString
                txt_SerieDoc_Det.Text = .Cells("Serie").Value.ToString
                txt_NumDoc_Det.Text = .Cells("Numero").Value.ToString

                If (.Cells("Fecha Emi").Value.ToString.Equals(String.Empty)) Then
                    ume_FecEmi_Det.Value = Nothing
                Else
                    If IsDate(.Cells("Fecha Emi").Value) Then
                        ume_FecEmi_Det.Value = CDate(.Cells("Fecha Emi").Value)
                    Else
                        ume_FecEmi_Det.Value = Nothing
                    End If
                End If

                If (.Cells("Fecha Emi").Value.ToString.Equals(String.Empty)) Then
                    ume_FecVen_Det.Value = Nothing
                Else
                    If IsDate(.Cells("Fecha ven").Value) Then
                        ume_FecVen_Det.Value = CDate(.Cells("Fecha ven").Value)
                    Else
                        ume_FecVen_Det.Value = Nothing
                    End If
                End If

                ume_Debe_Det.Value = IIf(.Cells("Debe").Value.ToString.Equals(String.Empty), 0, .Cells("Soles").Value.ToString)
                ume_Haber_Det.Value = IIf(.Cells("Haber").Value.ToString.Equals(String.Empty), 0, .Cells("Soles").Value.ToString)


                uce_cc.Value = .Cells("cc_id").Value.ToString


                If .Cells("TipoCam").Value.ToString.Equals(String.Empty) Then
                    uce_Moneda_Det.Value = 1
                Else
                    uce_Moneda_Det.Value = 2
                End If


                txt_Glosa_Det.Text = .Cells("Glosa").Value.ToString

                Call MostrarTabs(1, utc_Asiento, 1)

                Bol_NuevoDet = False
                lbl_des_cta.Appearance.ForeColor = Color.Black
                uc_Cuentas.Focus()

            End With
        Catch ex As Exception
            ShowError("Ocurrio un error:  " & ex.Message)
        End Try
    End Sub

    Private Sub ug_asiento_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_asiento.BeforeRowsDeleted

        e.DisplayPromptMsg = False
        e.Cancel = False

        
    End Sub

    Private Sub ug_asiento_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_asiento.AfterRowsDeleted
        Call ReHacerSecuencia()
        ug_asiento.UpdateData()
        Call Sum_Tot()
        If ug_asiento.Rows.Count > 0 Then
            ug_asiento.Focus()
            ug_asiento.Rows(0).Activate()
            ug_asiento.Rows(0).Selected = True
        End If

    End Sub

    Private Sub uce_Subdiario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Subdiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Cod_Mon_Cab_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Cod_Mon_Cab.Leave
        uce_Moneda.Value = txt_Cod_Mon_Cab.Text.Trim
    End Sub

    Private Sub txt_cod_Doc_Cab_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_Doc_Cab.Leave
        Try
            uce_TipoDoc.Value = txt_cod_Doc_Cab.Text.Trim
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Call IngresarFilas()
    End Sub

    Private Sub uc_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas.KeyDown

        If e.KeyCode = Keys.Escape Then btn_CancelarDet_Click(sender, e)
        If uc_Cuentas.Value Is Nothing Then Exit Sub

        Dim Int_TipoAnexo_Local As Integer = 0

        If e.KeyCode = Keys.Enter Then

            If lbl_des_cta.Text.Chars(0) = "*" Then Exit Sub

            Dim E_PlanCtas As New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas.Value}
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            PlanCtasBL.getCuenta(E_PlanCtas)

            Int_TipoAnexo_Local = 0
            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                Int_TipoAnexo_Local = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
            End If

            If Int_TipoAnexo_Local <> 0 Then
                txt_Anexo_Ruc_Det.Enabled = True
                txt_Anexo_Ruc_Det.Focus()
            Else
                txt_Anexo_Ruc_Det.Enabled = False
                txt_Anexo_Ruc_Det.Text = String.Empty
                txt_idAnexoDet.Text = String.Empty
                lbl_Des_Anexo.Text = String.Empty
                SendKeys.Send(vbTab)
            End If

            If E_PlanCtas.PC_ES_CC = 1 Then
                uce_cc.Enabled = True
            Else
                uce_cc.SelectedIndex = -1
                uce_cc.Enabled = False
            End If

            E_PlanCtas = Nothing
            PlanCtasBL = Nothing
        End If

        If e.KeyCode = Keys.Down Then
            uc_Cuentas.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If

    End Sub

    Private Sub txt_Anexo_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Anexo_Ruc_Det.Leave
        Try

            If uce_Subdiario.SelectedIndex = -1 Then
                Avisar("Seleccione un subdiario.")
                uce_Subdiario.Focus()
                Exit Sub
            End If

            Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO

            Dim E_Anexo As New SG_CO_TB_ANEXO
            Dim E_SubDiario As New SG_CO_TB_SUBDIARIO
            E_SubDiario.SD_ID = uce_Subdiario.Value
            E_SubDiario.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Anexo.AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Anexo.AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Obj_TipoAnexoBL.getTipoAnexo_x_SubDiario_Hono(E_SubDiario)}
            E_Anexo.AN_NUM_DOC = txt_Anexo_Ruc_Det.Text.Trim
            Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

            If E_Anexo.AN_DESCRIPCION.Length = 0 Then
                lbl_Des_Anexo.Text = "*El anexo no existe."
                txt_Anexo_Ruc_Det.Text = ""
                txt_idAnexoDet.Text = ""
            Else
                lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION
                txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO
            End If

            E_Anexo = Nothing
            Obj_AnexoBL = Nothing
            Obj_TipoAnexoBL.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Anexo_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Anexo_Ruc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then txt_idAnexoDet.Focus()
        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Det()
    End Sub

    Private Sub txt_cod_Doc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_Doc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_cod_Doc_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_Doc_Det.Leave
        uce_TipoDoc_Det.Value = txt_cod_Doc_Det.Value
    End Sub

    Private Sub uce_TipoDoc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_SerieDoc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_NumDoc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Cod_Mon_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Cod_Mon_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Cod_Mon_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Cod_Mon_Det.Leave
        Try
            If uce_Moneda.Items.Count = 0 Then
                Avisar("No se han cargado las monedas del sistema.")
                uce_Moneda.Focus()
                Exit Sub
            End If

            Dim Obj_MonedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
            Dim E_moneda As New SG_CO_TB_MONEDA With {.MO_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}, .MO_CODIGO = txt_Cod_Mon_Det.Text.Trim}
            Obj_MonedaBL.getMoneda(E_moneda)

            uce_Moneda_Det.Value = E_moneda.MO_CODIGO

            E_moneda = Nothing
            Obj_MonedaBL = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Moneda_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_FecEmi_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_FecEmi_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_FecVen_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_FecVen_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Debe_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Debe_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Haber_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Haber_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_cc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Glosa_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Glosa_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Debe_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_Debe_Det.Leave
        Try
            If IsDBNull(ume_Debe_Det.Value) Then
                ume_Debe_Det.Value = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ume_Haber_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_Haber_Det.Leave
        Try
            If IsDBNull(ume_Haber_Det.Value) Then
                ume_Haber_Det.Value = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uchk_Ocultar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Ocultar.CheckedChanged
        Call Ocultar_Columnas(uchk_Ocultar.Checked)
    End Sub

    Private Sub txt_NumDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc.Leave

        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(10, "0")
        Call mBuscar_Documento(uce_TipoDoc.Value, txt_SerieDoc.Text.Trim, txt_NumDoc.Text.Trim, gInt_IdEmpresa, txt_IdAnexo.Text, IIf(uchkRelacionado.Checked, cuenta42_relacionada, cuenta42), CDate(udte_Fec_Emi.Value).Year)

    End Sub

    Private Sub uce_Moneda_Det_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Moneda_Det.ValueChanged
        txt_Cod_Mon_Det.Text = uce_Moneda_Det.Value
    End Sub

    Public Sub CargarVoucher_to_Copy(ByVal Ent_cabecera As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB)
        Try
            Bol_Edicion = False
            Bol_Copy = True
            Int_IdCab_Edit = Ent_cabecera.AC_ID
            Dim Ds_Voucher As DataSet = Obj_Voucher.getVouchers_x_Id(Ent_cabecera)
            '____________________________________________________________________________Llenamos la cabecera

            If Ds_Voucher.Tables(0).Rows.Count > 0 Then '__________________________Tabla Cabecera
                With Ds_Voucher.Tables(0).Rows(0)
                    uce_Subdiario.Value = .Item("AC_IDSUBDIARIO")
                    'txt_Num_Voucher.Text = .Item("AC_NUM_VOUCHER")
                    uce_TipoCambio.Value = .Item("AC_TC_FORMATO")
                    ume_ValorTipoCambio.Value = .Item("AC_TC_OPE")
                    txt_Glosa.Text = .Item("AC_GLOSA_VOU")
                    uce_Moneda.Value = .Item("AC_IDMONEDA")
                    txt_Cod_Mon_Cab.Text = .Item("AC_IDMONEDA")
                End With
            End If

            If Ds_Voucher.Tables(2).Rows.Count > 0 Then '__________________________Tabla Compras
                With Ds_Voucher.Tables(2).Rows(0)

                    Int_TipoAnexo = .Item("CO_TIPO_ANEXO")

                    txt_IdAnexo.Text = .Item("CO_ANEXO_ID")
                    Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_IdAnexo.Text}
                    Obj_AnexoBL.getAnexo(E_Anexo)

                    txt_ruc_anexo.Text = E_Anexo.AN_NUM_DOC
                    txt_Des_Prove.Text = E_Anexo.AN_DESCRIPCION

                    uce_TipoDoc.Value = .Item("CO_TIP_DOC")
                    txt_cod_Doc_Cab.Text = .Item("CO_TIP_DOC")
                    txt_SerieDoc.Text = .Item("CO_SER_DOC")
                    txt_NumDoc.Text = .Item("CO_NUM_DOC")
                    udte_Fec_Emi.Value = .Item("co_FEC_EMI")
                    udte_Fec_Ven.Value = .Item("co_FEC_VEN")
                    udte_fec_Vou.Value = .Item("co_FEC_VOU")

                    ume_Total_Hono.Value = .Item("CO_TOTAL_HONO")
                    ume_Monto_Rete.Value = .Item("CO_MONTO_RET")
                    ume_Monto_Perci.Value = .Item("CO_MONTO_PERCI")

                End With
            End If
            '____________________________________________________________________________Llenamos el detalle

            Call LimpiaGrid(ug_asiento, uds_Asiento)


            If Ds_Voucher.Tables(1).Rows.Count > 0 Then
                With Ds_Voucher.Tables(1)
                    For i As Integer = 0 To .Rows.Count - 1
                        ug_asiento.DisplayLayout.Bands(0).AddNew()
                        Dim Int_NumFilas As Integer = ug_asiento.Rows.Count

                        ug_asiento.Rows(i).Cells("Item").Value = .Rows(i)("AD_SECUENCIA").ToString.PadLeft("3", "0")
                        ug_asiento.Rows(i).Cells("Cuenta").Value = .Rows(i)("ad_cuenta").ToString

                        Dim Obj_PlanCtas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                        E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
                        E_PlanCtas.PC_NUM_CUENTA = .Rows(i)("ad_cuenta").ToString

                        Obj_PlanCtas.getCuenta_X_NumeroCta(E_PlanCtas)

                        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                            ug_asiento.Rows(i).Cells("Descripcion").Value = txt_Des_Prove.Text
                        Else
                            ug_asiento.Rows(i).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION
                        End If

                        ug_asiento.Rows(i).Cells("TipoAnexo").Value = .Rows(i)("AD_TANEXO").ToString

                        If Ds_Voucher.Tables(1).Rows(i)("AD_FDOC").ToString.Trim.Length = 0 Then
                            'ug_asiento.Rows(i).Cells("Fecha Emi").Value = ""
                        Else
                            ug_asiento.Rows(i).Cells("Fecha Emi").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_FDOC")).ToShortDateString
                        End If

                        If Ds_Voucher.Tables(1).Rows(i)("AD_VDOC").ToString.Trim.Length = 0 Then
                            'ug_asiento.Rows(i).Cells("Fecha ven").Value = ""
                        Else
                            ug_asiento.Rows(i).Cells("Fecha ven").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_VDOC")).ToShortDateString
                        End If

                        ug_asiento.Rows(i).Cells("Tip_Doc").Value = .Rows(i)("AD_TDOC").ToString
                        ug_asiento.Rows(i).Cells("Serie").Value = .Rows(i)("AD_SDOC").ToString
                        ug_asiento.Rows(i).Cells("Numero").Value = .Rows(i)("AD_NDOC").ToString
                        ug_asiento.Rows(i).Cells("Anexo").Value = .Rows(i)("AD_IDANEXO").ToString
                        If .Rows(i)("AD_DEBE") > 0 Then
                            ug_asiento.Rows(i).Cells("Debe").Value = Convert.ToDouble(.Rows(i)("AD_DEBE")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_HABER") > 0 Then
                            ug_asiento.Rows(i).Cells("Haber").Value = Convert.ToDouble(.Rows(i)("AD_HABER")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_TCAM") > 0 Then
                            ug_asiento.Rows(i).Cells("TipoCam").Value = .Rows(i)("AD_TCAM")
                        Else
                            ug_asiento.Rows(i).Cells("TipoCam").Value = Nothing
                        End If

                        ug_asiento.Rows(i).Cells("Glosa").Value = .Rows(i)("AD_GLOSA").ToString
                        ug_asiento.Rows(i).Cells("Es_Destino").Value = .Rows(i)("AD_ES_DESTINO").ToString
                        ug_asiento.Rows(i).Cells("cc_id").Value = IIf(.Rows(i)("AD_IDCC").ToString.Equals(String.Empty), 0, .Rows(i)("AD_IDCC"))
                        ug_asiento.Rows(i).Cells("Soles").Value = .Rows(i)("AD_MONTO_ORI")
                        ug_asiento.Rows(i).Cells("porce_destino").Value = .Rows(i)("AD_PORCE_DESTINO")

                        ' si todo esta ok actualizamos la data confirmandola!
                        ug_asiento.UpdateData()
                    Next
                End With
            End If

            Call Sum_Tot()

            btn_Nuevo.Enabled = True

            'ugb_Cabecera.Enabled = False

            Call MostrarTabs(0, utc_Asiento, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub uc_Cuentas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas.ValueChanged
        Try
            lbl_des_cta.Text = uc_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta.Text = "*La cuenta no existe!"
            lbl_des_cta.Appearance.ForeColor = Color.Red
        End Try

    End Sub

    Private Sub txt_NumDoc_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc_Det.Leave
        Try
            If txt_NumDoc_Det.Text.Trim.Length > 0 Then
                txt_NumDoc_Det.Text = txt_NumDoc_Det.Text.PadLeft(10, "0")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ubtn_CrearAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_CrearAnexo.Click
        Try
            CO_PR_Reg_AnexoNuevo.Int_TipoAnexo = 4
            CO_PR_Reg_AnexoNuevo.ShowDialog()
            If CO_PR_Reg_AnexoNuevo.GetBol_Aceptar Then
                txt_ruc_anexo.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_NUM_DOC
                txt_IdAnexo.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_IDANEXO
                txt_Des_Prove.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_DESCRIPCION
                udte_fec_Vou.Focus()
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Impresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Impresion.Click
        Try
            If txt_IdCabecera.Text.Trim.Length = 0 Then Exit Sub
            Call Ver_Impresion_Voucher(udte_fec_Vou.Value, "Honorarios", uce_Subdiario.Text, txt_Num_Voucher.Text, txt_Glosa.Text, txt_IdCabecera.Text)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_Glosa_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Glosa.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_getAnexo"
                txt_Glosa.Text = txt_Des_Prove.Text.Trim
        End Select
    End Sub

    Private Sub udte_fec_Vou_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles udte_fec_Vou.Validated

        Try

            If udte_fec_Vou.Value Is Nothing Then Exit Sub

            Dim Bol_EstaCerrado As Boolean = False

            'Validamos que el año no este cerrado
            If Verificar_Anho_Cerrado(CDate(udte_fec_Vou.Value).Year) Then
                udte_fec_Vou.SelectAll()
                udte_fec_Vou.Focus()
                Exit Sub
            End If



            Call Verificar_Mes_Cerrado(Me, CDate(udte_fec_Vou.Value).Year, CDate(udte_fec_Vou.Value).Month, Bol_EstaCerrado)

            If Bol_EstaCerrado Then
                ugb_Cabecera.Enabled = True
                udte_fec_Vou.Enabled = True
                ubtn_Salir.Enabled = True
                'udte_fec_Vou.Focus()
            Else
                ugb_Cabecera.Enabled = True
                udte_fec_Vou.Enabled = True


                ubtn_Impresion.Enabled = True
                ubtn_Cancelar.Enabled = True
                ubtn_GrabarVoucher.Enabled = True
                ubtn_Salir.Enabled = True
                'udte_fec_Vou.Focus()
            End If


            If Not udte_fec_Vou.Value Is Nothing Then Call Cargar_Tasas_Impuestos()


            'valiadamos que el mes del voucher corresponda el mes del numero de voucher

            If txt_Num_Voucher.Text.Trim.Length > 0 Then
                Dim tmp As String = txt_Num_Voucher.Text.Substring(2, 2)
                Dim mes_fecha As String = CDate(udte_fec_Vou.Value).Month.ToString.PadLeft(2, "0")
                If mes_fecha <> tmp Then
                    Avisar("El numero de voucher depende de la fecha de voucher." & Chr(13) & "Vuelva a ingresar el numero para validar.")
                    txt_Num_Voucher.Text = ""
                    txt_Num_Voucher.Appearance.Image = Nothing
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub udte_fec_Vou_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fec_Vou.ValueChanged
        udte_Fec_Emi.Value = udte_fec_Vou.Value
        udte_Fec_Ven.Value = udte_fec_Vou.Value
        Call Obtener_TipoCambio_dia()
    End Sub

    Private Sub Obtener_TipoCambio_dia()
        Try

            If udte_fec_Vou.Value Is Nothing Then Exit Sub

            Dim Obj_tcBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim E_tc As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
            E_tc.TC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_tc.TC_FECHA = CDate(udte_fec_Vou.Value).ToShortDateString
            E_tc.TC_IDMONEDA = New SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            Obj_tcBL.getTipoCambio(E_tc)
            Select Case uce_TipoCambio.Value
                Case 1
                    ume_ValorTipoCambio.Value = E_tc.TC_COMPRA
                Case 2
                    ume_ValorTipoCambio.Value = E_tc.TC_VENTA
                Case 3
                    ume_ValorTipoCambio.Value = 0
                    ume_ValorTipoCambio.Focus()
            End Select

            E_tc = Nothing
            Obj_tcBL = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Actualizar_Importe_Cabecera()
        Try
            'Este proceso suma las cuentas del asiento para obtener los importes del total hono, la retencion, el monto percibido
            'para esto suma acumulando por cuenta tipo(compras,retencion,honorarios)
            'luego de sumar y acumular por cuenta tipo se actualiza en las cajas de la cabecera
            'estas valores de la cabecera son los que se guardan en la tabla de reg. de compras
            'la configuracion de las cuentas tipo estan en Menu/Maestros/Registros CVH

            Dim Dbl_Monto_Gasto_Hono As Double = 0
            Dim Dbl_Retencion As Double = 0
            Dim Dbl_Total_Honorario As Double = 0
            Dim Dbl_Inafecto As Double = 0

            Dim RegistrosBL As New BL.ContabilidadBL.SG_CO_TB_REG_COM_VTA_HON
            Dim RegistrosBE As New BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON
            Dim MiLista As New List(Of BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON)


            With RegistrosBE
                .RE_ID_OPERACION = New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = 4}
                .RE_ID_TIPOCUENTA = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA With {.TC_ID = 3} 'Anexo Honorarios
                .RE_ANHO = gDat_Fecha_Sis.Year
                .RE_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With
            MiLista = RegistrosBL.getRegistros(RegistrosBE)

            'Honorario la cta 424001
            For i As Integer = 0 To MiLista.Count - 1
                For f As Integer = 0 To ug_asiento.Rows.Count - 1
                    If ug_asiento.Rows(f).Cells("Cuenta").Value.ToString.Substring(0, MiLista(i).RE_NUM_CTA.PC_NUM_CUENTA.Length) = MiLista(i).RE_NUM_CTA.PC_NUM_CUENTA Then
                        If Val(ug_asiento.Rows(f).Cells("Debe").Value.ToString) > 0 Then
                            Dbl_Total_Honorario = Dbl_Total_Honorario + ug_asiento.Rows(f).Cells("Debe").Value
                        Else
                            Dbl_Total_Honorario = Dbl_Total_Honorario + ug_asiento.Rows(f).Cells("Haber").Value
                        End If
                    End If
                Next
            Next


            'La retencion la cuenta 40
            RegistrosBE.RE_ID_TIPOCUENTA = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA With {.TC_ID = 6} 'RETENCION 10%
            MiLista = RegistrosBL.getRegistros(RegistrosBE)

            For i As Integer = 0 To MiLista.Count - 1
                For f As Integer = 0 To ug_asiento.Rows.Count - 1
                    If ug_asiento.Rows(f).Cells("Cuenta").Value.ToString.Substring(0, MiLista(i).RE_NUM_CTA.PC_NUM_CUENTA.Length) = MiLista(i).RE_NUM_CTA.PC_NUM_CUENTA Then
                        If Val(ug_asiento.Rows(f).Cells("Haber").Value.ToString) > 0 Then
                            Dbl_Retencion = Dbl_Retencion + ug_asiento.Rows(f).Cells("Haber").Value
                        Else
                            Dbl_Retencion = Dbl_Retencion + ug_asiento.Rows(f).Cells("Debe").Value
                        End If
                    End If
                Next
            Next




            'El Gasto de Honorario la cuenta 60
            RegistrosBE.RE_ID_TIPOCUENTA = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA With {.TC_ID = 8} 'base imponible
            MiLista = RegistrosBL.getRegistros(RegistrosBE)

            For i As Integer = 0 To MiLista.Count - 1
                For f As Integer = 0 To ug_asiento.Rows.Count - 1
                    If ug_asiento.Rows(f).Cells("Cuenta").Value.ToString.Substring(0, MiLista(i).RE_NUM_CTA.PC_NUM_CUENTA.Length) = MiLista(i).RE_NUM_CTA.PC_NUM_CUENTA Then
                        If Val(ug_asiento.Rows(f).Cells("Haber").Value.ToString) > 0 Then
                            Dbl_Monto_Gasto_Hono = Dbl_Monto_Gasto_Hono + ug_asiento.Rows(f).Cells("Haber").Value
                        Else
                            Dbl_Monto_Gasto_Hono = Dbl_Monto_Gasto_Hono + ug_asiento.Rows(f).Cells("Debe").Value
                        End If
                    End If
                Next
            Next

            ume_Total_Hono.Value = Dbl_Monto_Gasto_Hono
            ume_Monto_Rete.Value = Dbl_Retencion
            ume_Monto_Perci.Value = Dbl_Total_Honorario

            RegistrosBE = Nothing
            RegistrosBL = Nothing
            MiLista = Nothing


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_Anexo_Ruc_Det_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Anexo_Ruc_Det.EditorButtonClick
        Try
            Call Ayuda_Anexo_Det()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_cc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_cc.KeyDown
        If e.KeyCode = Keys.Delete Then
            uce_cc.SelectedIndex = -1
        End If

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

    End Sub

    Private Sub txt_SerieDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SerieDoc.Leave
        txt_SerieDoc.Text = txt_SerieDoc.Text.PadLeft(4, "0")
    End Sub

    Private Sub txt_NumDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc.ValueChanged

    End Sub

    Private Sub uce_Subdiario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Subdiario.ValueChanged
        Cargar_Cuentas_Anexo()
    End Sub

    Private Sub udte_Fec_Emi_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_Fec_Emi.Enter
        udte_Fec_Emi.SelectAll()
    End Sub

    Private Sub udte_Fec_Ven_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_Fec_Ven.Enter
        udte_Fec_Ven.SelectAll()
    End Sub

    Private Sub ume_Total_Hono_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_Total_Hono.Enter
        ume_Total_Hono.SelectAll()
    End Sub

    Private Sub txt_IdAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdAnexo.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            anexoBE.AN_IDANEXO = txt_IdAnexo.Text.Trim
            anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            anexoBL.getAnexo_id_idemp(anexoBE)

            If anexoBE.AN_NUM_DOC.Trim <> String.Empty Then
                If anexoBE.AN_TIPO_ANEXO.TA_CODIGO = TipoA.Honorarios Then
                    txt_ruc_anexo.Text = anexoBE.AN_NUM_DOC
                    txt_Des_Prove.Text = anexoBE.AN_DESCRIPCION
                    udte_fec_Vou.Focus()
                Else
                    Avisar("El codigo no es de Honorarios")
                    txt_ruc_anexo.Text = ""
                    txt_Des_Prove.Text = "*El anexo no existe!"
                    udte_fec_Vou.Focus()
                End If

            Else
                txt_ruc_anexo.Text = ""
                txt_Des_Prove.Text = "*El anexo no existe!"
                udte_fec_Vou.Focus()
            End If

            anexoBL = Nothing
            anexoBE = Nothing
        End If
    End Sub

    Private Sub txt_Num_Voucher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Num_Voucher.TextChanged
        If txt_Num_Voucher.Text.Trim.Length = 0 Then
            txt_Num_Voucher.Appearance.Image = Nothing
        End If
    End Sub

    Private Sub txt_Num_Voucher_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Num_Voucher.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                'Buscamos el  numero de Voucher si ya existe para evisar por mensaje
                If txt_Num_Voucher.Text.Trim <> String.Empty Then

                    If udte_fec_Vou.Value Is Nothing Then
                        Avisar("Ingrese la fecha del voucher primero ")
                        txt_Num_Voucher.Text = String.Empty
                        udte_fec_Vou.Focus()
                        Exit Sub
                    End If

                    Dim mes As String = CDate(udte_fec_Vou.Value).Month.ToString.PadLeft(2, "0")
                    Dim numero As String = "03" & mes & txt_Num_Voucher.Text.PadLeft(6, "0")
                    Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE

                    If asientoBL.Existe_Num_Voucher(numero, gDat_Fecha_Sis.Year, gInt_IdEmpresa) Then
                        Call Avisar("El numero de voucher ya esta registrado.")
                        txt_Num_Voucher.Appearance.Image = Nothing
                        txt_Num_Voucher.SelectAll()
                        txt_Num_Voucher.Focus()
                    Else
                        txt_Num_Voucher.Appearance.Image = My.Resources.checkmark
                        txt_Num_Voucher.Text = numero
                        txt_ruc_anexo.Focus()
                    End If

                    asientoBL = Nothing
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txt_SerieDoc_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SerieDoc_Det.Leave
        If txt_SerieDoc_Det.Text.Length > 0 Then
            txt_SerieDoc_Det.Text = txt_SerieDoc_Det.Text.PadLeft(4, "0")
        End If
    End Sub

    Private Sub txt_idAnexoDet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idAnexoDet.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

            anexoBE.AN_IDANEXO = Val(txt_idAnexoDet.Text.Trim)
            anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            anexoBL.getAnexo_id_idemp(anexoBE)

            If anexoBE.AN_NUM_DOC.Trim <> String.Empty Then
                If anexoBE.AN_TIPO_ANEXO.TA_CODIGO = TipoA.Honorarios Then
                    txt_Anexo_Ruc_Det.Text = anexoBE.AN_NUM_DOC
                    lbl_Des_Anexo.Text = anexoBE.AN_DESCRIPCION
                    txt_cod_Doc_Det.Focus()
                Else
                    Avisar("El codigo no es de Honorarios no existe, Verifique")
                    txt_Anexo_Ruc_Det.Text = ""
                    lbl_Des_Anexo.Text = "*El Anexo no existe!"
                    txt_cod_Doc_Det.Focus()
                End If

            Else
                txt_Anexo_Ruc_Det.Text = ""
                lbl_Des_Anexo.Text = "*El Anexo no existe!"
                txt_cod_Doc_Det.Focus()
            End If

            anexoBL = Nothing
            anexoBE = Nothing

        End If
    End Sub
End Class