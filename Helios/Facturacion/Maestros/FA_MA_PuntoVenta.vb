Public Class FA_MA_PuntoVenta

    Dim bol_nuevo As Boolean = False

    Private Sub FA_MA_PuntoVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_PuntoVentas()
        Call MostrarTabs(0, utc_Lista, 0)
    End Sub

    Private Sub Cargar_Lista_PuntoVentas()
        Dim puntosBL As New BL.FacturacionBL.SG_FA_TB_PUNTO_VENTA
        ug_Lista.DataSource = puntosBL.get_Lista_PuntaVentas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        puntosBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Limpiar_Controls_InGroupox(ugb_datos)
        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(1, utc_Lista)
        txt_codigo.Focus()
        txt_codigo.Enabled = True
        bol_nuevo = True

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim puntosBL As New BL.FacturacionBL.SG_FA_TB_PUNTO_VENTA
        Dim puntosBE As New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA

        puntosBE.PV_ID = txt_codigo.Text.Trim
        puntosBE.PV_DESCRIPCION = txt_des.Text.Trim
        puntosBE.PV_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If bol_nuevo Then
            puntosBL.Insert(puntosBE)
        Else
            puntosBL.Update(puntosBE)
        End If

        Cargar_Lista_PuntoVentas()
        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Avisar("Listo")
        MostrarTabs(0, utc_Lista)

        puntosBE = Nothing
        puntosBL = Nothing

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("PV_ID").Value
        txt_des.Text = ug_Lista.ActiveRow.Cells("PV_DESCRIPCION").Value

        txt_codigo.Enabled = False

        bol_nuevo = False

        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(1, utc_Lista, 1)

        txt_des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click

        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(0, utc_Lista)

    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim puntosBL As New BL.FacturacionBL.SG_FA_TB_PUNTO_VENTA
            Dim puntosBE As New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
            puntosBE.PV_ID = ug_Lista.ActiveRow.Cells("PV_ID").Value
            puntosBE.PV_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            puntosBL.Delete(puntosBE)
            puntosBE = Nothing
            puntosBL = Nothing

            Cargar_Lista_PuntoVentas()

            Avisar("Listo!")

        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Series_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Series.Click


        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        FA_PR_AgregarSeries.IdPuntoVenta = ug_Lista.ActiveRow.Cells("PV_ID").Value
        FA_PR_AgregarSeries.ShowDialog()


    End Sub


    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub
End Class