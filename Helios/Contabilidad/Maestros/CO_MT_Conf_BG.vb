Imports Infragistics.Win.UltraWinTree

Public Class CO_MT_Conf_BG


    Dim Bol_EdicionRubros As Boolean = False
    Dim Bol_EdicionCuentas As Boolean = False


    Private Sub CO_MT_Conf_BG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Cargar_Formato_Balance_General()
        Call Cargar_Formato_Balance_General_2010()
        Call Cargar_Rubros()
        Call Cargar_Cuentas()
        Call Formatear_Grilla_Selector(ug_Cuentas)
        Call Formatear_Grilla_Selector(ug_Rubro_or_Cuenta)
        Call MostrarTabs(0, utc_vista, 0)
    End Sub

    Private Sub Cargar_Formato_Balance_General()

        Dim ClasesbgBL As New BL.ContabilidadBL.SG_CO_TB_CLASES_BG
        Dim GrupobgBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOS_BG
        Dim RubroBL As New BL.ContabilidadBL.SG_CO_TB_RUBRO
        Dim CuentaBL As New BL.ContabilidadBL.SG_CO_TB_RUBRO_CUENTA

        Dim ListaClases As List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
        Dim ListaGrupos As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
        Dim ListaRubros As List(Of BE.ContabilidadBE.SG_CO_TB_RUBRO)
        Dim ListaCuentas As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)


        Dim Unaclase As BE.ContabilidadBE.SG_CO_TB_CLASES_BG
        Dim UnGrupo As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG
        Dim UnRubro As BE.ContabilidadBE.SG_CO_TB_RUBRO
        Dim UnaCuenta As BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        Dim nodoClase As UltraTreeNode
        Dim nodoGrupo As UltraTreeNode
        Dim nodoRubro As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode


        Try

            ut_formatobg.Nodes.Clear()
            ListaClases = ClasesbgBL.getClases()

            For Each Unaclase In ListaClases
                nodoClase = ut_formatobg.Nodes.Add()
                nodoClase.Key = Unaclase.CBG_ID
                nodoClase.Text = Unaclase.CBG_DESCRIPCION
                nodoClase.Override.NodeAppearance.Image = My.Resources.rss
                ListaGrupos = GrupobgBL.getGrupos_x_Clase(Unaclase)

                For Each UnGrupo In ListaGrupos
                    nodoGrupo = nodoClase.Nodes.Add()
                    nodoGrupo.Key = nodoClase.Key + "G" + UnGrupo.GBG_ID.ToString
                    nodoGrupo.Text = UnGrupo.GBG_DESCRIPCION
                    nodoGrupo.Override.NodeAppearance.Image = My.Resources.layers

                    ListaRubros = RubroBL.getRubros_x_Grupos(UnGrupo)
                    For Each UnRubro In ListaRubros
                        nodoRubro = nodoGrupo.Nodes.Add()
                        nodoRubro.Key = nodoGrupo.Key & "R" & UnRubro.RU_ID.ToString
                        nodoRubro.Text = UnRubro.RU_CODIGO & " - " & UnRubro.RU_DESCRIPCION
                        nodoRubro.Override.NodeAppearance.Image = My.Resources.css

                        ListaCuentas = CuentaBL.getCuentas_x_Rubro(UnRubro)
                        For Each UnaCuenta In ListaCuentas
                            nodoCuenta = nodoRubro.Nodes.Add
                            nodoCuenta.Key = nodoRubro.Key & "C" & UnaCuenta.PC_IDCUENTA.ToString
                            nodoCuenta.Text = UnaCuenta.PC_NUM_CUENTA & " - " & UnaCuenta.PC_DESCRIPCION
                            nodoCuenta.Override.NodeAppearance.Image = My.Resources._16__Envelope_
                        Next
                    Next
                Next
            Next

            ut_formatobg.ExpandAll()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Cargar_Formato_Balance_General_2010()

        Dim ClasesbgBL As New BL.ContabilidadBL.SG_CO_TB_CLASES_BG
        Dim GrupobgBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOS_BG
        Dim CuentaBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_CUENTAS

        Dim ListaClases As List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
        Dim ListaGrupos As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
        Dim ListaCuentas As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)


        Dim Unaclase As BE.ContabilidadBE.SG_CO_TB_CLASES_BG
        Dim UnGrupo As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG
        Dim UnaCuenta As BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        Dim nodoClase As UltraTreeNode
        Dim nodoGrupo As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode


        Try

            ut_formatobg10.Nodes.Clear()

            ListaClases = ClasesbgBL.getClases()
            For Each Unaclase In ListaClases
                nodoClase = ut_formatobg10.Nodes.Add()
                nodoClase.Key = Unaclase.CBG_ID
                nodoClase.Text = Unaclase.CBG_DESCRIPCION
                nodoClase.Override.NodeAppearance.Image = My.Resources.rss

                ListaGrupos = GrupobgBL.getGrupos_x_Clase(Unaclase)
                For Each UnGrupo In ListaGrupos
                    nodoGrupo = nodoClase.Nodes.Add()
                    nodoGrupo.Key = nodoClase.Key + "G" + UnGrupo.GBG_ID.ToString
                    nodoGrupo.Text = UnGrupo.GBG_DESCRIPCION
                    nodoGrupo.Override.NodeAppearance.Image = My.Resources.layers

                    ListaCuentas = CuentaBL.getCuentas_x_Grupo(UnGrupo, gInt_IdEmpresa, gDat_Fecha_Sis.Year)
                    For Each UnaCuenta In ListaCuentas
                        nodoCuenta = nodoGrupo.Nodes.Add()
                        nodoCuenta.Key = nodoGrupo.Key & "C" & UnaCuenta.PC_IDCUENTA.ToString
                        nodoCuenta.Text = UnaCuenta.PC_NUM_CUENTA & " - " & UnaCuenta.PC_DESCRIPCION
                        nodoCuenta.Override.NodeAppearance.Image = My.Resources._16__Envelope_
                    Next
                Next
            Next

            ut_formatobg10.ExpandAll()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Cargar_Rubros()
        Dim RubrosBL As New BL.ContabilidadBL.SG_CO_TB_RUBRO
        Dim rubros As List(Of BE.ContabilidadBE.SG_CO_TB_RUBRO)
        Dim rubro As BE.ContabilidadBE.SG_CO_TB_RUBRO
        rubros = RubrosBL.getRubros()
        Dim i As Integer = 0

        LimpiaGrid(ug_Rubro_or_Cuenta, uds_Rubros)
        ug_Rubro_or_Cuenta.DataSource = uds_Rubros

        For Each rubro In rubros
            ug_Rubro_or_Cuenta.DisplayLayout.Bands(0).AddNew()
            ug_Rubro_or_Cuenta.Rows(i).Cells("RU_ID").Value = rubro.RU_ID
            ug_Rubro_or_Cuenta.Rows(i).Cells("RU_CODIGO").Value = rubro.RU_CODIGO
            ug_Rubro_or_Cuenta.Rows(i).Cells("RU_DESCRIPCION").Value = rubro.RU_DESCRIPCION
            i += 1
        Next

        rubro = Nothing
        rubros = Nothing
        RubrosBL = Nothing

        ug_Rubro_or_Cuenta.DisplayLayout.Bands(0).Columns("RU_ID").Hidden = True
        ug_Rubro_or_Cuenta.DisplayLayout.Bands(0).Columns("RU_CODIGO").Header.Caption = "Codigo"
        ug_Rubro_or_Cuenta.DisplayLayout.Bands(0).Columns("RU_DESCRIPCION").Header.Caption = "Descripcion"

        ug_Rubro_or_Cuenta.Rows(0).Activate()

    End Sub

    Private Sub Cargar_Cuentas()
        Dim CuentaBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim CuentaBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        With CuentaBE
            .PC_PERIODO = gDat_Fecha_Sis.Year
            .PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        ug_Cuentas.DataSource = CuentaBL.getCuentas_NDig(CuentaBE, 2)
        ug_Cuentas.DisplayLayout.Bands(0).Columns("PC_NUM_CUENTA").Width = 50

        ug_Cuentas10.DataSource = CuentaBL.getCuentas_NDig(CuentaBE, 2)
        ug_Cuentas10.DisplayLayout.Bands(0).Columns("PC_NUM_CUENTA").Width = 50

        ug_Cuentas.Rows(0).Activate()

        CuentaBL = Nothing
        CuentaBE = Nothing
    End Sub

    Private Sub ug_rubros_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Rubro_or_Cuenta.DoubleClickRow

        Dim nodeSel As UltraTreeNode = ut_formatobg.SelectedNodes(0)
        Dim Node_Added As UltraTreeNode = Nothing

        'Agregamos los rubros de la grilla a los grupos del Arbol

        Dim Int_IdRubro As Integer = ug_Rubro_or_Cuenta.ActiveRow.Cells("RU_ID").Value
        Dim Str_Descripcion As String = ug_Rubro_or_Cuenta.ActiveRow.Cells("RU_CODIGO").Value & " - " & ug_Rubro_or_Cuenta.ActiveRow.Cells("RU_DESCRIPCION").Value

        If Existe_Rubro_en_Arbol(Int_IdRubro) Then
            Avisar("El Rubro ya esta registrado en otro Grupo")
            Exit Sub
        End If

        Node_Added = ut_formatobg.SelectedNodes(0).Nodes.Add()
        Node_Added.Key = nodeSel.Key & "R" & Int_IdRubro
        Node_Added.Text = Str_Descripcion

    End Sub

    Private Function Existe_Rubro_en_Arbol(ByVal Int_Codigo_Rubro As Integer) As Boolean
        Existe_Rubro_en_Arbol = False

        Dim nodoClase As UltraTreeNode
        Dim nodoGrupo As UltraTreeNode
        Dim nodoRubro As UltraTreeNode

        For Each nodoClase In ut_formatobg.Nodes
            For Each nodoGrupo In nodoClase.Nodes
                For Each nodoRubro In nodoGrupo.Nodes
                    If nodoRubro.Key.Equals(nodoGrupo.Key & "R" & Int_Codigo_Rubro.ToString) Then
                        nodoClase = Nothing
                        nodoGrupo = Nothing
                        nodoRubro = Nothing
                        Return True
                        Exit Function
                    End If
                Next
            Next
        Next

    End Function

    Private Function Existe_Cuenta_en_Rubro(ByVal Int_Cuenta As Integer) As Boolean
        Existe_Cuenta_en_Rubro = False

        Dim nodoClase As UltraTreeNode
        Dim nodoGrupo As UltraTreeNode
        Dim nodoRubro As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode

        For Each nodoClase In ut_formatobg.Nodes
            For Each nodoGrupo In nodoClase.Nodes
                For Each nodoRubro In nodoGrupo.Nodes
                    If nodoRubro.Key.Equals(ut_formatobg.SelectedNodes(0).Key) Then
                        For Each nodoCuenta In nodoRubro.Nodes
                            If nodoCuenta.Key.Equals(nodoRubro.Key & "C" & Int_Cuenta.ToString) Then
                                nodoClase = Nothing
                                nodoGrupo = Nothing
                                nodoRubro = Nothing
                                nodoCuenta = Nothing
                                Return True
                                Exit Function
                            End If
                        Next
                    End If
                Next
            Next
        Next

    End Function

    Private Sub ubtn_CargarRubros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_CargarRubros.Click
        Bol_EdicionCuentas = False
        Bol_EdicionRubros = True
        Call MostrarTabs(0, utc_vista, 0)
    End Sub

    Private Sub ubtn_CargarCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_CargarCuentas.Click
        Bol_EdicionRubros = False
        Bol_EdicionCuentas = True
        Call MostrarTabs(1, utc_vista, 1)
        
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

    Private Sub ubtn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Grabar.Click

        'Grabamos los datos del arbol 
        Dim rubro_cuentaBL As New BL.ContabilidadBL.SG_CO_TB_RUBRO_CUENTA
        Dim grupobg_RubroBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_RUBRO
        Dim grupobg_RubroBE As BE.ContabilidadBE.SG_CO_TB_GRUPOBG_RUBRO
        Dim rubro_cuentaBE As BE.ContabilidadBE.SG_CO_TB_RUBRO_CUENTA

        Dim nodoClase As UltraTreeNode
        Dim nodoGrupo As UltraTreeNode
        Dim nodoRubro As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode

        Dim Id_grupo As Integer = 0
        Dim Id_rubro As Integer = 0
        Dim Id_cuenta As Integer = 0


        Call grupobg_RubroBL.Limpiar_Tablas_Amarres_BG()

        For Each nodoClase In ut_formatobg.Nodes
            For Each nodoGrupo In nodoClase.Nodes
                Id_grupo = Val(nodoGrupo.Key.ToString.Remove(0, 2))

                For Each nodoRubro In nodoGrupo.Nodes
                    Id_rubro = Val(nodoRubro.Key.ToString.Remove(0, 4))

                    grupobg_RubroBE = New BE.ContabilidadBE.SG_CO_TB_GRUPOBG_RUBRO
                    grupobg_RubroBE.GR_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG With {.GBG_ID = Id_grupo}
                    grupobg_RubroBE.GR_IDRUBRO = New BE.ContabilidadBE.SG_CO_TB_RUBRO With {.RU_ID = Id_rubro}
                    grupobg_RubroBL.Insert(grupobg_RubroBE)

                    For Each nodoCuenta In nodoRubro.Nodes
                        Id_cuenta = Val(nodoCuenta.Key.ToString.Remove(0, 6))

                        rubro_cuentaBE = New BE.ContabilidadBE.SG_CO_TB_RUBRO_CUENTA
                        rubro_cuentaBE.RC_IDRUBRO = New BE.ContabilidadBE.SG_CO_TB_RUBRO With {.RU_ID = Id_rubro}
                        rubro_cuentaBE.RC_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = Id_cuenta}
                        rubro_cuentaBL.Insert(rubro_cuentaBE)

                    Next
                Next
            Next
        Next
        Avisar("Listo!")
    End Sub

    Private Sub ubtn_Recargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Recargar.Click
        Call Cargar_Formato_Balance_General()
    End Sub

    Private Sub ug_Cuentas_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Cuentas.DoubleClickRow
        Try
            Dim nodeSel As UltraTreeNode = ut_formatobg.SelectedNodes(0)
            Dim Node_Added As UltraTreeNode = Nothing
            'agregamos las cuentas a los nodos Rubros

            Dim Int_IdCuenta As Integer = ug_Cuentas.ActiveRow.Cells("PC_IDCUENTA").Value
            Dim Str_Descripcion As String = ug_Cuentas.ActiveRow.Cells("PC_NUM_CUENTA").Value & " - " & ug_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value

            If Existe_Cuenta_en_Rubro(Int_IdCuenta) Then
                Avisar("La cuenta ya esta registrado en este Rubro")
                Exit Sub
            End If

            Node_Added = ut_formatobg.SelectedNodes(0).Nodes.Add()
            Node_Added.Key = nodeSel.Key & "C" & Int_IdCuenta.ToString
            Node_Added.Text = Str_Descripcion
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ug_Cuentas10_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Cuentas10.DoubleClickRow
        Try
            Dim nodeSel As UltraTreeNode = ut_formatobg10.SelectedNodes(0)
            Dim Node_Added As UltraTreeNode = Nothing
            Dim Node_tmp As UltraTreeNode = Nothing
            'agregamos las cuentas a los nodos Rubros


            Dim Int_IdCuenta As String = ug_Cuentas10.ActiveRow.Cells("PC_NUM_CUENTA").Value
            Dim Str_Descripcion As String = ug_Cuentas10.ActiveRow.Cells("PC_NUM_CUENTA").Value & " - " & ug_Cuentas10.ActiveRow.Cells("PC_DESCRIPCION").Value


            For Each Node_tmp In nodeSel.Nodes
                If Node_tmp.Key = nodeSel.Key & "C" & Int_IdCuenta.ToString Then
                    Exit Sub
                End If
            Next

            Node_Added = ut_formatobg10.SelectedNodes(0).Nodes.Add(nodeSel.Key & "C" & Int_IdCuenta.ToString, Str_Descripcion)
            'Node_Added.Key = nodeSel.Key & "C" & Int_IdCuenta.ToString
            'Node_Added.Text = Str_Descripcion
            Node_Added.Override.NodeAppearance.Image = My.Resources._16__Envelope_

        Catch ex As Exception

        End Try
        
    End Sub

   
    Private Sub ubtn_Guardar_BG_2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Guardar_BG_2010.Click
        'Grabamos los datos del arbol 

        Dim grupobg_CuentasBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_CUENTAS
        Dim grupobg_CuentasBE As BE.ContabilidadBE.SG_CO_TB_GRUPOBG_CUENTAS

        Dim nodoClase As UltraTreeNode
        Dim nodoGrupo As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode

        Dim Id_grupo As Integer = 0
        Dim Id_cuenta As Integer = 0


        Call grupobg_CuentasBL.Delete(gInt_IdEmpresa)

        For Each nodoClase In ut_formatobg10.Nodes
            For Each nodoGrupo In nodoClase.Nodes
                Id_grupo = Val(nodoGrupo.Key.ToString.Remove(0, 2))

                For Each nodoCuenta In nodoGrupo.Nodes
                    Id_cuenta = Val(nodoCuenta.Key.ToString.Remove(0, 4))

                    grupobg_CuentasBE = New BE.ContabilidadBE.SG_CO_TB_GRUPOBG_CUENTAS
                    grupobg_CuentasBE.GC_IDGRUPO = New BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG With {.GBG_ID = Id_grupo}
                    grupobg_CuentasBE.GC_IDCUENTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = Id_cuenta}
                    grupobg_CuentasBE.GC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    grupobg_CuentasBL.Insert(grupobg_CuentasBE)

                Next
            Next
        Next

        Avisar("Listo!")

    End Sub

    
    Private Sub ubtn_Recargar_BG2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Recargar_BG2010.Click
        Call Cargar_Formato_Balance_General_2010()
    End Sub

    Private Sub ut_formatobg10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ut_formatobg10.KeyDown
        If e.KeyCode = Keys.Delete Then
            ut_formatobg10.ActiveNode.Remove()
        End If
    End Sub
End Class