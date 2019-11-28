<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_LG_Login
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_LG_Login))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_VerSunat")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txt_Usuario = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Contra = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.ugb_login = New Infragistics.Win.Misc.UltraGroupBox
        Me.upb_usu_ok = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.upb_login = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.ume_tc_venta = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_tc_compra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ubtn_regresar = New Infragistics.Win.Misc.UltraButton
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.Fecha = New Infragistics.Win.Misc.UltraLabel
        CType(Me.txt_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Contra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_login.SuspendLayout()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(180, 41)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(124, 21)
        Me.txt_Usuario.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(111, 45)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Usuario"
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(111, 66)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Contraseña"
        '
        'txt_Contra
        '
        Me.txt_Contra.Location = New System.Drawing.Point(180, 63)
        Me.txt_Contra.Name = "txt_Contra"
        Me.txt_Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contra.Size = New System.Drawing.Size(124, 21)
        Me.txt_Contra.TabIndex = 1
        '
        'ubtn_Cancelar
        '
        Appearance10.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Cancelar.Appearance = Appearance10
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(428, 111)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(44, 28)
        Me.ubtn_Cancelar.TabIndex = 6
        '
        'ubtn_Aceptar
        '
        Appearance9.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Aceptar.Appearance = Appearance9
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(383, 111)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(44, 28)
        Me.ubtn_Aceptar.TabIndex = 5
        '
        'ugb_login
        '
        Me.ugb_login.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
        Me.ugb_login.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_login.Controls.Add(Me.upb_usu_ok)
        Me.ugb_login.Controls.Add(Me.upb_login)
        Me.ugb_login.Controls.Add(Me.ume_tc_venta)
        Me.ugb_login.Controls.Add(Me.ume_tc_compra)
        Me.ugb_login.Controls.Add(Me.ubtn_regresar)
        Me.ugb_login.Controls.Add(Me.udte_fecha)
        Me.ugb_login.Controls.Add(Me.ubtn_Aceptar)
        Me.ugb_login.Controls.Add(Me.UltraLabel5)
        Me.ugb_login.Controls.Add(Me.UltraLabel3)
        Me.ugb_login.Controls.Add(Me.Fecha)
        Me.ugb_login.Controls.Add(Me.ubtn_Cancelar)
        Me.ugb_login.Controls.Add(Me.UltraLabel1)
        Me.ugb_login.Controls.Add(Me.UltraLabel4)
        Me.ugb_login.Controls.Add(Me.txt_Contra)
        Me.ugb_login.Controls.Add(Me.txt_Usuario)
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.SizeInPoints = 10.0!
        Me.ugb_login.HeaderAppearance = Appearance11
        Me.ugb_login.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_login.Location = New System.Drawing.Point(3, 1)
        Me.ugb_login.Name = "ugb_login"
        Me.ugb_login.Size = New System.Drawing.Size(481, 147)
        Me.ugb_login.TabIndex = 0
        '
        'upb_usu_ok
        '
        Me.upb_usu_ok.BackColor = System.Drawing.Color.Transparent
        Me.upb_usu_ok.BorderShadowColor = System.Drawing.Color.Transparent
        Me.upb_usu_ok.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.upb_usu_ok.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.upb_usu_ok.Location = New System.Drawing.Point(308, 42)
        Me.upb_usu_ok.Name = "upb_usu_ok"
        Me.upb_usu_ok.Size = New System.Drawing.Size(21, 18)
        Me.upb_usu_ok.TabIndex = 15
        Me.upb_usu_ok.Visible = False
        '
        'upb_login
        '
        Me.upb_login.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_login.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.upb_login.DrawBorderShadow = True
        Me.upb_login.Image = CType(resources.GetObject("upb_login.Image"), Object)
        Me.upb_login.Location = New System.Drawing.Point(6, 32)
        Me.upb_login.Name = "upb_login"
        Me.upb_login.Size = New System.Drawing.Size(101, 84)
        Me.upb_login.TabIndex = 13
        '
        'ume_tc_venta
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.ume_tc_venta.Appearance = Appearance4
        Me.ume_tc_venta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tc_venta.InputMask = "n.nnn"
        Me.ume_tc_venta.Location = New System.Drawing.Point(400, 67)
        Me.ume_tc_venta.Name = "ume_tc_venta"
        Me.ume_tc_venta.Size = New System.Drawing.Size(68, 20)
        Me.ume_tc_venta.TabIndex = 4
        Me.ume_tc_venta.Text = "UltraMaskedEdit1"
        '
        'ume_tc_compra
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.ume_tc_compra.Appearance = Appearance6
        Appearance12.Image = Global.Contabilidad.My.Resources.Resources._16__Internet_1
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance12
        EditorButton1.Key = "btn_VerSunat"
        Me.ume_tc_compra.ButtonsLeft.Add(EditorButton1)
        Me.ume_tc_compra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tc_compra.InputMask = "n.nnn"
        Me.ume_tc_compra.Location = New System.Drawing.Point(400, 46)
        Me.ume_tc_compra.Name = "ume_tc_compra"
        Me.ume_tc_compra.Size = New System.Drawing.Size(68, 20)
        Me.ume_tc_compra.TabIndex = 3
        Me.ume_tc_compra.Text = "UltraMaskedEdit1"
        '
        'ubtn_regresar
        '
        Appearance3.Image = Global.Contabilidad.My.Resources.Resources._16__Arrow_first_
        Me.ubtn_regresar.Appearance = Appearance3
        Me.ubtn_regresar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.ubtn_regresar.Location = New System.Drawing.Point(330, 111)
        Me.ubtn_regresar.Name = "ubtn_regresar"
        Me.ubtn_regresar.Size = New System.Drawing.Size(44, 28)
        Me.ubtn_regresar.TabIndex = 7
        Me.ubtn_regresar.Text = "..."
        '
        'udte_fecha
        '
        Me.udte_fecha.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.udte_fecha.Location = New System.Drawing.Point(180, 86)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.Size = New System.Drawing.Size(124, 21)
        Me.udte_fecha.TabIndex = 2
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(352, 70)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel5.TabIndex = 12
        Me.UltraLabel5.Text = "Venta"
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(352, 50)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Compra"
        '
        'Fecha
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Fecha.Appearance = Appearance8
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(111, 89)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(36, 14)
        Me.Fecha.TabIndex = 12
        Me.Fecha.Text = "Fecha"
        '
        'CO_LG_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(490, 152)
        Me.Controls.Add(Me.ugb_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CO_LG_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.txt_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Contra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_login.ResumeLayout(False)
        Me.ugb_login.PerformLayout()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Usuario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Contra As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_login As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Fecha As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_regresar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_tc_compra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_tc_venta As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upb_login As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents upb_usu_ok As Infragistics.Win.UltraWinEditors.UltraPictureBox
End Class
