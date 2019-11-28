Public Class CO_MT_CentroCosto


    Dim Bol_Nuevo As Boolean = False


    Private Sub CO_MT_CentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Lista_CentroCostos()
        Call Formatear_Grilla_Selector(ug_cc)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)

    End Sub

    Private Sub Cargar_Lista_CentroCostos()
        Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
        ccBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        ug_cc.DataSource = ccBL.getCentroCostos(ccBE)
        ccBE = Nothing
        ccBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_cc, 1)

        Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO

        une_codigo.Value = ccBL.get_Generar_Codigo_CC(gInt_IdEmpresa)

        ccBE = Nothing
        ccBL = Nothing

        Bol_Nuevo = True
        une_codigo.Enabled = True
        une_codigo.Focus()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If Preguntar("Esta seguro de eliminar?") Then
            Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
            Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
            ccBE.CC_CODIGO = ug_cc.ActiveRow.Cells("CC_CODIGO").Value
            ccBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            ccBL.Delete(ccBE)
            Avisar("Listo!")
            Call Cargar_Lista_CentroCostos()
            ccBE = Nothing
            ccBL = Nothing
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_cc, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO

        With ccBE
            .CC_CODIGO = une_codigo.Value
            .CC_DESCRIPCION = txt_des.Text.Trim
            .CC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CC_TERMINAL = Environment.MachineName
            .CC_FECREG = Date.Now
            .CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        If Bol_Nuevo Then
            ccBL.Insert(ccBE)
        Else
            ccBL.Update(ccBE)
        End If

        Call Avisar("Listo!")
        Call Cargar_Lista_CentroCostos()
        Call Tool_Cancelar_Click(sender, e)

        ccBE = Nothing
        ccBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_cc, 1)

        une_codigo.Value = ug_cc.ActiveRow.Cells("CC_CODIGO").Value
        txt_des.Text = ug_cc.ActiveRow.Cells("CC_DESCRIPCION").Value

        Bol_Nuevo = False
        une_codigo.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub ug_cc_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_cc.DoubleClickRow
        If ug_cc.Rows.Count = 0 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub une_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub
End Class