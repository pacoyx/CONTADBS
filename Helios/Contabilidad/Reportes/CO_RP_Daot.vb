Public Class CO_RP_Daot

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub CO_RP_Daot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_Ayo.Text = gDat_Fecha_Sis.Year
        ume_uit.Value = 3650
        une_por.Value = 2
        ume_tope.Value = ume_uit.Value * une_por.Value
        Call Formatear_Grilla_Selector(ug_daot)
        ubtn_exportar.Enabled = False
        ubtn_Imprimir.Enabled = False

    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click

        If ug_daot.Rows.Count = 0 Then
            Avisar("No hay informacion para continuar")
            Exit Sub
        End If

        If ume_tope.Value Is Nothing Then Exit Sub


        Me.Cursor = Cursors.WaitCursor

        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dbl_tope As Double = ume_tope.Value
        Dim dt_daot As DataTable = CType(ug_daot.DataSource, DataTable)  'reporteBL.get_DAOT(txt_Ayo.Text.Trim, uos_tipo.Value, dbl_tope, gInt_IdEmpresa)
        Dim Str_titulo As String = String.Empty

        If uos_tipo.Value = 1 Then
            Str_titulo = "Gastos acumulados a Diciembre " & txt_Ayo.Text
        Else
            Str_titulo = "Ingresos acumulados a Diciembre " & txt_Ayo.Text
        End If

        Dim Obj_Crystal As New LR.ClsReporte

        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_28.rpt", dt_daot, "", "pEmpresa;" & gStr_NomEmpresa, "pRuc;", "pTitulo;" & Str_titulo)
        Obj_Crystal.Dispose()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub une_por_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_por.KeyDown
        If e.KeyCode = Keys.Enter Then
            une_por.Focus()
        End If
    End Sub

    Private Sub une_por_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles une_por.Leave
        If ume_uit.Value Is Nothing Then Exit Sub
        If une_por.Value Is Nothing Then Exit Sub

        ume_tope.Value = CDbl(ume_uit.Value) * CDbl(une_por.Value)

    End Sub

    Private Sub ume_uit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_uit.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                ume_tope.Value = CDbl(ume_uit.Value) * CDbl(une_por.Value)
            Catch ex As Exception
            End Try

            ume_tope.Focus()
        End If
    End Sub

    Private Sub ume_tope_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_tope.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_procesar.Focus()
        End If
    End Sub

    Private Sub ubtn_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_procesar.Click
        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dbl_tope As Double = ume_tope.Value
        Dim dt_daot As DataTable = reporteBL.get_DAOT(txt_Ayo.Text.Trim, uos_tipo.Value, dbl_tope, gInt_IdEmpresa)

        ug_daot.DataSource = dt_daot

        ubtn_exportar.Enabled = True
        ubtn_Imprimir.Enabled = True

        reporteBL = Nothing

    End Sub

    Private Sub ubtn_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_exportar.Click
        If ug_daot.Rows.Count = 0 Then
            Avisar("No hay informacion para continuar")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        'uge1_daot.Export(ug_daot, "daot.xls")
        'Process.Start("daot.xls")

        Me.Cursor = Cursors.Default
    End Sub
End Class