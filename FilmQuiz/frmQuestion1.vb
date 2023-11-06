Public Class frmQuestion1
    Private Sub tbnNext_Click(sender As Object, e As EventArgs) Handles tbnNext.Click
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If

        frmQuestion2.Show()


        Me.Hide()
    End Sub
End Class