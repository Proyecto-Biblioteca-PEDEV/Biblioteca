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
            If txtIdAlumno.Text.Length <> 15 Then
                MessageBox.Show("Debe ingresar una identidad valida", "incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Si las casillas estan sin ningun valor
            If txtIdAlumno.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtEdad.Text = "" Or cmbFacultad.SelectedIndex = -1 Then
                MessageBox.Show("Debe llenar todos los datos que se le solicitan", "Registro Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                insertarAlumno()

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
        If txtIdAlumno.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtEdad.Text = "" Or cmbFacultad.SelectedIndex = -1 Then
            MessageBox.Show("Debe llenar todos los datos que se le solicitan", "Registro Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            modificarAlumno()
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Length <> 15 Then
            MessageBox.Show("Debe ingresar una identidad valida", "incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
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
        txtBuscar.Clear()
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

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Ingresa un nuevo Alumno")
        ToolTip.ToolTipTitle = "Ingresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de editar
    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ToolTip.SetToolTip(btnEditar, "Edita el registro del Alumno")
        ToolTip.ToolTipTitle = "Editar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de Buscar
    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip.SetToolTip(btnBuscar, "Realiza una busqueda de un Alumno")
        ToolTip.ToolTipTitle = "Buscar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de elimminar
    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        ToolTip.SetToolTip(btnEliminar, "Elimina un Alumno")
        ToolTip.ToolTipTitle = "Eliminar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de limpiar
    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(btnLimpiar, "Permite ingresar nuevos datos en las cajas de texto")
        ToolTip.ToolTipTitle = "Limpiar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class