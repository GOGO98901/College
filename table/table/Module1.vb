Module Module1
    Dim tableWidth As Integer = 4
    Dim tableHeight As Integer = 4

    Sub Main()
        Call drawTable()
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

    Sub drawTable()
        Console.Write("  | ")
        For x As Integer = 0 To tableWidth
            If x >= 10 Then
                Console.Write(x.ToString + "| ")
                Continue For
            End If
            Console.Write(x.ToString + " | ")
        Next
        Console.WriteLine()
        Console.WriteLine("  ---------------------")
        For y As Integer = 0 To tableHeight
            Dim gridLine As String = y.ToString + " | "
            If y >= 10 Then
                gridLine = y.ToString + "| "
            End If
            For x As Integer = 0 To tableWidth
                Dim cell As Integer = x + y
                If cell >= 10 Then
                    gridLine += cell.ToString + "| "
                Else
                    gridLine += cell.ToString + " | "
                End If
            Next
            Console.WriteLine(gridLine)
        Next
    End Sub
End Module
