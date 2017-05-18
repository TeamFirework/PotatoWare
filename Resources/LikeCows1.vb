Public Class LikeCows1
    ''' <summary>
    ''' Used to keep count of how many textbox values have been cycled.
    ''' </summary>
    Dim CowTag As Integer = 0
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CowTag = CowTag + 1 'Increment the CowTag variable by 1.
        If CowTag = 1 Then
            Label1.Text =
                "Pressing Finish will download the latest " + vbNewLine +
                "event and replace the existing sp_event.dll " + vbNewLine +
                "file. If you want to keep it, go to where you " + vbNewLine +
                "installed PotatoWare and back it up."
        End If
        If CowTag = 2 Then
            Label1.Text =
                "To get sp_event.dll, go with Start + R:" + vbNewLine +
                "C:\ProgramData\PotatoWare\" + vbNewLine +
                "and copy sp_event.dll to back it up." + vbNewLine +
                "Press Next to restart, and Finish to download."
            btnFinish.Enabled = True
        End If
        If CowTag > 2 Then
            btnFinish.Enabled = False
            CowTag = 0
            Label1.Text =
"This Is an Internet sourced special Event system.
This Is where you go to take place in special events.
The file ''sp_event.dll'' in the program's folder is where
the Events will be found. The events can be saved."
        End If
        If My.Application.CommandLineArgs.Contains("--debug") Then
            Debug.WriteLine("Button click ops: Success.")
        End If
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'The following lines are placeholder for Finish Button completion.
        ' [:: START ThrowError ::]
        MessageBox.Show("Start the app with --debug on the command line to see what went down.")
        If My.Application.CommandLineArgs.Contains("--debug") Then
            Console.WriteLine("{!} ERROR: Debug switch will show you what happened.")
            Console.WriteLine("The Finish button is not completed.")
            Console.WriteLine("In the future, it will check a file for a version, then download it if it's new.")
            Console.WriteLine("Until I finish it, no special events.")
        End If
        Debug.WriteLine("{!} Error: The Finish button is not completed.")
        OopsLabel.Visible = True
        OopsTimer.Enabled = True
    End Sub
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        OopsLabel.Visible = True
        OopsTimer.Enabled = True
    End Sub
    Protected Friend Sub TimerElapse() Handles OopsTimer.Tick
        OopsLabel.Visible = False
        OopsTimer.Enabled = False
    End Sub
End Class