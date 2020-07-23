Public Class ChargeScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
        Else
            Timer1.Enabled = False
            Me.Hide()
            Main.Show()
        End If
    End Sub

End Class