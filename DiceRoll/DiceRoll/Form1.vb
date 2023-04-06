Public Class Form1

    ' Count the number of times we get 12
    Dim count As Integer = 500

    Private Sub btn_Roll_Click(sender As Object, e As EventArgs) Handles btn_Roll.Click
        ' Clear any previous results
        lsb_Dice.Items.Clear()

        ' Holds number of time 12 is gotten for your cash each round
        Dim count1 As Integer

        ' Create random number generator
        Dim rand As New Random()

        ' Get the bet amount from the TextBox control
        Dim betAmount As Integer = CDec(tbx_BetAmount.Text)

        ' Subtract the bet amount from the bank balance
        count -= betAmount

        ' Get the selected roll value from the ComboBox control
        Dim rollValue As Integer = CInt(cmb_RollValue.SelectedItem)

        ' Get the selected number of rolls from the ComboBox control
        Dim rollAmount As Integer = CInt(cmb_RollAmount.SelectedItem)

        ' Get the selected difficulty level from the ComboBox control
        Dim difficultyLevel As Integer = CInt(cmb_DifficultyLevel.SelectedItem)

        ' Set the reward multiplier based on the difficulty level
        Dim rewardMultiplier As Decimal = 1.0
        Select Case difficultyLevel
            Case 1
                rewardMultiplier = 1.0
            Case 2
                rewardMultiplier = 1.5
            Case 3
                rewardMultiplier = 2.0
            Case Else
                rewardMultiplier = 1.0
        End Select

        ' Roll two dice 1200 times
        For i As Integer = 1 To rollAmount
            ' Roll first die
            Dim die1 As Integer = rand.Next(1, 7)

            ' Roll second die
            Dim die2 As Integer = rand.Next(1, 7)

            ' Add up the dice
            Dim total As Integer = die1 + die2

            ' Display result
            lsb_Dice.Items.Add("Roll " & i & ": " & die1 & " + " & die2 & " = " & total)

            ' Check if we got the selected roll value
            If total = rollValue Then
                count += betAmount * 2
                count1 += 1
            End If
        Next

        ' Shows amount of cash in 
        Dim BankBal As Decimal
        BankBal = count
        tbx_Bank.Text() = BankBal

        ' Display the number of times we got the selected roll value
        Dim CashBal As Decimal
        CashBal = betAmount * count1
        tbx_Cash.Text = "Cash Won: " & CashBal

    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click

        ' Put back to starting Amount
        count = 500

        ' TextBoxes
        tbx_Cash.Clear()
        tbx_Bank.Clear()

        ' ListBox
        lsb_Dice.Items.Clear()

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Shows amount of cash
        Dim BankBal As Decimal
        BankBal = count
        tbx_Bank.Text() = BankBal

        ' Populate the ComboBox control with the possible roll values
        cmb_RollValue.Items.AddRange({2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12})
        cmb_RollValue.SelectedIndex = 0

        ' Populate the ComboBox control with the amount of rolls 
        cmb_RollAmount.Items.AddRange({10, 25, 50, 100, 250, 500, 650, 1300, 1350, 1500})
        cmb_RollAmount.SelectedIndex = 0




    End Sub
End Class
