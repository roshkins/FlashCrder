Imports System.IO
Public Class Form1
    ''' <summary>
    ''' Holds Question and answer Pairs. Answers must be a length 4 array. First answer is the correct one.
    ''' </summary>
    ''' <remarks></remarks>
    Structure QuestionAnswersPair
        Dim Question As String
        Dim Answers() As String
        Dim Weight As Double
    End Structure
    Dim Qs_and_As As New List(Of QuestionAnswersPair)

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Qs_and_As Is Nothing Then
            If MsgBox("Save Progress?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.SystemModal) = MsgBoxResult.Yes Then
                File.Delete(My.Computer.FileSystem.CurrentDirectory & "\questions.txt")
                Dim streamWrite As New StreamWriter(My.Computer.FileSystem.CurrentDirectory & "\questions.txt")
                For i = 0 To Qs_and_As.Count - 1
                    streamWrite.WriteLine(Qs_and_As(i).Question)
                    For j = 1 To 4
                        streamWrite.WriteLine(Qs_and_As(i).Answers(j))
                    Next
                    streamWrite.WriteLine(Qs_and_As(i).Weight)
                Next
                streamWrite.Close()
                streamWrite.Dispose()
            Else
            End If
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox1.SelectedIndex = 0
        Randomize(TimeOfDay.Ticks)
        'See if a Q&A file all ready exists...
        If File.Exists(My.Computer.FileSystem.CurrentDirectory & "\questions.txt") Then
            LoadQsAndAs(My.Computer.FileSystem.CurrentDirectory & "\questions.txt")
            '  If MsgBox("Show questions file for future editing?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            ' MsgBox("Opening Notepad document for Questions & answers... " & vbCrLf & "Talk to Rashi for the format.")
#If DEBUG Then
            Shell("notepad " & My.Computer.FileSystem.CurrentDirectory & "\questions.txt")
#End If
            ' End If
        Else
            Dim f = File.Create(My.Computer.FileSystem.CurrentDirectory & "\questions.txt")
            f.Close()
            MsgBox("Opening Notepad document for Questions & answers... " & vbCrLf & "Talk to Rashi for the format.")
            Shell("notepad " & My.Computer.FileSystem.CurrentDirectory & "\questions.txt")
            MsgBox("Closing program. Cannot function without this file. Notepad has been opened to create it.")
            Application.Exit()
            End
        End If
        CollectAnswer()
    End Sub
    Dim collectingAnswer As Boolean = False
    Sub CollectAnswer()
        '  Try
        questionTimer.Enabled = False
        collectingAnswer = True
        Dim Q_And_As_Pair = getRandomQandAsPair(Qs_and_As)
        If Q_And_As_Pair.Question = "" Then Stop
        With Q_And_As_Pair
            If AskQuestion(.Question, .Answers(1), .Answers(2), .Answers(3), .Answers(4)) Then
                MsgBox("Correct! The answer to """ & .Question & """is """ & .Answers(1) & """!")
                If Not Q_And_As_Pair.Weight - 0.1 = 0 Then
                    Q_And_As_Pair.Weight = Q_And_As_Pair.Weight - 0.1
                    For i = 0 To Qs_and_As.Count - 1
                        If Qs_and_As(i).Question = Q_And_As_Pair.Question Then
                            Qs_and_As(i) = Q_And_As_Pair
                        End If
                    Next
                End If
            Else
                MsgBox("Wrong. The answer to """ & .Question & """is """ & .Answers(1) & """!", MsgBoxStyle.Critical)
                If Not Q_And_As_Pair.Weight + 0.1 = 1 Then
                    Q_And_As_Pair.Weight = Q_And_As_Pair.Weight + 0.1
                    For i = 0 To Qs_and_As.Count - 1
                        If Qs_and_As(i).Question = Q_And_As_Pair.Question Then
                            Qs_and_As(i) = Q_And_As_Pair
                        End If
                    Next
                End If
            End If
        End With
        collectingAnswer = False
        If Not AutoAdvance Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
            Button1_Click(Nothing, New EventArgs)
        End If
        TopMost = True
        TopMost = False
        'Catch e As Exception
        'MsgBox("Error " & e.Message() & vbCrLf & "Quitting Application.", MsgBoxStyle.Exclamation)
        'Application.Exit()
        'End Try

    End Sub
    Function getRandomQandAsPair(ByVal l As List(Of QuestionAnswersPair)) As QuestionAnswersPair
        Dim i As Integer = Int(Rnd() * (l.Count))
        If Int(Rnd() * 100) < l.Item(i).Weight * 100 Then
            Dim itm = l.Item(i)
            If Not itm.Question = "" Then
                Return itm
            Else
                getRandomQandAsPair(l)
            End If
        Else
            Return getRandomQandAsPair(l)
        End If
        Return Nothing
    End Function
    ''' <summary>
    ''' Loads Questions and Answers into memory.
    ''' </summary>
    ''' <param name="fileLoc">The location of the answer file.</param>
    ''' <remarks></remarks>
    Sub LoadQsAndAs(ByVal fileLoc As String)
        Dim stream As New StreamReader(fileLoc) 'Create Stream
        Qs_and_As.Clear() 'Clear QsandAs
        Dim counter = 0
        Do
            Dim currentElement As New QuestionAnswersPair
            Dim Answrs(0) As String
            Do
                counter += 1
                Dim currentLine = stream.ReadLine()
                Select Case counter Mod 6
                    Case 1
                        currentElement.Question = currentLine
                    Case 0
                        currentElement.Answers = Answrs
                        currentElement.Weight = CInt(currentLine)
                        Qs_and_As.Add(currentElement)
                    Case Else
                        ReDim Preserve Answrs(Answrs.Length)
                        Answrs(Answrs.Length - 1) = currentLine
                End Select

            Loop Until counter = 6
            counter = 0
        Loop Until stream.EndOfStream
        stream.Dispose()
        Return
    End Sub
    Dim WithEvents tmr As New Windows.Forms.Timer With {.Interval = 10000}

    ''' <summary>
    ''' Produces the actual dialog from which to choose an answer.
    ''' </summary>
    ''' <param name="question">A string consisting of the question to be answered.</param>
    ''' <param name="a">A string consisting of the CORRECT answer to the question.</param>
    ''' <param name="b">A string consisting of an incorrect answer to the question.</param>
    ''' <param name="c">A string consisting of an incorrect answer to the question.</param>
    ''' <param name="d">A string consisting of an incorrect answer to the question.</param>
    ''' <returns>This function returns a boolean TRUE value if answer correctly, FALSE of not answered correctly, and Nothing if the box is closed.</returns>
    ''' <remarks></remarks>
    Function AskQuestion(ByVal question As String, ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String) As Boolean

        Dim qFrm As AskQuestion = New AskQuestion(CheckBox1)
        Select Case Int(Rnd() * 4) + 1
            Case 1
                qFrm.Label1.Text = question & vbCrLf & _
                      "Button A: " & a & vbCrLf & _
                      "Button B: " & b & vbCrLf & _
                      "Button C: " & c & vbCrLf & _
                      "Button D: " & d & vbCrLf
                qFrm.ShowDialog()
                Select Case qFrm.Answer
                    Case FlashCrder.AskQuestion.ClickedButton.A
                        Return True
                    Case Else
                        Return False
                End Select
            Case 2
                qFrm.Label1.Text = question & vbCrLf & _
      "Button A: " & b & vbCrLf & _
      "Button B: " & c & vbCrLf & _
      "Button C: " & d & vbCrLf & _
      "Button D: " & a & vbCrLf
                qFrm.ShowDialog()
                Select Case qFrm.Answer
                    Case FlashCrder.AskQuestion.ClickedButton.D
                        Return True
                    Case Else
                        Return False
                End Select
            Case 3
                qFrm.Label1.Text = question & vbCrLf & _
      "Button A: " & c & vbCrLf & _
      "Button B: " & d & vbCrLf & _
      "Button C: " & a & vbCrLf & _
      "Button D: " & b & vbCrLf
                qFrm.ShowDialog()
                Select Case qFrm.Answer
                    Case FlashCrder.AskQuestion.ClickedButton.C
                        Return True
                    Case Else
                        Return False
                End Select
            Case 4
                qFrm.Label1.Text = question & vbCrLf & _
      "Button A: " & d & vbCrLf & _
      "Button B: " & a & vbCrLf & _
      "Button C: " & b & vbCrLf & _
      "Button D: " & c & vbCrLf
                qFrm.ShowDialog()
                Select Case qFrm.Answer
                    Case FlashCrder.AskQuestion.ClickedButton.B
                        Return True
                    Case Else
                        Return False
                End Select
            Case Else
                Throw New ApplicationException("Random integer out of bounds")
        End Select

        End
        Return Nothing
    End Function

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Me.WindowState = FormWindowState.Normal
        tmr.Enabled = False
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        tmr.Enabled = True
    End Sub
    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        tmr.Enabled = Not tmr.Enabled
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        tmr.Enabled = Not tmr.Enabled
        With questionTimer
            Select Case ComboBox1.SelectedIndex
                Case 0
                    .Interval = 1000
                Case 1
                    .Interval = 10000
                Case 2
                    .Interval = 30000
                Case 3
                    .Interval = 60000
                Case 4
                    .Interval = 120000
                Case 5
                    .Interval = 180000
                Case 6
                    .Interval = 240000
                Case 7
                    .Interval = 300000
                Case 8
                    .Interval = 600000
                Case 9
                    .Interval = 900000
                Case 10
                    .Interval = 1200000
                Case 11
                    .Interval = 30 * 60 * 1000
                Case 12
                    .Interval = 45 * 60 * 1000
                Case 13
                    .Interval = 60 * 60 * 1000
            End Select
        End With
    End Sub

    Private Sub questionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles questionTimer.Tick
        If Not collectingAnswer Then
            CollectAnswer()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        questionTimer.Enabled = True
        Button1.Enabled = False
    End Sub
    Dim AutoAdvance As Boolean
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            'If MsgBox("Warning: You cannot uncheck this box while answering a question. " & vbCrLf & _
            '          "If you have selected an extremely short interval, it may not be possible for you to uncheck it." & vbCrLf & _
            '          "Are you sure you want to enable this functionality?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
            '    AutoAdvance = True
            'Else
            '    AutoAdvance = False
            '    CheckBox1.CheckState = CheckState.Unchecked
            'End If
            AutoAdvance = True
            CheckBox1.Checked = True
        Else
            AutoAdvance = False
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
