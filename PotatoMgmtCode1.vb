Imports System.Runtime.InteropServices
Partial Class PotatoManagement
    'Potato Management File
    '    File 1
    ''' <summary>
    ''' Checks submitted URLs.
    ''' </summary>
    Shared Sub URLCheck()
        If My.Application.CommandLineArgs.Contains("/url") Then
            Dim aceIndex As Integer = My.Application.CommandLineArgs.IndexOf("/url") + 1
            Dim codeKey As String = My.Application.CommandLineArgs.Item(aceIndex)
#Region ""
            If codeKey.StartsWith("potato://") Then
                'Begin checking. It's a potato URL!
            End If
#End Region    'Identifies URL stuffs.
        End If
    End Sub
    ''' <summary>
    ''' Command-line arguments passed to the application.
    ''' </summary>
    Dim args As ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
    ''' <summary>
    ''' Checks submitted arguments.
    ''' </summary>
    Shared Sub ArgCheck()
        If My.Application.CommandLineArgs.Count > 0 Then
#Region ""
            'If statements here!
#End Region    'Checking for arguments coming soon!
        End If
        ' No argument checks available.
    End Sub
End Class
