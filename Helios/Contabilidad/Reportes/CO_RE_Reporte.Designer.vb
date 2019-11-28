<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RE_Reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_RE_Reporte))
        Me.CRVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRVisor
        '
        Me.CRVisor.ActiveViewIndex = -1
        Me.CRVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVisor.Location = New System.Drawing.Point(0, 0)
        Me.CRVisor.Name = "CRVisor"
        Me.CRVisor.SelectionFormula = ""
        Me.CRVisor.Size = New System.Drawing.Size(292, 266)
        Me.CRVisor.TabIndex = 0
        Me.CRVisor.ViewTimeSelectionFormula = ""
        '
        'CO_RE_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.CRVisor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CO_RE_Reporte"
        Me.Text = "CO_RE_Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
