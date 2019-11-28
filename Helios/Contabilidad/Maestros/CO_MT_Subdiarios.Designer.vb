<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Subdiarios
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SD_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SD_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SD_ABREVIATURA")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SD_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SD_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SD_ABREVIATURA")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_SubDiario = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_SubDiarios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.uchk_cierre = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_EsApe = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_estado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uce_SubOpe = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Ope = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_Abrevi = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.Abreviatura = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Descri = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Codigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.utc_Subdiarios = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ToolS_Subdiarios = New System.Windows.Forms.ToolStrip
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
        CType(Me.ug_SubDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_SubDiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_SubOpe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Ope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Abrevi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Subdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Subdiarios.SuspendLayout()
        Me.ToolS_Subdiarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_SubDiario)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(725, 275)
        '
        'ug_SubDiario
        '
        Me.ug_SubDiario.DataSource = Me.uds_SubDiarios
        Me.ug_SubDiario.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 84
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 155
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Abreviatura"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 143
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_SubDiario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_SubDiario.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_SubDiario.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_SubDiario.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_SubDiario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_SubDiario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_SubDiario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_SubDiario.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_SubDiario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_SubDiario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_SubDiario.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_SubDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_SubDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_SubDiario.Location = New System.Drawing.Point(0, 0)
        Me.ug_SubDiario.Name = "ug_SubDiario"
        Me.ug_SubDiario.Size = New System.Drawing.Size(725, 275)
        Me.ug_SubDiario.TabIndex = 0
        '
        'uds_SubDiarios
        '
        Me.uds_SubDiarios.AllowDelete = False
        Me.uds_SubDiarios.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(725, 275)
        '
        'ugb_data
        '
        Me.ugb_data.Controls.Add(Me.UltraGroupBox1)
        Me.ugb_data.Controls.Add(Me.uce_SubOpe)
        Me.ugb_data.Controls.Add(Me.uce_Ope)
        Me.ugb_data.Controls.Add(Me.txt_Abrevi)
        Me.ugb_data.Controls.Add(Me.UltraLabel3)
        Me.ugb_data.Controls.Add(Me.UltraLabel2)
        Me.ugb_data.Controls.Add(Me.Abreviatura)
        Me.ugb_data.Controls.Add(Me.txt_Descri)
        Me.ugb_data.Controls.Add(Me.UltraLabel1)
        Me.ugb_data.Controls.Add(Me.txt_Codigo)
        Me.ugb_data.Controls.Add(Me.UltraLabel4)
        Me.ugb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_data.Location = New System.Drawing.Point(0, 0)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(725, 275)
        Me.ugb_data.TabIndex = 0
        Me.ugb_data.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uchk_cierre)
        Me.UltraGroupBox1.Controls.Add(Me.uchk_EsApe)
        Me.UltraGroupBox1.Controls.Add(Me.uchk_estado)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(112, 133)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(364, 51)
        Me.UltraGroupBox1.TabIndex = 12
        '
        'uchk_cierre
        '
        Me.uchk_cierre.BackColor = System.Drawing.Color.Transparent
        Me.uchk_cierre.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_cierre.Location = New System.Drawing.Point(296, 18)
        Me.uchk_cierre.Name = "uchk_cierre"
        Me.uchk_cierre.Size = New System.Drawing.Size(62, 20)
        Me.uchk_cierre.TabIndex = 2
        Me.uchk_cierre.Text = "Cierre"
        '
        'uchk_EsApe
        '
        Me.uchk_EsApe.BackColor = System.Drawing.Color.Transparent
        Me.uchk_EsApe.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_EsApe.Location = New System.Drawing.Point(197, 18)
        Me.uchk_EsApe.Name = "uchk_EsApe"
        Me.uchk_EsApe.Size = New System.Drawing.Size(80, 20)
        Me.uchk_EsApe.TabIndex = 1
        Me.uchk_EsApe.Text = "Apertura"
        '
        'uchk_estado
        '
        Me.uchk_estado.BackColor = System.Drawing.Color.Transparent
        Me.uchk_estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_estado.Checked = True
        Me.uchk_estado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_estado.Location = New System.Drawing.Point(17, 18)
        Me.uchk_estado.Name = "uchk_estado"
        Me.uchk_estado.Size = New System.Drawing.Size(94, 20)
        Me.uchk_estado.TabIndex = 0
        Me.uchk_estado.Text = "Estado Activo"
        '
        'uce_SubOpe
        '
        Me.uce_SubOpe.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_SubOpe.Location = New System.Drawing.Point(143, 241)
        Me.uce_SubOpe.Name = "uce_SubOpe"
        Me.uce_SubOpe.Size = New System.Drawing.Size(218, 21)
        Me.uce_SubOpe.TabIndex = 4
        '
        'uce_Ope
        '
        Me.uce_Ope.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Ope.Location = New System.Drawing.Point(143, 211)
        Me.uce_Ope.Name = "uce_Ope"
        Me.uce_Ope.ShowOverflowIndicator = True
        Me.uce_Ope.Size = New System.Drawing.Size(218, 21)
        Me.uce_Ope.TabIndex = 3
        '
        'txt_Abrevi
        '
        Me.txt_Abrevi.Location = New System.Drawing.Point(111, 92)
        Me.txt_Abrevi.MaxLength = 10
        Me.txt_Abrevi.Name = "txt_Abrevi"
        Me.txt_Abrevi.Size = New System.Drawing.Size(133, 21)
        Me.txt_Abrevi.TabIndex = 2
        '
        'UltraLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(57, 245)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Sub Operacion"
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(57, 215)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(57, 14)
        Me.UltraLabel2.TabIndex = 9
        Me.UltraLabel2.Text = "Operacion"
        '
        'Abreviatura
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Abreviatura.Appearance = Appearance8
        Me.Abreviatura.AutoSize = True
        Me.Abreviatura.Location = New System.Drawing.Point(43, 96)
        Me.Abreviatura.Name = "Abreviatura"
        Me.Abreviatura.Size = New System.Drawing.Size(62, 14)
        Me.Abreviatura.TabIndex = 9
        Me.Abreviatura.Text = "Abreviatura"
        '
        'txt_Descri
        '
        Me.txt_Descri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descri.Location = New System.Drawing.Point(112, 64)
        Me.txt_Descri.MaxLength = 100
        Me.txt_Descri.Name = "txt_Descri"
        Me.txt_Descri.Size = New System.Drawing.Size(413, 21)
        Me.txt_Descri.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(43, 68)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 9
        Me.UltraLabel1.Text = "Descripcion"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(111, 37)
        Me.txt_Codigo.MaxLength = 2
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(33, 21)
        Me.txt_Codigo.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(43, 41)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 9
        Me.UltraLabel4.Text = "Codigo"
        '
        'utc_Subdiarios
        '
        Me.utc_Subdiarios.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Subdiarios.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Subdiarios.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Subdiarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utc_Subdiarios.Location = New System.Drawing.Point(0, 25)
        Me.utc_Subdiarios.Name = "utc_Subdiarios"
        Me.utc_Subdiarios.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Subdiarios.Size = New System.Drawing.Size(729, 301)
        Me.utc_Subdiarios.TabIndex = 0
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        UltraTab1.Appearance = Appearance2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Subdiarios"
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._16__Pencil_tool_
        UltraTab2.Appearance = Appearance3
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de datos"
        Me.utc_Subdiarios.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(725, 275)
        '
        'ToolS_Subdiarios
        '
        Me.ToolS_Subdiarios.BackColor = System.Drawing.Color.White
        Me.ToolS_Subdiarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Subdiarios.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Subdiarios.Name = "ToolS_Subdiarios"
        Me.ToolS_Subdiarios.Size = New System.Drawing.Size(729, 25)
        Me.ToolS_Subdiarios.TabIndex = 1
        Me.ToolS_Subdiarios.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
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
        'CO_MT_Subdiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(729, 326)
        Me.Controls.Add(Me.utc_Subdiarios)
        Me.Controls.Add(Me.ToolS_Subdiarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Subdiarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Subdiarios"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_SubDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_SubDiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        Me.ugb_data.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.uce_SubOpe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Ope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Abrevi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Subdiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Subdiarios.ResumeLayout(False)
        Me.ToolS_Subdiarios.ResumeLayout(False)
        Me.ToolS_Subdiarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Subdiarios As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_SubDiarios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolS_Subdiarios As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ug_SubDiario As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_Codigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_cierre As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_estado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_EsApe As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_Abrevi As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Abreviatura As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descri As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_SubOpe As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Ope As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton

    
End Class
