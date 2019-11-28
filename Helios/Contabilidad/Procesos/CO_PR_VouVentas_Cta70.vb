Public Class CO_PR_VouVentas_Cta70
    Public Bol_aceptar As Boolean = False

    Private Sub CO_PR_VouVentas_Cta70_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        uc_Cuentas.Focus()
    End Sub

    Private Sub CO_PR_VouVentas_Cta70_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Cuentas_Combo()
    End Sub

    Private Sub Cargar_Cuentas_Combo()
        Try
            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            uc_Cuentas.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)

            E_PlanCtas = Nothing
            Obj_PlanCtasBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uc_Cuentas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas.ValueChanged
        Try
            txt_Des_Cta.Text = uc_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value
            txt_Des_Cta.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            txt_Des_Cta.Text = "*La cuenta no existe!"
            txt_Des_Cta.Appearance.ForeColor = Color.Red

        End Try

    End Sub

    Public Sub Inicializar_Form()
        uc_Cuentas.Text = String.Empty
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click

        If uc_Cuentas.Value Is Nothing Then
            Avisar("Ingrese una cuenta contable.")
            uc_Cuentas.Focus()
            Exit Sub
        End If

        Bol_aceptar = True
        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Bol_aceptar = False
        Me.Close()
    End Sub

    Private Sub uc_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Aceptar.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            uc_Cuentas.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If
        If e.KeyCode = Keys.Escape Then
            ubtn_Cancelar_Click(sender, e)
        End If
    End Sub
End Class