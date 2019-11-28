Imports Infragistics.Win

Public Class CO_MT_Buscar

    Public Int_Opcion As Integer = 0
    Public Int_TipoAnexo As Integer = 0

    Dim Dv_data As DataView
    Dim lista As New List(Of String)

    Public Function GetLista() As List(Of String)
        Return lista
    End Function

    Private Sub CO_MT_Buscar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub CO_MT_Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case Int_Opcion
                Case 0
                Case 1
                    Call Cargar_Proveedores()
                Case 2
                    Call Cargar_Clientes()
                Case 3
                    Call Cargar_Honorarios()
                Case 4
                    Call Cargar_Anexos(Int_TipoAnexo)
            End Select


            Call Formatear_Grilla_Selector(ug_data)
            txt_filtro.Clear()

        Catch ex As Exception

        End Try
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

            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim E_Anexos As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            E_Anexos.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
            E_Anexos.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Dv_data = AnexoBL.getAnexos_DT(E_Anexos).DefaultView
            ug_data.DataSource = Nothing
            ug_data.DataSource = Dv_data
            ug_data.Refresh()

            ug_data.DisplayLayout.Bands(0).Columns(1).Hidden = True
            ug_data.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
            ug_data.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Ruc"
            ug_data.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Razon Social"

            uce_campos.Items.Clear()
            uce_campos.Items.Add(0, "Codigo").Appearance.Image = My.Resources._16__Envelope_
            uce_campos.Items.Add(2, "Ruc").Appearance.Image = My.Resources._16__Idcard_
            uce_campos.Items.Add(3, "Razon Social").Appearance.Image = My.Resources._16__Credit_card_

            uce_campos.Value = 3

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cargar_Proveedores()
        Try
            Me.Text = "Lista de Proveedores"

            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim E_Anexos As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            E_Anexos.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Proveedor}
            E_Anexos.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Dv_data = AnexoBL.getAnexos_DT(E_Anexos).DefaultView
            ug_data.DataSource = Nothing
            ug_data.DataSource = Dv_data
            ug_data.Refresh()

            ug_data.DisplayLayout.Bands(0).Columns(1).Hidden = True
            ug_data.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
            ug_data.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Ruc"
            ug_data.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Razon Social"

            uce_campos.Items.Clear()
            uce_campos.Items.Add(1, "Codigo").Appearance.Image = My.Resources._16__Envelope_
            uce_campos.Items.Add(2, "Ruc").Appearance.Image = My.Resources._16__Idcard_
            uce_campos.Items.Add(3, "Razon Social").Appearance.Image = My.Resources._16__Credit_card_

            uce_campos.Value = 3

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Cargar_Anexos(ByVal Int_TipoAnexo As Integer)
        Try
            Dim titulo As String = ""
            Select Case Int_TipoAnexo
                Case 1
                    titulo = "Clientes"
                Case 2
                    titulo = "Proveedores"
                Case 3
                    titulo = "Personal"
                Case 4
                    titulo = "Honorarios"
                Case 5
                    titulo = "Terceros"
                Case 6
                    titulo = "Varios"
                Case 7
                    titulo = "Accionistas"
            End Select

            Me.Text = "Lista de " & titulo

            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim E_Anexos As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            E_Anexos.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo}
            E_Anexos.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Dv_data = AnexoBL.getAnexos_DT(E_Anexos).DefaultView
            ug_data.DataSource = Nothing
            ug_data.DataSource = Dv_data
            ug_data.Refresh()

            ug_data.DisplayLayout.Bands(0).Columns(1).Hidden = True
            ug_data.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
            ug_data.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Ruc"
            ug_data.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Razon Social"

            uce_campos.Items.Clear()
            uce_campos.Items.Add(1, "Codigo").Appearance.Image = My.Resources._16__Envelope_
            uce_campos.Items.Add(2, "Ruc").Appearance.Image = My.Resources._16__Idcard_
            uce_campos.Items.Add(3, "Razon Social").Appearance.Image = My.Resources._16__Credit_card_

            uce_campos.Value = 3

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cargar_Honorarios()
        Try
            Me.Text = "Lista de Honorarios"

            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim E_Anexos As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            E_Anexos.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Honorarios}
            E_Anexos.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Dv_data = AnexoBL.getAnexos_DT(E_Anexos).DefaultView
            ug_data.DataSource = Nothing
            ug_data.DataSource = Dv_data
            ug_data.Refresh()

            ug_data.DisplayLayout.Bands(0).Columns(1).Hidden = True
            ug_data.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
            ug_data.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Ruc"
            ug_data.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Razon Social"

            uce_campos.Items.Clear()
            uce_campos.Items.Add(1, "Codigo").Appearance.Image = My.Resources._16__Envelope_
            uce_campos.Items.Add(2, "Ruc").Appearance.Image = My.Resources._16__Idcard_
            uce_campos.Items.Add(3, "Razon Social").Appearance.Image = My.Resources._16__Credit_card_

            uce_campos.Value = 3

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txt_filtro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.ValueChanged
        Try

            Select Case uce_campos.Value

                Case 1
                    Dv_data.RowFilter = "AN_IDANEXO = " & txt_filtro.Text.Trim
                Case 2
                    Dv_data.RowFilter = "AN_NUM_DOC like'%" & txt_filtro.Text.Trim & "%'"
                Case 3
                    Dv_data.RowFilter = "AN_DESCRIPCION like'%" & txt_filtro.Text.Trim & "%'"

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
        If ug_data.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
    End Sub
End Class