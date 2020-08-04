Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class factura
    Dim idretorno As String
    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarImpresion()
        idretorno = Retornos.txtIdRetorno.Text
        llenarFactura()
        validarCampos()
    End Sub
    Private Sub llenarFactura()
        Try
            Dim cn As New conexion
            cn.conexion.Open()
            Dim cmd As New SqlCommand("select idFactura, descripcion, concat(a.nombre, ' ', a.apellido) as nombre, fecha, montoFactura from proyecto.Facturas as f inner join proyecto.Alumno as a on f.alumnoid = a.idAlumno where f.idretorno = '" + idretorno + "'", cn.conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If (dr.Read()) Then
                txtIdFactura.Text = Convert.ToString(dr("idFactura"))
                txtDescripción.Text = Convert.ToString(dr("descripcion"))
                txtAlumno.Text = Convert.ToString(dr("nombre"))
                txtFecha.Text = Convert.ToString(dr("fecha"))
                txtMonto.Text = Convert.ToString(dr("montoFactura"))
            End If
            cn.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub validarCampos()
        If (txtIdFactura.Text <> String.Empty And txtDescripción.Text <> String.Empty And txtAlumno.Text <> String.Empty And txtMonto.Text <> String.Empty And txtFecha.Text <> String.Empty And txtEfectivo.Text <> String.Empty And IsNumeric(txtEfectivo.Text) And txtCambio.Text <> String.Empty) Then
            activarImpresion()
        Else
            desactivarImpresion()
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtEfectivo_TextChanged(sender As Object, e As EventArgs) Handles txtEfectivo.TextChanged
        Dim cambio As Double
        cambio = Val(txtEfectivo.Text) - Val(txtMonto.Text)
        txtCambio.Text = cambio
        If Val(txtCambio.Text) >= 0 Then
            activarImpresion()
        Else
            desactivarImpresion()
        End If
    End Sub
    Private Sub activarImpresion()
        btnImprimir.Enabled = True
    End Sub
    Private Sub desactivarImpresion()
        btnImprimir.Enabled = False
    End Sub
    Private Sub txtIdFactura_MouseHover(sender As Object, e As EventArgs) Handles txtIdFactura.MouseHover
        toolTip.SetToolTip(txtIdFactura, "Muestra el # de Factura")
        toolTip.ToolTipTitle = "# Factura"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtDescripción_MouseHover(sender As Object, e As EventArgs) Handles txtDescripción.MouseHover
        toolTip.SetToolTip(txtDescripción, "Muestra la descripción de la Factura")
        toolTip.ToolTipTitle = "Descripción"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtAlumno_MouseHover(sender As Object, e As EventArgs) Handles txtAlumno.MouseHover
        toolTip.SetToolTip(txtAlumno, "Muestra el nombre del alumno al que se le carga la Factura")
        toolTip.ToolTipTitle = "Alumno"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        toolTip.SetToolTip(txtFecha, "Muestra la fecha en la que fue emitida la factura")
        toolTip.ToolTipTitle = "Fecha"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtMonto_MouseHover(sender As Object, e As EventArgs) Handles txtMonto.MouseHover
        toolTip.SetToolTip(txtMonto, "Muestra el monto de la Factura")
        toolTip.ToolTipTitle = "Monto"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtEfectivo_MouseHover(sender As Object, e As EventArgs) Handles txtEfectivo.MouseHover
        toolTip.SetToolTip(txtEfectivo, "Ingrese el efectivo del alumno")
        toolTip.ToolTipTitle = "Efectivo"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtCambio_MouseHover(sender As Object, e As EventArgs) Handles txtCambio.MouseHover
        toolTip.SetToolTip(txtCambio, "Calcula el cambio del alumno")
        toolTip.ToolTipTitle = "Cambio"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        toolTip.SetToolTip(btnSalir, "Regresa al formulario de retornos")
        toolTip.ToolTipTitle = "Regresar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnImprimir_MouseHover(sender As Object, e As EventArgs) Handles btnImprimir.MouseHover
        toolTip.SetToolTip(btnImprimir, "Imprime la factura actual")
        toolTip.ToolTipTitle = "Imprimir"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEfectivo_Validating(sender As Object, e As CancelEventArgs) Handles txtEfectivo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And IsNumeric(txtEfectivo.Text) Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos ni ingresar datos que no sean números")
        End If
    End Sub

    Private Sub txtDescripción_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripción.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub txtIdFactura_Validating(sender As Object, e As CancelEventArgs) Handles txtIdFactura.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub txtAlumno_Validating(sender As Object, e As CancelEventArgs) Handles txtAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub txtFecha_Validating(sender As Object, e As CancelEventArgs) Handles txtFecha.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub txtMonto_Validating(sender As Object, e As CancelEventArgs) Handles txtMonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub txtCambio_Validating(sender As Object, e As CancelEventArgs) Handles txtCambio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        MsgBox("Imprimiendo...", vbInformation)
    End Sub
End Class