Module Module1

    Sub Main()
        Console.WriteLine("The volume of a cylinder")
        Dim height As Integer
        Dim radius As Integer
        Dim output As Double
        Console.WriteLine("Please enter the height")
        height = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Please enter the radius")
        radius = Convert.ToInt32(Console.ReadLine())
        output = Math.Pow(Math.PI * radius, 2) * height
        Console.WriteLine("The volume is " + output.ToString)
        Console.ReadLine()
    End Sub

End Module
