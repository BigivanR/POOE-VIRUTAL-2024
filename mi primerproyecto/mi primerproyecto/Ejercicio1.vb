﻿Module Ejericio1

    Sub Main()
        Console.WriteLine("Num 1: ")
        Dim num1 As Double
        num1 = Double.Parse(Console.ReadLine())

        Console.WriteLine("Num 2: ")
        Dim num2 As Double
        num2 = Double.Parse(Console.ReadLine())

        Dim suma As Double
        suma = num1 + num2

        Console.WriteLine("La suma es: {0}", suma)

        Console.ReadKey() 'pausa.

    End Sub

End Module
