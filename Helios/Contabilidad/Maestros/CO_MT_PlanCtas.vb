Imports BE.ContabilidadBE
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTree
Imports Infragistics.Win

Public Class CO_MT_PlanCtas

    Dim Obj_Pctas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
    Dim Bol_Nuevo As Boolean
    Dim bol_Arbol_Digitos_2_a_6 As Boolean = False

    Private Sub CO_MT_PlanCtas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_buscar.Focus()
        If ut_Planeta.Nodes.Count = 0 Then
            Call Cargar_Plan_de_Cuentas_en_Arbol()
        End If

    End Sub

    Private Sub Cargar_Plan_de_Cuentas_en_Arbol()

        If bol_Arbol_Digitos_2_a_6 Then
            Call Cargar_Plan_al_Arbol_2_a_6Digitos()
        Else
            Call Cargar_Plan_al_Arbol_2()
        End If

        ug_Cuentas.DataSource = Obj_Pctas.getCuentas_DT(New SG_CO_TB_PLANCTAS With {.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}, .PC_PERIODO = gDat_Fecha_Sis.Year})


    End Sub


    Private Sub CO_MT_PlanCtas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call CargarCombos()
        Call Inicializar_Estado_Botones()
        Call MostrarTabs(0, utc_PlanCtas, 0)

        upb_1.Image = My.Resources.Recycle_Bin_Empty_2_24x24_32
        upb_2.Image = My.Resources.Recycle_Bin_Empty_3_24x24_32

    End Sub


    Private Sub CargarCombos()
        Try
            'Cargamos las Monedas _________________________________________________
            Dim Obj_Moneda As New BL.ContabilidadBL.SG_CO_TB_MONEDA
            Dim monedas As New List(Of SG_CO_TB_MONEDA)
            monedas = Obj_Moneda.getMonedas()

            uce_Moneda.DataSource = monedas
            uce_Moneda.DisplayMember = "MO_DESCRIPCION"
            uce_Moneda.ValueMember = "MO_CODIGO"
            '_______________________________________________________________________


            'Cargamos los Tipos de Anexos __________________________________________
            Dim obj_Anexo As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            uce_TipoAnexo.DataSource = obj_Anexo.getTipoAnexos
            uce_TipoAnexo.DisplayMember = "TA_DESCRIPCION"
            uce_TipoAnexo.ValueMember = "TA_CODIGO"
            '_______________________________________________________________________


            'Cargamos los Tipos de Movimientos _____________________________________
            uce_Movi.DataSource = Obj_Pctas.getTipoMovis
            uce_Movi.DisplayMember = "TM_DESCRIPCION"
            uce_Movi.ValueMember = "TM_CODIGO"
            '_______________________________________________________________________


            'Cargamos los Tipos de Movimientos detalle______________________________
            uce_TipoMovi.DataSource = Obj_Pctas.getTipoMovisDet
            uce_TipoMovi.DisplayMember = "TM_DESCRIPCION"
            uce_TipoMovi.ValueMember = "TM_CODIGO"
            '_______________________________________________________________________


            'cargamos los combos de los años
            uce_Ayo_Origen.Items.Add("2011")
            uce_Ayo_Origen.Items.Add("2012")

            uce_ayo_destino.Items.Add("2011")
            uce_ayo_destino.Items.Add("2012")
            uce_ayo_destino.Items.Add("2013")
            '_______________________________________________________________________


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CargarDatos()
        Try

            Call CargarDatos_Arbol()

            'Cargamos la grilla de cuentas de la grilla  de destinos
            Dim dt_cta1 As DataTable = Obj_Pctas.getCuentas_Ayuda(New SG_CO_TB_PLANCTAS With {.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}, .PC_PERIODO = gDat_Fecha_Sis.Year})
            Dim dt_cuentasGrillas As DataTable = Obj_Pctas.getCuentas_DT(New SG_CO_TB_PLANCTAS With {.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}, .PC_PERIODO = gDat_Fecha_Sis.Year})

            udd_PlanCtas1.DataSource = dt_cta1
            udd_PlanCtas1.DisplayMember = "PC_NUM_CUENTA"
            udd_PlanCtas1.ValueMember = "PC_NUM_CUENTA"

            ug_Cuentas.DataSource = dt_cuentasGrillas


            'Cargamos la columna DH(debe / haber)
            Call CrearComboGrid("DH", "NOMBRE", ug_Destinos, CrearTablaTipoDH, True)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Plan_al_Arbol()
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim ds As New DataSet
            Dim entidad As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            entidad.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            entidad.PC_PERIODO = gDat_Fecha_Sis.Year
            ds = Obj_Pctas.getCuentas_Ds(entidad)


            Dim nodo1 As UltraTreeNode
            Dim nodo2 As UltraTreeNode
            Dim nodo3 As UltraTreeNode

            usb1.Panels("numero").Text = "Num. de Cuentas : " & (ds.Tables("Digitos2").Rows.Count + ds.Tables("Digitos4").Rows.Count + ds.Tables("Digitos6").Rows.Count).ToString
            usb1.Panels("barra").Visible = True
            usb1.Panels("barra").ProgressBarInfo.Minimum = 0
            usb1.Panels("barra").ProgressBarInfo.Maximum = ds.Tables("Digitos2").Rows.Count
            usb1.Panels("barra").ProgressBarInfo.ShowLabel = True
            usb1.Panels("barra").ProgressBarInfo.Style = UltraWinProgressBar.ProgressBarStyle.Office2007Continuous


            ut_Planeta.Nodes.Clear()

            For i As Integer = 0 To ds.Tables("Digitos2").Rows.Count - 1
                nodo1 = ut_Planeta.Nodes.Add
                nodo1.Text = ds.Tables("Digitos2").Rows(i)("CUENTA") & " " & ds.Tables("Digitos2").Rows(i)("DESCRIPCION")
                nodo1.Key = ds.Tables("Digitos2").Rows(i)("ID")
                nodo1.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_24x24_32


                For Each fila As DataRow In ds.Tables("Digitos4").Select("padre ='" & ds.Tables("Digitos2").Rows(i)("CUENTA") & "'")
                    nodo2 = nodo1.Nodes.Add
                    nodo2.Text = fila.Item("CUENTA") & " " & fila.Item("DESCRIPCION")
                    nodo2.Key = fila.Item("ID")
                    nodo2.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_24x24_32

                    For Each fila2 As DataRow In ds.Tables("Digitos6").Select("padre ='" & fila.Item("CUENTA") & "'")
                        nodo3 = nodo2.Nodes.Add
                        nodo3.Text = fila2.Item("CUENTA") & " " & fila2.Item("DESCRIPCION")
                        nodo3.Key = fila2.Item("ID")
                        nodo3.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_24x24_32
                    Next
                Next

                usb1.Panels("barra").ProgressBarInfo.Value += 1
                Me.Refresh()

            Next

            usb1.Panels("barra").ProgressBarInfo.Value = 0
            usb1.Panels("barra").Visible = False

            Me.Cursor = Cursors.Default

            entidad = Nothing
            ds.Dispose()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Plan_al_Arbol_2()
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim ds As New DataSet
            Dim entidad As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            entidad.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            entidad.PC_PERIODO = gDat_Fecha_Sis.Year
            ds = Obj_Pctas.getCuentas_Ds_2(entidad)


            Dim nodo1 As UltraTreeNode
            Dim nodo2 As UltraTreeNode
            Dim nodo3 As UltraTreeNode
            Dim nodo4 As UltraTreeNode

            usb1.Panels("numero").Text = "Num. de Cuentas : " & (ds.Tables("Digitos2").Rows.Count + ds.Tables("Digitos3").Rows.Count + ds.Tables("Digitos4").Rows.Count + ds.Tables("Digitos6").Rows.Count).ToString
            usb1.Panels("barra").Visible = True
            usb1.Panels("barra").ProgressBarInfo.Minimum = 0
            usb1.Panels("barra").ProgressBarInfo.Maximum = ds.Tables("Digitos2").Rows.Count
            usb1.Panels("barra").ProgressBarInfo.ShowLabel = True
            usb1.Panels("barra").ProgressBarInfo.Style = UltraWinProgressBar.ProgressBarStyle.Office2007Continuous


            ut_Planeta.Nodes.Clear()

            For i As Integer = 0 To ds.Tables("Digitos2").Rows.Count - 1
                nodo1 = ut_Planeta.Nodes.Add
                nodo1.Text = ds.Tables("Digitos2").Rows(i)("CUENTA") & " " & ds.Tables("Digitos2").Rows(i)("DESCRIPCION")
                nodo1.Key = ds.Tables("Digitos2").Rows(i)("ID")
                nodo1.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32

                For Each fila3dig As DataRow In ds.Tables("Digitos3").Select("padre ='" & ds.Tables("Digitos2").Rows(i)("CUENTA") & "'")
                    nodo2 = nodo1.Nodes.Add
                    nodo2.Text = fila3dig.Item("CUENTA") & " " & fila3dig.Item("DESCRIPCION")
                    nodo2.Key = fila3dig.Item("ID")
                    nodo2.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32

                    For Each fila4dig As DataRow In ds.Tables("Digitos4").Select("padre ='" & fila3dig.Item("CUENTA") & "'")
                        nodo3 = nodo2.Nodes.Add
                        nodo3.Text = fila4dig.Item("CUENTA") & " " & fila4dig.Item("DESCRIPCION")
                        nodo3.Key = fila4dig.Item("ID")
                        nodo3.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32

                        For Each fila6dig As DataRow In ds.Tables("Digitos6").Select("padre ='" & fila4dig.Item("CUENTA") & "'")
                            nodo4 = nodo3.Nodes.Add
                            nodo4.Text = fila6dig.Item("CUENTA") & " " & fila6dig.Item("DESCRIPCION")
                            nodo4.Key = fila6dig.Item("ID")
                            nodo4.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_16x16_32
                        Next
                    Next
                Next

                usb1.Panels("barra").ProgressBarInfo.Value += 1
                Me.Refresh()

            Next

            usb1.Panels("barra").ProgressBarInfo.Value = 0
            usb1.Panels("barra").Visible = False

            Me.Cursor = Cursors.Default

            entidad = Nothing
            ds.Dispose()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Plan_al_Arbol_2_a_6Digitos()
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim ds As New DataSet
            Dim entidad As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            entidad.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            entidad.PC_PERIODO = gDat_Fecha_Sis.Year


            ds = Obj_Pctas.getCuentas_Ds_3(entidad)


            Dim nodo1 As UltraTreeNode
            Dim nodo2 As UltraTreeNode
            Dim nodo3 As UltraTreeNode
            Dim nodo4 As UltraTreeNode
            Dim nodo5 As UltraTreeNode

            usb1.Panels("numero").Text = "Num. de Cuentas : " & (ds.Tables("Digitos2").Rows.Count + ds.Tables("Digitos3").Rows.Count + ds.Tables("Digitos4").Rows.Count + ds.Tables("Digitos6").Rows.Count).ToString
            usb1.Panels("barra").Visible = True
            usb1.Panels("barra").ProgressBarInfo.Minimum = 0
            usb1.Panels("barra").ProgressBarInfo.Maximum = ds.Tables("Digitos2").Rows.Count
            usb1.Panels("barra").ProgressBarInfo.ShowLabel = True
            usb1.Panels("barra").ProgressBarInfo.Style = UltraWinProgressBar.ProgressBarStyle.Office2007Continuous


            ut_Planeta.Nodes.Clear()

            For i As Integer = 0 To ds.Tables("Digitos2").Rows.Count - 1
                nodo1 = ut_Planeta.Nodes.Add
                nodo1.Text = ds.Tables("Digitos2").Rows(i)("CUENTA") & " " & ds.Tables("Digitos2").Rows(i)("DESCRIPCION")
                nodo1.Key = ds.Tables("Digitos2").Rows(i)("ID")

                If ds.Tables("Digitos2").Rows(i)("PC_IDTIPO_MOV") = 1 Then
                    nodo1.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32
                Else
                    nodo1.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_16x16_32
                End If

                For Each fila3dig As DataRow In ds.Tables("Digitos3").Select("padre ='" & ds.Tables("Digitos2").Rows(i)("CUENTA") & "'")
                    nodo2 = nodo1.Nodes.Add
                    nodo2.Text = fila3dig.Item("CUENTA") & " " & fila3dig.Item("DESCRIPCION")
                    nodo2.Key = fila3dig.Item("ID")

                    If fila3dig.Item("PC_IDTIPO_MOV") = 1 Then
                        nodo2.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32
                    Else
                        nodo2.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_16x16_32
                    End If


                    For Each fila4dig As DataRow In ds.Tables("Digitos4").Select("padre ='" & fila3dig.Item("CUENTA") & "'")
                        nodo3 = nodo2.Nodes.Add
                        nodo3.Text = fila4dig.Item("CUENTA") & " " & fila4dig.Item("DESCRIPCION")
                        nodo3.Key = fila4dig.Item("ID")

                        If fila4dig.Item("PC_IDTIPO_MOV") = 1 Then
                            nodo3.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32
                        Else
                            nodo3.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_16x16_32
                        End If


                        For Each fila5dig As DataRow In ds.Tables("Digitos5").Select("padre ='" & fila4dig.Item("CUENTA") & "'")
                            nodo4 = nodo3.Nodes.Add
                            nodo4.Text = fila5dig.Item("CUENTA") & " " & fila5dig.Item("DESCRIPCION")
                            nodo4.Key = fila5dig.Item("ID")

                            If fila5dig.Item("PC_IDTIPO_MOV") = 1 Then
                                nodo4.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32
                            Else
                                nodo4.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_16x16_32
                            End If


                            For Each fila6dig As DataRow In ds.Tables("Digitos6").Select("padre ='" & fila5dig.Item("CUENTA") & "'")
                                nodo5 = nodo4.Nodes.Add
                                nodo5.Text = fila6dig.Item("CUENTA") & " " & fila6dig.Item("DESCRIPCION")
                                nodo5.Key = fila6dig.Item("ID")

                                If fila6dig.Item("PC_IDTIPO_MOV") = 1 Then
                                    nodo5.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_2_16x16_32
                                Else
                                    nodo5.Override.NodeAppearance.Image = My.Resources.Recycle_Bin_Empty_3_16x16_32
                                End If
                            Next
                        Next
                    Next
                Next

                usb1.Panels("barra").ProgressBarInfo.Value += 1
                Me.Refresh()

            Next

            usb1.Panels("barra").ProgressBarInfo.Value = 0
            usb1.Panels("barra").Visible = False

            Me.Cursor = Cursors.Default

            entidad = Nothing
            ds.Dispose()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CargarDatos_Arbol()
        ' Dim ds As New DataSet
        ' Dim entidad As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        ' entidad.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        ' entidad.PC_PERIODO = gDat_Fecha_Sis.Year
        'ds = Obj_Pctas.getCuentas_Ds(entidad)

        'UltraTree1.DataSource = ds
        'UltraTree1.DataMember = "Digitos2"


        'AutoGenerateColumnSets' to true so that UltraTreeCOlumnSets are automatically generated
        ' Me.UltraTree1.ColumnSettings.AutoGenerateColumnSets = True

        'SynchronizeCurrencyManager' to false to optimize performance
        'Me.UltraTree1.SynchronizeCurrencyManager = False

        'Me.UltraTree1.ViewStyle = Infragistics.Win.UltraWinTree.ViewStyle.OutlookExpress

        'Me.UltraTree1.ColumnSettings.AutoFitColumns = AutoFitColumns.ResizeAllColumns
        'UltraTree1.DisplayStyle = UltraTreeDisplayStyle.WindowsVista

        'UltraTree1.Nodes(0).Cells("ID").Column.Visible = False


        'For Each nodo As UltraTreeNode In UltraTree1.Nodes
        '    nodo.Override.NodeAppearance.Image = My.Resources._16__Address_book_
        'Next



    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

    Private Sub Inicializar_Estado_Botones()
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Editar.Enabled = True
        Tool_Salir.Enabled = True
        Tool_Eliminar.Enabled = True
    End Sub

    Private Sub Cambiar_Estado_Botones()
        Tool_Nuevo.Enabled = Not (Tool_Nuevo.Enabled)
        Tool_Grabar.Enabled = Not Tool_Grabar.Enabled
        Tool_Cancelar.Enabled = Not Tool_Cancelar.Enabled
        Tool_Editar.Enabled = Not Tool_Editar.Enabled
        Tool_Salir.Enabled = Not Tool_Salir.Enabled
        Tool_Eliminar.Enabled = Not Tool_Eliminar.Enabled
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Call Cambiar_Estado_Botones()
            Call MostrarTabs(1, utc_PlanCtas, 2)
            Call Limpiar_Controls_InGroupox(ugb_data)
            Call Limpiar_Controls_InGroupox(ugb_data2)
            Call LimpiaGrid(ug_Destinos, uds_Destinos)

            Bol_Nuevo = True
            uchk_Estado.Checked = True
            uce_Moneda.SelectedIndex = 0
            uce_TipoAnexo.SelectedIndex = -1
            uce_Movi.SelectedIndex = 0
            uce_TipoMovi.SelectedIndex = 0

            Dim obj_usu As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            If obj_usu.Es_Administrador(New SG_CO_TB_USUARIO With {.US_NOMBRE = gStr_Usuario_Sis}) Then
                utc_PlanCtas.Tabs(3).Enabled = True
            End If
            obj_usu = Nothing


            txt_NumCta.Enabled = True
            txt_NumCta.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_NumCta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumCta.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

        If e.KeyCode = Keys.Escape Then
            Tool_Cancelar_Click(sender, e)
            'UltraTree1.Focus()
        End If

    End Sub

    Private Sub txt_Descri_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Descri.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.Escape Then
            Tool_Cancelar_Click(sender, e)
            ' UltraTree1.Focus()
        End If
    End Sub

    Private Sub uce_Moneda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_Movi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Movi.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_TipoMovi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoMovi.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_TipoAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoAnexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_CC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_CC.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_Auto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_Auto.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_Estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_Estado.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Try
            Cambiar_Estado_Botones()
            MostrarTabs(0, utc_PlanCtas, 0)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try

            If txt_NumCta.Text.Trim.Length = 0 Then
                Avisar("debe ingresar el numero de cuenta contable")
                txt_NumCta.Focus()
                Exit Function
            End If

            Return True
        Catch ex As Exception

        End Try
    End Function

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try

            If Not ValidarDatos() Then Exit Sub

            Dim E_Cuenta As New SG_CO_TB_PLANCTAS

            ' If UltraTree1.SelectedNodes.Count = 0 Then Exit Sub
            Dim Int_ID_cta As Integer = 0

            Try
                If uos_Vista.Value = "A" Then
                    Int_ID_cta = ut_Planeta.SelectedNodes(0).Key
                Else
                    Int_ID_cta = ug_Cuentas.ActiveRow.Cells("PC_IDCUENTA").Value
                End If



            Catch ex As Exception
                Int_ID_cta = 0
            End Try


            With E_Cuenta
                .PC_IDCUENTA = Int_ID_cta
                .PC_NUM_CUENTA = txt_NumCta.Text.Trim
                .PC_IDMONEDA = New SG_CO_TB_MONEDA With {.MO_CODIGO = uce_Moneda.Value}
                .PC_IDCLASE = New SG_CO_TB_CLASE_CTA With {.CC_CODIGO = txt_Clase.Text.Trim}
                .PC_IDTIPO_MOV = New SG_CO_TB_TIPOMOV With {.TM_CODIGO = uce_Movi.Value}
                .PC_IDTIPO_MOV_DET = New SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = uce_TipoMovi.Value}
                .PC_IDTIPO_ANEXO = IIf(uce_TipoAnexo.SelectedIndex < 0, Nothing, New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TipoAnexo.Value})
                .PC_DESCRIPCION = txt_Descri.Text.Trim
                .PC_PERIODO = gDat_Fecha_Sis.Year
                .PC_ES_CC = IIf(uchk_CC.Checked, 1, 0)
                .PC_ES_AUTO = IIf(uchk_Auto.Checked, 1, 0)
                .PC_ISTATUS = IIf(uchk_Estado.Checked, 1, 0)
                .PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .PC_TERMINAL = Environment.MachineName
                .PC_FECREG = Date.Now
                .PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With


            'Grabamos las Cuentas Destinos

            Dim Obj_CtaDestino As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO
            Dim E_Cta_Destino As SG_CO_TB_CTA_DESTINO
            Dim lista_destino As New List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)

            'eliminamos todo las cuentas destinos de la cuenta origen
            If Not Bol_Nuevo Then Obj_CtaDestino.Delete(Int_ID_cta)

            ug_Destinos.UpdateData()
            For i As Integer = 0 To ug_Destinos.Rows.Count - 1
                If Not ug_Destinos.Rows(i).Cells("Cuenta_Destino").Value.ToString.Trim = "" Then
                    E_Cta_Destino = New SG_CO_TB_CTA_DESTINO()
                    With E_Cta_Destino
                        .CD_IDCUENTA = New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Int_ID_cta}
                        .CD_CTA_DESTINO = ug_Destinos.Rows(i).Cells("Cuenta_Destino").Value
                        .CD_DH = ug_Destinos.Rows(i).Cells("DH").Value
                        .CD_PORCE = ug_Destinos.Rows(i).Cells("Porcentaje").Value
                        .CD_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                        .CD_PC_TERMINAL = Environment.MachineName
                        .CD_PC_FECREG = Date.Now
                        .CD_SECUENCIA = i
                    End With

                    If Bol_Nuevo Then
                        lista_destino.Add(E_Cta_Destino)
                    Else
                        Obj_CtaDestino.Insert(E_Cta_Destino)
                    End If

                End If
            Next



            If Bol_Nuevo Then
                Obj_Pctas.Insert(E_Cuenta, lista_destino)
            Else
                Obj_Pctas.Update(E_Cuenta)
            End If

            Call Avisar("    Listo!  ")
            Call Tool_Cancelar_Click(sender, e)

            If Bol_Nuevo Then
                If Preguntar("Desea recargar los datos?") Then
                    Call Cargar_Plan_de_Cuentas_en_Arbol()
                    txt_buscar.Focus()
                End If
            End If

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try


            Dim Int_ID_cta As Integer = 0

            If uos_Vista.Value = "A" Then
                If ut_Planeta.SelectedNodes.Count = 0 Then Exit Sub
                Int_ID_cta = ut_Planeta.SelectedNodes(0).Key
            Else
                Int_ID_cta = ug_Cuentas.ActiveRow.Cells("PC_IDCUENTA").Value
            End If


            Dim cuenta As New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Int_ID_cta}
            Dim CtasDestinos As New List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)
            Dim Obj_DestinosBL As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO

            Obj_Pctas.getCuenta(cuenta)
            CtasDestinos = Obj_DestinosBL.getCuentasDestinos(cuenta.PC_IDCUENTA)


            Limpiar_Controls_InGroupox(ugb_data)
            Limpiar_Controls_InGroupox(ugb_data2)

            With cuenta
                If .PC_DESCRIPCION.Length > 0 Then
                    txt_NumCta.Text = .PC_NUM_CUENTA
                    txt_Descri.Text = .PC_DESCRIPCION

                    ugb_ctas_destino.Text = "Cuentas Destino de la Cta : " & txt_NumCta.Text & " - " & txt_Descri.Text

                    txt_Clase.Text = .PC_IDCLASE.CC_CODIGO
                    txt_ClaseDescri.Text = Obj_Pctas.getClase_de_Cuenta(New SG_CO_TB_CLASE_CTA With {.CC_CODIGO = txt_Clase.Text})
                    uce_Moneda.Value = .PC_IDMONEDA.MO_CODIGO

                    If .PC_IDTIPO_ANEXO Is Nothing Then
                        uce_TipoAnexo.SelectedIndex = -1
                    Else
                        uce_TipoAnexo.Value = .PC_IDTIPO_ANEXO.TA_CODIGO
                    End If

                    uce_Movi.Value = .PC_IDTIPO_MOV.TM_CODIGO
                    uce_TipoMovi.Value = .PC_IDTIPO_MOV_DET.TM_CODIGO
                    uchk_CC.Checked = IIf(.PC_ES_CC = 1, True, False)
                    uchk_Auto.Checked = IIf(.PC_ES_AUTO = 1, True, False)
                    uchk_Estado.Checked = IIf(.PC_ISTATUS = 1, True, False)

                End If
            End With

            Call LimpiaGrid(ug_Destinos, uds_Destinos)
            Dim i As Integer = 0
            For Each destino As SG_CO_TB_CTA_DESTINO In CtasDestinos
                ug_Destinos.DisplayLayout.Bands(0).AddNew()
                ug_Destinos.Rows(i).Cells("Secuencia").Value = destino.CD_SECUENCIA
                ug_Destinos.Rows(i).Cells("Cuenta_Destino").Value = destino.CD_CTA_DESTINO
                ug_Destinos.Rows(i).Cells("DH").Value = destino.CD_DH
                ug_Destinos.Rows(i).Cells("Porcentaje").Value = destino.CD_PORCE
                ug_Destinos.UpdateData()
                i += 1
            Next

            ug_Destinos.DisplayLayout.Bands(0).AddNew()

            Call MostrarTabs(1, utc_PlanCtas, 2)
            Call Cambiar_Estado_Botones()

            'habilitamos el tab de "Utilidades" si el usuario fuese administrador

            Dim obj_usu As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            If obj_usu.Es_Administrador(New SG_CO_TB_USUARIO With {.US_NOMBRE = gStr_Usuario_Sis}) Then utc_PlanCtas.Tabs(3).Enabled = True

            txt_NumCta.Enabled = False
            txt_Descri.Focus()
            Bol_Nuevo = False

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro que desea eliminar la cuenta?") Then

                Dim Int_ID_cta As Integer = 0

                If uos_Vista.Value = "A" Then
                    If ut_Planeta.SelectedNodes.Count = 0 Then Exit Sub
                    Int_ID_cta = ut_Planeta.SelectedNodes(0).Key
                Else
                    Int_ID_cta = ug_Cuentas.ActiveRow.Cells("PC_IDCUENTA").Value
                End If

                Obj_Pctas.Delete(New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Int_ID_cta, .PC_PERIODO = gDat_Fecha_Sis.Year, .PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
                Avisar("    Listo!      ")
                Call CargarDatos()
            End If

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Function CrearTablaTipoDH() As DataTable
        Dim Dt_dh As New DataTable
        Dim dr As DataRow
        Dt_dh.Columns.Add("CODIGO", Type.GetType("System.String"))
        Dt_dh.Columns.Add("NOMBRE", Type.GetType("System.String"))
        dr = Dt_dh.NewRow
        dr.Item("CODIGO") = "D"
        dr.Item("NOMBRE") = "DEBE"
        Dt_dh.Rows.Add(dr)
        dr = Dt_dh.NewRow
        dr.Item("CODIGO") = "H"
        dr.Item("NOMBRE") = "HABER"
        Dt_dh.Rows.Add(dr)
        Return Dt_dh

    End Function

    Private Sub ug_Destinos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Destinos.BeforeRowsDeleted

        e.DisplayPromptMsg = False
        e.Cancel = False

    End Sub

    Private Sub ubtn_Copiar_Ayo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Copiar_Ayo.Click
        
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarTabs(4, utc_PlanCtas)
    End Sub

    Private Sub txt_buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_buscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uos_Vista.Value = "A" Then
                If txt_buscar.Text.Trim.Length = 0 Then
                    Avisar("Ingrese una cuenta para comenzar la busqueda")
                    txt_buscar.Text = String.Empty
                    txt_buscar.Focus()
                    Exit Sub
                End If
                Call Buscar_Nodo(txt_buscar.Text.Trim)
            Else
                For i As Integer = 0 To ug_Cuentas.Rows.Count - 1
                    If ug_Cuentas.Rows(i).Cells("PC_NUM_CUENTA").Value = txt_buscar.Text.Trim Then
                        ug_Cuentas.Focus()
                        ug_Cuentas.Rows(i).Activate()
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Buscar_Nodo(ByVal Str_Dato As String)
        Dim nodo2 As New UltraTreeNode

        For Each nodo2 In ut_Planeta.Nodes

            If Str_Dato.Length = 2 Then
                If nodo2.Text.Substring(0, 2).Trim = Str_Dato Then
                    ut_Planeta.ActiveNode = nodo2
                    ut_Planeta.ActiveNode.Selected = True
                    ut_Planeta.Select()
                    Call Resaltar_Nodo()
                    Exit Sub
                End If
            Else
                For Each nodo3 As UltraTreeNode In nodo2.Nodes
                    If Str_Dato.Length = 3 Then
                        If nodo3.Text.Substring(0, 3).Trim = Str_Dato Then
                            ut_Planeta.ActiveNode = nodo3
                            ut_Planeta.ActiveNode.Selected = True
                            ut_Planeta.Select()
                            Exit Sub
                        End If
                    Else
                        For Each nodo4 As UltraTreeNode In nodo3.Nodes
                            If Str_Dato.Length = 4 Then
                                If nodo4.Text.Substring(0, 4).Trim = Str_Dato Then
                                    ut_Planeta.ActiveNode = nodo4
                                    ut_Planeta.ActiveNode.Selected = True
                                    ut_Planeta.Select()
                                    Exit Sub
                                End If
                            Else
                                For Each nodo5 As UltraTreeNode In nodo4.Nodes
                                    If Str_Dato.Length = 5 Then
                                        If nodo5.Text.Substring(0, 5).Trim = Str_Dato Then
                                            ut_Planeta.ActiveNode = nodo5
                                            ut_Planeta.ActiveNode.Selected = True
                                            ut_Planeta.Select()
                                            Exit Sub
                                        End If
                                    Else
                                        If Str_Dato.Length = 6 Then
                                            If nodo5.Text.Substring(0, 6).Trim = Str_Dato Then
                                                ut_Planeta.ActiveNode = nodo5
                                                ut_Planeta.ActiveNode.Selected = True
                                                ut_Planeta.Select()
                                                Exit Sub
                                            End If
                                        End If
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Resaltar_Nodo()
        Dim ovr As Infragistics.Win.UltraWinTree.Override
        ovr = ut_Planeta.Override
        ovr.HotTracking = DefaultableBoolean.True
        ovr.BorderStyleNode = UIElementBorderStyle.Solid
        ovr.NodeAppearance.BorderColor = Color.Transparent
        ovr.ActiveNodeAppearance.BorderColor = Color.Red
        ovr.ExpandedNodeAppearance.BorderColor = Color.Magenta
        ovr.HotTrackingNodeAppearance.BorderColor = Color.Blue
        ovr.SelectedNodeAppearance.BorderColor = Color.Black
    End Sub


    Private Sub UltraTree1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Tool_Editar_Click(sender, e)
        End If
    End Sub

    Private Sub Tool_Recargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Recargar.Click
        Call Cargar_Plan_de_Cuentas_en_Arbol()
        txt_buscar.Focus()
    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click
        CO_MT_PlanCtas_Reporte.ShowDialog()
    End Sub

    Private Sub ug_Destinos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Destinos.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_Destinos.PerformAction(UltraGridAction.NextCellByTab, False, False)
        End If
    End Sub

    Private Sub txt_NumCta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NumCta.Leave
        'busco su clase pa pintarla en el formulario
        If txt_NumCta.Text.Trim.Length = 0 Then Exit Sub
        txt_Clase.Text = txt_NumCta.Text.Substring(0, 1)
        txt_ClaseDescri.Text = Obj_Pctas.getClase_de_Cuenta(New SG_CO_TB_CLASE_CTA With {.CC_CODIGO = txt_Clase.Text})
    End Sub

    Private Sub ubtn_Grabar_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Grabar_Nuevo.Click
        If Not ValidarDatos() Then Exit Sub

        Dim E_Cuenta As New SG_CO_TB_PLANCTAS

        ' If UltraTree1.SelectedNodes.Count = 0 Then Exit Sub
        Dim Int_ID_cta As Integer = 0

        Try
            Int_ID_cta = ut_Planeta.SelectedNodes(0).Key

        Catch ex As Exception
            Int_ID_cta = 0
        End Try


        With E_Cuenta
            .PC_IDCUENTA = Int_ID_cta
            .PC_NUM_CUENTA = txt_NumCta.Text.Trim
            .PC_IDMONEDA = New SG_CO_TB_MONEDA With {.MO_CODIGO = uce_Moneda.Value}
            .PC_IDCLASE = New SG_CO_TB_CLASE_CTA With {.CC_CODIGO = txt_Clase.Text.Trim}
            .PC_IDTIPO_MOV = New SG_CO_TB_TIPOMOV With {.TM_CODIGO = uce_Movi.Value}
            .PC_IDTIPO_MOV_DET = New SG_CO_TB_TIPOMOV_DET With {.TM_CODIGO = uce_TipoMovi.Value}
            .PC_IDTIPO_ANEXO = IIf(uce_TipoAnexo.SelectedIndex < 0, Nothing, New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TipoAnexo.Value})
            .PC_DESCRIPCION = txt_Descri.Text.Trim
            .PC_PERIODO = gDat_Fecha_Sis.Year
            .PC_ES_CC = IIf(uchk_CC.Checked, 1, 0)
            .PC_ES_AUTO = IIf(uchk_Auto.Checked, 1, 0)
            .PC_ISTATUS = IIf(uchk_Estado.Checked, 1, 0)
            .PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PC_TERMINAL = Environment.MachineName
            .PC_FECREG = Date.Now
            .PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With


        'Grabamos las Cuentas Destinos

        Dim Obj_CtaDestino As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO
        Dim E_Cta_Destino As SG_CO_TB_CTA_DESTINO
        Dim lista_destino As New List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)

        'eliminamos todo las cuentas destinos de la cuenta origen
        If Not Bol_Nuevo Then Obj_CtaDestino.Delete(Int_ID_cta)


        For i As Integer = 0 To ug_Destinos.Rows.Count - 1
            If Not ug_Destinos.Rows(i).Cells("Cuenta_Destino").Value.ToString.Trim = "" Then
                E_Cta_Destino = New SG_CO_TB_CTA_DESTINO()
                With E_Cta_Destino
                    .CD_IDCUENTA = New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Int_ID_cta}
                    .CD_CTA_DESTINO = ug_Destinos.Rows(i).Cells("Cuenta_Destino").Value
                    .CD_DH = ug_Destinos.Rows(i).Cells("DH").Value
                    .CD_PORCE = ug_Destinos.Rows(i).Cells("Porcentaje").Value
                    .CD_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .CD_PC_TERMINAL = Environment.MachineName
                    .CD_PC_FECREG = Date.Now
                    .CD_SECUENCIA = i
                End With

                If Bol_Nuevo Then
                    lista_destino.Add(E_Cta_Destino)
                Else
                    Obj_CtaDestino.Insert(E_Cta_Destino)
                End If

            End If
        Next


        Try
            If Bol_Nuevo Then
                Obj_Pctas.Insert(E_Cuenta, lista_destino)
            Else
                Obj_Pctas.Update(E_Cuenta)
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
        


        Call Tool_Cancelar_Click(sender, e)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub uos_Vista_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_Vista.ValueChanged

        Select Case uos_Vista.Value
            Case "A"
                ut_Planeta.Visible = True
                ug_Cuentas.Visible = False
            Case "G"
                ut_Planeta.Visible = False
                ug_Cuentas.Visible = True
        End Select

    End Sub

    Private Sub ug_Cuentas_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Cuentas.DoubleClickRow
        If e.Row.IsFilterRow Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub
End Class