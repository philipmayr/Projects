Public Class TopicDialog

    Private Sub TopicTitleDialog_Shown() Handles Me.Shown
        TextBox.Focus()
    End Sub

    Private Sub DialogOKButton_Click() Handles DialogOKButton.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub
End Class