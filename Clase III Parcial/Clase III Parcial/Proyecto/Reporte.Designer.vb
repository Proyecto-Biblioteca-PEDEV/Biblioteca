<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.librosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BibliotecaDataSet = New Clase_III_Parcial.BibliotecaDataSet()
        Me.RetornosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReporteLibros = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.librosTableAdapter = New Clase_III_Parcial.BibliotecaDataSetTableAdapters.librosTableAdapter()
        Me.PrestamoTableAdapter = New Clase_III_Parcial.BibliotecaDataSetTableAdapters.PrestamoTableAdapter()
        Me.RetornosTableAdapter = New Clase_III_Parcial.BibliotecaDataSetTableAdapters.RetornosTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.librosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetornosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'librosBindingSource
        '
        Me.librosBindingSource.DataMember = "libros"
        Me.librosBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'BibliotecaDataSet
        '
        Me.BibliotecaDataSet.DataSetName = "BibliotecaDataSet"
        Me.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetornosBindingSource
        '
        Me.RetornosBindingSource.DataMember = "Retornos"
        Me.RetornosBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'PrestamoBindingSource
        '
        Me.PrestamoBindingSource.DataMember = "Prestamo"
        Me.PrestamoBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.ReporteLibros)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 369)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'ReporteLibros
        '
        Me.ReporteLibros.Enabled = False
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.librosBindingSource
        Me.ReporteLibros.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReporteLibros.LocalReport.ReportEmbeddedResource = "Clase_III_Parcial.Prueba.rdlc"
        Me.ReporteLibros.Location = New System.Drawing.Point(12, 29)
        Me.ReporteLibros.Name = "ReporteLibros"
        Me.ReporteLibros.ServerReport.BearerToken = Nothing
        Me.ReporteLibros.Size = New System.Drawing.Size(836, 335)
        Me.ReporteLibros.TabIndex = 7
        Me.ReporteLibros.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnPrestamos)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(323, 225)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte"
        '
        'librosTableAdapter
        '
        Me.librosTableAdapter.ClearBeforeFill = True
        '
        'PrestamoTableAdapter
        '
        Me.PrestamoTableAdapter.ClearBeforeFill = True
        '
        'RetornosTableAdapter
        '
        Me.RetornosTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.Image = Global.Clase_III_Parcial.My.Resources.Resources.seo_report1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(37, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 45)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Retornos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPrestamos
        '
        Me.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPrestamos.Image = Global.Clase_III_Parcial.My.Resources.Resources.seo_report
        Me.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrestamos.Location = New System.Drawing.Point(37, 94)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(138, 45)
        Me.btnPrestamos.TabIndex = 45
        Me.btnPrestamos.Text = "Prestamos"
        Me.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.seo_report1
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(37, 43)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(138, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.Text = "Libros"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 400)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.librosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetornosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents librosBindingSource As BindingSource
    Friend WithEvents BibliotecaDataSet As BibliotecaDataSet
    Friend WithEvents librosTableAdapter As BibliotecaDataSetTableAdapters.librosTableAdapter
    Friend WithEvents ReporteLibros As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrestamoBindingSource As BindingSource
    Friend WithEvents PrestamoTableAdapter As BibliotecaDataSetTableAdapters.PrestamoTableAdapter
    Friend WithEvents RetornosBindingSource As BindingSource
    Friend WithEvents RetornosTableAdapter As BibliotecaDataSetTableAdapters.RetornosTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPrestamos As Button
End Class
