Imports BE.ContabilidadBE

Public Class CO_MT_Subdiarios

    Dim Obj_SubD As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
    Dim Dt_Subdiarios As DataTable
    Dim Bol_Nuevo As Boolean


    Private Sub CO_MT_Subdiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call CargarCombos()
        Call Inicializar_Estado_Botones()
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

    Private Sub CargarCombos()
        Try
            'cargamos las Operaciones del S.C.
            Dim ListaOpe As New List(Of SG_CO_TB_OPERACION)
            Dim obj_OpeBL As New BL.ContabilidadBL.SG_CO_TB_OPERACION
            obj_OpeBL.getOperaciones(ListaOpe)
            uce_Ope.DataSource = ListaOpe
            uce_Ope.DisplayMember = "OP_DESCRIPCION"
            uce_Ope.ValueMember = "OP_CODIGO"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CargarDatos()
        Try
            Dt_Subdiarios = Obj_SubD.getSubdiarios(New SG_CO_TB_SUBDIARIO With {.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
            ug_SubDiario.DataSource = Dt_Subdiarios
            Call Formatear_Grilla_Selector(ug_SubDiario)
            MostrarTabs(0, utc_Subdiarios)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Try
            Cambiar_Estado_Botones()
            MostrarTabs(1, utc_Subdiarios, 1)
            Bol_Nuevo = True
            Call Limpiar_Controls_InGroupox(ugb_data)
            uchk_estado.Checked = True
            txt_Codigo.Enabled = True
            txt_Codigo.Focus()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_Codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Descri_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Descri.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_Abrevi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Abrevi.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_Ope_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Ope.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_SubOpe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_SubOpe.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Preguntar("Desea Grabar?") Then
                Tool_Grabar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub uchk_estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_estado.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_EsApe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_EsApe.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uchk_cierre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_cierre.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click

        Cambiar_Estado_Botones()
        MostrarTabs(0, utc_Subdiarios, 0)
   
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        If ug_SubDiario.ActiveRow.Index < 0 Then Exit Sub

        Call Limpiar_Controls_InGroupox(ugb_data)
        Dim codigo_subd As String = ug_SubDiario.ActiveRow.Cells("SD_ID").Value

        Dim dt As DataTable = Obj_SubD.getSubdiario(New SG_CO_TB_SUBDIARIO With {.SD_ID = codigo_subd, .SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})

        If dt.Rows.Count = 0 Then
            Avisar("No hay registros encontrados.")
            Exit Sub
        End If

        With dt.Rows(0)
            txt_Codigo.Text = .Item("SD_ID")
            txt_Descri.Text = .Item("SD_DESCRIPCION")
            txt_Abrevi.Text = .Item("SD_ABREVIATURA")
            uchk_cierre.Checked = .Item("SD_ES_CIER")
            uchk_EsApe.Checked = .Item("SD_ES_APER")
            uchk_estado.Checked = .Item("SD_ISTATUS")
            uce_Ope.Value = .Item("SD_IDOPERACION")
            uce_SubOpe.Value = IIf(IsDBNull(.Item("SD_IDSUBOPE")), Nothing, .Item("SD_IDSUBOPE"))
        End With

        txt_Codigo.Enabled = False
        Bol_Nuevo = False
        Cambiar_Estado_Botones()
        MostrarTabs(1, utc_Subdiarios, 1)
        txt_Descri.Focus()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

    Private Sub uce_Ope_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Ope.ValueChanged
        Try
            Dim obj_SubOpe As New BL.ContabilidadBL.SG_CO_TB_SUBOPERACION
            Dim Arr_SubOpes As New List(Of SG_CO_TB_SUBOPERACION)
            Arr_SubOpes.Add(New SG_CO_TB_SUBOPERACION(0, String.Empty, _
                                                      New SG_CO_TB_OPERACION With {.OP_CODIGO = uce_Ope.Value}))

            obj_SubOpe.getSubOperaciones(Arr_SubOpes)
            uce_SubOpe.DataSource = Arr_SubOpes
            uce_SubOpe.DisplayMember = "SO_DESCRIPCION"
            uce_SubOpe.ValueMember = "SO_CODIGO"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Validar = False
        Try
            If txt_Codigo.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar un codigo")
                txt_Codigo.Focus()
                Exit Function
            End If

            If txt_Descri.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar una descripcion.")
                txt_Descri.Focus()
                Exit Function
            End If

            If txt_Abrevi.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar una abreviatura.")
                txt_Abrevi.Focus()
                Exit Function
            End If

            If uce_Ope.SelectedIndex = -1 Then
                Avisar("Seleccione una operacion para el subdiario.")
                uce_Ope.Focus()
                Exit Function
            End If

            If uce_SubOpe.Items.Count > 0 Then
                If uce_SubOpe.SelectedIndex = -1 Then
                    Avisar("Seleccione una Sub operacion para el subdiario.")
                    uce_SubOpe.Focus()
                    Exit Function
                End If
            End If
            

            Validar = True
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Function

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Try
            If Not Validar() Then Exit Sub

            If Bol_Nuevo Then

                Obj_SubD.Insert(New SG_CO_TB_SUBDIARIO With { _
                .SD_ID = txt_Codigo.Text.Trim, _
                .SD_DESCRIPCION = txt_Descri.Text.Trim, _
                .SD_ABREVIATURA = txt_Abrevi.Text.Trim, _
                .SD_ES_APER = IIf(uchk_EsApe.Checked, 1, 0), _
                .SD_ES_CIER = IIf(uchk_cierre.Checked, 1, 0), _
                .SD_ISTATUS = IIf(uchk_estado.Checked, 1, 0), _
                .SD_IDOPERACION = New SG_CO_TB_OPERACION(uce_Ope.Value, String.Empty, 0), _
                .SD_IDSUBOPE = IIf(uce_SubOpe.Items.Count = 0, Nothing, New SG_CO_TB_SUBOPERACION With {.SO_CODIGO = uce_SubOpe.Value}), _
                .SD_USUARIO = Environment.UserName, _
                .SD_TERMINAL = Environment.MachineName, _
                .SD_FECREG = Now.Date, _
                .SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})

            Else

                Obj_SubD.Update(New SG_CO_TB_SUBDIARIO With { _
                .SD_ID = txt_Codigo.Text.Trim, _
                .SD_DESCRIPCION = txt_Descri.Text.Trim, _
                .SD_ABREVIATURA = txt_Abrevi.Text.Trim, _
                .SD_ES_APER = IIf(uchk_EsApe.Checked, 1, 0), _
                .SD_ES_CIER = IIf(uchk_cierre.Checked, 1, 0), _
                .SD_ISTATUS = IIf(uchk_estado.Checked, 1, 0), _
                .SD_IDOPERACION = New SG_CO_TB_OPERACION(uce_Ope.Value, String.Empty, 0), _
                .SD_IDSUBOPE = IIf(uce_SubOpe.Items.Count = 0, Nothing, New SG_CO_TB_SUBOPERACION With {.SO_CODIGO = uce_SubOpe.Value}), _
                .SD_USUARIO = Environment.UserName, _
                .SD_TERMINAL = Environment.MachineName, _
                .SD_FECREG = Now.Date, _
                .SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})

            End If

            Avisar("    Listo!      ")

            Call CargarDatos()
            Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_SubDiario_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_SubDiario.DoubleClickRow

        Tool_Editar_Click(sender, e)

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Try
            If Preguntar("Esta seguro que desea eliminar el subdiario?") Then
                Obj_SubD.Delete(New SG_CO_TB_SUBDIARIO With {.SD_ID = ug_SubDiario.ActiveRow.Cells("SD_ID").Value, _
                            .SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
                Call CargarDatos()
                Avisar("    Listo!   ")
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_exp_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class