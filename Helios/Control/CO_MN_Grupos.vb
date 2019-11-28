

Public Class CO_MN_Grupos

    Dim obj_GrupoBL As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MN_Grupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Modulos()
        Call CargarGrupos()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Formatear_Grilla_Selector(ug_Grupos)
        Call MostrarTabs(0, utc_Grupos, 0)

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Limpiar_Controls_InGroupox(ugb_datos)
            Call MostrarTabs(1, utc_Grupos, 1)

            Bol_Nuevo = True

            une_Id.Enabled = True
            une_Id.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            If Bol_Nuevo Then
                obj_GrupoBL.Insert(New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU(une_Id.Value, txt_Des.Text, New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = uce_Modulo.Value}))
            Else
                obj_GrupoBL.Update(New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU(une_Id.Value, txt_Des.Text, New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = uce_Modulo.Value}))
            End If

            Call Avisar("Listo!")
            Call CargarGrupos()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            If ug_Grupos.ActiveRow.Index = -1 Then Exit Sub
            Dim E_modulo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU
            E_modulo = obj_GrupoBL.getGrupo(ug_Grupos.ActiveRow.Cells("GM_ID").Value)

            une_Id.Value = E_modulo.GM_ID
            txt_Des.Text = E_modulo.GM_NOMBRE
            uce_Modulo.Value = E_modulo.GM_IDMODULO.MO_ID

            E_modulo = Nothing

            Call MostrarTabs(1, utc_Grupos, 2)
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            une_Id.Enabled = False
            txt_Des.Focus()
            Bol_Nuevo = False

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(0, utc_Grupos, 0)
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro que desea eliminar el Grupo") Then
                obj_GrupoBL.Delete(New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = ug_Grupos.ActiveRow.Cells("GM_ID").Value})
                Avisar("    Listo!      ")
                Call CargarGrupos()
            End If
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub CargarGrupos()
        Try
            Dim Obj_ModBL As New BL.ContabilidadBL.SG_CO_TB_MODULO
            Dim grupos As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            grupos = obj_GrupoBL.getGrupos()

            Call LimpiaGrid(ug_Grupos, uds_Grupos)

            Dim i As Integer = 0
            For Each grupo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU In grupos
                ug_Grupos.DisplayLayout.Bands(0).AddNew()

                ug_Grupos.Rows(i).Cells("GM_NOMMOD").Value = Obj_ModBL.getModulo(grupo.GM_IDMODULO.MO_ID).MO_DESCRIPCION
                ug_Grupos.Rows(i).Cells("GM_ID").Value = grupo.GM_ID
                ug_Grupos.Rows(i).Cells("GM_NOMBRE").Value = grupo.GM_NOMBRE

                ug_Grupos.UpdateData()
                i += 1
            Next

            Obj_ModBL = Nothing
            grupos = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_Modulos()
        Try
            Dim Obj_ModBl As New BL.ContabilidadBL.SG_CO_TB_MODULO
            uce_Modulo.DataSource = Obj_ModBl.getModulos
            uce_Modulo.DisplayMember = "MO_DESCRIPCION"
            uce_Modulo.ValueMember = "MO_ID"

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_Grupos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs)
        If e.Row.Index = -1 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ug_Grupos_DoubleClickRow_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Grupos.DoubleClickRow
        Try
            If ug_Grupos.ActiveRow.Index = -1 Then Exit Sub

            Call Tool_Editar_Click(sender, e)

        Catch ex As Exception

        End Try
    End Sub
End Class