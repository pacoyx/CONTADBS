Imports Infragistics.Win.UltraWinToolbars
Imports System.Drawing.Printing
Imports System.Threading

Public Class CO_MN_MenuInicial

    Private Sub CO_MN_MenuInicial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CO_MN_MenuInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 10

        Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        If UsuarioBL.getTipo_Acceso_x_NomUsu(gStr_Usuario_Sis) = 2 Then
            Call Armar_Menu_por_Perfil()
        Else
            Call Armar_Menu_por_Usuario()
        End If
        UsuarioBL = Nothing


        Call Cargar_Estilos()
        Call Cargar_Imagen_Fondo()
        Call cargar_Fondo_Perfil()
        'Call Iniciar_CrystalReport()
        Me.Opacity = 100


        'utm_MenuBeta.Ribbon.QuickAccessToolbar.Location = QuickAccessToolbarLocation.BelowRibbon
        utm_MenuBeta.Ribbon.IsMinimized = True
        utm_MenuBeta.Ribbon.ApplicationMenuButtonImage = My.Resources._09_osX_Logo_marks

    End Sub
    Private Sub CO_MN_MenuBeta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not Preguntar("Esta Seguro que quiere cerrar el Sistema?") Then
            e.Cancel = True
            Exit Sub
        End If

        Call Grabar_Log_Salida()
        'Global.System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub Iniciar_CrystalReport()
        Try
            Dim Hilo_tmp As New Thread(AddressOf Carga_Servicio_Crystal)
            Hilo_tmp.IsBackground = True
            Hilo_tmp.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargar_Fondo_Perfil()

        Dim estilo_infra As String = String.Empty

        Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_IMG_SIS
        Dim obj_ImgSisBL As New BL.ContabilidadBL.SG_CO_TB_IMG_SIS
        Dim Obj_UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Dim Int_IdUsu As Integer = Obj_UsuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)
        Dim dt As DataTable = Nothing

        Try
            dt = obj_ImgSisBL.getImg_x_IdUsu(Int_IdUsu)

            If dt.Rows.Count > 0 Then
                estilo_infra = dt.Rows(0)("IS_ESTILO_SKIN")
                Call Cargar_Estilo_Infra(estilo_infra)
            End If

            Obj_UsuarioBL = Nothing
            obj_ImgSisBL = Nothing
            Entidad = Nothing
            dt = Nothing

        Catch ex As Exception
            Call Cargar_Estilo_Infra("Office2007Blue.isl")
            Obj_UsuarioBL = Nothing
            obj_ImgSisBL = Nothing
            Entidad = Nothing
            dt = Nothing
        End Try
    End Sub

    Private Sub Cargar_Imagen_Fondo()
        Try

            '_________________________________

            Dim Int_IdUsu As Integer = 0
            Dim obj_ImgSisBL As New BL.ContabilidadBL.SG_CO_TB_IMG_SIS
            Dim Obj_UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            Int_IdUsu = Obj_UsuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)

            Dim Dt As DataTable = obj_ImgSisBL.getImg_x_IdUsu(Int_IdUsu)

            If Dt.Rows.Count = 0 Then
                'Dt = obj_ImgSisBL.getImg_x_Pc(Environment.MachineName)
                Dt = obj_ImgSisBL.getImg_x_IdUsu(Int_IdUsu)

                If Dt.Rows.Count > 0 Then
                    Me.BackgroundImage = Bytes2Image(Dt.Rows(0)("IS_IMG"))
                Else
                    Me.BackgroundImage = My.Resources.MSNwall
                End If
            Else
                Me.BackgroundImage = Bytes2Image(Dt.Rows(0)("IS_IMG"))
            End If

            Dt.Dispose()
            Obj_UsuarioBL = Nothing
            obj_ImgSisBL = Nothing

        Catch ex As Exception

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

    Public Sub Armar_Menu_por_Perfil()
        Try

            CO_MN_Carga.Show()
            CO_MN_Carga.Activate()
            CO_MN_Carga.Refresh()

            Dim Int_IdPerfil As Integer = 1
            Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            Dim PerfilModuloBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_MODULO
            Dim PerfilModuloBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO
            Dim PerfilGrupoBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_GRUPO
            Dim PerfilGrupoBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO
            Dim PerfilOpcionBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_OPCION
            Dim PerfilOpcionBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION


            Dim dt_perfil_modulo As DataTable = Nothing
            Dim dt_perfil_grupo As DataTable = Nothing
            Dim dt_perfil_opcion As DataTable = Nothing
            Dim dt_perfil_opcion_hijo As DataTable = Nothing


            Int_IdPerfil = UsuarioBL.getPerfil_x_NomUsu(gStr_Usuario_Sis)
            PerfilModuloBE.PM_IDPERFIL = Int_IdPerfil
            PerfilModuloBE.PM_IDEMPRESA = gInt_IdEmpresa
            dt_perfil_modulo = PerfilModuloBL.getModulos_x_Perfil(PerfilModuloBE)


            Dim Int_Cod_Mod As Int16 = 0
            Dim Str_Nom_Mod As String = String.Empty

            For m As Integer = 0 To dt_perfil_modulo.Rows.Count - 1
                Str_Nom_Mod = dt_perfil_modulo.Rows(m)("MO_DESCRIPCION")
                Int_Cod_Mod = dt_perfil_modulo.Rows(m)("MO_ID")
                If dt_perfil_modulo.Rows(m)("IDPERFIL") > 0 Then
                    utm_MenuBeta.Ribbon.Tabs.Add(Str_Nom_Mod)

                    PerfilGrupoBE.PG_IDPERFIL = Int_IdPerfil
                    PerfilGrupoBE.PG_IDEMPRESA = gInt_IdEmpresa
                    PerfilGrupoBE.PG_IDMODULO = Int_Cod_Mod
                    dt_perfil_grupo = PerfilGrupoBL.getGrupos_x_Perfil(PerfilGrupoBE)

                    Dim Str_Nom_Grupo As String = String.Empty
                    Dim Int_cod_Grupo As Integer = 0
                    For g As Integer = 0 To dt_perfil_grupo.Rows.Count - 1
                        Str_Nom_Grupo = dt_perfil_grupo.Rows(g)("GM_NOMBRE")
                        Int_cod_Grupo = dt_perfil_grupo.Rows(g)("GM_ID")
                        If dt_perfil_grupo.Rows(g)("IDPERFIL") > 0 Then
                            utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups.Add(Str_Nom_Grupo)

                            PerfilOpcionBE.PG_IDPERFIL = Int_IdPerfil
                            PerfilOpcionBE.PG_IDEMPRESA = gInt_IdEmpresa
                            PerfilOpcionBE.PG_IDMODULO = Int_Cod_Mod
                            PerfilOpcionBE.PG_IDGRUPO = Int_cod_Grupo
                            dt_perfil_opcion = PerfilOpcionBL.getOpciones_x_perfil(PerfilOpcionBE)
                            For o As Integer = 0 To dt_perfil_opcion.Rows.Count - 1
                                If dt_perfil_opcion.Rows(o)("IDPERFIL") > 0 Then
                                    If dt_perfil_opcion.Rows(o)("OM_IDPADRE").ToString = String.Empty Then

                                        Dim nombre_Boton_Key As String = dt_perfil_opcion.Rows(o)("OM_ID") & "M"

                                        If dt_perfil_opcion.Rows(o)("OM_TIPO") = 1 Then
                                            Dim Boton As New ButtonTool(dt_perfil_opcion.Rows(o)("OM_ID") & "M")
                                            Boton.SharedProps.Caption = dt_perfil_opcion.Rows(o)("OM_DESCRIPCION")
                                            Boton.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText
                                            Boton.SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(dt_perfil_opcion.Rows(o)("OM_IMG"))
                                            Boton.Tag = dt_perfil_opcion.Rows(o)("OM_ID")
                                            utm_MenuBeta.Tools.Add(Boton)

                                        Else

                                            Dim Boton As New PopupMenuTool(dt_perfil_opcion.Rows(o)("OM_ID") & "M")
                                            Boton.SharedProps.Caption = dt_perfil_opcion.Rows(o)("OM_DESCRIPCION")
                                            Boton.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText
                                            Boton.SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(dt_perfil_opcion.Rows(o)("OM_IMG"))
                                            Boton.Tag = dt_perfil_opcion.Rows(o)("OM_ID")
                                            utm_MenuBeta.Tools.Add(Boton)

                                            'buscar Item por Boton.Key

                                            PerfilOpcionBE.PG_IDOPCION = dt_perfil_opcion.Rows(o)("OM_ID")
                                            dt_perfil_opcion_hijo = PerfilOpcionBL.getOpcionesHijos_x_padre(PerfilOpcionBE)

                                            For oh As Integer = 0 To dt_perfil_opcion_hijo.Rows.Count - 1
                                                Dim BtnMnu As New ButtonTool(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM")
                                                BtnMnu.Tag = dt_perfil_opcion_hijo.Rows(oh)("OM_ID")

                                                If dt_perfil_opcion_hijo.Rows(oh)("IDPERFIL") > 0 Then
                                                    utm_MenuBeta.Tools.Add(BtnMnu)

                                                    Boton.Tools.AddTool(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM", False)
                                                    Boton.Tools(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM").SharedProps.Caption = dt_perfil_opcion_hijo.Rows(oh)("OM_DESCRIPCION")
                                                    Boton.Tools(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM").SharedProps.DisplayStyle = ToolDisplayStyle.Default
                                                    Boton.Tools(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM").SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(dt_perfil_opcion_hijo.Rows(oh)("OM_IMG"))
                                                End If

                                            Next
                                        End If

                                        utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups(Str_Nom_Grupo).Tools.AddTool(nombre_Boton_Key)

                                        If dt_perfil_opcion.Rows(o)("OM_TAMANO_IMG") = 2 Then
                                            utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups(Str_Nom_Grupo).Tools(nombre_Boton_Key).InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large
                                        End If

                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next



            dt_perfil_modulo = Nothing
            dt_perfil_grupo = Nothing
            dt_perfil_opcion = Nothing
            dt_perfil_opcion_hijo = Nothing

            PerfilModuloBL = Nothing
            PerfilModuloBE = Nothing
            PerfilGrupoBL = Nothing
            PerfilGrupoBE = Nothing
            PerfilOpcionBL = Nothing
            PerfilOpcionBE = Nothing


            CO_MN_Carga.Close()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Armar_Menu_por_Perfil_ReCargar()
        Try

            CO_MN_Carga.Show()
            CO_MN_Carga.Activate()
            CO_MN_Carga.Refresh()

            Dim Int_IdPerfil As Integer = 1
            Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            Dim PerfilModuloBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_MODULO
            Dim PerfilModuloBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_MODULO
            Dim PerfilGrupoBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_GRUPO
            Dim PerfilGrupoBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_GRUPO
            Dim PerfilOpcionBL As New BL.ContabilidadBL.SG_CO_TB_PERFIL_OPCION
            Dim PerfilOpcionBE As New BE.ContabilidadBE.SG_CO_TB_PERFIL_OPCION


            Dim dt_perfil_modulo As DataTable = Nothing
            Dim dt_perfil_grupo As DataTable = Nothing
            Dim dt_perfil_opcion As DataTable = Nothing
            Dim dt_perfil_opcion_hijo As DataTable = Nothing


            Int_IdPerfil = UsuarioBL.getPerfil_x_NomUsu(gStr_Usuario_Sis)
            PerfilModuloBE.PM_IDPERFIL = Int_IdPerfil
            PerfilModuloBE.PM_IDEMPRESA = gInt_IdEmpresa
            dt_perfil_modulo = PerfilModuloBL.getModulos_x_Perfil(PerfilModuloBE)


            Dim Int_Cod_Mod As Int16 = 0
            Dim Str_Nom_Mod As String = String.Empty

            'Limpiamos todos los menus si hay
            For t As Integer = 0 To utm_MenuBeta.Ribbon.Tabs.Count - 1
                For g As Integer = 0 To utm_MenuBeta.Ribbon.Tabs(t).Groups.Count - 1
                    utm_MenuBeta.Ribbon.Tabs(t).Groups(g).Tools.Clear()
                Next
            Next

            For t As Integer = 0 To utm_MenuBeta.Ribbon.Tabs.Count - 1
                utm_MenuBeta.Ribbon.Tabs(t).Groups.Clear()
            Next

            utm_MenuBeta.Ribbon.Tabs.Clear()



            'Skin______________

            Dim myBoton1 As PopupControlContainerTool = utm_MenuBeta.Tools("C_Mnu_Skin")
            Dim Item2 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_Fondo")
            Dim Item3 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_CambiarFecha")
            Dim Item4 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_CambiarEmpresa")
            Dim Item5 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_Impresoras")
            Dim Item6 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_Calculadora")
            Dim Item7 As PopupGalleryTool = utm_MenuBeta.Tools("C_Mnu_Ayuda")
            Dim Item8 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_CerrarSession")
            Dim Item9 As ButtonTool = utm_MenuBeta.Tools("C_Mnu_Salir")

            utm_MenuBeta.Tools.Clear()

            utm_MenuBeta.Tools.Add(myBoton1)
            utm_MenuBeta.Tools.Add(Item2)
            utm_MenuBeta.Tools.Add(Item3)
            utm_MenuBeta.Tools.Add(Item4)
            utm_MenuBeta.Tools.Add(Item5)
            utm_MenuBeta.Tools.Add(Item6)
            utm_MenuBeta.Tools.Add(Item7)
            utm_MenuBeta.Tools.Add(Item8)
            utm_MenuBeta.Tools.Add(Item9)

            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(myBoton1.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item2.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item3.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item4.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item5.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item6.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item7.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item8.Key)
            utm_MenuBeta.Ribbon.ApplicationMenu.ToolAreaLeft.Tools.AddTool(Item9.Key)


            '___________________________________________________________skin



            For m As Integer = 0 To dt_perfil_modulo.Rows.Count - 1
                Str_Nom_Mod = dt_perfil_modulo.Rows(m)("MO_DESCRIPCION")
                Int_Cod_Mod = dt_perfil_modulo.Rows(m)("MO_ID")
                If dt_perfil_modulo.Rows(m)("IDPERFIL") > 0 Then
                    utm_MenuBeta.Ribbon.Tabs.Add(Str_Nom_Mod)

                    PerfilGrupoBE.PG_IDPERFIL = Int_IdPerfil
                    PerfilGrupoBE.PG_IDEMPRESA = gInt_IdEmpresa
                    PerfilGrupoBE.PG_IDMODULO = Int_Cod_Mod
                    dt_perfil_grupo = PerfilGrupoBL.getGrupos_x_Perfil(PerfilGrupoBE)

                    Dim Str_Nom_Grupo As String = String.Empty
                    Dim Int_cod_Grupo As Integer = 0
                    For g As Integer = 0 To dt_perfil_grupo.Rows.Count - 1
                        Str_Nom_Grupo = dt_perfil_grupo.Rows(g)("GM_NOMBRE")
                        Int_cod_Grupo = dt_perfil_grupo.Rows(g)("GM_ID")
                        If dt_perfil_grupo.Rows(g)("IDPERFIL") > 0 Then
                            utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups.Add(Str_Nom_Grupo)

                            PerfilOpcionBE.PG_IDPERFIL = Int_IdPerfil
                            PerfilOpcionBE.PG_IDEMPRESA = gInt_IdEmpresa
                            PerfilOpcionBE.PG_IDMODULO = Int_Cod_Mod
                            PerfilOpcionBE.PG_IDGRUPO = Int_cod_Grupo
                            dt_perfil_opcion = PerfilOpcionBL.getOpciones_x_perfil(PerfilOpcionBE)
                            For o As Integer = 0 To dt_perfil_opcion.Rows.Count - 1
                                If dt_perfil_opcion.Rows(o)("IDPERFIL") > 0 Then
                                    If dt_perfil_opcion.Rows(o)("OM_IDPADRE").ToString = String.Empty Then

                                        Dim nombre_Boton_Key As String = dt_perfil_opcion.Rows(o)("OM_ID") & "M"

                                        If dt_perfil_opcion.Rows(o)("OM_TIPO") = 1 Then
                                            Dim Boton As New ButtonTool(dt_perfil_opcion.Rows(o)("OM_ID") & "M")
                                            Boton.SharedProps.Caption = dt_perfil_opcion.Rows(o)("OM_DESCRIPCION")
                                            Boton.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText
                                            Boton.SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(dt_perfil_opcion.Rows(o)("OM_IMG"))
                                            Boton.Tag = dt_perfil_opcion.Rows(o)("OM_ID")
                                            utm_MenuBeta.Tools.Add(Boton)

                                        Else

                                            Dim Boton As New PopupMenuTool(dt_perfil_opcion.Rows(o)("OM_ID") & "M")
                                            Boton.SharedProps.Caption = dt_perfil_opcion.Rows(o)("OM_DESCRIPCION")
                                            Boton.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText
                                            Boton.SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(dt_perfil_opcion.Rows(o)("OM_IMG"))
                                            Boton.Tag = dt_perfil_opcion.Rows(o)("OM_ID")
                                            utm_MenuBeta.Tools.Add(Boton)

                                            'buscar Item por Boton.Key

                                            PerfilOpcionBE.PG_IDOPCION = dt_perfil_opcion.Rows(o)("OM_ID")
                                            dt_perfil_opcion_hijo = PerfilOpcionBL.getOpcionesHijos_x_padre(PerfilOpcionBE)

                                            For oh As Integer = 0 To dt_perfil_opcion_hijo.Rows.Count - 1
                                                Dim BtnMnu As New ButtonTool(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM")
                                                BtnMnu.Tag = dt_perfil_opcion_hijo.Rows(oh)("OM_ID")

                                                If dt_perfil_opcion_hijo.Rows(oh)("IDPERFIL") > 0 Then
                                                    utm_MenuBeta.Tools.Add(BtnMnu)

                                                    Boton.Tools.AddTool(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM", False)
                                                    Boton.Tools(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM").SharedProps.Caption = dt_perfil_opcion_hijo.Rows(oh)("OM_DESCRIPCION")
                                                    Boton.Tools(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM").SharedProps.DisplayStyle = ToolDisplayStyle.Default
                                                    Boton.Tools(dt_perfil_opcion_hijo.Rows(oh)("OM_ID") & "BM").SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(dt_perfil_opcion_hijo.Rows(oh)("OM_IMG"))
                                                End If

                                            Next
                                        End If

                                        utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups(Str_Nom_Grupo).Tools.AddTool(nombre_Boton_Key)

                                        If dt_perfil_opcion.Rows(o)("OM_TAMANO_IMG") = 2 Then
                                            utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups(Str_Nom_Grupo).Tools(nombre_Boton_Key).InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large
                                        End If

                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next



            dt_perfil_modulo = Nothing
            dt_perfil_grupo = Nothing
            dt_perfil_opcion = Nothing
            dt_perfil_opcion_hijo = Nothing

            PerfilModuloBL = Nothing
            PerfilModuloBE = Nothing
            PerfilGrupoBL = Nothing
            PerfilGrupoBE = Nothing
            PerfilOpcionBL = Nothing
            PerfilOpcionBE = Nothing


            CO_MN_Carga.Close()
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Armar_Menu_por_Usuario()
        Try
            CO_MN_Carga.Show()
            CO_MN_Carga.Activate()
            CO_MN_Carga.Refresh()

            Dim Obj_Modulo As New BL.ContabilidadBL.SG_CO_TB_MODULO
            Dim Obj_Grupo As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU
            Dim Obj_Opciones As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
            Dim Obj_Usu As New BL.ContabilidadBL.SG_CO_TB_USUARIO

            Dim modulos As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO)
            Dim grupos As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
            Dim Opciones As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
            Dim Opciones_Items_BtnMnu As New List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)

            Dim Bol_HasMod As Boolean = False
            Dim Bol_HasGru As Boolean = False
            Dim Int_IdUsuario As Integer = Obj_Usu.getIdUsu_x_NomUsu(gStr_Usuario_Sis)

            modulos = Obj_Modulo.getModulos

            Dim Int_Cod_Mod As Int16 = 0
            Dim Str_Nom_Mod As String = String.Empty

            'Limpiamos todos los menus si hay
            utm_MenuBeta.Ribbon.Tabs.Clear()

            For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO In modulos
                Str_Nom_Mod = modulo.MO_DESCRIPCION
                Int_Cod_Mod = modulo.MO_ID

                Bol_HasMod = Validar_Usuari_x_Modulo(Int_IdUsuario, Int_Cod_Mod)
                '
                If Bol_HasMod Then
                    utm_MenuBeta.Ribbon.Tabs.Add(Str_Nom_Mod)
                    grupos = Obj_Grupo.getGrupos_x_Modulo(Int_Cod_Mod)

                    For Each grupo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU In grupos

                        Bol_HasGru = Validar_Usuario_x_Grupo(Int_IdUsuario, grupo.GM_ID)

                        If Bol_HasGru Then

                            utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups.Add(grupo.GM_NOMBRE)
                            Opciones = Obj_Opciones.getOpcionesMenu_x_Grupo(grupo.GM_ID)

                            For Each opcion As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In Opciones

                                If opcion.OM_IDPADRE Is Nothing Then

                                    Dim nombre_Boton_Key As String = opcion.OM_ID & "M"
                                    If opcion.OM_TIPO.TB_ID = 1 Then
                                        Dim Boton As New ButtonTool(opcion.OM_ID & "M")
                                        Boton.SharedProps.Caption = opcion.OM_DESCRIPCION
                                        Boton.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText
                                        Boton.SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(opcion.OM_IMG)
                                        Boton.Tag = opcion.OM_ID
                                        utm_MenuBeta.Tools.Add(Boton)
                                    Else
                                        Dim Boton As New PopupMenuTool(opcion.OM_ID & "M")

                                        Boton.SharedProps.Caption = opcion.OM_DESCRIPCION
                                        Boton.SharedProps.DisplayStyle = ToolDisplayStyle.ImageAndText
                                        Boton.SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(opcion.OM_IMG)
                                        Boton.Tag = opcion.OM_ID
                                        utm_MenuBeta.Tools.Add(Boton)

                                        'buscar Item por Boton.Key
                                        Opciones_Items_BtnMnu = Obj_Opciones.getOpcionesMenu_x_ItemPadre(opcion.OM_ID)
                                        For Each itemBtnMn As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In Opciones_Items_BtnMnu
                                            Dim BtnMnu As New ButtonTool(itemBtnMn.OM_ID & "BM")
                                            BtnMnu.Tag = itemBtnMn.OM_ID
                                            utm_MenuBeta.Tools.Add(BtnMnu)

                                            Boton.Tools.AddTool(itemBtnMn.OM_ID & "BM", False)
                                            Boton.Tools(itemBtnMn.OM_ID & "BM").SharedProps.Caption = itemBtnMn.OM_DESCRIPCION
                                            Boton.Tools(itemBtnMn.OM_ID & "BM").SharedProps.DisplayStyle = ToolDisplayStyle.Default
                                            Boton.Tools(itemBtnMn.OM_ID & "BM").SharedProps.AppearancesSmall.Appearance.Image = Bytes2Image(itemBtnMn.OM_IMG)
                                        Next

                                    End If

                                    utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups(grupo.GM_NOMBRE).Tools.AddTool(nombre_Boton_Key)

                                    If opcion.OM_TAMANO_IMG.TI_ID = 2 Then
                                        utm_MenuBeta.Ribbon.Tabs(Str_Nom_Mod).Groups(grupo.GM_NOMBRE).Tools(nombre_Boton_Key).InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large
                                    End If


                                End If
                            Next
                        End If
                    Next
                End If
            Next

            CO_MN_Carga.Close()


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Function Validar_Usuari_x_Modulo(ByVal Int_Usuario As Integer, ByVal Modulo As Integer) As Boolean
        Validar_Usuari_x_Modulo = False
        Try
            Dim modulos_usuario As New List(Of BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO)
            Dim Obj_ModUsuBL As New BL.ContabilidadBL.SG_CO_TB_MODULO_USUARIO

            modulos_usuario = Obj_ModUsuBL.getMod_x_Usuario(Int_Usuario)

            For Each mymodulo As BE.ContabilidadBE.SG_CO_TB_MODULO_USUARIO In modulos_usuario
                If mymodulo.MU_IDMODULO.MO_ID = Modulo Then Return True
            Next

            Obj_ModUsuBL = Nothing

        Catch ex As Exception

        End Try
    End Function

    Public Function Validar_Usuario_x_Grupo(ByVal Int_Usuario As Integer, ByVal Int_Grupo As Integer) As Boolean
        Validar_Usuario_x_Grupo = False
        Try

            Dim Obj_GrupoUsu As New BL.ContabilidadBL.SG_CO_TB_USUARIO_GRUPO_MNU
            Dim gruposUsus As New List(Of BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU)
            gruposUsus = Obj_GrupoUsu.getGrupos_Usu(Int_Usuario)

            For Each myGrupo As BE.ContabilidadBE.SG_CO_TB_USUARIO_GRUPO_MNU In gruposUsus
                If myGrupo.GU_IDGRUPO.GM_ID = Int_Grupo Then Return True
            Next

        Catch ex As Exception

        End Try
    End Function

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
        'Call Guardar_Estilo_Infra_RegEdit(ListBox1.Text)
        Call Guardar_Estilo_en_PerfilTabla(ListBox1.Text)
    End Sub

    Private Sub utm_MenuBeta_ToolClick_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utm_MenuBeta.ToolClick
        Try
            Select Case e.Tool.Key
                Case "C_Mnu_Fondo"
                    CO_MT_CambiarFondoMenu.MdiParent = Me
                    CO_MT_CambiarFondoMenu.Show()
                Case "C_Mnu_Impresoras"
                    CO_MT_Impresoras.MdiParent = Me
                    CO_MT_Impresoras.Show()
                Case "C_Mnu_CambiarFecha"
                    CO_MT_CambiarFecha.MdiParent = Me
                    CO_MT_CambiarFecha.Show()
                Case "C_Mnu_CambiarEmpresa"
                    CO_MT_CambiarEmpresa.Show()
                Case "C_Mnu_Salir"
                    Me.Close()
                Case "C_Mnu_CerrarSession"
                    Application.Restart()
                Case "C_Mnu_Acercade"
                    AboutBox1.ShowDialog()
                Case "C_Mnu_Calculadora"
                    Process.Start("PortableDeskCalcv520.exe")
                Case "CO_Mnu_CambiarClaveUsu"
                    CO_MT_CambiarClaveUsu.Show()
                Case Else

                    Dim Obj_OpcionMenuBL As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
                    Dim Id As String = e.Tool.Key.ToString.Replace("BM", "").Replace("M", "").Trim
                    Dim Nom_formulario As String = Obj_OpcionMenuBL.getNombre_formulario_x_Id(CInt(Id))

                    Dim formulario As Form
                    Dim tipoObjeto As Type = Type.GetType(String.Format("Contabilidad.{0}", Nom_formulario))
                    Dim objeto As Object = Activator.CreateInstance(tipoObjeto)
                    formulario = DirectCast(objeto, Form)
                    formulario.MdiParent = Me
                    formulario.Show()

            End Select


        Catch ex As Exception

        End Try

    End Sub

End Class