Public Class TE_AR_Bancos

    Private Sub TE_AR_Bancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Lista_de_Bancos()
        Call MostrarTabs(0, utc_ListaBancos, 0)
        Call Formatear_Grilla_Selector(ug_listaBancos)
        Call Formatear_Grilla_Selector(ug_Cuentas)
    End Sub


    Private Sub Cargar_Lista_de_Bancos()

        Dim Obj_BancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO
        Dim Bancos As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO)
        Dim BancosBE As New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        Bancos = Obj_BancoBL.getBancos(BancosBE)

        Call LimpiaGrid(ug_listaBancos, uds_ListaBancos)

        Dim I As Integer = 0
        For Each banco As BE.ContabilidadBE.SG_CO_TB_BANCO In Bancos
            ug_listaBancos.DisplayLayout.Bands(0).AddNew()
            With ug_listaBancos.Rows(I)
                .Cells("BA_ID").Value = banco.BA_ID
                .Cells("BA_CODIGO").Value = banco.BA_CODIGO
                .Cells("BA_NOMBRE").Value = banco.BA_NOMBRE
                .Cells("BA_RUC").Value = banco.BA_RUC
            End With

            I += 1
        Next

        ug_listaBancos.UpdateData()

        Bancos = Nothing
        BancosBE = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_CtaCorrientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_CtaCorrientes.Click
        Call MostrarTabs(1, utc_ListaBancos, 1)
        Call Cargar_Cuentas_Corrientes(ug_listaBancos.ActiveRow.Cells("BA_ID").Value)
        lbl_NombreBancos.Text = "Banco: " & ug_listaBancos.ActiveRow.Cells("BA_NOMBRE").Value
    End Sub

    Private Sub Cargar_Cuentas_Corrientes(ByVal Int_IdBanco As Integer)

        Dim CtasCorrientesBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CTACTE
        Dim Bancos As New List(Of BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
        Bancos = CtasCorrientesBL.getCtasCorrientes(New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE With {.BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = Int_IdBanco}})

        Call LimpiaGrid(ug_Cuentas, uds_CtasCorri)

        Dim i As Integer = 0
        For Each banco As BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE In Bancos
            ug_Cuentas.DisplayLayout.Bands(0).AddNew()
            ug_Cuentas.Rows(i).Cells("BC_IDBANCO").Value = banco.BC_IDBANCO.BA_ID
            ug_Cuentas.Rows(i).Cells("BC_ID_CTA").Value = banco.BC_ID_CTA
            ug_Cuentas.Rows(i).Cells("BC_NUMERO_CTA").Value = banco.BC_NUMERO_CTA
            ug_Cuentas.Rows(i).Cells("BC_DESCRIPCION").Value = banco.BC_DESCRIPCION
            ug_Cuentas.Rows(i).Cells("BC_FECHA_APERTURA").Value = banco.BC_FECHA_APERTURA
            ug_Cuentas.Rows(i).Cells("BC_FORMATO_CHEQUE").Value = banco.BC_FORMATO_CHEQUE
            i += 1
        Next
        ug_Cuentas.UpdateData()

        CtasCorrientesBL = Nothing
        Bancos = Nothing


    End Sub

    Private Sub ubt_Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Regresar.Click
        Call MostrarTabs(0, utc_ListaBancos, 0)
    End Sub

    Private Sub ug_Cuentas_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Cuentas.DoubleClickRow

    End Sub

    Private Sub ug_listaBancos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_listaBancos.DoubleClickRow
        Tool_CtaCorrientes_Click(sender, e)
        ug_Cuentas.Focus()
    End Sub

    Private Sub ug_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Cuentas.KeyDown
        If e.KeyCode = Keys.Escape Then
            ubt_Regresar_Click(sender, e)
        End If
    End Sub
End Class