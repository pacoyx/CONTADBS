Public Class CO_RP_Bal_Inv

    Private Sub ubtn_VerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_VerReporte.Click
        Dim Obj_Crystal As New LR.ClsReporte
        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        Dim dt_repor As DataTable = Nothing

        Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Obj_EmpresaBL.getEmpresas_2(E_Empresa)
        Dim periodo As String = txt_Ayo.Text
        Dim ruc As String = E_Empresa.EM_RUC
        Dim emp As String = E_Empresa.EM_NOMBRE

        Select Case uos_Formato.Value
            Case "10"
                dt_repor = reporteBL.get_BI_formato_3_2_cta10(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_29.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "12"
                dt_repor = reporteBL.get_BI_formato_3_3_cta12(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_30.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "14"
                dt_repor = reporteBL.get_BI_formato_3_4_cta14(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_31.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "16"
                dt_repor = reporteBL.get_BI_formato_3_5_cta16(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_32.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "19"
                dt_repor = reporteBL.get_BI_formato_3_5_cta19(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_32_2.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "34"
                dt_repor = reporteBL.get_BI_formato_3_5_cta34(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_32_3.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "40"
                dt_repor = reporteBL.get_BI_formato_3_10_cta40(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_48.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "41"
                dt_repor = reporteBL.get_BI_formato_3_11_cta41(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_33.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "42"
                dt_repor = reporteBL.get_BI_formato_3_12_cta42_det(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_34.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "43"
                dt_repor = reporteBL.get_BI_formato_3_12_cta43(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_34_2.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "46"
                dt_repor = reporteBL.get_BI_formato_3_13_cta46(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_35.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "49"


            Case "50"
                CO_RP_DetCta50.ShowDialog()
                If CO_RP_DetCta50.bol_Aceptar Then
                    Dim dt_tmp_cab As DataTable = reporteBL.get_Grabar_Cabecera_DetCta50(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                    dt_repor = reporteBL.get_Grabat_Detalle_DetCta50(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                    Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_36.rpt", dt_repor, "", _
                                                "pPeriodo;" & periodo, _
                                                "pRuc;" & ruc, _
                                                "pEmpresa;" & emp, _
                                                "pV1;" & dt_tmp_cab.Rows(0)("RC_CS"), _
                                                "pV2;" & dt_tmp_cab.Rows(0)("RC_VN"), _
                                                "pV3;" & dt_tmp_cab.Rows(0)("RC_NA1"), _
                                                "pV4;" & dt_tmp_cab.Rows(0)("RC_NA2"), _
                                                "pV5;" & dt_tmp_cab.Rows(0)("RC_NA3"))
                End If

        End Select

        Obj_Crystal.Dispose()

    End Sub

    Private Sub CO_RP_Bal_Inv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ayo.Text = gDat_Fecha_Sis.Year.ToString
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub
End Class