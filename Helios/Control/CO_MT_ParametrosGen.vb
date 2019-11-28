Imports Infragistics.Win.UltraWinGrid

Public Class CO_MT_ParametrosGen

    Private Sub CO_MT_ParametrosGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Control_ITF()
        Call Cargar_SubDiarios()
        Call Cargar_Contrasena()
        Call Cargar_Correo()
        Call Cargar_Host()
        Call Cargar_Cuentas_Cierre()
    End Sub

    Private Sub Cargar_Cuentas_Cierre()
        Dim ctacierreBL As New BL.ContabilidadBL.SG_CO_TB_CTAS_CIERRE
        Dim dt_tmp As DataTable = ctacierreBL.get_CuentasCierre(gDat_Fecha_Sis.Year, gInt_IdEmpresa)

        If dt_tmp.Rows.Count > 0 Then
            txt_cta_MARGEN_COMER.Text = dt_tmp.Rows(0)("CC_CUENTA_MARGEN_COMER")
            txt_cta_VALOR_AGREGADO.Text = dt_tmp.Rows(0)("CC_CUENTA_VALOR_AGREGADO")
            txt_cta_VALOR_EXCEDENTE.Text = dt_tmp.Rows(0)("CC_CUENTA_VALOR_EXCEDENTE")
            txt_cta_RESUL_EXPLOTACION.Text = dt_tmp.Rows(0)("CC_CUENTA_RESUL_EXPLOTACION")
            txt_cta_RESUL_ANTES_PARTI.Text = dt_tmp.Rows(0)("CC_CUENTA_RESUL_ANTES_PARTI")
            txt_cta_RESULTADO_EJER.Text = dt_tmp.Rows(0)("CC_CUENTA_RESULTADO_EJER")
        Else
            txt_cta_MARGEN_COMER.Text = String.Empty
            txt_cta_VALOR_AGREGADO.Text = String.Empty
            txt_cta_VALOR_EXCEDENTE.Text = String.Empty
            txt_cta_RESUL_EXPLOTACION.Text = String.Empty
            txt_cta_RESUL_ANTES_PARTI.Text = String.Empty
            txt_cta_RESULTADO_EJER.Text = String.Empty
        End If

        dt_tmp = Nothing
        ctacierreBL = Nothing
    End Sub

    Private Sub Cargar_Contrasena()
        Try
            Dim ParametrosBL As New BL.ContabilidadBL.SG_CO_TB_PARAMETROSGENERALES
            Dim ParametrosBE As New BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES

            Dim dt_para As DataTable = ParametrosBL.getParametros

            txt_Contrasena.Text = dt_para.Rows(0)("PG_CLAVE_CONTROL_MES")
            txt_Correo_Cta_Web.Text = dt_para.Rows(0)("PG_CORREO_CTA_WEB")
            uchk_marcador_Proratear.Checked = IIf(dt_para.Rows(0)("PG_MARCADOR_PRORATEO") = 1, True, False)
            dt_para.Dispose()
            ParametrosBE = Nothing
            ParametrosBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Control_ITF()
        Try

            Dim ControlITF_BL As New BL.ContabilidadBL.SG_CO_TB_EMP_ITF
            Dim Dt_controlITF As DataTable = ControlITF_BL.getControl_ITF()

            Dim i As Integer = 0
            For Each fila As DataRow In Dt_controlITF.Rows
                ug_emp_itf.DisplayLayout.Bands(0).AddNew()
                ug_emp_itf.Rows(i).Cells("EM_ID").Value = fila("EM_ID")
                ug_emp_itf.Rows(i).Cells("EM_NOMBRE").Value = fila("EM_NOMBRE")
                ug_emp_itf.Rows(i).Cells("ES_ITF").Value = IIf(fila("ES_ITF") = 1, True, False)
                ug_emp_itf.Rows(i).Cells("IDSUBDIARIO").Value = fila("IDSUBDIARIO")
                ug_emp_itf.Rows(i).Cells("IDTIPO_ITF").Value = fila("IDTIPO_ITF")

                ug_emp_itf.Rows(i).Cells("EI_CTA6").Value = fila("EI_CTA6")
                ug_emp_itf.Rows(i).Cells("EI_CTA9").Value = fila("EI_CTA9")
                ug_emp_itf.Rows(i).Cells("EI_CTA7").Value = fila("EI_CTA7")

                i += 1
            Next


            ControlITF_BL = Nothing
            Dt_controlITF.Dispose()


            Call CrearComboGrid("IDTIPO_ITF", "TI_DESCRIPCION", ug_emp_itf, getTabla_Tipo_Asiento_ITF, True)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Function getTabla_Tipo_Asiento_ITF() As DataTable
        getTabla_Tipo_Asiento_ITF = Nothing
        Dim TipoAsientoITFBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_ASIENTO_ITF

        Return TipoAsientoITFBL.getTipos()

        TipoAsientoITFBL = Nothing

    End Function

    Private Sub Cargar_SubDiarios()
        Try

            Dim SubdiarioBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
            Dim SubdiarioBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            SubdiarioBE.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            udd_subdiario.DataSource = SubdiarioBL.getSubdiarios(SubdiarioBE)


            udd_subdiario.DisplayMember = "SD_DESCRIPCION"
            udd_subdiario.ValueMember = "SD_ID"

            SubdiarioBE = Nothing
            SubdiarioBL = Nothing


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_Host()
        Dim HostBL As New BL.ContabilidadBL.SG_CO_TB_CONF_CORREO_HOST
        Dim Dt As DataTable = HostBL.getHost

        If Dt.Rows.Count > 0 Then
            With Dt.Rows(0)
                txt_host.Text = .Item("CC_HOST")
                txt_usuario_host.Text = .Item("CC_USUARIO")
                txt_Clave_host.Text = .Item("CC_CLAVE")
            End With
        End If

        Dt.Dispose()
        HostBL = Nothing

    End Sub

    Private Sub Cargar_Correo()
        Dim CorreoBL As New BL.ContabilidadBL.SG_CO_TB_CONF_CORREO_MENSAJE
        Dim dt As DataTable = CorreoBL.getCorreos

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                txt_Correo_Cta_Web.Text = .Item("CCM_CORREO_PARA")
                txt_correo_de.Text = .Item("CCM_CORREO_DE")
                txt_nombre_Mostrar.Text = .Item("CCM_CORREO_DE_NOMBRE")
                txt_asunto.Text = .Item("CCM_ASUNTO")
                txt_mensaje.Text = .Item("CCM_MENSAJE")
            End With
        End If

        dt.Dispose()
        CorreoBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_EMP_ITF)
            Dim empItfBE As BE.ContabilidadBE.SG_CO_TB_EMP_ITF
            Dim Emp_Itf_BL As New BL.ContabilidadBL.SG_CO_TB_EMP_ITF

            ug_emp_itf.UpdateData()

            For i As Integer = 0 To ug_emp_itf.Rows.Count - 1
                empItfBE = New BE.ContabilidadBE.SG_CO_TB_EMP_ITF
                empItfBE.EI_IDEMP = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = ug_emp_itf.Rows(i).Cells("EM_ID").Value}
                empItfBE.EI_ES_ITF = IIf(ug_emp_itf.Rows(i).Cells("ES_ITF").Value, 1, 0)
                empItfBE.EI_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = ug_emp_itf.Rows(i).Cells("IDSUBDIARIO").Value}
                empItfBE.EI_IDTIPO_ITF = New BE.ContabilidadBE.SG_CO_TB_TIPO_ASIENTO_ITF With {.TI_ID = ug_emp_itf.Rows(i).Cells("IDTIPO_ITF").Value}
                empItfBE.EI_CTA6 = ug_emp_itf.Rows(i).Cells("EI_CTA6").Value.ToString
                empItfBE.EI_CTA9 = ug_emp_itf.Rows(i).Cells("EI_CTA9").Value.ToString
                empItfBE.EI_CTA7 = ug_emp_itf.Rows(i).Cells("EI_CTA7").Value.ToString
                lista.Add(empItfBE)
            Next

            Emp_Itf_BL.Insert(lista)

            Emp_Itf_BL = Nothing
            empItfBE = Nothing
            lista = Nothing

            Avisar("    Listo!      ")


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_emp_itf_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        If e.Cell.Column.Key = "ES_ITF" Then
            If e.Cell.Value = False Then
                e.Cell.Row.Cells("IDSUBDIARIO").Value = Nothing
            End If
        End If
    End Sub

    Private Sub ubtn_ClaveControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_ClaveControl.Click
        Try
            Dim ParametrosBL As New BL.ContabilidadBL.SG_CO_TB_PARAMETROSGENERALES
            Dim ParametrosBE As New BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES

            ParametrosBE.PG_CLAVE_CONTROL_MES = txt_Contrasena.Text.Trim

            ParametrosBL.Update(ParametrosBE)

            Avisar("    Listo!      ")

            ParametrosBE = Nothing
            ParametrosBL = Nothing


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_emp_itf_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            With ug_emp_itf
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
            End With
        End If
    End Sub

    Private Sub ubtn_Actualizar_Correo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Actualizar_Correo.Click

        Dim CorreoBL As New BL.ContabilidadBL.SG_CO_TB_CONF_CORREO_MENSAJE
        Dim CorreoBE As New BE.ContabilidadBE.SG_CO_TB_CONF_CORREO_MENSAJE

        CorreoBE.CCM_CORREO_PARA = txt_Correo_Cta_Web.Text.Trim
        CorreoBE.CCM_CORREO_DE = txt_correo_de.Text.Trim
        CorreoBE.CCM_CORREO_DE_NOMBRE = txt_nombre_Mostrar.Text.Trim
        CorreoBE.CCM_ASUNTO = txt_asunto.Text.Trim
        CorreoBE.CCM_MENSAJE = txt_mensaje.Text.Trim

        CorreoBL.Update(CorreoBE)

        CorreoBE = Nothing
        CorreoBL = Nothing

    End Sub

    Private Sub ubtn_actualizar_host_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_actualizar_host.Click

        Dim HostBL As New BL.ContabilidadBL.SG_CO_TB_CONF_CORREO_HOST
        Dim HostBE As New BE.ContabilidadBE.SG_CO_TB_CONF_CORREO_HOST

        HostBE.CC_HOST = txt_host.Text.Trim
        HostBE.CC_USUARIO = txt_usuario_host.Text.Trim
        HostBE.CC_CLAVE = txt_Clave_host.Text.Trim
        HostBL.Update(HostBE)

        HostBE = Nothing
        HostBL = Nothing

    End Sub

    Private Sub ubtn_inicializadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_inicializadores.Click
        Try
            Dim ParametrosBL As New BL.ContabilidadBL.SG_CO_TB_PARAMETROSGENERALES
            Dim ParametrosBE As New BE.ContabilidadBE.SG_CO_TB_PARAMETROSGENERALES

            ParametrosBE.PG_MARCADOR_PRORATEO = IIf(uchk_marcador_Proratear.Checked, 1, 0)

            ParametrosBL.Update_Inicializadores(ParametrosBE)

            Avisar("    Listo!      ")

            ParametrosBE = Nothing
            ParametrosBL = Nothing


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    
    Private Sub ubtn_Grabar_CtasCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Grabar_CtasCierre.Click

        Dim ctacierreBL As New BL.ContabilidadBL.SG_CO_TB_CTAS_CIERRE
        Dim ctacierreBE As New BE.ContabilidadBE.SG_CO_TB_CTAS_CIERRE

        ctacierreBE.CC_CUENTA_MARGEN_COMER = txt_cta_MARGEN_COMER.Text.Trim
        ctacierreBE.CC_CUENTA_VALOR_AGREGADO = txt_cta_VALOR_AGREGADO.Text.Trim
        ctacierreBE.CC_CUENTA_VALOR_EXCEDENTE = txt_cta_VALOR_EXCEDENTE.Text.Trim
        ctacierreBE.CC_CUENTA_RESUL_EXPLOTACION = txt_cta_RESUL_EXPLOTACION.Text.Trim
        ctacierreBE.CC_CUENTA_RESUL_ANTES_PARTI = txt_cta_RESUL_ANTES_PARTI.Text.Trim
        ctacierreBE.CC_CUENTA_RESULTADO_EJER = txt_cta_RESULTADO_EJER.Text.Trim
        ctacierreBE.CC_ANHO = gDat_Fecha_Sis.Year
        ctacierreBE.CC_IDEMPRESA = gInt_IdEmpresa

        ctacierreBL.Delete(ctacierreBE)
        ctacierreBL.Insert(ctacierreBE)

        ctacierreBE = Nothing
        ctacierreBL = Nothing

        Avisar("Listo!")


    End Sub
End Class