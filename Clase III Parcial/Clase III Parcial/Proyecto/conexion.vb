Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-HD05D0Q;Initial Catalog=Biblioteca;Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public dt As DataTable
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader
    'Conexion a la base de datos
    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    '---------------------------------------------------------Inicio FUNCIONES FORMULARIO LIBROS -------------------------------------------
    '---------------------------------------------------------SANDRA JACKELIN CALDERON RAMIREZ -------------------------------------------
    'Inserta un nuevo libro
    Public Function insertarLibro(idLibro As Integer, nombre As String, autor As String, editorial As String,
                                    genero As Integer, publicacion As String, pais As String, idioma As String, estado As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarLibros", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idLibro", idLibro)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@autor", autor)
            cmb.Parameters.AddWithValue("@editorial", editorial)
            cmb.Parameters.AddWithValue("@generoId", genero)
            cmb.Parameters.AddWithValue("@publicacion", publicacion)
            cmb.Parameters.AddWithValue("@pais", pais)
            cmb.Parameters.AddWithValue("@idioma", idioma)
            cmb.Parameters.AddWithValue("@estadoId", estado)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conexion.Close()
        End Try
    End Function
    'Muestra todos los datos de los libros existentes
    Public Function mostar(dgv As DataGridView)
        Try
            conexion.Open()
            cmb = New SqlCommand("BuscarLibro", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function


    ' Elimina el registro de un libro
    Public Function eliminarLibro(idLibro As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarLibro", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idLibro", idLibro)
            If cmb.ExecuteNonQuery <> 0 Then
                conexion.Close()
                Return True
            Else
                conexion.Close()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Muestra los datos de un libro
    Public Sub buscarYLlenarDGV(dgv As DataGridView, idlibro As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("BuscarLibrouno", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            With cmb.Parameters
                .Add(New SqlParameter("@idLibro", idlibro))
            End With
            da.Fill(dt)
            dgv.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    'Modifica el registro de un libro
    Public Function modificarLibros(ByVal idLibro As Integer, ByVal nombre As String, ByVal autor As String, ByVal editorial As String,
                                    ByVal genero As Integer, ByVal publicacion As String, ByVal pais As String, ByVal idioma As String, ByVal estadoId As Integer) As Boolean
        Try
            conexion.Open()
            cmb = New SqlCommand("ModificarLibros", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idLibro", idLibro)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@autor", autor)
            cmb.Parameters.AddWithValue("@editorial", editorial)
            cmb.Parameters.AddWithValue("@generoId", genero)
            cmb.Parameters.AddWithValue("@publicacion", publicacion)
            cmb.Parameters.AddWithValue("@pais", pais)
            cmb.Parameters.AddWithValue("@idioma", idioma)
            cmb.Parameters.AddWithValue("@estadoId", estadoId)

            If cmb.ExecuteNonQuery Then
                conexion.Close()
                Return True
            Else
                conexion.Close()
                Return False
            End If
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
        End Try
    End Function

    '---------------------------------------------------------FINAL FUNCIONES FORMULARIO LIBROS -------------------------------------------



    '------------------------------------------------------------- Inicio Funciones Formulario Estudiantes -------------------------------------
    '----------------------------------------------------------- OLMAN JOSUE GARCIA CABRERA -----------------------------------------------------------
    Public Function insertarAlumno(idAlumno As String, nombre As String, apellido As String, edad As String,
                                    facultadid As Integer, estadoid As Integer, multa As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarAlumno", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@IdAlumno", idAlumno)
            cmb.Parameters.AddWithValue("@Nombre", convertirMayusculas(nombre))
            cmb.Parameters.AddWithValue("@Apellido", convertirMayusculas(apellido))
            cmb.Parameters.AddWithValue("@Edad", edad)
            cmb.Parameters.AddWithValue("@Facultadid", facultadid)
            cmb.Parameters.AddWithValue("@Estadoid", estadoid)
            cmb.Parameters.AddWithValue("@Multa", multa)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function modificarAlumno(idAlumno As String, nombre As String, apellido As String, edad As String,
                                    facultadid As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("modificarAlumno", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@IdAlumno", idAlumno)
            cmb.Parameters.AddWithValue("@Nombre", convertirMayusculas(nombre))
            cmb.Parameters.AddWithValue("@Apellido", convertirMayusculas(apellido))
            cmb.Parameters.AddWithValue("@Edad", edad)
            cmb.Parameters.AddWithValue("@Facultadid", facultadid)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function buscarAlumno(idAlumno As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("buscarAlumno", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idAlumno", idAlumno)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function eliminarAlumno(idAlumno As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarAlumno", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idAlumno", idAlumno)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function mostrarAlumnos(DTGalumno As DataGridView)

        Try
            conexion.Open()
            cmb = New SqlCommand("llenarAlumno", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            da.Fill(dt)
            DTGalumno.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function convertirMayusculas(ByVal Texto As String)
        Return StrConv(Texto, VbStrConv.ProperCase)
    End Function

    Public Function convertirMinusculas(ByVal Texto As String)
        Return StrConv(Texto, VbStrConv.Lowercase)
        '---------------------------------------------------------FINAL FUNCIONES FORMULARIO ESTUDIANTES -------------------------------------------
    End Function

    '--------------------------------------------- Formulario Inicio Libros Prestados -------------------------------
    '---------------------------------------------------- Olman Josue Garcia Cabrera -------------------------------

    Public Function MostrarLibrosPrestados(DGLibrosPrestados As DataGridView)

        Try
            conexion.Open()
            cmb = New SqlCommand("MostrarLibrosPrestados", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            da.Fill(dt)
            DGLibrosPrestados.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub BuscarLibrosPrestados(dgv As DataGridView, idPrestamo As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("BuscarLibrosPrestados", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            With cmb.Parameters
                .Add(New SqlParameter("@idPrestamo", idPrestamo))
            End With
            da.Fill(dt)
            dgv.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    '--------------------------------------------- Formulario Final Libros Prestados -------------------------------

    '--------------------------------------------- Formulario Inicio Libros Vencidos -------------------------------
    '------------------------------------------------- Sandra Jackelin Calderon  -----------------------------------

    Public Function mostrarLibrosVencidos(DGLibrosVencidos As DataGridView)

        Try
            conexion.Open()
            cmb = New SqlCommand("mostrarLibrosVencidos", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            da.Fill(dt)
            DGLibrosVencidos.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub buscarLibrosVencidos(dgv As DataGridView, idAlumno As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("buscarLibrosVencidos", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            With cmb.Parameters
                .Add(New SqlParameter("@idAlumno", idAlumno))
            End With
            da.Fill(dt)
            dgv.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    '--------------------------------------------- Formulario Final Libros Vencidos -------------------------------
End Class


