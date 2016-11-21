Module Module1
    Sub Main()
        Console.WriteLine("Player One enter your chosen number: ")
        Dim NumberToGuess As Integer = Console.ReadLine()
        While NumberToGuess < 1 Or NumberToGuess > 10
            Console.WriteLine("Not a valid choice, please enther another number: ")
            NumberToGuess = Console.ReadLine()
        End While
        Dim Guess As Integer = 0
        Dim NumberOfGuesses As Integer = 0
        While Not Guess = NumberToGuess And NumberOfGuesses < 5
            Console.WriteLine("Player Two have a guess: ")
            Guess = Console.ReadLine()
            NumberOfGuesses += 1
        End While
        If Guess = NumberToGuess Then
            Console.WriteLine("Player Two Wins")
        Else
            Console.WriteLine("Player One Wins")
        End If
        Console.ReadLine()
    End Sub
End Module
