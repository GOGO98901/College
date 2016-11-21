Public Class Form1

    Private proj As Example

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proj = New Example()
        proj.load()
        proj.display(lstDisplay)
    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        proj.display(lstDisplay)
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        proj.add(txtAddItem.Text)
        proj.display(lstDisplay)
    End Sub

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click
        proj.remove()
        proj.display(lstDisplay)
    End Sub
End Class

Public Class Example
    Dim NameQ(0 To 20) As String
    Dim Front As Integer
    Dim Rear As Integer
    Dim Qsize As Integer
    Dim Limit As Integer

    Public Sub load()
        Limit = 20
        Front = 1
        Rear = 0
        Qsize = 0
    End Sub

    Public Sub display(box As ListBox)
        box.Items.Clear()
        Dim Counter As Integer
        Dim OutputString As String
        For Counter = 1 To 20
            Dim StartString As String = Counter & " -->  "
            If Counter < 10 Then StartString = Counter & "  -->  "
            OutputString = StartString & NameQ(Counter)
            If Counter = Front Then
                OutputString = OutputString & " " & " <-- Front"
            End If
            If Counter = Rear Then
                OutputString = OutputString & " " & " <-- Rear"
            End If
            box.Items.Add(OutputString)
        Next
    End Sub

    Public Sub add(text As String)
        If Not Qsize = Limit Then
            If Rear = Limit Then
                Rear = 1
            Else
                Rear += 1
            End If
            Qsize += 1
            NameQ(Rear) = text
        Else : MsgBox("Queue is full")
        End If
    End Sub

    Public Sub remove()
        If Qsize > 0 Then
            If Front = Limit Then
                Front = 1
            Else
                Front += 1
            End If
            Qsize -= 1
        Else : MsgBox("Queue is empty")
        End If
    End Sub
End Class