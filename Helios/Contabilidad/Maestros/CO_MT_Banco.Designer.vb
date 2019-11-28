<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Banco
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_NOMBRE")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_RUC")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_NOMBRE")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_RUC")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_MT_Banco))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Bancos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Bancos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox
        Me.upb_Telefonos = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.upb_Contactos = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.upb_Cuentas = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.uchk_esPrin = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ume_limiteCredito = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txt_dir = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_ruc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_website = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_codzip = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_nombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uce_Pais = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Bancos = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.lblwebsize = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Codigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.utc_Bancos = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
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
        CType(Me.ug_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_website, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codzip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Pais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Bancos.SuspendLayout()
        Me.ToolS_Bancos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Bancos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(801, 396)
        '
        'ug_Bancos
        '
        Me.ug_Bancos.DataSource = Me.uds_Bancos
        Me.ug_Bancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Codigo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Nombre"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 403
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "R.U.C."
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_Bancos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Bancos.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_Bancos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Bancos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Bancos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_Bancos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Bancos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Bancos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Bancos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Bancos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_Bancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Bancos.Location = New System.Drawing.Point(0, 0)
        Me.ug_Bancos.Name = "ug_Bancos"
        Me.ug_Bancos.Size = New System.Drawing.Size(801, 396)
        Me.ug_Bancos.TabIndex = 0
        '
        'uds_Bancos
        '
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_Bancos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(801, 396)
        '
        'ugb_data
        '
        Me.ugb_data.Controls.Add(Me.upb_Telefonos)
        Me.ugb_data.Controls.Add(Me.upb_Contactos)
        Me.ugb_data.Controls.Add(Me.upb_Cuentas)
        Me.ugb_data.Controls.Add(Me.uchk_esPrin)
        Me.ugb_data.Controls.Add(Me.ume_limiteCredito)
        Me.ugb_data.Controls.Add(Me.txt_dir)
        Me.ugb_data.Controls.Add(Me.txt_ruc)
        Me.ugb_data.Controls.Add(Me.txt_website)
        Me.ugb_data.Controls.Add(Me.txt_codzip)
        Me.ugb_data.Controls.Add(Me.txt_nombre)
        Me.ugb_data.Controls.Add(Me.uce_Pais)
        Me.ugb_data.Controls.Add(Me.uce_Bancos)
        Me.ugb_data.Controls.Add(Me.UltraLabel8)
        Me.ugb_data.Controls.Add(Me.UltraLabel5)
        Me.ugb_data.Controls.Add(Me.UltraLabel3)
        Me.ugb_data.Controls.Add(Me.UltraLabel7)
        Me.ugb_data.Controls.Add(Me.lblwebsize)
        Me.ugb_data.Controls.Add(Me.UltraLabel2)
        Me.ugb_data.Controls.Add(Me.UltraLabel6)
        Me.ugb_data.Controls.Add(Me.txt_Codigo)
        Me.ugb_data.Controls.Add(Me.UltraLabel1)
        Me.ugb_data.Controls.Add(Me.UltraLabel11)
        Me.ugb_data.Controls.Add(Me.UltraLabel10)
        Me.ugb_data.Controls.Add(Me.UltraLabel9)
        Me.ugb_data.Controls.Add(Me.UltraLabel4)
        Me.ugb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_data.Location = New System.Drawing.Point(0, 0)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(801, 396)
        Me.ugb_data.TabIndex = 0
        Me.ugb_data.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'upb_Telefonos
        '
        Me.upb_Telefonos.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Telefonos.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.upb_Telefonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upb_Telefonos.Image = CType(resources.GetObject("upb_Telefonos.Image"), Object)
        Me.upb_Telefonos.Location = New System.Drawing.Point(670, 280)
        Me.upb_Telefonos.Name = "upb_Telefonos"
        Me.upb_Telefonos.Size = New System.Drawing.Size(100, 86)
        Me.upb_Telefonos.TabIndex = 10
        '
        'upb_Contactos
        '
        Me.upb_Contactos.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Contactos.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.upb_Contactos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upb_Contactos.Image = CType(resources.GetObject("upb_Contactos.Image"), Object)
        Me.upb_Contactos.Location = New System.Drawing.Point(670, 162)
        Me.upb_Contactos.Name = "upb_Contactos"
        Me.upb_Contactos.Size = New System.Drawing.Size(100, 86)
        Me.upb_Contactos.TabIndex = 10
        '
        'upb_Cuentas
        '
        Me.upb_Cuentas.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Cuentas.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.upb_Cuentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upb_Cuentas.Image = CType(resources.GetObject("upb_Cuentas.Image"), Object)
        Me.upb_Cuentas.Location = New System.Drawing.Point(670, 44)
        Me.upb_Cuentas.Name = "upb_Cuentas"
        Me.upb_Cuentas.Size = New System.Drawing.Size(100, 86)
        Me.upb_Cuentas.TabIndex = 10
        '
        'uchk_esPrin
        '
        Me.uchk_esPrin.BackColor = System.Drawing.Color.Transparent
        Me.uchk_esPrin.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_esPrin.Location = New System.Drawing.Point(205, 271)
        Me.uchk_esPrin.Name = "uchk_esPrin"
        Me.uchk_esPrin.Size = New System.Drawing.Size(120, 20)
        Me.uchk_esPrin.TabIndex = 8
        Me.uchk_esPrin.Text = "Es Banco Principal"
        '
        'ume_limiteCredito
        '
        Me.ume_limiteCredito.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ume_limiteCredito.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_limiteCredito.InputMask = "{double:9.2}"
        Me.ume_limiteCredito.Location = New System.Drawing.Point(205, 207)
        Me.ume_limiteCredito.Name = "ume_limiteCredito"
        Me.ume_limiteCredito.Size = New System.Drawing.Size(110, 20)
        Me.ume_limiteCredito.TabIndex = 6
        Me.ume_limiteCredito.Text = "UltraMaskedEdit1"
        '
        'txt_dir
        '
        Me.txt_dir.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_dir.Location = New System.Drawing.Point(111, 109)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(358, 21)
        Me.txt_dir.TabIndex = 3
        '
        'txt_ruc
        '
        Me.txt_ruc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_ruc.Location = New System.Drawing.Point(297, 34)
        Me.txt_ruc.MaxLength = 11
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(138, 21)
        Me.txt_ruc.TabIndex = 1
        '
        'txt_website
        '
        Me.txt_website.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_website.Location = New System.Drawing.Point(111, 163)
        Me.txt_website.Name = "txt_website"
        Me.txt_website.Size = New System.Drawing.Size(324, 21)
        Me.txt_website.TabIndex = 5
        '
        'txt_codzip
        '
        Me.txt_codzip.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_codzip.Location = New System.Drawing.Point(111, 136)
        Me.txt_codzip.MaxLength = 10
        Me.txt_codzip.Name = "txt_codzip"
        Me.txt_codzip.Size = New System.Drawing.Size(128, 21)
        Me.txt_codzip.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_nombre.Location = New System.Drawing.Point(111, 65)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(324, 21)
        Me.txt_nombre.TabIndex = 2
        '
        'uce_Pais
        '
        Me.uce_Pais.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Pais.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Pais.Location = New System.Drawing.Point(205, 233)
        Me.uce_Pais.Name = "uce_Pais"
        Me.uce_Pais.Size = New System.Drawing.Size(339, 21)
        Me.uce_Pais.TabIndex = 7
        '
        'uce_Bancos
        '
        Me.uce_Bancos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Bancos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Bancos.Location = New System.Drawing.Point(205, 308)
        Me.uce_Bancos.Name = "uce_Bancos"
        Me.uce_Bancos.Size = New System.Drawing.Size(218, 21)
        Me.uce_Bancos.TabIndex = 9
        '
        'UltraLabel8
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance4
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(172, 237)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel8.TabIndex = 9
        Me.UltraLabel8.Text = "Pais"
        '
        'UltraLabel5
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance6
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(43, 113)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel5.TabIndex = 9
        Me.UltraLabel5.Text = "Direccion"
        '
        'UltraLabel3
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance11
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(157, 313)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Bancos"
        '
        'UltraLabel7
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance17
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel7.Location = New System.Drawing.Point(109, 210)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel7.TabIndex = 9
        Me.UltraLabel7.Text = "Limite de Credito"
        '
        'lblwebsize
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.lblwebsize.Appearance = Appearance12
        Me.lblwebsize.AutoSize = True
        Me.lblwebsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblwebsize.Location = New System.Drawing.Point(43, 167)
        Me.lblwebsize.Name = "lblwebsize"
        Me.lblwebsize.Size = New System.Drawing.Size(50, 14)
        Me.lblwebsize.TabIndex = 9
        Me.lblwebsize.Text = "Web Site"
        '
        'UltraLabel2
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance13
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(267, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel2.TabIndex = 9
        Me.UltraLabel2.Text = "Ruc"
        '
        'UltraLabel6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance14
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(43, 140)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel6.TabIndex = 9
        Me.UltraLabel6.Text = "Codigo ZIP"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Codigo.Location = New System.Drawing.Point(111, 37)
        Me.txt_Codigo.MaxLength = 2
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(34, 21)
        Me.txt_Codigo.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(43, 69)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel1.TabIndex = 9
        Me.UltraLabel1.Text = "Nombre"
        '
        'UltraLabel11
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance16
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(692, 145)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel11.TabIndex = 9
        Me.UltraLabel11.Text = "Contactos"
        '
        'UltraLabel10
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance19
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(670, 263)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(111, 14)
        Me.UltraLabel10.TabIndex = 9
        Me.UltraLabel10.Text = "Numeros Telefonicos"
        '
        'UltraLabel9
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance20
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(668, 27)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(102, 14)
        Me.UltraLabel9.TabIndex = 9
        Me.UltraLabel9.Text = "Cuentas Corrientes"
        '
        'UltraLabel4
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance18
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(43, 41)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 9
        Me.UltraLabel4.Text = "Codigo"
        '
        'utc_Bancos
        '
        Me.utc_Bancos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Bancos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Bancos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Bancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utc_Bancos.Location = New System.Drawing.Point(0, 25)
        Me.utc_Bancos.Name = "utc_Bancos"
        Me.utc_Bancos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Bancos.Size = New System.Drawing.Size(803, 419)
        Me.utc_Bancos.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.utc_Bancos.TabIndex = 2
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        UltraTab1.Appearance = Appearance2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Bancos"
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._16__Pencil_tool_
        UltraTab2.Appearance = Appearance3
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de datos"
        Me.utc_Bancos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.utc_Bancos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(801, 396)
        '
        'ToolS_Bancos
        '
        Me.ToolS_Bancos.BackColor = System.Drawing.Color.White
        Me.ToolS_Bancos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Bancos.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Bancos.Name = "ToolS_Bancos"
        Me.ToolS_Bancos.Size = New System.Drawing.Size(803, 25)
        Me.ToolS_Bancos.TabIndex = 3
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
        'CO_MT_Banco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 444)
        Me.Controls.Add(Me.utc_Bancos)
        Me.Controls.Add(Me.ToolS_Bancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Banco"
        Me.Text = "Mantenimiento de Bancos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        Me.ugb_data.PerformLayout()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_website, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codzip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Pais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Bancos.ResumeLayout(False)
        Me.ToolS_Bancos.ResumeLayout(False)
        Me.ToolS_Bancos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Bancos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Bancos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_Bancos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Codigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents uds_Bancos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_dir As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_website As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_codzip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_nombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblwebsize As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_esPrin As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ume_limiteCredito As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents uce_Pais As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upb_Telefonos As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents upb_Contactos As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents upb_Cuentas As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
End Class
