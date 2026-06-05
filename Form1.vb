Public Class Form1
    Private rnd As New Random()

    Private Enum Move
        Rock = 0
        Paper = 1
        Scissors = 2
        Lizard = 3
        Spock = 4
    End Enum

    Private playerScore As Integer = 0
    Private computerScore As Integer = 0
    Private history As New List(Of String)()
    Private moveCounts(4) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUI()
    End Sub

    Private Function GetComputerMove() As Move
        Return CType(rnd.Next(0, 5), Move)
    End Function

    Private Function MoveToString(m As Move) As String
        Return [Enum].GetName(GetType(Move), m)
    End Function

    Private Function DecideWinner(player As Move, computer As Move) As Integer
        ' return: 1 = player wins, -1 = computer wins, 0 = tie
        If player = computer Then
            Return 0
        End If

        ' rules: who beats who
        ' Rock crushes Scissors and Lizard
        ' Paper covers Rock and disproves Spock
        ' Scissors cuts Paper and decapitates Lizard
        ' Lizard poisons Spock and eats Paper
        ' Spock vaporizes Rock and smashes Scissors

        Select Case player
            Case Move.Rock
                If computer = Move.Scissors Or computer = Move.Lizard Then Return 1
            Case Move.Paper
                If computer = Move.Rock Or computer = Move.Spock Then Return 1
            Case Move.Scissors
                If computer = Move.Paper Or computer = Move.Lizard Then Return 1
            Case Move.Lizard
                If computer = Move.Spock Or computer = Move.Paper Then Return 1
            Case Move.Spock
                If computer = Move.Rock Or computer = Move.Scissors Then Return 1
        End Select

        Return -1
    End Function

    Private Sub PlayRound(playerMove As Move, computerMove As Move)
        moveCounts(CInt(playerMove)) += 1

        Dim result = DecideWinner(playerMove, computerMove)

        Dim resultText As String
        If result = 1 Then
            playerScore += 1
            resultText = "You win!"
            ' cheering sound
            Try
                System.Media.SystemSounds.Exclamation.Play()
            Catch
            End Try
            lblResult.ForeColor = System.Drawing.Color.DarkGreen
        ElseIf result = -1 Then
            computerScore += 1
            resultText = "You lose."
            Try
                System.Media.SystemSounds.Hand.Play()
            Catch
            End Try
            lblResult.ForeColor = System.Drawing.Color.DarkRed
        Else
            resultText = "Tie."
            Try
                System.Media.SystemSounds.Beep.Play()
            Catch
            End Try
            lblResult.ForeColor = System.Drawing.Color.DimGray
        End If

        Dim entry = String.Format("{0} | You: {1}  Computer: {2}", DateTime.Now.ToString("HH:mm:ss"), MoveToString(playerMove), MoveToString(computerMove)) & " => " & resultText
        history.Add(entry)

        lblResult.Text = resultText

        UpdateUI()
        lstHistory.Items.Add(entry)
        lstHistory.TopIndex = Math.Max(0, lstHistory.Items.Count - 1)
    End Sub

    Private Sub UpdateUI()
        lblPlayerScore.Text = String.Format("Player: {0}", playerScore)
        lblComputerScore.Text = String.Format("Computer: {0}", computerScore)

        lblMostChosen.Text = "Most chosen move: -"
        Dim maxCount = moveCounts.Max()
        If maxCount > 0 Then
            Dim idx = Array.IndexOf(moveCounts, maxCount)
            lblMostChosen.Text = String.Format("Most chosen move: {0} ({1})", MoveToString(CType(idx, Move)), maxCount)
        End If
    End Sub

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim comp = GetComputerMove()
        lblPlayerChoice.Text = "Your choice: Rock"
        lblComputerChoice.Text = "Computer choice: " & MoveToString(comp)
        PlayRound(Move.Rock, comp)
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim comp = GetComputerMove()
        lblPlayerChoice.Text = "Your choice: Paper"
        lblComputerChoice.Text = "Computer choice: " & MoveToString(comp)
        PlayRound(Move.Paper, comp)
    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        Dim comp = GetComputerMove()
        lblPlayerChoice.Text = "Your choice: Scissors"
        lblComputerChoice.Text = "Computer choice: " & MoveToString(comp)
        PlayRound(Move.Scissors, comp)
    End Sub

    Private Sub btnLizard_Click(sender As Object, e As EventArgs) Handles btnLizard.Click
        Dim comp = GetComputerMove()
        lblPlayerChoice.Text = "Your choice: Lizard"
        lblComputerChoice.Text = "Computer choice: " & MoveToString(comp)
        PlayRound(Move.Lizard, comp)
    End Sub

    Private Sub btnSpock_Click(sender As Object, e As EventArgs) Handles btnSpock.Click
        Dim comp = GetComputerMove()
        lblPlayerChoice.Text = "Your choice: Spock"
        lblComputerChoice.Text = "Computer choice: " & MoveToString(comp)
        PlayRound(Move.Spock, comp)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        playerScore = 0
        computerScore = 0
        history.Clear()
        lstHistory.Items.Clear()
        For i = 0 To moveCounts.Length - 1
            moveCounts(i) = 0
        Next
        lblPlayerChoice.Text = "Your choice: -"
        lblComputerChoice.Text = "Computer choice: -"
        UpdateUI()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class
