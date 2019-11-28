Public Class CO_PR_GeneraITFMes

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub CO_PR_GeneraITFMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        Tool_Grabar.Enabled = False
        uce_Mes.Value = gDat_Fecha_Sis.Month
        Call CargarBanco()
        Call Formatear_Grilla_Selector(ug_itf)

    End Sub

    Private Sub CargarBanco()
        Dim cuentasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim cuentasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        Dim Dt_cuentas As DataTable = Nothing
        cuentasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        cuentasBE.PC_PERIODO = une_Ayo.Value
        cuentasBE.PC_IDTIPO_MOV_DET = New BE.ContabilidadBE.SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = 3}
        Dt_cuentas = cuentasBL.getCuentas_Movimiento_Tipo_Caja_Bancos(cuentasBE)

        For i As Integer = 0 To Dt_cuentas.Rows.Count - 1
            With Dt_cuentas.Rows(i)
                uce_banco.Items.Add(.Item("IDCUENTA"), .Item("CUENTA") & " - " & .Item("DESCRIPCION"))
            End With
        Next

        Dt_cuentas.Dispose()
        cuentasBE = Nothing
        cuentasBL = Nothing

    End Sub

    Private Sub Tool_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim fechaVou As Date = ObtenerUltimoDia("01/" & uce_Mes.Value & "/" & une_Ayo.Value)
            AsientoBL.Generar_Asiento_ITF_Mensual(gInt_IdEmpresa, une_Ayo.Value, uce_Mes.Value, ume_tot_itf.Value, fechaVou, gStr_Usuario_Sis, uce_banco.Value)
            AsientoBL = Nothing
            Avisar("Listo!")
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Generar.Click
        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Try

            If uce_Mes.SelectedIndex = -1 Then
                Avisar("Seleccione un mes")
                uce_Mes.Focus()
                Exit Sub
            End If

            If uce_banco.SelectedIndex = -1 Then
                Avisar("Seleccione un banco")
                uce_banco.Focus()
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim dt_data As DataTable = AsientoBL.getMov_Bancos_Calcular_ITF(gInt_IdEmpresa, une_Ayo.Value, uce_Mes.Value, uce_banco.Value)

            ug_itf.DataSource = dt_data
            Tool_Grabar.Enabled = True

            AsientoBL = Nothing

            ume_tot_debito.Value = 0
            ume_tot_itf.Value = 0
            ume_tot_itf_debito.Value = 0
            ume_tot_itf_credito.Value = 0

            If dt_data.Rows.Count > 0 Then
                ume_tot_debito.Value = dt_data.Compute("sum(DEBITO)", "")
                ume_total_credito.Value = dt_data.Compute("sum(CREDITO)", "")
                ume_tot_itf_debito.Value = dt_data.Compute("sum(ITF_2DEC)", "DEBITO > 0")
                ume_tot_itf_credito.Value = dt_data.Compute("sum(ITF_2DEC)", "CREDITO > 0")
                ume_tot_itf.Value = dt_data.Compute("sum(ITF_2DEC)", "")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub ug_itf_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_itf.InitializeLayout

    End Sub

    Private Sub uce_banco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_banco.ValueChanged
        Tool_Calcular_Click(sender, e)
    End Sub
End Class