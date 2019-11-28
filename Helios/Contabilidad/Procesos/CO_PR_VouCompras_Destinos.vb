Imports Infragistics.Win.UltraWinGrid

Public Class CO_PR_VouCompras_Destinos
    Public Bol_Aceptar As Boolean = False
    Public bol_Dividir_9s As Boolean = True

    Private Sub CO_PR_VouCompras_Destinos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        uc_Cuentas.Focus()
    End Sub

    Private Sub CO_PR_VouCompras_Destinos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Cuentas_Combo()
        txt_total_porce.Text = 0

        ug_Destinos.Visible = True
        Me.Height = 491
        If Not bol_Dividir_9s Then Me.Height = 131 : ug_Destinos.Visible = False

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

    Private Sub uc_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If txt_Des_Cta.Text.Chars(0) = "*" Then Exit Sub

                If Not bol_Dividir_9s Then ubtn_Aceptar_Click(sender, e)


                Dim Obj_DestinosBL As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO
                Dim Destinos As New List(Of BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO)

                Destinos = Obj_DestinosBL.getCuentasDestinos(uc_Cuentas.Value)

                Call LimpiaGrid(ug_Destinos, uds_Destinos)

                Dim i As Integer = 0
                For Each destino As BE.ContabilidadBE.SG_CO_TB_CTA_DESTINO In Destinos
                    ug_Destinos.DisplayLayout.Bands(0).AddNew()
                    ug_Destinos.Rows(i).Cells("Cuenta").Value = destino.CD_CTA_DESTINO
                    ug_Destinos.Rows(i).Cells("Porcentaje").Value = destino.CD_PORCE
                    ug_Destinos.Rows(i).Cells("DH").Value = destino.CD_DH
                    i += 1
                Next

                ug_Destinos.UpdateData()

                Destinos = Nothing
                Obj_DestinosBL = Nothing

                ug_Destinos.Rows(0).Cells("Porcentaje").Activate()
                'SendKeys.Send(Keys.F2)
                ug_Destinos.Focus()
                ug_Destinos.PerformAction(UltraGridAction.ToggleEditMode, False, False)
                'SendKeys.Send(Keys.Right)
                'SendKeys.Send(Keys.Enter)

                'ug_Destinos.PerformAction(UltraGridAction.FirstCellInGrid, False, False)
            Catch ex As Exception

            End Try

        End If

        If e.KeyCode = Keys.Down Then
            uc_Cuentas.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub uc_Cuentas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles uc_Cuentas.InitializeLayout

    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click

        If uc_Cuentas.Text.Trim = String.Empty Then
            Avisar("Ingrese una cuenta contable valida")
            uc_Cuentas.Focus()
            Exit Sub
        End If

        If uc_Cuentas.Value Is Nothing Then
            Avisar("Ingrese una cuenta contable valida")
            uc_Cuentas.Focus()
            Exit Sub
        End If

        If txt_total_porce.Text > 100 Then
            If Preguntar("TENGA CUIDADO!" & Chr(13) & "El porcentaje excede el 100%." & Chr(13) & "Desea continuar?") Then
                Bol_Aceptar = True
                Me.Close()
            Else
                Exit Sub
            End If
        End If

        Bol_Aceptar = True
        Me.Close()
    End Sub

    Public Function getDestinos() As DataTable
        getDestinos = Nothing
        Try

            Dim dt As New DataTable
            Dim dr As DataRow

            dt.Columns.Add("cuenta", Type.GetType("System.String"))
            dt.Columns.Add("porcentaje", Type.GetType("System.Double"))
            dt.Columns.Add("dh", Type.GetType("System.String"))

            For i As Integer = 0 To ug_Destinos.Rows.Count - 1
                dr = dt.NewRow()
                dr("cuenta") = ug_Destinos.Rows(i).Cells("Cuenta").Value
                dr("porcentaje") = ug_Destinos.Rows(i).Cells("Porcentaje").Value
                dr("dh") = ug_Destinos.Rows(i).Cells("DH").Value
                dt.Rows.Add(dr)
            Next

            Return dt

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Function

    Private Sub ug_Destinos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Destinos.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Call Sumar_Porcentaje()
                With ug_Destinos
                    .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End With
                If ug_Destinos.ActiveRow.Index = ug_Destinos.Rows.Count - 1 Then
                    ubtn_Aceptar.Focus()
                End If

            End If

            If e.KeyCode = Keys.Up Then
                e.SuppressKeyPress = True
                With ug_Destinos
                    .PerformAction(UltraGridAction.PrevCellByTab, False, False)
                    .PerformAction(UltraGridAction.PrevCellByTab, False, False)
                End With
            End If

            If e.KeyCode = Keys.Down Then
                e.SuppressKeyPress = True
                With ug_Destinos
                    .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End With
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Sumar_Porcentaje()
        Dim Dbl_Porcentaje As Double = 0
        ug_Destinos.UpdateData()
        For i As Integer = 0 To ug_Destinos.Rows.Count - 1
            If Not ug_Destinos.Rows(i).Cells("Cuenta").Value.ToString.StartsWith("7") Then
                Dbl_Porcentaje += ug_Destinos.Rows(i).Cells("Porcentaje").Value
            End If
        Next

        txt_total_porce.Text = Dbl_Porcentaje.ToString
    End Sub

    Public Sub Inicializar_Form()
        Call LimpiaGrid(ug_Destinos, uds_Destinos)
        uc_Cuentas.Text = String.Empty
    End Sub
End Class