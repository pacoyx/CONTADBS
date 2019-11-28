Public Class FA_PR_Caja_Ape

    Private Sub FA_PR_Caja_Ape_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ume_fecha.Value = gDat_Fecha_Sis
        txt_cod_cajero.Text = gInt_IdUsuario_Sis
        txt_des_cajero.Text = gStr_Usuario_Sis
        ume_soles.Value = 0
        ume_dolares.Value = 0
        Call Cargar_Turnos()
    End Sub

    Private Sub Cargar_Turnos()
        Dim turnoBL As New BL.FacturacionBL.SG_FA_TB_TURNO
        Dim turnoBE As New BE.FacturacionBE.SG_FA_TB_TURNO
        turnoBE.TU_IDEMPRESA = gInt_IdEmpresa
        uce_turno.DataSource = turnoBL.get_Turnos(turnoBE)
        uce_turno.DisplayMember = "TU_DESCRIPCION"
        uce_turno.ValueMember = "TU_ID"
        turnoBE = Nothing
        turnoBL = Nothing
    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If uce_turno.SelectedIndex = -1 Then
            Call Avisar("Seleccione un turno")
            uce_turno.Focus()
            Exit Sub
        End If

        If ume_fecha.Value.ToString = "" Then
            Call Avisar("Ingrese la fecha")
            ume_fecha.Focus()
            Exit Sub
        End If

        If ume_soles.Value.ToString = "" Then ume_soles.Value = 0
        If ume_dolares.Value.ToString = "" Then ume_dolares.Value = 0



        'validar que no exista una caja abierta con el mismo cajero,fecha y turno


        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim dt_data As DataTable = cajaBL.get_Data_Caja(txt_cod_cajero.Text, CDate(ume_fecha.Value).ToShortDateString, gInt_IdEmpresa)

        If dt_data.Rows.Count > 0 Then
            Call Avisar("Ya existe una caja aperturada en esta fecha.")
            dt_data.Dispose()
            cajaBL = Nothing
            Exit Sub
        End If
        dt_data.Dispose()



        Dim cajaBE As New BE.FacturacionBE.SG_FA_TB_CAJA_CAB

        With cajaBE
            .CA_ID = 0
            .CA_APE_SOL = ume_soles.Value
            .CA_APE_DOL = ume_dolares.Value
            .CA_CIE_SOL = 0
            .CA_CIE_DOL = 0
            .CA_IDUSUARIO = txt_cod_cajero.Text
            .CA_IDTURNO = uce_turno.Value
            .CA_FECHA = ume_fecha.Value
            .CA_ESTADO = 0
            .CA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CA_TERMINAL = Environment.MachineName
            .CA_FECREG = Date.Now
            .CA_IDEMPRESA = gInt_IdEmpresa
        End With

        cajaBL.Insert(cajaBE)
        txt_idcaja.Text = cajaBE.CA_ID.ToString.PadLeft(5, "0")

        Call Avisar("Listo!")


    End Sub
End Class