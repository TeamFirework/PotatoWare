Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public Sub Exception(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If Application.CommandLineArgs.Contains("--debug") Then
                MessageBox.Show("An exception has occurred: " + e.Exception.Message)
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(Environment.CurrentDirectory + "\potato.log", True)
                file.WriteLine("----------")
                file.WriteLine(Date.Today)
                file.WriteLine(e.Exception.Message)
                file.WriteLine("Error at file: " + e.Exception.Source)
                file.WriteLine(e.Exception.StackTrace)
                file.Close()
            End If
            PoisonPotato.Show()
            MessageBox.Show("Oops! Something slipped inside the application, where we can't resume. Sorry!")
        End Sub
    End Class
End Namespace