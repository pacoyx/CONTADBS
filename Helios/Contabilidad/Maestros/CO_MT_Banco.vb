Imports BE.ContabilidadBE

Public Class CO_MT_Banco
    Dim Obj_BancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MT_Banco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call CargarCombos()
        Call Inicializar_Estado_Botones_Tool(ToolS_Bancos)
        Call MostrarTabs(0, utc_Bancos, 0)
        Call Formatear_Grilla_Selector(ug_Bancos)
    End Sub

    Private Sub CargarDatos()
        Try
            Dim Bancos As New List(Of SG_CO_TB_BANCO)
            Dim BancosBE As New SG_CO_TB_BANCO With {.BA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
            Bancos = Obj_BancoBL.getBancos(BancosBE)

            Call LimpiaGrid(ug_Bancos, uds_Bancos)

            Dim I As Integer = 0
            For Each banco As SG_CO_TB_BANCO In Bancos
                ug_Bancos.DisplayLayout.Bands(0).AddNew()
                ug_Bancos.Rows(I).Cells("BA_ID").Value = banco.BA_ID
                ug_Bancos.Rows(I).Cells("BA_CODIGO").Value = banco.BA_CODIGO
                ug_Bancos.Rows(I).Cells("BA_NOMBRE").Value = banco.BA_NOMBRE
                ug_Bancos.Rows(I).Cells("BA_RUC").Value = banco.BA_RUC
                I += 1
            Next
            ug_Bancos.UpdateData()

            Bancos = Nothing
            BancosBE = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarCombos()

        uce_Bancos.DataSource = Obj_BancoBL.getBancos(New SG_CO_TB_BANCO With {.BA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
        uce_Bancos.DisplayMember = "BA_NOMBRE"
        uce_Bancos.ValueMember = "BA_CODIGO"

        Dim Obj_PaisBL As New BL.ContabilidadBL.AyudaTest
        'Dim RunSQL_getTable1 = Obj_PaisBL.RunSQL_getTable(String.Format("select PA_CODIGO,PA_DESCRIPCION from SG_CO_TB_PAIS where PA_IDEMPRESA = {0}", gInt_IdEmpresa))
        Dim RunSQL_getTable1 = Obj_PaisBL.RunSQL_getTable(String.Format("SELECT NA_ID,NA_DESCRIPCION FROM SG_PL_TB_NACIONALIDAD"))
        uce_Pais.DataSource = RunSQL_getTable1
        uce_Pais.DisplayMember = "NA_DESCRIPCION"
        uce_Pais.ValueMember = "NA_ID"


    End Sub


    Private Sub txt_Codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyDown, ume_limiteCredito.KeyDown, uchk_esPrin.KeyDown, uce_Pais.KeyDown, uce_Bancos.KeyDown, txt_website.KeyDown, txt_ruc.KeyDown, txt_nombre.KeyDown, txt_dir.KeyDown, txt_codzip.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            MostrarTabs(1, utc_Bancos, 1)
            Bol_Nuevo = True

            upb_Cuentas.Enabled = Not Bol_Nuevo
            upb_Contactos.Enabled = Not Bol_Nuevo
            upb_Telefonos.Enabled = Not Bol_Nuevo


            Call Limpiar_Controls_InGroupox(ugb_data)
            uchk_esPrin.Checked = True
            txt_Codigo.Enabled = True
            txt_Codigo.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            Dim BancoBE As New SG_CO_TB_BANCO

            Dim id As Integer = 0
            If Bol_Nuevo Then
                id = 0
            Else
                id = ug_Bancos.ActiveRow.Cells("BA_ID").Value
            End If

            With BancoBE
                .BA_ID = id
                .BA_CODIGO = txt_Codigo.Text.Trim
                .BA_NOMBRE = txt_nombre.Text.Trim
                .BA_RUC = txt_ruc.Text.Trim
                .BA_DIRECCION = txt_dir.Text.Trim
                .BA_CODIGO_ZIP = txt_codzip.Text.Trim
                .BA_WEBSITE = txt_website.Text.Trim
                .BA_LIMITE_CREDITO = ume_limiteCredito.Value
                .BA_ES_PRINCIPAL = IIf(uchk_esPrin.Checked, 1, 0)
                .BA_IDBANCO_PRIN = IIf(uchk_esPrin.Checked, 0, uce_Bancos.Value)
                .BA_IDPAIS = New SG_CO_TB_PAIS With {.PA_CODIGO = uce_Pais.Value}
                .BA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .BA_ISTATUS = 1
                .BA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .BA_TERMINAL = Environment.MachineName
                .BA_FECREG = Date.Now
            End With

            If Bol_Nuevo Then Obj_BancoBL.Insert(BancoBE) Else Obj_BancoBL.Update(BancoBE)

            Call CargarDatos()
            Call Avisar("Listo!")
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(0, utc_Bancos, 0)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If ug_Bancos.Rows.Count = 0 Then Exit Sub
            If ug_Bancos.ActiveRow Is Nothing Then Exit Sub

            If Preguntar("Esta seguro de eliminar?") Then

                Obj_BancoBL.Delete(New SG_CO_TB_BANCO With {.BA_ID = ug_Bancos.ActiveRow.Cells("BA_ID").Value})
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            Dim BancoBE As New SG_CO_TB_BANCO With {.BA_ID = ug_Bancos.ActiveRow.Cells("BA_ID").Value}
            Obj_BancoBL.getBanco(BancoBE)

            With BancoBE
                txt_Codigo.Text = .BA_CODIGO
                txt_ruc.Text = .BA_RUC
                txt_nombre.Text = .BA_NOMBRE
                txt_dir.Text = .BA_DIRECCION
                txt_codzip.Text = .BA_CODIGO_ZIP
                txt_website.Text = .BA_WEBSITE
                ume_limiteCredito.Value = .BA_LIMITE_CREDITO
                uce_Pais.Value = .BA_IDPAIS.PA_CODIGO
                uce_Bancos.Value = .BA_IDBANCO_PRIN
                uchk_esPrin.Checked = IIf(.BA_ES_PRINCIPAL = 1, True, False)
            End With

            Bol_Nuevo = False

            upb_Cuentas.Enabled = Not Bol_Nuevo
            upb_Contactos.Enabled = Not Bol_Nuevo
            upb_Telefonos.Enabled = Not Bol_Nuevo

            txt_Codigo.Enabled = Bol_Nuevo
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_Bancos, 1)
            txt_nombre.Focus()


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_Bancos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Bancos.DoubleClickRow
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub upb_Cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upb_Cuentas.Click
        Try
            CO_MT_Banco_CtasCorrientes.Int_IdBanco = ug_Bancos.ActiveRow.Cells("BA_ID").Value
            CO_MT_Banco_CtasCorrientes.lbl_titulo.Text = txt_nombre.Text.Trim
            CO_MT_Banco_CtasCorrientes.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub upb_Contactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upb_Contactos.Click
        Try
            CO_MT_Banco_Contactos.Int_IdBanco = ug_Bancos.ActiveRow.Cells("BA_ID").Value
            CO_MT_Banco_Contactos.lbl_titulo.Text = txt_nombre.Text.Trim
            CO_MT_Banco_Contactos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub upb_Telefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upb_Telefonos.Click
        Try
            CO_MT_Banco_Telefonos.Int_IdBanco = ug_Bancos.ActiveRow.Cells("BA_ID").Value
            CO_MT_Banco_Telefonos.lbl_titulo.Text = txt_nombre.Text.Trim
            CO_MT_Banco_Telefonos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class