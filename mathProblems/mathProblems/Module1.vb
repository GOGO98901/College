Module Module1

    Dim _title As String = "Interesting Maths Programming Tasks"
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
                Console.WriteLine("1: Fibonacci Sequence")
                Console.WriteLine("2: Prime numbers")
                Console.WriteLine("3: Pascals Triangle")
                Console.WriteLine("4: Palindromee detector")
                Console.WriteLine("5: Palindromee dates")
                Console.WriteLine()
                Console.Write("> ")
                input = Console.ReadLine()
                If checkInput(input) Then
                    If IsNumeric(input) Then
                        taskId = input
                        If taskId >= 0 And taskId <= 5 Then
                            okay = True
                        End If
                    End If
                End If
                If okay = False Then
                    Console.WriteLine("Please enter a numbers from 0-5s only")
                    Console.WriteLine("Press enter to try again")
                    Console.ReadLine()
                End If
            Loop Until okay
            Do
                again = False
                If taskId = 0 Then
                    Environment.Exit(0)
                ElseIf taskId = 1 Then
                    Call fibonacci()
                ElseIf taskId = 2 Then
                    Call prime()
                ElseIf taskId = 3 Then
                    Call pascal()
                ElseIf taskId = 4 Then
                    Call palindrome()
                ElseIf taskId = 5 Then
                    Call palindromeDates()
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

    Sub fibonacci()
        Call title()
        Dim terms As Integer = 10
        Console.WriteLine("The fibonacci Sequence with " & terms & " terms")
        Dim old As Integer = 1
        Dim twoOld As Integer = 0
        Console.Write("0, 1")
        For no As Integer = 2 To terms
            Dim output As Integer = old + twoOld
            Console.Write(", " + output.ToString)
            twoOld = old
            old = output
        Next
        Console.WriteLine()
    End Sub

    Sub prime()
        Call title()
        Console.WriteLine("The prime numbers under 1000")
        Console.Write("2")
        For no As Integer = 2 To 1000
            If checkPrime(no) Then
                Console.Write(", " & no)
            End If
        Next
        Console.WriteLine()
    End Sub

    Sub pascal()
        Call title()
        Console.WriteLine("Pascals Triangle")
        Dim height As Integer = getIntInput()
        Call title()
        Console.WriteLine("Pascals Triangle")
        Dim list(height, height) As Integer
        For row As Integer = 1 To height
            
            For place As Integer = 1 To row
                Dim aboveLeft As Integer = 0
                Dim aboveRight As Integer = 0
                If row - 1 > 0 Then
                    If place - 1 > 0 Then
                        aboveLeft = list(row - 1, place - 1)
                    End If
                    If place <= row Then
                        aboveRight = list(row - 1, place)
                    End If
                End If
                If row = 1 And place = 1 Then
                    list(row, place) = 1
                Else
                    list(row, place) = aboveLeft + aboveRight
                End If
            Next
        Next
        Dim maxLen As Integer = Len(list(height, height / 2).ToString)
        For row As Integer = 1 To height
            Dim line As String = ""
            For gap As Integer = height To row Step -1
                line += " "
            Next
            For place As Integer = 1 To row
                Dim space As String = ""
                For p As Integer = Len(list(row, place).ToString) To maxLen / 2
                    space += " "
                Next
                line += space + list(row, place).ToString + space
            Next
            Console.WriteLine(line)
        Next
    End Sub

    Sub palindrome()
        Call title()
        Console.WriteLine("Palindrome detector")
        Console.WriteLine("Enter 0 to find out each word is a palindrome or enter 1 to show all palindromes in a string")
        Dim method As Integer = getIntInput()
        While (method = 0 Or method = 1) = False
            Console.WriteLine("Only enter a 0 or a 1")
            method = getIntInput()
        End While

        If method = 0 Then
            Call title()
            Console.WriteLine("Palindrome detector")
            Console.WriteLine("Enter your word")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            While (checkInput(input) = False)
                Console.WriteLine("You need to enter something")
                Console.Write("> ")
                input = Console.ReadLine()
            End While
            Call title()
            Console.WriteLine("Palindrome detector")
            Console.WriteLine()
            Console.Write("Your string '" + input + "' is ")
            If isPalindrome(input) Then
                Console.WriteLine("a palindrome")
            Else
                Console.WriteLine("not a palindrome")
            End If
        Else
            Call title()
            Console.WriteLine("Palindrome detector")
            Console.WriteLine("Enter your sentence")
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            Dim parts As String() = input.Split(" ")
            Dim palindromes As String = ""
            For Each part As String In parts
                Console.WriteLine(part)

                If isPalindrome(part) Then
                    palindromes += " " + part + " "
                End If
            Next
            Call title()
            Console.WriteLine("Palindrome detector")
            Console.WriteLine("The following are palindromes")
            Console.WriteLine()
            Console.WriteLine(palindromes)
        End If
        Console.WriteLine()
    End Sub

    Sub palindromeDates()
        Call title()
        Console.WriteLine("Palindrome Dates from 1000AD to today")
        Dim startp As DateTime = New DateTime(1000, 1, 1)
        Dim endp As DateTime = DateTime.Now()
        Dim CurrD As DateTime = startp

        While (CurrD <= endp)
            Dim dateOnly As Date = CurrD.Date
            If isPalindrome(dateOnly.ToString.Split(" ")(0).Replace("/", "")) Then
                Console.Write("  " + dateOnly.ToString.Split(" ")(0) + "  | ")
            End If
            CurrD = CurrD.AddDays(1)
        End While
        Console.WriteLine()
    End Sub

    Function isPalindrome(input As String) As Boolean
        Dim flip As String = ""
        For Each c As Char In input.ToLower()
            flip = c + flip
        Next
        If flip = input.ToLower() Then
            Return True
        End If
        Return False
    End Function

    Function getIntInput() As Integer
        Dim int As Integer
        Dim valid As Boolean = False
        While valid = False
            Console.Write("> ")
            Dim input As String = Console.ReadLine()
            If IsNumeric(input) Then
                int = input
                valid = True
            Else
                Console.WriteLine("You must enter a number")
            End If
        End While
        Return int
    End Function

    Function checkPrime(number As Integer) As Boolean
        If number <= 2 Then
            Return False
        End If
        For i As Integer = 2 To number ^ 0.5
            If number Mod i = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Function checkInput(input As String) As Boolean
        If Len(input) > 0 Then
            Return True
        Else
            Console.WriteLine("You must enter something!")
            Return False
        End If
    End Function

End Module
