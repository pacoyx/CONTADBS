Public Class FA_PR_IngClienteRapido

    Public str_num_ruc As String = String.Empty
    Public bol_Grabo As Boolean = False

    Private Sub FA_PR_IngClienteRapido_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txt_nombres.Focus()
    End Sub

    Private Sub FA_PR_IngClienteRapido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Combos()
        txt_num_doc.Text = str_num_ruc

        Select Case str_num_ruc.Length
            Case 11
                uce_TipoDoc.Value = 6
            Case 8
                uce_TipoDoc.Value = 1
            Case Else
                uce_TipoDoc.Value = 6
        End Select

        ubtn_Grabar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        btn_sunat.Appearance.Image = My.Resources._16__Internet_

    End Sub

    Private Sub Cargar_Combos()
        Dim obj_docPBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_DOC_IDENTIDAD
        uce_TipoDoc.DataSource = obj_docPBL.getTipoDos
        uce_TipoDoc.DisplayMember = "DI_DESCRIPCION"
        uce_TipoDoc.ValueMember = "DI_CODIGO"
        obj_docPBL = Nothing
    End Sub

    Private Sub ubtn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Cancelar.Click
        bol_Grabo = False
        Me.Close()
    End Sub

    Private Sub ubtn_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Grabar.Click


        If txt_nombres.Text.Trim.Length = 0 Then
            Avisar("Ingrese los nombres")
            txt_nombres.Focus()
            Exit Sub
        End If

        If txt_num_doc.Text.Trim.Length = 0 Then
            Avisar("Ingrese el numero de documento")
            txt_num_doc.Focus()
            Exit Sub
        End If



        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE

        With clienteBE
            .CL_ID = 0
            .CL_NOMBRE = txt_nombres.Text
            .CL_TDOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = uce_TipoDoc.Value}
            .CL_NDOC = txt_num_doc.Text.Trim
            .CL_DIRECCION = txt_dir.Text.Trim
            .CL_ES_RELACIONADO = 0
            .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CL_TERMINAL = Environment.MachineName
            .CL_FECREG = Now.Date
            .CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        clienteBL.Insert(clienteBE, Nothing)

        clienteBE = Nothing
        clienteBL = Nothing

        bol_Grabo = True
        str_num_ruc = txt_num_doc.Text.Trim

        Call Avisar("Listo!")

        Me.Close()

    End Sub

    Private Sub txt_nombres_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_nombres.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_TipoDoc.Focus()
        End If
    End Sub

    Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_doc.Focus()
        End If
    End Sub

    Private Sub txt_num_doc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_dir.Focus()
        End If
    End Sub

    Private Sub txt_dir_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_dir.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Grabar.Focus()
        End If
    End Sub

    Private Sub btn_sunat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sunat.Click
        CO_MT_TCamb_Web.Str_Direccion_Defecto = "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias"
        CO_MT_TCamb_Web.Show()
    End Sub
End Class