Imports System.Text.RegularExpressions
Imports System.Globalization.CultureInfo
Imports System.Security.Cryptography
Imports System.Text
Imports System
Public Class Usuarios
    Dim conexion As New conexion()
    Dim cultureInfo As New System.Globalization.CultureInfo("es-MX")

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        conexion.mostarUsuarios(DGUsuarios)
    End Sub

    'username@midominio.com
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub botonesBlo()
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub botonesdes()
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub


    Private Sub limpiar()
        txtIdUsuario.Clear()
        txtUsername.Clear()
        txtApellido.Clear()
        txtUsername.Clear()
        txtEdad.Clear()
        txtContrasena.Clear()
        txtCorreo.Clear()
        conexion.mostarUsuarios(DGUsuarios)
        cbPuesto.SelectedIndex = -1
        txtNombreUsuario.Clear()
        botonesBlo()
    End Sub


    Private Sub insertarUsuaurio()
        Dim id As Integer
        Dim Nombre, Apellido, Correo, Puesto, contrasena As String
        Dim Edad As Integer
        Dim UserName, estado As String

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

        id = txtIdUsuario.Text
        Nombre = txtUsername.Text
        Apellido = txtApellido.Text
        UserName = txtUsername.Text
        contrasena = conexion.Encriptar(txtContrasena.Text)
        Correo = txtCorreo.Text
        Edad = txtEdad.Text
        Puesto = cbPuesto.Text
        estado = "activo"
        Try

            If conexion.insertarUsuarios(id, UserName, contrasena, fTCase(Nombre), fTCase(Apellido), Edad, Puesto, LCase(Correo), estado) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Function fTCase(str As String) As String
        'Return cultureInfo.TextInfo.ToTitleCase(str)
        Return StrConv(str, VbStrConv.ProperCase)
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        Dim puesto As String
        id = Val(txtIdUsuario.Text)
        puesto = cbPuesto.Text
        If conexion.eliminarUsuarios(id, puesto) = True Then
            MessageBox.Show("Usuario Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function cadenaTexto(ByVal text As String)

        Return StrConv(text, VbStrConv.ProperCase)

    End Function


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim id As Integer
        Dim Nombre, Apellido, Correo, Puesto, contrasena As String
        Dim Edad As Integer
        Dim UserName As String

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

        id = txtIdUsuario.Text
        Nombre = txtUsername.Text
        Apellido = txtApellido.Text
        UserName = txtUsername.Text
        contrasena = conexion.Encriptar(txtContrasena.Text)
        Correo = txtCorreo.Text
        Edad = txtEdad.Text
        Puesto = cbPuesto.Text

        Try

            If conexion.editarUsuarios(id, UserName, contrasena, Nombre, Apellido, Edad, Puesto, Correo) Then
                MessageBox.Show("Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub DGUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellContentClick

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuaurio()

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtnombreUsuario.Text = "" Then
            MessageBox.Show("Debe de escribir el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        conexion.buscarYLlenarUsuarios(DGUsuarios, txtNombreUsuario.Text)

    End Sub

    Private Sub DGlibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellContentClick

    End Sub
End Class