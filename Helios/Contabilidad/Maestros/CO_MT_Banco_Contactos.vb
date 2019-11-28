Public Class CO_MT_Banco_Contactos
    Public Int_IdBanco As Integer
    Dim Bol_Nuevo As Boolean


    Private Sub CO_MT_Banco_Contactos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
        Call Cargar_TipoComunicacion()
        Call Inicializar_Estado_Botones_Tool(ToolS_Bancos)
        Call MostrarTabs(0, utc_Contactos, 0)
        Call Formatear_Grilla_Selector(ug_Contactos)
        Call Formatear_Grilla_Selector(ug_Telefono)

    End Sub

    Public Sub Cargar_Datos()
        Try

            Dim BanContactosBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CONTACTO
            Dim BanContactosBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO
            Dim contactos As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO)

            BanContactosBE.BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}
            contactos = BanContactosBL.getContactos(BanContactosBE)
            Call LimpiaGrid(ug_Contactos, uds_Contactos)
            Dim i As Integer = 0
            For Each contacto As BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO In contactos
                ug_Contactos.DisplayLayout.Bands(0).AddNew()
                ug_Contactos.Rows(i).Cells("BC_IDBANCO").Value = contacto.BC_IDBANCO.BA_ID
                ug_Contactos.Rows(i).Cells("BC_IDCONTACTO").Value = contacto.BC_IDCONTACTO
                ug_Contactos.Rows(i).Cells("BC_NOMBRES").Value = contacto.BC_NOMBRES
                ug_Contactos.Rows(i).Cells("BC_APELLIDOS").Value = contacto.BC_APELLIDOS
                ug_Contactos.Rows(i).Cells("BC_CARGO").Value = contacto.BC_CARGO
                i += 0
            Next

            ug_Contactos.UpdateData()

            BanContactosBL = Nothing
            BanContactosBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_Contactos, 1)
            Call Limpiar_Controls_InGroupox(ugb_datos)

            ugb_Medios.Enabled = False
            Bol_Nuevo = True
            txt_nombres.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If ug_Contactos.Rows.Count = 0 Then Exit Sub
            If ug_Contactos.ActiveRow Is Nothing Then Exit Sub
            If Preguntar("Esta seguro de eliminar?") Then
                Dim ContactoBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CONTACTO
                Dim ContactoBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO
                ContactoBancoBE.BC_IDCONTACTO = ug_Contactos.ActiveRow.Cells("BC_IDCONTACTO").Value
                ContactoBancoBL.Delete(ContactoBancoBE)
                Call Cargar_Datos()
                ContactoBancoBL = Nothing
                ContactoBancoBE = Nothing
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(0, utc_Contactos, 0)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try

            If ug_Contactos.Rows.Count = 0 Then Exit Sub

            Call Limpiar_Controls_InGroupox(ugb_datos)

            Dim ContactoBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CONTACTO
            Dim ContactoBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO

            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_Contactos, 1)

            ContactoBancoBE.BC_IDCONTACTO = ug_Contactos.ActiveRow.Cells("BC_IDCONTACTO").Value
            ContactoBancoBL.getContactos_x_Id(ContactoBancoBE)

            With ContactoBancoBE
                txt_nombres.Text = .BC_NOMBRES
                txt_apellidos.Text = .BC_APELLIDOS
                txt_cargo.Text = .BC_CARGO
                txt_email.Text = .BC_EMAIL
            End With

            Call Cargar_Telefonos()
            ugb_Medios.Enabled = True
            txt_nombres.Focus()

            '__________________________________________ Limpiamos Memoria

            ContactoBancoBL = Nothing
            ContactoBancoBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_nombres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombres.KeyDown, txt_cargo.KeyDown, txt_apellidos.KeyDown, txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            Dim ContactoBancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CONTACTO
            Dim ContactoBancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO

            Dim IdContacto As Integer = 0
            If Not Bol_Nuevo Then IdContacto = ug_Contactos.ActiveRow.Cells("BC_IDCONTACTO").Value


            With ContactoBancoBE
                .BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}
                .BC_IDCONTACTO = IdContacto
                .BC_NOMBRES = txt_nombres.Text.Trim
                .BC_APELLIDOS = txt_apellidos.Text.Trim
                .BC_CARGO = txt_cargo.Text.Trim
                .BC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .BC_TERMINAL = Environment.MachineName
                .BC_FECREG = Date.Now
                .BC_EMAIL = txt_email.Text.Trim
            End With


            If Bol_Nuevo Then ContactoBancoBL.Insert(ContactoBancoBE) Else ContactoBancoBL.Update(ContactoBancoBE)

            ContactoBancoBL = Nothing
            ContactoBancoBE = Nothing

            Call Avisar("Listo!")
            Call Cargar_Datos()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click
        Try


            If uce_TipoComu.SelectedIndex = -1 Then
                Avisar("Seleccione un tipo de comunicacion")
                uce_TipoComu.Focus()
                Exit Sub
            End If

            If txt_numero.Text.Length = 0 Then
                Avisar("Ingrese el dato.")
                txt_numero.Focus()
                Exit Sub
            End If





            Dim ContactoTelBL As New BL.ContabilidadBL.SG_CO_TB_CONTACTO_TELEF
            Dim ContactoTelBE As New BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF
            Dim IdContacto As Integer = ug_Contactos.ActiveRow.Cells("BC_IDCONTACTO").Value

            With ContactoTelBE
                .CT_IDCONTACTO = New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO With {.BC_IDCONTACTO = IdContacto}
                .CT_IDCOMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION With {.TC_ID = uce_TipoComu.Value}
                .CT_NUMERO = txt_numero.Text.Trim
                .CT_ISTATUS = 1
                .CT_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .CT_TERMINAL = Environment.MachineName
                .CT_FECREG = Date.Now
                .CT_DESCRIPCION = txt_descripcion.Text.Trim.Trim
            End With

            ContactoTelBL.Insert(ContactoTelBE)

            ContactoTelBL = Nothing
            ContactoTelBE = Nothing

            Call Cargar_Telefonos()

            txt_numero.Clear()
            txt_descripcion.Clear()
            uce_TipoComu.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_quitar.Click
        Try
            Dim ContactoTelBL As New BL.ContabilidadBL.SG_CO_TB_CONTACTO_TELEF
            Dim ContactoTelBE As New BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF

            ContactoTelBE.CT_IDREG = ug_Telefono.ActiveRow.Cells("CT_IDREG").Value
            ContactoTelBL.Delete(ContactoTelBE)

            ContactoTelBL = Nothing
            ContactoTelBE = Nothing

            Call Cargar_Telefonos()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Telefonos()
        Try
            Dim ContactoTelBL As New BL.ContabilidadBL.SG_CO_TB_CONTACTO_TELEF
            Dim ContactoTelBE As New BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF
            Dim IdContacto As Integer = ug_Contactos.ActiveRow.Cells("BC_IDCONTACTO").Value
            Dim telefonos As New List(Of BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF)
            ContactoTelBE.CT_IDCONTACTO = New BE.ContabilidadBE.SG_CO_TB_BANCO_CONTACTO With {.BC_IDCONTACTO = IdContacto}
            telefonos = ContactoTelBL.getTelefonos(ContactoTelBE)

            Call LimpiaGrid(ug_Telefono, uds_Telefonos)

            Dim i As Integer = 0
            For Each ContTelefono As BE.ContabilidadBE.SG_CO_TB_CONTACTO_TELEF In telefonos
                ug_Telefono.DisplayLayout.Bands(0).AddNew()
                ug_Telefono.Rows(i).Cells("CT_IDREG").Value = ContTelefono.CT_IDREG
                ug_Telefono.Rows(i).Cells("CT_IDCONTACTO").Value = ContTelefono.CT_IDCONTACTO.BC_IDCONTACTO
                ug_Telefono.Rows(i).Cells("CT_IDCOMUNICACION").Value = ContTelefono.CT_IDCOMUNICACION.TC_ID
                ug_Telefono.Rows(i).Cells("TC_DESCRIPCION").Value = ContTelefono.CT_IDCOMUNICACION.TC_DESCRIPCION
                ug_Telefono.Rows(i).Cells("CT_NUMERO").Value = ContTelefono.CT_NUMERO
                ug_Telefono.Rows(i).Cells("CT_DESCRIPCION").Value = ContTelefono.CT_DESCRIPCION
                ug_Telefono.Rows(i).Cells("CT_ISTATUS").Value = ContTelefono.CT_ISTATUS
                i += 1
            Next

            ug_Telefono.UpdateData()

            ContactoTelBL = Nothing
            ContactoTelBE = Nothing

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

            TipoComuBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_TipoComu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoComu.KeyDown, txt_numero.KeyDown, txt_descripcion.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ug_Contactos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Contactos.DoubleClickRow
        Try
            If ug_Contactos.Rows.Count = 0 Then
                Exit Sub
            End If
            Tool_Editar_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class