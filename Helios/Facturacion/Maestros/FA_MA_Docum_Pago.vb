Public Class FA_MA_Docum_Pago

    Dim bol_nuevo As Boolean = False

    Private Sub FA_MA_Docum_Pago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_Documentos()
        Call MostrarTabs(0, utc_Docu, 0)
        Call Formatear_Grilla_Selector(ug_Documentos)
    End Sub

    Private Sub Cargar_Lista_Documentos()
        Dim docuBL As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
        ug_Documentos.DataSource = docuBL.get_DocuPagos(gInt_IdEmpresa)
        docuBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Docu, 1)

        txt_codigo.Focus()
        txt_codigo.Enabled = True

        bol_nuevo = True
    End Sub

    
    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Docu, 0)
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text.Length = 0 Then
            Avisar("Ingrese el codigo del documento")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_des.Text.Length = 0 Then
            Avisar("Ingrese la descripcion del documento")
            txt_des.Focus()
            Exit Sub
        End If

        If txt_Abrevi.Text.Length = 0 Then
            Avisar("Ingrese la abreviatura del documento")
            txt_Abrevi.Focus()
            Exit Sub
        End If

        Dim docusBL As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
        Dim docusBE As New BE.FacturacionBE.SG_FA_TB_DOCU_PAGO

        With docusBE
            .DP_CODIGO = txt_codigo.Text.Trim
            .DP_DESCRIPCION = txt_des.Text.Trim
            .DP_ABREVIATURA = txt_Abrevi.Text.Trim
            .DP_CTA_CONTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = txt_cta_conta.Text.Trim}
            .DP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        If bol_nuevo Then
            docusBL.Insert(docusBE)
        Else
            docusBL.Update(docusBE)
        End If


        Call Cargar_Lista_Documentos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Avisar("Listo")
        Call MostrarTabs(0, utc_Docu, 0)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Documentos.Rows.Count = 0 Then Exit Sub
        If ug_Documentos.ActiveRow Is Nothing Then Exit Sub

        txt_codigo.Text = ug_Documentos.ActiveRow.Cells("DP_CODIGO").Value
        txt_des.Text = ug_Documentos.ActiveRow.Cells("DP_DESCRIPCION").Value

        txt_Abrevi.Text = ug_Documentos.ActiveRow.Cells("DP_ABREVIATURA").Value
        txt_cta_conta.Text = ug_Documentos.ActiveRow.Cells("DP_CTA_CONTA").Value

        bol_nuevo = False
        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Docu, 1)

        txt_des.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Documentos.Rows.Count = 0 Then Exit Sub
        If ug_Documentos.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Esta seguro de Eliminar") Then

            Dim docusBL As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
            Dim docusBE As New BE.FacturacionBE.SG_FA_TB_DOCU_PAGO

            docusBE.DP_CODIGO = ug_Documentos.ActiveRow.Cells("DP_CODIGO").Value
            docusBE.DP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            docusBL.Delete(docusBE)

            docusBE = Nothing
            docusBL = Nothing

            Call Cargar_Lista_Documentos()

        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown, txt_des.KeyDown, txt_Abrevi.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub
End Class