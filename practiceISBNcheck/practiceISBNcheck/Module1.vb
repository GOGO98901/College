Module Module1

    Sub Main()
        Dim ISBN(13) As Integer
        Dim Count As Integer
        Dim CalculateDigit As Integer
        For Count = 1 To 13
            Console.WriteLine("Please enter next digit of ISBN: ")
            ISBN(Count) = Console.ReadLine()
        Next
        CalculateDigit = 0
        Count = 1
        While Count < 13
            CalculateDigit += ISBN(Count)
            Count += 1
            CalculateDigit += ISBN(Count) * 3
            Count += 1
        End While
        While CalculateDigit >= 10
            CalculateDigit -= 10
        End While
        CalculateDigit = 10 - CalculateDigit
        If CalculateDigit = 10 Then
            CalculateDigit = 0
        End If
        If CalculateDigit = ISBN(13) Then
            Console.WriteLine("Valid ISBN")
        Else
            Console.WriteLine("Invalid ISBN")
        End If
        Console.ReadLine()

    End Sub

End Module
