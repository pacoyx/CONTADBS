Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class ClsReporte
    Implements IDisposable


    Public Sub Muestra_Reporte(ByVal STRnombreReporte As String, _
     ByVal myDatos As DataTable, _
     ByVal STRfiltro As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New CO_RE_Reporte
            Dim myReporte As New ReportDocument

            'Cargo el reporte segun ruta
            myReporte.Load(STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            f.CRVisor.SelectionFormula = STRfiltro

            myReporte.SetDataSource(myDatos)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            f.CRVisor.ShowGroupTreeButton = True
            f.Show()

        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Function Genera_Parametros(ByVal ParamArray MyMatriz() As String) As ParameterFields
        Dim c As Long, STRnombre As String, STRvalor As String, l As Integer
        Dim parametros As New ParameterFields

        Try
            For c = 0 To MyMatriz.Length - 1
                l = InStr(MyMatriz(c), ";")
                If l > 0 Then
                    STRnombre = Mid(MyMatriz(c), 1, l - 1)
                    STRvalor = Mid(MyMatriz(c), l + 1, Len(MyMatriz(c)) - l)
                    Dim parametro As New ParameterField
                    Dim dVal As New ParameterDiscreteValue
                    parametro.ParameterFieldName = STRnombre
                    dVal.Value = STRvalor
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)
                End If
            Next
            Return (parametros)
        Catch ex As Exception
            Throw
        End Try

    End Function


    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar otro estado (objetos administrados).
            End If

            ' TODO: Liberar su propio estado (objetos no administrados).
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
