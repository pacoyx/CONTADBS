Public Class FA_MA_Familias

    Dim Bol_Nuevo As Boolean

    Private Sub FA_MA_Familias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub CargarDatos()
        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI
        ug_Lista.DataSource = familiaBL.get_Familias(gInt_IdEmpresa)
        familiaBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True

        txt_codigo.Enabled = True
        txt_codigo.Value = 0
        txt_codigo.Focus()

    End Sub



    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim familiaBE As New BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI
        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI

        familiaBE.FA_CODIGO = txt_codigo.Text
        familiaBE.FA_DESCRIPCION = txt_des.Text
        familiaBE.FA_IDEMPRESA = gInt_IdEmpresa

        If Bol_Nuevo Then
            familiaBL.Insert(familiaBE)
        Else
            familiaBL.Update(familiaBE)
        End If


        familiaBE = Nothing
        familiaBL = Nothing


        Avisar("Listo")

        Call CargarDatos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_TipoAne, 0)
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        Call Limpiar_Controls_InGroupox(ugb_datos)

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("FA_CODIGO").Value
        txt_des.Text = ug_Lista.ActiveRow.Cells("FA_DESCRIPCION").Value

        Bol_Nuevo = False
        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)

        txt_des.Focus()


    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If Preguntar("seguro de eliminar?") Then
            Dim familiaBE As New BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI
            Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI

            familiaBE.FA_CODIGO = ug_Lista.ActiveRow.Cells("FA_CODIGO").Value
            familiaBE.FA_IDEMPRESA = gInt_IdEmpresa

            familiaBL.Delete(familiaBE)

            familiaBL = Nothing
            familiaBE = Nothing

            Call CargarDatos()

            Avisar("Listo")
        End If



    End Sub


    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub ug_Lista_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        Call Tool_Editar_Click(sender, e)
    End Sub
End Class