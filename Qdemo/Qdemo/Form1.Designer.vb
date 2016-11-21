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
        Me.txtAddItem = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.cmdDisplay = New System.Windows.Forms.Button()
        Me.lblItemRemoved = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAddItem
        '
        Me.txtAddItem.Location = New System.Drawing.Point(36, 83)
        Me.txtAddItem.Name = "txtAddItem"
        Me.txtAddItem.Size = New System.Drawing.Size(116, 20)
        Me.txtAddItem.TabIndex = 0
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(92, 148)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(59, 26)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(93, 212)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(57, 26)
        Me.cmdRemove.TabIndex = 3
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(229, 58)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(247, 303)
        Me.lstDisplay.TabIndex = 4
        '
        'cmdDisplay
        '
        Me.cmdDisplay.Location = New System.Drawing.Point(227, 14)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(62, 26)
        Me.cmdDisplay.TabIndex = 5
        Me.cmdDisplay.Text = "Display"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        Me.cmdDisplay.Visible = False
        '
        'lblItemRemoved
        '
        Me.lblItemRemoved.AutoSize = True
        Me.lblItemRemoved.Location = New System.Drawing.Point(33, 286)
        Me.lblItemRemoved.Name = "lblItemRemoved"
        Me.lblItemRemoved.Size = New System.Drawing.Size(0, 13)
        Me.lblItemRemoved.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 402)
        Me.Controls.Add(Me.lblItemRemoved)
        Me.Controls.Add(Me.cmdDisplay)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtAddItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddItem As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents cmdDisplay As System.Windows.Forms.Button
    Friend WithEvents lblItemRemoved As System.Windows.Forms.Label

End Class
