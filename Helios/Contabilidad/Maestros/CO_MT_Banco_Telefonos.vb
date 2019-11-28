Public Class CO_MT_Banco_Telefonos

    Public Int_IdBanco As Integer
    Dim Bol_Nuevo As Boolean


    Private Sub CO_MT_Banco_Telefonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
        Call Cargar_TipoComunicacion()
        Call Inicializar_Estado_Botones_Tool(ToolS_Bancos)
        Call MostrarTabs(0, utc_Telefonos, 0)
        Call Formatear_Grilla_Selector(ug_Telefonos)
    End Sub

    Private Sub Cargar_Datos()
        Try
            Dim TelefonosBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_TELEF
            Dim TelefonosBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF
            Dim Telefonos As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF)

            TelefonosBancoBE.BT_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}
            Telefonos = TelefonosBancoBL.getTelefonos(TelefonosBancoBE)

            Call LimpiaGrid(ug_Telefonos, uds_Telefonos)

            Dim i As Integer = 0
            For Each telefono As BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF In Telefonos
                ug_Telefonos.DisplayLayout.Bands(0).AddNew()
                ug_Telefonos.Rows(i).Cells("BT_IDBANCO").Value = telefono.BT_IDBANCO.BA_ID
                ug_Telefonos.Rows(i).Cells("BT_IDTEL").Value = telefono.BT_IDTEL
                ug_Telefonos.Rows(i).Cells("BT_IDCOMUNICACION").Value = telefono.BT_IDCOMUNICACION.TC_ID
                ug_Telefonos.Rows(i).Cells("TC_DESCRIPCION").Value = telefono.BT_IDCOMUNICACION.TC_DESCRIPCION
                ug_Telefonos.Rows(i).Cells("BT_NUMERO").Value = telefono.BT_NUMERO
                ug_Telefonos.Rows(i).Cells("BT_DESCRIPCION").Value = telefono.BT_DESCRIPCION
                ug_Telefonos.Rows(i).Cells("BT_ISTATUS").Value = telefono.BT_ISTATUS
                i += 1
            Next

            ug_Telefonos.UpdateData()

            TelefonosBancoBL = Nothing
            TelefonosBancoBE = Nothing
            Telefonos = Nothing


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_TipoComunicacion()
        Try
            Dim TipoComuBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_COMUNICACION

            uce_TipoComu.DataSource = TipoComuBL.getTipos
            uce_TipoComu.DisplayMember = "TC_DESCRIPCION"
            uce_TipoComu.ValueMember = "TC_ID"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_Telefonos, 1)
            Call Limpiar_Controls_InGroupox(ugb_datos)
            ume_numero.Value = Nothing

            Bol_Nuevo = True
            uce_TipoComu.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If ug_Telefonos.Rows.Count = 0 Then Exit Sub
            If ug_Telefonos.ActiveRow Is Nothing Then Exit Sub
            If Preguntar("Esta seguro de eliminar?") Then
                Dim TelefonosBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_TELEF
                Dim TelefonosBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF
                TelefonosBancoBE.BT_IDTEL = ug_Telefonos.ActiveRow.Cells("BT_IDTEL").Value
                TelefonosBancoBL.Delete(TelefonosBancoBE)
                Call Cargar_Datos()
                TelefonosBancoBL = Nothing
                TelefonosBancoBE = Nothing
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            'Validar los datos de entrada
            If Not Validar() Then Exit Sub

            Dim TelefonosBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_TELEF
            Dim TelefonosBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF
            Dim id As Integer = 0

            If Not Bol_Nuevo Then id = ug_Telefonos.ActiveRow.Cells("BT_IDTEL").Value

            With TelefonosBancoBE
                .BT_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}
                .BT_IDTEL = id
                .BT_IDCOMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION With {.TC_ID = uce_TipoComu.Value}
                .BT_NUMERO = ume_numero.Value
                .BT_DESCRIPCION = txt_descripcion.Text.Trim
                .BT_ISTATUS = uos_estado.Value
                .BT_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .BT_TERMINAL = Environment.MachineName
                .BT_FECREG = Now.Date
            End With


            If Bol_Nuevo Then
                TelefonosBancoBL.Insert(TelefonosBancoBE)
            Else
                TelefonosBancoBL.Update(TelefonosBancoBE)
            End If

            Call Avisar("Listo!")
            Call Cargar_Datos()
            Call Tool_Cancelar_Click(sender, e)

            TelefonosBancoBL = Nothing
            TelefonosBancoBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Function Validar() As Boolean
        Validar = False
        Try
            If uce_TipoComu.SelectedIndex = -1 Then
                Avisar("Seleccione un tipo de Comunicacion")
                uce_TipoComu.Focus()
                Exit Function
            End If

            If ume_numero.Value Is Nothing Or ume_numero.Value Is DBNull.Value Then
                Avisar("Ingrese el numero de comunicacion")
                ume_numero.Focus()
                Exit Function
            End If

            Return True
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Function

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(0, utc_Telefonos, 0)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try

            If ug_Telefonos.Rows.Count = 0 Then
                Exit Sub
            End If

            Call Limpiar_Controls_InGroupox(ugb_datos)

            Dim TelefonosBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_TELEF
            Dim TelefonosBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_TELEF

            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_Telefonos, 1)

            TelefonosBancoBE.BT_IDTEL = ug_Telefonos.ActiveRow.Cells("BT_IDTEL").Value
            TelefonosBancoBL.getTelefonos_x_Id(TelefonosBancoBE)

            With TelefonosBancoBE
                uce_TipoComu.Value = .BT_IDCOMUNICACION.TC_ID
                ume_numero.Value = .BT_NUMERO
                txt_descripcion.Text = .BT_DESCRIPCION
                uos_estado.Value = .BT_ISTATUS
            End With


            uce_TipoComu.Focus()
            '__________________________________________ Limpiamos Memoria

            TelefonosBancoBL = Nothing
            TelefonosBancoBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_TipoComu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoComu.KeyDown, ume_numero.KeyDown, txt_descripcion.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uos_estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uos_estado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Preguntar("Desea guardar los datos?") Then
                Tool_Grabar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub ug_Telefonos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Telefonos.DoubleClickRow
        Try
            Tool_Editar_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class