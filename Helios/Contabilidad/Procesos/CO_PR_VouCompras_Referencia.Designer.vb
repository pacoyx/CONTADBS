<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_VouCompras_Referencia
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_PR_VouCompras_Referencia))
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ugb_ref = New Infragistics.Win.Misc.UltraGroupBox
        Me.btn_Aceptar_Ref = New Infragistics.Win.Misc.UltraButton
        Me.ume_Monto_Igv_Ref = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_BaseI_Ref = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.ume_Fec_Ref = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_TipoDoc_Ref = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_NumDoc_Ref = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_SerieDoc_Ref = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_cod_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        CType(Me.ugb_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_ref.SuspendLayout()
        CType(Me.uce_TipoDoc_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDoc_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_ref
        '
        Me.ugb_ref.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_ref.Controls.Add(Me.txt_cod_doc)
        Me.ugb_ref.Controls.Add(Me.btn_Aceptar_Ref)
        Me.ugb_ref.Controls.Add(Me.ume_Monto_Igv_Ref)
        Me.ugb_ref.Controls.Add(Me.ume_BaseI_Ref)
        Me.ugb_ref.Controls.Add(Me.UltraLabel13)
        Me.ugb_ref.Controls.Add(Me.UltraLabel11)
        Me.ugb_ref.Controls.Add(Me.ume_Fec_Ref)
        Me.ugb_ref.Controls.Add(Me.UltraLabel28)
        Me.ugb_ref.Controls.Add(Me.uce_TipoDoc_Ref)
        Me.ugb_ref.Controls.Add(Me.txt_NumDoc_Ref)
        Me.ugb_ref.Controls.Add(Me.txt_SerieDoc_Ref)
        Me.ugb_ref.Controls.Add(Me.UltraLabel1)
        Me.ugb_ref.Controls.Add(Me.UltraLabel29)
        Me.ugb_ref.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_ref.Location = New System.Drawing.Point(2, 1)
        Me.ugb_ref.Name = "ugb_ref"
        Me.ugb_ref.Size = New System.Drawing.Size(486, 126)
        Me.ugb_ref.TabIndex = 1
        Me.ugb_ref.Text = "Informacion del Comprobante de referencia"
        Me.ugb_ref.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btn_Aceptar_Ref
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.btn_Aceptar_Ref.Appearance = Appearance3
        Me.btn_Aceptar_Ref.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat
        Me.btn_Aceptar_Ref.Location = New System.Drawing.Point(401, 88)
        Me.btn_Aceptar_Ref.Name = "btn_Aceptar_Ref"
        Me.btn_Aceptar_Ref.Size = New System.Drawing.Size(76, 27)
        Me.btn_Aceptar_Ref.TabIndex = 6
        Me.btn_Aceptar_Ref.Text = "&Aceptar"
        '
        'ume_Monto_Igv_Ref
        '
        Appearance67.TextHAlignAsString = "Right"
        Me.ume_Monto_Igv_Ref.Appearance = Appearance67
        Me.ume_Monto_Igv_Ref.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ume_Monto_Igv_Ref.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Monto_Igv_Ref.InputMask = "{double:-9.2}"
        Me.ume_Monto_Igv_Ref.Location = New System.Drawing.Point(377, 34)
        Me.ume_Monto_Igv_Ref.Name = "ume_Monto_Igv_Ref"
        Me.ume_Monto_Igv_Ref.Size = New System.Drawing.Size(100, 20)
        Me.ume_Monto_Igv_Ref.TabIndex = 4
        '
        'ume_BaseI_Ref
        '
        Appearance68.TextHAlignAsString = "Right"
        Me.ume_BaseI_Ref.Appearance = Appearance68
        Me.ume_BaseI_Ref.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ume_BaseI_Ref.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_BaseI_Ref.InputMask = "{double:-9.2}"
        Me.ume_BaseI_Ref.Location = New System.Drawing.Point(377, 55)
        Me.ume_BaseI_Ref.Name = "ume_BaseI_Ref"
        Me.ume_BaseI_Ref.Size = New System.Drawing.Size(100, 20)
        Me.ume_BaseI_Ref.TabIndex = 5
        '
        'UltraLabel13
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance78
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(309, 37)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel13.TabIndex = 58
        Me.UltraLabel13.Text = "Monto IGV"
        '
        'UltraLabel11
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance80
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(285, 58)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(82, 14)
        Me.UltraLabel11.TabIndex = 59
        Me.UltraLabel11.Text = "Base Imponible"
        '
        'ume_Fec_Ref
        '
        Appearance21.Image = CType(resources.GetObject("Appearance21.Image"), Object)
        Appearance21.TextHAlignAsString = "Right"
        Me.ume_Fec_Ref.Appearance = Appearance21
        Me.ume_Fec_Ref.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ume_Fec_Ref.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Date]
        Me.ume_Fec_Ref.InputMask = "{date}"
        Me.ume_Fec_Ref.Location = New System.Drawing.Point(78, 84)
        Me.ume_Fec_Ref.Name = "ume_Fec_Ref"
        Me.ume_Fec_Ref.Size = New System.Drawing.Size(174, 20)
        Me.ume_Fec_Ref.TabIndex = 3
        Me.ume_Fec_Ref.Text = "UltraMaskedEdit1"
        '
        'UltraLabel28
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel28.Appearance = Appearance47
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UltraLabel28.Location = New System.Drawing.Point(12, 88)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(60, 15)
        Me.UltraLabel28.TabIndex = 44
        Me.UltraLabel28.Text = "Fecha Doc."
        '
        'uce_TipoDoc_Ref
        '
        Me.uce_TipoDoc_Ref.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc_Ref.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_TipoDoc_Ref.Location = New System.Drawing.Point(106, 34)
        Me.uce_TipoDoc_Ref.Name = "uce_TipoDoc_Ref"
        Me.uce_TipoDoc_Ref.Size = New System.Drawing.Size(146, 21)
        Me.uce_TipoDoc_Ref.TabIndex = 0
        '
        'txt_NumDoc_Ref
        '
        Me.txt_NumDoc_Ref.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_NumDoc_Ref.Location = New System.Drawing.Point(131, 58)
        Me.txt_NumDoc_Ref.Name = "txt_NumDoc_Ref"
        Me.txt_NumDoc_Ref.Size = New System.Drawing.Size(121, 21)
        Me.txt_NumDoc_Ref.TabIndex = 2
        '
        'txt_SerieDoc_Ref
        '
        Appearance9.TextHAlignAsString = "Left"
        Me.txt_SerieDoc_Ref.Appearance = Appearance9
        Me.txt_SerieDoc_Ref.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_SerieDoc_Ref.Location = New System.Drawing.Point(78, 58)
        Me.txt_SerieDoc_Ref.Name = "txt_SerieDoc_Ref"
        Me.txt_SerieDoc_Ref.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDoc_Ref.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 63)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel1.TabIndex = 43
        Me.UltraLabel1.Text = "Ser. / Num."
        '
        'UltraLabel29
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel29.Appearance = Appearance2
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(10, 37)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel29.TabIndex = 43
        Me.UltraLabel29.Text = "Documento"
        '
        'txt_cod_doc
        '
        Appearance4.TextHAlignAsString = "Center"
        Me.txt_cod_doc.Appearance = Appearance4
        Me.txt_cod_doc.Location = New System.Drawing.Point(78, 34)
        Me.txt_cod_doc.Name = "txt_cod_doc"
        Me.txt_cod_doc.Size = New System.Drawing.Size(28, 21)
        Me.txt_cod_doc.TabIndex = 60
        '
        'CO_PR_VouCompras_Referencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(491, 130)
        Me.Controls.Add(Me.ugb_ref)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_VouCompras_Referencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento de Referencia"
        CType(Me.ugb_ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_ref.ResumeLayout(False)
        Me.ugb_ref.PerformLayout()
        CType(Me.uce_TipoDoc_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDoc_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ugb_ref As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Aceptar_Ref As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_Monto_Igv_Ref As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_BaseI_Ref As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_Fec_Ref As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoDoc_Ref As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDoc_Ref As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SerieDoc_Ref As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_cod_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
