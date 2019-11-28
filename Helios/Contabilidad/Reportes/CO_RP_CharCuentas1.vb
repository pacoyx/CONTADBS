Public Class CO_RP_CharCuentas1

    Private Sub CO_PR_CharCuentas1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Formatear_Grilla_Selector(ug_cuentas)
        Call CargarCuentas()
    End Sub

    Private Sub CargarCuentas()
        Try
            Dim CuentaBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim CuentaBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            With CuentaBE
                .PC_PERIODO = gDat_Fecha_Sis.Year
                .PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            ug_cuentas.DataSource = CuentaBL.getCuentas_Movimiento(CuentaBE)

            CuentaBL = Nothing
            CuentaBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_cuentas_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_cuentas.DoubleClickRow
        Try
            If ug_cuentas.ActiveRow.Index < 0 Then
                Exit Sub
            End If

            Dim ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim cuenta As Integer = ug_cuentas.ActiveRow.Cells("PC_IDCUENTA").Value
            UltraChart1.Data.DataSource = ReporteBL.getEstadistico_cta_x_mes(cuenta, gInt_IdEmpresa, gDat_Fecha_Sis.Year)
            UltraChart1.Data.DataBind()
            ReporteBL = Nothing
            UltraChart1.Visible = True
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class