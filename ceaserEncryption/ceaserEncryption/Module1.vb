Module Module1
    Dim _title As String = "Ceaser encryption and decryption"
    Dim _sep As String = "-------------------------------------------------------------------------------"
    Sub Main()
        Console.Title = _title
        Call Program()
    End Sub

    Sub Program()
        Console.Clear()
        Console.WriteLine(_title)
        Console.WriteLine(_sep)
        Console.WriteLine("Please enter a valid number 1(encrypt), 2(decrypt), 3(exit)")
        Console.WriteLine(_sep)
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        Dim inOption As Integer
        If Integer.TryParse(input, inOption) Then
            If inOption = 1 Then
                Call encryptFun()
            ElseIf inOption = 2 Then
                Call decryptFun()
            ElseIf inOption = 3 Then
                Environment.Exit(0)
            Else
                Call Program()
                Return
            End If
        Else
            Call Program()
        End If
        Console.WriteLine(_sep)
        Console.WriteLine("Press Enter to exit back to main menu")
        Console.ReadLine()
        Call Program()
        Return
    End Sub

    Sub encryptFun()
        Dim stepOne As Boolean = False
        Dim stepTwo As Boolean = False
        Dim key As Integer = 0
        Dim textString As String = ""
        While stepOne = False
            Console.Clear()
            Console.WriteLine("Ceaser Encryption")
            Console.WriteLine(_sep)
            Console.WriteLine("Please enter a number key (0-32)")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, key) Then
                stepOne = True
            End If
        End While
        While stepTwo = False
            Console.Clear()
            Console.WriteLine("Ceaser Encryption")
            Console.WriteLine(_sep)
            Console.WriteLine("Please enter a your text to encrypt")
            Console.Write("> ")
            textString = Console.ReadLine()
            If Len(textString) > 0 Then
                stepTwo = True
            End If
        End While
        Call encrypt(key, textString)
    End Sub

    Sub decryptFun()
        Dim stepOne As Boolean = False
        Dim stepTwo As Boolean = False
        Dim key As Integer = 0
        Dim textString As String = ""
        While stepOne = False
            Console.Clear()
            Console.WriteLine("Ceaser Decryption")
            Console.WriteLine(_sep)
            Console.WriteLine("Please enter a your key to decrypt")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, key) Then
                stepOne = True
            End If
        End While
        While stepTwo = False
            Console.Clear()
            Console.WriteLine("Ceaser Decryption")
            Console.WriteLine(_sep)
            Console.WriteLine("Please enter a your text to decrypt")
            Console.Write("> ")
            textString = Console.ReadLine()
            If Len(textString) > 0 Then
                stepTwo = True
            End If
        End While
        Call decrypt(key, textString)
    End Sub

    Sub encrypt(key As Integer, textString As String)
        Console.Clear()
        Console.WriteLine("Ceaser Encryption")
        Console.WriteLine(_sep)

        Dim newString As String = ""
        For Each c As Char In textString
            'If c = " " Then
            '   newString += " "
            '   Continue For
            'End If
            Dim i As Integer = Asc(c)
            Dim newC As Char = Chr(i + key)
            newString += newC.ToString
        Next
        My.Computer.Clipboard.SetText(newString)

        Console.WriteLine("Your encrypted text is bellow and has been copied to your clipboard, your key is '" + key.ToString + "'")
        Console.WriteLine(_sep)
        Console.WriteLine(newString)
    End Sub

    Sub decrypt(key As Integer, textString As String)
        Console.Clear()
        Console.WriteLine("Ceaser Encryption")
        Console.WriteLine(_sep)

        Dim newString As String = ""
        For Each c As Char In textString
            'If c = " " Then
            '   newString += " "
            '   Continue For
            'End If
            Dim i As Integer = Asc(c)
            Dim newC As Char = Chr(i - key)
            newString += newC.ToString
        Next
        My.Computer.Clipboard.SetText(newString)

        Console.WriteLine("Your decrypted text is bellow and has been copied to your clipboard, your key is '" + key.ToString + "'")
        Console.WriteLine(_sep)
        Console.WriteLine(newString)
    End Sub
End Module
