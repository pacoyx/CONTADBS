Imports BE.ContabilidadBE

Public Class CO_MT_Banco_CtasCorrientes

    Dim CtasCorrientesBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CTACTE
    Public Int_IdBanco As Integer
    Dim Bol_Nuevo As Boolean


    Private Sub CO_MT_Banco_CtasCorrientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Cargar_Cuentas_Combo()
        Call Inicializar_Estado_Botones_Tool(ToolS_Bancos)
        Call MostrarTabs(0, utc_CtasCorrientes, 0)
        Call Formatear_Grilla_Selector(ug_Cuentas)
    End Sub
    
    Private Sub CargarDatos()
        Try
            Dim Bancos As New List(Of SG_CO_TB_BANCO_CTACTE)
            Bancos = CtasCorrientesBL.getCtasCorrientes(New SG_CO_TB_BANCO_CTACTE With {.BC_IDBANCO = New SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}})

            Call LimpiaGrid(ug_Cuentas, uds_CtasCorri)

            Dim i As Integer = 0
            For Each banco As SG_CO_TB_BANCO_CTACTE In Bancos
                ug_Cuentas.DisplayLayout.Bands(0).AddNew()
                ug_Cuentas.Rows(i).Cells("BC_IDBANCO").Value = banco.BC_IDBANCO.BA_ID
                ug_Cuentas.Rows(i).Cells("BC_ID_CTA").Value = banco.BC_ID_CTA
                ug_Cuentas.Rows(i).Cells("BC_NUMERO_CTA").Value = banco.BC_NUMERO_CTA
                ug_Cuentas.Rows(i).Cells("BC_DESCRIPCION").Value = banco.BC_DESCRIPCION
                ug_Cuentas.Rows(i).Cells("BC_FECHA_APERTURA").Value = banco.BC_FECHA_APERTURA
                ug_Cuentas.Rows(i).Cells("BC_FORMATO_CHEQUE").Value = banco.BC_FORMATO_CHEQUE
                i += 1
            Next
            ug_Cuentas.UpdateData()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cuentas_Combo()
        Try
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            uc_Cuentas.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)

            E_PlanCtas = Nothing
            Obj_PlanCtasBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_CtasCorrientes, 1)
            Call Limpiar_Controls_InGroupox(ugb_data)
            ume_fecApe.Value = Nothing
            ume_fecCie.Value = Nothing
            Bol_Nuevo = True
            txt_numCta.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_numCta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_numCta.KeyDown, ume_fecCie.KeyDown, ume_fecApe.KeyDown, txt_ultimoChk.KeyDown, txt_des.KeyDown, txt_formatoCheque.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uc_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ultimoChk.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            uc_Cuentas.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub uc_Cuentas_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uc_Cuentas.ValueChanged
        Try
            lbl_des_cta.Text = uc_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta.Text = "*La cuenta no existe!"
            lbl_des_cta.Appearance.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(0, utc_CtasCorrientes, 0)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If ug_Cuentas.Rows.Count = 0 Then Exit Sub
            If ug_Cuentas.ActiveRow Is Nothing Then Exit Sub
            If Preguntar("Esta seguro de eliminar?") Then
                CtasCorrientesBL.Delete(New SG_CO_TB_BANCO_CTACTE With {.BC_ID_CTA = ug_Cuentas.ActiveRow.Cells("BC_ID_CTA").Value})
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            'Validar los datos de entrada
            If Not Validar() Then Exit Sub

            Dim CuentaBE As New SG_CO_TB_BANCO_CTACTE
            Dim id As Integer = 0
            If Not Bol_Nuevo Then id = ug_Cuentas.ActiveRow.Cells("BC_ID_CTA").Value

            With CuentaBE
                .BC_ID_CTA = id
                .BC_IDBANCO = New SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}
                .BC_NUMERO_CTA = txt_numCta.Text.Trim
                .BC_DESCRIPCION = txt_des.Text.Trim
                .BC_IDCUENTA = New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas.Value}
                .BC_ULTIMO_CHEQUE = txt_ultimoChk.Text.Trim
                .BC_FECHA_APERTURA = IIf(ume_fecApe.Value.ToString.Length = 0, "", ume_fecApe.Value)
                .BC_FECHA_CIERRE = IIf(ume_fecCie.Value.ToString.Length = 0, "", ume_fecCie.Value)

                .BC_ISTATUS = 1
                .BC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .BC_TERMINAL = Environment.MachineName
                .BC_FECREG = Date.Now
                .BC_FORMATO_CHEQUE = txt_formatoCheque.Text.Trim
                .BC_PERIODO = gDat_Fecha_Sis.Year
            End With

            If Bol_Nuevo Then CtasCorrientesBL.Insert(CuentaBE) Else CtasCorrientesBL.Update(CuentaBE)

            Call Avisar("Listo!")
            Call CargarDatos()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Validar = False
        Try
            If txt_numCta.Text.Trim.Length = 0 Then
                Avisar("Ingrese un numero de cuenta corriente")
                txt_numCta.Focus()
                Exit Function
            End If

            If uc_Cuentas.Value = Nothing Then
                Avisar("Selecciona una cuenta contable")
                uc_Cuentas.Focus()
                Exit Function
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            Dim Cuenta As New SG_CO_TB_BANCO_CTACTE With {.BC_ID_CTA = ug_Cuentas.ActiveRow.Cells("BC_ID_CTA").Value}
            CtasCorrientesBL.getCtasCorriente(Cuenta)

            Call Limpiar_Controls_InGroupox(ugb_data)

            ume_fecApe.Value = Nothing
            ume_fecCie.Value = Nothing

            txt_numCta.Text = Cuenta.BC_NUMERO_CTA
            txt_des.Text = Cuenta.BC_DESCRIPCION
            uc_Cuentas.Value = Cuenta.BC_IDCUENTA.PC_IDCUENTA
            txt_ultimoChk.Text = Cuenta.BC_ULTIMO_CHEQUE
            ume_fecApe.Value = IIf(Cuenta.BC_FECHA_APERTURA.Equals(String.Empty), Nothing, Cuenta.BC_FECHA_APERTURA)
            ume_fecCie.Value = IIf(Cuenta.BC_FECHA_CIERRE.Equals(String.Empty), Nothing, Cuenta.BC_FECHA_CIERRE)
            txt_formatoCheque.Text = IIf(Cuenta.BC_FORMATO_CHEQUE.Equals(String.Empty), Nothing, Cuenta.BC_FORMATO_CHEQUE)
            Call Cambiar_Estado_Botones_Tool(ToolS_Bancos)
            Call MostrarTabs(1, utc_CtasCorrientes, 1)
            txt_numCta.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_Cuentas_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Cuentas.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub
End Class