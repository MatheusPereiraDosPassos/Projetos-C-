Module Module1

    Sub Main()
        Dim c As libUtil.Calc
        c = New libUtil.Calc()

        System.Console.WriteLine(c.Somar(45, 10))
        System.Console.WriteLine(c.Subtrair(20, 10))
        System.Console.WriteLine(c.Multiplicar(8, 10))
        System.Console.WriteLine(c.Dividir(60, 50))

        System.Console.ReadKey()


    End Sub

End Module
