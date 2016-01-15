Module Module1

    Dim _title As String = "File Handlering Programming Tasks"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Structure binary
        Dim product As String
        Dim Price As Single
        Dim Cost As Single
    End Structure

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
                Console.WriteLine("-------{ Reading with known length }------")
                Console.WriteLine("1: Seperated by line")
                Console.WriteLine("2: Seperated by commas")
                Console.WriteLine("3: Adding numbers by line")
                Console.WriteLine("4: Adding numbers by commas")
                Console.WriteLine("------{ Reading with unknown length }-----")
                Console.WriteLine("5: Reading")
                Console.WriteLine("6: Adding up")
                Console.WriteLine("---------{ Writing to text files }--------")
                Console.WriteLine("7: Writing single line")
                Console.WriteLine("8: Appending single line")
                Console.WriteLine("-------{ Writing binary structure }-------")
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
                Call title()
                again = False
                If taskId = 0 Then
                    Environment.Exit(0)
                ElseIf taskId = 1 Then
                    Call readOne()
                ElseIf taskId = 2 Then
                    Call readTwo()
                ElseIf taskId = 3 Then
                    Call readThree()
                ElseIf taskId = 4 Then
                    Call readFour()
                ElseIf taskId = 5 Then
                    Call readFive()
                ElseIf taskId = 6 Then
                    Call readSix()
                ElseIf taskId = 7 Then
                    Call writeSeven()
                ElseIf taskId = 8 Then
                    Call writeEight()
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

    Sub readOne()
        FileOpen(1, "testFile1.txt", OpenMode.Input)
        Dim data(5) As String
        data(0) = LineInput(1).Replace("ï»¿", "")
        data(1) = LineInput(1)
        data(2) = LineInput(1)
        data(3) = LineInput(1)
        data(4) = LineInput(1)
        FileClose(1)

        Console.WriteLine(data(0))
        Console.WriteLine(data(1))
        Console.WriteLine(data(2))
        Console.WriteLine(data(3))
        Console.WriteLine(data(4))
    End Sub

    Sub readTwo()
        FileOpen(1, "testFile2.txt", OpenMode.Input)
        Dim data() As String = LineInput(1).Replace("ï»¿", "").Split(",")
        FileClose(1)

        Console.WriteLine(data(0))
        Console.WriteLine(data(1))
        Console.WriteLine(data(2))
        Console.WriteLine(data(3))
        Console.WriteLine(data(4))
    End Sub

    Sub readThree()
        FileOpen(1, "testFile3.txt", OpenMode.Input)
        Dim data(5) As String
        data(0) = LineInput(1).Replace("ï»¿", "")
        data(1) = LineInput(1)
        data(2) = LineInput(1)
        data(3) = LineInput(1)
        data(4) = LineInput(1)
        FileClose(1)

        Dim sum As Integer = Int(data(0)) + Int(data(1)) + Int(data(2)) + Int(data(3)) + Int(data(4))

        Console.WriteLine("    " + data(0))
        Console.WriteLine(" +  " + data(1))
        Console.WriteLine(" +  " + data(2))
        Console.WriteLine(" +  " + data(3))
        Console.WriteLine(" +  " + data(4))
        Console.WriteLine("----------")
        Console.WriteLine("    " & sum)
    End Sub

    Sub readFour()
        FileOpen(1, "testFile4.txt", OpenMode.Input)
        Dim data() As String = LineInput(1).Replace("ï»¿", "").Split(",")
        FileClose(1)

        Dim sum As Integer = Int(data(0)) + Int(data(1)) + Int(data(2)) + Int(data(3)) + Int(data(4)) + Int(data(5)) + Int(data(6)) + Int(data(7)) + Int(data(8)) + Int(data(9))

        Console.WriteLine("    " + data(0))
        Console.WriteLine(" +  " + data(1))
        Console.WriteLine(" +  " + data(2))
        Console.WriteLine(" +  " + data(3))
        Console.WriteLine(" +  " + data(4))
        Console.WriteLine(" +  " + data(5))
        Console.WriteLine(" +  " + data(6))
        Console.WriteLine(" +  " + data(7))
        Console.WriteLine(" +  " + data(8))
        Console.WriteLine(" +  " + data(9))
        Console.WriteLine("----------")
        Console.WriteLine("    " & sum)
    End Sub

    Sub readFive()
        FileOpen(1, "testFile1.txt", OpenMode.Input)
        Dim noLine As Integer = 0
        Dim data As String = ""
        Do Until EOF(1)
            data += LineInput(1).Replace("ï»¿", "") + vbNewLine
            noLine += 1
        Loop
        FileClose(1)

        Console.WriteLine("testFile1.txt contains " & noLine & " lines")
        Console.WriteLine(data)
    End Sub

    Sub readSix()
        FileOpen(1, "testFile3.txt", OpenMode.Input)
        Dim sum As Integer = 0
        Dim data As String = "NULL"
        Do Until EOF(1)
            Dim line = LineInput(1).Replace("ï»¿", "")
            If data = "NULL" Then
                data = "   " + line
            Else
                data += vbNewLine + " + " + line
            End If
            sum += Int(line)
        Loop
        FileClose(1)
        Console.WriteLine(data)

        Console.WriteLine("----------")
        Console.WriteLine("   " & sum)
    End Sub

    Sub writeSeven()
        Console.WriteLine("Enter a line of text")
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        If Not (checkInput(input)) Then
            Do Until checkInput(input)
                Console.Write("> ")
                input = Console.ReadLine()
            Loop
        End If
        FileOpen(1, "wrtingtest.txt", OpenMode.Output)
        WriteLine(1, input)
        FileClose(1)
    End Sub

    Sub writeEight()
        Console.WriteLine("Enter a line of text for the existing file")
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        If Not (checkInput(input)) Then
            Do Until checkInput(input)
                Console.Write("> ")
                input = Console.ReadLine()
            Loop
        End If
        FileOpen(1, "testFile5.txt", OpenMode.Append)
        Write(1, input)
        FileClose(1)
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
