Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BibliotecaDataSet.libros' table. You can move, or remove it, as needed.
        Me.librosTableAdapter.Fill(Me.BibliotecaDataSet.libros)
        'TODO: This line of code loads data into the 'BibliotecaDataSet.Retornos' table. You can move, or remove it, as needed.
        Me.RetornosTableAdapter.Fill(Me.BibliotecaDataSet.Retornos)
        'TODO: This line of code loads data into the 'BibliotecaDataSet.Prestamo' table. You can move, or remove it, as needed.
        Me.PrestamoTableAdapter.Fill(Me.BibliotecaDataSet.Prestamo)

        Me.ReporteLibros.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ReporteLibros.Enabled = True
        ReporteLibros.Visible = True
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs)
    End Sub
End Class