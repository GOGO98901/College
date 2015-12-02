Module Module1

    Sub Main()
        Console.Title = "String length finder"
        Dim good As Boolean = False
        Dim text As String = ""
        Dim length As Integer = -1
        While good = False
            Console.Clear()
            Console.WriteLine("Enter a string to find out its length")
            Console.Write("> ")
            text = Console.ReadLine()
            length = Len(text)
            If length > 0 Then
                good = True
            End If
        End While
        Console.Clear()
        Console.WriteLine("The length of '" + text + "' is '" + length.ToString + "'")
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub
End Module