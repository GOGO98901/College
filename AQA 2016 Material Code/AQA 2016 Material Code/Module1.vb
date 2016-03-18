'Skeleton Program for the AQA AS Paper 1 Summer 2016 examination
'this code should be used in conjunction with the Preliminary Material
'written by the AQA Programmer Team
'developed in the Visual Studio 2008 programming environment

'Version Number 1.0

Imports System.IO

Module Module1
    Const TrainingGame As String = "Training.txt"
    Const CustomGame As String = "customGame.txt"

    Const GameEasy As Integer = 45
    Const GameMedium As Integer = 35
    Const GameHard As Integer = 25

    Dim ShowShips As Boolean = True

    Structure TShip
        Dim Name As String
        Dim Size As Integer
    End Structure

    Sub GetRowColumn(ByRef Row As Integer, ByRef Column As Integer)
        Console.WriteLine()
        Column = GetValueBetween(0, 9, "Please enter column")
        If Column = -1 Then Return
        Row = GetValueBetween(0, 9, "Please enter row")
        Console.WriteLine()
    End Sub

    Function GetValueBetween(par1 As Integer, par2 As Integer, message As String)
        Dim input As Integer = GetNumericInput(message)
        If input = -1 Or input >= par1 And input <= par2 Then Return input
        Do
            Console.WriteLine("You must enter a value between " & par1 & " and " & par2)
            input = GetNumericInput(message)
        Loop Until input = -1 Or input >= par1 And input <= par2
        Return input
    End Function

    Function GetNumericInput(message As String) As Integer
        Console.WriteLine(message)
        Console.Write("> ")
        Dim input As Object = Console.ReadLine()
        If IsNumeric(input) Then
            Return input
        End If
        Console.WriteLine("Enter a numerical value only")
        Return GetNumericInput(message)
    End Function

    Function MakePlayerMove(ByRef Board(,) As Char, ByRef Ships() As TShip) As Boolean
        Dim Row As Integer
        Dim Column As Integer
        Dim message As String = ""
        GetRowColumn(Row, Column)
        If Column = -1 Or Row = -1 Then Return True
        If Board(Row, Column) = "m" Or Board(Row, Column) = "h" Then
            message = "Sorry, you have already shot at the square (" & Column & "," & Row & "). Please try again."
            Return MakePlayerMove(Board, Ships)
        ElseIf Board(Row, Column) = "-" Then
            message = "Sorry, (" & Column & "," & Row & ") is a miss."
            Board(Row, Column) = "m"
        Else
            message = "Hit at (" & Column & "," & Row & ")."
            Dim ship As Char = Board(Row, Column)
            Board(Row, Column) = "h"
            If Not doesShipExist(Board, ship) Then
                message = "[Computer] You sunk my " & getShipFromChar(Ships, ship).Name & "!"
            End If
        End If
        Console.Clear()
        PrintBoard(Board, Ships)
        Console.WriteLine()
        Console.WriteLine(message)
        Return False
    End Function

    Function doesShipExist(ByRef Board(,) As Char, ship As Char)
        Dim Row As Integer
        Dim Column As Integer
        For Row = 0 To 9
            For Column = 0 To 9
                If Board(Row, Column) = ship Then Return True
            Next
        Next
        Return False
    End Function

    Sub SetUpBoard(ByRef Board(,) As Char)
        Dim Row As Integer
        Dim Column As Integer
        For Row = 0 To 9
            For Column = 0 To 9
                Board(Row, Column) = "-"
            Next
        Next
    End Sub

    Sub SaveGame(ByVal Filename As String, ByVal Board(,) As Char, ByVal goesLeft As Integer)
        Using FileWriter As StreamWriter = New StreamWriter(Filename)
            For Row = 0 To 9
                Dim line As String = ""
                For Column = 0 To 9
                    line += Board(Row, Column)
                Next
                FileWriter.WriteLine(line)
            Next
            FileWriter.WriteLine(goesLeft)
        End Using
        Console.WriteLine("File saved!")
    End Sub

    Sub LoadGame(ByVal Filename As String, ByRef Board(,) As Char, ByRef goesLeft As Integer)
        Dim Row As Integer
        Dim Column As Integer
        Dim Line As String
        Using FileReader As StreamReader = New StreamReader(Filename)
            For Row = 0 To 9
                Line = FileReader.ReadLine()
                For Column = 0 To 9
                    Board(Row, Column) = Line(Column)
                Next
            Next
            If Not FileReader.EndOfStream Then
                goesLeft = FileReader.ReadLine()
            Else
                goesLeft = 0
            End If
        End Using
    End Sub

    Sub PlaceRandomShips(ByRef Board(,) As Char, ByVal Ships() As TShip)
        Dim Valid As Boolean
        Dim Row As Integer
        Dim Column As Integer
        Dim Orientation As Char
        Dim HorV As Integer
        For Each Ship In Ships
            Randomize()
            Valid = False
            While Not Valid
                Row = Int(Rnd() * 10)
                Column = Int(Rnd() * 10)
                HorV = Int(Rnd() * 2)
                If HorV = 0 Then
                    Orientation = "v"
                Else
                    Orientation = "h"
                End If
                Valid = ValidateBoatPosition(Board, Ship, Row, Column, Orientation)
            End While
            Console.WriteLine("[Computer] Placing the " & Ship.Name & " on the board")
            PlaceShip(Board, Ship, Row, Column, Orientation)
        Next
    End Sub

    Sub PlaceShip(ByRef Board(,) As Char, ByVal Ship As TShip, ByVal Row As Integer, ByVal Column As Integer, ByVal Orientation As Char)
        Dim Scan As Integer
        If Orientation = "v" Then
            For Scan = 0 To Ship.Size - 1
                Board(Row + Scan, Column) = Ship.Name(0)
            Next
        ElseIf Orientation = "h" Then
            For Scan = 0 To Ship.Size - 1
                Board(Row, Column + Scan) = Ship.Name(0)
            Next
        End If
    End Sub

    Function ValidateBoatPosition(ByVal Board(,) As Char, ByVal Ship As TShip, ByVal Row As Integer, ByVal Column As Integer, ByVal Orientation As Char)
        Dim Scan As Integer
        If Orientation = "v" And Row + Ship.Size > 10 Then
            Return False
        ElseIf Orientation = "h" And Column + Ship.Size > 10 Then
            Return False
        Else
            If Orientation = "v" Then
                For Scan = 0 To Ship.Size - 1
                    If Board(Row + Scan, Column) <> "-" Then
                        Return False
                    End If
                Next
            ElseIf (Orientation = "h") Then
                For Scan = 0 To Ship.Size - 1
                    If Board(Row, Column + Scan) <> "-" Then
                        Return False
                    End If
                Next
            End If
        End If
        Return True
    End Function

    Function CheckWin(ByVal Ships() As TShip, ByVal Board(,) As Char)
        Dim Row As Integer
        Dim Column As Integer
        For Row = 0 To 9
            For Column = 0 To 9
                If isShip(Ships, Board(Row, Column)) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Function isShip(ByVal Ships() As TShip, place As Char) As Boolean
        For Each ship In Ships
            If place = ship.Name(0) Then Return True
        Next
        Return False
    End Function


    Sub PrintBoard(ByVal Board(,) As Char, ByVal Ships() As TShip)
        Dim Row As Integer
        Dim Column As Integer
        Console.WriteLine()
        Console.WriteLine("The board looks like this: ")
        Console.WriteLine()
        Console.Write(" ")
        For Column = 0 To 9
            Console.Write(" " & Column & "  ")
        Next
        Console.WriteLine()
        For Row = 0 To 9
            Console.Write(Row & " ")
            For Column = 0 To 9
                If Board(Row, Column) = "-" Then
                    Console.Write(" ")
                ElseIf isShip(Ships, Board(Row, Column)) Then
                    If ShowShips Then
                        Console.Write(Board(Row, Column))
                    Else
                        Console.Write(" ")
                    End If
                Else
                    Console.Write(Board(Row, Column))
                End If
                If Column <> 9 Then
                    Console.Write(" | ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub DisplayMenu()
        Console.Clear()
        Console.WriteLine("MAIN MENU")
        Console.WriteLine()
        Console.WriteLine("1. Start new game")
        Console.WriteLine("2. Load training game")
        Console.WriteLine("3. Load saved game")
        Console.WriteLine("8. Show ships [" & ShowShips.ToString.ToLower & "]")
        Console.WriteLine("9. Quit")
        Console.WriteLine()
    End Sub

    Sub DisplayGameMode()
        Console.Clear()
        Console.WriteLine("GAME MODE")
        Console.WriteLine()
        Console.WriteLine("1. Casual (unlimited moves)")
        Console.WriteLine("2. Easy (" & GameEasy & " moves)")
        Console.WriteLine("3. Medium (" & GameMedium & " moves)")
        Console.WriteLine("4. Hard (" & GameHard & " moves)")
        Console.WriteLine("9. Exit (Main menu)")
    End Sub

    Function GetMainMenuChoice()
        Dim Choice As String
        Console.Write("Please enter your choice: ")
        Choice = Console.ReadLine()
        Console.WriteLine()
        If IsNumeric(Choice) Then Return Choice
        Return 0
    End Function

    Sub PlayGame(ByVal Board(,) As Char, ByVal Ships() As TShip, ByVal GoesLeft As Integer)
        Dim GameWon As Boolean = False
        Dim Gamelost As Boolean = False
        Dim GameQuit As Boolean = False
        If GoesLeft = 0 Then
            Do
                DisplayGameMode()
                Dim modeOption As String = GetMainMenuChoice()
                If modeOption = 1 Then
                    GoesLeft = -1
                ElseIf modeOption = 2 Then
                    GoesLeft = GameEasy
                ElseIf modeOption = 3 Then
                    GoesLeft = GameMedium
                ElseIf modeOption = 4 Then
                    GoesLeft = GameHard
                ElseIf modeOption = 9 Then
                    GameQuit = True
                    Return
                End If
            Loop While GoesLeft = 0
        End If
        Console.Clear()
        Do
            PrintBoard(Board, Ships)
            Console.WriteLine()
            Console.WriteLine("Type -1 to exit to main menu")
            Console.WriteLine()
            Console.WriteLine("You have " & GoesLeft & " goes left")
            GameQuit = MakePlayerMove(Board, Ships)
            If Not GameQuit Then
                If Not GoesLeft = -1 Then
                    If GoesLeft = 0 Then
                        Gamelost = True
                    End If
                    GoesLeft -= 1
                End If

                GameWon = CheckWin(Ships, Board)
                If GameWon Then
                    Console.WriteLine("All ships sunk!")
                    Console.WriteLine()
                ElseIf Gamelost Then
                    Console.WriteLine("Ran out of moves!")
                    Console.WriteLine()
                End If
            Else
                Console.WriteLine("Do you want to save before going back to main menu? (Y/N)")
                Console.Write("> ")
                Dim input = Console.ReadLine().ToUpper
                If input = "Y" Then
                    SaveGame(CustomGame, Board, GoesLeft)
                End If
            End If
            Console.WriteLine("Press enter to continue")
            Console.ReadLine()
            Console.Clear()
        Loop Until GameWon Or Gamelost Or GameQuit
    End Sub

    Sub SetUpShips(ByRef Ships() As TShip)
        Ships(0).Name = "Aircraft Carrier"
        Ships(0).Size = 5
        Ships(1).Name = "Battleship"
        Ships(1).Size = 4
        Ships(2).Name = "Submarine"
        Ships(2).Size = 3
        Ships(3).Name = "Destroyer"
        Ships(3).Size = 3
        Ships(4).Name = "Patrol Boat"
        Ships(4).Size = 2
        Ships(5).Name = "Rowing Boat"
        Ships(5).Size = 1
        Ships(6).Name = "Frigate"
        Ships(6).Size = 3
    End Sub

    Function getShipFromChar(ByVal Ships() As TShip, ByVal name As Char) As TShip
        For Each Ship In Ships
            If Ship.Name.StartsWith(name) Then Return Ship
        Next
        Return Nothing
    End Function

    Sub Main()
        Console.Title = "Battleship"

        Dim Board(9, 9) As Char
        Dim Ships(6) As TShip
        Dim MenuOption As Integer
        Dim GoesLeft As Integer
        Do
            SetUpBoard(Board)
            SetUpShips(Ships)
            DisplayMenu()
            MenuOption = GetMainMenuChoice()
            Console.Clear()
            If MenuOption = 1 Then
                PlaceRandomShips(Board, Ships)
                PlayGame(Board, Ships, GoesLeft)
            ElseIf MenuOption = 2 Then
                LoadGame(TrainingGame, Board, GoesLeft)
                PlayGame(Board, Ships, GoesLeft)
            ElseIf MenuOption = 3 Then
                If Not File.Exists(CustomGame) Then
                    Console.WriteLine("There is no saved game")
                    Console.WriteLine("Press enter to continue")
                    Console.ReadLine()
                Else
                    LoadGame(CustomGame, Board, GoesLeft)
                    PlayGame(Board, Ships, GoesLeft)
                End If
            ElseIf MenuOption = 8 Then
                ShowShips = Not ShowShips
            End If
        Loop Until MenuOption = 9
    End Sub
End Module