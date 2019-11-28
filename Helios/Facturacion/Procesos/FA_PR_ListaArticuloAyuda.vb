Public Class FA_PR_ListaArticuloAyuda

    Public Int_Opcion As Integer = 0
    Public Int_TipoAnexo As Integer = 0

    Dim lista As New List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO)

    Public Function GetLista() As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO)
        Return lista
    End Function

    Private Sub FA_PR_ListaArticuloAyuda_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Focus_Filtro()
    End Sub

    Private Sub FA_PR_ListaArticuloAyuda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Select Case Int_Opcion
            Case 1
                Call Cargar_Articulos()
        End Select

    End Sub

    Private Sub Focus_Filtro()
        If ug_data.Rows.Count = 0 Then Exit Sub
        ug_data.Rows(0).Activate()
        ug_data.Rows.FilterRow.Cells("AR_CODIGO").Activate()
        ug_data.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub Cargar_Articulos()

        Me.Text = "Lista de Articulos"

        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

        ug_data.DataSource = articuloBL.get_Articulos_Ayuda(gInt_IdEmpresa)


        ug_data.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Sel."
        ug_data.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Codigo"
        ug_data.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Descripcion"
        ug_data.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Precio"


        'ug_data.DisplayLayout.Bands(0).Columns(0).Width = 30
        'ug_data.DisplayLayout.Bands(0).Columns(1).Width = 50
        'ug_data.DisplayLayout.Bands(0).Columns(2).Width = 100
        'ug_data.DisplayLayout.Bands(0).Columns(3).Width = 50

        'ug_data.DisplayLayout.Bands(0).Columns(0).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        'ug_data.DisplayLayout.Bands(0).Columns(3).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double
        'ug_data.DisplayLayout.Bands(0).Columns(3).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right


        'ug_data.DisplayLayout.Bands(0).Columns("sel").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
        'ug_data.DisplayLayout.Bands(0).Columns("AR_CODIGO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        'ug_data.DisplayLayout.Bands(0).Columns("AR_DESCRIPCION").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        'ug_data.DisplayLayout.Bands(0).Columns("AR_PRECIO_VENTA").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

        articuloBL = Nothing


    End Sub

    Private Sub ug_data_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_data.KeyDown

        lista.Clear()
        ug_data.UpdateData()

        If ug_data.Rows.Count > 0 Then

            If e.KeyCode = Keys.Down And ug_data.ActiveRow.IsFilterRow Then
                ug_data.Rows(0).Activate()
            End If

            If e.KeyCode = Keys.Enter Then

                If ug_data.ActiveRow.IsFilterRow Then Exit Sub

                Dim articuloBE As BE.FacturacionBE.SG_FA_TB_ARTICULO
                articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

                articuloBE.AR_CODIGO = ug_data.ActiveRow.Cells("AR_CODIGO").Value
                articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
                articuloBE.AR_PRECIO_VENTA = ug_data.ActiveRow.Cells("AR_PRECIO_VENTA").Value
                articuloBE.AR_INCLUYE_IGV = ug_data.ActiveRow.Cells("AR_INCLUYE_IGV").Value
                articuloBE.AR_ES_NO_AFEC_IGV = ug_data.ActiveRow.Cells("AR_ES_NO_AFEC_IGV").Value

                lista.Add(articuloBE)

                Me.Close()
            End If
        End If

    End Sub

    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow

        If ug_data.ActiveRow.IsFilterRow Then Exit Sub

        lista.Clear()
        ug_data.UpdateData()

        If ug_data.Rows.Count > 0 Then

            Dim articuloBE As BE.FacturacionBE.SG_FA_TB_ARTICULO
            articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

            articuloBE.AR_CODIGO = ug_data.ActiveRow.Cells("AR_CODIGO").Value
            articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
            articuloBE.AR_PRECIO_VENTA = ug_data.ActiveRow.Cells("AR_PRECIO_VENTA").Value
            articuloBE.AR_INCLUYE_IGV = ug_data.ActiveRow.Cells("AR_INCLUYE_IGV").Value
            articuloBE.AR_ES_NO_AFEC_IGV = ug_data.ActiveRow.Cells("AR_ES_NO_AFEC_IGV").Value
            lista.Add(articuloBE)

            Me.Close()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()
        ug_data.UpdateData()

        Dim articuloBE As BE.FacturacionBE.SG_FA_TB_ARTICULO

        For f As Integer = 0 To ug_data.Rows.Count - 1


            If ug_data.Rows(f).Cells("Sel").Value Then

                articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

                articuloBE.AR_CODIGO = ug_data.Rows(f).Cells("AR_CODIGO").Value
                articuloBE.AR_DESCRIPCION = ug_data.Rows(f).Cells("AR_DESCRIPCION").Value
                articuloBE.AR_PRECIO_VENTA = ug_data.Rows(f).Cells("AR_PRECIO_VENTA").Value
                articuloBE.AR_INCLUYE_IGV = ug_data.Rows(f).Cells("AR_INCLUYE_IGV").Value
                articuloBE.AR_ES_NO_AFEC_IGV = ug_data.Rows(f).Cells("AR_ES_NO_AFEC_IGV").Value

                lista.Add(articuloBE)
            End If
        Next

        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        lista.Clear()
        Me.Close()
    End Sub

    
End Class