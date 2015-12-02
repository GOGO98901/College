Module Module1

    Sub Main()
        Call Round()
    End Sub

    Sub Round()
        Dim input As String
        Dim inputOption As Integer
        Dim rand As New Random
        Console.Clear()
        Console.WriteLine("Rock Paper Scissors")
        Console.WriteLine("Type 1(Rock) 2(Paper) 3(Scissors) 4(To Exit the program)")
        Console.WriteLine("--------------------------------------------------------")
        input = Console.ReadLine()
        If Integer.TryParse(input, inputOption) Then
            If inputOption = 4 Then
                Environment.Exit(0)
            Else
                If inputOption = 1 Or inputOption = 2 Or inputOption = 3 Then
                    Call Check(rand.Next(1, 3), inputOption)
                Else
                    Console.WriteLine("Only type the numbers 1, 2, 3 or 4")
                End If
            End If
        Else
                Console.WriteLine("Please only enter a numerical value")
        End If
        Console.WriteLine("--------------------------------------------------------")
        Console.WriteLine("Press enter to continue")
        Console.ReadLine()
        Call Round()
    End Sub

    Sub Check(computer As Integer, user As Integer)
        Dim names(0 To 2) As String
        names(0) = "Rock"
        names(1) = "Paper"
        names(2) = "Scissors"
        Dim rock = 1
        Dim paper = 2
        Dim scissors = 3
        Console.WriteLine("You used " + names(user - 1))
        Console.WriteLine("Computer used " + names(computer - 1))
        Console.WriteLine("--------------------------------------------------------")
        If computer = user Then
            Console.WriteLine("Its a Draw!!")
        Else
            If computer = rock Then
                If user = paper Then
                    Console.WriteLine("You Won!!")
                Else
                    Console.WriteLine("You Lost!!")
                End If
            ElseIf computer = paper Then
                If user = scissors Then
                    Console.WriteLine("You Won!!")
                Else
                    Console.WriteLine("You Lost!!")
                End If
            ElseIf computer = scissors Then
                If user = rock Then
                    Console.WriteLine("You Won!!")
                Else
                    Console.WriteLine("You Lost!!")
                End If
            End If
        End If
    End Sub

End Module
