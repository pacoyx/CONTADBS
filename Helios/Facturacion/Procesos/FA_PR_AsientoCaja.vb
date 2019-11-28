Public Class FA_PR_AsientoCaja

    Private Sub FA_PR_AsientoCaja_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'ubtn_Cargar.Appearance.Image = My.Resources._16__Build_


    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Cargar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Cargar.Click
        Call Cargar_Comprobantes()
    End Sub

    Private Sub Cargar_Comprobantes()

        If ume_fecha.Value Is Nothing Then Exit Sub

        Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C

        If uchk_Anulados.Checked Then
            ug_Lista.DataSource = comprobantesBL.get_Lista_x_Fecha_Todo(CDate(ume_fecha.Value).ToShortDateString, gInt_IdEmpresa)
        Else
            ug_Lista.DataSource = comprobantesBL.get_Lista_x_Fecha_SoloActivos(CDate(ume_fecha.Value).ToShortDateString, gInt_IdEmpresa)
        End If


        comprobantesBL = Nothing


    End Sub

    Private Sub ume_fecha_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Cargar.Focus()
        End If
    End Sub

    Private Sub Tool_Generar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Generar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub

        Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim str_Num_voucher As String = String.Empty

        Try
            Me.Cursor = Cursors.WaitCursor

            comprobanteBL.Generar_Asiento_Caja(ume_fecha.Value, gInt_IdEmpresa, gStr_Usuario_Sis, str_Num_voucher)
            comprobanteBL = Nothing

            txt_numVoucherCaja.Text = str_Num_voucher
            Call Cargar_Comprobantes()
            Call Avisar("Listo!")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Avisar("Ocurrio un error :" & ex.Message)
            Me.Cursor = Cursors.Default
        End Try
        

    End Sub

    Private Sub ug_Lista_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Lista.InitializeRow
        If e.Row.Cells("CO_ESTADO").Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub
End Class