'Skeleton Program code for the AQA COMP1 Summer 2013 examination
'this code should be used in conjunction with the Preliminary Material
'written by the AQA COMP1 Programmer Team
'developed in the Visual Studio 2008 (Console Mode) programming environment (VB.NET)

Module Module1
    Sub Main()
        Dim Ciphertext As String
        Dim Plaintext As String
        Dim Choice As Char
        Dim AmountToShift As Integer
        Dim StartPosition As Integer
        Dim EndPosition As Integer
        Dim SizeOfRailFence As Integer
        Dim N As Integer
        Ciphertext = ""
        Plaintext = ""
        Console.Title = "Skeleton Program code for the AQA COMP1 Summer 2013 examination"
        Do
            DisplayMenu()
            Choice = GetMenuChoice()
            Select Case Choice
                Case "a"
                    Plaintext = GetTextFromUser()
                Case "b"
                    DisplayPlaintext(Plaintext)
                Case "d"
                    Ciphertext = GetTextFromUser()
                Case "e"
                    DisplayCiphertext(Ciphertext)
                Case "g"
                    DisplayPlaintext(Plaintext)
                    AmountToShift = GetKeyForCaesarCipher()
                    Ciphertext = UseCaesarCipher(Plaintext, AmountToShift)
                    DisplayCiphertext(Ciphertext)
                Case "h"
                    DisplayPlaintext(Plaintext)
                    SizeOfRailFence = GetSizeOfRailFence()
                    Ciphertext = EncryptUsingRailFence(Plaintext, SizeOfRailFence)
                    DisplayCiphertext(Ciphertext)
                Case "j"
                    DisplayCiphertext(Ciphertext)
                    AmountToShift = -GetKeyForCaesarCipher()
                    Plaintext = UseCaesarCipher(Ciphertext, AmountToShift)
                    DisplayPlaintext(Plaintext)
                Case "k"
                    DisplayCiphertext(Ciphertext)
                    SizeOfRailFence = GetSizeOfRailFence()
                    Plaintext = DecryptUsingRailFence(Ciphertext, SizeOfRailFence)
                    DisplayPlaintext(Plaintext)
                Case "n"
                    GetPositionsToUse(StartPosition, EndPosition)
                    N = GetValueForN()
                    Plaintext = EveryNthCharacterSteganography(StartPosition, EndPosition, N)
                    DisplayPlaintext(Plaintext)
            End Select
            If Choice <> "q" Then
                Console.WriteLine("Press enter key to continue")
                Console.ReadLine()
            End If
        Loop Until Choice = "q"
    End Sub

    Sub DisplayMenu()
        Console.Clear()
        Console.WriteLine("PLAINTEXT OPTIONS")
        Console.WriteLine("  a.  Get plaintext from user")
        Console.WriteLine("  b.  Display plaintext")
        Console.WriteLine("CIPHERTEXT OPTIONS")
        Console.WriteLine("  d.  Get ciphertext from user")
        Console.WriteLine("  e.  Display ciphertext")
        Console.WriteLine("ENCRYPT")
        Console.WriteLine("  g.  Caesar cipher")
        Console.WriteLine("  h.  Rail fence")
        Console.WriteLine("DECRYPT")
        Console.WriteLine("  j.  Caesar cipher")
        Console.WriteLine("  k.  Rail fence")
        Console.WriteLine("STEGANOGRAPHY")
        Console.WriteLine("  n.  nth character (text from file)")
        Console.WriteLine()
        Console.Write("Please select an option from the above list (or enter q to quit): ")
    End Sub

    Function GetMenuChoice() As Char
        Dim MenuChoice As Char
        MenuChoice = Console.ReadLine
        Console.WriteLine()
        GetMenuChoice = MenuChoice
    End Function

    Function GetTextFromUser() As String
        Dim TextFromUser As String
        Console.Write("Please enter the text to use: ")
        TextFromUser = Console.ReadLine
        GetTextFromUser = TextFromUser
    End Function

    Sub GetPositionsToUse(ByRef StartPosition As Integer, ByRef EndPosition As Integer)
        Console.Write("Please enter the start position to use in the file: ")
        StartPosition = Console.ReadLine
        Console.Write("Please enter the end position to use in the file: ")
        EndPosition = Console.ReadLine
    End Sub

    Function GetTextFromFile(ByVal StartPosition As Integer, ByVal EndPosition As Integer) As String
        Dim CharacterFromFile As Char
        Dim TextFromFile As String
        Dim Count As Integer
        FileOpen(1, "diary.txt", OpenMode.Binary)
        For Count = 1 To StartPosition - 1
            FileGet(1, CharacterFromFile)
        Next
        TextFromFile = ""
        For Count = StartPosition To EndPosition
            FileGet(1, CharacterFromFile)
            TextFromFile = TextFromFile & CharacterFromFile
        Next
        FileClose(1)
        GetTextFromFile = TextFromFile
    End Function

    Function GetKeyForCaesarCipher() As Integer
        Dim Key As Integer
        Console.Write("Enter the amount that shifts the plaintext alphabet to the ciphertext alphabet: ")
        Key = Console.ReadLine
        GetKeyForCaesarCipher = Key
    End Function

    Function GetTypeOfCharacter(ByVal ASCIICode As Integer) As String
        Dim TypeOfCharacter As String
        If ASCIICode >= Asc("A") And ASCIICode <= Asc("Z") Then
            TypeOfCharacter = "Upper"
        Else
            If ASCIICode >= Asc("a") And ASCIICode <= Asc("z") Then
                TypeOfCharacter = "Lower"
            Else
                TypeOfCharacter = "Other"
            End If
        End If
        GetTypeOfCharacter = TypeOfCharacter
    End Function

    Function ApplyShiftToASCIICodeForCharacter(ByVal ASCIICode As Integer, ByVal AmountToShift As Integer) As Integer
        Dim NewASCIICode As Integer
        Dim TypeOfCharacter As String
        TypeOfCharacter = GetTypeOfCharacter(ASCIICode)
        If TypeOfCharacter <> "Other" Then
            If TypeOfCharacter = "Upper" Then
                NewASCIICode = ((26 + ASCIICode - Asc("A") + AmountToShift) Mod 26) + Asc("A")
            Else
                NewASCIICode = ((26 + ASCIICode - Asc("a") + AmountToShift) Mod 26) + Asc("a")
            End If
        Else
            NewASCIICode = ASCIICode
        End If
        ApplyShiftToASCIICodeForCharacter = NewASCIICode
    End Function

    Function UseCaesarCipher(ByVal OriginalText As String, ByVal AmountToShift As Integer) As String
        Dim ChangedText As String
        Dim Count As Integer
        Dim ASCIICode As Integer
        ChangedText = ""
        For Count = 0 To OriginalText.Length - 1
            ASCIICode = Asc(OriginalText(Count))
            ASCIICode = ApplyShiftToASCIICodeForCharacter(ASCIICode, AmountToShift)
            ChangedText = ChangedText & Chr(ASCIICode)
        Next
        UseCaesarCipher = ChangedText
    End Function

    Function GetSizeOfRailFence() As Integer
        Dim SizeOfRailFence As Integer
        Console.Write("Enter the number of lines in the rail fence: ")
        SizeOfRailFence = Console.ReadLine
        GetSizeOfRailFence = SizeOfRailFence
    End Function

    Function EncryptUsingRailFence(ByVal OriginalText As String, ByVal SizeOfRailFence As Integer) As String
        Dim Count1 As Integer
        Dim Count2 As Integer
        Dim Ciphertext As String
        Ciphertext = ""
        For Count1 = 1 To SizeOfRailFence
            Count2 = Count1 - 1
            While Count2 < OriginalText.Length
                Ciphertext = Ciphertext & OriginalText(Count2)
                Count2 = Count2 + SizeOfRailFence
            End While
        Next
        EncryptUsingRailFence = Ciphertext
    End Function

    Function DecryptUsingRailFence(ByVal Ciphertext As String, ByVal SizeOfRailFence As Integer) As String
        Dim Plaintext As String
        Dim NoOfColumns As Integer
        Dim NoOfRows As Integer
        Dim NoOfCiphertextCharacters As Integer
        Dim NoOfCiphertextCharactersProcessed As Integer
        Dim i As Integer
        Dim j As Integer
        Dim PositionOfNextCharacter As Integer
        Dim LastFullRowNo As Integer
        Dim AmountToReduceNoOfColumnsTimesjBy As Integer
        Dim BeginningOfNextRowIndex As Integer
        Plaintext = ""
        NoOfCiphertextCharacters = Ciphertext.Length
        'The ciphertext was created from a visualisation of the plaintext as
        'a two-dimensional grid of characters with no of rows = size of rail fence
        NoOfRows = SizeOfRailFence
        NoOfColumns = NoOfCiphertextCharacters \ SizeOfRailFence
        'If NoOfCiphertextCharacters divides exactly all rows will be full
        'otherwise the last column will be incomplete and NoOfColumns will not include last column
        If NoOfCiphertextCharacters Mod SizeOfRailFence <> 0 Then
            NoOfColumns = NoOfColumns + 1
        End If
        'Calculate row no of last full row, 0 means every row full
        LastFullRowNo = NoOfCiphertextCharacters Mod SizeOfRailFence
        NoOfCiphertextCharactersProcessed = 0
        For i = 1 To NoOfColumns 'Work along the columns building the plaintext a column at a time
            AmountToReduceNoOfColumnsTimesjBy = 0
            For j = 0 To NoOfRows - 1   'Work down the rows building the plaintext
                If LastFullRowNo <> 0 Then  'Last column doesn't have a character in every row
                    If j > LastFullRowNo Then 'There are shorter rows to skip
                        AmountToReduceNoOfColumnsTimesjBy = AmountToReduceNoOfColumnsTimesjBy + 1
                    End If
                End If
                'NoOfColumns * j locates in ciphertext beginning of each row
                BeginningOfNextRowIndex = NoOfColumns * j - AmountToReduceNoOfColumnsTimesjBy
                PositionOfNextCharacter = BeginningOfNextRowIndex + i - 1
                NoOfCiphertextCharactersProcessed = NoOfCiphertextCharactersProcessed + 1
                If NoOfCiphertextCharactersProcessed <= NoOfCiphertextCharacters Then
                    Plaintext = Plaintext + Ciphertext(PositionOfNextCharacter)
                End If
            Next
        Next
        DecryptUsingRailFence = Plaintext
    End Function

    Function GetValueForN() As Integer
        Dim N As Integer
        Console.Write("Enter the value of n: ")
        N = Console.ReadLine
        GetValueForN = N
    End Function

    Function EveryNthCharacterSteganography(ByVal StartPosition As Integer, ByVal EndPosition As Integer, ByVal N As Integer) As String
        Dim HiddenMessage As String
        Dim CurrentPosition As Integer
        CurrentPosition = StartPosition
        HiddenMessage = ""
        While CurrentPosition <= EndPosition
            HiddenMessage = HiddenMessage & GetTextFromFile(CurrentPosition, CurrentPosition)
            CurrentPosition = CurrentPosition + N
        End While
        EveryNthCharacterSteganography = HiddenMessage
    End Function

    Sub DisplayPlaintext(ByVal TextToDisplay As String)
        Console.WriteLine()
        Console.Write("The plaintext is: ")
        Console.WriteLine(TextToDisplay)
    End Sub

    Sub DisplayCiphertext(ByVal TextToDisplay As String)
        Console.WriteLine()
        Console.Write("The ciphertext is: ")
        Console.WriteLine(TextToDisplay)
    End Sub
End Module