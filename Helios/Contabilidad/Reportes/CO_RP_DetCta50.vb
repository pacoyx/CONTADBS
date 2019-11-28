Imports Infragistics.Win.UltraWinGrid

Public Class CO_RP_DetCta50

    Public bol_Aceptar As Boolean = False

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        'Grabamos la cabecera
        reporteBL.set_Grabar_Cabecera_DetCta50(gDat_Fecha_Sis.Year, ume_1.Value, ume_2.Value, ume_3.Value, ume_4.Value, ume_5.Value, gInt_IdEmpresa)



        'Grabamos el detalle
        ug_detalle.UpdateData()
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            With ug_detalle.Rows(i)
                If Not .Cells("RD_TIPO_DOC").Value.ToString = "" Then
                    reporteBL.set_Grabat_Detalle_DetCta50(gDat_Fecha_Sis.Year, gInt_IdEmpresa, .Cells("RD_TIPO_DOC").Value.ToString, .Cells("RD_NUM_DOC").Value, .Cells("RD_RAZON").Value, .Cells("RD_TIPO_ACCION").Value, .Cells("RD_NUM_ACCIONES").Value, .Cells("RD_POR_ACCIONES").Value)
                End If

            End With
        Next

        bol_Aceptar = True
        Me.Close()
        reporteBL = Nothing

    End Sub

    Private Sub ug_detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False

    End Sub

    Private Sub CO_RP_DetCta50_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ayo.Text = gDat_Fecha_Sis.Year.ToString
        txt_empresa.Text = gStr_NomEmpresa

        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dt_tmp As DataTable = Nothing

        'cargamos datos de la cabecera
        dt_tmp = reporteBL.get_Grabar_Cabecera_DetCta50(gDat_Fecha_Sis.Year, gInt_IdEmpresa)

        If dt_tmp.Rows.Count > 0 Then
            ume_1.Value = dt_tmp.Rows(0)("RC_CS")
            ume_2.Value = dt_tmp.Rows(0)("RC_VN")
            ume_3.Value = dt_tmp.Rows(0)("RC_NA1")
            ume_4.Value = dt_tmp.Rows(0)("RC_NA2")
            ume_5.Value = dt_tmp.Rows(0)("RC_NA3")
        End If


        'cargamos datos del detalle
        dt_tmp = reporteBL.get_Grabat_Detalle_DetCta50(gDat_Fecha_Sis.Year, gInt_IdEmpresa)

        Call LimpiaGrid(ug_detalle, uds_detalle)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(i).Cells("RD_TIPO_DOC").Value = dt_tmp.Rows(i)("RD_TIPO_DOC")
            ug_detalle.Rows(i).Cells("RD_NUM_DOC").Value = dt_tmp.Rows(i)("RD_NUM_DOC")
            ug_detalle.Rows(i).Cells("RD_RAZON").Value = dt_tmp.Rows(i)("RD_RAZON")
            ug_detalle.Rows(i).Cells("RD_TIPO_ACCION").Value = dt_tmp.Rows(i)("RD_TIPO_ACCION")
            ug_detalle.Rows(i).Cells("RD_NUM_ACCIONES").Value = dt_tmp.Rows(i)("RD_NUM_ACCIONES")
            ug_detalle.Rows(i).Cells("RD_POR_ACCIONES").Value = dt_tmp.Rows(i)("RD_POR_ACCIONES")
        Next

        ug_detalle.UpdateData()
        ug_detalle.DisplayLayout.Bands(0).AddNew()

        dt_tmp = Nothing
        reporteBL = Nothing

    End Sub

    Private Sub ume_1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_1.KeyDown, ume_5.KeyDown, ume_4.KeyDown, ume_3.KeyDown, ume_2.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ug_detalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
        End If
    End Sub
End Class