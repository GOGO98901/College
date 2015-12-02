Module Module1
    Dim _title As String = "Find the mole"
    Dim _sep As String = "-------------------------------------------------------------------------------"

    Dim auto As Boolean = False

    Dim boardWidth As Integer = 9   'take one off due to array so 0 is really 10
    Dim boardHeight As Integer = 9  'take one off due to array so 0 is really 10

    Dim board(boardWidth, boardHeight) As Integer

    Dim boardPositionX As Integer
    Dim boardPositionY As Integer

    Sub Main()
        Console.Title = _title
        Call start()
    End Sub

    Sub reset()
        For y As Integer = 0 To boardWidth
            For x As Integer = 0 To boardHeight
                board(x, y) = 0
            Next
        Next
        Dim xPos As Integer = CInt(Int((boardWidth * Rnd())))
        Dim yPos As Integer = CInt(Int((boardHeight * Rnd())))
        boardPositionX = xPos
        boardPositionY = yPos
        board(xPos, yPos) = 1
    End Sub

    Sub title()
        Console.Clear()
        Console.WriteLine(_title)
        Console.WriteLine(_sep)
    End Sub

    Sub start()
        Call title()
        Console.WriteLine("Type 1 to find the mole or 2 to exit")
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        Dim inputOption As Integer
        If Integer.TryParse(input, inputOption) Then
            If inputOption = 2 Then
                Environment.Exit(0)
            ElseIf inputOption = 1 Then
                Dim found As Boolean = False
                Dim guess As Integer = 0
                Call reset()
                Dim x As Integer = -1
                Dim y As Integer
                While found = False
                    guess += 1
                    Call title()
                    Call printBoard(False)
                    Console.WriteLine()
                    If auto Then
                        x += 1
                        If x = boardWidth + 1 Then
                            x = 0
                            y += 1
                        End If
                    Else
                        x = getXAxis() - 1
                        y = getYAxis() - 1
                    End If
                    Console.Clear()
                    If x = boardPositionX And y = boardPositionY Then
                        found = True
                    Else
                        board(x, y) = 2
                    End If
                    Call title()
                    Call printBoard(found)
                    Console.WriteLine()
                    Console.WriteLine("You guessed [x=" + (x + 1).ToString + ", y=" + (y + 1).ToString + "]")
                    If Not found Then
                        Console.WriteLine("Unlucky! Try Again")
                    Else
                        Console.WriteLine("Congratulations!!! You found it")
                    End If
                    Console.WriteLine("Press enter to continue")
                    Console.ReadLine()
                End While
            End If
        End If
        Call start()
        Return
    End Sub

    Sub printBoard(visible As Boolean)
        Console.Write("  | ")
        For x As Integer = 0 To boardWidth
            If x >= 9 Then
                Console.Write((x + 1).ToString + "| ")
                Continue For
            End If
            Console.Write((x + 1).ToString + " | ")
        Next
        Console.WriteLine()
        Console.WriteLine("  ---------------------------------------------")
        For y As Integer = 0 To boardWidth
            Dim gridLine As String = (y + 1).ToString + " | "
            If y >= 9 Then
                gridLine = (y + 1).ToString + "| "
            End If
            For x As Integer = 0 To boardHeight
                Dim cell As Integer = board(x, y)
                Dim dis As String = cell.ToString
                If visible = False Then
                    If cell = 1 Then
                        dis = "0"
                    End If
                End If
                If cell = 2 Then
                    dis = "x"
                End If
                gridLine += dis + " | "
            Next
            Console.WriteLine(gridLine)
        Next
    End Sub

    Function getXAxis() As Integer
        Console.WriteLine("Enter your X axis guess")
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        Dim numberX As Integer
        If Integer.TryParse(input, numberX) Then
            If numberX > 0 And numberX <= boardWidth + 1 Then
                Return numberX
            End If
        End If
        Return getXAxis()
    End Function

    Function getYAxis() As Integer
        Console.WriteLine("Enter your Y axis guess")
        Console.Write("> ")
        Dim input As String = Console.ReadLine()
        Dim numberY As Integer
        If Integer.TryParse(input, numberY) Then
            If numberY > 0 And numberY <= boardHeight + 1 Then
                Return numberY
            End If
        End If
        Return getYAxis()
    End Function
End Module
