Public Class CO_RP_ImpCheques

    Private Sub CO_RP_ImpCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Formatear_Grilla_Selector(ug_Vouchers)
    End Sub

    Friend Sub Cargar_Vouchers(ByVal mes As Integer)
        Try
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim AsientoCabBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB

            AsientoCabBE.AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            AsientoCabBE.AC_ANHO = gDat_Fecha_Sis.Year
            AsientoCabBE.AC_MES = mes

            Call LimpiaGrid(ug_Vouchers, uds_Vouchers)
            Dim dt As DataTable = AsientoBL.getVouchers_Impresion_cheques(AsientoCabBE)
            ug_Vouchers.DataSource = dt
            ug_Vouchers.UpdateData()
            ug_Vouchers.Refresh()

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub


    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim SubdBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
            Dim SubdBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            SubdBE.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            SubdBE.SD_ID = ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value.ToString.Substring(0, 2)
            Dim dt As DataTable = SubdBL.getSubdiario(SubdBE)

            Call Ver_Impresion_Voucher(ug_Vouchers.ActiveRow.Cells("AC_FEC_VOUCHER").Value, _
                                       "Caja y Bancos", _
                                       dt.Rows(0)("SD_DESCRIPCION").ToString, _
                                       ug_Vouchers.ActiveRow.Cells("AC_NUM_VOUCHER").Value, _
                                       ug_Vouchers.ActiveRow.Cells("AC_GLOSA_VOU").Value, _
                                       ug_Vouchers.ActiveRow.Cells("AC_ID").Value)
            dt.Dispose()
            SubdBE = Nothing
            SubdBL = Nothing

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Tool_Cheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cheque.Click
        'primero traigo los datos del cheque
        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim datos_cheque As Dictionary(Of String, Object)
        Dim Int_IdCab As Integer = ug_Vouchers.ActiveRow.Cells("AC_ID").Value
        Dim Str_Nombre_Girar As String = ""
        Dim Dt_Datos_Cheque As DataTable = Nothing
        Dim Num_letras As String = ""

        datos_cheque = AsientoBL.getDatos_Cheque(Int_IdCab, gInt_IdEmpresa)
        Dt_Datos_Cheque = AsientoBL.getDatos_Cheque_Dt(Int_IdCab, gInt_IdEmpresa)

        If datos_cheque.Count > 0 Then
            If datos_cheque("razon") = "" Then
                Str_Nombre_Girar = InputBox("Ingrese el nombre", "Sistema", ".....")
                Dt_Datos_Cheque.Rows(0)("RAZON") = Str_Nombre_Girar
            End If
        Else
            Call Avisar("No hay informacion para mostrar")
        End If

        Num_letras = Letras(CDbl(datos_cheque("importe")))

        Try
            Dim ReportesBL As New LR.ClsReporte
            ReportesBL.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, datos_cheque("formato")), Dt_Datos_Cheque, "", "pLetras;" & Num_letras)
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

            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)


            Dt_Datos_Cheque = AsientoBL.getDatos_Cheque_Dt(Int_IdCab, gInt_IdEmpresa)

            Dbl_Importe_Cheque = CDbl(Dt_Datos_Cheque.Rows(0)("importe"))
            Str_Num_letras = Letras(Dbl_Importe_Cheque)
            Str_Proveedor = Dt_Datos_Cheque.Rows(0)("razon").ToString

            If Str_Proveedor.Trim = String.Empty Then
                Str_Proveedor = InputBox("Ingrese el nombre", "Sistema", ".....")
            End If

            Str_Num_cheque = Dt_Datos_Cheque.Rows(0)("NUM_CHEQUE")
            Str_Fec_cheque = Dt_Datos_Cheque.Rows(0)("FECHA")
            Str_Nom_Banco = Dt_Datos_Cheque.Rows(0)("BANCO")

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
                     "pLetras;" & Str_Num_letras)

            ReportesBL.Dispose()
            EmpresaBL = Nothing
            EmpresaBE = Nothing
            Dt_Asiento.Dispose()
            Dt_Datos_Cheque.Dispose()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Actualizar.Click

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Vouchers(uce_Mes.Value)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Cargar_Vouchers(uce_Mes.Value)
    End Sub

    Private Sub ubtn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ubtn_Cheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub ubtn_Voucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class