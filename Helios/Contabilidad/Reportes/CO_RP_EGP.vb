Public Class CO_RP_EGP

    Private Sub CO_RP_EGP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dt_data As DataTable = reporteBL.get_Reporte_EGP(txt_Ayo.Text.Trim, uce_Mes.Value, gInt_IdEmpresa, uos_opciones.Value)
        Dim Str_titulo As String = "Por el periodo a " & uce_Mes.Text & " del " & txt_Ayo.Text.Trim

        Dim Obj_Crystal As New LR.ClsReporte

        Select Case uos_opciones.Value
            Case 1, 3
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_37.rpt", dt_data, "", _
                                 "pPeriodo;" & txt_Ayo.Text.Trim, _
                                 "pEmpresa;" & gStr_NomEmpresa, _
                                 "pTitulo1;" & Str_titulo, _
                                 "pTipo;" & uos_opciones.Text)
            Case 2, 4
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_38.rpt", dt_data, "", _
                                   "pPeriodo;" & txt_Ayo.Text.Trim, _
                                   "pEmpresa;" & gStr_NomEmpresa, _
                                   "pTitulo1;" & Str_titulo, _
                                   "pAyo1;" & txt_Ayo.Text, _
                                   "pAyo2;" & (CInt(txt_Ayo.Text) - 1).ToString, _
                                   "pTipo;" & uos_opciones.Text)
            Case Else
        End Select
        
        Obj_Crystal.Dispose()
        reporteBL = Nothing
        Me.Cursor = Cursors.Default
    End Sub
End Class