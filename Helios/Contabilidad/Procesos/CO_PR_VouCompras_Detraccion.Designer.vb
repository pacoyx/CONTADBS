<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_VouCompras_Detraccion
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
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_PR_VouCompras_Detraccion))
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ugb_DatosDetra = New Infragistics.Win.Misc.UltraGroupBox
        Me.uce_Servicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Tipo_Servicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ume_Valor_Razonable = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_Fec_Detra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txt_Num_Dep = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ume_Tasa_Detra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.btn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.btn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.lbl_valor_razonable = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.ugb_DatosDetra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_DatosDetra.SuspendLayout()
        CType(Me.uce_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Tipo_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Num_Dep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_DatosDetra
        '
        Me.ugb_DatosDetra.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_DatosDetra.Controls.Add(Me.uce_Servicio)
        Me.ugb_DatosDetra.Controls.Add(Me.uce_Tipo_Servicio)
        Me.ugb_DatosDetra.Controls.Add(Me.ume_Valor_Razonable)
        Me.ugb_DatosDetra.Controls.Add(Me.ume_Fec_Detra)
        Me.ugb_DatosDetra.Controls.Add(Me.txt_Num_Dep)
        Me.ugb_DatosDetra.Controls.Add(Me.ume_Tasa_Detra)
        Me.ugb_DatosDetra.Controls.Add(Me.UltraLabel21)
        Me.ugb_DatosDetra.Controls.Add(Me.btn_Cancelar)
        Me.ugb_DatosDetra.Controls.Add(Me.btn_Aceptar)
        Me.ugb_DatosDetra.Controls.Add(Me.UltraLabel7)
        Me.ugb_DatosDetra.Controls.Add(Me.UltraLabel5)
        Me.ugb_DatosDetra.Controls.Add(Me.lbl_valor_razonable)
        Me.ugb_DatosDetra.Controls.Add(Me.UltraLabel9)
        Me.ugb_DatosDetra.Controls.Add(Me.UltraLabel1)
        Me.ugb_DatosDetra.Controls.Add(Me.UltraLabel3)
        Me.ugb_DatosDetra.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_DatosDetra.Location = New System.Drawing.Point(2, 3)
        Me.ugb_DatosDetra.Name = "ugb_DatosDetra"
        Me.ugb_DatosDetra.Size = New System.Drawing.Size(502, 181)
        Me.ugb_DatosDetra.TabIndex = 61
        Me.ugb_DatosDetra.Text = "Ingrese los datos de la detraccion"
        '
        'uce_Servicio
        '
        Me.uce_Servicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Servicio.Location = New System.Drawing.Point(122, 59)
        Me.uce_Servicio.Name = "uce_Servicio"
        Me.uce_Servicio.Size = New System.Drawing.Size(364, 21)
        Me.uce_Servicio.TabIndex = 1
        '
        'uce_Tipo_Servicio
        '
        Me.uce_Tipo_Servicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Tipo_Servicio.Location = New System.Drawing.Point(122, 33)
        Me.uce_Tipo_Servicio.Name = "uce_Tipo_Servicio"
        Me.uce_Tipo_Servicio.Size = New System.Drawing.Size(364, 21)
        Me.uce_Tipo_Servicio.TabIndex = 0
        '
        'ume_Valor_Razonable
        '
        Appearance91.TextHAlignAsString = "Right"
        Me.ume_Valor_Razonable.Appearance = Appearance91
        Me.ume_Valor_Razonable.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Valor_Razonable.InputMask = "{double:-9.2}"
        Me.ume_Valor_Razonable.Location = New System.Drawing.Point(395, 115)
        Me.ume_Valor_Razonable.Name = "ume_Valor_Razonable"
        Me.ume_Valor_Razonable.Size = New System.Drawing.Size(91, 20)
        Me.ume_Valor_Razonable.TabIndex = 7
        Me.ume_Valor_Razonable.Visible = False
        '
        'ume_Fec_Detra
        '
        Appearance21.Image = CType(resources.GetObject("Appearance21.Image"), Object)
        Appearance21.TextHAlignAsString = "Right"
        Me.ume_Fec_Detra.Appearance = Appearance21
        Me.ume_Fec_Detra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Date]
        Me.ume_Fec_Detra.InputMask = "{date}"
        Me.ume_Fec_Detra.Location = New System.Drawing.Point(395, 89)
        Me.ume_Fec_Detra.Name = "ume_Fec_Detra"
        Me.ume_Fec_Detra.Size = New System.Drawing.Size(91, 20)
        Me.ume_Fec_Detra.TabIndex = 4
        Me.ume_Fec_Detra.Text = "UltraMaskedEdit1"
        '
        'txt_Num_Dep
        '
        Me.txt_Num_Dep.Location = New System.Drawing.Point(130, 112)
        Me.txt_Num_Dep.Name = "txt_Num_Dep"
        Me.txt_Num_Dep.Size = New System.Drawing.Size(95, 21)
        Me.txt_Num_Dep.TabIndex = 3
        '
        'ume_Tasa_Detra
        '
        Appearance66.TextHAlignAsString = "Right"
        Me.ume_Tasa_Detra.Appearance = Appearance66
        Me.ume_Tasa_Detra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Tasa_Detra.InputMask = "nn"
        Me.ume_Tasa_Detra.Location = New System.Drawing.Point(122, 87)
        Me.ume_Tasa_Detra.Name = "ume_Tasa_Detra"
        Me.ume_Tasa_Detra.Size = New System.Drawing.Size(29, 20)
        Me.ume_Tasa_Detra.TabIndex = 2
        '
        'UltraLabel21
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance57
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(153, 91)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel21.TabIndex = 63
        Me.UltraLabel21.Text = "%"
        '
        'btn_Cancelar
        '
        Appearance5.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance5.TextHAlignAsString = "Right"
        Me.btn_Cancelar.Appearance = Appearance5
        Me.btn_Cancelar.Location = New System.Drawing.Point(262, 145)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(78, 28)
        Me.btn_Cancelar.TabIndex = 6
        Me.btn_Cancelar.Text = "&Cancelar"
        '
        'btn_Aceptar
        '
        Appearance6.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance6.TextHAlignAsString = "Right"
        Me.btn_Aceptar.Appearance = Appearance6
        Me.btn_Aceptar.Location = New System.Drawing.Point(181, 145)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 28)
        Me.btn_Aceptar.TabIndex = 5
        Me.btn_Aceptar.Text = "&Aceptar"
        '
        'UltraLabel7
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance69
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(14, 37)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel7.TabIndex = 59
        Me.UltraLabel7.Text = "Tipo de Servicio"
        '
        'UltraLabel5
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance29
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(14, 63)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel5.TabIndex = 57
        Me.UltraLabel5.Text = "Bien o Servicio"
        '
        'lbl_valor_razonable
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.lbl_valor_razonable.Appearance = Appearance81
        Me.lbl_valor_razonable.AutoSize = True
        Me.lbl_valor_razonable.Location = New System.Drawing.Point(296, 118)
        Me.lbl_valor_razonable.Name = "lbl_valor_razonable"
        Me.lbl_valor_razonable.Size = New System.Drawing.Size(88, 14)
        Me.lbl_valor_razonable.TabIndex = 58
        Me.lbl_valor_razonable.Text = "Valor Razonable"
        Me.lbl_valor_razonable.Visible = False
        '
        'UltraLabel9
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance1
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(14, 116)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(108, 14)
        Me.UltraLabel9.TabIndex = 58
        Me.UltraLabel9.Text = "Numero de Deposito"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(296, 92)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(93, 14)
        Me.UltraLabel1.TabIndex = 56
        Me.UltraLabel1.Text = "Fecha Detraccion"
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(14, 89)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel3.TabIndex = 56
        Me.UltraLabel3.Text = "Tasa Detraccion"
        '
        'CO_PR_VouCompras_Detraccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(506, 186)
        Me.Controls.Add(Me.ugb_DatosDetra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_VouCompras_Detraccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la Detraccion"
        CType(Me.ugb_DatosDetra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_DatosDetra.ResumeLayout(False)
        Me.ugb_DatosDetra.PerformLayout()
        CType(Me.uce_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Tipo_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Num_Dep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ugb_DatosDetra As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_Valor_Razonable As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Fec_Detra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_Num_Dep As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ume_Tasa_Detra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_valor_razonable As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Tipo_Servicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Servicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
