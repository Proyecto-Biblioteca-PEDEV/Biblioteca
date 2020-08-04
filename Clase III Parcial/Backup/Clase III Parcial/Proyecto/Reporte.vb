Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BibliotecaDataSet.Retornos' table. You can move, or remove it, as needed.
        Me.RetornosTableAdapter.Fill(Me.BibliotecaDataSet.Retornos)
        'TODO: This line of code loads data into the 'BibliotecaDataSet.Prestamo' table. You can move, or remove it, as needed.
        Me.PrestamoTableAdapter.Fill(Me.BibliotecaDataSet.Prestamo)

        Me.ReporteLibros.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ReporteLibros.Enabled = True
        ReporteLibros.Visible = True
        ReportePrestamos.Enabled = False
        ReportePrestamos.Visible = False
        ReporteRetornos.Enabled = False
        ReporteRetornos.Visible = False
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        ReporteLibros.Enabled = False
        ReporteLibros.Visible = False
        ReportePrestamos.Enabled = True
        ReportePrestamos.Visible = True
        ReporteRetornos.Enabled = False
        ReporteRetornos.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReporteLibros.Enabled = False
        ReporteLibros.Visible = False
        ReportePrestamos.Enabled = False
        ReportePrestamos.Visible = False
        ReporteRetornos.Enabled = True
        ReporteRetornos.Visible = True
    End Sub
End Class