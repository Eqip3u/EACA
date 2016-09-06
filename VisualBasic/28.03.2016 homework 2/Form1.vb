Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RightBox.Text = "" Or LeftBox.Text = "") Then ' Если боксы пусты, то суммируется лист
            MsgBox("Сумма чисел (лист) = " & (Val(LeftList.Text) + Val(RightList.Text)))
        Else
            MsgBox("Сумма чисел = " & Fix(Val(RightBox.Text)) + Fix(Val(LeftBox.Text))) ' Отбрасывает часть после запятой и суммируем числа правого и левого бокса
        End If
    End Sub

    Private Sub LeftBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LeftBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True 'блокировка клавиатуры для левого бокса
    End Sub

    Private Sub RightBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RightBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True 'блокировка клавиатуры для правого бокса
    End Sub
End Class

