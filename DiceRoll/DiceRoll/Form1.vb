Public Class Form1

    ' Count the number of times we get 12
    Dim count As Integer = 500

    Private Sub btn_Roll_Click(sender As Object, e As EventArgs) Handles btn_Roll.Click
        ' Clear any previous results
        lsb_Dice.Items.Clear()

        ' Create random number generator
        Dim rand As New Random()

        ' Pay to Play
        count -= 40

        ' Roll two dice 1200 times
        For i As Integer = 1 To 1200
            ' Roll first die
            Dim die1 As Integer = rand.Next(1, 7)

            ' Roll second die
            Dim die2 As Integer = rand.Next(1, 7)

            ' Add up the dice
            Dim total As Integer = die1 + die2

            ' Display result
            lsb_Dice.Items.Add("Roll " & i & ": " & die1 & " + " & die2 & " = " & total)

            ' Check if we got 12
            If total = 12 Then
                count += 1
            End If
        Next

        ' Shows amount of cash
        Dim JackPot As Decimal
        JackPot = 500 * count
        tbx_Money.Text() = JackPot

        ' Display the number of times we got 12
        tbx_Count.Text = count
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click

        ' Put back to starting Amount
        Dim count As Integer = 500

        ' TextBoxes
        tbx_Count.Clear()
        tbx_Money.Clear()

        ' ListBox
        lsb_Dice.Items.Clear()

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Shows amount of cash
        Dim JackPot As Decimal
        JackPot = 500 * count
        tbx_Money.Text() = JackPot

    End Sub
End Class
