Public Class CO_MT_DetClientes

    Public Int_IdCliente As Integer
    Dim Bol_Tiene_Data_Cliente As Boolean = False

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            Dim ClienteDetBL As New BL.ContabilidadBL.SG_CO_TB_CLIENTES
            Dim ClienteDetBE As New BE.ContabilidadBE.SG_CO_TB_CLIENTES

            With ClienteDetBE
                .CL_IDCLIENTE = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = Int_IdCliente}
                .CL_APE_PAT = txt_ape_pat.Text.Trim
                .CL_APE_MAT = txt_ape_mat.Text.Trim
                .CL_NOMBRES = txt_nombres.Text
                .CL_RAZON_SOCIAL = txt_razon.Text.Trim
                .CL_GIRO_NEGOCIO = New BE.ContabilidadBE.SG_CO_TB_GIRONEGOCIO With {.GN_ID = uce_gironegocio.Value}
                .CL_DIR_FISCAL = txt_dir_fiscal.Text.Trim
                .CL_DIR_LEGAL = txt_dir_legal.Text.Trim
                .CL_IDPAIS = New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = uce_pais.Value}
                .CL_CODIGO_POSTAL = txt_codigo_postal.Text.Trim
                .CL_CIUDAD = txt_ciudad.Text.Trim
                .CL_REFERENCIA = txt_referencia.Text.Trim
                .CL_TELEF1 = ume_tel1.Value.ToString
                .CL_TELEF2 = ume_tel2.Value.ToString
                .CL_MOVIL1 = ume_mobil1.Value.ToString
                .CL_MOVIL2 = ume_mobil2.Value.ToString
                .CL_FAX1 = ume_fax1.Value.ToString
                .CL_FAX2 = ume_fax2.Value.ToString
                .CL_EMAIL = txt_email.Text.Trim
                .CL_WEBSITE = txt_web_site.Text.Trim
                .CL_CODIGO_INDUSTRIAL = txt_cod_industrial.Text.Trim
                .CL_FORMA_COBRO = New BE.ContabilidadBE.SG_CO_TB_FORMACOBRANZA With {.FC_ID = uce_Forma_cobro.Value}
                .CL_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = uce_moneda.Value}
                .CL_FORMA_ENVIO = New BE.ContabilidadBE.SG_CO_TB_FORMAENVIO With {.FE_ID = uce_forma_envio.Value}
                .CL_FORMA_DESPACHO = New BE.ContabilidadBE.SG_CO_TB_FORMADESPACHO With {.FD_ID = uce_forma_despacho.Value}
                .CL_REPRESENTANTE_LEGAL = txt_repre_legal.Text.Trim
                .CL_REPRESENTANTE_LEGAL_DOC = txt_doc_repre_legal.Text.Trim
                .CL_AGENTE_PERCEPCION = IIf(uchk_a_percepcion.Checked, 1, 0)
                .CL_AGENTE_RETENCION = IIf(uchk_a_retencion.Checked, 1, 0)
                .CL_BUENOS_CONTRIBUYENTES = IIf(uchk_buen_contri.Checked, 1, 0)
                .CL_IDVENDEDOR = New BE.ContabilidadBE.SG_CO_TB_VENDEDOR With {.VE_ID = uce_vendedor.Value}
                .CL_IDCOBRADOR = New BE.ContabilidadBE.SG_CO_TB_COBRADOR With {.CO_ID = uce_cobrador.Value}
                .CL_ES_PRINCIPAL = IIf(uchk_es_principal.Checked, 1, 0)
                .CL_DESCUENTO = ume_descuento.Value
                .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .CL_TERMINAL = Environment.MachineName
                .CL_FECREG = Now.Date
            End With

            If Bol_Tiene_Data_Cliente Then ClienteDetBL.Update(ClienteDetBE) Else ClienteDetBL.Insert(ClienteDetBE)

            ClienteDetBL = Nothing
            ClienteDetBE = Nothing

            Me.Close()


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CO_MT_DetClientes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_ape_pat.Focus()
    End Sub

    Private Sub CO_MT_DetClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()

        Dim ClienteDetBL As New BL.ContabilidadBL.SG_CO_TB_CLIENTES
        Dim ClienteDetBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
        Dim Dt_cliente As DataTable = Nothing

        With ClienteDetBE
            .AN_IDANEXO = Int_IdCliente
            .AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        Dt_cliente = ClienteDetBL.getClientes(ClienteDetBE)

        Limpiar_Controls_InGroupox(UltraGroupBox1)
        Limpiar_Controls_InGroupox(UltraGroupBox2)
        Limpiar_Controls_InGroupox(UltraGroupBox3)
        Limpiar_Controls_InGroupox(UltraGroupBox4)

        Dim elcontrol As Control
        For Each elcontrol In UltraGroupBox2.Controls
            If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = Nothing
            End If
        Next
        

        If Dt_cliente.Rows.Count > 0 Then
            Bol_Tiene_Data_Cliente = True
            With ClienteDetBE
                txt_ape_pat.Text = Dt_cliente.Rows(0)("CL_APE_PAT").ToString
                txt_ape_mat.Text = Dt_cliente.Rows(0)("CL_APE_MAT").ToString
                txt_nombres.Text = Dt_cliente.Rows(0)("CL_NOMBRES").ToString
                txt_razon.Text = Dt_cliente.Rows(0)("CL_RAZON_SOCIAL").ToString
                uce_gironegocio.Value = Dt_cliente.Rows(0)("CL_GIRO_NEGOCIO").ToString
                txt_dir_fiscal.Text = Dt_cliente.Rows(0)("CL_DIR_FISCAL").ToString
                txt_dir_legal.Text = Dt_cliente.Rows(0)("CL_DIR_LEGAL").ToString
                uce_pais.Value = Dt_cliente.Rows(0)("CL_IDPAIS").ToString
                txt_codigo_postal.Text = Dt_cliente.Rows(0)("CL_CODIGO_POSTAL").ToString
                txt_ciudad.Text = Dt_cliente.Rows(0)("CL_CIUDAD").ToString
                txt_referencia.Text = Dt_cliente.Rows(0)("CL_REFERENCIA").ToString
                ume_tel1.Value = Dt_cliente.Rows(0)("CL_TELEF1").ToString
                ume_tel2.Value = Dt_cliente.Rows(0)("CL_TELEF2").ToString
                ume_mobil1.Value = Dt_cliente.Rows(0)("CL_MOVIL1").ToString
                ume_mobil2.Value = Dt_cliente.Rows(0)("CL_MOVIL2").ToString
                ume_fax1.Value = Dt_cliente.Rows(0)("CL_FAX1").ToString
                ume_fax2.Value = Dt_cliente.Rows(0)("CL_FAX2").ToString
                txt_email.Text = Dt_cliente.Rows(0)("CL_EMAIL").ToString
                txt_web_site.Text = Dt_cliente.Rows(0)("CL_WEBSITE").ToString
                txt_cod_industrial.Text = Dt_cliente.Rows(0)("CL_CODIGO_INDUSTRIAL").ToString
                uce_Forma_cobro.Value = Dt_cliente.Rows(0)("CL_FORMA_COBRO").ToString
                uce_moneda.Value = Dt_cliente.Rows(0)("CL_IDMONEDA").ToString
                uce_forma_envio.Value = Dt_cliente.Rows(0)("CL_FORMA_ENVIO").ToString
                uce_forma_despacho.Value = Dt_cliente.Rows(0)("CL_FORMA_DESPACHO").ToString
                txt_repre_legal.Text = Dt_cliente.Rows(0)("CL_REPRESENTANTE_LEGAL").ToString
                txt_doc_repre_legal.Text = Dt_cliente.Rows(0)("CL_REPRESENTANTE_LEGAL_DOC").ToString
                uchk_a_percepcion.Checked = IIf(Dt_cliente.Rows(0)("CL_AGENTE_PERCEPCION").ToString = "1", True, False)
                uchk_a_retencion.Checked = IIf(Dt_cliente.Rows(0)("CL_AGENTE_RETENCION").ToString = "1", True, False)
                uchk_buen_contri.Checked = IIf(Dt_cliente.Rows(0)("CL_BUENOS_CONTRIBUYENTES").ToString = "1", True, False)
                uce_vendedor.Value = Dt_cliente.Rows(0)("CL_IDVENDEDOR").ToString
                uce_cobrador.Value = Dt_cliente.Rows(0)("CL_IDCOBRADOR").ToString
                uchk_es_principal.Checked = IIf(Dt_cliente.Rows(0)("CL_ES_PRINCIPAL").ToString = "1", True, False)
                ume_descuento.Value = Dt_cliente.Rows(0)("CL_DESCUENTO").ToString
            End With
        Else
            For Each elcontrol In UltraGroupBox2.Controls
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
                    Try
                        CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraComboEditor).SelectedIndex = 0
                    Catch ex As Exception
                    End Try
                End If
            Next

            For Each elcontrol In UltraGroupBox3.Controls
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
                    Try
                        CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraComboEditor).SelectedIndex = 0
                    Catch ex As Exception
                    End Try
                End If
            Next
        End If

        Dt_cliente.Dispose()
        ClienteDetBE = Nothing


    End Sub

    Private Sub Cargar_Combos()
        Try
            Dim GirosBL As New BL.ContabilidadBL.SG_CO_TB_GIRONEGOCIO
            Dim GirosBE As New BE.ContabilidadBE.SG_CO_TB_GIRONEGOCIO
            GirosBE.GN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_gironegocio.DataSource = GirosBL.getGiros(GirosBE)
            uce_gironegocio.DisplayMember = "GN_DESCRIPCION"
            uce_gironegocio.ValueMember = "GN_ID"

            GirosBL = Nothing
            GirosBE = Nothing

            Dim PaisBL As New BL.ContabilidadBL.SG_CO_TB_PAIS
            Dim PaisBE As New BE.ContabilidadBE.SG_CO_TB_PAIS
            PaisBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_pais.DataSource = PaisBL.getPais(PaisBE)
            uce_pais.DisplayMember = "PA_DESCRIPCION"
            uce_pais.ValueMember = "PA_CODIGO"

            PaisBE = Nothing
            PaisBL = Nothing


            Dim MonedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
            uce_moneda.DataSource = MonedaBL.getMonedas()
            uce_moneda.DisplayMember = "MO_DESCRIPCION"
            uce_moneda.ValueMember = "MO_CODIGO"

            MonedaBL = Nothing



            Dim formaCobroBL As New BL.ContabilidadBL.SG_CO_TB_FORMACOBRANZA
            Dim formaCobroBE As New BE.ContabilidadBE.SG_CO_TB_FORMACOBRANZA
            formaCobroBE.FC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_Forma_cobro.DataSource = formaCobroBL.getFormasCobro(formaCobroBE)
            uce_Forma_cobro.DisplayMember = "FC_DESCRIPCION"
            uce_Forma_cobro.ValueMember = "FC_ID"

            formaCobroBE = Nothing
            formaCobroBL = Nothing


            Dim formaEnvioBL As New BL.ContabilidadBL.SG_CO_TB_FORMAENVIO
            Dim formaEnvioBE As New BE.ContabilidadBE.SG_CO_TB_FORMAENVIO
            formaEnvioBE.FE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_forma_envio.DataSource = formaEnvioBL.getFormaEnvio(formaEnvioBE)
            uce_forma_envio.DisplayMember = "FE_DESCRIPCION"
            uce_forma_envio.ValueMember = "FE_ID"

            formaEnvioBE = Nothing
            formaEnvioBL = Nothing

            Dim formaDespachoBL As New BL.ContabilidadBL.SG_CO_TB_FORMADESPACHO
            Dim formaDespachoBE As New BE.ContabilidadBE.SG_CO_TB_FORMADESPACHO
            formaDespachoBE.FD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_forma_despacho.DataSource = formaDespachoBL.getFormaDespacho(formaDespachoBE)
            uce_forma_despacho.ValueMember = "FD_ID"
            uce_forma_despacho.DisplayMember = "FD_DESCRIPCION"

            formaDespachoBE = Nothing
            formaDespachoBL = Nothing


            Dim VendedorBL As New BL.ContabilidadBL.SG_CO_TB_VENDEDOR
            Dim VendedorBE As New BE.ContabilidadBE.SG_CO_TB_VENDEDOR
            VendedorBE.VE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_vendedor.DataSource = VendedorBL.getVendedor(VendedorBE)
            uce_vendedor.DisplayMember = "VE_DESCRIPCION"
            uce_vendedor.ValueMember = "VE_ID"

            VendedorBE = Nothing
            VendedorBL = Nothing

            Dim CobradorBL As New BL.ContabilidadBL.SG_CO_TB_COBRADOR
            Dim CobradorBE As New BE.ContabilidadBE.SG_CO_TB_COBRADOR
            CobradorBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_cobrador.DataSource = CobradorBL.getCobrador(CobradorBE)
            uce_cobrador.DisplayMember = "CO_DESCRIPCION"
            uce_cobrador.ValueMember = "CO_ID"

            CobradorBL = Nothing
            CobradorBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_num_doc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ape_pat.KeyDown, ume_tel2.KeyDown, ume_tel1.KeyDown, ume_mobil2.KeyDown, ume_mobil1.KeyDown, ume_fax2.KeyDown, ume_fax1.KeyDown, txt_nombres.KeyDown, txt_ape_mat.KeyDown, uchk_es_principal.KeyDown, uchk_buen_contri.KeyDown, uchk_a_retencion.KeyDown, uchk_a_percepcion.KeyDown, uce_vendedor.KeyDown, uce_pais.KeyDown, uce_moneda.KeyDown, uce_gironegocio.KeyDown, uce_forma_envio.KeyDown, uce_forma_despacho.KeyDown, uce_Forma_cobro.KeyDown, txt_web_site.KeyDown, txt_repre_legal.KeyDown, txt_referencia.KeyDown, txt_email.KeyDown, txt_dir_legal.KeyDown, txt_dir_fiscal.KeyDown, txt_codigo_postal.KeyDown, txt_cod_industrial.KeyDown, txt_ciudad.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub UltraTextEditor1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_razon.KeyDown
        If e.KeyCode = Keys.Enter Then uce_gironegocio.Focus()
    End Sub

    Private Sub txt_doc_repre_legal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_doc_repre_legal.KeyDown
        If e.KeyCode = Keys.Enter Then uce_Forma_cobro.Focus()
    End Sub

    Private Sub uce_cobrador_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_cobrador.KeyDown
        If e.KeyCode = Keys.Enter Then uchk_a_percepcion.Focus()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            Dim ClienteDetBL As New BL.ContabilidadBL.SG_CO_TB_CLIENTES
            Dim ClienteDetBE As New BE.ContabilidadBE.SG_CO_TB_CLIENTES

            With ClienteDetBE
                .CL_IDCLIENTE = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = Int_IdCliente}
            End With

            ClienteDetBL.Delete(ClienteDetBE)

            ClienteDetBL = Nothing
            ClienteDetBE = Nothing

            Avisar("Los datos se eliminaron!")

            Limpiar_Controls_InGroupox(UltraGroupBox1)
            Limpiar_Controls_InGroupox(UltraGroupBox2)
            Limpiar_Controls_InGroupox(UltraGroupBox3)
            Limpiar_Controls_InGroupox(UltraGroupBox4)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class