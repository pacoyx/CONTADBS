Public Class CO_PR_ActDetraccion

    Private Sub CO_PR_ActDetraccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month


    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
         Call Cargar_Datos()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Lista_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Lista.AfterRowUpdate
        Dim comprasBE As New BE.ContabilidadBE.SG_CO_TB_COMPRAS
        Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE

        comprasBE.CO_IDCAB = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB With {.AC_ID = e.Row.Cells("CO_IDCAB").Value}
        If e.Row.Cells("CO_TASA_DETRA").Value.ToString = "" Then
            comprasBE.CO_TASA_DETRA = 0
        Else
            comprasBE.CO_TASA_DETRA = e.Row.Cells("CO_TASA_DETRA").Value
        End If

        comprasBE.CO_NUMERO_DETRA = e.Row.Cells("CO_NUMERO_DETRA").Value.ToString
        If e.Row.Cells("CO_FEC_EMI_DETRA").Value.ToString = "" Then
            comprasBE.CO_FEC_EMI_DETRA = String.Empty
        Else
            comprasBE.CO_FEC_EMI_DETRA = CDate(e.Row.Cells("CO_FEC_EMI_DETRA").Value).ToShortDateString
        End If

        asientoBL.Actualizar_Datos_Detraccion(comprasBE)

        comprasBE = Nothing
        asientoBL = Nothing
    End Sub

    Private Sub ubtn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Actualizar.Click
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        ug_Lista.DataSource = asientoBL.get_Documentos_con_Detraccion(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)
        asientoBL = Nothing

        lbl_numreg.Text = "Numero de Registros : " & ug_Lista.Rows.Count
    End Sub
End Class