Imports System.Security.Cryptography

Class MD5Maker

    Function MD5(ByVal myStr As String) As String
        Dim provider As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String = “”
        Dim i As Integer
        provider = New MD5CryptoServiceProvider()
        bytValue = System.Text.Encoding.UTF8.GetBytes(myStr)
        bytHash = provider.ComputeHash(bytValue)
        provider.Clear()
        For i = 0 To (bytHash.Length) - 1
            strOutput &= bytHash(i).ToString(“x”).PadLeft(2, “0”)
        Next
        Return strOutput
    End Function

End Class
