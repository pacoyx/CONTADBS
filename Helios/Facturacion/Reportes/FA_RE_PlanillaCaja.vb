Public Class FA_RE_PlanillaCaja

    Dim dt_reporte As New DataTable
    Dim es_super As Boolean = False

    Private Sub FA_RE_PlanillaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Crear_Tabla_Reporte()
        Call Cargar_Turnos()
        Call Validar_Super_ft()

        ume_fecha.Value = gDat_Fecha_Sis
        txt_cajero.Text = gStr_Usuario_Sis

    End Sub
    Private Sub Validar_Super_ft()
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        es_super = usuarioBL.es_super_ft(gStr_Usuario_Sis)
        usuarioBL = Nothing
        If gStr_Usuario_Sis = "admin" Then
            es_super = True
        End If
    End Sub

    Private Sub Cargar_Turnos()
        Dim turnoBL As New BL.FacturacionBL.SG_FA_TB_TURNO
        Dim turnoBE As New BE.FacturacionBE.SG_FA_TB_TURNO
        turnoBE.TU_IDEMPRESA = gInt_IdEmpresa
        uce_turno.DataSource = turnoBL.get_Turnos(turnoBE)
        uce_turno.DisplayMember = "TU_DESCRIPCION"
        uce_turno.ValueMember = "TU_ID"
        turnoBE = Nothing
        turnoBL = Nothing
    End Sub

    Private Sub Crear_Tabla_Reporte()
        dt_reporte.Columns.Clear()
        dt_reporte.Columns.Add("TD", Type.GetType("System.String"))
        dt_reporte.Columns.Add("SD", Type.GetType("System.String"))
        dt_reporte.Columns.Add("ND", Type.GetType("System.String"))
        dt_reporte.Columns.Add("EFECTIVO", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("VISANET", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("MASTERCARD", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("AMEX", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("DINNER", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("REMESAS", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("TOTAL", Type.GetType("System.Double"))
    End Sub

    Private Sub Procesar_Reporte()

        If ume_fecha.Value.ToString = "" Then
            Call Avisar("Ingrese Fecha")
            ume_fecha.Focus()
            Exit Sub
        End If

        If uce_turno.SelectedIndex = -1 Then
            Avisar("Seleccione un turno")
            uce_turno.Focus()
            Exit Sub
        End If

        Dim reportBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim dt_tmp As DataTable = Nothing
        Dim dt_detalle As DataTable = Nothing
        Dim nuevaf As DataRow

        If es_super Then
            dt_tmp = reportBL.get_Planilla_Caja_super(CDate(ume_fecha.Value).ToShortDateString, uce_turno.Value, gInt_IdEmpresa)
        Else
            dt_tmp = reportBL.get_Planilla_Caja(gInt_IdUsuario_Sis, CDate(ume_fecha.Value).ToShortDateString, uce_turno.Value, gInt_IdEmpresa)
        End If



        Try

            Me.Cursor = Cursors.WaitCursor
            dt_reporte.Rows.Clear()

            For Each fila As DataRow In dt_tmp.Rows
                nuevaf = dt_reporte.NewRow()
                With nuevaf
                    .Item("TD") = fila.Item("TDOC").ToString
                    .Item("SD") = fila.Item("SDOC").ToString
                    .Item("ND") = fila.Item("NDOC").ToString
                    .Item("EFECTIVO") = 0
                    .Item("VISANET") = 0
                    .Item("MASTERCARD") = 0
                    .Item("AMEX") = 0
                    .Item("DINNER") = 0
                    .Item("REMESAS") = 0
                    .Item("TOTAL") = 0
                    dt_detalle = reportBL.get_Detalle_Pago_x_IdCompro(fila.Item("CO_ID"))

                    If dt_detalle.Rows.Count > 0 Then
                        Dim total As Double = 0

                        For Each fdet As DataRow In dt_detalle.Rows
                            If fdet.Item("CD_IDDOCPAGO").ToString = "001" Then .Item("EFECTIVO") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "002" Then .Item("VISANET") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "003" Then .Item("MASTERCARD") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "004" Then .Item("AMEX") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "005" Then .Item("DINNER") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "006" Then .Item("REMESAS") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                        Next
                        .Item("TOTAL") = total

                    Else
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "001" Then .Item("EFECTIVO") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "002" Then .Item("VISANET") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "003" Then .Item("MASTERCARD") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "004" Then .Item("AMEX") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "005" Then .Item("DINNER") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "006" Then .Item("REMESAS") = fila.Item("TOTAL")
                        .Item("TOTAL") = fila.Item("TOTAL")
                    End If

                End With
                dt_reporte.Rows.Add(nuevaf)
            Next

        dt_tmp.Dispose()
        reportBL = Nothing


        Dim crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_09.RPT", dt_reporte, "", "pEmpresa;" & gStr_NomEmpresa, "pCajero;" & txt_cajero.Text.Trim, "pTurno;" & uce_turno.Text, "pFecha;" & CDate(ume_fecha.Value).ToShortDateString)
        crystalBL = Nothing

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try



    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click
        Call Procesar_Reporte()
    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_cajero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cajero.ValueChanged

    End Sub

    Private Sub ume_fecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Call Procesar_Reporte()
            uce_turno.Focus()
        End If
    End Sub
End Class