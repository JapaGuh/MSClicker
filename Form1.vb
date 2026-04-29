Public Class Form1

    Private clicks As Single = 0.0F

    Private record As Integer = 0
    Private timesClicked As Integer = 0
    Private bestTime As Integer = 0

    Private bonus As Single = 1.0F
    Private bonusCost As Single = 1.0F

    Private critMult As Single = 1.0F
    Private critMultCost As Single = 1.0F

    Private critChance As Integer = 1
    Private critChanceCost As Single = 1.0F

    Private popUp As Boolean = True
    Private time As Integer = 0

    Private autoOn As Boolean = False
    Private autoPCost As Single = 1000.0F
    Private autoP As Single = 1.0F

    Private Sub btnClicker_Click(sender As Object, e As EventArgs) Handles btnClicker.Click
        clicks = clicks + 1 + bonus
        timesClicked = timesClicked + 1
        lblTimesClicked.Text = timesClicked.ToString()
        lblClicks.Text = clicks.ToString("F0")
        If clicks > record Then
            record = CInt(clicks)
            lblRecord.Text = record.ToString()
        End If

        If record > 1000000 And popUp Then
            bestTime = time
            lblBestTime.Text = bestTime & " seconds"
            MessageBox.Show("Congratulations! You have reached the end of the game!
Do you want to continue?")
            btnReset.Visible = True
            btnFinish.Visible = True

        End If

        If critChance > 0 Then
            Dim rand As New Random()
            Dim chance As Integer = rand.Next(1, 101)
            If chance <= critChance Then
                clicks = clicks + (bonus * critMult)
                lblClicks.Text = clicks.ToString("F0")
                Beep()
            End If
        End If
    End Sub
    Private Sub btnBonus_Click(sender As Object, e As EventArgs) Handles btnBonus.Click
        If clicks >= bonusCost Then
            clicks = clicks - bonusCost
            bonus = bonus + 1
            bonusCost = bonusCost * CSng(1.2)
            lblClicks.Text = clicks.ToString("F0")
            lblBonus.Text = bonus.ToString("F0")
            lblBonusCost.Text = bonusCost.ToString("F0")
        End If
    End Sub
    Private Sub btnCritChance_Click(sender As Object, e As EventArgs) Handles btnCritChance.Click
        If clicks >= critChanceCost Then
            clicks = clicks - critChanceCost
            critChance = critChance + 5
            critChanceCost = critChanceCost * CSng(1.8)
            lblClicks.Text = clicks.ToString("F0")
            lblCritChance.Text = critChance.ToString() & " %"
            lblCritChanceCost.Text = critChanceCost.ToString("F0")
        End If
    End Sub
    Private Sub btnCritMult_Click(sender As Object, e As EventArgs) Handles btnCritMult.Click
        If clicks >= critMultCost Then
            clicks = clicks - critMultCost
            critMult = critMult * CSng(1.5)
            critMultCost = critMultCost * CSng(1.7)
            lblClicks.Text = clicks.ToString("F0")
            lblCritMult.Text = critMult.ToString("F0") & " %"
            lblCritMultCost.Text = critMultCost.ToString("F0")
        End If
    End Sub
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Application.Exit()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnReset.Visible = False
        btnFinish.Visible = False
        popUp = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Visible = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        lblTimer.Text = time & " seconds"
    End Sub
    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If clicks > 1000 And Not autoOn Then
            clicks = clicks - 1000
            autoOn = True
            btnAuto.BackColor = Color.LightCoral
            Timer2.Start()
            Timer2.Interval = autoP * 1000
            btnAutoPCost.BackColor = Color.LightGray
        End If
    End Sub
    Private Sub btnAutoPCost_Click(sender As Object, e As EventArgs) Handles btnAutoPCost.Click
        If autoP > 0.1 And autoPCost < clicks Then
            autoPCost = autoPCost * 1.5
            autoP = autoP - 0.1
            Timer2.Interval = autoP * 1000
            clicks = clicks - autoPCost

            lblAutoP.Text = autoP.ToString("F1") & " seconds"
            lblAutoPCost.Text = autoPCost.ToString("F0")
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        clicks = clicks + bonus
        lblClicks.Text = clicks.ToString("F0")
        If clicks > record Then
            record = CInt(clicks)
            lblRecord.Text = record.ToString()
        End If

    End Sub
End Class
