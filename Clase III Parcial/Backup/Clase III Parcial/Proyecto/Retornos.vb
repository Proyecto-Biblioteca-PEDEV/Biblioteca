Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Retornos
    Private Sub Retornos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDataGridPrestamos()
        mostrarPrestamos()
        bloquearModificar()
        bloquearFactura()
        obtenerFecha()
        controlCmbEstado()
    End Sub
    Private Sub mostrarPrestamos()
        mostrarDataGridPrestamos()
        Dim cn As New conexion
        Dim dt As DataTable = cn.mostrarTablaPrestamos()
        DGlibros.DataSource = dt
    End Sub
    Private Sub mostrarRetornos()
        mostrarDataGridRetornos()
        Dim cn As New conexion
        Dim dt As DataTable = cn.mostrarTablaRetornos()
        DGRetornos.DataSource = dt
    End Sub
    Private Sub obtenerFecha()
        Dim fecha As Date = Date.Today
        txtFechaRetorno.Text = fecha
    End Sub
    Private Sub insertarRetorno()
        Try
        Dim cn As New conexion
        Dim idretorno, libroid, prestamoid As Integer
        Dim multa As Double
        Dim alumnoid, estadoMulta As String
        Dim fechaRetorno As Date
        idretorno = txtIdRetorno.Text
        alumnoid = txtIdAlumno.Text
        libroid = txtIdLibro.Text
        prestamoid = txtIdPrestamo.Text
        fechaRetorno = txtFechaRetorno.Text
        multa = txtMulta.Text
            estadoMulta = asignarEstado()
            If cn.insertarRetornos(idretorno, alumnoid, libroid, prestamoid, fechaRetorno, multa, estadoMulta) Then
                MessageBox.Show("Se guardó el registro de retorno", "Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ocurrió un error al tratar de registrar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub buscarRetorno()
        Try
            Dim cn As New conexion
            Dim idretorno As Integer
            idretorno = txtBuscar.Text
            If cn.buscarRetornos(idretorno) Then
                MsgBox("Encontrado")
                mostrarBusqueda()
                activarModificar()
                cmbEstadoMulta.Enabled = True
            Else
                MsgBox("No se encontró ese registro")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mostrarBusqueda()
        Try
            Dim cn As New conexion
            Dim cmd As New SqlCommand("buscarRetorno", cn.conexion)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            cn.conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idretorno", txtBuscar.Text)
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                mostrarDataGridRetornos()
                DGRetornos.DataSource = dt
                activarModificar()
                cn.conexion.Close()
            Else
                DGRetornos.DataSource = Nothing
                cn.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub editarRetorno()
        Try
            Dim cn As New conexion
            Dim idretorno As Integer
            Dim estadoMulta As String
            idretorno = txtIdRetorno.Text
            estadoMulta = cmbEstadoMulta.Text
            If cn.editarRetorno(idretorno, estadoMulta) Then
                MessageBox.Show("Se modificó el registro de retorno correctamente", "Datos Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ocurrió un error al tratar de modificar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DGlibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGlibros.CellContentClick
        Dim fechaVence As Date
        Try
            Dim dgdatos As DataGridViewRow = DGlibros.Rows(e.RowIndex)
            txtIdPrestamo.Text = dgdatos.Cells(0).Value.ToString
            txtIdAlumno.Text = dgdatos.Cells(1).Value.ToString
            txtIdLibro.Text = dgdatos.Cells(3).Value.ToString
            fechaVence = dgdatos.Cells(6).Value.ToString
            calcularMulta(fechaVence)
            controlCmbEstado()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub calcularMulta(fechaVence As Date)
        Dim fechaRetorno As Date
        Dim multa As Double
        fechaRetorno = txtFechaRetorno.Text
        If (Date.Compare(fechaVence, fechaRetorno) < 0) Then
            Dim dias As Long = DateDiff(DateInterval.Day, fechaVence, fechaRetorno)
            multa = 50 * dias
            txtMulta.Text = multa
        Else
            multa = 0
            txtMulta.Text = multa
        End If
    End Sub
    Private Sub insertarFactura()
        Try
        Dim cn As New conexion
        Dim idretorno As Integer
        Dim montoFactura As Double
        Dim alumnoid As String
        Dim fecha As Date
        idretorno = txtIdRetorno.Text
        alumnoid = txtIdAlumno.Text
        fecha = txtFechaRetorno.Text
            montoFactura = txtMulta.Text
            If cn.insertarFactura(idretorno, alumnoid, montoFactura, fecha) Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub insertarFacturaEditar()
        Try
            Dim cn As New conexion
            Dim idretorno As Integer
            Dim fecha As Date
            idretorno = txtIdRetorno.Text
            fecha = txtFechaRetorno.Text
            If cn.insertarFacturaEditar(idretorno, fecha) Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function asignarEstado()
        Dim estado As String
        If (Val(txtMulta.Text) > 0) Then
            estado = cmbEstadoMulta.Text
        Else
            estado = "Ninguno"
        End If
        Return estado
    End Function
    Private Sub controlCmbEstado()
        If Val(txtMulta.Text) = 0 Then
            cmbEstadoMulta.Enabled = False
        Else
            cmbEstadoMulta.Enabled = True
        End If
    End Sub
    Private Function validarCampos()
        If txtIdRetorno.Text <> String.Empty And IsNumeric(txtIdRetorno.Text) And txtIdPrestamo.Text <> String.Empty And txtIdAlumno.Text <> String.Empty And txtIdLibro.Text <> String.Empty And txtFechaRetorno.Text <> String.Empty And txtMulta.Text <> String.Empty Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub mostrarDataGridPrestamos()
        btnRetornos.Enabled = True
        btnPrestamos.Enabled = False
        DGlibros.Enabled = True
        DGlibros.Visible = True
        DGRetornos.Enabled = False
        DGRetornos.Visible = False
    End Sub
    Private Sub mostrarDataGridRetornos()
        btnRetornos.Enabled = False
        btnPrestamos.Enabled = True
        DGlibros.Enabled = False
        DGlibros.Visible = False
        DGRetornos.Enabled = True
        DGRetornos.Visible = True
    End Sub
    Private Sub activarModificar()
        btnEditar.Enabled = True
    End Sub
    Private Sub bloquearModificar()
        btnEditar.Enabled = False
    End Sub
    Private Sub activarFactura()
        btnFactura.Enabled = True
    End Sub
    Private Sub bloquearFactura()
        btnFactura.Enabled = False
    End Sub
    Private Sub limpiar()
        txtIdRetorno.Clear()
        txtIdAlumno.Clear()
        txtIdPrestamo.Clear()
        txtIdLibro.Clear()
        txtFechaRetorno.Clear()
        txtMulta.Clear()
        txtBuscar.Clear()
        obtenerFecha()
        bloquearModificar()
        bloquearFactura()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        mostrarDataGridPrestamos()
    End Sub

    Private Sub btnRetornos_Click(sender As Object, e As EventArgs) Handles btnRetornos.Click
        mostrarRetornos()
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If validarCampos() = True Then
            insertarRetorno()
            mostrarRetornos()
            If cmbEstadoMulta.SelectedIndex = 0 Then
                activarFactura()
                insertarFactura()
            End If
        Else
            MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarRetorno()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarRetorno()
        If cmbEstadoMulta.SelectedIndex = 0 Then
            activarFactura()
            insertarFacturaEditar()
        End If
    End Sub
    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        factura.Show()
    End Sub
    Private Sub txtIdRetorno_MouseHover(sender As Object, e As EventArgs) Handles txtIdRetorno.MouseHover
        toolTip.SetToolTip(txtIdRetorno, "Ingrese el ID de retorno")
        toolTip.ToolTipTitle = "ID Retorno"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdAlumno_MouseHover(sender As Object, e As EventArgs) Handles txtIdAlumno.MouseHover
        toolTip.SetToolTip(txtIdAlumno, "Se asignará el ID del alumno")
        toolTip.ToolTipTitle = "ID Alumno"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdLibro_MouseHover(sender As Object, e As EventArgs) Handles txtIdLibro.MouseHover
        toolTip.SetToolTip(txtIdLibro, "Se asignará el ID del libro")
        toolTip.ToolTipTitle = "ID Libro"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdPrestamo_MouseHover(sender As Object, e As EventArgs) Handles txtIdPrestamo.MouseHover
        toolTip.SetToolTip(txtIdPrestamo, "Se asignará el ID del préstamo")
        toolTip.ToolTipTitle = "ID Préstamo"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtFechaRetorno_MouseHover(sender As Object, e As EventArgs) Handles txtFechaRetorno.MouseHover
        toolTip.SetToolTip(txtFechaRetorno, "Contiene la fecha en la que se realiza el retorno")
        toolTip.ToolTipTitle = "Fecha Retorno"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtBuscar_MouseHover(sender As Object, e As EventArgs) Handles txtBuscar.MouseHover
        toolTip.SetToolTip(txtBuscar, "Inserte el ID del Retorno que desea buscar")
        toolTip.ToolTipTitle = "Buscar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtMulta_MouseHover(sender As Object, e As EventArgs) Handles txtMulta.MouseHover
        toolTip.SetToolTip(txtMulta, "Calcula automáticamente el valor de  la multa")
        toolTip.ToolTipTitle = "Multa"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub cmbEstadoMulta_MouseHover(sender As Object, e As EventArgs) Handles cmbEstadoMulta.MouseHover
        toolTip.SetToolTip(cmbEstadoMulta, "Seleccione si la multa está pagada o no")
        toolTip.ToolTipTitle = "Estado Multa"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        toolTip.SetToolTip(btnIngresar, "Ingresa un registro en la tabla Retornos")
        toolTip.ToolTipTitle = "Ingresar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        toolTip.SetToolTip(btnEditar, "Modifica un registro de la tabla Retornos")
        toolTip.ToolTipTitle = "Modificar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        toolTip.SetToolTip(btnBuscar, "Busca un registro en la tabla Retornos")
        toolTip.ToolTipTitle = "Buscar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        toolTip.SetToolTip(btnLimpiar, "Limpia las cajas de texto")
        toolTip.ToolTipTitle = "Limpiar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnPrestamos_MouseHover(sender As Object, e As EventArgs) Handles btnPrestamos.MouseHover
        toolTip.SetToolTip(btnPrestamos, "Muestra la tabla de Préstamos")
        toolTip.ToolTipTitle = "Préstamos"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnRetornos_MouseHover(sender As Object, e As EventArgs) Handles btnRetornos.MouseHover
        toolTip.SetToolTip(btnRetornos, "Muestra la tabla de Retornos")
        toolTip.ToolTipTitle = "Retornos"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnFactura_MouseHover(sender As Object, e As EventArgs) Handles btnFactura.MouseHover
        toolTip.SetToolTip(btnFactura, "Muestra la Factura")
        toolTip.ToolTipTitle = "Factura"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdRetorno_Validating(sender As Object, e As CancelEventArgs) Handles txtIdRetorno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtIdRetorno.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No pueden dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub
    Private Sub txtIdAlumno_Validating(sender As Object, e As CancelEventArgs) Handles txtIdAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub
    Private Sub txtIdLibro_Validating(sender As Object, e As CancelEventArgs) Handles txtIdLibro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub
    Private Sub txtIdPrestamo_Validating(sender As Object, e As CancelEventArgs) Handles txtIdPrestamo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub
    Private Sub txtFechaRetorno_Validating(sender As Object, e As CancelEventArgs) Handles txtFechaRetorno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub
    Private Sub txtMulta_Validating(sender As Object, e As CancelEventArgs) Handles txtMulta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub
    Private Sub txtBuscar_Validating(sender As Object, e As CancelEventArgs) Handles txtBuscar.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtBuscar.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No puede ingresar datos que no sean números")
        End If
    End Sub
End Class