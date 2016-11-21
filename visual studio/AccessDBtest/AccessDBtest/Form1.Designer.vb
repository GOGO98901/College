<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDBCreate = New System.Windows.Forms.Button()
        Me.btnDBOpen = New System.Windows.Forms.Button()
        Me.btnDBremove = New System.Windows.Forms.Button()
        Me.btnDBclose = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnDBstudentTable = New System.Windows.Forms.Button()
        Me.btnDBexamTable = New System.Windows.Forms.Button()
        Me.btnDBresultTable = New System.Windows.Forms.Button()
        Me.btnDBaddFields = New System.Windows.Forms.Button()
        Me.StudentUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudentSurname = New System.Windows.Forms.TextBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAddExam = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.examSubject = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.examTitle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.examCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.examWeight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.examMaxScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDBCreate
        '
        Me.btnDBCreate.Location = New System.Drawing.Point(12, 12)
        Me.btnDBCreate.Name = "btnDBCreate"
        Me.btnDBCreate.Size = New System.Drawing.Size(109, 23)
        Me.btnDBCreate.TabIndex = 0
        Me.btnDBCreate.Text = "Create DataBase"
        Me.btnDBCreate.UseVisualStyleBackColor = True
        '
        'btnDBOpen
        '
        Me.btnDBOpen.Location = New System.Drawing.Point(12, 70)
        Me.btnDBOpen.Name = "btnDBOpen"
        Me.btnDBOpen.Size = New System.Drawing.Size(109, 23)
        Me.btnDBOpen.TabIndex = 1
        Me.btnDBOpen.Text = "Open DataBase"
        Me.btnDBOpen.UseVisualStyleBackColor = True
        '
        'btnDBremove
        '
        Me.btnDBremove.Location = New System.Drawing.Point(12, 41)
        Me.btnDBremove.Name = "btnDBremove"
        Me.btnDBremove.Size = New System.Drawing.Size(109, 23)
        Me.btnDBremove.TabIndex = 2
        Me.btnDBremove.Text = "Remove DataBase"
        Me.btnDBremove.UseVisualStyleBackColor = True
        '
        'btnDBclose
        '
        Me.btnDBclose.Location = New System.Drawing.Point(12, 99)
        Me.btnDBclose.Name = "btnDBclose"
        Me.btnDBclose.Size = New System.Drawing.Size(109, 23)
        Me.btnDBclose.TabIndex = 3
        Me.btnDBclose.Text = "Close DataBase"
        Me.btnDBclose.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(599, 403)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 132
        Me.LineShape2.X2 = -21
        Me.LineShape2.Y1 = 134
        Me.LineShape2.Y2 = 134
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 133
        Me.LineShape1.X2 = 133
        Me.LineShape1.Y1 = -22
        Me.LineShape1.Y2 = 428
        '
        'btnDBstudentTable
        '
        Me.btnDBstudentTable.Location = New System.Drawing.Point(15, 146)
        Me.btnDBstudentTable.Name = "btnDBstudentTable"
        Me.btnDBstudentTable.Size = New System.Drawing.Size(106, 23)
        Me.btnDBstudentTable.TabIndex = 5
        Me.btnDBstudentTable.Text = "Add Student Table"
        Me.btnDBstudentTable.UseVisualStyleBackColor = True
        '
        'btnDBexamTable
        '
        Me.btnDBexamTable.Location = New System.Drawing.Point(15, 175)
        Me.btnDBexamTable.Name = "btnDBexamTable"
        Me.btnDBexamTable.Size = New System.Drawing.Size(106, 23)
        Me.btnDBexamTable.TabIndex = 6
        Me.btnDBexamTable.Text = "Add Exam Table"
        Me.btnDBexamTable.UseVisualStyleBackColor = True
        '
        'btnDBresultTable
        '
        Me.btnDBresultTable.Location = New System.Drawing.Point(15, 204)
        Me.btnDBresultTable.Name = "btnDBresultTable"
        Me.btnDBresultTable.Size = New System.Drawing.Size(106, 23)
        Me.btnDBresultTable.TabIndex = 7
        Me.btnDBresultTable.Text = "Add Result Table"
        Me.btnDBresultTable.UseVisualStyleBackColor = True
        '
        'btnDBaddFields
        '
        Me.btnDBaddFields.Location = New System.Drawing.Point(15, 233)
        Me.btnDBaddFields.Name = "btnDBaddFields"
        Me.btnDBaddFields.Size = New System.Drawing.Size(106, 23)
        Me.btnDBaddFields.TabIndex = 8
        Me.btnDBaddFields.Text = "Add extra Fields"
        Me.btnDBaddFields.UseVisualStyleBackColor = True
        '
        'StudentUsername
        '
        Me.StudentUsername.Location = New System.Drawing.Point(248, 13)
        Me.StudentUsername.Name = "StudentUsername"
        Me.StudentUsername.Size = New System.Drawing.Size(100, 20)
        Me.StudentUsername.TabIndex = 9
        Me.StudentUsername.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Student Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Student First Name"
        '
        'StudentFirstName
        '
        Me.StudentFirstName.Location = New System.Drawing.Point(248, 37)
        Me.StudentFirstName.Name = "StudentFirstName"
        Me.StudentFirstName.Size = New System.Drawing.Size(100, 20)
        Me.StudentFirstName.TabIndex = 11
        Me.StudentFirstName.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Student Surname"
        '
        'StudentSurname
        '
        Me.StudentSurname.Location = New System.Drawing.Point(248, 63)
        Me.StudentSurname.Name = "StudentSurname"
        Me.StudentSurname.Size = New System.Drawing.Size(100, 20)
        Me.StudentSurname.TabIndex = 13
        Me.StudentSurname.Tag = ""
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(248, 89)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(100, 23)
        Me.btnAddStudent.TabIndex = 15
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnAddExam
        '
        Me.btnAddExam.Location = New System.Drawing.Point(463, 138)
        Me.btnAddExam.Name = "btnAddExam"
        Me.btnAddExam.Size = New System.Drawing.Size(100, 23)
        Me.btnAddExam.TabIndex = 22
        Me.btnAddExam.Text = "Add Exam"
        Me.btnAddExam.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Subject"
        '
        'examSubject
        '
        Me.examSubject.Location = New System.Drawing.Point(463, 60)
        Me.examSubject.Name = "examSubject"
        Me.examSubject.Size = New System.Drawing.Size(100, 20)
        Me.examSubject.TabIndex = 20
        Me.examSubject.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Exam Title"
        '
        'examTitle
        '
        Me.examTitle.Location = New System.Drawing.Point(463, 34)
        Me.examTitle.Name = "examTitle"
        Me.examTitle.Size = New System.Drawing.Size(100, 20)
        Me.examTitle.TabIndex = 18
        Me.examTitle.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Exam Code"
        '
        'examCode
        '
        Me.examCode.Location = New System.Drawing.Point(463, 10)
        Me.examCode.Name = "examCode"
        Me.examCode.Size = New System.Drawing.Size(100, 20)
        Me.examCode.TabIndex = 16
        Me.examCode.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(416, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Weight"
        '
        'examWeight
        '
        Me.examWeight.Location = New System.Drawing.Point(463, 86)
        Me.examWeight.Name = "examWeight"
        Me.examWeight.Size = New System.Drawing.Size(100, 20)
        Me.examWeight.TabIndex = 23
        Me.examWeight.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Max Score"
        '
        'examMaxScore
        '
        Me.examMaxScore.Location = New System.Drawing.Point(463, 112)
        Me.examMaxScore.Name = "examMaxScore"
        Me.examMaxScore.Size = New System.Drawing.Size(100, 20)
        Me.examMaxScore.TabIndex = 25
        Me.examMaxScore.Tag = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 403)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.examMaxScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.examWeight)
        Me.Controls.Add(Me.btnAddExam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.examSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.examTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.examCode)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentSurname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StudentFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StudentUsername)
        Me.Controls.Add(Me.btnDBaddFields)
        Me.Controls.Add(Me.btnDBresultTable)
        Me.Controls.Add(Me.btnDBexamTable)
        Me.Controls.Add(Me.btnDBstudentTable)
        Me.Controls.Add(Me.btnDBclose)
        Me.Controls.Add(Me.btnDBremove)
        Me.Controls.Add(Me.btnDBOpen)
        Me.Controls.Add(Me.btnDBCreate)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDBCreate As System.Windows.Forms.Button
    Friend WithEvents btnDBOpen As System.Windows.Forms.Button
    Friend WithEvents btnDBremove As System.Windows.Forms.Button
    Friend WithEvents btnDBclose As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnDBstudentTable As System.Windows.Forms.Button
    Friend WithEvents btnDBexamTable As System.Windows.Forms.Button
    Friend WithEvents btnDBresultTable As System.Windows.Forms.Button
    Friend WithEvents btnDBaddFields As System.Windows.Forms.Button
    Friend WithEvents StudentUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StudentFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StudentSurname As System.Windows.Forms.TextBox
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents btnAddExam As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents examSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents examTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents examCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents examWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents examMaxScore As System.Windows.Forms.TextBox

End Class
