Public Class HelpBox
    Public contentForHelp As String
    Private Sub HelpBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If contentForHelp = Nothing Then
            'The help box is empty. Close helpbox.
            HelpContent.Text = "Error occurred"
        Else
            'The help box has something in it! Keep it open and make it show up.
            HelpContent.Text = contentForHelp
        End If
    End Sub
End Class