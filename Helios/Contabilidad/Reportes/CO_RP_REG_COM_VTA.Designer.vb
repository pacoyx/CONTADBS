<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_REG_COM_VTA
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.uos_Tipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Imprimir = New Infragistics.Win.Misc.UltraButton
        Me.ugb_opciones = New Infragistics.Win.Misc.UltraGroupBox
        Me.uos_opciones = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.uchk_incluir_RH = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_opciones.SuspendLayout()
        CType(Me.uos_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(58, 28)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(62, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(168, 4)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(214, 97)
        Me.ugb_Datos.TabIndex = 2
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(20, 59)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 195
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(58, 55)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(123, 21)
        Me.uce_Mes.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'uos_Tipo
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uos_Tipo.Appearance = Appearance4
        Me.uos_Tipo.BackColor = System.Drawing.Color.Transparent
        Me.uos_Tipo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Tipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Tipo.CheckedIndex = 0
        ValueListItem1.DataValue = "C"
        ValueListItem1.DisplayText = "Registro de Compras"
        ValueListItem2.DataValue = "V"
        ValueListItem2.DisplayText = "Registro de Ventas"
        ValueListItem5.DataValue = "H"
        ValueListItem5.DisplayText = "Registro de Honorarios"
        Me.uos_Tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem5})
        Me.uos_Tipo.ItemSpacingHorizontal = 10
        Me.uos_Tipo.ItemSpacingVertical = 7
        Me.uos_Tipo.Location = New System.Drawing.Point(13, 23)
        Me.uos_Tipo.Name = "uos_Tipo"
        Me.uos_Tipo.Size = New System.Drawing.Size(133, 71)
        Me.uos_Tipo.TabIndex = 2
        Me.uos_Tipo.Text = "Registro de Compras"
        '
        'ubtn_Cancelar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_Cancelar.Appearance = Appearance3
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(307, 212)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Cancelar.TabIndex = 1
        Me.ubtn_Cancelar.Text = "&Salir"
        '
        'ubtn_Imprimir
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.ubtn_Imprimir.Appearance = Appearance2
        Me.ubtn_Imprimir.Location = New System.Drawing.Point(226, 212)
        Me.ubtn_Imprimir.Name = "ubtn_Imprimir"
        Me.ubtn_Imprimir.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Imprimir.TabIndex = 0
        Me.ubtn_Imprimir.Text = "&Imprimir"
        '
        'ugb_opciones
        '
        Me.ugb_opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_opciones.Controls.Add(Me.uos_opciones)
        Me.ugb_opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_opciones.Location = New System.Drawing.Point(6, 105)
        Me.ugb_opciones.Name = "ugb_opciones"
        Me.ugb_opciones.Size = New System.Drawing.Size(160, 101)
        Me.ugb_opciones.TabIndex = 3
        Me.ugb_opciones.Text = "Formatos"
        '
        'uos_opciones
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uos_opciones.Appearance = Appearance5
        Me.uos_opciones.BackColor = System.Drawing.Color.Transparent
        Me.uos_opciones.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_opciones.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_opciones.CheckedIndex = 0
        ValueListItem3.DataValue = "S"
        ValueListItem3.DisplayText = "Simple ( Carta Vertical )"
        ValueListItem4.DataValue = "SN"
        ValueListItem4.DisplayText = "Sunat ( Matricial )"
        ValueListItem6.DataValue = "SNC"
        ValueListItem6.DisplayText = "Sunat ( Carta Horizontal )"
        Me.uos_opciones.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4, ValueListItem6})
        Me.uos_opciones.ItemSpacingHorizontal = 10
        Me.uos_opciones.ItemSpacingVertical = 7
        Me.uos_opciones.Location = New System.Drawing.Point(6, 22)
        Me.uos_opciones.Name = "uos_opciones"
        Me.uos_opciones.Size = New System.Drawing.Size(148, 73)
        Me.uos_opciones.TabIndex = 0
        Me.uos_opciones.Text = "Simple ( Carta Vertical )"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.uos_Tipo)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(161, 98)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Registro"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.uchk_incluir_RH)
        Me.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox2.Location = New System.Drawing.Point(172, 107)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(210, 99)
        Me.UltraGroupBox2.TabIndex = 5
        Me.UltraGroupBox2.Text = "+ Opciones"
        '
        'uchk_incluir_RH
        '
        Me.uchk_incluir_RH.BackColor = System.Drawing.Color.Transparent
        Me.uchk_incluir_RH.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_incluir_RH.Location = New System.Drawing.Point(12, 24)
        Me.uchk_incluir_RH.Name = "uchk_incluir_RH"
        Me.uchk_incluir_RH.Size = New System.Drawing.Size(180, 20)
        Me.uchk_incluir_RH.TabIndex = 0
        Me.uchk_incluir_RH.Text = "Incluir R.H."
        '
        'CO_RP_REG_COM_VTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(394, 248)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_opciones)
        Me.Controls.Add(Me.ubtn_Imprimir)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_REG_COM_VTA"
        Me.Text = "Registro de Compra / Venta / Honorario"
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_opciones.ResumeLayout(False)
        CType(Me.uos_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uos_Tipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Imprimir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_opciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_opciones As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_incluir_RH As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
