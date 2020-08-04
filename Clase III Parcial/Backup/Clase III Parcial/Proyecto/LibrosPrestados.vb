Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class LibrosPrestados
    Dim conexion As New conexion()

    Private Sub LibrosPrestados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        conexion.MostrarLibrosPrestados(DGlibrosPrestados)
    End Sub

    Private Sub txtIdLibro_MouseHover(sender As Object, e As EventArgs) Handles txtIdPrestamo.MouseHover
        ToolTip.SetToolTip(txtIdPrestamo, "Ingrese un Codigo")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdLibro_Validating(sender As Object, e As CancelEventArgs) Handles txtIdPrestamo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un Codigo")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtIdPrestamo.Text = "" Then
            MessageBox.Show("Debe de escribir el id del Prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        conexion.BuscarLibrosPrestados(DGlibrosPrestados, txtIdPrestamo.Text)
    End Sub

    Private Sub limpiar()
        txtIdPrestamo.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        conexion.MostrarLibrosPrestados(DGlibrosPrestados)
    End Sub
End Class