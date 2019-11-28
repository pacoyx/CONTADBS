<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_TCamb_Copy
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_MT_TCamb_Copy))
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_Emp_Actual = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.uos_OpcGrabar = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.uce_Empresas = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.upb_Paso = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.txt_Emp_Actual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_OpcGrabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_data
        '
        Me.ugb_data.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_data.Controls.Add(Me.une_Ayo)
        Me.ugb_data.Controls.Add(Me.uce_Empresas)
        Me.ugb_data.Controls.Add(Me.UltraLabel4)
        Me.ugb_data.Controls.Add(Me.UltraLabel1)
        Me.ugb_data.Controls.Add(Me.UltraLabel2)
        Me.ugb_data.Controls.Add(Me.uce_Mes)
        Me.ugb_data.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_data.Location = New System.Drawing.Point(12, 8)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(297, 125)
        Me.ugb_data.TabIndex = 0
        Me.ugb_data.Text = "Empresa Origen"
        Me.ugb_data.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txt_Emp_Actual
        '
        Me.txt_Emp_Actual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.WindowsVista
        Me.txt_Emp_Actual.Location = New System.Drawing.Point(14, 57)
        Me.txt_Emp_Actual.Name = "txt_Emp_Actual"
        Me.txt_Emp_Actual.ReadOnly = True
        Me.txt_Emp_Actual.Size = New System.Drawing.Size(282, 21)
        Me.txt_Emp_Actual.TabIndex = 19
        '
        'une_Ayo
        '
        Me.une_Ayo.Enabled = False
        Me.une_Ayo.Location = New System.Drawing.Point(71, 60)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 64)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 18
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(14, 91)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel2.TabIndex = 17
        Me.UltraLabel2.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(71, 87)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(157, 21)
        Me.uce_Mes.TabIndex = 2
        '
        'ubtn_Aceptar
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.ubtn_Aceptar.Appearance = Appearance2
        Me.ubtn_Aceptar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007ScrollbarButton
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(484, 139)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(87, 32)
        Me.ubtn_Aceptar.TabIndex = 4
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_Cancelar.Appearance = Appearance3
        Me.ubtn_Cancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(577, 139)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(87, 32)
        Me.ubtn_Cancelar.TabIndex = 5
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'uos_OpcGrabar
        '
        Me.uos_OpcGrabar.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.uos_OpcGrabar.CheckedIndex = 0
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "Reemplazar todo el Mes"
        ValueListItem2.DataValue = CType(2, Short)
        ValueListItem2.DisplayText = "Solo dias faltantes"
        Me.uos_OpcGrabar.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uos_OpcGrabar.ItemSpacingHorizontal = 10
        Me.uos_OpcGrabar.ItemSpacingVertical = 5
        Me.uos_OpcGrabar.Location = New System.Drawing.Point(14, 84)
        Me.uos_OpcGrabar.Name = "uos_OpcGrabar"
        Me.uos_OpcGrabar.Size = New System.Drawing.Size(278, 32)
        Me.uos_OpcGrabar.TabIndex = 3
        Me.uos_OpcGrabar.Text = "Reemplazar todo el Mes"
        '
        'uce_Empresas
        '
        Me.uce_Empresas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Empresas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Empresas.Location = New System.Drawing.Point(71, 33)
        Me.uce_Empresas.Name = "uce_Empresas"
        Me.uce_Empresas.Size = New System.Drawing.Size(208, 21)
        Me.uce_Empresas.TabIndex = 0
        '
        'UltraLabel3
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(14, 37)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Empresa Actual"
        '
        'UltraLabel4
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance4
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 33)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Empresa"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.txt_Emp_Actual)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.uos_OpcGrabar)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(353, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(311, 125)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Empresa Destino"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'upb_Paso
        '
        Me.upb_Paso.AutoSize = True
        Me.upb_Paso.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Paso.Image = CType(resources.GetObject("upb_Paso.Image"), Object)
        Me.upb_Paso.Location = New System.Drawing.Point(315, 57)
        Me.upb_Paso.Name = "upb_Paso"
        Me.upb_Paso.Size = New System.Drawing.Size(32, 32)
        Me.upb_Paso.TabIndex = 6
        '
        'CO_MT_TCamb_Copy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(673, 176)
        Me.Controls.Add(Me.upb_Paso)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_data)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.MaximizeBox = False
        Me.Name = "CO_MT_TCamb_Copy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar tipo de cambio desde otra empresa"
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        Me.ugb_data.PerformLayout()
        CType(Me.txt_Emp_Actual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_OpcGrabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Empresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_Empresas As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uos_OpcGrabar As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Emp_Actual As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents upb_Paso As Infragistics.Win.UltraWinEditors.UltraPictureBox
End Class
