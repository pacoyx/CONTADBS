Public Class CO_MT_UsuariosWeb

    Private Sub CO_MT_UsuariosWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Usuario_Sistema()
    End Sub

    Private Sub Cargar_Usuario_Sistema()

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Dim Dt_usu As DataTable = usuarioBL.getUsuariosWeb

        Call LimpiaGrid(ug_usuariosWeb, uds_UsuariosWeb)

        For i As Integer = 0 To Dt_usu.Rows.Count - 1

            ug_usuariosWeb.DisplayLayout.Bands(0).AddNew()
            ug_usuariosWeb.Rows(i).Cells("US_ID").Value = Dt_usu.Rows(i)("US_ID")
            ug_usuariosWeb.Rows(i).Cells("US_NOMBRE").Value = Dt_usu.Rows(i)("US_NOMBRE")
            ug_usuariosWeb.Rows(i).Cells("US_DESCRIPCION").Value = Dt_usu.Rows(i)("US_DESCRIPCION")
            ug_usuariosWeb.Rows(i).Cells("US_ES_WEB").Value = If(Dt_usu.Rows(i)("US_ES_WEB") = 1, True, False)

        Next

        ug_usuariosWeb.UpdateData()

        Dt_usu.Dispose()
        usuarioBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Dim usuarioBE As BE.ContabilidadBE.SG_CO_TB_USUARIO

        ug_usuariosWeb.UpdateData()

        For i As Integer = 0 To ug_usuariosWeb.Rows.Count - 1
            Dim Int_estado As Integer = IIf(ug_usuariosWeb.Rows(i).Cells("US_ES_WEB").Value, 1, 0)
            usuarioBE = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ES_WEB = Int_estado, .US_ID = ug_usuariosWeb.Rows(i).Cells("US_ID").Value}
            usuarioBL.Update_Permiso_Web(usuarioBE)
        Next

        usuarioBL = Nothing

        Avisar("Listo!")

    End Sub
End Class