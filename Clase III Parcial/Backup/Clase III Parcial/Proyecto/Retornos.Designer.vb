<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Retornos
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.DGRetornos = New System.Windows.Forms.DataGridView()
        Me.btnRetornos = New System.Windows.Forms.Button()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.DGlibros = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEstadoMulta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMulta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdAlumno = New System.Windows.Forms.TextBox()
        Me.txtIdLibro = New System.Windows.Forms.TextBox()
        Me.txtIdPrestamo = New System.Windows.Forms.TextBox()
        Me.txtFechaRetorno = New System.Windows.Forms.TextBox()
        Me.txtIdRetorno = New System.Windows.Forms.TextBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGRetornos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.DGRetornos)
        Me.GroupBox2.Controls.Add(Me.btnRetornos)
        Me.GroupBox2.Controls.Add(Me.btnPrestamos)
        Me.GroupBox2.Controls.Add(Me.DGlibros)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 367)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "ID RETORNO"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(108, 23)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 30)
        Me.txtBuscar.TabIndex = 44
        '
        'DGRetornos
        '
        Me.DGRetornos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRetornos.Location = New System.Drawing.Point(6, 63)
        Me.DGRetornos.Name = "DGRetornos"
        Me.DGRetornos.Size = New System.Drawing.Size(825, 298)
        Me.DGRetornos.TabIndex = 3
        '
        'btnRetornos
        '
        Me.btnRetornos.Location = New System.Drawing.Point(444, 19)
        Me.btnRetornos.Name = "btnRetornos"
        Me.btnRetornos.Size = New System.Drawing.Size(95, 31)
        Me.btnRetornos.TabIndex = 2
        Me.btnRetornos.Text = "Retornos"
        Me.btnRetornos.UseVisualStyleBackColor = True
        '
        'btnPrestamos
        '
        Me.btnPrestamos.Location = New System.Drawing.Point(299, 19)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(95, 31)
        Me.btnPrestamos.TabIndex = 1
        Me.btnPrestamos.Text = "Préstamos"
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'DGlibros
        '
        Me.DGlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlibros.Location = New System.Drawing.Point(6, 63)
        Me.DGlibros.Name = "DGlibros"
        Me.DGlibros.Size = New System.Drawing.Size(825, 298)
        Me.DGlibros.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(233, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.btnFactura)
        Me.GroupBox1.Controls.Add(Me.cmbEstadoMulta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMulta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdAlumno)
        Me.GroupBox1.Controls.Add(Me.txtIdLibro)
        Me.GroupBox1.Controls.Add(Me.txtIdPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtFechaRetorno)
        Me.GroupBox1.Controls.Add(Me.txtIdRetorno)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(323, 299)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Retornos"
        '
        'cmbEstadoMulta
        '
        Me.cmbEstadoMulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoMulta.FormattingEnabled = True
        Me.cmbEstadoMulta.Items.AddRange(New Object() {"Pagado", "No Pagado"})
        Me.cmbEstadoMulta.Location = New System.Drawing.Point(121, 233)
        Me.cmbEstadoMulta.Name = "cmbEstadoMulta"
        Me.cmbEstadoMulta.Size = New System.Drawing.Size(133, 31)
        Me.cmbEstadoMulta.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "ESTADO MULTA"
        '
        'txtMulta
        '
        Me.txtMulta.Location = New System.Drawing.Point(121, 200)
        Me.txtMulta.Multiline = True
        Me.txtMulta.Name = "txtMulta"
        Me.txtMulta.ReadOnly = True
        Me.txtMulta.Size = New System.Drawing.Size(133, 27)
        Me.txtMulta.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "MULTA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 23)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Id Alumno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Id Libro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Id Prestamo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha Retorno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id Retorno"
        '
        'txtIdAlumno
        '
        Me.txtIdAlumno.Location = New System.Drawing.Point(121, 68)
        Me.txtIdAlumno.Multiline = True
        Me.txtIdAlumno.Name = "txtIdAlumno"
        Me.txtIdAlumno.ReadOnly = True
        Me.txtIdAlumno.Size = New System.Drawing.Size(133, 27)
        Me.txtIdAlumno.TabIndex = 8
        '
        'txtIdLibro
        '
        Me.txtIdLibro.Location = New System.Drawing.Point(121, 101)
        Me.txtIdLibro.Multiline = True
        Me.txtIdLibro.Name = "txtIdLibro"
        Me.txtIdLibro.ReadOnly = True
        Me.txtIdLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtIdLibro.TabIndex = 7
        '
        'txtIdPrestamo
        '
        Me.txtIdPrestamo.Location = New System.Drawing.Point(121, 134)
        Me.txtIdPrestamo.Multiline = True
        Me.txtIdPrestamo.Name = "txtIdPrestamo"
        Me.txtIdPrestamo.ReadOnly = True
        Me.txtIdPrestamo.Size = New System.Drawing.Size(133, 27)
        Me.txtIdPrestamo.TabIndex = 6
        '
        'txtFechaRetorno
        '
        Me.txtFechaRetorno.Location = New System.Drawing.Point(121, 167)
        Me.txtFechaRetorno.Multiline = True
        Me.txtFechaRetorno.Name = "txtFechaRetorno"
        Me.txtFechaRetorno.ReadOnly = True
        Me.txtFechaRetorno.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaRetorno.TabIndex = 1
        '
        'txtIdRetorno
        '
        Me.txtIdRetorno.Location = New System.Drawing.Point(121, 35)
        Me.txtIdRetorno.Multiline = True
        Me.txtIdRetorno.Name = "txtIdRetorno"
        Me.txtIdRetorno.Size = New System.Drawing.Size(133, 27)
        Me.txtIdRetorno.TabIndex = 0
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'btnFactura
        '
        Me.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFactura.Image = Global.Clase_III_Parcial.My.Resources.Resources.ic_ad_97607
        Me.btnFactura.Location = New System.Drawing.Point(272, 188)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(45, 45)
        Me.btnFactura.TabIndex = 48
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditar.Image = Global.Clase_III_Parcial.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(272, 86)
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
        Me.btnIngresar.Location = New System.Drawing.Point(272, 35)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(272, 137)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(45, 45)
        Me.btnLimpiar.TabIndex = 40
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Retornos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 409)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Retornos"
        Me.Text = "Retornos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGRetornos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGlibros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdAlumno As TextBox
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents txtIdPrestamo As TextBox
    Friend WithEvents txtFechaRetorno As TextBox
    Friend WithEvents txtIdRetorno As TextBox
    Friend WithEvents cmbEstadoMulta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMulta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents DGRetornos As DataGridView
    Friend WithEvents btnRetornos As Button
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnFactura As Button
End Class
