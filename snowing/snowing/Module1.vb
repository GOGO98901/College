Module Module1
    Dim SnowX(200), SnowY(200)
    Sub Main()
        Dim counter As Integer
        Randomize()
        Console.SetWindowSize(110, 69)
        For counter = 1 To 200
            SnowX(counter) = CInt(Int((108 * Rnd()) + 1))
            SnowY(counter) = CInt(Int((68 * Rnd()) + 1))
        Next
        For counter = 1 To 200
            If counter <> 1000 Then Console.Clear()
            Snowfall(counter)
            System.Threading.Thread.Sleep(250)
        Next
        Console.ReadLine()
    End Sub
    Sub DrawSnow(x As Integer, y As Integer)
        Console.SetCursorPosition(x + 1, y)
        Console.Write("*")
        Console.SetCursorPosition(x, y + 1)
        Console.Write("***")
        Console.SetCursorPosition(x + 1, y + 2)
        Console.Write("*")
    End Sub
    Sub Snowfall(Limit As Integer)
        Dim counter As Integer
        For counter = 1 To Limit
            SnowY(counter) = (SnowY(counter) + 1) Mod 68
            SnowX(counter) = (SnowX(counter) + CInt(Int(3 * Rnd()))) Mod 108
            DrawSnow(SnowX(counter), SnowY(counter))
        Next
    End Sub
End Module

