Module Module1

    Sub Main()
        Console.Title = "Basic Calculator"
        Dim numberOne, numberTwo As Integer
        Dim answer As Single
        While True
            Call printMenu()
            Dim task = Console.ReadLine
            If task = 0 Then Return

            Console.Clear()

            Call input2nums(numberOne, numberTwo)

            Console.Clear()
            If task = 1 Then
                Call addition(answer, numberOne, numberTwo)
                Console.WriteLine("Addition")
            ElseIf task = 2 Then
                Call subtraction(answer, numberOne, numberTwo)
                Console.WriteLine("Subtraction")
            ElseIf task = 3 Then
                Call multiplication(answer, numberOne, numberTwo)
                Console.WriteLine("Multiplication")
            ElseIf task = 4 Then
                Call division(answer, numberOne, numberTwo)
                Console.WriteLine("Division")
            Else
                Console.WriteLine("Unknown option")
            End If

            Call output(answer)

            Console.WriteLine()
            Console.WriteLine("Press enter to go back to main menu")
            Console.ReadLine()
            Console.Clear()
        End While
    End Sub

    Sub printMenu()
        Console.WriteLine("What maths function do you want to use?")
        Console.WriteLine("0: exit")
        Console.WriteLine("1: Addition")
        Console.WriteLine("2: Subtraction")
        Console.WriteLine("3: Multiplication")
        Console.WriteLine("4: Division")
    End Sub

    Sub input2nums(ByRef one As Integer, ByRef two As Integer)
        Console.WriteLine("Input Number 1")
        Console.Write("> ")
        one = Console.ReadLine
        Console.Clear()
        Console.WriteLine("Input Number 2")
        Console.Write("> ")
        two = Console.ReadLine
    End Sub

    Sub addition(ByRef answer As Integer, number1 As Integer, number2 As Integer)
        answer = number1 + number2
    End Sub

    Sub subtraction(ByRef answer As Integer, number1 As Integer, number2 As Integer)
        answer = number1 - number2
    End Sub

    Sub multiplication(ByRef answer As Integer, number1 As Integer, number2 As Integer)
        answer = number1 * number2
    End Sub

    Sub division(ByRef answer As Integer, number1 As Integer, number2 As Integer)
        answer = number1 / number2
    End Sub

    Sub output(answer As Integer)
        Console.WriteLine("The answer is " & answer)
    End Sub
End Module
