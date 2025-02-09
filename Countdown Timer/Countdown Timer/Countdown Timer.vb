Public Class CountdownTimer

    Private Stopped As Boolean, Seconds, Minutes, Hours As Integer

    Private Sub StartStop() Handles StartStopButton.Click
        If CountdownTimerTimer.Enabled Then
            CountdownTimerTimer.Stop()
            BlinkTimer.Stop()
            Stopped = True
        Else
            If Stopped Then
                CountdownTimerTimer.Start()
                BlinkTimer.Start()
                ResetButton.Enabled = True
            Else
                Seconds = CInt(SecondsNumericUpDown.Value)
                Minutes = CInt(MinutesNumericUpDown.Value)
                Hours = CInt(HoursNumericUpDown.Value)
                SecondsLabel.Text = If(Seconds < 10, "0" & Seconds, CStr(Seconds))
                MinutesLabel.Text = If(Minutes < 10, "0" & Minutes, CStr(Minutes))
                HoursLabel.Text = If(Hours < 10, "0" & Hours, CStr(Hours))
                SecondsNumericUpDown.Enabled = False
                MinutesNumericUpDown.Enabled = False
                HoursNumericUpDown.Enabled = False
                CountdownTimerTimer.Start()
                BlinkTimer.Start()
                ResetButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub Reset() Handles ResetButton.Click
        CountdownTimerTimer.Stop()
        BlinkTimer.Stop()
        Seconds = 0
        Minutes = 0
        Hours = 0
        Stopped = False
        SecondsLabel.Text = "00"
        MinutesLabel.Text = "00"
        HoursLabel.Text = "00"
        SecondsNumericUpDown.Value = 0
        MinutesNumericUpDown.Value = 0
        HoursNumericUpDown.Value = 0
        BlinkingSLabel.Visible = True
        BlinkingMLabel.Visible = True
        BlinkingHLabel.Visible = True
        SecondsNumericUpDown.Enabled = True
        MinutesNumericUpDown.Enabled = True
        HoursNumericUpDown.Enabled = True
        ResetButton.Enabled = False
    End Sub

    Private Sub CountdownTimerTimer_Tick() Handles CountdownTimerTimer.Tick
        If Hours = 0 AndAlso Minutes = 0 AndAlso Seconds = 0 Then
            WindowState = FormWindowState.Normal
            CountdownTimerTimer.Stop()
            BlinkTimer.Stop()
            Stopped = False
            BlinkingSLabel.Visible = True
            BlinkingMLabel.Visible = True
            BlinkingHLabel.Visible = True
            BeepTimer.Start()
            MessageBox.Show("Countdown has ended.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            BeepTimer.Stop()
        Else
            If Seconds = 0 Then
                Seconds = 60
                Seconds -= 1
                If Minutes = 0 Then
                    Minutes = 60
                    Minutes -= 1
                    If Hours = 0 Then
                        WindowState = FormWindowState.Normal
                        CountdownTimerTimer.Stop()
                        BlinkTimer.Stop()
                        Stopped = False
                        BlinkingSLabel.Visible = True
                        BlinkingMLabel.Visible = True
                        BlinkingHLabel.Visible = True
                        BeepTimer.Start()
                        MessageBox.Show("Countdown has ended.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        BeepTimer.Stop()
                    Else
                        Hours -= 1
                    End If
                Else
                    Minutes -= 1
                End If
            Else
                Seconds -= 1
            End If
        End If
        SecondsLabel.Text = If(Seconds < 10, "0" & Seconds, CStr(Seconds))
        MinutesLabel.Text = If(Minutes < 10, "0" & Minutes, CStr(Minutes))
        HoursLabel.Text = If(Hours < 10, "0" & Hours, CStr(Hours))
    End Sub

    Private Sub BlinkTimer_Tick() Handles BlinkTimer.Tick
        BlinkingSLabel.Visible = BlinkingSLabel.Visible = False
        BlinkingMLabel.Visible = BlinkingMLabel.Visible = False
        BlinkingHLabel.Visible = BlinkingHLabel.Visible = False
    End Sub

    Private Sub BeepTimer_Tick() Handles BeepTimer.Tick
        Console.Beep()
    End Sub

    Private Sub NumericUpDown_Enter(sender As Object, e As EventArgs) Handles SecondsNumericUpDown.Enter, MinutesNumericUpDown.Enter, HoursNumericUpDown.Enter
        Dim NumericUpDown = CType(sender, NumericUpDown)
        NumericUpDown.Select(0, NumericUpDown.Value.ToString().Length)
    End Sub

    Private Sub NumericUpDown_Leave(sender As Object, e As EventArgs) Handles SecondsNumericUpDown.Leave, MinutesNumericUpDown.Leave, HoursNumericUpDown.Leave
        Dim NumericUpDown = CType(sender, NumericUpDown)
        If NumericUpDown.Text = String.Empty Then NumericUpDown.Text = "0"
    End Sub

    Private Sub NumericUpDown_TextChanged() Handles SecondsNumericUpDown.TextChanged, MinutesNumericUpDown.TextChanged, HoursNumericUpDown.TextChanged
        Seconds = If(SecondsNumericUpDown.Text = String.Empty, 0, CInt(SecondsNumericUpDown.Value))
        Minutes = If(MinutesNumericUpDown.Text = String.Empty, 0, CInt(MinutesNumericUpDown.Value))
        Hours = If(HoursNumericUpDown.Text = String.Empty, 0, CInt(HoursNumericUpDown.Value))
        StartStopButton.Enabled = Not (Seconds = 0 AndAlso Minutes = 0 AndAlso Hours = 0)
    End Sub

    Private Sub CountdownTimer_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(ClientRectangle, SystemColors.ActiveCaption, Color.Black, Drawing2D.LinearGradientMode.Vertical), ClientRectangle)
    End Sub
End Class
