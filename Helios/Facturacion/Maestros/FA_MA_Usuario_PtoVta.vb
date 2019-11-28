Public Class FA_MA_Usuario_PtoVta

    Private Sub FA_MA_Usuario_PtoVta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Usuario()
        Call Cargar_PtosVtas()


    End Sub

    Private Sub Cargar_PtosVtas_x_Usuario()

        'lb_Lista.Items.Clear()

        Dim usuPtovtaBL As New BL.FacturacionBL.SG_FA_TB_USU_PTOVTA
        Dim usuPtovtaBE As New BE.FacturacionBE.SG_FA_TB_USU_PTOVTA

        usuPtovtaBE.UP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        usuPtovtaBE.UP_IDUSARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_usuario.Value}

        lb_Lista.DataSource = usuPtovtaBL.get_Lista_PtosVtas_x_Usuario(usuPtovtaBE)
        lb_Lista.DisplayMember = "PV_DESCRIPCION"
        lb_Lista.ValueMember = "UP_IDPTO_VTA"


        usuPtovtaBL = Nothing
        usuPtovtaBE = Nothing

    End Sub

    Private Sub Cargar_Usuario()

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        'une_idusuario.Value = usuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)
        uce_usuario.DataSource = usuarioBL.getUsuarios
        uce_usuario.DisplayMember = "US_NOMBRE"
        uce_usuario.ValueMember = "US_ID"
        usuarioBL = Nothing

    End Sub

    Private Sub Cargar_PtosVtas()

        Dim ptovtaBL As New BL.FacturacionBL.SG_FA_TB_PUNTO_VENTA
        Dim dt_tmp As DataTable = ptovtaBL.get_Lista_PuntaVentas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        ptovtaBL = Nothing

        uce_PtoVta.DataSource = dt_tmp
        uce_PtoVta.DisplayMember = "PV_DESCRIPCION"
        uce_PtoVta.ValueMember = "PV_ID"

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Agregar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Agregar.Click

        For i As Integer = 0 To lb_Lista.Items.Count - 1

            Dim dr As DataRowView
            dr = lb_Lista.Items(i)
            If dr.Row.Item(0).ToString = uce_PtoVta.Value Then
                Avisar("Ya existe el punto de venta en la lista")
                Exit Sub
            End If
        Next


        Dim usuPtovtaBL As New BL.FacturacionBL.SG_FA_TB_USU_PTOVTA
        Dim usuPtovtaBE As New BE.FacturacionBE.SG_FA_TB_USU_PTOVTA

        usuPtovtaBE.UP_IDUSARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_usuario.Value}
        usuPtovtaBE.UP_IDPTO_VTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PtoVta.Value}
        usuPtovtaBE.UP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        usuPtovtaBL.Insert(usuPtovtaBE)

        usuPtovtaBL = Nothing
        usuPtovtaBE = Nothing

        Call Cargar_PtosVtas_x_Usuario()

    End Sub

    Private Sub uce_usuario_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_usuario.ValueChanged
        Call Cargar_PtosVtas_x_Usuario()
    End Sub

    Private Sub ubtn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_eliminar.Click
        Dim usuPtovtaBL As New BL.FacturacionBL.SG_FA_TB_USU_PTOVTA
        Dim usuPtovtaBE As New BE.FacturacionBE.SG_FA_TB_USU_PTOVTA

        usuPtovtaBE.UP_IDUSARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_usuario.Value}
        usuPtovtaBE.UP_IDPTO_VTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = lb_Lista.SelectedValue}
        usuPtovtaBE.UP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        usuPtovtaBL.Delete(usuPtovtaBE)

        usuPtovtaBL = Nothing
        usuPtovtaBE = Nothing

        Call Cargar_PtosVtas_x_Usuario()
    End Sub
End Class