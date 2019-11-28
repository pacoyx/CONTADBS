<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_AdmMes
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Me.ToolS_AdmMes = New System.Windows.Forms.ToolStrip
        Me.Tool_Cerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Abrir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox
        Me.txt_estado = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_pwd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.ugb_periodo = New Infragistics.Win.Misc.UltraGroupBox
        Me.une_periodo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.ubtn_agregar = New Infragistics.Win.Misc.UltraButton
        Me.ug_periodo = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Periodo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_Abrir_Periodo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.Tool_CerrarPeriodo = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolS_AdmMes.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_periodo.SuspendLayout()
        CType(Me.une_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_AdmMes
        '
        Me.ToolS_AdmMes.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_AdmMes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Cerrar, Me.ToolStripSeparator1, Me.Tool_Abrir, Me.ToolStripSeparator2})
        Me.ToolS_AdmMes.Location = New System.Drawing.Point(3, 16)
        Me.ToolS_AdmMes.Name = "ToolS_AdmMes"
        Me.ToolS_AdmMes.Size = New System.Drawing.Size(448, 25)
        Me.ToolS_AdmMes.TabIndex = 0
        Me.ToolS_AdmMes.Text = "ToolStrip1"
        '
        'Tool_Cerrar
        '
        Me.Tool_Cerrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Cerrar.Image = Global.Contabilidad.My.Resources.Resources._16__Lock_on_
        Me.Tool_Cerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cerrar.Name = "Tool_Cerrar"
        Me.Tool_Cerrar.Size = New System.Drawing.Size(89, 22)
        Me.Tool_Cerrar.Text = "Cerrar Mes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Abrir
        '
        Me.Tool_Abrir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Abrir.Image = Global.Contabilidad.My.Resources.Resources._16__Lock_off_
        Me.Tool_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Abrir.Name = "Tool_Abrir"
        Me.Tool_Abrir.Size = New System.Drawing.Size(81, 22)
        Me.Tool_Abrir.Text = "Abrir Mes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Controls.Add(Me.txt_estado)
        Me.ugb_Parametros.Controls.Add(Me.ToolS_AdmMes)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel3)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(10, 249)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(454, 138)
        Me.ugb_Parametros.TabIndex = 8
        Me.ugb_Parametros.Text = "Cerrar / Aperturar Mes"
        '
        'txt_estado
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.txt_estado.Appearance = Appearance3
        Me.txt_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estado.Location = New System.Drawing.Point(63, 105)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.ReadOnly = True
        Me.txt_estado.Size = New System.Drawing.Size(138, 24)
        Me.txt_estado.TabIndex = 13
        Me.txt_estado.Text = "Cerrado"
        '
        'une_Ayo
        '
        Me.une_Ayo.Enabled = False
        Me.une_Ayo.Location = New System.Drawing.Point(63, 51)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(13, 55)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(11, 111)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Estado :"
        '
        'UltraLabel4
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance2
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(11, 82)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(63, 78)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_Mes.TabIndex = 1
        '
        'txt_pwd
        '
        Me.txt_pwd.Location = New System.Drawing.Point(92, 34)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(213, 21)
        Me.txt_pwd.TabIndex = 2
        '
        'UltraLabel2
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance9
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(20, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel2.TabIndex = 12
        Me.UltraLabel2.Text = "Clave Adm :"
        '
        'ugb_periodo
        '
        Me.ugb_periodo.Controls.Add(Me.une_periodo)
        Me.ugb_periodo.Controls.Add(Me.ubtn_agregar)
        Me.ugb_periodo.Controls.Add(Me.ug_periodo)
        Me.ugb_periodo.Controls.Add(Me.ToolStrip1)
        Me.ugb_periodo.Location = New System.Drawing.Point(9, 80)
        Me.ugb_periodo.Name = "ugb_periodo"
        Me.ugb_periodo.Size = New System.Drawing.Size(452, 152)
        Me.ugb_periodo.TabIndex = 9
        Me.ugb_periodo.Text = " Administrar Periodos "
        '
        'une_periodo
        '
        Me.une_periodo.Location = New System.Drawing.Point(267, 49)
        Me.une_periodo.MaskInput = "nnnn"
        Me.une_periodo.Name = "une_periodo"
        Me.une_periodo.Size = New System.Drawing.Size(100, 21)
        Me.une_periodo.TabIndex = 4
        '
        'ubtn_agregar
        '
        Me.ubtn_agregar.Location = New System.Drawing.Point(268, 76)
        Me.ubtn_agregar.Name = "ubtn_agregar"
        Me.ubtn_agregar.Size = New System.Drawing.Size(99, 27)
        Me.ubtn_agregar.TabIndex = 3
        Me.ubtn_agregar.Text = "Agregar Periodo"
        '
        'ug_periodo
        '
        Me.ug_periodo.DataSource = Me.uds_Periodo
        Me.ug_periodo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 78
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ug_periodo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_periodo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_periodo.Location = New System.Drawing.Point(11, 44)
        Me.ug_periodo.Name = "ug_periodo"
        Me.ug_periodo.Size = New System.Drawing.Size(242, 102)
        Me.ug_periodo.TabIndex = 2
        Me.ug_periodo.Text = "UltraGrid1"
        '
        'uds_Periodo
        '
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_Periodo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_Abrir_Periodo, Me.ToolStripSeparator6, Me.Tool_CerrarPeriodo})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(446, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Abrir_Periodo
        '
        Me.Tool_Abrir_Periodo.Image = Global.Contabilidad.My.Resources.Resources._16__Redo_
        Me.Tool_Abrir_Periodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Abrir_Periodo.Name = "Tool_Abrir_Periodo"
        Me.Tool_Abrir_Periodo.Size = New System.Drawing.Size(97, 22)
        Me.Tool_Abrir_Periodo.Text = "Abrir Periodo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_CerrarPeriodo
        '
        Me.Tool_CerrarPeriodo.Image = Global.Contabilidad.My.Resources.Resources._16__Key_
        Me.Tool_CerrarPeriodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_CerrarPeriodo.Name = "Tool_CerrarPeriodo"
        Me.Tool_CerrarPeriodo.Size = New System.Drawing.Size(103, 22)
        Me.Tool_CerrarPeriodo.Text = "Cerrar Periodo"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(476, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripButton2.Text = "Salir  "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'CO_PR_AdmMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(476, 401)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.ugb_periodo)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.UltraLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_AdmMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Mes"
        Me.ToolS_AdmMes.ResumeLayout(False)
        Me.ToolS_AdmMes.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_periodo.ResumeLayout(False)
        Me.ugb_periodo.PerformLayout()
        CType(Me.une_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_AdmMes As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Cerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Abrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_pwd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_estado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_periodo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ug_periodo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Periodo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents une_periodo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ubtn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Abrir_Periodo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_CerrarPeriodo As System.Windows.Forms.ToolStripButton
End Class
