<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TE_AR_TipoCambio
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECHA")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COMPRA")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VENTA")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FECHA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMPRA")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VENTA")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ToolS_Subdiarios = New System.Windows.Forms.ToolStrip
        Me.tool_Imprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_Web = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uds_Lista_Tc = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ub_Datos1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ug_ListaTc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ToolS_Subdiarios.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista_Tc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ub_Datos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ub_Datos1.SuspendLayout()
        CType(Me.ug_ListaTc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Subdiarios
        '
        Me.ToolS_Subdiarios.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Subdiarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_Imprimir, Me.ToolStripSeparator1, Me.tool_Web, Me.ToolStripSeparator2, Me.Tool_Salir})
        Me.ToolS_Subdiarios.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Subdiarios.Name = "ToolS_Subdiarios"
        Me.ToolS_Subdiarios.Size = New System.Drawing.Size(365, 25)
        Me.ToolS_Subdiarios.TabIndex = 4
        Me.ToolS_Subdiarios.Text = "ToolStrip1"
        '
        'tool_Imprimir
        '
        Me.tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources.klpq_24x24_32
        Me.tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_Imprimir.Name = "tool_Imprimir"
        Me.tool_Imprimir.Size = New System.Drawing.Size(65, 22)
        Me.tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tool_Web
        '
        Me.tool_Web.Image = Global.Contabilidad.My.Resources.Resources._16__Internet_
        Me.tool_Web.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_Web.Name = "tool_Web"
        Me.tool_Web.Size = New System.Drawing.Size(74, 22)
        Me.tool_Web.Text = "Ver Sunat"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 39)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(327, 51)
        Me.ugb_Parametros.TabIndex = 7
        '
        'une_Ayo
        '
        Me.une_Ayo.Enabled = False
        Me.une_Ayo.Location = New System.Drawing.Point(48, 13)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 17)
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
        Me.UltraLabel4.Location = New System.Drawing.Point(129, 17)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(167, 13)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'uds_Lista_Tc
        '
        Me.uds_Lista_Tc.AllowDelete = False
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Double)
        Me.uds_Lista_Tc.Band.Columns.AddRange(New Object() {UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'ub_Datos1
        '
        Me.ub_Datos1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
        Me.ub_Datos1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ub_Datos1.Controls.Add(Me.ug_ListaTc)
        Me.ub_Datos1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ub_Datos1.Location = New System.Drawing.Point(12, 96)
        Me.ub_Datos1.Name = "ub_Datos1"
        Me.ub_Datos1.Size = New System.Drawing.Size(332, 388)
        Me.ub_Datos1.TabIndex = 8
        Me.ub_Datos1.Text = "Ingrese el tipo de cambio"
        '
        'ug_ListaTc
        '
        Me.ug_ListaTc.DataSource = Me.uds_Lista_Tc
        Appearance1.BackColor = System.Drawing.Color.White
        Me.ug_ListaTc.DisplayLayout.Appearance = Appearance1
        Me.ug_ListaTc.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance8
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaskInput = "{double:1.3}"
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DoublePositive
        UltraGridColumn2.Width = 121
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance9
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = "{double:1.3}"
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DoublePositive
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_ListaTc.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ListaTc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaTc.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_ListaTc.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaTc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.ug_ListaTc.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 10.0!
        Appearance3.ForeColor = System.Drawing.Color.White
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_ListaTc.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance6.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance6.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaTc.DisplayLayout.Override.RowAlternateAppearance = Appearance6
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_ListaTc.DisplayLayout.Override.RowSelectorAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_ListaTc.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.ug_ListaTc.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_ListaTc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_ListaTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaTc.Location = New System.Drawing.Point(3, 21)
        Me.ug_ListaTc.Name = "ug_ListaTc"
        Me.ug_ListaTc.Size = New System.Drawing.Size(326, 364)
        Me.ug_ListaTc.TabIndex = 0
        Me.ug_ListaTc.Text = "UltraGrid1"
        '
        'TE_AR_TipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(365, 491)
        Me.Controls.Add(Me.ub_Datos1)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolS_Subdiarios)
        Me.Name = "TE_AR_TipoCambio"
        Me.Text = "Tipo de Cambio"
        Me.ToolS_Subdiarios.ResumeLayout(False)
        Me.ToolS_Subdiarios.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista_Tc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ub_Datos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ub_Datos1.ResumeLayout(False)
        CType(Me.ug_ListaTc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Subdiarios As System.Windows.Forms.ToolStrip
    Friend WithEvents tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_Web As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_Lista_Tc As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ub_Datos1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_ListaTc As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
