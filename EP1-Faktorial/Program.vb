Imports System

Module Program
    Sub Main(args As String())

        Dim pokracovat As Boolean = True

        While pokracovat
            Dim cislo As Integer
            Dim text As String
            Dim spravnahodnota As Boolean = False


            Do
                Console.write("Zadej celé číslo pro výpočet faktoriálu: ")
                text = console.readline()

                If Integer.Tryparse(text, cislo) AndAlso cislo >= 0 AndAlso cislo <= 10 Then
                    spravnahodnota = True

                ElseIf Integer.TryParse(text, cislo) AndAlso cislo < 0 Then
                    Console.writeline("Záporná čísla nejsou povolena!")
                Else
                    Console.Writeline("Chyba!!! Zadej číslo v rozmezí 0 - 10.")
                End If

            Loop Until spravnahodnota

            Dim vysledekfaktorialu As Integer = ComputeFactorial(cislo)
            Console.WriteLine($"Faktoriál čísla {cislo} je {vysledekfaktorialu}")

            Console.WriteLine("Přejete si provést další výpočet? (ano/ne)")
            Dim pokracovani As String = Console.Readline()

            If pokracovani.ToLower() <> "ano" Then

                pokracovat = False

            End If
        End While

        Console.writeline("Program byl ukončen! Stiskni libovolnou klávesu.")

        Console.ReadKey()
    End Sub


    Function ComputeFactorial(ByVal n As Integer) As Integer
        If n = 0 Then
            Return 1

        Else

            Dim vysledek As Integer = 1
            For x As Integer = 1 To n
                vysledek *= x
            Next

            Return vysledek
        End If
    End Function

End Module
