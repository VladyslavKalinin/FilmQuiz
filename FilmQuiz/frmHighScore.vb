Public Class frmHighScore
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry Your Score Was Not Good Enough"
        Else
            lblMessage.Text = "Congratulations! Your Score Will Be Added To The Hall Of Fame"
            lstHighScore.Items.Add(playerName & vbTab & playerScore)
        End If
    End Sub
End Class