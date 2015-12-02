Module Module1

    Dim _title As String = "Sports Club"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Sub Main()
        Console.Title = _title
        Call title()
        Call start()
    End Sub

    Sub title()
        Console.Clear()
        Console.WriteLine(_title + " price guide")
        Console.WriteLine(_sep)
    End Sub

    Sub start()
        Dim stepAge As Boolean = False
        Dim age As Integer = -1
        While stepAge = False
            Console.WriteLine("Please enter you age in years")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, age) Then
                Call title()
                stepAge = True
            End If
        End While

        Dim stepYears As Boolean = False
        Dim years As Integer = -1
        While stepYears = False
            Console.WriteLine("Please enter how many years you have had membership for")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, years) Then
                Call title()
                stepYears = True
            End If
        End While
        Call calculate(age, years)
        Console.ReadLine()
    End Sub

    Sub calculate(age As Integer, years As Integer)
        Dim price As Integer = -1
        Dim category As String = "null"
        If age <= 18 Then
            price = 60
            If years >= 2 Then
                price -= 20
            End If
            category = "Junior"
        ElseIf age <= 49 Then
            price = 120
            If years >= 10 Then
                price -= 30
            End If
            category = "Seniors"
        Else
            price = 80
            category = "Veterans"
        End If
        Call title()
        Console.WriteLine("This member is classed as an '" + category + "'")
        Console.WriteLine("And should pay a yearly subscription fee of £" + price.ToString)
    End Sub
End Module
