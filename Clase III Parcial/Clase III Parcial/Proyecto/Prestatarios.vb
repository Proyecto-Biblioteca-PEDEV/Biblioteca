Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Prestatarios
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Dim conexion As conexion = New conexion
    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Biblioteca;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Sub llenarDataGrid(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, alu.idAlumno as IdAlumno,alu.estadoid as EstadoAlumno,lib.nombre as NombreLibro,lib.idLibro as IdLibro,pres.fechaPrestamo as FechaPrestamo ,pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDataGridEstado(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select idLibro, nombre, estadoId from proyecto.libros where estadoId = 3", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatosPrestamo()
        mostrarDatosDisponibles()

        abrirConexion()
        llenarDataGrid(DGlibros)
        llenarDataGridEstado(DGDisponibles)
    End Sub
    Private Sub mostrarDatosPrestamo()
        conexion.Consulta("select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, alu.idAlumno as IdAlumno,alu.estadoid as EstadoAlumno,lib.nombre as NombreLibro,lib.idLibro as IdLibro,pres.fechaPrestamo as FechaPrestamo ,pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid", "proyecto.prestamo")
        DGlibros.DataSource = conexion.ds.Tables("proyecto.Prestamo")
    End Sub

    Private Sub mostrarDatosDisponibles()
        conexion.Consulta("select idLibro, nombre, estadoId from proyecto.libros where estadoId = 3", "proyecto.libros")
        DGDisponibles.DataSource = conexion.ds.Tables("proyecto.libros")
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If tstPrestamo.Text = "" Or txtAlumno.Text = "" Or txtIdLibro.Text = "" Or txtFechaEntrega.Text = "" Or txtFechaPrestamo.Text = "" Or txtEstado.Text = "" Then
                MessageBox.Show("Datos no completados, porfavor intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtEstadoAlumno.Text = "2" Then
                    MessageBox.Show("Accesso del alumno denegado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If txtEstado.Text = "4" Then
                        MessageBox.Show("Libro no disponible, intentelo denuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Ingresar()
                        mostrarDatosPrestamo()
                        mostrarDatosDisponibles()

                    End If


                End If
            End If
        Catch ex As Exception
            'MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

        conexion.conexion.Close()
    End Sub

    Private Sub Ingresar()
        Dim idPrestamo, idLibro As Integer
        Dim idAlumno, fechaPrestamo, fechaVencimiento As String
        idPrestamo = tstPrestamo.Text
        idAlumno = txtAlumno.Text
        idLibro = txtIdLibro.Text
        fechaPrestamo = txtFechaPrestamo.Text
        fechaVencimiento = txtFechaEntrega.Text

        Try
            If conexion.insertarUsuarioPrestamo(idPrestamo, idAlumno, idLibro, fechaPrestamo, fechaVencimiento) Then
                MessageBox.Show("Ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub editar()
        Dim idPrestamo, idLibro As Integer
        Dim idAlumno, fechaPrestamo, fechaVencimiento As String
        idPrestamo = tstPrestamo.Text
        idAlumno = txtAlumno.Text
        idLibro = txtIdLibro.Text
        fechaPrestamo = txtFechaPrestamo.Text
        fechaVencimiento = txtFechaEntrega.Text
        Try
            If (conexion.editarUsuarioPrestamo(idPrestamo, idAlumno, idLibro, fechaPrestamo, fechaVencimiento)) Then
                MsgBox("Editado Exitosamente")
                'conexion.conexion.Close()
            Else
                MsgBox("Error al editar")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub editarLibroNuevo()
        Dim idLibro As Integer
        idLibro = txtTemporal.Text
        Try
            If (conexion.editarUsuarioPrestamoLibrouevo(idLibro)) Then

                'conexion.conexion.Close()
            Else
                MsgBox("Error al editar libro anterior")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub editarLibroViejo()
        Dim idLibro As Integer
        idLibro = txtIdLibro.Text
        Try
            If (conexion.editarUsuarioPrestamoLibroViejo(idLibro)) Then

                'conexion.conexion.Close()
            Else
                MsgBox("Error al editar libro anterior")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Try
            If tstPrestamo.Text = "" Or txtAlumno.Text = "" Or txtIdLibro.Text = "" Or txtFechaEntrega.Text = "" Or txtFechaPrestamo.Text = "" Or txtEstado.Text = "" Then
                MessageBox.Show("Datos no completados, porfavor intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtEstado.Text = "4" Then
                    MessageBox.Show("Libro no disponible, intentelo denuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    editar()
                    mostrarDatosPrestamo()
                    mostrarDatosDisponibles()
                    If txtTemporal.Text = txtIdLibro.Text Then
                        MessageBox.Show("El libro conservara su estado ocupado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        editarLibroNuevo()
                        editarLibroViejo()
                    End If
                End If


            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

        conexion.conexion.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAlumno.Clear()
        txtFechaEntrega.Clear()
        txtFechaPrestamo.Clear()
        txtIdLibro.Clear()
        tstPrestamo.Clear()
        txtEstado.Clear()
        txtBusquedaLibro.Clear()
        txtBusquedaPrestamos.Clear()

        conexion.conectar()
        mostrarDatosPrestamo()
        mostrarDatosDisponibles()
        abrirConexion()

        btnEditar.Enabled = False

        conexion.conexion.Close()
    End Sub
    Private Sub busquedaDeDatos()
        conexion.Consulta("select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, alu.idAlumno as IdAlumno,alu.estadoid as EstadoAlumno,lib.nombre as NombreLibro,lib.idLibro as IdLibro,pres.fechaPrestamo as FechaPrestamo ,pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid where idPrestamo = '" + txtBusquedaPrestamos.Text + "'", "proyecto.Prestamo")
        DGlibros.DataSource = conexion.ds.Tables("proyecto.Prestamo")
    End Sub

    Private Sub busquedaDeDatosLibro()
        conexion.Consulta("select idLibro, nombre, estadoId from proyecto.libros where idLibro = '" + txtBusquedaLibro.Text + "'", "proyecto.libros")
        DGDisponibles.DataSource = conexion.ds.Tables("proyecto.libros")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.conectar()
        abrirConexion()
        conexion.Consulta("select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, alu.idAlumno as IdAlumno,alu.estadoid as EstadoAlumno,lib.nombre as NombreLibro,lib.idLibro as IdLibro,pres.fechaPrestamo as FechaPrestamo ,pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid where idPrestamo = '" + txtBusquedaPrestamos.Text + "'", "proyecto.Prestamo")

        If (conexion.validarEmpleadosPrestamo(txtBusquedaPrestamos.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            btnEditar.Enabled = True
            busquedaDeDatos()
        End If
        conexion.conexion.Close()
    End Sub

    Private Sub DGlibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGlibros.CellContentClick
        Try
            Dim dgPrestamo As DataGridViewRow = DGlibros.Rows(e.RowIndex)
            tstPrestamo.Text = dgPrestamo.Cells(0).Value.ToString()
            txtAlumno.Text = dgPrestamo.Cells(2).Value.ToString()
            txtEstadoAlumno.Text = dgPrestamo.Cells(3).Value.ToString()
            txtTemporal.Text = dgPrestamo.Cells(5).Value.ToString()
            txtFechaPrestamo.Text = dgPrestamo.Cells(6).Value.ToString()
            txtFechaEntrega.Text = dgPrestamo.Cells(7).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub DGDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDisponibles.CellContentClick
        Try
            Dim dgPrestamo As DataGridViewRow = DGDisponibles.Rows(e.RowIndex)
            txtIdLibro.Text = dgPrestamo.Cells(0).Value.ToString()
            txtEstado.Text = dgPrestamo.Cells(2).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion.conectar()
        abrirConexion()
        conexion.Consulta("select idLibro, nombre, estadoId from proyecto.libros where idPrestamo = '" + txtBusquedaLibro.Text + "'", "proyecto.libros")

        If (conexion.validarEmpleadosPrestamoDeLibros(txtBusquedaLibro.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatosLibro()

        End If
        conexion.conexion.Close()
    End Sub

    Private Sub tstPrestamo_MouseHover(sender As Object, e As EventArgs) Handles tstPrestamo.MouseHover
        ToolTip.SetToolTip(tstPrestamo, "Ejemplo: 1")
        ToolTip.ToolTipTitle = "Id Del Prestamo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlumno_MouseHover(sender As Object, e As EventArgs) Handles txtAlumno.MouseHover
        ToolTip.SetToolTip(txtAlumno, "Ejemplo: 0318-2004-02610")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdLibro_MouseHover(sender As Object, e As EventArgs) Handles txtIdLibro.MouseHover
        ToolTip.SetToolTip(txtIdLibro, "Ejemplo: 123")
        ToolTip.ToolTipTitle = "Id Libro"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFechaPrestamo_MouseHover(sender As Object, e As EventArgs) Handles txtFechaPrestamo.MouseHover
        ToolTip.SetToolTip(txtFechaPrestamo, "Ejemplo: 01/01/2020")
        ToolTip.ToolTipTitle = "Fecha de Prestamo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFechaEntrega_MouseHover(sender As Object, e As EventArgs) Handles txtFechaEntrega.MouseHover
        ToolTip.SetToolTip(txtFechaEntrega, "Ejemplo: 02/01/2020")
        ToolTip.ToolTipTitle = "fecha de Entrega"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEstado_MouseHover(sender As Object, e As EventArgs) Handles txtEstado.MouseHover
        ToolTip.SetToolTip(txtEstado, "Ejemplo: 04")
        ToolTip.ToolTipTitle = "Estado del libro"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEstadoAlumno_MouseHover(sender As Object, e As EventArgs) Handles txtEstadoAlumno.MouseHover
        ToolTip.SetToolTip(txtEstadoAlumno, "Ejemplo: 01")
        ToolTip.ToolTipTitle = "Estado del alumno"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Añadir un prestamo")
        ToolTip.ToolTipTitle = "Añadir"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ToolTip.SetToolTip(btnEditar, "Editar un prestamo")
        ToolTip.ToolTipTitle = "Editar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(btnLimpiar, "Limpiar Text box")
        ToolTip.ToolTipTitle = "Limpiar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip.SetToolTip(btnBuscar, "Buscar info en prestamos")
        ToolTip.ToolTipTitle = "Buscar Prestamos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip.SetToolTip(Button2, "Buscar info de libros disponibles")
        ToolTip.ToolTipTitle = "Buscar Libro Disponibles"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub tstPrestamo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tstPrestamo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlumno.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdLibro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdLibro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtFechaPrestamo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFechaPrestamo.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtFechaEntrega_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFechaEntrega.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEstado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEstadoAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEstadoAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

End Class