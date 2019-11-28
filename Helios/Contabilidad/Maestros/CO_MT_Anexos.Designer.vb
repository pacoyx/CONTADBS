<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Anexos
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_IDANEXO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DI_ABREVIATURA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_NUM_DOC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_DESCRIPCION", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_IDANEXO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DI_ABREVIATURA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_NUM_DOC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_DESCRIPCION")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Anexos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Anexos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox
        Me.ubtn_Grabar = New Infragistics.Win.Misc.UltraButton
        Me.uchk_NoDomi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_EsRelacionado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txt_Razon = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_num_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_TipoEmp = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_TipoAnexo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.utc_Anexos = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ulbl_titulo = New Infragistics.Win.Misc.UltraLabel
        Me.ueb_TipoAnexos = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.Tool_Act_InfoClie = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.txt_Razon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Anexos.SuspendLayout()
        CType(Me.ueb_TipoAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Anexos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(613, 347)
        '
        'ug_Anexos
        '
        Me.ug_Anexos.DataSource = Me.uds_Anexos
        Me.ug_Anexos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Cod Anex"
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Width = 54
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Tipo Docu."
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Width = 42
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Documento"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 138
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Razon Social"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_Anexos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Anexos.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_Anexos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Anexos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Anexos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Anexos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Anexos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_Anexos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Anexos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_Anexos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Anexos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Anexos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Anexos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_Anexos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Anexos.Location = New System.Drawing.Point(0, 0)
        Me.ug_Anexos.Name = "ug_Anexos"
        Me.ug_Anexos.Size = New System.Drawing.Size(613, 347)
        Me.ug_Anexos.TabIndex = 0
        '
        'uds_Anexos
        '
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_Anexos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(613, 347)
        '
        'ugb_data
        '
        Me.ugb_data.Controls.Add(Me.ubtn_Grabar)
        Me.ugb_data.Controls.Add(Me.uchk_NoDomi)
        Me.ugb_data.Controls.Add(Me.uchk_EsRelacionado)
        Me.ugb_data.Controls.Add(Me.txt_Razon)
        Me.ugb_data.Controls.Add(Me.UltraLabel5)
        Me.ugb_data.Controls.Add(Me.txt_num_doc)
        Me.ugb_data.Controls.Add(Me.UltraLabel2)
        Me.ugb_data.Controls.Add(Me.UltraLabel4)
        Me.ugb_data.Controls.Add(Me.UltraLabel3)
        Me.ugb_data.Controls.Add(Me.UltraLabel1)
        Me.ugb_data.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_data.Controls.Add(Me.uce_TipoEmp)
        Me.ugb_data.Controls.Add(Me.uce_TipoAnexo)
        Me.ugb_data.Location = New System.Drawing.Point(12, 12)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(587, 324)
        Me.ugb_data.TabIndex = 0
        '
        'ubtn_Grabar
        '
        Appearance19.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.ubtn_Grabar.Appearance = Appearance19
        Me.ubtn_Grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Grabar.Location = New System.Drawing.Point(349, 214)
        Me.ubtn_Grabar.Name = "ubtn_Grabar"
        Me.ubtn_Grabar.Size = New System.Drawing.Size(127, 34)
        Me.ubtn_Grabar.TabIndex = 5
        Me.ubtn_Grabar.Text = "&Grabar"
        '
        'uchk_NoDomi
        '
        Appearance10.FontData.SizeInPoints = 10.0!
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.uchk_NoDomi.Appearance = Appearance10
        Me.uchk_NoDomi.Location = New System.Drawing.Point(103, 200)
        Me.uchk_NoDomi.Name = "uchk_NoDomi"
        Me.uchk_NoDomi.Size = New System.Drawing.Size(120, 20)
        Me.uchk_NoDomi.TabIndex = 6
        Me.uchk_NoDomi.Text = "No Domiciliado"
        '
        'uchk_EsRelacionado
        '
        Appearance3.FontData.SizeInPoints = 10.0!
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uchk_EsRelacionado.Appearance = Appearance3
        Me.uchk_EsRelacionado.Location = New System.Drawing.Point(103, 174)
        Me.uchk_EsRelacionado.Name = "uchk_EsRelacionado"
        Me.uchk_EsRelacionado.Size = New System.Drawing.Size(120, 20)
        Me.uchk_EsRelacionado.TabIndex = 6
        Me.uchk_EsRelacionado.Text = "Relacionado"
        '
        'txt_Razon
        '
        Me.txt_Razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Razon.Location = New System.Drawing.Point(103, 131)
        Me.txt_Razon.MaxLength = 100
        Me.txt_Razon.Name = "txt_Razon"
        Me.txt_Razon.Size = New System.Drawing.Size(373, 21)
        Me.txt_Razon.TabIndex = 4
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(19, 135)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel5.TabIndex = 1
        Me.UltraLabel5.Text = "Razon Social"
        '
        'txt_num_doc
        '
        Me.txt_num_doc.Location = New System.Drawing.Point(103, 104)
        Me.txt_num_doc.MaxLength = 11
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(142, 21)
        Me.txt_num_doc.TabIndex = 3
        '
        'UltraLabel2
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance15
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(19, 108)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Numero Doc."
        '
        'UltraLabel4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance12
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(19, 81)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Tipo Doc."
        '
        'UltraLabel3
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance14
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(19, 54)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel3.TabIndex = 1
        Me.UltraLabel3.Text = "Tipo Empresa"
        '
        'UltraLabel1
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance16
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(19, 27)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Tipo Anexo"
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDoc.Location = New System.Drawing.Point(103, 77)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(243, 21)
        Me.uce_TipoDoc.TabIndex = 2
        '
        'uce_TipoEmp
        '
        Me.uce_TipoEmp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoEmp.Location = New System.Drawing.Point(103, 50)
        Me.uce_TipoEmp.Name = "uce_TipoEmp"
        Me.uce_TipoEmp.Size = New System.Drawing.Size(182, 21)
        Me.uce_TipoEmp.TabIndex = 1
        '
        'uce_TipoAnexo
        '
        Me.uce_TipoAnexo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoAnexo.Location = New System.Drawing.Point(103, 23)
        Me.uce_TipoAnexo.Name = "uce_TipoAnexo"
        Me.uce_TipoAnexo.Size = New System.Drawing.Size(243, 21)
        Me.uce_TipoAnexo.TabIndex = 0
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(613, 347)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Imprimir, Me.ToolStripSeparator5, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator6, Me.ToolStripSeparator7, Me.Tool_Act_InfoClie})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(810, 25)
        Me.ToolS_Mantenimiento.TabIndex = 4
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
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
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        Me.Tool_Grabar.Visible = False
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
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
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
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
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'tool_Ayuda2
        '
        Me.tool_Ayuda2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tool_Ayuda2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tool_Ayuda2.Image = Global.Contabilidad.My.Resources.Resources._16__Help_
        Me.tool_Ayuda2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_Ayuda2.Name = "tool_Ayuda2"
        Me.tool_Ayuda2.Size = New System.Drawing.Size(23, 22)
        Me.tool_Ayuda2.Text = "Acerca de las Cuentas Tipo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'utc_Anexos
        '
        Me.utc_Anexos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Anexos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Anexos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Anexos.Location = New System.Drawing.Point(181, 56)
        Me.utc_Anexos.Name = "utc_Anexos"
        Me.utc_Anexos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Anexos.Size = New System.Drawing.Size(617, 373)
        Me.utc_Anexos.TabIndex = 5
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        UltraTab1.Appearance = Appearance2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Anexos"
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._16__Pencil_tool_
        UltraTab2.Appearance = Appearance1
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion Datos"
        Me.utc_Anexos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(613, 347)
        '
        'ulbl_titulo
        '
        Appearance9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance9.TextHAlignAsString = "Center"
        Me.ulbl_titulo.Appearance = Appearance9
        Me.ulbl_titulo.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ulbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ulbl_titulo.Location = New System.Drawing.Point(182, 28)
        Me.ulbl_titulo.Name = "ulbl_titulo"
        Me.ulbl_titulo.Size = New System.Drawing.Size(613, 23)
        Me.ulbl_titulo.TabIndex = 8
        Me.ulbl_titulo.Text = "..."
        '
        'ueb_TipoAnexos
        '
        UltraExplorerBarGroup1.Text = "Tipos de Anexos"
        UltraExplorerBarGroup1.ToolTipText = "Tipos de Anexos"
        Me.ueb_TipoAnexos.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1})
        Me.ueb_TipoAnexos.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Me.ueb_TipoAnexos.Location = New System.Drawing.Point(0, 28)
        Me.ueb_TipoAnexos.Name = "ueb_TipoAnexos"
        Me.ueb_TipoAnexos.Size = New System.Drawing.Size(175, 401)
        Me.ueb_TipoAnexos.TabIndex = 3
        Me.ueb_TipoAnexos.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        Me.ueb_TipoAnexos.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.Office2007
        '
        'Tool_Act_InfoClie
        '
        Me.Tool_Act_InfoClie.Image = Global.Contabilidad.My.Resources.Resources._726
        Me.Tool_Act_InfoClie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Act_InfoClie.Name = "Tool_Act_InfoClie"
        Me.Tool_Act_InfoClie.Size = New System.Drawing.Size(157, 22)
        Me.Tool_Act_InfoClie.Text = "Actualizar Datos Clientes"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'CO_MT_Anexos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(810, 434)
        Me.Controls.Add(Me.ueb_TipoAnexos)
        Me.Controls.Add(Me.ulbl_titulo)
        Me.Controls.Add(Me.utc_Anexos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Anexos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Anexos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Anexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Anexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        Me.ugb_data.PerformLayout()
        CType(Me.txt_Razon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Anexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Anexos.ResumeLayout(False)
        CType(Me.ueb_TipoAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
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
    Friend WithEvents utc_Anexos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Anexos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Anexos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ulbl_titulo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_TipoAnexo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_num_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoEmp As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Razon As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ueb_TipoAnexos As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents uchk_EsRelacionado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ubtn_Grabar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uchk_NoDomi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Act_InfoClie As System.Windows.Forms.ToolStripButton
End Class
