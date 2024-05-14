Imports System

Module Program
    Sub Main(args As String())

        Dim cislo As Integer
        Dim vysledek As Integer = 1
        Dim text As String
        Dim spravnahodnota As Boolean = False

        Do
            Console.write("Zadej celé číslo pro výpočet faktoriálu: ")
            text = console.readline()

            If Integer.Tryparse(text, cislo) AndAlso cislo >= 0 AndAlso cislo <= 10 Then
                spravnahodnota = True

            Else
                Console.Writeline("Chyba!!! Zadej číslo v rozmezí 0 - 10.")
            End If

        Loop Until spravnahodnota

        If cislo > 0 Then
            For x As Integer = 1 To cislo
                vysledek *= x
            Next
        End If


        Console.writeline($"Faktoriál čísla {cislo} je {vysledek}")



        Console.ReadKey()
    End Sub
End Module
