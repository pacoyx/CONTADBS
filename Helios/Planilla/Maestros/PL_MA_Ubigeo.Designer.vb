<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Ubigeo
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_CODIGO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_DESCRIPCION")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_DESCRIPCION")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ug_Ubigeo = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Ubigeo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uce_Provincia = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Departamento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ug_Ubigeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Ubigeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Provincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Departamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.ug_Ubigeo)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Provincia)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Departamento)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(476, 344)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'ug_Ubigeo
        '
        Me.ug_Ubigeo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Ubigeo.DataSource = Me.uds_Ubigeo
        Me.ug_Ubigeo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 81
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ug_Ubigeo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Ubigeo.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Ubigeo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Ubigeo.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Ubigeo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Ubigeo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Ubigeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Ubigeo.Location = New System.Drawing.Point(22, 74)
        Me.ug_Ubigeo.Name = "ug_Ubigeo"
        Me.ug_Ubigeo.Size = New System.Drawing.Size(431, 258)
        Me.ug_Ubigeo.TabIndex = 2
        Me.ug_Ubigeo.Text = "Distrito"
        '
        'uds_Ubigeo
        '
        Me.uds_Ubigeo.AllowDelete = False
        Me.uds_Ubigeo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'uce_Provincia
        '
        Me.uce_Provincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Provincia.Location = New System.Drawing.Point(104, 43)
        Me.uce_Provincia.Name = "uce_Provincia"
        Me.uce_Provincia.Size = New System.Drawing.Size(185, 21)
        Me.uce_Provincia.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance36
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(22, 47)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Provincia"
        '
        'uce_Departamento
        '
        Me.uce_Departamento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Departamento.Location = New System.Drawing.Point(104, 16)
        Me.uce_Departamento.Name = "uce_Departamento"
        Me.uce_Departamento.Size = New System.Drawing.Size(252, 21)
        Me.uce_Departamento.TabIndex = 0
        '
        'UltraLabel27
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel27.Appearance = Appearance6
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Location = New System.Drawing.Point(22, 20)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel27.TabIndex = 7
        Me.UltraLabel27.Text = "Departamento"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(397, 362)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(91, 26)
        Me.ubtn_Cancelar.TabIndex = 1
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(308, 362)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(83, 26)
        Me.ubtn_Aceptar.TabIndex = 0
        Me.ubtn_Aceptar.Text = "&Enviar"
        '
        'PL_MA_Ubigeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(502, 394)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "PL_MA_Ubigeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de Ubigeo..."
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.ug_Ubigeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Ubigeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Provincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Departamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_Ubigeo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uce_Provincia As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Departamento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Ubigeo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
End Class
