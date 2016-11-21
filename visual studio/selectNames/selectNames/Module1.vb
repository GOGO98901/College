Module Module1
    Dim _title As String = "Find the mole"
    Dim _sep As String = "-------------------------------------------------------------------------------"


    Dim numberOfNames As Integer = 10
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
        Dim longer As New ArrayList
        Dim list(numberOfNames, 2) As String
        For count As Integer = 1 To numberOfNames
            Dim good As Boolean = False
            Do
                Call title()
                Console.WriteLine("Enter a name (" & count & "/" & numberOfNames & ")")
                Console.Write("> ")
                Dim name As String = Console.ReadLine()
                Dim parts() As String = name.Split(" ")
                If parts.Length = 2 Then
                    list(count - 1, 0) = parts(0)
                    list(count - 1, 1) = parts(1)
                    good = True
                Else
                    Console.WriteLine("Please only enter two names")
                    Console.WriteLine("Press enter to try agian")
                    Console.ReadLine()
                End If
            Loop Until good
        Next
        For count As Integer = 0 To numberOfNames - 1
            Dim lengthF As Integer = Len(list(count, 0))
            Dim lengthL As Integer = Len(list(count, 1))
            If lengthL > lengthF Then
                longer.Add(list(count, 0) + " " + list(count, 1))
            End If
        Next
        Call title()
        Console.WriteLine("Bellow are all the names in which the surname is longer than the first name")
        Console.WriteLine()
        For Each name In longer
            Console.WriteLine(name)
        Next
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub
End Module
