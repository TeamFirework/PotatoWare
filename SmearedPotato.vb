Public Class SmearedPotato
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If MsgBox("Are you sure you want to discard everything in the document?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SmearedPotato") = MsgBoxResult.Yes Then
            TextField.Text = ""
        End If
    End Sub
    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog.ShowDialog()
        Try
            Dim Streme As New System.IO.StreamReader(OpenFileDialog.OpenFile())
            TextField.Text = Streme.ReadToEnd()
        Catch
            MessageBox.Show(caption:="Open - SmearedPotato", text:="Opening either was cancelled or failed.")
        End Try
    End Sub
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveFileDialog.ShowDialog()
        Try
            Dim Streme As New System.IO.StreamWriter(SaveFileDialog.OpenFile())
            My.Computer.FileSystem.WriteAllText(SaveFileDialog.OpenFile().ToString, TextField.Text, False)
        Catch
            MessageBox.Show(caption:="Save - SmearedPotato", text:="Saving either was cancelled or failed.")
        End Try
    End Sub
    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        MsgBox("Sorry, but printing is currently unavailable. Please try again later.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SmearedPotato")
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        Clipboard.SetText(TextField.SelectedText)
        TextField.SelectedText = ""
    End Sub
    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        Clipboard.SetText(TextField.SelectedText)
    End Sub
    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        'Get the data stored in the clipboard
        Dim iData As IDataObject = Clipboard.GetDataObject()
        'Check to see if the data is in a text format
        If iData.GetDataPresent(DataFormats.Text) Then
            'If it's text, then paste it into the textbox
            TextField.SelectedText = CType(iData.GetData(DataFormats.Text), String)
        Else
            'If it's not text, don't allow pasting
        End If
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
#Region "Content For Help"
        HelpBox.contentForHelp =
            "What is SmearedPotato?" + vbNewLine + vbNewLine +
            "SmearedPotato is a plain text editor. You can use it to write things. The icons should be familiar if you've ever used a computer before."
#End Region
        HelpBox.Show()
    End Sub
End Class