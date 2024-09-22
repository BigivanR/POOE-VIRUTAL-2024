Imports System.Globalization
Imports System.Runtime.InteropServices

Module Ejercicio2
    Sub main()
        'Determinar si el número es positivo o negativo.
        Dim num1 As String

        Console.Write("Introduce un número: ")
        num1 = Console.ReadLine()

        If (num1 >= 1) Then

            Console.WriteLine("El número es positivo.")

        ElseIf (num1 <= -1) Then

            Console.WriteLine("El número es negativo.")

        ElseIf (num1 = 0) Then

            Console.WriteLine("El número es neutro.")

        Else

            Console.WriteLine("Por favor, introduce un número válido.")

        End If

        Console.ReadKey() ' pause

    End Sub

End Module
