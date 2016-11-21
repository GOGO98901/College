Module Module1

    Sub Main()
        Dim answer As Integer = 0
        Dim column As Integer = 8
        Do Until column < 1
            Console.WriteLine("Enter a bit value:")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            answer += column * input
            column /= 2
        Loop
        Console.WriteLine("Decimal Value is: " & answer)
        Console.ReadLine()
    End Sub

End Module
