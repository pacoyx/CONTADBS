Public Class FA_RE_RankingVentas

    Private Sub FA_RE_RankingVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Me.Cursor = Cursors.WaitCursor

        Dim reportesfaBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable

        dt_data = reportesfaBL.get_Reg_RankingVentas(gInt_IdEmpresa)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_08.RPT", dt_data, "", "pEmp;" & gStr_NomEmpresa)

        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub
End Class