<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopicDialog
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
        Me.Label = New System.Windows.Forms.Label()
        Me.DialogOKButton = New System.Windows.Forms.Button()
        Me.DialogCancelButton = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(12, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(143, 21)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Enter the topic title:"
        '
        'DialogOKButton
        '
        Me.DialogOKButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogOKButton.Location = New System.Drawing.Point(197, 12)
        Me.DialogOKButton.Name = "DialogOKButton"
        Me.DialogOKButton.Size = New System.Drawing.Size(75, 23)
        Me.DialogOKButton.TabIndex = 1
        Me.DialogOKButton.Text = "OK"
        Me.DialogOKButton.UseVisualStyleBackColor = True
        '
        'DialogCancelButton
        '
        Me.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DialogCancelButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogCancelButton.Location = New System.Drawing.Point(197, 41)
        Me.DialogCancelButton.Name = "DialogCancelButton"
        Me.DialogCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.DialogCancelButton.TabIndex = 2
        Me.DialogCancelButton.Text = "Cancel"
        Me.DialogCancelButton.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.Location = New System.Drawing.Point(16, 70)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(256, 22)
        Me.TextBox.TabIndex = 0
        '
        'TopicDialog
        '
        Me.AcceptButton = Me.DialogOKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.DialogCancelButton
        Me.ClientSize = New System.Drawing.Size(284, 104)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.DialogCancelButton)
        Me.Controls.Add(Me.DialogOKButton)
        Me.Controls.Add(Me.Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TopicDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Topic Notes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents DialogOKButton As System.Windows.Forms.Button
    Friend WithEvents DialogCancelButton As System.Windows.Forms.Button
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
End Class
