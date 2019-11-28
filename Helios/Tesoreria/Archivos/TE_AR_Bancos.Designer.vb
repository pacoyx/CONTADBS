<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TE_AR_Bancos
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_NOMBRE")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BA_RUC")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_NOMBRE")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BA_RUC")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_IDBANCO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_ID_CTA")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NUMERO_CTA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_DESCRIPCION")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_FECHA_APERTURA")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_FORMATO_CHEQUE")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_IDBANCO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_ID_CTA")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_NUMERO_CTA")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_DESCRIPCION")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_FECHA_APERTURA")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_FORMATO_CHEQUE")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.utc_ListaBancos = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.uds_ListaBancos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_listaBancos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tool_CtaCorrientes = New System.Windows.Forms.ToolStripButton
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        Me.uds_CtasCorri = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lbl_NombreBancos = New Infragistics.Win.Misc.UltraLabel
        Me.ubt_Regresar = New Infragistics.Win.Misc.UltraButton
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_ListaBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_ListaBancos.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.uds_ListaBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_listaBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_CtasCorri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_CtaCorrientes, Me.ToolStripSeparator1, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(805, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'utc_ListaBancos
        '
        Me.utc_ListaBancos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_ListaBancos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_ListaBancos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_ListaBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utc_ListaBancos.Location = New System.Drawing.Point(0, 25)
        Me.utc_ListaBancos.Name = "utc_ListaBancos"
        Me.utc_ListaBancos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_ListaBancos.Size = New System.Drawing.Size(805, 344)
        Me.utc_ListaBancos.TabIndex = 9
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Lista de Bancos"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Cuentas Corrientes"
        Me.utc_ListaBancos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(801, 318)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_listaBancos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(801, 318)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ubt_Regresar)
        Me.UltraTabPageControl2.Controls.Add(Me.lbl_NombreBancos)
        Me.UltraTabPageControl2.Controls.Add(Me.ug_Cuentas)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(801, 318)
        '
        'uds_ListaBancos
        '
        Me.uds_ListaBancos.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_ListaBancos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'ug_listaBancos
        '
        Me.ug_listaBancos.DataSource = Me.uds_ListaBancos
        Appearance16.BackColor = System.Drawing.Color.White
        Me.ug_listaBancos.DisplayLayout.Appearance = Appearance16
        Me.ug_listaBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
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
        Me.ug_listaBancos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_listaBancos.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_listaBancos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_listaBancos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.ug_listaBancos.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Me.ug_listaBancos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_listaBancos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.FontData.Name = "Arial"
        Appearance19.FontData.SizeInPoints = 10.0!
        Appearance19.ForeColor = System.Drawing.Color.White
        Appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_listaBancos.DisplayLayout.Override.HeaderAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance20.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_listaBancos.DisplayLayout.Override.RowAlternateAppearance = Appearance20
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_listaBancos.DisplayLayout.Override.RowSelectorAppearance = Appearance9
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance27.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_listaBancos.DisplayLayout.Override.SelectedRowAppearance = Appearance27
        Me.ug_listaBancos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_listaBancos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_listaBancos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_listaBancos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_listaBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_listaBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_listaBancos.Location = New System.Drawing.Point(0, 0)
        Me.ug_listaBancos.Name = "ug_listaBancos"
        Me.ug_listaBancos.Size = New System.Drawing.Size(801, 318)
        Me.ug_listaBancos.TabIndex = 1
        '
        'Tool_CtaCorrientes
        '
        Me.Tool_CtaCorrientes.Image = Global.Contabilidad.My.Resources.Resources._16__Page_number_1
        Me.Tool_CtaCorrientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_CtaCorrientes.Name = "Tool_CtaCorrientes"
        Me.Tool_CtaCorrientes.Size = New System.Drawing.Size(120, 22)
        Me.Tool_CtaCorrientes.Text = "Cuentas Corrientes"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'uds_CtasCorri
        '
        Me.uds_CtasCorri.AllowDelete = False
        UltraDataColumn5.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn9.DataType = GetType(Date)
        Me.uds_CtasCorri.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'ug_Cuentas
        '
        Me.ug_Cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Cuentas.DataSource = Me.uds_CtasCorri
        Appearance21.BackColor = System.Drawing.Color.White
        Me.ug_Cuentas.DisplayLayout.Appearance = Appearance21
        Me.ug_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "Num. Cuenta"
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Width = 126
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "Descripcion"
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Width = 352
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.Caption = "Fecha Apertura"
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.Caption = "Formato Cheque"
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Cuentas.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_Cuentas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.ug_Cuentas.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Me.ug_Cuentas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_Cuentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.FontData.BoldAsString = "True"
        Appearance23.FontData.Name = "Arial"
        Appearance23.FontData.SizeInPoints = 10.0!
        Appearance23.ForeColor = System.Drawing.Color.White
        Appearance23.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_Cuentas.DisplayLayout.Override.HeaderAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance24.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Cuentas.DisplayLayout.Override.RowAlternateAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance25.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_Cuentas.DisplayLayout.Override.RowSelectorAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_Cuentas.DisplayLayout.Override.SelectedRowAppearance = Appearance26
        Me.ug_Cuentas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Cuentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Cuentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Cuentas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Cuentas.Location = New System.Drawing.Point(8, 38)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(790, 270)
        Me.ug_Cuentas.TabIndex = 1
        '
        'lbl_NombreBancos
        '
        Appearance1.FontData.SizeInPoints = 10.0!
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_NombreBancos.Appearance = Appearance1
        Me.lbl_NombreBancos.Location = New System.Drawing.Point(11, 9)
        Me.lbl_NombreBancos.Name = "lbl_NombreBancos"
        Me.lbl_NombreBancos.Size = New System.Drawing.Size(316, 23)
        Me.lbl_NombreBancos.TabIndex = 2
        Me.lbl_NombreBancos.Text = "UltraLabel1"
        '
        'ubt_Regresar
        '
        Me.ubt_Regresar.Location = New System.Drawing.Point(631, 9)
        Me.ubt_Regresar.Name = "ubt_Regresar"
        Me.ubt_Regresar.Size = New System.Drawing.Size(161, 23)
        Me.ubt_Regresar.TabIndex = 3
        Me.ubt_Regresar.Text = "Regresar"
        '
        'TE_AR_Bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(805, 369)
        Me.Controls.Add(Me.utc_ListaBancos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "TE_AR_Bancos"
        Me.Text = "Listado de Bancos"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_ListaBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_ListaBancos.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.uds_ListaBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_listaBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_CtasCorri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_CtaCorrientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utc_ListaBancos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_ListaBancos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_listaBancos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_CtasCorri As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lbl_NombreBancos As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubt_Regresar As Infragistics.Win.Misc.UltraButton
End Class
