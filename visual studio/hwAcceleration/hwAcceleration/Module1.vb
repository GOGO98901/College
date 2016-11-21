Module Module1

    Sub Main()
        Dim initVel As Integer
        Dim finalVel As Integer
        Dim time As Integer
        Dim output As Double
        Console.WriteLine("Acceleration workerouter thing")
        Console.WriteLine("Please enter the initial Velocity")
        initVel = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Please enter the final Velocity")
        finalVel = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Please enter the time taken")
        time = Convert.ToInt32(Console.ReadLine())
        output = (finalVel - initVel) / time
        Console.WriteLine("Your Acceleration was: " + output.ToString)
        Console.WriteLine("(" + finalVel.ToString + "-" + initVel.ToString + ") / " + time.ToString + " = " + output.ToString)
        Console.ReadLine()
    End Sub

End Module
