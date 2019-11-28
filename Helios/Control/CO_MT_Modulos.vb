Public Class CO_MT_Modulos

    Dim Obj_ModBL As New BL.ContabilidadBL.SG_CO_TB_MODULO
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MT_Modulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarModulos()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Formatear_Grilla_Selector(ug_Modulos)
        Call MostrarTabs(0, utc_Modulos, 0)
    End Sub
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Limpiar_Controls_InGroupox(ugb_datos)
            Call MostrarTabs(1, utc_Modulos, 1)

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
                Obj_ModBL.Insert(New BE.ContabilidadBE.SG_CO_TB_MODULO(une_Id.Value, txt_Des.Text))
            Else
                Obj_ModBL.Update(New BE.ContabilidadBE.SG_CO_TB_MODULO(une_Id.Value, txt_Des.Text))
            End If

            Call Avisar("Listo!")
            Call CargarModulos()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            If ug_Modulos.ActiveRow.Index = -1 Then Exit Sub
            Dim E_modulo As BE.ContabilidadBE.SG_CO_TB_MODULO
            E_modulo = Obj_ModBL.getModulo(ug_Modulos.ActiveRow.Cells("MO_ID").Value)

            une_Id.Value = E_modulo.MO_ID
            txt_Des.Text = E_modulo.MO_DESCRIPCION

            E_modulo = Nothing

            Call MostrarTabs(1, utc_Modulos, 2)
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
            Call MostrarTabs(0, utc_Modulos, 0)
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro que desea eliminar el modulo") Then

                Obj_ModBL.Delete(New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = ug_Modulos.ActiveRow.Cells("MO_ID").Value})

                Avisar("    Listo!      ")
                Call CargarModulos()

            End If

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub CargarModulos()
        Try
            Dim Modulos As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO)
            Modulos = Obj_ModBL.getModulos()

            Call LimpiaGrid(ug_Modulos, uds_Modulos)

            Dim i As Integer = 0
            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO In Modulos
                ug_Modulos.DisplayLayout.Bands(0).AddNew()
                ug_Modulos.Rows(i).Cells("MO_ID").Value = modulo.MO_ID
                ug_Modulos.Rows(i).Cells("MO_DESCRIPCION").Value = modulo.MO_DESCRIPCION

                ug_Modulos.UpdateData()
                i += 1
            Next



        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub une_Id_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Id.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Des_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Des.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tool_Grabar_Click(sender, e)
        End If
    End Sub

    Private Sub ug_Modulos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Modulos.DoubleClickRow
        If e.Row.Index = -1 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub
End Class