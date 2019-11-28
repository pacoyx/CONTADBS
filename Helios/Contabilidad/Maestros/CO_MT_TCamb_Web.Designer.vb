<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_TCamb_Web
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
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Me.wb_tc = New System.Windows.Forms.WebBrowser
        Me.uce_Direccion = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.usb_Web = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar
        CType(Me.uce_Direccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wb_tc
        '
        Me.wb_tc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wb_tc.Location = New System.Drawing.Point(12, 39)
        Me.wb_tc.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_tc.Name = "wb_tc"
        Me.wb_tc.Size = New System.Drawing.Size(803, 419)
        Me.wb_tc.TabIndex = 1
        '
        'uce_Direccion
        '
        Me.uce_Direccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uce_Direccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Direccion.Location = New System.Drawing.Point(12, 12)
        Me.uce_Direccion.Name = "uce_Direccion"
        Me.uce_Direccion.Size = New System.Drawing.Size(804, 21)
        Me.uce_Direccion.TabIndex = 2
        '
        'usb_Web
        '
        Me.usb_Web.Location = New System.Drawing.Point(0, 464)
        Me.usb_Web.Name = "usb_Web"
        UltraStatusPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        UltraStatusPanel1.Key = "Barra"
        UltraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Progress
        UltraStatusPanel1.Width = 200
        Me.usb_Web.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1})
        Me.usb_Web.Size = New System.Drawing.Size(827, 23)
        Me.usb_Web.TabIndex = 3
        Me.usb_Web.Text = "UltraStatusBar1"
        Me.usb_Web.ViewStyle = Infragistics.Win.UltraWinStatusBar.ViewStyle.Office2007
        '
        'CO_MT_TCamb_Web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(827, 487)
        Me.Controls.Add(Me.usb_Web)
        Me.Controls.Add(Me.uce_Direccion)
        Me.Controls.Add(Me.wb_tc)
        Me.Name = "CO_MT_TCamb_Web"
        Me.Text = "Pagina Web Tipo Cambio Referencial"
        CType(Me.uce_Direccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wb_tc As System.Windows.Forms.WebBrowser
    Friend WithEvents uce_Direccion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents usb_Web As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
End Class
