Module Module1

    Const letter As Char = "a"

    Sub Main()
        Console.Title = "Find the first " + letter
        Console.WriteLine("Note: in programing indexes start at 0")
        Console.WriteLine("Enter your string bellow")
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        Dim place As Integer = input.IndexOf(letter)
        If place = -1 Then
            Console.WriteLine("Your string does not contain " + letter)
        Else
            Console.WriteLine("The first " + letter + " is at possition " + place.ToString)
        End If
        Console.ReadLine()
    End Sub

End Module
