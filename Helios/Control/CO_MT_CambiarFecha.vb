Public Class CO_MT_CambiarFecha

    Private Sub CO_MT_CambiarFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MonthCalendar1.SetDate(gDat_Fecha_Sis)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click
        gDat_Fecha_Sis = MonthCalendar1.SelectionStart.ToShortDateString
        CO_MN_MenuInicial.usb_menu.Panels("usb_fecha").Text = String.Format("Fecha : {0}", gDat_Fecha_Sis.ToShortDateString)
        Avisar("La fecha ha sido Actualizada")
        Me.Close()

    End Sub
End Class