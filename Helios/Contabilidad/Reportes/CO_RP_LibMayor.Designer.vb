<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_LibMayor
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
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuenta")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuenta")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuenta")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuenta")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_RP_LibMayor))
        Me.ugb_Opciones = New Infragistics.Win.Misc.UltraGroupBox
        Me.une_Digito = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.uchk_SinFecha = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_Resumen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_Ctas_Titulo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ubtn_Imprimir = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.uchk_todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.upb_Mayor = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.lbl_mensaje = New Infragistics.Win.Misc.UltraLabel
        Me.ug_ctas_titulo = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_ctasTitulo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.upb_cargando = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Opciones.SuspendLayout()
        CType(Me.une_Digito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ctas_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ctasTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_Opciones
        '
        Me.ugb_Opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Opciones.Controls.Add(Me.une_Digito)
        Me.ugb_Opciones.Controls.Add(Me.uchk_SinFecha)
        Me.ugb_Opciones.Controls.Add(Me.uchk_Resumen)
        Me.ugb_Opciones.Controls.Add(Me.uchk_Ctas_Titulo)
        Me.ugb_Opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Opciones.Location = New System.Drawing.Point(216, 6)
        Me.ugb_Opciones.Name = "ugb_Opciones"
        Me.ugb_Opciones.Size = New System.Drawing.Size(191, 95)
        Me.ugb_Opciones.TabIndex = 13
        Me.ugb_Opciones.Text = "Opciones"
        '
        'une_Digito
        '
        Me.une_Digito.Location = New System.Drawing.Point(139, 65)
        Me.une_Digito.MaskInput = "n"
        Me.une_Digito.Name = "une_Digito"
        Me.une_Digito.Size = New System.Drawing.Size(41, 21)
        Me.une_Digito.TabIndex = 199
        '
        'uchk_SinFecha
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SinFecha.Appearance = Appearance4
        Me.uchk_SinFecha.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.Location = New System.Drawing.Point(15, 43)
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
        Me.uchk_Resumen.Location = New System.Drawing.Point(15, 26)
        Me.uchk_Resumen.Name = "uchk_Resumen"
        Me.uchk_Resumen.Size = New System.Drawing.Size(165, 20)
        Me.uchk_Resumen.TabIndex = 0
        Me.uchk_Resumen.Text = "Resumen"
        '
        'uchk_Ctas_Titulo
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Ctas_Titulo.Appearance = Appearance8
        Me.uchk_Ctas_Titulo.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Ctas_Titulo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Ctas_Titulo.Location = New System.Drawing.Point(15, 66)
        Me.uchk_Ctas_Titulo.Name = "uchk_Ctas_Titulo"
        Me.uchk_Ctas_Titulo.Size = New System.Drawing.Size(118, 20)
        Me.uchk_Ctas_Titulo.TabIndex = 197
        Me.uchk_Ctas_Titulo.Text = "Cuentas Titulo"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 6)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(198, 95)
        Me.ugb_Datos.TabIndex = 12
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
        'ubtn_Imprimir
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources.klpq_24x24_32
        Me.ubtn_Imprimir.Appearance = Appearance2
        Me.ubtn_Imprimir.Location = New System.Drawing.Point(251, 430)
        Me.ubtn_Imprimir.Name = "ubtn_Imprimir"
        Me.ubtn_Imprimir.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Imprimir.TabIndex = 14
        Me.ubtn_Imprimir.Text = "&Imprimir"
        '
        'ubtn_Cancelar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_Cancelar.Appearance = Appearance3
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(332, 430)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Cancelar.TabIndex = 15
        Me.ubtn_Cancelar.Text = "&Salir"
        '
        'uchk_todos
        '
        Me.uchk_todos.Location = New System.Drawing.Point(12, 107)
        Me.uchk_todos.Name = "uchk_todos"
        Me.uchk_todos.Size = New System.Drawing.Size(66, 20)
        Me.uchk_todos.TabIndex = 16
        Me.uchk_todos.Text = "Todos"
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
        UltraGridColumn2.Width = 75
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Cuentas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Cuentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Cuentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Cuentas.Location = New System.Drawing.Point(12, 133)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(395, 288)
        Me.ug_Cuentas.TabIndex = 17
        '
        'upb_Mayor
        '
        Me.upb_Mayor.Location = New System.Drawing.Point(12, 438)
        Me.upb_Mayor.Name = "upb_Mayor"
        Me.upb_Mayor.Size = New System.Drawing.Size(221, 23)
        Me.upb_Mayor.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.upb_Mayor.TabIndex = 18
        Me.upb_Mayor.Text = "[Formatted]"
        Me.upb_Mayor.Visible = False
        '
        'lbl_mensaje
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mensaje.Appearance = Appearance7
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(12, 421)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(0, 0)
        Me.lbl_mensaje.TabIndex = 196
        '
        'ug_ctas_titulo
        '
        Me.ug_ctas_titulo.DataSource = Me.uds_ctasTitulo
        Me.ug_ctas_titulo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 58
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.ug_ctas_titulo.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_ctas_titulo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ctas_titulo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ctas_titulo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ctas_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ctas_titulo.Location = New System.Drawing.Point(12, 133)
        Me.ug_ctas_titulo.Name = "ug_ctas_titulo"
        Me.ug_ctas_titulo.Size = New System.Drawing.Size(395, 288)
        Me.ug_ctas_titulo.TabIndex = 198
        Me.ug_ctas_titulo.Text = "UltraGrid1"
        '
        'uds_ctasTitulo
        '
        Me.uds_ctasTitulo.AllowDelete = False
        UltraDataColumn5.DataType = GetType(Boolean)
        UltraDataColumn5.DefaultValue = False
        UltraDataColumn7.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        UltraDataColumn8.DataType = GetType(Integer)
        UltraDataColumn8.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.uds_ctasTitulo.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'upb_cargando
        '
        Me.upb_cargando.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_cargando.Image = CType(resources.GetObject("upb_cargando.Image"), Object)
        Me.upb_cargando.Location = New System.Drawing.Point(12, 133)
        Me.upb_cargando.Name = "upb_cargando"
        Me.upb_cargando.Size = New System.Drawing.Size(395, 288)
        Me.upb_cargando.TabIndex = 199
        Me.upb_cargando.Visible = False
        '
        'CO_RP_LibMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(417, 467)
        Me.Controls.Add(Me.upb_cargando)
        Me.Controls.Add(Me.ug_ctas_titulo)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.upb_Mayor)
        Me.Controls.Add(Me.ug_Cuentas)
        Me.Controls.Add(Me.uchk_todos)
        Me.Controls.Add(Me.ubtn_Imprimir)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ugb_Opciones)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_LibMayor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Mayor"
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Opciones.ResumeLayout(False)
        Me.ugb_Opciones.PerformLayout()
        CType(Me.une_Digito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ctas_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ctasTitulo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ubtn_Imprimir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uchk_todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents upb_Mayor As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents lbl_mensaje As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_Ctas_Titulo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ug_ctas_titulo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_ctasTitulo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents une_Digito As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents upb_cargando As Infragistics.Win.UltraWinEditors.UltraPictureBox
End Class
