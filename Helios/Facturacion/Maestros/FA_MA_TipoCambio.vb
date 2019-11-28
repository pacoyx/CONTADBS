Public Class FA_MA_TipoCambio

    Dim bol_nuevo As Boolean = False

    Private Sub FA_MA_TipoCambio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_tc, 0)
        Call Formatear_Grilla_Selector(ug_tc)
    End Sub

    Private Sub Cargar_Datos()
        Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
        Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

        tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        tipocambioBE.PA_FECHA = gDat_Fecha_Sis

        ug_tc.DataSource = tipocambioBL.get_Pariedad_x_Ayo(tipocambioBE)

        tipocambioBE = Nothing
        tipocambioBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_tc, 1)

        udte_fecha.Value = gDat_Fecha_Sis
        udte_fecha.Enabled = True
        udte_fecha.Focus()

        bol_nuevo = True
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If ume_compra.Value.ToString.Length = 0 Then
            Avisar("Ingrese el valor para 'compra'")
            ume_compra.Focus()
            Exit Sub
        End If

        If ume_Venta.Value.ToString.Length = 0 Then
            Avisar("Ingrese el valor para 'venta'")
            ume_Venta.Focus()
            Exit Sub
        End If

        Dim tcBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
        Dim tcBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

        tcBE.PA_COMPRA = ume_compra.Value
        tcBE.PA_VENTA = ume_Venta.Value
        tcBE.PA_FECHA = CDate(udte_fecha.Value).ToShortDateString
        tcBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        tcBE.PA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
        tcBE.PA_TERMINAL = Environment.MachineName
        tcBE.PA_FECREG = Now.Date
        tcBE.PA_IDMONEDA = New BE.FacturacionBE.SG_FA_TB_MONEDA With {.MO_ID = "02"}

        If bol_nuevo Then
            If uchk_empresas.Checked Then
                tcBL.Insert_AllEmpresas(tcBE)
            Else
                tcBL.Insert(tcBE)
            End If
        Else
            If uchk_empresas.Checked Then
                tcBL.Update_AllEmpresas(tcBE)
            Else
                tcBL.Update(tcBE)
            End If

        End If


        tcBE = Nothing
        tcBL = Nothing

        Call Cargar_Datos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Avisar("Listo")
        Call MostrarTabs(0, utc_tc)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_tc.Rows.Count = 0 Then Exit Sub
        If ug_tc.ActiveRow Is Nothing Then Exit Sub

        udte_fecha.Value = ug_tc.ActiveRow.Cells("PA_FECHA").Value
        ume_compra.Value = ug_tc.ActiveRow.Cells("PA_COMPRA").Value
        ume_Venta.Value = ug_tc.ActiveRow.Cells("PA_VENTA").Value

        udte_fecha.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_tc, 1)

        bol_nuevo = False

        ume_compra.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_tc, 0)
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub udte_fecha_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha.KeyDown, ume_compra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ubtn_tipo_camb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_tipo_camb.Click
        CO_MT_TCamb_Web.Str_Direccion_Defecto = "http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias"
        CO_MT_TCamb_Web.Show()
    End Sub
End Class