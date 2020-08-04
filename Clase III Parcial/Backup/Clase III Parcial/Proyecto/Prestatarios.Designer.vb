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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBusquedaLibro = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGDisponibles = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBusquedaPrestamos = New System.Windows.Forms.TextBox()
        Me.DGlibros = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTemporal = New System.Windows.Forms.TextBox()
        Me.txtFechaEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaPrestamo = New System.Windows.Forms.MaskedTextBox()
        Me.txtAlumno = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstadoAlumno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdLibro = New System.Windows.Forms.TextBox()
        Me.tstPrestamo = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox3.Controls.Add(Me.txtBusquedaLibro)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.DGDisponibles)
        Me.GroupBox3.Location = New System.Drawing.Point(633, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(255, 392)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Id Libros Disponibles"
        Me.GroupBox3.UseWaitCursor = True
        '
        'txtBusquedaLibro
        '
        Me.txtBusquedaLibro.Location = New System.Drawing.Point(57, 27)
        Me.txtBusquedaLibro.Multiline = True
        Me.txtBusquedaLibro.Name = "txtBusquedaLibro"
        Me.txtBusquedaLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtBusquedaLibro.TabIndex = 47
        Me.txtBusquedaLibro.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar1
        Me.Button2.Location = New System.Drawing.Point(6, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 45)
        Me.Button2.TabIndex = 46
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'DGDisponibles
        '
        Me.DGDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDisponibles.Location = New System.Drawing.Point(6, 65)
        Me.DGDisponibles.Name = "DGDisponibles"
        Me.DGDisponibles.Size = New System.Drawing.Size(243, 321)
        Me.DGDisponibles.TabIndex = 0
        Me.DGDisponibles.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.txtBusquedaPrestamos)
        Me.GroupBox2.Controls.Add(Me.DGlibros)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 392)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        Me.GroupBox2.UseWaitCursor = True
        '
        'txtBusquedaPrestamos
        '
        Me.txtBusquedaPrestamos.Location = New System.Drawing.Point(57, 27)
        Me.txtBusquedaPrestamos.Multiline = True
        Me.txtBusquedaPrestamos.Name = "txtBusquedaPrestamos"
        Me.txtBusquedaPrestamos.Size = New System.Drawing.Size(133, 27)
        Me.txtBusquedaPrestamos.TabIndex = 45
        Me.txtBusquedaPrestamos.UseWaitCursor = True
        '
        'DGlibros
        '
        Me.DGlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlibros.Location = New System.Drawing.Point(6, 65)
        Me.DGlibros.Name = "DGlibros"
        Me.DGlibros.Size = New System.Drawing.Size(595, 321)
        Me.DGlibros.TabIndex = 0
        Me.DGlibros.UseWaitCursor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar1
        Me.btnBuscar.Location = New System.Drawing.Point(6, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.btnBuscar.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.txtTemporal)
        Me.GroupBox1.Controls.Add(Me.txtFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.txtFechaPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtAlumno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEstadoAlumno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdLibro)
        Me.GroupBox1.Controls.Add(Me.tstPrestamo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(646, 210)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prestamos"
        Me.GroupBox1.UseWaitCursor = True
        '
        'txtTemporal
        '
        Me.txtTemporal.Enabled = False
        Me.txtTemporal.Location = New System.Drawing.Point(375, 139)
        Me.txtTemporal.Multiline = True
        Me.txtTemporal.Name = "txtTemporal"
        Me.txtTemporal.Size = New System.Drawing.Size(133, 27)
        Me.txtTemporal.TabIndex = 49
        Me.txtTemporal.UseWaitCursor = True
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.Location = New System.Drawing.Point(135, 68)
        Me.txtFechaEntrega.Mask = "00/00/0000"
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(133, 32)
        Me.txtFechaEntrega.TabIndex = 48
        Me.txtFechaEntrega.UseWaitCursor = True
        Me.txtFechaEntrega.ValidatingType = GetType(Date)
        '
        'txtFechaPrestamo
        '
        Me.txtFechaPrestamo.Location = New System.Drawing.Point(135, 30)
        Me.txtFechaPrestamo.Mask = "00/00/0000"
        Me.txtFechaPrestamo.Name = "txtFechaPrestamo"
        Me.txtFechaPrestamo.Size = New System.Drawing.Size(133, 32)
        Me.txtFechaPrestamo.TabIndex = 47
        Me.txtFechaPrestamo.UseWaitCursor = True
        Me.txtFechaPrestamo.ValidatingType = GetType(Date)
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(375, 68)
        Me.txtAlumno.Mask = "0000-0000-00000"
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(133, 32)
        Me.txtAlumno.TabIndex = 46
        Me.txtAlumno.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Estado Alumno"
        Me.Label3.UseWaitCursor = True
        '
        'txtEstadoAlumno
        '
        Me.txtEstadoAlumno.Enabled = False
        Me.txtEstadoAlumno.Location = New System.Drawing.Point(135, 139)
        Me.txtEstadoAlumno.Multiline = True
        Me.txtEstadoAlumno.Name = "txtEstadoAlumno"
        Me.txtEstadoAlumno.Size = New System.Drawing.Size(133, 27)
        Me.txtEstadoAlumno.TabIndex = 8
        Me.txtEstadoAlumno.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Estado Libro"
        Me.Label2.UseWaitCursor = True
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(135, 106)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(133, 27)
        Me.txtEstado.TabIndex = 7
        Me.txtEstado.UseWaitCursor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditar.Image = Global.Clase_III_Parcial.My.Resources.Resources.editar1
        Me.btnEditar.Location = New System.Drawing.Point(564, 86)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(45, 45)
        Me.btnEditar.TabIndex = 42
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.UseWaitCursor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.Image = Global.Clase_III_Parcial.My.Resources.Resources.agregar1
        Me.btnIngresar.Location = New System.Drawing.Point(564, 35)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(45, 45)
        Me.btnIngresar.TabIndex = 41
        Me.btnIngresar.UseVisualStyleBackColor = True
        Me.btnIngresar.UseWaitCursor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLimpiar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar1
        Me.btnLimpiar.Location = New System.Drawing.Point(564, 138)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(45, 45)
        Me.btnLimpiar.TabIndex = 40
        Me.btnLimpiar.UseVisualStyleBackColor = True
        Me.btnLimpiar.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(281, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Id Alumno"
        Me.Label9.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Id Libro"
        Me.Label8.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fecha Prestamo"
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha Entrega"
        Me.Label6.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id Prestamo"
        Me.Label1.UseWaitCursor = True
        '
        'txtIdLibro
        '
        Me.txtIdLibro.Enabled = False
        Me.txtIdLibro.Location = New System.Drawing.Point(375, 106)
        Me.txtIdLibro.Multiline = True
        Me.txtIdLibro.Name = "txtIdLibro"
        Me.txtIdLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtIdLibro.TabIndex = 7
        Me.txtIdLibro.UseWaitCursor = True
        '
        'tstPrestamo
        '
        Me.tstPrestamo.Location = New System.Drawing.Point(375, 35)
        Me.tstPrestamo.Multiline = True
        Me.tstPrestamo.Name = "tstPrestamo"
        Me.tstPrestamo.Size = New System.Drawing.Size(133, 27)
        Me.tstPrestamo.TabIndex = 0
        Me.tstPrestamo.UseWaitCursor = True
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Prestatarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 628)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Prestatarios"
        Me.Text = "Prestatarios"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBusquedaLibro As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DGDisponibles As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBusquedaPrestamos As TextBox
    Friend WithEvents DGlibros As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTemporal As TextBox
    Friend WithEvents txtFechaEntrega As MaskedTextBox
    Friend WithEvents txtFechaPrestamo As MaskedTextBox
    Friend WithEvents txtAlumno As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEstadoAlumno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents tstPrestamo As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
End Class
