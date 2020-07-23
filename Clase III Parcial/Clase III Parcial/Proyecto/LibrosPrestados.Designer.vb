<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrosPrestados
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGlibros = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdAlumno = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreLibro = New System.Windows.Forms.TextBox()
        Me.TxtAutor = New System.Windows.Forms.TextBox()
        Me.txtEditorial = New System.Windows.Forms.TextBox()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtFechaPrestamo = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtIdLibro = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.DGlibros)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 369)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'DGlibros
        '
        Me.DGlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlibros.Location = New System.Drawing.Point(6, 31)
        Me.DGlibros.Name = "DGlibros"
        Me.DGlibros.Size = New System.Drawing.Size(825, 321)
        Me.DGlibros.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtIdAlumno)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreLibro)
        Me.GroupBox1.Controls.Add(Me.TxtAutor)
        Me.GroupBox1.Controls.Add(Me.txtEditorial)
        Me.GroupBox1.Controls.Add(Me.txtAlumno)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtFechaPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtGenero)
        Me.GroupBox1.Controls.Add(Me.txtIdLibro)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(320, 376)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Libros Prestados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 25)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Id Alumno"
        '
        'txtIdAlumno
        '
        Me.txtIdAlumno.Location = New System.Drawing.Point(130, 269)
        Me.txtIdAlumno.Multiline = True
        Me.txtIdAlumno.Name = "txtIdAlumno"
        Me.txtIdAlumno.Size = New System.Drawing.Size(133, 27)
        Me.txtIdAlumno.TabIndex = 44
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(269, 137)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditar.Image = Global.Clase_III_Parcial.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(269, 86)
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
        Me.btnIngresar.Location = New System.Drawing.Point(269, 35)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(269, 239)
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
        Me.btnEliminar.Location = New System.Drawing.Point(269, 188)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 45)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Autor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Editorial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Genero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha Prestamo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id Libro"
        '
        'txtNombreLibro
        '
        Me.txtNombreLibro.Location = New System.Drawing.Point(130, 71)
        Me.txtNombreLibro.Multiline = True
        Me.txtNombreLibro.Name = "txtNombreLibro"
        Me.txtNombreLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtNombreLibro.TabIndex = 8
        '
        'TxtAutor
        '
        Me.TxtAutor.Location = New System.Drawing.Point(130, 104)
        Me.TxtAutor.Multiline = True
        Me.TxtAutor.Name = "TxtAutor"
        Me.TxtAutor.Size = New System.Drawing.Size(133, 27)
        Me.TxtAutor.TabIndex = 7
        '
        'txtEditorial
        '
        Me.txtEditorial.Location = New System.Drawing.Point(130, 137)
        Me.txtEditorial.Multiline = True
        Me.txtEditorial.Name = "txtEditorial"
        Me.txtEditorial.Size = New System.Drawing.Size(133, 27)
        Me.txtEditorial.TabIndex = 6
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(130, 236)
        Me.txtAlumno.Multiline = True
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(133, 27)
        Me.txtAlumno.TabIndex = 4
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(130, 302)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(133, 27)
        Me.txtEstado.TabIndex = 3
        '
        'txtFechaPrestamo
        '
        Me.txtFechaPrestamo.Location = New System.Drawing.Point(130, 203)
        Me.txtFechaPrestamo.Multiline = True
        Me.txtFechaPrestamo.Name = "txtFechaPrestamo"
        Me.txtFechaPrestamo.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaPrestamo.TabIndex = 2
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(130, 170)
        Me.txtGenero.Multiline = True
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(133, 27)
        Me.txtGenero.TabIndex = 1
        '
        'txtIdLibro
        '
        Me.txtIdLibro.Location = New System.Drawing.Point(130, 38)
        Me.txtIdLibro.Multiline = True
        Me.txtIdLibro.Name = "txtIdLibro"
        Me.txtIdLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtIdLibro.TabIndex = 0
        '
        'LibrosPrestados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 410)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LibrosPrestados"
        Me.Text = "LibrosPrestados"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGlibros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreLibro As TextBox
    Friend WithEvents TxtAutor As TextBox
    Friend WithEvents txtEditorial As TextBox
    Friend WithEvents txtAlumno As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtFechaPrestamo As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdAlumno As TextBox
End Class
