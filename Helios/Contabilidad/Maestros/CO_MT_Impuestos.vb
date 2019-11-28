
Imports BE.ContabilidadBE

Public Class CO_MT_Impuestos
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MT_Impuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Formatear_Grilla_Selector(ug_impuestos)
        Call MostrarTabs(0, utc_Impuestos, 0)
        Call CargarCombo_ConMeses(uce_Mes)
        Call CargarCombo_ConMeses(uce_mes_cara)
        Call CargarCombo_ConMeses(uce_mes_origen)
        Call CargarCombo_ConMeses(uce_Mes_Destino)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Impuestos_Sunat()
        Call Cargar_Tipos_Impuestos()

        une_ayo_cara.Value = gDat_Fecha_Sis.Year
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_mes_cara.Value = gDat_Fecha_Sis.Month
        une_ayo_cara.Enabled = False


    End Sub

    Private Sub Cargar_Tipos_Impuestos()
        Try
            Dim Obj_Tipo_ImpuestoBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_IMPUESTO
            uce_TipoImpuesto.DataSource = Obj_Tipo_ImpuestoBL.getTipos
            uce_TipoImpuesto.DisplayMember = "TI_DESCRIPCION"
            uce_TipoImpuesto.ValueMember = "TI_CODIGO"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Impuestos_Sunat()
        Try

            Dim Obj_Impuesto_SunatBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO_SUNAT
            uc_Imp_Sunat.DataSource = Obj_Impuesto_SunatBL.getImpuestos()
            uc_Imp_Sunat.DisplayMember = "IS_DESCRIPCION"
            uc_Imp_Sunat.ValueMember = "IS_CODIGO"


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Datos()
        Try
            Dim Obj_impuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
            Dim impuestos As New List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Dim E_Impuesto As New SG_CO_TB_IMPUESTO
            E_Impuesto.IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            impuestos = Obj_impuestoBL.getImpuestos(E_Impuesto)
            Call LimpiaGrid(ug_impuestos, uds_Impuestos)
            Dim i As Integer = 0
            For Each impuesto As SG_CO_TB_IMPUESTO In impuestos
                ug_impuestos.DisplayLayout.Bands(0).AddNew()

                ug_impuestos.Rows(i).Cells("Codigo").Value = impuesto.IM_CODIGO
                ug_impuestos.Rows(i).Cells("Descripcion").Value = impuesto.IM_DESCRIPCION
                ug_impuestos.Rows(i).Cells("Tasa").Value = impuesto.IM_TASA

                i += 1
            Next


            ug_impuestos.UpdateData()

            impuestos = Nothing
            E_Impuesto = Nothing
            Obj_impuestoBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
    Private Sub Cargar_Datos_por_Periodo()
        Try
            Dim Obj_impuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
            Dim impuestos As New List(Of BE.ContabilidadBE.SG_CO_TB_IMPUESTO)
            Dim E_Impuesto As New SG_CO_TB_IMPUESTO


            E_Impuesto.IM_PERIODO = une_ayo_cara.Value
            E_Impuesto.IM_MES = uce_mes_cara.Value
            E_Impuesto.IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            impuestos = Obj_impuestoBL.getImpuestos_x_Periodo(E_Impuesto)

            Call LimpiaGrid(ug_impuestos, uds_Impuestos)


            Dim i As Integer = 0
            For Each impuesto As SG_CO_TB_IMPUESTO In impuestos
                ug_impuestos.DisplayLayout.Bands(0).AddNew()

                ug_impuestos.Rows(i).Cells("Codigo").Value = impuesto.IM_CODIGO
                ug_impuestos.Rows(i).Cells("Descripcion").Value = impuesto.IM_DESCRIPCION
                ug_impuestos.Rows(i).Cells("Tasa").Value = impuesto.IM_TASA

                i += 1
            Next


            ug_impuestos.UpdateData()

            impuestos = Nothing
            E_Impuesto = Nothing
            Obj_impuestoBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub




    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_Impuestos, 1)
            Call Limpiar_Controls_InGroupox(ugb_datos)

            Bol_Nuevo = True
            une_Ayo.Value = une_ayo_cara.Value
            une_Ayo.Enabled = False
            uce_Mes.SelectedIndex = -1
            uce_Mes.Enabled = True
            txt_codigo.Enabled = True
            uc_Imp_Sunat.Value = Nothing
            uce_Mes.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            Dim Obj_ImpuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO

            Dim E_impuesto As New SG_CO_TB_IMPUESTO
            With E_impuesto
                .IM_CODIGO = txt_codigo.Text.Trim
                .IM_CODIGO_SUNAT = New SG_CO_TB_IMPUESTO_SUNAT With {.IS_CODIGO = uc_Imp_Sunat.Value}
                .IM_DESCRIPCION = txt_des.Text.Trim
                .IM_ABREVIATURA = txt_abre.Text.Trim
                .IM_TASA = ume_tasa.Value
                .IM_CUENTA = txt_cta.Text.Trim
                .IM_ISTATUS = uos_Estado.Value
                .IM_PERIODO = une_Ayo.Value
                .IM_MES = uce_Mes.Value
                .IM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .IM_TERMINAL = Environment.MachineName
                .IM_FECREG = Date.Now
                .IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .IM_IDTIPOIMPUESTO = New SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = uce_TipoImpuesto.Value}
            End With

            If Bol_Nuevo Then
                Obj_ImpuestoBL.Insert(E_impuesto)
            Else
                Obj_ImpuestoBL.Update(E_impuesto)
            End If

            Call Avisar("    Listo!  ")
            Call Cargar_Datos_por_Periodo()
            Call Tool_Cancelar_Click(sender, e)
            E_impuesto = Nothing
            Obj_ImpuestoBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try
            Dim Obj_ImpuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
            Dim E_impuesto As New SG_CO_TB_IMPUESTO

            E_impuesto.IM_CODIGO = ug_impuestos.ActiveRow.Cells("Codigo").Value
            E_impuesto.IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_impuesto.IM_PERIODO = une_ayo_cara.Value
            E_impuesto.IM_MES = uce_mes_cara.Value

            Obj_ImpuestoBL.getImpuestos_x_Codigo_1(E_impuesto)
            With E_impuesto
                txt_codigo.Text = .IM_CODIGO
                uc_Imp_Sunat.Value = .IM_CODIGO_SUNAT.IS_CODIGO
                txt_des.Text = .IM_DESCRIPCION
                txt_abre.Text = .IM_ABREVIATURA
                ume_tasa.Value = .IM_TASA
                uos_Estado.Value = .IM_ISTATUS
                txt_cta.Text = .IM_CUENTA
                uce_Mes.Value = uce_mes_cara.Value
                une_Ayo.Value = une_ayo_cara.Value
                uce_TipoImpuesto.Value = .IM_IDTIPOIMPUESTO.TI_CODIGO
            End With

            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_Impuestos, 1)
            txt_codigo.Enabled = False
            uce_Mes.Enabled = False
            Bol_Nuevo = False
            txt_des.Focus()


            E_impuesto = Nothing
            Obj_ImpuestoBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(0, utc_Impuestos, 0)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Seguro de Eliminar el registro?.") Then
                Dim Obj_ImpuestoBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
                Dim E_Impuesto As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO
                E_Impuesto.IM_CODIGO = ug_impuestos.ActiveRow.Cells("Codigo").Value
                E_Impuesto.IM_PERIODO = une_ayo_cara.Value
                E_Impuesto.IM_MES = uce_mes_cara.Value
                E_Impuesto.IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                Obj_ImpuestoBL.Delete(E_Impuesto)
                Avisar("Listo!")
                Call Cargar_Datos_por_Periodo()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()

    End Sub

    Private Sub une_Ayo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Ayo.KeyDown, ume_tasa.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)

    End Sub

    Private Sub uce_Mes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Mes.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_cod_sunat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub UltraTextEditor1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub UltraTextEditor2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta.KeyDown, txt_abre.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub UltraNumericEditor1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub une_cta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uos_Estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uos_Estado.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_mes_cara_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_mes_cara.ValueChanged
        Try
            Call Cargar_Datos_por_Periodo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uc_Imp_Sunat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Imp_Sunat.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_TipoImpuesto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoImpuesto.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ubtn_Copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Copiar.Click
        Try

            If Not IsNumeric(txt_Ayo_Origen.Text) Then
                Avisar("Ingrese un año valido")
                txt_Ayo_Origen.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txt_Ayo_Destino.Text) Then
                Avisar("Ingrese un año valido")
                txt_Ayo_Destino.Focus()
                Exit Sub
            End If


            Dim Obj_ImpuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
            Dim E_Impuesto As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO
            E_Impuesto.IM_PERIODO = txt_Ayo_Origen.Text.Trim
            E_Impuesto.IM_MES = uce_mes_origen.Value
            E_Impuesto.IM_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Impuesto.IM_USUARIO = txt_Ayo_Destino.Text
            E_Impuesto.IM_TERMINAL = uce_Mes_Destino.Value
            Obj_ImpuestosBL.Copiar_Impuestos_x_Periodo(E_Impuesto)

            Avisar("Listo!")

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Ver_Util_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Ver_Util.Click
        txt_Ayo_Origen.Text = gDat_Fecha_Sis.Year
        txt_Ayo_Destino.Text = gDat_Fecha_Sis.Year

        uce_mes_origen.Value = uce_mes_cara.Value
        uce_Mes_Destino.Value = uce_mes_cara.Value
        ToolS_Mantenimiento.Enabled = False
        Call MostrarTabs(2, utc_Impuestos, 2)
    End Sub

    Private Sub ubtn_Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Regresar.Click
        ToolS_Mantenimiento.Enabled = True
        Call MostrarTabs(0, utc_Impuestos, 0)
    End Sub

    Private Sub ug_impuestos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_impuestos.DoubleClickRow
        Try
            If ug_impuestos.Rows.Count = 0 Then Exit Sub
            Call Tool_Editar_Click(sender, e)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class
