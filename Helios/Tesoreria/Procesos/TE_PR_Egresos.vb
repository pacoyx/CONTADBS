Public Class TE_PR_Egresos

    Private Sub TE_PR_Egresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        udte_Voucher.Value = gDat_Fecha_Sis

        Call Cargar_TipoAnexos()
        Call Cargar_Documentos()
        Call Cargar_Cmb_Monedas()
        Call Cargar_MedioPago()
        Call Cargar_CentroCosto()
        Call Cargar_Conceptos()
        Call Cargar_Bancos()

        ugb_detalle.Enabled = False
        uce_TipoAnexo.SelectedIndex = 1
        uce_Concepto.SelectedIndex = 0
        uce_Comprobante.Value = 17
        uce_Moneda.SelectedIndex = 0
        uce_MedioPago.SelectedIndex = -1
        uce_centrocosto.SelectedIndex = -1

    End Sub

    Private Sub Cargar_Bancos()
        Dim BancosBL As New BL.ContabilidadBL.SG_CO_TB_BANCO
        Dim BancosBE As New BE.ContabilidadBE.SG_CO_TB_BANCO
        BancosBE.BA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_Banco.DataSource = BancosBL.getBancos(BancosBE)
        uce_Banco.DisplayMember = "BA_NOMBRE"
        uce_Banco.ValueMember = "BA_ID"

        BancosBE = Nothing
        BancosBL = Nothing

    End Sub

    Private Sub Cargar_TipoAnexos()
        Dim TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
        uce_TipoAnexo.DataSource = TipoAnexoBL.getTipoAnexos()
        uce_TipoAnexo.DisplayMember = "TA_DESCRIPCION"
        uce_TipoAnexo.ValueMember = "TA_CODIGO"
        TipoAnexoBL = Nothing
    End Sub

    Private Sub Cargar_Documentos()

        Dim DocumentoBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        Dim DocumentoBE As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
        DocumentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        uce_Comprobante.DataSource = DocumentoBL.getDocumentos(DocumentoBE)
        uce_Comprobante.DisplayMember = "DO_DESCRIPCION"
        uce_Comprobante.ValueMember = "DO_CODIGO"

        DocumentoBE = Nothing
        DocumentoBL = Nothing


    End Sub

    Private Sub Cargar_Cmb_Monedas()
        Dim MonedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
        uce_Moneda.DataSource = MonedaBL.getMonedas()
        uce_Moneda.DisplayMember = "MO_DESCRIPCION"
        uce_Moneda.ValueMember = "MO_CODIGO"
        MonedaBL = Nothing
    End Sub

    Public Sub Cargar_MedioPago()
        Dim MedioBL As New BL.ContabilidadBL.SG_CO_TB_MEDIOPAGO
        uce_MedioPago.DataSource = MedioBL.getMedios
        uce_MedioPago.DisplayMember = "MP_DESCRIPCION"
        uce_MedioPago.ValueMember = "MP_CODIGO"
        MedioBL = Nothing
    End Sub

    Private Sub Cargar_CentroCosto()
        Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO With {.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        uce_centrocosto.DataSource = ccBL.getCentroCostos(ccBE)
        uce_centrocosto.DisplayMember = "CC_DESCRIPCION"
        uce_centrocosto.ValueMember = "CC_CODIGO"
        ccBL = Nothing
        ccBE = Nothing
    End Sub

    Private Sub getTipodeCambio()

        Dim tipoCambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
        Dim tipoCambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
        tipoCambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        tipoCambioBE.TC_FECHA = CDate(udte_Voucher.Value).ToShortDateString
        tipoCambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
        tipoCambioBL.getTipoCambio(tipoCambioBE)
        ume_ValorTipoCambio.Value = 0
        ume_ValorTipoCambio.Value = tipoCambioBE.TC_VENTA
        tipoCambioBL = Nothing
        tipoCambioBE = Nothing

    End Sub

    Private Sub Cargar_Conceptos()
        Dim conceptosBL As New BL.TesoreriaBL.SG_TE_TB_CONCEPTOS_MOV
        Dim conceptosBE As New BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV

        conceptosBE.CM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        conceptosBE.CM_IDTIPO_MOV = New BE.TesoreriaBE.SG_TE_TB_TIPO_MOVIMIENTO With {.TM_ID = 2}

        uce_Concepto.DataSource = conceptosBL.getConceptos(conceptosBE)
        uce_Concepto.DisplayMember = "CM_DESCRIPCION"
        uce_Concepto.ValueMember = "CM_ID"

        conceptosBE = Nothing
        conceptosBL = Nothing

    End Sub

    Private Sub Ayuda_Proveedor_Cab()

        CO_MT_Buscar.Int_Opcion = 4
        CO_MT_Buscar.Int_TipoAnexo = uce_TipoAnexo.Value
        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_ruc_anexo.Text = matriz(2)
            txt_IdAnexo.Text = matriz(0)
            txt_Des_Prove.Text = matriz(3)
        End If

        txt_ruc_anexo.Focus()


    End Sub

    Private Sub udte_fec_Vou_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_Voucher.ValueChanged
        Call getTipodeCambio()
    End Sub

    Private Sub txt_ruc_anexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_anexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor_Cab()
        End If
    End Sub

    Private Sub uce_TipoAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoAnexo.KeyDown, uce_Concepto.KeyDown, uce_Comprobante.KeyDown, uce_CuentaBancaria.KeyDown, uce_Banco.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_SerieDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_NumDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_Moneda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_centrocosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_centrocosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Glosa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Glosa.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

        If e.KeyCode = Keys.Down Then
            If txt_Des_Prove.Text.Trim.Length = 0 Then
                txt_Glosa.Text = uce_Concepto.Text
            Else
                txt_Glosa.Text = "Pago " & txt_Des_Prove.Text
            End If

        End If
    End Sub

    Private Sub ume_ValorTipoCambio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_ValorTipoCambio.KeyDown, ume_importe_Ori.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_Moneda.Value = 1 Then 'soles
                ume_Importe_Mov.Value = Double.Parse(ume_importe_Ori.Value)
            Else
                ume_Importe_Mov.Value = Math.Round(Double.Parse(ume_importe_Ori.Value) * Double.Parse(ume_ValorTipoCambio.Value), 2)
            End If
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub udte_fec_compro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_Voucher.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_MedioPago_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_MedioPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ubtn_CrearAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_CrearAnexo.Click
        CO_PR_Reg_AnexoNuevo.ShowDialog()
        If CO_PR_Reg_AnexoNuevo.GetBol_Aceptar Then
            txt_ruc_anexo.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_NUM_DOC
            txt_IdAnexo.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_IDANEXO
            txt_Des_Prove.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_DESCRIPCION
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Call Limpiar_Controls_InGroupox(ugb_cabecera)

    End Sub

    Private Sub uce_Banco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Banco.ValueChanged
        Dim cuentaBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CTACTE
        Dim cuentaBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE

        cuentaBE.BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = uce_Banco.Value}
        uce_CuentaBancaria.DataSource = cuentaBL.getCtasCorrientes_dt(cuentaBE)
        uce_CuentaBancaria.DisplayMember = "DESCRIPCION"
        uce_CuentaBancaria.ValueMember = "BC_ID_CTA"
        uce_CuentaBancaria.SelectedIndex = 0

        cuentaBE = Nothing
        cuentaBL = Nothing
    End Sub

    Private Sub uce_Comprobante_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Comprobante.ValueChanged
        If uce_Comprobante.Value = 17 Then
            uce_MedioPago.Value = "007"
        Else
            uce_MedioPago.SelectedIndex = -0
        End If
    End Sub

    Public Sub Agregar_Documentos_Pendientes()
        Dim ListaDocPendiente As New List(Of Cls_DocPendientes)
        Dim item As Cls_DocPendientes

        CO_PR_DocPendientes.Str_Cuenta = String.Empty
        CO_PR_DocPendientes.Int_Anexo = txt_IdAnexo.Text.Trim
        CO_PR_DocPendientes.ShowDialog()
        ListaDocPendiente = CO_PR_DocPendientes.getListaDocs

        Dim i As Integer = 0
        For Each item In ListaDocPendiente

            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(i).Cells("Tipo").Value = item.tdoc
            ug_detalle.Rows(i).Cells("Serie").Value = item.sdoc
            ug_detalle.Rows(i).Cells("Documento").Value = item.ndoc
            ug_detalle.Rows(i).Cells("importe").Value = IIf(item.debe > 0, item.debe, item.haber)

            ug_detalle.Rows(i).Cells("comentario").Value = ""


            'Busco el codigo del documento por el nombre
            Dim Str_Cod_Doc As String = String.Empty
            Dim DocumentoBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
            Dim DocumentoBE As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            DocumentoBE.DO_DESCRIPCION = item.tdoc.Trim
            DocumentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            DocumentoBL.getDocumentos_x_Descripcion(DocumentoBE)

            Str_Cod_Doc = DocumentoBE.DO_CODIGO

            DocumentoBE = Nothing
            DocumentoBL = Nothing




            'Busco por el Id del Detalle si es en Dolares.
            Dim DetalleBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim DetalleBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim DetalleBE2 As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim Bol_EsDolar As Boolean = False

            DetalleBE.AD_IDCAB = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB With {.AC_ID = ListaDocPendiente(i).ID_MIN}
            DetalleBE.AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Str_Cod_Doc}
            DetalleBE.AD_SDOC = item.sdoc
            DetalleBE.AD_NDOC = item.ndoc
            'DetalleBE.AD_CUENTA = uc_Cuentas.Text.Trim
            DetalleBE.AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_IdAnexo.Text.Trim}
            Try
                DetalleBE2 = DetalleBL.getDetalle_x_Id_2(DetalleBE)
            Catch ex As Exception
                'GoTo Saltar_punto1
            End Try

            If Not DetalleBE2 Is Nothing Then

                Bol_EsDolar = False
                If DetalleBE2.AD_TCAM > 0 Then Bol_EsDolar = Not Bol_EsDolar

                If Bol_EsDolar Then
                    ug_detalle.Rows(i).Cells("importe_ori").Value = DetalleBE2.AD_MONTO_ORI
                    ug_detalle.Rows(i).Cells("tc").Value = DetalleBE2.AD_TCAM
                Else
                    ug_detalle.Rows(i).Cells("importe_ori").Value = 0
                    ug_detalle.Rows(i).Cells("tc").Value = 0
                End If

                ug_detalle.Rows(i).Cells("cuenta").Value = DetalleBE2.AD_CUENTA
                ug_detalle.Rows(i).Cells("cod_TD").Value = Str_Cod_Doc
                ug_detalle.Rows(i).Cells("fecha_TD").Value = DetalleBE2.AD_FDOC

            End If

            DetalleBE2 = Nothing
            DetalleBE = Nothing
            DetalleBL = Nothing


            i += 1
        Next
        ug_detalle.UpdateData()

        Call Sumar_Soles_Dolares()
    End Sub

    Private Sub Agregar_De_ListaConceptos()
        Dim dt_detalles As DataTable = Nothing
        Dim ListaBL As New BL.TesoreriaBL.SG_TE_TB_CONCEPTOS_MOV_LISTAS
        Dim ListaBE As New BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV_LISTAS
        ListaBE.CL_IDCONCEPTO = uce_Concepto.Value
        dt_detalles = ListaBL.getListas(ListaBE)


        TE_PR_Lista_Auxi.Dt_Data = dt_detalles
        TE_PR_Lista_Auxi.ShowDialog()

        If TE_PR_Lista_Auxi.Bol_Aceptar Then
            Dim mylista As New List(Of BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV_LISTAS)
            mylista = TE_PR_Lista_Auxi.mylista

            Dim i As Integer = 0
            For Each item As BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV_LISTAS In mylista
                ug_detalle.DisplayLayout.Bands(0).AddNew()
                ug_detalle.Rows(i).Cells("Tipo").Value = String.Empty
                ug_detalle.Rows(i).Cells("Serie").Value = String.Empty
                ug_detalle.Rows(i).Cells("documento").Value = String.Empty
                ug_detalle.Rows(i).Cells("importe").Value = 0
                ug_detalle.Rows(i).Cells("importe_ori").Value = 0
                ug_detalle.Rows(i).Cells("comentario").Value = item.CL_ITEM
                ug_detalle.Rows(i).Cells("tc").Value = 0
                ug_detalle.Rows(i).Cells("cuenta").Value = item.CL_CUENTA
                ug_detalle.Rows(i).Cells("cod_TD").Value = 0
                ug_detalle.Rows(i).Cells("fecha_TD").Value = Now.Date
                i += 1
            Next
            ug_detalle.UpdateData()

            ug_detalle.DisplayLayout.Bands(0).Columns("importe").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        End If
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_add_auxi.Click

        Dim conceptoBL As New BL.TesoreriaBL.SG_TE_TB_CONCEPTOS_MOV
        Dim conceptoBE As New BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV
        conceptoBE.CM_ID = uce_Concepto.Value
        conceptoBL.getConceptos_x_Id(conceptoBE)

        If conceptoBE.CM_ES_DOCUMENTO = 1 Then
            Call Agregar_Documentos_Pendientes()
        Else
            If conceptoBE.CM_ES_DETALLE = 1 Then
                'listamos los Item que estan en la lista de detalles como AFP's
                Call Agregar_De_ListaConceptos()
            Else
                'aki agregamos line por linea pidiendo referencia




            End If
        End If









    End Sub

    Private Sub Sumar_Soles_Dolares()
        Dim soles As Double = 0
        Dim dolares As Double = 0

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells("importe").Value.ToString <> String.Empty Then
                soles += ug_detalle.Rows(i).Cells("importe").Value
            End If

            If ug_detalle.Rows(i).Cells("importe_ori").Value.ToString <> String.Empty Then
                dolares += ug_detalle.Rows(i).Cells("importe_ori").Value
            End If
        Next

        txt_total_soles.Text = soles.ToString("##,##0.00")
        txt_total_dolares.Text = dolares.ToString("##,##0.00")
    End Sub


    Private Sub btn_ListoCab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ListoCab.Click
        ugb_detalle.Enabled = True
        ubtn_add_auxi.Focus()
    End Sub

    Private Sub txt_ruc_anexo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_anexo.EditorButtonClick
        Select Case e.Button.Key
            Case "Ayuda"
                Call Ayuda_Proveedor_Cab()
            Case ""

        End Select
    End Sub


    Private Sub UltraTextEditor1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_deducir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_deducir.CheckedChanged
        ume_importe_Ori.Value = 0
        ume_importe_Ori.Enabled = Not uchk_deducir.Checked
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        Dim CabeceraBE As New BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_C
        Dim DetalleBE As BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_D
        Dim Lista_Det As New List(Of BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_D)
        Dim MovimientosBL As New BL.TesoreriaBL.SG_TE_TB_MOVIMIENTOS
        Me.Cursor = Cursors.WaitCursor

        With CabeceraBE
            .MC_ID_TIPOANEXO = uce_TipoAnexo.Value
            .MC_ANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_IdAnexo.Text.Trim}
            .MC_IDCONCEPTO = New BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV With {.CM_ID = uce_Concepto.Value}
            .MC_ID_COMPRO = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = uce_Comprobante.Value}
            .MC_SER_COMPRO = txt_SerieDoc.Text.Trim
            .MC_NUM_COMPRO = txt_NumDoc.Text.Trim
            .MC_FECHA = CDate(udte_Voucher.Value).ToShortDateString
            .MC_TIPCAMBIO = ume_ValorTipoCambio.Value
            .MC_COMENTARIO = txt_Glosa.Text.Trim
            .MC_IDCENCOS = uce_centrocosto.Value
            .MC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = uce_Moneda.Value}
            .MC_MEDIOPAGO = New BE.ContabilidadBE.SG_CO_TB_MEDIOPAGO With {.MP_CODIGO = uce_MedioPago.Value}
            .MC_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .MC_PC_TERMINAL = Environment.MachineName
            .MC_PC_FECREG = Date.Now
            .MC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .MC_CUENTA_CORRI = New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE With {.BC_ID_CTA = uce_CuentaBancaria.Value}
            .MC_IMPORTE_ORI = Double.Parse(ume_importe_Ori.Value)
            .MC_IMPORTE = Double.Parse(ume_Importe_Mov.Value)
        End With


        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            DetalleBE = New BE.TesoreriaBE.SG_TE_TB_MOVIMIENTO_D
            With DetalleBE
                .MD_IDMC = CabeceraBE
                .MD_SECUENCIA = i + 1
                .MD_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_detalle.Rows(i).Cells("cod_TD").Value}
                .MD_SER_DOC = ug_detalle.Rows(i).Cells("Serie").Value
                .MD_NUM_DOC = ug_detalle.Rows(i).Cells("documento").Value
                .MD_FEC_DOC = ug_detalle.Rows(i).Cells("fecha_TD").Value
                .MD_IMPORTE = ug_detalle.Rows(i).Cells("importe").Value
                .MD_COMENTARIO = ug_detalle.Rows(i).Cells("comentario").Value
                .MD_ES_CONCI = 0
                .MD_ANHO_CONI = 0
                .MD_MES_CONCI = 0
                .MD_CUENTA = ug_detalle.Rows(i).Cells("cuenta").Value
                .MD_TC = ug_detalle.Rows(i).Cells("tc").Value
                .MD_IMPORTE_ORI = ug_detalle.Rows(i).Cells("importe_ori").Value
            End With
            Lista_Det.Add(DetalleBE)
        Next


        Try
            MovimientosBL.Insert_Egreso(CabeceraBE, Lista_Det)
            Avisar("    Listo!      ")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Default
        End Try




    End Sub

    Private Sub txt_total_soles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_total_soles.ValueChanged
        If uchk_deducir.Checked Then
            ume_importe_Ori.Value = txt_total_soles.Text.Trim
            If uce_Moneda.Value = 1 Then 'soles
                ume_Importe_Mov.Value = Double.Parse(ume_importe_Ori.Value)
            Else
                ume_Importe_Mov.Value = Double.Parse(ume_importe_Ori.Value) * Double.Parse(ume_ValorTipoCambio.Value)
            End If
        End If
    End Sub
End Class