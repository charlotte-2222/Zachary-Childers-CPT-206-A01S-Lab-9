Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgSplah.Increment(1)
        If prgSplah.Value = 110 Then ' <-Timer'
            Me.Hide()
            MainForm.Show()
        End If
        date_time.Text = DateTime.Now.ToString("M/d/yyyy h:mm:stt") ' <-- Date
    End Sub
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class