Public Class CO_RP_ConciliacionBancos

    Private Sub CO_RP_ConciliacionBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Combos_Bancos()
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Cargar_Combos_Bancos()
        Try

            Dim BancosBL As New BL.ContabilidadBL.SG_CO_TB_BANCO

            uce_Bancos.DataSource = BancosBL.getBancos(New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
            uce_Bancos.DisplayMember = "BA_NOMBRE"
            uce_Bancos.ValueMember = "BA_ID"

            BancosBL = Nothing

            uce_Bancos.SelectedIndex = -1
            uce_CtasCorrientes.SelectedIndex = -1
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub uce_Bancos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Bancos.ValueChanged
        Try
            Dim CtasCorrientesBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CTACTE
            Dim BancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE With {.BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = uce_Bancos.Value}}

            Dim cuentas As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
            cuentas = CtasCorrientesBL.getCtasCorrientes(BancoBE)

            uce_CtasCorrientes.Items.Clear()

            For Each cuenta As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE In cuentas
                uce_CtasCorrientes.Items.Add(cuenta.BC_IDCUENTA.PC_IDCUENTA, String.Format("{0} - {1}", cuenta.BC_NUMERO_CTA, cuenta.BC_DESCRIPCION))
            Next

            'uce_CtasCorrientes.DataSource = CtasCorrientesBL.getCtasCorrientes(BancoBE)
            'uce_CtasCorrientes.DisplayMember = "BC_ID_CTA"
            'uce_CtasCorrientes.ValueMember = "BC_DESCRIPCION"

            cuentas = Nothing
            CtasCorrientesBL = Nothing
            BancoBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Try

            If uce_Bancos.SelectedIndex = -1 Then
                Avisar("Seleccine un banco")
                uce_Bancos.Focus()
                Exit Sub
            End If

            If uce_CtasCorrientes.SelectedIndex = -1 Then
                Avisar("Seleccine una cuenta corriente")
                uce_CtasCorrientes.Focus()
                Exit Sub
            End If



            Me.Cursor = Cursors.WaitCursor

            Dim ObjReportes As New LR.ClsReporte
            Dim ObjReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim SaldoBE As New BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO
            Dim Dt_data As DataTable = Nothing
            Dim Str_NomReporte As String = String.Empty
            Dim Str_periodo As String = String.Format("{0} / {1}", uce_Mes.Text.Trim, une_Ayo.Text.Trim)
            Dim Str_Cuenta As String = uce_CtasCorrientes.Text

            SaldoBE.SMB_ANHO = une_Ayo.Value
            SaldoBE.SMB_MES = uce_Mes.Value
            SaldoBE.SMB_CUENTA = uce_CtasCorrientes.Value
            SaldoBE.SMB_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}


            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)

            Select Case uos_Reportes.Value
                Case 1
                    Str_NomReporte = "SG_CO_12.rpt"
                    Dt_data = ObjReportesBL.getConciliacionBanco1(SaldoBE)
                    ObjReportes.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NomReporte), Dt_data, "", _
                                        "pEmpresa;" & EmpresaBE.EM_NOMBRE, _
                                        "pRuc;" & EmpresaBE.EM_RUC, _
                                        "pPeriodo;" & Str_periodo)

                Case 2
                    Str_NomReporte = "SG_CO_13.rpt"
                    Dt_data = ObjReportesBL.getConciliacionBanco2(SaldoBE)
                    ObjReportes.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NomReporte), Dt_data, "", _
                                        "pEmpresa;" & EmpresaBE.EM_NOMBRE, _
                                        "pRuc;" & EmpresaBE.EM_RUC, _
                                        "pPeriodo;" & Str_periodo, _
                                        "pCuenta;" & Str_Cuenta)
            End Select



            EmpresaBE = Nothing
            EmpresaBL = Nothing
            ObjReportes = Nothing
            Dt_data = Nothing
            SaldoBE = Nothing
            ObjReportesBL = Nothing
            ObjReportes = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub
End Class