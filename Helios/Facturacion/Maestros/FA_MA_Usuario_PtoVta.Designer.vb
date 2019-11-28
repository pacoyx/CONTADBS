<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_MA_Usuario_PtoVta
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Agregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PtoVta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_usuario = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lb_Lista = New System.Windows.Forms.ListBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_eliminar = New Infragistics.Win.Misc.UltraButton()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.uce_PtoVta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator9})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(341, 25)
        Me.ToolS_Mantenimiento.TabIndex = 7
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(21, 14)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Usuario"
        '
        'ubtn_Agregar
        '
        Me.ubtn_Agregar.Location = New System.Drawing.Point(238, 118)
        Me.ubtn_Agregar.Name = "ubtn_Agregar"
        Me.ubtn_Agregar.Size = New System.Drawing.Size(63, 23)
        Me.ubtn_Agregar.TabIndex = 10
        Me.ubtn_Agregar.Text = "Agregar"
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(21, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Punto Venta"
        '
        'uce_PtoVta
        '
        Me.uce_PtoVta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PtoVta.Location = New System.Drawing.Point(93, 36)
        Me.uce_PtoVta.Name = "uce_PtoVta"
        Me.uce_PtoVta.Size = New System.Drawing.Size(214, 21)
        Me.uce_PtoVta.TabIndex = 11
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_usuario)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.uce_PtoVta)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(7, 37)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(325, 65)
        Me.UltraGroupBox1.TabIndex = 12
        '
        'uce_usuario
        '
        Me.uce_usuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_usuario.Location = New System.Drawing.Point(93, 10)
        Me.uce_usuario.Name = "uce_usuario"
        Me.uce_usuario.Size = New System.Drawing.Size(214, 21)
        Me.uce_usuario.TabIndex = 15
        '
        'lb_Lista
        '
        Me.lb_Lista.FormattingEnabled = True
        Me.lb_Lista.Location = New System.Drawing.Point(52, 118)
        Me.lb_Lista.Name = "lb_Lista"
        Me.lb_Lista.Size = New System.Drawing.Size(180, 147)
        Me.lb_Lista.TabIndex = 13
        '
        'UltraLabel3
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 118)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel3.TabIndex = 8
        Me.UltraLabel3.Text = "Lista :"
        '
        'ubtn_eliminar
        '
        Me.ubtn_eliminar.Location = New System.Drawing.Point(238, 147)
        Me.ubtn_eliminar.Name = "ubtn_eliminar"
        Me.ubtn_eliminar.Size = New System.Drawing.Size(63, 23)
        Me.ubtn_eliminar.TabIndex = 14
        Me.ubtn_eliminar.Text = "Eliminar"
        '
        'FA_MA_Usuario_PtoVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(341, 275)
        Me.Controls.Add(Me.ubtn_eliminar)
        Me.Controls.Add(Me.lb_Lista)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ubtn_Agregar)
        Me.Name = "FA_MA_Usuario_PtoVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacionar Usuario - Punto Venta "
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.uce_PtoVta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PtoVta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lb_Lista As System.Windows.Forms.ListBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_eliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uce_usuario As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
