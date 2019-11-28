Public Class FA_MA_Numeracion

    Dim Bol_Nuevo As Boolean = False

    Private Sub FA_MA_Numeracion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Lista_Numeracion()
        Call Cargar_Documentos()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Numeracion, 0)

    End Sub

    Private Sub Cargar_Lista_Numeracion()
        Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
        ug_Lista_Num.DataSource = numeracionBL.get_Lista_Numeracion(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        numeracionBL = Nothing
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        uce_TipoDoc.DataSource = documentosBL.get_Docs_Facturacion(gInt_IdEmpresa)
        uce_TipoDoc.DisplayMember = "DO_ABREVIATURA"
        uce_TipoDoc.ValueMember = "DO_CODIGO"
        documentosBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Lista_Num.Rows.Count = 0 Then Exit Sub
        If ug_Lista_Num.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim SG_FA_TB_NUM_COMPROBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO
            Dim SG_FA_TB_NUM_COMPROBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO

            SG_FA_TB_NUM_COMPROBE.NC_IDTIPO = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = ug_Lista_Num.ActiveRow.Cells("NC_IDTIPO").Value}
            SG_FA_TB_NUM_COMPROBE.NC_SERIE = ug_Lista_Num.ActiveRow.Cells("NC_SERIE").Value
            SG_FA_TB_NUM_COMPROBE.NC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            SG_FA_TB_NUM_COMPROBL.Delete(SG_FA_TB_NUM_COMPROBE)

            SG_FA_TB_NUM_COMPROBE = Nothing
            SG_FA_TB_NUM_COMPROBL = Nothing

            Call Cargar_Lista_Numeracion()
            Call Avisar("Listo!")

        End If
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Numeracion, 0)
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Lista_Num.Rows.Count = 0 Then Exit Sub
        If ug_Lista_Num.ActiveRow Is Nothing Then Exit Sub

        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Numeracion, 1)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        uce_TipoDoc.Value = ug_Lista_Num.ActiveRow.Cells("NC_IDTIPO").Value
        txt_serie.Text = ug_Lista_Num.ActiveRow.Cells("NC_SERIE").Value
        txt_NumDoc.Text = ug_Lista_Num.ActiveRow.Cells("NC_NUMERO").Value

        uce_TipoDoc.Enabled = False
        txt_serie.Enabled = False

        Bol_Nuevo = False

        txt_NumDoc.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim SG_FA_TB_NUM_COMPROBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO
        Dim SG_FA_TB_NUM_COMPROBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO

        SG_FA_TB_NUM_COMPROBE.NC_IDTIPO = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
        SG_FA_TB_NUM_COMPROBE.NC_SERIE = txt_serie.Text.Trim
        SG_FA_TB_NUM_COMPROBE.NC_NUMERO = txt_NumDoc.Text.Trim
        SG_FA_TB_NUM_COMPROBE.NC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}


        If Bol_Nuevo Then
            SG_FA_TB_NUM_COMPROBL.Insert(SG_FA_TB_NUM_COMPROBE)
        Else
            SG_FA_TB_NUM_COMPROBL.Update(SG_FA_TB_NUM_COMPROBE)
        End If

        SG_FA_TB_NUM_COMPROBE = Nothing
        SG_FA_TB_NUM_COMPROBL = Nothing

        Call Cargar_Lista_Numeracion()
        Call Avisar("Listo!")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Numeracion, 1)


        uce_TipoDoc.Enabled = True
        txt_serie.Enabled = True
        Bol_Nuevo = True
        uce_TipoDoc.Focus()

    End Sub

    Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_serie.Focus()
        End If
    End Sub

    Private Sub txt_serie_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_serie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_NumDoc.Focus()
        End If
    End Sub

    Private Sub txt_NumDoc_Leave(sender As System.Object, e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(10, "0")
    End Sub
End Class