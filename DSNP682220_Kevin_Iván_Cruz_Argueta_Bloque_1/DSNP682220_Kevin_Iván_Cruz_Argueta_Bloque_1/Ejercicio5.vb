Module Ejercicio5
    Sub tablaMultiplicar()
        Console.Write("Tabla: ")
        Dim i = 0, ntabla As Integer = Console.ReadLine()

        For i = 1 To 12 Step 1
            Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i)
        Next
    End Sub
End Module
