Imports System.Data.SqlClient
Public Class Libros
    Dim conexion As New conexion()
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        llenarGenero()
        desactivar()
        conexion.mostar(DGlibros)
        cmbGenero.SelectedIndex = -1
    End Sub

    'Limpiar textBox y Buttons
    Private Sub limpiar()
        txtIdLibro.Clear()
        txtNombreLibro.Clear()
        TxtAutor.Clear()
        txtPublicacion.Clear()
        txtEditorial.Clear()
        txtPais.Clear()
        txtIdioma.Clear()
        llenarGenero()
        txtbuscar.Clear()
        txtIdLibro.Enabled = True
        cmbGenero.SelectedIndex = -1
        activarBotones()
    End Sub
    'funcion que permite llenar el cmbGenero con los datos de la tabla Genero
    Private Sub llenarGenero()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable
        Try
            DA = New SqlDataAdapter("select * from proyecto.genero", conexion.conexion)
            DA.Fill(DT)
            cmbGenero.DataSource = DT
            cmbGenero.DisplayMember = "nombre"
            cmbGenero.ValueMember = "idGenero"

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.conexion.Close()
        End Try
    End Sub
    'convierte la cadena de texto de idioma y pais en mayuscula y minusculas
    Function cadenaTexto(ByVal text As String)

        Return StrConv(text, VbStrConv.ProperCase)

    End Function

    'Inserta un nuevo libro
    Private Sub insertarLibro()
        Dim idLibro, estado, genero As Integer
        Dim nombre, autor, editorial, publicacion, pais, idioma As String
        idLibro = Val(txtIdLibro.Text)
        nombre = cadenaTexto(txtNombreLibro.Text)
        autor = cadenaTexto(TxtAutor.Text)
        editorial = cadenaTexto(txtEditorial.Text)
        genero = cmbGenero.SelectedIndex
        publicacion = Val(txtPublicacion.Text)
        pais = cadenaTexto(txtPais.Text)
        idioma = cadenaTexto(txtIdioma.Text)
        estado = 4
        Try
            If conexion.insertarLibro(idLibro, nombre, autor, editorial, genero, publicacion, pais, idioma, estado) Then
                MessageBox.Show("Libro Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                conexion.mostar(DGlibros)
                desactivar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'boton insertar libros
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Not IsNumeric(txtPublicacion.Text) Then
            MessageBox.Show("Debe ingresar un año valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf IsNumeric(txtPublicacion.text) Then
            Dim valor As Integer
            valor = Val(txtPublicacion.Text)
            If valor = 0 Then
                MessageBox.Show("Debe ingresar un año valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf valor < 1 Then
                MessageBox.Show("Debe ingresar un año valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

        End If

        If txtIdLibro.Text = "" Or txtNombreLibro.Text = "" Or TxtAutor.Text = "" Or txtEditorial.Text = "" Or cmbGenero.SelectedIndex = -1 Or txtPublicacion.Text = "" Or txtPais.Text = "" Or txtIdioma.Text = "" Then
            MessageBox.Show("Debe de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        insertarLibro()

    End Sub

    'boton eliminar libros
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdLibro.Text = "" Then
            MessageBox.Show("Debe de escribir el id del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If conexion.eliminarLibro(Val(txtIdLibro.Text)) = True Then
            MessageBox.Show("Libro Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        limpiar()
        desactivar()
        conexion.mostar(DGlibros)
    End Sub

    'boton Modificar libros
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim idLibro, genero As Integer
        Dim nombre, autor, editorial, publicacion, pais, idioma As String
        txtIdLibro.Enabled = False
        idLibro = Val(txtIdLibro.Text)
        nombre = cadenaTexto(txtNombreLibro.Text)
        autor = cadenaTexto(TxtAutor.Text)
        editorial = cadenaTexto(txtEditorial.Text)
        genero = cmbGenero.SelectedIndex
        publicacion = Val(txtPublicacion.Text)
        pais = cadenaTexto(txtPais.Text)
        idioma = cadenaTexto(txtIdioma.Text)

        Try
            If txtIdLibro.Text = "" Or txtNombreLibro.Text = "" Or TxtAutor.Text = "" Or txtEditorial.Text = "" Or cmbGenero.SelectedIndex = -1 Or txtPublicacion.Text = "" Or txtPais.Text = "" Or txtIdioma.Text = "" Then
                MessageBox.Show("Debe de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not IsNumeric(txtPublicacion.Text) Or txtPublicacion.Text <= 0 Or txtPublicacion.Text > 9999 Then
                MessageBox.Show("Debe ingresar un año valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If conexion.modificarLibros(idLibro, nombre, autor, editorial, genero, publicacion, pais, idioma) Then
                MessageBox.Show("Libro Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            limpiar()
            desactivar()
            conexion.mostar(DGlibros)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Activa los botones eliminar y editar
    Public Sub activar()
        btnEliminar.Enabled = True
        btnEditar.Enabled = True
    End Sub

    'desactiva los botones eliminar y editar
    Public Sub desactivar()
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
    End Sub

    Public Sub activarBotones()
        btnIngresar.Enabled = True
        btnBuscar.Enabled = True
    End Sub

    'boton Buscar por idLibro
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtbuscar.Text = "" Then
            MessageBox.Show("Debe de escribir el id del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        conexion.buscarYLlenarDGV(DGlibros, txtbuscar.Text)

    End Sub

    'Permite llenar las casillas de texto
    Private Sub DGlibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGlibros.CellContentClick
        Try
            Dim dg1libros As DataGridViewRow = DGlibros.Rows(e.RowIndex)
            txtIdLibro.Text = dg1libros.Cells(0).Value.ToString()
            txtNombreLibro.Text = dg1libros.Cells(1).Value.ToString()
            TxtAutor.Text = dg1libros.Cells(2).Value.ToString()
            txtEditorial.Text = dg1libros.Cells(3).Value.ToString()
            cmbGenero.SelectedIndex = dg1libros.Cells(4).Value.ToString()
            txtPublicacion.Text = dg1libros.Cells(5).Value.ToString()
            txtPais.Text = dg1libros.Cells(6).Value.ToString()
            txtIdioma.Text = dg1libros.Cells(7).Value.ToString()
            txtIdLibro.Enabled = False
            activar()
            botones()
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.conexion.Close()
        End Try
    End Sub

    Public Sub botones()
        btnIngresar.Enabled = False
        btnBuscar.Enabled = False
    End Sub
    'Limpia los textbox
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        desactivar()
        conexion.mostar(DGlibros)
    End Sub

    'error Provide idLibro
    Private Sub txtIdLibro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdLibro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'error Provide NombreLibro
    Private Sub txtNombreLibro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreLibro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'error Provide Autor
    Private Sub TxtAutor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtAutor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'error Provide editorial
    Private Sub txtEditorial_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEditorial.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'error Provide publicacion
    Private Sub txtPublicacion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPublicacion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'error Provide pais
    Private Sub txtPais_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPais.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'error Provide idioma
    Private Sub txtIdioma_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdioma.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    'ToolTip de idlibro
    Private Sub txtIdLibro_MouseHover(sender As Object, e As EventArgs) Handles txtIdLibro.MouseHover
        ToolTip.SetToolTip(txtIdLibro, "Ejemplo: 123")
        ToolTip.ToolTipTitle = "Codigo Libro"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de Nombrelibro
    Private Sub txtNombreLibro_MouseHover(sender As Object, e As EventArgs) Handles txtNombreLibro.MouseHover
        ToolTip.SetToolTip(txtNombreLibro, "Ejemplo: Harry Potter")
        ToolTip.ToolTipTitle = "nombre Libro"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de Autor
    Private Sub TxtAutor_MouseHover(sender As Object, e As EventArgs) Handles TxtAutor.MouseHover
        ToolTip.SetToolTip(TxtAutor, "Ejemplo: J.K Rowling")
        ToolTip.ToolTipTitle = "Nombre Autor"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de editorial
    Private Sub txtEditorial_MouseHover(sender As Object, e As EventArgs) Handles txtEditorial.MouseHover
        ToolTip.SetToolTip(txtEditorial, "Ejemplo: Editorial Salamandra")
        ToolTip.ToolTipTitle = "Nombre Editorial"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de publicacion
    Private Sub txtPublicacion_MouseHover(sender As Object, e As EventArgs) Handles txtPublicacion.MouseHover
        ToolTip.SetToolTip(txtPublicacion, "Ejemplo: 2004")
        ToolTip.ToolTipTitle = "Año de publicacion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de pais
    Private Sub txtPais_MouseHover(sender As Object, e As EventArgs) Handles txtPais.MouseHover
        ToolTip.SetToolTip(txtPais, "Ejemplo: EE.UU")
        ToolTip.ToolTipTitle = "Pais"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de idioma
    Private Sub txtIdioma_MouseHover(sender As Object, e As EventArgs) Handles txtIdioma.MouseHover
        ToolTip.SetToolTip(txtIdioma, "Ejemplo: Español")
        ToolTip.ToolTipTitle = "Idioma"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de ingresar
    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Ingresa un nuevo libro a la Biblioteca")
        ToolTip.ToolTipTitle = "Ingresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de editar
    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ToolTip.SetToolTip(btnEditar, "Edita un libro a la Biblioteca")
        ToolTip.ToolTipTitle = "Editar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de Buscar
    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip.SetToolTip(btnBuscar, "Realiza una busqueda de un libro en la Biblioteca")
        ToolTip.ToolTipTitle = "Buscar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de elimminar
    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        ToolTip.SetToolTip(btnEliminar, "Elimina un libro en la Biblioteca")
        ToolTip.ToolTipTitle = "Eliminar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de limpiar
    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(btnLimpiar, "Permite ingresar nuevos datos en las cajas de texto")
        ToolTip.ToolTipTitle = "Limpiar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    ''ToolTip de Genero
    Private Sub cmbGenero_MouseHover(sender As Object, e As EventArgs) Handles cmbGenero.MouseHover
        ToolTip.SetToolTip(cmbGenero, "Muestra la lista de generos existentes")
        ToolTip.ToolTipTitle = "Genero"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'ToolTip de Data Libros
    Private Sub DGlibros_MouseHover(sender As Object, e As EventArgs) Handles DGlibros.MouseHover
        ToolTip.SetToolTip(DGlibros, "Muestra la informacion de cada libro")
        ToolTip.ToolTipTitle = "Informacion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtbuscar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtbuscar.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtbuscar_MouseHover(sender As Object, e As EventArgs) Handles txtbuscar.MouseHover
        ToolTip.SetToolTip(txtbuscar, "Ejemplo: 123")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
