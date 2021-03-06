﻿Module Module1

    Sub Main()
        Dim N, Choice As Integer
        Dim StartTime, StopTime As Long
        Dim Numbers(Integer.MaxValue / 16) As Integer
        Do
            DisplayMenu()
            Choice = Console.ReadLine
            Select Case Choice
                Case 1
                    Console.Write("Enter the size of the array of random numbers (Max " & (Integer.MaxValue / 16) & "): ")
                    N = Console.ReadLine
                    GenerateArray(Numbers, N)
                    'DisplayArray(Numbers, N)
                    Console.WriteLine("Created a random array with " & N & " entries")
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
                    MergeSort(Numbers, N, 0, N)
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
        Console.WriteLine("4) Merge Sort")
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
        For i = 0 To (Limit - 1) Step 1
            For j = 0 To Limit Step 1
                Dim nI, nJ As Integer
                nI = Numbers(i)
                nJ = Numbers(j)
                If nI > nJ Then
                    Numbers(j) = nI
                    Numbers(i) = nJ
                End If
            Next
        Next
    End Sub
    Sub BubbleSort(Numbers() As Integer, Limit As Integer)
        Dim sorted As Boolean
        Dim i As Integer = 2
        While Not sorted
            sorted = True
            For i2 = Limit To i Step -1
                Dim t1 = Numbers(i2)
                Dim t2 = Numbers(i2 - 1)
                If t1 > t2 Then Continue For
                sorted = False
                Numbers(i2) = t2
                Numbers(i2 - 1) = t1
            Next
            i += 1
        End While
    End Sub

    Sub MergeSort(Numbers() As Integer, Limit As Integer, First As Integer, Last As Integer)
        Dim Mid As Integer
        If Last > First Then
            Mid = (Last + First) \ 2
            MergeSort(Numbers, Limit, First, Mid)
            MergeSort(Numbers, Limit, Mid + 1, Last)
            Merge(Numbers, Limit, First, Mid, Last)
        End If
    End Sub

    Sub Merge(Numbers() As Integer, Limit As Integer, StartPtr As Integer, MidPtr As Integer, EndPtr As Integer)
        Dim TempStore(Limit) As Integer
        Dim LeftCounter, RightCounter, Counter, CopyCounter As Integer
        For CopyCounter = StartPtr To EndPtr
            TempStore(CopyCounter) = Numbers(CopyCounter)
        Next
        LeftCounter = StartPtr
        RightCounter = MidPtr + 1
        Counter = StartPtr
        While LeftCounter <= MidPtr And RightCounter <= EndPtr
            If TempStore(LeftCounter) <= TempStore(RightCounter) Then
                Numbers(Counter) = TempStore(LeftCounter)
                LeftCounter = LeftCounter + 1
            Else
                Numbers(Counter) = TempStore(RightCounter)
                RightCounter = RightCounter + 1
            End If
            Counter += 1
        End While
        If LeftCounter <= MidPtr Then
            For CopyCounter = 1 To MidPtr - LeftCounter + 1
                Numbers(Counter + CopyCounter - 1) = TempStore(LeftCounter + CopyCounter - 1)
            Next
        Else
            For CopyCounter = 1 To EndPtr - RightCounter + 1
                Numbers(Counter + CopyCounter - 1) = TempStore(RightCounter + CopyCounter - 1)
            Next
        End If
    End Sub

    Sub PartitionSort(Numbers() As Integer, Limit As Integer)
        'write Partition Sort code here
    End Sub

End Module
