Module Module1

    Sub Main()
        Console.Title = "Cost Of Sweets"
        Dim stepOne As Boolean = False
        Dim stepTwo As Boolean = False
        Dim cost As Double = 0.0
        Dim mass As Double = 0.0
        While stepOne = False
            Console.Clear()
            Console.WriteLine("Enter the cost per 100g in the form '£0.00'")
            Console.Write("> £")
            Dim input As String = Console.ReadLine()
            If Double.TryParse(input, cost) Then
                stepOne = True
            End If
        End While
        While stepTwo = False
            Console.Clear()
            Console.WriteLine("Enter the mass of sweets purchased in the form '0.00' in grams")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Double.TryParse(input, mass) Then
                stepTwo = True
            End If
        End While
        Console.Clear()

        Dim price As Double = cost * (mass / 100.0)
       
        Console.WriteLine("Price: £" + price.ToString)

        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

End Module
