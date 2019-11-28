Public Class CO_RP_LibCajaBancos

    Private Sub CO_RP_LibCajaBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
        lbl_mensaje.Text = String.Empty
        Call Cargar_Cuentas()
    End Sub

    Private Sub Cargar_Cuentas()
        Try
            If txt_Ayo.Text.Trim.Length = 0 Then Exit Sub

            Dim CuentasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim CuentasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            CuentasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            CuentasBE.PC_PERIODO = txt_Ayo.Text.Trim
            CuentasBE.PC_IDTIPO_MOV_DET = New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = uos_Formato.Value}
            Dim Dt_ctas As DataTable = CuentasBL.getCuentas_Movimiento_Tipo_Caja_Bancos(CuentasBE)

            Call LimpiaGrid(ug_Cuentas, uds_Cuentas)
            'ug_Cuentas.DataSource = Dt_ctas

            For i As Integer = 0 To Dt_ctas.Rows.Count - 1
                ug_Cuentas.DisplayLayout.Bands(0).AddNew()
                ug_Cuentas.Rows(i).Cells("Sel").Value = False
                ug_Cuentas.Rows(i).Cells("Cuenta").Value = Dt_ctas.Rows(i)("CUENTA")
                ug_Cuentas.Rows(i).Cells("Descripcion").Value = Dt_ctas.Rows(i)("DESCRIPCION")
                ug_Cuentas.Rows(i).Cells("IdCuenta").Value = Dt_ctas.Rows(i)("IDCUENTA")
            Next

            ug_Cuentas.UpdateData()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uchk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_todos.CheckedChanged
        Try

            For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                ug_Cuentas.Rows(i).Cells("Sel").Value = uchk_todos.Checked
            Next
            ug_Cuentas.UpdateData()

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
            Call Grabar_Saldos()
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
            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            CabeceraBE.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            CabeceraBE.AC_MES = CInt(uce_Mes.Value)
            CabeceraBE.AC_IDEMPRESA = EmpresaBE
            CabeceraBE.AC_TERMINAL = Environment.MachineName

            Dim Dt As DataTable = Nothing
            Dim Str_ConFecha As Integer = IIf(uchk_SinFecha.Checked, "1", "0")
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim Str_NombreRep As String = "SG_CO_08.RPT"
            Dim Str_Resumen As String = IIf(uchk_Resumen.Checked, "1", "0")

            Select Case uos_Formato.Value
                Case 2 'caja
                    Dt = Obj_ReporteBL.getLibro_Caja(CabeceraBE)
                Case 3 'bancos
                    Dt = Obj_ReporteBL.getLibro_Bancos(CabeceraBE)
            End Select


            EmpresaBL.getEmpresas_2(EmpresaBE)

            Select Case uos_Formato.Value
                Case 2 'caja
                    Str_NombreRep = "SG_CO_19.RPT"
                Case 3 'bancos
                    Str_NombreRep = "SG_CO_09.RPT"
            End Select

            Using ObjReporte As New LR.ClsReporte

                ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
                                           String.Format("pPeriodoo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                     "pRuc;" & EmpresaBE.EM_RUC, _
                                     "pRazon;" & EmpresaBE.EM_NOMBRE.Trim, _
                                     "pFecha_Pag;" & Str_ConFecha, "pResumen;" & Str_Resumen)
            End Using

            upb_Mayor.Visible = False
            lbl_mensaje.Text = ""
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grabar_Saldos()
        Try
            Dim lista_cuentas As New List(Of String)
            Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

            ug_Cuentas.UpdateData()

            upb_Mayor.Value = 0
            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = ug_Cuentas.Rows.Count
            upb_Mayor.Visible = True
            lbl_mensaje.Text = "Calculando saldos... "
            Me.Refresh()

            For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                If ug_Cuentas.Rows(i).Cells("Sel").Value Then
                    lista_cuentas.Add(ug_Cuentas.Rows(i).Cells("Cuenta").Value.ToString)
                End If
                upb_Mayor.IncrementValue(1)
            Next

            Call ReportesBL.setSaldos_Cuentas(lista_cuentas, txt_Ayo.Text.Trim, uce_Mes.Value, Environment.MachineName, gInt_IdEmpresa)

            lbl_mensaje.Text = "Cargando Reporte... "
            Me.Refresh()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Codigos()
        Try
            Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
            Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

            ug_Cuentas.UpdateData()
            upb_Mayor.Value = 0
            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = ug_Cuentas.Rows.Count
            upb_Mayor.Visible = True
            lbl_mensaje.Text = "Seleccionando cuentas... "
            Me.Refresh()
            For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                If ug_Cuentas.Rows(i).Cells("Sel").Value Then
                    lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(ug_Cuentas.Rows(i).Cells("Cuenta").Value.ToString, Environment.MachineName, gInt_IdEmpresa))
                End If
                upb_Mayor.IncrementValue(1)
            Next

            Call ReportesBL.setCodigos(lista_codigos)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uos_Formato_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_Formato.ValueChanged
        Try
            uchk_todos.Checked = False
            Call Cargar_Cuentas()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class