<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.RichTextBoxContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForecolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewTopicButton = New System.Windows.Forms.Button()
        Me.SaveTopicButton = New System.Windows.Forms.Button()
        Me.EditTopicTitleButton = New System.Windows.Forms.Button()
        Me.DeleteTopicButton = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.RichTextBoxContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxContextMenuStrip
        '
        Me.RichTextBoxContextMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBoxContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator3, Me.FontToolStripMenuItem, Me.ForecolorToolStripMenuItem})
        Me.RichTextBoxContextMenuStrip.Name = "ContextMenuStrip1"
        Me.RichTextBoxContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.RichTextBoxContextMenuStrip.ShowImageMargin = False
        Me.RichTextBoxContextMenuStrip.Size = New System.Drawing.Size(114, 220)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(110, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(110, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.FontToolStripMenuItem.Text = "Font..."
        '
        'ForecolorToolStripMenuItem
        '
        Me.ForecolorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForecolorToolStripMenuItem.Name = "ForecolorToolStripMenuItem"
        Me.ForecolorToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ForecolorToolStripMenuItem.Text = "Fore Color..."
        '
        'NewTopicButton
        '
        Me.NewTopicButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewTopicButton.AutoSize = True
        Me.NewTopicButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTopicButton.Location = New System.Drawing.Point(297, 12)
        Me.NewTopicButton.Name = "NewTopicButton"
        Me.NewTopicButton.Size = New System.Drawing.Size(91, 23)
        Me.NewTopicButton.TabIndex = 9
        Me.NewTopicButton.Text = "New Topic"
        Me.ToolTip.SetToolTip(Me.NewTopicButton, "New Topic")
        Me.NewTopicButton.UseVisualStyleBackColor = True
        '
        'SaveTopicButton
        '
        Me.SaveTopicButton.AutoSize = True
        Me.SaveTopicButton.Enabled = False
        Me.SaveTopicButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTopicButton.Location = New System.Drawing.Point(12, 12)
        Me.SaveTopicButton.Name = "SaveTopicButton"
        Me.SaveTopicButton.Size = New System.Drawing.Size(91, 23)
        Me.SaveTopicButton.TabIndex = 7
        Me.SaveTopicButton.Text = "Save Topic"
        Me.ToolTip.SetToolTip(Me.SaveTopicButton, "Save Topic")
        Me.SaveTopicButton.UseVisualStyleBackColor = True
        '
        'EditTopicTitleButton
        '
        Me.EditTopicTitleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditTopicTitleButton.AutoSize = True
        Me.EditTopicTitleButton.Enabled = False
        Me.EditTopicTitleButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditTopicTitleButton.Location = New System.Drawing.Point(394, 12)
        Me.EditTopicTitleButton.Name = "EditTopicTitleButton"
        Me.EditTopicTitleButton.Size = New System.Drawing.Size(91, 23)
        Me.EditTopicTitleButton.TabIndex = 10
        Me.EditTopicTitleButton.Text = "Edit Topic Title"
        Me.ToolTip.SetToolTip(Me.EditTopicTitleButton, "Edit Topic Title")
        Me.EditTopicTitleButton.UseVisualStyleBackColor = True
        '
        'DeleteTopicButton
        '
        Me.DeleteTopicButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteTopicButton.AutoSize = True
        Me.DeleteTopicButton.Enabled = False
        Me.DeleteTopicButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteTopicButton.Location = New System.Drawing.Point(491, 12)
        Me.DeleteTopicButton.Name = "DeleteTopicButton"
        Me.DeleteTopicButton.Size = New System.Drawing.Size(91, 23)
        Me.DeleteTopicButton.TabIndex = 11
        Me.DeleteTopicButton.Text = "Delete Topic"
        Me.ToolTip.SetToolTip(Me.DeleteTopicButton, "Delete Topic")
        Me.DeleteTopicButton.UseVisualStyleBackColor = True
        '
        'FontDialog
        '
        Me.FontDialog.Color = System.Drawing.SystemColors.ControlText
        Me.FontDialog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RichTextBox
        '
        Me.RichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox.ContextMenuStrip = Me.RichTextBoxContextMenuStrip
        Me.RichTextBox.Enabled = False
        Me.RichTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.Location = New System.Drawing.Point(12, 41)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox.Size = New System.Drawing.Size(570, 321)
        Me.RichTextBox.TabIndex = 6
        Me.RichTextBox.Text = ""
        '
        'ComboBox
        '
        Me.ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox.Location = New System.Drawing.Point(109, 14)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox.Sorted = True
        Me.ComboBox.TabIndex = 8
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(594, 374)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.NewTopicButton)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.SaveTopicButton)
        Me.Controls.Add(Me.EditTopicTitleButton)
        Me.Controls.Add(Me.DeleteTopicButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(610, 210)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Topic Notes"
        Me.RichTextBoxContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents RichTextBoxContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForecolorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NewTopicButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveTopicButton As System.Windows.Forms.Button
    Friend WithEvents EditTopicTitleButton As System.Windows.Forms.Button
    Friend WithEvents DeleteTopicButton As System.Windows.Forms.Button

End Class
