Imports Infragistics.Win.UltraWinTree

Public Class CO_MT_Conf_EGP

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Cargar_Cuentas(ByVal digitos As Integer)
        Dim CuentaBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim CuentaBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS


        With CuentaBE
            .PC_PERIODO = gDat_Fecha_Sis.Year
            .PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With

        ug_Cuentas10.DataSource = CuentaBL.getCuentas_NDig(CuentaBE, digitos)
        ug_Cuentas10.DisplayLayout.Bands(0).Columns("PC_NUM_CUENTA").Width = 50
        ug_Cuentas10.Rows(0).Activate()

        CuentaBL = Nothing
        CuentaBE = Nothing
    End Sub

    Private Sub CO_MT_Conf_EGP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Cuentas(2)
        Call Cargar_Arbol_EGP()
    End Sub

    Private Sub Cargar_Arbol_EGP()

        Dim formatoEgpBL As New BL.ContabilidadBL.SG_CO_TB_CONCEPTO_EGP
        Dim CtasConceptoBL As New BL.ContabilidadBL.SG_CO_TB_CTA_CONCEPTO_EGP
        Dim dt_titulos As DataTable = formatoEgpBL.get_Ctas_Titulo()
        Dim dt_Cuentas As DataTable = Nothing

        Dim nodoConcepto As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode


        Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}, .PC_PERIODO = gDat_Fecha_Sis.Year}

        ut_formatobg10.Nodes.Clear()

        For i As Integer = 0 To dt_titulos.Rows.Count - 1

            nodoConcepto = ut_formatobg10.Nodes.Add()

            nodoConcepto.Key = dt_titulos.Rows(i)("CO_ID").ToString.PadLeft(2, "0")
            nodoConcepto.Text = dt_titulos.Rows(i)("CO_DESCRIPCION")
            nodoConcepto.Override.NodeAppearance.Image = My.Resources.rss

            dt_Cuentas = CtasConceptoBL.get_Ctas_X_Concepto(dt_titulos.Rows(i)("CO_ID"), gInt_IdEmpresa)
            For ii As Integer = 0 To dt_Cuentas.Rows.Count - 1
                nodoCuenta = nodoConcepto.Nodes.Add
                nodoCuenta.Key = nodoConcepto.Key & "C" & dt_Cuentas.Rows(ii)("CC_CUENTA").ToString
                planctasBE.PC_NUM_CUENTA = dt_Cuentas.Rows(ii)("CC_CUENTA").ToString
                planctasBL.getCuenta_X_NumeroCta(planctasBE)

                nodoCuenta.Text = dt_Cuentas.Rows(ii)("CC_CUENTA").ToString & " - " & planctasBE.PC_DESCRIPCION
                nodoCuenta.Override.NodeAppearance.Image = My.Resources.layers
            Next
        Next

        ut_formatobg10.ExpandAll()

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
            Node_Added.Override.NodeAppearance.Image = My.Resources.layers

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ubtn_Recargar_BG2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Recargar_BG2010.Click
        Call Cargar_Arbol_EGP()
    End Sub

    Private Sub UltraNumericEditor1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraNumericEditor1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Cuentas(UltraNumericEditor1.Value)
        End If
    End Sub

    Private Sub Tool_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Guardar.Click
        Dim CtaConceptoBL As New BL.ContabilidadBL.SG_CO_TB_CTA_CONCEPTO_EGP
        Dim CtaConceptoBE As BE.ContabilidadBE.SG_CO_TB_CTA_CONCEPTO_EGP

        Dim nodoConcepto As UltraTreeNode
        Dim nodoCuenta As UltraTreeNode

        Dim cuenta As String
        Dim concepto As Integer


        CtaConceptoBL.Limpiar_Tabla_Amarre(New BE.ContabilidadBE.SG_CO_TB_CTA_CONCEPTO_EGP With {.CC_IDEMPRESA = gInt_IdEmpresa})

        For Each nodoConcepto In ut_formatobg10.Nodes
            concepto = nodoConcepto.Key

            For Each nodoCuenta In nodoConcepto.Nodes
                cuenta = nodoCuenta.Key.Remove(0, 3)

                CtaConceptoBE = New BE.ContabilidadBE.SG_CO_TB_CTA_CONCEPTO_EGP
                CtaConceptoBE.CC_CONCEPTO = concepto
                CtaConceptoBE.CC_CUENTA = cuenta
                CtaConceptoBE.CC_IDEMPRESA = gInt_IdEmpresa
                CtaConceptoBL.Insert(CtaConceptoBE)
            Next
        Next
        Avisar("Listo!")
    End Sub

    Private Sub ut_formatobg10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ut_formatobg10.KeyDown
        If e.KeyCode = Keys.Delete Then
            ut_formatobg10.ActiveNode.Remove()
        End If
    End Sub
End Class