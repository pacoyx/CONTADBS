Public Class CO_MT_TCamb_Copy

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccine un mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        If uce_Empresas.SelectedIndex = -1 Then
            Avisar("Seleccione una empresa")
            uce_Empresas.Focus()
            Exit Sub
        End If


        Try
            Dim Obj_TcambBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim E_TCs As New List(Of BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO)
            Dim E_TC As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            E_TC.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = uce_Empresas.Value}
            E_TC.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            E_TC.TC_FECHA = String.Format("01/{0}/{1}", uce_Mes.Value, une_Ayo.Value)
            E_TC.TC_TERMINAL = Environment.MachineName
            E_TC.TC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            E_TC.TC_FECREG = Date.Now

            E_TCs = Obj_TcambBL.getTipoCambios(E_TC, gInt_IdEmpresa)

            Obj_TcambBL.Insert(E_TCs, IIf(uos_OpcGrabar.Value = 1, True, False))

            Avisar("   Listo!  ")
            Dim int_indice As Integer = CO_MT_TipoCambio.uce_Mes.SelectedIndex
            CO_MT_TipoCambio.uce_Mes.SelectedIndex = 0
            CO_MT_TipoCambio.uce_Mes.SelectedIndex = int_indice



        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CO_MT_TCamb_Copy_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        uce_Empresas.Focus()
    End Sub

    Private Sub CO_MT_TCamb_Copy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarEmpresaActual()
        Call CargarEmpresas()
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub cargarEmpresaActual()
        Try
            Dim Obj_EmpBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Obj_EmpBL.getEmpresas_2(E_Empresa)

            txt_Emp_Actual.Text = E_Empresa.EM_NOMBRE
            E_Empresa = Nothing
            Obj_EmpBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CargarEmpresas()
        Try

            Dim obj_EmpBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim Empresas As New List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)

            Empresas = obj_EmpBL.getEmpresas_1()
            uce_Empresas.DataSource = Empresas
            uce_Empresas.DisplayMember = "EM_NOMBRE"
            uce_Empresas.ValueMember = "EM_ID"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub uce_Empresas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Empresas.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub une_Ayo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Ayo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_Mes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Mes.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uos_OpcGrabar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uos_OpcGrabar.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_Empresas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Empresas.ValueChanged
        If uce_Empresas.Value = gInt_IdEmpresa Then
            Avisar("La empresa no puede ser la misma en donde esta trabajando")
            uce_Empresas.SelectedIndex = -1
            Exit Sub
        End If
    End Sub



End Class