<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblOlvideContra = New System.Windows.Forms.LinkLabel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMostrarContra = New System.Windows.Forms.Button()
        Me.btnOcultarContra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.Desktop
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(505, 41)
        Me.PanelSuperior.TabIndex = 26
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Clase_III_Parcial.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(417, -11)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 64)
        Me.btnMinimizar.TabIndex = 5
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Clase_III_Parcial.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(465, -11)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 64)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(189, 240)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(96, 31)
        Me.btnIniciar.TabIndex = 32
        Me.btnIniciar.Text = "Iniciar Sesion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(92, 196)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(275, 29)
        Me.txtContrasena.TabIndex = 28
        '
        'lblOlvideContra
        '
        Me.lblOlvideContra.AutoSize = True
        Me.lblOlvideContra.BackColor = System.Drawing.Color.Transparent
        Me.lblOlvideContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlvideContra.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblOlvideContra.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.lblOlvideContra.Location = New System.Drawing.Point(174, 294)
        Me.lblOlvideContra.Name = "lblOlvideContra"
        Me.lblOlvideContra.Size = New System.Drawing.Size(134, 16)
        Me.lblOlvideContra.TabIndex = 31
        Me.lblOlvideContra.TabStop = True
        Me.lblOlvideContra.Text = "Olvide mi contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(92, 150)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(275, 29)
        Me.txtUsuario.TabIndex = 27
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Clase_III_Parcial.My.Resources.Resources.logo_negro_png_super_ultra
        Me.PictureBox2.Location = New System.Drawing.Point(207, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'btnMostrarContra
        '
        Me.btnMostrarContra.BackColor = System.Drawing.Color.DimGray
        Me.btnMostrarContra.FlatAppearance.BorderSize = 0
        Me.btnMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarContra.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnMostrarContra.Image = CType(resources.GetObject("btnMostrarContra.Image"), System.Drawing.Image)
        Me.btnMostrarContra.Location = New System.Drawing.Point(373, 201)
        Me.btnMostrarContra.Name = "btnMostrarContra"
        Me.btnMostrarContra.Size = New System.Drawing.Size(43, 20)
        Me.btnMostrarContra.TabIndex = 29
        Me.btnMostrarContra.UseVisualStyleBackColor = False
        '
        'btnOcultarContra
        '
        Me.btnOcultarContra.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOcultarContra.FlatAppearance.BorderSize = 0
        Me.btnOcultarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultarContra.Image = CType(resources.GetObject("btnOcultarContra.Image"), System.Drawing.Image)
        Me.btnOcultarContra.Location = New System.Drawing.Point(373, 201)
        Me.btnOcultarContra.Name = "btnOcultarContra"
        Me.btnOcultarContra.Size = New System.Drawing.Size(29, 24)
        Me.btnOcultarContra.TabIndex = 30
        Me.btnOcultarContra.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Pass"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Clase_III_Parcial.My.Resources.Resources.WhatsApp_Image_2020_08_04_at_4_48_12_AM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(505, 325)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.btnMostrarContra)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.lblOlvideContra)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnOcultarContra)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelSuperior.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnMostrarContra As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblOlvideContra As LinkLabel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnOcultarContra As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
