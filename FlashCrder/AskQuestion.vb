Public Class AskQuestion
    Public img As Image
    Dim retVal As ClickedButton = Nothing
    Enum ClickedButton
        A
        B
        C
        D
    End Enum
    Public ReadOnly Property Answer() As ClickedButton
        Get
            Return retVal
        End Get
    End Property

    Private Sub AskQuestion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Dim AAChk As CheckBox
    Public Sub New(ByRef AutoAdv As CheckBox)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AAChk = AutoAdv
        CheckBox1.Checked = AAChk.Checked
    End Sub
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click, Button6.Click, Button7.Click, Button8.Click
        Select Case sender.ToString
            Case Button5.ToString
                retVal = ClickedButton.A
            Case Button6.ToString
                retVal = ClickedButton.B
            Case Button7.ToString
                retVal = ClickedButton.C
            Case Button8.ToString
                retVal = ClickedButton.D
        End Select
        AAChk.Checked = CheckBox1.Checked
        Me.Close()
    End Sub

    Private Sub AskQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim g As Graphics = Graphics.FromHwnd(Me.Handle)
        'g.PageUnit = GraphicsUnit.Pixel

        'Dim difference = Math.Round((Label1.Height - g.MeasureString(Label1.Text & vbCrLf, New Font("Times New Roman", 12), Label1.Width).Height))
        'Label1.Height = Int(Math.Round(g.MeasureString(Label1.Text & vbCrLf, New Font("Times New Roman", 12), Label1.Width).Height))
        'Me.Height += difference
        'Dim oldLblHeight = Label1.Height
        'Dim oldwdth = Label1.Width
        'Label1.AutoSize = True
        'oldLblHeight -= Label1.Height
        'Me.Height -= oldLblHeight
        'oldLblHeight = Label1.Height
        'Label1.AutoSize = False
        'Label1.Height = oldLblHeight
        'Label1.Width = oldwdth
    End Sub

    Private Sub AskQuestion_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
        Application.Exit()
    End Sub

    Private Sub AskQuestion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case Char.ToLower(e.KeyChar)
            Case "a"
                Button_Click(Button5, e)
            Case "b"
                Button_Click(Button6, e)
            Case "c"
                Button_Click(Button7, e)
            Case "d"
                Button_Click(Button8, e)
            Case Else
                'Ignore anything else
        End Select
    End Sub

    Private Sub Label1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
End Class