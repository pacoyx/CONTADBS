<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_Analisis5
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_DESCRIPCION")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_DESCRIPCION")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_CUENTA")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_CUENTA")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.uds_cc = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_cc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ug_cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ulbl_etiqueta = New Infragistics.Win.Misc.UltraLabel
        Me.ubtn_Imprimir = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.ugb_ccostos = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes2 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        CType(Me.uds_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_ccostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_ccostos.SuspendLayout()
        CType(Me.uce_Mes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_cc
        '
        Me.uds_cc.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn2.DataType = GetType(Short)
        Me.uds_cc.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_cc
        '
        Me.ug_cc.DataSource = Me.uds_cc
        Me.ug_cc.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Codigo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Descripcion"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_cc.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_cc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_cc.Location = New System.Drawing.Point(16, 136)
        Me.ug_cc.Name = "ug_cc"
        Me.ug_cc.Size = New System.Drawing.Size(293, 263)
        Me.ug_cc.TabIndex = 0
        Me.ug_cc.Text = "UltraGrid1"
        '
        'ug_cuentas
        '
        Me.ug_cuentas.DataSource = Me.uds_cuentas
        Me.ug_cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Cuenta"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5})
        Me.ug_cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_cuentas.Location = New System.Drawing.Point(16, 136)
        Me.ug_cuentas.Name = "ug_cuentas"
        Me.ug_cuentas.Size = New System.Drawing.Size(293, 263)
        Me.ug_cuentas.TabIndex = 0
        Me.ug_cuentas.Visible = False
        '
        'uds_cuentas
        '
        Me.uds_cuentas.AllowAdd = False
        Me.uds_cuentas.AllowDelete = False
        UltraDataColumn4.DataType = GetType(Boolean)
        Me.uds_cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn4, UltraDataColumn5})
        '
        'ulbl_etiqueta
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.ulbl_etiqueta.Appearance = Appearance4
        Me.ulbl_etiqueta.AutoSize = True
        Me.ulbl_etiqueta.Location = New System.Drawing.Point(16, 116)
        Me.ulbl_etiqueta.Name = "ulbl_etiqueta"
        Me.ulbl_etiqueta.Size = New System.Drawing.Size(168, 14)
        Me.ulbl_etiqueta.TabIndex = 1
        Me.ulbl_etiqueta.Text = "Seleccione los Centro de Costos"
        '
        'ubtn_Imprimir
        '
        Appearance5.Image = Global.Contabilidad.My.Resources.Resources.klpq_24x24_32
        Me.ubtn_Imprimir.Appearance = Appearance5
        Me.ubtn_Imprimir.Location = New System.Drawing.Point(177, 426)
        Me.ubtn_Imprimir.Name = "ubtn_Imprimir"
        Me.ubtn_Imprimir.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Imprimir.TabIndex = 4
        Me.ubtn_Imprimir.Text = "&Imprimir"
        Me.ubtn_Imprimir.Visible = False
        '
        'ubtn_Cancelar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_Cancelar.Appearance = Appearance3
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(258, 426)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Cancelar.TabIndex = 5
        Me.ubtn_Cancelar.Text = "&Salir"
        '
        'ubtn_Aceptar
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.ubtn_Aceptar.Appearance = Appearance2
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(96, 426)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Aceptar.TabIndex = 4
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(98, 16)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.ReadOnly = True
        Me.txt_Ayo.Size = New System.Drawing.Size(61, 21)
        Me.txt_Ayo.TabIndex = 198
        '
        'UltraLabel3
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(13, 20)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel3.TabIndex = 199
        Me.UltraLabel3.Text = "Periodo :"
        '
        'ugb_ccostos
        '
        Me.ugb_ccostos.Controls.Add(Me.UltraLabel4)
        Me.ugb_ccostos.Controls.Add(Me.UltraLabel5)
        Me.ugb_ccostos.Controls.Add(Me.uce_Mes2)
        Me.ugb_ccostos.Controls.Add(Me.uce_Mes)
        Me.ugb_ccostos.Controls.Add(Me.txt_Ayo)
        Me.ugb_ccostos.Controls.Add(Me.ug_cuentas)
        Me.ugb_ccostos.Controls.Add(Me.UltraLabel3)
        Me.ugb_ccostos.Controls.Add(Me.ug_cc)
        Me.ugb_ccostos.Controls.Add(Me.ulbl_etiqueta)
        Me.ugb_ccostos.Location = New System.Drawing.Point(12, 12)
        Me.ugb_ccostos.Name = "ugb_ccostos"
        Me.ugb_ccostos.Size = New System.Drawing.Size(321, 405)
        Me.ugb_ccostos.TabIndex = 200
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(13, 73)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel4.TabIndex = 202
        Me.UltraLabel4.Text = "Hasta el Mes :"
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 47)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel5.TabIndex = 203
        Me.UltraLabel5.Text = "Desde el Mes :"
        '
        'uce_Mes2
        '
        Me.uce_Mes2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes2.Location = New System.Drawing.Point(98, 69)
        Me.uce_Mes2.Name = "uce_Mes2"
        Me.uce_Mes2.Size = New System.Drawing.Size(143, 21)
        Me.uce_Mes2.TabIndex = 200
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(98, 43)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(143, 21)
        Me.uce_Mes.TabIndex = 201
        '
        'CO_RP_Analisis5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(343, 463)
        Me.Controls.Add(Me.ugb_ccostos)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Imprimir)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_Analisis5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis por Centro de Costo"
        CType(Me.uds_cc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_cc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_ccostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_ccostos.ResumeLayout(False)
        Me.ugb_ccostos.PerformLayout()
        CType(Me.uce_Mes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uds_cc As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_cc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ulbl_etiqueta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Imprimir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_ccostos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes2 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
