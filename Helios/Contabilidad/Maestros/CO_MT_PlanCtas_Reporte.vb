Public Class CO_MT_PlanCtas_Reporte

    Private Sub CO_MT_PlanCtas_Reporte_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        uc_Cuentas1.Focus()
    End Sub

    Private Sub CO_MT_PlanCtas_Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        Call Cargar_Cuentas_Combo()
        uc_Cuentas1.Value = Nothing
        uc_Cuentas2.Value = Nothing
    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        PlanCtasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        PlanCtasBE.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas1.DataSource = PlanCtasBL.getCuentas_DT(PlanCtasBE)
        uc_Cuentas2.DataSource = PlanCtasBL.getCuentas_DT(PlanCtasBE)

        PlanCtasBE = Nothing
        PlanCtasBL = Nothing

    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub uc_Cuentas1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas1.KeyDown
        If e.KeyCode = Keys.Enter Then
            uc_Cuentas2.Focus()
        End If
    End Sub

    Private Sub uc_Cuentas2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Imprimir.Focus()
        End If
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Dim dt_tmp As DataTable = Nothing

        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        dt_tmp = reporteBL.get_PlanCtas_1(uc_Cuentas1.Text, uc_Cuentas2.Text, txt_Ayo.Text.Trim.Trim, gInt_IdEmpresa)

        Dim CristalBL As New LR.ClsReporte
        CristalBL.Muestra_Reporte(gStr_RutaRep & "\SG_CO_23.RPT", dt_tmp, "", "pCuentaIni;" & uc_Cuentas1.Text, "pCuentaFin;" & uc_Cuentas2.Text, "pEmpresa;" & gStr_NomEmpresa)
        Me.Cursor = Cursors.Default
    End Sub
End Class