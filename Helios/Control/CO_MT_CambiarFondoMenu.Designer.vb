<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_CambiarFondoMenu
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
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_MT_CambiarFondoMenu))
        Me.ubtn_Cambiar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.upb_img = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.SuspendLayout()
        '
        'ubtn_Cambiar
        '
        Appearance20.Image = Global.Contabilidad.My.Resources.Resources._104
        Appearance20.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance20.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubtn_Cambiar.Appearance = Appearance20
        Me.ubtn_Cambiar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.ubtn_Cambiar.Location = New System.Drawing.Point(259, 212)
        Me.ubtn_Cambiar.Name = "ubtn_Cambiar"
        Me.ubtn_Cambiar.Size = New System.Drawing.Size(110, 31)
        Me.ubtn_Cambiar.TabIndex = 6
        Me.ubtn_Cambiar.Text = "&Buscar Imagen"
        '
        'ubtn_Aceptar
        '
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.ubtn_Aceptar.Appearance = Appearance1
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(12, 212)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(89, 29)
        Me.ubtn_Aceptar.TabIndex = 10
        Me.ubtn_Aceptar.Text = "&Guardar"
        '
        'ubtn_Cancelar
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.ubtn_Cancelar.Appearance = Appearance2
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(107, 212)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(83, 29)
        Me.ubtn_Cancelar.TabIndex = 11
        Me.ubtn_Cancelar.Text = "&Salir"
        '
        'upb_img
        '
        Me.upb_img.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_img.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.upb_img.Image = CType(resources.GetObject("upb_img.Image"), Object)
        Me.upb_img.Location = New System.Drawing.Point(12, 27)
        Me.upb_img.Name = "upb_img"
        Me.upb_img.Size = New System.Drawing.Size(357, 179)
        Me.upb_img.TabIndex = 7
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 7)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Vista Previa"
        '
        'CO_MT_CambiarFondoMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(376, 249)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Cambiar)
        Me.Controls.Add(Me.upb_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_CambiarFondoMenu"
        Me.Text = "Cambiar Fondo del Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ubtn_Cambiar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents upb_img As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
