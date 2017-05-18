Partial Class PotatoManagement
    Public Class Crypt
        '*************************
        '** Global Variables
        '*************************

        Dim strFileToEncrypt As String
        Dim strFileToDecrypt As String
        Dim strOutputEncrypt As String
        Dim strOutputDecrypt As String
        Dim fsInput As System.IO.FileStream
        Dim fsOutput As System.IO.FileStream
        '*************************
        '** Create A Key
        '*************************

        Private Function CreateKey(ByVal strPassword As String) As Byte()
            'Convert strPassword to an array and store in chrData.
            Dim chrData() As Char = strPassword.ToCharArray
            'Use intLength to get strPassword size.
            Dim intLength As Integer = chrData.GetUpperBound(0)
            'Declare bytDataToHash and make it the same size as chrData.
            Dim bytDataToHash(intLength) As Byte

            'Use For Next to convert and store chrData into bytDataToHash.
            For i As Integer = 0 To chrData.GetUpperBound(0)
                bytDataToHash(i) = CByte(Asc(chrData(i)))
            Next

            'Declare what hash to use.
            Dim SHA512 As New System.Security.Cryptography.SHA512Managed
            'Declare bytResult, Hash bytDataToHash and store it in bytResult.
            Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
            'Declare bytKey(31).  It will hold 256 bits.
            Dim bytKey(31) As Byte

            'Use For Next to put a specific size (256 bits) of 
            'bytResult into bytKey. The 0 To 31 will put the first 256 bits
            'of 512 bits into bytKey.
            For i As Integer = 0 To 31
                bytKey(i) = bytResult(i)
            Next

            Return bytKey 'Return the key.
        End Function
        '*************************
        '** Create An IV
        '*************************

        Private Function CreateIV(ByVal strPassword As String) As Byte()
            'Convert strPassword to an array and store in chrData.
            Dim chrData() As Char = strPassword.ToCharArray
            'Use intLength to get strPassword size.
            Dim intLength As Integer = chrData.GetUpperBound(0)
            'Declare bytDataToHash and make it the same size as chrData.
            Dim bytDataToHash(intLength) As Byte

            'Use For Next to convert and store chrData into bytDataToHash.
            For i As Integer = 0 To chrData.GetUpperBound(0)
                bytDataToHash(i) = CByte(Asc(chrData(i)))
            Next

            'Declare what hash to use.
            Dim SHA512 As New System.Security.Cryptography.SHA512Managed
            'Declare bytResult, Hash bytDataToHash and store it in bytResult.
            Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
            'Declare bytIV(15).  It will hold 128 bits.
            Dim bytIV(15) As Byte

            'Use For Next to put a specific size (128 bits) of bytResult into bytIV.
            'The 0 To 30 for bytKey used the first 256 bits of the hashed password.
            'The 32 To 47 will put the next 128 bits into bytIV.
            For i As Integer = 32 To 47
                bytIV(i - 32) = bytResult(i)
            Next

            Return bytIV 'Return the IV.
        End Function
        '****************************
        '** Encrypt/Decrypt File
        '****************************

        Private Enum CryptoAction
            'Define the enumeration for CryptoAction.
            ActionEncrypt = 1
            ActionDecrypt = 2
        End Enum

        Private Sub EncryptOrDecryptFile(ByVal strInputFile As String,
                                         ByVal strOutputFile As String,
                                         ByVal bytKey() As Byte,
                                         ByVal bytIV() As Byte,
                                         ByVal Direction As CryptoAction)
            Try 'In case of errors.

                'Setup file streams to handle input and output.
                fsInput = New System.IO.FileStream(strInputFile, FileMode.Open,
                                                      FileAccess.Read)
                fsOutput = New System.IO.FileStream(strOutputFile,
                                                       FileMode.OpenOrCreate,
                                                       FileAccess.Write)
                fsOutput.SetLength(0) 'make sure fsOutput is empty

                'Declare variables for encrypt/decrypt process.
                Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
                Dim lngBytesProcessed As Long = 0 'running count of bytes processed
                Dim lngFileLength As Long = fsInput.Length 'the input file's length
                Dim intBytesInCurrentBlock As Integer 'current bytes being processed
                Dim csCryptoStream As Security.Cryptography.CryptoStream
                'Declare your CryptoServiceProvider.
                Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
                'Determine if ecryption or decryption and setup CryptoStream.
                Select Case Direction
                    Case CryptoAction.ActionEncrypt
                        csCryptoStream = New Security.Cryptography.CryptoStream(fsOutput,
                        cspRijndael.CreateEncryptor(bytKey, bytIV),
                        Security.Cryptography.CryptoStreamMode.Write)

                    Case CryptoAction.ActionDecrypt
                        csCryptoStream = New System.Security.Cryptography.CryptoStream(fsOutput,
                        cspRijndael.CreateDecryptor(bytKey, bytIV),
                        Security.Cryptography.CryptoStreamMode.Write)
                End Select

                'Use While to loop until all of the file is processed.
                While lngBytesProcessed < lngFileLength
                    'Read file with the input filestream.
                    intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                    'Write output file with the cryptostream.
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                    'Update lngBytesProcessed
                    lngBytesProcessed = lngBytesProcessed +
                                            CLng(intBytesInCurrentBlock)
                End While

                'Close FileStreams and CryptoStream.
                csCryptoStream.Close()
                fsInput.Close()
                fsOutput.Close()
            Catch
                ' Nothing
            End Try
        End Sub
        Public Function DecryptFile(password As String, destination As String)
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(password)
            'Send the password to the CreateIV function.
            bytIV = CreateIV("PotatoWare")
            'Start the decryption.
            EncryptOrDecryptFile(strFileToDecrypt, destination,
                                 bytKey, bytIV, CryptoAction.ActionDecrypt)
        End Function
        Public Function EncryptFile(password As String, destination As String)
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(password)
            'Send the password to the CreateIV function.
            bytIV = CreateIV("PotatoWare")
            'Start the encryption.
            EncryptOrDecryptFile(strFileToEncrypt, destination,
                                 bytKey, bytIV, CryptoAction.ActionEncrypt)
        End Function
    End Class
End Class
