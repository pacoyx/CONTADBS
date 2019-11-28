<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_RegCompraVentaHono
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Num_cta")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_cta", -1, "udd_Cuenta")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDCUENTA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_IDCUENTA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_NUM_CUENTA")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Operacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uds_cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lb_tiposCta = New System.Windows.Forms.ListBox
        Me.udd_Cuenta = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.uds_Cuentas_ayuda = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        CType(Me.uce_Operacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udd_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas_ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 40)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(57, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Operacion"
        '
        'uce_Operacion
        '
        Me.uce_Operacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Operacion.Location = New System.Drawing.Point(73, 36)
        Me.uce_Operacion.Name = "uce_Operacion"
        Me.uce_Operacion.Size = New System.Drawing.Size(205, 21)
        Me.uce_Operacion.TabIndex = 1
        '
        'uds_cuentas
        '
        Me.uds_cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn1})
        '
        'ug_cuentas
        '
        Me.ug_cuentas.DataSource = Me.uds_cuentas
        Me.ug_cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.ug_cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_cuentas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_cuentas.Location = New System.Drawing.Point(284, 63)
        Me.ug_cuentas.Name = "ug_cuentas"
        Me.ug_cuentas.Size = New System.Drawing.Size(320, 355)
        Me.ug_cuentas.TabIndex = 2
        '
        'lb_tiposCta
        '
        Me.lb_tiposCta.FormattingEnabled = True
        Me.lb_tiposCta.Location = New System.Drawing.Point(10, 63)
        Me.lb_tiposCta.Name = "lb_tiposCta"
        Me.lb_tiposCta.Size = New System.Drawing.Size(268, 355)
        Me.lb_tiposCta.TabIndex = 3
        '
        'udd_Cuenta
        '
        Me.udd_Cuenta.DataSource = Me.uds_Cuentas_ayuda
        Me.udd_Cuenta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Numero"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 116
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Descripcion"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.udd_Cuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udd_Cuenta.DisplayMember = "PC_NUM_CUENTA"
        Me.udd_Cuenta.DropDownWidth = 400
        Me.udd_Cuenta.Location = New System.Drawing.Point(284, 164)
        Me.udd_Cuenta.Name = "udd_Cuenta"
        Me.udd_Cuenta.Size = New System.Drawing.Size(367, 148)
        Me.udd_Cuenta.TabIndex = 6
        Me.udd_Cuenta.ValueMember = "PC_IDCUENTA"
        Me.udd_Cuenta.Visible = False
        '
        'uds_Cuentas_ayuda
        '
        Me.uds_Cuentas_ayuda.AllowAdd = False
        Me.uds_Cuentas_ayuda.AllowDelete = False
        UltraDataColumn2.DataType = GetType(Integer)
        Me.uds_Cuentas_ayuda.Band.Columns.AddRange(New Object() {UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(616, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'CO_MT_RegCompraVentaHono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(616, 429)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.udd_Cuenta)
        Me.Controls.Add(Me.lb_tiposCta)
        Me.Controls.Add(Me.ug_cuentas)
        Me.Controls.Add(Me.uce_Operacion)
        Me.Controls.Add(Me.UltraLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_RegCompraVentaHono"
        Me.Text = "Registro de Compra,Venta y Hono"
        CType(Me.uce_Operacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udd_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas_ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Operacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lb_tiposCta As System.Windows.Forms.ListBox
    Friend WithEvents udd_Cuenta As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents uds_Cuentas_ayuda As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
