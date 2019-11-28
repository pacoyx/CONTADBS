Imports Infragistics.Win.UltraWinGrid

Public Class CO_MT_CambiarEmpresa

    Private Sub CO_MT_CambiarEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Empresas()
    End Sub

    Private Sub Cargar_Empresas()
        Try
            Dim Obj_Emp As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim empresas As List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            empresas = Obj_Emp.getEmpresas_1()

            Call LimpiaGrid(ug_Empresa, uds_Empresas)

            Dim i As Integer = 0
            For Each empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA In empresas
                If Not empresa.EM_ID = gInt_IdEmpresa Then

                    ug_Empresa.DisplayLayout.Bands(0).AddNew()

                    ug_Empresa.Rows(i).Cells("EM_IMAGEN").Value = empresa.EM_IMAGEN
                    ug_Empresa.Rows(i).Cells("EM_ID").Value = empresa.EM_ID
                    ug_Empresa.Rows(i).Cells("EM_NOMBRE").Value = empresa.EM_NOMBRE

                    ug_Empresa.UpdateData()
                    i += 1
                End If
            Next

        Catch ex As Exception
            ShowError(ex.Message)
        End Try


    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()

    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click
        Try

            'Validamos que tenga permiso para ingresar a la empresa seleccionada

            Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            Dim IdEmpresa_tmp As Integer = ug_Empresa.ActiveRow.Cells("EM_ID").Value

            If Not UsuarioBL.Validar_Usuario_x_Empresa(gStr_Usuario_Sis, IdEmpresa_tmp) Then
                Avisar("El usuario no tiene permiso para ingresar a esta empresa")
                Exit Sub
            End If

            'Avisamos el cierre de ventanas y proseguimos de ser conforme
            If Preguntar("Se cerraran todas las ventanas. Desea seguir?") Then

                For Each ChildForm As Form In CO_MN_MenuInicial.MdiChildren
                    ChildForm.Close()
                Next

                gInt_IdEmpresa = ug_Empresa.ActiveRow.Cells("EM_ID").Value
                gStr_NomEmpresa = ug_Empresa.ActiveRow.Cells("EM_NOMBRE").Value
                CO_MN_MenuInicial.Text = "Sistema Contable - " & ug_Empresa.ActiveRow.Cells("EM_NOMBRE").Value
                Me.Close()
            Else
                Exit Sub
            End If


            Me.Cursor = Cursors.WaitCursor

            If UsuarioBL.getTipo_Acceso_x_NomUsu(gStr_Usuario_Sis) = 2 Then
                Call CO_MN_MenuInicial.Armar_Menu_por_Perfil_ReCargar()
            Else
                Call CO_MN_MenuInicial.Armar_Menu_por_Usuario()
            End If

            Me.Cursor = Cursors.Default

            UsuarioBL = Nothing

        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub ug_Empresa_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Empresa.DoubleClickRow
        Try
            ubtn_aceptar_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ug_Empresa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Empresa.KeyDown

        If e.KeyCode = Keys.Enter Then ubtn_aceptar_Click(sender, e)
        If e.KeyCode = Keys.Escape Then End

        If e.KeyCode = Keys.Right Then
            ug_Empresa.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Empresa.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Empresa.PerformAction(UltraGridAction.NextCellByTab, False, False)
        End If

        If e.KeyCode = Keys.Left Then
            ug_Empresa.PerformAction(UltraGridAction.PrevCellByTab, False, False)
            ug_Empresa.PerformAction(UltraGridAction.PrevCellByTab, False, False)
            ug_Empresa.PerformAction(UltraGridAction.PrevCellByTab, False, False)
        End If

        If e.KeyCode = Keys.Down Then
            With ug_Empresa
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
            End With
        End If

        If e.KeyCode = Keys.Up Then
            With ug_Empresa
                .PerformAction(UltraGridAction.PrevCellByTab, False, False)
            End With
        End If

    End Sub
End Class