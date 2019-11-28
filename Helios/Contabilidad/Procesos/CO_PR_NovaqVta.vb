Public Class CO_PR_NovaqVta

    Private Sub CO_PR_NovaqVta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        Call Cargar_Cmb_SubDiario()

        ugb_Caja.Enabled = uchk_Gen_asi_caja.Checked

    End Sub
    Private Sub Cargar_Cmb_SubDiario()

        Dim Obj_SubDBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        Dim E_SD As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
        E_SD.SD_IDOPERACION = New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = gCInt_Ope_Generales}
        E_SD.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        uce_SubDiario.DataSource = Obj_SubDBL.getSubdiarios_x_Modulo(E_SD)
        uce_SubDiario.DisplayMember = "SD_DESCRIPCION"
        uce_SubDiario.ValueMember = "SD_ID"

        E_SD = Nothing
        Obj_SubDBL = Nothing

    End Sub

    Private Sub ubtn_Contabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Contabilizar.Click

        If Not Preguntar("Seguro de Procesar?") Then
            Exit Sub
        End If

        If txt_cta12.Text.Trim.Length = 0 Then
            Avisar("Ingrese la cuenta 12")
            txt_cta12.Focus()
            Exit Sub
        End If

        If txt_cta12Rel.Text.Trim.Length = 0 Then
            Avisar("Ingrese la cuenta 12 relacionada")
            txt_cta12Rel.Focus()
            Exit Sub
        End If


        If txt_cta40.Text.Trim.Length = 0 Then
            Avisar("Ingrese la cuenta 40 de IGV")
            txt_cta40.Focus()
            Exit Sub
        End If



        Try
            Dim ContaBL As New BL.ContabilidadBL.Migrador
            Me.Cursor = Cursors.WaitCursor
            Dim dt_tmp As DataTable = CType(ug_cab.DataSource, DataTable)

            ContaBL.Migrar_Asiento_Ventas_Comercial(CInt(txt_Ayo.Text), uce_Mes.Value, txt_cta12.Text.Trim, txt_cta12Rel.Text.Trim, txt_cta40.Text.Trim, uchk_Gen_asi_caja.Checked, uce_SubDiario.Value, txt_num_cta.Text, dt_tmp)
            Me.Cursor = Cursors.Default
            Call Avisar("Listo!")
            ContaBL = Nothing
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Facturas()

        If txt_Ayo.Text.Trim.Length = 0 Then
            Avisar("Ingrese Año")
            txt_Ayo.Focus()
            Exit Sub
        End If


        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione Mes")
            uce_Mes.Focus()
            Exit Sub
        End If


        Dim ContaBL As New BL.ContabilidadBL.Migrador
        Me.Cursor = Cursors.WaitCursor
        ug_cab.DataSource = ContaBL.get_Cabecera_Ventas_Novaq(CInt(txt_Ayo.Text), uce_Mes.Value)
        Me.Cursor = Cursors.Default
        ContaBL = Nothing

        lbl_num_fac.Text = "Numero de Facturas : " & ug_cab.Rows.Count.ToString

    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_VerFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_VerFac.Click
        Call Cargar_Facturas()
        Call Validar_Doc_inConta()
    End Sub

    Private Sub txt_cta12_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta12.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cta12Rel.Focus()
        End If
    End Sub

    Private Sub txt_cta12Rel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta12Rel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cta40.Focus()
        End If
    End Sub

    Private Sub Validar_Doc_inConta()
        Dim ContaBL As New BL.ContabilidadBL.Migrador

        For i As Integer = 0 To ug_cab.Rows.Count - 1
            With ug_cab.Rows(i)
                If ContaBL.Existe_Doc_de_Venta(.Cells("DOCUMENT_ID").Value, .Cells("NUMBER_SERIE").Value, .Cells("NUMBER_DOCUMENT").Value) Then
                    ug_cab.Rows(i).Cells("CONTA").Value = True
                Else
                    ug_cab.Rows(i).Cells("CONTA").Value = False
                End If
            End With
        Next

        ug_cab.UpdateData()

        ContaBL = Nothing
    End Sub

    Private Sub uchk_Gen_asi_caja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Gen_asi_caja.CheckedChanged
        ugb_Caja.Enabled = uchk_Gen_asi_caja.Checked
    End Sub

    Private Sub txt_Glosa_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_num_cta.Leave

        Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        planctasBE.PC_NUM_CUENTA = txt_num_cta.Text.Trim
        planctasBE.PC_PERIODO = txt_Ayo.Value
        planctasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        planctasBL.getCuenta_X_NumeroCta(planctasBE)

        txt_des_cuenta.Text = planctasBE.PC_DESCRIPCION.ToString

        planctasBE = Nothing
        planctasBL = Nothing

    End Sub
End Class