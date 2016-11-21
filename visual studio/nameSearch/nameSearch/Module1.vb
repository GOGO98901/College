Module Module1

    Sub Main()
        Console.Title = "Name Search"
        Dim cont As Char = "y"
        Dim names As New ArrayList()
        While (cont = "n") = False
            names.Add(getInput("Enter a name"))
            cont = getInput("Do you want to enter another name? (y/n)")
        End While
        Dim place = searchName(names, getInput("Enter the name you would like to look for"))
        If place = -1 Then
            Console.WriteLine("That name was not found")
        Else
            Console.WriteLine("That name was found at index " & place)
        End If
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

    Function getInput(text As String) As String
            Console.Clear()
        Console.WriteLine(text)
        Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Len(input) > 0 Then Return input
            Return getInput(text)
    End Function

    Function searchName(list As ArrayList, name As String) As Integer
        Dim count As Integer = 0
        For Each name2 As String In list
            count += 1
            If name = name2 Then Return count
        Next
        Return -1
    End Function
End Module
