Module Module1
    Structure test
        Dim testNum As Single
        Dim testChr As Char
        Dim testSrt As String
    End Structure

    Sub Main()
        Dim testData As test
        testData.testNum = 1.25
        testData.testChr = "P"
        testData.testSrt = "Yeah! Computing"

        FileOpen(1, "BinaryTest.bin", OpenMode.Binary, OpenAccess.Write)
        FilePut(1, testData)
        FileClose(1)
    End Sub

End Module
