﻿Public Class frmMain
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtName.Text
        frmQuestion1.Show()

        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
