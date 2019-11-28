<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_Char2
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_IDANEXO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DI_ABREVIATURA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_NUM_DOC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_DESCRIPCION")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_IDANEXO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DI_ABREVIATURA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_NUM_DOC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_DESCRIPCION")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim GradientEffect1 As Infragistics.UltraChart.Resources.Appearance.GradientEffect = New Infragistics.UltraChart.Resources.Appearance.GradientEffect
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.uce_TiposAnexos = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uds_Anexos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_anexos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraChart1 = New Infragistics.Win.UltraWinChart.UltraChart
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        CType(Me.uce_TiposAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_anexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'uce_TiposAnexos
        '
        Me.uce_TiposAnexos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TiposAnexos.Location = New System.Drawing.Point(96, 30)
        Me.uce_TiposAnexos.Name = "uce_TiposAnexos"
        Me.uce_TiposAnexos.Size = New System.Drawing.Size(206, 21)
        Me.uce_TiposAnexos.TabIndex = 0
        '
        'uds_Anexos
        '
        Me.uds_Anexos.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_Anexos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'ug_anexos
        '
        Me.ug_anexos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ug_anexos.DataSource = Me.uds_Anexos
        Appearance1.BackColor = System.Drawing.Color.White
        Me.ug_anexos.DisplayLayout.Appearance = Appearance1
        Me.ug_anexos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Ruc"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Descripcion"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_anexos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_anexos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.ug_anexos.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.ug_anexos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 10.0!
        Appearance3.ForeColor = System.Drawing.Color.White
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_anexos.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_anexos.DisplayLayout.Override.RowSelectorAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_anexos.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.ug_anexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_anexos.Location = New System.Drawing.Point(12, 57)
        Me.ug_anexos.Name = "ug_anexos"
        Me.ug_anexos.Size = New System.Drawing.Size(290, 357)
        Me.ug_anexos.TabIndex = 1
        Me.ug_anexos.Text = "UltraGrid1"
        '
        'UltraChart1
        '
        Me.UltraChart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraChart1.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UltraChart1.Axis.X.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X.LineThickness = 1
        Me.UltraChart1.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.UltraChart1.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.X.MajorGridLines.Visible = True
        Me.UltraChart1.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.UltraChart1.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.X.MinorGridLines.Visible = False
        Me.UltraChart1.Axis.X.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.UltraChart1.Axis.X.Visible = True
        Me.UltraChart1.Axis.X2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray
        Me.UltraChart1.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.UltraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Far
        Me.UltraChart1.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.X2.Labels.Visible = False
        Me.UltraChart1.Axis.X2.LineThickness = 1
        Me.UltraChart1.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.UltraChart1.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.X2.MajorGridLines.Visible = True
        Me.UltraChart1.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.UltraChart1.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.X2.MinorGridLines.Visible = False
        Me.UltraChart1.Axis.X2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.UltraChart1.Axis.X2.Visible = False
        Me.UltraChart1.Axis.Y.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.UltraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.UltraChart1.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.UltraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y.LineThickness = 1
        Me.UltraChart1.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.UltraChart1.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Y.MajorGridLines.Visible = True
        Me.UltraChart1.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.UltraChart1.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Y.MinorGridLines.Visible = False
        Me.UltraChart1.Axis.Y.TickmarkInterval = 50
        Me.UltraChart1.Axis.Y.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.UltraChart1.Axis.Y.Visible = True
        Me.UltraChart1.Axis.Y2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray
        Me.UltraChart1.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.UltraChart1.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.UltraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Y2.Labels.Visible = False
        Me.UltraChart1.Axis.Y2.LineThickness = 1
        Me.UltraChart1.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.UltraChart1.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Y2.MajorGridLines.Visible = True
        Me.UltraChart1.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.UltraChart1.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Y2.MinorGridLines.Visible = False
        Me.UltraChart1.Axis.Y2.TickmarkInterval = 50
        Me.UltraChart1.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.UltraChart1.Axis.Y2.Visible = False
        Me.UltraChart1.Axis.Z.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.UltraChart1.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z.Labels.Visible = False
        Me.UltraChart1.Axis.Z.LineThickness = 1
        Me.UltraChart1.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.UltraChart1.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Z.MajorGridLines.Visible = True
        Me.UltraChart1.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.UltraChart1.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Z.MinorGridLines.Visible = False
        Me.UltraChart1.Axis.Z.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.UltraChart1.Axis.Z.Visible = False
        Me.UltraChart1.Axis.Z2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray
        Me.UltraChart1.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z2.Labels.ItemFormatString = ""
        Me.UltraChart1.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.UltraChart1.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.UltraChart1.Axis.Z2.Labels.Visible = False
        Me.UltraChart1.Axis.Z2.LineThickness = 1
        Me.UltraChart1.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.UltraChart1.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Z2.MajorGridLines.Visible = True
        Me.UltraChart1.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.UltraChart1.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.UltraChart1.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.UltraChart1.Axis.Z2.MinorGridLines.Visible = False
        Me.UltraChart1.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.UltraChart1.Axis.Z2.Visible = False
        Me.UltraChart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UltraChart1.ColorModel.AlphaLevel = CType(150, Byte)
        Me.UltraChart1.ColorModel.ColorBegin = System.Drawing.Color.Pink
        Me.UltraChart1.ColorModel.ColorEnd = System.Drawing.Color.DarkRed
        Me.UltraChart1.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.CustomLinear
        Me.UltraChart1.Effects.Effects.Add(GradientEffect1)
        Me.UltraChart1.Location = New System.Drawing.Point(308, 57)
        Me.UltraChart1.Name = "UltraChart1"
        Me.UltraChart1.Size = New System.Drawing.Size(863, 357)
        Me.UltraChart1.TabIndex = 2
        Me.UltraChart1.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray
        Me.UltraChart1.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray
        Me.UltraChart1.Tooltips.TooltipControl = Nothing
        Me.UltraChart1.Visible = False
        '
        'UltraLabel1
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(29, 34)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Tipo Anexo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(1183, 25)
        Me.ToolS_Mantenimiento.TabIndex = 6
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'CO_PR_Char2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1183, 426)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraChart1)
        Me.Controls.Add(Me.ug_anexos)
        Me.Controls.Add(Me.uce_TiposAnexos)
        Me.Name = "CO_PR_Char2"
        Me.Text = "Movimiento Mensual por Anexo"
        CType(Me.uce_TiposAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Anexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_anexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uce_TiposAnexos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_Anexos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_anexos As Infragistics.Win.UltraWinGrid.UltraGrid
    Private WithEvents UltraChart1 As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
