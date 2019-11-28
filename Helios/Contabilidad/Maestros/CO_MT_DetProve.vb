Public Class CO_MT_DetProve

    Public int_idanexo As Integer
    Public str_razon As String

    Private Sub CO_MT_DetProve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()

        Dim proveedorBL As New BL.ContabilidadBL.SG_CO_TB_PROVEEDOR
        Dim proveedorBE As New BE.ContabilidadBE.SG_CO_TB_PROVEEDOR
        Dim Dt_proveedor As DataTable = Nothing

        With proveedorBE
            .PR_IDPROVEEDOR = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = int_idanexo}
        End With

        Dt_proveedor = proveedorBL.getProveedor(proveedorBE)

        Limpiar_Controls_InGroupox(UltraGroupBox1)
        Limpiar_Controls_InGroupox(UltraGroupBox2)


        Dim elcontrol As Control
        For Each elcontrol In UltraGroupBox2.Controls
            If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = Nothing
            End If
        Next


        txt_razon.Text = str_razon

        If Dt_proveedor.Rows.Count > 0 Then
            With proveedorBE
                txt_ape_pat.Text = Dt_proveedor.Rows(0)("PR_APE_PAT")
                txt_ape_mat.Text = Dt_proveedor.Rows(0)("PR_APE_MAT")
                txt_nombres.Text = Dt_proveedor.Rows(0)("PR_NOMBRES")
                txt_razon.Text = Dt_proveedor.Rows(0)("PR_RAZON_SOCIAL")
                uce_gironegocio.Value = Dt_proveedor.Rows(0)("PR_GIRO_NEGOCIO")
                txt_dir_fiscal.Text = Dt_proveedor.Rows(0)("PR_DIR_FISCAL").ToString
                txt_dir_legal.Text = Dt_proveedor.Rows(0)("PR_DIR_LEGAL").ToString
                uce_pais.Value = Dt_proveedor.Rows(0)("PR_IDPAIS")
                txt_codigo_postal.Text = Dt_proveedor.Rows(0)("PR_CODIGO_POSTAL")
                txt_ciudad.Text = Dt_proveedor.Rows(0)("PR_CITY")
                txt_referencia.Text = Dt_proveedor.Rows(0)("PR_REFERENCIA")
                ume_tel1.Value = Dt_proveedor.Rows(0)("PR_TELEF")
                ume_tel2.Value = Dt_proveedor.Rows(0)("PR_TELEF2")
                ume_mobil1.Value = Dt_proveedor.Rows(0)("PR_MOVIL1")
                'ume_mobil2.Value = Dt_proveedor.Rows(0)("PR_MOVIL2")
                ume_fax1.Value = Dt_proveedor.Rows(0)("PR_FAX1")
                ume_fax2.Value = Dt_proveedor.Rows(0)("PR_FAX2")
                txt_email.Text = Dt_proveedor.Rows(0)("PR_EMAIL")
                txt_web_site.Text = Dt_proveedor.Rows(0)("PR_WEBSITE")
                txt_cod_industrial.Text = Dt_proveedor.Rows(0)("PR_CODIGO_INDUSTRIAL")
                'uce_Forma_pago.Value = Dt_proveedor.Rows(0)("PR_IDFORMA_PAGO")
                'uce_moneda.Value = Dt_proveedor.Rows(0)("PR_IDMONEDA")
                'uce_forma_envio.Value = Dt_proveedor.Rows(0)("PR_FORMA_ENVIO")
                'uce_forma_despacho.Value = Dt_proveedor.Rows(0)("PR_FORMA_DESPACHO")
                txt_repre_legal.Text = Dt_proveedor.Rows(0)("PR_REPRESENTANTE_LEGAL")
                txt_doc_repre_legal.Text = Dt_proveedor.Rows(0)("PR_REPRESENTANTE_DNI")
                'uce_vendedor.Value = Dt_proveedor.Rows(0)("PR_IDVENDEDOR")
                'uce_cobrador.Value = Dt_proveedor.Rows(0)("PR_IDCOBRADOR")
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

          
        End If

        Dt_proveedor.Dispose()
        proveedorBE = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click


        Dim proveBE As New BE.ContabilidadBE.SG_CO_TB_PROVEEDOR
        Dim proveBL As New BL.ContabilidadBL.SG_CO_TB_PROVEEDOR

        With proveBE
            .PR_IDPROVEEDOR = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = int_idanexo}
            .PR_RAZON_SOCIAL = txt_razon.Text
            .PR_APE_PAT = txt_ape_pat.Text
            .PR_APE_MAT = txt_ape_mat.Text
            .PR_NOMBRES = txt_nombres.Text

            If uce_gironegocio.SelectedIndex = -1 Then
                .PR_GIRO_NEGOCIO = String.Empty
            Else
                .PR_GIRO_NEGOCIO = uce_gironegocio.Value.ToString
            End If


            .PR_DIR_FISCAL = txt_dir_fiscal.Value
            .PR_DIR_LEGAL = txt_dir_legal.Text
            .PR_IDPAIS = New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = uce_pais.Value}
            .PR_CITY = txt_ciudad.Text
            .PR_CODIGO_POSTAL = txt_codigo_postal.Text
            .PR_REFERENCIA = txt_referencia.Text
            .PR_TELEF = ume_tel1.Value.ToString
            .PR_TELEF2 = ume_tel2.Value.ToString
            .PR_MOVIL1 = ume_mobil1.Value.ToString
            .PR_FAX1 = ume_fax1.Value.ToString
            .PR_FAX2 = ume_fax2.Value.ToString
            .PR_EMAIL = txt_email.Text
            .PR_WEBSITE = txt_web_site.Text
            .PR_CODIGO_INDUSTRIAL = txt_cod_industrial.Text
            .PR_IDFORMA_PAGO = New BE.ContabilidadBE.SG_CO_TB_FORMAPAGO With {.ID = 1}
            .PR_REPRESENTANTE_LEGAL = txt_repre_legal.Text
            .PR_REPRESENTANTE_DNI = txt_doc_repre_legal.Text
            .PR_DESCUENTO = 0
            .PR_ES_AGENTE_PERCEPCION = 0
            .PR_ES_AGENTE_RETENCION = 0
            .PR_ES_BUEN_CONTRIBUYENTE = 0
            .PR_DIAS_CREDITO = 0
            .PR_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PR_PC_TERMINAL = Environment.MachineName
            .PR_PC_FECREG = Now.Date


        End With

        proveBL.Insert(proveBE)

        Avisar("Listo!")

        proveBL = Nothing
        proveBE = Nothing

        Me.Close()

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


            'Dim MonedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
            'uce_moneda.DataSource = MonedaBL.getMonedas()
            'uce_moneda.DisplayMember = "MO_DESCRIPCION"
            'uce_moneda.ValueMember = "MO_CODIGO"

            'MonedaBL = Nothing



            'Dim formaCobroBL As New BL.ContabilidadBL.SG_CO_TB_FORMACOBRANZA
            'Dim formaCobroBE As New BE.ContabilidadBE.SG_CO_TB_FORMACOBRANZA
            'formaCobroBE.FC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'uce_Forma_pago.DataSource = formaCobroBL.getFormasCobro(formaCobroBE)
            'uce_Forma_pago.DisplayMember = "FC_DESCRIPCION"
            'uce_Forma_pago.ValueMember = "FC_ID"

            'formaCobroBE = Nothing
            'formaCobroBL = Nothing


            'Dim formaEnvioBL As New BL.ContabilidadBL.SG_CO_TB_FORMAENVIO
            'Dim formaEnvioBE As New BE.ContabilidadBE.SG_CO_TB_FORMAENVIO
            'formaEnvioBE.FE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'uce_forma_envio.DataSource = formaEnvioBL.getFormaEnvio(formaEnvioBE)
            'uce_forma_envio.DisplayMember = "FE_DESCRIPCION"
            'uce_forma_envio.ValueMember = "FE_ID"

            'formaEnvioBE = Nothing
            'formaEnvioBL = Nothing

            'Dim formaDespachoBL As New BL.ContabilidadBL.SG_CO_TB_FORMADESPACHO
            'Dim formaDespachoBE As New BE.ContabilidadBE.SG_CO_TB_FORMADESPACHO
            'formaDespachoBE.FD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'uce_forma_despacho.DataSource = formaDespachoBL.getFormaDespacho(formaDespachoBE)
            'uce_forma_despacho.ValueMember = "FD_ID"
            'uce_forma_despacho.DisplayMember = "FD_DESCRIPCION"

            'formaDespachoBE = Nothing
            'formaDespachoBL = Nothing


            'Dim VendedorBL As New BL.ContabilidadBL.SG_CO_TB_VENDEDOR
            'Dim VendedorBE As New BE.ContabilidadBE.SG_CO_TB_VENDEDOR
            'VendedorBE.VE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'uce_vendedor.DataSource = VendedorBL.getVendedor(VendedorBE)
            'uce_vendedor.DisplayMember = "VE_DESCRIPCION"
            'uce_vendedor.ValueMember = "VE_ID"

            'VendedorBE = Nothing
            'VendedorBL = Nothing

            'Dim CobradorBL As New BL.ContabilidadBL.SG_CO_TB_COBRADOR
            'Dim CobradorBE As New BE.ContabilidadBE.SG_CO_TB_COBRADOR
            'CobradorBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'uce_cobrador.DataSource = CobradorBL.getCobrador(CobradorBE)
            'uce_cobrador.DisplayMember = "CO_DESCRIPCION"
            'uce_cobrador.ValueMember = "CO_ID"

            'CobradorBL = Nothing
            'CobradorBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class