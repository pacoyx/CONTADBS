Public Class CO_MT_Empresa
    Dim Bol_Nuevo As Boolean


    Private Sub CO_MT_Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Inicializar_Estado_Botones()
        Call Cargar_Combos()
        Call MostrarTabs(0, utc_Empresa, 0)

    End Sub


#Region "Sub's"
    Private Sub CargarDatos()
        Try
            Dim Obj_Emp As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim empresas As List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            empresas = Obj_Emp.getEmpresas_1()

            Call LimpiaGrid(ug_Empresa, uds_Empresas)

            Dim i As Integer = 0
            For Each empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA In empresas
                ug_Empresa.DisplayLayout.Bands(0).AddNew()

                ug_Empresa.Rows(i).Cells("EM_IMAGEN").Value = empresa.EM_IMAGEN
                ug_Empresa.Rows(i).Cells("EM_ID").Value = empresa.EM_ID
                ug_Empresa.Rows(i).Cells("EM_NOMBRE").Value = empresa.EM_NOMBRE

                ug_Empresa.UpdateData()
                i += 1
            Next

        Catch ex As Exception
            ShowError(ex.Message)
        End Try


    End Sub

    Private Sub Cambiar_Estado_Botones()
        Tool_Nuevo.Enabled = Not (Tool_Nuevo.Enabled)
        Tool_Grabar.Enabled = Not Tool_Grabar.Enabled
        Tool_Cancelar.Enabled = Not Tool_Cancelar.Enabled
        Tool_Editar.Enabled = Not Tool_Editar.Enabled
        Tool_Salir.Enabled = Not Tool_Salir.Enabled
        Tool_Eliminar.Enabled = Not Tool_Eliminar.Enabled
    End Sub

    Private Sub Inicializar_Estado_Botones()
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Editar.Enabled = True
        Tool_Salir.Enabled = True
        Tool_Eliminar.Enabled = True
    End Sub

    Private Sub Cargar_Combos()
        Try 'marggy_23@hotmail.com 975493490

            Dim PaisBL As New BL.ContabilidadBL.SG_CO_TB_PAIS
            Dim PaisBE As New BE.ContabilidadBE.SG_CO_TB_PAIS
            PaisBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_pais.DataSource = PaisBL.getPais(PaisBE)
            uce_pais.DisplayMember = "PA_DESCRIPCION"
            uce_pais.ValueMember = "PA_CODIGO"
            PaisBL = Nothing
            PaisBE = Nothing

            Dim DepaBL As New BL.ContabilidadBL.SG_CO_TB_DEPARTAMENTO
            uce_depa.DataSource = DepaBL.getDepartamentos()
            uce_depa.ValueMember = "DE_ID"
            uce_depa.DisplayMember = "DE_DESCRIPCION"
            DepaBL = Nothing





        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


#End Region

#Region "Tools"

    Private Sub ubtn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Quitar.Click
        Try
            upb_img.Image = Nothing
            upb_img.Image = My.Resources.Desconocido

        Catch ex As Exception

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

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones()
            Call MostrarTabs(1, utc_Empresa, 2)
            Call Limpiar_Controls_InGroupox(ugb_data)

            Bol_Nuevo = True
            upb_img.Image = Nothing
            upb_img.Image = My.Resources.Desconocido

            une_Id.Enabled = True
            une_Id.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            Dim Obj_EmpBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA

            With empresaBE
                .EM_ID = une_Id.Value
                .EM_NOMBRE = txt_NomEmp.Text.Trim
                .EM_RUC = txt_Ruc.Text.Trim
                .EM_DIR1 = txt_Direccion.Text.Trim
                .EM_NUMTELF1 = IIf(ume_Telefono.Value.ToString = String.Empty, String.Empty, ume_Telefono.Value)
                .EM_REPRESENTANTE = txt_repre.Text.Trim
                .EM_IMAGEN = Image2Bytes(upb_img.Image)

                .EM_FEC_INS = IIf(ume_fec_ins.Value.ToString = String.Empty, String.Empty, ume_fec_ins.Value)
                .EM_IDPAIS = IIf(uce_pais.SelectedIndex = -1, 0, uce_pais.Value)
                .EM_IDDEPARTAMENTO = IIf(uce_depa.SelectedIndex = -1, 0, uce_depa.Value)
                .EM_DOCREPRE = txt_doc_repre.Text.Trim
                .EM_IDCIUDAD = IIf(uce_provincia.SelectedIndex = -1, 0, uce_provincia.Value)
                .EM_DIR2 = txt_dir2.Text.Trim
                .EM_POST1 = txt_postal1.Text.Trim
                .EM_POST2 = txt_postal2.Text.Trim
                .EM_NUMTELF2 = IIf(ume_telefono2.Value.ToString = String.Empty, String.Empty, ume_telefono2.Value)
                .EM_FAX1 = txt_fax1.Text.Trim
                .EM_FAX2 = txt_fax1.Text.Trim
                .EM_MOVIL1 = txt_mobil_1.Text.Trim
                .EM_MOVIL2 = txt_mobil_1.Text.Trim
                .EM_EMAIL1 = txt_email1.Text.Trim
                .EM_EMAIL2 = txt_email2.Text.Trim
                .EM_WEB_SITE = txt_pagina_web.Text.Trim
                .EM_ES_AGENTE_RETENCION = IIf(uchk_agente_ret.Checked, 1, 0)
                .EM_ES_AGENTE_PER_VTA_INT = IIf(uchk_agente_per.Checked, 1, 0)
                .EM_ES_AGENTE_PER_COMBUS = IIf(uchk_agente_per_com.Checked, 1, 0)
                .EM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .EM_TERMINAL = Environment.MachineName
                .EM_FECREG = Now.Date
                .EM_CARGO_REPRE = txt_cargo_repre.Text.Trim

                If upb_logo.Image Is Nothing Then
                    .EM_LOGO = Image2Bytes(My.Resources.Desconocido)
                Else
                    .EM_LOGO = Image2Bytes(upb_logo.Image)
                End If


            End With


            If Bol_Nuevo Then
                Obj_EmpBL.Insert(empresaBE)
            Else
                Obj_EmpBL.Update(empresaBE)
            End If

            Avisar("    Listo!  ")

            Call CargarDatos()
            Tool_Cancelar_Click(sender, e)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = ug_Empresa.ActiveRow.Cells("EM_ID").Value}
            empresaBL.getEmpresas_2(empresaBE)

            With empresaBE
                une_Id.Value = empresaBE.EM_ID
                txt_NomEmp.Text = empresaBE.EM_NOMBRE
                txt_Ruc.Text = empresaBE.EM_RUC
                txt_Direccion.Text = empresaBE.EM_DIR1
                ume_Telefono.Value = empresaBE.EM_NUMTELF1
                txt_repre.Text = empresaBE.EM_REPRESENTANTE
                txt_doc_repre.Text = empresaBE.EM_DOCREPRE
                ume_fec_ins.Value = .EM_FEC_INS
                txt_dir2.Text = .EM_DIR2
                uce_pais.Value = .EM_IDPAIS
                uce_depa.Value = .EM_IDDEPARTAMENTO
                uce_provincia.Value = .EM_IDCIUDAD
                txt_email1.Text = .EM_EMAIL1
                txt_email2.Text = .EM_EMAIL2
                txt_fax1.Text = .EM_FAX1
                txt_fax2.Text = .EM_FAX2
                txt_postal1.Text = .EM_POST1
                txt_postal2.Text = .EM_POST2
                txt_mobil_1.Text = .EM_MOVIL1
                txt_mobil_2.Text = .EM_MOVIL2
                uchk_agente_ret.Checked = IIf(.EM_ES_AGENTE_RETENCION = 1, True, False)
                uchk_agente_per.Checked = IIf(.EM_ES_AGENTE_PER_VTA_INT = 1, True, False)
                uchk_agente_per_com.Checked = IIf(.EM_ES_AGENTE_PER_COMBUS = 1, True, False)
                txt_cargo_repre.Text = .EM_CARGO_REPRE
            End With


            Try
                upb_img.Image = Nothing
                upb_img.Image = Bytes2Image(empresaBE.EM_IMAGEN)
            Catch ex As Exception
                upb_img.Image = My.Resources.Desconocido
            End Try


            Try
                upb_logo.Image = Nothing
                upb_logo.Image = Bytes2Image(empresaBE.EM_LOGO)
            Catch ex As Exception
                upb_logo.Image = My.Resources.Desconocido
            End Try

            Bol_Nuevo = False
            une_Id.Enabled = False

            Call Cambiar_Estado_Botones()
            Call MostrarTabs(1, utc_Empresa, 2)

            txt_NomEmp.Focus()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cambiar_Estado_Botones()
        MostrarTabs(0, utc_Empresa, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

#End Region

    Private Sub une_Id_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Id.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_NomEmp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NomEmp.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Ruc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Ruc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Direccion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ume_Telefono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Telefono.KeyDown, ume_telefono2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_repre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_repre.KeyDown, txt_doc_repre.KeyDown, txt_cargo_repre.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ug_Empresa_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Empresa.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub uce_depa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_depa.ValueChanged
        Try

            Dim CiudadBL As New BL.ContabilidadBL.SG_CO_TB_PROVINCIA
            Dim CiudadBE As New BE.ContabilidadBE.SG_CO_TB_PROVINCIA
            CiudadBE.DE_ID = uce_depa.Value
            uce_provincia.DataSource = CiudadBL.getProvincia(CiudadBE)
            uce_provincia.DisplayMember = "DE_DESCRIPCION"
            uce_provincia.ValueMember = "DE_ID"
            CiudadBE = Nothing
            CiudadBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub UltraLabel19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraLabel19.Click

    End Sub

    Private Sub txt_email2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_email2.ValueChanged

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
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
                Me.upb_logo.Image = Image.FromFile(oFD.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Try
            upb_logo.Image = Nothing
            upb_logo.Image = My.Resources.Desconocido

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_dir2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_dir2.KeyDown, uce_pais.KeyDown, txt_postal1.KeyDown, txt_mobil_1.KeyDown, txt_fax2.KeyDown, txt_fax1.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_depa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_depa.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.Delete Then uce_depa.SelectedIndex = -1

    End Sub

    Private Sub uce_provincia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_provincia.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.Delete Then uce_provincia.SelectedIndex = -1
    End Sub
End Class