Public Class CO_RP_Mov_Cta
    Dim Int_TipoAnexo As Integer = 0


    Private Sub CO_RP_Mov_Cta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Cuentas_Combo()
        une_Ayo.Value = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
        uce_Mes.Items.Add(0, "Todos")
        uce_Mes.Value = 0
    End Sub

    Private Sub Cargar_Cuentas_Combo()
        Try
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            uc_Cuentas1.DataSource = Obj_PlanCtasBL.getCuentas_Manejan_Anexo(E_PlanCtas)

            E_PlanCtas = Nothing
            Obj_PlanCtasBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
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

   
    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_ruc1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc1.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor1()
        End If
    End Sub

    Private Sub txt_ruc1_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc1.EditorButtonClick
        Call Ayuda_Proveedor1()
    End Sub

    Private Sub txt_ruc1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc1.ValueChanged
        If txt_ruc1.Text.Trim.Length = 0 Then
            txt_idAnexo1.Text = String.Empty
            lbl_Des_Anexo1.Text = String.Empty
        End If
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dt_resultado As DataTable = reportesBL.get_Movimiento_por_Cuentas(uc_Cuentas1.Text.Trim, gInt_IdEmpresa, gDat_Fecha_Sis.Year, uce_Mes.Value, IIf(txt_idAnexo1.Text.Trim.Length = 0, 0, txt_idAnexo1.Text.Trim))
        ug_resultado.DataSource = dt_resultado

        ume_tot_d.Value = dt_resultado.Compute("sum(debe)", "")
        ume_tot_h.Value = dt_resultado.Compute("sum(haber)", "")

        ulbl_num_reg.Text = "Total de Registros : " & dt_resultado.Rows.Count

        reportesBL = Nothing
    End Sub

    Private Sub uc_Cuentas1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uc_Cuentas1.ValueChanged
        Try
            lbl_des_cta1.Text = uc_Cuentas1.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta1.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta1.Text = "*La cuenta no existe!"
            lbl_des_cta1.Appearance.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Tool_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_excel.Click

        Dim dt As DataTable

        dt = CType(ug_resultado.DataSource, DataTable)

        Dim Obj_Funciones As New LR.ClsFunciones
        Dim Str_titulo As String = "Movimientos de la Cuenta : " & uc_Cuentas1.Text & " - " & lbl_des_cta1.Text.Trim

        Obj_Funciones.exportar_A_MS_Excel(dt, Str_titulo)

        Obj_Funciones = Nothing
    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click
        Dim Obj_repo As New LR.ClsReporte
        Dim dt As DataTable
        Dim Str_Cuentas As String = "Cuenta     : " & uc_Cuentas1.Text & " - " & lbl_des_cta1.Text.Trim
        Dim Str_Analisis As String = "Analisis  : " & txt_ruc1.Text.Trim & " - " & lbl_Des_Anexo1.Text.Trim
        Me.Cursor = Cursors.WaitCursor
        dt = CType(ug_resultado.DataSource, DataTable)
        Obj_repo.Muestra_Reporte(gStr_RutaRep & "\SG_CO_25.rpt", dt, "", "pEmp;" & gStr_NomEmpresa, "pCuenta;" & Str_Cuentas, "pAnalisis;" & Str_Analisis)
        Obj_repo.Dispose()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uc_Cuentas1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ruc1.Focus()
        End If
    End Sub
End Class