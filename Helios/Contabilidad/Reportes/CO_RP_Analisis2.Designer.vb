<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_Analisis2
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
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Ayuda")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraListViewSubItemColumn1 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("IdTipo")
        Dim UltraListViewSubItemColumn2 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("Tipo")
        Dim UltraListViewSubItemColumn3 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("Ruc")
        Dim UltraListViewSubItemColumn4 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("Descripcion")
        Dim UltraListViewSubItemColumn5 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("idanexo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_IDCAB")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_IDSUBDIARIO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SD_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_NUM_VOUCHER")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_ANHO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_MES")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_FEC_VOUCHER")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_CUENTA")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_IDANEXO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_DEBE")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_HABER")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_TCAM")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_GLOSA")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_MONTO_ORI")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_IDCUENTA")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_TDOC")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_SDOC")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_NDOC")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.txt_cod_Doc_Cab = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_NumDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_SerieDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.txt_IdAnexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uce_TipoAnexo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_Des_Prove = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_ruc_anexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.ulbl_num_filas = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ugb_anexos = New Infragistics.Win.Misc.UltraGroupBox
        Me.ulv_anexos = New Infragistics.Win.UltraWinListView.UltraListView
        Me.ug_doc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Histo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolS_Histo = New System.Windows.Forms.ToolStrip
        Me.Tool_Buscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Exportar = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExcelMicrosoftOfficeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenOfficeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.utc_parametros = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.uos_busqueda = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_cod_Doc_Cab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.txt_IdAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Prove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_anexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ugb_anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_anexos.SuspendLayout()
        CType(Me.ulv_anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Histo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Histo.SuspendLayout()
        CType(Me.utc_parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_parametros.SuspendLayout()
        CType(Me.uos_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_cod_Doc_Cab)
        Me.UltraTabPageControl1.Controls.Add(Me.uce_TipoDoc)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_NumDoc)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_SerieDoc)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(890, 40)
        '
        'txt_cod_Doc_Cab
        '
        Me.txt_cod_Doc_Cab.Location = New System.Drawing.Point(74, 7)
        Me.txt_cod_Doc_Cab.Name = "txt_cod_Doc_Cab"
        Me.txt_cod_Doc_Cab.Size = New System.Drawing.Size(29, 21)
        Me.txt_cod_Doc_Cab.TabIndex = 0
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 200
        Me.uce_TipoDoc.Location = New System.Drawing.Point(103, 7)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(112, 21)
        Me.uce_TipoDoc.TabIndex = 1
        '
        'txt_NumDoc
        '
        Me.txt_NumDoc.Location = New System.Drawing.Point(266, 7)
        Me.txt_NumDoc.Name = "txt_NumDoc"
        Me.txt_NumDoc.Size = New System.Drawing.Size(102, 21)
        Me.txt_NumDoc.TabIndex = 3
        '
        'UltraLabel9
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance81
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(11, 11)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel9.TabIndex = 89
        Me.UltraLabel9.Text = "Documento"
        '
        'txt_SerieDoc
        '
        Appearance77.TextHAlignAsString = "Left"
        Me.txt_SerieDoc.Appearance = Appearance77
        Me.txt_SerieDoc.Location = New System.Drawing.Point(214, 7)
        Me.txt_SerieDoc.Name = "txt_SerieDoc"
        Me.txt_SerieDoc.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDoc.TabIndex = 2
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_IdAnexo)
        Me.UltraTabPageControl2.Controls.Add(Me.uce_TipoAnexo)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Des_Prove)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_ruc_anexo)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(890, 40)
        '
        'txt_IdAnexo
        '
        Me.txt_IdAnexo.Location = New System.Drawing.Point(320, 10)
        Me.txt_IdAnexo.Name = "txt_IdAnexo"
        Me.txt_IdAnexo.ReadOnly = True
        Me.txt_IdAnexo.Size = New System.Drawing.Size(57, 21)
        Me.txt_IdAnexo.TabIndex = 63
        '
        'uce_TipoAnexo
        '
        Me.uce_TipoAnexo.DropDownListWidth = 200
        Me.uce_TipoAnexo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoAnexo.Location = New System.Drawing.Point(42, 10)
        Me.uce_TipoAnexo.Name = "uce_TipoAnexo"
        Me.uce_TipoAnexo.Size = New System.Drawing.Size(117, 21)
        Me.uce_TipoAnexo.TabIndex = 94
        '
        'txt_Des_Prove
        '
        Me.txt_Des_Prove.Location = New System.Drawing.Point(376, 10)
        Me.txt_Des_Prove.Name = "txt_Des_Prove"
        Me.txt_Des_Prove.ReadOnly = True
        Me.txt_Des_Prove.Size = New System.Drawing.Size(223, 21)
        Me.txt_Des_Prove.TabIndex = 64
        '
        'txt_ruc_anexo
        '
        Appearance111.Image = Global.Contabilidad.My.Resources.Resources._104
        Appearance111.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance111.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance111
        EditorButton1.Key = "Ayuda"
        Me.txt_ruc_anexo.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_anexo.Location = New System.Drawing.Point(165, 10)
        Me.txt_ruc_anexo.Name = "txt_ruc_anexo"
        Me.txt_ruc_anexo.Size = New System.Drawing.Size(155, 21)
        Me.txt_ruc_anexo.TabIndex = 62
        '
        'UltraLabel7
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance29
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(6, 14)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel7.TabIndex = 65
        Me.UltraLabel7.Text = "Anexo :"
        '
        'ulbl_num_filas
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.TextHAlignAsString = "Right"
        Me.ulbl_num_filas.Appearance = Appearance14
        Me.ulbl_num_filas.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.None
        Me.ulbl_num_filas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ulbl_num_filas.Location = New System.Drawing.Point(558, 11)
        Me.ulbl_num_filas.Name = "ulbl_num_filas"
        Me.ulbl_num_filas.Size = New System.Drawing.Size(326, 23)
        Me.ulbl_num_filas.TabIndex = 90
        Me.ulbl_num_filas.Text = "..."
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Me.UltraGroupBox2.Controls.Add(Me.ugb_anexos)
        Me.UltraGroupBox2.Controls.Add(Me.ug_doc)
        Me.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(895, 324)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Movimientos Encontrados :"
        '
        'ugb_anexos
        '
        Me.ugb_anexos.Controls.Add(Me.ulv_anexos)
        Me.ugb_anexos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_anexos.Location = New System.Drawing.Point(217, 46)
        Me.ugb_anexos.Name = "ugb_anexos"
        Me.ugb_anexos.Size = New System.Drawing.Size(517, 181)
        Me.ugb_anexos.TabIndex = 1
        Me.ugb_anexos.Text = "Seleccione un Anexo :(Doble Clic)"
        Me.ugb_anexos.Visible = False
        '
        'ulv_anexos
        '
        Me.ulv_anexos.ItemSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.[False]
        Me.ulv_anexos.ItemSettings.HotTracking = True
        Me.ulv_anexos.Location = New System.Drawing.Point(6, 24)
        Me.ulv_anexos.Name = "ulv_anexos"
        Me.ulv_anexos.Size = New System.Drawing.Size(505, 151)
        UltraListViewSubItemColumn1.DataType = GetType(Short)
        UltraListViewSubItemColumn1.Key = "IdTipo"
        UltraListViewSubItemColumn1.Text = "IdTipo"
        UltraListViewSubItemColumn1.Width = 50
        UltraListViewSubItemColumn2.DataType = GetType(String)
        UltraListViewSubItemColumn2.Key = "Tipo"
        UltraListViewSubItemColumn2.Text = "Tipo_Anexo"
        UltraListViewSubItemColumn3.DataType = GetType(String)
        UltraListViewSubItemColumn3.Key = "Ruc"
        UltraListViewSubItemColumn3.Text = "Ruc"
        UltraListViewSubItemColumn4.DataType = GetType(String)
        UltraListViewSubItemColumn4.Key = "Descripcion"
        UltraListViewSubItemColumn4.Text = "Descripcion"
        UltraListViewSubItemColumn5.DataType = GetType(Integer)
        UltraListViewSubItemColumn5.Key = "idanexo"
        Me.ulv_anexos.SubItemColumns.AddRange(New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn() {UltraListViewSubItemColumn1, UltraListViewSubItemColumn2, UltraListViewSubItemColumn3, UltraListViewSubItemColumn4, UltraListViewSubItemColumn5})
        Me.ulv_anexos.TabIndex = 0
        Me.ulv_anexos.View = Infragistics.Win.UltraWinListView.UltraListViewStyle.Details
        Me.ulv_anexos.ViewSettingsDetails.AutoFitColumns = Infragistics.Win.UltraWinListView.AutoFitColumns.ResizeAllColumns
        Me.ulv_anexos.ViewSettingsDetails.FullRowSelect = True
        '
        'ug_doc
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Me.ug_doc.DisplayLayout.Appearance = Appearance2
        Me.ug_doc.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Me.ug_doc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_doc.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_doc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.ug_doc.DisplayLayout.Override.CardAreaAppearance = Appearance3
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 10.0!
        Appearance8.ForeColor = System.Drawing.Color.White
        Appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_doc.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.ug_doc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_doc.DisplayLayout.Override.RowSelectorAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_doc.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.ug_doc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_doc.Location = New System.Drawing.Point(3, 21)
        Me.ug_doc.Name = "ug_doc"
        Me.ug_doc.Size = New System.Drawing.Size(889, 300)
        Me.ug_doc.TabIndex = 0
        Me.ug_doc.Text = "UltraGrid1"
        '
        'uds_Histo
        '
        Me.uds_Histo.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn9.DataType = GetType(Integer)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Integer)
        Me.uds_Histo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'ToolS_Histo
        '
        Me.ToolS_Histo.BackColor = System.Drawing.Color.White
        Me.ToolS_Histo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Buscar, Me.ToolStripSeparator2, Me.Tool_Imprimir, Me.ToolStripSeparator1, Me.Tool_Exportar, Me.ToolStripSeparator4, Me.Tool_salir, Me.ToolStripSeparator3})
        Me.ToolS_Histo.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Histo.Name = "ToolS_Histo"
        Me.ToolS_Histo.Size = New System.Drawing.Size(916, 25)
        Me.ToolS_Histo.TabIndex = 2
        Me.ToolS_Histo.Text = "ToolStrip1"
        '
        'Tool_Buscar
        '
        Me.Tool_Buscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Buscar.Image = Global.Contabilidad.My.Resources.Resources._16__Print_preview_
        Me.Tool_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Buscar.Name = "Tool_Buscar"
        Me.Tool_Buscar.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Buscar.Text = "Buscar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Exportar
        '
        Me.Tool_Exportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelMicrosoftOfficeToolStripMenuItem, Me.OpenOfficeToolStripMenuItem})
        Me.Tool_Exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Contents_
        Me.Tool_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Exportar.Name = "Tool_Exportar"
        Me.Tool_Exportar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Exportar.Text = "Exportar"
        '
        'ExcelMicrosoftOfficeToolStripMenuItem
        '
        Me.ExcelMicrosoftOfficeToolStripMenuItem.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.ExcelMicrosoftOfficeToolStripMenuItem.Name = "ExcelMicrosoftOfficeToolStripMenuItem"
        Me.ExcelMicrosoftOfficeToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ExcelMicrosoftOfficeToolStripMenuItem.Text = "Excel - Microsoft Office"
        '
        'OpenOfficeToolStripMenuItem
        '
        Me.OpenOfficeToolStripMenuItem.Image = Global.Contabilidad.My.Resources.Resources.icono_openOffice_calc
        Me.OpenOfficeToolStripMenuItem.Name = "OpenOfficeToolStripMenuItem"
        Me.OpenOfficeToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OpenOfficeToolStripMenuItem.Text = "Calc - Open Office"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'utc_parametros
        '
        Me.utc_parametros.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_parametros.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_parametros.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_parametros.Location = New System.Drawing.Point(15, 77)
        Me.utc_parametros.Name = "utc_parametros"
        Me.utc_parametros.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_parametros.Size = New System.Drawing.Size(892, 61)
        Me.utc_parametros.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.utc_parametros.TabIndex = 91
        Appearance7.Image = Global.Contabilidad.My.Resources.Resources._16__Credit_card_
        UltraTab1.Appearance = Appearance7
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Datos del  Documento"
        Appearance11.Image = Global.Contabilidad.My.Resources.Resources._16__Idcard_
        UltraTab2.Appearance = Appearance11
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Datos del Anexo"
        Me.utc_parametros.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(890, 40)
        '
        'uos_busqueda
        '
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.uos_busqueda.Appearance = Appearance12
        Me.uos_busqueda.BackColor = System.Drawing.Color.Transparent
        Me.uos_busqueda.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_busqueda.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_busqueda.CheckedIndex = 0
        ValueListItem1.DataValue = CType(0, Short)
        ValueListItem1.DisplayText = "Por Documento"
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Por Anexo"
        Me.uos_busqueda.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uos_busqueda.Location = New System.Drawing.Point(15, 14)
        Me.uos_busqueda.Name = "uos_busqueda"
        Me.uos_busqueda.Size = New System.Drawing.Size(181, 20)
        Me.uos_busqueda.TabIndex = 92
        Me.uos_busqueda.Text = "Por Documento"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uos_busqueda)
        Me.UltraGroupBox1.Controls.Add(Me.ulbl_num_filas)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(894, 43)
        Me.UltraGroupBox1.TabIndex = 93
        '
        'CO_RP_Analisis2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(916, 479)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.utc_parametros)
        Me.Controls.Add(Me.ToolS_Histo)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Name = "CO_RP_Analisis2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador de Documentos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_cod_Doc_Cab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.txt_IdAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Prove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_anexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.ugb_anexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_anexos.ResumeLayout(False)
        CType(Me.ulv_anexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Histo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Histo.ResumeLayout(False)
        Me.ToolS_Histo.PerformLayout()
        CType(Me.utc_parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_parametros.ResumeLayout(False)
        CType(Me.uos_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cod_Doc_Cab As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SerieDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_doc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Histo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolS_Histo As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ulbl_num_filas As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_Exportar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents OpenOfficeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelMicrosoftOfficeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents utc_parametros As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uos_busqueda As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents txt_IdAnexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Prove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_anexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_anexos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ulv_anexos As Infragistics.Win.UltraWinListView.UltraListView
    Friend WithEvents uce_TipoAnexo As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
