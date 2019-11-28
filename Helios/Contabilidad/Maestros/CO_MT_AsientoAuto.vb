Imports BE.ContabilidadBE

Public Class CO_MT_AsientoAuto

    Dim Bol_Nuevo As Boolean


    Private Sub CO_MT_AsientoAuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatosListado()
        Call Cargar_Subdiarios()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Cuentas_Det()
        Call Formatear_Grilla_Selector(ug_AsientoAuto)

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click

        uce_SubDiario.Enabled = True
        uce_SubDiario.SelectedIndex = -1
        uos_estadoCab.Value = 1

        Call LimpiaGrid(ug_detalle, uds_AsientoDet)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_AsientoAuto, 1)

        Bol_Nuevo = True
        uce_SubDiario.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            If uce_SubDiario.SelectedIndex = -1 Then
                uce_SubDiario.Focus()
                Exit Sub
            End If

            If ug_detalle.Rows.Count = 0 Then
                ug_detalle.Focus()
                Exit Sub
            End If

            Dim E_AutoCab As New SG_CO_TB_ASIENTO_AUTO_CAB
            Dim Obj_AutoCab As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_CAB

            ug_detalle.UpdateData()

            Dim Id As Integer = 0
            If Not Bol_Nuevo Then Id = ug_AsientoAuto.ActiveRow.Cells("Id").Value


            With E_AutoCab
                .AA_ID = Id
                .AA_IDSUBDIARIO = New SG_CO_TB_SUBDIARIO With {.SD_ID = uce_SubDiario.Value}
                .AA_ANHO = gDat_Fecha_Sis.Year
                .AA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AA_ISTATUS = uos_estadoCab.Value
                .AA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AA_TERMINAL = Environment.MachineName
                .AA_FECREG = Date.Now
            End With


            If Not Bol_Nuevo Then Obj_AutoCab.Delete(E_AutoCab)

            Obj_AutoCab.Insert(E_AutoCab)


            'for  grilla
            For i As Int32 = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells("Cuenta").Value.ToString <> "" Then
                    Dim Obj_AutoDet As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_DET
                    Dim E_AutoDet As New SG_CO_TB_ASIENTO_AUTO_DET
                    With E_AutoDet
                        .AA_IDCAB = E_AutoCab
                        .AA_IDCUENTA = New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = ug_detalle.Rows(i).Cells("Cuenta").Value}

                        If ug_detalle.Rows(i).Cells("Cuenta_Rel").Value.ToString.Equals(String.Empty) Then
                            .AA_IDCUENTA_R = Nothing
                        Else
                            .AA_IDCUENTA_R = New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = ug_detalle.Rows(i).Cells("Cuenta_Rel").Value}
                        End If

                        .AA_IDCONPCETO = New SG_CO_TB_CONCEPTO_REGISTRO With {.CR_ID = ug_detalle.Rows(i).Cells("Concepto").Value}
                        .AA_DH = ug_detalle.Rows(i).Cells("DH").Value '--------------------------------------------------->>1=debe;2=haber
                        .AA_ISTATUS = uos_estadoCab.Value
                        .AA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                        .AA_TERMINAL = Environment.MachineName
                        .AA_FECREG = Date.Now
                        .AA_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = ug_detalle.Rows(i).Cells("Moneda").Value}

                    End With
                    Obj_AutoDet.Insert(E_AutoDet)
                End If
            Next

            Avisar("Listo!")

            Call CargarDatosListado()
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            Bol_Nuevo = False

            If ug_AsientoAuto.Rows.Count = 0 Then Exit Sub

            uce_SubDiario.Value = ug_AsientoAuto.ActiveRow.Cells("Codigo").Value
            uos_estadoCab.Value = IIf(ug_AsientoAuto.ActiveRow.Cells("Estado").Value, 1, 0)
            uce_SubDiario.Enabled = False

            'Cargamos el Detalle

            Dim detalleBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_DET
            Dim asiento_autoBE As New SG_CO_TB_ASIENTO_AUTO_CAB
            Dim detalles As List(Of SG_CO_TB_ASIENTO_AUTO_DET)

            asiento_autoBE.AA_ID = ug_AsientoAuto.ActiveRow.Cells("Id").Value
            detalles = detalleBL.getDetalles(asiento_autoBE)

            Call LimpiaGrid(ug_detalle, uds_AsientoDet)
            Dim i As Integer = 0

            For Each detalle As SG_CO_TB_ASIENTO_AUTO_DET In detalles

                ug_detalle.DisplayLayout.Bands(0).AddNew()
                ug_detalle.Rows(i).Cells("Cuenta").Value = detalle.AA_IDCUENTA.PC_IDCUENTA
                ug_detalle.Rows(i).Cells("Moneda").Value = detalle.AA_IDMONEDA.MO_CODIGO

                If Not detalle.AA_IDCUENTA_R Is Nothing Then
                    ug_detalle.Rows(i).Cells("Cuenta_Rel").Value = detalle.AA_IDCUENTA_R.PC_IDCUENTA
                End If

                ug_detalle.Rows(i).Cells("DH").Value = detalle.AA_DH
                ug_detalle.Rows(i).Cells("Concepto").Value = detalle.AA_IDCONPCETO.CR_ID

                i += 1
            Next

            ug_detalle.UpdateData()
            ug_detalle.DisplayLayout.Bands(0).AddNew()

            asiento_autoBE = Nothing
            detalleBL = Nothing

            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_AsientoAuto, 1)
            ug_detalle.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_AsientoAuto, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Not Preguntar("Esta seguro?") Then Exit Sub

            Dim Obj_cab As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_CAB
            Dim E_cab As New SG_CO_TB_ASIENTO_AUTO_CAB
            E_cab.AA_ID = ug_AsientoAuto.ActiveRow.Cells("Id").Value
            Obj_cab.Delete(E_cab)

            Call CargarDatosListado()
            Avisar("    Listo!  ")

            E_cab = Nothing
            Obj_cab = Nothing


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub


    Private Sub CargarDatosListado()
        Try
            Dim AutoCabBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_CAB
            Dim Dt_Listado As DataTable = Nothing
            Dim AutocabBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB

            AutocabBE.AA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            AutocabBE.AA_ANHO = gDat_Fecha_Sis.Year

            Dt_Listado = AutoCabBL.getAutoCab(AutocabBE)

            Call LimpiaGrid(ug_AsientoAuto, uds_AsientoAuto)

            For i As Integer = 0 To Dt_Listado.Rows.Count - 1
                With Dt_Listado.Rows(i)
                    ug_AsientoAuto.DisplayLayout.Bands(0).AddNew()
                    ug_AsientoAuto.Rows(i).Cells("Id").Value = .Item("AA_ID")
                    ug_AsientoAuto.Rows(i).Cells("Estado").Value = .Item("AA_ISTATUS")
                    ug_AsientoAuto.Rows(i).Cells("Codigo").Value = .Item("AA_IDSUBDIARIO")
                    ug_AsientoAuto.Rows(i).Cells("Descripcion").Value = .Item("SD_DESCRIPCION")
                End With
            Next
            '4557880200069361

            ug_AsientoAuto.UpdateData()

            Dt_Listado.Dispose()
            Dt_Listado = Nothing

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Subdiarios()
        Try
            Dim ObjSUbdiario As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
            Dim E_subdiario As New SG_CO_TB_SUBDIARIO With {.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}

            uce_SubDiario.DataSource = ObjSUbdiario.getSubdiarios(E_subdiario)
            uce_SubDiario.DisplayMember = "SD_DESCRIPCION"
            uce_SubDiario.ValueMember = "SD_ID"

            uce_SubDiario.SelectedIndex = -1

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cuentas_Det()

        Dim Obj_PlanCtas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim E_PlanCtas As New SG_CO_TB_PLANCTAS

        With E_PlanCtas
            .PC_PERIODO = gDat_Fecha_Sis.Year
            .PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        udd_Cuenta.DataSource = Obj_PlanCtas.getCuentas_Movimiento(E_PlanCtas)

        Call CrearComboGrid("DH", "NOMBRE", ug_detalle, CrearTablaTipoDH, True)


        Dim Obj_ConceptosBL As New BL.ContabilidadBL.SG_CO_TB_CONCEPTO_REGISTRO
        Call CrearComboGrid("CONCEPTO", "CR_DESCRIPCION", ug_detalle, Obj_ConceptosBL.getConceptos, True)

        Obj_ConceptosBL = Nothing


        Dim monedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
        Call CrearComboGrid("Moneda", "MO_DESCRIPCION", ug_detalle, monedaBL.getMonedas_dt, True)
        monedaBL = Nothing

    End Sub
    Public Function CrearTablaTipoDH() As DataTable
        Dim Dt_dh As New DataTable
        Dim dr As DataRow
        Dt_dh.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        Dt_dh.Columns.Add("NOMBRE", Type.GetType("System.String"))
        dr = Dt_dh.NewRow
        dr.Item("CODIGO") = 1
        dr.Item("NOMBRE") = "DEBE"
        Dt_dh.Rows.Add(dr)
        dr = Dt_dh.NewRow
        dr.Item("CODIGO") = 2
        dr.Item("NOMBRE") = "HABER"
        Dt_dh.Rows.Add(dr)
        Return Dt_dh

    End Function

    Private Sub ug_AsientoAuto_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_AsientoAuto.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub uce_SubDiario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_SubDiario.ValueChanged
        Try

            If Bol_Nuevo Then
                Dim Obj_AutoCab As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_AUTO_CAB
                Dim Dt_Listado As DataTable = Nothing
                Dim E_autocab As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_AUTO_CAB

                E_autocab.AA_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                E_autocab.AA_ANHO = gDat_Fecha_Sis.Year

                Dt_Listado = Obj_AutoCab.getAutoCab(E_autocab)

                Dim Drfilita As DataRow() = Dt_Listado.Select(String.Format("AA_IDSUBDIARIO='{0}'", uce_SubDiario.Value))
                If Drfilita.Length > 0 Then
                    Avisar("El subdiario ya tiene unas cuentas establecidas. " & vbCrLf & "Seleccione otro!!")
                    uce_SubDiario.Focus()
                    uce_SubDiario.SelectedIndex = -1
                End If

                Obj_AutoCab = Nothing
                Dt_Listado.Dispose()
                Dt_Listado = Nothing
                E_autocab = Nothing
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class
