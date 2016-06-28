Imports ADOX
Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Dim data As New DataBase()
    Private Sub btnDataBaseCreate(sender As System.Object, e As System.EventArgs) Handles btnDBCreate.Click
        data.CreateDataBase()
    End Sub

    Private Sub btnDataBaseRemove(sender As System.Object, e As System.EventArgs) Handles btnDBremove.Click
        data.RemoveDataBase()
    End Sub

    Private Sub btnDataBaseOpen(sender As System.Object, e As System.EventArgs) Handles btnDBOpen.Click
        data.OpenDataBase()
    End Sub

    Private Sub btnDataBaseClose(sender As System.Object, e As System.EventArgs) Handles btnDBclose.Click
        data.CloseDataBase()
    End Sub

    Private Sub btnDataBaseAddStudentTable(sender As System.Object, e As System.EventArgs) Handles btnDBstudentTable.Click
        data.AddTableStudent()
    End Sub

    Private Sub btnDataBaseAddExamTable(sender As System.Object, e As System.EventArgs) Handles btnDBexamTable.Click
        data.AddTableExam()
    End Sub

    Private Sub btnDataBaseAddResultTable(sender As System.Object, e As System.EventArgs) Handles btnDBresultTable.Click
        data.AddTableResults()
    End Sub

    Private Sub btnDataBaseAddFields(sender As System.Object, e As System.EventArgs) Handles btnDBaddFields.Click
        data.CreateField("Exams", "[MaxScore] Int")
        data.CreateField("Students", "[DateofBirth] Varchar(20)")
        data.CreateField("Students", "[Gender] Varchar(20)")
        data.CreateField("Results", "[ExamDate] Int")
    End Sub
End Class

Class DataBase
    Const DataBaseFileName As String = "Test.mdb"
    Dim mycommand As OleDbCommand
    Dim myconnection As OleDbConnection
    Dim myReader As OleDbDataReader
    Dim SQLstr As String

    Sub CreateDataBase()
        Dim cat As Catalog = New Catalog()
        Try
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseFileName & ";Jet OLEDB:Engine Type=5")
            MsgBox("Database Created Successfully")
        Catch ex As Exception
            MsgBox("Database Creation failed " & ex.Message)
        End Try
        cat = Nothing
    End Sub

    Sub RemoveDataBase()
        Try
            System.IO.File.Delete(DataBaseFileName)
            MsgBox("DataBase Deleted")
        Catch ex As Exception
            MsgBox("Database not Deleted " & ex.Message)
        End Try
    End Sub

    Sub OpenDataBase()
        Try
            myconnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseFileName)
            myconnection.Open()
            MsgBox("Database Opened Successfully")
        Catch ex As Exception
            MsgBox("Database not opened " & ex.Message)
        End Try
    End Sub

    Sub CloseDataBase()
        Try
            myconnection.Close()
            MsgBox("Database Closed Successfully")
        Catch ex As Exception
            MsgBox("Database not Closed " & ex.Message)
        End Try
    End Sub

    Sub AddTableStudent()
        Try
            RunNonQuery("CREATE TABLE [Students] ([Username] Varchar(20) CONSTRAINT PrimaryKey PRIMARY KEY, [FirstName] Varchar(25), [Surname] Varchar(25))")
            MsgBox("Students Table created")
        Catch ex As Exception
            MsgBox("Students Table not Created " & ex.Message)
        End Try
    End Sub

    Sub AddTableExam()
        Try
            RunNonQuery("CREATE TABLE [Exams] ([ExamCode] Varchar(6) CONSTRAINT PrimaryKey PRIMARY KEY, [ExamTitle] Varchar(25), [Subject] Varchar(25))")
            MsgBox("Exams Table created")
        Catch ex As Exception
            MsgBox("Exams Table not Created " & ex.Message)
        End Try
    End Sub

    Sub AddTableResults()
        Try
            RunNonQuery("CREATE TABLE [Results] ([ResultID] Varchar(6) CONSTRAINT PrimaryKey PRIMARY KEY, [UserName] Varchar(20), [ExamCode] Varchar(6), [Score] Int)")
            MsgBox("Results Table created")
        Catch ex As Exception
            MsgBox("Results Table not Created " & ex.Message)
        End Try
    End Sub

    Sub CreateField(Table As String, Command As String)
        Try
            RunNonQuery("ALTER TABLE [" & Table & "] ADD COLUMN " & Command)
            MsgBox("Field Added Sucessfully '" & Command & "'")
        Catch ex As Exception
            MsgBox("Field NOT Added Sucessfully '" & Command & "' " & ex.Message)
        End Try
    End Sub

    Sub RunNonQuery(DDLstr As String)
        mycommand = New OleDb.OleDbCommand(DDLstr, myconnection)
        mycommand.ExecuteNonQuery()
    End Sub
End Class