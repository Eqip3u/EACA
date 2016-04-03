Public Class Form1

    Private Sub buttonGame_Click(sender As Object, e As EventArgs) Handles buttonGame.Click
        Randomize()
        Dim random As Integer = Int((10 * Rnd()) + 1)
        If (random = Val(box.Text)) Then
            MsgBox("Вы выйграли" & vbNewLine & " число которое загадал компьютер = " & random & vbNewLine & " число которое ввели вы = " & Val(box.Text))
        Else
            MsgBox("Вы проиграли" & vbNewLine & " число которое загадал компьютер = " & random & vbNewLine & " число которое ввели вы = " & Val(box.Text))
        End If

    End Sub

    Private Sub replayGame_Click(sender As Object, e As EventArgs) Handles replayGame.Click
        Application.Restart()
    End Sub

    Private Sub exitGame_Click(sender As Object, e As EventArgs) Handles exitGame.Click
        End
    End Sub
End Class
