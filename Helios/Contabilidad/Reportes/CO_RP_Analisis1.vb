Imports Infragistics.Win

Public Class CO_RP_Analisis1

    Dim Dt_DocumentosCtas As DataTable = Nothing
    Dim Bol_IsGrupo As Boolean = False
    Dim Ds_Doc_Pendi As DataSet

    Private Sub CO_RP_Analisis1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Cuentas_Combo()
            Call Cargar_TipoAnexos()
            Call Formatear_Grilla_Selector(ug_Pendientes)
            udte_Fec_Voucher.Value = gDat_Fecha_Sis

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Cargar_TipoAnexos()
        Try

            Dim TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
            uce_TipoAnexo.DataSource = TipoAnexoBL.getTipoAnexos()
            uce_TipoAnexo.DisplayMember = "TA_DESCRIPCION"
            uce_TipoAnexo.ValueMember = "TA_CODIGO"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cargar_Cuentas_Combo()
        Try
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            uc_Cuentas.DataSource = Obj_PlanCtasBL.getCuentas_Manejan_Anexo(E_PlanCtas)

            E_PlanCtas = Nothing
            Obj_PlanCtasBL = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub uchk_Cuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Cuenta.CheckedChanged
        ugb_Cuenta.Enabled = uchk_Cuenta.Checked
        If uchk_Cuenta.Checked Then
            uc_Cuentas.Focus()
        End If
    End Sub

    Private Sub uchk_Anexo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Anexo.CheckedChanged
        ugb_Anexos.Enabled = uchk_Anexo.Checked

        If Not uchk_Anexo.Checked Then
            txt_Ruc_Anexo.Text = String.Empty
            uce_TipoAnexo.SelectedIndex = -1
            lbl_Des_Anexo.Text = String.Empty
            txt_idAnexoDet.Text = String.Empty
        End If

        If uchk_Cuenta.Checked Then
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            Entidad.PC_IDCUENTA = uc_Cuentas.Value
            PlanCtasBL.getCuenta(Entidad)

            If Not Entidad.PC_IDTIPO_ANEXO Is Nothing Then
                uce_TipoAnexo.Value = Entidad.PC_IDTIPO_ANEXO.TA_CODIGO
                txt_Ruc_Anexo.Focus()
            End If

        End If

        If Not uchk_Anexo.Checked Then
            Call Consultar_Documentos()
        End If
    End Sub

    Private Sub uchk_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Fecha.CheckedChanged
        ugb_Fecha.Enabled = uchk_Fecha.Checked
    End Sub

    Private Sub uc_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If Not uchk_Anexo.Checked And Not uchk_Fecha.Checked Then
                    Tool_Consultar_Click(sender, e)
                    If ug_Pendientes.Rows.Count > 0 Then
                        ug_Pendientes.Focus()
                    Else
                        uc_Cuentas.Focus()
                    End If

                    Exit Sub
                End If

                If uchk_Anexo.Checked Then

                    Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                    Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                    Entidad.PC_IDCUENTA = uc_Cuentas.Value
                    PlanCtasBL.getCuenta(Entidad)

                    If Not Entidad.PC_IDTIPO_ANEXO Is Nothing Then
                        uce_TipoAnexo.Value = Entidad.PC_IDTIPO_ANEXO.TA_CODIGO
                        txt_Ruc_Anexo.Focus()
                    End If

                End If
            Catch ex As Exception
            End Try
        End If

        If e.KeyCode = Keys.Down Then
            uc_Cuentas.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If
        If e.KeyCode = Keys.Escape Then

        End If
    End Sub

    Private Sub uc_Cuentas_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uc_Cuentas.ValueChanged
        Try
            txt_des_cuenta.Text = uc_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value
            txt_des_cuenta.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            txt_des_cuenta.Text = "*La cuenta no existe!"
            txt_des_cuenta.Appearance.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub txt_Ruc_Anexo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Ruc_Anexo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
                Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                E_Anexo.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                E_Anexo.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TipoAnexo.Value}
                E_Anexo.AN_NUM_DOC = txt_Ruc_Anexo.Text.Trim

                Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

                If E_Anexo.AN_DESCRIPCION.Length = 0 Then
                    lbl_Des_Anexo.Text = "El anexo no existe."
                    txt_idAnexoDet.Text = String.Empty
                Else
                    lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION
                    txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO

                    Tool_Consultar_Click(sender, e)
                    If ug_Pendientes.Rows.Count > 0 Then
                        ug_Pendientes.Focus()
                    Else
                        txt_Ruc_Anexo.Focus()
                    End If
                End If

                E_Anexo = Nothing
                Obj_AnexoBL = Nothing
                Obj_TipoAnexoBL.Dispose()

            End If


            If e.KeyCode = Keys.F2 Then
                Call Ayuda_Proveedor_Cab()
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub Ayuda_Proveedor_Cab()

        CO_MT_Buscar.Int_Opcion = 4
        CO_MT_Buscar.Int_TipoAnexo = uce_TipoAnexo.Value
        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_Ruc_Anexo.Text = matriz(2)
            txt_idAnexoDet.Text = matriz(0)
            lbl_Des_Anexo.Text = matriz(3)
        End If

        txt_Ruc_Anexo.Focus()


    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Try
            Dim Obj_repo As New LR.ClsReporte
            Obj_repo.Muestra_Reporte(gStr_RutaRep & "\", Nothing, "", "")
            Obj_repo.Dispose()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call Consultar_Documentos()
    End Sub

    Private Sub Consultar_Documentos()
        Try

            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim anexo As Integer = 0

            If uchk_Anexo.Checked Then
                If txt_idAnexoDet.Text.Trim.Length = 0 Then
                    Avisar("Ingrese un anexo")
                    txt_idAnexoDet.Focus()
                    Exit Sub
                End If

                If uchk_Anexo.Checked Then anexo = CInt(txt_idAnexoDet.Text)
                Ds_Doc_Pendi = AsientoBL.getDoc_Pendientes2_Relacionado(uc_Cuentas.Text.Trim, anexo, gInt_IdEmpresa, CDate(udte_Fec_Voucher.Value))
                ug_Pendientes.DataSource = Nothing
                ug_Pendientes.SetDataBinding(Ds_Doc_Pendi, "Cab")

                ug_Pendientes.DisplayLayout.Bands(0).Columns("SEL").Hidden = True
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AD_IDANEXO").Hidden = True
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AN_NUM_DOC").Hidden = True
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AN_DESCRIPCION").Hidden = True
                ug_Pendientes.DisplayLayout.Bands(0).Columns("DO_DESCRIPCION").Header.Caption = "Documento"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AD_SDOC").Header.Caption = "Serie"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AD_NDOC").Header.Caption = "Numero"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("TOTAL_DEUDA").Header.Caption = "Saldo"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("DEUDA").Header.Caption = "Total Doc."
                ug_Pendientes.DisplayLayout.Bands(0).Columns("PAGO").Header.Caption = "Pago / Amortizacion"


                ug_Pendientes.DisplayLayout.Bands(1).Columns("AC_NUM_VOUCHER").Header.Caption = "Num. Voucher"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("AD_CUENTA").Header.Caption = "Cta Contable"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("SD_DESCRIPCION").Header.Caption = "Subdiario"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("FEC_EMISION").Header.Caption = "Emision"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("DO_DESCRIPCION").Header.Caption = "Documento"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("AD_SDOC").Header.Caption = "Serie"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("AD_NDOC").Header.Caption = "Numero"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("AD_DEBE").Header.Caption = "Debe"
                ug_Pendientes.DisplayLayout.Bands(1).Columns("AD_HABER").Header.Caption = "Haber"

                ug_Pendientes.DisplayLayout.Bands(1).Columns("AC_ID").Hidden = True
                ug_Pendientes.DisplayLayout.Bands(1).Columns("AC_IDSUBDIARIO").Hidden = True


                Bol_IsGrupo = False
                Call Sumas3()
                If Ds_Doc_Pendi.Tables(0).Rows.Count = 0 Then ug_Pendientes.Focus()

            Else 'todos x Cuenta

                If uchk_Anexo.Checked Then anexo = CInt(txt_idAnexoDet.Text)
                Dt_DocumentosCtas = AsientoBL.getDoc_Pendientes2(uc_Cuentas.Text.Trim, anexo, gInt_IdEmpresa, CDate(udte_Fec_Voucher.Value))
                ug_Pendientes.DataBindings.Clear()
                ug_Pendientes.DataMember = Nothing
                ug_Pendientes.DataSource = Nothing
                ug_Pendientes.Refresh()
                ug_Pendientes.DataSource = Dt_DocumentosCtas

                ug_Pendientes.DisplayLayout.Bands(0).Columns("AD_IDANEXO").Header.Caption = "Codigo"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AN_NUM_DOC").Header.Caption = "Ruc"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AN_DESCRIPCION").Header.Caption = "Razon Social"

                ug_Pendientes.DisplayLayout.Bands(0).Columns("DEUDA").Header.Caption = "Total Doc."
                ug_Pendientes.DisplayLayout.Bands(0).Columns("DEUDA").CellAppearance.TextHAlign = HAlign.Right
                ug_Pendientes.DisplayLayout.Bands(0).Columns("DEUDA").Style = UltraWinGrid.ColumnStyle.Double
                ug_Pendientes.DisplayLayout.Bands(0).Columns("DEUDA").Format = "###,###.00"

                ug_Pendientes.DisplayLayout.Bands(0).Columns("PAGO").Header.Caption = "Pago / Amortizacion"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("PAGO").CellAppearance.TextHAlign = HAlign.Right
                ug_Pendientes.DisplayLayout.Bands(0).Columns("PAGO").Style = UltraWinGrid.ColumnStyle.Double
                ug_Pendientes.DisplayLayout.Bands(0).Columns("PAGO").Format = "###,###.00"

                ug_Pendientes.DisplayLayout.Bands(0).Columns("SALDO").Header.Caption = "Saldo"
                ug_Pendientes.DisplayLayout.Bands(0).Columns("SALDO").CellAppearance.TextHAlign = HAlign.Right
                ug_Pendientes.DisplayLayout.Bands(0).Columns("SALDO").Style = UltraWinGrid.ColumnStyle.Double
                ug_Pendientes.DisplayLayout.Bands(0).Columns("SALDO").Format = "###,###.00"


                ug_Pendientes.DisplayLayout.Bands(0).Columns("AD_IDANEXO").Width = 100
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AN_NUM_DOC").Width = 200
                ug_Pendientes.DisplayLayout.Bands(0).Columns("AN_DESCRIPCION").Width = 500
                ug_Pendientes.DisplayLayout.Bands(0).Columns("DEUDA").Width = 200
                ug_Pendientes.DisplayLayout.Bands(0).Columns("PAGO").Width = 200
                ug_Pendientes.DisplayLayout.Bands(0).Columns("SALDO").Width = 200

                Call Sumas2()
                Bol_IsGrupo = True
            End If


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_Ruc_Anexo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Ruc_Anexo.EditorButtonClick
        Try
            Call Ayuda_Proveedor_Cab()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
    Private Sub Sumas2()
        Try
            ume_tot_deuda.Value = Format(0, "###,###.00")
            ume_tot_pago.Value = Format(0, "###,###.00")
            ume_Diferencia.Value = Format(0, "###,###.00")

            If Dt_DocumentosCtas.Rows.Count = 0 Then Exit Sub

            Dim sumd As Double = Dt_DocumentosCtas.Compute("sum(DEUDA)", "")
            Dim sump As Double = Dt_DocumentosCtas.Compute("sum(PAGO)", "")
            Dim dif As Double = sumd - sump

            ume_tot_deuda.Value = Format(sumd, "###,###.00")
            ume_tot_pago.Value = Format(sump, "###,###.00")
            ume_Diferencia.Value = Format(dif, "###,###.00")


            lbl_num_doc.Text = "Num. Documentos : " & Dt_DocumentosCtas.Rows.Count & " encontrados"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ug_Pendientes_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Pendientes.DoubleClickRow
        Try
            If Bol_IsGrupo Then
                uchk_Anexo.Checked = True
                txt_Ruc_Anexo.Text = ug_Pendientes.ActiveRow.Cells("AN_NUM_DOC").Value.ToString
                txt_idAnexoDet.Text = ug_Pendientes.ActiveRow.Cells("AD_IDANEXO").Value.ToString
                lbl_Des_Anexo.Text = ug_Pendientes.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
                Call Consultar_Documentos()
            Else
                'aki deberia entrar cuando es detallado por anexo
                'si le damos doble click deberia cargar el formulario del asiento
                'a modo de edicion sin permitir hacer click en los botones
                If e.Row.Band.Index = 1 Then
                    Editar_Voucher(ug_Pendientes.ActiveRow.Cells("AC_ID").Value, ug_Pendientes.ActiveRow.Cells("AC_IDSUBDIARIO").Value)
                End If








            End If

        Catch ex As Exception
            ShowError("ocurrio un error: " & ex.Message)
        End Try
    End Sub

    Private Sub ug_Pendientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Pendientes.KeyDown
        Try
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Escape Then
                If Not Bol_IsGrupo Then
                    uchk_Anexo.Checked = False
                    txt_Ruc_Anexo.Clear()
                    txt_idAnexoDet.Clear()
                    lbl_Des_Anexo.Text = ""
                    Call Consultar_Documentos()
                End If
            End If
            If e.KeyCode = Keys.Enter Then
                If Bol_IsGrupo Then
                    uchk_Anexo.Checked = True
                    txt_Ruc_Anexo.Text = ug_Pendientes.ActiveRow.Cells("AN_NUM_DOC").Value.ToString
                    txt_idAnexoDet.Text = ug_Pendientes.ActiveRow.Cells("AD_IDANEXO").Value.ToString
                    lbl_Des_Anexo.Text = ug_Pendientes.ActiveRow.Cells("AN_DESCRIPCION").Value.ToString
                    Call Consultar_Documentos()
                End If
            End If
        Catch ex As Exception
            ShowError("ocurrio un error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sumas3()
        Try
            ume_tot_deuda.Value = Format(0, "###,###.00")
            ume_tot_pago.Value = Format(0, "###,###.00")
            ume_Diferencia.Value = Format(0, "###,###.00")

            If Ds_Doc_Pendi.Tables(0).Rows.Count = 0 Then Exit Sub

            Dim sumd As Double = Ds_Doc_Pendi.Tables(0).Compute("sum(DEUDA)", "")
            Dim sump As Double = Ds_Doc_Pendi.Tables(0).Compute("sum(PAGO)", "")
            Dim dif As Double = sumd - sump

            ume_tot_deuda.Value = Format(sumd, "###,###.00")
            ume_tot_pago.Value = Format(sump, "###,###.00")
            ume_Diferencia.Value = Format(dif, "###,###.00")


            lbl_num_doc.Text = "Num. Documentos : " & Ds_Doc_Pendi.Tables(0).Rows.Count & " encontrados"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub Editar_Voucher(ByVal IdAsiento As Integer, ByVal Codsubdiario As String)
        Try
            Dim Operacion As Integer = 0
            Dim SubdiarioBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
            Dim SubdiarioBe As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            SubdiarioBe.SD_ID = Codsubdiario
            SubdiarioBe.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Dim Dt As DataTable = SubdiarioBL.getSubdiario(SubdiarioBe)

            If Dt.Rows.Count = 0 Then
                Avisar("No se encontro el subdiario.")
                Exit Sub
            End If

            E_Cabecera.AC_ID = IdAsiento

            Select Case Dt.Rows(0)("SD_IDOPERACION")
                Case 1 'COMPRAS
                    CO_PR_VouCompras.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouCompras.Show()
                    CO_PR_VouCompras.Text = CO_PR_VouCompras.Text & " ( Solo Lectura )"
                    CO_PR_VouCompras.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouCompras.Ocultar_Columnas(True)
                    CO_PR_VouCompras.ubtn_GrabarVoucher.Enabled = False
                    CO_PR_VouCompras.ubtn_Cancelar.Enabled = False
                    CO_PR_VouCompras.btn_Nuevo.Enabled = False
                    CO_PR_VouCompras.btn_ListoCab.Enabled = False

                Case 2 'VENTAS
                    CO_PR_VouVentas.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouVentas.Show()
                    CO_PR_VouVentas.Text = CO_PR_VouVentas.Text & " ( Solo Lectura )"
                    CO_PR_VouVentas.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouVentas.Ocultar_Columnas(True)
                    CO_PR_VouVentas.ubtn_GrabarVoucher.Enabled = False
                    CO_PR_VouVentas.ubtn_Cancelar.Enabled = False
                    CO_PR_VouVentas.btn_Nuevo.Enabled = False
                    CO_PR_VouVentas.btn_ListoCab.Enabled = False

                Case 3 'CAJA Y BANCOS
                    CO_PR_VouCajaBancos.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouCajaBancos.Show()
                    CO_PR_VouCajaBancos.Text = CO_PR_VouCajaBancos.Text & " ( Solo Lectura )"
                    CO_PR_VouCajaBancos.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouCajaBancos.Ocultar_Columnas(True)
                    CO_PR_VouCajaBancos.ubtn_GrabarVoucher.Enabled = False
                    CO_PR_VouCajaBancos.ubtn_Cancelar.Enabled = False
                    CO_PR_VouCajaBancos.btn_Nuevo.Enabled = False


                Case 4 'HONORARIOS
                    CO_PR_VouHonorarios.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouHonorarios.Show()
                    CO_PR_VouHonorarios.Text = CO_PR_VouHonorarios.Text & " ( Solo Lectura )"
                    CO_PR_VouHonorarios.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouHonorarios.Ocultar_Columnas(True)
                    CO_PR_VouHonorarios.ubtn_GrabarVoucher.Enabled = False
                    CO_PR_VouHonorarios.ubtn_Cancelar.Enabled = False
                    CO_PR_VouHonorarios.btn_Nuevo.Enabled = False
                    CO_PR_VouHonorarios.btn_ListoCab.Enabled = False

                Case 5 'GENERALES
                    CO_PR_VouGenerales.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouGenerales.Show()
                    CO_PR_VouGenerales.Text = CO_PR_VouGenerales.Text & " ( Solo Lectura )"
                    CO_PR_VouGenerales.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouGenerales.Ocultar_Columnas(True)
                    CO_PR_VouGenerales.ubtn_GrabarVoucher.Enabled = False
                    CO_PR_VouGenerales.ubtn_Cancelar.Enabled = False
                    CO_PR_VouGenerales.btn_Nuevo.Enabled = False

            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcelMicrosoftOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelMicrosoftOfficeToolStripMenuItem.Click
        Try
            Dim dt As DataTable
            If Bol_IsGrupo Then
                dt = CType(ug_Pendientes.DataSource, DataTable)
            Else
                dt = CType(ug_Pendientes.DataSource, DataSet).Tables(0)
            End If

            Dim Obj_Funciones As New LR.ClsFunciones
            Dim Str_titulo As String = "Doc. Pendientes de la Cuenta : " & uc_Cuentas.Text & " - " & txt_des_cuenta.Text.Trim

            Obj_Funciones.exportar_A_MS_Excel(dt, Str_titulo)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub OpenOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOfficeToolStripMenuItem.Click
        Try
            Dim dt As DataTable
            If Bol_IsGrupo Then
                dt = CType(ug_Pendientes.DataSource, DataTable)
            Else
                dt = CType(ug_Pendientes.DataSource, DataSet).Tables(0)
            End If

            Dim Obj_Funciones As New LR.ClsFunciones
            Dim Str_titulo As String = "Doc. Pendientes de la Cuenta : " & uc_Cuentas.Text & " - " & txt_des_cuenta.Text.Trim

            Obj_Funciones.exportar_A_OO_Calc(dt, Str_titulo)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class
