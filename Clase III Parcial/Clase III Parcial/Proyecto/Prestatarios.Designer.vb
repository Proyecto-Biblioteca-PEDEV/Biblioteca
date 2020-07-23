<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestatarios
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.txtIdLibro = New System.Windows.Forms.TextBox()
        Me.txtFechaPrestamo = New System.Windows.Forms.TextBox()
        Me.txtFechaEntrega = New System.Windows.Forms.TextBox()
        Me.tstPrestamo = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.DGlibros)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 369)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DGlibros
        '
        Me.DGlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlibros.Location = New System.Drawing.Point(6, 31)
        Me.DGlibros.Name = "DGlibros"
        Me.DGlibros.Size = New System.Drawing.Size(712, 321)
        Me.DGlibros.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAlumno)
        Me.GroupBox1.Controls.Add(Me.txtIdLibro)
        Me.GroupBox1.Controls.Add(Me.txtFechaPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.tstPrestamo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(353, 298)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prestatarios"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(277, 137)
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
        Me.btnEditar.Location = New System.Drawing.Point(277, 86)
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
        Me.btnIngresar.Location = New System.Drawing.Point(277, 35)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(277, 239)
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
        Me.btnEliminar.Location = New System.Drawing.Point(277, 188)
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
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Id Alumno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Id Libro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha Prestamo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha Entrega"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id Prestamo"
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(120, 68)
        Me.txtAlumno.Multiline = True
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(133, 27)
        Me.txtAlumno.TabIndex = 8
        '
        'txtIdLibro
        '
        Me.txtIdLibro.Location = New System.Drawing.Point(120, 101)
        Me.txtIdLibro.Multiline = True
        Me.txtIdLibro.Name = "txtIdLibro"
        Me.txtIdLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtIdLibro.TabIndex = 7
        '
        'txtFechaPrestamo
        '
        Me.txtFechaPrestamo.Location = New System.Drawing.Point(120, 134)
        Me.txtFechaPrestamo.Multiline = True
        Me.txtFechaPrestamo.Name = "txtFechaPrestamo"
        Me.txtFechaPrestamo.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaPrestamo.TabIndex = 6
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.Location = New System.Drawing.Point(121, 167)
        Me.txtFechaEntrega.Multiline = True
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaEntrega.TabIndex = 1
        '
        'tstPrestamo
        '
        Me.tstPrestamo.Location = New System.Drawing.Point(120, 35)
        Me.tstPrestamo.Multiline = True
        Me.tstPrestamo.Name = "tstPrestamo"
        Me.tstPrestamo.Size = New System.Drawing.Size(133, 27)
        Me.tstPrestamo.TabIndex = 0
        '
        'Prestatarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 401)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Prestatarios"
        Me.Text = "Prestatarios"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlumno As TextBox
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents txtFechaPrestamo As TextBox
    Friend WithEvents txtFechaEntrega As TextBox
    Friend WithEvents tstPrestamo As TextBox
End Class
