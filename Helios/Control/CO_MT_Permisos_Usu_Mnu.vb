Public Class CO_MT_Permisos_Usu_Mnu

    Private Sub CO_MT_Permisos_Usu_Mnu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_usuarios()
        Call Cargar_Modulos()
        Call Comenzar_el_Form()

    End Sub

    Private Sub Comenzar_el_Form()
        uce_Editor.SelectedIndex = -1
        ueb_Niveles.Enabled = False
        utc_Permisos_Niveles.Enabled = False
        ugb_Botonera.Enabled = False
    End Sub

    Private Sub ueb_Niveles_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles ueb_Niveles.ItemClick
        Select Case e.Item.Key
            Case "M" 'modulos
                If uce_Editor.SelectedIndex = -1 Then Exit Sub

                Call Limpiar_Check_Modulos()
                Call Cargar_Mod_xUsuario_TabModulos()
                Call MostrarTabs(0, utc_Permisos_Niveles, 0)

            Case "G" 'Grupos
                If uce_Editor.SelectedIndex = -1 Then Exit Sub
                uce_Modulos.SelectedIndex = -1

                Call Cargar_Modulo_x_Usuario_TabGrupos()
                Call LimpiaGrid(ug_PermisosGrupos, uds_Grupos)
                Call MostrarTabs(1, utc_Permisos_Niveles, 1)


            Case "O" 'Opciones
                If uce_Editor.SelectedIndex = -1 Then Exit Sub

                Call Cargar_Modulo_x_Usuario_TabVentanas()
                uce_Modulo_V.SelectedIndex = -1
                uce_Grupo_V.SelectedIndex = -1

                MostrarTabs(2, utc_Permisos_Niveles, 2)

            Case "C" 'Comandos
                If uce_Editor.SelectedIndex = -1 Then Exit Sub

                Call Cargar_Modulo_x_Usuario_TabComandos()
                uce_Modulos_C.SelectedIndex = -1
                uce_Grupos_C.SelectedIndex = -1
                uce_Ventana_C.SelectedIndex = -1

                Call LimpiaGrid(ug_Permisos_Cmd, uds_Comandos)
                MostrarTabs(3, utc_Permisos_Niveles, 3)

        End Select
        utc_Permisos_Niveles.Enabled = True
        uce_Editor.Enabled = False
        ueb_Niveles.Enabled = False
        ugb_Botonera.Enabled = True

    End Sub

    Private Sub Cargar_Modulo_x_Usuario_TabGrupos()
        Try
            If uce_Editor.SelectedIndex = -1 Then Exit Sub

            Dim modulos_usuario As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            Dim Obj_ModUsuBL As New BL.ContabilidadBL.SG_CO_TB_MODULO_USUARIO

            modulos_usuario = Obj_ModUsuBL.getMod_x_Usuario(uce_Editor.Value)

            uce_Modulos.Items.Clear()

            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO In modulos_usuario
                uce_Modulos.Items.Add(modulo.MU_IDMODULO.MO_ID, modulo.MU_IDMODULO.MO_DESCRIPCION)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_Modulo_x_Usuario_TabVentanas()
        Try
            If uce_Editor.SelectedIndex = -1 Then Exit Sub

            Dim modulos_usuario As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            Dim Obj_ModUsuBL As New BL.ContabilidadBL.SG_CO_TB_MODULO_USUARIO

            modulos_usuario = Obj_ModUsuBL.getMod_x_Usuario(uce_Editor.Value)

            uce_Modulo_V.Items.Clear()

            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO In modulos_usuario
                uce_Modulo_V.Items.Add(modulo.MU_IDMODULO.MO_ID, modulo.MU_IDMODULO.MO_DESCRIPCION)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_Modulo_x_Usuario_TabComandos()
        Try
            If uce_Editor.SelectedIndex = -1 Then Exit Sub

            Dim modulos_usuario As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            Dim Obj_ModUsuBL As New BL.ContabilidadBL.SG_CO_TB_MODULO_USUARIO

            modulos_usuario = Obj_ModUsuBL.getMod_x_Usuario(uce_Editor.Value)

            uce_Modulos_C.Items.Clear()

            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO In modulos_usuario
                uce_Modulos_C.Items.Add(modulo.MU_IDMODULO.MO_ID, modulo.MU_IDMODULO.MO_DESCRIPCION)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Limpiar_Check_Modulos()
        Try
            For i As Integer = 0 To ug_PermisosModulos.Rows.Count - 1
                ug_PermisosModulos.Rows(i).Cells("Sel").Value = False
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_Modulos()
        Try

            Dim Obj_ModBL As New BL.ContabilidadBL.SG_CO_TB_MODULO
            Dim modulos As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO)

            modulos = Obj_ModBL.getModulos()

            Call LimpiaGrid(ug_PermisosModulos, uds_Per_mod)

            Dim i As Integer = 0
            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO In modulos
                ug_PermisosModulos.DisplayLayout.Bands(0).AddNew()
                ug_PermisosModulos.Rows(i).Cells("Sel").Value = False
                ug_PermisosModulos.Rows(i).Cells("Codigo").Value = modulo.MO_ID
                ug_PermisosModulos.Rows(i).Cells("Descripcion").Value = modulo.MO_DESCRIPCION
                ug_PermisosModulos.Update()
                i += 1
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Cargar_Mod_xUsuario_TabModulos()
        Try

            Dim modulos_usuario As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            Dim Obj_ModUsuBL As New BL.ContabilidadBL.SG_CO_TB_MODULO_USUARIO

            modulos_usuario = Obj_ModUsuBL.getMod_x_Usuario(uce_Editor.Value)

            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO In modulos_usuario
                For i As Integer = 0 To ug_PermisosModulos.Rows.Count - 1
                    If ug_PermisosModulos.Rows(i).Cells("Codigo").Value = modulo.MU_IDMODULO.MO_ID Then
                        ug_PermisosModulos.Rows(i).Cells("Sel").Value = True
                    End If
                Next
            Next
            ug_PermisosModulos.UpdateData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cargar_usuarios()
        Try

            Dim Obj_UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO


            uce_Editor.DataSource = Obj_UsuarioBL.getUsuarios
            uce_Editor.DisplayMember = "US_NOMBRE"
            uce_Editor.ValueMember = "US_ID"


        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Editor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Editor.ValueChanged

        If uce_Editor.SelectedIndex = -1 Then Exit Sub
        ueb_Niveles.Enabled = True


    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Try
            Call Limpiar_Check_Modulos()
            Call MostrarTabs(0, utc_Permisos_Niveles, 0)
            utc_Permisos_Niveles.Enabled = False
            ugb_Botonera.Enabled = False
            uce_Editor.Enabled = True
            ueb_Niveles.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_actualizar.Click
        Try

            Select Case utc_Permisos_Niveles.SelectedTab.Index()
                Case 0 'modulos
                    Call Grabar_Permisos_Modulo()
                Case 1 'grupos
                    Call Grabar_Permisos_Grupos()
                Case 2 'ventanas
                    Call Guardar_Permisos_Ventanas()
                Case 3 'comandos
                    Call Guardar_Permisos_Comandos()
            End Select

            Avisar("    Listo!  ")

            'ugb_Botonera.Enabled = False
            'uce_Editor.Enabled = True
            'ueb_Niveles.Enabled = True

            'Call Limpiar_Check_Modulos()
            'Call MostrarTabs(0, utc_Permisos_Niveles, 0)
            'utc_Permisos_Niveles.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Grabar_Permisos_Modulo()
        Try
            Dim Obj_Mod_PerBL As New BL.ContabilidadBL.SG_CO_TB_MODULO_USUARIO
            Dim permiso As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO

            Obj_Mod_PerBL.DeleteAll(New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value})



            For i As Integer = 0 To ug_PermisosModulos.Rows.Count - 1
                If ug_PermisosModulos.Rows(i).Cells("Sel").Value Then
                    permiso = New BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO()

                    permiso.MU_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    permiso.MU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = ug_PermisosModulos.Rows(i).Cells("Codigo").Value}
                    permiso.MU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    permiso.MU_ISTATUS = 1
                    permiso.MU_TERMINAL = Environment.MachineName
                    permiso.MU_USUARIO = Environment.UserName
                    permiso.MU_FECREG = Date.Now

                    Obj_Mod_PerBL.Insert(permiso)
                Else
                    Dim Obj_Mod_Grupo As New BL.ContabilidadBL.SG_CO_TB_USUARIO_GRUPO_MNU
                    Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU

                    Entidad.GU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    Entidad.GU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = ug_PermisosModulos.Rows(i).Cells("Codigo").Value}
                    Obj_Mod_Grupo.DeleteAll(Entidad)

                End If
            Next
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Grabar_Permisos_Grupos()
        Try
            Dim E_grupo As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim Obj_GrupoBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO_GRUPO_MNU

            Call Obj_GrupoBL.DeleteAll(New BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU With {.GU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}, .GU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = uce_Modulos.Value}})

            For i As Integer = 0 To ug_PermisosGrupos.Rows.Count - 1
                If ug_PermisosGrupos.Rows(i).Cells("Sel").Value = True Then
                    E_grupo = New BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU
                    E_grupo.GU_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = ug_PermisosGrupos.Rows(i).Cells("Codigo").Value}
                    E_grupo.GU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    E_grupo.GU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = uce_Modulos.Value}
                    Call Obj_GrupoBL.Insert(E_grupo)
                Else
                    Dim Obj_OpcionesBL As New BL.ContabilidadBL.SG_CO_TB_USU_GRU_OPC
                    Dim E_Opciones As New BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC
                    E_Opciones.UGO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    E_Opciones.UGO_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = ug_PermisosGrupos.Rows(i).Cells("Codigo").Value}
                    Obj_OpcionesBL.Delete(E_Opciones)

                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guardar_Permisos_Ventanas()
        Try

            Dim Obj_opcinesBL As New BL.ContabilidadBL.SG_CO_TB_USU_GRU_OPC
            Dim E_Opciones As BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC

            E_Opciones = New BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC()
            E_Opciones.UGO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            E_Opciones.UGO_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = uce_Grupo_V.Value}

            Obj_opcinesBL.Delete(E_Opciones)

            For i As Integer = 0 To ug_PermisosOpciones.Rows.Count - 1
                If ug_PermisosOpciones.Rows(i).Cells("Sel").Value = True Then
                    E_Opciones = New BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC()
                    E_Opciones.UGO_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = uce_Grupo_V.Value}
                    E_Opciones.UGO_IDOPCION = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = ug_PermisosOpciones.Rows(i).Cells("Codigo").Value}
                    E_Opciones.UGO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    Obj_opcinesBL.Insert(E_Opciones)
                Else

                    Dim Obj_usu_opc_cmdBL As New BL.ContabilidadBL.SG_CO_TB_USU_OPC_CMD
                    Dim E_usu_opc_cmd As New BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD
                    E_usu_opc_cmd.UOC_IDUSU = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    E_usu_opc_cmd.UOC_IDOPC = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = uce_Ventana_C.Value}

                    Obj_usu_opc_cmdBL.Delete(E_usu_opc_cmd)
                End If
            Next

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_Permisos_Comandos()
        Try
            Dim Obj_usu_opc_cmdBL As New BL.ContabilidadBL.SG_CO_TB_USU_OPC_CMD
            Dim E_usu_opc_cmd As BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD

            E_usu_opc_cmd = New BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD()
            E_usu_opc_cmd.UOC_IDUSU = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            E_usu_opc_cmd.UOC_IDOPC = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = uce_Ventana_C.Value}

            Obj_usu_opc_cmdBL.Delete(E_usu_opc_cmd)

            For i As Integer = 0 To ug_Permisos_Cmd.Rows.Count - 1
                If ug_Permisos_Cmd.Rows(i).Cells("Sel").Value = True Then
                    E_usu_opc_cmd = New BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD()
                    E_usu_opc_cmd.UOC_IDUSU = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
                    E_usu_opc_cmd.UOC_IDOPC = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = uce_Ventana_C.Value}
                    E_usu_opc_cmd.UOC_IDCMD = New BE.ContabilidadBE.SG_CO_TB_BTN_CMD With {.BC_ID = ug_Permisos_Cmd.Rows(i).Cells("Codigo").Value}
                    Obj_usu_opc_cmdBL.Insert(E_usu_opc_cmd)
                End If
            Next

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_Modulos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Modulos.ValueChanged
        Try

            If uce_Modulos.SelectedIndex = -1 Then Exit Sub

            'Cargamos los GRUPOS por Modulo()

            Dim Obj_GruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU
            Dim grupos As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)

            grupos = Obj_GruposBL.getGrupos_x_Modulo(uce_Modulos.Value)

            Call LimpiaGrid(ug_PermisosGrupos, uds_Grupos)

            Dim i As Integer = 0
            For Each grupo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU In grupos
                ug_PermisosGrupos.DisplayLayout.Bands(0).AddNew()
                ug_PermisosGrupos.Rows(i).Cells("Sel").Value = False
                ug_PermisosGrupos.Rows(i).Cells("Codigo").Value = grupo.GM_ID
                ug_PermisosGrupos.Rows(i).Cells("Descripcion").Value = grupo.GM_NOMBRE
                i += 1
            Next

            ug_PermisosGrupos.UpdateData()

            'ahora leemos los permisos por Grupo por usuario para ver cual pintamos a True
            Dim Obj_GrupoUsu As New BL.ContabilidadBL.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim gruposUsus As New List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU)
            gruposUsus = Obj_GrupoUsu.getGrupos_Usu(uce_Editor.Value)

            For Each grupousu As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU In gruposUsus

                For j As Integer = 0 To ug_PermisosGrupos.Rows.Count - 1
                    If ug_PermisosGrupos.Rows(j).Cells("Codigo").Value = grupousu.GU_IDGRUPO.GM_ID Then
                        ug_PermisosGrupos.Rows(j).Cells("Sel").Value = True
                    End If
                Next
            Next

            ug_PermisosGrupos.UpdateData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Modulo_V_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Modulo_V.ValueChanged
        Try

            If uce_Modulo_V.SelectedIndex = -1 Then Exit Sub

            'aki cargo los grupos que son de este Modulo por usuario
            'ahora leemos los permisos por Grupo por usuario para ver cual pintamos a True
            Dim Obj_GrupoUsu As New BL.ContabilidadBL.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim grupos As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            Entidad.GU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            Entidad.GU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = uce_Modulo_V.Value}
            grupos = Obj_GrupoUsu.getGrupos_x_Usu_Modulo(Entidad)

            uce_Grupo_V.Items.Clear()

            For Each grupo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU In grupos
                uce_Grupo_V.Items.Add(grupo.GM_ID, grupo.GM_NOMBRE)
            Next

            Call LimpiaGrid(ug_PermisosOpciones, uds_Opciones)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub uce_Grupo_V_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Grupo_V.ValueChanged
        Try

            Dim Obj_opcionesBL As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
            Dim E_usu_gru As New BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC
            Dim opciones As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)

            opciones = Obj_opcionesBL.getOpcionesMenu_x_Grupo(uce_Grupo_V.Value)

            Call LimpiaGrid(ug_PermisosOpciones, uds_Opciones)

            Dim i As Int32 = 0

            For Each opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In opciones

                ug_PermisosOpciones.DisplayLayout.Bands(0).AddNew()
                With ug_PermisosOpciones.Rows(i)
                    .Cells("Sel").Value = False
                    .Cells("Codigo").Value = opcion.OM_ID
                    .Cells("Descripcion").Value = opcion.OM_DESCRIPCION
                End With

                i += 1
            Next

            ug_PermisosOpciones.UpdateData()

            E_usu_gru.UGO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            E_usu_gru.UGO_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = uce_Grupo_V.Value}
            opciones = Obj_opcionesBL.getOpciones_x_Usuario_y_Grupo(E_usu_gru)

            For Each opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In opciones
                For j As Integer = 0 To ug_PermisosOpciones.Rows.Count - 1
                    If ug_PermisosOpciones.Rows(j).Cells("Codigo").Value = opcion.OM_ID Then ug_PermisosOpciones.Rows(j).Cells("Sel").Value = True
                Next
            Next
            ug_PermisosOpciones.UpdateData()
            opciones = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_Sel_Todo_Mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Sel_Todo_Mod.Click
        Call Marcar_NoMarcar_Sel_Grilla(ug_PermisosModulos)
    End Sub

    Private Sub ubtn_Sel_Todo_Grupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Sel_Todo_Grupo.Click
        Call Marcar_NoMarcar_Sel_Grilla(ug_PermisosGrupos)
    End Sub

    Private Sub ubtn_Sel_Todo_Ventana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Sel_Todo_Ventana.Click
        Call Marcar_NoMarcar_Sel_Grilla(ug_PermisosOpciones)
    End Sub

    Private Sub Marcar_NoMarcar_Sel_Grilla(ByVal grid As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try

            If grid.Rows.Count = 0 Then Exit Sub

            If grid.Rows(0).Cells("Sel").Value = True Then
                For i As Integer = 0 To grid.Rows.Count - 1
                    With grid.Rows(i).Cells("Sel")
                        .Value = False
                    End With
                Next
            Else
                For i As Integer = 0 To grid.Rows.Count - 1
                    With grid.Rows(i).Cells("Sel")
                        .Value = True
                    End With
                Next
            End If

            

            grid.UpdateData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Nuevo.Click
        CO_MT_Usuarios.MdiParent = CO_MN_MenuPrincipal
        CO_MT_Usuarios.Show()
    End Sub

    Private Sub uce_Editor_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_Editor.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_Buscar"
                MsgBox("Buscando")
            Case ""

        End Select
    End Sub

    Private Sub uce_Modulos_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Modulos_C.ValueChanged
        Try

            If uce_Modulos_C.SelectedIndex = -1 Then Exit Sub

            'aki cargo los grupos que son de este Modulo por usuario
            'ahora leemos los permisos por Grupo por usuario para ver cual pintamos a True
            Dim Obj_GrupoUsu As New BL.ContabilidadBL.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim grupos As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            Entidad.GU_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            Entidad.GU_IDMODULO = New BE.ContabilidadBE.SG_CO_TB_MODULO With {.MO_ID = uce_Modulos_C.Value}
            grupos = Obj_GrupoUsu.getGrupos_x_Usu_Modulo(Entidad)

            uce_Grupos_C.Items.Clear()

            For Each grupo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU In grupos
                uce_Grupos_C.Items.Add(grupo.GM_ID, grupo.GM_NOMBRE)
            Next

            Call LimpiaGrid(ug_Permisos_Cmd, uds_Comandos)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Grupos_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Grupos_C.ValueChanged
        Try
            Dim Obj_opcionesBL As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
            Dim E_usu_gru As New BE.ContabilidadBE.SG_CO_TB_USU_GRU_OPC
            Dim opciones As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)

            E_usu_gru.UGO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            E_usu_gru.UGO_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU With {.GM_ID = uce_Grupos_C.Value}
            opciones = Obj_opcionesBL.getOpciones_x_Usuario_y_Grupo(E_usu_gru)

            uce_Ventana_C.Items.Clear()

            For Each opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In opciones
                uce_Ventana_C.Items.Add(opcion.OM_ID, opcion.OM_DESCRIPCION)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_Ventana_C_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Ventana_C.ValueChanged
        Try
            If uce_Ventana_C.SelectedIndex = -1 Then Exit Sub

            Dim Obj_usu_cmdBL As New BL.ContabilidadBL.SG_CO_TB_USU_OPC_CMD
            Dim Obj_ComandosBL As New BL.ContabilidadBL.SG_CO_TB_BTN_CMD

            Dim cmds As New List(Of BE.ContabilidadBE.SG_CO_TB_BTN_CMD)
            Dim E_usu_OPC_CMD As New BE.ContabilidadBE.SG_CO_TB_USU_OPC_CMD

            cmds = Obj_ComandosBL.getCmds()

            Call LimpiaGrid(ug_Permisos_Cmd, uds_Comandos)

            Dim i As Integer = 0
            For Each cmd As BE.ContabilidadBE.SG_CO_TB_BTN_CMD In cmds
                ug_Permisos_Cmd.DisplayLayout.Bands(0).AddNew()
                ug_Permisos_Cmd.Rows(i).Cells("Sel").Value = False
                ug_Permisos_Cmd.Rows(i).Cells("Codigo").Value = cmd.BC_ID
                ug_Permisos_Cmd.Rows(i).Cells("Descripcion").Value = cmd.BC_DESCRIPCION
                i += 1
            Next

            ug_Permisos_Cmd.UpdateData()

            E_usu_OPC_CMD.UOC_IDUSU = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = uce_Editor.Value}
            E_usu_OPC_CMD.UOC_IDOPC = New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU With {.OM_ID = uce_Ventana_C.Value}
            cmds = Obj_usu_cmdBL.getCmds_x_usu_y_opcion(E_usu_OPC_CMD)

            For Each cmd As BE.ContabilidadBE.SG_CO_TB_BTN_CMD In cmds
                For j As Int32 = 0 To ug_Permisos_Cmd.Rows.Count - 1
                    With ug_Permisos_Cmd.Rows(j)
                        If .Cells("Codigo").Value = cmd.BC_ID Then .Cells("Sel").Value = True
                    End With
                Next
            Next

            ug_Permisos_Cmd.UpdateData()

            cmds = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_Sel_Todo_Comandos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Sel_Todo_Comandos.Click
        Call Marcar_NoMarcar_Sel_Grilla(ug_Permisos_Cmd)
    End Sub
End Class
