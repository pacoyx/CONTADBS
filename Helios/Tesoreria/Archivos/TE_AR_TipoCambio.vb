Public Class TE_AR_TipoCambio

    Dim Dt_tc As DataTable
    Const Int_Moneda As Integer = 2

    Private Sub TE_AR_TipoCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo()
        Call Cargar_TipoCambio()
        Call Formatear_Grilla_Selector(ug_ListaTc)
    End Sub


    Private Sub Cargar_TipoCambio()

        Dim dv As DataView

        Dim Obj_TipCamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO

        Dim E_TC As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
        E_TC.TC_FECHA = "01/" & (uce_Mes.Value).ToString.PadLeft("2", "0") & "/" & gDat_Fecha_Sis.Year.ToString
        E_TC.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_TC.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}

        Dt_tc = Obj_TipCamBL.getTipoCambios_Dt(E_TC)
        GetTheTable(E_TC.TC_FECHA)

        dv = New DataView(Dt_tc)
        dv.Sort = "Fecha"
        ug_ListaTc.DataSource = dv




    End Sub

    Private Sub GetTheTable(ByVal varFecha As String)

        Dim nCols As Integer = 4
        'Dim nRows As Integer = DateTime.DaysInMonth(Year(STRfecha), Month(STRfecha))
        Dim nRows As Integer = DateTime.DaysInMonth(Year(varFecha), Month(varFecha))
        Dim i As Integer, INTdia As Integer

        INTdia = 1
        Dt_tc.Columns("Fecha").ReadOnly = True
        'Dt_tc.Columns("Moneda").ReadOnly = True


        For i = 0 To nRows
            Dim x As Integer = Dt_tc.Rows.Count
            Dim j As Integer
            Dim b As String = String.Format(Format(INTdia, "00") & "/" & Format(uce_Mes.SelectedIndex + 1, "00") & "/" & Format(gDat_Fecha_Sis.Year), i, j)
            Dim row() As DataRow = Dt_tc.Select("Fecha = '" & b & "'")

            If row.Length = 0 Then
                Dim dr As DataRow = Dt_tc.NewRow()
                dr(0) = b
                dr(1) = 0
                dr(2) = 0

                Dt_tc.Rows.Add(dr)
            End If
            INTdia += 1
            If nRows < INTdia Then
                Exit For
            End If
        Next
        'DTs.Tables("TipoCambio").AcceptChanges()
    End Sub

    Private Sub CargarCombo()

        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Items.Add(1, "Enero")
        uce_Mes.Items.Add(2, "Febrero")
        uce_Mes.Items.Add(3, "Marzo")
        uce_Mes.Items.Add(4, "Abril")
        uce_Mes.Items.Add(5, "Mayo")
        uce_Mes.Items.Add(6, "Junio")
        uce_Mes.Items.Add(7, "Julio")
        uce_Mes.Items.Add(8, "Agosto")
        uce_Mes.Items.Add(9, "Septiembre")
        uce_Mes.Items.Add(10, "Octubre")
        uce_Mes.Items.Add(11, "Noviembre")
        uce_Mes.Items.Add(12, "Diciembre")

        uce_Mes.Value = gDat_Fecha_Sis.Month

    End Sub

    Private Sub tool_Web_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_Web.Click
        CO_MT_TCamb_Web.Show()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_TipoCambio()
    End Sub
End Class