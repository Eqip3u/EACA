﻿Module Module1
    Sub ageRequest()
        Dim vInput
        vInput = InputBox("Введите свой возраст") 'запрос
        vInput = Val(vInput) 'Превращение строки в число
        If (vInput > 0 And vInput < 6) Then
            MsgBox("Дошкольник")
        ElseIf (vInput >= 6 And vInput < 18) Then
            MsgBox("Школьник")
        ElseIf (vInput >= 18 And vInput < 24) Then
            MsgBox("Студент")
        ElseIf (vInput >= 24 And vInput < 65) Then
            MsgBox("Работающий")
        ElseIf (vInput >= 65 And vInput < 110) Then
            MsgBox("Пенсионер")
        ElseIf (vInput = 0 Or vInput >= 110) Then ' Проверка верности вводимого значения
            MsgBox("Введите настоящий возраст")
        End If
    End Sub
End Module