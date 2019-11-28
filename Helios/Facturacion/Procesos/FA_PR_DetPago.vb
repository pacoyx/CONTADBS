Imports Infragistics.Win.UltraWinGrid

Public Class FA_PR_DetPago

    Public pComprobante As String = ""
    Public pImporte As Double = 0
    Public pIdComprobante As Integer = 0

    Private Sub FA_PR_DetPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_Des_Cliente.Text = pComprobante
        ume_total.Value = pImporte
        Call Cargar_DocumentoPago()

        ume_total_det.Value = 0.0

        Call Cargar_Detalle()
        Call Sumar_detalles()

        ubtn_aceptar.Appearance.Image = My.Resources._003

        ug_detalle.Rows(0).Cells("Importe").Activate()
        ug_detalle.Focus()
        ug_detalle.PerformAction(UltraGridAction.ToggleEditMode, False, False)
        SendKeys.Send(Keys.F2)
        SendKeys.Send(Keys.F2)


    End Sub

    Private Sub Cargar_Detalle()
        If pIdComprobante = 0 Then Exit Sub

        Dim reporteBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim dt_detalle As DataTable = reporteBL.get_Detalle_Pago_x_IdCompro(pIdComprobante)

        For Each fdet As DataRow In dt_detalle.Rows

            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells("DP_CODIGO").Value = fdet.Item("CD_IDDOCPAGO") Then
                    ug_detalle.Rows(i).Cells("Importe").Value = fdet.Item("CD_IMPORTE")
                End If
            Next

        Next

    End Sub

    Private Sub Cargar_DocumentoPago()

        Dim docPago As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
        Dim dt_tmp As DataTable = docPago.get_DocuPagos(gInt_IdEmpresa)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(i).Cells("DP_CODIGO").Value = dt_tmp.Rows(i)("DP_CODIGO")
            ug_detalle.Rows(i).Cells("DP_DESCRIPCION").Value = dt_tmp.Rows(i)("DP_DESCRIPCION")
            ug_detalle.Rows(i).Cells("Importe").Value = 0
        Next

        ug_detalle.UpdateData()

    End Sub

    Private Sub Sumar_detalles()
        Dim total As Double = 0

        ug_detalle.UpdateData()

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells("Importe").Value.ToString <> "" Then
                total += ug_detalle.Rows(i).Cells("Importe").Value
            End If
        Next
        ume_total_det.Value = total

    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click

        If ume_total.Value <> ume_total_det.Value Then
            Avisar("El monto detallado debe ser igual al monto del comprobante")
            Exit Sub
        End If


        Dim detalleBE As BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO
        Dim detalleBL As New BL.FacturacionBL.SG_FA_TB_COMPRO_DOCPAGO
        Dim ls_lista As New List(Of BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO)

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells("Importe").Value > 0 Then
                detalleBE = New BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO
                With detalleBE
                    .CD_IDCOMPROBANTE = pIdComprobante
                    .CD_IDDOCPAGO = ug_detalle.Rows(i).Cells("DP_CODIGO").Value.ToString
                    .CD_IMPORTE = ug_detalle.Rows(i).Cells("Importe").Value
                    .CD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .CD_PC = Environment.MachineName
                    .CD_FECREG = Date.Now
                End With
                ls_lista.Add(detalleBE)
            End If
        Next
        

        detalleBL.Insert(ls_lista)

        Call Avisar("Listo")
        Me.Close()

    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub ug_detalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Sumar_detalles()
            With ug_detalle
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
            End With
            If ug_detalle.ActiveRow.Index = ug_detalle.Rows.Count - 1 Then
                ubtn_aceptar.Focus()
            End If
        End If


        If e.KeyCode = Keys.Delete Then
            ug_detalle.ActiveRow.Cells("Importe").Value = 0.0
        End If

    End Sub

End Class