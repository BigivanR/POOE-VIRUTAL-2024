Module Module1
    Sub masa()
        Dim cantidad, origen, destino As Integer
        Dim resultado As Double

        Console.WriteLine("Conversor de Masa")
        Console.WriteLine("Elige la unidad a convertir:")
        Console.WriteLine("1. Kilogramos")
        Console.WriteLine("2. Gramos")
        Console.WriteLine("3. Libras")
        Console.WriteLine("4. Onzas")
        Console.Write("Selecciona una opción (1-4): ")
        Try
            origen = Integer.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Error: Opción de origen no válida.")
            Return
        End Try

        Console.Write("Ingresa la cantidad a convertir: ")
        Try
            cantidad = Double.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Error: Cantidad no válida.")
            Return
        End Try

        Console.WriteLine("Elige la unidad de destino:")
        Console.WriteLine("1. Kilogramos")
        Console.WriteLine("2. Gramos")
        Console.WriteLine("3. Libras")
        Console.WriteLine("4. Onzas")
        Console.Write("Selecciona una opción (1-4): ")
        Try
            destino = Integer.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Error: Opción de destino no válida.")
            Return
        End Try

        resultado = Convertir(cantidad, origen, destino)
        Console.WriteLine($"Resultado: {resultado}")
    End Sub

    Function Convertir(cantidad As Double, origen As Integer, destino As Integer) As Double
        'Conversión a kilogramos como base
        Dim Kilogramos As Double = cantidad

        Select Case origen
            Case 1  'Kilogramos
                Kilogramos = cantidad
            Case 2  'Gramos
                Kilogramos = cantidad / 1000
            Case 3  'Libras
                Kilogramos = cantidad * 0.453592
            Case 4  'Onzas
                Kilogramos = cantidad * 0.0283495
            Case Else
                Throw New ArgumentException("Opción de origen no válida.")
        End Select

        'Convertir de kilogramos a la unidad de destino
        Select Case destino
            Case 1   'Kilogramos
                Return Kilogramos
            Case 2   'Gramos
                Return Kilogramos * 1000
            Case 3   'Libras
                Return Kilogramos / 0.453592
            Case 4    'Onzas
                Return Kilogramos / 0.0283495
            Case Else
                Throw New ArgumentException("Opción de destino no válida.")
        End Select
    End Function

End Module
