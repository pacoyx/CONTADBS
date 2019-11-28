Public Class CO_PR_DocPendientes

    Public Str_Cuenta As String
    Public Int_Anexo As Integer
    Public Bol_Aceptar As Boolean
    Dim lista As New List(Of Cls_DocPendientes)

    Public Function getListaDocs() As List(Of Cls_DocPendientes)
        getListaDocs = Nothing
        Try
            Return lista
        Catch ex As Exception
            getListaDocs = Nothing
        End Try
    End Function

    Private Sub CO_PR_DocPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Documentos()
        'Call Formatear_Grilla_Selector(ug_Documentos)
        ug_Documentos.Focus()

    End Sub

    Private Sub Cargar_Documentos()
        Try
            Dim ASientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim dt As DataTable = Nothing

            If Str_Cuenta = String.Empty Then
                dt = ASientoBL.getDoc_Pendientes_x_Anexo(Int_Anexo, gInt_IdEmpresa)
            Else
                dt = ASientoBL.getDoc_Pendientes(Str_Cuenta, Int_Anexo, gInt_IdEmpresa, gDat_Fecha_Sis.Year)
            End If

            Call LimpiaGrid(ug_Documentos, uds_Documentos)

            For i As Integer = 0 To dt.Rows.Count - 1
                ug_Documentos.DisplayLayout.Bands(0).AddNew()
                ug_Documentos.Rows(i).Cells("Sel").Value = False
                ug_Documentos.Rows(i).Cells("FEC_EMISION").Value = dt.Rows(i)("FEC_EMISION")
                ug_Documentos.Rows(i).Cells("DO_ABREVIATURA").Value = dt.Rows(i)("DO_DESCRIPCION")
                ug_Documentos.Rows(i).Cells("AD_SDOC").Value = dt.Rows(i)("AD_SDOC")
                ug_Documentos.Rows(i).Cells("AD_NDOC").Value = dt.Rows(i)("AD_NDOC")
                ug_Documentos.Rows(i).Cells("DEBE").Value = dt.Rows(i)("DEBE")
                ug_Documentos.Rows(i).Cells("HABER").Value = dt.Rows(i)("HABER")
                ug_Documentos.Rows(i).Cells("TOTAL_DEUDA").Value = dt.Rows(i)("TOTAL_DEUDA")
                ug_Documentos.Rows(i).Cells("ID_MIN").Value = dt.Rows(i)("ID_MIN")
                ug_Documentos.Rows(i).Cells("ID_MAX").Value = dt.Rows(i)("ID_MAX")

                ug_Documentos.UpdateData()
            Next
            ulbl_cantidad.Text = "Número de Registros : " & ug_Documentos.Rows.Count.ToString





            If ug_Documentos.Rows.Count > 0 Then ug_Documentos.Rows(0).Activate()

        Catch ex As Exception
        End Try
    End Sub

    

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        Try
            If ug_Documentos.Rows.Count = 0 Then
                Bol_Aceptar = False
                Me.Close()
            End If

            Dim Lista_Doc As Cls_DocPendientes

            If Varios() Then
                For i As Integer = 0 To ug_Documentos.Rows.Count - 1
                    If ug_Documentos.Rows(i).Cells("Sel").Value Then
                        Lista_Doc = New Cls_DocPendientes

                        Lista_Doc.fecha = IIf(ug_Documentos.Rows(i).Cells("FEC_EMISION").Value.ToString = "", String.Empty, ug_Documentos.Rows(i).Cells("FEC_EMISION").Value)
                        Lista_Doc.tdoc = ug_Documentos.Rows(i).Cells("DO_ABREVIATURA").Value.ToString
                        Lista_Doc.sdoc = ug_Documentos.Rows(i).Cells("AD_SDOC").Value.ToString
                        Lista_Doc.ndoc = ug_Documentos.Rows(i).Cells("AD_NDOC").Value.ToString
                        Lista_Doc.debe = ug_Documentos.Rows(i).Cells("DEBE").Value
                        Lista_Doc.haber = ug_Documentos.Rows(i).Cells("HABER").Value
                        Lista_Doc.ID_MIN = ug_Documentos.Rows(i).Cells("ID_MIN").Value
                        Lista_Doc.ID_MAX = ug_Documentos.Rows(i).Cells("ID_MAX").Value

                        lista.Add(Lista_Doc)
                    End If
                Next
            Else
                If ug_Documentos.Rows.Count > 0 Then
                    Lista_Doc = New Cls_DocPendientes
                    lista.Clear()
                    Lista_Doc.fecha = IIf(ug_Documentos.ActiveRow.Cells("FEC_EMISION").Value.ToString = "", String.Empty, ug_Documentos.ActiveRow.Cells("FEC_EMISION").Value)
                    Lista_Doc.tdoc = ug_Documentos.ActiveRow.Cells("DO_ABREVIATURA").Value.ToString
                    Lista_Doc.sdoc = ug_Documentos.ActiveRow.Cells("AD_SDOC").Value.ToString
                    Lista_Doc.ndoc = ug_Documentos.ActiveRow.Cells("AD_NDOC").Value.ToString
                    Lista_Doc.debe = ug_Documentos.ActiveRow.Cells("DEBE").Value
                    Lista_Doc.haber = ug_Documentos.ActiveRow.Cells("HABER").Value
                    Lista_Doc.ID_MIN = ug_Documentos.ActiveRow.Cells("ID_MIN").Value
                    Lista_Doc.ID_MAX = ug_Documentos.ActiveRow.Cells("ID_MAX").Value
                    lista.Add(Lista_Doc)
                End If
                

            End If

            Bol_Aceptar = True
            Me.Close()


        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        lista.Clear()
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Function Varios() As Boolean
        Varios = False
        Try
            Dim Cont As Integer = 0
            For i As Integer = 0 To ug_Documentos.Rows.Count - 1
                If ug_Documentos.Rows(i).Cells("Sel").Value Then
                    Cont += 1
                End If
            Next

            If Cont > 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub ug_Documentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Documentos.KeyDown
        If e.KeyCode = Keys.Enter Then If ug_Documentos.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
        If e.KeyCode = Keys.Escape Then ubtn_Cancelar_Click(sender, e)
    End Sub

    Private Sub ug_Documentos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Documentos.DoubleClickRow
        Try
            If ug_Documentos.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
        Catch ex As Exception
        End Try
    End Sub
End Class