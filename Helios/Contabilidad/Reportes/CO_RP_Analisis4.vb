Public Class CO_RP_Analisis4

    Private Sub CO_PR_Analisis4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Cuentas_Combo()
        Call CargarCombo_ConMeses(uce_Mes)
        Call CargarCombo_ConMeses(uce_Mes2)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = 1
        uce_Mes2.Value = gDat_Fecha_Sis.Month
        uce_nivel.Value = 6
    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas1.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)
        uc_Cuentas2.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)

        E_PlanCtas = Nothing
        Obj_PlanCtasBL = Nothing


    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Bol_masRapido As Boolean = True
        Dim dt_tmp As DataTable = Nothing


        If Bol_masRapido Then
            Me.Cursor = Cursors.WaitCursor

            If uce_nivel.SelectedIndex = -1 Then
                Avisar("Seleccione un nivel")
                uce_nivel.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            reporteBL.Set_Cuentas_Rango_a_Tmp(uc_Cuentas1.Text, uc_Cuentas2.Text, txt_Ayo.Text.Trim, Environment.MachineName, gInt_IdEmpresa)
            dt_tmp = reporteBL.get_Reporte_Mov_Anual_x_Cuenta_V2(uce_nivel.Value, txt_Ayo.Text, Environment.MachineName, gInt_IdEmpresa)

        Else

            Dim lis_imp_x_mes As New List(Of Double)
            Dim listado_ctas As List(Of String) = reporteBL.get_Cuentas_x_Rango(uc_Cuentas1.Text, uc_Cuentas2.Text, txt_Ayo.Text.Trim, gInt_IdEmpresa)

            upb_reporte.Minimum = 0
            upb_reporte.Maximum = listado_ctas.Count + 1
            upb_reporte.Value = 0


            upb_reporte.Visible = True


            reporteBL.Limpiar_Tabla_Reporte("SG_CO_TB_MOV_ANUAL_CTAS", " where pc = '" & Environment.MachineName & "'")
            lis_imp_x_mes.Clear()
            For Each cuenta As String In listado_ctas

                lis_imp_x_mes.Clear()
                For i As Integer = 1 To 12
                    If i >= uce_Mes.Value And i <= uce_Mes2.Value Then
                        lis_imp_x_mes.Add(reporteBL.get_Mov_Anual_x_Cuenta(txt_Ayo.Text.Trim, i, cuenta, gInt_IdEmpresa))
                    Else
                        lis_imp_x_mes.Add(0)
                    End If
                Next

                reporteBL.Insert_Mov_Anual_x_Cuenta(cuenta, lis_imp_x_mes, Environment.MachineName)

                upb_reporte.IncrementValue(1)
            Next
            upb_reporte.Visible = False

            dt_tmp = reporteBL.get_Reporte_Mov_Anual_x_Cuenta(txt_Ayo.Text.Trim, gInt_IdEmpresa)

        End If

        reporteBL = Nothing

        Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        EmpresaBL.getEmpresas_2(EmpresaBE)

        Dim CristalBL As New LR.ClsReporte
        CristalBL.Muestra_Reporte(gStr_RutaRep & "\SG_CO_20.RPT", dt_tmp, "", "pMesIni;" & uce_Mes.Text, "pMesFin;" & uce_Mes2.Text, "pCuentaIni;" & uc_Cuentas1.Text, "pCuentaFin;" & uc_Cuentas2.Text, "pEmpresa;" & EmpresaBE.EM_NOMBRE)
        Me.Cursor = Cursors.Default


        EmpresaBE = Nothing
        EmpresaBL = Nothing
        CristalBL = Nothing

    End Sub

    Private Sub uc_Cuentas1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas1.KeyDown
        If e.KeyCode = Keys.Enter Then
            uc_Cuentas2.Focus()
        End If
    End Sub

    Private Sub uc_Cuentas2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas2.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_Mes.Focus()
        End If
    End Sub

    Private Sub uce_Mes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Mes.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_Mes2.Focus()
        End If
    End Sub

    Private Sub uce_Mes2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Mes2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Imprimir.Focus()
        End If
    End Sub
End Class