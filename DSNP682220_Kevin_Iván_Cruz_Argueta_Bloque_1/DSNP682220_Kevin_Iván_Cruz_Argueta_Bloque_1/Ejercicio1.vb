Imports System.ComponentModel.Design

Module Module1
    Sub Main()
        Dim continuar As String = "s"
        While continuar = "s"
            Console.WriteLine("::.. MENU ..::")
            Console.WriteLine("1. Determinar si es mayor o menor de edad.")
            Console.WriteLine("2. Determinar si el número es positivo o negativo.")
            Console.WriteLine("3. Descuento en compras.")
            Console.WriteLine("4. Suma números enteros.")
            Console.WriteLine("5. Tabla de wmultiplicar.")
            Console.WriteLine("6. Salir.")
            Console.Write("Opcion: ")
            Dim opcion As Integer = Console.ReadLine()
            Console.Clear()
            Select Case opcion
                Case 1
                    edad()
                Case 2
                    numeropon()
                Case 3
                    descuento()
                Case 4
                    Suma()
                Case 5
                    tablaMultiplicar()

                Case Else
                    continuar = "n"
            End Select
        End While
    End Sub
    Sub edad()
        'Ejercicio 1 solicitar la edad de una persona y determinar si es menor o mayor de edad, deberá mostrar un mensaje.
        Dim Edad, mayor, menor As Integer

        mayor = 18
        menor = 17

        Console.WriteLine("Ingrese su edad: ")
        Edad = Console.ReadLine()

        If Edad >= mayor Then
            Console.WriteLine("Es mayor de edad")
        End If
        If Edad <= menor Then
            Console.WriteLine("Es menor de edad")
        End If

        Console.ReadKey() ' pause
    End Sub

End Module
