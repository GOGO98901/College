﻿Module Module1

    Sub Main()
        Dim N, Choice As Integer
        Dim StartTime, StopTime As Long
        Dim Numbers(30000) As Integer
        Do
            DisplayMenu()
            Choice = Console.ReadLine
            Select Case Choice
                Case 1
                    Console.Write("Enter the size of the array of random numbers (Max 30000): ")
                    N = Console.ReadLine
                    GenerateArray(Numbers, N)
                    DisplayArray(Numbers, N)
                    Console.Write("Press ENTER to continue: ")
                    Console.ReadLine()
                Case 2
                    StartTime = My.Computer.Clock.TickCount
                    ExchangeSort(Numbers, N)
                    StopTime = My.Computer.Clock.TickCount
                    DisplayArray(Numbers, N)
                    Console.Write("Run Time = " & StopTime - StartTime & " mS")
                    Console.ReadLine()
                Case 3
                    StartTime = My.Computer.Clock.TickCount
                    BubbleSort(Numbers, N)
                    StopTime = My.Computer.Clock.TickCount
                    DisplayArray(Numbers, N)
                    Console.Write("Run Time = " & StopTime - StartTime & " mS")
                    Console.ReadLine()
                Case 4
                    StartTime = My.Computer.Clock.TickCount
                    InsertionSort(Numbers, N)
                    StopTime = My.Computer.Clock.TickCount
                    DisplayArray(Numbers, N)
                    Console.Write("Run Time = " & StopTime - StartTime & " mS")
                    Console.ReadLine()
                Case 5
                    StartTime = My.Computer.Clock.TickCount
                    PartitionSort(Numbers, N)
                    StopTime = My.Computer.Clock.TickCount
                    DisplayArray(Numbers, N)
                    Console.Write("Run Time = " & StopTime - StartTime & " mS")
                    Console.ReadLine()
            End Select
        Loop Until Choice = 6
    End Sub
    Sub DisplayMenu()
        Console.Clear()
        Console.WriteLine("Sorting Methods - Please select an option below")
        Console.WriteLine()
        Console.WriteLine("1) Generate array of random numbers")
        Console.WriteLine("2) Exchange Sort")
        Console.WriteLine("3) Bubble Sort")
        Console.WriteLine("4) Insertion Sort")
        Console.WriteLine("5) Partition Sort")
        Console.WriteLine("6) Quit")
        Console.WriteLine()
        Console.Write("Enter option number: ")
    End Sub
    Sub GenerateArray(Numbers() As Integer, Limit As Integer)
        Dim counter As Integer
        Randomize()
        For counter = 1 To Limit
            Numbers(counter) = CInt(Int((99999 * Rnd()) + 1))
        Next
    End Sub
    Sub DisplayArray(Numbers() As Integer, Limit As Integer)
        Dim counter As Integer
        Dim Pad As String
        For counter = 1 To Limit
            Pad = Left("          ", 9 - Len(Str(counter)))
            Console.WriteLine(counter & Pad & Numbers(counter))
        Next
    End Sub

    Sub ExchangeSort(Numbers() As Integer, Limit As Integer)
        'write Exchange Sort code here
    End Sub
    Sub BubbleSort(Numbers() As Integer, Limit As Integer)
        'write Exchange Sort code here
    End Sub
    Sub InsertionSort(Numbers() As Integer, Limit As Integer)
        'write Insertion Sort code here
    End Sub
    Sub PartitionSort(Numbers() As Integer, Limit As Integer)
        'write Partition Sort code here
    End Sub

End Module
