Module Module1
    Sub Main()
        'Dim Names As String() = {"Ben", "Thor", "Zoe", "Kate"}
        Dim Names(4) As String
        Dim PlayerName As String
        Dim Max As Integer
        Dim current As Integer
        Dim Found As Boolean
        Names(1) = "Ben"
        Names(2) = "Thor"
        Names(3) = "Zoe"
        Names(4) = "Kate"
        Max = 4
        current = 1
        Found = False
        Console.WriteLine("What player are you locking for?")
        PlayerName = Console.ReadLine()
        While Not Found And current <= Max
            If Names(current) = PlayerName Then
                Found = True
            Else
                current += 1
            End If
        End While
        If Found Then
            Console.WriteLine("Yes, they have a top score")
        Else
            Console.WriteLine("No, they do not have a top score")
        End If
        Console.ReadLine()
    End Sub
End Module
