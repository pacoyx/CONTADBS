Public Class CO_MT_Perfiles
    Dim Bol_Nuevo As Boolean = False
    Dim PerfilBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_USUARIO
    Dim PerfilBE As New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO

    Private Sub CO_MT_Perfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Perfiles()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Formatear_Grilla_Selector(ug_perfiles)
        Call MostrarTabs(0, utc_perfiles, 0)
    End Sub

    Private Sub Cargar_Perfiles()
        Try

            ug_perfiles.DataSource = PerfilBL.getTipos()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Limpiar_Controls_InGroupox(ugb_datos)
            Call MostrarTabs(1, utc_perfiles, 1)

            Bol_Nuevo = True

            txt_cod.Enabled = True
            txt_cod.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            If Bol_Nuevo Then
                PerfilBL.Insert(New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO(txt_cod.Text.Trim, txt_des.Text))
            Else
                PerfilBL.Update(New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO(txt_cod.Text.Trim, txt_des.Text))
            End If

            Call Avisar("Listo!")
            Call Cargar_Perfiles()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(0, utc_perfiles, 0)
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro que desea eliminar el perfil") Then
                PerfilBL.Delete(New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO With {.TU_CODIGO = ug_perfiles.ActiveRow.Cells("TU_CODIGO").Value})
                Avisar("    Listo!      ")
                Call Cargar_Perfiles()
            End If
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            If ug_perfiles.ActiveRow.Index = -1 Then Exit Sub

            txt_cod.Text = ug_perfiles.ActiveRow.Cells("TU_CODIGO").Value
            txt_des.Text = ug_perfiles.ActiveRow.Cells("TU_DESCRIPCION").Value

            Call MostrarTabs(1, utc_perfiles, 2)
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            txt_cod.Enabled = False
            txt_des.Focus()
            Bol_Nuevo = False

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub
End Class