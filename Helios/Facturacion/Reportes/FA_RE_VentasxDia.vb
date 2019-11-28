Public Class FA_RE_VentasxDia

    Private Sub FA_RE_VentasxDia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uce_ordenado.SelectedIndex = 0
        ume_fecha.Value = gDat_Fecha_Sis
    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        If ume_fecha.Value.ToString = String.Empty Then
            Avisar("Ingrese una fecha valida.")
            ume_fecha.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim reportesfaBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        Dim dt_ordenado As New DataTable
        Dim dv_ordenado As New DataView
        Dim str_orden As String = String.Empty

        str_orden = uce_ordenado.Value.ToString & " " & uos_orden.Value.ToString

        If uchk_otro.Checked Then
            dt_data = reportesfaBL.get_Reg_Ventas_x_Dia_2(CDate(ume_fecha.Value), gInt_IdEmpresa)
        Else
            dt_data = reportesfaBL.get_Reg_Ventas_x_Dia(CDate(ume_fecha.Value), gInt_IdEmpresa)
        End If

        dv_ordenado = dt_data.DefaultView
        dv_ordenado.Sort = str_orden
        dt_ordenado = dv_ordenado.ToTable

        If uchk_otro.Checked Then
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_03_2.RPT", dt_ordenado, "", "pEmp;" & gStr_NomEmpresa, "pFecha;Fecha : " & CDate(ume_fecha.Value).ToShortDateString)
        Else
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_03.RPT", dt_ordenado, "", "pEmp;" & gStr_NomEmpresa)
        End If

        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ume_fecha_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then Call Tool_imprimir_Click(sender, e)
    End Sub
End Class