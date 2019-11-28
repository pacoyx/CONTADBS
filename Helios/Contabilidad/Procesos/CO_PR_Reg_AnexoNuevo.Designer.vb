<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_Reg_AnexoNuevo
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox
        Me.uchk_EsRelacionado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txt_Razon = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_num_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_TipoEmp = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_TipoAnexo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ubtn_cancelar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.txt_Razon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_data
        '
        Me.ugb_data.Controls.Add(Me.uchk_EsRelacionado)
        Me.ugb_data.Controls.Add(Me.txt_Razon)
        Me.ugb_data.Controls.Add(Me.UltraLabel5)
        Me.ugb_data.Controls.Add(Me.txt_num_doc)
        Me.ugb_data.Controls.Add(Me.UltraLabel2)
        Me.ugb_data.Controls.Add(Me.UltraLabel4)
        Me.ugb_data.Controls.Add(Me.UltraLabel3)
        Me.ugb_data.Controls.Add(Me.UltraLabel1)
        Me.ugb_data.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_data.Controls.Add(Me.uce_TipoEmp)
        Me.ugb_data.Controls.Add(Me.uce_TipoAnexo)
        Me.ugb_data.Location = New System.Drawing.Point(8, 32)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(486, 170)
        Me.ugb_data.TabIndex = 1
        '
        'uchk_EsRelacionado
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.uchk_EsRelacionado.Appearance = Appearance1
        Me.uchk_EsRelacionado.BackColor = System.Drawing.Color.Transparent
        Me.uchk_EsRelacionado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_EsRelacionado.Location = New System.Drawing.Point(103, 145)
        Me.uchk_EsRelacionado.Name = "uchk_EsRelacionado"
        Me.uchk_EsRelacionado.Size = New System.Drawing.Size(120, 20)
        Me.uchk_EsRelacionado.TabIndex = 5
        Me.uchk_EsRelacionado.Text = "Relacionado"
        '
        'txt_Razon
        '
        Me.txt_Razon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Razon.Location = New System.Drawing.Point(103, 118)
        Me.txt_Razon.MaxLength = 100
        Me.txt_Razon.Name = "txt_Razon"
        Me.txt_Razon.Size = New System.Drawing.Size(373, 21)
        Me.txt_Razon.TabIndex = 4
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(19, 122)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel5.TabIndex = 1
        Me.UltraLabel5.Text = "Razon Social"
        '
        'txt_num_doc
        '
        Me.txt_num_doc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_num_doc.Location = New System.Drawing.Point(103, 91)
        Me.txt_num_doc.MaxLength = 11
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(142, 21)
        Me.txt_num_doc.TabIndex = 3
        '
        'UltraLabel2
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance15
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(19, 95)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Numero Doc."
        '
        'UltraLabel4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance12
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(19, 68)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Tipo Doc."
        '
        'UltraLabel3
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance14
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(19, 41)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel3.TabIndex = 1
        Me.UltraLabel3.Text = "Tipo Empresa"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(19, 14)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Tipo Anexo"
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDoc.Location = New System.Drawing.Point(103, 64)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(243, 21)
        Me.uce_TipoDoc.TabIndex = 2
        '
        'uce_TipoEmp
        '
        Me.uce_TipoEmp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_TipoEmp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoEmp.Location = New System.Drawing.Point(103, 37)
        Me.uce_TipoEmp.Name = "uce_TipoEmp"
        Me.uce_TipoEmp.Size = New System.Drawing.Size(182, 21)
        Me.uce_TipoEmp.TabIndex = 1
        '
        'uce_TipoAnexo
        '
        Me.uce_TipoAnexo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_TipoAnexo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoAnexo.Location = New System.Drawing.Point(103, 10)
        Me.uce_TipoAnexo.Name = "uce_TipoAnexo"
        Me.uce_TipoAnexo.Size = New System.Drawing.Size(182, 21)
        Me.uce_TipoAnexo.TabIndex = 0
        '
        'ubtn_cancelar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.ubtn_cancelar.Appearance = Appearance3
        Me.ubtn_cancelar.Location = New System.Drawing.Point(408, 208)
        Me.ubtn_cancelar.Name = "ubtn_cancelar"
        Me.ubtn_cancelar.Size = New System.Drawing.Size(86, 31)
        Me.ubtn_cancelar.TabIndex = 1
        Me.ubtn_cancelar.Text = "&Cancelar"
        '
        'ubtn_Aceptar
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.ubtn_Aceptar.Appearance = Appearance2
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(322, 208)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(80, 31)
        Me.ubtn_Aceptar.TabIndex = 0
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'UltraLabel6
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance16
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 5)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(230, 21)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Registro de Anexo Rapido ..."
        '
        'CO_PR_Reg_AnexoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(499, 242)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ugb_data)
        Me.Controls.Add(Me.ubtn_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_Reg_AnexoNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Anexo"
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        Me.ugb_data.PerformLayout()
        CType(Me.txt_Razon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_EsRelacionado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_Razon As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_num_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_TipoEmp As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_TipoAnexo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
End Class
