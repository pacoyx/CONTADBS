Public Class FA_RE_VentasxCliente

    Private Sub FA_RE_VentasxCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        uce_ordenado.SelectedIndex = 0
    End Sub

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
        dt_data = reportesfaBL.get_Reg_Ventas_x_Cliente(txt_IdCliente.Text.Trim, gInt_IdEmpresa)

        dv_ordenado = dt_data.DefaultView
        dv_ordenado.Sort = str_orden
        dt_ordenado = dv_ordenado.ToTable

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_04.RPT", dt_ordenado, "", "pEmp;" & gStr_NomEmpresa)

        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ayuda_Anexo_Cab()
        FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaClientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(1)
            txt_Des_Cliente.Text = matriz(2)
        End If

        matriz = Nothing

    End Sub

    Private Sub txt_ruc_cliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Anexo_Cab()
        End If
    End Sub

    Private Sub txt_ruc_cliente_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
        Call Ayuda_Anexo_Cab()
    End Sub

    Private Sub txt_ruc_cliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_ruc_cliente.TextChanged
        If txt_ruc_cliente.Text.Length = 0 Then
            txt_IdCliente.Clear()
            txt_Des_Cliente.Clear()
        End If
    End Sub
End Class