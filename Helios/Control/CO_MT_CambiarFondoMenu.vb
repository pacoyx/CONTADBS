Public Class CO_MT_CambiarFondoMenu
    Dim Int_IdUsu As Integer = 0

    Private Sub CO_MT_CambiarFondoMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj_ImgSisBL As New BL.ContabilidadBL.SG_CO_TB_IMG_SIS
        Dim Obj_UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Int_IdUsu = Obj_UsuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)
        Dim Dt As DataTable = obj_ImgSisBL.getImg_x_IdUsu(Int_IdUsu)

        If Dt.Rows.Count = 0 Then
            Dt = obj_ImgSisBL.getImg_x_Pc(Environment.MachineName)
            If Dt.Rows.Count > 0 Then
                upb_img.Image = Bytes2Image(Dt.Rows(0)("IS_IMG"))
            Else
                upb_img.Image = My.Resources.MSNwall
            End If
        End If

    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        Try

            Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_IMG_SIS
            Dim obj_ImgSisBL As New BL.ContabilidadBL.SG_CO_TB_IMG_SIS
            Dim Obj_UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            Dim Int_IdUsu As Integer = Obj_UsuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)

            Entidad.IS_IMG = Image2Bytes(upb_img.Image)
            Entidad.IS_PC = Environment.MachineName
            Entidad.IS_USUARIO = Int_IdUsu

            obj_ImgSisBL.Insert(Entidad)
            Call Avisar("    Listo!  ")
            CO_MN_MenuInicial.BackgroundImage = upb_img.Image

            obj_ImgSisBL = Nothing
            Entidad = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cambiar.Click
        Try
            ' Seleccionar la imagen
            Dim oFD As New OpenFileDialog
            oFD.Title = "Selecccionar la imagen"
            oFD.Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If oFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' La cantidad de caracteres máximo
                ' (por si el path es demasiado largo)
                Dim i As Integer = 255 'dt.Columns("Nombre").MaxLength
                If i < 0 Then i = 255
                ' El nombre del fichero
                ' Nos quedamos solo con el nombre, sin el path
                Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
                If sNombre.Length > i Then
                    ' Si el nombre es más grande de lo permitido, lo cortamos
                    sNombre = sNombre.Substring(0, i)
                End If

                'Me.txt_foto.Text = sNombre
                Me.upb_img.Image = Image.FromFile(oFD.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class