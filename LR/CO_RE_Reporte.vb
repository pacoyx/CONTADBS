Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class CO_RE_Reporte
    Public var_Titulo As String

    Private Sub CO_RE_Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub CRVisor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CRVisor.Click

    End Sub

    Private Sub CRVisor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVisor.Load

    End Sub
End Class