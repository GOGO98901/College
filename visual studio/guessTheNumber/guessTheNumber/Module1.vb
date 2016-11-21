Module Module1
    Dim _title As String = "Random number Game"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Sub Main()
        Console.Title = _title
        Call start()
    End Sub

    Sub title()
        Console.Clear()
        Console.WriteLine(_title)
        Console.WriteLine(_sep)
    End Sub

    Sub start()
        Dim playingM As Boolean = True
        While playingM
            Dim playing As Boolean = True
            Dim answer As Integer = CInt(Math.Ceiling(Rnd() * 100))
            Dim input As String
            While playing
                Call title()

                input = getInput("Guess a number between 1 and 100")
                If IsNumeric(input) Then
                    If input >= 1 And input <= 100 Then
                        If input > answer Then
                            Console.WriteLine("That guess was high")
                        ElseIf input < answer Then
                            Console.WriteLine("That guess was low")
                        Else
                            Console.WriteLine("Correct you guessed the number")
                            Console.ReadLine()
                            playing = False
                        End If
                    Else
                        Console.WriteLine("Please only enter a number between 1 and 100")
                    End If
                Else
                    Console.WriteLine("Please only enter a number")
                End If
                Console.WriteLine("Press enter to continue")
                Console.ReadLine()
            End While
            Dim rerun As Char = getInput("Do you want to try again? (y/n)")
            If rerun = "n" Then
                playingM = False
            End If
        End While
    End Sub

    Function getInput(text As String) As String
        Console.WriteLine(text)
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        If Len(input) > 0 Then Return input
        Return getInput(text)
    End Function

End Module