Public Class CO_MT_CambiarClaveUsu

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click


        Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Dim UsuarioBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO
        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA

        UsuarioBE.US_CLAVE = txt_clave_act.Text.Trim
        UsuarioBE.US_NOMBRE = txt_usuario.Text.Trim
        EmpresaBE.UE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If UsuarioBL.Validar_Usuario_Sistema(UsuarioBE, EmpresaBE) Then
            If txt_nueva_cla.Text.Trim.Equals(txt_confirma.Text.Trim) Then
                UsuarioBL.cambiar_clave_usuario(txt_usuario.Text.Trim, txt_confirma.Text.Trim)
                Avisar("Cambio de clave correcto")
                usuarioBL = Nothing
            Else
                Avisar("Las claves no son iguales")
                txt_nueva_cla.Focus()
            End If
        Else
            Avisar("Contraseña de usuario incorrecta")
            txt_usuario.Focus()
        End If


        UsuarioBL = Nothing
        UsuarioBE = Nothing
        EmpresaBE = Nothing
        
    End Sub

    Private Sub CO_MT_CambiarClaveUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Text = gStr_Usuario_Sis
    End Sub

    Private Sub txt_clave_act_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clave_act.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_nueva_cla_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nueva_cla.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class