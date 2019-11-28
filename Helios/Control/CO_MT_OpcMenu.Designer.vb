<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_OpcMenu
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MODULO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OM_NOMGRUPO", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OM_ID")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OM_DESCRIPCION")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MODULO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OM_NOMGRUPO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OM_ID")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OM_DESCRIPCION")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_MT_OpcMenu))
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_ItemMenu = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_ItemMenu = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugb_Img = New Infragistics.Win.Misc.UltraGroupBox
        Me.lbl_TextoLarge = New Infragistics.Win.Misc.UltraLabel
        Me.ubtn_agregar = New Infragistics.Win.Misc.UltraButton
        Me.upb_img = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.ubtn_Quitar = New Infragistics.Win.Misc.UltraButton
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_NomFormulario = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uce_Modulo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Grupo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Tamano = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Padre = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_TipoBoton = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.une_Id = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txt_Des = New Infragistics.Win.UltraWinEditors.UltraTextEditor
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
        Me.utc_ItemMenu = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraValidator1 = New Infragistics.Win.Misc.UltraValidator(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_ItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Img.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_NomFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Modulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Grupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Tamano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Padre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoBoton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_ItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_ItemMenu.SuspendLayout()
        CType(Me.UltraValidator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_ItemMenu)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(712, 334)
        '
        'ug_ItemMenu
        '
        Me.ug_ItemMenu.DataSource = Me.uds_ItemMenu
        Me.ug_ItemMenu.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Grupo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Codigo"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Descripcion"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_ItemMenu.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ItemMenu.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ItemMenu.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_ItemMenu.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_ItemMenu.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        Me.ug_ItemMenu.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_ItemMenu.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ItemMenu.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ItemMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_ItemMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ItemMenu.Location = New System.Drawing.Point(0, 0)
        Me.ug_ItemMenu.Name = "ug_ItemMenu"
        Me.ug_ItemMenu.Size = New System.Drawing.Size(712, 334)
        Me.ug_ItemMenu.TabIndex = 3
        '
        'uds_ItemMenu
        '
        Me.uds_ItemMenu.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Short)
        Me.uds_ItemMenu.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'UltraGrid1
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance13
        Me.UltraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.FontData.Name = "Arial"
        Appearance15.FontData.SizeInPoints = 10.0!
        Appearance15.ForeColor = System.Drawing.Color.White
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance15
        Appearance8.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance8.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.UltraGrid1.DisplayLayout.Override.RowAlternateAppearance = Appearance8
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.UltraGrid1.DisplayLayout.Override.SelectedRowAppearance = Appearance17
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(712, 334)
        Me.UltraGrid1.TabIndex = 2
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Img)
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(712, 334)
        '
        'ugb_Img
        '
        Me.ugb_Img.Controls.Add(Me.lbl_TextoLarge)
        Me.ugb_Img.Controls.Add(Me.ubtn_agregar)
        Me.ugb_Img.Controls.Add(Me.upb_img)
        Me.ugb_Img.Controls.Add(Me.ubtn_Quitar)
        Me.ugb_Img.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Img.Location = New System.Drawing.Point(11, 215)
        Me.ugb_Img.Name = "ugb_Img"
        Me.ugb_Img.Size = New System.Drawing.Size(692, 111)
        Me.ugb_Img.TabIndex = 2
        Me.ugb_Img.Text = "Icono que se mostrara en el Item del Menu"
        '
        'lbl_TextoLarge
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.lbl_TextoLarge.Appearance = Appearance25
        Me.lbl_TextoLarge.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.lbl_TextoLarge.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_TextoLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_TextoLarge.Location = New System.Drawing.Point(298, 36)
        Me.lbl_TextoLarge.Name = "lbl_TextoLarge"
        Me.lbl_TextoLarge.Size = New System.Drawing.Size(247, 63)
        Me.lbl_TextoLarge.TabIndex = 6
        Me.lbl_TextoLarge.Text = "Se recomienda que el Icono tenga las dimensiones minimas de 24 x 24 para que no o" & _
            "curra distorcion de la imagen"
        Me.lbl_TextoLarge.Visible = False
        '
        'ubtn_agregar
        '
        Appearance20.Image = Global.Contabilidad.My.Resources.Resources._16__Insert_bitmap_
        Appearance20.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance20.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.ubtn_agregar.Appearance = Appearance20
        Me.ubtn_agregar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.ubtn_agregar.Location = New System.Drawing.Point(111, 36)
        Me.ubtn_agregar.Name = "ubtn_agregar"
        Me.ubtn_agregar.Size = New System.Drawing.Size(75, 60)
        Me.ubtn_agregar.TabIndex = 0
        Me.ubtn_agregar.Text = "&Cambiar Icono"
        '
        'upb_img
        '
        Me.upb_img.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_img.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.upb_img.Image = CType(resources.GetObject("upb_img.Image"), Object)
        Me.upb_img.Location = New System.Drawing.Point(13, 28)
        Me.upb_img.Name = "upb_img"
        Me.upb_img.Size = New System.Drawing.Size(75, 71)
        Me.upb_img.TabIndex = 4
        '
        'ubtn_Quitar
        '
        Appearance21.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_over_
        Appearance21.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance21.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.ubtn_Quitar.Appearance = Appearance21
        Me.ubtn_Quitar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.ubtn_Quitar.Location = New System.Drawing.Point(192, 36)
        Me.ubtn_Quitar.Name = "ubtn_Quitar"
        Me.ubtn_Quitar.Size = New System.Drawing.Size(75, 60)
        Me.ubtn_Quitar.TabIndex = 5
        Me.ubtn_Quitar.Text = "&Quitar"
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.txt_NomFormulario)
        Me.ugb_datos.Controls.Add(Me.uce_Modulo)
        Me.ugb_datos.Controls.Add(Me.uce_Grupo)
        Me.ugb_datos.Controls.Add(Me.uce_Tamano)
        Me.ugb_datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_datos.Controls.Add(Me.uce_Padre)
        Me.ugb_datos.Controls.Add(Me.uce_TipoBoton)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.une_Id)
        Me.ugb_datos.Controls.Add(Me.txt_Des)
        Me.ugb_datos.Location = New System.Drawing.Point(11, 13)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(692, 196)
        Me.ugb_datos.TabIndex = 0
        '
        'txt_NomFormulario
        '
        Me.txt_NomFormulario.Location = New System.Drawing.Point(94, 130)
        Me.txt_NomFormulario.Name = "txt_NomFormulario"
        Me.txt_NomFormulario.Size = New System.Drawing.Size(237, 21)
        Me.txt_NomFormulario.TabIndex = 4
        '
        'uce_Modulo
        '
        Me.uce_Modulo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Modulo.Location = New System.Drawing.Point(475, 52)
        Me.uce_Modulo.Name = "uce_Modulo"
        Me.uce_Modulo.Size = New System.Drawing.Size(198, 21)
        Me.uce_Modulo.TabIndex = 5
        '
        'uce_Grupo
        '
        Me.uce_Grupo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Grupo.Location = New System.Drawing.Point(475, 79)
        Me.uce_Grupo.Name = "uce_Grupo"
        Me.uce_Grupo.Size = New System.Drawing.Size(198, 21)
        Me.uce_Grupo.TabIndex = 6
        '
        'uce_Tamano
        '
        Me.uce_Tamano.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Tamano.Location = New System.Drawing.Point(94, 103)
        Me.uce_Tamano.Name = "uce_Tamano"
        Me.uce_Tamano.Size = New System.Drawing.Size(173, 21)
        Me.uce_Tamano.TabIndex = 3
        '
        'UltraLabel6
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance5
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel6.Location = New System.Drawing.Point(428, 52)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Modulo"
        '
        'uce_Padre
        '
        Me.uce_Padre.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Padre.Location = New System.Drawing.Point(475, 106)
        Me.uce_Padre.Name = "uce_Padre"
        Me.uce_Padre.Size = New System.Drawing.Size(198, 21)
        Me.uce_Padre.TabIndex = 7
        '
        'uce_TipoBoton
        '
        Me.uce_TipoBoton.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoBoton.Location = New System.Drawing.Point(94, 76)
        Me.uce_TipoBoton.Name = "uce_TipoBoton"
        Me.uce_TipoBoton.Size = New System.Drawing.Size(116, 21)
        Me.uce_TipoBoton.TabIndex = 2
        '
        'UltraLabel4
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance10
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel4.Location = New System.Drawing.Point(428, 79)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Grupo"
        '
        'UltraLabel8
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance23
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel8.Location = New System.Drawing.Point(25, 134)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel8.TabIndex = 2
        Me.UltraLabel8.Text = "Formulario"
        '
        'UltraLabel5
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance12
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel5.Location = New System.Drawing.Point(25, 107)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Tamaño Img"
        '
        'UltraLabel7
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance9
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel7.Location = New System.Drawing.Point(396, 110)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel7.TabIndex = 2
        Me.UltraLabel7.Text = "Se asigana a:"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(25, 26)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Codigo"
        '
        'UltraLabel2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance11
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(25, 80)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Tipo Boton"
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(25, 56)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Descripción"
        '
        'une_Id
        '
        Me.une_Id.Location = New System.Drawing.Point(94, 22)
        Me.une_Id.MaskInput = "nnnn"
        Me.une_Id.Name = "une_Id"
        Me.une_Id.Size = New System.Drawing.Size(60, 21)
        Me.une_Id.TabIndex = 0
        '
        'txt_Des
        '
        Me.txt_Des.Location = New System.Drawing.Point(94, 49)
        Me.txt_Des.Name = "txt_Des"
        Me.txt_Des.Size = New System.Drawing.Size(237, 21)
        Me.txt_Des.TabIndex = 1
        Me.UltraValidator1.GetValidationSettings(Me.txt_Des).IsRequired = True
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(716, 25)
        Me.ToolS_Mantenimiento.TabIndex = 6
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
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
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'utc_ItemMenu
        '
        Me.utc_ItemMenu.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_ItemMenu.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_ItemMenu.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_ItemMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utc_ItemMenu.Location = New System.Drawing.Point(0, 25)
        Me.utc_ItemMenu.Name = "utc_ItemMenu"
        Me.utc_ItemMenu.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_ItemMenu.Size = New System.Drawing.Size(716, 360)
        Me.utc_ItemMenu.TabIndex = 7
        Appearance3.FontData.BoldAsString = "True"
        UltraTab1.ActiveAppearance = Appearance3
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        UltraTab1.Appearance = Appearance2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Modulos"
        Appearance4.FontData.BoldAsString = "True"
        UltraTab2.ActiveAppearance = Appearance4
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._16__Pencil_tool_
        UltraTab2.Appearance = Appearance1
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso/Edicion de Datos"
        Me.utc_ItemMenu.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(712, 334)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(714, 312)
        '
        'CO_MT_OpcMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 385)
        Me.Controls.Add(Me.utc_ItemMenu)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_OpcMenu"
        Me.Text = "Mantenimiento de Item del Menu"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_ItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Img.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_NomFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Modulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Grupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Tamano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Padre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoBoton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_ItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_ItemMenu.ResumeLayout(False)
        CType(Me.UltraValidator1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents utc_ItemMenu As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_TipoBoton As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_Id As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txt_Des As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uds_ItemMenu As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uce_Grupo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Tamano As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Img As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents upb_img As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents ubtn_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_ItemMenu As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uce_Modulo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_TextoLarge As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraValidator1 As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents uce_Padre As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_NomFormulario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
End Class
