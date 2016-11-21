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
        Me.cmdPush = New System.Windows.Forms.Button()
        Me.cmdPop = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAddItem
        '
        Me.txtAddItem.Location = New System.Drawing.Point(36, 83)
        Me.txtAddItem.Name = "txtAddItem"
        Me.txtAddItem.Size = New System.Drawing.Size(116, 20)
        Me.txtAddItem.TabIndex = 0
        '
        'cmdPush
        '
        Me.cmdPush.Location = New System.Drawing.Point(92, 148)
        Me.cmdPush.Name = "cmdPush"
        Me.cmdPush.Size = New System.Drawing.Size(59, 26)
        Me.cmdPush.TabIndex = 2
        Me.cmdPush.Text = "Push"
        Me.cmdPush.UseVisualStyleBackColor = True
        '
        'cmdPop
        '
        Me.cmdPop.Location = New System.Drawing.Point(93, 212)
        Me.cmdPop.Name = "cmdPop"
        Me.cmdPop.Size = New System.Drawing.Size(57, 26)
        Me.cmdPop.TabIndex = 3
        Me.cmdPop.Text = "Pop"
        Me.cmdPop.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(229, 58)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(247, 303)
        Me.lstDisplay.TabIndex = 4
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(92, 273)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(62, 26)
        Me.cmdClear.TabIndex = 5
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 402)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cmdPop)
        Me.Controls.Add(Me.cmdPush)
        Me.Controls.Add(Me.txtAddItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddItem As System.Windows.Forms.TextBox
    Friend WithEvents cmdPush As System.Windows.Forms.Button
    Friend WithEvents cmdPop As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button

End Class
