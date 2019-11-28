Public Class FA_MA_Cajeros

    Dim Bol_Nuevo As Boolean = False

    Private Sub FA_MA_Cajeros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Datos()
        Call Cargar_Usuario_Sistema()

        Call Formatear_Grilla_Selector(ug_Cajeros)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Cajeros, 0)

    End Sub

    Private Sub Cargar_Datos()
        Dim cajeroBL As New BL.FacturacionBL.SG_FA_TB_CAJERO
        ug_Cajeros.DataSource = cajeroBL.get_Cajeros(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        cajeroBL = Nothing
    End Sub

    Private Sub Cargar_Usuario_Sistema()
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        uce_Vendedor.DataSource = usuarioBL.getUsuarios
        uce_Vendedor.DisplayMember = "US_NOMBRE"
        uce_Vendedor.ValueMember = "US_ID"
        usuarioBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Cajeros.Rows.Count = 0 Then Exit Sub
        If ug_Cajeros.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de Eliminar?") Then
            Dim cajeroBL As New BL.FacturacionBL.SG_FA_TB_CAJERO
            Dim cajeroBE As New BE.FacturacionBE.SG_FA_TB_CAJERO
            cajeroBE.CA_ID = ug_Cajeros.ActiveRow.Cells("CA_ID").Value
            cajeroBE.CA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            cajeroBL.Delete(cajeroBE)
            cajeroBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Listo")
            ug_Cajeros.Focus()
        End If

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Cajeros, 0)
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Cajeros.Rows.Count = 0 Then Exit Sub
        If ug_Cajeros.ActiveRow Is Nothing Then Exit Sub

        txt_codigo.Text = ug_Cajeros.ActiveRow.Cells("CA_ID").Value
        txt_Nombre.Text = ug_Cajeros.ActiveRow.Cells("CA_NOMBRES").Value
        uce_Vendedor.Value = ug_Cajeros.ActiveRow.Cells("CA_IDUSUARIO").Value
        uchk_estado.Checked = ug_Cajeros.ActiveRow.Cells("CA_ESTADO").Value

        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Cajeros, 1)

        txt_Nombre.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_codigo.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar un codigo")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_Nombre.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar el nombre")
            txt_Nombre.Focus()
            Exit Sub
        End If

        Dim cajeroBL As New BL.FacturacionBL.SG_FA_TB_CAJERO
        Dim cajeroBE As New BE.FacturacionBE.SG_FA_TB_CAJERO

        With cajeroBE
            .CA_ID = txt_codigo.Text.Trim
            .CA_NOMBRES = txt_Nombre.Text.Trim
            .CA_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Vendedor.Value}
            .CA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .CA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CA_TERMINAL = Environment.MachineName
            .CA_FECREG = Date.Now
            .CA_ESTADO = IIf(uchk_estado.Checked, 1, 0)
        End With

        If Bol_Nuevo Then cajeroBL.Insert(cajeroBE) Else cajeroBL.Update(cajeroBE)

        Call Avisar("Listo!")
        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Cajeros, 1)

        Bol_Nuevo = True
        uchk_estado.Checked = Bol_Nuevo

        txt_codigo.Enabled = True
        txt_codigo.Focus()
    End Sub
End Class