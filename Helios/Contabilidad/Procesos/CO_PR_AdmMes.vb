Public Class CO_PR_AdmMes

    'Para este proceso de cerrar mes se tiene un campo en la BD
    'Donde se guarda un valor tipo entero, para indicar el estado del mes se usara estos vaores :
    '1= mes cerraado
    '0=mes abierto
    'NULL = mes abierto ó no establecido( que se toma como abierto)
    Dim Str_Pwd_Adm As String = "911"

    Private Sub CO_PR_AdmMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)

        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month


        Dim parametrosBL As New BL.ContabilidadBL.SG_CO_TB_PARAMETROSGENERALES
        Dim dt_p As DataTable = parametrosBL.getParametros()

        If dt_p.Rows.Count > 0 Then
            Str_Pwd_Adm = dt_p.Rows(0)("PG_CLAVE_CONTROL_MES").ToString
        End If

        dt_p = Nothing
        parametrosBL = Nothing



        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES

        Dim dt_periodos As DataTable = AdmMesBL.get_Periodos(gInt_IdEmpresa)

        For i As Integer = 0 To dt_periodos.Rows.Count - 1
            ug_periodo.DisplayLayout.Bands(0).AddNew()
            ug_periodo.Rows(i).Cells("Periodo").Value = dt_periodos.Rows(i)("AP_ANHO")
            If dt_periodos.Rows(i)("AP_ESTADO") = 0 Then '0=abierto;  1=cerrado
                ug_periodo.Rows(i).Cells("Estado").Value = "ABIERTO"
            Else
                ug_periodo.Rows(i).Cells("Estado").Value = "CERRADO"
            End If
        Next

        dt_periodos.Dispose()
        AdmMesBL = Nothing

        ug_periodo.UpdateData()


        ugb_periodo.Enabled = False
        ugb_Parametros.Enabled = False

    End Sub

    Private Sub Tool_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cerrar.Click
        Try

            

            Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
            Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

            With AdmMesBE
                .AM_ANHO = une_Ayo.Value
                .AM_MES = uce_Mes.Value
                .AM_ESTADO = 1
                .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AM_TERMINAL = Environment.MachineName
                .AM_FECREG = Now.Date
            End With

            If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
                Avisar("El mes esta cerrado." & Chr(13) & "Tiene que abrirlo antes.")
                AdmMesBL = Nothing
                AdmMesBE = Nothing
                Exit Sub
            End If

            AdmMesBL.Delete(AdmMesBE)
            AdmMesBL.Insert(AdmMesBE)

            Avisar("Listo!")
            AdmMesBL = Nothing
            AdmMesBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Abrir.Click
        Try
            If Not txt_pwd.Text.Trim.Equals(Str_Pwd_Adm) Then
                Avisar("La clave de permiso para esta operacion es incorrecta.")
                txt_pwd.Focus()
                Exit Sub
            End If

            Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
            Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

            With AdmMesBE
                .AM_ANHO = une_Ayo.Value
                .AM_MES = uce_Mes.Value
                .AM_ESTADO = 0
                .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AM_TERMINAL = Environment.MachineName
                .AM_FECREG = Now.Date
            End With

            If Not AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
                Avisar("El mes esta abierto.")
                AdmMesBL = Nothing
                AdmMesBE = Nothing
                Exit Sub
            End If

            AdmMesBL.Delete(AdmMesBE)
            AdmMesBL.Insert(AdmMesBE)

            Avisar("Listo!")

            AdmMesBL = Nothing
            AdmMesBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

   

    Private Sub une_Ayo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Ayo.KeyDown, uce_Mes.KeyDown, txt_pwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_pwd.Text.Trim = "" Then
                Call Avisar("Ingresar la palabra clave para continuar")
                Exit Sub
            End If

            If Not txt_pwd.Text.Trim.Equals(Str_Pwd_Adm) Then
                Avisar("La clave de permiso para esta operacion es incorrecta.")
                txt_pwd.Focus()
                Exit Sub
            End If

            ugb_periodo.Enabled = True
            ugb_Parametros.Enabled = True

        End If
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Try

            Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
            Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

            With AdmMesBE
                .AM_ANHO = une_Ayo.Value
                .AM_MES = uce_Mes.Value
                .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
                txt_estado.Text = "Cerrado"
            Else
                txt_estado.Text = "Abrierto"
            End If

            AdmMesBL = Nothing
            AdmMesBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Me.Close()
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click

        If une_periodo.Value < 2012 Then Exit Sub

        For i As Integer = 0 To ug_periodo.Rows.Count - 1
            If ug_periodo.Rows(i).Cells("Periodo").Value = une_periodo.Value Then
                Avisar("El periodo ya esta registrado en el sistema")
                une_periodo.Focus()
                Exit Sub
            End If
        Next



        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        AdmMesBL.set_Periodos(une_periodo.Value, gInt_IdEmpresa, Environment.UserName, Environment.MachineName, Now.Date.ToShortDateString)
        AdmMesBL = Nothing

        ug_periodo.DisplayLayout.Bands(0).AddNew()
        ug_periodo.Rows(ug_periodo.Rows.Count - 1).Cells("Periodo").Value = une_periodo.Value
        ug_periodo.Rows(ug_periodo.Rows.Count - 1).Cells("Estado").Value = "ABIERTO"
        ug_periodo.UpdateData()


    End Sub

    Private Sub Tool_Abrir_Periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Abrir_Periodo.Click
        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        AdmMesBL.Actualizar_Periodo(ug_periodo.ActiveRow.Cells("Periodo").Value, 0, gInt_IdEmpresa)
        ug_periodo.ActiveRow.Cells("Estado").Value = "ABIERTO"
        ug_periodo.UpdateData()
        AdmMesBL = Nothing
    End Sub

    Private Sub Tool_CerrarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_CerrarPeriodo.Click
        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        AdmMesBL.Actualizar_Periodo(ug_periodo.ActiveRow.Cells("Periodo").Value, 1, gInt_IdEmpresa)
        ug_periodo.ActiveRow.Cells("Estado").Value = "CERRADO"
        ug_periodo.UpdateData()
        AdmMesBL = Nothing
    End Sub

    Private Sub ug_periodo_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_periodo.AfterRowsDeleted
        ug_periodo.UpdateData()
    End Sub

    Private Sub ug_periodo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_periodo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        AdmMesBL.Eliminar_Periodo(ug_periodo.ActiveRow.Cells("Periodo").Value, 1, gInt_IdEmpresa)
        AdmMesBL = Nothing
    End Sub

    Private Sub txt_pwd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pwd.ValueChanged

    End Sub
End Class