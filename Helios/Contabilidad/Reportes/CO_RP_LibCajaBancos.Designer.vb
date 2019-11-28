<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_LibCajaBancos
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
        Me.components = New System.ComponentModel.Container
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuenta")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuenta")
        Me.ugb_Opciones = New Infragistics.Win.Misc.UltraGroupBox
        Me.uchk_SinFecha = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_Resumen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uchk_todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.lbl_mensaje = New Infragistics.Win.Misc.UltraLabel
        Me.upb_Mayor = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.ubtn_Imprimir = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.uos_Formato = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Opciones.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_Opciones
        '
        Me.ugb_Opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Opciones.Controls.Add(Me.uchk_SinFecha)
        Me.ugb_Opciones.Controls.Add(Me.uchk_Resumen)
        Me.ugb_Opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Opciones.Location = New System.Drawing.Point(366, 12)
        Me.ugb_Opciones.Name = "ugb_Opciones"
        Me.ugb_Opciones.Size = New System.Drawing.Size(191, 97)
        Me.ugb_Opciones.TabIndex = 15
        Me.ugb_Opciones.Text = "Opciones"
        '
        'uchk_SinFecha
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SinFecha.Appearance = Appearance4
        Me.uchk_SinFecha.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.Location = New System.Drawing.Point(15, 53)
        Me.uchk_SinFecha.Name = "uchk_SinFecha"
        Me.uchk_SinFecha.Size = New System.Drawing.Size(165, 20)
        Me.uchk_SinFecha.TabIndex = 0
        Me.uchk_SinFecha.Text = "Sin Fecha de Impresion"
        '
        'uchk_Resumen
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Resumen.Appearance = Appearance5
        Me.uchk_Resumen.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Resumen.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Resumen.Location = New System.Drawing.Point(15, 32)
        Me.uchk_Resumen.Name = "uchk_Resumen"
        Me.uchk_Resumen.Size = New System.Drawing.Size(165, 20)
        Me.uchk_Resumen.TabIndex = 0
        Me.uchk_Resumen.Text = "Resumen"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 12)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(198, 97)
        Me.ugb_Datos.TabIndex = 14
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel4
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance6
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
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(58, 28)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(62, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'uchk_todos
        '
        Me.uchk_todos.Location = New System.Drawing.Point(12, 115)
        Me.uchk_todos.Name = "uchk_todos"
        Me.uchk_todos.Size = New System.Drawing.Size(120, 20)
        Me.uchk_todos.TabIndex = 17
        Me.uchk_todos.Text = "Todos"
        '
        'lbl_mensaje
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mensaje.Appearance = Appearance7
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(14, 427)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(39, 14)
        Me.lbl_mensaje.TabIndex = 200
        Me.lbl_mensaje.Text = "Cargar"
        '
        'upb_Mayor
        '
        Me.upb_Mayor.Location = New System.Drawing.Point(12, 448)
        Me.upb_Mayor.Name = "upb_Mayor"
        Me.upb_Mayor.Size = New System.Drawing.Size(363, 19)
        Me.upb_Mayor.TabIndex = 199
        Me.upb_Mayor.Text = "[Formatted]"
        Me.upb_Mayor.Visible = False
        '
        'ubtn_Imprimir
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources.klpq_24x24_32
        Me.ubtn_Imprimir.Appearance = Appearance2
        Me.ubtn_Imprimir.Location = New System.Drawing.Point(396, 433)
        Me.ubtn_Imprimir.Name = "ubtn_Imprimir"
        Me.ubtn_Imprimir.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Imprimir.TabIndex = 197
        Me.ubtn_Imprimir.Text = "&Imprimir"
        '
        'ubtn_Cancelar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_Cancelar.Appearance = Appearance3
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(477, 433)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Cancelar.TabIndex = 198
        Me.ubtn_Cancelar.Text = "&Salir"
        '
        'uds_Cuentas
        '
        Me.uds_Cuentas.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn3.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn4.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.uds_Cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.uos_Formato)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(216, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(144, 97)
        Me.UltraGroupBox1.TabIndex = 201
        Me.UltraGroupBox1.Text = "Formato"
        '
        'uos_Formato
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.uos_Formato.Appearance = Appearance8
        Me.uos_Formato.BackColor = System.Drawing.Color.Transparent
        Me.uos_Formato.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Formato.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Formato.CheckedIndex = 0
        ValueListItem1.DataValue = CType(2, Short)
        ValueListItem1.DisplayText = "Efectivo"
        ValueListItem2.DataValue = CType(3, Short)
        ValueListItem2.DisplayText = "Cuenta Corriente"
        Me.uos_Formato.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uos_Formato.ItemSpacingHorizontal = 10
        Me.uos_Formato.ItemSpacingVertical = 5
        Me.uos_Formato.Location = New System.Drawing.Point(14, 30)
        Me.uos_Formato.Name = "uos_Formato"
        Me.uos_Formato.Size = New System.Drawing.Size(118, 46)
        Me.uos_Formato.TabIndex = 0
        Me.uos_Formato.Text = "Efectivo"
        '
        'ug_Cuentas
        '
        Me.ug_Cuentas.DataSource = Me.uds_Cuentas
        Me.ug_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Cuentas.Location = New System.Drawing.Point(12, 141)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(545, 278)
        Me.ug_Cuentas.TabIndex = 202
        '
        'CO_RP_LibCajaBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(564, 473)
        Me.Controls.Add(Me.ug_Cuentas)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.upb_Mayor)
        Me.Controls.Add(Me.ubtn_Imprimir)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.uchk_todos)
        Me.Controls.Add(Me.ugb_Opciones)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_LibCajaBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Caja y Bancos"
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Opciones.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Opciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_SinFecha As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Resumen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lbl_mensaje As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upb_Mayor As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents ubtn_Imprimir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_Formato As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
