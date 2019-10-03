Module Module1

    Sub Main()
        Dim WORDSTR1, WORDSTR2, CH1, NEXTCHAR As String
        Dim COUNT As Integer

        WORDSTR1 = " "
        WORDSTR2 = " "
        CH1 = " "
        NEXTCHAR = " "
        COUNT = 0

        Console.Write("Enter String")
        WORDSTR1 = Console.ReadLine

        Console.Write("Enter character to eliminate: ")
        CH1 = Console.ReadLine

        For COUNT = 1 To Len(WORDSTR1)
            NEXTCHAR = Mid(WORDSTR1, COUNT, 1)
            If NEXTCHAR <> CH1 Then
                WORDSTR2 = WORDSTR2 & NEXTCHAR
            End If
        Next

        Console.WriteLine("Final String = " & WORDSTR2)
        Console.ReadKey()

    End Sub

End Module
