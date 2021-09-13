Imports System.Net
Imports SpeechLib
Public Class Form1
    Dim length As Integer = 0
    Dim inputLength As Integer = 0
    Dim finalScore As String
    Dim copyTxt = " "
    Dim input = " "
    Dim score As Integer = 0
    Dim wordsMissed As Integer
    Dim timeInt As Integer = 0
    Dim time As Double = 0
    Dim quake As New Random
    Dim rating As String
    Dim adjustedInput()
    Dim ranNum1 As Integer
    Dim ranNum2 As Integer
    Dim ranNum3 As Integer
    Public Shared value As Integer = 5
    Dim numWrongWords As Integer = 0
    Dim picCount As Integer = 0
    Dim minOff As Integer = 2
    Dim maxOn As Integer = 1
    Dim randomNumber As Integer
    Dim sapi As SpVoice
    Dim letterRead
    Dim readStatus
    Dim spaceChar As String = "Space"
    Function countWords()
        copyTxt = Split(lblCopytxt.Text, " ") 'Everytime there is a space in the label, a new word in the array would be created
        length = UBound(copyTxt) - LBound(copyTxt) + 1 'Gets the number of words in the label
        input = Split((txtInput.Text), " ") 'Everytime there is a space in the textbox, a new word in the array would be created
        inputLength = UBound(input) - LBound(input) + 1 'Gets the number of words typed by user
    End Function

    Function rateScore()
        Select Case score / length
            Case = 1
                rating = "SS"
                MessageBox.Show("You typed perfectly! Well done!")
            Case > 0.95, < 1
                rating = "S"
                MessageBox.Show("You extremely well!")
            Case < 0.5
                MessageBox.Show("Nice try! You have room for improvement!")
        End Select
    End Function
    Function readOut(read)
        sapi = CreateObject("sapi.spvoice")
        sapi.Speak(read, 1, 1)
    End Function
    Function wordPlace()
        Dim i As Integer = 0
        If inputLength > length Then
            For i = 0 To length - 1
                If copyTxt(i) = input(i) Then 
                    score = score + 1
                End If
            Next
        Else
            For i = 0 To inputLength - 1
                If copyTxt(i) = input(i) Then
                    score = score + 1
                End If
            Next
        End If

    End Function




    Private Sub btnNewText_Click(sender As Object, e As EventArgs) Handles btnNewText.Click
        txtInput.Enabled = True
        btnCheck.Enabled = True
        Dim txtID As Integer
        txtID = Int((10 - 2) * Rnd())
        Select Case txtID
            Case 1
                lblCopytxt.Text = ""
        End Select
        'copyTxt = Split(Label1.Text, " ")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (Me.Height / 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (Me.Width / 2)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

        tmrTime.Enabled = True
        If quakeStatus = True Then  'if the player enabled the earthquake mode, the earthquake will start
            tmrShake.Enabled = True
        End If
        ranNum1 = Int((255 - 2) * Rnd()) 'creates a random 'red', blue', and 'green' RGB values
        ranNum2 = Int((255 - 2) * Rnd())
        ranNum3 = Int((255 - 2) * Rnd())
        Me.BackColor = Color.FromArgb((ranNum1), (ranNum2), (ranNum3)) 'changes the colour of the form

        countWords()
        wordsMissed = (length - inputLength)  'counts the words unattempted
        If wordsMissed < 0 Then
            lblNotAt.Text = ("You typed " + CStr(Math.Abs(wordsMissed)) + " extra words")
        ElseIf wordsMissed > 0 Then
            lblNotAt.Text = ("Words left: " + CStr(wordsMissed))
        End If
        picCount = picCount + 1
        If picCount Mod 2 = 0 Then
            picBox.Image = My.Resources._1574231965_financial_regulators
        Else
            picBox.Image = My.Resources.valorant_offwhitelvaloranniewjewiaunch_keyart
        End If
        If readStatus = True And txtInput.Text.Length > 0 Then
            letterRead = txtInput.Text.Substring(txtInput.Text.Length - 1)
            If letterRead = " " Then
                readOut(spaceChar)
            End If
            readOut(letterRead)
        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            wordPlace()
            tmrShake.Enabled = False
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        tmrTime.Enabled = False
        If txtInput.Text = "" Then
            MessageBox.Show("Type something")
        End If
        wordPlace()
        finalScore = ("Score: " + CStr(score))
        lblScore.Text = finalScore
        'MessageBox.Show(length, inputLength)
        wordsMissed = (length - inputLength)
        rateScore()
        If wordsMissed < 0 Then
            lblNotAt.Text = ("You typed " + CStr(Math.Abs(wordsMissed)) + " extra words")
        ElseIf wordsMissed > 0 Then
            lblNotAt.Text = ("Words left: " + CStr(wordsMissed))
        End If
        time = 0
        lblTime.Text = 0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
    End Sub

    Private Sub btnGetApi_Click(sender As Object, e As EventArgs) Handles btnGetApi.Click
        'Code sourced from https://www.youtube.com/watch?v=FE4PdSnox1w
        txtInput.Enabled = True
        txtInput.Visible = True
        tmrTime.Enabled = False
        lblTime.Text = 0
        time = 0
        If flashStatus = True Then
            tmrBlackOut.Enabled = True
        End If
        Try
            Dim Request As HttpWebRequest = HttpWebRequest.Create("Http://numbersapi.com/random/trivia")
            Request.Proxy = Nothing 'speeds up request
            'Request.UserAgent = "Test"

            Dim response As HttpWebResponse = Request.GetResponse
            Dim responsestream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responsestream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            lblCopytxt.Text = data
        Catch ex As Exception
            MessageBox.Show("Could not load a text. Try checking your internet connection.")
        End Try
        lblCopytxt.Left = (Me.Width / 2) - (lblCopytxt.Width / 2)
        txtInput.Text = ""
        countWords()
        lblNotAt.Text = ("Words left: " + CStr(length))
        'copyTxt = Split(Label1.Text, " ")
        lblInstructions.Visible = False
        btnCheck.Enabled = True

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
        lblCopytxt.Text = ""
        score = 0
        time = 0
        wordsMissed = 0
    End Sub
    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        timeInt = (timeInt + 1)
        time = timeInt / 10

        lblTime.Text = CStr(time) + " seconds"
    End Sub
    Private Sub tmrShake_Tick(sender As Object, e As EventArgs) Handles tmrShake.Tick 'code inspired from https://www.youtube.com/watch?v=pCR-EkOx-WA
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (Me.Height / 2) + quake.Next(-40, 40)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (Me.Width / 2) + quake.Next(-40, 40)
        If quakeStatus = False Then
            tmrShake.Enabled = False
            Me.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (Me.Height / 2)
            Me.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (Me.Width / 2)
        End If
    End Sub
    Private Sub tmrBlackout_Tick(sender As Object, e As EventArgs) Handles tmrBlackOut.Tick
        ' between calls '
        randomNumber = Int(2 + Rnd() * (5 - 0 + 1))


    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        readStatus = True
        readOut(lblCopytxt.Text)
    End Sub

End Class
