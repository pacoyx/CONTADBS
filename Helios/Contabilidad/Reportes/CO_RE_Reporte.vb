Public Class CO_RE_Reporte

    Private Sub CO_RE_Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '********** Asigna iconoal fromulario ****************'

        Me.Text = Titulo
    End Sub
    Public Property Titulo() As String
        Get
            Return var_Titulo
        End Get
        Set(ByVal Value As String)
            var_Titulo = Value
        End Set
    End Property
End Class