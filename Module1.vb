Module Module1

    Sub Main()
        Dim WordString1, WordString2, WordString3, FirstWord, LastWord As String
        Dim Xb As Integer

        WordString1 = " "
        WordString2 = " "
        WordString3 = " "
        FirstWord = " "
        LastWord = " "
        Xb = 0

        Console.Write("Enter 1st string of 2 words: ")
        WordString1 = Console.ReadLine

        Console.Write("Enter 2nd string of 2 words: ")
        WordString2 = Console.ReadLine

        Xb = InStr(WordString1, " ")
        FirstWord = Left(WordString1, Xb - 1)

        Xb = InStr(WordString2, " ")
        LastWord = Right(WordString2, Len(WordString2) - Xb)

        WordString3 = FirstWord & " " & LastWord
        Console.WriteLine(WordString3)

        Console.ReadKey()



    End Sub

End Module
