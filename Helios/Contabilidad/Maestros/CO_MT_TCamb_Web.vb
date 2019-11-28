Public Class CO_MT_TCamb_Web
    Public Str_Direccion_Defecto As String = "http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias"
    Private Sub CO_MT_TCamb_Web_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombos()
        Call CargarWeb()
        usb_Web.Panels("Barra").ProgressBarInfo.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
    End Sub

    Private Sub uce_Direccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Direccion.ValueChanged
        If uce_Direccion.Items.Count > 0 Then

            wb_tc.Navigate(uce_Direccion.Value)
        Else
            wb_tc.Navigate(Str_Direccion_Defecto)
        End If
    End Sub

    Private Sub CargarCombos()
        Try
            uce_Direccion.Items.Add("http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias", "Sunat")
            uce_Direccion.Items.Add("http://www.sbs.gob.pe/0/home.aspx", "SBS")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarWeb()
        Try
            If uce_Direccion.Items.Count > 0 Then
                uce_Direccion.SelectedIndex = 0
                wb_tc.Navigate(uce_Direccion.Value)
            Else
                wb_tc.Navigate(Str_Direccion_Defecto)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub wb_tc_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb_tc.DocumentCompleted
        ' uce_Direccion.Items.Add(e.Url.AbsoluteUri)
    End Sub

    Private Sub wb_tc_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles wb_tc.ProgressChanged

        usb_Web.Panels("Barra").ProgressBarInfo.Maximum = e.MaximumProgress
        usb_Web.Panels("Barra").ProgressBarInfo.Minimum = e.CurrentProgress

        If e.MaximumProgress <= 0 Then

        End If
    End Sub
End Class