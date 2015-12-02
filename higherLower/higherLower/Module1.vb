Module Module1
    Dim _title As String = "Higher or Lower?"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Sub Main()
        Console.Title = _title
        Call Start()
    End Sub

    Sub title()
        Console.Clear()
        Console.WriteLine(_title)
        Console.WriteLine(_sep)
    End Sub

    Sub Start()
        Dim score As Integer = 0
        Dim round As Integer = 0
        Dim running As Boolean = True
        While running
            round += 1
            Dim startNo As Integer = CInt(Math.Ceiling(Rnd() * 15))
            Dim actual As Integer = CInt(Math.Ceiling(Rnd() * 15))

            Dim input As String = ""

            Call title()
            Console.WriteLine("Score: " + score.ToString)
            Console.WriteLine("Only enter 'high' or 'low'")

            Console.WriteLine("Is it higher or lower than **[" + startNo.ToString + "]** ?")
            Dim valid As Boolean = False
            While valid = False
                Console.Write("> ")
                input = Console.ReadLine()
                valid = True
                Dim correct As Boolean = False
                If input = "high" Then
                    If actual > startNo Then
                        correct = True
                    End If
                ElseIf input = "low" Then
                    If actual < startNo Then
                        correct = True
                    End If
                Else
                    Console.WriteLine("Only enter 'high' or 'low'")
                    valid = False
                    Continue While
                End If
                If correct Then
                    Console.Clear()
                    Call title()
                    score += 1
                    Console.WriteLine("Score: " + score.ToString)
                    Console.WriteLine(_sep)
                    Console.WriteLine("Correct!")
                    Console.WriteLine("+1 to your score")
                    Console.WriteLine(_sep)
                    Console.WriteLine("Press enter to continue")
                    Console.ReadLine()
                Else
                    running = False
                End If
            End While
        End While
        Call title()
        Console.WriteLine("Unlucky")
        Console.WriteLine("You got a score of " + score.ToString)
        Console.WriteLine("And reached round " + round.ToString)
        Console.WriteLine(_sep)
        Console.WriteLine("Would you like to play again? (y/n)")
        Dim run As String = Console.ReadLine()
        If run = "y" Then
            Call Start()
            Return
        End If
    End Sub

End Module
