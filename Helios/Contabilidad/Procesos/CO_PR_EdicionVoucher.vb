Public Class CO_PR_EdicionVoucher

    Private Sub CP_PR_EdicionVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Operaciones()
        Call Formatear_Grilla_Selector(ug_Vouchers)


        If gStr_Usuario_Sis = "jascenzo" Then
            uce_Operacion.Value = "3"
            uce_Operacion.Enabled = False
            uce_SubDiario.Value = "05"
            uce_SubDiario.Enabled = False
            Tool_Eliminar.Text = "Anular"
        Else
            uce_Operacion.Enabled = True
            uce_Operacion.SelectedIndex = -1
            uce_SubDiario.SelectedIndex = -1
            uce_SubDiario.Enabled = True
            Tool_Eliminar.Text = "Eliminar"
        End If


    End Sub

    Private Sub Cargar_Operaciones()
        Try

            Dim Obj_OperacionesBL As New BL.ContabilidadBL.SG_CO_TB_OPERACION
            Dim operaciones As New List(Of BE.ContabilidadBE.SG_CO_TB_OPERACION)

            Obj_OperacionesBL.getOperaciones(operaciones)
            uce_Operacion.DataSource = operaciones
            uce_Operacion.DisplayMember = "OP_DESCRIPCION"
            uce_Operacion.ValueMember = "OP_CODIGO"

            Obj_OperacionesBL = Nothing

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_Operacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Operacion.ValueChanged
        Try
            'Cargamos los subdiarios por operacion seleccionada
            If uce_Operacion.SelectedIndex = -1 Then Exit Sub

            Dim SubDiarioBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
            Dim SubDiarioBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            SubDiarioBE.SD_IDOPERACION = New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value}
            SubDiarioBE.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_SubDiario.DataSource = SubDiarioBL.getSubdiarios_x_Modulo(SubDiarioBE)
            uce_SubDiario.ValueMember = "SD_ID"
            uce_SubDiario.DisplayMember = "SD_DESCRIPCION"

            SubDiarioBL = Nothing
            SubDiarioBE = Nothing

            Call LimpiaGrid(ug_Vouchers, uds_Vouchers)

            uce_SubDiario.SelectedIndex = -1
            'uce_Mes.SelectedIndex = -1

            'bloquemos los botones de impresion de cheque y voucher caja sino es "CAJA BANCOS"

            Dim OperacionBL As New BL.ContabilidadBL.SG_CO_TB_OPERACION
            Dim OperacionBE As New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value}

            If OperacionBL.EsCajaBancos(OperacionBE) Then
                Tool_Cheque.Enabled = True
                Tool_VoucherCheque.Enabled = True
                ug_Vouchers.DisplayLayout.Bands(0).Columns("AC_ES_IMPRESO").Hidden = False
            Else
                Tool_Cheque.Enabled = False
                Tool_VoucherCheque.Enabled = False
                ug_Vouchers.DisplayLayout.Bands(0).Columns("AC_ES_IMPRESO").Hidden = True
            End If

            OperacionBE = Nothing
            OperacionBL = Nothing

            uce_SubDiario.SelectedIndex = 0

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub


    Friend Sub Cargar_Vouchers(ByVal subdiario As String, ByVal mes As Integer)
        Try
            Dim ObjAsiento As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            E_Cabecera.AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = subdiario}
            E_Cabecera.AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Cabecera.AC_ANHO = gDat_Fecha_Sis.Year
            E_Cabecera.AC_MES = mes

            Call LimpiaGrid(ug_Vouchers, uds_Vouchers)
            Dim dt As DataTable = ObjAsiento.getVouchers(E_Cabecera)
            ug_Vouchers.DataSource = dt
            ug_Vouchers.UpdateData()
            ug_Vouchers.Refresh()

            lbl_total.Text = "Total de Registros : " & dt.Rows.Count

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Actualizar_Cargar_Vouchers(ByVal subdiario As String, ByVal mes As Integer)
        Try
            Dim Str_Voucher As String = String.Empty
            If ug_Vouchers.Rows.Count > 0 Then
                Str_Voucher = ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value.ToString
            End If


            Dim ObjAsiento As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            E_Cabecera.AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = subdiario}
            E_Cabecera.AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Cabecera.AC_ANHO = gDat_Fecha_Sis.Year
            E_Cabecera.AC_MES = mes

            Call LimpiaGrid(ug_Vouchers, uds_Vouchers)
            Dim dt As DataTable = ObjAsiento.getVouchers(E_Cabecera)
            ug_Vouchers.DataSource = dt

            If Not Str_Voucher.Equals(String.Empty) Then
                For i As Integer = 0 To ug_Vouchers.Rows.Count - 1
                    If ug_Vouchers.Rows(i).Cells("AC_NUM_VOUCHER").Value.ToString.Equals(Str_Voucher) Then
                        ug_Vouchers.Rows(i).Activate()
                        Exit Sub
                    End If
                Next
            End If


        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Voucher_II(ByVal subdiario As String, ByVal mes As Integer)
        Try

            Dim ObjAsiento As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            E_Cabecera.AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = subdiario}
            E_Cabecera.AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Cabecera.AC_ANHO = gDat_Fecha_Sis.Year
            E_Cabecera.AC_MES = mes

            Call LimpiaGrid(ug_Vouchers, uds_Vouchers)
            Dim dt As DataTable = ObjAsiento.getVouchers(E_Cabecera)
            ug_Vouchers.DataSource = dt
            ug_Vouchers.UpdateData()
            ug_Vouchers.Refresh()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Activar_Fila_x_NumVoucher(ByVal Str_Num_Voucher As String)
        Try
            For i As Integer = 0 To ug_Vouchers.Rows.Count - 1
                If ug_Vouchers.Rows(i).Cells(1).Value.ToString.Trim.Equals(Str_Num_Voucher) Then
                    ug_Vouchers.Rows(i).Cells(1).Activate()
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Vouchers(uce_SubDiario.Value, uce_Mes.Value)
    End Sub

    Private Sub Editar_Voucher()
        Try
            If ug_Vouchers.Rows.Count = 0 Then Exit Sub
            If ug_Vouchers.ActiveRow.Index < 0 Then Exit Sub

            Dim Bol_estado As Boolean
            Call Verificar_Mes_Cerrado(gDat_Fecha_Sis.Year, uce_Mes.Value, Bol_estado)

            If Bol_estado Then Exit Sub
            If ug_Vouchers.ActiveRow Is Nothing Then Exit Sub
            If ug_Vouchers.Rows.Count = 0 Then Exit Sub

            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim num_voucher As String = ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value
            Dim fec_voucher As Date = ug_Vouchers.ActiveRow.Cells("AC_FEC_VOUCHER").Value

            E_Cabecera.AC_ID = asientoBL.get_Id_asiento(num_voucher, gInt_IdEmpresa, fec_voucher.ToShortDateString)

            'E_Cabecera.AC_ID = ug_Vouchers.ActiveRow.Cells("AC_ID").Value

            asientoBL = Nothing

            Select Case uce_Operacion.Value
                Case 1 'COMPRAS
                    CO_PR_VouCompras.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouCompras.Show()
                    CO_PR_VouCompras.Text = CO_PR_VouCompras.Text & " ( Edicion )"
                    CO_PR_VouCompras.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouCompras.Ocultar_Columnas(True)
                    CO_PR_VouCompras.txt_Glosa.Focus()

                Case 2 'VENTAS
                    CO_PR_VouVentas.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouVentas.Show()
                    CO_PR_VouVentas.Text = CO_PR_VouVentas.Text & " ( Edicion )"
                    CO_PR_VouVentas.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouVentas.Ocultar_Columnas(True)
                    CO_PR_VouVentas.txt_Glosa.Focus()

                Case 3 'CAJA Y BANCOS
                    CO_PR_VouCajaBancos.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouCajaBancos.Show()
                    CO_PR_VouCajaBancos.Text = CO_PR_VouCajaBancos.Text & " ( Edicion )"
                    CO_PR_VouCajaBancos.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouCajaBancos.Ocultar_Columnas(True)
                    CO_PR_VouCajaBancos.txt_Glosa.Focus()

                Case 4 'HONORARIOS
                    CO_PR_VouHonorarios.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouHonorarios.Show()
                    CO_PR_VouHonorarios.Text = CO_PR_VouHonorarios.Text & " ( Edicion )"
                    CO_PR_VouHonorarios.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouHonorarios.Ocultar_Columnas(True)
                    CO_PR_VouHonorarios.txt_Glosa.Focus()

                Case 5 'GENERALES
                    CO_PR_VouGenerales.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouGenerales.Show()
                    CO_PR_VouGenerales.Text = CO_PR_VouGenerales.Text & " ( Edicion )"
                    CO_PR_VouGenerales.CargarVoucher_toEdit(E_Cabecera)
                    CO_PR_VouGenerales.Ocultar_Columnas(True)
                    CO_PR_VouGenerales.txt_Glosa.Focus()

            End Select

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Copiar_Voucher()
        Try
            If ug_Vouchers.ActiveRow Is Nothing Then
                Exit Sub
            End If

            If ug_Vouchers.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            E_Cabecera.AC_ID = ug_Vouchers.ActiveRow.Cells("AC_ID").Value

            Select Case uce_Operacion.Value
                Case 1 'COMPRAS
                    CO_PR_VouCompras.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouCompras.Show()
                    CO_PR_VouCompras.CargarVoucher_to_Copy(E_Cabecera)
                    CO_PR_VouCompras.Ocultar_Columnas(True)
                    CO_PR_VouCompras.Text = CO_PR_VouCompras.Text & " ( Copiar )"

                Case 2 'VENTAS
                    CO_PR_VouVentas.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouVentas.Show()
                    CO_PR_VouVentas.CargarVoucher_to_Copy(E_Cabecera)
                    CO_PR_VouVentas.Ocultar_Columnas(True)
                    CO_PR_VouVentas.Text = CO_PR_VouVentas.Text & " ( Copiar )"

                Case 3 'CAJA Y BANCOS
                    CO_PR_VouCajaBancos.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouCajaBancos.Show()
                    CO_PR_VouCajaBancos.CargarVoucher_to_Copy(E_Cabecera)
                    CO_PR_VouCajaBancos.Ocultar_Columnas(True)
                    CO_PR_VouCajaBancos.Text = CO_PR_VouCajaBancos.Text & " ( Copiar )"

                Case 4 'HONORARIOS
                    CO_PR_VouHonorarios.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouHonorarios.Show()
                    CO_PR_VouHonorarios.CargarVoucher_to_Copy(E_Cabecera)
                    CO_PR_VouHonorarios.Ocultar_Columnas(True)
                    CO_PR_VouHonorarios.Text = CO_PR_VouHonorarios.Text & " ( Copiar )"
                Case 5 'GENERALES
                    CO_PR_VouGenerales.MdiParent = CO_MN_MenuInicial
                    CO_PR_VouGenerales.Show()
                    CO_PR_VouGenerales.CargarVoucher_to_Copy(E_Cabecera)
                    CO_PR_VouGenerales.Ocultar_Columnas(True)
                    CO_PR_VouGenerales.Text = CO_PR_VouGenerales.Text & " ( Copiar )"
            End Select

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub ug_Vouchers_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Vouchers.DoubleClickRow
        Call Editar_Voucher()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Vouchers.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim Num As String = ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value.ToString
        Dim fecha As String = ug_Vouchers.ActiveRow.Cells("AC_FEC_VOUCHER").Value.ToString

        If Preguntar(String.Format("Seguro de Eliminar el voucher Nº{0} con fecha : {1}", Num, fecha)) Then

            Dim Obj_asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Asiento_Cab As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            E_Asiento_Cab.AC_ID = ug_Vouchers.ActiveRow.Cells("AC_ID").Value

            Dim OperacionBL As New BL.ContabilidadBL.SG_CO_TB_OPERACION
            Dim OperacionBE As New BE.ContabilidadBE.SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Operacion.Value}

            If OperacionBL.EsCajaBancos(OperacionBE) Then
                Obj_asientoBL.Anular_CajaBancos(E_Asiento_Cab.AC_ID)
            Else
                Obj_asientoBL.Delete(E_Asiento_Cab)
            End If

            OperacionBL = Nothing
            OperacionBE = Nothing

            Call Cargar_Vouchers(uce_SubDiario.Value, uce_Mes.Value)

        End If
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Call Editar_Voucher()
    End Sub

    Private Sub uce_SubDiario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_SubDiario.ValueChanged
        Call LimpiaGrid(ug_Vouchers, uds_Vouchers)
        If uce_Mes.SelectedIndex <> -1 Then
            Call Cargar_Vouchers(uce_SubDiario.Value, uce_Mes.Value)
        End If
    End Sub

    Private Sub Tool_Copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Copiar.Click
        Call Copiar_Voucher()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim id_asiento As Integer = 0
            id_asiento = asientoBL.get_Id_asiento(ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value, _
                                                  gInt_IdEmpresa, _
                                                  CDate(ug_Vouchers.ActiveRow.Cells("AC_FEC_VOUCHER").Value).ToShortDateString)

            Call Ver_Impresion_Voucher(ug_Vouchers.ActiveRow.Cells("AC_FEC_VOUCHER").Value, _
                                       uce_Operacion.Text, _
                                       uce_SubDiario.Text, _
                                       ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value, _
                                       ug_Vouchers.ActiveRow.Cells("AC_GLOSA_VOU").Value, _
                                       id_asiento)

            asientoBL = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ubtn_Refrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Actualizar_Cargar_Vouchers(uce_SubDiario.Value, uce_Mes.Value)
    End Sub

    Public Sub Verificar_Mes_Cerrado(ByVal ayo As Integer, ByVal mes As Integer, ByRef Bol_estado As Boolean)

        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

        With AdmMesBE
            .AM_ANHO = ayo
            .AM_MES = mes
            .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        Bol_estado = False
        If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
            Bol_estado = True
            Avisar("El mes esta cerrado y no se puede modificar el voucher.")
        End If

        AdmMesBL = Nothing
        AdmMesBE = Nothing


    End Sub

    Private Sub Tool_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Actualizar_Cargar_Vouchers(uce_SubDiario.Value, uce_Mes.Value)
    End Sub

    Private Sub uce_Operacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Operacion.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_SubDiario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_SubDiario.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_Cheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cheque.Click

        If ug_Vouchers.Rows.Count = 0 Then Exit Sub

        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim datos_cheque As Dictionary(Of String, Object)
        Dim Int_IdCab As Integer = ug_Vouchers.ActiveRow.Cells("AC_ID").Value
        Dim Str_Nombre_Girar As String = ""
        Dim Dt_Datos_Cheque As DataTable = Nothing
        Dim Num_letras As String = ""

        datos_cheque = AsientoBL.getDatos_Cheque(Int_IdCab, gInt_IdEmpresa)
        Dt_Datos_Cheque = AsientoBL.getDatos_Cheque_Dt(Int_IdCab, gInt_IdEmpresa)

        If Preguntar("Desea ingresar nombre?") Then
            Dim nombre As String = InputBox("ingrese nombre", "Impresion de Cheques", "")
            Dt_Datos_Cheque.Rows(0)("RAZON") = nombre
        End If

        If Dt_Datos_Cheque.Rows.Count > 0 Then
            If Dt_Datos_Cheque.Rows(0)("RAZON") = "" Then
                Str_Nombre_Girar = InputBox("Ingrese el nombre", "Sistema", ".....")
                Dt_Datos_Cheque.Rows(0)("RAZON") = Str_Nombre_Girar
            End If
        Else
            Call Avisar("No hay informacion para mostrar")
            Exit Sub
        End If

        Num_letras = Letras(CDbl(datos_cheque("importe")))

        Try
            Dim ReportesBL As New LR.ClsReporte
            ReportesBL.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, datos_cheque("formato")), Dt_Datos_Cheque, "", "pLetras;" & Num_letras)

            AsientoBL.Actualizar_Estado_Impresion_Cheque(Int_IdCab)
            ug_Vouchers.ActiveRow.Cells("AC_ES_IMPRESO").Value = True


            AsientoBL = Nothing
            ReportesBL.Dispose()


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_VoucherCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_VoucherCheque.Click
        Try
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim ReportesBL As New LR.ClsReporte
            Dim Dt_Datos_Cheque As DataTable = Nothing
            Dim Dt_Asiento As DataTable = Nothing
            Dim Int_IdCab As Integer = ug_Vouchers.ActiveRow.Cells("AC_ID").Value
            Dim Str_Num_letras As String = ""
            Dim Str_Num_Voucher As String = ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value.ToString
            Dim Str_Glosa_Cab As String = ug_Vouchers.ActiveRow.Cells("AC_GLOSA_VOU").Value.ToString
            Dim Dbl_Importe_Cheque As Double = 0
            Dim Str_Proveedor As String = String.Empty
            Dim Str_Num_cheque As String = String.Empty
            Dim Str_Fec_cheque As String = String.Empty
            Dim Str_Nom_Banco As String = String.Empty
            Dim Str_Medio_Pago As String = String.Empty

            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)


            Dt_Datos_Cheque = AsientoBL.getDatos_Cheque_Dt(Int_IdCab, gInt_IdEmpresa)

            Dbl_Importe_Cheque = CDbl(Dt_Datos_Cheque.Rows(0)("importe"))
            Str_Num_letras = Letras(Dbl_Importe_Cheque)
            Str_Proveedor = Dt_Datos_Cheque.Rows(0)("razon").ToString
            Str_Medio_Pago = Dt_Datos_Cheque.Rows(0)("medio_pago").ToString

            If Str_Proveedor.Trim = String.Empty Then
                Str_Proveedor = InputBox("Ingrese el nombre", "Sistema", ".....")
            End If

            Str_Num_cheque = Dt_Datos_Cheque.Rows(0)("NUM_CHEQUE").ToString
            Str_Fec_cheque = Dt_Datos_Cheque.Rows(0)("FECHA").ToString
            Str_Nom_Banco = Dt_Datos_Cheque.Rows(0)("BANCO").ToString

            CabeceraBE.AC_IDEMPRESA = EmpresaBE
            CabeceraBE.AC_FEC_VOUCHER = Str_Fec_cheque
            CabeceraBE.AC_ID = Int_IdCab
            Dt_Asiento = AsientoBL.getVoucher_Impresion1(CabeceraBE)

            ReportesBL.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, "SG_CO_15.rpt"), Dt_Asiento, "", _
                    "pFecha;" & Str_Fec_cheque, _
                    "pEmpresa;" & EmpresaBE.EM_NOMBRE, _
                    "pNumVoucher;" & Str_Num_Voucher, _
                    "pGlosa;" & Str_Glosa_Cab, _
                    "pImporte_ch;" & Dbl_Importe_Cheque, _
                    "pProve_ch;" & Str_Proveedor, _
                    "pNum_Cheque;" & Str_Num_cheque, _
                    "pBanco;" & Str_Nom_Banco, _
                     "pLetras;" & Str_Num_letras, _
                     "pMedio;" & Str_Medio_Pago)

            ReportesBL.Dispose()
            EmpresaBL = Nothing
            EmpresaBE = Nothing
            Dt_Asiento.Dispose()
            Dt_Datos_Cheque.Dispose()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_txt_Buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tool_txt_Buscar.KeyDown

        If e.KeyCode = Keys.Enter Then
            For i As Integer = 0 To ug_Vouchers.Rows.Count - 1
                If ug_Vouchers.Rows(i).Cells("AC_NUM_VOUCHER2").Value = Tool_txt_Buscar.Text.Trim Then
                    ug_Vouchers.Focus()
                    ug_Vouchers.Rows(i).Activate()
                End If
            Next
        End If
        
    End Sub

    Private Sub ug_Vouchers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Vouchers.KeyDown
        If e.KeyCode = Keys.Enter Then Call Editar_Voucher()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub ug_Vouchers_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Vouchers.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click

        If uce_Operacion.Value Is Nothing Then Exit Sub
        If uce_Operacion.SelectedIndex = -1 Then Exit Sub

        Select Case uce_Operacion.Value

            Case 1 'compras
                CO_PR_VouCompras.MdiParent = CO_MN_MenuInicial
                CO_PR_VouCompras.Show()
            Case 2 'ventas
                CO_PR_VouVentas.MdiParent = CO_MN_MenuInicial
                CO_PR_VouVentas.Show()
            Case 3 'caja y Bancos
                CO_PR_VouCajaBancos.MdiParent = CO_MN_MenuInicial
                CO_PR_VouCajaBancos.Show()
            Case 4 'Honorarios
                CO_PR_VouHonorarios.MdiParent = CO_MN_MenuInicial
                CO_PR_VouHonorarios.Show()
            Case 5 'Generales
                CO_PR_VouGenerales.MdiParent = CO_MN_MenuInicial
                CO_PR_VouGenerales.Show()
        End Select

    End Sub
End Class