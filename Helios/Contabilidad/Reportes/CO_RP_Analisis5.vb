Public Class CO_RP_Analisis5

    Private Sub CO_RP_Analisis5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Listado_CC()
        Call CargarCombo_ConMeses(uce_Mes)
        Call CargarCombo_ConMeses(uce_Mes2)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True

    End Sub


    Private Sub Cargar_Listado_CC()
        Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
        ccBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        Dim dt_tmp As DataTable = ccBL.getCentroCostos(ccBE)

        Dim i As Integer = 0
        For Each fila As DataRow In dt_tmp.Rows
            ug_cc.DisplayLayout.Bands(0).AddNew()
            ug_cc.Rows(i).Cells("Sel").Value = True
            ug_cc.Rows(i).Cells("CC_CODIGO").Value = fila("CC_CODIGO")
            ug_cc.Rows(i).Cells("CC_DESCRIPCION").Value = fila("CC_DESCRIPCION")
            ug_cc.UpdateData()
            i += 1
        Next

        If ug_cc.Rows.Count > 0 Then
            ug_cc.Focus()
            ug_cc.Rows(0).Activate()
        End If

        ccBL = Nothing
        ccBE = Nothing

    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click

        If ug_cuentas.Visible Then
            ug_cuentas.Visible = False
            ug_cc.Visible = True
            ubtn_Imprimir.Visible = False
            ubtn_Aceptar.Visible = True
            ulbl_etiqueta.Text = "Seleccione los Centro de Costos"
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click


        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione el mes inicial")
            uce_Mes.Focus()
            Exit Sub
        End If

        If uce_Mes2.SelectedIndex = -1 Then
            Avisar("Seleccione el mes final")
            uce_Mes2.Focus()
            Exit Sub
        End If



        Dim dt_reporte As DataTable = Nothing
        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        'Grabamos los codigos temporales ( cuentas contables )
        Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
        Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        Me.Cursor = Cursors.WaitCursor

        ug_cuentas.UpdateData()

        With ug_cuentas
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Cells("Sel").Value Then
                    lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(.Rows(i).Cells("AD_CUENTA").Value.ToString, Environment.MachineName & "A", gInt_IdEmpresa))
                End If
            Next
        End With

        Call ReportesBL.setCodigos(lista_codigos)


        'Cargamos el dt con la data del reporte
        dt_reporte = ReportesBL.get_Reporte_Mov_X_Cc(txt_Ayo.Text.Trim, uce_Mes.Value, uce_Mes2.Value, gInt_IdEmpresa, Environment.MachineName, Environment.MachineName & "A")

        'Levantamos el reporte
        Dim CristalBL As New LR.ClsReporte
        CristalBL.Muestra_Reporte(gStr_RutaRep & "\SG_CO_24.RPT", dt_reporte, "", "pPeriodo;" & txt_Ayo.Text.Trim, _
                                  "pMes1;" & uce_Mes.Text, "pMes2;" & uce_Mes2.Text, "pEmpresa;" & gStr_NomEmpresa)

        'Destruimos los objetos para liberar memoria
        CristalBL.Dispose()
        ReportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        ug_cuentas.Visible = True
        ug_cc.Visible = False
        ulbl_etiqueta.Text = "Seleccione las cuentas"

        'Grabamos los codigos temporales
        Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
        Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        ug_cc.UpdateData()

        For i As Integer = 0 To ug_cc.Rows.Count - 1
            If ug_cc.Rows(i).Cells("Sel").Value Then
                lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(ug_cc.Rows(i).Cells("CC_CODIGO").Value.ToString, Environment.MachineName, gInt_IdEmpresa))
            End If
        Next

        Call ReportesBL.setCodigos(lista_codigos)

        'Levantamos el Reporte
        Dim PlabCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim dt_cuenta As DataTable = Nothing
        dt_cuenta = PlabCtasBL.get_Cuentas_por_CentroCosto(gDat_Fecha_Sis.Year, gInt_IdEmpresa, Environment.MachineName)
        ug_cuentas.DataSource = dt_cuenta


        'dt_cuenta.Dispose()
        PlabCtasBL = Nothing
        ubtn_Imprimir.Visible = True
        ubtn_Aceptar.Visible = False
    End Sub
End Class