Imports ADOX
Imports System.Data.OleDb
Imports System.IO
'needs ACE installed
'needs microsoft ado ext 6.0 for dll and security ref
'Assumes MusicRelationship database is in H:/
Module Module1

    Sub Main()
        Dim bob As New MusicConnection
        Dim Artlist As List(Of Artist)
        Dim Alblist As List(Of Album)
        Dim CDList As List(Of CD)
        bob.OpenDataBase()
        Artlist = bob.sqlArtistSelectToList()
        Alblist = bob.sqlArtistAlbumsSelectToList()
        CDList = bob.sqlCDSelectToList()

        For Each Alb In Alblist
            Console.WriteLine(Alb.getArtistName & " " & Alb.getAlbumName)
        Next
        Console.WriteLine()

        For Each Arti In Artlist
            Console.WriteLine(Arti.getArtistName & " " & Arti.getID)
        Next
        Console.WriteLine()
        For Each cdli In CDList
            Console.WriteLine(cdli.getAlbumName & " by " & cdli.getArtist & ", has " & cdli.getNumberOfTracks & " track(s)")
        Next

        Console.WriteLine()
        Console.WriteLine("The following artists have more than 10 tracks in albums")
        For Each art In getArtistsWithMoreThan10Tracks(Alblist, Artlist)
            Console.WriteLine(art.getArtistName & " " & art.getID)
        Next
        bob.close()
        Console.ReadLine()
    End Sub

    Function getArtistsWithMoreThan10Tracks(ByVal Alblist As List(Of Album), ByVal Artlist As List(Of Artist)) As List(Of Artist)
        Dim objArtists As New List(Of Artist)
        For Each album In Alblist
            Dim tracks = album.getTracks
            If tracks >= 10 Then
                Dim artistId = album.getID
                For Each aArtist In Artlist
                    If aArtist.getID = artistId Then
                        objArtists.Add(aArtist)
                    End If
                Next
            End If
        Next
        Return objArtists
    End Function


    Sub openExplorer()
        Dim TheBrowser As Object = CreateObject("InternetExplorer.Application")
        TheBrowser.Visible = True
        TheBrowser.Navigate("www.google.com")
        Console.ReadLine()
    End Sub
End Module
Class MusicConnection
    'connects to the database
    Private connString As String
    Dim mycommand As OleDbCommand
    Dim myconnection As OleDbConnection
    Dim dr As OleDbDataReader
    Dim DDLstr As String
    Dim SQLstr As String
    Dim objArtists As New List(Of Artist)
    Dim objAlbums As New List(Of Album)
    Dim objCds As New List(Of CD)
    Sub OpenDataBase()
        Try ' Provider=Microsoft.JET.OLEDB.4.0 for mdb  .ACE.OLEDB.12.0 for accdb
            myconnection = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=MusicRelationships.mdb") ' this might be a nightmare!
            myconnection.Open()
            Console.WriteLine("Database Opened Successfully")
        Catch ex As Exception
            Console.WriteLine("Database not opened " & ex.Message)
        End Try

    End Sub
    Function sqlArtistSelectToList() As List(Of Artist) ' returns a list use this as a template
        Dim j As Integer = 0
        Try
            mycommand = New OleDbCommand("SELECT [Artistname], [ArtistID]  from ArtistDetails ", myconnection)
            dr = mycommand.ExecuteReader()
            While dr.HasRows
                While dr.Read
                    objArtists.Add(New Artist)
                    With objArtists(j)
                        .setArtistName(dr("ArtistName"))
                        .setID(dr("ArtistID"))
                    End With
                    j = j + 1
                    'Console.WriteLine(dr("yyy") & " " & dr("xxx")) ' output just for testing if something going wrong
                End While
                dr.NextResult()
            End While
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Return objArtists
    End Function
    Function sqlArtistAlbumsSelectToList() As List(Of Album) ' returns a list use this as a template
        Dim j As Integer = 0
        Try
            mycommand = New OleDbCommand("SELECT ArtistDetails.ArtistName, AlbumTitles.[Album title], AlbumTitles.[Release date], AlbumTitles.[Number of tracks], AlbumTitles.ArtistID FROM ArtistDetails INNER JOIN AlbumTitles ON ArtistDetails.ArtistID = AlbumTitles.ArtistID ORDER BY ArtistDetails.ArtistName;", myconnection)
            dr = mycommand.ExecuteReader()
            While dr.HasRows
                While dr.Read
                    objAlbums.Add(New Album)
                    With objAlbums(j)
                        .setArtistName(dr("ArtistName"))
                        .setID(dr("ArtistID"))
                        .setAlbumName(dr("Album title"))
                        .setTracks(dr("Number of tracks"))
                    End With
                    j = j + 1
                    'Console.WriteLine(dr("yyy") & " " & dr("xxx")) ' output just for testing if something going wrong
                End While
                dr.NextResult()
            End While
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Return objAlbums
    End Function
    Function sqlCDSelectToList() As List(Of CD) ' returns a list use this as a template
        Dim j As Integer = 0
        Try
            mycommand = New OleDbCommand("SELECT CDList.Artist, CDList.[Album title], CDList.[Number of tracks] FROM CDList;", myconnection)
            dr = mycommand.ExecuteReader()
            While dr.HasRows
                While dr.Read
                    objCds.Add(New CD)
                    With objCds(j)
                        .setArtist(dr("Artist"))
                        .setAlbumName(dr("Album title"))
                        .setNumberOfTracks(dr("Number of tracks"))
                    End With
                    j = j + 1
                    'Console.WriteLine(dr("yyy") & " " & dr("xxx")) ' output just for testing if something going wrong
                End While
                dr.NextResult()
            End While
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Return objCds
    End Function

    Sub close()
        myconnection.Close()
    End Sub


End Class
Class Artist ' an adt 
    Private ID As String
    Private ArtistName As String
    'Getters

    Public Function getID() As String
        Return ID
    End Function
    Public Function getArtistName() As String
        Return ArtistName
    End Function
    'Setters
    Public Sub setID(ByVal value As String)
        ID = value
    End Sub
    Public Sub setArtistName(ByVal value As String)
        ArtistName = value
    End Sub

End Class

Class Album ' an adt 
    Private ID As String
    Private AlbumName As String
    Private ArtistName As String
    Private tracks As Integer

    Public Function getID() As String
        Return ID
    End Function
    Public Function getAlbumName() As String
        Return AlbumName
    End Function

    Public Sub setID(ByVal value As String)
        ID = value
    End Sub
    Public Sub setAlbumName(ByVal value As String)
        AlbumName = value
    End Sub
    Public Function getArtistName() As String
        Return ArtistName
    End Function
    Public Sub setArtistName(ByVal value As String)
        ArtistName = value
    End Sub
    Public Sub setTracks(ByVal value As Integer)
        tracks = value
    End Sub
    Public Function getTracks() As String
        Return tracks
    End Function

End Class

Class CD
    Private Artist As String
    Private AlbumName As String
    Private NumberOfTracks As Integer

    Public Function getArtist() As String
        Return Artist
    End Function
    Public Sub setArtist(ByVal value As String)
        Artist = value
    End Sub

    Public Function getAlbumName() As String
        Return AlbumName
    End Function
    Public Sub setAlbumName(ByVal value As String)
        AlbumName = value
    End Sub

    Public Function getNumberOfTracks() As Integer
        Return NumberOfTracks
    End Function
    Public Sub setNumberOfTracks(ByVal value As Integer)
        NumberOfTracks = value
    End Sub
End Class



'Public Class output to HTML

'    Dim dt As New DataTable

'    public Sub BuildDataTable
'        dt.Columns.Add("c1")
'        dt.Columns.Add("c2")
'        dt.Columns.Add("c3")
'        dt.Columns.Add("c4")
'        dt.Columns.Add("c5")

'        For r As Integer = 1 To 10
'            dt.Rows.Add(New Object() {"r" & r.ToString & "c1", "r" & r.ToString & "c2", "r" & r.ToString & "c3", "r" & r.ToString & "c4", "r" & r.ToString & "c5"})
'        Next

'    End Sub

'    Private Sub CreateHTMLTable
'        Dim strBuilder As New System.Text.StringBuilder
'        strBuilder.Append("<table border='1' cellpadding='10' cellspacing='0'>")
'        For x As Integer = 0 To dt.Rows.Count - 1
'            strBuilder.Append("<tr>") 'Start the row 
'            strBuilder.Append(String.Format("<td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td>", _
'                          dt.Rows(x).Item(0).ToString, dt.Rows(x).Item(1).ToString, dt.Rows(x).Item(2).ToString, dt.Rows(x).Item(3).ToString, dt.Rows(x).Item(4).ToString))
'            strBuilder.Append("</tr>")  'Finish the row 
'        Next
'        WebBrowser1.DocumentText = strBuilder.ToString
'        'alternatively you can save strBuilder.ToString as html + show it in ie
'    End Sub

'End Class