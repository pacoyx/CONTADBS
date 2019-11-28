Public Class CO_MT_OpcMenu

    Dim Obj_OpcMnu As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MT_OpcMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Item_Menu()
        Call Cargar_Combos()
        Call MostrarTabs(0, utc_ItemMenu, 0)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Formatear_Grilla_Selector(ug_ItemMenu)

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try

            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Limpiar_Controls_InGroupox(ugb_datos)
            Call MostrarTabs(1, utc_ItemMenu, 1)

            Bol_Nuevo = True

            une_Id.Enabled = False
            txt_Des.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            If txt_Des.Text.Trim.Length = 0 Then
                Avisar("Ingrese una descripcion para la opcion de menu")
                txt_Des.Focus()
                Exit Sub
            End If

            If uce_Grupo.SelectedIndex = -1 Then
                Avisar("Seleccione un grupo para la opcion")
                uce_Grupo.Focus()
                Exit Sub
            End If

            If uce_Tamano.SelectedIndex = -1 Then
                Avisar("Seleccione un tamaño para el grupo")
                uce_Tamano.Focus()
                Exit Sub
            End If

            If uce_TipoBoton.SelectedIndex = -1 Then
                Avisar("Seleccion un tipo de boton para la opcion")
                uce_TipoBoton.Focus()
                Exit Sub
            End If


            Dim E_Item As New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU
            With E_Item
                .OM_ID = une_Id.Value
                .OM_DESCRIPCION = txt_Des.Text.Trim
                .OM_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = uce_Grupo.Value}
                .OM_IMG = Image2Bytes(upb_img.Image)
                .OM_TAMANO_IMG = New BE.ContabilidadBE.SG_CO_TB_TAMANO_ICON With {.TI_ID = uce_Tamano.Value}
                .OM_TIPO = New BE.ContabilidadBE.SG_CO_TB_TIPO_BOTON_MENU With {.TB_ID = uce_TipoBoton.Value}
                If uce_Padre.SelectedIndex = -1 Then
                    .OM_IDPADRE = Nothing
                Else
                    .OM_IDPADRE = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = uce_Padre.Value}
                End If
                .OM_NOM_FORM = txt_NomFormulario.Text.Trim
            End With

            If Bol_Nuevo Then
                Obj_OpcMnu.Insert(E_Item)
            Else
                Obj_OpcMnu.Update(E_Item)
            End If

            Call Avisar("Listo!")
            Call Cargar_Item_Menu()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            If ug_ItemMenu.ActiveRow.Index = -1 Then Exit Sub
            Dim E_ItemOpcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU

            E_ItemOpcion = Obj_OpcMnu.getOpcionesMenu_x_Id(ug_ItemMenu.ActiveRow.Cells("OM_ID").Value)

            une_Id.Value = E_ItemOpcion.OM_ID
            txt_Des.Text = E_ItemOpcion.OM_DESCRIPCION
            uce_TipoBoton.Value = E_ItemOpcion.OM_TIPO.TB_ID
            uce_Tamano.Value = E_ItemOpcion.OM_TAMANO_IMG.TI_ID
            uce_Modulo.Value = E_ItemOpcion.OM_IDGRUPO.GM_IDMODULO.MO_ID
            uce_Grupo.Value = E_ItemOpcion.OM_IDGRUPO.GM_ID
            upb_img.Image = Bytes2Image(E_ItemOpcion.OM_IMG)
            txt_NomFormulario.Text = E_ItemOpcion.OM_NOM_FORM

            If E_ItemOpcion.OM_IDPADRE Is Nothing Then
                uce_Padre.SelectedIndex = -1
            Else
                uce_Padre.Value = E_ItemOpcion.OM_IDPADRE.OM_ID
            End If

            E_ItemOpcion = Nothing

            Call MostrarTabs(1, utc_ItemMenu, 2)
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
            Call MostrarTabs(0, utc_ItemMenu, 0)
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro que desea eliminar el Item de Menu") Then
                Obj_OpcMnu.Delete(New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = ug_ItemMenu.ActiveRow.Cells("OM_ID").Value})
                Avisar("    Listo!      ")
                Call Cargar_Item_Menu()
            End If
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click
        Try
            ' Seleccionar la imagen
            Dim oFD As New OpenFileDialog
            oFD.Title = "Selecccionar la imagen"
            oFD.Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If oFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' La cantidad de caracteres máximo
                ' (por si el path es demasiado largo)
                Dim i As Integer = 255 'dt.Columns("Nombre").MaxLength
                If i < 0 Then i = 255
                ' El nombre del fichero
                ' Nos quedamos solo con el nombre, sin el path
                Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
                If sNombre.Length > i Then
                    ' Si el nombre es más grande de lo permitido, lo cortamos
                    sNombre = sNombre.Substring(0, i)
                End If

                'Me.txt_foto.Text = sNombre
                Me.upb_img.Image = Image.FromFile(oFD.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Quitar.Click
        Try
            upb_img.Image = Nothing
            upb_img.Image = My.Resources._16__Envelope_

        Catch ex As Exception

        End Try
    End Sub

    Private Sub une_Id_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Id.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Des_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Des.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_Modulo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoBoton.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If



    End Sub

    Private Sub UltraComboEditor2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Tamano.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub UltraComboEditor1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Grupo.KeyDown, uce_Modulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub


    Private Sub Cargar_Item_Menu()
        Try
            Dim Items As List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)

            Items = Obj_OpcMnu.getOpcionesMenu()

            Call LimpiaGrid(ug_ItemMenu, uds_ItemMenu)
            uce_Padre.Items.Clear()

            Dim i As Integer = 0
            For Each item As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In Items
                ug_ItemMenu.DisplayLayout.Bands(0).AddNew()

                Dim Obj_GrupoMnu As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU

                ug_ItemMenu.Rows(i).Cells("OM_NOMGRUPO").Value = Obj_GrupoMnu.getGrupo(item.OM_IDGRUPO.GM_ID).GM_NOMBRE
                ug_ItemMenu.Rows(i).Cells("MODULO").Value = Obj_GrupoMnu.getGrupo(item.OM_IDGRUPO.GM_ID).GM_IDMODULO.MO_DESCRIPCION
                ug_ItemMenu.Rows(i).Cells("OM_ID").Value = item.OM_ID
                ug_ItemMenu.Rows(i).Cells("OM_DESCRIPCION").Value = item.OM_DESCRIPCION

                Obj_GrupoMnu = Nothing
                ug_ItemMenu.UpdateData()
                i += 1

                If item.OM_TIPO.TB_ID = 2 Then
                    uce_Padre.Items.Add(item.OM_ID, item.OM_DESCRIPCION)
                End If

            Next

            ug_ItemMenu.Rows(0).Activate()

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Combos()
        Try
            Dim Obj_TamanosIcon As New BL.ContabilidadBL.SG_CO_TB_TAMANO_ICON
            uce_Tamano.DataSource = Obj_TamanosIcon.getTamanos
            uce_Tamano.DisplayMember = "TI_DESCRIPCION"
            uce_Tamano.ValueMember = "TI_ID"

            Dim Obj_TiposBotonIcon As New BL.ContabilidadBL.SG_CO_TB_TIPO_BOTON_MENU
            uce_TipoBoton.DataSource = Obj_TiposBotonIcon.getTiposBotonIcon
            uce_TipoBoton.DisplayMember = "TB_DESCRIPCION"
            uce_TipoBoton.ValueMember = "TB_ID"


            Dim Obj_Modulo As New BL.ContabilidadBL.SG_CO_TB_MODULO
            uce_Modulo.DataSource = Obj_Modulo.getModulos
            uce_Modulo.DisplayMember = "MO_DESCRIPCION"
            uce_Modulo.ValueMember = "MO_ID"

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_Modulo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Modulo.ValueChanged
        Try
            Dim Obj_gruposMenu As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU
            uce_Grupo.DataSource = Obj_gruposMenu.getGrupos_x_Modulo(uce_Modulo.Value)
            uce_Grupo.DisplayMember = "GM_NOMBRE"
            uce_Grupo.ValueMember = "GM_ID"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ug_ItemMenu_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_ItemMenu.InitializeLayout

    End Sub

    Private Sub ug_ItemMenu_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ItemMenu.DoubleClickRow
        Try
            If ug_ItemMenu.ActiveRow.Index = -1 Then
                Exit Sub
            End If

            Call Tool_Editar_Click(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Tamano_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Tamano.ValueChanged
        If uce_Tamano.Value = 2 Then
            lbl_TextoLarge.Visible = True
        Else
            lbl_TextoLarge.Visible = False
        End If
    End Sub

    Private Sub uce_Padre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Padre.KeyDown
        If e.KeyCode = Keys.Delete Then
            uce_Padre.SelectedIndex = -1
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class