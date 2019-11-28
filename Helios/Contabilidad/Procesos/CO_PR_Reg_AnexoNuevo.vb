Imports BE.ContabilidadBE

Public Class CO_PR_Reg_AnexoNuevo
    Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO
    Dim Bol_Aceptar As Boolean = False
    Public Int_TipoAnexo As Integer = 0

    Public Function GetBol_Aceptar() As Boolean
        Return Bol_Aceptar
    End Function

    Public Function GetE_Anexo() As BE.ContabilidadBE.SG_CO_TB_ANEXO
        Return E_Anexo
    End Function

    Private Sub CO_PR_Reg_AnexoNuevo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_num_doc.Focus()
    End Sub

    Private Sub CO_PR_Reg_AnexoNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombos()
        uce_TipoAnexo.Value = Int_TipoAnexo
        uce_TipoEmp.Value = 2
        uce_TipoDoc.Value = 6

        txt_num_doc.Text = ""
        txt_Razon.Text = ""
    End Sub

    Private Sub CargarCombos()
        Try
            'tipos de anexo
            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            uce_TipoAnexo.DataSource = AnexoBL.getTipoAnexos()
            uce_TipoAnexo.DisplayMember = "TA_DESCRIPCION"
            uce_TipoAnexo.ValueMember = "TA_CODIGO"

            'tipo de empresa
            Dim obj_TipoEmpsBL As New BL.ContabilidadBL.SG_CO_TB_TIPOEMPRESA
            uce_TipoEmp.DataSource = obj_TipoEmpsBL.getTipoEmpresas
            uce_TipoEmp.DisplayMember = "TE_DESCRIPCION"
            uce_TipoEmp.ValueMember = "TE_CODIGO"

            'tipo de doc persona
            Dim obj_docPBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_DOC_IDENTIDAD
            uce_TipoDoc.DataSource = obj_docPBL.getTipoDos
            uce_TipoDoc.DisplayMember = "DI_DESCRIPCION"
            uce_TipoDoc.ValueMember = "DI_CODIGO"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub uce_TipoAnexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoAnexo.KeyDown, uce_TipoEmp.KeyDown, uce_TipoDoc.KeyDown, txt_Razon.KeyDown, txt_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        Try

            If Not ValidarDatos() Then Exit Sub

            Dim obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            With E_Anexo
                .AN_IDANEXO = 0
                .AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = uce_TipoAnexo.Value}
                .AN_TIPO_EMPRESA = New SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = uce_TipoEmp.Value}
                .AN_TIPO_DOC = New SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = uce_TipoDoc.Value}
                .AN_NUM_DOC = txt_num_doc.Text.Trim
                .AN_DESCRIPCION = txt_Razon.Text.Trim
                .AN_PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AN_PC_TERMINAL = Environment.MachineName
                .AN_PC_FECREG = Date.Now
                .AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AN_ES_RELACIONADO = IIf(uchk_EsRelacionado.Checked, 1, 0)
            End With

            obj_AnexoBL.Insert(E_Anexo)
            obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)
            Bol_Aceptar = True
            Me.Close()

        Catch ex As Exception
            Bol_Aceptar = False
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_cancelar.Click
        Try
            '
            'Parte de eliminar medio codigo

            Bol_Aceptar = False
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        ValidarDatos = False
        Try

            If uce_TipoAnexo.SelectedIndex = -1 Then
                Avisar("Debe seleccionar un Tipo de Anexo")
                uce_TipoAnexo.Focus()
                Exit Function
            End If

            If uce_TipoEmp.SelectedIndex = -1 Then
                Avisar("Debe seleccionar un Tipo de Empresa")
                uce_TipoEmp.Focus()
                Exit Function
            End If

            If uce_TipoDoc.SelectedIndex = -1 Then
                Avisar("Debe seleccionar un Tipo de Documento")
                uce_TipoDoc.Focus()
                Exit Function
            End If

            If txt_num_doc.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar un numero de documento")
                txt_num_doc.Focus()
                Exit Function
            End If

            If txt_Razon.Text.Trim.Length = 0 Then
                Avisar("Debe ingresar la razon social")
                txt_Razon.Focus()
                Exit Function
            End If

            Return True
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Function

    Private Sub uchk_EsRelacionado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_EsRelacionado.KeyDown
        If e.KeyCode = Keys.Enter Then ubtn_Aceptar.Focus()
    End Sub
End Class