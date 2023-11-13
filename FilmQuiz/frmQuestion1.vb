Public Class frmQuestion1
    Private Sub tbnNext_Click(sender As Object, e As EventArgs) Handles tbnNext.Click

        tmrQ1.Enabled = False
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If
        frmMain.stopTrack()
        frmQuestion2.Show()
        frmQuestion2.init()
        Me.Hide()

    End Sub
    Public Sub init()

        progressCount = 0
        tmrQ1.Enabled = True
        barQ1.Value = 0

        frmMain.playTrack("C:\Users\11161870\Source\Repos\VladyslavKalinin\FilmQuiz\FilmQuiz\questionMusic.mp3")

        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False



    End Sub

    Private Sub tmrQ1_Tick(sender As Object, e As EventArgs) Handles tmrQ1.Tick
        progressCount = progressCount + 1

        barQ1.PerformStep()
        If progressCount = 10 Then
            tmrQ1.Enabled = False
            MsgBox("Too Slow Try Again")
            frmMain.stopTrack()
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()

        End If
    End Sub

End Class