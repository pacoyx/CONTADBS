<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_Caja_Ape
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ume_soles = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_dolares = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_des_cajero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_fecha = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idcaja = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_cod_cajero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_des_cajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.uce_turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idcaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.txt_cod_cajero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator1, Me.Tool_salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(336, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ume_soles
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.ume_soles.Appearance = Appearance6
        Me.ume_soles.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_soles.InputMask = "{double:-9.3}"
        Me.ume_soles.Location = New System.Drawing.Point(94, 30)
        Me.ume_soles.Name = "ume_soles"
        Me.ume_soles.Size = New System.Drawing.Size(140, 20)
        Me.ume_soles.TabIndex = 135
        '
        'UltraLabel32
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance7
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(26, 31)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(35, 16)
        Me.UltraLabel32.TabIndex = 136
        Me.UltraLabel32.Text = "Soles"
        '
        'UltraLabel1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(26, 57)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(47, 16)
        Me.UltraLabel1.TabIndex = 136
        Me.UltraLabel1.Text = "Dolares"
        '
        'ume_dolares
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.ume_dolares.Appearance = Appearance4
        Me.ume_dolares.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_dolares.InputMask = "{double:-9.3}"
        Me.ume_dolares.Location = New System.Drawing.Point(94, 56)
        Me.ume_dolares.Name = "ume_dolares"
        Me.ume_dolares.Size = New System.Drawing.Size(140, 20)
        Me.ume_dolares.TabIndex = 135
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ume_dolares)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.ume_soles)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel32)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(15, 230)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(309, 84)
        Me.UltraGroupBox1.TabIndex = 137
        Me.UltraGroupBox1.Text = "Saldos de Inicio"
        '
        'txt_des_cajero
        '
        Me.txt_des_cajero.Location = New System.Drawing.Point(114, 38)
        Me.txt_des_cajero.Name = "txt_des_cajero"
        Me.txt_des_cajero.ReadOnly = True
        Me.txt_des_cajero.Size = New System.Drawing.Size(169, 21)
        Me.txt_des_cajero.TabIndex = 143
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(9, 71)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel3.TabIndex = 141
        Me.UltraLabel3.Text = "Turno :"
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(9, 45)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel2.TabIndex = 139
        Me.UltraLabel2.Text = "Cajero(a) :"
        '
        'UltraLabel4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(9, 16)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel4.TabIndex = 140
        Me.UltraLabel4.Text = "Fecha :"
        '
        'ume_fecha
        '
        Me.ume_fecha.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fecha.InputMask = "{LOC}dd/mm/yyyy"
        Me.ume_fecha.Location = New System.Drawing.Point(73, 10)
        Me.ume_fecha.Name = "ume_fecha"
        Me.ume_fecha.Size = New System.Drawing.Size(75, 20)
        Me.ume_fecha.TabIndex = 138
        Me.ume_fecha.Text = "UltraMaskedEdit1"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.txt_cod_cajero)
        Me.UltraGroupBox2.Controls.Add(Me.uce_turno)
        Me.UltraGroupBox2.Controls.Add(Me.txt_des_cajero)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox2.Controls.Add(Me.ume_fecha)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(15, 121)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(309, 98)
        Me.UltraGroupBox2.TabIndex = 144
        '
        'uce_turno
        '
        Me.uce_turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_turno.Location = New System.Drawing.Point(73, 67)
        Me.uce_turno.Name = "uce_turno"
        Me.uce_turno.Size = New System.Drawing.Size(210, 21)
        Me.uce_turno.TabIndex = 144
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel5
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance9
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(12, 17)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(58, 19)
        Me.UltraLabel5.TabIndex = 145
        Me.UltraLabel5.Text = "Nº Caja"
        '
        'txt_idcaja
        '
        Me.txt_idcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idcaja.Location = New System.Drawing.Point(76, 13)
        Me.txt_idcaja.Name = "txt_idcaja"
        Me.txt_idcaja.ReadOnly = True
        Me.txt_idcaja.Size = New System.Drawing.Size(124, 26)
        Me.txt_idcaja.TabIndex = 145
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.txt_idcaja)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(15, 59)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(309, 51)
        Me.UltraGroupBox3.TabIndex = 146
        '
        'txt_cod_cajero
        '
        Me.txt_cod_cajero.Location = New System.Drawing.Point(73, 38)
        Me.txt_cod_cajero.Name = "txt_cod_cajero"
        Me.txt_cod_cajero.ReadOnly = True
        Me.txt_cod_cajero.Size = New System.Drawing.Size(41, 21)
        Me.txt_cod_cajero.TabIndex = 145
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'UltraLabel6
        '
        Appearance1.BackColor = System.Drawing.Color.Purple
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.UltraLabel6.Appearance = Appearance1
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.UltraLabel6.Location = New System.Drawing.Point(15, 34)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(309, 19)
        Me.UltraLabel6.TabIndex = 151
        Me.UltraLabel6.Text = "Apertura de Caja"
        '
        'FA_PR_Caja_Ape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(336, 323)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FA_PR_Caja_Ape"
        Me.Text = "Apertura de Caja"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_des_cajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.uce_turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idcaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.txt_cod_cajero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ume_soles As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_dolares As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_des_cajero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_fecha As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_turno As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idcaja As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_cod_cajero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
End Class
