Public Class CO_RP_Char4

    Private Sub CO_PR_Char4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_CentroCostos()

        Me.trackBar1.Value = Fix(Me.uchart_2.Transform3D.XRotation)
        Me.trackBar2.Value = Fix(Me.uchart_2.Transform3D.YRotation)
        Me.trackBar3.Value = Fix(Me.uchart_2.Transform3D.ZRotation)

        Me.lblX.Text = String.Format("X Grados del Eje: {0}", Me.uchart_2.Transform3D.XRotation.ToString())
        Me.lblY.Text = String.Format("Y Grados del Eje: {0}", Me.uchart_2.Transform3D.YRotation.ToString())
        Me.lblZ.Text = String.Format("Z Grados del Eje: {0}", Me.uchart_2.Transform3D.ZRotation.ToString())
        utc_Chars.Tabs(0).Selected = True
        Call Cargar_Rep_Estadistico()
    End Sub

    Private Sub Cargar_CentroCostos()
        Try
            uce_CC.Items.Add("90", "FERTILIDAD")
            uce_CC.Items.Add("91", "GINECOLOGIA")
            uce_CC.Items.Add("92", "OBSTETRICIA")
            uce_CC.Items.Add("93", "CIRUGIA PLASTICA")
            uce_CC.Items.Add("94", "CIRUGIA CARDIOVASCULAR")
            uce_CC.Items.Add("95", "TRAUMATOLOGIA")
            uce_CC.Items.Add("96", "NEONATOLOGIA")
            uce_CC.Items.Add("97", "OTRAS INTERVENCIONES - LABORATORIO")
            uce_CC.Items.Add("98", "ADMINISTRATIVO")
            uce_CC.Items.Add("99", "GASTOS NO DEDUCIBLES")
            uce_CC.SelectedIndex = -1

            For i As Integer = 0 To uce_CC.Items.Count - 1
                ug_CenCost.DisplayLayout.Bands(0).AddNew()
                ug_CenCost.Rows(i).Cells("Sel").Value = True
                ug_CenCost.Rows(i).Cells("Codigo").Value = CType(uce_CC.Items.GetItem(i), Infragistics.Win.ValueListItem).DataValue
                ug_CenCost.Rows(i).Cells("Nombre").Value = CType(uce_CC.Items.GetItem(i), Infragistics.Win.ValueListItem).DisplayText
            Next

            ug_CenCost.UpdateData()
            ug_CenCost.Rows(0).Selected = True

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ups_opc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uos_opc.ValueChanged
        If uos_opc.Value = "1" Then
            uce_CC.Enabled = False
            Call Cargar_Rep_Estadistico()
        Else
            uce_CC.Enabled = True
            If uce_CC.SelectedIndex = -1 Then uce_CC.SelectedIndex = 0
            Call Cargar_Rep_Estadistico()
        End If
    End Sub

    Private Sub Cargar_Rep_Estadistico()
        Try
            Dim ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            If uos_opc.Value = "1" Then 'Anual
                If uos_tipo.Value = 0 Then
                    uchart_1.Data.DataSource = ReporteBL.getEstadistico_Mov_Anual_de_centroCostos(gDat_Fecha_Sis.Year, gInt_IdEmpresa)
                    uchart_1.TitleTop.Text = "Movimiento Anual de Centro de Costos"
                Else
                    uchart_2.Data.DataSource = ReporteBL.getEstadistico_Mov_Anual_de_centroCostos_3D(gDat_Fecha_Sis.Year, gInt_IdEmpresa)
                    uchart_2.TitleTop.Text = "Movimiento Anual de Centro de Costos"
                End If

            Else 'Por Centro de Costo

                If uos_tipo.Value = 0 Then
                    uchart_1.Data.DataSource = ReporteBL.getEstadistico_Mov_Anual_x_CentroCosto(gDat_Fecha_Sis.Year, uce_CC.Value, gInt_IdEmpresa)
                    uchart_1.TitleTop.Text = "Movimiento Anual de : " & uce_CC.Value & " - " & uce_CC.Text
                Else
                    uchart_2.Data.DataSource = ReporteBL.getEstadistico_Mov_Anual_x_CentroCosto(gDat_Fecha_Sis.Year, uce_CC.Value, gInt_IdEmpresa)
                    uchart_2.TitleTop.Text = "Movimiento Anual de : " & uce_CC.Value & " - " & uce_CC.Text
                End If

            End If

            ReporteBL = Nothing
            uchart_2.Visible = True
            uchart_1.Visible = True

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_CC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_CC.ValueChanged
        If uos_opc.Value = "2" Then
            Call Cargar_Rep_Estadistico()
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub trackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll
        Me.uchart_2.Transform3D.XRotation = Me.trackBar1.Value
        Me.lblX.Text = String.Format("X Grados del Eje: {0}", Me.trackBar1.Value.ToString())
    End Sub

    Private Sub trackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar2.Scroll
        Me.uchart_2.Transform3D.YRotation = Me.trackBar2.Value
        Me.lblY.Text = String.Format("Y Grados del Eje: {0}", Me.trackBar2.Value.ToString())
    End Sub

    Private Sub trackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar3.Scroll
        Me.uchart_2.Transform3D.ZRotation = Me.trackBar3.Value
        Me.lblZ.Text = String.Format("Z Grados del Eje: {0}", Me.trackBar3.Value.ToString())
    End Sub

    Private Sub uos_tipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_tipo.ValueChanged
        If uos_opc.Value = "2" Then
            If uce_CC.SelectedIndex = -1 Then
                uce_CC.SelectedIndex = 0
            End If
        End If

        If uos_tipo.Value = 0 Then
            ugb_ejes.Enabled = False
            MostrarTabs(0, utc_Chars, 0)
            'utc_Chars.Tabs(0).Selected = True
            'utc_Chars.Tabs(1).Enabled = False
            Call Cargar_Rep_Estadistico()
        Else
            ugb_ejes.Enabled = True
            MostrarTabs(1, utc_Chars, 1)
            'utc_Chars.Tabs(1).Selected = True
            'utc_Chars.Tabs(0).Enabled = False
            Call Cargar_Rep_Estadistico()
        End If

    End Sub

    Private Sub ug_CenCost_ClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles ug_CenCost.ClickCell
        If e.Cell.Column.Index = 0 Then
            Dim Dt_data As DataTable
            Try
                Dim ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
                If uos_opc.Value = "1" Then 'Anual
                    If uos_tipo.Value = 0 Then '2D
                        Dt_data = ReporteBL.getEstadistico_Mov_Anual_de_centroCostos(gDat_Fecha_Sis.Year, gInt_IdEmpresa)
                        uchart_1.TitleTop.Text = "Movimiento Anual de Centro de Costos"
                    Else        '3D
                        Dt_data = ReporteBL.getEstadistico_Mov_Anual_de_centroCostos_3D(gDat_Fecha_Sis.Year, gInt_IdEmpresa)
                        uchart_2.TitleTop.Text = "Movimiento Anual de Centro de Costos"

                        ug_CenCost.UpdateData()
                        For j As Integer = 0 To ug_CenCost.Rows.Count - 1
                            If ug_CenCost.Rows(j).Cells("Sel").Value = False Then
                                Dim centro As String = ug_CenCost.Rows(j).Cells("nombre").Value
                                For i As Integer = 0 To Dt_data.Rows.Count - 1
                                    If Dt_data.Rows(i)("CENTROCOSTO") = centro Then
                                        For z As Integer = 1 To 12
                                            Dt_data.Rows(i)(z) = 0
                                        Next
                                    End If
                                Next
                            End If
                        Next
                    End If

                    uchart_2.Data.DataSource = Dt_data
                End If

                ReporteBL = Nothing
                uchart_2.Visible = True
                uchart_1.Visible = True

            Catch ex As Exception
                ShowError(ex.Message)
            End Try
        End If
    End Sub
End Class