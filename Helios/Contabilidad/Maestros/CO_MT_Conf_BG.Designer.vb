<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Conf_BG
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RU_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RU_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RU_CODIGO")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDCUENTA")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_IDCUENTA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_NUM_CUENTA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDCUENTA")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RU_ID")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RU_DESCRIPCION")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RU_CODIGO")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Rubro_or_Cuenta = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.utc_vista = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ubtn_Recargar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Grabar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_CargarCuentas = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_CargarRubros = New Infragistics.Win.Misc.UltraButton
        Me.ut_formatobg = New Infragistics.Win.UltraWinTree.UltraTree
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ubtn_Recargar_BG2010 = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Guardar_BG_2010 = New Infragistics.Win.Misc.UltraButton
        Me.ug_Cuentas10 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ut_formatobg10 = New Infragistics.Win.UltraWinTree.UltraTree
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.uds_Rubros = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.utc_conf_bg = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.ug_Rubro_or_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.utc_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_vista.SuspendLayout()
        CType(Me.ut_formatobg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ug_Cuentas10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ut_formatobg10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Rubros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_conf_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_conf_bg.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.ug_Rubro_or_Cuenta)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(319, 353)
        '
        'ug_Rubro_or_Cuenta
        '
        Me.ug_Rubro_or_Cuenta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Codigo"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 56
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Rubro_or_Cuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Rubro_or_Cuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Rubro_or_Cuenta.Location = New System.Drawing.Point(0, 0)
        Me.ug_Rubro_or_Cuenta.Name = "ug_Rubro_or_Cuenta"
        Me.ug_Rubro_or_Cuenta.Size = New System.Drawing.Size(319, 353)
        Me.ug_Rubro_or_Cuenta.TabIndex = 1
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.ug_Cuentas)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(319, 353)
        '
        'ug_Cuentas
        '
        Me.ug_Cuentas.DataSource = Me.uds_Cuentas
        Me.ug_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Cuenta"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Width = 57
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Descripcion"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Cuentas.Location = New System.Drawing.Point(0, 0)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(319, 353)
        Me.ug_Cuentas.TabIndex = 0
        '
        'uds_Cuentas
        '
        Me.uds_Cuentas.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        Me.uds_Cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.utc_vista)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Recargar)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Grabar)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_CargarCuentas)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_CargarRubros)
        Me.UltraTabPageControl1.Controls.Add(Me.ut_formatobg)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(748, 434)
        '
        'utc_vista
        '
        Me.utc_vista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_vista.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.utc_vista.Controls.Add(Me.UltraTabPageControl5)
        Me.utc_vista.Controls.Add(Me.UltraTabPageControl6)
        Me.utc_vista.Location = New System.Drawing.Point(416, 52)
        Me.utc_vista.Name = "utc_vista"
        Me.utc_vista.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.utc_vista.Size = New System.Drawing.Size(323, 379)
        Me.utc_vista.TabIndex = 6
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "Rubros"
        UltraTab2.TabPage = Me.UltraTabPageControl6
        UltraTab2.Text = "Cuentas Contables"
        Me.utc_vista.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(319, 353)
        '
        'ubtn_Recargar
        '
        Appearance20.Image = Global.Contabilidad.My.Resources.Resources.arrow_refresh
        Me.ubtn_Recargar.Appearance = Appearance20
        Me.ubtn_Recargar.Location = New System.Drawing.Point(416, 23)
        Me.ubtn_Recargar.Name = "ubtn_Recargar"
        Me.ubtn_Recargar.Size = New System.Drawing.Size(26, 23)
        Me.ubtn_Recargar.TabIndex = 5
        '
        'ubtn_Grabar
        '
        Me.ubtn_Grabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance22.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.ubtn_Grabar.Appearance = Appearance22
        Me.ubtn_Grabar.Location = New System.Drawing.Point(664, 21)
        Me.ubtn_Grabar.Name = "ubtn_Grabar"
        Me.ubtn_Grabar.Size = New System.Drawing.Size(75, 26)
        Me.ubtn_Grabar.TabIndex = 4
        Me.ubtn_Grabar.Text = "&Guardar"
        '
        'ubtn_CargarCuentas
        '
        Me.ubtn_CargarCuentas.Location = New System.Drawing.Point(509, 23)
        Me.ubtn_CargarCuentas.Name = "ubtn_CargarCuentas"
        Me.ubtn_CargarCuentas.Size = New System.Drawing.Size(56, 23)
        Me.ubtn_CargarCuentas.TabIndex = 3
        Me.ubtn_CargarCuentas.Text = "Cuentas"
        '
        'ubtn_CargarRubros
        '
        Me.ubtn_CargarRubros.Location = New System.Drawing.Point(447, 23)
        Me.ubtn_CargarRubros.Name = "ubtn_CargarRubros"
        Me.ubtn_CargarRubros.Size = New System.Drawing.Size(56, 23)
        Me.ubtn_CargarRubros.TabIndex = 2
        Me.ubtn_CargarRubros.Text = "Rubros"
        '
        'ut_formatobg
        '
        Me.ut_formatobg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ut_formatobg.DisplayStyle = Infragistics.Win.UltraWinTree.UltraTreeDisplayStyle.WindowsVista
        Me.ut_formatobg.HideSelection = False
        Me.ut_formatobg.Location = New System.Drawing.Point(12, 23)
        Me.ut_formatobg.Name = "ut_formatobg"
        Me.ut_formatobg.NodeConnectorStyle = Infragistics.Win.UltraWinTree.NodeConnectorStyle.Solid
        Me.ut_formatobg.Size = New System.Drawing.Size(362, 408)
        Me.ut_formatobg.TabIndex = 0
        Me.ut_formatobg.ViewStyle = Infragistics.Win.UltraWinTree.ViewStyle.FreeForm
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ubtn_Recargar_BG2010)
        Me.UltraTabPageControl2.Controls.Add(Me.ubtn_Guardar_BG_2010)
        Me.UltraTabPageControl2.Controls.Add(Me.ug_Cuentas10)
        Me.UltraTabPageControl2.Controls.Add(Me.ut_formatobg10)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(748, 434)
        '
        'ubtn_Recargar_BG2010
        '
        Appearance7.Image = Global.Contabilidad.My.Resources.Resources.arrow_refresh
        Me.ubtn_Recargar_BG2010.Appearance = Appearance7
        Me.ubtn_Recargar_BG2010.Location = New System.Drawing.Point(409, 23)
        Me.ubtn_Recargar_BG2010.Name = "ubtn_Recargar_BG2010"
        Me.ubtn_Recargar_BG2010.Size = New System.Drawing.Size(26, 23)
        Me.ubtn_Recargar_BG2010.TabIndex = 7
        '
        'ubtn_Guardar_BG_2010
        '
        Me.ubtn_Guardar_BG_2010.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance21.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.ubtn_Guardar_BG_2010.Appearance = Appearance21
        Me.ubtn_Guardar_BG_2010.Location = New System.Drawing.Point(659, 21)
        Me.ubtn_Guardar_BG_2010.Name = "ubtn_Guardar_BG_2010"
        Me.ubtn_Guardar_BG_2010.Size = New System.Drawing.Size(75, 26)
        Me.ubtn_Guardar_BG_2010.TabIndex = 6
        Me.ubtn_Guardar_BG_2010.Text = "&Guardar"
        '
        'ug_Cuentas10
        '
        Me.ug_Cuentas10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Cuentas10.DataSource = Me.uds_Cuentas
        Me.ug_Cuentas10.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "Cuenta"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 57
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "Descripcion"
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.ug_Cuentas10.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ug_Cuentas10.Location = New System.Drawing.Point(409, 52)
        Me.ug_Cuentas10.Name = "ug_Cuentas10"
        Me.ug_Cuentas10.Size = New System.Drawing.Size(325, 379)
        Me.ug_Cuentas10.TabIndex = 2
        '
        'ut_formatobg10
        '
        Me.ut_formatobg10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ut_formatobg10.DisplayStyle = Infragistics.Win.UltraWinTree.UltraTreeDisplayStyle.WindowsVista
        Me.ut_formatobg10.HideSelection = False
        Me.ut_formatobg10.Location = New System.Drawing.Point(13, 23)
        Me.ut_formatobg10.Name = "ut_formatobg10"
        Me.ut_formatobg10.NodeConnectorStyle = Infragistics.Win.UltraWinTree.NodeConnectorStyle.Solid
        Me.ut_formatobg10.Size = New System.Drawing.Size(360, 408)
        Me.ut_formatobg10.TabIndex = 1
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(748, 434)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(748, 434)
        '
        'uds_Rubros
        '
        Me.uds_Rubros.AllowDelete = False
        Me.uds_Rubros.Band.Columns.AddRange(New Object() {UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'utc_conf_bg
        '
        Me.utc_conf_bg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_conf_bg.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_conf_bg.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_conf_bg.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_conf_bg.Location = New System.Drawing.Point(12, 35)
        Me.utc_conf_bg.Name = "utc_conf_bg"
        Me.utc_conf_bg.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_conf_bg.Size = New System.Drawing.Size(752, 460)
        Me.utc_conf_bg.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Formato Bal. Gral. Extra"
        UltraTab3.Visible = False
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Formato Bal. General"
        Me.utc_conf_bg.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(748, 434)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(776, 25)
        Me.ToolStrip1.TabIndex = 8
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
        'CO_MT_Conf_BG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(776, 507)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.utc_conf_bg)
        Me.Name = "CO_MT_Conf_BG"
        Me.Text = "Configuracion Cuentas de Balance General"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.ug_Rubro_or_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.utc_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_vista.ResumeLayout(False)
        CType(Me.ut_formatobg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ug_Cuentas10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ut_formatobg10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Rubros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_conf_bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_conf_bg.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_conf_bg As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Rubro_or_Cuenta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ut_formatobg As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents ubtn_CargarCuentas As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_CargarRubros As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Grabar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_Rubros As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ubtn_Recargar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents utc_vista As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_Cuentas10 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ut_formatobg10 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents ubtn_Recargar_BG2010 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Guardar_BG_2010 As Infragistics.Win.Misc.UltraButton
End Class
