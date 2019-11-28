Public Class CO_RP_Analisis3
    Dim Int_TipoAnexo As Integer = 0



    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        '_______________________________________________________________________________________
        Me.Cursor = Cursors.WaitCursor
        Dim ObjCon_RepBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim ObjReportes As New LR.ClsReporte
        Dim Dt_Data As DataTable = Nothing

        Dim planCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim planCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        planCtasBE.PC_IDCUENTA = uc_Cuentas1.Value
        planCtasBL.getCuenta(planCtasBE)


        'si la cuenta maneja anexo de referencia, entonces
        If planCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
            Dt_Data = ObjCon_RepBL.get_Analisis_por_Cuenta_sinAnexo(uc_Cuentas1.Text.Trim, uc_Cuentas2.Text.Trim, _
                                CDate(udte_f1.Value).ToShortDateString, CDate(udte_f2.Value).ToShortDateString, _
                                CDate(udte_f1.Value).Year, gInt_IdEmpresa)
        Else

            Dt_Data = ObjCon_RepBL.getAnalisis_por_cuenta(CDate(udte_f1.Value).ToShortDateString, _
                                           CDate(udte_f2.Value).ToShortDateString, _
                                           uc_Cuentas1.Text.Trim, uc_Cuentas2.Text.Trim, _
                                           IIf(txt_idAnexo1.Text.Trim = String.Empty, 0, txt_idAnexo1.Text.Trim), _
                                           IIf(txt_idAnexo2.Text.Trim = String.Empty, 0, txt_idAnexo2.Text.Trim), _
                                           IIf(uchk_SoloPendientes.Checked, 1, 0), CDate(udte_f1.Value).Year, gInt_IdEmpresa)
        End If


        planCtasBE = Nothing
        planCtasBL = Nothing


        Dim str_nombre_rep As String = "\SG_CO_11.rpt"
        If uchk_Fechas.Checked Then str_nombre_rep = "\SG_CO_11_2.rpt"

        ObjReportes.Muestra_Reporte(gStr_RutaRep & str_nombre_rep, Dt_Data, "", "pEmpresa;" & gStr_NomEmpresa, "pRuc;" & "", "pFecha1;" & CDate(udte_f1.Value).ToShortDateString, "pFecha2;" & CDate(udte_f2.Value).ToShortDateString, "pResumen;" & IIf(uchk_Resumen.Checked, 1, 0))

        ObjCon_RepBL = Nothing
        ObjReportes.Dispose()
        Dt_Data.Dispose()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Cargar_Cuentas_Combo()
        Try
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            uc_Cuentas1.DataSource = Obj_PlanCtasBL.getCuentas_Manejan_Anexo(E_PlanCtas)
            uc_Cuentas2.DataSource = Obj_PlanCtasBL.getCuentas_Manejan_Anexo(E_PlanCtas)

            E_PlanCtas = Nothing
            Obj_PlanCtasBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CO_RP_Analisis3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Cuentas_Combo()
        udte_f1.Value = ObtenerPrimerDia("01/01/" + gDat_Fecha_Sis.Year.ToString)
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

    Private Sub Ayuda_Proveedor1()


        '____________
        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas1.Value}
        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        PlanCtasBL.getCuenta(E_PlanCtas)

        Int_TipoAnexo = 0
        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
            Int_TipoAnexo = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
            'uc_Cuentas2.Value = uc_Cuentas1.Value
        Else
            Avisar("Ingrese la Cuenta Contable")
            uc_Cuentas1.Focus()
        End If

        E_PlanCtas = Nothing
        PlanCtasBL = Nothing
        '___________________


        Select Case Int_TipoAnexo
            Case 1 'clientes
                CO_MT_Buscar.Int_Opcion = 2
            Case 2 'proveedores
                CO_MT_Buscar.Int_Opcion = 1
            Case 3 'personal
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
            Case 4 ' Honorarios
                CO_MT_Buscar.Int_Opcion = 3
            Case 5 'terceros
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
            Case 6 'Varios
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
            Case 7 'Accionistas
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
        End Select



        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_ruc1.Text = matriz(2)
            txt_idAnexo1.Text = matriz(0)
            lbl_Des_Anexo1.Text = matriz(3)
        End If
    End Sub

    Private Sub Ayuda_Proveedor2()

        '____________
        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas1.Value}
        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        PlanCtasBL.getCuenta(E_PlanCtas)

        Int_TipoAnexo = 0
        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
            Int_TipoAnexo = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
        End If

        E_PlanCtas = Nothing
        PlanCtasBL = Nothing
        '___________________

        Select Case Int_TipoAnexo
            Case 1 'clientes
                CO_MT_Buscar.Int_Opcion = 2
            Case 2 'proveedores
                CO_MT_Buscar.Int_Opcion = 1
            Case 3 'personal
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
            Case 4 ' Honorarios
                CO_MT_Buscar.Int_Opcion = 3
            Case 5 'terceros
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
            Case 6 'Varios
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
            Case 7 'Accionistas
                CO_MT_Buscar.Int_Opcion = 4
                CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo
        End Select

        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_ruc2.Text = matriz(2)
            txt_idAnexo2.Text = matriz(0)
            lbl_des_anexo2.Text = matriz(3)
        End If
    End Sub

    Private Sub txt_ruc1_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc1.EditorButtonClick
        Call Ayuda_Proveedor1()
    End Sub

    Private Sub txt_ruc1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc1.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor1()
        End If
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_ruc2_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc2.EditorButtonClick
        Call Ayuda_Proveedor2()
    End Sub

    Private Sub txt_ruc2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc2.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor2()
        End If
        If e.KeyCode = Keys.Enter Then ubtn_Imprimir.Focus()
    End Sub

    Private Sub getDatosAnexo(ByVal Inicio As Boolean)
        Try
            If txt_ruc1.Text.Trim.Length = 0 Then
                txt_idAnexo1.Text = String.Empty
                lbl_Des_Anexo1.Text = String.Empty
                Exit Sub
            End If

            If txt_ruc2.Text.Trim.Length = 0 Then
                txt_idAnexo2.Text = String.Empty
                lbl_des_anexo2.Text = String.Empty
                Exit Sub
            End If

            '____________
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas1.Value}
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            PlanCtasBL.getCuenta(E_PlanCtas)

            Int_TipoAnexo = 0
            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                Int_TipoAnexo = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
                'uc_Cuentas2.Value = uc_Cuentas1.Value
            End If

            E_PlanCtas = Nothing
            PlanCtasBL = Nothing
            '___________________

            Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
            Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO

            E_Anexo.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Anexo.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo}
            E_Anexo.AN_NUM_DOC = txt_ruc1.Text.Trim
            Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

            If Inicio Then
                If E_Anexo.AN_DESCRIPCION.Length = 0 Then
                    lbl_Des_Anexo1.Text = "El anexo no existe."
                    txt_idAnexo1.Text = String.Empty
                Else
                    lbl_Des_Anexo1.Text = E_Anexo.AN_DESCRIPCION
                    txt_idAnexo1.Text = E_Anexo.AN_IDANEXO
                End If
            Else
                If E_Anexo.AN_DESCRIPCION.Length = 0 Then
                    lbl_des_anexo2.Text = "El anexo no existe."
                    txt_idAnexo2.Text = String.Empty
                Else
                    lbl_des_anexo2.Text = E_Anexo.AN_DESCRIPCION
                    txt_idAnexo2.Text = E_Anexo.AN_IDANEXO
                End If
            End If

            E_Anexo = Nothing
            Obj_AnexoBL = Nothing
            Obj_TipoAnexoBL.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub txt_ruc1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc1.Leave
        Call getDatosAnexo(True)
    End Sub

    Private Sub txt_ruc2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc2.Leave
        Call getDatosAnexo(False)
    End Sub

    Private Sub uc_Cuentas1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas1.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_f1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_f1.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_f2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_f2.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uc_Cuentas2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas2.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_ruc2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc2.Enter
        txt_ruc2.Text = txt_ruc1.Text
        txt_idAnexo2.Text = txt_idAnexo1.Text
        lbl_des_anexo2.Text = lbl_Des_Anexo1.Text
    End Sub

    Private Sub uc_Cuentas2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas2.Enter
        uc_Cuentas2.Text = uc_Cuentas1.Text
    End Sub

    Private Sub uc_Cuentas1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles uc_Cuentas1.InitializeLayout

    End Sub
End Class