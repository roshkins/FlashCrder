<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskQuestion
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
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button5.Location = New System.Drawing.Point(10, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 43)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "A"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button6.Location = New System.Drawing.Point(74, 135)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 43)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "B"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button7.Location = New System.Drawing.Point(144, 135)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 43)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "C"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button8.Location = New System.Drawing.Point(208, 135)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 43)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "D"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Click the button that corresponds with your answer."
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(44, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Quit Application"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(84, 215)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Auto-advance"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'AskQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.KeyPreview = True
        Me.Name = "AskQuestion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Question for you!"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
