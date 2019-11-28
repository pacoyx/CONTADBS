Public Class CO_RP_Char2

    Private Sub CO_PR_Char2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_TiposAnexos()
        Call Formatear_Grilla_Selector(ug_anexos)
    End Sub

    Private Sub Cargar_TiposAnexos()
        Try
            Dim TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO

            uce_TiposAnexos.DataSource = TipoAnexoBL.getTipoAnexos()
            uce_TiposAnexos.DisplayMember = "TA_DESCRIPCION"
            uce_TiposAnexos.ValueMember = "TA_CODIGO"

            TipoAnexoBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Anexo_x_tipo_de_Anexo()
        Try
            Dim AnexosBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim AnexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

            AnexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TiposAnexos.Value}
            AnexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            ug_anexos.DataSource = AnexosBL.getAnexos_DT(AnexoBE)

            AnexoBE = Nothing
            AnexosBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_TiposAnexos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TiposAnexos.ValueChanged
        Call Cargar_Anexo_x_tipo_de_Anexo()
    End Sub


    Private Sub ug_anexos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_anexos.DoubleClickRow
        Try
            If ug_anexos.ActiveRow.Index < 0 Then Exit Sub

            Dim ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim Int_Anexo As Integer = ug_anexos.ActiveRow.Cells("AN_IDANEXO").Value
            UltraChart1.Data.DataSource = ReporteBL.getEstadistico_mov_mensual_x_anexo(Int_Anexo, gInt_IdEmpresa, gDat_Fecha_Sis.Year)
            UltraChart1.Data.DataBind()
            ReporteBL = Nothing
            UltraChart1.Visible = True
            UltraChart1.TitleTop.Text = "Movimiento del " & uce_TiposAnexos.Text & " " & ug_anexos.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class