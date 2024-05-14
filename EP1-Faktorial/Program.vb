Imports System

Module Program
    Sub Main(args As String())

        Console.write("Zadej celé číslo pro výpočet faktoriálu: ")

        Dim cislo As Integer = Integer.Parse(Console.ReadLine())
        Dim vysledek As Integer = 1


        For x As Integer = 1 To cislo
            vysledek *= x
        Next

        Console.writeline($"Faktoriál čísla {cislo} je {vysledek}")

        Console.ReadKey()
    End Sub
End Module
