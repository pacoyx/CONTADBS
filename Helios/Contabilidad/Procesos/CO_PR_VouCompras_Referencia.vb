Public Class CO_PR_VouCompras_Referencia

    Public Bol_Ventana_Compras As Boolean = True

    Private Sub btn_Aceptar_Ref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar_Ref.Click
        Me.Close()
    End Sub

    Private Sub uce_TipoDoc_Ref_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_SerieDoc_Ref_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_NumDoc_Ref_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Monto_Igv_Ref_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Monto_Igv_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_BaseI_Ref_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_BaseI_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub CO_PR_VouCompras_Referencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Documentos()
    End Sub

    Private Sub Cargar_Documentos()
        Try
            Dim Obj_DocBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
            Dim E_Doc As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            E_Doc.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            uce_TipoDoc_Ref.DataSource = Obj_DocBL.getDocumentos(E_Doc)
            uce_TipoDoc_Ref.DisplayMember = "DO_DESCRIPCION"
            uce_TipoDoc_Ref.ValueMember = "DO_CODIGO"


            E_Doc = Nothing
            Obj_DocBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_NumDoc_Ref_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc_Ref.Leave
        txt_NumDoc_Ref.Text = txt_NumDoc_Ref.Text.PadLeft(10, "0")

        'buscamos el documento para obtener sus datos
        Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim milista As New List(Of String)
        milista = asientoBL.get_Base_igv_x_Docu(uce_TipoDoc_Ref.Value, txt_SerieDoc_Ref.Text.Trim, txt_NumDoc_Ref.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa, Bol_Ventana_Compras)

        If milista.Count > 0 Then
            ume_Fec_Ref.Value = milista(0)
            ume_Monto_Igv_Ref.Value = milista(1)
            ume_BaseI_Ref.Value = milista(2)
        Else
            ume_Fec_Ref.Value = Nothing
            ume_Monto_Igv_Ref.Value = Nothing
            ume_BaseI_Ref.Value = Nothing
        End If

        asientoBL = Nothing
        milista = Nothing

    End Sub

    Private Sub ume_Fec_Ref_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Fec_Ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_SerieDoc_Ref_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SerieDoc_Ref.Leave
        'txt_SerieDoc_Ref.Text = txt_SerieDoc_Ref.Text.Trim.PadLeft(4, "0")
    End Sub

    Private Sub txt_cod_doc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_TipoDoc_Ref.Focus()
        End If
    End Sub

    Private Sub txt_cod_doc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_doc.Leave
        uce_TipoDoc_Ref.Value = txt_cod_doc.Text.Trim
    End Sub

    Private Sub uce_TipoDoc_Ref_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc_Ref.Leave
        txt_cod_doc.Text = uce_TipoDoc_Ref.Value
    End Sub
End Class