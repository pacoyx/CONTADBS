Public Class FA_MA_FormaPago

    Dim bol_nuevo As Boolean

    Private Sub FA_MA_FormaPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_FormasPago()
        Call MostrarTabs(0, utc_FormaPago, 0)
        Call Formatear_Grilla_Selector(ug_Lista)

    End Sub


    Private Sub Cargar_Lista_FormasPago()

        Dim formapBL As New BL.FacturacionBL.SG_FA_TB_FORMA_PAGO
        ug_Lista.DataSource = formapBL.get_Lista_FP(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        formapBL = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Limpiar_Controls_InGroupox(ugb_datos)
        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(1, utc_FormaPago)

        txt_codigo.Focus()
        txt_codigo.Enabled = True

        bol_nuevo = True
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim formapBL As New BL.FacturacionBL.SG_FA_TB_FORMA_PAGO
        Dim formapBE As New BE.FacturacionBE.SG_FA_TB_FORMA_PAGO

        formapBE.FP_ID = txt_codigo.Text.Trim
        formapBE.FP_DESCRIPCION = txt_des.Text.Trim
        formapBE.FP_ES_CREDITO = IIf(uchk_es_credito.Checked, 1, 0)
        formapBE.FP_DIAS_CREDITO = une_diasCredito.Value
        formapBE.FP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If bol_nuevo Then
            formapBL.Insert(formapBE)
        Else
            formapBL.Update(formapBE)
        End If

        formapBE = Nothing
        formapBL = Nothing


        Cargar_Lista_FormasPago()
        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Avisar("Listo")
        MostrarTabs(0, utc_FormaPago)


    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("FP_ID").Value
        txt_des.Text = ug_Lista.ActiveRow.Cells("FP_DESCRIPCION").Value
        uchk_es_credito.Checked = ug_Lista.ActiveRow.Cells("FP_ES_CREDITO").Value
        une_diasCredito.Value = ug_Lista.ActiveRow.Cells("FP_DIAS_CREDITO").Value

        bol_nuevo = False
        txt_codigo.Enabled = False

        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(1, utc_FormaPago, 1)

        txt_des.Focus()




    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(0, utc_FormaPago)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Esta seguro de Eliminar") Then

            Dim formapBL As New BL.FacturacionBL.SG_FA_TB_FORMA_PAGO
            Dim formapBE As New BE.FacturacionBE.SG_FA_TB_FORMA_PAGO

            formapBE.FP_ID = ug_Lista.ActiveRow.Cells("FP_ID").Value
            formapBE.FP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            formapBL.Delete(formapBE)

            formapBE = Nothing
            formapBL = Nothing
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uchk_es_credito_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_es_credito.CheckedChanged
        If Not uchk_es_credito.Checked Then
            une_diasCredito.Value = 0
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            uchk_es_credito.Focus()
        End If
    End Sub

    Private Sub uchk_es_credito_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uchk_es_credito.KeyDown
        If e.KeyCode = Keys.Enter Then
            une_diasCredito.Focus()
        End If
    End Sub
End Class