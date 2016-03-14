    Sub Main()
        Dim a, b, c, x1, x2, D
        a = Val(InputBox("Введите коэффициет a"))
        b = Val(InputBox("Введите средний коэффициент b"))
        c = Val(InputBox("Введите свободный член с"))
        D = b ^ 2 - 4 * a * c
        If (D >= 0) Then
            x1 = (-b + Sqr(D)) / (2 * a)
            x2 = (-b - Sqr(D)) / (2 * a)
            MsgBox("x1=" & x1)
            MsgBox("x2=" & x2)
        Else
            MsgBox("Действительных корней не существует")
        End If
    End Sub
