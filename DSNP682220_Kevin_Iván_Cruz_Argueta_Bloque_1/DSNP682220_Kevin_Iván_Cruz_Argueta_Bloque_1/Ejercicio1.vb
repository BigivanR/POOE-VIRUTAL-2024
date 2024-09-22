Module Module1
    Sub Main()
        'Ejercicio 1 solicitar la edad de una persona y determinar si es menor o mayor de edad, deberá mostrar un mensaje.
        Dim Edad As Integer
        Dim mayor, menor As Integer
        mayor = 18
        menor = 17

        Console.WriteLine("Ingrese su edad: ")
        Edad = Console.ReadLine()

        If Edad >= mayor Then Console.WriteLine("Es mayor de edad")
        If Edad <= menor Then Console.WriteLine("Es menor de edad")

        Console.ReadKey() ' pause

    End Sub

End Module
