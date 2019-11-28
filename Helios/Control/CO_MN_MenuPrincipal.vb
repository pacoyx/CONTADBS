Public Class CO_MN_MenuPrincipal

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utm_Menu.ToolClick
        Select Case e.Tool.Key
            Case "Mnu_Subdiarios"

                CO_MT_Subdiarios.MdiParent = Me
                CO_MT_Subdiarios.Show()
            Case "Mnu_PlanCtas"

                CO_MT_PlanCtas.MdiParent = Me
                CO_MT_PlanCtas.Show()

            Case "Mnu_Usuarios"
                CO_MT_Usuarios.MdiParent = Me
                CO_MT_Usuarios.Show()

            Case "tool_Salir"
                Me.Close()
            Case "Mnu_Anexos"
                'lista de anexos
                CO_MT_Anexos.MdiParent = Me
                CO_MT_Anexos.Show()

            Case "tool_LogSistema"
                'abre el log del sistema
                CO_MN_Log.MdiParent = Me
                CO_MN_Log.Show()

            Case "tool_TipodeAnexos"
                CO_SE_TipoAnexos.MdiParent = Me
                CO_SE_TipoAnexos.Show()
            Case "Mnu_Empresas"
                CO_MT_Empresa.MdiParent = Me
                CO_MT_Empresa.Show()

            Case "tool_TipoCambio"
                CO_MT_TipoCambio.MdiParent = Me
                CO_MT_TipoCambio.Show()
            Case "Mnu_Modulos"
                CO_MT_Modulos.MdiParent = Me
                CO_MT_Modulos.Show()

            Case "tool_TipoDocIdentidad"
                CO_MN_MenuInicial.Show()

            Case "Mnu_Grupos"
                CO_MN_Grupos.MdiParent = Me
                CO_MN_Grupos.Show()

            Case "tool_Item"
                CO_MT_OpcMenu.MdiParent = Me
                CO_MT_OpcMenu.Show()

            Case "Mnu_Permisos"
                CO_MT_Permisos_Usu_Mnu.MdiParent = Me
                CO_MT_Permisos_Usu_Mnu.Show()

            Case "tool_AsientoAuto"
                CO_MT_AsientoAuto.MdiParent = Me
                CO_MT_AsientoAuto.Show()
            Case "tool_Documentos"
                CO_MT_Documentos.MdiParent = Me
                CO_MT_Documentos.Show()
            Case "tool_VCompras"
                CO_PR_VouCompras.MdiParent = Me
                CO_PR_VouCompras.Show()
            Case "tool_Impuestos"
                CO_MT_Impuestos.MdiParent = Me
                CO_MT_Impuestos.Show()

            Case "tool_EdicionVou"
                CO_PR_EdicionVoucher.MdiParent = Me
                CO_PR_EdicionVoucher.Show()
        End Select

    End Sub



    Private Sub CO_MN_MenuPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Call Grabar_Log_Salida()

        Try
            Global.System.Windows.Forms.Application.Exit()
        Catch
            Global.System.Windows.Forms.Application.Exit()
        End Try

    End Sub
    Private Sub Grabar_Log_Salida()
        Try
            Dim LogBL As New BL.ContabilidadBL.SG_CO_TB_LOG_SIS
            Dim E_log As New BE.ContabilidadBE.SG_CO_TB_LOG_SIS

            With E_log
                .LS_ID = gInt_IdLog
                .LS_FEC_SAL = Date.Now
            End With

            LogBL.Update(E_log)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
    Private Sub CO_MN_MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Estilos()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Cargar_Estilos()
        Try
            Dim Ruta As String = My.Application.Info.DirectoryPath
            'lvwEstilos.Items.Add(0, "Predeterminado")
            Dim I As Integer = 1
            Ruta = String.Format("{0}\StyleLibraries\", Ruta)
            For Each Archivo As String In My.Computer.FileSystem.GetFiles(Ruta, FileIO.SearchOption.SearchAllSubDirectories, "*.isl")
                ListBox1.Items.Add(Archivo.Substring(Ruta.Length).Trim())
                I += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Call Cargar_Estilo_Infra(ListBox1.Text)
        Call Guardar_Estilo_Infra_RegEdit(ListBox1.Text)
    End Sub
End Class
