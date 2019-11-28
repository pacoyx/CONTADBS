<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Banco_Contactos
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_IDBANCO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_IDCONTACTO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_NOMBRES")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_APELLIDOS")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_CARGO")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_IDBANCO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_IDCONTACTO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NOMBRES")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_APELLIDOS")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_CARGO")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CT_IDREG")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CT_IDCONTACTO")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CT_IDCOMUNICACION")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TC_DESCRIPCION")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CT_NUMERO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CT_DESCRIPCION")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CT_ISTATUS")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CT_IDREG")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CT_IDCONTACTO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CT_IDCOMUNICACION")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TC_DESCRIPCION")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CT_NUMERO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CT_DESCRIPCION")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CT_ISTATUS")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Contactos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Contactos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox
        Me.ugb_Medios = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_numero = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_descripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_TipoComu = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ubtn_quitar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_agregar = New Infragistics.Win.Misc.UltraButton
        Me.ug_Telefono = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Telefonos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_apellidos = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_email = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_cargo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.utc_Contactos = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.lbl_titulo = New Infragistics.Win.Misc.UltraLabel
        Me.ToolS_Bancos = New System.Windows.Forms.ToolStrip
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Contactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Contactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.ugb_Medios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Medios.SuspendLayout()
        CType(Me.txt_numero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoComu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Telefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Telefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_apellidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Contactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Contactos.SuspendLayout()
        Me.ToolS_Bancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Contactos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(619, 349)
        '
        'ug_Contactos
        '
        Me.ug_Contactos.DataSource = Me.uds_Contactos
        Me.ug_Contactos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Nombres"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 143
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Apellidos"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 254
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "Cargo / Funcion"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.ug_Contactos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Contactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Contactos.Location = New System.Drawing.Point(0, 0)
        Me.ug_Contactos.Name = "ug_Contactos"
        Me.ug_Contactos.Size = New System.Drawing.Size(619, 349)
        Me.ug_Contactos.TabIndex = 0
        '
        'uds_Contactos
        '
        Me.uds_Contactos.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn2.DataType = GetType(Integer)
        Me.uds_Contactos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(619, 349)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.ugb_Medios)
        Me.ugb_datos.Controls.Add(Me.txt_nombres)
        Me.ugb_datos.Controls.Add(Me.txt_apellidos)
        Me.ugb_datos.Controls.Add(Me.txt_email)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.txt_cargo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Location = New System.Drawing.Point(19, 21)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(589, 325)
        Me.ugb_datos.TabIndex = 0
        '
        'ugb_Medios
        '
        Me.ugb_Medios.Controls.Add(Me.txt_numero)
        Me.ugb_Medios.Controls.Add(Me.txt_descripcion)
        Me.ugb_Medios.Controls.Add(Me.UltraLabel6)
        Me.ugb_Medios.Controls.Add(Me.UltraLabel5)
        Me.ugb_Medios.Controls.Add(Me.uce_TipoComu)
        Me.ugb_Medios.Controls.Add(Me.ubtn_quitar)
        Me.ugb_Medios.Controls.Add(Me.ubtn_agregar)
        Me.ugb_Medios.Controls.Add(Me.ug_Telefono)
        Me.ugb_Medios.Location = New System.Drawing.Point(36, 93)
        Me.ugb_Medios.Name = "ugb_Medios"
        Me.ugb_Medios.Size = New System.Drawing.Size(542, 212)
        Me.ugb_Medios.TabIndex = 13
        Me.ugb_Medios.Text = "Telefonos del Contacto"
        '
        'txt_numero
        '
        Me.txt_numero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_numero.Location = New System.Drawing.Point(249, 25)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(173, 21)
        Me.txt_numero.TabIndex = 1
        '
        'txt_descripcion
        '
        Me.txt_descripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_descripcion.Location = New System.Drawing.Point(82, 52)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(340, 21)
        Me.txt_descripcion.TabIndex = 2
        '
        'UltraLabel6
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance5
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 56)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "Descripcion"
        '
        'UltraLabel5
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance4
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(16, 29)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel5.TabIndex = 14
        Me.UltraLabel5.Text = "Tipo"
        '
        'uce_TipoComu
        '
        Me.uce_TipoComu.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_TipoComu.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoComu.Location = New System.Drawing.Point(82, 25)
        Me.uce_TipoComu.Name = "uce_TipoComu"
        Me.uce_TipoComu.Size = New System.Drawing.Size(161, 21)
        Me.uce_TipoComu.TabIndex = 0
        '
        'ubtn_quitar
        '
        Appearance20.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.ubtn_quitar.Appearance = Appearance20
        Me.ubtn_quitar.Location = New System.Drawing.Point(438, 89)
        Me.ubtn_quitar.Name = "ubtn_quitar"
        Me.ubtn_quitar.Size = New System.Drawing.Size(80, 29)
        Me.ubtn_quitar.TabIndex = 4
        Me.ubtn_quitar.Text = "&Quitar"
        '
        'ubtn_agregar
        '
        Appearance19.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.ubtn_agregar.Appearance = Appearance19
        Me.ubtn_agregar.Location = New System.Drawing.Point(438, 44)
        Me.ubtn_agregar.Name = "ubtn_agregar"
        Me.ubtn_agregar.Size = New System.Drawing.Size(80, 30)
        Me.ubtn_agregar.TabIndex = 3
        Me.ubtn_agregar.Text = "&Agregar"
        '
        'ug_Telefono
        '
        Me.ug_Telefono.DataSource = Me.uds_Telefonos
        Appearance10.BackColor = System.Drawing.Color.White
        Me.ug_Telefono.DisplayLayout.Appearance = Appearance10
        Me.ug_Telefono.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.Caption = "Tipo"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 113
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.Caption = "Numero"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Width = 111
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "Descripcion"
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "Activo"
        UltraGridColumn12.Header.VisiblePosition = 6
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.ug_Telefono.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Telefono.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.ug_Telefono.DisplayLayout.Override.CardAreaAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.FontData.Name = "Arial"
        Appearance16.FontData.SizeInPoints = 10.0!
        Appearance16.ForeColor = System.Drawing.Color.White
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_Telefono.DisplayLayout.Override.HeaderAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_Telefono.DisplayLayout.Override.RowSelectorAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_Telefono.DisplayLayout.Override.SelectedRowAppearance = Appearance18
        Me.ug_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Telefono.Location = New System.Drawing.Point(15, 89)
        Me.ug_Telefono.Name = "ug_Telefono"
        Me.ug_Telefono.Size = New System.Drawing.Size(407, 117)
        Me.ug_Telefono.TabIndex = 11
        Me.ug_Telefono.Text = "UltraGrid1"
        '
        'uds_Telefonos
        '
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Integer)
        UltraDataColumn8.DataType = GetType(Integer)
        UltraDataColumn12.DataType = GetType(Boolean)
        Me.uds_Telefonos.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'txt_nombres
        '
        Me.txt_nombres.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_nombres.Location = New System.Drawing.Point(92, 17)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(170, 21)
        Me.txt_nombres.TabIndex = 0
        '
        'txt_apellidos
        '
        Me.txt_apellidos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_apellidos.Location = New System.Drawing.Point(329, 17)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(225, 21)
        Me.txt_apellidos.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_email.Location = New System.Drawing.Point(371, 44)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(183, 21)
        Me.txt_email.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance21
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(329, 48)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "E-Mail"
        '
        'txt_cargo
        '
        Me.txt_cargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_cargo.Location = New System.Drawing.Point(92, 44)
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(231, 21)
        Me.txt_cargo.TabIndex = 2
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(36, 48)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(35, 14)
        Me.UltraLabel2.TabIndex = 10
        Me.UltraLabel2.Text = "Cargo"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(273, 21)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel1.TabIndex = 10
        Me.UltraLabel1.Text = "Apellidos"
        '
        'UltraLabel4
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance24
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(36, 21)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "Nombres"
        '
        'utc_Contactos
        '
        Me.utc_Contactos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Contactos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Contactos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Contactos.Location = New System.Drawing.Point(3, 58)
        Me.utc_Contactos.Name = "utc_Contactos"
        Me.utc_Contactos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Contactos.Size = New System.Drawing.Size(621, 372)
        Me.utc_Contactos.TabIndex = 10
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        UltraTab1.Appearance = Appearance1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Contactos"
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Pencil_tool_
        UltraTab2.Appearance = Appearance2
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Contactos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.utc_Contactos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(619, 349)
        '
        'lbl_titulo
        '
        Appearance9.BackColor = System.Drawing.Color.LightBlue
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance9.TextHAlignAsString = "Center"
        Me.lbl_titulo.Appearance = Appearance9
        Me.lbl_titulo.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(0, 28)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(624, 27)
        Me.lbl_titulo.TabIndex = 9
        Me.lbl_titulo.Text = "ScotiaBank"
        '
        'ToolS_Bancos
        '
        Me.ToolS_Bancos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolS_Bancos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Bancos.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Bancos.Name = "ToolS_Bancos"
        Me.ToolS_Bancos.Size = New System.Drawing.Size(628, 25)
        Me.ToolS_Bancos.TabIndex = 8
        Me.ToolS_Bancos.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(58, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(55, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'CO_MT_Banco_Contactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(628, 433)
        Me.Controls.Add(Me.utc_Contactos)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.ToolS_Bancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Banco_Contactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contactos de Bancos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Contactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Contactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.ugb_Medios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Medios.ResumeLayout(False)
        Me.ugb_Medios.PerformLayout()
        CType(Me.txt_numero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoComu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Telefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Telefonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_apellidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Contactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Contactos.ResumeLayout(False)
        Me.ToolS_Bancos.ResumeLayout(False)
        Me.ToolS_Bancos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Contactos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Contactos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_cargo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_titulo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Bancos As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_Contactos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_apellidos As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_email As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_Telefono As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Telefonos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Medios As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoComu As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_numero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_descripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
End Class
