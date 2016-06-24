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
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnDBstudentTable = New System.Windows.Forms.Button()
        Me.btnDBexamTable = New System.Windows.Forms.Button()
        Me.btnDBresultTable = New System.Windows.Forms.Button()
        Me.btnDBaddFields = New System.Windows.Forms.Button()
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(599, 403)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
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
        Me.btnDBstudentTable.Location = New System.Drawing.Point(147, 11)
        Me.btnDBstudentTable.Name = "btnDBstudentTable"
        Me.btnDBstudentTable.Size = New System.Drawing.Size(106, 23)
        Me.btnDBstudentTable.TabIndex = 5
        Me.btnDBstudentTable.Text = "Add Student Table"
        Me.btnDBstudentTable.UseVisualStyleBackColor = True
        '
        'btnDBexamTable
        '
        Me.btnDBexamTable.Location = New System.Drawing.Point(147, 41)
        Me.btnDBexamTable.Name = "btnDBexamTable"
        Me.btnDBexamTable.Size = New System.Drawing.Size(106, 23)
        Me.btnDBexamTable.TabIndex = 6
        Me.btnDBexamTable.Text = "Add Exam Table"
        Me.btnDBexamTable.UseVisualStyleBackColor = True
        '
        'btnDBresultTable
        '
        Me.btnDBresultTable.Location = New System.Drawing.Point(147, 70)
        Me.btnDBresultTable.Name = "btnDBresultTable"
        Me.btnDBresultTable.Size = New System.Drawing.Size(106, 23)
        Me.btnDBresultTable.TabIndex = 7
        Me.btnDBresultTable.Text = "Add Result Table"
        Me.btnDBresultTable.UseVisualStyleBackColor = True
        '
        'btnDBaddFields
        '
        Me.btnDBaddFields.Location = New System.Drawing.Point(147, 99)
        Me.btnDBaddFields.Name = "btnDBaddFields"
        Me.btnDBaddFields.Size = New System.Drawing.Size(106, 23)
        Me.btnDBaddFields.TabIndex = 8
        Me.btnDBaddFields.Text = "Add extra Fields"
        Me.btnDBaddFields.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 403)
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

End Class
