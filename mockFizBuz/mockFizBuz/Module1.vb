Module Module1

    Sub Main()
        Console.WriteLine("How far to count?")
        Dim HowFar = Console.ReadLine()
        While HowFar < 1
            Console.WriteLine("Not a valid number, please try again")
            HowFar = Console.ReadLine()
        End While
        For MyLoop As Integer = 1 To HowFar
            If MyLoop Mod 3 = 0 And MyLoop Mod 5 = 0 Then
                Console.WriteLine("FizzBuzz")
            Else
                If MyLoop Mod 3 = 0 Then
                    Console.WriteLine("Fizz")
                Else
                    If MyLoop Mod 5 = 0 Then
                        Console.WriteLine("Buzz")
                    Else
                        Console.WriteLine(MyLoop)
                    End If
                End If
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
