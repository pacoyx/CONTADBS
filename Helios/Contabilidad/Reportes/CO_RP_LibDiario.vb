Public Class CO_RP_LibDiario

    Private Sub CO_RE_LibDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Subdiarios()
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Cargar_Subdiarios()
        Try
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

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Try
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
            Call Mostrar_Reporte()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Mostrar_Reporte()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa
            E_Cabecera.AC_TERMINAL = Environment.MachineName

            Dim Dt As DataTable = Nothing
            Dim Str_mensaje As String = String.Empty
            Dim Str_ConFecha As Integer = IIf(uchk_SinFecha.Checked, "1", "0")
            Dim Str_Resumen As String = IIf(uchk_Resumen.Checked, "1", "0")

            If uchk_Asientos_Descu.Checked Then
                Dt = Obj_ReporteBL.getLibro_Diario_Asientos_Descuadrados(E_Cabecera)
                Str_mensaje = "Asientos Descuadrados"
            Else
                Dt = Obj_ReporteBL.getLibro_Diario(E_Cabecera)
            End If

            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Str_NombreRep As String = "SG_CO_07.RPT"
            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim, "pMensaje;" & Str_mensaje, "pFecha_Pag;" & Str_ConFecha, "pResumen;" & Str_Resumen)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grabar_Codigos()
        Try
            Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
            Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

            ug_subdiarios.UpdateData()

            For i As Integer = 0 To ug_subdiarios.Rows.Count - 1
                If ug_subdiarios.Rows(i).Cells("Sel").Value Then
                    lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(ug_subdiarios.Rows(i).Cells("Codigo").Value.ToString, Environment.MachineName, gInt_IdEmpresa))
                End If
            Next

            Call ReportesBL.setCodigos(lista_codigos)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uchk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_todos.CheckedChanged
        Try

            For i As Integer = 0 To ug_subdiarios.Rows.Count - 1
                ug_subdiarios.Rows(i).Cells("Sel").Value = uchk_todos.Checked
            Next

            ug_subdiarios.UpdateData()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class