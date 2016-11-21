Module Module1

    Sub Main()
        Console.Title = "Simple Division"
        Dim stepOne As Boolean = False
        Dim stepTwo As Boolean = False
        Dim noOne As Integer = 0
        Dim noTwo As Integer = 0
        While stepOne = False
            Console.Clear()
            Console.WriteLine("Enter number one")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, noOne) Then
                stepOne = True
            End If
        End While
        While stepTwo = False
            Console.Clear()
            Console.WriteLine("Enter number two")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Integer.TryParse(input, noTwo) Then
                stepTwo = True
            End If
        End While
        Console.Clear()
        Dim roundOut As Double = noOne / noTwo
        Dim roundDp As Double = Math.Round(noOne / noTwo, 2, MidpointRounding.AwayFromZero)
        Dim roundIn As Integer = Math.Round(noOne / noTwo, 0, MidpointRounding.AwayFromZero)
        Console.Write("Without Rounding: ")
        Console.WriteLine(noOne.ToString + " / " + noTwo.ToString + " = " + roundOut.ToString)
        Console.Write("Rounding to 3 Decimal places: ")
        Console.WriteLine(noOne.ToString + " / " + noTwo.ToString + " = " + roundDp.ToString)
        Console.Write("Rounding/Casting to integer: ")
        Console.WriteLine(noOne.ToString + " / " + noTwo.ToString + " = " + roundIn.ToString)



        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

End Module
