Imports System.IO
Module Module1

    Structure test
        Dim testSrt As String
        Dim testNum As Integer
        Dim testChr As Char
    End Structure

    Sub Main()
        Dim fileName As String = "BinaryTest.bin"

        Dim recovered As New test
        Dim testData As New test
        testData.testNum = 65
        testData.testChr = "*"
        testData.testSrt = "Yeah! Computing"


        FileOpen(1, fileName, OpenMode.Binary, OpenAccess.Write)
        FilePut(1, testData)
        FileClose(1)

        Dim objBR As BinaryReader
        Dim objFS As FileStream

        objFS = New FileStream(fileName, FileMode.Open, FileAccess.Read)
        objBR = New BinaryReader(objFS)
        objBR.BaseStream.Seek(0, SeekOrigin.Begin)

        While objFS.Position < objFS.Length
            recovered = Nothing
            With recovered
                .testSrt = objBR.ReadString
                .testNum = objBR.ReadInt32
                .testChr = objBR.ReadChar
            End With
        End While
        objBR.Close()
        objFS.Close()

        Console.WriteLine(recovered)


        Console.ReadLine()
    End Sub

End Module
