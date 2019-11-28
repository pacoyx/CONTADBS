Public Class CO_RP_REG_COM_VTA

    Private Sub CO_RP_REG_COM_VTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor


            If txt_Ayo.Text.Trim.Length = 0 Then
                Avisar("El periodo no se a cargado.")
                Exit Sub
            End If

            If uce_Mes.SelectedIndex = -1 Then
                Avisar("Seleccione mes")
                uce_Mes.Focus()
                Exit Sub
            End If

            Select Case uos_Tipo.Value
                Case "C"
                    Registro_Compras()
                Case "V"
                    Registro_Ventas()
                Case "H"
                    Registro_Honorarios()
            End Select

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Registro_Compras()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa
            E_Cabecera.AC_ESTADO = IIf(uchk_incluir_RH.Checked, 1, 0) 'agarramos el campo 'AC_ESTADO' para pasar 1 o 0 como parametro


            Dim Dt As DataTable = Obj_ReporteBL.getRegistro_Compras(E_Cabecera)
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Str_NombreRep As String = "SG_CO_03.RPT"

            Select Case uos_opciones.Value
                Case "S"
                    Str_NombreRep = "SG_CO_03.RPT"
                Case "SN"
                    Str_NombreRep = "SG_CO_02.RPT"
                Case "SNC"
                    Str_NombreRep = "SG_CO_02_1.RPT"
            End Select
            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Registro_Ventas()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa

            Dim Dt As DataTable = Obj_ReporteBL.getRegistro_Ventas(E_Cabecera)
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Str_NombreRep As String = "SG_CO_04.RPT"

            Select Case uos_opciones.Value
                Case "S"
                    Str_NombreRep = "SG_CO_05.RPT"
                Case "SN"
                    Str_NombreRep = "SG_CO_04.RPT"
                Case "SNC"
                    Str_NombreRep = "SG_CO_04_1.RPT"
            End Select

            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Registro_Honorarios()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa

            Dim Dt As DataTable = Obj_ReporteBL.getRegistro_Honorarios(E_Cabecera)
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Str_NombreRep As String = "SG_CO_04.RPT"

            Select Case uos_opciones.Value
                Case "S"
                    Str_NombreRep = "SG_CO_06.RPT"
                Case "SN"
                    Str_NombreRep = "SG_CO_06.RPT"
            End Select

            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub uos_Tipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_Tipo.ValueChanged
        Select Case uos_Tipo.Value
            Case "C"
                uchk_incluir_RH.Enabled = True

            Case Else
                uchk_incluir_RH.Enabled = False
                uchk_incluir_RH.Checked = False
        End Select
    End Sub
End Class