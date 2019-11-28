<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_MA_Articulo
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CODIGO", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CODIGO_ALT")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_PRECIO_VENTA")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_IDFAMILIA")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FA_DESCRIPCION")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_IDCATEGORIA")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_DESCRIPCION")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_NUM_CTA_CONTA")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ESTADO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_TIPO_ARTI")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_INCLUYE_IGV")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ING_RAP")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_MON_VTA")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CTRL_STOCK")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ES_NO_AFEC_IGV")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CODIGO_ALT")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_PRECIO_VENTA")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_IDFAMILIA")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FA_DESCRIPCION")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_IDCATEGORIA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_DESCRIPCION")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_NUM_CTA_CONTA")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ESTADO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_TIPO_ARTI")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_INCLUYE_IGV")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ING_RAP")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_MON_VTA")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CTRL_STOCK")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ES_NO_AFEC_IGV")
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Lista_Arti = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.uos_stock = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Categoria = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Familia = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lbl_des_cta = New Infragistics.Win.Misc.UltraLabel
        Me.uchk_ing_rap = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_incluyeIgv = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uce_PrecioVta = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
        Me.uos_Estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.uce_tipo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_descripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_cta_conta = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_codigo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_cod_alt = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ume_cant_um_compra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraMaskedEdit1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraColorPicker1 = New Infragistics.Win.UltraWinEditors.UltraColorPicker
        Me.une_stock_min = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txt_des_prove = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_idprove = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uce_um_distri = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_um_venta = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_fabricante = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_marca = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_pais = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_um_peso = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_um_compra = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Ubicaciones = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_GrupoArt = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip
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
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.utc_TipoAne = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.uchk_noafecto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista_Arti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.uos_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Familia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PrecioVta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cta_conta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_alt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_stock_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_des_prove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_distri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_fabricante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_marca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_pais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Ubicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_GrupoArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_TipoAne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_TipoAne.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(674, 287)
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_Lista_Arti
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 71
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 58
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "DESCRIPCION"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 354
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance36
        UltraGridColumn4.Header.Caption = "PRECIO"
        UltraGridColumn4.Header.VisiblePosition = 7
        UltraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn4.Width = 80
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.Caption = "FAMILIA"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 148
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "CATEGORIA"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 132
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance37.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance37
        UltraGridColumn9.Header.Caption = "CTA CONTA"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Width = 73
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 42
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 28
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "INC. IGV"
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn12.Width = 55
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Lista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance35.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance35.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance35
        Me.ug_Lista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(0, 0)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(674, 287)
        Me.ug_Lista.TabIndex = 0
        '
        'uds_Lista_Arti
        '
        Me.uds_Lista_Arti.AllowDelete = False
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Short)
        UltraDataColumn13.DataType = GetType(Short)
        UltraDataColumn15.DataType = GetType(Short)
        UltraDataColumn16.DataType = GetType(Short)
        Me.uds_Lista_Arti.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(674, 287)
        '
        'ugb_datos
        '
        Me.ugb_datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_datos.Controls.Add(Me.uchk_noafecto)
        Me.ugb_datos.Controls.Add(Me.UltraGroupBox2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel22)
        Me.ugb_datos.Controls.Add(Me.uce_Categoria)
        Me.ugb_datos.Controls.Add(Me.uce_Familia)
        Me.ugb_datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.uce_moneda)
        Me.ugb_datos.Controls.Add(Me.lbl_des_cta)
        Me.ugb_datos.Controls.Add(Me.uchk_ing_rap)
        Me.ugb_datos.Controls.Add(Me.uchk_incluyeIgv)
        Me.ugb_datos.Controls.Add(Me.uce_PrecioVta)
        Me.ugb_datos.Controls.Add(Me.uos_Estado)
        Me.ugb_datos.Controls.Add(Me.uce_tipo)
        Me.ugb_datos.Controls.Add(Me.txt_descripcion)
        Me.ugb_datos.Controls.Add(Me.txt_cta_conta)
        Me.ugb_datos.Controls.Add(Me.txt_codigo)
        Me.ugb_datos.Controls.Add(Me.txt_cod_alt)
        Me.ugb_datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_datos.Controls.Add(Me.UltraLabel11)
        Me.ugb_datos.Controls.Add(Me.UltraLabel10)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Controls.Add(Me.UltraLabel19)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_datos.Location = New System.Drawing.Point(8, 6)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(653, 275)
        Me.ugb_datos.TabIndex = 0
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.uos_stock)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(105, 187)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(186, 43)
        Me.UltraGroupBox2.TabIndex = 14
        '
        'uos_stock
        '
        Me.uos_stock.BackColor = System.Drawing.Color.Transparent
        Me.uos_stock.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_stock.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_stock.CheckedIndex = 0
        ValueListItem7.DataValue = CType(1, Short)
        ValueListItem7.DisplayText = "Libre"
        ValueListItem5.DataValue = CType(2, Short)
        ValueListItem5.DisplayText = "Lote"
        ValueListItem6.DataValue = CType(3, Short)
        ValueListItem6.DisplayText = "Serie"
        Me.uos_stock.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem5, ValueListItem6})
        Me.uos_stock.Location = New System.Drawing.Point(16, 13)
        Me.uos_stock.Name = "uos_stock"
        Me.uos_stock.Size = New System.Drawing.Size(153, 21)
        Me.uos_stock.TabIndex = 0
        Me.uos_stock.Text = "Libre"
        '
        'UltraLabel22
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance32
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(23, 203)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel22.TabIndex = 4
        Me.UltraLabel22.Text = "Control Stock "
        '
        'uce_Categoria
        '
        Me.uce_Categoria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Categoria.Location = New System.Drawing.Point(105, 160)
        Me.uce_Categoria.Name = "uce_Categoria"
        Me.uce_Categoria.Size = New System.Drawing.Size(312, 21)
        Me.uce_Categoria.TabIndex = 7
        '
        'uce_Familia
        '
        Me.uce_Familia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Familia.Location = New System.Drawing.Point(105, 133)
        Me.uce_Familia.Name = "uce_Familia"
        Me.uce_Familia.Size = New System.Drawing.Size(186, 21)
        Me.uce_Familia.TabIndex = 6
        '
        'UltraLabel6
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance22
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(42, 164)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel6.TabIndex = 10
        Me.UltraLabel6.Text = "Categoria"
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(54, 137)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel5.TabIndex = 11
        Me.UltraLabel5.Text = "Familia"
        '
        'uce_moneda
        '
        Me.uce_moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "M"
        ValueListItem1.DisplayText = "Mercaderia"
        ValueListItem4.DataValue = "S"
        ValueListItem4.DisplayText = "Servicio"
        Me.uce_moneda.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem4})
        Me.uce_moneda.Location = New System.Drawing.Point(105, 79)
        Me.uce_moneda.Name = "uce_moneda"
        Me.uce_moneda.Size = New System.Drawing.Size(68, 21)
        Me.uce_moneda.TabIndex = 4
        '
        'lbl_des_cta
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.lbl_des_cta.Appearance = Appearance2
        Me.lbl_des_cta.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_des_cta.Location = New System.Drawing.Point(174, 239)
        Me.lbl_des_cta.Name = "lbl_des_cta"
        Me.lbl_des_cta.Size = New System.Drawing.Size(376, 21)
        Me.lbl_des_cta.TabIndex = 10
        Me.lbl_des_cta.Text = "..."
        '
        'uchk_ing_rap
        '
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.uchk_ing_rap.Appearance = Appearance34
        Me.uchk_ing_rap.BackColor = System.Drawing.Color.Transparent
        Me.uchk_ing_rap.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_ing_rap.Location = New System.Drawing.Point(410, 110)
        Me.uchk_ing_rap.Name = "uchk_ing_rap"
        Me.uchk_ing_rap.Size = New System.Drawing.Size(131, 14)
        Me.uchk_ing_rap.TabIndex = 10
        Me.uchk_ing_rap.Text = "Ingreso Rapido"
        '
        'uchk_incluyeIgv
        '
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.uchk_incluyeIgv.Appearance = Appearance10
        Me.uchk_incluyeIgv.BackColor = System.Drawing.Color.Transparent
        Me.uchk_incluyeIgv.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_incluyeIgv.Checked = True
        Me.uchk_incluyeIgv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_incluyeIgv.Location = New System.Drawing.Point(410, 84)
        Me.uchk_incluyeIgv.Name = "uchk_incluyeIgv"
        Me.uchk_incluyeIgv.Size = New System.Drawing.Size(120, 20)
        Me.uchk_incluyeIgv.TabIndex = 11
        Me.uchk_incluyeIgv.Text = "Incluye I.G.V."
        '
        'uce_PrecioVta
        '
        Me.uce_PrecioVta.Location = New System.Drawing.Point(105, 106)
        Me.uce_PrecioVta.Name = "uce_PrecioVta"
        Me.uce_PrecioVta.Size = New System.Drawing.Size(102, 21)
        Me.uce_PrecioVta.TabIndex = 5
        '
        'uos_Estado
        '
        Me.uos_Estado.BackColor = System.Drawing.Color.Transparent
        Me.uos_Estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Estado.CheckedIndex = 0
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Activo"
        ValueListItem3.DataValue = CType(0, Short)
        ValueListItem3.DisplayText = "Inactivo"
        Me.uos_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_Estado.Location = New System.Drawing.Point(372, 203)
        Me.uos_Estado.Name = "uos_Estado"
        Me.uos_Estado.Size = New System.Drawing.Size(169, 21)
        Me.uos_Estado.TabIndex = 9
        Me.uos_Estado.Text = "Activo"
        '
        'uce_tipo
        '
        Me.uce_tipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem8.DataValue = "M"
        ValueListItem8.DisplayText = "Mercaderia"
        ValueListItem9.DataValue = "S"
        ValueListItem9.DisplayText = "Servicio"
        Me.uce_tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem8, ValueListItem9})
        Me.uce_tipo.Location = New System.Drawing.Point(444, 25)
        Me.uce_tipo.Name = "uce_tipo"
        Me.uce_tipo.Size = New System.Drawing.Size(106, 21)
        Me.uce_tipo.TabIndex = 2
        '
        'txt_descripcion
        '
        Me.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion.Location = New System.Drawing.Point(105, 52)
        Me.txt_descripcion.MaxLength = 100
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(445, 21)
        Me.txt_descripcion.TabIndex = 3
        '
        'txt_cta_conta
        '
        Me.txt_cta_conta.Location = New System.Drawing.Point(105, 239)
        Me.txt_cta_conta.MaxLength = 15
        Me.txt_cta_conta.Name = "txt_cta_conta"
        Me.txt_cta_conta.Size = New System.Drawing.Size(68, 21)
        Me.txt_cta_conta.TabIndex = 8
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(105, 25)
        Me.txt_codigo.MaxLength = 10
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(126, 21)
        Me.txt_codigo.TabIndex = 0
        '
        'txt_cod_alt
        '
        Me.txt_cod_alt.Location = New System.Drawing.Point(232, 25)
        Me.txt_cod_alt.MaxLength = 10
        Me.txt_cod_alt.Name = "txt_cod_alt"
        Me.txt_cod_alt.Size = New System.Drawing.Size(126, 21)
        Me.txt_cod_alt.TabIndex = 1
        '
        'UltraLabel9
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance1
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(387, 29)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel9.TabIndex = 0
        Me.UltraLabel9.Text = "Tipo Item"
        '
        'UltraLabel11
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance17
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(353, 111)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel11.TabIndex = 0
        Me.UltraLabel11.Text = "Item"
        '
        'UltraLabel10
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance16
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(353, 87)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel10.TabIndex = 0
        Me.UltraLabel10.Text = "Precio"
        '
        'UltraLabel8
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance11
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(318, 203)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel8.TabIndex = 0
        Me.UltraLabel8.Text = "Estado"
        '
        'UltraLabel7
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance3
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(21, 243)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "Cuenta Conta"
        '
        'UltraLabel4
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(32, 56)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Descripcion"
        '
        'UltraLabel19
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance7
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(50, 86)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel19.TabIndex = 0
        Me.UltraLabel19.Text = "Moneda"
        '
        'UltraLabel3
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance23
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(39, 110)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Precio Vta"
        '
        'UltraLabel2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(250, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Codigo Alterno"
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(55, 29)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Codigo"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(649, 287)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ume_cant_um_compra)
        Me.UltraGroupBox1.Controls.Add(Me.UltraMaskedEdit1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraColorPicker1)
        Me.UltraGroupBox1.Controls.Add(Me.une_stock_min)
        Me.UltraGroupBox1.Controls.Add(Me.txt_des_prove)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idprove)
        Me.UltraGroupBox1.Controls.Add(Me.UltraTextEditor2)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_distri)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_venta)
        Me.UltraGroupBox1.Controls.Add(Me.uce_fabricante)
        Me.UltraGroupBox1.Controls.Add(Me.uce_marca)
        Me.UltraGroupBox1.Controls.Add(Me.uce_pais)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_peso)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_compra)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Ubicaciones)
        Me.UltraGroupBox1.Controls.Add(Me.uce_GrupoArt)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(633, 274)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'ume_cant_um_compra
        '
        Me.ume_cant_um_compra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_cant_um_compra.InputMask = "{double:3.2}"
        Me.ume_cant_um_compra.Location = New System.Drawing.Point(227, 122)
        Me.ume_cant_um_compra.Name = "ume_cant_um_compra"
        Me.ume_cant_um_compra.Size = New System.Drawing.Size(50, 20)
        Me.ume_cant_um_compra.TabIndex = 12
        Me.ume_cant_um_compra.Text = "UltraMaskedEdit1"
        '
        'UltraMaskedEdit1
        '
        Me.UltraMaskedEdit1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.UltraMaskedEdit1.InputMask = "{double:3.2}"
        Me.UltraMaskedEdit1.Location = New System.Drawing.Point(428, 149)
        Me.UltraMaskedEdit1.Name = "UltraMaskedEdit1"
        Me.UltraMaskedEdit1.Size = New System.Drawing.Size(74, 20)
        Me.UltraMaskedEdit1.TabIndex = 12
        Me.UltraMaskedEdit1.Text = "UltraMaskedEdit1"
        '
        'UltraColorPicker1
        '
        Me.UltraColorPicker1.Location = New System.Drawing.Point(428, 122)
        Me.UltraColorPicker1.Name = "UltraColorPicker1"
        Me.UltraColorPicker1.Size = New System.Drawing.Size(190, 21)
        Me.UltraColorPicker1.TabIndex = 11
        Me.UltraColorPicker1.Text = "Control"
        '
        'une_stock_min
        '
        Me.une_stock_min.Location = New System.Drawing.Point(428, 177)
        Me.une_stock_min.MaskInput = "nnnn"
        Me.une_stock_min.Name = "une_stock_min"
        Me.une_stock_min.Size = New System.Drawing.Size(74, 21)
        Me.une_stock_min.TabIndex = 10
        '
        'txt_des_prove
        '
        Me.txt_des_prove.Location = New System.Drawing.Point(170, 10)
        Me.txt_des_prove.MaxLength = 10
        Me.txt_des_prove.Name = "txt_des_prove"
        Me.txt_des_prove.ReadOnly = True
        Me.txt_des_prove.Size = New System.Drawing.Size(446, 21)
        Me.txt_des_prove.TabIndex = 9
        '
        'txt_idprove
        '
        Me.txt_idprove.Location = New System.Drawing.Point(91, 10)
        Me.txt_idprove.MaxLength = 10
        Me.txt_idprove.Name = "txt_idprove"
        Me.txt_idprove.Size = New System.Drawing.Size(79, 21)
        Me.txt_idprove.TabIndex = 9
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Location = New System.Drawing.Point(428, 65)
        Me.UltraTextEditor2.MaxLength = 10
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(190, 21)
        Me.UltraTextEditor2.TabIndex = 9
        '
        'uce_um_distri
        '
        Me.uce_um_distri.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_distri.Location = New System.Drawing.Point(107, 177)
        Me.uce_um_distri.Name = "uce_um_distri"
        Me.uce_um_distri.Size = New System.Drawing.Size(170, 21)
        Me.uce_um_distri.TabIndex = 6
        '
        'uce_um_venta
        '
        Me.uce_um_venta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_venta.Location = New System.Drawing.Point(107, 149)
        Me.uce_um_venta.Name = "uce_um_venta"
        Me.uce_um_venta.Size = New System.Drawing.Size(170, 21)
        Me.uce_um_venta.TabIndex = 6
        '
        'uce_fabricante
        '
        Me.uce_fabricante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_fabricante.Location = New System.Drawing.Point(428, 38)
        Me.uce_fabricante.Name = "uce_fabricante"
        Me.uce_fabricante.Size = New System.Drawing.Size(190, 21)
        Me.uce_fabricante.TabIndex = 6
        '
        'uce_marca
        '
        Me.uce_marca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_marca.Location = New System.Drawing.Point(428, 92)
        Me.uce_marca.Name = "uce_marca"
        Me.uce_marca.Size = New System.Drawing.Size(190, 21)
        Me.uce_marca.TabIndex = 6
        '
        'uce_pais
        '
        Me.uce_pais.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_pais.Location = New System.Drawing.Point(93, 92)
        Me.uce_pais.Name = "uce_pais"
        Me.uce_pais.Size = New System.Drawing.Size(184, 21)
        Me.uce_pais.TabIndex = 6
        '
        'uce_um_peso
        '
        Me.uce_um_peso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_peso.Location = New System.Drawing.Point(502, 149)
        Me.uce_um_peso.Name = "uce_um_peso"
        Me.uce_um_peso.Size = New System.Drawing.Size(116, 21)
        Me.uce_um_peso.TabIndex = 6
        '
        'uce_um_compra
        '
        Me.uce_um_compra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_compra.Location = New System.Drawing.Point(107, 122)
        Me.uce_um_compra.Name = "uce_um_compra"
        Me.uce_um_compra.Size = New System.Drawing.Size(119, 21)
        Me.uce_um_compra.TabIndex = 6
        '
        'uce_Ubicaciones
        '
        Me.uce_Ubicaciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Ubicaciones.Location = New System.Drawing.Point(93, 65)
        Me.uce_Ubicaciones.Name = "uce_Ubicaciones"
        Me.uce_Ubicaciones.Size = New System.Drawing.Size(184, 21)
        Me.uce_Ubicaciones.TabIndex = 6
        '
        'uce_GrupoArt
        '
        Me.uce_GrupoArt.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_GrupoArt.Location = New System.Drawing.Point(93, 38)
        Me.uce_GrupoArt.Name = "uce_GrupoArt"
        Me.uce_GrupoArt.Size = New System.Drawing.Size(184, 21)
        Me.uce_GrupoArt.TabIndex = 6
        '
        'UltraLabel24
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance28
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(26, 96)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel24.TabIndex = 4
        Me.UltraLabel24.Text = "Pais"
        '
        'UltraLabel26
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel26.Appearance = Appearance29
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(323, 184)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel26.TabIndex = 4
        Me.UltraLabel26.Text = "Stock Minimo"
        '
        'UltraLabel23
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance4
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(323, 126)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel23.TabIndex = 4
        Me.UltraLabel23.Text = "Color"
        '
        'UltraLabel18
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance30
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(323, 152)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel18.TabIndex = 4
        Me.UltraLabel18.Text = "Peso"
        '
        'UltraLabel21
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance24
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(27, 180)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel21.TabIndex = 4
        Me.UltraLabel21.Text = "U.M. Distrib."
        '
        'UltraLabel20
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance26
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(27, 152)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel20.TabIndex = 4
        Me.UltraLabel20.Text = "U.M. Venta"
        '
        'UltraLabel17
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance27
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(27, 126)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel17.TabIndex = 4
        Me.UltraLabel17.Text = "U.M. Compra"
        '
        'UltraLabel25
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance31
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(26, 69)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel25.TabIndex = 4
        Me.UltraLabel25.Text = "Ubicacion"
        '
        'UltraLabel16
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance25
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(26, 42)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel16.TabIndex = 4
        Me.UltraLabel16.Text = "Grupo"
        '
        'UltraLabel15
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance18
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(24, 14)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Proveedor"
        '
        'UltraLabel14
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance19
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(323, 94)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel14.TabIndex = 4
        Me.UltraLabel14.Text = "Marca"
        '
        'UltraLabel13
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance20
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(323, 69)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel13.TabIndex = 4
        Me.UltraLabel13.Text = "Modelo"
        '
        'UltraLabel12
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance21
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(323, 42)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel12.TabIndex = 4
        Me.UltraLabel12.Text = "Fabricante"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(688, 25)
        Me.ToolS_Mantenimiento.TabIndex = 7
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'utc_TipoAne
        '
        Me.utc_TipoAne.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_TipoAne.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_TipoAne.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_TipoAne.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_TipoAne.Location = New System.Drawing.Point(4, 33)
        Me.utc_TipoAne.Name = "utc_TipoAne"
        Me.utc_TipoAne.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_TipoAne.Size = New System.Drawing.Size(678, 313)
        Me.utc_TipoAne.TabIndex = 8
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Articulos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_TipoAne.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(674, 287)
        '
        'uchk_noafecto
        '
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.uchk_noafecto.Appearance = Appearance13
        Me.uchk_noafecto.BackColor = System.Drawing.Color.Transparent
        Me.uchk_noafecto.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_noafecto.Location = New System.Drawing.Point(410, 133)
        Me.uchk_noafecto.Name = "uchk_noafecto"
        Me.uchk_noafecto.Size = New System.Drawing.Size(131, 14)
        Me.uchk_noafecto.TabIndex = 15
        Me.uchk_noafecto.Text = "No Afecto al Igv"
        '
        'FA_MA_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 349)
        Me.Controls.Add(Me.utc_TipoAne)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "FA_MA_Articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos / Servicios"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista_Arti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.uos_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Familia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PrecioVta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cta_conta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_alt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_stock_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_des_prove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_distri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_fabricante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_marca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_pais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Ubicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_GrupoArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_TipoAne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_TipoAne.ResumeLayout(False)
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
    Friend WithEvents utc_TipoAne As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_codigo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod_alt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Lista_Arti As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uos_Estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents uce_tipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_descripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cta_conta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PrecioVta As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents uchk_incluyeIgv As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_ing_rap As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_des_cta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_des_prove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idprove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_GrupoArt As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_um_compra As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_stock_min As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uce_um_distri As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_um_venta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraColorPicker1 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents uce_pais As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_um_peso As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Ubicaciones As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Categoria As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Familia As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_fabricante As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_marca As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_cant_um_compra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_stock As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uchk_noafecto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
