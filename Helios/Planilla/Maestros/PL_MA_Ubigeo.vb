Public Class PL_MA_Ubigeo

    Public Bol_Aceptar As Boolean = False
    Public Str_Ubigeo As String = String.Empty
    Public Str_Cod_Ubigeo As String = String.Empty
    Public Str_Des_Ubigeo As String = String.Empty

    Private Sub PL_MA_Ubigeo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Departamento()
        Call Formatear_Grilla_Selector(ug_Ubigeo)

        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
    End Sub

    Private Sub Cargar_Departamento()
        Dim departamentoBL As New BL.PlanillaBL.SG_PL_TB_UBI_DEPARTAMENTO
        uce_Departamento.DataSource = departamentoBL.getDepartamentos()
        uce_Departamento.ValueMember = "DE_CODIGO"
        uce_Departamento.DisplayMember = "DE_DESCRIPCION"
        departamentoBL = Nothing
        uce_Provincia.SelectedIndex = -1
        Call LimpiaGrid(ug_Ubigeo, uds_Ubigeo)
    End Sub

    Private Sub Cargar_Provincia()
        Dim provinciaBL As New BL.PlanillaBL.SG_PL_TB_UBI_PROVINCIA
        Dim departamentoBE As New BE.PlanillaBE.SG_PL_TB_UBI_DEPARTAMENTO
        departamentoBE.DE_CODIGO = uce_Departamento.Value
        uce_Provincia.DataSource = provinciaBL.getProvincias_x_Departamento(departamentoBE)
        uce_Provincia.ValueMember = "PR_CODIGO"
        uce_Provincia.DisplayMember = "PR_DESCRIPCION"
        provinciaBL = Nothing
        departamentoBE = Nothing
    End Sub

    Private Sub Cargar_Ubigeo()
        Dim UbigeoBL As New BL.PlanillaBL.SG_PL_TB_UBI_UBIGEO
        Dim provinciaBE As New BE.PlanillaBE.SG_PL_TB_UBI_PROVINCIA
        provinciaBE.PR_CODIGO = uce_Provincia.Value
        Call LimpiaGrid(ug_Ubigeo, uds_Ubigeo)
        ug_Ubigeo.DataSource = UbigeoBL.getUbigeo_x_Provincia(provinciaBE)
        provinciaBE = Nothing
        UbigeoBL = Nothing
    End Sub

    Private Sub uce_Departamento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Departamento.ValueChanged
        Call Cargar_Provincia()
        Call LimpiaGrid(ug_Ubigeo, uds_Ubigeo)
    End Sub

    Private Sub uce_Provincia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Provincia.ValueChanged
        Call Cargar_Ubigeo()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click

        Str_Ubigeo = ug_Ubigeo.ActiveRow.Cells("UB_CODIGO").Value & " - " & ug_Ubigeo.ActiveRow.Cells("UB_DESCRIPCION").Value
        Str_Cod_Ubigeo = ug_Ubigeo.ActiveRow.Cells("UB_CODIGO").Value
        Str_Des_Ubigeo = ug_Ubigeo.ActiveRow.Cells("UB_DESCRIPCION").Value

        Bol_Aceptar = True
        Me.Close()
    End Sub

    Private Sub ug_Ubigeo_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Ubigeo.DoubleClickRow
        ubtn_Aceptar_Click(sender, e)
    End Sub

    Private Sub ug_Ubigeo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Ubigeo.KeyDown
        If e.KeyCode = Keys.Escape Then ubtn_Cancelar_Click(sender, e)
        If e.KeyCode = Keys.Enter Then ubtn_Aceptar_Click(sender, e)
    End Sub
End Class