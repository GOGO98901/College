Module Module1

    Sub Main()
        Dim playerOneScore As Integer = 0
        Dim playerTwoScore As Integer = 0
        Console.WriteLine("How many games were played? (as integer)")
        Dim numberOfGames As Integer = Console.ReadLine()
        For noGame As Integer = 1 To numberOfGames
            Console.WriteLine("Round " & noGame & ": Did player one win this round? (y/n)")
            Dim input As Char = Console.ReadLine()
            If input = "y" Or input = "Y" Then
                playerOneScore += 1
            Else
                playerTwoScore += 1
            End If
        Next
        Console.WriteLine()
        Console.WriteLine("Player one scored " & playerOneScore)
        Console.WriteLine("Player Two scored " & playerTwoScore)
        Console.ReadLine()
    End Sub

End Module
