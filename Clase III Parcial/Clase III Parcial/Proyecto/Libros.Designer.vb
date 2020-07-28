<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreLibro = New System.Windows.Forms.TextBox()
        Me.TxtAutor = New System.Windows.Forms.TextBox()
        Me.txtEditorial = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.txtPublicacion = New System.Windows.Forms.TextBox()
        Me.txtIdLibro = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.DGlibros = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbGenero)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreLibro)
        Me.GroupBox1.Controls.Add(Me.TxtAutor)
        Me.GroupBox1.Controls.Add(Me.txtEditorial)
        Me.GroupBox1.Controls.Add(Me.txtPais)
        Me.GroupBox1.Controls.Add(Me.txtIdioma)
        Me.GroupBox1.Controls.Add(Me.txtPublicacion)
        Me.GroupBox1.Controls.Add(Me.txtIdLibro)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(822, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Libros "
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Location = New System.Drawing.Point(455, 83)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(196, 32)
        Me.cmbGenero.TabIndex = 44
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditar.Image = Global.Clase_III_Parcial.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(736, 72)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(45, 45)
        Me.btnEditar.TabIndex = 42
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.Image = Global.Clase_III_Parcial.My.Resources.Resources.agregar
        Me.btnIngresar.Location = New System.Drawing.Point(736, 17)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(45, 45)
        Me.btnIngresar.TabIndex = 41
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLimpiar.Image = Global.Clase_III_Parcial.My.Resources.Resources.limpiar
        Me.btnLimpiar.Location = New System.Drawing.Point(736, 170)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(45, 45)
        Me.btnLimpiar.TabIndex = 40
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEliminar.Image = Global.Clase_III_Parcial.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(736, 121)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 45)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Autor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Editorial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Genero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Publicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Pais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Idioma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo"
        '
        'txtNombreLibro
        '
        Me.txtNombreLibro.Location = New System.Drawing.Point(122, 50)
        Me.txtNombreLibro.Multiline = True
        Me.txtNombreLibro.Name = "txtNombreLibro"
        Me.txtNombreLibro.Size = New System.Drawing.Size(205, 27)
        Me.txtNombreLibro.TabIndex = 8
        '
        'TxtAutor
        '
        Me.TxtAutor.Location = New System.Drawing.Point(455, 50)
        Me.TxtAutor.Multiline = True
        Me.TxtAutor.Name = "TxtAutor"
        Me.TxtAutor.Size = New System.Drawing.Size(205, 27)
        Me.TxtAutor.TabIndex = 7
        '
        'txtEditorial
        '
        Me.txtEditorial.Location = New System.Drawing.Point(122, 86)
        Me.txtEditorial.Multiline = True
        Me.txtEditorial.Name = "txtEditorial"
        Me.txtEditorial.Size = New System.Drawing.Size(205, 27)
        Me.txtEditorial.TabIndex = 6
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(455, 124)
        Me.txtPais.Multiline = True
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(208, 27)
        Me.txtPais.TabIndex = 5
        '
        'txtIdioma
        '
        Me.txtIdioma.Location = New System.Drawing.Point(122, 170)
        Me.txtIdioma.Multiline = True
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(208, 27)
        Me.txtIdioma.TabIndex = 4
        '
        'txtPublicacion
        '
        Me.txtPublicacion.Location = New System.Drawing.Point(122, 126)
        Me.txtPublicacion.Multiline = True
        Me.txtPublicacion.Name = "txtPublicacion"
        Me.txtPublicacion.Size = New System.Drawing.Size(133, 27)
        Me.txtPublicacion.TabIndex = 2
        '
        'txtIdLibro
        '
        Me.txtIdLibro.Location = New System.Drawing.Point(122, 17)
        Me.txtIdLibro.Multiline = True
        Me.txtIdLibro.Name = "txtIdLibro"
        Me.txtIdLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtIdLibro.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(295, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.DGlibros)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(983, 388)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Codigo"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(134, 23)
        Me.txtbuscar.Multiline = True
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(133, 27)
        Me.txtbuscar.TabIndex = 44
        '
        'DGlibros
        '
        Me.DGlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlibros.Location = New System.Drawing.Point(6, 66)
        Me.DGlibros.Name = "DGlibros"
        Me.DGlibros.Size = New System.Drawing.Size(971, 307)
        Me.DGlibros.TabIndex = 0
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(455, 164)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 46
        Me.cmbEstado.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(339, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 24)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Estado"
        Me.Label10.Visible = False
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1008, 645)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Libros"
        Me.Text = "Libros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombreLibro As TextBox
    Friend WithEvents TxtAutor As TextBox
    Friend WithEvents txtEditorial As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtIdioma As TextBox
    Friend WithEvents txtPublicacion As TextBox
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGlibros As DataGridView
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label10 As Label
End Class
