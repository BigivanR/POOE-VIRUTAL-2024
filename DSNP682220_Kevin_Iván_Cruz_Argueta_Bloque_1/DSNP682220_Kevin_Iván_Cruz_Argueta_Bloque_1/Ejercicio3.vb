Module Ejercicio3

    Sub descuento()

        'Programa que de acuerdo con un monto de compra muestre el descuento aplicado y total a pagar.

        Console.Write("Ingrese el monto de compra: ")

        Dim monto As Decimal = Console.ReadLine()
        Dim descuento As Decimal = 0.0
        Dim total As Decimal

        If (monto >= 1000) Then

            descuento = 0.3 ' 30% de descuento para compras de 1000 o más

            descuento = monto * descuento
            total = monto - descuento

            Console.WriteLine($"Descuento aplicado: {descuento:C}")

            Console.WriteLine($"Total a pagar: {total:C}")

            Console.WriteLine("Presione cualquier tecla para continuar...")

        ElseIf (monto >= 500 AndAlso monto <= 999) Then

            descuento = 0.2 ' 20% de descuento para compras de 500 o más

            descuento = monto * descuento
            total = monto - descuento

            Console.WriteLine($"Descuento aplicado: {descuento:C}")

            Console.WriteLine($"Total a pagar: {total:C}")

            Console.WriteLine("Presione cualquier tecla para continuar...")

        ElseIf (monto >= 250 AndAlso monto <= 499) Then

            descuento = 0.1 ' 10% de descuento para compras de 500 o más

            descuento = monto * descuento
            total = monto - descuento

            Console.WriteLine($"Descuento aplicado: {descuento:C}")

            Console.WriteLine($"Total a pagar: {total:C}")

            Console.WriteLine("Presione cualquier tecla para continuar...")

        ElseIf (monto <= 249) Then

            descuento = 0.05 ' 5% de descuento para compras de 100 o más

            descuento = monto * descuento
            total = monto - descuento

            Console.WriteLine($"Descuento aplicado: {descuento:C}")

            Console.WriteLine($"Total a pagar: {total:C}")

            Console.WriteLine("Presione cualquier tecla para continuar...")

        End If

        Console.ReadKey()

    End Sub

End Module
