Public Class CO_LG_IniciarRegEdit
    Const cnstKey As String = "TUPAPI"
    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        Try

            If txt_servidor.Text.Trim.Length = 0 Then
                Avisar("Ingrese el nombre del servidor")
                txt_servidor.Focus()
                Exit Sub
            End If

            If txt_Base.Text.Trim.Length = 0 Then
                Avisar("Ingrese el nombre de la Base de Datos")
                txt_Base.Focus()
                Exit Sub
            End If

            If txt_Usuario.Text.Trim.Length = 0 Then
                Avisar("Ingrese el nombre del Usuario de Conexion.")
                txt_Usuario.Focus()
                Exit Sub
            End If

            If txt_Clave.Text.Trim.Length = 0 Then
                Avisar("Ingrese la clave del Usuario de Conexion.")
                txt_Clave.Focus()
                Exit Sub
            End If

            If txt_Reportes.Text.Trim.Length = 0 Then
                Avisar("Ingrese la ruta de los reportes.")
                txt_Reportes.Focus()
                Exit Sub
            End If

            If uce_Estilos.SelectedIndex = -1 Then
                Avisar("Seleccione un estilo  por favor")
                uce_Estilos.Focus()
                Exit Sub
            End If

            Dim clave_encriptada As String = EncryptString(txt_Clave.Text.Trim)


            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Servidor", txt_servidor.Text.Trim)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Base", txt_Base.Text.Trim)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Usuario", txt_Usuario.Text.Trim)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Clave", clave_encriptada)

            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Reportes", txt_Reportes.Text.Trim)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Infra", uce_Estilos.Text.Trim)


            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Function EncryptString(ByRef Text As String) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        n = Len(cnstKey)
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid(cnstKey, i, 1))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To Len(Text)
            TextASCIIS(i) = Asc(Mid(Text, i, 1))
        Next

        For i = 1 To Len(Text)
            j = IIf(j + 1 >= n, 1, j + 1)
            Temp = TextASCIIS(i) + UserKeyASCIIS(j)
            If Temp > 255 Then
                Temp = Temp - 255
            End If
            rtn = rtn & Chr(Temp)
        Next
        EncryptString = rtn
    End Function

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        End
    End Sub

    Private Sub CO_LG_IniciarRegEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Estilos()
    End Sub
    Private Sub Cargar_Estilos()
        Try
            Dim Ruta As String = My.Application.Info.DirectoryPath
            'lvwEstilos.Items.Add(0, "Predeterminado")
            Dim I As Integer = 1
            Ruta = String.Format("{0}\StyleLibraries\", Ruta)
            For Each Archivo As String In My.Computer.FileSystem.GetFiles(Ruta, FileIO.SearchOption.SearchAllSubDirectories, "*.isl")
                uce_Estilos.Items.Add(Archivo.Substring(Ruta.Length).Trim())
                I += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_servidor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_servidor.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Base_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Base.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Usuario.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Clave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Clave.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Reportes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Reportes.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Estilos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Estilos.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Reportes_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Reportes.EditorButtonClick
        FolderBrowserDialog1.ShowDialog()
        txt_Reportes.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class