
Public Class CO_RP_Kardes_Anexo

    Private Sub CO_RP_Kardes_Anexo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Tipos_de_Anexo()
        Call Cargar_Documentos()
        Call Formatear_Grilla_Selector(ug_kardex)

        uce_Mes.Items.Add(0, "Todos")
        uce_Mes.Value = 0

    End Sub


    Private Sub Cargar_Tipos_de_Anexo()
        Dim tipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
        uos_tipoAnexo.DataSource = tipoAnexoBL.getTipoAnexos_Dt
        uos_tipoAnexo.DisplayMember = "TA_DESCRIPCION"
        uos_tipoAnexo.ValueMember = "TA_CODIGO"
        tipoAnexoBL = Nothing
        uos_tipoAnexo.Value = 1
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        Dim documentosBE As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
        documentosBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_Documento.DataSource = documentosBL.getDocumentos(documentosBE)
        uce_Documento.DisplayMember = "DO_DESCRIPCION"
        uce_Documento.ValueMember = "DO_CODIGO"
        documentosBE = Nothing
        documentosBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call Cargar_Kardex()
    End Sub

    Private Sub Cargar_Kardex()
        Try


            If uos_Anexo.Value = 1 Then
                If txt_idAnexo1.Text.Trim.Length = 0 Then
                    Avisar("ingrese el " & uos_tipoAnexo.Text & " antes de consultar")
                    txt_ruc1.Focus()
                    Exit Sub
                End If
            End If


            Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Me.Cursor = Cursors.WaitCursor
            Dim dt_resultado As DataTable = reportesBL.get_Kardex_por_Anexo(gInt_IdEmpresa, IIf(txt_idAnexo1.Text.Trim = String.Empty, 0, txt_idAnexo1.Text.Trim), IIf(uce_Documento.Enabled, uce_Documento.Value, ""), uos_tipoAnexo.Value, une_Ayo.Value, uce_Mes.Value, IIf(uchk_pendientes.Checked, True, False))
            ug_kardex.DataSource = dt_resultado

            ume_tot_provi.Value = dt_resultado.Compute("sum(provision)", "")
            ume_tot_pago.Value = dt_resultado.Compute("sum(pago)", "")
            ume_tot_saldo.Value = dt_resultado.Compute("sum(saldo)", "")

            ulbl_num_reg.Text = "Total de Registros : " & dt_resultado.Rows.Count

            reportesBL = Nothing
            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ayuda_Proveedor1()

        Select Case uos_tipoAnexo.Value
            Case 1 'clientes
                CO_MT_Buscar.Int_Opcion = 2
            Case 2 'proveedores
                CO_MT_Buscar.Int_Opcion = 1
            Case 3 'personal
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uos_tipoAnexo.Value
            Case 4 ' Honorarios
                CO_MT_Buscar.Int_Opcion = 3
            Case 5 'terceros
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uos_tipoAnexo.Value
            Case 6 'Varios
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uos_tipoAnexo.Value
            Case 7 'Accionistas
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = uos_tipoAnexo.Value
        End Select


        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_ruc1.Text = matriz(2)
            txt_idAnexo1.Text = matriz(0)
            lbl_Des_Anexo1.Text = matriz(3)
        End If
    End Sub

    Private Sub txt_ruc1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc1.KeyDown
        If e.KeyCode = Keys.F2 Then Call Ayuda_Proveedor1()
    End Sub

    Private Sub txt_ruc1_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc1.EditorButtonClick
        Call Ayuda_Proveedor1()
    End Sub

    Private Sub uos_documento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_documento.ValueChanged
        If uos_documento.Value = 0 Then
            uce_Documento.SelectedIndex = -1
            uce_Documento.Enabled = False
            Call Cargar_Kardex()
        Else
            uce_Documento.Enabled = True
            uce_Documento.Value = 1
            uce_Documento.Focus()
        End If

    End Sub

    Private Sub uos_Anexo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_Anexo.ValueChanged
        If uos_Anexo.Value = 0 Then
            txt_ruc1.Text = String.Empty
            txt_idAnexo1.Text = String.Empty
            lbl_Des_Anexo1.Text = String.Empty
            txt_ruc1.Enabled = False
            Call Cargar_Kardex()
        Else
            Call Ayuda_Proveedor1()
            Call LimpiaGrid(ug_kardex, uds_kardex)
            txt_ruc1.Enabled = True
            txt_ruc1.Focus()
        End If

    End Sub

    Private Sub uos_tipoAnexo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_tipoAnexo.ValueChanged
        ulbl_Anexo.Text = uos_tipoAnexo.Text
        Call Cargar_Kardex()
    End Sub

    Private Sub Tool_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_excel.Click
        Dim Str_titulo As String = "Kardex de Movimiento de " & uos_tipoAnexo.Text & " : " & IIf(uos_Anexo.Value = 0, "Todos", txt_ruc1.Text.Trim & " - " & lbl_Des_Anexo1.Text.Trim)
        Dim dt_datos As DataTable
        dt_datos = CType(ug_kardex.DataSource, DataTable)

        Dim oExcel As Microsoft.Office.Interop.Excel.ApplicationClass
        Dim oBooks As Microsoft.Office.Interop.Excel.Workbooks
        Dim oBook As Microsoft.Office.Interop.Excel.WorkbookClass
        Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet


        Me.Cursor = Cursors.WaitCursor

        ' Inicia Excel y abre el workbook
        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBooks = oExcel.Workbooks
        oBook = oExcel.Workbooks.Add
        oSheet = oBook.Sheets(1)



        Const ROW_FIRST = 4
        Dim iRow As Int64 = 1
        Dim iCols As Int16 = dt_datos.Columns.Count


        oSheet.Cells(1, 1) = Str_titulo
        oSheet.Cells(1, 1).font.bold = True

        'Llenamos la cabecera
        For i As Integer = 1 To iCols
            oSheet.Cells(ROW_FIRST, i) = dt_datos.Columns(i - 1).Caption
            oSheet.Cells(ROW_FIRST, i).font.bold = True
            oSheet.Columns(i).ColumnWidth = 15
        Next



        For j As Integer = 0 To dt_datos.Rows.Count - 1
            Dim iCurrRow As Int64 = ROW_FIRST + iRow

            For iCol As Integer = 1 To iCols
                oSheet.Cells(iCurrRow, iCol) = dt_datos.Rows(j)(iCol - 1)
            Next

            Dim objCelda As Microsoft.Office.Interop.Excel.Range = oSheet.Range("G" & iCurrRow, "I" & iCurrRow)
            objCelda.EntireColumn.NumberFormat = "###,###,###.00"



            iRow += 1
        Next


        Dim objRango As Microsoft.Office.Interop.Excel.Range = oSheet.Range("A" & ROW_FIRST, "I" & iRow)
        objRango.Select()
        objRango.Borders.ColorIndex = 0

        objRango.Columns.AutoFit()
        '        objRango.Columns.Borders


        oBook.PrintPreview()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click
        Dim Obj_repo As New LR.ClsReporte
        Dim dt As DataTable
        Dim Str_titulo As String = "Kardex de Movimiento de " & uos_tipoAnexo.Text & " : " & IIf(uos_Anexo.Value = 0, "Todos", txt_ruc1.Text.Trim & " - " & lbl_Des_Anexo1.Text.Trim)

        Me.Cursor = Cursors.WaitCursor
        dt = CType(ug_kardex.DataSource, DataTable)
        Obj_repo.Muestra_Reporte(gStr_RutaRep & "\SG_CO_26.rpt", dt, "", "pEmp;" & gStr_NomEmpresa, "pTitulo;" & Str_titulo)
        Obj_repo.Dispose()
        Me.Cursor = Cursors.Default

    End Sub
End Class