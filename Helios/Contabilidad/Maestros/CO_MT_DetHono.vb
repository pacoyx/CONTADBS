Public Class CO_MT_DetHono

    Public int_idanexo As Integer
    Public str_razon As String

    Private Sub CO_MT_DetHono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()

        Dim honorarioBL As New BL.ContabilidadBL.SG_CO_TB_HONORARIO_PROFE
        Dim Dt_honorario As DataTable = Nothing

        Dt_honorario = honorarioBL.getHonorarios(int_idanexo)

        Call Limpiar_Controls_InGroupox(UltraGroupBox1)
        Call Limpiar_Controls_InGroupox(UltraGroupBox2)

        Dim elcontrol As Control
        For Each elcontrol In UltraGroupBox2.Controls
            If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = Nothing
            End If
        Next

        txt_razon.Text = str_razon

        If Dt_honorario.Rows.Count > 0 Then

            txt_ape_pat.Text = Dt_honorario.Rows(0)("HP_PRI_NOM")
            txt_ape_mat.Text = Dt_honorario.Rows(0)("HP_SEC_NOM")
            txt_nombres.Text = Dt_honorario.Rows(0)("HP_NOMBRE")

            txt_dir_fiscal.Text = Dt_honorario.Rows(0)("HP_DIR")
            uce_pais.Value = Dt_honorario.Rows(0)("HP_IDPAIS")
            txt_ciudad.Text = Dt_honorario.Rows(0)("HP_CIUDAD")
            ume_tel1.Value = Dt_honorario.Rows(0)("HP_TELF_FIJO")
            ume_mobil1.Value = Dt_honorario.Rows(0)("HP_TELF_MOVIL")
            txt_email.Text = Dt_honorario.Rows(0)("HP_EMAIL")
            txt_profesion.Text = Dt_honorario.Rows(0)("HP_PROFESION")

        Else
            For Each elcontrol In UltraGroupBox2.Controls
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
                    Try
                        CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraComboEditor).SelectedIndex = 0
                    Catch ex As Exception
                    End Try
                End If
            Next
        End If

        Dt_honorario.Dispose()

    End Sub

    Private Sub Cargar_Combos()
        Try

            Dim PaisBL As New BL.ContabilidadBL.SG_CO_TB_PAIS
            Dim PaisBE As New BE.ContabilidadBE.SG_CO_TB_PAIS
            PaisBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            uce_pais.DataSource = PaisBL.getPais(PaisBE)
            uce_pais.DisplayMember = "PA_DESCRIPCION"
            uce_pais.ValueMember = "PA_CODIGO"

            PaisBE = Nothing
            PaisBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        Dim honoBL As New BL.ContabilidadBL.SG_CO_TB_HONORARIO_PROFE
        Dim honoBE As New BE.ContabilidadBE.SG_CO_TB_HONORARIO_PROFE

        With honoBE
            .HP_IDHONORARIO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = int_idanexo}
            .HP_PRI_NOM = txt_ape_pat.Text
            .HP_SEC_NOM = txt_ape_mat.Text
            .HP_NOMBRE = txt_nombres.Text
            .HP_DIR = txt_dir_fiscal.Text
            .HP_IDPAIS = New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = uce_pais.Value}
            .HP_CIUDAD = txt_ciudad.Text
            .HP_TELF_FIJO = ume_tel1.Value.ToString
            .HP_TELF_MOVIL = ume_mobil1.Value.ToString
            .HP_EMAIL = txt_email.Text.ToString
            .HP_PROFESION = txt_profesion.Text
            .HP_IDCUENTA = Nothing
            .HP_ES_AFECTO_RENTA = 0
            .HP_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .HP_TERMINAL = Environment.MachineName
            .HP_FECREG = Now.Date
        End With

        honoBL.Insert(honoBE)

        Call Avisar("Listo!")

        honoBE = Nothing
        honoBL = Nothing

        Me.Close()

    End Sub


    Private Sub txt_ape_pat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ape_pat.KeyDown, ume_tel1.KeyDown, ume_mobil1.KeyDown, uce_pais.KeyDown, txt_referencia.KeyDown, txt_razon.KeyDown, txt_profesion.KeyDown, txt_nombres.KeyDown, txt_email.KeyDown, txt_dir_fiscal.KeyDown, txt_codigo_postal.KeyDown, txt_ciudad.KeyDown, txt_ape_mat.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class