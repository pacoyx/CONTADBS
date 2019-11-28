Public Class CO_RP_Balance_Compro

    Private Sub CO_RP_Balance_Compro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
        Call Cargar_Cuentas_Combo()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Call Ver_Reporte_Estandar()
    End Sub

    Private Sub Cargar_Cuentas_Combo()
        Try
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            uc_Cuentas1.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)
            uc_Cuentas2.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)

            E_PlanCtas = Nothing
            Obj_PlanCtasBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Ver_Reporte_Estandar()
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim Dt As DataTable = Nothing
        Dim Str_ConFecha As Integer = IIf(uchk_SinFecha.Checked, "1", "0")
        Dim Str_Titulo As String = "Balance de Comprobacion al mes de " & uce_Mes.Text & " " & txt_Ayo.Text
        Dim Dbl_Sum_Debe As Double = 0
        Dim Dbl_Sum_Haber As Double = 0
        Dim Dbl_Sum_Sal_Debe As Double = 0
        Dim Dbl_Sum_Sal_Haber As Double = 0
        Dim Dbl_Sum_Activo As Double = 0
        Dim Dbl_Sum_Pasivo As Double = 0
        Dim Dbl_Sum_Perdida As Double = 0
        Dim Dbl_Sum_Ganancia As Double = 0
        Try

            If uchk_CtasTitulo.Checked Then
                If une_Dig_titulo.Value = 0 Or une_Dig_titulo.Value Is Nothing Then
                    Avisar("Ingrese un numero valido en la caja")
                    une_Dig_titulo.Focus()
                    Exit Sub
                End If
            End If

            Dim ant_cierre As Integer = 0
            If uchk_antesde.Checked Then ant_cierre = 1


            Me.Cursor = Cursors.WaitCursor
            Dt = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, _
                                                         gInt_IdEmpresa, uc_Cuentas1.Text.Trim, _
                                                         uc_Cuentas2.Text.Trim, uchk_CtasTitulo.Checked, _
                                                         uos_opciones.Value, _
                                                          IIf(uchk_CtasTitulo.Checked, une_Dig_titulo.Value, 0), ant_cierre)


            If uchk_soloCtasTit.Checked Then

denuevo:
                For Each f As DataRow In Dt.Rows
                    If f.Item("CUENTA").ToString.Length <> une_Dig_titulo.Value Then
                        Dt.Rows.Remove(f)
                        GoTo denuevo
                    End If
                Next


            End If

            If une_Dig_titulo.Value = 5 Then
                Dbl_Sum_Debe = Dt.Compute("sum(DEBE)", "")
                Dbl_Sum_Haber = Dt.Compute("sum(HABER)", "")
                Dbl_Sum_Sal_Debe = Dt.Compute("sum(Saldo_Deudor)", "")
                Dbl_Sum_Sal_Haber = Dt.Compute("sum(Saldo_Acreedor)", "")
            Else
                If uchk_soloCtasTit.Checked Then
                    Dbl_Sum_Debe = Dt.Compute("sum(DEBE)", "")
                    Dbl_Sum_Haber = Dt.Compute("sum(HABER)", "")
                    Dbl_Sum_Sal_Debe = Dt.Compute("sum(Saldo_Deudor)", "")
                    Dbl_Sum_Sal_Haber = Dt.Compute("sum(Saldo_Acreedor)", "")
                Else
                    Dbl_Sum_Debe = Dt.Compute("sum(DEBE)", "len(CUENTA) <> " & une_Dig_titulo.Value)
                    Dbl_Sum_Haber = Dt.Compute("sum(HABER)", "len(CUENTA) <> " & une_Dig_titulo.Value)
                    Dbl_Sum_Sal_Debe = Dt.Compute("sum(Saldo_Deudor)", "len(cuenta)<> " & une_Dig_titulo.Value)
                    Dbl_Sum_Sal_Haber = Dt.Compute("sum(Saldo_Acreedor)", "len(cuenta)<> " & une_Dig_titulo.Value)
                End If
            End If






            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(EmpresaBE)

            Dim Str_NombreRep As String = "SG_CO_16.RPT"
            Dim ObjReporte As New LR.ClsReporte


            Select Case uos_Formato.Value
                Case 1 ' Estandar
                    Str_NombreRep = "SG_CO_16.RPT"

                    ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
                                       String.Format("pPeriodo;{0} / {1}", _
                                       uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                        "pRuc;" & EmpresaBE.EM_RUC, _
                                        "pRazon;" & EmpresaBE.EM_NOMBRE.Trim, _
                                        "pFecha_Pag;" & Str_ConFecha, _
                                        "pTitulo;" & Str_Titulo.ToUpper, _
                                        "pS_Debe;" & Dbl_Sum_Debe, _
                                        "pS_Haber;" & Dbl_Sum_Haber, _
                                        "pS_Sal_Debe;" & Dbl_Sum_Sal_Debe, _
                                        "pS_Sal_Haber;" & Dbl_Sum_Sal_Haber)

                Case 2 ' Con Resultados
                    Str_NombreRep = "SG_CO_17_1.RPT"

                    ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
                                        String.Format("pPeriodo;{0} / {1}", _
                                        uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                         "pRuc;" & EmpresaBE.EM_RUC, _
                                         "pRazon;" & EmpresaBE.EM_NOMBRE.Trim, _
                                         "pFecha_Pag;" & Str_ConFecha, _
                                         "pTitulo;" & Str_Titulo.ToUpper, _
                                         "pSoloCtaTit;" & IIf(uchk_soloCtasTit.Checked, "1", "0"), _
                                         "pNunDigCtaTit;" & une_Dig_titulo.Value, _
                                         "pSum_Debe;" & Dbl_Sum_Debe, _
                                         "pSum_Haber;" & Dbl_Sum_Haber, _
                                         "pSum_Saldo_Debe;" & Dbl_Sum_Sal_Debe, _
                                         "pSum_Saldo_Haber;" & Dbl_Sum_Sal_Haber)

            End Select




            ObjReporte.Dispose()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            ShowError(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub uc_Cuentas1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas1.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uc_Cuentas2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas2.Enter
        uc_Cuentas2.Text = uc_Cuentas1.Text
        uc_Cuentas2.Value = uc_Cuentas1.Value
    End Sub

    Private Sub uc_Cuentas1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas1.ValueChanged
        Try
            lbl_des_cta1.Text = uc_Cuentas1.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta1.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta1.Text = "*La cuenta no existe!"
            lbl_des_cta1.Appearance.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub uc_Cuentas2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas2.ValueChanged
        Try
            lbl_des_cta2.Text = uc_Cuentas2.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta2.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta2.Text = "*La cuenta no existe!"
            lbl_des_cta2.Appearance.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub uc_Cuentas2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas2.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uc_Cuentas1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles uc_Cuentas1.InitializeLayout

    End Sub

    Private Sub uchk_CtasTitulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_CtasTitulo.CheckedChanged
        If uchk_CtasTitulo.Checked Then
            une_Dig_titulo.Visible = uchk_CtasTitulo.Checked
            une_Dig_titulo.Value = 2
            une_Dig_titulo.Visible = True
            uchk_soloCtasTit.Enabled = True
        Else
            une_Dig_titulo.Visible = False
            uchk_soloCtasTit.Enabled = False
            uchk_soloCtasTit.Checked = False
        End If
    End Sub
End Class