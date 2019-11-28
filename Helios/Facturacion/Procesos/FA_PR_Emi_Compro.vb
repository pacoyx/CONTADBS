Imports Infragistics.Win.UltraWinGrid

Public Class FA_PR_Emi_Compro

    Dim imp_min_bol As Double = 700 'importe minimo para boletas en el caso que se pida DNI
    Public bol_nuevo As Boolean = True

    Private Sub FA_PR_Emi_Compro_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.Refresh()
    End Sub

    Private Sub FA_PR_Emi_Compro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'If Verificar_Estado_Caja() And bol_nuevo Then
        '    Call Avisar("Falta Aperturar la caja para la fecha : " & gDat_Fecha_Sis.ToShortDateString)
        '    ugb_cabecera.Enabled = False
        '    ToolS_Mantenimiento.Enabled = False
        '    ugb_docref.Visible = False
        '    Exit Sub
        'Else
        ugb_cabecera.Enabled = True
        ToolS_Mantenimiento.Enabled = True
        ugb_docref.Visible = False
        'End If

        'Call Cargar_Documentos()
        Call Cargar_Documentos_Ref()
        Call Cargar_Cmb_Monedas()
        Call Cargar_Punto_Venta()
        Call Cargar_Forma_Pago()
        Call Cargar_Empresas_Combo()
        Call Cargar_Documentos_de_Pagos()
        Call Cargar_Vendedores()

        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_

        udte_fec_emi.Value = gDat_Fecha_Sis
        udte_fec_Ven.Value = gDat_Fecha_Sis

        Call Iniciar_Ventana()

        usb_compro.Panels("usp_usuario").Text = "Usuario : " & gStr_Usuario_Sis
        usb_compro.Panels("usp_usuario").Appearance.Image = My.Resources._16__User_
        ubtn_quitar.Appearance.Image = My.Resources._16__Delete_
        ubtn_agregar.Appearance.Image = My.Resources._16__Plus_
        ubtn_ing_rap.Appearance.Image = My.Resources.INFOPATH_001
        ubtn_ing_rap.Appearance.ImageHAlign = Infragistics.Win.HAlign.Center
        txt_notas.ButtonsRight("btn_des_cli").Appearance.Image = My.Resources._16__Fill_left_
        txt_notas.ButtonsRight("btn_des_cli").Appearance.ImageHAlign = Infragistics.Win.HAlign.Center

    End Sub

    Private Sub Cargar_Vendedores()
        Dim vendedorBL As New BL.FacturacionBL.SG_FA_TB_VENDEDOR
        uce_vendedor.DataSource = vendedorBL.get_vendedores_cmb
        uce_vendedor.DisplayMember = "VE_DESCRIPCION"
        uce_vendedor.ValueMember = "VE_ID"
        vendedorBL = Nothing
    End Sub

    Private Function Verificar_Estado_Caja() As Boolean
        Dim rpta As Boolean = False

        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim dt_data As DataTable = cajaBL.get_Data_Caja(gInt_IdUsuario_Sis, CDate(gDat_Fecha_Sis).ToShortDateString, gInt_IdEmpresa)

        If dt_data.Rows.Count = 0 Then
            dt_data.Dispose()
            cajaBL = Nothing
            rpta = True
        End If
        dt_data.Dispose()

        Return rpta
    End Function

    Private Function Tiene_TipodeCambio() As Boolean
        Dim respuesta As Boolean = False

        Dim rpta As String = String.Empty
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "SISTE"
        paraetrosBE.AD_NOMBRE = "TC"

        rpta = paraetrosBL.get_Valor(paraetrosBE)

        If rpta = "F" Then

            Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
            Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

            tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocambioBE.PA_FECHA = gDat_Fecha_Sis.ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Fecha(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then
                respuesta = True
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"  ==>  de contabilidad

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocamBE.TC_FECHA = gDat_Fecha_Sis.ToShortDateString
            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBL.getTipoCambio(tipocamBE)

            If tipocamBE.TC_VENTA > 0 Then
                respuesta = True
            End If

            tipocamBE = Nothing
            tipocamBL = Nothing

        End If

        Return respuesta

    End Function

    Private Sub Cargar_Documentos_de_Pagos()
        Dim docusBL As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
        uce_docu_pago.DataSource = docusBL.get_DocuPagos(gInt_IdEmpresa)
        uce_docu_pago.DisplayMember = "DP_DESCRIPCION"
        uce_docu_pago.ValueMember = "DP_CODIGO"
        docusBL = Nothing
    End Sub

    Private Sub Cargar_Empresas_Combo()

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO

        uce_Empresas.DataSource = usuarioBL.get_Empresas_x_usuario(gStr_Usuario_Sis)
        uce_Empresas.DisplayMember = "EM_NOMBRE"
        uce_Empresas.ValueMember = "PU_IDEMPRESA"

        'uce_Empresas.Items.Add("3", "GESTAR S.A.C")
        'uce_Empresas.Items.Add("4", "GINEFERT  S.A.C.")
        'uce_Empresas.Items.Add("5", "GINECOLOGIA Y FERTILIDAD S.A.C")
        'uce_Empresas.Items.Add("6", "ECOGEST  S.A.C")

        uce_Empresas.Value = gInt_IdEmpresa

        usuarioBL = Nothing

    End Sub

    Public Sub Cargar_Comprobante_toEdit(entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
        Try

            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim ds_comprobante As New DataSet

            ds_comprobante = comprobantesBL.get_Comprobante_x_Id(entidad)

            With ds_comprobante.Tables(0)

                uce_PuntoVenta.Value = .Rows(0)("CO_IDPTOVTA")
                uce_TipoDoc.Value = .Rows(0)("CO_TDOC")
                uce_Serie.Value = .Rows(0)("CO_SDOC")
                txt_NumDoc.Value = .Rows(0)("CO_NDOC")
                txt_notas.Text = .Rows(0)("CO_NOTAS")
                txt_notas.Enabled = False
                txt_IdCliente.Value = .Rows(0)("CO_IDCLIENTE")

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

                clienteBE.CL_ID = txt_IdCliente.Value
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Id(clienteBE)

                txt_Des_Cliente.Text = clienteBE.CL_NOMBRE
                txt_ruc_cliente.Text = clienteBE.CL_NDOC

                clienteBE = Nothing
                clienteBL = Nothing

                uce_Moneda.Value = .Rows(0)("CO_IDMONEDA")
                ume_ValorTipoCambio.Value = .Rows(0)("CO_TCAM")
                ume_Tasa_Igv.Value = .Rows(0)("CO_IGV")
                uce_FormaPago.Value = .Rows(0)("CO_IDFORMA_PAGO")
                uce_docu_pago.Value = .Rows(0)("CO_IDDOCU_PAGO")
                txt_ref_pago.Text = .Rows(0)("CO_REF_PAGO")
                udte_fec_emi.Value = .Rows(0)("CO_FEC_EMI")
                udte_fec_Ven.Value = .Rows(0)("CO_FEC_VEN")
                txt_num_voucher_conta.Text = .Rows(0)("CO_NUMVOUCHER").ToString
                txt_IdComprobante.Text = .Rows(0)("CO_ID")
                uce_vendedor.Value = .Rows(0)("CO_IDVENDEDOR")
                uce_suscriptor.Value = .Rows(0)("CO_NUM_SUSCRIPTOR")
            End With


            Call LimpiaGrid(ug_Detalle, uds_detalle)

            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1
                ug_Detalle.DisplayLayout.Bands(0).AddNew()

                With ds_comprobante.Tables(1)

                    ug_Detalle.Rows(i).Cells("Item").Value = ds_comprobante.Tables(1).Rows(i)("CD_ITEM")
                    ug_Detalle.Rows(i).Cells("Cant").Value = ds_comprobante.Tables(1).Rows(i)("CD_CANT")
                    ug_Detalle.Rows(i).Cells("IdArticulo").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO")

                    If ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO") = "TEXTO" Then
                        ug_Detalle.Rows(i).Cells("DesArticulo").Value = ds_comprobante.Tables(1).Rows(i)("CD_TEXTO_ALT").ToString
                    Else
                        ug_Detalle.Rows(i).Cells("DesArticulo").Value = ds_comprobante.Tables(1).Rows(i)("AR_DESCRIPCION")
                    End If

                    ug_Detalle.Rows(i).Cells("Precio").Value = ds_comprobante.Tables(1).Rows(i)("CD_PRECIO")
                    ug_Detalle.Rows(i).Cells("SubTotal").Value = ds_comprobante.Tables(1).Rows(i)("CD_SUBTOTAL")
                    ug_Detalle.Rows(i).Cells("Impuesto").Value = ds_comprobante.Tables(1).Rows(i)("CD_IGV")
                    ug_Detalle.Rows(i).Cells("Total").Value = ds_comprobante.Tables(1).Rows(i)("CD_TOTAL")
                    ug_Detalle.Rows(i).Cells("InIGV").Value = ds_comprobante.Tables(1).Rows(i)("CD_INC_IGV")
                    ug_Detalle.Rows(i).Cells("NoAfeIgv").Value = ds_comprobante.Tables(1).Rows(i)("CD_INAFECTO")

                End With

                ug_Detalle.UpdateData()

            Next

            If ds_comprobante.Tables(2).Rows(0)("CON") > 0 Then
                txt_doc_pago.Visible = True
                txt_doc_pago.Text = "Detallado"
            Else
                txt_doc_pago.Visible = False
                txt_doc_pago.Text = ""
            End If



            ds_comprobante = Nothing
            comprobantesBL = Nothing

            Tool_Nuevo.Enabled = False
            Tool_Grabar.Enabled = False
            Tool_Nuevo.Enabled = False
            ugb_cabecera.Enabled = False

            ubtn_agregar.Enabled = False
            ubtn_quitar.Enabled = False
            ubtn_ing_rap.Enabled = False
            uce_Empresas.Enabled = False

        Catch ex As Exception
            ShowError("Ocurrio un problema " & ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Documentos_Ref()
        Dim documentosBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        uce_TipDocRef.DataSource = documentosBL.get_Docs_Facturacion(gInt_IdEmpresa)
        uce_TipDocRef.DisplayMember = "DO_ABREVIATURA"
        uce_TipDocRef.ValueMember = "DO_CODIGO"
        documentosBL = Nothing
    End Sub

    Private Sub Cargar_Forma_Pago()

        Dim formapBL As New BL.FacturacionBL.SG_FA_TB_FORMA_PAGO
        uce_FormaPago.DataSource = formapBL.get_Lista_FP(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_FormaPago.ValueMember = "FP_ID"
        uce_FormaPago.DisplayMember = "FP_DESCRIPCION"
        formapBL = Nothing

    End Sub

    Private Sub Cargar_Punto_Venta()

        Dim usuPtovtaBL As New BL.FacturacionBL.SG_FA_TB_USU_PTOVTA
        Dim usuPtovtaBE As New BE.FacturacionBE.SG_FA_TB_USU_PTOVTA
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO

        usuPtovtaBE.UP_IDUSARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = usuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)}
        usuPtovtaBE.UP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_PuntoVenta.DataSource = usuPtovtaBL.get_Lista_PtosVtas_x_Usuario(usuPtovtaBE)
        uce_PuntoVenta.ValueMember = "UP_IDPTO_VTA"
        uce_PuntoVenta.DisplayMember = "PV_DESCRIPCION"

        usuPtovtaBL = Nothing
        usuPtovtaBE = Nothing
        usuarioBL = Nothing

        If uce_PuntoVenta.Items.Count > 0 Then uce_PuntoVenta.SelectedIndex = 0

        'Dim puntoBL As New BL.FacturacionBL.SG_FA_TB_PUNTO_VENTA
        'uce_PuntoVenta.DataSource = puntoBL.get_Lista_PuntaVentas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        'uce_PuntoVenta.ValueMember = "PV_ID"
        'uce_PuntoVenta.DisplayMember = "PV_DESCRIPCION"
        'puntoBL = Nothing
    End Sub

    Private Sub Cargar_Documentos_x_PtoVta()

        'aqui hay que cargar los documentos por punto de venta

        Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
        Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

        seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PuntoVenta.Value}
        seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        uce_TipoDoc.DataSource = seriesBL.get_Lista_TD_X_PtoVta(seriesBE)
        uce_TipoDoc.DisplayMember = "DO_ABREVIATURA"
        uce_TipoDoc.Value = "PS_TD"

        seriesBE = Nothing
        seriesBL = Nothing

        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 0

        'Dim documentosBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        'uce_TipoDoc.DataSource = documentosBL.get_Docs_Facturacion(gInt_IdEmpresa)
        'uce_TipoDoc.DisplayMember = "DO_ABREVIATURA"
        'uce_TipoDoc.ValueMember = "DO_CODIGO"
        'documentosBL = Nothing

    End Sub

    Private Sub Cargar_Cmb_Monedas()

        Dim Obj_MonedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA
        uce_Moneda.DataSource = Obj_MonedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_Moneda.DisplayMember = "MO_ABREVIATURA"
        uce_Moneda.ValueMember = "MO_ID"
        Obj_MonedaBL = Nothing

    End Sub

    Private Sub Obtener_TipoCambio_dia()

        If udte_fec_emi.Value Is Nothing Then Exit Sub

        Dim rpta As String = String.Empty
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "SISTE"
        paraetrosBE.AD_NOMBRE = "TC"

        rpta = paraetrosBL.get_Valor(paraetrosBE)

        If rpta = "F" Then

            Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
            Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

            tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocambioBE.PA_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Fecha(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then
                ume_ValorTipoCambio.Value = dt_tc.Rows(0)("PA_VENTA")
            Else
                ume_ValorTipoCambio.Value = 0
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocamBE.TC_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBL.getTipoCambio(tipocamBE)

            ume_ValorTipoCambio.Value = tipocamBE.TC_VENTA

            tipocamBE = Nothing
            tipocamBL = Nothing

        End If


    End Sub

    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = CDate(udte_fec_emi.Value).Year
        impuestoBE.IM_MES = CDate(udte_fec_emi.Value).Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        ume_Tasa_Igv.Value = impuestoBE.IM_TASA


        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Sub udte_fec_emi_ValueChanged(sender As System.Object, e As System.EventArgs) Handles udte_fec_emi.ValueChanged
        Call Obtener_TipoCambio_dia()
        Call Cargar_Tasas_Impuestos()
        udte_fec_Ven.Value = udte_fec_emi.Value
    End Sub

    Private Sub txt_ruc_cliente_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab()
            Case "editar"

        End Select
    End Sub

    Private Sub Ayuda_Anexo_Cab()
        FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaClientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(1)
            txt_Des_Cliente.Text = matriz(2)
            txt_dir.Text = matriz(3)


            Dim comunicaBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI
            clienteBE.CC_IDCLIENTE = txt_IdCliente.Text
            Dim dt_cli_comu As DataTable = comunicaBL.get_Comuninicaciones_xId(clienteBE)


            uce_suscriptor.Items.Clear()
            For i As Integer = 0 To dt_cli_comu.Rows.Count - 1
                If dt_cli_comu.Rows(i)("CC_IDCOMUNICA") = 5 Then
                    uce_suscriptor.Items.Add(dt_cli_comu.Rows(i)("CC_DESCRIPCION"), dt_cli_comu.Rows(i)("CC_DESCRIPCION"))
                End If
            Next

            clienteBE = Nothing
            dt_cli_comu = Nothing
            comunicaBL = Nothing

        End If

    End Sub

    Private Sub txt_NumDoc_Leave(sender As System.Object, e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(10, "0")

        Call Validar_existe_num_comprobante(Nothing)

    End Sub

    Private Sub Validar_existe_Cliente(ByRef existe As Boolean)
        existe = True

        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
        clienteBE.CL_ID = txt_IdCliente.Text
        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        clienteBL.get_Cliente_x_Id(clienteBE)

        If clienteBE.CL_NOMBRE.Length = 0 Then
            Call Avisar("Cliente no existe en la base de datos,Revise por favor.")
            existe = False
        End If

        clienteBL = Nothing
        clienteBE = Nothing

    End Sub

    Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comproBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comproBE.CO_TDOC = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
        comproBE.CO_SDOC = uce_Serie.Value
        comproBE.CO_NDOC = txt_NumDoc.Text
        comproBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If comproBL.Existe_Comprobante(comproBE) Then
            Call Avisar("El numero de comprobante " & uce_TipoDoc.Text & "-" & uce_Serie.Value & "-" & txt_NumDoc.Text & " ya esta registrado,! Cuidado")
            existe = True
        End If

        comproBE = Nothing
        comproBL = Nothing

    End Sub

    Private Sub txt_ruc_cliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Buscar_Cliente()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab()
    End Sub

    Private Sub udte_fec_emi_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_emi.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_fec_Ven.Focus()
        End If
    End Sub

    Private Sub udte_fec_Ven_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_Ven.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_TipoDoc.Focus()
        End If
    End Sub

    Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then

            If uce_TipoDoc.Value = "07" Then
                ugb_docref.Visible = True
                uce_TipDocRef.Focus()
            Else
                txt_ruc_cliente.Focus()
            End If

        End If
    End Sub

    Private Sub txt_SerieDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_NumDoc.Focus()
        End If
    End Sub

    Private Sub txt_NumDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ruc_cliente.Focus()
        End If
    End Sub

    Private Sub uce_TipoDoc_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoDoc.ValueChanged

        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()

        'Notas de Credito
        If uce_TipoDoc.Value = "07" Then
            txt_NumDoc.ButtonsRight(0).Enabled = True
        Else
            txt_NumDoc.ButtonsRight(0).Enabled = False
        End If

        'Boletas de Ventas
        'If uce_TipoDoc.Value = "03" Then

        '    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
        '    Dim ls_anexoBOLETA As New List(Of String)
        '    ls_anexoBOLETA = clienteBL.get_Anexo_Boleta(gInt_IdEmpresa)

        '    txt_ruc_cliente.Text = ls_anexoBOLETA(1)
        '    txt_IdCliente.Text = ls_anexoBOLETA(0)
        '    txt_Des_Cliente.Text = ls_anexoBOLETA(2)
        '    txt_notas.Text = String.Empty
        '    txt_notas.Focus()

        '    clienteBL = Nothing
        '    ls_anexoBOLETA = Nothing

        'End If

    End Sub

    Private Sub txt_ruc_cliente_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_ruc_cliente.ValueChanged
        If txt_ruc_cliente.Text.Trim.Length = 0 Then
            txt_IdCliente.Text = String.Empty
            txt_Des_Cliente.Text = String.Empty
        End If
    End Sub

    Private Sub ubtn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_agregar.Click
        'FA_PR_ListaArticuloAyuda.MdiParent = CO_MN_MenuInicial

        FA_PR_ListaArticuloAyuda.Int_Opcion = 1
        FA_PR_ListaArticuloAyuda.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = FA_PR_ListaArticuloAyuda.GetLista
        Dim igv_cal As Double = 0
        Dim total_cal As Double = 0
        Dim subtotal_cal As Double = 0
        Dim precio_Arti As Double = 0
        Dim bruto As Double = 0
        Dim cant As Double = 0

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz

            precio_Arti = articulo.AR_PRECIO_VENTA




            If articulo.AR_INCLUYE_IGV = 1 Then
                'igv_cal = bruto * (ume_Tasa_Igv.Value / 100)

                igv_cal = precio_Arti * (ume_Tasa_Igv.Value / 100)
                igv_cal = igv_cal / ((ume_Tasa_Igv.Value / 100) + 1)
                igv_cal = Math.Round(igv_cal, 2)

                subtotal_cal = bruto - igv_cal
                total_cal = bruto
            Else

                subtotal_cal = bruto
                igv_cal = bruto * (ume_Tasa_Igv.Value / 100)
                total_cal = bruto + igv_cal
            End If

            If articulo.AR_ES_NO_AFEC_IGV = 1 Then
                igv_cal = 0
                subtotal_cal = precio_Arti
                total_cal = precio_Arti
            End If

            Call AgregarDetalle(1, articulo.AR_CODIGO, articulo.AR_DESCRIPCION, precio_Arti, igv_cal, total_cal, articulo.AR_INCLUYE_IGV, subtotal_cal, articulo.AR_ES_NO_AFEC_IGV)

        Next



    End Sub

    Public Sub AgregarDetalle(ByVal cant_ As Integer, ByVal idarticulo_ As String, ByVal desarticulo_ As String, ByVal precio_ As Double, ByVal impuesto_ As Double, ByVal total_ As Double, ByVal inIgv_ As Integer, ByVal SubTotal_ As Double, ByVal NoAfectoIgv_ As Integer)
        ug_Detalle.DisplayLayout.Bands(0).AddNew()
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Item").Value = ug_Detalle.Rows.Count
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Cant").Value = cant_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IdArticulo").Value = idarticulo_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DesArticulo").Value = desarticulo_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Precio").Value = precio_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Impuesto").Value = impuesto_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Total").Value = total_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("InIgv").Value = inIgv_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("SubTotal").Value = SubTotal_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("NoAfeIgv").Value = NoAfectoIgv_
        ug_Detalle.UpdateData()
        ug_Detalle.Refresh()
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value


        Dim igv_cal As Double = 0
        Dim total_cal As Double = 0
        Dim subtotal_cal As Double = 0
        Dim precio_Arti As Double = 0
        Dim bruto As Double = 0
        Dim cant As Double = 0

        precio_Arti = e.Row.Cells("Precio").Value
        cant = e.Row.Cells("Cant").Value

        bruto = precio_Arti * cant

        If e.Row.Cells("NoAfeIgv").Value = 1 Then

            subtotal_cal = bruto
            igv_cal = 0
            total_cal = bruto

        Else
            If e.Row.Cells("InIGV").Value = 1 Then
                'igv_cal = bruto * (ume_Tasa_Igv.Value / 100)

                igv_cal = precio_Arti * (ume_Tasa_Igv.Value / 100)
                igv_cal = igv_cal / ((ume_Tasa_Igv.Value / 100) + 1)
                igv_cal = Math.Round(igv_cal, 2)

                subtotal_cal = bruto - igv_cal
                total_cal = bruto
            Else

                subtotal_cal = bruto
                igv_cal = bruto * (ume_Tasa_Igv.Value / 100)
                total_cal = bruto + igv_cal
            End If


        End If




        e.Row.Cells("Total").Value = total_cal
        e.Row.Cells("Impuesto").Value = igv_cal
        e.Row.Cells("SubTotal").Value = subtotal_cal

        Call Calcular_Totales()

    End Sub

    Private Sub Calcular_Totales()

        Dim subtotal As Double = 0
        Dim igv As Double = 0
        Dim total As Double = 0

        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            subtotal += ug_Detalle.Rows(i).Cells("SubTotal").Value
            igv += ug_Detalle.Rows(i).Cells("Impuesto").Value
            total += ug_Detalle.Rows(i).Cells("Total").Value
        Next

        ume_subtotal.Value = subtotal ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
        ume_igv.Value = igv 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sIgv")
        ume_total.Value = total 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sTotal")

        Call Validar_Ing_Dni()

    End Sub

    Private Sub Validar_Ing_Dni()

        If uce_TipoDoc.Value = "03" Then
            Dim monto_tmp As Double = ume_total.Value

            If uce_Moneda.Value = "02" Then
                monto_tmp = (monto_tmp * ume_ValorTipoCambio.Value)
            End If


            If monto_tmp > imp_min_bol Then
                lbl_dni.Visible = True
                txt_dni.Visible = True
                txt_notas.Width = 394
            Else
                lbl_dni.Visible = False
                txt_dni.Visible = False
                txt_notas.Width = 489
            End If

        Else
            lbl_dni.Visible = False
            txt_dni.Visible = False
            txt_notas.Width = 489
        End If
    End Sub

    Private Sub ug_Detalle_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_Detalle.KeyDown

        If e.KeyCode = Keys.Enter Then

            ug_Detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Detalle.UpdateData()

        End If

    End Sub

    Private Sub ug_Detalle_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False

    End Sub

    Private Sub ubtn_quitar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_quitar.Click

        If ug_Detalle.Rows.Count = 0 Then Exit Sub
        If ug_Detalle.ActiveRow Is Nothing Then Exit Sub

        ug_Detalle.ActiveRow.Delete()

        Call Calcular_Totales()

    End Sub

    Private Sub Iniciar_Ventana()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_cabecera)
        Call LimpiaGrid(ug_Detalle, uds_detalle)

        ume_subtotal.Value = 0
        ume_igv.Value = 0
        ume_total.Value = 0
        txt_notas.Clear()
        txt_num_voucher_conta.Clear()
        txt_IdComprobante.Clear()

        'uce_TipoDoc.Value = "3"
        uce_Moneda.SelectedIndex = 0
        'udte_fec_emi.Value = gDat_Fecha_Sis
        'udte_fec_Ven.Value = gDat_Fecha_Sis


        Call Cargar_Tasas_Impuestos()
        Call Obtener_TipoCambio_dia()

        uce_PuntoVenta.SelectedIndex = 0
        uce_FormaPago.SelectedIndex = 0
        uce_docu_pago.SelectedIndex = 0

        uce_TipDocRef.Value = Nothing
        txt_serie_ref.Text = ""
        txt_numero_ref.Text = ""
        ume_fec_emi_ref.Value = Nothing
        ume_fec_ven_ref.Value = Nothing

        Tool_Imprimir.Enabled = False
        Tool_Grabar.Enabled = True
        ubtn_agregar.Enabled = True
        ubtn_quitar.Enabled = True
        ubtn_ing_rap.Enabled = True
        uce_Empresas.Enabled = True
        txt_doc_pago.Visible = False
        ugb_docref.Visible = False

        For Each ctrl As Control In ugb_cabecera.Controls
            ctrl.Enabled = True
        Next

        txt_notas.Width = 489
        txt_dni.Visible = False
        lbl_dni.Visible = False
        txt_dni.Text = ""
        txt_ruc_cliente.Focus()

    End Sub

    Private Sub Guardar_Comprobante()

        ug_Detalle.UpdateData()


        'Validaciones

        If gInt_IdEmpresa.ToString <> uce_Empresas.Value Then
            Call Avisar("Se cambio de empresa y la empresa actual no es la misma, revise.")
            Exit Sub
        End If


        If txt_IdCliente.Text = String.Empty Then
            Avisar("Ingrese un cliente valido")
            txt_ruc_cliente.Focus()
            Exit Sub
        End If

        If ume_Tasa_Igv.Value = 0 Then
            Avisar("La tasa del IGV no puede ser cero, verifique")
            Exit Sub
        End If

        If ug_Detalle.Rows.Count = 0 Then
            Avisar("No hay detalles para continuar.")
            Exit Sub
        End If

        If udte_fec_emi.Value Is Nothing Then
            Avisar("Ingrese la fecha de emision")
            Exit Sub
        End If

        If ume_subtotal.Value = 0 Then
            Avisar("No se puede grabar con el Subtotal en cero")
            Exit Sub
        End If

        If ume_total.Value = 0 Then
            Avisar("No se puede grabar con el Total en cero")
            Exit Sub
        End If


        If uce_TipoDoc.Value = "07" Then
            If txt_serie_ref.Text.Trim.Length = 0 Or txt_numero_ref.Text.Trim.Length = 0 Or uce_TipDocRef.SelectedIndex = -1 Then
                Avisar("Ingrese el documento de referencia")
                Exit Sub
            End If
        End If

        If txt_notas.Text.Trim.Length = 0 Then
            If Not Preguntar("El campo NOTAS esta vacio, Desea Continuar?") Then
                txt_notas.Focus()
                Exit Sub
            End If
        End If


        Dim rpta_existe As Boolean = False
        Call Validar_existe_num_comprobante(rpta_existe)

        If rpta_existe Then
            Avisar("No se puede continuar!")
            Exit Sub
        End If


        Call Validar_existe_Cliente(rpta_existe)

        If Not rpta_existe Then
            Avisar("No se puede continuar!")
            Exit Sub
        End If

        If txt_dni.Visible Then
            If txt_dni.Text.Trim.Length = 0 Then
                Avisar("Ingrese el dni del Cliente")
                txt_dni.Focus()
                Exit Sub
            End If
        End If


        'Comenzamos a Grabar
        Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        Dim documentoBL As New BL.FacturacionBL.SG_FA_TB_DOCUMENTO
        Dim documentoBE As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO
        Dim documentoBE2 As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO

        documentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        documentoBE.DO_CODIGO = uce_TipoDoc.Value
        documentoBL.get_Documentos_x_Cod(documentoBE)

        documentoBE2.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        documentoBE2.DO_CODIGO = uce_TipDocRef.Value
        documentoBL.get_Documentos_x_Cod(documentoBE2)

        With comprobanteBE
            .CO_ID = 0
            .CO_TDOC = documentoBE
            .CO_SDOC = uce_Serie.Value
            .CO_NDOC = txt_NumDoc.Text.Trim
            .CO_FEC_EMI = udte_fec_emi.Value
            .CO_FEC_VEN = udte_fec_Ven.Value
            .CO_SUBTOTAL = ume_subtotal.Value
            .CO_SUBTOTAL_NA = 0
            .CO_IGV = ume_igv.Value
            .CO_TOTAL = ume_total.Value
            .CO_IDMONEDA = New BE.FacturacionBE.SG_FA_TB_MONEDA With {.MO_ID = uce_Moneda.Value, .MO_ABREVIATURA = IIf(uce_Moneda.Value = "01", "MN", "ME")}
            .CO_TCAM = ume_ValorTipoCambio.Value

            If uce_TipoDoc.Value = "07" Then
                .CO_TDOC_REF = documentoBE2
                .CO_SDOC_REF = txt_serie_ref.Text
                .CO_NDOC_REF = txt_numero_ref.Text

                If ume_fec_emi_ref.Value.ToString = "" Then
                    .CO_FEC_EMI_REF = String.Empty
                Else
                    .CO_FEC_EMI_REF = CDate(ume_fec_emi_ref.Value).ToShortDateString
                End If

                If ume_fec_ven_ref.Value.ToString = "" Then
                    .CO_FEC_VEN_REF = String.Empty
                Else
                    .CO_FEC_VEN_REF = CDate(ume_fec_ven_ref.Value).ToShortDateString
                End If

            Else
                .CO_TDOC_REF = Nothing
                .CO_SDOC_REF = String.Empty
                .CO_NDOC_REF = String.Empty
                .CO_FEC_EMI_REF = String.Empty
                .CO_FEC_VEN_REF = String.Empty
            End If

            .CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CO_TERMINAL = Environment.MachineName
            .CO_FECREG = Now
            .CO_IDCLIENTE = New BE.FacturacionBE.SG_FA_TB_CLIENTE With {.CL_ID = txt_IdCliente.Text.Trim, .CL_NDOC = txt_ruc_cliente.Text.Trim, .CL_NOMBRE = txt_Des_Cliente.Text.Trim, .CL_DIRECCION = txt_dir.Text.Trim}
            .CO_NOTAS = txt_notas.Text.Trim
            .CO_ESTADO = 1
            .CO_IDPTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PuntoVenta.Value}
            .CO_IDFORMA_PAGO = New BE.FacturacionBE.SG_FA_TB_FORMA_PAGO With {.FP_ID = uce_FormaPago.Value}
            .CO_ES_CONTA_PROVI = 0
            .CO_ES_CONTA_CANCE = 0
            .CO_TASA_IGV = ume_Tasa_Igv.Value
            .CO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = gInt_IdUsuario_Sis}
            .CO_IDDOCU_PAGO = New BE.FacturacionBE.SG_FA_TB_DOCU_PAGO With {.DP_CODIGO = uce_docu_pago.Value}
            .CO_REF_PAGO = txt_ref_pago.Text.Trim
            .CO_ES_REEMPLA = IIf(uchk_Por_Reem.Checked, 1, 0)
            .CO_DNI = txt_dni.Text.Trim

            If uce_vendedor.SelectedIndex = -1 Then
                .CO_IDVENDEDOR = String.Empty
            Else
                .CO_IDVENDEDOR = uce_vendedor.Value
            End If

            If uce_suscriptor.SelectedIndex = -1 Then
                .CO_NUM_SUSCRIPTOR = String.Empty
            Else
                .CO_NUM_SUSCRIPTOR = uce_suscriptor.Value
            End If
        End With


        Dim detalleBE As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D

        ug_Detalle.UpdateData()

        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            detalleBE = New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D
            Dim des_articulo As String = ""

            If ug_Detalle.Rows(i).Cells("IdArticulo").Value <> "TEXTO" Then
                des_articulo = ug_Detalle.Rows(i).Cells("DesArticulo").Value.ToString
            End If

            With detalleBE
                .CD_IDCAB = Nothing
                .CD_ITEM = ug_Detalle.Rows(i).Cells("Item").Value
                .CD_IDARTICULO = New BE.FacturacionBE.SG_FA_TB_ARTICULO With {.AR_CODIGO = ug_Detalle.Rows(i).Cells("IdArticulo").Value, .AR_DESCRIPCION = des_articulo}
                .CD_CANT = ug_Detalle.Rows(i).Cells("Cant").Value
                .CD_PRECIO = ug_Detalle.Rows(i).Cells("Precio").Value
                .CD_DSCTO = 0
                .CD_SUBTOTAL = ug_Detalle.Rows(i).Cells("SubTotal").Value
                .CD_INAFECTO = ug_Detalle.Rows(i).Cells("NoAfeIgv").Value
                .CD_IGV = ug_Detalle.Rows(i).Cells("Impuesto").Value
                .CD_TOTAL = ug_Detalle.Rows(i).Cells("Total").Value
                .CD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .CD_INC_IGV = ug_Detalle.Rows(i).Cells("InIgv").Value

                .CD_TEXTO_ALT = ug_Detalle.Rows(i).Cells("DesArticulo").Value.ToString

                'If ug_Detalle.Rows(i).Cells("IdArticulo").Value = "TEXTO" Then
                '    .CD_TEXTO_ALT = ug_Detalle.Rows(i).Cells("DesArticulo").Value.ToString
                'Else
                '    .CD_TEXTO_ALT = ""
                'End If

            End With

            comprobanteBE.Detalles.Add(detalleBE)
        Next

        Dim voucherConta As String = String.Empty

        Try
            comprobanteBL.Insert(comprobanteBE, voucherConta)

            txt_IdComprobante.Text = comprobanteBE.CO_ID
            txt_num_voucher_conta.Text = voucherConta

            comprobanteBE = Nothing
            comprobanteBL = Nothing


            Call Avisar("Listo!")

            Tool_Imprimir.Enabled = True
            Tool_Grabar.Enabled = False
            Tool_Cancelar.Enabled = False
            ubtn_agregar.Enabled = False
            ubtn_quitar.Enabled = False

            For Each ctrl As Control In ugb_cabecera.Controls
                ctrl.Enabled = False
            Next


        Catch ex As Exception
            ShowError(ex.Message)
        End Try



    End Sub

    Private Sub uce_Serie_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Serie.ValueChanged
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub Obtener_Ult_Num_Compro()
        Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
        Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

        numeracionBE.NC_IDTIPO = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
        numeracionBE.NC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        numeracionBE.NC_SERIE = uce_Serie.Value

        txt_NumDoc.Text = numeracionBL.get_NumCompro_xTD_SD(numeracionBE)

        numeracionBE = Nothing
        numeracionBL = Nothing
    End Sub

    Private Sub Cargar_Series_Doc()

        Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
        Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

        seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PuntoVenta.Value}
        seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        seriesBE.PS_TD = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}

        uce_Serie.DataSource = seriesBL.get_Lista_Serie_x_TipDoc_x_PtoVta(seriesBE)
        uce_Serie.DisplayMember = "PS_SERIE"
        uce_Serie.ValueMember = "PS_SERIE"

        seriesBE = Nothing
        seriesBL = Nothing

        If uce_Serie.Items.Count > 0 Then uce_Serie.SelectedIndex = 0

    End Sub

    Private Sub uce_Serie_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Serie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_NumDoc.Focus()
        End If
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        Call Guardar_Comprobante()
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Dim ult_doc As String = uce_TipoDoc.Value

        Call Iniciar_Ventana()

        uce_TipoDoc.Value = ult_doc

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Iniciar_Ventana()
    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click

        If txt_IdComprobante.Text.Length = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_FA_01.RPT"
        Dim nom_param_linea As String = ""
        Dim texto_nota_cre As String = ""
        Dim bol_es_nc As Boolean = False

        Select Case uce_TipoDoc.Value
            Case "01" 'factura
                nom_reporte = "SG_FA_01.RPT"
                'nom_reporte = "SG_FA_01_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFAC"

            Case "03" 'boleta
                nom_reporte = "SG_FA_06.RPT"
                'nom_reporte = "SG_FA_06_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINBOL"

            Case "07" 'nota de credito
                nom_reporte = "SG_FA_07.RPT"
                'nom_reporte = "SG_FA_07_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINNCR"

                texto_nota_cre = "Por la anulacion del comprobante " & uce_TipDocRef.Value.ToString & " - " & txt_serie_ref.Text & " - " & txt_numero_ref.Text & " emitido el " & ume_fec_emi_ref.Value.ToString
                bol_es_nc = True

        End Select



        Dim idComprobante As Integer = txt_IdComprobante.Text
        Dim reportesBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_comprobante As DataTable = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)
        Dim Monto_en_Letras As String = Letras(ume_total.Value)
        Dim moneda As String = uce_Moneda.Value

        If moneda = "01" Then
            Monto_en_Letras = Monto_en_Letras & " NUEVOS SOLES"
        Else
            Monto_en_Letras = Monto_en_Letras & " DOLARES AMERICANOS"
        End If

        Call Completar_Lineas(nom_param_linea, dt_comprobante, bol_es_nc, texto_nota_cre)
       
        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pTasaigv;" & ume_Tasa_Igv.Value & "%")


        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

   

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ume_Tasa_Igv_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_Tasa_Igv.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_FormaPago.Focus()
        End If
    End Sub

    Private Sub uce_PuntoVenta_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_PuntoVenta.ValueChanged
        Call Cargar_Documentos_x_PtoVta()
    End Sub

    Private Sub uce_PuntoVenta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_PuntoVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_TipoDoc.Focus()
        End If
    End Sub

    Private Sub uce_FormaPago_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_FormaPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_docu_pago.Focus()
        End If
    End Sub

    Private Sub uce_Moneda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_FormaPago.Focus()
        End If
    End Sub

    Private Sub txt_NumDoc_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_NumDoc.EditorButtonClick
        ugb_docref.Visible = True
        uce_TipDocRef.Focus()
    End Sub

    Private Sub ubtn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_aceptar.Click

        If uce_TipDocRef.SelectedIndex = -1 Then
            uce_TipDocRef.Focus()
            Avisar("Seleccione un tipo de documento")
            Exit Sub
        End If

        If txt_serie_ref.Text.Trim.Length = 0 Then
            txt_serie_ref.Focus()
            Call Avisar("Ingrese la serie")
            Exit Sub
        End If

        If txt_numero_ref.Text.Trim.Length = 0 Then
            txt_numero_ref.Focus()
            Call Avisar("Ingrese el numero del comprobante")
            Exit Sub
        End If


        'Aqui se debe buscar el documento por referencia de comprobante ingresado.
        Call Cargar_Comprobante_para_NotCred(uce_TipDocRef.Value, txt_serie_ref.Text.Trim, txt_numero_ref.Text.Trim)

        ugb_docref.Visible = False
        txt_notas.Focus()

    End Sub

    Public Sub Cargar_Comprobante_para_NotCred(td_ As String, sd_ As String, nd_ As String)

        Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
        Dim ds_tmp As DataSet = Nothing

        comprobanteBE.CO_TDOC_REF = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = td_}
        comprobanteBE.CO_SDOC_REF = sd_
        comprobanteBE.CO_NDOC_REF = nd_
        comprobanteBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        ds_tmp = comprobanteBL.get_Comprobante_x_Num_Doc(comprobanteBE)

        comprobanteBL = Nothing
        comprobanteBE = Nothing


        If ds_tmp.Tables(0).Rows.Count = 0 Then Exit Sub

        With ds_tmp.Tables(0)

            txt_IdCliente.Value = .Rows(0)("CO_IDCLIENTE")

            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

            clienteBE.CL_ID = txt_IdCliente.Value
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteBL.get_Cliente_x_Id(clienteBE)

            txt_Des_Cliente.Text = clienteBE.CL_NOMBRE
            txt_ruc_cliente.Text = clienteBE.CL_NDOC

            clienteBE = Nothing
            clienteBL = Nothing

            uce_Moneda.Value = .Rows(0)("CO_IDMONEDA")
            uce_FormaPago.Value = .Rows(0)("CO_IDFORMA_PAGO")
            uce_docu_pago.Value = .Rows(0)("CO_IDDOCU_PAGO")
            txt_ref_pago.Text = .Rows(0)("CO_REF_PAGO")

            'ume_ValorTipoCambio.Value = .Rows(0)("CO_TCAM")
            'ume_Tasa_Igv.Value = .Rows(0)("CO_TASA_IGV")
            'udte_fec_emi.Value = .Rows(0)("CO_FEC_EMI")
            'udte_fec_Ven.Value = .Rows(0)("CO_FEC_VEN")
            'txt_num_voucher_conta.Text = .Rows(0)("CO_NUMVOUCHER").ToString
            'txt_IdComprobante.Text = .Rows(0)("CO_ID")
            txt_notas.Text = .Rows(0)("CO_NOTAS") & "  Doc. de Ref. : " & uce_TipDocRef.Text & "-" & txt_serie_ref.Text & "-" & txt_numero_ref.Text

            If .Rows(0)("CO_DNI").ToString.Length > 0 Then
                txt_dni.Text = .Rows(0)("CO_DNI").ToString
                lbl_dni.Visible = True
                txt_dni.Visible = True
                txt_notas.Width = 394
            Else
                txt_dni.Text = ""
                lbl_dni.Visible = False
                txt_dni.Visible = False
                txt_notas.Width = 489
            End If


        End With

        Call LimpiaGrid(ug_Detalle, uds_detalle)


        'Detalle del Comprobante
        For i As Integer = 0 To ds_tmp.Tables(1).Rows.Count - 1
            ug_Detalle.DisplayLayout.Bands(0).AddNew()

            With ds_tmp.Tables(1)

                ug_Detalle.Rows(i).Cells("Item").Value = .Rows(i)("CD_ITEM")
                ug_Detalle.Rows(i).Cells("Cant").Value = .Rows(i)("CD_CANT")
                ug_Detalle.Rows(i).Cells("IdArticulo").Value = .Rows(i)("CD_IDARTICULO")

                ug_Detalle.Rows(i).Cells("DesArticulo").Value = .Rows(i)("AR_DESCRIPCION")
                ug_Detalle.Rows(i).Cells("Precio").Value = .Rows(i)("CD_PRECIO")
                ug_Detalle.Rows(i).Cells("SubTotal").Value = .Rows(i)("CD_SUBTOTAL")
                ug_Detalle.Rows(i).Cells("Impuesto").Value = .Rows(i)("CD_IGV")
                ug_Detalle.Rows(i).Cells("Total").Value = .Rows(i)("CD_TOTAL")
                ug_Detalle.Rows(i).Cells("InIGV").Value = .Rows(i)("CD_INC_IGV")

            End With

            ug_Detalle.UpdateData()

        Next

        ds_tmp.Dispose()

    End Sub

    Private Sub uce_TipDocRef_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_serie_ref_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_serie_ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_numero_ref_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_numero_ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_fec_emi_ref_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_fec_emi_ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_fec_ven_ref_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_fec_ven_ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Buscar_Cliente()

        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

        clienteBE.CL_NDOC = txt_ruc_cliente.Text.Trim
        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        clienteBL.get_Cliente_x_Ruc(clienteBE)

        If clienteBE.HasRow Then
            txt_IdCliente.Text = clienteBE.CL_ID
            txt_Des_Cliente.Text = clienteBE.CL_NOMBRE
            uce_suscriptor.Focus()
        Else

            If Preguntar("El cliente no existe!, Desea Crearlo?") Then

                FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
                FA_PR_IngClienteRapido.ShowDialog()
                If FA_PR_IngClienteRapido.bol_Grabo Then
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    If clienteBE.HasRow Then
                        txt_IdCliente.Text = clienteBE.CL_ID
                        txt_Des_Cliente.Text = clienteBE.CL_NOMBRE
                        txt_dir.Text = clienteBE.CL_DIRECCION.ToString
                        uce_suscriptor.Focus()
                    End If
                End If
            End If

        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    'Private Sub uchk_manual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_manual.CheckedChanged
    '    txt_NumDoc.ReadOnly = Not uchk_manual.Checked

    '    If Not uchk_manual.Checked Then
    '        Call Cargar_Series_Doc()
    '        Call Obtener_Ult_Num_Compro()

    '        'Notas de Credito
    '        If uce_TipoDoc.Value = "07" Then
    '            txt_NumDoc.ButtonsRight(0).Enabled = True
    '        Else
    '            txt_NumDoc.ButtonsRight(0).Enabled = False
    '        End If

    '        'Boletas de Ventas
    '        If uce_TipoDoc.Value = "03" Then

    '            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
    '            Dim ls_anexoBOLETA As New List(Of String)
    '            ls_anexoBOLETA = clienteBL.get_Anexo_Boleta(gInt_IdEmpresa)

    '            txt_ruc_cliente.Text = ls_anexoBOLETA(1)
    '            txt_IdCliente.Text = ls_anexoBOLETA(0)
    '            txt_Des_Cliente.Text = ls_anexoBOLETA(2)
    '            txt_notas.Text = String.Empty
    '            txt_notas.Focus()

    '            clienteBL = Nothing
    '            ls_anexoBOLETA = Nothing

    '        End If
    '    End If
    'End Sub

    Private Sub ubtn_ing_rap_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_ing_rap.Click

        If Not ugb_cabecera.Enabled Then Exit Sub

        Dim igv_cal As Double = 0
        Dim total_cal As Double = 0
        Dim subtotal_cal As Double = 0
        Dim precio_Arti As Double = 0

        'Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        'Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

        'articuloBE.AR_IDEMPRESA = gInt_IdEmpresa
        'articuloBL.get_Articulo_IngRapido(articuloBE)

        'precio_Arti = articuloBE.AR_PRECIO_VENTA

        'If articuloBE.AR_INCLUYE_IGV = 1 Then
        '    igv_cal = precio_Arti * (ume_Tasa_Igv.Value / 100)
        '    igv_cal = igv_cal / ((ume_Tasa_Igv.Value / 100) + 1)
        '    igv_cal = Math.Round(igv_cal, 2)
        '    subtotal_cal = precio_Arti - igv_cal
        '    total_cal = precio_Arti
        'Else
        '    subtotal_cal = precio_Arti
        '    igv_cal = articuloBE.AR_PRECIO_VENTA * (ume_Tasa_Igv.Value / 100)
        '    total_cal = articuloBE.AR_PRECIO_VENTA + igv_cal
        'End If
        Dim texto As String = InputBox("Ingrese TEXTO:", "ingreso de texto")


        Call AgregarDetalle(0, "TEXTO", texto.ToUpper, precio_Arti, igv_cal, total_cal, 0, subtotal_cal, 0)


        'articuloBE = Nothing
        'articuloBL = Nothing

    End Sub

    Private Sub txt_notas_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_notas.EditorButtonClick
        txt_notas.Text = txt_Des_Cliente.Text.Trim
    End Sub

    Private Sub uce_Empresas_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Empresas.ValueChanged

        gInt_IdEmpresa = uce_Empresas.Value
        gStr_NomEmpresa = uce_Empresas.Text
        CO_MN_MenuInicial.Text = "Sistema Contable - " & uce_Empresas.Text

        Call Cargar_Punto_Venta()
        Call Cargar_Documentos_x_PtoVta()
        Call Iniciar_Ventana()
        
        'txt_ruc_cliente.Text = String.Empty
        'txt_IdCliente.Text = String.Empty
        'txt_Des_Cliente.Text = String.Empty


    End Sub

    Private Sub uce_docu_pago_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_docu_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ref_pago.Focus()
        End If
    End Sub

    Private Sub txt_ref_pago_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ref_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_agregar.Focus()
        End If
    End Sub

    Private Sub ugb_cabecera_Click(sender As System.Object, e As System.EventArgs) Handles ugb_cabecera.Click

    End Sub

    Private Sub txt_notas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_notas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_dni.Visible Then
                txt_dni.Focus()
            End If
        End If
    End Sub

    Private Sub uce_Moneda_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Moneda.ValueChanged
        Call Validar_Ing_Dni()
    End Sub

    Private Sub txt_numero_ref_Leave(sender As System.Object, e As System.EventArgs) Handles txt_numero_ref.Leave
        'Buscar Fechas del documentos

        If txt_numero_ref.Text.Trim.Length < 6 Then
            txt_numero_ref.Text = txt_numero_ref.Text.PadLeft(10, "0")
        End If
    End Sub

    Private Sub txt_serie_ref_Leave(sender As System.Object, e As System.EventArgs) Handles txt_serie_ref.Leave
        If txt_serie_ref.Text.Trim.Length < 3 Then
            txt_serie_ref.Text = txt_serie_ref.Text.PadLeft(4, "0")
        End If
    End Sub

    Private Sub ume_fec_emi_ref_Leave(sender As Object, e As System.EventArgs) Handles ume_fec_emi_ref.Leave
        ume_fec_ven_ref.Value = ume_fec_emi_ref.Value
    End Sub

    Private Sub ubtn_cerrar_ref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_cerrar_ref.Click
        ugb_docref.Visible = False
        txt_notas.Focus()
    End Sub

    Private Sub uce_FormaPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_FormaPago.ValueChanged
        If uce_FormaPago.SelectedIndex = -1 Then Exit Sub

        Dim formaBL As New BL.FacturacionBL.SG_FA_TB_FORMA_PAGO
        Dim diasCredito As Integer = formaBL.get_Dias_de_Credito(uce_FormaPago.Value, gInt_IdEmpresa)
        formaBL = Nothing

        udte_fec_Ven.Value = CDate(udte_fec_emi.Value).AddDays(diasCredito)


    End Sub

    Private Sub uce_suscriptor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_suscriptor.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_vendedor.Focus()
        End If
    End Sub

    Private Sub uce_vendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_vendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class