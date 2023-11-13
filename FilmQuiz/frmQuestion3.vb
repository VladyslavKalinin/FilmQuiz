Public Class frmQuestion3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrQ3.Enabled = False
        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If
        frmMain.stopTrack()
        frmHighScore.Show()
        frmHighScore.doScore()
        Me.Hide()

    End Sub

    Public Sub init()

        progressCount = 0
        tmrQ3.Enabled = True
        barQ3.Value = 0

        frmMain.playTrack("C:\Users\11161870\Source\Repos\VladyslavKalinin\FilmQuiz\FilmQuiz\questionMusic.mp3")

        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer3.Checked = False



    End Sub

    Private Sub tmrQ3_Tick(sender As Object, e As EventArgs) Handles tmrQ3.Tick
        progressCount += 1

        barQ3.PerformStep()

        If progressCount = 10 Then
            tmrQ3.Enabled = False
            MsgBox("Too Slow Try Again")
            frmMain.stopTrack()
            frmHighScore.Show()
            frmHighScore.doScore()
            Me.Hide()
        End If
    End Sub










End Class