' We import System.IO for files
Imports System.IO
' And System.Security.Cryptography for Hashes : MD5, SHA1, SHA256, ...
Imports System.Security.Cryptography

Public Class Security
    ' We specify the file path
    Dim path As String = "Scta1963#"

    ' And we compute the hashes : MD5, SHA-1 and SHA-256
    Dim hash_md5 = md5_hash(path)
    Dim hash_sha_1 = sha_1(path)
    Dim hash_sha_256 = sha_256(path)

    Public passMe As String

    Sub New()

        passMe = hash_generator("md5", "Scta1963#")

    End Sub

    ' Function to obtain the desired hash of a file
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' We declare the variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initializes a md5 hash object
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initializes a SHA-1 hash object
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initializes a SHA-256 hash object
            hash = SHA256.Create()
        Else
            MsgBox("Unknown type of hash : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If

        ' We declare a variable to be an array of bytes
        Dim hashValue() As Byte

        ' We create a FileStream for the file passed as a parameter
        'Dim fileStream As FileStream = File.OpenRead(file_name)
        ' We position the cursor at the beginning of stream
        'fileStream.Position = 0
        ' We calculate the hash of the file
        'hashValue = hash.ComputeHash(fileStream)
        ' The array of bytes is converted into hexadecimal before it can be read easily
        'Dim hash_hex = PrintByteArray(hashValue)

        ' We close the open file
        'fileStream.Close()

        ' The hash is returned
        Return hash

    End Function

    ' We traverse the array of bytes and converting each byte in hexadecimal
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' We traverse the array of bytes
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' We convert each byte in hexadecimal
            hex_value += array(i).ToString("X2")

        Next i

        ' We return the string in lowercase
        Return hex_value.ToLower

    End Function

    ' md5 is a reserved name, so we named the function : md5_hash
    Function md5_hash(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function

    Function sha_1(ByVal file_name As String)
        Return hash_generator("sha1", file_name)
    End Function

    Function sha_256(ByVal file_name As String)
        Return hash_generator("sha256", file_name)
    End Function

End Class
