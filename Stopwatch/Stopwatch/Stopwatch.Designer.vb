<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stopwatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stopwatch))
        Me.StopwatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.SecondsLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.StopwatchGroupBox = New System.Windows.Forms.GroupBox()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.HLabel = New System.Windows.Forms.Label()
        Me.MLabel = New System.Windows.Forms.Label()
        Me.SLabel = New System.Windows.Forms.Label()
        Me.BlinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StopwatchGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StopwatchTimer
        '
        Me.StopwatchTimer.Interval = 1000
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
        'ResetButton
        '
        Me.ResetButton.Enabled = False
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(137, 66)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(125, 23)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "Reset"
        Me.ToolTip.SetToolTip(Me.ResetButton, "Reset Stopwatch")
        Me.ResetButton.UseVisualStyleBackColor = True
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
        'StopwatchGroupBox
        '
        Me.StopwatchGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.StopwatchGroupBox.Controls.Add(Me.StartStopButton)
        Me.StopwatchGroupBox.Controls.Add(Me.HLabel)
        Me.StopwatchGroupBox.Controls.Add(Me.MLabel)
        Me.StopwatchGroupBox.Controls.Add(Me.SLabel)
        Me.StopwatchGroupBox.Controls.Add(Me.HoursLabel)
        Me.StopwatchGroupBox.Controls.Add(Me.ResetButton)
        Me.StopwatchGroupBox.Controls.Add(Me.SecondsLabel)
        Me.StopwatchGroupBox.Controls.Add(Me.MinutesLabel)
        Me.StopwatchGroupBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopwatchGroupBox.ForeColor = System.Drawing.Color.Black
        Me.StopwatchGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.StopwatchGroupBox.Name = "StopwatchGroupBox"
        Me.StopwatchGroupBox.Size = New System.Drawing.Size(268, 95)
        Me.StopwatchGroupBox.TabIndex = 0
        Me.StopwatchGroupBox.TabStop = False
        Me.StopwatchGroupBox.Text = "Stopwatch"
        '
        'StartStopButton
        '
        Me.StartStopButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartStopButton.ForeColor = System.Drawing.Color.Black
        Me.StartStopButton.Location = New System.Drawing.Point(6, 66)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(125, 23)
        Me.StartStopButton.TabIndex = 0
        Me.StartStopButton.Text = "Start / Stop"
        Me.ToolTip.SetToolTip(Me.StartStopButton, "Start / Stop Stopwatch")
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'HLabel
        '
        Me.HLabel.AutoSize = True
        Me.HLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLabel.ForeColor = System.Drawing.Color.Black
        Me.HLabel.Location = New System.Drawing.Point(66, 18)
        Me.HLabel.Name = "HLabel"
        Me.HLabel.Size = New System.Drawing.Size(21, 21)
        Me.HLabel.TabIndex = 0
        Me.HLabel.Text = "H"
        '
        'MLabel
        '
        Me.MLabel.AutoSize = True
        Me.MLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabel.ForeColor = System.Drawing.Color.Black
        Me.MLabel.Location = New System.Drawing.Point(153, 18)
        Me.MLabel.Name = "MLabel"
        Me.MLabel.Size = New System.Drawing.Size(24, 21)
        Me.MLabel.TabIndex = 0
        Me.MLabel.Text = "M"
        '
        'SLabel
        '
        Me.SLabel.AutoSize = True
        Me.SLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel.ForeColor = System.Drawing.Color.Black
        Me.SLabel.Location = New System.Drawing.Point(243, 18)
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(19, 21)
        Me.SLabel.TabIndex = 0
        Me.SLabel.Text = "S"
        '
        'BlinkTimer
        '
        Me.BlinkTimer.Interval = 500
        '
        'Stopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 119)
        Me.Controls.Add(Me.StopwatchGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Stopwatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stopwatch"
        Me.StopwatchGroupBox.ResumeLayout(False)
        Me.StopwatchGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StopwatchTimer As System.Windows.Forms.Timer
    Friend WithEvents MinutesLabel As System.Windows.Forms.Label
    Friend WithEvents SecondsLabel As System.Windows.Forms.Label
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents HoursLabel As System.Windows.Forms.Label
    Friend WithEvents StopwatchGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BlinkTimer As System.Windows.Forms.Timer
    Friend WithEvents HLabel As System.Windows.Forms.Label
    Friend WithEvents MLabel As System.Windows.Forms.Label
    Friend WithEvents SLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StartStopButton As System.Windows.Forms.Button

End Class
