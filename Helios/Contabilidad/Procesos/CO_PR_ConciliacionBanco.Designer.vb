<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_ConciliacionBanco
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_IDDET")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_FEC_VOUCHER")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_TDOC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_NDOC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_DEBE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_HABER")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_GLOSA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_ES_CONCI")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_ANHO_CONI")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_MES_CONCI")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_IDDET")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AC_FEC_VOUCHER")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_TDOC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_NDOC")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_DEBE")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_HABER")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_GLOSA")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_ES_CONCI")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_ANHO_CONI")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_MES_CONCI")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.uds_MovBancarios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_MovBancarios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox
        Me.uce_CtasCorrientes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Bancos = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uchk_Conciliados = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Tool_Consultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Guardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_cerrarMes = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton
        Me.ume_saldoAnterior = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_SAldoFinMes = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_sum_haber = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_sum_debe = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.ulbl_total_filas = New Infragistics.Win.Misc.UltraLabel
        CType(Me.uds_MovBancarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_MovBancarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uce_CtasCorrientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_MovBancarios
        '
        Me.uds_MovBancarios.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn9.DataType = GetType(Integer)
        UltraDataColumn10.DataType = GetType(Integer)
        Me.uds_MovBancarios.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'ug_MovBancarios
        '
        Me.ug_MovBancarios.DataSource = Me.uds_MovBancarios
        Me.ug_MovBancarios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Fecha"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Documento"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Numero"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance10
        UltraGridColumn5.Header.Caption = "Debe"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.MaskInput = ""
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance11
        UltraGridColumn6.Header.Caption = "Haber"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Glosa"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 290
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "Sel"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.ug_MovBancarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_MovBancarios.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_MovBancarios.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_MovBancarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_MovBancarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_MovBancarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_MovBancarios.Location = New System.Drawing.Point(12, 111)
        Me.ug_MovBancarios.Name = "ug_MovBancarios"
        Me.ug_MovBancarios.Size = New System.Drawing.Size(806, 293)
        Me.ug_MovBancarios.TabIndex = 0
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Controls.Add(Me.uce_CtasCorrientes)
        Me.ugb_Parametros.Controls.Add(Me.uce_Bancos)
        Me.ugb_Parametros.Controls.Add(Me.uchk_Conciliados)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel3)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel2)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(806, 77)
        Me.ugb_Parametros.TabIndex = 7
        '
        'uce_CtasCorrientes
        '
        Me.uce_CtasCorrientes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_CtasCorrientes.Location = New System.Drawing.Point(293, 43)
        Me.uce_CtasCorrientes.Name = "uce_CtasCorrientes"
        Me.uce_CtasCorrientes.Size = New System.Drawing.Size(294, 21)
        Me.uce_CtasCorrientes.TabIndex = 15
        '
        'uce_Bancos
        '
        Me.uce_Bancos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Bancos.Location = New System.Drawing.Point(293, 13)
        Me.uce_Bancos.Name = "uce_Bancos"
        Me.uce_Bancos.Size = New System.Drawing.Size(207, 21)
        Me.uce_Bancos.TabIndex = 15
        '
        'uchk_Conciliados
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Conciliados.Appearance = Appearance6
        Me.uchk_Conciliados.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Conciliados.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Conciliados.Checked = True
        Me.uchk_Conciliados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_Conciliados.Location = New System.Drawing.Point(665, 44)
        Me.uchk_Conciliados.Name = "uchk_Conciliados"
        Me.uchk_Conciliados.Size = New System.Drawing.Size(131, 20)
        Me.uchk_Conciliados.TabIndex = 14
        Me.uchk_Conciliados.Text = "Pendientes Conciliar"
        '
        'une_Ayo
        '
        Appearance19.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance19
        Me.une_Ayo.Location = New System.Drawing.Point(48, 13)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel3
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance16
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(190, 47)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(97, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Cuenta Corriente :"
        '
        'UltraLabel2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(236, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel2.TabIndex = 12
        Me.UltraLabel2.Text = "Banco :"
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(10, 47)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(48, 43)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Consultar, Me.ToolStripSeparator1, Me.Tool_Guardar, Me.ToolStripSeparator3, Me.Tool_cerrarMes, Me.ToolStripSeparator2, Me.Tool_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(826, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Consultar
        '
        Me.Tool_Consultar.Image = Global.Contabilidad.My.Resources.Resources._16__Print_preview_
        Me.Tool_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Consultar.Name = "Tool_Consultar"
        Me.Tool_Consultar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Consultar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Guardar
        '
        Me.Tool_Guardar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Guardar.Name = "Tool_Guardar"
        Me.Tool_Guardar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Guardar.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_cerrarMes
        '
        Me.Tool_cerrarMes.Image = Global.Contabilidad.My.Resources.Resources.Security_2_32x32_32
        Me.Tool_cerrarMes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_cerrarMes.Name = "Tool_cerrarMes"
        Me.Tool_cerrarMes.Size = New System.Drawing.Size(84, 22)
        Me.Tool_cerrarMes.Text = "Cerrar Mes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ume_saldoAnterior
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.ume_saldoAnterior.Appearance = Appearance12
        Me.ume_saldoAnterior.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_saldoAnterior.InputMask = "{double:-9.2}"
        Me.ume_saldoAnterior.Location = New System.Drawing.Point(390, 410)
        Me.ume_saldoAnterior.Name = "ume_saldoAnterior"
        Me.ume_saldoAnterior.ReadOnly = True
        Me.ume_saldoAnterior.Size = New System.Drawing.Size(100, 20)
        Me.ume_saldoAnterior.TabIndex = 9
        Me.ume_saldoAnterior.Text = "UltraMaskedEdit1"
        '
        'ume_SAldoFinMes
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.ume_SAldoFinMes.Appearance = Appearance15
        Me.ume_SAldoFinMes.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_SAldoFinMes.InputMask = "{double:-9.2}"
        Me.ume_SAldoFinMes.Location = New System.Drawing.Point(718, 436)
        Me.ume_SAldoFinMes.Name = "ume_SAldoFinMes"
        Me.ume_SAldoFinMes.ReadOnly = True
        Me.ume_SAldoFinMes.Size = New System.Drawing.Size(100, 20)
        Me.ume_SAldoFinMes.TabIndex = 9
        Me.ume_SAldoFinMes.Text = "UltraMaskedEdit1"
        '
        'ume_sum_haber
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.ume_sum_haber.Appearance = Appearance14
        Me.ume_sum_haber.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_sum_haber.InputMask = "{double:-9.2}"
        Me.ume_sum_haber.Location = New System.Drawing.Point(718, 410)
        Me.ume_sum_haber.Name = "ume_sum_haber"
        Me.ume_sum_haber.ReadOnly = True
        Me.ume_sum_haber.Size = New System.Drawing.Size(100, 20)
        Me.ume_sum_haber.TabIndex = 9
        Me.ume_sum_haber.Text = "UltraMaskedEdit1"
        '
        'ume_sum_debe
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.ume_sum_debe.Appearance = Appearance13
        Me.ume_sum_debe.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_sum_debe.InputMask = "{double:-9.2}"
        Me.ume_sum_debe.Location = New System.Drawing.Point(612, 410)
        Me.ume_sum_debe.Name = "ume_sum_debe"
        Me.ume_sum_debe.ReadOnly = True
        Me.ume_sum_debe.Size = New System.Drawing.Size(100, 20)
        Me.ume_sum_debe.TabIndex = 9
        Me.ume_sum_debe.Text = "UltraMaskedEdit1"
        '
        'UltraLabel5
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance17
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(509, 413)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel5.TabIndex = 16
        Me.UltraLabel5.Text = "Suma del Mes :"
        '
        'UltraLabel6
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance18
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(509, 439)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel6.TabIndex = 16
        Me.UltraLabel6.Text = "Saldo Mes :"
        '
        'UltraLabel7
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance3
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(293, 413)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(82, 14)
        Me.UltraLabel7.TabIndex = 16
        Me.UltraLabel7.Text = "Saldo Anterior :"
        '
        'ulbl_total_filas
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.ulbl_total_filas.Appearance = Appearance23
        Me.ulbl_total_filas.AutoSize = True
        Me.ulbl_total_filas.Location = New System.Drawing.Point(12, 413)
        Me.ulbl_total_filas.Name = "ulbl_total_filas"
        Me.ulbl_total_filas.Size = New System.Drawing.Size(87, 14)
        Me.ulbl_total_filas.TabIndex = 16
        Me.ulbl_total_filas.Text = "Total Registros :"
        '
        'CO_PR_ConciliacionBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(826, 464)
        Me.Controls.Add(Me.ulbl_total_filas)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.ume_sum_debe)
        Me.Controls.Add(Me.ume_SAldoFinMes)
        Me.Controls.Add(Me.ume_sum_haber)
        Me.Controls.Add(Me.ume_saldoAnterior)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ug_MovBancarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_ConciliacionBanco"
        Me.Text = "Conciliacion Bancaria"
        CType(Me.uds_MovBancarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_MovBancarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uce_CtasCorrientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_MovBancarios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_MovBancarios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_cerrarMes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uchk_Conciliados As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Tool_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uce_CtasCorrientes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Bancos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_saldoAnterior As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_SAldoFinMes As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_sum_haber As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_sum_debe As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulbl_total_filas As Infragistics.Win.Misc.UltraLabel
End Class
