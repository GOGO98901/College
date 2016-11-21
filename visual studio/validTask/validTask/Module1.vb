Module Module1

    Dim _title As String = "Validation Programming Tasks"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Sub Main()
        Console.Title = _title
        Call menu()
    End Sub

    Sub title()
        Console.Clear()
        Console.WriteLine(_title)
        Console.WriteLine(_sep)
    End Sub

    Sub menu()
        Dim input As String
        Do
            Dim okay As Boolean = False
            Dim taskId As Integer = 0
            Dim again As Boolean = True
            Do
                Call title()
                Console.WriteLine("Enter a number bellow to select that task or type '0' to exit")
                'Console.WriteLine("---------------{  Options  }-------------")
                'Console.WriteLine("0: exit")
                Console.WriteLine("---------------{ Task  One (10 chips) }-------------")
                Console.WriteLine("1: Length check")
                Console.WriteLine("2: Format Check")
                Console.WriteLine("3: Range Check")
                Console.WriteLine("4: Type check")
                Console.WriteLine("5: Lookup check")
                Console.WriteLine("6: Presence Check")
                Console.WriteLine("7: Verification")
                Console.WriteLine("8: Check digit")
                Console.WriteLine("---------------{ Task Five (5  chips) }-------------")
                Console.WriteLine("9: Hex number validator")
                Console.WriteLine("---------------{ Task  Two (3  chips) }-------------")
                Console.WriteLine("10: Carpet Calculator")
                Console.WriteLine("---------------{ Task Four (2  chips) }-------------")
                Console.WriteLine("11: Menu Validator")
                Console.WriteLine()
                Console.Write("> ")
                input = Console.ReadLine()
                If checkInput(input) Then
                    If IsNumeric(input) Then
                        taskId = input
                        If taskId >= 0 And taskId <= 11 Then
                            okay = True
                        End If
                    End If
                End If
                If okay = False Then
                    Console.WriteLine("Please enter a numbers from 0-11 only")
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            Loop Until okay
            Do
                again = False
                If taskId = 0 Then
                    Environment.Exit(0)
                ElseIf taskId = 1 Then
                    Call length()
                ElseIf taskId = 2 Then
                    Call format()
                ElseIf taskId = 3 Then
                    Call range()
                ElseIf taskId = 4 Then
                    Call type()
                ElseIf taskId = 5 Then
                    Call lookup()
                ElseIf taskId = 6 Then
                    Call presence()
                ElseIf taskId = 7 Then
                    Call verification()
                ElseIf taskId = 8 Then
                    Call checkDigit()
                ElseIf taskId = 9 Then
                    Call hexNumber()
                ElseIf taskId = 10 Then
                    Call carpet()
                ElseIf taskId = 11 Then
                    Call menuValid()
                End If
                Console.WriteLine("Do you want to run this again? (y/n)")
                Console.Write("> ")
                input = Console.ReadLine()
                If input = "y" Then
                    again = True
                End If
            Loop While again
            Console.WriteLine("Do you want to select another task? (y/n)")
            Console.Write("> ")
            input = Console.ReadLine()
        Loop While input = "y"
    End Sub

    Sub length()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a student email")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                If Len(input) = 22 Then
                    Console.WriteLine("That email is good")
                    running = False
                Else
                    Console.WriteLine("The emmail must be 22 characters long")
                End If
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub format()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a student email")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                If Len(input) = 22 Then
                    If IsNumeric(input.Substring(0, 6)) Then
                        If input.Substring(6) = "@godalming.ac.uk" Then
                            Console.WriteLine("That email is good")
                            running = False
                        Else
                            Console.WriteLine("The emmail must end with '@godalming.ac.uk'")
                        End If
                    Else
                        Console.WriteLine("The emmail must start with 6 numbers")
                    End If
                Else
                    Console.WriteLine("The emmail must be 22 characters long")
                End If
                If running Then
                    Console.WriteLine("Press enter to try agian")
                    Console.ReadLine()
                End If
            End If
        End While
    End Sub

    Sub range()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a student number")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                If IsNumeric(input) Then
                    Dim no As Integer = input
                    If no >= 150001 And no <= 159999 Then
                        Console.WriteLine("That number is good")
                        running = False
                    Else
                        Console.WriteLine("The student number must between 150001 and 159999")
                    End If
                Else
                    Console.WriteLine("The student number must be a number")
                End If
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub type()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a date in the form of (dd/mm/yyyy)")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                Try
                    Dim dateIn As Date = input
                    Console.WriteLine("That date is good")
                    running = False
                Catch ex As Exception
                    Console.WriteLine("That date was not valid ")
                End Try
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub lookup()
        Dim running As Boolean = True
        Dim input As String
        Dim emails As String() = {"150001@godalming.ac.uk", "150002@godalming.ac.uk", "150003@godalming.ac.uk", "150004@godalming.ac.uk", "150005@godalming.ac.uk"}
        While running
            Call title()
            Console.WriteLine("Enter an email from the students in the class (hardcoded)")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                Dim correct As Boolean = False
                For Each email As String In emails
                    If correct = False Then
                        If input = email Then
                            correct = True
                            running = False
                        End If
                    End If
                Next
                If correct Then
                    Console.WriteLine("A Student with that email is in the class")
                Else
                    Console.WriteLine("No Student in the class has that email")
                End If
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub presence()
        Call title()
        Console.WriteLine("This check has been done in every other task")
    End Sub

    Sub verification()
        Dim running As Boolean = True
        Dim email1 As String
        Dim email2 As String
        While running
            Dim good As Boolean = False
            Do
                Call title()
                Console.WriteLine("Enter your email")
                Console.Write("> ")
                email1 = Console.ReadLine()
                good = checkInput(email1)
                If good = False Then
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            Loop Until good
            good = False
            Do
                Call title()
                Console.WriteLine("Enter your email again")
                Console.Write("> ")
                email2 = Console.ReadLine()
                good = checkInput(email2)
                If good = False Then
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            Loop Until good
            If email1 = email2 Then
                Console.WriteLine("The two emails were identical. Well done")
                running = False
            Else
                Console.WriteLine("The two emails were NOT identical")
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub checkDigit()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a 6 digit number with a chick digit")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                If IsNumeric(input) Then
                    If Len(input) = 6 Then
                        Dim check As Integer = input.Substring(5)
                        Dim total As Double = 0.0
                        Dim counter As Integer = 0
                        For Each no As String In input.ToCharArray
                            counter += 1
                            If counter < 6 Then
                                total += no
                            End If
                        Next
                        Dim output As Integer = Math.Ceiling(total / 5)
                        If output = check Then
                            Console.WriteLine("That number worked out okay")
                            running = False
                        Else
                            Console.WriteLine("That number was bad")
                        End If
                    Else
                        Console.WriteLine("Only enter 6 numbers")
                    End If
                Else
                    Console.WriteLine("Only enter numbers")
                End If
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub hexNumber()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a 4 hex number")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                If Len(input) = 4 Then
                    Dim output As Integer
                    Try
                        output = Convert.ToInt32(input, 16)
                        running = False
                        Console.WriteLine("'" + input + "'" & " was converted to " & output)
                    Catch ex As Exception
                        Console.WriteLine("You can only enter the characters 'A' though 'F' and numbers '0' though '9'")
                    End Try
                Else
                    Console.WriteLine("You must only enter 4 characters")
                End If
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Sub carpet()
        Dim input As String
            Dim width As Integer = -1
            Dim length As Integer = -1
            Dim output As Integer
            Do
                Call title()
                Console.WriteLine("Enter the width of the room in meters")
                Console.Write("> ")
                input = Console.ReadLine()
                If checkInput(input) Then
                    If IsNumeric(input) Then
                        If input >= 2 And input <= 22 Then
                            width = input
                        Else
                            Console.WriteLine("The width must fit between 2 and 22")
                        End If
                    Else
                        Console.WriteLine("You must enter a number")
                    End If
                End If
                If width = -1 Then
                    Console.WriteLine("Press enter to try agian")
                    Console.ReadLine()
                End If
            Loop While width = -1
            Do
                Call title()
                Console.WriteLine("Enter the length of the room in meters")
                Console.Write("> ")
                input = Console.ReadLine()
                If checkInput(input) Then
                    If IsNumeric(input) Then
                        If input >= 2 And input <= 22 Then
                            length = input
                        Else
                            Console.WriteLine("The length must fit between 2 and 22")
                        End If
                    Else
                        Console.WriteLine("You must enter a number")
                    End If
                End If
                If length = -1 Then
                    Console.WriteLine("Press enter to try agian")
                    Console.ReadLine()
                End If
            Loop While length = -1
            output = width * length
            Call title()
            Console.WriteLine("The area of your carpet is " & output & "m^2")
    End Sub

    Sub menuValid()
        Dim running As Boolean = True
        Dim input As String
        While running
            Call title()
            Console.WriteLine("Enter a menu option from 'A' though 'G' in upper case")
            Console.Write("> ")
            input = Console.ReadLine()
            If checkInput(input) Then
                If Len(input) = 1 Then
                    If IsNumeric(input) = False Then
                        If Asc(input) >= Asc("A") And Asc(input) <= Asc("G") Then
                            Console.WriteLine("Menu selection accecpted")
                            running = False
                        Else
                            Console.WriteLine("Only use the characters 'A' through 'G' - In upper case")
                        End If
                    Else
                        Console.WriteLine("Only use the characters 'A' through 'G' - In upper Case")
                    End If
                Else
                    Console.WriteLine("Only enter one character")
                End If
            End If
            If running Then
                Console.WriteLine("Press enter to try agian")
                Console.ReadLine()
            End If
        End While
    End Sub

    Function checkInput(input As String) As Boolean
        If Len(input) > 0 Then
            Return True
        Else
            Console.WriteLine("You must enter something!")
            Return False
        End If
    End Function

End Module
