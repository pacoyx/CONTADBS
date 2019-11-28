Imports System
Imports System.Drawing.Printing

Public Class CO_MT_Impresoras

    Private Sub CO_MT_Impresoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pd As New PrintDocument
        Dim Impresoras As String

        ' Default printer      
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas  
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ListBox1.Items.Add(Impresoras.ToString)
        Next
        ' selecciona la impresora predeterminada  
        ListBox1.Text = s_Default_Printer
    End Sub

    Private Function SetDefPrinter(ByVal sNombreImpresora As String) As Boolean
        'Parámetro especifica nombre de impresora para poner por defecto.
        'La pongo por defecto y la quito.

        Dim WshNetwork As Object
        Dim pd As New PrintDocument

        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

        Try
            WshNetwork.SetDefaultPrinter(sNombreImpresora)
            pd.PrinterSettings.PrinterName = sNombreImpresora
            If pd.PrinterSettings.IsValid Then
                Return True
            Else
                WshNetwork.SetDefaultPrinter(sNombreImpresora)
                Return False
            End If
        Catch exptd As Exception
            'WshNetwork.SetDefaultPrinter(sNombreImpresora)
            Return False
        Finally
            WshNetwork = Nothing
            pd = Nothing
        End Try
    End Function

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
            ubtn_Aceptar_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            SetDefPrinter(ListBox1.SelectedItem)
            Me.Cursor = Cursors.Default
            Avisar("Listo!" & Chr(13) & "La Impresora fue cambiada.")
            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class