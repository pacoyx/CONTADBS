Public Class FA_MA_Monedas

    Dim bol_nuevo As Boolean = False

    Private Sub FA_MA_Monedas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Datos()
        Call Cargar_Monedas_Conta()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Monedas, 0)
        Call Formatear_Grilla_Selector(ug_Monedas)

    End Sub

    Private Sub Cargar_Datos()
        Dim monedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA
        ug_Monedas.DataSource = monedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        monedaBL = Nothing
    End Sub

    Private Sub Cargar_Monedas_Conta()
        Dim monedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
        uce_MonedaConta.DataSource = monedaBL.getMonedas
        uce_MonedaConta.DisplayMember = "MO_DESCRIPCION"
        uce_MonedaConta.ValueMember = "MO_CODIGO"
        monedaBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Monedas)

        txt_codigo.Focus()
        txt_codigo.Enabled = True

        bol_nuevo = True
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text.Trim.Length = 0 Then
            Avisar("Ingrese el codigo")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim.Length = 0 Then
            Avisar("Ingresar la descripcion")
            txt_des.Focus()
            Exit Sub
        End If


        Dim monedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA
        Dim monedaBE As New BE.FacturacionBE.SG_FA_TB_MONEDA

        With monedaBE
            .MO_ID = txt_codigo.Text.Trim
            .MO_DESCRIPCION = txt_des.Text.Trim
            .MO_ABREVIATURA = txt_abre.Text.Trim
            .MO_SIMBOLO = txt_simbolo.Text.Trim

            If uce_MonedaConta.SelectedIndex = -1 Then
                .MO_IDMON_CONTA = Nothing
            Else
                .MO_IDMON_CONTA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = uce_MonedaConta.Value}
            End If

            .MO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With


        If bol_nuevo Then
            monedaBL.Insert(monedaBE)
        Else
            monedaBL.Update(monedaBE)
        End If

        monedaBE = Nothing
        monedaBL = Nothing


        Call Cargar_Datos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Avisar("Listo")
        Call MostrarTabs(0, utc_Monedas)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Monedas.Rows.Count = 0 Then Exit Sub
        If ug_Monedas.ActiveRow Is Nothing Then Exit Sub

        txt_codigo.Text = ug_Monedas.ActiveRow.Cells("MO_ID").Value
        txt_des.Text = ug_Monedas.ActiveRow.Cells("MO_DESCRIPCION").Value
        txt_abre.Text = ug_Monedas.ActiveRow.Cells("MO_ABREVIATURA").Value
        txt_simbolo.Text = ug_Monedas.ActiveRow.Cells("MO_SIMBOLO").Value
        uce_MonedaConta.Value = ug_Monedas.ActiveRow.Cells("MO_IDMON_CONTA").Value

        bol_nuevo = False
        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Monedas, 1)

        txt_des.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Monedas, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Monedas.Rows.Count = 0 Then Exit Sub
        If ug_Monedas.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Esta seguro de Eliminar?") Then
            Dim monedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA
            Dim monedaBE As New BE.FacturacionBE.SG_FA_TB_MONEDA

            monedaBE.MO_ID = ug_Monedas.ActiveRow.Cells("MO_ID").Value
            monedaBE.MO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            monedaBL.Delete(monedaBE)

            Call Avisar("Listo!")

            monedaBE = Nothing
            monedaBL = Nothing
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown, uce_MonedaConta.KeyDown, txt_simbolo.KeyDown, txt_des.KeyDown, txt_abre.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub
End Class