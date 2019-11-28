Public Class FA_PR_Mante_Compro

    Dim es_super As Boolean = False

    Private Sub FA_PR_Mante_Compro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Empresas_Combo()
        Call Validar_Super_ft()
        uce_tipo.SelectedIndex = 2
        uce_Mes.SelectedIndex = -1

    End Sub

    Private Sub Validar_Super_ft()
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        es_super = usuarioBL.es_super_ft(gStr_Usuario_Sis)
        usuarioBL = Nothing
        If gStr_Usuario_Sis = "admin" Then
            es_super = True
        End If
    End Sub

    Private Sub Cargar_Empresas_Combo()

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO

        uce_Empresas.DataSource = usuarioBL.get_Empresas_x_usuario(gStr_Usuario_Sis)
        uce_Empresas.DisplayMember = "EM_NOMBRE"
        uce_Empresas.ValueMember = "PU_IDEMPRESA"

        uce_Empresas.Value = gInt_IdEmpresa

        usuarioBL = Nothing

        'uce_Empresas.Items.Add("3", "GESTAR S.A.C")
        'uce_Empresas.Items.Add("4", "GINEFERT  S.A.C.")
        'uce_Empresas.Items.Add("5", "GINECOLOGIA Y FERTILIDAD S.A.C")
        'uce_Empresas.Items.Add("6", "ECOGEST  S.A.C")
        'uce_Empresas.Value = gInt_IdEmpresa

    End Sub

    Private Sub Cargar_Comprobantes()
        Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobantesBE.CO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = gInt_IdUsuario_Sis}

        Select Case uce_tipo.Value
            Case 1 'diario
                comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
                If es_super Then
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Dia(comprobantesBE)
                Else
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Dia_02(comprobantesBE)
                End If

            Case 2 'semanal
                comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
                comprobantesBE.CO_FEC_VEN = CDate(udte_hasta.Value).ToShortDateString
                If es_super Then
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Semana(comprobantesBE)
                Else
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Semana_02(comprobantesBE)
                End If

            Case 3 'mensual
                If es_super Then
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Mes(gDat_Fecha_Sis.Year, uce_Mes.Value, comprobantesBE.CO_IDEMPRESA)
                Else
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Mes_02(gInt_IdUsuario_Sis, gDat_Fecha_Sis.Year, uce_Mes.Value, comprobantesBE.CO_IDEMPRESA)
                End If

        End Select

        comprobantesBE = Nothing
        comprobantesBL = Nothing
    End Sub

    Private Sub uce_tipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_tipo.ValueChanged


        udte_desde.Visible = True
        udte_hasta.Visible = True
        uce_Mes.Visible = True
        lbl_desde.Visible = True
        lbl_hasta.Visible = True
        lbl_desde.Text = "Desde"
        Select Case uce_tipo.Value
            Case 1 'diario
                udte_hasta.Visible = False
                uce_Mes.Visible = False

                lbl_hasta.Visible = False
            Case 2 'semanal
                uce_Mes.Visible = False

            Case 3 'mensual

                lbl_desde.Text = "Mes"
                lbl_hasta.Visible = False
                udte_desde.Visible = False
                udte_hasta.Visible = False

        End Select

        Call Cargar_Comprobantes()

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        FA_PR_Emi_Compro.MdiParent = CO_MN_MenuInicial
        FA_PR_Emi_Compro.Show()
    End Sub

    Private Sub Tool_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Consultar.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
        comprobanteBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobanteBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value

        FA_PR_Emi_Compro.MdiParent = CO_MN_MenuInicial
        FA_PR_Emi_Compro.bol_nuevo = False
        FA_PR_Emi_Compro.Show()
        FA_PR_Emi_Compro.Text = FA_PR_Emi_Compro.Text & " ( Consulta )"
        FA_PR_Emi_Compro.Cargar_Comprobante_toEdit(comprobanteBE)

        FA_PR_Emi_Compro.txt_notas.Focus()



    End Sub

    Private Sub Tool_Anular_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Anular.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        If ug_Listado.ActiveRow.Cells("CO_ESTADO").Value = 0 Then
            Avisar("El Comprobante ya se encuentra anulado.")
            Exit Sub
        End If

        If Preguntar("Esta seguro de Anular el comprobante?") Then

            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

            comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            comprobantesBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value
            comprobantesBL.Anular(comprobantesBE)

            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)

            '1 = Existe interface contabilidad
            '0 = no hay conta

            If rpta = "1" Then
                comprobantesBE.CO_IDVOUCHER = ug_Listado.ActiveRow.Cells("CO_IDVOUCHER").Value
                comprobantesBL.Anular_En_Contabilidad(comprobantesBE)
            End If

            paraetrosBE = Nothing
            paraetrosBL = Nothing

            ug_Listado.ActiveRow.Appearance.ForeColor = Color.Tomato
            ug_Listado.ActiveRow.Cells("CO_ESTADO").Value = 0
            ug_Listado.UpdateData()

            Avisar("    Listo!  ")

            comprobantesBE = Nothing
            comprobantesBL = Nothing
        End If

    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim idComprobante As Integer = ug_Listado.ActiveRow.Cells("CO_ID").Value
        Dim reportesBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_comprobante As DataTable = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)


        Dim nom_reporte As String = "SG_FA_01.RPT"
        Dim nom_param_linea As String = ""
        Dim texto_nota_cre As String = ""
        Dim bol_es_nc As Boolean = False
        Dim moneda As String = ug_Listado.ActiveRow.Cells("CO_IDMONEDA").Value
        Dim total_compro As Double = ug_Listado.ActiveRow.Cells("CO_TOTAL").Value

        Select Case dt_comprobante.Rows(0)("CO_TDOC")
            Case "01" 'factura
                nom_reporte = "SG_FA_01.RPT"
                'nom_reporte = "SG_FA_01_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFAC"

            Case "03" 'boleta
                nom_reporte = "SG_FA_06.RPT"
                'nom_reporte = "SG_FA_06_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINBOL"

            Case "07" 'nota de credito
                nom_reporte = "SG_FA_07.RPT"
                'nom_reporte = "SG_FA_07_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINNCR"
                texto_nota_cre = "Nota de credito que reemplaza al documento " & dt_comprobante.Rows(0)("CO_SDOC_REF") & "-" & dt_comprobante.Rows(0)("CO_NDOC_REF")
                bol_es_nc = True
        End Select

        Dim Monto_en_Letras As String = Letras(total_compro).ToUpper

        If moneda = "01" Then
            Monto_en_Letras = Monto_en_Letras & " NUEVOS SOLES"
        Else
            Monto_en_Letras = Monto_en_Letras & " DOLARES AMERICANOS"
        End If

        Call Completar_Lineas(nom_param_linea, dt_comprobante, bol_es_nc, texto_nota_cre)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pTasaigv;18%")


        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Comprobantes()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Comprobantes()
    End Sub


    Private Sub ug_Listado_InitializeRow(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Listado.InitializeRow
        If e.Row.Cells("CO_ESTADO").Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub udte_desde_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "1" Then 'por dia
                Call Cargar_Comprobantes()
            Else
                udte_hasta.Focus()
            End If
        End If
    End Sub

    Private Sub udte_hasta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Comprobantes()
        End If
    End Sub

    Private Sub ug_Listado_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado.DoubleClickRow

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If e.Row.IsActiveRow Then Exit Sub
        If e.Row Is Nothing Then Exit Sub

        Call Tool_Consultar_Click(sender, e)

    End Sub

    Private Sub uce_Empresas_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Empresas.ValueChanged
        gInt_IdEmpresa = uce_Empresas.Value
        gStr_NomEmpresa = uce_Empresas.Text
        CO_MN_MenuInicial.Text = "Sistema Contable - " & uce_Empresas.Text
        Call Cargar_Comprobantes()
        
    End Sub

    Private Sub uce_tipo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "1" Then 'por dia
                udte_desde.Focus()
            End If
        End If
    End Sub

    Private Sub Tool_Detallar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Detallar.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub



        Dim f As New FA_PR_DetPago
        With ug_Listado.ActiveRow
            f.pIdComprobante = .Cells("CO_ID").Value
            f.pComprobante = .Cells("CO_TDOC").Value & "-" & .Cells("CO_SDOC").Value & "-" & .Cells("CO_NDOC").Value
            f.pImporte = .Cells("CO_TOTAL").Value
        End With
        

        f.ShowDialog()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        If ug_Listado.ActiveRow.Cells("CO_ESTADO").Value = 0 Then
            Avisar("El Comprobante ya se encuentra anulado.")
            Exit Sub
        End If

        If Preguntar("Esta seguro de ELIMINAR el comprobante?") Then
            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

            comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            comprobantesBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value

            comprobantesBE.CO_TDOC = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = ug_Listado.ActiveRow.Cells("CO_TDOC").Value}
            comprobantesBE.CO_SDOC = ug_Listado.ActiveRow.Cells("CO_SDOC").Value
            comprobantesBE.CO_NDOC = ug_Listado.ActiveRow.Cells("CO_NDOC").Value

            comprobantesBL.Eliminar(comprobantesBE)
            Call Cargar_Comprobantes()

            Avisar("    Listo!  ")

            comprobantesBE = Nothing
            comprobantesBL = Nothing
        End If
    End Sub
End Class