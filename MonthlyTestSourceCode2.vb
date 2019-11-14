Module Module1

    Sub Main()
        Dim WordStr1, NextAlpha, MostRepeatedAlpha, RepairStr As String
        Dim Counter, PreviousMentionedAlpha, PresentAlpha As Integer

        WordStr1 = " "
        NextAlpha = " "
        MostRepeatedAlpha = " "
        RepairStr = " "
        Counter = 0
        PresentAlpha = 0
        PreviousMentionedAlpha = 1

        Console.Write("Enter the string that you need to be evaluated: ")
        WordStr1 = Console.ReadLine

        WordStr1 = UCase(WordStr1)

        For Counter = 1 To Len(WordStr1)
            NextAlpha = Mid(WordStr1, Counter, 1)
            If NextAlpha = " " Then
                NextAlpha = " "
            End If
            RepairStr = RepairStr & NextAlpha
        Next
        WordStr1 = RepairStr

        If WordStr1 <> " " Then
            For Counter = 1 To Len(WordStr1)
                NextAlpha = Mid(WordStr1, Counter, 1)
                Do While InStr(WordStr1, NextAlpha)
                    PresentAlpha = PresentAlpha + 1
                    WordStr1 = Left(WordStr1, InStr(WordStr1, NextAlpha) - 1) & Right(WordStr1, Len(WordStr1) - InStr(WordStr1, NextAlpha))
                Loop

                If PresentAlpha > PreviousMentionedAlpha Then
                    MostRepeatedAlpha = NextAlpha
                End If
                PreviousMentionedAlpha = PresentAlpha
                PresentAlpha = 0
            Next
        End If

        If MostRepeatedAlpha <> " " Then
            Console.WriteLine("Most repeated alphabet: " & MostRepeatedAlpha)
        End If

        Console.ReadKey()
    End Sub

End Module
