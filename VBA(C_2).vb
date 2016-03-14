    Sub Main()
        Dim M As Integer, N As Integer
        M = Val(InputBox("Введите первое число"))
        N = Val(InputBox("Введите второе число"))
        Do While M <> N
            If M > N Then
                M = M - N
            Else
                N = N - M
            End If
        Loop
        MsgBox("НОД =" & M)
    End Sub
