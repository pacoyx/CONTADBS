<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_Apertura_Tmp
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_CUENTA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_IDANEXO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_TDOC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_SDOC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AD_NDOC")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DEBE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HABER")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_CUENTA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_IDANEXO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_TDOC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_SDOC")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_NDOC")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DEBE")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HABER")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ume_fecha = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txt_subdiario = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.ubtn_Generar_Asiento = New Infragistics.Win.Misc.UltraButton
        Me.uds_asiento_tmp = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_asiento_tmp = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ume_tot_d = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_tot_h = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_subdiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_asiento_tmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_asiento_tmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ume_fecha)
        Me.UltraGroupBox1.Controls.Add(Me.txt_subdiario)
        Me.UltraGroupBox1.Controls.Add(Me.une_Ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_Cancelar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_Generar_Asiento)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(768, 73)
        Me.UltraGroupBox1.TabIndex = 35
        '
        'ume_fecha
        '
        Me.ume_fecha.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fecha.InputMask = "{LOC}dd/mm/yyyy"
        Me.ume_fecha.Location = New System.Drawing.Point(207, 18)
        Me.ume_fecha.Name = "ume_fecha"
        Me.ume_fecha.Size = New System.Drawing.Size(82, 20)
        Me.ume_fecha.TabIndex = 33
        Me.ume_fecha.Text = "UltraMaskedEdit1"
        '
        'txt_subdiario
        '
        Me.txt_subdiario.Location = New System.Drawing.Point(84, 40)
        Me.txt_subdiario.Name = "txt_subdiario"
        Me.txt_subdiario.Size = New System.Drawing.Size(205, 21)
        Me.txt_subdiario.TabIndex = 32
        '
        'une_Ayo
        '
        Me.une_Ayo.Location = New System.Drawing.Point(84, 17)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 31
        '
        'UltraLabel4
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance23
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(159, 21)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel4.TabIndex = 30
        Me.UltraLabel4.Text = "Fecha :"
        '
        'ubtn_Cancelar
        '
        Appearance7.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.ubtn_Cancelar.Appearance = Appearance7
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(679, 32)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(83, 28)
        Me.ubtn_Cancelar.TabIndex = 1
        Me.ubtn_Cancelar.Text = "Cancelar"
        '
        'UltraLabel3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance8
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(18, 44)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel3.TabIndex = 30
        Me.UltraLabel3.Text = "SubDiario :"
        '
        'UltraLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(18, 21)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel2.TabIndex = 30
        Me.UltraLabel2.Text = "Periodo :"
        '
        'ubtn_Generar_Asiento
        '
        Appearance4.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.ubtn_Generar_Asiento.Appearance = Appearance4
        Me.ubtn_Generar_Asiento.Location = New System.Drawing.Point(560, 32)
        Me.ubtn_Generar_Asiento.Name = "ubtn_Generar_Asiento"
        Me.ubtn_Generar_Asiento.Size = New System.Drawing.Size(113, 28)
        Me.ubtn_Generar_Asiento.TabIndex = 1
        Me.ubtn_Generar_Asiento.Text = "Generar Asiento"
        '
        'uds_asiento_tmp
        '
        Me.uds_asiento_tmp.AllowDelete = False
        UltraDataColumn2.DataType = GetType(Long)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        Me.uds_asiento_tmp.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'ug_asiento_tmp
        '
        Me.ug_asiento_tmp.DataSource = Me.uds_asiento_tmp
        Me.ug_asiento_tmp.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CUENTA"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 101
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "ANEXO"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 80
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "DOC"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 64
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "SERIE"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 47
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "NUMERO"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 223
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 109
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.Width = 92
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.ug_asiento_tmp.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_asiento_tmp.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_asiento_tmp.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_asiento_tmp.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_asiento_tmp.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_asiento_tmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_asiento_tmp.Location = New System.Drawing.Point(15, 118)
        Me.ug_asiento_tmp.Name = "ug_asiento_tmp"
        Me.ug_asiento_tmp.Size = New System.Drawing.Size(765, 328)
        Me.ug_asiento_tmp.TabIndex = 36
        Me.ug_asiento_tmp.Text = "UltraGrid1"
        '
        'ume_tot_d
        '
        Me.ume_tot_d.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance45.FontData.SizeInPoints = 9.0!
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextHAlignAsString = "Right"
        Me.ume_tot_d.Appearance = Appearance45
        Me.ume_tot_d.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ume_tot_d.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tot_d.InputMask = "{double:-9.2}"
        Me.ume_tot_d.Location = New System.Drawing.Point(569, 452)
        Me.ume_tot_d.Name = "ume_tot_d"
        Me.ume_tot_d.ReadOnly = True
        Me.ume_tot_d.Size = New System.Drawing.Size(102, 21)
        Me.ume_tot_d.TabIndex = 38
        '
        'ume_tot_h
        '
        Me.ume_tot_h.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance63.FontData.SizeInPoints = 9.0!
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextHAlignAsString = "Right"
        Me.ume_tot_h.Appearance = Appearance63
        Me.ume_tot_h.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ume_tot_h.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tot_h.InputMask = "{double:-9.2}"
        Me.ume_tot_h.Location = New System.Drawing.Point(677, 452)
        Me.ume_tot_h.Name = "ume_tot_h"
        Me.ume_tot_h.ReadOnly = True
        Me.ume_tot_h.Size = New System.Drawing.Size(103, 21)
        Me.ume_tot_h.TabIndex = 37
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Navy
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.UltraLabel1.Location = New System.Drawing.Point(0, 12)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(789, 21)
        Me.UltraLabel1.TabIndex = 39
        Me.UltraLabel1.Text = "Vista temporal del Asiento de Apertura Contable"
        '
        'CO_PR_Apertura_Tmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(789, 485)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ume_tot_d)
        Me.Controls.Add(Me.ume_tot_h)
        Me.Controls.Add(Me.ug_asiento_tmp)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_Apertura_Tmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura Temporal"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_subdiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_asiento_tmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_asiento_tmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_fecha As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_subdiario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Generar_Asiento As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_asiento_tmp As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_asiento_tmp As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ume_tot_d As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_tot_h As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
