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

    Private Sub btnAddStudent_Click(sender As System.Object, e As System.EventArgs) Handles btnAddStudent.Click
        Dim status As Boolean = data.InsertRecord("Students", "[Username], [FirstName], [Surname]", "'" & StudentUsername.Text & "','" & StudentFirstName.Text & "','" & StudentSurname.Text & "'")
        If status Then
            StudentUsername.Text = ""
            StudentFirstName.Text = ""
            StudentSurname.Text = ""
        End If
    End Sub

    Private Sub btnAddExam_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExam.Click
        Dim status As Boolean = data.InsertRecord("Exams", "[ExamCode], [ExamTitle], [Subject], [Weight], [MaxScore]", "'" & examCode.Text & "','" & examTitle.Text & "','" & examSubject.Text & "','" & examWeight.Text & "','" & examMaxScore.Text & "'")
        If status Then
            examCode.Text = ""
            examTitle.Text = ""
            examSubject.Text = ""
            examWeight.Text = ""
            examMaxScore.Text = ""
        End If
    End Sub
End Class

Class DataBase
    Const DataBaseFileName As String = "Test.mdb"
    Dim mycommand As OleDbCommand
    Dim myconnection As OleDbConnection
    Dim myReader As OleDbDataReader
    Dim SQLstr As String

    Function CreateDataBase() As Boolean
        Dim cat As Catalog = New Catalog()
        Try
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseFileName & ";Jet OLEDB:Engine Type=5")
            cat = Nothing
            MsgBox("Database Created Successfully")
            Return True
        Catch ex As Exception
            MsgBox("Database Creation failed " & ex.Message)
            Return False
        End Try
    End Function

    Function RemoveDataBase() As Boolean
        Try
            System.IO.File.Delete(DataBaseFileName)
            MsgBox("DataBase Deleted")
            Return True
        Catch ex As Exception
            MsgBox("Database not Deleted " & ex.Message)
            Return False
        End Try
    End Function

    Function OpenDataBase() As Boolean
        Try
            myconnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseFileName)
            myconnection.Open()
            MsgBox("Database Opened Successfully")
            Return True
        Catch ex As Exception
            MsgBox("Database not opened " & ex.Message)
            Return False
        End Try
    End Function

    Function CloseDataBase() As Boolean
        Try
            myconnection.Close()
            MsgBox("Database Closed Successfully")
            Return True
        Catch ex As Exception
            MsgBox("Database not Closed " & ex.Message)
            Return False
        End Try
    End Function

    Function AddTableStudent() As Boolean
        Try
            RunNonQuery("CREATE TABLE [Students] ([Username] Varchar(20) CONSTRAINT PrimaryKey PRIMARY KEY, [FirstName] Varchar(25), [Surname] Varchar(25))")
            MsgBox("Students Table created")
            Return True
        Catch ex As Exception
            MsgBox("Students Table not Created " & ex.Message)
            Return False
        End Try
    End Function

    Function AddTableExam() As Boolean
        Try
            RunNonQuery("CREATE TABLE [Exams] ([ExamCode] Varchar(6) CONSTRAINT PrimaryKey PRIMARY KEY, [ExamTitle] Varchar(25), [Subject] Varchar(25))")
            MsgBox("Exams Table created")
            Return True
        Catch ex As Exception
            MsgBox("Exams Table not Created " & ex.Message)
            Return False
        End Try
    End Function

    Function AddTableResults() As Boolean
        Try
            RunNonQuery("CREATE TABLE [Results] ([ResultID] Varchar(6) CONSTRAINT PrimaryKey PRIMARY KEY, [UserName] Varchar(20), [ExamCode] Varchar(6), [Score] Int)")
            MsgBox("Results Table created")
            Return True
        Catch ex As Exception
            MsgBox("Results Table not Created " & ex.Message)
            Return False
        End Try
    End Function

    Function CreateField(Table As String, Command As String) As Boolean
        Try
            RunNonQuery("ALTER TABLE [" & Table & "] ADD COLUMN " & Command)
            MsgBox("Field Added Sucessfully '" & Command & "'")
            Return True
        Catch ex As Exception
            MsgBox("Field NOT Added Sucessfully '" & Command & "' " & ex.Message)
            Return False
        End Try
    End Function

    Function InsertRecord(Table As String, Cells As String, Values As String) As Boolean
        Try
            RunNonQuery("INSERT INTO " & Table & "(" & Cells & ") VALUES (" & Values & ")")
            MsgBox("Record Added Sucessfully")
            Return True
        Catch ex As Exception
            MsgBox("Record NOT Added Sucessfully '" & Command() & "' " & ex.Message)
            Return False
        End Try
    End Function

    Sub RunNonQuery(DDLstr As String)
        mycommand = New OleDb.OleDbCommand(DDLstr, myconnection)
        mycommand.ExecuteNonQuery()
    End Sub
End Class