Public Class Notepad

    Private Sub Notepad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (WindowState = FormWindowState.Minimized OrElse WindowState = FormWindowState.Maximized) Then
            My.Settings.Location = Location
            My.Settings.Size = Size
        End If

        If SaveBtn.Enabled Then
            Select Case MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    RTB.SaveFile(Application.LocalUserAppDataPath & "\RTF File.rtf")
                Case Windows.Forms.DialogResult.No
                    Application.ExitThread()
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub Notepad_Load() Handles Me.Load
        If My.Settings.Location.IsEmpty Then CenterToScreen() Else Location = My.Settings.Location
        Size = My.Settings.Size

        Try
            RTB.LoadFile(Application.LocalUserAppDataPath & "\RTF File.rtf")
        Catch ex As Exception
        End Try

        SaveBtn.BackColor = Color.DarkSeaGreen
        SaveBtn.Enabled = False
        SaveBtn.Text = "Saved"
    End Sub

    Private Sub SaveBtn_Click() Handles SaveBtn.Click
        RTB.SaveFile(Application.LocalUserAppDataPath & "\RTF File.rtf")

        SaveBtn.BackColor = Color.DarkSeaGreen
        SaveBtn.Enabled = False
        SaveBtn.Text = "Saved"

        RTB.Focus()
    End Sub

    Private Sub FindBtn_Click() Handles FindBtn.Click
        FindDialog.ShowDialog()
    End Sub

    Private Sub RTB_TextChanged() Handles RTB.TextChanged
        SaveBtn.UseVisualStyleBackColor = True
        SaveBtn.Enabled = True
        SaveBtn.Text = "Save"

        FindBtn.Enabled = RTB.Text <> String.Empty
    End Sub

    Private Sub RTB_KeyDown(sender As Object, e As KeyEventArgs) Handles RTB.KeyDown
        If e.KeyData = Keys.Control + Keys.S Then SaveBtn.PerformClick()
        If e.KeyData = Keys.Control + Keys.F Then FindBtn.PerformClick()
    End Sub

    Private Sub RTBContextMenuStrip_Opening() Handles RTBContextMenuStrip.Opening
        UndoToolStripMenuItem.Enabled = RTB.CanUndo
        RedoToolStripMenuItem.Enabled = RTB.CanRedo
        CutToolStripMenuItem.Enabled = RTB.SelectionLength > 0
        CopyToolStripMenuItem.Enabled = RTB.SelectionLength > 0
        PasteToolStripMenuItem.Enabled = Clipboard.ContainsText OrElse Clipboard.ContainsImage
        DeleteToolStripMenuItem.Enabled = RTB.SelectionLength > 0
        SelectAllToolStripMenuItem.Enabled = RTB.TextLength > 0

        RTB.Focus()
    End Sub

    Private Sub UndoToolStripMenuItem_Click() Handles UndoToolStripMenuItem.Click
        RTB.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click() Handles RedoToolStripMenuItem.Click
        RTB.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click() Handles CutToolStripMenuItem.Click
        RTB.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click() Handles CopyToolStripMenuItem.Click
        RTB.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click() Handles PasteToolStripMenuItem.Click
        RTB.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click() Handles DeleteToolStripMenuItem.Click
        RTB.SelectedText = String.Empty
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click() Handles SelectAllToolStripMenuItem.Click
        RTB.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click() Handles FontToolStripMenuItem.Click
        FontDialog.Font = RTB.SelectionFont
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then RTB.SelectionFont = FontDialog.Font
    End Sub

    Private Sub ForeColorToolStripMenuItem_Click() Handles ForecolorToolStripMenuItem.Click
        ColorDialog.Color = RTB.SelectionColor
        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then RTB.SelectionColor = ColorDialog.Color
    End Sub
End Class

