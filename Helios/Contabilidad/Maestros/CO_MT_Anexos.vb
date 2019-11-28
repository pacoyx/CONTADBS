Imports BE.ContabilidadBE

Public Class CO_MT_Anexos
    Dim Bol_Nuevo As Boolean
    Dim Int_Cod_tipo_Anexo As Integer ' para refrescar la grilla despues de un Insert o Update

    Private Sub CO_MT_Anexos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Tipos_Anexos()
        Call Formatear_Grilla_Selector(ug_Anexos)
        Call Inicializar_Estado_Botones()
        Call CargarCombos()
        Call MostrarTabs(0, utc_Anexos)
    End Sub

    Private Sub CargarCombos()

        'tipos de anexo
        Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        uce_TipoAnexo.DataSource = AnexoBL.getTipoAnexos()
        uce_TipoAnexo.DisplayMember = "TA_DESCRIPCION"
        uce_TipoAnexo.ValueMember = "TA_CODIGO"

    

        'tipo de empresa
        Dim obj_TipoEmpsBL As New BL.ContabilidadBL.SG_CO_TB_TIPOEMPRESA
        uce_TipoEmp.DataSource = obj_TipoEmpsBL.getTipoEmpresas
        uce_TipoEmp.DisplayMember = "TE_DESCRIPCION"
        uce_TipoEmp.ValueMember = "TE_CODIGO"

        'tipo de doc persona
        Dim obj_docPBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_DOC_IDENTIDAD
        uce_TipoDoc.DataSource = obj_docPBL.getTipoDos
        uce_TipoDoc.DisplayMember = "DI_DESCRIPCION"
        uce_TipoDoc.ValueMember = "DI_CODIGO"


    End Sub

    Private Sub Cargar_Tipos_Anexos()
        Try
            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim tipos As New List(Of SG_CO_TB_TIPOANEXO)
            tipos = AnexoBL.getTipoAnexos()

            For Each tipo As SG_CO_TB_TIPOANEXO In tipos
                Dim g As Integer = tipo.TA_CODIGO
                ueb_TipoAnexos.Groups(0).Items.Add(g, tipo.TA_DESCRIPCION)
                ueb_TipoAnexos.Groups(0).Items(g.ToString).Settings.AppearancesSmall.Appearance.Image = Bytes2Image(tipo.TA_IMG)
            Next

            ueb_TipoAnexos.Groups.Add("Datos", "Informacion")

            ueb_TipoAnexos.Groups("Datos").Items.Add("1", "Datos Secundarios")
            ueb_TipoAnexos.Groups("Datos").Items("1").Settings.AppearancesSmall.Appearance.Image = My.Resources._16__Plus_favorites_

            ueb_TipoAnexos.Groups("Datos").Items.Add("2", "Direccion")
            ueb_TipoAnexos.Groups("Datos").Items("2").Settings.AppearancesSmall.Appearance.Image = My.Resources._16__Address_book_

            ueb_TipoAnexos.Groups("Datos").Items.Add("3", "Contactos")
            ueb_TipoAnexos.Groups("Datos").Items("3").Settings.AppearancesSmall.Appearance.Image = My.Resources._16__Idcard_

            ueb_TipoAnexos.Groups("Datos").Items.Add("4", "Datos Financieros")
            ueb_TipoAnexos.Groups("Datos").Items("4").Settings.AppearancesSmall.Appearance.Image = My.Resources._16__Briefcase_

            ueb_TipoAnexos.Groups("Datos").Items.Add("5", "Cuentas Bancarias")
            ueb_TipoAnexos.Groups("Datos").Items("5").Settings.AppearancesSmall.Appearance.Image = My.Resources._16__Page_number_

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CargarDatos(ByVal Int_TipoAnexo As Integer)
        Try

            Dim Bol_masRapido As Boolean = True
            Int_Cod_tipo_Anexo = Int_TipoAnexo
            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim anexos As New List(Of BE.ContabilidadBE.SG_CO_TB_ANEXO)

            Dim TipoAnexoBE As New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo}
            Dim EmpresaBE As New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Call LimpiaGrid(ug_Anexos, uds_Anexos)

            If Bol_masRapido Then
                Dim Dt_Anexos As DataTable = AnexoBL.getAnexos_DT(New SG_CO_TB_ANEXO With {.AN_TIPO_ANEXO = TipoAnexoBE, .AN_IDEMPRESA = EmpresaBE})
                ug_Anexos.DataSource = Dt_Anexos
            Else

                anexos = AnexoBL.getAnexos(New SG_CO_TB_ANEXO With {.AN_TIPO_ANEXO = TipoAnexoBE, .AN_IDEMPRESA = EmpresaBE})
                Dim i As Integer = 0
                For Each anexo As SG_CO_TB_ANEXO In anexos
                    ug_Anexos.DisplayLayout.Bands(0).AddNew()
                    ug_Anexos.Rows(i).Cells("AN_IDANEXO").Value = anexo.AN_IDANEXO
                    ug_Anexos.Rows(i).Cells("DI_ABREVIATURA").Value = anexo.AN_PC_USUARIO
                    ug_Anexos.Rows(i).Cells("AN_NUM_DOC").Value = anexo.AN_NUM_DOC
                    ug_Anexos.Rows(i).Cells("AN_DESCRIPCION").Value = anexo.AN_DESCRIPCION
                    i += 1
                    ug_Anexos.UpdateData()
                Next
            End If

            AnexoBL = Nothing
            TipoAnexoBE = Nothing
            EmpresaBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones()
        Call Limpiar_Controls_InGroupox(ugb_data)

        uce_TipoAnexo.Value = IIf(Int_Cod_tipo_Anexo = 0, 1, Int_Cod_tipo_Anexo)
        uce_TipoDoc.Value = 6
        uce_TipoEmp.Value = 2

        If gStr_Usuario_Sis.ToUpper = "ADMIN" Then
            Call MostrarTabs(1, utc_Anexos, 2)
        Else
            Call MostrarTabs(1, utc_Anexos, 1)
        End If


        Bol_Nuevo = True
        txt_num_doc.Enabled = True

        Dim obj_usu As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        If obj_usu.Es_Administrador(New SG_CO_TB_USUARIO With {.US_NOMBRE = gStr_Usuario_Sis}) Then utc_Anexos.Tabs(2).Enabled = True

        txt_num_doc.Focus()


    End Sub

    Private Function ValidarDatos() As Boolean
        ValidarDatos = False
     
        If uce_TipoAnexo.SelectedIndex = -1 Then
            Avisar("Debe seleccionar un Tipo de Anexo")
            uce_TipoAnexo.Focus()
            Exit Function
        End If

        If uce_TipoEmp.SelectedIndex = -1 Then
            Avisar("Debe seleccionar un Tipo de Empresa")
            uce_TipoEmp.Focus()
            Exit Function
        End If

        If uce_TipoDoc.SelectedIndex = -1 Then
            Avisar("Debe seleccionar un Tipo de Documento")
            uce_TipoDoc.Focus()
            Exit Function
        End If

        If txt_num_doc.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar un numero de documento")
            txt_num_doc.Focus()
            Exit Function
        End If

        If txt_Razon.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar la razon social")
            txt_Razon.Focus()
            Exit Function
        End If

        Return True
        
    End Function

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        'validamos
        If Not ValidarDatos() Then Exit Sub
        Try
            Dim obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO

            With E_Anexo

                If Bol_Nuevo Then
                    .AN_IDANEXO = 0
                Else
                    .AN_IDANEXO = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
                End If

                .AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TipoAnexo.Value}
                .AN_TIPO_EMPRESA = New SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = uce_TipoEmp.Value}
                .AN_TIPO_DOC = New SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = uce_TipoDoc.Value}
                .AN_NUM_DOC = txt_num_doc.Text.Trim
                .AN_DESCRIPCION = txt_Razon.Text.Trim
                .AN_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AN_PC_TERMINAL = Environment.MachineName
                .AN_PC_FECREG = Date.Now
                .AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AN_ES_RELACIONADO = IIf(uchk_EsRelacionado.Checked, 1, 0)
            End With

            If Bol_Nuevo Then
                obj_AnexoBL.Insert(E_Anexo)
            Else
                obj_AnexoBL.Update(E_Anexo)
            End If

            Call Avisar("    Listo!  ")

            Call CargarDatos(Int_Cod_tipo_Anexo)

            Tool_Cancelar_Click(sender, e)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            If ug_Anexos.Rows.Count = 0 Then Exit Sub
            If ug_Anexos.ActiveRow.Index = -1 Then Exit Sub

            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim AnexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            AnexoBE.AN_IDANEXO = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
            AnexoBL.getAnexo(AnexoBE)

            uce_TipoAnexo.Value = AnexoBE.AN_TIPO_ANEXO.TA_CODIGO
            uce_TipoDoc.Value = AnexoBE.AN_TIPO_DOC.DI_CODIGO
            uce_TipoEmp.Value = AnexoBE.AN_TIPO_EMPRESA.TE_CODIGO
            txt_num_doc.Text = AnexoBE.AN_NUM_DOC
            txt_Razon.Text = AnexoBE.AN_DESCRIPCION
            uchk_EsRelacionado.Checked = AnexoBE.AN_ES_RELACIONADO
            uchk_NoDomi.Checked = AnexoBE.AN_ES_NO_DOMI

            Call MostrarTabs(1, utc_Anexos, 1)
            Call Cambiar_Estado_Botones()

            ueb_TipoAnexos.Groups("Datos").Enabled = False

            txt_Razon.Focus()
            Bol_Nuevo = False

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cambiar_Estado_Botones()
        MostrarTabs(0, utc_Anexos, 0)
        ueb_TipoAnexos.Groups("Datos").Enabled = True
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro de eliminar el registro?") Then
                Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim AnexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                AnexoBE.AN_IDANEXO = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
                AnexoBL.Delete(AnexoBE)
                Avisar("    Listo!  ")
                Me.Cursor = Cursors.WaitCursor
                Call CargarDatos(Int_Cod_tipo_Anexo)
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
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

    Private Sub tool_Ayuda2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_Ayuda2.Click
        Dim str_mensaje As String
        str_mensaje = "121201 => Clientes " & Chr(13) & _
        "131251 => Clientes " & Chr(13) & _
        "141101 => Personal " & Chr(13) & _
        "141201 => Personal " & Chr(13) & _
        "1622901 => Terceros " & Chr(13) & _
        "189001 => Varios " & Chr(13) & _
        "421101 => Proveedores " & Chr(13) & _
        "421201 => Proveedores " & Chr(13) & _
        "422001 => Proveedores " & Chr(13) & _
        "42202 => Proveedores " & Chr(13) & _
        "424001 => Honorarios " & Chr(13) & _
        "431151 => Proveedores " & Chr(13) & _
        "431251 => Proveedores " & Chr(13) & _
        "441101 => Accionistas " & Chr(13)

        Avisar(str_mensaje)

    End Sub

    Private Sub ueb_TipoAnexos_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles ueb_TipoAnexos.ItemClick
        If e.Item.Group.Key.Equals("Datos") Then


            'Abrimos las ventanas de los casos
            If e.Item.Key.Equals("1") Then
                'si es 1=datos sec. solo para tipos anexos(1,2,3,4)
                If ulbl_titulo.Text = "Clientes" Or _
                        ulbl_titulo.Text = "Proveedores" Or _
                        ulbl_titulo.Text = "Personal" Or _
                        ulbl_titulo.Text = "Honorarios" Then

                    Select Case Int_Cod_tipo_Anexo
                        Case 1 'Clientes
                            CO_MT_DetClientes.Text = "Datos Secundarios : " & ug_Anexos.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
                            CO_MT_DetClientes.Int_IdCliente = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
                            CO_MT_DetClientes.ShowDialog()
                        Case 2 'Proveedores
                            CO_MT_DetProve.Text = "Datos Secundarios : " & ug_Anexos.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
                            CO_MT_DetProve.str_razon = ug_Anexos.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
                            CO_MT_DetProve.int_idanexo = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
                            CO_MT_DetProve.ShowDialog()
                        Case 3 'Personal
                            CO_MT_DetPerso.ShowDialog()
                        Case 4 'Honorarios
                            CO_MT_DetHono.str_razon = ug_Anexos.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
                            CO_MT_DetHono.int_idanexo = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
                            CO_MT_DetHono.ShowDialog()
                    End Select
                Else
                    Avisar("Es tipo de anexo no tiene establecido informacion secundaria")
                    Exit Sub
                End If
            Else
                'Levantamos las ventanas de contacto,direcciones, etc.


            End If


        Else

            If Tool_Cancelar.Enabled Then Tool_Cancelar_Click(sender, e)
            Call CargarDatos(e.Item.Key)
            ulbl_titulo.Text = e.Item.Text
        End If
    End Sub

    Private Sub ubtn_CopiarDestinos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim obj_Destino As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO
        obj_Destino.Copiar_DestinosIGF_a_PlanCtasNuevo()
        Avisar("Listo, destinos copiados correctamente")

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj_Destino As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO
        obj_Destino.Crear_Destino_Faltantes()
        Avisar("Listo!")
    End Sub

    Private Sub uce_TipoAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoAnexo.KeyDown, uce_TipoEmp.KeyDown, uce_TipoDoc.KeyDown, txt_Razon.KeyDown, txt_num_doc.KeyDown
        If e.KeyCode = Keys.Escape Then Tool_Cancelar_Click(sender, e)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ubtn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Grabar.Click
        If Not ValidarDatos() Then Exit Sub
        Try
            Dim obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO

            With E_Anexo

                If Bol_Nuevo Then
                    .AN_IDANEXO = 0
                Else
                    .AN_IDANEXO = ug_Anexos.ActiveRow.Cells("AN_IDANEXO").Value
                End If

                .AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TipoAnexo.Value}
                .AN_TIPO_EMPRESA = New SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = uce_TipoEmp.Value}
                .AN_TIPO_DOC = New SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = uce_TipoDoc.Value}
                .AN_NUM_DOC = txt_num_doc.Text.Trim
                .AN_DESCRIPCION = txt_Razon.Text.Trim
                .AN_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AN_PC_TERMINAL = Environment.MachineName
                .AN_PC_FECREG = Date.Now
                .AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AN_ES_RELACIONADO = IIf(uchk_EsRelacionado.Checked, 1, 0)
                .AN_ES_NO_DOMI = IIf(uchk_NoDomi.Checked, 1, 0)
            End With

            If Bol_Nuevo Then
                obj_AnexoBL.Insert(E_Anexo)
            Else
                obj_AnexoBL.Update(E_Anexo)
            End If

            Call Avisar("    Listo!  ")

            Call CargarDatos(Int_Cod_tipo_Anexo)

            Tool_Cancelar_Click(sender, e)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
        anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_Cod_tipo_Anexo}
        anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_anexos As DataTable = AnexoBL.getAnexos_DT(anexoBE)



        Using reporteBL As New LR.ClsReporte
            reporteBL.Muestra_Reporte(gStr_RutaRep & "\SG_CO_22.rpt", dt_anexos, "", "pEmpresa;" & gStr_NomEmpresa, "pTipoAnexo;" & ulbl_titulo.Text.Trim)
        End Using

        AnexoBL = Nothing
        anexoBE = Nothing
        dt_anexos = Nothing

    End Sub

    Private Sub ug_Anexos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Anexos.KeyDown

        If e.KeyCode = Keys.Escape Then Me.Close()

        If ug_Anexos.Rows.Count > 0 Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            Call Tool_Editar_Click(sender, e)
        End If
    End Sub

    Private Sub ug_Anexos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Anexos.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ubtn_Novaq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CO_PR_NovaqVta.Show()
    End Sub

    Private Sub Tool_Act_InfoClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Act_InfoClie.Click

        Dim migradorBL As New BL.ContabilidadBL.Migrador
        Me.Cursor = Cursors.WaitCursor
        Try
            migradorBL.Actualizar_Datos_Cliente_Novaq()
        Catch ex As Exception
            Avisar("Problemas con la actualizacion." & Chr(13) & ex.Message)
        End Try

        Me.Cursor = Cursors.Default
        migradorBL = Nothing

    End Sub
End Class