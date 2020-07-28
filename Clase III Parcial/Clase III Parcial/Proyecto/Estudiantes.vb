Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class Estudiantes
    Dim conexion As New conexion()
    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        conexion.mostrarAlumnos(DTGAlumno)
        limpiar()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If Not IsNumeric(txtEdad.Text) Then
                MessageBox.Show("Debe ingresar una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf IsNumeric(txtEdad.text) Then
                Dim valor As Integer
                valor = Val(txtEdad.Text)
                If valor = 0 Then
                    MessageBox.Show("Debe ingresar una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                ElseIf valor < 1 Then
                    MessageBox.Show("Debe ingresar una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                End If

            End If
            'Si las casillas estan sin ningun valor
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtApellido.Text <> String.Empty And txtEdad.Text <> String.Empty Then
                MessageBox.Show("Datos Ingresados Correctamente", "Registro Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If txtIdAlumno.Text = "" Then
                MessageBox.Show("El cuadro esta vacio o no esta lleno totalmente")
            ElseIf txtNombre.Text = "" Then
                MessageBox.Show("Ingrese el Nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtApellido.Text = "" Then
                MessageBox.Show("Ingrese el Apellido", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtEdad.Text = "" Then
                MessageBox.Show("Ingrese la Edad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                insertarAlumno()
                'mostrarDatos()
                conexion.mostrarAlumnos(DTGAlumno)
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarDatos()
        Dim cmd As New SqlCommand("Select * from proyecto.Alumno", conexion.conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Try
            conexion.conexion.Open()
            cmd.CommandType = CommandType.Text
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                DTGAlumno.DataSource = dt
                conexion.conexion.Close()
            Else
                DTGAlumno.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub insertarAlumno()
        Dim facultadid, estadoid As Integer
        Dim nombre, apellido, edad, idAlumno, multa As String
        idAlumno = txtIdAlumno.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        edad = txtEdad.Text
        facultadid = cmbFacultad.SelectedIndex
        estadoid = "1"
        multa = ""
        Try
            If conexion.insertarAlumno(idAlumno, nombre, apellido, edad, facultadid, estadoid, multa) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub modificarAlumno()
        Dim facultadid As Integer
        Dim idAlumno, nombre, apellido, edad As String
        idAlumno = txtIdAlumno.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        edad = txtEdad.Text
        facultadid = cmbFacultad.SelectedIndex
        Try
            If conexion.modificarAlumno(idAlumno, nombre, apellido, edad, facultadid) Then
                MessageBox.Show("Estudiante Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al actualizar Estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.mostrarAlumnos(DTGAlumno)
            'conexion.mostrarAlumnos(DTGAlumno)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buscarAlumno()

        Dim userName As String
        userName = txtBuscar.Text
        Try
            If (conexion.buscarAlumno(userName)) Then
                MsgBox("Encontrado")
                mostrarBusqueda()
                'conexion.conexion.Close()
            Else
                MsgBox("Error al buscar")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarBusqueda()
        Dim cmd As New SqlCommand("buscarAlumno", conexion.conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Try
            conexion.conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdAlumno", txtBuscar.Text)
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                DTGAlumno.DataSource = dt
                conexion.conexion.Close()
            Else
                DTGAlumno.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarAlumno()
        Dim idAlumno As String
        idAlumno = txtIdAlumno.Text
        Try
            If (conexion.eliminarAlumno(idAlumno)) Then
                MsgBox("El Estudiante fue Eliminado")
                conexion.conexion.Close()
                limpiar()
            Else
                MsgBox("Error al Eliminar Estudiante")
                conexion.conexion.Close()
            End If
            conexion.mostrarAlumnos(DTGAlumno)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Not IsNumeric(txtEdad.Text) Then
            MessageBox.Show("Debe ingresar una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf IsNumeric(txtEdad.Text) Then
            Dim valor As Integer
            valor = Val(txtEdad.Text)
            If valor = 0 Then
                MessageBox.Show("Debe ingresar una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf valor < 1 Then
                MessageBox.Show("Debe ingresar una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        modificarAlumno()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarAlumno()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarAlumno()
    End Sub

    Private Sub limpiar()
        txtIdAlumno.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        txtIdAlumno.Enabled = True
        cmbFacultad.SelectedIndex = -1
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        conexion.mostrarAlumnos(DTGAlumno)
        'conexion.mostrarAlumnos(DTGAlumno)
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingreser un Nombre")
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un Apellido")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese una Edad")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese un Nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        ToolTip.SetToolTip(txtApellido, "Ingrese un Apellido")
        ToolTip.ToolTipTitle = "Apellido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ingrese una Edad")
        ToolTip.ToolTipTitle = "Edad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub MaskIdAlumno_MouseHover(sender As Object, e As EventArgs) Handles MaskIdAlumno.MouseHover

    End Sub

    Private Sub DTGAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGAlumno.CellContentClick
        Dim dataAlumnos As DataGridViewRow = DTGAlumno.Rows(e.RowIndex)

        txtIdAlumno.Text = dataAlumnos.Cells(0).Value.ToString()
        txtNombre.Text = dataAlumnos.Cells(1).Value.ToString()
        txtApellido.Text = dataAlumnos.Cells(2).Value.ToString()
        txtEdad.Text = dataAlumnos.Cells(3).Value.ToString()
        cmbFacultad.SelectedIndex = dataAlumnos.Cells(4).Value.ToString()
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        txtIdAlumno.Enabled = False
    End Sub


End Class