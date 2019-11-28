Imports Infragistics.Win.UltraWinGrid

Public Class CO_MT_TipoCambio


    Dim Dt_tc As DataTable
    Dim dv As DataView
    Const Int_Moneda As Integer = 2
    Dim Obj_TipCamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO

    Private Sub CO_MT_TipoCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo()
        Call CargarDatos()

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            Dim cambios As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            Dim cambioBE As BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            For i As Integer = 0 To ug_ListaTc.Rows.Count - 1
                cambioBE = New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

                cambioBE.TC_FECHA = ug_ListaTc.Rows(i).Cells("Fecha").Value
                cambioBE.TC_COMPRA = ug_ListaTc.Rows(i).Cells("Compra").Value
                cambioBE.TC_VENTA = ug_ListaTc.Rows(i).Cells("Venta").Value
                cambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                cambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = Int_Moneda}
                cambioBE.TC_TERMINAL = Environment.MachineName
                cambioBE.TC_FECREG = Date.Now
                cambioBE.TC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)

                cambios.Add(cambioBE)
            Next

            Obj_TipCamBL.Insert(cambios)

            Avisar("Listo")

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_Imprimir.Click

        Dim TipoCambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

        TipoCambioBE.TC_FECHA = "01/" & (uce_Mes.Value).ToString.PadLeft("2", "0") & "/" & gDat_Fecha_Sis.Year.ToString
        TipoCambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        TipoCambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}

        Dim dt_tmp As DataTable = Obj_TipCamBL.getTipoCambios_Dt(TipoCambioBE)
        Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        EmpresaBL.getEmpresas_2(EmpresaBE)

        Dim reporteBL As New LR.ClsReporte
        reporteBL.Muestra_Reporte(gStr_RutaRep & "\sg_co_21.rpt", dt_tmp, "", "pEmpresa;" & EmpresaBE.EM_NOMBRE, "pPeriodo;" & une_Ayo.Value.ToString, "pMes;" & uce_Mes.Text)

        TipoCambioBE = Nothing
        reporteBL = Nothing
        EmpresaBE = Nothing
        EmpresaBL = Nothing


    End Sub

    Private Sub tool_Copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_Copiar.Click
        CO_MT_TCamb_Copy.ShowDialog()

    End Sub

    Private Sub tool_Web_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_Web.Click
        'CO_MT_TCamb_Web.MdiParent = CO_MN_MenuPrincipal
        CO_MT_TCamb_Web.Show()
    End Sub
    Private Sub CargarCombo()

        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

    End Sub

    Private Sub CargarDatos()
        Try


            Dim E_TC As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
            E_TC.TC_FECHA = "01/" & (uce_Mes.Value).ToString.PadLeft("2", "0") & "/" & gDat_Fecha_Sis.Year.ToString
            E_TC.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_TC.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}

            Dt_tc = Obj_TipCamBL.getTipoCambios_Dt(E_TC)
            GetTheTable(E_TC.TC_FECHA)

            dv = New DataView(Dt_tc)
            dv.Sort = "Fecha"
            ug_ListaTc.DataSource = dv

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub GetTheTable(ByVal varFecha As String)

        Dim nCols As Integer = 4
        'Dim nRows As Integer = DateTime.DaysInMonth(Year(STRfecha), Month(STRfecha))
        Dim nRows As Integer = DateTime.DaysInMonth(Year(varFecha), Month(varFecha))
        Dim i As Integer, INTdia As Integer

        INTdia = 1
        Dt_tc.Columns("Fecha").ReadOnly = True
        'Dt_tc.Columns("Moneda").ReadOnly = True


        For i = 0 To nRows
            Dim x As Integer = Dt_tc.Rows.Count
            Dim j As Integer
            Dim b As String = String.Format(Format(INTdia, "00") & "/" & Format(uce_Mes.SelectedIndex + 1, "00") & "/" & Format(gDat_Fecha_Sis.Year), i, j)
            Dim row() As DataRow = Dt_tc.Select("Fecha = '" & b & "'")

            If row.Length = 0 Then
                Dim dr As DataRow = Dt_tc.NewRow()
                dr(0) = b
                dr(1) = 0
                dr(2) = 0

                Dt_tc.Rows.Add(dr)
            End If
            INTdia += 1
            If nRows < INTdia Then
                Exit For
            End If
        Next
        'DTs.Tables("TipoCambio").AcceptChanges()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call CargarDatos()
    End Sub

    Private Sub ug_ListaTc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_ListaTc.KeyDown
        If e.KeyCode = Keys.Enter Then
            With ug_ListaTc
                Select Case ug_ListaTc.ActiveRow.Cells(ug_ListaTc.ActiveCell.Column.Index).Column.Key
                    Case "COMPRA"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    Case "VENTA"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select

            End With
        End If
    End Sub
End Class