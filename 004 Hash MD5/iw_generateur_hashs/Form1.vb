' On importe System.IO pour les fichiers
Imports System.IO
' Et System.Security.Cryptography pour les Hashs : MD5, SHA1, SHA256, ...
Imports System.Security
Imports System.Security.Cryptography

Public Class Form1

#Region "Raccourcis pour la fonction principale hash_generator"

    ' md5 est un nom réservé, nous avons donc nommé la fonction : md5_hash
    Function md5_hash(ByVal file_name As String)

        Return hash_generator("md5", file_name)

    End Function

    Function sha_1(ByVal file_name As String)

        Return hash_generator("sha1", file_name)

    End Function

    Function sha_256(ByVal file_name As String)

        Return hash_generator("sha256", file_name)

    End Function

#End Region

    ' Fonction qui permet d'obtenir le hash souhaité d'un fichier
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' On déclare la variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initialise un objet de hash : md5
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initialise un objet de hash : SHA-1
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initialise un objet de hash : SHA-256
            hash = SHA256.Create()
        Else
            MsgBox("Type de hash inconnu : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If

        ' On déclare une variable qui sera un tableau de bytes (octets)
        Dim hashValue() As Byte

        ' On crée un FileStream pour le fichier passé en paramètre
        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' On positionne le curseur au début du stream
        fileStream.Position = 0
        ' On calcule le hash du fichier
        'hashValue = hash.ComputeHash(fileStream)
        hashValue = file_name

        ' On convertit le tableau d'octets (bytes) en hexadécimal pour qu'on puisse le lire facilement
        Dim hash_hex = PrintByteArray(hashValue)

        ' On ferme le fichier ouvert
        fileStream.Close()

        ' On retourne le hash
        Return hash_hex

    End Function

    ' On parcoure le tableau de bytes (octets) et on convertit chaque octet (byte) en hexadécimal
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' On parcoure le tableau de bytes (octets)
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' On convertit chaque octet (byte) en hexadécimal
            hex_value += array(i).ToString("X2")

        Next i

        ' On retourne la chaine de caractères en minuscules
        Return hex_value.ToLower

    End Function

    Private Sub cmdHasher_Click(sender As System.Object, e As System.EventArgs) Handles cmdHasher.Click

        Dim path As String = "Scta1963#"
        ' Et on l'affiche dans la case
        txtToBeHashed.Text = path

        ' Et on calcule les Hashs : MD5, SHA-1 et SHA-256
        LB_md5.Text = md5_hash(path)
        LB_sha1.Text = sha_1(path)
        LB_sha256.Text = sha_256(path)

    End Sub

End Class
