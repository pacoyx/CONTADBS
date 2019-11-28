Public Class CO_MT_RegCompraVentaHono

    Private Sub CO_MT_RegCompraVentaHono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Operacion()
        Call Cargar_PlanCuentas_Ayuda()
        ug_cuentas.Enabled = False
    End Sub

    Private Sub Cargar_Operacion()
        Try
            Dim OperacionBL As New BL.ContabilidadBL.SG_CO_TB_OPERACION
            Dim operaciones As New List(Of BE.ContabilidadBE.SG_CO_TB_OPERACION)
            OperacionBL.getOperaciones(operaciones)

            If operaciones.Count > 0 Then
                uce_Operacion.DataSource = operaciones
                uce_Operacion.DisplayMember = "OP_DESCRIPCION"
                uce_Operacion.ValueMember = "OP_CODIGO"
            End If


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Tipo_Cuenta()
        Try
            LimpiaGrid(ug_cuentas, uds_cuentas)
            Dim TipoCuentaBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_CUENTA
            lb_tiposCta.DataSource = TipoCuentaBL.getTipos_x_Operacion(New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value})
            lb_tiposCta.DisplayMember = "TC_DESCRIPCION"
            lb_tiposCta.ValueMember = "TC_ID"
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cuentas_por_Tipo()
        Try
            Dim RegistrosBL As New BL.ContabilidadBL.SG_CO_TB_REG_COM_VTA_HON
            Dim RegistrosBE As New BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON
            Dim registros As New List(Of BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON)

            With RegistrosBE
                .RE_ID_OPERACION = New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value}
                .RE_ID_TIPOCUENTA = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA With {.TC_ID = lb_tiposCta.SelectedValue}
                .RE_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .RE_ANHO = gDat_Fecha_Sis.Year
            End With

            registros = RegistrosBL.getRegistros(RegistrosBE)

            Call LimpiaGrid(ug_cuentas, uds_cuentas)

            For i As Integer = 0 To registros.Count - 1
                ug_cuentas.DisplayLayout.Bands(0).AddNew()
                ug_cuentas.Rows(i).Cells("NUM_CTA").Value = registros(i).RE_NUM_CTA.PC_NUM_CUENTA
            Next
            ug_cuentas.UpdateData()
            ug_cuentas.DisplayLayout.Bands(0).AddNew()

            If ug_cuentas.Rows.Count > 0 Then ug_cuentas.Rows(0).Selected = True

            registros = Nothing
            RegistrosBE = Nothing
            RegistrosBL = Nothing


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_PlanCuentas_Ayuda()
        Try
            Dim Obj_PlanCtas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            With E_PlanCtas
                .PC_PERIODO = gDat_Fecha_Sis.Year
                .PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With
            udd_Cuenta.DataSource = Obj_PlanCtas.getCuentas_DT(E_PlanCtas)

            E_PlanCtas = Nothing

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub lb_tiposCta_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_tiposCta.DoubleClick
        Call Cargar_Cuentas_por_Tipo()
        ug_cuentas.Enabled = True
    End Sub

    Private Sub uce_Operacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Operacion.ValueChanged
        Call Cargar_Tipo_Cuenta()
    End Sub

    Private Sub ubtn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ug_cuentas_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_cuentas.AfterRowUpdate
        'Avisar(ug_cuentas.ActiveRow.Cells("num_cta").Text)
        Try
            Dim SG_CO_TB_REG_COM_VTA_HONBE As New BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON
            Dim SG_CO_TB_REG_COM_VTA_HONBL As New BL.ContabilidadBL.SG_CO_TB_REG_COM_VTA_HON

            With SG_CO_TB_REG_COM_VTA_HONBE
                .RE_ID_OPERACION = New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value}
                .RE_ID_TIPOCUENTA = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA With {.TC_ID = lb_tiposCta.SelectedValue}
                .RE_NUM_CTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = ug_cuentas.ActiveRow.Cells("num_cta").Text.Trim}
                .RE_ANHO = gDat_Fecha_Sis.Year
                .RE_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            SG_CO_TB_REG_COM_VTA_HONBL.Delete(SG_CO_TB_REG_COM_VTA_HONBE)
            SG_CO_TB_REG_COM_VTA_HONBL.Insert(SG_CO_TB_REG_COM_VTA_HONBE)

            SG_CO_TB_REG_COM_VTA_HONBE = Nothing
            SG_CO_TB_REG_COM_VTA_HONBL = Nothing


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_cuentas_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_cuentas.BeforeRowsDeleted
        Try


            Dim SG_CO_TB_REG_COM_VTA_HONBE As New BE.ContabilidadBE.SG_CO_TB_REG_COM_VTA_HON
            Dim SG_CO_TB_REG_COM_VTA_HONBL As New BL.ContabilidadBL.SG_CO_TB_REG_COM_VTA_HON

            With SG_CO_TB_REG_COM_VTA_HONBE
                .RE_ID_OPERACION = New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value}
                .RE_ID_TIPOCUENTA = New BE.ContabilidadBE.SG_CO_TB_TIPO_CUENTA With {.TC_ID = lb_tiposCta.SelectedValue}
                .RE_NUM_CTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = ug_cuentas.ActiveRow.Cells("num_cta").Text.Trim}
                .RE_ANHO = gDat_Fecha_Sis.Year
                .RE_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            SG_CO_TB_REG_COM_VTA_HONBL.Delete(SG_CO_TB_REG_COM_VTA_HONBE)

            SG_CO_TB_REG_COM_VTA_HONBE = Nothing
            SG_CO_TB_REG_COM_VTA_HONBL = Nothing



        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class