<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_LG_IniciarRegEdit
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_LG_IniciarRegEdit))
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Reportes = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_Clave = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_Usuario = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_Base = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_servidor = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Estilos = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_Reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Clave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Base, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_servidor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Estilos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_Estilos)
        Me.UltraGroupBox1.Controls.Add(Me.UltraPictureBox1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Reportes)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Clave)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Usuario)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Base)
        Me.UltraGroupBox1.Controls.Add(Me.txt_servidor)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(505, 187)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(52, 159)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Estilo"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(34, 132)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Reportes"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(51, 105)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Clave"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(41, 78)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Usuario"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(6, 51)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Base de Datos"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(38, 24)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Servidor"
        '
        'txt_Reportes
        '
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._104
        EditorButton1.Appearance = Appearance1
        Me.txt_Reportes.ButtonsRight.Add(EditorButton1)
        Me.txt_Reportes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Reportes.Location = New System.Drawing.Point(90, 128)
        Me.txt_Reportes.Name = "txt_Reportes"
        Me.txt_Reportes.Size = New System.Drawing.Size(407, 21)
        Me.txt_Reportes.TabIndex = 4
        '
        'txt_Clave
        '
        Me.txt_Clave.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Clave.Location = New System.Drawing.Point(90, 101)
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Clave.Size = New System.Drawing.Size(232, 21)
        Me.txt_Clave.TabIndex = 3
        '
        'txt_Usuario
        '
        Me.txt_Usuario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Usuario.Location = New System.Drawing.Point(90, 74)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(232, 21)
        Me.txt_Usuario.TabIndex = 2
        '
        'txt_Base
        '
        Me.txt_Base.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Base.Location = New System.Drawing.Point(90, 47)
        Me.txt_Base.Name = "txt_Base"
        Me.txt_Base.Size = New System.Drawing.Size(232, 21)
        Me.txt_Base.TabIndex = 1
        '
        'txt_servidor
        '
        Me.txt_servidor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_servidor.Location = New System.Drawing.Point(90, 20)
        Me.txt_servidor.Name = "txt_servidor"
        Me.txt_servidor.Size = New System.Drawing.Size(232, 21)
        Me.txt_servidor.TabIndex = 0
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(353, 262)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 27)
        Me.ubtn_Aceptar.TabIndex = 6
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(434, 262)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 27)
        Me.ubtn_Cancelar.TabIndex = 7
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(328, 15)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(172, 104)
        Me.UltraPictureBox1.TabIndex = 8
        '
        'UltraLabel7
        '
        Me.UltraLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.UltraLabel7.Location = New System.Drawing.Point(12, 12)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(500, 51)
        Me.UltraLabel7.TabIndex = 1
        Me.UltraLabel7.Text = "Ingrese los datos de Conexion por primera vez. El sistema registrara estos datos " & _
            "en la PC cliente para la comunicacion con el Servidor, utilizar reportes y estab" & _
            "lecer las mascaras del sistema."
        '
        'uce_Estilos
        '
        Me.uce_Estilos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.uce_Estilos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Estilos.Location = New System.Drawing.Point(90, 153)
        Me.uce_Estilos.Name = "uce_Estilos"
        Me.uce_Estilos.Size = New System.Drawing.Size(247, 21)
        Me.uce_Estilos.TabIndex = 9
        '
        'CO_LG_IniciarRegEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(521, 295)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CO_LG_IniciarRegEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Parametros de Conexion Inicial"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_Reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Clave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Base, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_servidor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Estilos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Clave As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Usuario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Base As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_servidor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Reportes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Estilos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
