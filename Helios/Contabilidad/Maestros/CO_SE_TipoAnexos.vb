Public Class CO_SE_TipoAnexos

    Dim Bol_Nuevo As Boolean


    Private Sub CO_SE_TipoAnexos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Formatear_Grilla_Selector(ug_TipoAne)
        Call Inicializar_Estado_Botones()
    End Sub

    Private Sub CargarDatos()
        Try
            Dim tipoAneBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
            Dim Lista As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOANEXO)
            Lista = tipoAneBL.getTipoAnexos()

            Call LimpiaGrid(ug_TipoAne, uds_TipoAne)

            Dim i As Integer = 0
            For Each tipo As BE.ContabilidadBE.SG_CO_TB_TIPOANEXO In Lista
                ug_TipoAne.DisplayLayout.Bands(0).AddNew()
                ug_TipoAne.Rows(i).Cells("TA_CODIGO").Value = CInt(tipo.TA_CODIGO)
                ug_TipoAne.Rows(i).Cells("TA_DESCRIPCION").Value = tipo.TA_DESCRIPCION
                ug_TipoAne.Rows(i).Cells("TA_IMG").Value = Bytes2Image(tipo.TA_IMG)
                ug_TipoAne.UpdateData()

                i += 1
            Next


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones()
            Call MostrarTabs(1, utc_TipoAne, 1)
            Call Limpiar_Controls_InGroupox(ugb_datos)

            Bol_Nuevo = True
            upb_img.Image = Nothing
            upb_img.Image = My.Resources.Desconocido
            une_codigo.Enabled = True
            une_codigo.Value = 0
            une_codigo.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Inicializar_Estado_Botones()
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Editar.Enabled = True
        Tool_Salir.Enabled = True
        Tool_Eliminar.Enabled = True
    End Sub

    Private Sub Cambiar_Estado_Botones()
        Tool_Nuevo.Enabled = Not (Tool_Nuevo.Enabled)
        Tool_Grabar.Enabled = Not Tool_Grabar.Enabled
        Tool_Cancelar.Enabled = Not Tool_Cancelar.Enabled
        Tool_Editar.Enabled = Not Tool_Editar.Enabled
        Tool_Salir.Enabled = Not Tool_Salir.Enabled
        Tool_Eliminar.Enabled = Not Tool_Eliminar.Enabled
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Cambiar_Estado_Botones()
            MostrarTabs(0, utc_TipoAne, 0)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            Dim obj_TiposBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
            Dim E_tipos As New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO


            E_tipos.TA_CODIGO = une_codigo.Value
            E_tipos.TA_DESCRIPCION = txt_des.Text.Trim
            E_tipos.TA_IMG = Image2Bytes(upb_img.Image)

            If Bol_Nuevo Then
                obj_TiposBL.Insert(E_tipos)
            Else
                obj_TiposBL.Update(E_tipos)
            End If

            obj_TiposBL = Nothing

            Avisar("    Listo!  ")

            Call CargarDatos()
            Tool_Cancelar_Click(sender, e)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
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
            upb_img.Image = My.Resources.Desconocido

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            If ug_TipoAne.ActiveRow.Index = -1 Then Exit Sub

            Call Limpiar_Controls_InGroupox(ugb_datos)

            Using obj_TiposBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
                Dim E_tipos As New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO
                E_tipos.TA_CODIGO = ug_TipoAne.ActiveRow.Cells("TA_CODIGO").Value
                obj_TiposBL.getTipoAnexo(E_tipos)
                une_codigo.Value = E_tipos.TA_CODIGO
                txt_des.Text = E_tipos.TA_DESCRIPCION

                Try
                    upb_img.Image = Bytes2Image(E_tipos.TA_IMG)
                Catch ex As Exception
                End Try

                Call MostrarTabs(1, utc_TipoAne, 1)
                Call Cambiar_Estado_Botones()

                une_codigo.Enabled = False
                txt_des.Focus()
                Bol_Nuevo = False


            End Using

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_TipoAne_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_TipoAne.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            Dim i As Integer = ug_TipoAne.ActiveRow.Cells("TA_CODIGO").Value
            If i < 5 Then
                Avisar("Este tipo de Anexo no se puede eliminar por ser plantilla del sistema.")
                Exit Sub
            End If

            If Preguntar("Esta seguro de eliminar el registro?") Then
                Using obj_tiposAne As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
                    obj_tiposAne.Delete(New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = i})
                End Using

                Avisar("    Listo!      ")
                Call CargarDatos()
            End If

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub une_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.Escape Then
            Tool_Cancelar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_des_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Preguntar("Desea Grabar los Datos?") Then
                Tool_Grabar_Click(sender, e)
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Tool_Cancelar_Click(sender, e)
        End If

    End Sub
End Class