<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_IngClienteRapido
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_DatosCliente = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_dir = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Grabar = New Infragistics.Win.Misc.UltraButton()
        Me.btn_sunat = New Infragistics.Win.Misc.UltraButton()
        CType(Me.ugb_DatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_DatosCliente.SuspendLayout()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_DatosCliente
        '
        Me.ugb_DatosCliente.Controls.Add(Me.txt_dir)
        Me.ugb_DatosCliente.Controls.Add(Me.txt_num_doc)
        Me.ugb_DatosCliente.Controls.Add(Me.UltraLabel1)
        Me.ugb_DatosCliente.Controls.Add(Me.UltraLabel3)
        Me.ugb_DatosCliente.Controls.Add(Me.UltraLabel4)
        Me.ugb_DatosCliente.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_DatosCliente.Controls.Add(Me.txt_nombres)
        Me.ugb_DatosCliente.Controls.Add(Me.UltraLabel2)
        Me.ugb_DatosCliente.Location = New System.Drawing.Point(12, 12)
        Me.ugb_DatosCliente.Name = "ugb_DatosCliente"
        Me.ugb_DatosCliente.Size = New System.Drawing.Size(410, 148)
        Me.ugb_DatosCliente.TabIndex = 0
        Me.ugb_DatosCliente.Text = "Datos Basicos del Cliente"
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(114, 115)
        Me.txt_dir.MaxLength = 250
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(276, 21)
        Me.txt_dir.TabIndex = 2
        '
        'txt_num_doc
        '
        Me.txt_num_doc.Location = New System.Drawing.Point(114, 86)
        Me.txt_num_doc.MaxLength = 11
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(142, 21)
        Me.txt_num_doc.TabIndex = 2
        '
        'UltraLabel1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(30, 119)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Direccion"
        '
        'UltraLabel3
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(30, 90)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel3.TabIndex = 11
        Me.UltraLabel3.Text = "Numero Doc."
        '
        'UltraLabel4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance12
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(30, 63)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "Tipo Doc."
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDoc.Location = New System.Drawing.Point(114, 59)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(276, 21)
        Me.uce_TipoDoc.TabIndex = 1
        '
        'txt_nombres
        '
        Me.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombres.Location = New System.Drawing.Point(114, 32)
        Me.txt_nombres.MaxLength = 50
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(276, 21)
        Me.txt_nombres.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(29, 36)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel2.TabIndex = 6
        Me.UltraLabel2.Text = "Nombres"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(347, 164)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 26)
        Me.ubtn_Cancelar.TabIndex = 1
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'ubtn_Grabar
        '
        Me.ubtn_Grabar.Location = New System.Drawing.Point(266, 164)
        Me.ubtn_Grabar.Name = "ubtn_Grabar"
        Me.ubtn_Grabar.Size = New System.Drawing.Size(75, 26)
        Me.ubtn_Grabar.TabIndex = 1
        Me.ubtn_Grabar.Text = "&Grabar"
        '
        'btn_sunat
        '
        Me.btn_sunat.Location = New System.Drawing.Point(16, 164)
        Me.btn_sunat.Name = "btn_sunat"
        Me.btn_sunat.Size = New System.Drawing.Size(75, 26)
        Me.btn_sunat.TabIndex = 2
        Me.btn_sunat.Text = "&Sunat"
        '
        'FA_PR_IngClienteRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(431, 192)
        Me.Controls.Add(Me.btn_sunat)
        Me.Controls.Add(Me.ubtn_Grabar)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ugb_DatosCliente)
        Me.Name = "FA_PR_IngClienteRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Cliente Rapido"
        CType(Me.ugb_DatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_DatosCliente.ResumeLayout(False)
        Me.ugb_DatosCliente.PerformLayout()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ugb_DatosCliente As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_num_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Grabar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_dir As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_sunat As Infragistics.Win.Misc.UltraButton
End Class
