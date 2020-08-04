Imports System.Text.RegularExpressions
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Usuarios
    Dim conexion As New conexion()
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public cn As SqlConnection


    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatos()
        llenarDataGrid(DGlibros)
    End Sub

    Private Sub mostrarDatos()
        conexion.Consulta("select * from proyecto.Usuarios", "proyecto.Usuarios")
        DGlibros.DataSource = conexion.ds.Tables("proyecto.Usuarios")
    End Sub

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub limpiar()
        txtIdUsuario.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        cbPuesto.Text = String.Empty
        txtCorreo.Clear()
        txtContraseña.Clear()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuarios()
            'MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.conexion.Close()
        End If
        mostrarDatos()
    End Sub

    Private Sub insertarUsuarios()
        Dim id As Integer
        Dim Nombre, Apellido, Correo, Puesto, contrasena, estado As String
        Dim Edad As Integer
        Dim UserName As String

        Select Case cbPuesto.SelectedIndex
            Case 0
                Puesto = "Admin"
            Case 1
                Puesto = "Invitado"
        End Select

        id = txtIdUsuario.Text
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        UserName = txtUserName.Text
        contrasena = txtContraseña.Text
        Correo = txtCorreo.Text

        estado = txtEstado.Text

        Try
            If conexion.insertarUsuarios(id, UserName, contrasena, Nombre, Apellido, Edad, Puesto, Correo, estado) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("No se por que" + ex.ToString)
        End Try
        mostrarDatos()
    End Sub


    Private Sub eliminarUsuarios()
        Dim id As Integer
        Dim Puesto As String
        id = txtIdUsuario.Text
        Puesto = cbPuesto.Text
        Try
            If (conexion.eliminarUsuarios(id, Puesto)) Then
                MsgBox("Dado de baja")
                'conexion.conexion.Close()
            Else
                MsgBox("Error al dar de baja usuario")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        mostrarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuarios()
        mostrarDatos()
    End Sub

    Private Sub editarUsuarios()
        Dim id As Integer
        Dim Nombre, Apellido, Correo, Puesto, contrasena As String
        Dim Edad As Integer
        Dim UserName As String

        Select Case cbPuesto.SelectedIndex
            Case 0
                Puesto = "Admin"
            Case 1
                Puesto = "Invitado"
        End Select

        id = txtIdUsuario.Text
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        UserName = txtUserName.Text
        contrasena = txtContraseña.Text
        Correo = txtCorreo.Text
        Edad = txtEdad.Text

        Try
            If conexion.editarUsuarios(id, UserName, contrasena, Nombre, Apellido, Edad, Puesto, Correo) Then
                MsgBox("Dado de baja")
                conexion.conexion.Close()
            Else
                MsgBox("Error al dar de baja usuario")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("No se por que" + ex.ToString)
        End Try
    End Sub

    Sub llenarDataGrid(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from proyecto.Usuarios", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarUsuarios()
        mostrarDatos()
    End Sub

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=RK800\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub busquedaDeDatos()
        conexion.Consulta("select * from proyecto.Usuarios where id = '" + txtIdUsuario.Text + "'", "proyecto.Usuarios")
        DGlibros.DataSource = conexion.ds.Tables("proyecto.Usuarios")
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.conectar()
        abrirConexion()
        conexion.Consulta("select * from proyecto.Usuarios where id = '" + txtIdUsuario.Text + "'", "proyecto.Usuarios")

        If (conexion.validarUsuarios(txtIdUsuario.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatos()
        End If
    End Sub


End Class