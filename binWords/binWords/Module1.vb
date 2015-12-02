Module Module1

    Sub Main()
        Dim input As String
        Do
            Console.Clear()
            Console.WriteLine("  One: not A")
            Console.WriteLine("  Two: A and B")
            Console.WriteLine("Three: A or B")
            Console.WriteLine("Enter task number")
            Console.Write("> ")
            input = Console.ReadLine()
            Console.Clear()
            If input = "one" Or input = 1 Then
                Call one()
            ElseIf input = "two" Or input = 2 Then
                Call two()
            ElseIf input = "three" Or input = 3 Then
                Call three()
            Else
                Console.WriteLine("unknown or error!")
            End If
            Console.WriteLine("Run again (y/n)")
            Console.Write("> ")
            input = Console.ReadLine()
        Loop While input = "y"
    End Sub

    Sub one()
        Console.WriteLine("Enter binary word")
        Console.Write("> ")
        Dim input As Byte = Console.ReadLine()
        Dim output As Byte = Not input

        Console.WriteLine("Output = " & output)
    End Sub

    Sub two()
        Console.WriteLine("Enter 1st binary word")
        Console.Write("> ")
        Dim inputA As Byte = Console.ReadLine()
        Console.WriteLine("Enter 2nd binary word")
        Console.Write("> ")
        Dim inputB As Byte = Console.ReadLine()

        Dim output As Byte = inputA And inputB

        Console.WriteLine("Output = " & output)
    End Sub

    Sub three()
        Console.WriteLine("Enter 1st binary word")
        Console.Write("> ")
        Dim inputA As Byte = Console.ReadLine()
        Console.WriteLine("Enter 2nd binary word")
        Console.Write("> ")
        Dim inputB As Byte = Console.ReadLine()

        Dim output As Byte = inputA Or inputB

        Console.WriteLine("Output = " & output)
    End Sub

End Module
