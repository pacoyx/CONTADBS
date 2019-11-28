Imports Infragistics.Win.UltraWinGrid

Public Class FA_MA_Clientes

    Dim Bol_Nuevo As Boolean

    Private Sub FA_MA_Clientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Cargar_Combos()
        Call Setear_Grilla_Couminicacion()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_TipoAne, 0)
    End Sub

    Private Sub Cargar_Combos()

        Dim obj_docPBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_DOC_IDENTIDAD
        uce_TipoDoc.DataSource = obj_docPBL.getTipoDos
        uce_TipoDoc.DisplayMember = "DI_DESCRIPCION"
        uce_TipoDoc.ValueMember = "DI_CODIGO"
        obj_docPBL = Nothing

        txt_ubigeo.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_direccion.ButtonsRight(0).Appearance.Image = My.Resources._104

    End Sub

    Private Sub Setear_Grilla_Couminicacion()
        Dim ComunicacionBL As New BL.FacturacionBL.SG_FA_TB_TIPO_COMUNICACION
        Call CrearComboGrid("CODIGO", "TC_DESCRIPCION", ug_Comunicacion, ComunicacionBL.getTipos(gInt_IdEmpresa), True)
        ComunicacionBL = Nothing
    End Sub

    Private Sub CargarDatos()

        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
        ug_Lista.DataSource = familiaBL.get_Clientes(gInt_IdEmpresa)
        familiaBL = Nothing

        lbl_tot_cli.Text = "N° de Clientes : " & ug_Lista.Rows.Count.ToString()

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        uce_TipoDoc.Value = 6
        Bol_Nuevo = True
        uchk_estado.Checked = True
        txt_nombres.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_nombres.Text.Trim.Length = 0 Then
            Avisar("Ingrese el nombre del cliente")
            txt_nombres.Focus()
            Exit sub
        End If

        If txt_num_doc.Text.Trim.Length = 0 Then
            Avisar("Ingrese el numero de Documento")
            txt_num_doc.Focus()
            Exit Sub
        End If




        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE

        With clienteBE
            .CL_ID = IIf(txt_id.Text.Trim.Length = 0, 0, txt_id.Text.Trim)
            .CL_NOMBRE = txt_nombres.Text
            .CL_TDOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = uce_TipoDoc.Value}
            .CL_NDOC = txt_num_doc.Text.Trim
            .CL_DIRECCION = txt_direccion.Text.Trim
            .CL_ES_RELACIONADO = IIf(uchk_EsRelacionado.Checked, 1, 0)
            .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CL_TERMINAL = Environment.MachineName
            .CL_FECREG = Now.Date
            .CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .CL_ESTADO = IIf(uchk_estado.Checked, 1, 0)
            .CL_FICHA_TEC = txt_ficha_tec.Text.Trim
            .CL_UBIGEO = txt_ubigeo.Text
            .CL_NO_DOMI = IIf(uchk_NoDomi.Checked, 1, 0)
        End With


        ug_Comunicacion.UpdateData()

        Dim ls_comunica As New List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)

        For i As Integer = 0 To ug_Comunicacion.Rows.Count - 1
            If ug_Comunicacion.Rows(i).Cells("Descripcion").Value.ToString.Length > 0 Then
                ls_comunica.Add(New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI With {.CC_IDCLIENTE = clienteBE.CL_ID, .CC_IDCOMUNICA = ug_Comunicacion.Rows(i).Cells("Codigo").Value, .CC_DESCRIPCION = ug_Comunicacion.Rows(i).Cells("Descripcion").Value.ToString})
            End If
        Next


        Try
            If Bol_Nuevo Then
                clienteBL.Insert(clienteBE, ls_comunica)
            Else
                clienteBL.Update(clienteBE, ls_comunica)
            End If
        Catch ex As Exception
            Avisar(ex.Message)
            clienteBE = Nothing
            clienteBL = Nothing
            Exit Sub
        End Try



        clienteBE = Nothing
        clienteBL = Nothing

        Call CargarDatos()
        Call Avisar("Listo")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_TipoAne, 0)
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call LimpiaGrid(ug_Comunicacion, uds_Comunicaciones)

        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE

        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        clienteBE.CL_ID = ug_Lista.ActiveRow.Cells("CL_ID").Value

        clienteBL.get_Cliente_x_Id(clienteBE)

        If clienteBE.HasRow Then
            txt_id.Text = clienteBE.CL_ID
            txt_nombres.Text = ug_Lista.ActiveRow.Cells("CL_NOMBRE").Value
            uce_TipoDoc.Value = clienteBE.CL_TDOC.DI_CODIGO
            txt_num_doc.Text = clienteBE.CL_NDOC
            txt_direccion.Text = clienteBE.CL_DIRECCION

            uchk_EsRelacionado.Checked = IIf(clienteBE.CL_ES_RELACIONADO = 1, True, False)
            uchk_estado.Checked = IIf(clienteBE.CL_ESTADO = 1, True, False)
            uchk_NoDomi.Checked = IIf(clienteBE.CL_NO_DOMI = 1, True, False)

            txt_ficha_tec.Text = clienteBE.CL_FICHA_TEC
            txt_ubigeo.Text = clienteBE.CL_UBIGEO
            txt_idanexo_conta.Text = clienteBE.CL_IDANEX_CONTA
        End If

        clienteBE = Nothing
        clienteBL = Nothing


        Dim comunicacionesBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI
        Dim comunicacionesBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI
        comunicacionesBE.CC_IDCLIENTE = txt_id.Text
        Dim dt_tmp As DataTable = comunicacionesBL.get_Comuninicaciones_xId(comunicacionesBE)
        comunicacionesBE = Nothing
        comunicacionesBL = Nothing

        Call LimpiaGrid(ug_Comunicacion, uds_Comunicaciones)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Comunicacion.DisplayLayout.Bands(0).AddNew()
            ug_Comunicacion.Rows(i).Cells("Codigo").Value = dt_tmp.Rows(i)("CC_IDCOMUNICA")
            ug_Comunicacion.Rows(i).Cells("Descripcion").Value = dt_tmp.Rows(i)("CC_DESCRIPCION")
            ug_Comunicacion.UpdateData()
        Next
        ug_Comunicacion.DisplayLayout.Bands(0).AddNew()


        Bol_Nuevo = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)

        txt_nombres.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("seguro de eliminar?") Then

            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE

            clienteBE.CL_ID = ug_Lista.ActiveRow.Cells("CL_ID").Value
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            clienteBL.Delete(clienteBE)

            clienteBL = Nothing
            clienteBE = Nothing

            Call CargarDatos()

            Call Avisar("Listo")

        End If

    End Sub

    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_id.KeyDown, txt_idanexo_conta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombres.Focus()
        End If
    End Sub

    Private Sub ug_Lista_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub txt_nombres_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_nombres.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_num_doc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_direccion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_telefono_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_des_ubigeo.KeyDown, txt_ubigeo.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.F2 Then
            PL_MA_Ubigeo.ShowDialog()
            If PL_MA_Ubigeo.Bol_Aceptar Then
                txt_ubigeo.Text = PL_MA_Ubigeo.Str_Cod_Ubigeo.ToString
                txt_des_ubigeo.Text = PL_MA_Ubigeo.Str_Des_Ubigeo.ToString
            End If
        End If
    End Sub

    Private Sub txt_correo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_ubigeo_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ubigeo.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ubigeo"
                PL_MA_Ubigeo.ShowDialog()
                If PL_MA_Ubigeo.Bol_Aceptar Then
                    txt_ubigeo.Text = PL_MA_Ubigeo.Str_Cod_Ubigeo.ToString
                    txt_des_ubigeo.Text = PL_MA_Ubigeo.Str_Des_Ubigeo.ToString
                End If
        End Select
    End Sub

    Private Sub txt_direccion_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_direccion.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_sunat"
                CO_MT_TCamb_Web.Show()
        End Select


    End Sub

    Private Sub ug_Comunicacion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_Comunicacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            With ug_Comunicacion
                Select Case ug_Comunicacion.ActiveRow.Cells(ug_Comunicacion.ActiveCell.Column.Index).Column.Key
                    Case "Codigo"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    Case "Descripcion"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        '.PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select
            End With
        End If
    End Sub


    Private Sub utc_TipoAne_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles utc_TipoAne.SelectedTabChanged

    End Sub
End Class