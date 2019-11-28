Imports Infragistics.Win.UltraWinListView
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win.UltraWinGrid

Public Class CO_LG_Empresas

    Private Sub CO_LG_Empresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Verificar_RegEdit()
        Call Cargar_Empresas()
        Call Cargar_Estilo_Infra("Office2007Blue.isl")
    End Sub

    Private Sub Cargar_Empresas()
        Try
            Dim Obj_Emp As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim empresas As List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            empresas = Obj_Emp.getEmpresas_1()

            Try
                upb_Cabecera.Image = Bytes2Image(empresas(0).EM_LOGO)
            Catch ex As Exception

            End Try

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

            ug_Empresa.Rows(0).Cells(0).Activate()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Verificar_RegEdit()




        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Servidor", Nothing) Is Nothing Or _
            My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Base", Nothing) Is Nothing Or _
            My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Clave", Nothing) Is Nothing Or _
            My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Usuario", Nothing) Is Nothing Then
            CO_LG_IniciarRegEdit.ShowDialog()
        End If

        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Servidor", Nothing) = "" Or _
            My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Base", Nothing) = "" Or _
            My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Usuario", Nothing) = "" Or _
            My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Clave", Nothing) = "" Then
            CO_LG_IniciarRegEdit.ShowDialog()
        End If





    End Sub

    Private Sub ug_Empresa_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Empresa.DoubleClickRow
        gInt_IdEmpresa = ug_Empresa.ActiveRow.Cells("EM_ID").Value
        gStr_NomEmpresa = ug_Empresa.ActiveRow.Cells("EM_NOMBRE").Value
        Me.Hide()
        CO_LG_Login.ugb_login.Text = ug_Empresa.ActiveRow.Cells("EM_NOMBRE").Value
        CO_LG_Login.Show()
    End Sub

    Private Sub ug_Empresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Empresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            gInt_IdEmpresa = ug_Empresa.ActiveRow.Cells("EM_ID").Value
            gStr_NomEmpresa = ug_Empresa.ActiveRow.Cells("EM_NOMBRE").Value
            Me.Hide()
            CO_LG_Login.ugb_login.Text = ug_Empresa.ActiveRow.Cells("EM_NOMBRE").Value
            CO_LG_Login.Show()
        End If

        If e.KeyCode = Keys.Escape Then
            End
        End If

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