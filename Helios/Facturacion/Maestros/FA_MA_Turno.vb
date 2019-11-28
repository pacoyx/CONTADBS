Public Class FA_MA_Turno
    Dim Bol_Nuevo As Boolean

    Private Sub FA_MA_Turno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub CargarDatos()
        Dim turnoBL As New BL.FacturacionBL.SG_FA_TB_TURNO
        Dim turnoBE As New BE.FacturacionBE.SG_FA_TB_TURNO
        turnoBE.TU_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = turnoBL.get_Turnos(turnoBE)
        turnoBE = Nothing
        turnoBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True

        txt_codigo.Enabled = True
        txt_codigo.Value = 0
        txt_codigo.Focus()

    End Sub


    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text.Length = 0 Then
            Avisar("Ingrese el codigo")
            txt_codigo.Focus()
            Exit Sub
        End If

        Dim turnoBE As New BE.FacturacionBE.SG_FA_TB_TURNO
        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_TURNO

        turnoBE.TU_ID = txt_codigo.Text
        turnoBE.TU_DESCRIPCION = txt_des.Text
        turnoBE.TU_IDEMPRESA = gInt_IdEmpresa

        If Bol_Nuevo Then
            familiaBL.Insert(turnoBE)
        Else
            familiaBL.Update(turnoBE)
        End If


        turnoBE = Nothing
        familiaBL = Nothing


        Avisar("Listo")

        Call CargarDatos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_TipoAne, 0)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        Call Limpiar_Controls_InGroupox(ugb_datos)

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("TU_ID").Value
        txt_des.Text = ug_Lista.ActiveRow.Cells("TU_DESCRIPCION").Value

        Bol_Nuevo = False
        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)

        txt_des.Focus()


    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("seguro de eliminar?") Then
            Dim familiaBE As New BE.FacturacionBE.SG_FA_TB_TURNO
            Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_TURNO

            familiaBE.TU_ID = ug_Lista.ActiveRow.Cells("TU_ID").Value
            familiaBE.TU_IDEMPRESA = gInt_IdEmpresa

            familiaBL.Delete(familiaBE)

            familiaBL = Nothing
            familiaBE = Nothing

            Call CargarDatos()

            Avisar("Listo")
        End If

    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub ug_Lista_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        Call Tool_Editar_Click(sender, e)
    End Sub
End Class