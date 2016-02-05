Module Module1
    Dim Plaintext, Ciphertext, OneTimePad As String
    Dim choice As Integer

    Sub Main()
        Do
            DisplayMenu()
            choice = Console.ReadLine
            If choice = 1 Then EncryptMessage()
            If choice = 2 Then DecryptMessage()
        Loop Until choice = 3
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
            Ciphertext = Ciphertext + Chr((((asc(Plaintext(counter)) - 64) + (asc(OneTimePad(counter)) - 64)) Mod 26) + 64)
        Next
        Console.Write(Ciphertext)
        FileOpen(1, "Message.txt", OpenMode.Output)
        FileOpen(2, "Key.txt", OpenMode.Output)
        Print(1, Ciphertext)
        Print(2, OneTimePad)
        FileClose(1, 2)
    End Sub
    Sub DecryptMessage()

    End Sub
End Module