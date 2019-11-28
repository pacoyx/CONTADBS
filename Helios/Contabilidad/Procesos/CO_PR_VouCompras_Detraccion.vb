Public Class CO_PR_VouCompras_Detraccion


    Public ReadOnly Property get_Tasa_Detraccion()
        Get
            Return ume_Tasa_Detra.Value
        End Get
    End Property

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        uce_Tipo_Servicio.SelectedIndex = -1
        uce_Servicio.SelectedIndex = -1
        ume_Tasa_Detra.Value = Nothing
        ume_Fec_Detra.Value = Nothing
        txt_Num_Dep.Text = String.Empty
        ume_Valor_Razonable.Value = 0

        Me.Close()
    End Sub

    Private Sub txt_Tipo_Serv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Bien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Tasa_Detra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Tasa_Detra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Num_Dep_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Num_Dep.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Fec_Detra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Fec_Detra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Valor_Razonable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Valor_Razonable.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub CO_PR_VouCompras_Detraccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combo_TipoServicos()
    End Sub

    Private Sub Cargar_Combo_TipoServicos()
        Try
            Dim tipoServicioBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_SERVI_DETRA
            uce_Tipo_Servicio.DataSource = tipoServicioBL.getTipos()
            uce_Tipo_Servicio.DisplayMember = "TS_DESCRIPCION"
            uce_Tipo_Servicio.ValueMember = "TS_CODIGO"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub uce_Tipo_Servicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Tipo_Servicio.ValueChanged
        Try
            Dim servicioBL As New BL.ContabilidadBL.SG_CO_TB_SERVI_DETRA
            uce_Servicio.DataSource = servicioBL.getServicios_x_Tipo(uce_Tipo_Servicio.Value)
            uce_Servicio.DisplayMember = "SD_DESCRICPION"
            uce_Servicio.ValueMember = "SD_CODIGO"


        Catch ex As Exception

        End Try
    End Sub
End Class