Imports System

Module Program
    Sub Main(args As String())

        Dim cislo As Integer = Integer.Parse(Console.ReadLine())
        Dim vysledek As Integer = 1

        Console.write("Zadej celé číslo pro výpočet faktoriálu: ")

        For x As Integer = 1 To cislo
            vysledek *= x
        Next


    End Sub
End Module
