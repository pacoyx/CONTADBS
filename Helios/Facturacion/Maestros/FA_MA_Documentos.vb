Public Class FA_MA_Documentos

    Dim Bol_Nuevo As Boolean

    Private Sub FA_MA_Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Docs()
        Call Formatear_Grilla_Selector(ug_Doc)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Doc, 0)

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
      
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Doc, 1)

        Bol_Nuevo = True

        txt_codigo.Enabled = True
        txt_codigo.Focus()

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



            Dim DocumentoBL As New BL.FacturacionBL.SG_FA_TB_DOCUMENTO
            Dim DocumentoBE As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO

            With DocumentoBE
                .DO_CODIGO = txt_codigo.Text.Trim
                .DO_DESCRIPCION = txt_Des.Text.Trim
                .DO_ABREVIATURA = txt_Abre.Text.Trim
                .DO_ES_RESTA = IIf(uchk_esResta.Checked, 1, 0)
                .DO_CODIGO_SUNAT = txt_CodSunat.Text.Trim
                .DO_ISTATUS = uos_Estado.Value
                .DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .DO_FECREG = Date.Now
                .DO_TERMINAL = Environment.MachineName
                .DO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .DO_COD_CONTA = txt_cod_conta.Text.Trim
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

        If ug_Doc.Rows.Count = 0 Then Exit Sub
        If ug_Doc.ActiveRow Is Nothing Then Exit Sub


        txt_codigo.Text = ug_Doc.ActiveRow.Cells("DO_CODIGO").Value.ToString
        txt_Des.Text = ug_Doc.ActiveRow.Cells("DO_DESCRIPCION").Value.ToString
        txt_Abre.Text = ug_Doc.ActiveRow.Cells("DO_ABREVIATURA").Value.ToString
        txt_CodSunat.Text = ug_Doc.ActiveRow.Cells("DO_CODIGO_SUNAT").Value.ToString
        uos_Estado.Value = ug_Doc.ActiveRow.Cells("DO_ISTATUS").Value
        uchk_esResta.Checked = IIf(ug_Doc.ActiveRow.Cells("DO_ES_RESTA").Value = 1, True, False)
        txt_cod_conta.Text = ug_Doc.ActiveRow.Cells("DO_COD_CONTA").Value.ToString

        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Doc, 1)

        txt_Des.Focus()



    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Doc, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If Preguntar("Seguro de eliminar el registro.") Then
            Dim DocumentoBL As New BL.FacturacionBL.SG_FA_TB_DOCUMENTO
            Dim DocumentoBE As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO

            DocumentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            DocumentoBE.DO_CODIGO = ug_Doc.ActiveRow.Cells("DO_CODIGO").Value

            DocumentoBL.Delete(DocumentoBE)

            Call Avisar("Listo!")
            Call Cargar_Docs()

            DocumentoBE = Nothing
            DocumentoBL = Nothing
        End If

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Cargar_Docs()

        Dim documentoBL As New BL.FacturacionBL.SG_FA_TB_DOCUMENTO
        Dim documentoBE As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO
        documentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_docs As DataTable = documentoBL.get_Documentos(documentoBE)
        ug_Doc.DataSource = dt_docs

        documentoBE = Nothing
        documentoBL = Nothing

    End Sub

    Private Sub ug_Doc_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Doc.DoubleClickRow

        If ug_Doc.ActiveRow.Index = -1 Then Exit Sub
        Call Tool_Editar_Click(sender, e)

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

    Private Sub ucp_doc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub UltraLabel5_Click(sender As System.Object, e As System.EventArgs) Handles UltraLabel5.Click

    End Sub
End Class