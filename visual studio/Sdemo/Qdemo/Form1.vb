Public Class Form1

    Private proj As Example

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proj = New Example()
        proj.load()
        proj.display(lstDisplay)
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        proj.clear()
        proj.display(lstDisplay)
    End Sub

    Private Sub cmdPush_Click(sender As System.Object, e As System.EventArgs) Handles cmdPush.Click
        proj.push(txtAddItem.Text)
        proj.display(lstDisplay)
    End Sub

    Private Sub cmdPop_Click(sender As System.Object, e As System.EventArgs) Handles cmdPop.Click
        proj.remove()
        proj.display(lstDisplay)
    End Sub
End Class

Public Class Example
    Dim NameQ(0 To 20) As String
    Dim SPos As Integer
    Dim Limit As Integer

    Public Sub load()
        Limit = 20
        SPos = 0
    End Sub

    Public Sub display(box As ListBox)
        box.Items.Clear()
        Dim Counter As Integer
        Dim OutputString As String
        For Counter = 20 To 1 Step -1
            Dim StartString As String = Counter & " -->  "
            If Counter < 10 Then StartString = Counter & "  -->  "
            OutputString = StartString & NameQ(Counter)
            If SPos = Counter Then
                OutputString += "  <-- Current"
            End If
            box.Items.Add(OutputString)
        Next
    End Sub

    Public Sub push(text As String)
        If Not SPos = Limit Then
            SPos += 1
            NameQ(SPos) = text
        Else : MsgBox("Stack is full")
        End If
    End Sub

    Public Sub remove()
        If SPos > 0 Then
            SPos -= 1
        Else : MsgBox("Stack is empty")
        End If
    End Sub

    Public Sub clear()
        SPos = 0
    End Sub
End Class