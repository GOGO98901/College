Module Module1

    Sub Main()
        'livePlay()

        Dim jingle As String = "E:40250,E:40250,E:40250, ,E:40250,E:40250,E:40500,E:40250,G:40250,C:40250,D:40250,E:40750,F:40250,F:40250,F:40250,F:40250,F:40250,E:40250,E:40250,E:40250,E:40250,E:40250,D:40250,D:40250,D:40250,E:40250,D:40250,G:40250"

        Dim notestr As String
        Dim Notes() As String
        Dim notelength As Integer
        Dim thisNote As Single
        'FileOpen(1, "mytune.csv", OpenMode.Input, OpenAccess.Read)
        'notestr = LineInput(1)
        'FileClose(1)
        notestr = jingle
        Notes = notestr.Split(",")
        For i = 0 To UBound(Notes)
            thisNote = (Num2Freq(NoteToNum(Notes(i))))
            If thisNote < 1 Then
                System.Threading.Thread.Sleep(250)
            Else
                notelength = CInt(Right(Notes(i), 4))
                Console.Beep(thisNote, notelength)
            End If
        Next
    End Sub

    Sub livePlay()
        Dim livenote As Char
        Dim thisnote As Single
        While livenote <> "z"
            livenote = Console.ReadKey.KeyChar
            thisnote = (Num2Freq(NoteToNum(livenote & ":4")))
            Console.Beep(thisnote, 500)
        End While
    End Sub

    Function Num2Freq(n As Integer)
        If n = 0 Then
            Num2Freq = 0
        Else
            Num2Freq = 2 ^ ((n - 49) / 12) * 440
        End If
    End Function

    Function NoteToNum(note As String) As Integer
        ' uses A:1,A#2 ect. G:8 is the highest note availble
        Dim tmp As Integer
        Select Case Left(note, 2)
            Case "A:" : tmp = 1
            Case "A#" : tmp = 2
            Case "B:" : tmp = 3
            Case "C:" : tmp = 4
            Case "C#" : tmp = 5
            Case "D:" : tmp = 6
            Case "D#" : tmp = 7
            Case "E:" : tmp = 8
            Case "F:" : tmp = 9
            Case "F#" : tmp = 10
            Case "G:" : tmp = 11
            Case "G#" : tmp = 12
            Case " " : tmp = 0 : note = "0"
        End Select
        If note <> "0" Then NoteToNum = tmp + (14 * Mid(note, 3, 1))
    End Function
End Module