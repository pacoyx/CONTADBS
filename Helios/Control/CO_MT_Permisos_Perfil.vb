Imports Infragistics.Win.UltraWinTree

Public Class CO_MT_Permisos_Perfil
    Dim Bol_Listo As Boolean = False

    Private Sub CO_MT_Permisos_Perfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Perfil()
    End Sub

    Private Sub Cargar_Perfil()
        Try
            Dim obj_TipoUsu As New BL.ContabilidadBL.SG_CO_TB_TIPO_USUARIO
            uce_perfil.DataSource = obj_TipoUsu.getTipos()
            uce_perfil.DisplayMember = "TU_DESCRIPCION"
            uce_perfil.ValueMember = "TU_CODIGO"
            obj_TipoUsu = Nothing
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
    Private Sub Cargar_Permisos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dt_perfil_empresa As DataTable = Nothing
            Dim dt_perfil_modulos As DataTable = Nothing
            Dim dt_perfil_grupos As DataTable = Nothing
            Dim dt_perfil_Opciones As DataTable = Nothing
            Dim dt_perfil_Opciones_Hijos As DataTable = Nothing

            Dim PerfilEmpresaBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_EMPRESA
            Dim PerfilEmpresaBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_EMPRESA

            Dim PerfilModuloBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_MODULO
            Dim PerfilModuloBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO

            Dim PerfilGrupoBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_GRUPO
            Dim PerfilGrupoBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO

            Dim PerfilOpcionBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_OPCION
            Dim PerfilOpcionBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION


            PerfilEmpresaBE.PU_IDPERFIL = uce_perfil.Value
            PerfilModuloBE.PM_IDPERFIL = uce_perfil.Value
            PerfilGrupoBE.PG_IDPERFIL = uce_perfil.Value
            PerfilOpcionBE.PG_IDPERFIL = uce_perfil.Value


            ut_permisos.Nodes.Clear()
            dt_perfil_empresa = PerfilEmpresaBL.getEmpresas_x_Perfil(PerfilEmpresaBE)
            For i As Integer = 0 To dt_perfil_empresa.Rows.Count - 1
                Dim mynode_emp As UltraTreeNode
                Dim Int_IdEmp As Integer = dt_perfil_empresa.Rows(i)("EM_ID")
                mynode_emp = ut_permisos.Nodes.Add
                mynode_emp.Text = dt_perfil_empresa.Rows(i)("EM_NOMBRE")
                mynode_emp.Key = Int_IdEmp
                mynode_emp.Tag = Int_IdEmp
                If dt_perfil_empresa.Rows(i)("IDPERFIL") > 0 Then
                    mynode_emp.CheckedState = CheckState.Checked
                End If
                mynode_emp.Override.NodeStyle = NodeStyle.CheckBox
                mynode_emp.Override.NodeAppearance.Image = My.Resources.H_D_05_24x24_32

                Dim mynode_mod As UltraTreeNode
                PerfilModuloBE.PM_IDEMPRESA = Int_IdEmp
                dt_perfil_modulos = PerfilModuloBL.getModulos_x_Perfil(PerfilModuloBE)
                For m As Integer = 0 To dt_perfil_modulos.Rows.Count - 1
                    Dim Int_IdMod As Integer = dt_perfil_modulos.Rows(m)("MO_ID")
                    mynode_mod = mynode_emp.Nodes.Add()
                    mynode_mod.Text = dt_perfil_modulos.Rows(m)("MO_DESCRIPCION")
                    mynode_mod.Key = Int_IdEmp.ToString & "-" & Int_IdMod
                    mynode_mod.Tag = Int_IdMod
                    If dt_perfil_modulos.Rows(m)("IDPERFIL") > 0 Then
                        mynode_mod.CheckedState = CheckState.Checked
                    End If
                    mynode_mod.Override.NodeStyle = NodeStyle.CheckBox
                    mynode_mod.Override.NodeAppearance.Image = My.Resources.database

                    Dim mynode_grupo As UltraTreeNode
                    PerfilGrupoBE.PG_IDEMPRESA = Int_IdEmp
                    PerfilGrupoBE.PG_IDMODULO = Int_IdMod
                    dt_perfil_grupos = PerfilGrupoBL.getGrupos_x_Perfil(PerfilGrupoBE)

                    For g As Integer = 0 To dt_perfil_grupos.Rows.Count - 1
                        Dim Int_IdGrupo As Integer = dt_perfil_grupos.Rows(g)("GM_ID")
                        mynode_grupo = mynode_mod.Nodes.Add
                        mynode_grupo.Text = dt_perfil_grupos.Rows(g)("GM_NOMBRE")
                        mynode_grupo.Key = Int_IdEmp.ToString & Int_IdMod & "-" & Int_IdGrupo.ToString
                        mynode_grupo.Tag = Int_IdGrupo
                        If dt_perfil_grupos.Rows(g)("IDPERFIL") > 0 Then
                            mynode_grupo.CheckedState = CheckState.Checked
                        End If
                        mynode_grupo.Override.NodeStyle = NodeStyle.CheckBox
                        mynode_grupo.Override.NodeAppearance.Image = My.Resources.group

                        Dim mynode_opcion As UltraTreeNode
                        PerfilOpcionBE.PG_IDEMPRESA = Int_IdEmp
                        PerfilOpcionBE.PG_IDMODULO = Int_IdMod
                        PerfilOpcionBE.PG_IDGRUPO = Int_IdGrupo
                        dt_perfil_Opciones = PerfilOpcionBL.getOpciones_x_perfil(PerfilOpcionBE)

                        For o As Integer = 0 To dt_perfil_Opciones.Rows.Count - 1
                            Dim Int_IdOpcion As Integer = dt_perfil_Opciones.Rows(o)("OM_ID")
                            mynode_opcion = mynode_grupo.Nodes.Add()
                            mynode_opcion.Text = dt_perfil_Opciones.Rows(o)("OM_DESCRIPCION")
                            mynode_opcion.Key = Int_IdEmp.ToString & Int_IdMod.ToString & Int_IdGrupo.ToString & "-" & Int_IdOpcion.ToString
                            mynode_opcion.Tag = Int_IdOpcion
                            If dt_perfil_Opciones.Rows(o)("IDPERFIL") > 0 Then
                                mynode_opcion.CheckedState = CheckState.Checked
                            End If
                            mynode_opcion.Override.NodeStyle = NodeStyle.CheckBox
                            mynode_opcion.Override.NodeAppearance.Image = My.Resources.layout




                            Dim mynode_opcion_hijo As UltraTreeNode
                            PerfilOpcionBE.PG_IDOPCION = Int_IdOpcion
                            dt_perfil_Opciones_Hijos = PerfilOpcionBL.getOpcionesHijos_x_padre(PerfilOpcionBE)
                            For oh As Integer = 0 To dt_perfil_Opciones_Hijos.Rows.Count - 1
                                Dim Int_IdOpcion_hijo As Integer = dt_perfil_Opciones_Hijos.Rows(oh)("OM_ID")
                                mynode_opcion_hijo = mynode_opcion.Nodes.Add
                                mynode_opcion_hijo.Text = dt_perfil_Opciones_Hijos.Rows(oh)("OM_DESCRIPCION")
                                mynode_opcion_hijo.Key = Int_IdEmp.ToString & Int_IdMod.ToString & Int_IdGrupo.ToString & Int_IdOpcion.ToString & "-" & Int_IdOpcion_hijo.ToString
                                mynode_opcion_hijo.Tag = Int_IdOpcion_hijo
                                If dt_perfil_Opciones_Hijos.Rows(oh)("IDPERFIL") > 0 Then
                                    mynode_opcion_hijo.CheckedState = CheckState.Checked
                                End If
                                mynode_opcion_hijo.Override.NodeStyle = NodeStyle.CheckBox
                                mynode_opcion_hijo.Override.NodeAppearance.Image = My.Resources.layout
                            Next



                        Next
                    Next
                Next
            Next


            PerfilEmpresaBE = Nothing
            PerfilEmpresaBL = Nothing

            PerfilModuloBL = Nothing
            PerfilModuloBE = Nothing

            PerfilGrupoBL = Nothing
            PerfilGrupoBE = Nothing

            PerfilOpcionBE = Nothing
            PerfilOpcionBL = Nothing

            dt_perfil_empresa.Dispose()
            dt_perfil_modulos.Dispose()
            dt_perfil_grupos.Dispose()
            dt_perfil_Opciones.Dispose()

            Me.Cursor = Cursors.Default
            Bol_Listo = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_perfil_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_perfil.ValueChanged
        Call Cargar_Permisos()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Call Grabar_Opicones()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Grabar_Opicones()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim nodo_emp As UltraTreeNode = Nothing
            Dim nodo_mod As UltraTreeNode = Nothing
            Dim nodo_gru As UltraTreeNode = Nothing
            Dim nodo_opc As UltraTreeNode = Nothing
            Dim nodo_opc_hijo As UltraTreeNode = Nothing
            Dim Int_Cod_Emp As Integer = 0

            Dim PerfilEmpresaBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_EMPRESA
            Dim PerfilEmpresaBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_EMPRESA

            Dim PerfilModuloBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_MODULO
            Dim PerfilModuloBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO

            Dim PerfilGrupoBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_GRUPO
            Dim PerfilGrupoBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO

            Dim PerfilOpcionBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_OPCION
            Dim PerfilOpcionBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION

            PerfilModuloBE.PM_IDPERFIL = uce_perfil.Value
            PerfilEmpresaBE.PU_IDPERFIL = uce_perfil.Value
            PerfilGrupoBE.PG_IDPERFIL = uce_perfil.Value
            PerfilOpcionBE.PG_IDPERFIL = uce_perfil.Value

            PerfilEmpresaBL.Delete(PerfilEmpresaBE)
            'PerfilModuloBL.Delete(PerfilModuloBE)
            'PerfilGrupoBL.Delete(PerfilGrupoBE)
            'PerfilOpcionBL.Delete(PerfilOpcionBE)

            For Each nodo_emp In ut_permisos.Nodes
                PerfilEmpresaBE.PU_IDEMPRESA = nodo_emp.Tag
                If nodo_emp.CheckedState Then
                    PerfilEmpresaBL.Insert(PerfilEmpresaBE)
                End If

                For Each nodo_mod In nodo_emp.Nodes
                    If nodo_mod.CheckedState Then
                        PerfilModuloBE.PM_IDMODULO = nodo_mod.Tag
                        PerfilModuloBE.PM_IDEMPRESA = nodo_emp.Tag
                        PerfilModuloBL.Insert(PerfilModuloBE)

                        For Each nodo_gru In nodo_mod.Nodes
                            If nodo_gru.CheckedState Then
                                PerfilGrupoBE.PG_IDEMPRESA = nodo_emp.Tag
                                PerfilGrupoBE.PG_IDMODULO = nodo_mod.Tag
                                PerfilGrupoBE.PG_IDGRUPO = nodo_gru.Tag
                                PerfilGrupoBL.Insert(PerfilGrupoBE)

                                For Each nodo_opc In nodo_gru.Nodes
                                    If nodo_opc.CheckedState Then
                                        PerfilOpcionBE.PG_IDEMPRESA = nodo_emp.Tag
                                        PerfilOpcionBE.PG_IDMODULO = nodo_mod.Tag
                                        PerfilOpcionBE.PG_IDGRUPO = nodo_gru.Tag
                                        PerfilOpcionBE.PG_IDOPCION = nodo_opc.Tag
                                        PerfilOpcionBL.Insert(PerfilOpcionBE)
                                        For Each nodo_opc_hijo In nodo_opc.Nodes
                                            If nodo_opc_hijo.CheckedState Then
                                                PerfilOpcionBE.PG_IDEMPRESA = nodo_emp.Tag
                                                PerfilOpcionBE.PG_IDMODULO = nodo_mod.Tag
                                                PerfilOpcionBE.PG_IDGRUPO = nodo_gru.Tag
                                                PerfilOpcionBE.PG_IDOPCION = nodo_opc_hijo.Tag
                                                PerfilOpcionBL.Insert(PerfilOpcionBE)
                                            End If
                                        Next
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            Next

            PerfilGrupoBE = Nothing
            PerfilGrupoBL = Nothing

            PerfilModuloBE = Nothing
            PerfilModuloBL = Nothing

            PerfilEmpresaBE = Nothing
            PerfilEmpresaBL = Nothing

            Avisar("Listo!")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw ex
        End Try
    End Sub

    Private Sub ut_permisos_AfterCheck(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.NodeEventArgs) Handles ut_permisos.AfterCheck
        Try
            If Bol_Listo Then
                If e.TreeNode.HasNodes Then
                    For Each nodo As UltraTreeNode In e.TreeNode.Nodes
                        nodo.CheckedState = e.TreeNode.CheckedState
                    Next
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class