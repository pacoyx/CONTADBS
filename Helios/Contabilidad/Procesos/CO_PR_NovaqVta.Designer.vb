<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_NovaqVta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONTA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DOCUMENT_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUMBER_SERIE")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUMBER_DOCUMENT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DOCUMENT_DATE", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CADUCATE_DATE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CUSTOMER_ID")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AMOUNT")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SELL_RATE")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CURRENCY_ID")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMMENT")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AMOUNT_TAX")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STATUS")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CUSTOMER_NAME")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CONTA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DOCUMENT_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUMBER_SERIE")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUMBER_DOCUMENT")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DOCUMENT_DATE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CADUCATE_DATE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CUSTOMER_ID")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AMOUNT")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SELL_RATE")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CURRENCY_ID")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COMMENT")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AMOUNT_TAX")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("STATUS")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CUSTOMER_NAME")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lbl_num_fac = New Infragistics.Win.Misc.UltraLabel
        Me.ug_cab = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_cab = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ugb_periodo = New Infragistics.Win.Misc.UltraGroupBox
        Me.ubtn_VerFac = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ubtn_Contabilizar = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_Caja = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_des_cuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_num_cta = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_SubDiario = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_cta40_dol = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_cta_12Rel_dol = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_cta12_dol = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.uchk_Gen_asi_caja = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ugb_Cuentas = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_cta40 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_cta12Rel = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_cta12 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_cab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_cab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_periodo.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Caja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Caja.SuspendLayout()
        CType(Me.txt_des_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_cta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_SubDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_cta40_dol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cta_12Rel_dol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cta12_dol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Cuentas.SuspendLayout()
        CType(Me.txt_cta40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cta12Rel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cta12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.lbl_num_fac)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_cab)
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_periodo)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(817, 369)
        '
        'lbl_num_fac
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.lbl_num_fac.Appearance = Appearance10
        Me.lbl_num_fac.AutoSize = True
        Me.lbl_num_fac.Location = New System.Drawing.Point(15, 350)
        Me.lbl_num_fac.Name = "lbl_num_fac"
        Me.lbl_num_fac.Size = New System.Drawing.Size(14, 14)
        Me.lbl_num_fac.TabIndex = 201
        Me.lbl_num_fac.Text = "..."
        '
        'ug_cab
        '
        Me.ug_cab.DataSource = Me.uds_cab
        Me.ug_cab.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 36
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Doc."
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 35
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Serie"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 43
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Numero"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 75
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Fec. Emi."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 79
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Fec. Venc."
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 81
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Ruc Cliente"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 88
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance12
        UltraGridColumn8.Header.Caption = "Importe"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 58
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance13
        UltraGridColumn9.Header.Caption = "T.C."
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 39
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Mon."
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Width = 42
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "Glosa"
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance14
        UltraGridColumn12.Header.Caption = "Igv"
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 54
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Estado"
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Width = 46
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.ug_cab.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_cab.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_cab.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_cab.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_cab.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance18.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance18.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_cab.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Me.ug_cab.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_cab.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_cab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_cab.Location = New System.Drawing.Point(3, 67)
        Me.ug_cab.Name = "ug_cab"
        Me.ug_cab.Size = New System.Drawing.Size(811, 277)
        Me.ug_cab.TabIndex = 202
        Me.ug_cab.Text = "UltraGrid1"
        '
        'uds_cab
        '
        Me.uds_cab.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn12.DefaultValue = 0
        Me.uds_cab.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'ugb_periodo
        '
        Me.ugb_periodo.Controls.Add(Me.ubtn_VerFac)
        Me.ugb_periodo.Controls.Add(Me.UltraLabel4)
        Me.ugb_periodo.Controls.Add(Me.uce_Mes)
        Me.ugb_periodo.Controls.Add(Me.UltraLabel2)
        Me.ugb_periodo.Controls.Add(Me.txt_Ayo)
        Me.ugb_periodo.Controls.Add(Me.ubtn_Contabilizar)
        Me.ugb_periodo.Location = New System.Drawing.Point(3, 3)
        Me.ugb_periodo.Name = "ugb_periodo"
        Me.ugb_periodo.Size = New System.Drawing.Size(811, 58)
        Me.ugb_periodo.TabIndex = 201
        '
        'ubtn_VerFac
        '
        Appearance5.Image = Global.Contabilidad.My.Resources.Resources._16__Print_preview_
        Me.ubtn_VerFac.Appearance = Appearance5
        Me.ubtn_VerFac.Location = New System.Drawing.Point(298, 18)
        Me.ubtn_VerFac.Name = "ubtn_VerFac"
        Me.ubtn_VerFac.Size = New System.Drawing.Size(101, 29)
        Me.ubtn_VerFac.TabIndex = 200
        Me.ubtn_VerFac.Text = "Ver Facturas"
        '
        'UltraLabel4
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(122, 25)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 199
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(160, 21)
        Me.uce_Mes.MaxDropDownItems = 12
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(123, 21)
        Me.uce_Mes.TabIndex = 198
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 25)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel2.TabIndex = 197
        Me.UltraLabel2.Text = "Año :"
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(50, 21)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(62, 21)
        Me.txt_Ayo.TabIndex = 196
        '
        'ubtn_Contabilizar
        '
        Appearance4.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.ubtn_Contabilizar.Appearance = Appearance4
        Me.ubtn_Contabilizar.Location = New System.Drawing.Point(405, 18)
        Me.ubtn_Contabilizar.Name = "ubtn_Contabilizar"
        Me.ubtn_Contabilizar.Size = New System.Drawing.Size(84, 29)
        Me.ubtn_Contabilizar.TabIndex = 0
        Me.ubtn_Contabilizar.Text = "Procesar"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Caja)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Controls.Add(Me.uchk_Gen_asi_caja)
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Cuentas)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(817, 369)
        '
        'ugb_Caja
        '
        Me.ugb_Caja.Controls.Add(Me.UltraLabel12)
        Me.ugb_Caja.Controls.Add(Me.txt_des_cuenta)
        Me.ugb_Caja.Controls.Add(Me.txt_num_cta)
        Me.ugb_Caja.Controls.Add(Me.UltraLabel22)
        Me.ugb_Caja.Controls.Add(Me.uce_SubDiario)
        Me.ugb_Caja.Controls.Add(Me.UltraLabel11)
        Me.ugb_Caja.Location = New System.Drawing.Point(23, 177)
        Me.ugb_Caja.Name = "ugb_Caja"
        Me.ugb_Caja.Size = New System.Drawing.Size(639, 129)
        Me.ugb_Caja.TabIndex = 202
        Me.ugb_Caja.Text = "Asiento Caja"
        '
        'UltraLabel12
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance3
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(20, 109)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(512, 14)
        Me.UltraLabel12.TabIndex = 204
        Me.UltraLabel12.Text = "* SOLO SE REALIZARA EL ASIENTO DE LAS CUENTAS DE CLIENTES RELACIONADAS 13XXXX"
        '
        'txt_des_cuenta
        '
        Me.txt_des_cuenta.Location = New System.Drawing.Point(260, 59)
        Me.txt_des_cuenta.Name = "txt_des_cuenta"
        Me.txt_des_cuenta.Size = New System.Drawing.Size(193, 21)
        Me.txt_des_cuenta.TabIndex = 203
        '
        'txt_num_cta
        '
        Me.txt_num_cta.Location = New System.Drawing.Point(178, 59)
        Me.txt_num_cta.Name = "txt_num_cta"
        Me.txt_num_cta.Size = New System.Drawing.Size(76, 21)
        Me.txt_num_cta.TabIndex = 201
        '
        'UltraLabel22
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance26
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(20, 63)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(155, 14)
        Me.UltraLabel22.TabIndex = 202
        Me.UltraLabel22.Text = "Cuenta Contable Cancelacion"
        '
        'uce_SubDiario
        '
        Me.uce_SubDiario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_SubDiario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_SubDiario.Location = New System.Drawing.Point(178, 32)
        Me.uce_SubDiario.Name = "uce_SubDiario"
        Me.uce_SubDiario.Size = New System.Drawing.Size(275, 21)
        Me.uce_SubDiario.TabIndex = 200
        '
        'UltraLabel11
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance7
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(20, 36)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(124, 14)
        Me.UltraLabel11.TabIndex = 199
        Me.UltraLabel11.Text = "Subdiario  Cancelacion:"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_cta40_dol)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cta_12Rel_dol)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cta12_dol)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(350, 13)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(312, 122)
        Me.UltraGroupBox1.TabIndex = 201
        Me.UltraGroupBox1.Text = "Cuentas Dolares"
        '
        'txt_cta40_dol
        '
        Me.txt_cta40_dol.Location = New System.Drawing.Point(141, 82)
        Me.txt_cta40_dol.Name = "txt_cta40_dol"
        Me.txt_cta40_dol.Size = New System.Drawing.Size(145, 21)
        Me.txt_cta40_dol.TabIndex = 199
        '
        'txt_cta_12Rel_dol
        '
        Me.txt_cta_12Rel_dol.Location = New System.Drawing.Point(141, 56)
        Me.txt_cta_12Rel_dol.Name = "txt_cta_12Rel_dol"
        Me.txt_cta_12Rel_dol.Size = New System.Drawing.Size(145, 21)
        Me.txt_cta_12Rel_dol.TabIndex = 199
        '
        'txt_cta12_dol
        '
        Me.txt_cta12_dol.Location = New System.Drawing.Point(141, 29)
        Me.txt_cta12_dol.Name = "txt_cta12_dol"
        Me.txt_cta12_dol.Size = New System.Drawing.Size(145, 21)
        Me.txt_cta12_dol.TabIndex = 199
        '
        'UltraLabel6
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance11
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(25, 86)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel6.TabIndex = 198
        Me.UltraLabel6.Text = "Cuenta IGV.:"
        '
        'UltraLabel7
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance2
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(24, 60)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(111, 14)
        Me.UltraLabel7.TabIndex = 198
        Me.UltraLabel7.Text = "Cuenta Clientes Rel.:"
        '
        'UltraLabel8
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance25
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(25, 33)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel8.TabIndex = 198
        Me.UltraLabel8.Text = "Cuenta Clientes :"
        '
        'uchk_Gen_asi_caja
        '
        Me.uchk_Gen_asi_caja.Location = New System.Drawing.Point(23, 151)
        Me.uchk_Gen_asi_caja.Name = "uchk_Gen_asi_caja"
        Me.uchk_Gen_asi_caja.Size = New System.Drawing.Size(206, 20)
        Me.uchk_Gen_asi_caja.TabIndex = 0
        Me.uchk_Gen_asi_caja.Text = "Generar Asiento de Cancelacion"
        '
        'ugb_Cuentas
        '
        Me.ugb_Cuentas.Controls.Add(Me.txt_cta40)
        Me.ugb_Cuentas.Controls.Add(Me.txt_cta12Rel)
        Me.ugb_Cuentas.Controls.Add(Me.txt_cta12)
        Me.ugb_Cuentas.Controls.Add(Me.UltraLabel5)
        Me.ugb_Cuentas.Controls.Add(Me.UltraLabel3)
        Me.ugb_Cuentas.Controls.Add(Me.UltraLabel1)
        Me.ugb_Cuentas.Location = New System.Drawing.Point(23, 13)
        Me.ugb_Cuentas.Name = "ugb_Cuentas"
        Me.ugb_Cuentas.Size = New System.Drawing.Size(312, 122)
        Me.ugb_Cuentas.TabIndex = 200
        Me.ugb_Cuentas.Text = "Cuentas Soles"
        '
        'txt_cta40
        '
        Me.txt_cta40.Location = New System.Drawing.Point(141, 82)
        Me.txt_cta40.Name = "txt_cta40"
        Me.txt_cta40.Size = New System.Drawing.Size(145, 21)
        Me.txt_cta40.TabIndex = 199
        '
        'txt_cta12Rel
        '
        Me.txt_cta12Rel.Location = New System.Drawing.Point(141, 56)
        Me.txt_cta12Rel.Name = "txt_cta12Rel"
        Me.txt_cta12Rel.Size = New System.Drawing.Size(145, 21)
        Me.txt_cta12Rel.TabIndex = 199
        '
        'txt_cta12
        '
        Me.txt_cta12.Location = New System.Drawing.Point(141, 29)
        Me.txt_cta12.Name = "txt_cta12"
        Me.txt_cta12.Size = New System.Drawing.Size(145, 21)
        Me.txt_cta12.TabIndex = 199
        '
        'UltraLabel5
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance24
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(25, 86)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel5.TabIndex = 198
        Me.UltraLabel5.Text = "Cuenta IGV.:"
        '
        'UltraLabel3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance8
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(24, 60)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(111, 14)
        Me.UltraLabel3.TabIndex = 198
        Me.UltraLabel3.Text = "Cuenta Clientes Rel.:"
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(25, 33)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel1.TabIndex = 198
        Me.UltraLabel1.Text = "Cuenta Clientes :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(845, 25)
        Me.ToolStrip1.TabIndex = 202
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(12, 28)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(821, 395)
        Me.UltraTabControl1.TabIndex = 203
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Vista de Datos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Cuentas Contables"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(817, 369)
        '
        'CO_PR_NovaqVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(845, 427)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_NovaqVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes de Comercial - NovaQ"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.ug_cab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_cab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_periodo.ResumeLayout(False)
        Me.ugb_periodo.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Caja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Caja.ResumeLayout(False)
        Me.ugb_Caja.PerformLayout()
        CType(Me.txt_des_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_cta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_SubDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_cta40_dol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cta_12Rel_dol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cta12_dol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Cuentas.ResumeLayout(False)
        Me.ugb_Cuentas.PerformLayout()
        CType(Me.txt_cta40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cta12Rel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cta12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ubtn_Contabilizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_Cuentas As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_cta40 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cta12Rel As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cta12 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_periodo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_cab As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_cab As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_VerFac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lbl_num_fac As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_cta40_dol As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cta_12Rel_dol As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cta12_dol As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Caja As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_Gen_asi_caja As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_SubDiario As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_num_cta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_des_cuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
End Class
