Public Class CO_RP_LibMayor

    Private Sub SG_CO_LibMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
        ug_ctas_titulo.Visible = False
        Call Cargar_Cuentas()

    End Sub

    Private Sub Cargar_Cuentas()
        Try

            Dim CuentasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim CuentasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            CuentasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            CuentasBE.PC_PERIODO = txt_Ayo.Text.Trim
            Dim Dt_ctas As DataTable = CuentasBL.getCuentas_Movimiento_Con_Check(CuentasBE)
            Dim Dt_ctas_Titulo As DataTable = CuentasBL.getCuentas_NDig(CuentasBE, 2)

            Call LimpiaGrid(ug_Cuentas, uds_Cuentas)
            ug_Cuentas.DataSource = Dt_ctas
            ug_Cuentas.UpdateData()


            Call LimpiaGrid(ug_ctas_titulo, uds_ctasTitulo)
            For i As Integer = 0 To Dt_ctas_Titulo.Rows.Count - 1
                ug_ctas_titulo.DisplayLayout.Bands(0).AddNew()
                ug_ctas_titulo.Rows(i).Cells("Sel").Value = False
                ug_ctas_titulo.Rows(i).Cells("Cuenta").Value = Dt_ctas_Titulo.Rows(i)("PC_NUM_CUENTA")
                ug_ctas_titulo.Rows(i).Cells("Descripcion").Value = Dt_ctas_Titulo.Rows(i)("PC_DESCRIPCION")
                ug_ctas_titulo.Rows(i).Cells("IdCuenta").Value = Dt_ctas_Titulo.Rows(i)("PC_IDCUENTA")
            Next

            If ug_ctas_titulo.Rows.Count > 0 Then ug_ctas_titulo.Rows(0).Activate()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub uchk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_todos.CheckedChanged
        Try

            If uchk_Ctas_Titulo.Checked Then
                For i As Integer = 0 To ug_ctas_titulo.Rows.Count - 1
                    ug_ctas_titulo.Rows(i).Cells("Sel").Value = uchk_todos.Checked
                Next
                ug_ctas_titulo.UpdateData()
            Else
                For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                    ug_Cuentas.Rows(i).Cells("Sel").Value = uchk_todos.Checked
                Next
                ug_Cuentas.UpdateData()
            End If



        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If txt_Ayo.Text.Trim.Length = 0 Then
                Avisar("El periodo no se a cargado.")
                Exit Sub
            End If

            If uce_Mes.SelectedIndex = -1 Then
                Avisar("Seleccione mes")
                uce_Mes.Focus()
                Exit Sub
            End If


            If uchk_Ctas_Titulo.Checked Then
                'grabamos los codigos de las cuentas contables
                Call Grabar_Codigos_deTitulos()
            Else

                'grabamos los codigos
                Call Grabar_Codigos()

                'grabamos los saldos de las cuentas
                Call Grabar_Saldos()

                'grabamos las cuentas anteriore al mes
                Call Grabar_Ctas_Ant_Mes()

            End If

            'cargamos el reporte
            Call Mostrar_Reporte()

            

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar_Reporte()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa
            E_Cabecera.AC_TERMINAL = Environment.MachineName

            Dim Dt As DataTable = Nothing
            Dim Str_ConFecha As Integer = IIf(uchk_SinFecha.Checked, "1", "0")
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim Str_NombreRep As String = "SG_CO_08.RPT"
            Dim Str_Resumen As String = IIf(uchk_Resumen.Checked, "1", "0")

            Dt = Obj_ReporteBL.getLibro_Mayor(E_Cabecera)
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Obj_Crystal As New LR.ClsReporte

            Obj_Crystal.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim, "pFecha_Pag;" & Str_ConFecha, "pResumen;" & Str_Resumen)
            Obj_Crystal.Dispose()

            upb_Mayor.Visible = False
            lbl_mensaje.Text = ""
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grabar_Ctas_Ant_Mes()
        Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Call ReportesBL.Grabar_Ctas_Ant_Mes(txt_Ayo.Text, uce_Mes.Value, Environment.MachineName, gInt_IdEmpresa)
    End Sub

    Private Sub Grabar_Saldos()
        Try
            Dim lista_cuentas As New List(Of String)
            Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

            ug_Cuentas.UpdateData()

            upb_Mayor.Value = 0
            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = ug_Cuentas.Rows.Count
            upb_Mayor.Visible = True
            lbl_mensaje.Text = "Calculando saldos... "
            Me.Refresh()

            For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                If ug_Cuentas.Rows(i).Cells("Sel").Value Then
                    lista_cuentas.Add(ug_Cuentas.Rows(i).Cells("Cuenta").Value.ToString)
                End If
                upb_Mayor.IncrementValue(1)
            Next

            upb_Mayor.Value = 0
            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = 100

            Dim numeroR As New Random
            upb_Mayor.Value = numeroR.Next(45, 100)

            lbl_mensaje.Text = "Cargando Reporte... "
            Me.Refresh()
            Call ReportesBL.setSaldos_Cuentas(lista_cuentas, txt_Ayo.Text.Trim, uce_Mes.Value, Environment.MachineName, gInt_IdEmpresa)

            upb_Mayor.Value = 100

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Codigos()
        Try
            Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
            Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

            ug_Cuentas.UpdateData()
            upb_Mayor.Value = 0
            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = ug_Cuentas.Rows.Count
            upb_Mayor.Visible = True
            lbl_mensaje.Text = "Seleccionando cuentas... "
            Me.Refresh()
            For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                If ug_Cuentas.Rows(i).Cells("Sel").Value Then
                    lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(ug_Cuentas.Rows(i).Cells("Cuenta").Value.ToString, Environment.MachineName, gInt_IdEmpresa))
                End If
                upb_Mayor.IncrementValue(1)
            Next

            Call ReportesBL.setCodigos(lista_codigos)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub Grabar_Codigos_deTitulos()
        Try

            Dim titulos As String = ""

            ug_ctas_titulo.UpdateData()
            For z As Integer = 0 To ug_ctas_titulo.Rows.Count - 1
                If ug_ctas_titulo.Rows(z).Cells("Sel").Value Then
                    titulos += "'" & ug_ctas_titulo.Rows(z).Cells("Cuenta").Value & "',"
                End If
            Next

            titulos = titulos.Remove(titulos.Length - 1, 1)



            Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
            Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim dt_cuentas As DataTable = ReportesBL.get_Cuentas_por_Titulos(titulos, gInt_IdEmpresa, txt_Ayo.Text.Trim, 2)
            Dim lista_cuentas As New List(Of String)


            ug_Cuentas.UpdateData()
            upb_Mayor.Value = 0
            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = dt_cuentas.Rows.Count
            upb_Mayor.Visible = True
            lbl_mensaje.Text = "Seleccionando cuentas... "
            Me.Refresh()

            For i As Integer = 0 To dt_cuentas.Rows.Count - 1
                lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(dt_cuentas.Rows(i)("Cuenta").ToString, Environment.MachineName, gInt_IdEmpresa))
                lista_cuentas.Add(dt_cuentas.Rows(i)("Cuenta").ToString)
                upb_Mayor.IncrementValue(1)
            Next


            Call ReportesBL.setCodigos(lista_codigos)
            Call ReportesBL.setSaldos_Cuentas(lista_cuentas, txt_Ayo.Text.Trim, uce_Mes.Value, Environment.MachineName, gInt_IdEmpresa)
            Call ReportesBL.Grabar_Ctas_Ant_Mes(txt_Ayo.Text, uce_Mes.Value, Environment.MachineName, gInt_IdEmpresa)



        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uchk_titulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Ctas_Titulo.CheckedChanged
        ug_ctas_titulo.Visible = uchk_Ctas_Titulo.Checked
        ug_Cuentas.Visible = Not uchk_Ctas_Titulo.Checked

        If uchk_Ctas_Titulo.Checked Then
            une_Digito.Value = 2
        Else
            une_Digito.Value = Nothing
        End If
    End Sub

    Private Sub une_Digito_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles une_Digito.Enter
        une_Digito.SelectAll()
    End Sub

    Private Sub une_Digito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Digito.KeyDown
        If e.KeyCode = Keys.Enter Then

            If une_Digito.Value Is Nothing Then Exit Sub
            If une_Digito.Value = 0 Then Exit Sub

            Dim CuentasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim CuentasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            CuentasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            CuentasBE.PC_PERIODO = txt_Ayo.Text.Trim

            Dim Dt_ctas_Titulo As DataTable = CuentasBL.getCuentas_NDig(CuentasBE, une_Digito.Value)
            upb_cargando.Visible = True
            Me.Cursor = Cursors.WaitCursor


            upb_Mayor.Minimum = 0
            upb_Mayor.Maximum = Dt_ctas_Titulo.Rows.Count
            upb_Mayor.Visible = True
            lbl_mensaje.Text = "Seleccionando cuentas... "
            Me.Refresh()

            Call LimpiaGrid(ug_ctas_titulo, uds_ctasTitulo)
            For i As Integer = 0 To Dt_ctas_Titulo.Rows.Count - 1
                ug_ctas_titulo.DisplayLayout.Bands(0).AddNew()
                ug_ctas_titulo.Rows(i).Cells("Sel").Value = False
                ug_ctas_titulo.Rows(i).Cells("Cuenta").Value = Dt_ctas_Titulo.Rows(i)("PC_NUM_CUENTA")
                ug_ctas_titulo.Rows(i).Cells("Descripcion").Value = Dt_ctas_Titulo.Rows(i)("PC_DESCRIPCION")
                ug_ctas_titulo.Rows(i).Cells("IdCuenta").Value = Dt_ctas_Titulo.Rows(i)("PC_IDCUENTA")
                upb_Mayor.IncrementValue(1)
            Next

            upb_Mayor.Value = 0
            upb_Mayor.Visible = False

            If ug_ctas_titulo.Rows.Count > 0 Then ug_ctas_titulo.Rows(0).Activate()

            upb_cargando.Visible = False
            Me.Refresh()
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class