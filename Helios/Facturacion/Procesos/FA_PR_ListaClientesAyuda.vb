Public Class FA_PR_ListaClientesAyuda

    Public Int_Opcion As Integer = 0
    Public Int_TipoAnexo As Integer = 0

    Dim Dv_data As DataView
    Dim lista As New List(Of String)

    Public Function GetLista() As List(Of String)
        Return lista
    End Function

    Private Sub FA_PR_ListaAyuda_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub FA_PR_ListaAyuda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_

        Select Case Int_Opcion
            Case 1
                Call Cargar_Clientes()
        End Select

        Call Formatear_Grilla_Selector(ug_data)
        txt_filtro.Clear()


    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        lista.Clear()
        For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
            lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
        Next

        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        lista.Clear()
        Me.Close()
    End Sub

    Private Sub Cargar_Clientes()
        Try
            Me.Text = "Lista de Clientes"

            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE

            Dv_data = clienteBL.get_Clientes_Ayuda(gInt_IdEmpresa).DefaultView
            ug_data.DataSource = Nothing
            ug_data.DataSource = Dv_data
            ug_data.Refresh()

            ug_data.DisplayLayout.Bands(0).Columns(0).Hidden = True
            ug_data.DisplayLayout.Bands(0).Columns(3).Hidden = True
            ug_data.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Doc"
            ug_data.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Descripcion"


            uce_campos.Items.Clear()
            uce_campos.Items.Add(1, "Doc").Appearance.Image = My.Resources._16__Idcard_
            uce_campos.Items.Add(2, "Nombres").Appearance.Image = My.Resources._16__Credit_card_

            uce_campos.Value = 2


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txt_filtro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.ValueChanged
        Try

            Select Case uce_campos.Value

                Case 1
                    Dv_data.RowFilter = "CL_NDOC like '" & txt_filtro.Text.Trim & "%'"
                Case 2
                    Dv_data.RowFilter = "CL_NOMBRE like '%" & txt_filtro.Text.Trim & "%'"

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uce_campos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_campos.KeyDown
        If e.KeyCode = Keys.Enter Then txt_filtro.Focus()
    End Sub

    Private Sub txt_filtro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_filtro.KeyDown

        If e.KeyCode = Keys.Enter Then
            If ug_data.Rows.Count > 0 Then
                Call ubtn_Aceptar_Click(sender, e)
            End If
        End If


        If e.KeyCode = Keys.Down Then
            If ug_data.Rows.Count > 0 Then
                ug_data.Focus()
            End If
        End If


        If e.KeyCode = Keys.Escape Then
            ubtn_Cancelar_Click(sender, e)
        End If

    End Sub

    Private Sub ug_data_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_data.KeyDown
        Try
            If ug_data.Rows.Count > 0 Then
                If ug_data.ActiveRow.Index = 0 Then
                    If e.KeyCode = Keys.Up Then
                        txt_filtro.Focus()
                    End If
                End If

                If e.KeyCode = Keys.Enter Then
                    ubtn_Aceptar_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow
        If ug_data.ActiveRow.IsFilterRow Then Exit Sub
        If ug_data.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
    End Sub

    Private Sub Tool_Agregar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Agregar.Click

        FA_PR_IngClienteRapido.ShowDialog()
        If FA_PR_IngClienteRapido.bol_Grabo Then

            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

            clienteBE.CL_NDOC = FA_PR_IngClienteRapido.str_num_ruc
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteBL.get_Cliente_x_Ruc(clienteBE)

            lista.Clear()
            If clienteBE.HasRow Then
                lista.Add(clienteBE.CL_ID)
                lista.Add(clienteBE.CL_NDOC)
                lista.Add(clienteBE.CL_NOMBRE)
            End If

            clienteBE = Nothing
            clienteBL = Nothing

            Me.Close()
        End If

    End Sub
End Class