Module Module1
    Function TotalCost(dblPrice As Double) As Double
        Const dblTaxRate = 0.085
        TotalCost = dblPrice + (dblPrice * dblTaxRate)
    End Function

    Function GetSum() As Integer
        Dim intUserData As Integer
        Dim intSum As Integer
        intSum = 0
        Do While intSum <= 25
            intUserData = InputBox("Пожалуйста, введите целое число", "Вход пользователя", 0)
            intSum = intSum + intUserData
        Loop
        GetSum = intSum
        Exit Function
GetSum_ErrorHandler:
        Select Case Err.Number
            Case 13
                MsgBox("Это значение не может быть прибавлено" & "Введите целое цисло", vbExclamation)
                intUserData = 0
                Resume Next
            Case Else
                MsgBox("Произошла ошибка" & Err.Description & vbCrLf & "..работа функций прекращиется", vbCritical)
                Exit Function
        End Select
    End Function

    Sub Test()
        i = GetSum()
        Debug.Print(i)
    End Sub

    Sub GetTotal()
        Dim dblTotal As Double
        dblTotal = TotalCost(10)
        Debug.Print(dblTotal)
    End Sub


    Sub DisplayTotalCost()
        Dim dblTotalCost As Double
        Dim dblPrice As Double
        dblPrice = InputBox("Пожалуйста, введите цену")
        dblTotalCost = TotalCost(dblPrice)
        If dblTotalCost < 50 Then
            MsgBox("Стоймость" & Str(dblTotalCost) & vbCrLf & "Это меньше допустимой", vbCritical)
        Else
            MsgBox("Стоймость" & Str(dblTotalCost) & vbCrLf & "Такая стоймость допускается", vbExclamation)
        End If
    End Sub
End Module