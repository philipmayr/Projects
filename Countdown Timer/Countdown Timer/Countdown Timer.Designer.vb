<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountdownTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountdownTimer))
        Me.BlinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SLabel = New System.Windows.Forms.Label()
        Me.HoursNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CountdownTimerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BeepTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.SecondsLabel = New System.Windows.Forms.Label()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.BlinkingSLabel = New System.Windows.Forms.Label()
        Me.BlinkingMLabel = New System.Windows.Forms.Label()
        Me.MinutesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SecondsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BlinkingHLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.MLabel = New System.Windows.Forms.Label()
        Me.HLabel = New System.Windows.Forms.Label()
        Me.TimerGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.HoursNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlinkTimer
        '
        Me.BlinkTimer.Interval = 500
        '
        'SLabel
        '
        Me.SLabel.AutoSize = True
        Me.SLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel.ForeColor = System.Drawing.Color.Black
        Me.SLabel.Location = New System.Drawing.Point(243, 68)
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(13, 13)
        Me.SLabel.TabIndex = 0
        Me.SLabel.Text = "S"
        '
        'HoursNumericUpDown
        '
        Me.HoursNumericUpDown.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursNumericUpDown.Location = New System.Drawing.Point(14, 66)
        Me.HoursNumericUpDown.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoursNumericUpDown.Name = "HoursNumericUpDown"
        Me.HoursNumericUpDown.Size = New System.Drawing.Size(46, 22)
        Me.HoursNumericUpDown.TabIndex = 0
        '
        'CountdownTimerTimer
        '
        Me.CountdownTimerTimer.Interval = 1000
        '
        'BeepTimer
        '
        Me.BeepTimer.Interval = 500
        '
        'MinutesLabel
        '
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesLabel.ForeColor = System.Drawing.Color.Black
        Me.MinutesLabel.Location = New System.Drawing.Point(93, 18)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(54, 45)
        Me.MinutesLabel.TabIndex = 0
        Me.MinutesLabel.Text = "00"
        '
        'SecondsLabel
        '
        Me.SecondsLabel.AutoSize = True
        Me.SecondsLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsLabel.ForeColor = System.Drawing.Color.Black
        Me.SecondsLabel.Location = New System.Drawing.Point(183, 18)
        Me.SecondsLabel.Name = "SecondsLabel"
        Me.SecondsLabel.Size = New System.Drawing.Size(54, 45)
        Me.SecondsLabel.TabIndex = 0
        Me.SecondsLabel.Text = "00"
        '
        'HoursLabel
        '
        Me.HoursLabel.AutoSize = True
        Me.HoursLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursLabel.ForeColor = System.Drawing.Color.Black
        Me.HoursLabel.Location = New System.Drawing.Point(6, 18)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(54, 45)
        Me.HoursLabel.TabIndex = 0
        Me.HoursLabel.Text = "00"
        '
        'BlinkingSLabel
        '
        Me.BlinkingSLabel.AutoSize = True
        Me.BlinkingSLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlinkingSLabel.ForeColor = System.Drawing.Color.Black
        Me.BlinkingSLabel.Location = New System.Drawing.Point(243, 18)
        Me.BlinkingSLabel.Name = "BlinkingSLabel"
        Me.BlinkingSLabel.Size = New System.Drawing.Size(19, 21)
        Me.BlinkingSLabel.TabIndex = 0
        Me.BlinkingSLabel.Text = "S"
        '
        'BlinkingMLabel
        '
        Me.BlinkingMLabel.AutoSize = True
        Me.BlinkingMLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlinkingMLabel.ForeColor = System.Drawing.Color.Black
        Me.BlinkingMLabel.Location = New System.Drawing.Point(153, 18)
        Me.BlinkingMLabel.Name = "BlinkingMLabel"
        Me.BlinkingMLabel.Size = New System.Drawing.Size(24, 21)
        Me.BlinkingMLabel.TabIndex = 0
        Me.BlinkingMLabel.Text = "M"
        '
        'MinutesNumericUpDown
        '
        Me.MinutesNumericUpDown.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesNumericUpDown.Location = New System.Drawing.Point(101, 66)
        Me.MinutesNumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutesNumericUpDown.Name = "MinutesNumericUpDown"
        Me.MinutesNumericUpDown.Size = New System.Drawing.Size(46, 22)
        Me.MinutesNumericUpDown.TabIndex = 0
        '
        'SecondsNumericUpDown
        '
        Me.SecondsNumericUpDown.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsNumericUpDown.Location = New System.Drawing.Point(191, 66)
        Me.SecondsNumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.SecondsNumericUpDown.Name = "SecondsNumericUpDown"
        Me.SecondsNumericUpDown.Size = New System.Drawing.Size(46, 22)
        Me.SecondsNumericUpDown.TabIndex = 0
        '
        'BlinkingHLabel
        '
        Me.BlinkingHLabel.AutoSize = True
        Me.BlinkingHLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlinkingHLabel.ForeColor = System.Drawing.Color.Black
        Me.BlinkingHLabel.Location = New System.Drawing.Point(66, 18)
        Me.BlinkingHLabel.Name = "BlinkingHLabel"
        Me.BlinkingHLabel.Size = New System.Drawing.Size(21, 21)
        Me.BlinkingHLabel.TabIndex = 0
        Me.BlinkingHLabel.Text = "H"
        '
        'ResetButton
        '
        Me.ResetButton.Enabled = False
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(137, 94)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(125, 23)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "Reset"
        Me.ToolTip.SetToolTip(Me.ResetButton, "Reset Countdown")
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'StartStopButton
        '
        Me.StartStopButton.Enabled = False
        Me.StartStopButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartStopButton.ForeColor = System.Drawing.Color.Black
        Me.StartStopButton.Location = New System.Drawing.Point(6, 94)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(125, 23)
        Me.StartStopButton.TabIndex = 0
        Me.StartStopButton.Text = "Start / Stop"
        Me.ToolTip.SetToolTip(Me.StartStopButton, "Start / Stop Countdown")
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'MLabel
        '
        Me.MLabel.AutoSize = True
        Me.MLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabel.ForeColor = System.Drawing.Color.Black
        Me.MLabel.Location = New System.Drawing.Point(153, 68)
        Me.MLabel.Name = "MLabel"
        Me.MLabel.Size = New System.Drawing.Size(17, 13)
        Me.MLabel.TabIndex = 0
        Me.MLabel.Text = "M"
        '
        'HLabel
        '
        Me.HLabel.AutoSize = True
        Me.HLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLabel.ForeColor = System.Drawing.Color.Black
        Me.HLabel.Location = New System.Drawing.Point(66, 68)
        Me.HLabel.Name = "HLabel"
        Me.HLabel.Size = New System.Drawing.Size(15, 13)
        Me.HLabel.TabIndex = 0
        Me.HLabel.Text = "H"
        '
        'TimerGroupBox
        '
        Me.TimerGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.TimerGroupBox.Controls.Add(Me.HLabel)
        Me.TimerGroupBox.Controls.Add(Me.MLabel)
        Me.TimerGroupBox.Controls.Add(Me.SLabel)
        Me.TimerGroupBox.Controls.Add(Me.SecondsNumericUpDown)
        Me.TimerGroupBox.Controls.Add(Me.MinutesNumericUpDown)
        Me.TimerGroupBox.Controls.Add(Me.HoursNumericUpDown)
        Me.TimerGroupBox.Controls.Add(Me.StartStopButton)
        Me.TimerGroupBox.Controls.Add(Me.ResetButton)
        Me.TimerGroupBox.Controls.Add(Me.BlinkingHLabel)
        Me.TimerGroupBox.Controls.Add(Me.BlinkingMLabel)
        Me.TimerGroupBox.Controls.Add(Me.BlinkingSLabel)
        Me.TimerGroupBox.Controls.Add(Me.HoursLabel)
        Me.TimerGroupBox.Controls.Add(Me.SecondsLabel)
        Me.TimerGroupBox.Controls.Add(Me.MinutesLabel)
        Me.TimerGroupBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerGroupBox.ForeColor = System.Drawing.Color.Black
        Me.TimerGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.TimerGroupBox.Name = "TimerGroupBox"
        Me.TimerGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimerGroupBox.Size = New System.Drawing.Size(268, 126)
        Me.TimerGroupBox.TabIndex = 0
        Me.TimerGroupBox.TabStop = False
        Me.TimerGroupBox.Text = "Countdown Timer"
        '
        'CountdownTimer
        '
        Me.AcceptButton = Me.StartStopButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 150)
        Me.Controls.Add(Me.TimerGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CountdownTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Countdown Timer"
        CType(Me.HoursNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimerGroupBox.ResumeLayout(False)
        Me.TimerGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlinkTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CountdownTimerTimer As System.Windows.Forms.Timer
    Friend WithEvents HoursNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SLabel As System.Windows.Forms.Label
    Friend WithEvents BeepTimer As System.Windows.Forms.Timer
    Friend WithEvents MinutesLabel As System.Windows.Forms.Label
    Friend WithEvents SecondsLabel As System.Windows.Forms.Label
    Friend WithEvents HoursLabel As System.Windows.Forms.Label
    Friend WithEvents BlinkingSLabel As System.Windows.Forms.Label
    Friend WithEvents BlinkingMLabel As System.Windows.Forms.Label
    Friend WithEvents MinutesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SecondsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BlinkingHLabel As System.Windows.Forms.Label
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents StartStopButton As System.Windows.Forms.Button
    Friend WithEvents MLabel As System.Windows.Forms.Label
    Friend WithEvents HLabel As System.Windows.Forms.Label
    Friend WithEvents TimerGroupBox As System.Windows.Forms.GroupBox

End Class
