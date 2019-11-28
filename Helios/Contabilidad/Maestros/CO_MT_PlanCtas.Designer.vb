<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_PlanCtas
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDCUENTA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_IDCUENTA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_NUM_CUENTA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_NUM_CUENTA")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Secuencia")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta_Destino", -1, "udd_PlanCtas1")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DH")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Secuencia")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta_Destino")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DH")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Porcentaje")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_MT_PlanCtas))
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox
        Me.uos_Vista = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.upb_1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.upb_2 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_buscar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ut_Planeta = New Infragistics.Win.UltraWinTree.UltraTree
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_data2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.uchk_Estado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_Auto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.uchk_CC = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox
        Me.ubtn_Grabar_Nuevo = New Infragistics.Win.Misc.UltraButton
        Me.uce_TipoAnexo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_TipoMovi = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Movi = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_ClaseDescri = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_Clase = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Descri = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_NumCta = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_ctas_destino = New Infragistics.Win.Misc.UltraGroupBox
        Me.udd_PlanCtas1 = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.uds_Ayuda_Plan = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Destinos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Destinos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_data3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.upb_Agente = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ubtn_Copiar_Ayo = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_ayo_destino = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Ayo_Origen = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.upb_Paso = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.utc_PlanCtas = New Infragistics.Win.UltraWinTabControl.UltraTabControl
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
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Recargar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        Me.usb1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.uos_Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txt_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ut_Planeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_data2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data2.SuspendLayout()
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoMovi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Movi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ClaseDescri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Clase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumCta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ugb_ctas_destino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_ctas_destino.SuspendLayout()
        CType(Me.udd_PlanCtas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Ayuda_Plan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Destinos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Destinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ugb_data3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data3.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.uce_ayo_destino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Ayo_Origen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_PlanCtas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_PlanCtas.SuspendLayout()
        Me.ToolS_Subdiarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Cuentas)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl1.Controls.Add(Me.ut_Planeta)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(640, 426)
        '
        'ug_Cuentas
        '
        Me.ug_Cuentas.DataSource = Me.uds_Cuentas
        Me.ug_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Cuenta"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Descripcion"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Cuentas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Cuentas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.Color.LightYellow
        Me.ug_Cuentas.DisplayLayout.Override.FilterRowAppearance = Appearance18
        Me.ug_Cuentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Cuentas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance13.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance13.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Cuentas.DisplayLayout.Override.RowAlternateAppearance = Appearance13
        Me.ug_Cuentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Cuentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Cuentas.Location = New System.Drawing.Point(7, 61)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(625, 362)
        Me.ug_Cuentas.TabIndex = 20
        Me.ug_Cuentas.Text = "UltraGrid1"
        Me.ug_Cuentas.Visible = False
        '
        'uds_Cuentas
        '
        Me.uds_Cuentas.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        Me.uds_Cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.uos_Vista)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(363, 5)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(269, 50)
        Me.UltraGroupBox6.TabIndex = 19
        Me.UltraGroupBox6.Text = "Vista"
        '
        'uos_Vista
        '
        Me.uos_Vista.BackColor = System.Drawing.Color.Transparent
        Me.uos_Vista.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Vista.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Vista.CheckedIndex = 0
        ValueListItem2.DataValue = "A"
        ValueListItem2.DisplayText = "Arbol"
        ValueListItem3.DataValue = "G"
        ValueListItem3.DisplayText = "Grilla"
        Me.uos_Vista.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_Vista.ItemSpacingVertical = 2
        Me.uos_Vista.Location = New System.Drawing.Point(28, 20)
        Me.uos_Vista.Name = "uos_Vista"
        Me.uos_Vista.Size = New System.Drawing.Size(150, 23)
        Me.uos_Vista.TabIndex = 0
        Me.uos_Vista.Text = "Arbol"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox5.Controls.Add(Me.upb_1)
        Me.UltraGroupBox5.Controls.Add(Me.upb_2)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(131, 5)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(218, 50)
        Me.UltraGroupBox5.TabIndex = 18
        Me.UltraGroupBox5.Text = "Leyenda"
        '
        'UltraLabel14
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance14
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(144, 25)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel14.TabIndex = 15
        Me.UltraLabel14.Text = "Movimiento"
        '
        'UltraLabel13
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance4
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(45, 25)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel13.TabIndex = 15
        Me.UltraLabel13.Text = "Titulo"
        '
        'upb_1
        '
        Me.upb_1.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_1.Location = New System.Drawing.Point(6, 19)
        Me.upb_1.Name = "upb_1"
        Me.upb_1.Size = New System.Drawing.Size(33, 24)
        Me.upb_1.TabIndex = 14
        '
        'upb_2
        '
        Me.upb_2.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_2.Location = New System.Drawing.Point(105, 19)
        Me.upb_2.Name = "upb_2"
        Me.upb_2.Size = New System.Drawing.Size(33, 24)
        Me.upb_2.TabIndex = 14
        '
        'UltraGroupBox4
        '
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraGroupBox4.Appearance = Appearance17
        Me.UltraGroupBox4.Controls.Add(Me.txt_buscar)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(7, 5)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(118, 50)
        Me.UltraGroupBox4.TabIndex = 17
        Me.UltraGroupBox4.Text = "Buscar : "
        '
        'txt_buscar
        '
        Appearance12.FontData.SizeInPoints = 10.0!
        Me.txt_buscar.Appearance = Appearance12
        Me.txt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar.Location = New System.Drawing.Point(8, 19)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(103, 24)
        Me.txt_buscar.TabIndex = 2
        '
        'ut_Planeta
        '
        Appearance8.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance8.BackColor2 = System.Drawing.Color.AliceBlue
        Appearance8.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.ut_Planeta.Appearance = Appearance8
        Me.ut_Planeta.DisplayStyle = Infragistics.Win.UltraWinTree.UltraTreeDisplayStyle.WindowsVista
        Me.ut_Planeta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ut_Planeta.Location = New System.Drawing.Point(7, 61)
        Me.ut_Planeta.Name = "ut_Planeta"
        Me.ut_Planeta.NodeConnectorStyle = Infragistics.Win.UltraWinTree.NodeConnectorStyle.Solid
        Me.ut_Planeta.Size = New System.Drawing.Size(625, 362)
        Me.ut_Planeta.TabIndex = 13
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data2)
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(640, 426)
        '
        'ugb_data2
        '
        Me.ugb_data2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_data2.Controls.Add(Me.uchk_Estado)
        Me.ugb_data2.Controls.Add(Me.uchk_Auto)
        Me.ugb_data2.Controls.Add(Me.uchk_CC)
        Me.ugb_data2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_data2.Location = New System.Drawing.Point(12, 242)
        Me.ugb_data2.Name = "ugb_data2"
        Me.ugb_data2.Size = New System.Drawing.Size(625, 63)
        Me.ugb_data2.TabIndex = 1
        Me.ugb_data2.Text = "Marcadores"
        '
        'uchk_Estado
        '
        Me.uchk_Estado.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Estado.Checked = True
        Me.uchk_Estado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_Estado.Location = New System.Drawing.Point(305, 35)
        Me.uchk_Estado.Name = "uchk_Estado"
        Me.uchk_Estado.Size = New System.Drawing.Size(115, 20)
        Me.uchk_Estado.TabIndex = 2
        Me.uchk_Estado.Text = "Estado Activo"
        '
        'uchk_Auto
        '
        Me.uchk_Auto.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Auto.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Auto.Location = New System.Drawing.Point(192, 35)
        Me.uchk_Auto.Name = "uchk_Auto"
        Me.uchk_Auto.Size = New System.Drawing.Size(80, 20)
        Me.uchk_Auto.TabIndex = 1
        Me.uchk_Auto.Text = "Automatico"
        '
        'uchk_CC
        '
        Me.uchk_CC.BackColor = System.Drawing.Color.Transparent
        Me.uchk_CC.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_CC.Location = New System.Drawing.Point(49, 35)
        Me.uchk_CC.Name = "uchk_CC"
        Me.uchk_CC.Size = New System.Drawing.Size(117, 20)
        Me.uchk_CC.TabIndex = 0
        Me.uchk_CC.Text = "Centro de Costo"
        '
        'ugb_data
        '
        Me.ugb_data.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_data.Controls.Add(Me.ubtn_Grabar_Nuevo)
        Me.ugb_data.Controls.Add(Me.uce_TipoAnexo)
        Me.ugb_data.Controls.Add(Me.uce_TipoMovi)
        Me.ugb_data.Controls.Add(Me.uce_Movi)
        Me.ugb_data.Controls.Add(Me.UltraLabel6)
        Me.ugb_data.Controls.Add(Me.uce_Moneda)
        Me.ugb_data.Controls.Add(Me.UltraLabel5)
        Me.ugb_data.Controls.Add(Me.txt_ClaseDescri)
        Me.ugb_data.Controls.Add(Me.txt_Clase)
        Me.ugb_data.Controls.Add(Me.UltraLabel3)
        Me.ugb_data.Controls.Add(Me.UltraLabel1)
        Me.ugb_data.Controls.Add(Me.UltraLabel2)
        Me.ugb_data.Controls.Add(Me.txt_Descri)
        Me.ugb_data.Controls.Add(Me.UltraLabel7)
        Me.ugb_data.Controls.Add(Me.txt_NumCta)
        Me.ugb_data.Controls.Add(Me.UltraLabel4)
        Me.ugb_data.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_data.Location = New System.Drawing.Point(12, 12)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(625, 217)
        Me.ugb_data.TabIndex = 0
        Me.ugb_data.Text = "Datos Basico"
        '
        'ubtn_Grabar_Nuevo
        '
        Appearance9.Image = Global.Contabilidad.My.Resources.Resources.checkmark
        Me.ubtn_Grabar_Nuevo.Appearance = Appearance9
        Me.ubtn_Grabar_Nuevo.Location = New System.Drawing.Point(497, 178)
        Me.ubtn_Grabar_Nuevo.Name = "ubtn_Grabar_Nuevo"
        Me.ubtn_Grabar_Nuevo.Size = New System.Drawing.Size(114, 30)
        Me.ubtn_Grabar_Nuevo.TabIndex = 12
        Me.ubtn_Grabar_Nuevo.Text = "Grabar y Nuevo"
        '
        'uce_TipoAnexo
        '
        Me.uce_TipoAnexo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoAnexo.Location = New System.Drawing.Point(387, 103)
        Me.uce_TipoAnexo.Name = "uce_TipoAnexo"
        Me.uce_TipoAnexo.ShowOverflowIndicator = True
        Me.uce_TipoAnexo.Size = New System.Drawing.Size(172, 21)
        Me.uce_TipoAnexo.TabIndex = 3
        '
        'uce_TipoMovi
        '
        Me.uce_TipoMovi.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoMovi.Location = New System.Drawing.Point(123, 178)
        Me.uce_TipoMovi.Name = "uce_TipoMovi"
        Me.uce_TipoMovi.ShowOverflowIndicator = True
        Me.uce_TipoMovi.Size = New System.Drawing.Size(122, 21)
        Me.uce_TipoMovi.TabIndex = 5
        '
        'uce_Movi
        '
        Me.uce_Movi.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Movi.Location = New System.Drawing.Point(123, 151)
        Me.uce_Movi.Name = "uce_Movi"
        Me.uce_Movi.ShowOverflowIndicator = True
        Me.uce_Movi.Size = New System.Drawing.Size(122, 21)
        Me.uce_Movi.TabIndex = 4
        '
        'UltraLabel6
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance3
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(320, 107)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Tipo Anexo"
        '
        'uce_Moneda
        '
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(123, 103)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.ShowOverflowIndicator = True
        Me.uce_Moneda.Size = New System.Drawing.Size(122, 21)
        Me.uce_Moneda.TabIndex = 2
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(33, 182)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel5.TabIndex = 11
        Me.UltraLabel5.Text = "Tipo Mov."
        '
        'txt_ClaseDescri
        '
        Me.txt_ClaseDescri.Location = New System.Drawing.Point(328, 35)
        Me.txt_ClaseDescri.MaxLength = 200
        Me.txt_ClaseDescri.Name = "txt_ClaseDescri"
        Me.txt_ClaseDescri.ReadOnly = True
        Me.txt_ClaseDescri.Size = New System.Drawing.Size(283, 21)
        Me.txt_ClaseDescri.TabIndex = 10
        '
        'txt_Clase
        '
        Me.txt_Clase.Location = New System.Drawing.Point(305, 35)
        Me.txt_Clase.MaxLength = 2
        Me.txt_Clase.Name = "txt_Clase"
        Me.txt_Clase.ReadOnly = True
        Me.txt_Clase.Size = New System.Drawing.Size(21, 21)
        Me.txt_Clase.TabIndex = 10
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(33, 155)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel3.TabIndex = 11
        Me.UltraLabel3.Text = "Movimiento"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(260, 39)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Clase"
        '
        'UltraLabel2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance10
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(33, 107)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel2.TabIndex = 11
        Me.UltraLabel2.Text = "Moneda"
        '
        'txt_Descri
        '
        Me.txt_Descri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descri.Location = New System.Drawing.Point(123, 62)
        Me.txt_Descri.MaxLength = 100
        Me.txt_Descri.Name = "txt_Descri"
        Me.txt_Descri.Size = New System.Drawing.Size(488, 21)
        Me.txt_Descri.TabIndex = 1
        '
        'UltraLabel7
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance15
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(33, 66)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel7.TabIndex = 11
        Me.UltraLabel7.Text = "Descripcion"
        '
        'txt_NumCta
        '
        Me.txt_NumCta.Location = New System.Drawing.Point(123, 35)
        Me.txt_NumCta.MaxLength = 20
        Me.txt_NumCta.Name = "txt_NumCta"
        Me.txt_NumCta.Size = New System.Drawing.Size(97, 21)
        Me.txt_NumCta.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance23
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(33, 39)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel4.TabIndex = 11
        Me.UltraLabel4.Text = "Numero Cuenta"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_ctas_destino)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(640, 426)
        '
        'ugb_ctas_destino
        '
        Me.ugb_ctas_destino.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Near
        Me.ugb_ctas_destino.Controls.Add(Me.udd_PlanCtas1)
        Me.ugb_ctas_destino.Controls.Add(Me.ug_Destinos)
        Me.ugb_ctas_destino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_ctas_destino.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_ctas_destino.Location = New System.Drawing.Point(0, 0)
        Me.ugb_ctas_destino.Name = "ugb_ctas_destino"
        Me.ugb_ctas_destino.Size = New System.Drawing.Size(640, 426)
        Me.ugb_ctas_destino.TabIndex = 0
        Me.ugb_ctas_destino.Text = "Cuentas Destino de la Cta : "
        '
        'udd_PlanCtas1
        '
        Me.udd_PlanCtas1.DataSource = Me.uds_Ayuda_Plan
        Me.udd_PlanCtas1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Numero Cuenta"
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "Descripcion"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5})
        UltraGridBand2.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        Me.udd_PlanCtas1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udd_PlanCtas1.DisplayLayout.GroupByBox.Hidden = True
        Me.udd_PlanCtas1.DisplayLayout.MaxColScrollRegions = 1
        Me.udd_PlanCtas1.DisplayLayout.MaxRowScrollRegions = 1
        Me.udd_PlanCtas1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udd_PlanCtas1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udd_PlanCtas1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.udd_PlanCtas1.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.AppearancesOnly
        Me.udd_PlanCtas1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udd_PlanCtas1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udd_PlanCtas1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udd_PlanCtas1.Location = New System.Drawing.Point(22, 130)
        Me.udd_PlanCtas1.Name = "udd_PlanCtas1"
        Me.udd_PlanCtas1.Size = New System.Drawing.Size(452, 173)
        Me.udd_PlanCtas1.TabIndex = 1
        Me.udd_PlanCtas1.Visible = False
        '
        'uds_Ayuda_Plan
        '
        Me.uds_Ayuda_Plan.AllowAdd = False
        Me.uds_Ayuda_Plan.AllowDelete = False
        Me.uds_Ayuda_Plan.Band.Columns.AddRange(New Object() {UltraDataColumn4, UltraDataColumn5})
        '
        'ug_Destinos
        '
        Me.ug_Destinos.DataSource = Me.uds_Destinos
        Me.ug_Destinos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 61
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "Cuenta Destino"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.ug_Destinos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ug_Destinos.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_Destinos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Destinos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Destinos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_Destinos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Destinos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_Destinos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_Destinos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Destinos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Destinos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Destinos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_Destinos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Destinos.Location = New System.Drawing.Point(3, 21)
        Me.ug_Destinos.Name = "ug_Destinos"
        Me.ug_Destinos.Size = New System.Drawing.Size(634, 402)
        Me.ug_Destinos.TabIndex = 0
        '
        'uds_Destinos
        '
        UltraDataColumn6.DataType = GetType(Short)
        UltraDataColumn9.DataType = GetType(Double)
        Me.uds_Destinos.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ugb_data3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(640, 426)
        '
        'ugb_data3
        '
        Me.ugb_data3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_data3.Controls.Add(Me.UltraGroupBox3)
        Me.ugb_data3.Controls.Add(Me.UltraGroupBox2)
        Me.ugb_data3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_data3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_data3.Location = New System.Drawing.Point(0, 0)
        Me.ugb_data3.Name = "ugb_data3"
        Me.ugb_data3.Size = New System.Drawing.Size(640, 426)
        Me.ugb_data3.TabIndex = 0
        Me.ugb_data3.Text = "Copiar Plan de Cuentas..."
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox3.Controls.Add(Me.upb_Agente)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(22, 39)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(602, 166)
        Me.UltraGroupBox3.TabIndex = 17
        '
        'UltraLabel10
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextHAlignAsString = "Left"
        Me.UltraLabel10.Appearance = Appearance26
        Me.UltraLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraLabel10.Location = New System.Drawing.Point(112, 18)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(490, 42)
        Me.UltraLabel10.TabIndex = 15
        Me.UltraLabel10.Text = "Seleccione el año origen, este año sera tomado como referencia para ser copiado, " & _
            "luego seleccione el año destino, el sistema realizara la siguiente tarea :"
        '
        'UltraLabel11
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextHAlignAsString = "Left"
        Me.UltraLabel11.Appearance = Appearance25
        Me.UltraLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraLabel11.Location = New System.Drawing.Point(112, 69)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(490, 91)
        Me.UltraLabel11.TabIndex = 15
        Me.UltraLabel11.Text = resources.GetString("UltraLabel11.Text")
        '
        'upb_Agente
        '
        Me.upb_Agente.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Agente.Image = CType(resources.GetObject("upb_Agente.Image"), Object)
        Me.upb_Agente.Location = New System.Drawing.Point(18, 16)
        Me.upb_Agente.Name = "upb_Agente"
        Me.upb_Agente.Size = New System.Drawing.Size(88, 141)
        Me.upb_Agente.TabIndex = 14
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.ubtn_Copiar_Ayo)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox2.Controls.Add(Me.uce_ayo_destino)
        Me.UltraGroupBox2.Controls.Add(Me.uce_Ayo_Origen)
        Me.UltraGroupBox2.Controls.Add(Me.upb_Paso)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(21, 211)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(603, 88)
        Me.UltraGroupBox2.TabIndex = 16
        '
        'ubtn_Copiar_Ayo
        '
        Appearance27.Image = Global.Contabilidad.My.Resources.Resources._16__Copy_plus_
        Me.ubtn_Copiar_Ayo.Appearance = Appearance27
        Me.ubtn_Copiar_Ayo.Location = New System.Drawing.Point(481, 20)
        Me.ubtn_Copiar_Ayo.Name = "ubtn_Copiar_Ayo"
        Me.ubtn_Copiar_Ayo.Size = New System.Drawing.Size(107, 56)
        Me.ubtn_Copiar_Ayo.TabIndex = 13
        Me.ubtn_Copiar_Ayo.Text = "Copiar Plan"
        '
        'UltraLabel9
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance30
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(301, 20)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(81, 17)
        Me.UltraLabel9.TabIndex = 12
        Me.UltraLabel9.Text = "Año Destino"
        '
        'UltraLabel8
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance24
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(41, 20)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(75, 17)
        Me.UltraLabel8.TabIndex = 12
        Me.UltraLabel8.Text = "Año Origen"
        '
        'uce_ayo_destino
        '
        Me.uce_ayo_destino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_ayo_destino.Location = New System.Drawing.Point(301, 40)
        Me.uce_ayo_destino.Name = "uce_ayo_destino"
        Me.uce_ayo_destino.Size = New System.Drawing.Size(144, 21)
        Me.uce_ayo_destino.TabIndex = 1
        '
        'uce_Ayo_Origen
        '
        Me.uce_Ayo_Origen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Ayo_Origen.Location = New System.Drawing.Point(41, 40)
        Me.uce_Ayo_Origen.Name = "uce_Ayo_Origen"
        Me.uce_Ayo_Origen.Size = New System.Drawing.Size(144, 21)
        Me.uce_Ayo_Origen.TabIndex = 1
        '
        'upb_Paso
        '
        Me.upb_Paso.AutoSize = True
        Me.upb_Paso.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Paso.Image = CType(resources.GetObject("upb_Paso.Image"), Object)
        Me.upb_Paso.Location = New System.Drawing.Point(225, 29)
        Me.upb_Paso.Name = "upb_Paso"
        Me.upb_Paso.Size = New System.Drawing.Size(32, 32)
        Me.upb_Paso.TabIndex = 0
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(687, 503)
        '
        'utc_PlanCtas
        '
        Me.utc_PlanCtas.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_PlanCtas.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_PlanCtas.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_PlanCtas.Controls.Add(Me.UltraTabPageControl3)
        Me.utc_PlanCtas.Controls.Add(Me.UltraTabPageControl4)
        Me.utc_PlanCtas.Location = New System.Drawing.Point(4, 30)
        Me.utc_PlanCtas.Name = "utc_PlanCtas"
        Me.utc_PlanCtas.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_PlanCtas.Size = New System.Drawing.Size(644, 452)
        Me.utc_PlanCtas.TabIndex = 0
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        UltraTab1.Appearance = Appearance1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Cuentas"
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Pencil_tool_
        UltraTab2.Appearance = Appearance2
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Cuentas"
        Appearance16.Image = Global.Contabilidad.My.Resources.Resources._16__Bullets_and_numbering_
        UltraTab3.Appearance = Appearance16
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = " Cuentas Destinos "
        Appearance35.Image = Global.Contabilidad.My.Resources.Resources._16__Hammer_
        UltraTab4.Appearance = Appearance35
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Utilidades"
        Me.utc_PlanCtas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(640, 426)
        '
        'ToolS_Subdiarios
        '
        Me.ToolS_Subdiarios.BackColor = System.Drawing.Color.White
        Me.ToolS_Subdiarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.ToolStripSeparator8, Me.Tool_Recargar, Me.ToolStripSeparator6, Me.Tool_imprimir, Me.ToolStripSeparator7, Me.Tool_Salir})
        Me.ToolS_Subdiarios.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Subdiarios.Name = "ToolS_Subdiarios"
        Me.ToolS_Subdiarios.Size = New System.Drawing.Size(658, 25)
        Me.ToolS_Subdiarios.TabIndex = 2
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Recargar
        '
        Me.Tool_Recargar.Image = Global.Contabilidad.My.Resources.Resources._726
        Me.Tool_Recargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Recargar.Name = "Tool_Recargar"
        Me.Tool_Recargar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Recargar.Text = "Recargar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'usb1
        '
        Me.usb1.Location = New System.Drawing.Point(0, 484)
        Me.usb1.Name = "usb1"
        UltraStatusPanel1.Key = "numero"
        UltraStatusPanel1.Text = "Num de Cuentas :"
        UltraStatusPanel1.Width = 140
        UltraStatusPanel2.Key = "barra"
        UltraStatusPanel2.MarqueeInfo.MarqueeStyle = Infragistics.Win.UltraWinStatusBar.MarqueeStyle.Sliding
        UltraStatusPanel2.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Progress
        UltraStatusPanel2.Width = 500
        Me.usb1.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2})
        Me.usb1.Size = New System.Drawing.Size(658, 27)
        Me.usb1.TabIndex = 3
        Me.usb1.Text = "UltraStatusBar1"
        '
        'CO_MT_PlanCtas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(658, 511)
        Me.Controls.Add(Me.usb1)
        Me.Controls.Add(Me.ToolS_Subdiarios)
        Me.Controls.Add(Me.utc_PlanCtas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_PlanCtas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Plan de Cuentas"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.uos_Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.txt_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ut_Planeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_data2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data2.ResumeLayout(False)
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        Me.ugb_data.PerformLayout()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoMovi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Movi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ClaseDescri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Clase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumCta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ugb_ctas_destino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_ctas_destino.ResumeLayout(False)
        CType(Me.udd_PlanCtas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Ayuda_Plan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Destinos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Destinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ugb_data3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data3.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.uce_ayo_destino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Ayo_Origen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_PlanCtas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_PlanCtas.ResumeLayout(False)
        Me.ToolS_Subdiarios.ResumeLayout(False)
        Me.ToolS_Subdiarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_PlanCtas As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ToolS_Subdiarios As System.Windows.Forms.ToolStrip
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
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_NumCta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Clase As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoAnexo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_TipoMovi As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Movi As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descri As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_data2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_ClaseDescri As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_CC As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Estado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Auto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_ctas_destino As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_Destinos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Destinos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udd_PlanCtas1 As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents uds_Ayuda_Plan As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_data3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_Ayo_Origen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents upb_Paso As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents upb_Agente As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents ubtn_Copiar_Ayo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_ayo_destino As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_buscar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ut_Planeta As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents upb_2 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents upb_1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents usb1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents Tool_Recargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ubtn_Grabar_Nuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uos_Vista As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
