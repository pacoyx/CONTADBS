Public Class FA_MA_Categoria_Arti

    Dim Bol_Nuevo As Boolean

    Private Sub FA_MA_Categoria_Arti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Cargar_Combos()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub CargarDatos()
        Dim categoriasBL As New BL.FacturacionBL.SG_FA_TB_CATEGORIA_ARTI
        ug_Lista.DataSource = categoriasBL.get_Categorias(gInt_IdEmpresa)
        categoriasBL = Nothing
    End Sub

    Private Sub Cargar_Combos()
        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI
        Dim dt_tmp As DataTable = familiaBL.get_Familias(gInt_IdEmpresa)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            uce_Familia.Items.Add(dt_tmp.Rows(i)("FA_CODIGO"), dt_tmp.Rows(i)("FA_CODIGO") & " - " & dt_tmp.Rows(i)("FA_DESCRIPCION"))
        Next

        dt_tmp.Dispose()
        familiaBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True

        txt_codigo.Enabled = True
        txt_codigo.Value = 0
        uce_Familia.SelectedIndex = 0
        txt_codigo.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim categoriaBE As New BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI
        Dim categoriaBL As New BL.FacturacionBL.SG_FA_TB_CATEGORIA_ARTI

        categoriaBE.CA_CODIGO = txt_codigo.Text
        categoriaBE.CA_DESCRIPCION = txt_des.Text
        categoriaBE.CA_IDFAMILIA = uce_Familia.Value
        categoriaBE.CA_IDEMPRESA = gInt_IdEmpresa

        If Bol_Nuevo Then
            categoriaBL.Insert(categoriaBE)
        Else
            categoriaBL.Update(categoriaBE)
        End If


        categoriaBE = Nothing
        categoriaBL = Nothing


        Call Avisar("Listo")

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

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("CA_CODIGO").Value
        txt_des.Text = ug_Lista.ActiveRow.Cells("CA_DESCRIPCION").Value
        uce_Familia.Value = ug_Lista.ActiveRow.Cells("CA_IDFAMILIA").Value

        Bol_Nuevo = False
        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)

        txt_des.Focus()


    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If Preguntar("seguro de eliminar?") Then

            Dim categoriaBE As New BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI
            Dim categoriaBL As New BL.FacturacionBL.SG_FA_TB_CATEGORIA_ARTI

            categoriaBE.CA_CODIGO = ug_Lista.ActiveRow.Cells("cA_CODIGO").Value
            categoriaBE.CA_IDEMPRESA = gInt_IdEmpresa

            categoriaBL.Delete(categoriaBE)

            categoriaBL = Nothing
            categoriaBE = Nothing

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