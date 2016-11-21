Module Module1

    Dim _title As String = "Meeting away from home"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Sub Main()
        Console.Title = _title
        Call title()
        Call start()
    End Sub

    Sub title()
        Console.Clear()
        Console.WriteLine(_title + " guide")
        Console.WriteLine(_sep)
    End Sub

    Sub start()
        Dim stepPrice As Boolean = False
        Dim price As Double = -1.0
        While stepPrice = False
            Console.WriteLine("Please enter the price per night")
            Console.Write("> £")
            Dim input As String = Console.ReadLine()
            If Double.TryParse(input, price) Then
                Call title()
                stepPrice = True
            End If
        End While

        Dim stepDistance As Boolean = False
        Dim distance As Integer = -1
        While stepDistance = False
            Console.WriteLine("Please enter how many miles away the hotel is from the venue (round up to whole number)")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, distance) Then
                Call title()
                stepDistance = True
            End If
        End While
        Call title()
        If calculate(price, distance) Then
            Console.WriteLine("It is okay to stay at this hotel")
        Else
            Console.WriteLine("It is NOT okay to stay at this hotel")
        End If
        Console.WriteLine(_sep)
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

    Function calculate(price As Integer, distance As Integer) As Boolean
        If price >= 60 Or distance > 5 Then
            Return False
        End If
        Return True
    End Function
End Module
