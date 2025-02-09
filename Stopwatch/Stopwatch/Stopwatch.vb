Public Class Stopwatch

    Private Seconds, Minutes, Hours As Integer

    Private Sub StartStop() Handles StartStopButton.Click
        If StopwatchTimer.Enabled Then
            StopwatchTimer.Stop()
            BlinkTimer.Stop()
        Else
            StopwatchTimer.Start()
            BlinkTimer.Start()
            ResetButton.Enabled = True
        End If
    End Sub

    Private Sub Reset() Handles ResetButton.Click
        StopwatchTimer.Stop()
        BlinkTimer.Stop()
        Seconds = 0
        Minutes = 0
        Hours = 0
        SecondsLabel.Text = "00"
        MinutesLabel.Text = "00"
        HoursLabel.Text = "00"
        StartStopButton.Enabled = True
        ResetButton.Enabled = False
    End Sub

    Private Sub StopwatchTimer_Tick() Handles StopwatchTimer.Tick
        If Seconds = 59 Then
            Seconds = 0
            Minutes += 1
            SecondsLabel.Text = "00"
            If Minutes = 60 Then
                Minutes = 0
                Hours += 1
                MinutesLabel.Text = "00"
                If Hours = 24 Then Reset() Else HoursLabel.Text = If(Hours < 10, "0" & Hours, CStr(Hours))
            Else
                MinutesLabel.Text = If(Minutes < 10, "0" & Minutes, CStr(Minutes))
            End If
        Else
            Seconds += 1
            SecondsLabel.Text = If(Seconds < 10, "0" & Seconds, CStr(Seconds))
        End If
    End Sub

    Private Sub BlinkTimer_Tick() Handles BlinkTimer.Tick
        SLabel.Visible = SLabel.Visible = False
        MLabel.Visible = MLabel.Visible = False
        HLabel.Visible = HLabel.Visible = False
    End Sub

    Private Sub Stopwatch_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(ClientRectangle, SystemColors.ActiveCaption, Color.Black, Drawing2D.LinearGradientMode.Vertical), ClientRectangle)
    End Sub
End Class
