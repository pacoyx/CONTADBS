Public Class CO_RP_Consolidado_Cta

    Private Sub CO_RP_Consolidado_Cta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Subdiarios()
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        'txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Cargar_Subdiarios()

        Dim SubdiariosBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        Dim SubdiariosBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        Dim Dt As DataTable = SubdiariosBL.getSubdiarios(SubdiariosBE)

        Call LimpiaGrid(ug_subdiarios, uds_subdiarios)

        For i As Integer = 0 To Dt.Rows.Count - 1
            ug_subdiarios.DisplayLayout.Bands(0).AddNew()
            ug_subdiarios.Rows(i).Cells("Sel").Value = True
            ug_subdiarios.Rows(i).Cells("Codigo").Value = Dt.Rows(i)("SD_ID")
            ug_subdiarios.Rows(i).Cells("Subdiario").Value = Dt.Rows(i)("SD_DESCRIPCION")
        Next
        ug_subdiarios.UpdateData()

        SubdiariosBE = Nothing
        SubdiariosBL = Nothing


    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor

        If txt_Ayo.Text.Trim.Length = 0 Then
            Avisar("El periodo no se a cargado.")
            Exit Sub
        End If

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        Call Grabar_Codigos()

        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        ug_datos.DataSource = reportesBL.get_Consolidado_Cta(txt_Ayo.Text, uce_Mes.Value, Environment.MachineName, gInt_IdEmpresa)
        UltraGridExcelExporter1.Export(ug_datos, "Consolidado.xls")
        Process.Start("Consolidado.xls")

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Grabar_Codigos()

        Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
        Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        ug_subdiarios.UpdateData()

        For i As Integer = 0 To ug_subdiarios.Rows.Count - 1
            If ug_subdiarios.Rows(i).Cells("Sel").Value Then
                lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(ug_subdiarios.Rows(i).Cells("Codigo").Value.ToString, Environment.MachineName, gInt_IdEmpresa))
            End If
        Next

        Call ReportesBL.setCodigos(lista_codigos)

    End Sub

    Private Sub uchk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_todos.CheckedChanged
        For i As Integer = 0 To ug_subdiarios.Rows.Count - 1
            ug_subdiarios.Rows(i).Cells("Sel").Value = uchk_todos.Checked
        Next

        ug_subdiarios.UpdateData()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class