Module Module1

    Sub Main()
        Dim Wordstr1, Vowel As String
        Dim Counter, AmountofVowels As Integer

        Wordstr1 = " "
        Vowel = "AEIOU"
        AmountofVowels = 0
        Counter = 0


        Console.Write("Enter the string that you need to be verifed: ")
        Wordstr1 = Console.ReadLine

        Wordstr1 = UCase(Wordstr1)

        For Counter = 1 To Len(Wordstr1)
            If InStr(Vowel, Mid(Wordstr1, Counter, 1)) > 0 Then
                AmountofVowels = AmountofVowels + 1

            End If

        Next

        Console.Write("THE AMOUNT OF VOWELS IN THE STRING ENTERED: " & AmountofVowels)
        Console.ReadKey()

    End Sub

End Module
