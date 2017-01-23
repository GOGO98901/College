Module Module1

    Sub Main()
        Dim Cities As New Dictionary(Of String, String)
        Cities.Add("London", "England")
        Cities.Add("Manchester", "England")
        Cities.Add("Paris", "France")
        Cities.Add("Birmingham", "England")
        Cities.Add("Madrid", "Spain")

        Console.WriteLine(Cities)
        Console.ReadKey()

    End Sub

End Module
