Public Class FA_PR_AgregarSeries

    Public IdPuntoVenta As String


    Private Sub FA_PR_AgregarSeries_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Series()
        Call Cargar_Documentos()
        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        uce_TipoDoc.DataSource = documentosBL.get_Docs_Facturacion(gInt_IdEmpresa)
        uce_TipoDoc.DisplayMember = "DO_ABREVIATURA"
        uce_TipoDoc.ValueMember = "DO_CODIGO"
        documentosBL = Nothing
    End Sub

    Private Sub Cargar_Series()
        Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
        Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

        seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = IdPuntoVenta}
        seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        ug_Lista.DataSource = seriesBL.get_Lista_Series(seriesBE)

        seriesBE = Nothing
        seriesBL = Nothing

    End Sub

    Private Sub ubtn_Agregar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Agregar.Click

        If txt_serie.Text.Trim = String.Empty Then
            Avisar("Ingrese la serie")
            txt_serie.Focus()
            Exit Sub
        End If


        For i As Integer = 0 To ug_Lista.Rows.Count - 1
            If ug_Lista.Rows(i).Cells("PS_SERIE").Value = txt_serie.Text.Trim And ug_Lista.Rows(i).Cells("PS_TD").Value = uce_TipoDoc.Value Then
                Avisar("La serie ya esta Registrada")
                Exit Sub
            End If
        Next


        Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
        Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

        seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = IdPuntoVenta}
        seriesBE.PS_SERIE = txt_serie.Text.Trim
        seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        seriesBE.PS_TD = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}

        seriesBL.Insert(seriesBE)

        seriesBE = Nothing
        seriesBL = Nothing

        ug_Lista.DisplayLayout.Bands(0).AddNew()
        ug_Lista.Rows(ug_Lista.Rows.Count - 1).Cells("PS_SERIE").Value = txt_serie.Text.Trim
        ug_Lista.Rows(ug_Lista.Rows.Count - 1).Cells("PS_TD").Value = uce_TipoDoc.Value
        ug_Lista.Rows(ug_Lista.Rows.Count - 1).Cells("DO_ABREVIATURA").Value = uce_TipoDoc.Text

        ug_Lista.UpdateData()

        txt_serie.Text = String.Empty
        txt_serie.Focus()


    End Sub

    Private Sub ubtn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_eliminar.Click


        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de Eliminar?") Then

            Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
            Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

            seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = IdPuntoVenta}
            seriesBE.PS_SERIE = ug_Lista.ActiveRow.Cells("PS_SERIE").Value
            seriesBE.PS_TD = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_Lista.ActiveRow.Cells("PS_TD").Value}
            seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            seriesBL.Delete(seriesBE)

            seriesBE = Nothing
            seriesBL = Nothing

            ug_Lista.ActiveRow.Delete()

        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_serie_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_serie.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Agregar.Focus()
        End If
    End Sub

    Private Sub ug_Lista_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Lista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub
End Class