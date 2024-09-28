Module Menu
    Sub Main()
        Dim continuar As String = "s"
        While continuar = "s"
            Console.WriteLine("::.. MENU ..::")
            Console.WriteLine("1. Conversor de medida de longitud.")
            Console.WriteLine("2. Conversor de medida de de masa.")
            Console.WriteLine("3. conversor de medida de tiempo.")
            Console.WriteLine("4. conversor de medida de almacenamiento.")
            Console.WriteLine("6. Salir.")
            Console.Write("Opcion: ")
            Dim opcion As Integer = Console.ReadLine()
            Console.Clear()
            Select Case opcion
                Case 1
                    longitud()
                Case Else
                    continuar = "n"
            End Select
        End While
    End Sub

End Module
