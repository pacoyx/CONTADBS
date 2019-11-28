Imports BE.ContabilidadBE
Imports Infragistics.Win.UltraWinListView

Public Class CO_RP_Analisis2
    Dim dt_DataHistorialDoc As DataTable
    Private Sub CO_RP_Analisis2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Documentos()
        Call Cargar_TipoAnexos()
        Call Formatear_Grilla_Selector(ug_doc)
        Call MostrarTabs(0, utc_parametros, 0)
    End Sub

    Private Sub Cargar_TipoAnexos()
        'tipos de anexo
        Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        uce_TipoAnexo.DataSource = AnexoBL.getTipoAnexos()
        uce_TipoAnexo.DisplayMember = "TA_DESCRIPCION"
        uce_TipoAnexo.ValueMember = "TA_CODIGO"
        uce_TipoAnexo.SelectedIndex = 0
        AnexoBL = Nothing
    End Sub

    Private Sub Ayuda_Proveedor1()

        Select Case uce_TipoAnexo.Value
            Case 1 'clientes
                CO_MT_Buscar.Int_Opcion = 2
            Case 2 'proveedores
                CO_MT_Buscar.Int_Opcion = 1
            Case 3 'personal
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uce_TipoAnexo.Value
            Case 4 ' Honorarios
                CO_MT_Buscar.Int_Opcion = 3
            Case 5 'terceros
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uce_TipoAnexo.Value
            Case 6 'Varios
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uce_TipoAnexo.Value
            Case 7 'Accionistas
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uce_TipoAnexo.Value
        End Select



        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_ruc_anexo.Text = matriz(2)
            txt_IdAnexo.Text = matriz(0)
            txt_Des_Prove.Text = matriz(3)
        End If
    End Sub


    Private Sub Cagar_Historial_Documento()
        Try
            Dim ObjReportes As New BL.ContabilidadBL.SG_CO_Reportes_Registros



            Select Case uos_busqueda.Value
                Case 0 'por documento
                    dt_DataHistorialDoc = ObjReportes.getHistorial_Docs(uce_TipoDoc.Value, txt_SerieDoc.Text.Trim, txt_NumDoc.Text.Trim, gInt_IdEmpresa)
                    ug_doc.DataSource = Nothing
                    ug_doc.DataSource = dt_DataHistorialDoc

                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDCAB").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_IDSUBDIARIO").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_ANHO").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_MES").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDCUENTA").Hidden = True

                    ug_doc.DisplayLayout.Bands(0).Columns("SD_DESCRIPCION").Header.Caption = "Subdiario"
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_NUM_VOUCHER").Header.Caption = "Vuocher"
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_FEC_VOUCHER").Header.Caption = "Fecha"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_CUENTA").Header.Caption = "Cuenta"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDANEXO").Header.Caption = "Anexo"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_DEBE").Header.Caption = "Debe"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_HABER").Header.Caption = "Haber"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TCAM").Header.Caption = "T.C."
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_GLOSA").Header.Caption = "Glosa"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_MONTO_ORI").Header.Caption = "Dolares"

                    ug_doc.DisplayLayout.Bands(0).Columns("SD_DESCRIPCION").Width = 70
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_NUM_VOUCHER").Width = 80
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_FEC_VOUCHER").Width = 70
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_CUENTA").Width = 60
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TCAM").Width = 40
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_GLOSA").Width = 150
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_MONTO_ORI").Width = 50

                    ug_doc.DisplayLayout.Bands(0).Columns("AD_DEBE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_HABER").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_MONTO_ORI").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TCAM").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                Case 1 'por anexo

                    If txt_ruc_anexo.Text.Trim = String.Empty Then
                        Avisar("Ingrese el ruc de la razon socia a buscar")
                        txt_ruc_anexo.Focus()
                        Exit Sub
                    End If

                    If txt_IdAnexo.Text.Trim = String.Empty Then
                        Avisar("Ingrese el ruc de la razon socia a buscar")
                        txt_IdAnexo.Focus()
                        Exit Sub
                    End If




                    dt_DataHistorialDoc = ObjReportes.getHistorial_Docs_x_Anexo(txt_IdAnexo.Text.Trim, gInt_IdEmpresa)
                    ug_doc.DataSource = Nothing
                    ug_doc.DataSource = dt_DataHistorialDoc
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDANEXO").Hidden = True

                    ug_doc.DisplayLayout.Bands(0).Columns("AC_IDSUBDIARIO").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDCAB").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_ANHO").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_MES").Hidden = True
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDCUENTA").Hidden = True

                    ug_doc.DisplayLayout.Bands(0).Columns("SD_DESCRIPCION").Header.Caption = "Subdiario"
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_NUM_VOUCHER").Header.Caption = "Voucher"
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_FEC_VOUCHER").Header.Caption = "Fecha"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_CUENTA").Header.Caption = "Cuenta"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_IDANEXO").Header.Caption = "Anexo"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TDOC").Header.Caption = "Doc"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_SDOC").Header.Caption = "Serie"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_NDOC").Header.Caption = "Num. Doc."
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_MONTO_ORI").Header.Caption = "Dolares"

                    ug_doc.DisplayLayout.Bands(0).Columns("AD_DEBE").Header.Caption = "Debe"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_HABER").Header.Caption = "Haber"
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TCAM").Header.Caption = "T.C."
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_GLOSA").Header.Caption = "Glosa"

                    ug_doc.DisplayLayout.Bands(0).Columns("SD_DESCRIPCION").Width = 70
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_NUM_VOUCHER").Width = 80
                    ug_doc.DisplayLayout.Bands(0).Columns("AC_FEC_VOUCHER").Width = 70
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_CUENTA").Width = 60
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TDOC").Width = 40
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_SDOC").Width = 40
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TCAM").Width = 40
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_GLOSA").Width = 150
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_MONTO_ORI").Width = 50

                    ug_doc.DisplayLayout.Bands(0).Columns("AD_DEBE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_HABER").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_MONTO_ORI").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    ug_doc.DisplayLayout.Bands(0).Columns("AD_TCAM").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End Select



            ulbl_num_filas.Text = String.Format("{0} Registros ", ug_doc.Rows.Count)
            If dt_DataHistorialDoc.Rows.Count > 0 Then ug_doc.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Documentos()
        Try
            Dim Obj_DocBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
            Dim E_Doc As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            E_Doc.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            uce_TipoDoc.DataSource = Obj_DocBL.getDocumentos(E_Doc)
            uce_TipoDoc.DisplayMember = "DO_DESCRIPCION"
            uce_TipoDoc.ValueMember = "DO_CODIGO"

            E_Doc = Nothing
            Obj_DocBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Buscar.Click
        Call Cagar_Historial_Documento()
    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_NumDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown

        If e.KeyCode = Keys.Enter Then
            txt_NumDoc.Text = txt_NumDoc.Text.Trim.PadLeft(10, "0")
            Call Cagar_Historial_Documento()
        End If

    End Sub

    Private Sub txt_cod_Doc_Cab_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_Doc_Cab.Leave
        uce_TipoDoc.Value = txt_cod_Doc_Cab.Text.Trim
    End Sub

    Private Sub txt_cod_Doc_Cab_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_Doc_Cab.KeyDown, uce_TipoDoc.KeyDown, txt_SerieDoc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub OpenOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOfficeToolStripMenuItem.Click
        Try
            Dim Obj_Funciones As New LR.ClsFunciones
            Dim Dt As DataTable = Ultragrid_to_DataTable(ug_doc)
            Obj_Funciones.exportar_A_OO_Calc(Dt, "Historial del Documento : " & uce_TipoDoc.Text & " - " & txt_NumDoc.Text & " " & txt_NumDoc.Text)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ExcelMicrosoftOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelMicrosoftOfficeToolStripMenuItem.Click
        Try
            Dim Obj_Funciones As New LR.ClsFunciones
            Dim Dt As DataTable = Ultragrid_to_DataTable(ug_doc)
            Obj_Funciones.exportar_A_MS_Excel(Dt, "Historial del Documento : " & uce_TipoDoc.Text & " - " & txt_NumDoc.Text & " " & txt_NumDoc.Text)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click

        If ug_doc.Rows.Count = 0 Then
            Exit Sub
        End If


        Try
            Dim ObjReporte As New LR.ClsReporte
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, "SG_CO_10.rpt"), dt_DataHistorialDoc, "", "pPeriodo;" & String.Format("{0}/{1}", gDat_Fecha_Sis.Year, gDat_Fecha_Sis.Month), "pRazon;" & gStr_NomEmpresa)

            Obj_EmpresaBL = Nothing
            E_Empresa = Nothing
            ObjReporte.Dispose()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uos_busqueda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_busqueda.ValueChanged
        Call MostrarTabs(uos_busqueda.Value, utc_parametros, uos_busqueda.Value)
        Select Case uos_busqueda.Value
            Case 0
                txt_cod_Doc_Cab.Focus()
            Case 1
                txt_ruc_anexo.Focus()
        End Select
    End Sub

    '20467534026
    Private Sub Buscar_Por_RucAnexo()
        Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        Dim AnexoBE As New SG_CO_TB_ANEXO
        Dim Lista_Anexo As New List(Of BE.ContabilidadBE.SG_CO_TB_ANEXO)

        AnexoBE.AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        AnexoBE.AN_NUM_DOC = txt_ruc_anexo.Text.Trim

        Lista_Anexo = AnexoBL.getAnexo_x_Solo_por_Ruc(AnexoBE)

        If Lista_Anexo.Count = 0 Then
            txt_Des_Prove.Text = "El anexo no existe."
            txt_IdAnexo.Text = String.Empty
        Else
            If Lista_Anexo.Count > 1 Then

                ugb_anexos.Visible = True
                ulv_anexos.Items.Clear()
                For i As Integer = 0 To Lista_Anexo.Count - 1
                    Dim ULVI_fila As UltraListViewItem = ulv_anexos.Items.Add(i)
                    ULVI_fila.SubItems("IdTipo").Value = CInt(Lista_Anexo(i).AN_TIPO_ANEXO.TA_CODIGO)
                    ULVI_fila.SubItems("Tipo").Value = Lista_Anexo(i).AN_TIPO_ANEXO.TA_DESCRIPCION
                    ULVI_fila.SubItems("Ruc").Value = Lista_Anexo(i).AN_NUM_DOC
                    ULVI_fila.SubItems("Descripcion").Value = Lista_Anexo(i).AN_DESCRIPCION
                    ULVI_fila.SubItems("idanexo").Value = Lista_Anexo(i).AN_IDANEXO

                Next

                ulv_anexos.SubItemColumns(0).Width = 50
                ulv_anexos.SubItemColumns("IdTipo").Width = 50
                ulv_anexos.SubItemColumns("Tipo").Width = 150
                ulv_anexos.SubItemColumns("Ruc").Width = 150
                ulv_anexos.SubItemColumns("Descripcion").Width = 100
                ulv_anexos.SubItemColumns("idanexo").Width = 10


                Lista_Anexo = Nothing
                ulv_anexos.Items(0).Activate()
                ulv_anexos.Focus()


            Else
                txt_Des_Prove.Text = Lista_Anexo(0).AN_DESCRIPCION
                txt_IdAnexo.Text = Lista_Anexo(0).AN_IDANEXO
                Call Cagar_Historial_Documento()
            End If
        End If

        AnexoBE = Nothing
        AnexoBL = Nothing
    End Sub

    Private Sub txt_ruc_anexo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc_anexo.Leave
        If txt_ruc_anexo.Text.Trim.Length > 0 Then
            Call Buscar_Por_RucAnexo()
        End If

    End Sub

    Private Sub txt_ruc_anexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_anexo.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.F2 Then Call Ayuda_Proveedor1()
    End Sub

    Private Sub ulv_anexos_ItemDoubleClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinListView.ItemDoubleClickEventArgs) Handles ulv_anexos.ItemDoubleClick
        txt_IdAnexo.Text = e.Item.SubItems("idanexo").Value
        txt_Des_Prove.Text = e.Item.SubItems("Descripcion").Value
        ugb_anexos.Visible = False
        Tool_Buscar_Click(sender, e)
    End Sub

    Private Sub txt_NumDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.Trim.PadLeft(10, "0")
    End Sub

    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged
        txt_cod_Doc_Cab.Text = uce_TipoDoc.Value
    End Sub

    Private Sub uce_TipoAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoAnexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ruc_anexo.Focus()
        End If
    End Sub

    Private Sub txt_IdAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdAnexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            anexoBE.AN_IDANEXO = Val(txt_IdAnexo.Text.Trim)
            anexoBL.getAnexo(anexoBE)

            If anexoBE.AN_NUM_DOC.Trim <> String.Empty Then
                If anexoBE.AN_TIPO_ANEXO.TA_CODIGO = TipoA.Proveedor Then
                    txt_ruc_anexo.Text = anexoBE.AN_NUM_DOC
                    txt_Des_Prove.Text = anexoBE.AN_DESCRIPCION
                Else
                    txt_ruc_anexo.Text = ""
                    txt_Des_Prove.Text = "*El Anexo no existe!"
                End If
            Else
                txt_ruc_anexo.Text = ""
                txt_Des_Prove.Text = "*El Anexo no existe!"
            End If

            anexoBL = Nothing
            anexoBE = Nothing

        End If
    End Sub

    Private Sub txt_ruc_anexo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_anexo.EditorButtonClick
        Call Ayuda_Proveedor1()
    End Sub
End Class