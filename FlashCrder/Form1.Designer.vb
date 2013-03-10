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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.questionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " To close this application, right click the icon on the taskbar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and select ""Clos" & _
            "e""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please keep this window open."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Question Interval:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.ComboBox1, "Select the time delay between flashcards")
        Me.ComboBox1.Items.AddRange(New Object() {"Keep 'em coming... Don't stop!", "Every ten seconds", "Every 30 seconds", "Every minute", "Every two minutes", "Every three minutes", "Every four minutes", "Every five minutes", "Every ten minutes", "every fifteen minutes", "every twenty mintues", "every 30 minutes", "every 45 minutes", "every hour"})
        Me.ComboBox1.Location = New System.Drawing.Point(108, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.HelpProvider1.SetShowHelp(Me.ComboBox1, True)
        Me.ComboBox1.Size = New System.Drawing.Size(172, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'questionTimer
        '
        Me.questionTimer.Interval = 5000
        '
        'Button1
        '
        Me.HelpProvider1.SetHelpString(Me.Button1, "When you click this, a timer will start counting until your next flashcard should" & _
                " show up. A quick way to engage this button is to press the ""Enter"" key.")
        Me.Button1.Location = New System.Drawing.Point(60, 104)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(172, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start timer for next question"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.CheckBox1, "Enables automatic showing of the next question. It's like clicking the button so " & _
                "you don't have to!")
        Me.CheckBox1.Location = New System.Drawing.Point(34, 133)
        Me.CheckBox1.Name = "CheckBox1"
        Me.HelpProvider1.SetShowHelp(Me.CheckBox1, True)
        Me.CheckBox1.Size = New System.Drawing.Size(225, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Check this box to auto-advance questions"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 157)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpString(Me, "Try clicking the question mark button, and clicking somewhere else.")
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Flash Card Quizzer 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents questionTimer As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox


End Class
