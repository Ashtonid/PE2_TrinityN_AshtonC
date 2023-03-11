Public Class SplashScreenvb

    Private Sub tmrProgTimer_Tick(sender As Object, e As EventArgs) Handles tmrProgTimer.Tick


        If (pbProgBar.Value = pbProgBar.Maximum - 1) Then
            pbProgBar.Value += 1
            Me.Hide()


        Else
            pbProgBar.PerformStep()
            pbPercent.Text = pbProgBar.Value & ("%")
        End If

    End Sub
    'The code below loads the splash screen and starts the timer for the progress bar.


    Private Sub SplashScreenvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tmrProgTimer.Enabled = True
    End Sub
End Class