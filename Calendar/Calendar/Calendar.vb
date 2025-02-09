Public Class Calendar

    Private path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Calendar\"

    Private Sub Calendar_FormClosing() Handles Me.FormClosing
        If WindowState <> FormWindowState.Minimized Then My.Settings.Location = Location
    End Sub

    Private B As Boolean

    Private Sub Calendar_Load() Handles Me.Load
        If My.Settings.Location.IsEmpty Then CenterToScreen() Else Location = My.Settings.Location

        If Not IO.Directory.Exists(path) Then IO.Directory.CreateDirectory(path)

        Try
            RTB.LoadFile(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf")
        Catch ex As Exception
        End Try

        Dim L As New List(Of Date)

        For Each file In New IO.DirectoryInfo(path).GetFiles()
            L.Add(Date.FromOADate(CDbl(IO.Path.GetFileNameWithoutExtension(file.Name))).Date)
        Next

        L.Sort()

        For Each element As String In L
            ComboBox.Items.Add(element)
        Next

        ComboBox.SelectedItem = Date.FromOADate(CDbl(IO.Path.GetFileNameWithoutExtension(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf")))

        SaveNoteButton.Enabled = False
        B = True
    End Sub

    Private Sub MonthCalendar_DateChanged() Handles MonthCalendar.DateChanged
        ComboBox.SelectedIndex = -1
        Try
            RTB.LoadFile(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf")
            ComboBox.SelectedItem = Date.FromOADate(CDbl(IO.Path.GetFileNameWithoutExtension(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf")))
        Catch ex As Exception
            RTB.Clear()
        End Try

        SaveNoteButton.UseVisualStyleBackColor = True
        SaveNoteButton.Enabled = False
        SaveNoteButton.Text = "Save Note"
    End Sub

    Private Sub RTBContextMenuStrip_Opening() Handles RTBContextMenuStrip.Opening
        If MonthCalendar.SelectionRange.Start <> Today And RTB.Text = String.Empty Then DeleteNoteToolStripMenuItem.Enabled = True Else DeleteNoteToolStripMenuItem.Enabled = False

        UndoToolStripMenuItem.Enabled = RTB.CanUndo
        RedoToolStripMenuItem.Enabled = RTB.CanRedo
        CutToolStripMenuItem.Enabled = RTB.SelectionLength > 0
        CopyToolStripMenuItem.Enabled = RTB.SelectionLength > 0
        PasteToolStripMenuItem.Enabled = Clipboard.ContainsText() OrElse Clipboard.ContainsImage()
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

    Private Sub ForeColorToolStripMenuItem_Click() Handles ForeColorToolStripMenuItem.Click
        ColorDialog.Color = RTB.SelectionColor
        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then RTB.SelectionColor = ColorDialog.Color
    End Sub

    Private Sub SaveNoteButton_Click() Handles SaveNoteButton.Click
        RTB.SaveFile(path & MonthCalendar.SelectionStart.Date.ToOADate & ".rtf")
        ComboBox.SelectedIndex = ComboBox.Items.Add(Date.FromOADate(CDbl(IO.Path.GetFileNameWithoutExtension(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf"))))

        SaveNoteButton.Enabled = False
        SaveNoteButton.Text = "Note Saved"
    End Sub

    Private Sub RTB_KeyDown(sender As Object, e As KeyEventArgs) Handles RTB.KeyDown
        If e.KeyData = Keys.Control + Keys.S Then SaveNoteButton.PerformClick()
        If e.KeyData = Keys.Control + Keys.B Then
            If RTB.SelectionFont.Bold Then
                If RTB.SelectionFont.Underline Then
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Underline)
                Else
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Regular)
                End If
            Else
                If RTB.SelectionFont.Underline Then
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Underline Or FontStyle.Bold)
                Else
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Bold)
                End If
            End If
        End If
        If e.KeyData = Keys.Control + Keys.U Then
            If RTB.SelectionFont.Underline Then
                If RTB.SelectionFont.Bold Then
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Bold)
                Else
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Regular)
                End If
            Else
                If RTB.SelectionFont.Bold Then
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Bold Or FontStyle.Underline)
                Else
                    RTB.SelectionFont = New Font(RTB.Font.FontFamily, RTB.Font.Size, FontStyle.Underline)
                End If
            End If
        End If
    End Sub

    Private Sub RTB_LostFocus() Handles RTB.LostFocus
        If RTB.Text <> Nothing Then RTB.SaveFile(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf")
    End Sub

    Private Sub RTB_TextChanged() Handles RTB.TextChanged
        SaveNoteButton.UseVisualStyleBackColor = True
        SaveNoteButton.Enabled = True
        SaveNoteButton.Text = "Save Note"
    End Sub

    Private Sub ComboBox_SelectedIndexChanged() Handles ComboBox.SelectedIndexChanged
        If B AndAlso ComboBox.SelectedIndex <> -1 Then MonthCalendar.SetDate(Date.Parse(ComboBox.Text))
    End Sub

    Private Sub DeleteNoteToolStripMenuItem_Click() Handles DeleteNoteToolStripMenuItem.Click
        If MessageBox.Show("Do you want to delete the Note for " & MonthCalendar.SelectionRange.Start.Date & "?", "Delete Note", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ComboBox.Items.Remove(ComboBox.SelectedItem)
            IO.File.Delete(path & MonthCalendar.SelectionStart.Date.ToOADate() & ".rtf")
            MonthCalendar.SetDate(Today)
        End If
    End Sub
End Class
