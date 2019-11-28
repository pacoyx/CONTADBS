<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_LG_Empresas
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EM_IMAGEN")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EM_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EM_NOMBRE")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EM_IMAGEN")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EM_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EM_NOMBRE")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_LG_Empresas))
        Me.upb_Cabecera = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.uds_Empresas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ug_Empresa = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        CType(Me.uds_Empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ug_Empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'upb_Cabecera
        '
        Me.upb_Cabecera.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_Cabecera.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.upb_Cabecera.Location = New System.Drawing.Point(11, 6)
        Me.upb_Cabecera.Name = "upb_Cabecera"
        Me.upb_Cabecera.Size = New System.Drawing.Size(569, 50)
        Me.upb_Cabecera.TabIndex = 6
        '
        'uds_Empresas
        '
        Me.uds_Empresas.AllowDelete = False
        UltraDataColumn1.DataType = GetType(System.Drawing.Bitmap)
        UltraDataColumn2.DataType = GetType(Integer)
        Me.uds_Empresas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.ug_Empresa)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(11, 62)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(572, 285)
        Me.UltraGroupBox1.TabIndex = 7
        Me.UltraGroupBox1.Text = "Seleccione una empresa"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ug_Empresa
        '
        Me.ug_Empresa.DataSource = Me.uds_Empresas
        Appearance1.BackColor = System.Drawing.Color.White
        Me.ug_Empresa.DisplayLayout.Appearance = Appearance1
        Me.ug_Empresa.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand1.CardView = True
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance18.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance18.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn1.CellAppearance = Appearance18
        UltraGridColumn1.Header.Caption = "Logo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 63)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.ImageWithShadow
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Codigo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Empresa"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.UseRowLayout = True
        Me.ug_Empresa.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Empresa.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ug_Empresa.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Empresa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.ug_Empresa.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 10.0!
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_Empresa.DisplayLayout.Override.HeaderAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_Empresa.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_Empresa.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.ug_Empresa.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Empresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Empresa.Location = New System.Drawing.Point(3, 21)
        Me.ug_Empresa.Name = "ug_Empresa"
        Me.ug_Empresa.Size = New System.Drawing.Size(566, 261)
        Me.ug_Empresa.TabIndex = 1
        '
        '_CO_LG_Empresas_Toolbars_Dock_Area_Left
        '
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.White
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.Name = "_CO_LG_Empresas_Toolbars_Dock_Area_Left"
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 352)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CO_LG_Empresas_Toolbars_Dock_Area_Right
        '
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.White
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(593, 0)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.Name = "_CO_LG_Empresas_Toolbars_Dock_Area_Right"
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 352)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CO_LG_Empresas_Toolbars_Dock_Area_Top
        '
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.White
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.Name = "_CO_LG_Empresas_Toolbars_Dock_Area_Top"
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(593, 0)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CO_LG_Empresas_Toolbars_Dock_Area_Bottom
        '
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.White
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 352)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.Name = "_CO_LG_Empresas_Toolbars_Dock_Area_Bottom"
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(593, 0)
        Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        '
        'CO_LG_Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 352)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.upb_Cabecera)
        Me.Controls.Add(Me._CO_LG_Empresas_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._CO_LG_Empresas_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._CO_LG_Empresas_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._CO_LG_Empresas_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CO_LG_Empresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Contable"
        CType(Me.uds_Empresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ug_Empresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents upb_Cabecera As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents uds_Empresas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_Empresa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _CO_LG_Empresas_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CO_LG_Empresas_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CO_LG_Empresas_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CO_LG_Empresas_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
End Class
