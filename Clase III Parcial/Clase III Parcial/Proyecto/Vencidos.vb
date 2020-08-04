Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class Vencidos
    Dim conexion As New conexion()

    Private Sub Vencidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        conexion.mostrarLibrosVencidos(DGVencidos)
    End Sub

    Private Sub txtIdAlumno_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtIdAlumno, "Ingrese un Alumno")
        ToolTip.ToolTipTitle = "Alumno"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdAlumno_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un ID Alumno")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtIdAlumno.Text = "" Then
            MessageBox.Show("Debe de escribir el id del Alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtIdAlumno.Text.Length <> 15 Then
            MessageBox.Show("Debe ingresar una identidad valida", "incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        conexion.buscarLibrosVencidos(DGVencidos, txtIdAlumno.Text)
    End Sub

    Private Sub limpiar()
        txtIdAlumno.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        conexion.MostrarLibrosPrestados(DGVencidos)
    End Sub
End Class