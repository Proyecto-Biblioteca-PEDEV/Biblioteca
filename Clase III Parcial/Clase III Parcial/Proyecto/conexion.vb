Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=Biblioteca;Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public dt As DataTable
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public comando As SqlCommand
    Public lectorVariables As SqlDataReader
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
    '--------------------------------------------- Inicio Formulario Retornos -------------------------------------
    '--------------------------------------------- Sven Alessandro Rodriguez  -------------------------------------
    Public Function mostrarTablaPrestamos()
        Dim cmd As New SqlCommand("mostrarPrestamos", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Public Function mostrarTablaRetornos()
        Dim cmd As New SqlCommand("mostrarRetornos", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function
    Public Function insertarRetornos(idretorno As Integer, alumnoid As String,
    libroid As Integer, prestamoid As Integer, fechaRetorno As Date, multa As Double, estadoMulta As String)
        Try
            conexion.Open()
            cmd = New SqlCommand("insertarRetorno", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idretorno", idretorno)
            cmd.Parameters.AddWithValue("@alumnoid", alumnoid)
            cmd.Parameters.AddWithValue("@libroid", libroid)
            cmd.Parameters.AddWithValue("@prestamoid", prestamoid)
            cmd.Parameters.AddWithValue("@fechaRetorno", fechaRetorno)
            cmd.Parameters.AddWithValue("@multa", multa)
            cmd.Parameters.AddWithValue("@estadoMulta", estadoMulta)
            If cmd.ExecuteNonQuery <> 0 Then
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
    Public Function buscarRetornos(idretorno As Integer)
        Try
            conexion.Open()
            cmd = New SqlCommand("buscarRetorno", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idretorno", idretorno)
            If cmd.ExecuteNonQuery <> 0 Then
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
    Public Function editarRetorno(idretorno As Integer, estadoMulta As String)
        Try
            conexion.Open()
            cmd = New SqlCommand("editarRetorno", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idretorno", idretorno)
            cmd.Parameters.AddWithValue("@estadoMulta", estadoMulta)
            If cmd.ExecuteNonQuery <> 0 Then
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
    Public Function insertarFactura(idretorno As Integer, alumnoid As String, montoFactura As Double, fecha As Date)
        Try
            conexion.Open()
            cmd = New SqlCommand("insertarFactura", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idretorno", idretorno)
            cmd.Parameters.AddWithValue("@alumnoid", alumnoid)
            cmd.Parameters.AddWithValue("@montoFactura", montoFactura)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            If cmd.ExecuteNonQuery <> 0 Then
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
    Public Function insertarFacturaEditar(idretorno As Integer, fecha As Date)
        Try
            conexion.Open()
            cmd = New SqlCommand("insertarFacturaEditar", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idretorno", idretorno)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            If cmd.ExecuteNonQuery <> 0 Then
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
    '------------------------------ Final Formulario Retornos ------------------------------------------'

    '--------------------------------------------- FORMULARIO PRESTAMOS -------------------------------
    '------------------------------------------------- ERNESTO JOSE FLORES -----------------------------------

    Public cmbB As SqlCommand
    Public scmb As SqlCommandBuilder
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public cmbP As SqlCommandBuilder


    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        Try
            ds.Tables.Clear()
            da = New SqlDataAdapter(sql, conexion)
            cmbP = New SqlCommandBuilder(da)
            da.Fill(ds, tabla)
        Catch ex As Exception
            'MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

    End Sub

    Public Function insertarUsuarioPrestamo(idPrestamo As Integer, idAlumno As String, idLibro As Integer, fechaPrestamo As String, fechaVencimiento As String)
        Try
            conexion.Open()
            cmbB = New SqlCommand("InsertarPrestamo", conexion)
            cmbB.CommandType = CommandType.StoredProcedure
            Dim estado As Integer
            estado = 4

            cmbB.Parameters.AddWithValue("@idPrestamo", idPrestamo)
            cmbB.Parameters.AddWithValue("@idAlumno", idAlumno)
            cmbB.Parameters.AddWithValue("@idLibro", idLibro)
            cmbB.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)
            cmbB.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento)
            cmbB.Parameters.AddWithValue("@idEstado", estado)
            If cmbB.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ' MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        End Try
        conexion.Close()
    End Function

    Public Function editarUsuarioPrestamo(idPrestamo As Integer, idAlumno As String, idLibro As Integer, fechaPrestamo As String, fechaVencimiento As String)
        Try
            conexion.Open()
            cmbB = New SqlCommand("EditarPrestamo", conexion)
            cmbB.CommandType = CommandType.StoredProcedure


            cmbB.Parameters.AddWithValue("@idPrestamo", idPrestamo)
            cmbB.Parameters.AddWithValue("@idAlumno", idAlumno)
            cmbB.Parameters.AddWithValue("@idLibro", idLibro)
            cmbB.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)
            cmbB.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento)
            If cmbB.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ' MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function editarUsuarioPrestamoLibrouevo(idLibro As Integer)
        Try
            conexion.Open()
            cmbB = New SqlCommand("EditarlibroEditado ", conexion)
            cmbB.CommandType = CommandType.StoredProcedure
            Dim estadoLibro As Integer
            estadoLibro = 3

            cmbB.Parameters.AddWithValue("@estadoLibro", estadoLibro)
            cmbB.Parameters.AddWithValue("@idLibro", idLibro)

            If cmbB.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ' MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function editarUsuarioPrestamoLibroViejo(idLibro As Integer)
        Try
            conexion.Open()
            cmbB = New SqlCommand("EditarLibroViejo", conexion)
            cmbB.CommandType = CommandType.StoredProcedure
            Dim estadoLibro As Integer
            estadoLibro = 4

            cmbB.Parameters.AddWithValue("@estadoLibro", estadoLibro)
            cmbB.Parameters.AddWithValue("@idLibro", idLibro)

            If cmbB.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ' MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


    Function validarEmpleadosPrestamo(ByVal id As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, alu.idAlumno as IdAlumno,alu.estadoid as EstadoAlumno,lib.nombre as NombreLibro,lib.idLibro as IdLibro,pres.fechaPrestamo as FechaPrestamo ,pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid where idPrestamo = '" + id + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return respuesta
    End Function

    Function validarEmpleadosPrestamoDeLibros(ByVal id As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from proyecto.libros where idLibro = '" + id + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If

        Catch ex As Exception
            ' MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

        Return respuesta
    End Function

    Function validarIngresoPrestamos(ByVal codigo As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select idLibro, nombre, estadoId from proyecto.libros where idLibro = '" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Return respuesta
        conexion.Close()
    End Function

    '--------------------------------------------- Formulario Final Libros Vencidos -------------------------------

    '------------------------- FUNCION DE FORMULARIO USUARIO -------------------------------------------------------
    '----------------------------- GLORIA MURILLO--------------------------------------------------------------
    'Ingresar Un Usuario
    Public Function insertarUsuarios(id As Integer, UserName As String, contrasena As String, Nombre As String,
                                 Apellido As String, Edad As Integer, Puesto As String, Correo As String, estado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@UserName", UserName)
            cmb.Parameters.AddWithValue("@contrasena", contrasena)
            cmb.Parameters.AddWithValue("@Nombre", Nombre)
            cmb.Parameters.AddWithValue("@Apellido", Apellido)
            cmb.Parameters.AddWithValue("@Edad", Edad)
            cmb.Parameters.AddWithValue("@Puesto", Puesto)
            cmb.Parameters.AddWithValue("@Correo", Correo)
            cmb.Parameters.AddWithValue("@estado", estado)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("No se por que" + ex.ToString)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    'Buscar un Usuario por ID
    Public Function buscarUsuarios(UserName As Integer) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@UserName", UserName)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    'Eliminar Usuario
    Public Function eliminarUsuarios(id As Integer, Puesto As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@Puesto", Puesto)
            Return If(cmb.ExecuteNonQuery <> 0, True, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function editarUsuarios(id As Integer, UserName As String, contrasena As String, Nombre As String,
                                 Apellido As String, Edad As Integer, Puesto As String, Correo As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@UserName", UserName)
            cmb.Parameters.AddWithValue("@contrasena", contrasena)
            cmb.Parameters.AddWithValue("@Nombre", Nombre)
            cmb.Parameters.AddWithValue("@Apellido", Apellido)
            cmb.Parameters.AddWithValue("@Edad", Edad)
            cmb.Parameters.AddWithValue("@Puesto", Puesto)
            cmb.Parameters.AddWithValue("@Correo", Correo)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Function validarUsuarios(ByVal id As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from proyecto.Usuarios where id = '" + id + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

        Return respuesta
    End Function

    Public Function mostarUsuarios(dgv As DataGridView)
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrarUsuario", conexion)
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


    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Sub buscarYLlenarUsuarios(dgv As DataGridView, UserName As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("buscarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            With cmb.Parameters
                .Add(New SqlParameter("@UserName", UserName))
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


    '----------------------------------------------------------- Recuperar Contraseña ----------------------------------------------
    '--------------------------------------------------------- Inicio Recuperar Contraseña -----------------------------------------
    Public Function obtenerVariableEntera(ByVal instruccion As String, columnas As String) As Integer
        Try
            conexion.Open()
            Dim valor As Integer
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            While lectorVariables.Read
                valor = Convert.ToInt16(lectorVariables(columnas))
            End While
            lectorVariables.Close()
            conexion.Close()
            Return valor
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

    Public Function comprobarExistencias(ByVal instruccion As String) As Integer
        Try
            conexion.Open()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = instruccion
            Dim existe As String = CStr(comando.ExecuteScalar())
            If existe <> "" Then
                conexion.Close()
                Return 1
            Else
                conexion.Close()
                Return 2
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

    Public Function comprobarUsuario(ByVal UserName As String, ByVal contra As String) As Boolean

        conexion.Open()
        Dim sqlcomando As String = "Select * from proyecto.Usuarios where UserName = '" & UserName & "' And contrasena ='" & contra & "' "
        comando = conexion.CreateCommand
        comando.CommandText = sqlcomando

        Dim t As Object = CInt(comando.ExecuteScalar())

        conexion.Close()
        If t = 0 Then
            Return False
        End If

        Return True

    End Function
    Public Function obtenerVariableCadena(ByVal instruccion As String, columnas As String) As String
        Try
            conexion.Open()
            Dim valorS As String
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            If lectorVariables.Read Then
                valorS = Convert.ToString(lectorVariables(columnas))
            Else
                Return Nothing
            End If
            lectorVariables.Close()
            conexion.Close()
            Return valorS
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function
    '--------------------------------------------------------- Fin Recuperar Contraseña -----------------------------------------

End Class

