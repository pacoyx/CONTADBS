Public Class CO_MN_Log

    Private Sub CO_MN_Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarData()
    End Sub

    Private Sub CargarData()
        Try

            Dim obj_log As New BL.ContabilidadBL.SG_CO_TB_LOG_SIS
            ug_Log.DataSource = obj_log.getLogs
            Call Formatear_Grilla_Selector(ug_Log)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_Salir.Click
        Close()
    End Sub

    Private Sub Tool_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Actualizar.Click
        Call CargarData()
    End Sub
End Class