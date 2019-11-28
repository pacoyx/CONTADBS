Public Class FA_RE_RegVentas

    Private Sub FA_RE_RegVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim reportesfaBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        Dim periodo As String = txt_Ayo.Text & " / " & uce_Mes.Text

        dt_data = reportesfaBL.get_Reg_Venta(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa)
        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_02.RPT", dt_data, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & periodo)
        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub
End Class