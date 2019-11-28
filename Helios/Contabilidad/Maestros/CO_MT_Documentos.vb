Public Class CO_MT_Documentos

    Dim DocumentoBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MT_Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Docs()
        Call Formatear_Grilla_Selector(ug_Doc)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try

            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Limpiar_Controls_InGroupox(ugb_datos)
            Call MostrarTabs(1, utc_Doc, 1)

            Bol_Nuevo = True
            ucp_doc.Value = Nothing
            txt_codigo.Enabled = True
            txt_codigo.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try


            'Tambien falta validar!!!
            If txt_codigo.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar un codigo")
                txt_codigo.Focus()
                Exit Sub
            End If

            If txt_Des.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar una descricpion")
                txt_Des.Focus()
                Exit Sub
            End If



            Dim DocumentoBE As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            With DocumentoBE
                .DO_CODIGO = txt_codigo.Text.Trim
                .DO_DESCRIPCION = txt_Des.Text.Trim
                .DO_ABREVIATURA = txt_Abre.Text.Trim
                .DO_ES_RESTA = IIf(uchk_esResta.Checked, 1, 0)
                .DO_CODIGO_SUNAT = txt_CodSunat.Text.Trim
                .DO_ISTATUS = uos_Estado.Value
                .DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .DO_PC_FECREG = Date.Now
                .DO_PC_TERMINAL = Environment.MachineName
                .DO_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .DO_COLOR_DOC = ucp_doc.ColorHtml
            End With

            If Bol_Nuevo Then
                DocumentoBL.Insert(DocumentoBE)
            Else
                DocumentoBL.Update(DocumentoBE)
            End If


            ' aki hay mostrar mensaje de OK
            Call Avisar("Listo!")
            Call Cargar_Docs()
            Call Tool_Cancelar_Click(sender, e)
            DocumentoBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            Dim DocumentoBE As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            DocumentoBE.DO_CODIGO = ug_Doc.ActiveRow.Cells("DO_CODIGO").Value
            DocumentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            DocumentoBL.getDocumentos_x_Codigo(DocumentoBE)

            If DocumentoBE.DO_DESCRIPCION.Trim.Length > 0 Then
                txt_codigo.Text = DocumentoBE.DO_CODIGO
                txt_Des.Text = DocumentoBE.DO_DESCRIPCION
                txt_Abre.Text = DocumentoBE.DO_ABREVIATURA
                txt_CodSunat.Text = DocumentoBE.DO_CODIGO_SUNAT
                uos_Estado.Value = DocumentoBE.DO_ISTATUS
                uchk_esResta.Checked = IIf(DocumentoBE.DO_ES_RESTA = 1, True, False)
                ucp_doc.Color = System.Drawing.Color.FromName(DocumentoBE.DO_COLOR_DOC)

                'System.Drawing.ColorTranslator.FromHtml(DocumentoBE.DO_COLOR_DOC)

            End If
            '
            txt_codigo.Enabled = False

            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_Doc, 1)

            txt_Des.Focus()
            DocumentoBE = Nothing

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(0, utc_Doc, 0)
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Seguro de eliminar el registro.") Then
                DocumentoBL.Delete(New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_Doc.ActiveRow.Cells("DO_CODIGO").Value, .DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
                Avisar("Listo!")
                Call Cargar_Docs()
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Cargar_Docs()
        Try
            Dim docs As New List(Of BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            Dim E_Doc As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            E_Doc.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            docs = DocumentoBL.getDocumentos(E_Doc)
            Call LimpiaGrid(ug_Doc, uds_Doc)

            Dim i As Integer = 0
            For Each doc As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO In docs
                ug_Doc.DisplayLayout.Bands(0).AddNew()
                ug_Doc.Rows(i).Cells("DO_CODIGO").Value = doc.DO_CODIGO
                ug_Doc.Rows(i).Cells("DO_DESCRIPCION").Value = doc.DO_DESCRIPCION
                ug_Doc.Rows(i).Cells("DO_ABREVIATURA").Value = doc.DO_ABREVIATURA
                ug_Doc.Rows(i).Cells("DO_ISTATUS").Value = doc.DO_ISTATUS
                i += 1
            Next

            ug_Doc.UpdateData()

            docs = Nothing
            E_Doc = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_Doc_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Doc.DoubleClickRow
        Try
            If ug_Doc.ActiveRow.Index = -1 Then Exit Sub
            Call Tool_Editar_Click(sender, e)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Des_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Des.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Abre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Abre.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uos_Estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uos_Estado.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_CodSunat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CodSunat.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_esResta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_esResta.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ucp_doc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ucp_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class