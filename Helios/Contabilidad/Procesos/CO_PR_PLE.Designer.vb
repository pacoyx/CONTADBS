<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_PLE
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_planCuentas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_LibMayor = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_LibDiario = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_LibCajaBancos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_RegVentas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_RegCompras = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ToolS_Analisis1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Generar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Abrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lbl_fecha = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.ToolS_Analisis1.SuspendLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.uchk_planCuentas)
        Me.UltraGroupBox2.Controls.Add(Me.uchk_LibMayor)
        Me.UltraGroupBox2.Controls.Add(Me.uchk_LibDiario)
        Me.UltraGroupBox2.Controls.Add(Me.uchk_LibCajaBancos)
        Me.UltraGroupBox2.Controls.Add(Me.uchk_RegVentas)
        Me.UltraGroupBox2.Controls.Add(Me.uchk_RegCompras)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 75)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(201, 174)
        Me.UltraGroupBox2.TabIndex = 198
        Me.UltraGroupBox2.Text = "Seleccione ..."
        '
        'uchk_planCuentas
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uchk_planCuentas.Appearance = Appearance2
        Me.uchk_planCuentas.BackColor = System.Drawing.Color.Transparent
        Me.uchk_planCuentas.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_planCuentas.Location = New System.Drawing.Point(23, 148)
        Me.uchk_planCuentas.Name = "uchk_planCuentas"
        Me.uchk_planCuentas.Size = New System.Drawing.Size(120, 20)
        Me.uchk_planCuentas.TabIndex = 0
        Me.uchk_planCuentas.Text = "Plan de Cuentas"
        '
        'uchk_LibMayor
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.uchk_LibMayor.Appearance = Appearance7
        Me.uchk_LibMayor.BackColor = System.Drawing.Color.Transparent
        Me.uchk_LibMayor.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_LibMayor.Location = New System.Drawing.Point(23, 127)
        Me.uchk_LibMayor.Name = "uchk_LibMayor"
        Me.uchk_LibMayor.Size = New System.Drawing.Size(120, 20)
        Me.uchk_LibMayor.TabIndex = 0
        Me.uchk_LibMayor.Text = "Libro Mayor"
        '
        'uchk_LibDiario
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uchk_LibDiario.Appearance = Appearance3
        Me.uchk_LibDiario.BackColor = System.Drawing.Color.Transparent
        Me.uchk_LibDiario.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_LibDiario.Location = New System.Drawing.Point(23, 101)
        Me.uchk_LibDiario.Name = "uchk_LibDiario"
        Me.uchk_LibDiario.Size = New System.Drawing.Size(120, 20)
        Me.uchk_LibDiario.TabIndex = 0
        Me.uchk_LibDiario.Text = "Libro Diario"
        '
        'uchk_LibCajaBancos
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_LibCajaBancos.Appearance = Appearance4
        Me.uchk_LibCajaBancos.BackColor = System.Drawing.Color.Transparent
        Me.uchk_LibCajaBancos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_LibCajaBancos.Enabled = False
        Me.uchk_LibCajaBancos.Location = New System.Drawing.Point(23, 75)
        Me.uchk_LibCajaBancos.Name = "uchk_LibCajaBancos"
        Me.uchk_LibCajaBancos.Size = New System.Drawing.Size(146, 20)
        Me.uchk_LibCajaBancos.TabIndex = 0
        Me.uchk_LibCajaBancos.Text = "Libro Caja y Bancos"
        '
        'uchk_RegVentas
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uchk_RegVentas.Appearance = Appearance5
        Me.uchk_RegVentas.BackColor = System.Drawing.Color.Transparent
        Me.uchk_RegVentas.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_RegVentas.Location = New System.Drawing.Point(23, 49)
        Me.uchk_RegVentas.Name = "uchk_RegVentas"
        Me.uchk_RegVentas.Size = New System.Drawing.Size(146, 20)
        Me.uchk_RegVentas.TabIndex = 0
        Me.uchk_RegVentas.Text = "Registro de Ventas"
        '
        'uchk_RegCompras
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.uchk_RegCompras.Appearance = Appearance6
        Me.uchk_RegCompras.BackColor = System.Drawing.Color.Transparent
        Me.uchk_RegCompras.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_RegCompras.Location = New System.Drawing.Point(23, 23)
        Me.uchk_RegCompras.Name = "uchk_RegCompras"
        Me.uchk_RegCompras.Size = New System.Drawing.Size(146, 20)
        Me.uchk_RegCompras.TabIndex = 0
        Me.uchk_RegCompras.Text = "Registro de Compras"
        '
        'ToolS_Analisis1
        '
        Me.ToolS_Analisis1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolS_Analisis1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_Generar, Me.ToolStripSeparator1, Me.Tool_Abrir, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolS_Analisis1.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Analisis1.Name = "ToolS_Analisis1"
        Me.ToolS_Analisis1.Size = New System.Drawing.Size(229, 25)
        Me.ToolS_Analisis1.TabIndex = 196
        Me.ToolS_Analisis1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Generar
        '
        Me.Tool_Generar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Generar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Generar.Name = "Tool_Generar"
        Me.Tool_Generar.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Generar.Text = "Generar"
        Me.Tool_Generar.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Abrir
        '
        Me.Tool_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Abrir.Name = "Tool_Abrir"
        Me.Tool_Abrir.Size = New System.Drawing.Size(37, 22)
        Me.Tool_Abrir.Text = "Abrir"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(39, 10)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(38, 21)
        Me.une_Ayo.TabIndex = 17
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.une_Ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Mes)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(201, 41)
        Me.UltraGroupBox1.TabIndex = 197
        '
        'UltraLabel1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 14)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 16
        Me.UltraLabel1.Text = "Año :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(79, 10)
        Me.uce_Mes.MaxDropDownItems = 12
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_Mes.TabIndex = 14
        '
        'lbl_fecha
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fecha.Appearance = Appearance23
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(18, 255)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(14, 14)
        Me.lbl_fecha.TabIndex = 199
        Me.lbl_fecha.Text = "..."
        '
        'CO_PR_PLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(229, 285)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.ToolS_Analisis1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "CO_PR_PLE"
        Me.Text = "Prog. Libros Elect."
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ToolS_Analisis1.ResumeLayout(False)
        Me.ToolS_Analisis1.PerformLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_LibMayor As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_LibDiario As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_LibCajaBancos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_RegVentas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_RegCompras As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolS_Analisis1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Generar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Abrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_planCuentas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lbl_fecha As Infragistics.Win.Misc.UltraLabel
End Class
