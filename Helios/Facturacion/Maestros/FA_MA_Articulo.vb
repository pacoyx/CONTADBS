Public Class FA_MA_Articulo
    Dim Bol_Nuevo As Boolean = False

    Private Sub FA_MA_Articulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call CargarDatos()
        Call Cargar_Combos()
        Call Cargar_Monedas()
        Call Cargar_Tipo_Articulo()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_TipoAne, 0)

    End Sub

   

    Private Sub CargarDatos()
        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        ug_Lista.DataSource = articuloBL.get_Articulos_FA(gInt_IdEmpresa)
        articuloBL = Nothing
    End Sub


    Private Sub Cargar_Combos()

        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI
        uce_Familia.DataSource = familiaBL.get_Familias_Combo(gInt_IdEmpresa)
        uce_Familia.DisplayMember = "FA_DESCRIPCION"
        uce_Familia.ValueMember = "FA_CODIGO"
        familiaBL = Nothing

    End Sub
    Private Sub Cargar_Tipo_Articulo()

        Dim tipoArtBL As New BL.FacturacionBL.SG_FA_TB_TIPO_ARTICULO
        uce_tipo.DataSource = tipoArtBL.getTipos(gInt_IdEmpresa)
        uce_tipo.DisplayMember = "TA_DESCRIPCION"
        uce_tipo.ValueMember = "TA_ID"

        tipoArtBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA

        uce_moneda.DataSource = monedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_moneda.DisplayMember = "MO_ABREVIATURA"
        uce_moneda.ValueMember = "MO_ID"

        monedaBL = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 2)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True

        lbl_des_cta.Text = ""
        txt_codigo.Enabled = True
        uce_tipo.Enabled = True

        txt_codigo.Text = ""
        uce_PrecioVta.Value = 0
        uce_tipo.Value = "S"
        uce_moneda.SelectedIndex = 0
        uce_Familia.SelectedIndex = 0

        Call Obtener_Ult_Codigo_Articulo()

        txt_codigo.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_cta_conta.Text.Trim.Length > 0 Then
            lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        End If


        If txt_codigo.Text.Trim.Length = 0 Then
            Avisar("Ingrese el codigo")
            txt_codigo.Focus()
            Exit Sub
        End If


        If txt_descripcion.Text.Trim.Length = 0 Then
            Avisar("Ingrese la descripcion")
            txt_descripcion.Focus()
            Exit Sub
        End If

        If txt_cta_conta.Text.Length > 0 Then
            If lbl_des_cta.Text.StartsWith("*") Then
                Avisar("La cuenta no existe, ingrese una cuenta valida.")
                txt_cta_conta.Focus()
                Exit Sub
            End If
        End If


        

        Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

        With articuloBE

            .AR_CODIGO = txt_codigo.Text.Trim
            .AR_CODIGO_ALT = txt_cod_alt.Text.Trim
            .AR_DESCRIPCION = txt_descripcion.Text
            .AR_PRECIO_VENTA = uce_PrecioVta.Value
            .AR_IDFAMILIA = uce_Familia.Value
            .AR_IDCATEGORIA = uce_Categoria.Value
            .AR_NUM_CTA_CONTA = txt_cta_conta.Text.Trim
            .AR_ESTADO = uos_Estado.Value
            .AR_IDEMPRESA = gInt_IdEmpresa
            .AR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AR_TERMINAL = Environment.MachineName
            .AR_FECREG = Now.Date
            .AR_TIPO_ARTI = uce_tipo.Value
            .AR_INCLUYE_IGV = IIf(uchk_incluyeIgv.Checked, 1, 0)
            .AR_ING_RAP = IIf(uchk_ing_rap.Checked, 1, 0)
            .AR_MON_VTA = uce_moneda.Value
            .AR_CTRL_STOCK = uos_stock.Value
            .AR_ORIGEN = "FA"
            .AR_ES_NO_AFEC_IGV = IIf(uchk_noafecto.Checked, 1, 0)
        End With



        If Bol_Nuevo Then
            articuloBL.Insert(articuloBE)
        Else
            articuloBL.Update(articuloBE)
        End If

        articuloBE = Nothing
        articuloBL = Nothing

        Call CargarDatos()
        Call Avisar("Listo")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(0, utc_TipoAne, 0)
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        Call Limpiar_Controls_InGroupox(ugb_datos)

     
        txt_descripcion.Text = ug_Lista.ActiveRow.Cells("AR_DESCRIPCION").Value
        uce_PrecioVta.Value = ug_Lista.ActiveRow.Cells("AR_PRECIO_VENTA").Value
        uce_Familia.Value = ug_Lista.ActiveRow.Cells("AR_IDFAMILIA").Value
        txt_cta_conta.Text = ug_Lista.ActiveRow.Cells("AR_NUM_CTA_CONTA").Value.ToString

        uce_moneda.Value = ug_Lista.ActiveRow.Cells("AR_MON_VTA").Value.ToString
        uos_stock.Value = ug_Lista.ActiveRow.Cells("AR_CTRL_STOCK").Value

        If txt_cta_conta.Text.Trim.Length > 0 Then
            lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        Else
            lbl_des_cta.Text = ""
        End If

        uos_Estado.Value = IIf(ug_Lista.ActiveRow.Cells("AR_ESTADO").Value, 1, 0)

        uce_tipo.Value = ug_Lista.ActiveRow.Cells("AR_TIPO_ARTI").Value
        uce_Categoria.Value = ug_Lista.ActiveRow.Cells("AR_IDCATEGORIA").Value
        uchk_incluyeIgv.Checked = IIf(ug_Lista.ActiveRow.Cells("AR_INCLUYE_IGV").Value = 1, True, False)
        uchk_ing_rap.Checked = IIf(ug_Lista.ActiveRow.Cells("AR_ING_RAP").Value = 1, True, False)
        uchk_noafecto.Checked = IIf(ug_Lista.ActiveRow.Cells("AR_ES_NO_AFEC_IGV").Value = 1, True, False)

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("AR_CODIGO").Value
        txt_cod_alt.Text = ug_Lista.ActiveRow.Cells("AR_CODIGO_ALT").Value

        Bol_Nuevo = False
        txt_codigo.Enabled = False
        uce_tipo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)

        txt_descripcion.Focus()


    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If Preguntar("seguro de eliminar?") Then
            Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
            Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

            articuloBE.AR_CODIGO = ug_Lista.ActiveRow.Cells("AR_CODIGO").Value
            articuloBE.AR_IDEMPRESA = gInt_IdEmpresa

            articuloBL.Delete(articuloBE)

            articuloBL = Nothing
            articuloBE = Nothing

            Call CargarDatos()

            Call Avisar("Listo")

        End If

    End Sub


    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_alt.Focus()
        End If
    End Sub

    Private Sub ug_Lista_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub uce_Familia_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Familia.ValueChanged

        Dim categoriaBL As New BL.FacturacionBL.SG_FA_TB_CATEGORIA_ARTI
        Dim familiaBE As New BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI

        familiaBE.FA_CODIGO = uce_Familia.Value
        familiaBE.FA_IDEMPRESA = gInt_IdEmpresa

        uce_Categoria.DataSource = categoriaBL.get_Categorias_x_Familia(familiaBE)
        uce_Categoria.DisplayMember = "CA_DESCRIPCION"
        uce_Categoria.ValueMember = "CA_CODIGO"

        familiaBE = Nothing
        categoriaBL = Nothing

    End Sub

    Private Sub txt_codigo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_codigo.ValueChanged
        txt_cod_alt.Text = txt_codigo.Text
    End Sub

    Private Sub txt_cod_alt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_alt.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_descripcion.Focus()
        End If
    End Sub

    Private Sub txt_descripcion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_descripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_PrecioVta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_PrecioVta.KeyDown
        If e.KeyCode = Keys.Enter Then uce_Familia.Focus()
    End Sub

    Private Sub uce_Categoria_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Categoria.KeyDown
        If e.KeyCode = Keys.Enter Then txt_cta_conta.Focus()
    End Sub


    Private Sub uchk_ing_rap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_ing_rap.CheckedChanged

        If uchk_ing_rap.Checked Then

            Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
            Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
            articuloBE.AR_CODIGO = txt_codigo.Text
            articuloBE.AR_IDEMPRESA = gInt_IdEmpresa

            If articuloBL.Existe_Arti_Ingreso_Rap(articuloBE) Then
                Call Avisar("ya existe un articulo con la opcion de 'Ingreso Rapido'")
                uchk_ing_rap.Checked = False
            End If

            articuloBE = Nothing
            articuloBL = Nothing

        End If
    End Sub

    Private Sub txt_cta_conta_Leave(sender As System.Object, e As System.EventArgs) Handles txt_cta_conta.Leave
        lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
    End Sub

    Private Sub Obtener_Ult_Codigo_Articulo()

        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        txt_codigo.Text = articuloBL.get_Codigo_Articulo_Nuevo(gInt_IdEmpresa, uce_tipo.Value)
        articuloBL = Nothing

    End Sub

    Private Sub uce_Familia_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_tipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_tipo.ValueChanged

        If Bol_Nuevo Then
            Call Obtener_Ult_Codigo_Articulo()
        End If

    End Sub

    Private Sub uce_moneda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class