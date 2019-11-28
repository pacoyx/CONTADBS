Public Class CO_PR_CierreApertura

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub CO_PR_CierreApertura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        une_Ayo.ReadOnly = True
        une_Ayo.Value = gDat_Fecha_Sis.Year

    End Sub

    Private Sub Tool_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Procesar.Click

        If uos_tipo.Value = 1 Then 'Cierre
            CO_PR_Cierre_Tmp.ShowDialog()
        End If

        If uos_tipo.Value = 2 Then 'Apertura
            'aqui levantamos el formulario de apertura con el asiento de apertura temporal

            CO_PR_Apertura_Tmp.ShowDialog()
        End If

    End Sub
End Class