Public Class FA_MA_Vendedor

    Dim bol_nuevo As Boolean = False

    Private Sub FA_MA_Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
        Call Cargar_Combo()
        Call Formatear_Grilla_Selector(ug_Vendedor)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_vendedor, 0)

    End Sub

    Private Sub Cargar_Datos()
        Dim vendedorBL As New BL.FacturacionBL.SG_FA_TB_VENDEDOR
        ug_Vendedor.DataSource = vendedorBL.get_vendedores()
        vendedorBL = Nothing
    End Sub

    Private Sub Cargar_Combo()

        Dim obj_docPBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_DOC_IDENTIDAD
        uce_TipoDoc.DataSource = obj_docPBL.getTipoDos
        uce_TipoDoc.DisplayMember = "DI_DESCRIPCION"
        uce_TipoDoc.ValueMember = "DI_CODIGO"
        obj_docPBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_vendedor, 1)
        Call Limpiar_Controls_InGroupox(ugb_Datos)

        uce_TipoDoc.Value = 6
        bol_nuevo = True


        Dim vendedorBL As New BL.FacturacionBL.SG_FA_TB_VENDEDOR
        txt_codigo.Text = vendedorBL.get_Ult_cod()
        vendedorBL = Nothing

        txt_des.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text.Trim.Length = 0 Then
            Avisar("Ingrese el codigo del vendedor, busque el ultimo numero utilizado")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim.Length = 0 Then
            Avisar("Ingrese el nombre del vendedor")
            txt_des.Focus()
            Exit Sub
        End If


        Dim vendedorBE As New BE.FacturacionBE.SG_FA_TB_VENDEDOR
        Dim vendedorBL As New BL.FacturacionBL.SG_FA_TB_VENDEDOR

        With vendedorBE
            .VE_ID = txt_codigo.Text.Trim
            .VE_DESCRIPCION = txt_des.Text.Trim
            .VE_DIR = txt_dir.Text.Trim
            .VE_TELF = txt_tel.Text.Trim
            .VE_EMAIL = txt_email.Text.Trim
            .VE_TIP_DOC = uce_TipoDoc.Value
            .VE_NUM_DOC = txt_num_doc.Text.Trim
            .VE_USUARIO = gStr_Usuario_Sis
            .VE_FECREG = Now
        End With

        If bol_nuevo Then
            vendedorBL.Insert(vendedorBE)
        Else
            vendedorBL.Update(vendedorBE)
        End If

        vendedorBE = Nothing
        vendedorBL = Nothing

        Call Cargar_Datos()
        Call Avisar("Listo")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Vendedor.Rows.Count = 0 Then Exit Sub
        If ug_Vendedor.ActiveRow Is Nothing Then Exit Sub
        Call Limpiar_Controls_InGroupox(ugb_Datos)

        txt_codigo.Text = ug_Vendedor.ActiveRow.Cells("VE_ID").Value
        txt_des.Text = ug_Vendedor.ActiveRow.Cells("VE_DESCRIPCION").Value
        txt_dir.Text = ug_Vendedor.ActiveRow.Cells("VE_DIR").Value
        txt_tel.Text = ug_Vendedor.ActiveRow.Cells("VE_TELF").Value
        txt_email.Text = ug_Vendedor.ActiveRow.Cells("VE_EMAIL").Value
        uce_TipoDoc.Value = ug_Vendedor.ActiveRow.Cells("VE_TIP_DOC").Value
        txt_num_doc.Text = ug_Vendedor.ActiveRow.Cells("VE_NUM_DOC").Value


        bol_nuevo = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_vendedor, 1)

        txt_des.Focus()



    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_vendedor, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Vendedor.Rows.Count = 0 Then Exit Sub
        If ug_Vendedor.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("seguro de eliminar?") Then
            Dim vendedorBE As New BE.FacturacionBE.SG_FA_TB_VENDEDOR
            Dim vendedorBL As New BL.FacturacionBL.SG_FA_TB_VENDEDOR
            vendedorBE.VE_ID = ug_Vendedor.ActiveRow.Cells("VE_ID").Value
            vendedorBL.Delete(vendedorBE)

            Avisar("Listo!")
            vendedorBE = Nothing
            vendedorBL = Nothing

        End If


    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_dir_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_dir.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_tel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_tel.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_email_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_TipoDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_num_doc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class