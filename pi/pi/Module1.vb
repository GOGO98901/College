Module Module1

    Sub Main()
        Console.Title = "How much PI?"
        Dim stepOne As Boolean = False
        Dim places As Integer = -1
        While stepOne = False
            Console.Clear()
            Console.WriteLine("Enter the number of decimal places would you like to see PI to?")
            Console.WriteLine("note: due to limitation 'Rounding digits must be between 0 and 15, inclusive.'")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If Double.TryParse(input, places) Then
                If (places > 0 And places <= 15) Then
                    stepOne = True
                End If
            End If
        End While
        Console.Clear()
        Console.Write("Pi to " + places.ToString + "dp is ")
        Dim pi As Double = Math.Round(Math.PI, places, MidpointRounding.AwayFromZero)
        Console.WriteLine(pi)
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub
End Module
