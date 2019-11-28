Public Class FA_MA_Parametros

    Dim Bol_Nuevo As Boolean = False


    Private Sub FA_MA_Parametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call MostrarTabs(0, utc_Parametros, 0)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_Parametros()
        Call Formatear_Grilla_Selector(ug_parametros)

        'Cambios de prueba pra ver el funcionamiento del TFS(team fundation server)
        'subiendo cambios nuevos



    End Sub

    Private Sub Cargar_Lista_Parametros()
        Dim parametrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        ug_parametros.DataSource = parametrosBL.get_Lista_Parametros(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        parametrosBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Parametros, 1)
        Bol_Nuevo = True
        txt_tipo.Enabled = True
        txt_codigo.Enabled = True
        txt_tipo.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Parametros, 0)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        If ug_parametros.Rows.Count = 0 Then Exit Sub

        Bol_Nuevo = False
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Parametros, 1)

        txt_tipo.Text = ug_parametros.ActiveRow.Cells("AD_TIPO").Value.ToString
        txt_codigo.Text = ug_parametros.ActiveRow.Cells("AD_NOMBRE").Value.ToString
        txt_valor.Text = ug_parametros.ActiveRow.Cells("AD_VALOR").Value.ToString

        txt_tipo.Enabled = False
        txt_codigo.Enabled = False


    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_tipo.Text.Trim.Length = 0 Then
            Avisar("Ingrese el Tipo")
            txt_tipo.Focus()
            Exit Sub
        End If

        If txt_codigo.Text.Trim.Length = 0 Then
            Avisar("Ingrese el Codigo")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_valor.Text.Trim.Length = 0 Then
            Avisar("Ingrese el Valor")
            txt_valor.Focus()
            Exit Sub
        End If


        Dim parametroBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim parametroBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        With parametroBE
            .AD_TIPO = txt_tipo.Text.Trim
            .AD_NOMBRE = txt_codigo.Text.Trim
            .AD_VALOR = txt_valor.Text.Trim
            .AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        If Bol_Nuevo Then
            parametroBL.Insert(parametroBE)
            Call Cargar_Lista_Parametros()
        Else
            parametroBL.Update(parametroBE)
        End If

        parametroBE = Nothing
        parametroBL = Nothing

        Call Avisar("Listo!")
        Call Cargar_Lista_Parametros()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If Not Preguntar("Seguro de eliminar el Parametro?") Then Exit Sub

        Dim parametroBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim parametroBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        With parametroBE
            .AD_TIPO = ug_parametros.ActiveRow.Cells("AD_TIPO").Value.ToString
            .AD_NOMBRE = ug_parametros.ActiveRow.Cells("AD_NOMBRE").Value.ToString
            .AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        parametroBL.Delete(parametroBE)

        Call Avisar("Listo!")

        Call Cargar_Lista_Parametros()

        parametroBE = Nothing
        parametroBL = Nothing

    End Sub

    Private Sub txt_tipo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_valor.Focus()
        End If
    End Sub

    Private Sub txt_valor_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_valor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tool_Grabar.Select()
        End If
    End Sub
End Class