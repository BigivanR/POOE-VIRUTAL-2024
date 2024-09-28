Module Module2
    Sub longitud()
        Dim cantidad, origen, destino As Integer
        Dim resultado As Double
        Console.WriteLine("Conversor de Unidades de Longitud ")
        Console.WriteLine("Elige la unidad de origen: ")
        Console.WriteLine("1. Metros")
        Console.WriteLine("2. Kilómetros")
        Console.WriteLine("3. Millas")
        Console.WriteLine("4. Pies")
        Console.Write("Selecciona una opción (1-4): ")
        origen = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa la cantidad a convertir: ")
        cantidad = Double.Parse(Console.ReadLine())

        Console.WriteLine("Elige la unidad de destino: ")
        Console.WriteLine("1. Metros")
        Console.WriteLine("2. Kilómetros")
        Console.WriteLine("3. Millas")
        Console.WriteLine("4. Pies")
        Console.Write("Selecciona una opción (1-4): ")
        destino = Integer.Parse(Console.ReadLine())

        Select Case origen
            Case 1 ' Metros
                Select Case destino
                    Case 1 ' Metros
                        resultado = cantidad
                    Case 2 ' Kilómetros
                        resultado = cantidad / 1000
                    Case 3 ' Millas
                        resultado = cantidad / 1609.34
                    Case 4 ' Pies
                        resultado = cantidad / 0.3048
                    Case Else
                        Throw New ArgumentException("Opción de destino no válida.")
                End Select
            Case 2 ' Kilómetros
                Select Case destino
                    Case 1 ' Metros
                        resultado = cantidad * 1000
                    Case 2 ' Kilómetros
                        resultado = cantidad
                    Case 3 ' Millas
                        resultado = cantidad / 1.60934
                    Case 4 ' Pies
                        resultado = cantidad * 3280.84
                    Case Else
                        Throw New ArgumentException("Opción de destino no válida.")
                End Select
            Case 3 ' Millas
                Select Case destino
                    Case 1 ' Metros
                        resultado = cantidad * 1609.34
                    Case 2 ' Kilómetros
                        resultado = cantidad * 1.60934
                    Case 3 ' Millas
                        resultado = cantidad
                    Case 4 ' Pies
                        resultado = cantidad * 5280
                    Case Else
                        Throw New ArgumentException("Opción de destino no válida.")
                End Select
            Case 4 ' Pies
                Select Case destino
                    Case 1 ' Metros
                        resultado = cantidad * 0.3048
                    Case 2 ' Kilómetros
                        resultado = cantidad / 3280.84
                    Case 3 ' Millas
                        resultado = cantidad / 5280
                    Case 4 ' Pies
                        resultado = cantidad
                    Case Else
                        Throw New ArgumentException("Opción de destino no válida.")
                End Select
            Case Else
                Throw New ArgumentException("Opción de origen no válida.")
        End Select

        Console.WriteLine($"Resultado: {resultado}")
    End Sub
End Module
