Module Module1
    Dim _title As String = "Chocolate Machine"
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
        Dim usingM As Boolean = True
        While usingM
            Dim selecting As Boolean = True
            Dim input As String
            While selecting
                Call title()
                Call drawTable()
                input = getInput("Enter the number slot of the bar that you would like")
                If IsNumeric(input) Then
                    If input >= 1 And input <= 4 Then
                        selecting = False
                    Else
                        Console.WriteLine("Please only enter numbers 1-4")
                    End If
                Else
                    Console.WriteLine("Please only enter a number to select the bar")
                End If
                If selecting Then
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            End While
            Dim change = order(getPrice(input))
            Console.WriteLine("You have been given " & change & "p change")
            Console.WriteLine("And the chocolate bar")
            Dim rerun As Char = getInput("Do you want to get another bar? (y/n)")
            If rerun = "n" Then
                usingM = False
            End If
        End While
    End Sub

    Sub drawTable()
        For row As Integer = 1 To 4
            If row = 2 Then
                Console.WriteLine("|   Mars   |   Twix   | Milkybar |  Freddo  |")
            ElseIf row = 3 Then
                Console.WriteLine("|   " & getPrice(1) & "p    |   " & getPrice(2) & "p    |   " & getPrice(3) & "p    |   " & getPrice(4) & "p    |")
            Else

                Console.WriteLine("|          |          |          |          |")
            End If
        Next
        Console.WriteLine("    (1)         (2)        (3)        (4)  ")
        Console.WriteLine(_sep)
    End Sub

    Function order(price As Integer) As Integer
        Dim payed As Integer = 0
        While payed < price
            Call title()
            Console.WriteLine("You still have to pay " & price - payed & "p")
            Dim input As String = getInput("Enter the coin to enter 1p(1), 2p(2), 5p(3), 10p(4), 20p(5), 50p(6)")
            If IsNumeric(input) Then
                If input >= 1 And input <= 6 Then
                    If input = 1 Then payed += 1
                    If input = 2 Then payed += 2
                    If input = 3 Then payed += 5
                    If input = 4 Then payed += 10
                    If input = 5 Then payed += 20
                    If input = 6 Then payed += 50
                Else
                    Console.WriteLine("Please only enter numbers 1-6")
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            Else
                Console.WriteLine("Please only enter a number")
                Console.WriteLine("Press enter to try again")
                Console.ReadLine()
            End If
        End While
        Return payed - price
    End Function

    Function getPrice(index As Integer) As Integer
        If index = 1 Then Return 50
        If index = 2 Then Return 45
        If index = 3 Then Return 20
        If index = 4 Then Return 10
        Return 0
    End Function

    Function getInput(text As String) As String
        Console.WriteLine(text)
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        If Len(input) > 0 Then Return input
        Return getInput(text)
    End Function

End Module
