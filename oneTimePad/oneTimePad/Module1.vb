Imports System.IO
Module Module1
    Dim Plaintext, Ciphertext, OneTimePad As String
    Dim choice As String

    Sub Main()
        Do
            DisplayMenu()
            choice = Console.ReadLine
            If IsNumeric(choice) Then
                If choice = 1 Then EncryptMessage()
                If choice = 2 Then DecryptMessage()
            End If
        Loop Until choice = "3"
    End Sub

    Sub DisplayMenu()
        Console.Clear()
        Console.WriteLine("1. Encrypt New Message.")
        Console.WriteLine("2. Decrypt Message.")
        Console.WriteLine("3. Quit.")
        Console.Write("Enter Choice: ")
    End Sub

    Sub EncryptMessage()
        Console.Write("Enter New Message: ")
        Plaintext = Console.ReadLine.ToUpper
        Do
            Console.Write("Enter New Key: ")
            OneTimePad = Console.ReadLine.ToUpper
            If Len(OneTimePad) < Len(Plaintext) Then Console.WriteLine("Key is not long enough!")
        Loop Until Len(OneTimePad) >= Len(Plaintext)
        Ciphertext = ""
        For counter = 0 To Len(Plaintext) - 1
            Ciphertext = Ciphertext + Chr((((Asc(Plaintext(counter)) - 64) + (Asc(OneTimePad(counter)) - 64)) Mod 26) + 64)
        Next
        Console.Write(Ciphertext)
        FileOpen(1, "Message.txt", OpenMode.Output)
        FileOpen(2, "Key.txt", OpenMode.Output)
        Print(1, Ciphertext)
        Print(2, OneTimePad)
        FileClose(1, 2)
    End Sub

    Sub DecryptMessage()
        If System.IO.File.Exists("Message.txt") Then
            If System.IO.File.Exists("Key.txt") Then
                Console.Clear()

                Dim messageE, messageD, key As String
                Using reader As StreamReader = New StreamReader("Message.txt")
                    messageE = reader.ReadLine
                End Using
                Using reader As StreamReader = New StreamReader("Key.txt")
                    key = reader.ReadLine
                End Using
                Console.WriteLine("Message: " & messageE)
                Console.WriteLine("    Key: " & key)
                'Console.WriteLine(vbCrLf & "Decrypting")

                messageD = ""
                For counter = 0 To Len(messageE) - 1
                    Dim encodedChar As Integer = Asc(messageE(counter)) - 64
                    Dim KeyChar As Integer = Asc(key(counter)) - 64

                    messageD += Chr((encodedChar - KeyChar) + 64)
                Next

                Console.WriteLine(vbCrLf & " Output: " & messageD)
            Else
                Console.WriteLine("No key found to decrypt message")
            End If
        Else
            Console.WriteLine("No message found to decrypt")
        End If
        Console.ReadLine()
    End Sub
End Module