Public Class frmQuestion2
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        tmrQ2.Enabled = False
        If btnAnswer4.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()
        frmQuestion3.init()
        Me.Hide()

    End Sub
    Public Sub init()

        progressCount = 0
        tmrQ2.Enabled = True
        barQ2.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub

    Private Sub tmrQ2_Tick(sender As Object, e As EventArgs) Handles tmrQ2.Tick
        progressCount = progressCount + 1

        barQ2.PerformStep()
        If progressCount = 10 Then
            tmrQ2.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion3.Show()
            frmQuestion3.init()
            Me.Hide()

        End If
    End Sub
End Class