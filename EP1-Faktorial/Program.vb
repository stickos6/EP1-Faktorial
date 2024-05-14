Imports System

Module Program
    Sub Main(args As String())

        Dim cislo As Integer
        Dim vysledek As Integer = 1

        Do
            Console.write("Zadej celé číslo pro výpočet faktoriálu: ")
        Loop Until Integer.TryParse(Console.readline(), cislo)


        For x As Integer = 1 To cislo
                vysledek *= x
            Next

            Console.writeline($"Faktoriál čísla {cislo} je {vysledek}")

        Console.ReadKey()
    End Sub
End Module
