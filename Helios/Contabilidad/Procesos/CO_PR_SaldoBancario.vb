Public Class CO_PR_SaldoBancario

    Dim Bol_Nuevo As Boolean = False
    Dim Bol_Consulta As Boolean = False

    Private Sub CO_PR_SaldoBancario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ugb_Parametros.Enabled = False
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Items.Add(0, "Saldo Inicial")
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Combos_Bancos()
        Call Inicializar_Estado_Botones_Tool(ToolS_SaldoBanco)
        Call Formatear_Grilla_Selector(ug_Saldos)
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Cargar_Datos()
        Try
            Dim SaldoBL As New BL.ContabilidadBL.SG_CO_TB_SALDO_MOV_BANCO
            Dim SaldoBE As New BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO
            Dim Dt_saldos As DataTable = Nothing

            SaldoBE.SMB_ANHO = gDat_Fecha_Sis.Year
            SaldoBE.SMB_CUENTA = uce_CtasCorrientes.Value
            SaldoBE.SMB_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'saldos = SaldoBL.getSaldos(SaldoBE)
            Dt_saldos = SaldoBL.getSaldos_dt(SaldoBE)

            Call LimpiaGrid(ug_Saldos, uds_Saldos)

            For i As Integer = 0 To Dt_saldos.Rows.Count - 1
                ug_Saldos.DisplayLayout.Bands(0).AddNew()
                ug_Saldos.Rows(i).Cells("SMB_ANHO").Value = Dt_saldos.Rows(i)("SMB_ANHO")
                ug_Saldos.Rows(i).Cells("SMB_MES").Value = Dt_saldos.Rows(i)("SMB_MES")
                ug_Saldos.Rows(i).Cells("SMB_CUENTA").Value = Dt_saldos.Rows(i)("SMB_CUENTA")
                ug_Saldos.Rows(i).Cells("PC_NUM_CUENTA").Value = Dt_saldos.Rows(i)("PC_NUM_CUENTA")
                ug_Saldos.Rows(i).Cells("SMB_SALDO").Value = Dt_saldos.Rows(i)("SMB_SALDO")
                ug_Saldos.Rows(i).Cells("SMB_IDEMPRESA").Value = Dt_saldos.Rows(i)("SMB_IDEMPRESA")
            Next

            ug_Saldos.UpdateData()

            SaldoBL = Nothing
            SaldoBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
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

    Private Sub uce_Mes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Mes.KeyDown
        If e.KeyCode = Keys.Delete Then
            uce_Mes.SelectedIndex = -1
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Bol_Nuevo = True
            Bol_Consulta = False
            ugb_Parametros.Enabled = True
            uce_Bancos.Enabled = True
            une_Ayo.Enabled = True
            uce_Mes.Enabled = True
            ume_saldo.Enabled = True
            uce_CtasCorrientes.Enabled = True
            ume_saldo.Value = 0
            Call Cambiar_Estado_Botones_Tool(ToolS_SaldoBanco)
            uce_Bancos.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            Dim SaldoBE As New BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO
            Dim SaldoBL As New BL.ContabilidadBL.SG_CO_TB_SALDO_MOV_BANCO

            With SaldoBE
                .SMB_ANHO = une_Ayo.Value
                .SMB_MES = uce_Mes.Value
                .SMB_CUENTA = uce_CtasCorrientes.Value
                .SMB_SALDO = ume_saldo.Value
                .SMB_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            If Bol_Nuevo Then
                SaldoBL.Insert(SaldoBE)
            Else
                SaldoBL.Update(SaldoBE)
            End If

            SaldoBE = Nothing
            SaldoBL = Nothing

            Call Limpiar_Controls_InGroupox(ugb_Parametros)

            une_Ayo.Value = gDat_Fecha_Sis.Year
            uce_Mes.Value = gDat_Fecha_Sis.Month

            ugb_Parametros.Enabled = False
            Avisar("Listo!")

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_Saldos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Saldos.DoubleClick
        Try
            If Bol_Consulta Then Exit Sub

            Bol_Nuevo = False

            With ug_Saldos.ActiveRow
                une_Ayo.Value = .Cells("SMB_ANHO").Value
                uce_Mes.Value = .Cells("SMB_MES").Value
                ume_saldo.Value = .Cells("SMB_SALDO").Value
                uce_CtasCorrientes.Value = .Cells("SMB_CUENTA").Value
            End With


            Dim SaldoBL As New BL.ContabilidadBL.SG_CO_TB_SALDO_MOV_BANCO
            uce_Bancos.Value = SaldoBL.getBancoId_x_CtaCteId(uce_CtasCorrientes.Value)
            SaldoBL = Nothing

            uce_Bancos.Enabled = False
            une_Ayo.Enabled = False
            uce_Mes.Enabled = False
            uce_CtasCorrientes.Enabled = False

            Call Cambiar_Estado_Botones_Tool(ToolS_SaldoBanco)
            ugb_Parametros.Enabled = True

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            If Bol_Consulta Then
                Call Inicializar_Estado_Botones_Tool(ToolS_SaldoBanco)
                Exit Sub
            End If

            ugb_Parametros.Enabled = False
            Call Cambiar_Estado_Botones_Tool(ToolS_SaldoBanco)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_CtasCorrientes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_CtasCorrientes.ValueChanged
        Call Cargar_Datos()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Try
            Bol_Nuevo = False
            Bol_Consulta = True

            uce_Bancos.Enabled = True
            une_Ayo.Enabled = False
            'uce_Mes.Enabled = True
            uce_CtasCorrientes.Enabled = True
            ume_saldo.Enabled = False
            ugb_Parametros.Enabled = True

            Tool_Editar.Enabled = False
            Tool_Cancelar.Enabled = True
            Tool_Eliminar.Enabled = False
            Tool_Grabar.Enabled = False
            Tool_Nuevo.Enabled = False
            Tool_Salir.Enabled = False

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        'Validar_______________________________________________

        If une_Ayo.Value Is Nothing Then
            Avisar("Ingrese año")
            Exit Sub
        End If

        If uce_Mes.Value Is Nothing Or uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione Mes")
            Exit Sub
        End If

        If uce_CtasCorrientes.Value Is Nothing Or uce_CtasCorrientes.SelectedIndex = -1 Then
            Avisar("Seleccione Cuenta Corriente")
            Exit Sub
        End If

        'Preguntar_______________________________________________

        If Preguntar("Esta seguro de eliminar?") Then

            Dim saldoBE As New BE.ContabilidadBE.SG_CO_TB_SALDO_MOV_BANCO
            Dim saldoBL As New BL.ContabilidadBL.SG_CO_TB_SALDO_MOV_BANCO

            saldoBE.SMB_ANHO = une_Ayo.Value
            saldoBE.SMB_MES = uce_Mes.Value
            saldoBE.SMB_CUENTA = uce_CtasCorrientes.Value
            saldoBE.SMB_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            saldoBL.Delete(saldoBE)

            Call Avisar("Eliminado!")

            saldoBE = Nothing
            saldoBL = Nothing
        End If

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        ugb_Parametros.Enabled = True
        'uce_Mes.Enabled = True
        Bol_Consulta = False
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Datos()
    End Sub
End Class