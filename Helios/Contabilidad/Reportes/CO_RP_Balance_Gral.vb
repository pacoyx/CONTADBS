Public Class CO_RP_Balance_Gral

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub CO_RP_Balance_Gral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click

        Dim Str_NombreRep As String = "SG_CO_18.RPT"
        Dim ObjReporte As New LR.ClsReporte
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Dt As DataTable = Nothing
        Dim Dt_ctas_sobregiro As DataTable = Nothing

        Dim ClasesBL As New BL.ContabilidadBL.SG_CO_TB_CLASES_BG
        Dim clasesBG As New List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
        Dim clase As BE.ContabilidadBE.SG_CO_TB_CLASES_BG

        Dim gruposBG As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
        Dim GruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOS_BG
        Dim grupo As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG

        Dim grupoBgCuentasBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_CUENTAS
        Dim cuentas As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
        Dim cuenta As BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}




        Try

            Me.Cursor = Cursors.WaitCursor
            clasesBG = ClasesBL.getClases()
            Dt_ctas_sobregiro = Obj_ReporteBL.getCuentas10s_sobreGiro(txt_Ayo.Text.Trim, gInt_IdEmpresa)


            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = clasesBG.Count
            pb1.Visible = True

            Obj_ReporteBL.Limpiar_Tabla_Balance_Gral()

            For Each clase In clasesBG
                gruposBG = GruposBL.getGrupos_x_Clase(clase)
                For Each grupo In gruposBG
                    cuentas = grupoBgCuentasBL.getCuentas_x_Grupo(grupo, gInt_IdEmpresa, txt_Ayo.Value)
                    For Each cuenta In cuentas
                        Obj_ReporteBL.setImportes_Balance_Gral(clase.CBG_ID, grupo.GBG_ID, cuenta.PC_NUM_CUENTA, CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False))
                    Next
                Next
                pb1.Increment(1)
            Next

            pb1.Value = 0

            Obj_ReporteBL.set_Actualiza_Importe_CajaBancos_Cero()

            Me.Refresh()

            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = Dt_ctas_sobregiro.Rows.Count
            pb1.Visible = True

            For j As Integer = 0 To Dt_ctas_sobregiro.Rows.Count - 1
                Obj_ReporteBL.setActualizar_Cta10_SobreGiro(Dt_ctas_sobregiro.Rows(j)("PC_NUM_CUENTA"), txt_Ayo.Text.Trim, IIf(uos_Formato.Value = 1, uce_Mes.Value, uce_Mes.Value + 1), gInt_IdEmpresa, IIf(uos_Formato.Value = 1, 0, 1))
                pb1.Increment(1)
            Next

            pb1.Visible = False
            pb1.Value = 0


            'actualizo el bal. gen. la cta 89 de resultado de ejercicio
            Obj_ReporteBL.set_Actualizar_Resultado_Ejercicio(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "89")


            'actualiza los totales del pasivo y patrimonio
            Obj_ReporteBL.setActualizar_Importe_PasivoPatrimonio()


            'Hacemos un select a la tabla
            Dt = Obj_ReporteBL.getBalance_Gral_1()

            Dim Str_Titulo As String = "Estado de Situacion Financiera a " & uce_Mes.Text & " " & txt_Ayo.Text.Trim
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
            "pTitulo;" & Str_Titulo, "pFormato;(" & uos_Formato.CheckedItem.DisplayText & ")", _
            "pRuc;" & EmpresaBE.EM_RUC, "pRazon;" & EmpresaBE.EM_NOMBRE)

            Me.Cursor = Cursors.Default

            EmpresaBL = Nothing
            EmpresaBE = Nothing
            grupoBgCuentasBL = Nothing
            ClasesBL = Nothing
            clasesBG = Nothing
            gruposBG = Nothing
            GruposBL = Nothing
            Dt = Nothing


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub
End Class