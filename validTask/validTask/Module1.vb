Module Module1
    Dim _title As String = "Validation Programming Tasks"
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
        Dim input As String
        Do
            Dim valid As Boolean
            Dim task As Integer = 0
            While valid = False
                Call title()
                Console.WriteLine("Pick an task (enter the corresponding number)")
                Console.WriteLine("1: Length Check")
                Console.WriteLine("2: Format Check")
                Console.WriteLine("3: Range Check")
                Console.WriteLine("4: Type Check")
                Console.WriteLine("5: Lookup Check")
                Console.WriteLine("6: Presence Check")
                Console.WriteLine("7: Verification Check")
                Console.WriteLine("8: Check digit")
                Console.Write("> ")
                input = Console.ReadLine()
                If Integer.TryParse(input, task) Then
                    If task > 0 And task <= 8 Then
                        valid = True
                    Else
                        Console.WriteLine("Only enter a number from 1-8!")
                        Console.WriteLine("Press enter to try again")
                        Console.ReadLine()
                    End If
                Else
                    Console.WriteLine("Only enter the numbers please!")
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            End While
            Call title()
            If task = 1 Then
                Call length()
            ElseIf task = 2 Then
                Call format()
            ElseIf task = 3 Then
                Console.WriteLine("No function yet")
            ElseIf task = 4 Then
                Console.WriteLine("No function yet")
            ElseIf task = 5 Then
                Console.WriteLine("No function yet")
            ElseIf task = 6 Then
                Console.WriteLine("No function yet")
            ElseIf task = 7 Then
                Console.WriteLine("No function yet")
            ElseIf task = 8 Then
                Console.WriteLine("No function yet")
            End If

            task = 0
            valid = False
            Console.WriteLine()
            Console.WriteLine(_sep)
            Console.WriteLine("Do you want to run program again? (y/n)")
            Console.Write("> ")
            input = Console.ReadLine()
        Loop While input = "y"
    End Sub

    Sub length()
        Dim correct As Boolean = False
        Do
            Call title()
            Console.WriteLine("Enter you college email")
            Console.Write("> ")
            Dim email As String = Console.ReadLine()
            If Len(email) > 20 Then
                correct = True
            Else
                Console.WriteLine("Your email must have at least 20 characters")
                Console.WriteLine("Press enter to try again")
                Console.ReadLine()
            End If
        Loop Until correct
        Console.WriteLine("yay")

    End Sub

    Sub format()
        Dim correct As Boolean = False
        Do
            Call title()
            Console.WriteLine("Enter you college email")
            Console.Write("> ")
            Dim email As String = Console.ReadLine()
            If Len(email) = 22 Then
                Dim number As Integer
                If Integer.TryParse(email.Substring(0, 6), number) Then
                    If email.Substring(5, Len(email) - 1) = "@godalming.ac.uk" Then
                        correct = True
                    Else
                        Console.WriteLine("Your email must end in '@godalming.ac.uk")
                        Console.WriteLine("Press enter to try again")
                        Console.ReadLine()
                    End If
                Else
                    Console.WriteLine("Your email contain your number ID (eg. 153863)")
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            Else
                Console.WriteLine("Your email must have 22 characters")
                Console.WriteLine("Press enter to try again")
                Console.ReadLine()
            End If
        Loop Until correct
        Console.WriteLine("yay")
    End Sub
End Module
