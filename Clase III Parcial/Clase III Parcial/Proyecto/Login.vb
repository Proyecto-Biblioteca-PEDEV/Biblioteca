Imports System.ComponentModel

Public Class Login

    Dim conexion As conexion = New conexion

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        btnOcultarContra.Visible = False
        txtContrasena.PasswordChar = "●"
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim usuario, contrasena As String
        usuario = txtUsuario.Text
        contrasena = txtContrasena.Text

        If conexion.comprobarUsuario(usuario, contrasena) = True Then
            ChargeScreen.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o Contraseña incorrectos!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        recuperar.Show()
    End Sub

    Private Sub btnMostrarContra_Click(sender As Object, e As EventArgs) Handles btnMostrarContra.Click
        btnMostrarContra.Visible = False
        btnOcultarContra.Visible = True
        txtContrasena.PasswordChar = ""
    End Sub

    Private Sub btnOcultarContra_Click(sender As Object, e As EventArgs) Handles btnOcultarContra.Click
        btnOcultarContra.Visible = False
        btnMostrarContra.Visible = True
        txtContrasena.PasswordChar = "●"
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip1.SetToolTip(txtUsuario, "Introduzca el Nombre de Usuario")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        ToolTip1.SetToolTip(txtContrasena, "Introduzca su Contraseña")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblOlvideContra.LinkClicked
        recuperar.Show()

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub
End Class