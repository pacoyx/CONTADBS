Public Class FA_RE_VentasxCajero

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim reportesfaBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable

        Dim dt_ordenado As New DataTable
        Dim dv_ordenado As New DataView
        Dim str_orden As String = String.Empty

        str_orden = uce_ordenado.Value.ToString & " " & uos_orden.Value.ToString
        dt_data = reportesfaBL.get_Reg_Ventas_x_Cajero(uce_Cajero.Value, gInt_IdEmpresa)

        dv_ordenado = dt_data.DefaultView
        dv_ordenado.Sort = str_orden
        dt_ordenado = dv_ordenado.ToTable

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_05.RPT", dt_ordenado, "", "pEmp;" & gStr_NomEmpresa)

        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FA_RE_VentasxCajero_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Cajeros()
        uce_ordenado.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Cajeros()

        Dim cajeroBL As New BL.FacturacionBL.SG_FA_TB_CAJERO
        uce_Cajero.DataSource = cajeroBL.get_Cajeros(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_Cajero.DisplayMember = "CA_NOMBRES"
        uce_Cajero.ValueMember = "CA_ID"
        cajeroBL = Nothing

    End Sub


End Class