Public Class FindDialog

    Private Start As Integer, SearchOptions As RichTextBoxFinds, LastSearchTerm As String, WholeWordChecked, MatchCaseChecked As Boolean

    Private Sub FindDialog_Shown() Handles Me.Shown
        txtSearchTerm.Text = LastSearchTerm
        chkWholeWord.Checked = WholeWordChecked
        chkMatchCase.Checked = MatchCaseChecked
        txtSearchTerm.SelectAll()
        txtSearchTerm.Focus()
    End Sub

    Private Sub Dialog_FormClosed() Handles Me.FormClosed
        Notepad.RTB.Select()
    End Sub

    Private Sub txtSearchTerm_TextChanged() Handles txtSearchTerm.TextChanged
        btnFindNext.Enabled = txtSearchTerm.Text <> String.Empty
    End Sub

    Private Sub chk_CheckedChanged() Handles chkWholeWord.CheckedChanged, chkMatchCase.CheckedChanged
        If chkWholeWord.Checked AndAlso chkMatchCase.Checked = False Then
            SearchOptions = RichTextBoxFinds.WholeWord Or RichTextBoxFinds.None
        ElseIf chkWholeWord.Checked = False AndAlso chkMatchCase.Checked Then
            SearchOptions = RichTextBoxFinds.None Or RichTextBoxFinds.MatchCase
        ElseIf chkWholeWord.Checked AndAlso chkMatchCase.Checked Then
            SearchOptions = RichTextBoxFinds.WholeWord Or RichTextBoxFinds.MatchCase
        ElseIf chkWholeWord.Checked = False AndAlso chkMatchCase.Checked = False Then
            SearchOptions = RichTextBoxFinds.None Or RichTextBoxFinds.None
        End If
    End Sub

    Private Sub btnFindNext_Click() Handles btnFindNext.Click
        Start = Notepad.RTB.Find(txtSearchTerm.Text, Start, SearchOptions)
        If Start = -1 Then
            MessageBox.Show("Search term not found.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Start = 0
        Else
            Start += 1
        End If
        LastSearchTerm = txtSearchTerm.Text
        WholeWordChecked = chkWholeWord.Checked
        MatchCaseChecked = chkMatchCase.Checked
    End Sub

    Private Sub btnCancelButon_Click() Handles btnCancel.Click
        Close()
    End Sub
End Class