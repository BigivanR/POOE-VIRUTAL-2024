Module Ejercicio4

    Sub Suma()
        Console.Write("Maximo a mostrar: ")
        Dim n As Integer = Console.ReadLine()
        Dim a = 1, b = 0, c As Integer = 1

        While c <= n
            c = a + b
            b = a
            a = c
            Console.WriteLine("{0}", c)
            Console.WriteLine("{0}+{1}=", a, b)

        End While
    End Sub

End Module
