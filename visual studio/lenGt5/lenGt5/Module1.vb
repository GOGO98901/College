Module Module1

    Sub Main()
        Console.Title = "String"
        Dim good As Boolean = False
        Dim text As String = ""
        Dim length As Integer = -1
        While good = False
            Console.Clear()
            Console.WriteLine("Enter a string that is greater than 5")
            Console.Write("> ")
            text = Console.ReadLine()
            length = Len(text)
            If length > 5 Then
                good = True
            End If
        End While
        Console.Clear()
        Console.WriteLine("That String is acceptable")
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

End Module
