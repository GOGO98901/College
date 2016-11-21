Public Class Form1
    Dim NameQ(0 To 20) As String
    Dim Front As Integer
    Dim Rear As Integer
    Dim Qsize As Integer
    Dim Limit As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limit = 20
        Front = 1
        Rear = 0
        Qsize = 0
    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        Dim Counter As Integer
        Dim OutputString As String
        For Counter = 1 To 20
            OutputString = Counter & " " & NameQ(Counter)
            If Counter = Front Then
                OutputString = OutputString & " " & "Front"
            End If
            If Counter = Rear Then
                OutputString = OutputString & " " & "Rear"
            End If
            lstDisplay.Items.Add(OutputString)
        Next
    End Sub
End Class