

Public Class Form1
    Private Sub rdoBtn1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtn1.CheckedChanged
        If rdoBtn1.Checked Then
            selectedHorse = 1
        End If
    End Sub

    Private Sub rdoBtn2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtn2.CheckedChanged
        If rdoBtn2.Checked Then
            selectedHorse = 2
        End If
    End Sub

    Private Sub rdoBtn3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtn3.CheckedChanged
        If rdoBtn3.Checked Then
            selectedHorse = 3
        End If
    End Sub

    Private Sub rdoBtn4_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtn4.CheckedChanged
        If rdoBtn4.Checked Then
            selectedHorse = 4
        End If
    End Sub

    Private Sub rdoBtn5_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtn5.CheckedChanged
        If rdoBtn5.Checked Then
            selectedHorse = 5
        End If
    End Sub

    ' Declare winner
    Private winnerTextBox As TextBox = Nothing

    Private flashWinnerText As Boolean = False

    ' Declare flashing Horses
    Private flashHorseLabels As Boolean = False

    ' Declare the Timer for flashing text
    Private WithEvents flashTextTimer As New System.Windows.Forms.Timer()

    ' Variable to control flash of lblCurrentBet
    Private flashLblCurrentBet As Boolean = True

    ' Declare the Timer
    Private WithEvents myTimer As New System.Windows.Forms.Timer()

    ' Declare the number of Rounds
    Private currentRound As Integer = 1
    Private Const MaxRounds As Integer = 3

    ' Add variable to track the selected horse and if the user has won
    Private selectedHorse As Integer = 0
    Private userHasWon As Boolean = False

    ' Initializing Starting Money and Bets
    Private startingMoney As Integer = 1000
    Private currentMoney As Integer = startingMoney
    Private currentBet As Integer = 0
    ' Random instance
    Private rnd As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial values to the text boxes
        txtBoxStartMoney.Text = startingMoney.ToString()
        txtBoxStartMoney.ForeColor = Color.White
        txtBoxStartMoney.Refresh()
        txtBoxStartMoney.Enabled = True
        ' Make sure the Start Money TextBox is not editable
        txtBoxStartMoney.ReadOnly = True
        txtBoxStartMoney.TabStop = False

        txtBoxCurrentMoney.Text = currentMoney.ToString()
        txtBoxCurrentMoney.ForeColor = Color.White
        txtBoxCurrentMoney.Enabled = True
        ' Make sure the Money Left TextBox is not editable
        txtBoxCurrentMoney.ReadOnly = True
        txtBoxCurrentMoney.TabStop = False

        ' Disable the Next button at form load
        btnNext.Enabled = False

        ' Hide the Horses racing bars
        pbHorse1.Visible = False
        pbHorse2.Visible = False
        pbHorse3.Visible = False
        pbHorse4.Visible = False
        pbHorse5.Visible = False

        ' Hide the horse labels
        lblHorse1.Visible = False
        lblHorse2.Visible = False
        lblHorse3.Visible = False
        lblHorse4.Visible = False
        lblHorse5.Visible = False

        'Hide Standings
        lblStanding.Visible = False

        ' Hide the txtBoxHorseStandings
        txtBoxHorse1Standing.Visible = False
        txtBoxHorse2Standing.Visible = False
        txtBoxHorse3Standing.Visible = False
        txtBoxHorse4Standing.Visible = False
        txtBoxHorse5Standing.Visible = False

        ' Configure the flash text Timer
        flashTextTimer.Interval = 250 ' Interval set for half a second
        flashTextTimer.Start() ' Start the timer to begin flashing       

        ' Configure the Timer
        With myTimer
            .Interval = 500 ' Set the interval to 1 second
            .Enabled = False ' The timer will not start ticking until enabled
        End With
    End Sub

    ' Place Bet Button Click
    Private Sub btnPlaceBet_Click(sender As Object, e As EventArgs) Handles btnPlaceBet.Click
        ' Validate and place the bet
        Dim betAmount As Decimal
        If Decimal.TryParse(txtBoxCurrentBet.Text, betAmount) AndAlso betAmount > 0 AndAlso betAmount = Math.Floor(betAmount) Then
            If betAmount <= currentMoney Then
                ' Convert the decimal to an integer and place the bet
                currentBet = Convert.ToInt32(betAmount)
                currentMoney -= currentBet
                txtBoxCurrentMoney.Text = currentMoney.ToString()

                ' Disable betting until the race is over
                gbHorse.Enabled = False
                btnPlaceBet.Enabled = False
                txtBoxCurrentBet.Enabled = False ' Disable the bet amount text box after placing a bet

            Else
                MessageBox.Show("You cannot bet more than your current money.", "Invalid Bet")
            End If
        Else
            MessageBox.Show("Please enter a valid bet amount. Only Full Dollar Bets are accepted.", "Invalid Input")
        End If

        ' Stop flashing for the Current Bet label when a bet is placed
        flashLblCurrentBet = False
        lblCurrentBet.ForeColor = Color.White ' Reset to visible color

        ' Reset the Place Bet button's ForeColor to stop it from flashing if it was flashing
        btnPlaceBet.ForeColor = Color.Gold

        ' Flashing for the Start Race button
        flashTextTimer.Start()
    End Sub

    ' Start Race Button Click
    Private Sub btnStartRace_Click(sender As Object, e As EventArgs) Handles btnStartRace.Click
        ' First, check if a valid bet has been placed
        If currentBet <= 0 Then
            MessageBox.Show("Please place a bet before starting the race.")
            Exit Sub
        End If

        ' Check if the user still has money to bet
        If currentMoney <= 0 Then
            MessageBox.Show("You have run out of money.")
            Exit Sub
        End If

        ' Check if maximum rounds have been reached
        If currentRound > MaxRounds Then
            MessageBox.Show("Maximum rounds reached.")
            Exit Sub
        End If

        ' Start the race only if a horse is selected
        If selectedHorse > 0 Then
            ' Update the round number label
            lblRoundNumber.Text = "Round " & currentRound.ToString()

            ' Start the race
            myTimer.Start()
            btnStartRace.Enabled = False
            btnPlaceBet.Enabled = False ' Disable betting during the race
            gbHorse.Enabled = False ' Disable horse selection during the race

            ' Show the racing UI elements
            ShowRacingElements()

            ' Start flashing the horse labels randomly
            flashHorseLabels = True
            flashTextTimer.Start()
        Else
            MessageBox.Show("Please select a horse before starting the race.")
        End If
    End Sub

    Private Sub ShowRacingElements()
        ' Show the horses racing bars
        pbHorse1.Visible = True
        pbHorse2.Visible = True
        pbHorse3.Visible = True
        pbHorse4.Visible = True
        pbHorse5.Visible = True

        ' Show the Horse labels
        lblHorse1.Visible = True
        lblHorse2.Visible = True
        lblHorse3.Visible = True
        lblHorse4.Visible = True
        lblHorse5.Visible = True

        ' Show Standings
        lblStanding.Visible = True

        ' Make the txtBoxHorseStandings visible
        txtBoxHorse1Standing.Visible = True
        txtBoxHorse2Standing.Visible = True
        txtBoxHorse3Standing.Visible = True
        txtBoxHorse4Standing.Visible = True
        txtBoxHorse5Standing.Visible = True

        flashTextTimer.Stop() ' Stop flashing when the bet is placed
        btnStartRace.ForeColor = Color.Gold ' Reset to visible color
    End Sub


    ' Timer Tick for Race Progress
    Private Sub myTimer_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick

        ' Randomly increment the progress for each horse to simulate the race
        pbHorse1.Increment(rnd.Next(1, 5))
        pbHorse2.Increment(rnd.Next(1, 5))
        pbHorse3.Increment(rnd.Next(1, 5))
        pbHorse4.Increment(rnd.Next(1, 5))
        pbHorse5.Increment(rnd.Next(1, 5))

        ' Check for a winner and update standings
        CheckForWinner()
    End Sub
    Private Sub CheckForWinner()
        ' Create a list to hold the progress bars(Horses)
        Dim horseProgressBars As New List(Of ProgressBar) From {pbHorse1, pbHorse2, pbHorse3, pbHorse4, pbHorse5}

        ' Sort the progress bars by their current value in descending order
        Dim sortedProgressBars = horseProgressBars.OrderByDescending(Function(pb) pb.Value).ToList()

        ' Initialize the placements list
        Dim placements As New List(Of String) From {"Winner!", "2nd", "3rd", "4th", "5th"}

        ' Check which Horse has finished the race and determine the winner(pb ended)
        Dim raceFinished As Boolean = False
        For Each pb In sortedProgressBars
            If pb.Value >= pb.Maximum AndAlso Not raceFinished Then
                ' Stop the timer as the race is finished
                myTimer.Stop()
                raceFinished = True

                ' Assign the winner text and remove it from the placements list
                SetWinnerText(pb, placements(0))
                placements.RemoveAt(0)

                ' Check if the user's selected horse is the winner
                Dim winningHorseIndex As Integer = horseProgressBars.IndexOf(pb) + 1
                If selectedHorse = winningHorseIndex Then
                    ' User selected the winning horse
                    currentMoney += currentBet * 2 ' Payout calculation 
                    userHasWon = True
                    MessageBox.Show("Congratulations! Your horse won! You now have $" & currentMoney.ToString(), "Winner", MessageBoxButtons.OK)
                Else
                    userHasWon = False
                    ' If a horse was selected but did not win, notify the user
                    If selectedHorse > 0 Then
                        MessageBox.Show("Your horse did not win. Try again!", "Not this time", MessageBoxButtons.OK)
                    End If
                End If
            End If
        Next

        ' If the race is finished, assign text for the rest based on their current sorted order
        If raceFinished Then
            ' Stop flashing the horse labels when the race is finished
            flashHorseLabels = False
            ' Iterate over the sorted progress bars and assign placements to the rest
            Dim placementIndex As Integer = 0
            For Each pb In sortedProgressBars
                If pb.Value < pb.Maximum Then
                    SetWinnerText(pb, placements(placementIndex))
                    placementIndex += 1 ' Move to the next placement

                End If
            Next

            ' Reset bet and selected horse for the next round
            currentBet = 0
            selectedHorse = 0
            txtBoxCurrentBet.Text = ""
            ResetRadioButtons()

            ' Disable the start race button as the race is over
            btnStartRace.Enabled = False

            ' Check if the user has run out of money after the race
            If currentMoney <= 0 Then
                MessageBox.Show("You've run out of money. Game over!", "Game Over", MessageBoxButtons.OK)
                EndGame()
            Else
                ' Enable the next round button for the user to proceed to the next round
                btnNext.Enabled = True
                ' Call PrepareNextRoundOrFinish to either set up for the next round or end the game
                '  PrepareNextRoundOrFinish()
            End If
        End If
    End Sub

    Private Sub SetWinnerText(progressBar As ProgressBar, text As String)
        Dim currentTextBox As TextBox = Nothing

        ' Determine which progress bar corresponds to which text box
        Select Case progressBar.Name
            Case "pbHorse1"
                currentTextBox = txtBoxHorse1Standing
            Case "pbHorse2"
                currentTextBox = txtBoxHorse2Standing
            Case "pbHorse3"
                currentTextBox = txtBoxHorse3Standing
            Case "pbHorse4"
                currentTextBox = txtBoxHorse4Standing
            Case "pbHorse5"
                currentTextBox = txtBoxHorse5Standing
        End Select

        If currentTextBox IsNot Nothing Then
            currentTextBox.Enabled = True
            currentTextBox.ReadOnly = True
            currentTextBox.Text = text
            currentTextBox.Refresh()

            ' If this horse is the winner, start flashing
            If text = "Winner!" Then
                winnerTextBox = currentTextBox ' Set the winner
                flashWinnerText = True
            Else
                currentTextBox.ForeColor = Color.White ' Set non-winners to a static color
            End If
        End If
    End Sub


    ' Prepare the game for a new round or finish the game
    Private Sub PrepareNextRoundOrFinish()
        ' Check if the game is over due to no money left or max rounds have been reached
        If currentRound < MaxRounds AndAlso currentMoney > 0 Then
            currentRound += 1
            UpdateRoundNumber(currentRound) ' Update the round number 
            ResetRace() ' Prepare for the next round
        ElseIf currentMoney <= 0 Then
            MessageBox.Show("Game over! You've run out of money.")
            EndGame() ' Disable all relevant controls
        Else
            MessageBox.Show("Game over! Maximum rounds reached.")
            EndGame() ' Disable all relevant controls
        End If
    End Sub

    Private Sub ResetRace()
        ' Reset the progress bars and other controls for the next round
        pbHorse1.Value = 0
        pbHorse2.Value = 0
        pbHorse3.Value = 0
        pbHorse4.Value = 0
        pbHorse5.Value = 0

        ' Clear the standings text boxes
        txtBoxHorse1Standing.Clear()
        txtBoxHorse1Standing.Enabled = False
        txtBoxHorse2Standing.Clear()
        txtBoxHorse2Standing.Enabled = False
        txtBoxHorse3Standing.Clear()
        txtBoxHorse3Standing.Enabled = False
        txtBoxHorse4Standing.Clear()
        txtBoxHorse4Standing.Enabled = False
        txtBoxHorse5Standing.Clear()
        txtBoxHorse5Standing.Enabled = False

        ' Hide the Horses racing bars
        pbHorse1.Visible = False
        pbHorse2.Visible = False
        pbHorse3.Visible = False
        pbHorse4.Visible = False
        pbHorse5.Visible = False

        ' Hide the horse labels
        lblHorse1.Visible = False
        lblHorse2.Visible = False
        lblHorse3.Visible = False
        lblHorse4.Visible = False
        lblHorse5.Visible = False

        'Hide Standings
        lblStanding.Visible = False

        ' Hide the txtBoxHorseStandings
        txtBoxHorse1Standing.Visible = False
        txtBoxHorse2Standing.Visible = False
        txtBoxHorse3Standing.Visible = False
        txtBoxHorse4Standing.Visible = False
        txtBoxHorse5Standing.Visible = False

        ' Re-enable the group box to allow for the next bet
        gbHorse.Enabled = True
        btnPlaceBet.Enabled = True
        btnStartRace.Enabled = True

        ' Re-enable the bet amount text box for the next round
        txtBoxCurrentBet.Enabled = True

        rdoBtn1.Checked = True
        selectedHorse = 1 ' Reset the selected horse to the default for the new round
        rdoBtn1_CheckedChanged(rdoBtn1, New EventArgs()) ' Manually set the CheckedChanged handler
    End Sub

    Private Sub EndGame()
        ' Disable controls as the game is over
        btnPlaceBet.Enabled = False
        btnStartRace.Enabled = False
        btnNext.Enabled = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Proceed to the next round or finish the game based on the user's decision
        If currentRound >= MaxRounds OrElse currentMoney <= 0 Then
            ' End the game if the max rounds have been reached or the user is out of money
            EndGame()
        Else
            ' If the user won and wishes to continue, or if the user did not win, reset for the next round
            If userHasWon Then
                Dim response As DialogResult = MessageBox.Show("You won the round! Would you like to continue playing?", "Continue?", MessageBoxButtons.YesNo)
                If response = DialogResult.Yes Then
                    ResetRace()
                Else
                    EndGame()
                End If
            Else
                ResetRace()
            End If
        End If
        ' Disable the Next button again to await the next race completion
        btnNext.Enabled = False
    End Sub

    Private Sub ResetRadioButtons()
        rdoBtn1.Checked = True
        rdoBtn2.Checked = False
        rdoBtn3.Checked = False
        rdoBtn4.Checked = False
        rdoBtn5.Checked = False
    End Sub

    Private Delegate Sub UpdateRoundNumberDelegate(roundNumber As Integer)

    Private Sub UpdateRoundNumber(roundNumber As Integer)
        If lblRoundNumber.InvokeRequired Then
            Dim d As New UpdateRoundNumberDelegate(AddressOf UpdateRoundNumber)
            Me.Invoke(d, New Object() {roundNumber})
        Else
            lblRoundNumber.Text = "Round " & roundNumber.ToString()
        End If
    End Sub

    ' Flash text on the controls
    Private Sub flashTextTimer_Tick(sender As Object, e As EventArgs) Handles flashTextTimer.Tick
        If btnPlaceBet.Enabled Then
            ' Flash the Place Bet button's text
            If btnPlaceBet.ForeColor = btnPlaceBet.BackColor Then
                btnPlaceBet.ForeColor = Color.Gold ' or any visible color
            Else
                btnPlaceBet.ForeColor = btnPlaceBet.BackColor
            End If
        End If

        ' Flash the Current Bet label's text 
        If flashLblCurrentBet AndAlso lblCurrentBet.Enabled Then
            If lblCurrentBet.ForeColor = lblCurrentBet.BackColor Then
                lblCurrentBet.ForeColor = Color.White ' 
            Else
                lblCurrentBet.ForeColor = lblCurrentBet.BackColor
            End If
        End If

        If btnStartRace.Enabled AndAlso Not btnPlaceBet.Enabled Then
            ' Flash the Start Race button's text
            If btnStartRace.ForeColor = btnStartRace.BackColor Then
                btnStartRace.ForeColor = Color.Gold ' or any visible color
            Else
                btnStartRace.ForeColor = btnStartRace.BackColor
            End If
        End If

        If btnNext.Enabled AndAlso Not btnStartRace.Enabled Then
            ' Flash the Next button's text
            If btnNext.ForeColor = btnNext.BackColor Then
                btnNext.ForeColor = Color.Gold ' or any visible color
            Else
                btnNext.ForeColor = btnNext.BackColor
            End If
        End If

        ' Flash the horse labels randomly if flashHorseLabels is True
        If flashHorseLabels Then
            Dim labelsToFlash() As Label = {lblHorse1, lblHorse2, lblHorse3, lblHorse4, lblHorse5}
            Dim randomLabelIndex As Integer = rnd.Next(labelsToFlash.Length)

            For i As Integer = 0 To labelsToFlash.Length - 1
                If i = randomLabelIndex Then
                    labelsToFlash(i).ForeColor = If(labelsToFlash(i).ForeColor = Color.White, Color.Gold, Color.White)
                Else
                    ' Reset other labels to a non-flashing state
                    labelsToFlash(i).ForeColor = Color.White
                End If
            Next
        End If

        ' Flash the Winner textbox's text if flashWinnerText is True
        If flashWinnerText AndAlso winnerTextBox IsNot Nothing Then
            winnerTextBox.ForeColor = If(winnerTextBox.ForeColor = Color.Gold, Color.Black, Color.Gold)
        End If
    End Sub
    Private Sub StopFlashingWinner()
        flashWinnerText = False
        If winnerTextBox IsNot Nothing Then
            winnerTextBox.ForeColor = Color.Gold
            winnerTextBox = Nothing ' Reset for the next round/game
        End If
        flashTextTimer.Stop() ' Stop the timer if it's only for flashing the winner's text
    End Sub

End Class
