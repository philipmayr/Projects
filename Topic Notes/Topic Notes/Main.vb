Public Class Main

    Private Path As String

    Private Sub NewTopicButton_Click() Handles NewTopicButton.Click
        TopicDialog.TextBox.Text = String.Empty
        If TopicDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim TopicTitle = TopicDialog.TextBox.Text
            If TopicTitle <> String.Empty Then
                For Each Character In IO.Path.GetInvalidFileNameChars
                    If TopicTitle.Contains(Character) Then
                        MessageBox.Show("Invalid character(s)", "Topic Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Topic Notes")
                Path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Topic Notes\" & TopicTitle & ".rtf"
                Dim RTB = New RichTextBox
                RTB.Font = New Font("Segoe UI", 9.75)
                RTB.SaveFile(Path, RichTextBoxStreamType.RichText)
                RichTextBox.LoadFile(Path, RichTextBoxStreamType.RichText)
                RichTextBox.Enabled = True
                RichTextBox.Focus()
                ComboBox.Items.Add(TopicTitle)
                ComboBox.Text = TopicTitle
                EditTopicTitleButton.Enabled = True
                DeleteTopicButton.Enabled = True
                SaveTopicButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub EditTopicTitleButton_Click() Handles EditTopicTitleButton.Click
        TopicDialog.TextBox.Text = ComboBox.Text
        If TopicDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim TopicTitle = TopicDialog.TextBox.Text
            If TopicTitle <> String.Empty AndAlso TopicTitle <> ComboBox.Text Then
                For Each Character In IO.Path.GetInvalidFileNameChars
                    If TopicTitle.Contains(Character) Then
                        MessageBox.Show("Invalid character(s)", "Topic Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                My.Computer.FileSystem.RenameFile(Path, TopicTitle & ".rtf")
                Path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Topic Notes\" & TopicTitle & ".rtf"
                ComboBox.Items.Remove(ComboBox.Text)
                ComboBox.Items.Add(TopicTitle)
                ComboBox.Text = TopicTitle
            End If
        End If
    End Sub

    Private Sub DeleteTopicButton_Click() Handles DeleteTopicButton.Click
        If MessageBox.Show("Are you sure you want to delete the topic?", "Topic Notes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(Path)
            ComboBox.Items.Remove(ComboBox.Text)
            If ComboBox.Items.Count = 0 Then ComboBox.Enabled = False Else ComboBox.Focus()
            RichTextBox.Clear()
            RichTextBox.Enabled = False
            SaveTopicButton.Enabled = False
            DeleteTopicButton.Enabled = False
            EditTopicTitleButton.Enabled = False
        End If
    End Sub

    Private Sub Main_FormClosing() Handles Me.FormClosing
        If Not (WindowState = FormWindowState.Minimized OrElse WindowState = FormWindowState.Maximized) Then
            My.Settings.Location = Location
            My.Settings.Size = Size
        End If
    End Sub

    Private Sub Main_Load() Handles MyBase.Load
        If My.Settings.Location.IsEmpty Then CenterToScreen() Else Location = My.Settings.Location
        Size = My.Settings.Size

        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Topic Notes") Then
            For Each File In New IO.DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Topic Notes").GetFiles()
                ComboBox.Items.Add(File.ToString.Replace(File.Extension, ""))
            Next
            ComboBox.Text = My.Settings.LastTopic
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged() Handles ComboBox.SelectedIndexChanged
        Path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Topic Notes\" & ComboBox.Text & ".rtf"
        My.Settings.LastTopic = ComboBox.Text
        My.Settings.Save()
        RichTextBox.LoadFile(path, RichTextBoxStreamType.RichText)
        RichTextBox.Enabled = True
        RichTextBox.Focus()
        SaveTopicButton.Enabled = True
        EditTopicTitleButton.Enabled = True
        DeleteTopicButton.Enabled = True
    End Sub

    Private Sub SaveTopicButton_Click() Handles SaveTopicButton.Click
        RichTextBox.SaveFile(Path, RichTextBoxStreamType.RichText)
        RichTextBox.Focus()
    End Sub

    Private Sub RichTextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox.KeyDown
        If e.KeyData = Keys.Control + Keys.B Then
            If RichTextBox.SelectionFont.Bold Then
                If RichTextBox.SelectionFont.Underline Then
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Underline)
                Else
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Regular)
                End If
            Else
                If RichTextBox.SelectionFont.Underline Then
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Underline Or FontStyle.Bold)
                Else
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Bold)
                End If
            End If
        End If
            If e.KeyData = Keys.Control + Keys.U Then
            If RichTextBox.SelectionFont.Underline Then
                If RichTextBox.SelectionFont.Bold Then
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Bold)
                Else
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Regular)
                End If
            Else
                If RichTextBox.SelectionFont.Bold Then
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Bold Or FontStyle.Underline)
                Else
                    RichTextBox.SelectionFont = New Font(RichTextBox.Font.FontFamily, RichTextBox.Font.Size, FontStyle.Underline)
                End If
            End If
            End If
    End Sub

    Private Sub RichTextBox_LostFocus() Handles RichTextBox.LostFocus
        RichTextBox.SaveFile(Path, RichTextBoxStreamType.RichText)
    End Sub

    Private Sub RichTextBoxContextMenuStrip_Opening() Handles RichTextBoxContextMenuStrip.Opening
        UndoToolStripMenuItem.Enabled = RichTextBox.CanUndo
        RedoToolStripMenuItem.Enabled = RichTextBox.CanRedo
        CutToolStripMenuItem.Enabled = RichTextBox.SelectionLength > 0
        CopyToolStripMenuItem.Enabled = RichTextBox.SelectionLength > 0
        PasteToolStripMenuItem.Enabled = Clipboard.ContainsText OrElse Clipboard.ContainsImage
        DeleteToolStripMenuItem.Enabled = RichTextBox.SelectionLength > 0
        SelectAllToolStripMenuItem.Enabled = RichTextBox.TextLength > 0

        RichTextBox.Focus()
    End Sub

    Private Sub UndoToolStripMenuItem_Click() Handles UndoToolStripMenuItem.Click
        RichTextBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click() Handles RedoToolStripMenuItem.Click
        RichTextBox.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click() Handles CutToolStripMenuItem.Click
        RichTextBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click() Handles CopyToolStripMenuItem.Click
        RichTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click() Handles PasteToolStripMenuItem.Click
        RichTextBox.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click() Handles DeleteToolStripMenuItem.Click
        RichTextBox.SelectedText = String.Empty
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click() Handles SelectAllToolStripMenuItem.Click
        RichTextBox.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click() Handles FontToolStripMenuItem.Click
        FontDialog.Font = RichTextBox.SelectionFont
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox.SelectionFont = FontDialog.Font
    End Sub

    Private Sub ForeColorToolStripMenuItem_Click() Handles ForecolorToolStripMenuItem.Click
        ColorDialog.Color = RichTextBox.SelectionColor
        If ColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox.SelectionColor = ColorDialog.Color
    End Sub
End Class
